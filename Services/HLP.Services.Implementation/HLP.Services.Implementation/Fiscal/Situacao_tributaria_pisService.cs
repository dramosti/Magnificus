using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Fiscal;
using Ninject;
using HLP.Models.Entries.Fiscal;
using HLP.Repository.Interfaces.Entries.Fiscal;

namespace HLP.Services.Implementation.Entries.Fiscal
{
    public class Situacao_tributaria_pisService : ISituacao_tributaria_pisService
    {
        [Inject]
        public ISituacao_tributaria_pisRepository pisRepository { get; set; }

        public Situacao_tributaria_pisModel GetStPis(int idCSTPis)
        {
            return pisRepository.GetStPis(idCSTPis);
        }

        public void Save(Situacao_tributaria_pisModel pis)
        {
            pisRepository.Save(pis);
        }

        public void Delete(int idCSTPis)
        {
            pisRepository.Delete(idCSTPis);
        }


        public int Copy(int idCSTPis)
        {
            return pisRepository.Copy(idCSTPis);
        }
    }
}
