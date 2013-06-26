using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Gerais
{
    public class Modos_entregaModel
    {
        [ParameterOrder(Order = 1)]
        public int? idModosEntrega { get; set; }
        [ParameterOrder(Order = 2)]
        public string xModosEntrega { get; set; }
        [ParameterOrder(Order = 3)]
        public string xDescricao { get; set; }
        [ParameterOrder(Order = 4)]
        public byte stServico { get; set; }
        [ParameterOrder(Order = 5)]
        public int? idTransportador { get; set; }

    }
}
