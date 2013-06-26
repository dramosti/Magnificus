using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.CRM;

namespace HLP.Repository.Interfaces.Entries.CRM
{
    public interface IPersonalidadeRepository
    {
        PersonalidadeModel GetPersonalidade(int idPersonalidade);
        void Save(PersonalidadeModel personalidade);
        void Delete(int idPersonalidade);
        int Copy(int idPersonalidade);
    }
}
