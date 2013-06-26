using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Gerais;
using Ninject;
using HLP.Repository.Interfaces.Entries.Gerais;
using HLP.Models.Entries.Gerais;

namespace HLP.Services.Implementation.Entries.Gerais
{
    public class CidadeService : ICidadeService
    {
        [Inject]
        public ICidadeRepository cidadeRepository { get; set; }

        public List<CidadeModel> GetCidadeByUf(int idUf)
        {
            return cidadeRepository.GetCidadeByUf(idUf);
        }


        public CidadeModel GetCidade(int idCidade)
        {
            return cidadeRepository.GetCidade(idCidade);
        }

        public UFModel GetUfByCidade(int idCidade)
        {
            return cidadeRepository.GetUfByCidade(idCidade);
        }

        public void Save(CidadeModel cidade)
        {
            cidadeRepository.Save(cidade);
        }

        public void Delete(int idCidade)
        {
            cidadeRepository.Delete(idCidade);
        }


        public List<CidadeModel> GetAll()
        {
            return cidadeRepository.GetAll();
        }


        public int Copy(int idCidade)
        {
            return cidadeRepository.Copy(idCidade);
        }



        public CidadeModel GetCidadeByName(string xName)
        {
            return cidadeRepository.GetCidadeByName(xName);
        }
    }
}
