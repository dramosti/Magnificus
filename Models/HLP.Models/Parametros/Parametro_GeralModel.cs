using HLP.Comum.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLP.Models.Entries.Parametros
{
    public class Parametro_GeralModel
    {
        [ParameterOrder(Order = 1)]
        public int? idParametroGeral { get; set; }
        [ParameterOrder(Order = 2)]
        public int idEmpresa { get; set; }
        [ParameterOrder(Order = 3)]
        public byte stMaiusculo { get; set; }
    }
}
