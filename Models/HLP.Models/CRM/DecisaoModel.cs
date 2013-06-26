using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.CRM
{
    public class DecisaoModel
    {
        [ParameterOrder(Order = 1)]
        public int? idDecisao { get; set; }
        [ParameterOrder(Order = 2)]
        public string xDecisao { get; set; }
        [ParameterOrder(Order = 3)]
        public string xDescricao { get; set; }

    }
}
