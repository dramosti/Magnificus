using HLP.Comum.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLP.Models.Entries.Fiscal
{
    public class Carga_trib_media_st_icmsModel
    {
        [ParameterOrder(Order = 1)]
        public int? idCargaTribMediaStIcms { get; set; }
        [ParameterOrder(Order = 2)]
        public int idRamoAtividade { get; set; }
        [ParameterOrder(Order = 3)]
        public int idUf { get; set; }
        [ParameterOrder(Order = 4)]
        public decimal pCargaTributariaMedia { get; set; }
    }
}
