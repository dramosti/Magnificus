using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Fiscal;

namespace HLP.Services.Interfaces.Entries.Fiscal
{
    public interface ISituacao_tributaria_pisService
    {
        Situacao_tributaria_pisModel GetStPis(int idCSTPis);
        void Save(Situacao_tributaria_pisModel pis);
        void Delete(int idCSTPis);
        int Copy(int idCSTPis);
    }
}
