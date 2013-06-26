using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.CRM;

namespace HLP.Repository.Interfaces.Entries.CRM
{
    public interface IFidelidadeRepository
    {
        FidelidadeModel GetFidelidade(int idFidelidade);
        void Save(FidelidadeModel fidelidade);
        void Delete(int idFidelidade);
        int Copy(int idFidelidade);
    }
}
