using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.RecursosHumanos
{
    public class SetorModel
    {
        [ParameterOrder(Order = 1)]
        public int idEmpresa { get; set; }
        [ParameterOrder(Order = 2)]
        public int? idSetor { get; set; }
        [ParameterOrder(Order = 3)]
        public string xSetor { get; set; }
        [ParameterOrder(Order = 4)]
        public string xDescricao { get; set; }
        [ParameterOrder(Order = 5)]
        public string xEmail { get; set; }

    }
}
