using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Gerais
{
    public class Condicao_pagamentoModel
    {
        [ParameterOrder(Order = 1)]
        public int? idCondicaoPagamento { get; set; }
        [ParameterOrder(Order = 2)]
        public string xCondicaoPagamento { get; set; }
        [ParameterOrder(Order = 3)]
        public string xDescricao { get; set; }
        [ParameterOrder(Order = 4)]
        public byte stMetodo { get; set; }
        [ParameterOrder(Order = 5)]
        public int? nMeses { get; set; }
        [ParameterOrder(Order = 6)]
        public int? nSemanas { get; set; }
        [ParameterOrder(Order = 7)]
        public int? nDias { get; set; }
        [ParameterOrder(Order = 8)]
        public int? idPlanoPagamento { get; set; }
        [ParameterOrder(Order = 9)]
        public int? idDiaPagamento { get; set; }
        [ParameterOrder(Order = 10)]
        public byte? stDataVencimento { get; set; }
        [ParameterOrder(Order = 11)]
        public byte stCondicao { get; set; }



    }
}
