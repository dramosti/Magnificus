using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;

namespace HLP.Services.Interfaces.Entries.Gerais
{
    public interface ISiteService
    {
        void Save(SiteModel objSite);
        void Delete(SiteModel objSite);
        void Copy(SiteModel objSite);
        SiteModel GetSite(int idSite, bool bChildren = false);
        List<SiteModel> GetAll();
    }
}
