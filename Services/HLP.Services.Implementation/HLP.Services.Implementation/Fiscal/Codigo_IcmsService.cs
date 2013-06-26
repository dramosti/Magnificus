using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Fiscal;
using HLP.Models.Entries.Fiscal;
using HLP.Repository.Interfaces.Entries.Fiscal;
using Ninject;

namespace HLP.Services.Implementation.Entries.Fiscal
{
    public class Codigo_IcmsService : ICodigo_IcmsService
    {
        [Inject]
        public ICodigo_IcmsRepository _Codigo_IcmsRepository { get; set; }

        public void Save(Codigo_IcmsModel objCodigo_Icms)
        {
            _Codigo_IcmsRepository.Save(objCodigo_Icms);
        }

        public void Update(Codigo_IcmsModel objCodigo_Icms)
        {
            _Codigo_IcmsRepository.Update(objCodigo_Icms);
        }

        public void Delete(Codigo_IcmsModel objCodigo_Icms)
        {
            _Codigo_IcmsRepository.Delete(objCodigo_Icms);
        }

        public void Delete(int idCodigoIcmsPai)
        {
            _Codigo_IcmsRepository.Delete(idCodigoIcmsPai);
        }

        public void Copy(Codigo_IcmsModel objCodigo_Icms)
        {
            _Codigo_IcmsRepository.Copy(objCodigo_Icms);
        }

        public Codigo_IcmsModel GetCodigo_Icms(int idCodigoIcms)
        {
            return _Codigo_IcmsRepository.GetCodigo_Icms(idCodigoIcms);
        }

        public List<Codigo_IcmsModel> GetAllCodigo_Icms(int idCodigoIcmsPai)
        {
            return _Codigo_IcmsRepository.GetAllCodigo_Icms(idCodigoIcmsPai);
        }
    }
}
