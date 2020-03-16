using System;

namespace Quiz.Domain
{
    public class Resposta
    {
        public Guid Id { get; set; }
        public Pergunta Pergunta { get; set; }
        public OpcaoResposta OpcaoResposta { get; set; }

        public Resposta(Pergunta pergunta, OpcaoResposta opcaoResposta)
        {
            Id = Guid.NewGuid();
            Pergunta = pergunta;
            OpcaoResposta = opcaoResposta;
        }
    }
}
