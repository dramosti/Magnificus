using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Gerais
{
    public class Plano_pagamentoModel
    {
        [ParameterOrder(Order = 1)]
        public int? idPlanoPagamento { get; set; }
        [ParameterOrder(Order = 2)]
        public string xPlanoPagamento { get; set; }
        [ParameterOrder(Order = 3)]
        public string xDescricao { get; set; }
        [ParameterOrder(Order = 4)]
        public byte stAlocacao { get; set; }
        [ParameterOrder(Order = 5)]
        public byte stFormaPagamento { get; set; }
        [ParameterOrder(Order = 6)]
        public int nAlterar { get; set; }
        [ParameterOrder(Order = 7)]
        public int nNumerosPagamentos { get; set; }
        [ParameterOrder(Order = 8)]
        public decimal nValorMoeda { get; set; }
        [ParameterOrder(Order = 9)]
        public decimal nValorMinimo { get; set; }
        [ParameterOrder(Order = 10)]
        public byte stAlocacaoImpostos { get; set; }
        [ParameterOrder(Order = 11)]
        public string xNota { get; set; }

        public List<Plano_pagamento_linhasModel> lPlano_pagamento_linhas = new List<Plano_pagamento_linhasModel>();
    }
}
