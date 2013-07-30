using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.Financeiro;
using HLP.Models.Entries.Financeiro;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Comum.Infrastructure;
using Ninject;
using HLP.Comum.Infrastructure.Static;


namespace HLP.Repository.Implementation.Entries.Financeiro
{
    public class AgenciaRepository : IAgenciaRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<AgenciaModel> regAgenciaAccessor;
        private DataAccessor<AgenciaModel> regAgenciaByBancoAccessor;

        public void Save(AgenciaModel objAgencia)
        {
            //Aqui deve-se setar as FK's (se houver)
            //Exemplo:
            //produto.idEmpresa = CompanyData.idEmpresa;

            if (objAgencia.idAgencia == null)
            {
                objAgencia.idAgencia = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                "[dbo].[Proc_save_Agencia]",
                ParameterBase<AgenciaModel>.SetParameterValue(objAgencia));
            }
            else
            {
                UndTrabalho.dbPrincipal.ExecuteScalar(
                "[dbo].[Proc_update_Agencia]",
                ParameterBase<AgenciaModel>.SetParameterValue(objAgencia));
            }
        }

        public void Delete(AgenciaModel objAgencia)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
            UndTrabalho.dbTransaction,
           "[dbo].[Proc_delete_Agencia]",
            UserData.idUser,
            objAgencia.idAgencia);
        }

        public void Copy(AgenciaModel objAgencia)
        {
            objAgencia.idAgencia = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
            UndTrabalho.dbTransaction,
           "dbo.Proc_copy_Agencia",
            objAgencia.idAgencia);
        }

        public AgenciaModel GetAgencia(int idAgencia)
        {

            if (regAgenciaAccessor == null)
            {
                regAgenciaAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_Agencia",
                                         new Parameters(UndTrabalho.dbPrincipal)
                                         .AddParameter<int>("idAgencia"),
                                         MapBuilder<AgenciaModel>.MapAllProperties().Build());
            }

            return regAgenciaAccessor.Execute(idAgencia).FirstOrDefault();
        }

        public List<AgenciaModel> GetByBanco(int idBanco)
        {
            if (regAgenciaByBancoAccessor == null)
            {
                regAgenciaByBancoAccessor = UndTrabalho.dbPrincipal.CreateSqlStringAccessor("SELECT * FROM Agencia WHERE idBanco = @idBanco",
                                  new Parameters(UndTrabalho.dbPrincipal)
                                    .AddParameter<int>("idBanco"),
                                  MapBuilder<AgenciaModel>.MapAllProperties().Build());
            }


            return regAgenciaByBancoAccessor.Execute(idBanco).ToList();
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
