using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Fiscal;
using Ninject;
using HLP.Repository.Interfaces.Entries.Fiscal;
using HLP.Models.Entries.Fiscal;

namespace HLP.Services.Implementation.Entries.Fiscal
{
    public class Situacao_tributaria_icmsService : ISituacao_tributaria_icmsService
    {
        [Inject]
        public ISituacao_tributaria_icmsRepository icmsRepository { get; set; }

        public Situacao_tributaria_icmsModel GetStIcms(int idCSTIcms)
        {
            return icmsRepository.GetStIcms(idCSTIcms);
        }

        public void Save(Situacao_tributaria_icmsModel icms)
        {
            icmsRepository.Save(icms);
        }

        public void Delete(int idCSTIcms)
        {
            icmsRepository.Delete(idCSTIcms);
        }


        public int Copy(int idCSTIcms)
        {
            return icmsRepository.Copy(idCSTIcms);
        }
    }
}
