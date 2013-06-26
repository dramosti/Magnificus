using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;

namespace HLP.Repository.Interfaces.Entries.Gerais
{
    public interface ISiteRepository
    {
        void Save(SiteModel objSite);
        void Delete(SiteModel objSite);
        void Copy(SiteModel objSite);
        SiteModel GetSite(int idSite);
        List<SiteModel> GetAll();

        void BeginTransaction();
        void CommitTransaction();
        void RollackTransaction();
    }
}
