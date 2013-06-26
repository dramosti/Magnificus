using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Fiscal;
using Ninject;
using HLP.Models.Entries.Fiscal;
using HLP.Repository.Interfaces.Entries.Fiscal;

namespace HLP.Services.Implementation.Entries.Fiscal
{
    public class Situacao_tributaria_ipiService : ISituacao_tributaria_ipiService
    {
        [Inject]
        public ISituacao_tributaria_ipiRepository ipiRepository { get; set; }

        public Situacao_tributaria_ipiModel GetStIpi(int idCSTIpi)
        {
            return ipiRepository.GetStIpi(idCSTIpi);
        }

        public void Save(Situacao_tributaria_ipiModel ipi)
        {
            ipiRepository.Save(ipi);
        }

        public void Delete(int idCSTIpi)
        {
            ipiRepository.Delete(idCSTIpi);
        }


        public int Copy(int idCSTIpi)
        {
            return ipiRepository.Copy(idCSTIpi);
        }
    }
}
