using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Fiscal
{
    public class CfopModel
    {
        [ParameterOrder(Order = 1)]
        public int? idCfop { get; set; }

        [ParameterOrder(Order = 2)]
        public int cCfop { get; set; }

        [ParameterOrder(Order = 3)]
        public string xCfop { get; set; }

        [ParameterOrder(Order = 4)]
        public string xCfopResumida { get; set; }

    }
}
