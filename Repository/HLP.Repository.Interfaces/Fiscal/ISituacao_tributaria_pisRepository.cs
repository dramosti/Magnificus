using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Fiscal;

namespace HLP.Repository.Interfaces.Entries.Fiscal
{
    public interface ISituacao_tributaria_pisRepository
    {
        Situacao_tributaria_pisModel GetStPis(int idCSTPis);
        void Save(Situacao_tributaria_pisModel pis);
        void Delete(int idCSTPis);
        int Copy(int idCSTPis);
    }
}
