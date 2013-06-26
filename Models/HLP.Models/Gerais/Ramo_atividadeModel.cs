using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Gerais
{
    public class Ramo_atividadeModel
    {
        [ParameterOrder(Order = 1)]
        public int? idRamoAtividade { get; set; }
        [ParameterOrder(Order = 2)]
        public string xRamo { get; set; }
        [ParameterOrder(Order = 3)]
        public string xDescricao { get; set; }
        [ParameterOrder(Order = 4)]
        public string xCnae { get; set; }

    }
}
