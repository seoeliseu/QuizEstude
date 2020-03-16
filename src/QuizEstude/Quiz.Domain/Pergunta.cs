using System;
using System.Collections.Generic;

namespace Quiz.Domain
{
    public class Pergunta
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public List<OpcaoResposta> OpcaoRespostas { get; set; }
        public Pergunta(Guid id, string descricao)
        {
            Id = id;
            Descricao = descricao;
            OpcaoRespostas = new List<OpcaoResposta>();
        }

        public Pergunta AddOpcaoResposta(Guid id,string resposta, bool correta)
        {
            OpcaoRespostas.Add(new OpcaoResposta(id,resposta, correta));
            return this;
        }

        public OpcaoResposta GetOpcaoResposta(Guid id)
        {
            return OpcaoRespostas.Find(or => or.Id == id);
        }
    }
}