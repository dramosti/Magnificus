using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.RecursosHumanos
{
    public class CargoModel
    {
        [ParameterOrder(Order = 1)]
        public int? idCargo { get; set; }
        [ParameterOrder(Order = 2)]
        public string xCargo { get; set; }
        [ParameterOrder(Order = 3)]
        public string xDescricao { get; set; }
        [ParameterOrder(Order = 4)]
        public int idEmpresa { get; set; }

    }
}
