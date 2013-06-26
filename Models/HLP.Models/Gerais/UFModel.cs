using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Gerais
{
    public class UFModel
    {

        [ParameterOrder(Order = 1)]
        public int? idUF { get; set; }

        [ParameterOrder(Order = 2)]
        public string xSiglaUf { get; set; }

        [ParameterOrder(Order = 3)]
        public string xUf { get; set; }

        [ParameterOrder(Order = 4)]
        public int cIbgeUf { get; set; }

        [ParameterOrder(Order = 5)]
        public int idRegiao { get; set; }

    }
}
