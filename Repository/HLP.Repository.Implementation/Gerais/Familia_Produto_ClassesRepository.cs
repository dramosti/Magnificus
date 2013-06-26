using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using HLP.Comum.Infrastructure;
using HLP.Models.Entries.Gerais;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Comum.Models.Static;
using HLP.Repository.Interfaces.Entries.Gerais;

namespace HLP.Repository.Implementation.Entries.Gerais
{
    public class Familia_Produto_ClassesRepository : IFamilia_Produto_ClassesRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Familia_Produto_ClassesModel> regFamilia_Produto_ClassesAccessor;

        public void Save(Familia_Produto_ClassesModel objFamilia_Produto_Classes)
        {
            objFamilia_Produto_Classes.idFamilia_Produto_Classes = (int)UndTrabalho.dbPrincipal.ExecuteScalar(UndTrabalho.dbTransaction, "dbo.Proc_save_Familia_Produto_Classes",
            ParameterBase<Familia_Produto_ClassesModel>.SetParameterValue(objFamilia_Produto_Classes));

            objFamilia_Produto_Classes.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Update(Familia_Produto_ClassesModel objFamilia_Produto_Classes)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(UndTrabalho.dbTransaction,
            "[dbo].[Proc_update_Familia_Produto_Classes]",
            ParameterBase<Familia_Produto_ClassesModel>.SetParameterValue(objFamilia_Produto_Classes));

            objFamilia_Produto_Classes.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Delete(int idFamilia_Produto_Classes)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(UndTrabalho.dbTransaction, "dbo.Proc_delete_Familia_Produto_Classes",
                 UserData.idUser,
                 idFamilia_Produto_Classes);
        }

        public void Copy(Familia_Produto_ClassesModel objFamilia_Produto_Classes)
        {
            objFamilia_Produto_Classes.idFamilia_Produto_Classes = null;
            objFamilia_Produto_Classes.idFamilia_Produto_Classes = (int)UndTrabalho.dbPrincipal.ExecuteScalar(UndTrabalho.dbTransaction,
                      "dbo.Proc_save_Familia_Produto_Classes",
            ParameterBase<Familia_Produto_ClassesModel>.SetParameterValue(objFamilia_Produto_Classes));
        }

        public Familia_Produto_ClassesModel GetFamilia_Produto_Classes(int idFamilia_Produto_Classes)
        {
            if (regFamilia_Produto_ClassesAccessor == null)
            {
                regFamilia_Produto_ClassesAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_Familia_Produto_Classes",
                                 new Parameters(UndTrabalho.dbPrincipal)
                                 .AddParameter<int>("idFamilia_Produto_Classes"),
                                 MapBuilder<Familia_Produto_ClassesModel>.MapAllProperties().Build());
            }

            return regFamilia_Produto_ClassesAccessor.Execute(idFamilia_Produto_Classes).FirstOrDefault();
        }

        public List<Familia_Produto_ClassesModel> GetAllFamilia_Produto_Classes(int idFamiliaProduto)
        {
            DataAccessor<Familia_Produto_ClassesModel> reg = UndTrabalho.dbPrincipal.CreateSqlStringAccessor
             ("select * from Familia_Produto_Classes where idFamiliaProduto = @idFamiliaProduto", new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idFamiliaProduto"),
             MapBuilder<Familia_Produto_ClassesModel>.MapAllProperties().Build());

            return reg.Execute(idFamiliaProduto).ToList();
        }

    }
}
