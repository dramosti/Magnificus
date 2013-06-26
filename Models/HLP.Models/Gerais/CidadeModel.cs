using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Gerais
{
   public  class CidadeModel
    {
        [ParameterOrder(Order = 1)]
        public int? idCidade { get; set; }

        [ParameterOrder(Order = 2)]
        public string xCidade { get; set; }

        [ParameterOrder(Order = 3)]
        public int cIbge { get; set; }

        [ParameterOrder(Order = 4)]
        public int idUF { get; set; }

    }
}
