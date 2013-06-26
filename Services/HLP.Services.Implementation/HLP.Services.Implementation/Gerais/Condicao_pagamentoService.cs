using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Gerais;
using HLP.Repository.Interfaces.Entries.Gerais;
using Ninject;
using HLP.Models.Entries.Gerais;

namespace HLP.Services.Implementation.Entries.Gerais
{
    public class Condicao_pagamentoService : ICondicao_pagamentoService
    {
        [Inject]
        public ICondicao_pagamentoRepository condicaoRepository { get; set; }

        public Condicao_pagamentoModel GetCondicao(int idCondicaoPagamento)
        {
            return condicaoRepository.GetCondicao(idCondicaoPagamento);
        }

        public void Save(Condicao_pagamentoModel condicao)
        {
            condicaoRepository.Save(condicao);
        }

        public void Delete(int idCondicaoPagamento)
        {
            condicaoRepository.Delete(idCondicaoPagamento);
        }


        public int Copy(int idCondicaoPagamento)
        {
            return condicaoRepository.Copy(idCondicaoPagamento);
        }
    }
}
