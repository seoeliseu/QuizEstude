using System;

namespace Quiz.Domain
{
    public class OpcaoResposta
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public bool Correta { get; set; }
        public OpcaoResposta(Guid id, string descricao, bool correta)
        {
            Id = id;
            Descricao = descricao;
            Correta = correta;
        }
    }
}
