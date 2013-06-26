using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Gerais;
using HLP.Models.Entries.Gerais;
using Ninject;
using HLP.Repository.Interfaces.Entries.Gerais;

namespace HLP.Services.Implementation.Entries.Gerais
{
    public class Familia_Produto_ClassesService : IFamilia_Produto_ClassesService
    {
        [Inject]
        public IFamilia_Produto_ClassesRepository iFamilia_Produto_ClassesRepository { get; set; }

        public void Save(Familia_Produto_ClassesModel objFamilia_Produto_Classes)
        {
            iFamilia_Produto_ClassesRepository.Save(objFamilia_Produto_Classes);
        }

        public void Update(Familia_Produto_ClassesModel objFamilia_Produto_Classes)
        {
            iFamilia_Produto_ClassesRepository.Update(objFamilia_Produto_Classes);
        }

        public void Delete(int idFamilia_Produto)
        {
            iFamilia_Produto_ClassesRepository.Delete(idFamilia_Produto);
        }

        public void Copy(Familia_Produto_ClassesModel objFamilia_Produto_Classes)
        {
            iFamilia_Produto_ClassesRepository.Copy(objFamilia_Produto_Classes);
        }

        public Familia_Produto_ClassesModel GetFamilia_Produto_Classes(int idFamilia_Produto_Classes)
        {
           return iFamilia_Produto_ClassesRepository.GetFamilia_Produto_Classes(idFamilia_Produto_Classes);
        }

        public List<Familia_Produto_ClassesModel> GetAllFamilia_Produto_Classes(int idFamiliaProduto)
        {
            return iFamilia_Produto_ClassesRepository.GetAllFamilia_Produto_Classes(idFamiliaProduto);
        }
    }
}
