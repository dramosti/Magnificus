using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;

namespace HLP.Repository.Interfaces.Entries.Gerais
{
    public interface ICidadeRepository
    {
        List<CidadeModel> GetCidadeByUf(int idUf);
        List<CidadeModel> GetAll();
        CidadeModel GetCidade(int idCidade);
        UFModel GetUfByCidade(int idCidade);
        CidadeModel GetCidadeByName(string xName);
        void Save(CidadeModel cidade);
        void Delete(int idCidade);
        int Copy(int idCidade);
    }
}
