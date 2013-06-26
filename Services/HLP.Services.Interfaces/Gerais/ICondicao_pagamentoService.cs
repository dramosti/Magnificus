using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;

namespace HLP.Services.Interfaces.Entries.Gerais
{
    public interface ICondicao_pagamentoService
    {
        Condicao_pagamentoModel GetCondicao(int idCondicaoPagamento);
        void Save(Condicao_pagamentoModel condicao);
        void Delete(int idCondicaoPagamento);
        int Copy(int idCondicaoPagamento);
    }
}
