using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.CRM;

namespace HLP.Services.Interfaces.Entries.CRM
{
    public interface IDecisaoService
    {
        DecisaoModel GetDecisao(int idDecisao);
        void Save(DecisaoModel decisao);
        void Delete(int idDecisao);
        int Copy(int idDecisao);
    }
}
