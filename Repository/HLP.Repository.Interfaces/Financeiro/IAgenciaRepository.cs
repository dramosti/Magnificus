using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Financeiro;

namespace HLP.Repository.Interfaces.Entries.Financeiro
{
    public interface IAgenciaRepository
    {
        void Save(AgenciaModel objAgencia);
        void Delete(AgenciaModel objAgencia);
        void Copy(AgenciaModel objAgencia);
        AgenciaModel GetAgencia(int idAgencia);
        List<AgenciaModel> GetByBanco(int idBanco);

        void BeginTransaction();
        void CommitTransaction();
        void RollackTransaction();
    }
}
