using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.CRM;

namespace HLP.Services.Interfaces.Entries.CRM
{
    public interface IPersonalidadeService
    {
        PersonalidadeModel GetPersonalidade(int idPersonalidade);
        void Save(PersonalidadeModel personalidade);
        void Delete(int idPersonalidade);
        int Copy(int idPersonalidade);
    }
}
