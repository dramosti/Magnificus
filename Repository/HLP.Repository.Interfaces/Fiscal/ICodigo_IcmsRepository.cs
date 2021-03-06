﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Fiscal;

namespace HLP.Repository.Interfaces.Entries.Fiscal
{
    public interface ICodigo_IcmsRepository
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
