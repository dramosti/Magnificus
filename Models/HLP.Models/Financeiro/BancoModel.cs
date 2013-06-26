using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Financeiro
{
    public class BancoModel
    {
        [ParameterOrder(Order = 1)]
        public int? idBanco { get; set; }
        [ParameterOrder(Order = 2)]
        public string cBanco { get; set; }
        [ParameterOrder(Order = 3)]
        public string xBancoResumido { get; set; }
        [ParameterOrder(Order = 4)]
        public string xBanco { get; set; }
        [ParameterOrder(Order = 5)]
        public string xLinkLogo { get; set; }
        [ParameterOrder(Order = 6)]
        public byte vDxMais { get; set; }
        [ParameterOrder(Order = 7)]
        public byte vDxMenos { get; set; }


    }
}
