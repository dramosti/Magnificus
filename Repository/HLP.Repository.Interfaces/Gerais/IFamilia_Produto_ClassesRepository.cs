using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;

namespace HLP.Repository.Interfaces.Entries.Gerais
{
    public interface IFamilia_Produto_ClassesRepository
    {
        void Save(Familia_Produto_ClassesModel objFamilia_Produto_Classes);
        void Update(Familia_Produto_ClassesModel objFamilia_Produto_Classes);
        void Delete(int idFamilia_Produto);
        void Copy(Familia_Produto_ClassesModel objFamilia_Produto_Classes);
        Familia_Produto_ClassesModel GetFamilia_Produto_Classes(int idFamilia_Produto_Classes);
        List<Familia_Produto_ClassesModel> GetAllFamilia_Produto_Classes(int idFamiliaProduto);
    }
}
