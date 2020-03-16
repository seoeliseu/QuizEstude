using System;
using System.Collections.Generic;

namespace Quiz.Domain
{
    public class Questionario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public List<Pergunta> Perguntas { get; set; }

        public Questionario (Guid id,string nome)
        {
            Id = id;
            Nome = nome;
            Perguntas = new List<Pergunta>();
        }

        public void AddPergunta(Guid id ,string pergunta)
        {
            Perguntas.Add(new Pergunta(id, pergunta));
        }

        public Pergunta GetPergunta(Guid id)
        {
            return Perguntas.Find(p => p.Id == id);
        }

        public override string ToString()
        {
            var retorno = "Nome: " + Nome + "\n" +
                          "Perguntas\n";
            foreach (var pergunta in Perguntas)
            {
                retorno += pergunta.Descricao + "\n";
            }
            return retorno;
        }
    }
}
