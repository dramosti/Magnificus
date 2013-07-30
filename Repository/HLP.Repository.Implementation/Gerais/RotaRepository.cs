using System;
using System.Linq;
using Ninject;
using HLP.Comum.Infrastructure;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Models.Entries.Gerais;
using HLP.Repository.Interfaces.Entries.Gerais;
using System.Collections.Generic;
using HLP.Comum.Infrastructure.Static;

namespace HLP.Repository.Implementation.Entries.Gerais
{
    public class RotaRepository : IRotaRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<RotaModel> regRotaAccessor;

        public void Save(RotaModel objRota)
        {
            //Aqui deve-se setar as FK's (se houver)
            //Exemplo:
            //produto.idEmpresa = CompanyData.idEmpresa;

            if (objRota.idRota == null)
            {
                objRota.idRota = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                "[dbo].[Proc_save_Rota]",
                ParameterBase<RotaModel>.SetParameterValue(objRota));
            }
            else
            {                
                UndTrabalho.dbPrincipal.ExecuteScalar(
                "[dbo].[Proc_update_Rota]",
                ParameterBase<RotaModel>.SetParameterValue(objRota));
            }
        }

        public void Delete(RotaModel objRota)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
            UndTrabalho.dbTransaction,
           "[dbo].[Proc_delete_Rota]",
            UserData.idUser,
            objRota.idRota);
        }

        public void Copy(RotaModel objRota)
        {
            objRota.idRota = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
            UndTrabalho.dbTransaction,
           "dbo.Proc_copy_Rota",
            objRota.idRota);
        }

        public RotaModel GetRota(int idRota)
        {

            if (regRotaAccessor == null)
            {
                regRotaAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_Rota",
                                         new Parameters(UndTrabalho.dbPrincipal)
                                         .AddParameter<int>("idRota"),
                                         MapBuilder<RotaModel>.MapAllProperties().Build());
            }

            return regRotaAccessor.Execute(idRota).FirstOrDefault();
        }

        public void BeginTransaction()
        {
            UndTrabalho.BeginTransaction();
        }
        public void CommitTransaction()
        {
            UndTrabalho.CommitTransaction();
        }
        public void RollackTransaction()
        {
            UndTrabalho.RollBackTransaction();
        }
    }
}
