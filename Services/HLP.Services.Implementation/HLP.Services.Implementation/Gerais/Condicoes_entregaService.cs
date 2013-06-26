using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Gerais;
using HLP.Models.Entries.Gerais;
using Ninject;
using HLP.Repository.Interfaces.Entries.Gerais;

namespace HLP.Services.Implementation.Entries.Gerais
{
    public class Condicoes_entregaService : ICondicoes_entregaService
    {
        [Inject]
        public ICondicoes_entregaRepository condicaoRepository { get; set; }

        public Condicoes_entregaModel GetCondicao(int idCondicaoEntrega)
        {
            return condicaoRepository.GetCondicao(idCondicaoEntrega);
        }

        public void Save(Condicoes_entregaModel condicao)
        {
            condicaoRepository.Save(condicao);
        }

        public void Delete(int idCondicaoEntrega)
        {
            condicaoRepository.Delete(idCondicaoEntrega);
        }


        public int Copy(int idCondicaoEntrega)
        {
            return condicaoRepository.Copy(idCondicaoEntrega);
        }
    }
}
