using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.RecursosHumanos
{
    public class DepartamentoModel
    {
        [ParameterOrder(Order = 1)]
        public int? idDepartamento { get; set; }
        [ParameterOrder(Order = 2)]
        public string xDepartamento { get; set; }
        [ParameterOrder(Order = 3)]
        public string xDescricao { get; set; }
        [ParameterOrder(Order = 4)]
        public int? idSetor { get; set; }
        [ParameterOrder(Order = 5)]
        public string xEmail { get; set; }

    }
}
