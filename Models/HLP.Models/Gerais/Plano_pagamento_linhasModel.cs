using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Gerais
{
    public class Plano_pagamento_linhasModel : BaseModelFilhos
    {
        private int? _idLinhasPagamento;
        [ParameterOrder(Order = 1)]
        public int? idLinhasPagamento
        {
            get { return _idLinhasPagamento; }
            set
            {
                _idLinhasPagamento = value;
                base.SetID(value);
            }
        }
        [ParameterOrder(Order = 2)]
        public decimal? nQuantidade { get; set; }
        [ParameterOrder(Order = 3)]
        public decimal? nValorouPorcentagem { get; set; }
        [ParameterOrder(Order = 4)]
        public byte? stValorouPorcentagem { get; set; }
        [ParameterOrder(Order = 5)]
        public int idPlanoPagamento { get; set; }

    }
}
