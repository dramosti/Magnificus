using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.RecursosHumanos;
using Ninject;
using HLP.Repository.Interfaces.Entries.RecursosHumanos;
using HLP.Models.Entries.RecursosHumanos;

namespace HLP.Services.Implementation.Entries.RecursosHumanos
{
    public class SetorService : ISetorService
    {
        [Inject]
        public ISetorRepository setorRepository { get; set; }

        public SetorModel GetSetor(int idSetor)
        {
            return setorRepository.GetSetor(idSetor);
        }

        public void Save(SetorModel setor)
        {
            setorRepository.Save(setor);
        }

        public void Delete(int idSetor)
        {
            setorRepository.Delete(idSetor);
        }


        public int Copy(int idSetor)
        {
            return setorRepository.Copy(idSetor);
        }

        public List<SetorModel> GetAll()
        {
            return setorRepository.GetAll();
        }
    }
}
