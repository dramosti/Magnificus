using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Fiscal
{
    public class Situacao_tributaria_icmsModel
    {
        [ParameterOrder(Order = 1)]
        public int? idCSTIcms { get; set; }
        [ParameterOrder(Order = 2)]
        public string cCSTIcms { get; set; }
        [ParameterOrder(Order = 3)]
        public string xCSTIcms { get; set; }
        [ParameterOrder(Order = 4)]
        public byte stSimplesNacional { get; set; }


    }
}
