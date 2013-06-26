using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Fiscal
{
    public class Codigo_Icms_paiModel
    {
        [ParameterOrder(Order = 1)]
        public int idEmpresa { get; set; }
        [ParameterOrder(Order = 2)]
        public int? idCodigoIcmsPai { get; set; }
        [ParameterOrder(Order = 3)]
        public int cIcms { get; set; }

        public List<Codigo_IcmsModel> lCodigo_Icms = new List<Codigo_IcmsModel>();
    }
}
