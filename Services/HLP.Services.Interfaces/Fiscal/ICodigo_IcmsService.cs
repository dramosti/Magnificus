using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Fiscal;

namespace HLP.Services.Interfaces.Entries.Fiscal
{
    public interface ICodigo_IcmsService
    {
        void Save(Codigo_IcmsModel objCodigo_Icms);
        void Update(Codigo_IcmsModel objCodigo_Icms);
        void Delete(Codigo_IcmsModel objCodigo_Icms);
        void Delete(int idCodigoIcmsPai);
        void Copy(Codigo_IcmsModel objCodigo_Icms);
        Codigo_IcmsModel GetCodigo_Icms(int idCodigoIcms);
        List<Codigo_IcmsModel> GetAllCodigo_Icms(int idCodigoIcmsPai);

    }
}
