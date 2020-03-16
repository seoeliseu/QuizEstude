using System;
using System.Collections.Generic;

namespace Quiz.Domain
{
    public class QuestionarioResposta
    {
        public Guid Id { get; set; }
        public Questionario Questionario { get; set; }
        public List<Resposta> Respostas { get; set; }

        public QuestionarioResposta(Questionario questionario)
        {
            Respostas = new List<Resposta>();
            Questionario = questionario;
        }

        public QuestionarioResposta AddResposta(Guid perguntaId, Guid opcaoRespostaId)
        {
            Respostas.Add(new Resposta(Questionario.GetPergunta(perguntaId)
                , Questionario.GetPergunta(perguntaId).GetOpcaoResposta(opcaoRespostaId)));
            return this;
        }

        public override string ToString()
        {
            var retorno = "Resposta Questionário: " + Questionario.Nome + "\n";

            foreach (var resposta in Respostas)
            {
                retorno += resposta.Pergunta.Descricao + "\n" + 
                           "Resposta: " + resposta.OpcaoResposta.Descricao;
                retorno += " - " + (resposta.OpcaoResposta.Correta == true ? "Correta" : "Errado");
            }

            return retorno;
        }
    }
}
