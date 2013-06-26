using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Fiscal
{
    public class Situacao_tributaria_ipiModel
    {
        [ParameterOrder(Order = 1)]
        public int? idCSTIpi { get; set; }
        [ParameterOrder(Order = 2)]
        public string cCSTIpi { get; set; }
        [ParameterOrder(Order = 3)]
        public string xCSTIpi { get; set; }
        [ParameterOrder(Order = 4)]
        public byte stSimplesNacional { get; set; }


    }
}
