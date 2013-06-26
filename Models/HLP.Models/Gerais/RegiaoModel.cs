using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Gerais
{
   public class RegiaoModel
    {
        [ParameterOrder(Order = 1)]
        public int? idRegiao { get; set; }

        [ParameterOrder(Order = 2)]
        public string xRegiao { get; set; }

        [ParameterOrder(Order = 3)]
        public int idPais { get; set; }

    }
}
