using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Gerais;
using Ninject;
using HLP.Repository.Interfaces.Entries.Gerais;
using HLP.Models.Entries.Gerais;
using System.Data;

namespace HLP.Services.Implementation.Entries.Gerais
{
    public class UFService : IUFService
    {
        [Inject]
        public IUFRepository ufRepository { get; set; }

        public List<UFModel> GetAll()
        {
            return ufRepository.GetAll();
        }


        public UFModel GetUF(int idUF)
        {
            return ufRepository.GetUF(idUF);
        }

        public DataTable GetAlltoComboBox()
        {
            return ufRepository.GetAlltoComboBox();
        }

        public void Save(UFModel uf)
        {
            ufRepository.Save(uf);
        }

        public void Delete(int idUF)
        {
            ufRepository.Delete(idUF);
        }


        public bool IsNew(string xSiglaUf)
        {
            return ufRepository.IsNew(xSiglaUf);
        }


        public int Copy(int idUF)
        {
            return ufRepository.Copy(idUF);
        }
    }
}
