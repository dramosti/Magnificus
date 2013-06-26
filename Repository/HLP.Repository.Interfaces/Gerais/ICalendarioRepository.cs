using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;

namespace HLP.Repository.Interfaces.Entries.Gerais
{
    public interface ICalendarioRepository
    {
        void Save(CalendarioModel objCalendario);
        void Delete(CalendarioModel objCalendario);
        void Copy(CalendarioModel objCalendario);
        CalendarioModel GetCalendario(int idCalendario);
        List<CalendarioModel> GetCalendarios(int idEmpresa);

        void BeginTransaction();
        void CommitTransaction();
        void RollackTransaction();
    }
}
