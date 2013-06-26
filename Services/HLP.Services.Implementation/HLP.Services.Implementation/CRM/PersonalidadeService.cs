using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.CRM;
using HLP.Models.Entries.CRM;
using Ninject;
using HLP.Repository.Interfaces.Entries.CRM;

namespace HLP.Services.Implementation.Entries.CRM
{
    public class PersonalidadeService : IPersonalidadeService
    {
        [Inject]
        public IPersonalidadeRepository personalidadeRepository { get; set; }

        public PersonalidadeModel GetPersonalidade(int idPersonalidade)
        {
            return personalidadeRepository.GetPersonalidade(idPersonalidade);
        }

        public void Save(PersonalidadeModel personalidade)
        {
            personalidadeRepository.Save(personalidade);
        }

        public void Delete(int idPersonalidade)
        {
            personalidadeRepository.Delete(idPersonalidade);
        }

        public int Copy(int idPersonalidade)
        {
            return personalidadeRepository.Copy(idPersonalidade);
        }
    }
}
