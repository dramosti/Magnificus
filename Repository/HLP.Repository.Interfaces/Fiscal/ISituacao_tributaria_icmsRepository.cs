using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Fiscal;

namespace HLP.Repository.Interfaces.Entries.Fiscal
{
    public interface ISituacao_tributaria_icmsRepository
    {
        Situacao_tributaria_icmsModel GetStIcms(int idCSTIcms);
        void Save(Situacao_tributaria_icmsModel icms);
        void Delete(int idCSTIcms);
        int Copy(int idCSTIcms);
    }
}
