using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Financeiro
{
    public class Dia_pagamentoModel
    {
        [ParameterOrder(Order = 1)]
        public int? idDiaPagamento { get; set; }
        [ParameterOrder(Order = 2)]
        public string xDiaPagamento { get; set; }
        [ParameterOrder(Order = 3)]
        public string xDescricao { get; set; }

        public List<Dia_pagamento_linhasModel> lDia_pagamento_linhas = new List<Dia_pagamento_linhasModel>();
    }


    public class Dia_pagamento_linhasModel : BaseModelFilhos
    {

        private int? _idDiaPagamentoLinhas;
        [ParameterOrder(Order = 1)]
        public int? idDiaPagamentoLinhas
        {
            get { return _idDiaPagamentoLinhas; }
            set
            {
                _idDiaPagamentoLinhas = value;
                base.SetID(value);
            }
        }
        [ParameterOrder(Order = 2)]
        public byte? stSemanaMes { get; set; }
        [ParameterOrder(Order = 3)]
        public byte? stDiaUtil { get; set; }
        [ParameterOrder(Order = 4)]
        public int? nDia { get; set; }
        [ParameterOrder(Order = 5)]
        public int idDiaPagamento { get; set; }

    }


}
