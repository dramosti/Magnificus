using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Comercial
{
    public class JurosModel
    {

        [ParameterOrder(Order = 1)]
        public int? idJuros { get; set; }
        [ParameterOrder(Order = 2)]
        public string xDescricao { get; set; }
        [ParameterOrder(Order = 3)]
        public decimal pJuros { get; set; }
        [ParameterOrder(Order = 4)]
        public int nQuantidadeDiasMes { get; set; }
        [ParameterOrder(Order = 5)]
        public byte stDiaMes { get; set; }
        [ParameterOrder(Order = 6)]
        public int nCarencia { get; set; }
        [ParameterOrder(Order = 7)]
        public string xNome { get; set; }


    }
}
