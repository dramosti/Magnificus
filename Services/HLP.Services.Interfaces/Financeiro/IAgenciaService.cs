using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Financeiro;

namespace HLP.Services.Interfaces.Entries.Financeiro
{
    public interface IAgenciaService
    {
        void Save(AgenciaModel objAgencia);
        void Delete(AgenciaModel objAgencia);
        void Copy(AgenciaModel objAgencia);
        AgenciaModel GetAgencia(int idAgencia, bool bChildren = false);
        List<AgenciaModel> GetByBanco(int idBanco);
    }
}
