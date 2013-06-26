using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.CRM
{
    public class FidelidadeModel
    {
        [ParameterOrder(Order = 1)]
        public int? idFidelidade { get; set; }
        [ParameterOrder(Order = 2)]
        public string xFidelidade { get; set; }
        [ParameterOrder(Order = 3)]
        public string xDescricao { get; set; }

    }
}
