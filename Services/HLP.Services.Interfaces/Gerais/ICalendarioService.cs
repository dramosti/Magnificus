using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;

namespace HLP.Services.Interfaces.Entries.Gerais
{
    public interface ICalendarioService
    {
        void Save(CalendarioModel objCalendario);
        void Delete(CalendarioModel objCalendario);
        void Copy(CalendarioModel objCalendario);
        CalendarioModel GetCalendario(int idCalendario, bool bChildren = false);
        List<CalendarioModel> GetCalendarios(int idEmpresa);
    }
}
