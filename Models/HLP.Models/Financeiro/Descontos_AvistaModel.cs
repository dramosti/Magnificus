using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Financeiro
{
    public class Descontos_AvistaModel
    {
        [ParameterOrder(Order = 1)]
        public int? idDescontosAvista { get; set; }
        [ParameterOrder(Order = 2)]
        public string xDescontos { get; set; }
        [ParameterOrder(Order = 3)]
        public string xDescricao { get; set; }
        [ParameterOrder(Order = 4)]
        public int? idProximoDesconto { get; set; }
        [ParameterOrder(Order = 5)]
        public byte stLiquidoAtual { get; set; }
        [ParameterOrder(Order = 6)]
        public int? nMeses { get; set; }
        [ParameterOrder(Order = 7)]
        public int? nDias { get; set; }
        [ParameterOrder(Order = 8)]
        public decimal? pDesconto { get; set; }

    }
}
