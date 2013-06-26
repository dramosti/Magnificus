using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.CRM;
using HLP.Repository.Interfaces.Entries.CRM;
using Ninject;

namespace HLP.Services.Implementation.Entries.CRM
{
    public class FidelidadeService : IFidelidadeService
    {
        [Inject]
        public IFidelidadeRepository fidelidadeRepository { get; set; }


        public Models.Entries.CRM.FidelidadeModel GetFidelidade(int idFidelidade)
        {
            return fidelidadeRepository.GetFidelidade(idFidelidade);
        }

        public void Save(Models.Entries.CRM.FidelidadeModel fidelidade)
        {
            fidelidadeRepository.Save(fidelidade);
        }

        public void Delete(int idFidelidade)
        {
            fidelidadeRepository.Delete(idFidelidade);
        }

        public int Copy(int idFidelidade)
        {
           return fidelidadeRepository.Copy(idFidelidade);
        }
    }
}
