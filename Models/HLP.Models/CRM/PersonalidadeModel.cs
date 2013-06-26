using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.CRM
{
    public class PersonalidadeModel
    {
        [ParameterOrder(Order = 1)]
        public int? idPersonalidade { get; set; }
        [ParameterOrder(Order = 2)]
        public string xPersonalidade { get; set; }
        [ParameterOrder(Order = 3)]
        public string xDescricao { get; set; }

    }
}
