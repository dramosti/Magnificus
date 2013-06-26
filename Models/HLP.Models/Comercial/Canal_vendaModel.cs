using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Comercial
{
    public class Canal_vendaModel
    {
        [ParameterOrder(Order = 1)]
        public int? idCanalVenda { get; set; }
        [ParameterOrder(Order = 2)]
        public string cCanalVenda { get; set; }
        [ParameterOrder(Order = 3)]
        public string xCanalVenda { get; set; }

    }
}
