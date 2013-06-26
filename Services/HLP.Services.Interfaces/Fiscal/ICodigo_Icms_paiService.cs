using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Fiscal;

namespace HLP.Services.Interfaces.Entries.Fiscal
{
    public interface ICodigo_Icms_paiService
    {
        void Save(Codigo_Icms_paiModel objCodigo_Icms_pai);
        void Delete(Codigo_Icms_paiModel objCodigo_Icms_pai);
        void Copy(Codigo_Icms_paiModel objCodigo_Icms_pai);
        Codigo_Icms_paiModel GetCodigo_Icms_pai(int idCodigoIcmsPai, bool bChildren = false);
    }
}
