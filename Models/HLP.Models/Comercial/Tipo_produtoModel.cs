using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Comercial
{
    public class Tipo_produtoModel
    {
        [ParameterOrder(Order = 1)]
        public int? idTipoProduto { get; set; }
        [ParameterOrder(Order = 2)]
        public string xTipo { get; set; }
        [ParameterOrder(Order = 3)]
        public string xDescricao { get; set; }
        [ParameterOrder(Order = 4)]
        public byte stPatrimonio { get; set; }
        [ParameterOrder(Order = 5)]
        public byte stProducao { get; set; }
        [ParameterOrder(Order = 6)]
        public byte stEstoque { get; set; }
        [ParameterOrder(Order = 7)]
        public byte stCompras { get; set; }
        [ParameterOrder(Order = 8)]
        public byte stComercial { get; set; }
        [ParameterOrder(Order = 9)]
        public byte stTerceiros { get; set; }
        [ParameterOrder(Order = 10)]
        public byte stServicos { get; set; }

    }
}
