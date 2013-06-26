using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Gerais
{
    public class FabricanteModel
    {
        [ParameterOrder(Order = 1)]
        public int? idFabricante { get; set; }
        [ParameterOrder(Order = 2)]
        public string xFantasia { get; set; }
        [ParameterOrder(Order = 3)]
        public string xRazao { get; set; }

    }
}
