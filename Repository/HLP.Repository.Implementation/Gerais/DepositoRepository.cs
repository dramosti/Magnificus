using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.Gerais;
using HLP.Models.Entries.Gerais;
using HLP.Comum.Infrastructure;
using Ninject;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Comum.Infrastructure.Static;


namespace HLP.Repository.Implementation.Entries.Gerais
{
    public class DepositoRepository : IDepositoRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<DepositoModel> regDepositoBySiteAccessor;
        private DataAccessor<DepositoModel> regDepositoAccessor;


        public List<DepositoModel> GetBySite(int idSite)
        {
            if (regDepositoBySiteAccessor == null)
            {
                regDepositoBySiteAccessor = UndTrabalho.dbPrincipal.CreateSqlStringAccessor("SELECT * FROM Deposito WHERE idSite = @idSite",
                                  new Parameters(UndTrabalho.dbPrincipal)
                                    .AddParameter<int>("idSite"),
                                  MapBuilder<DepositoModel>.MapAllProperties().Build());
            }


            return regDepositoBySiteAccessor.Execute(idSite).ToList();
        }


        public DepositoModel GetDeposito(int idDeposito)
        {
            if (regDepositoAccessor == null)
            {
                regDepositoAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_deposito",
                                  new Parameters(UndTrabalho.dbPrincipal)
                                    .AddParameter<int>("idDeposito"),
                                  MapBuilder<DepositoModel>.MapAllProperties().Build());
            }


            return regDepositoAccessor.Execute(idDeposito).FirstOrDefault();
        }

        public void Save(DepositoModel deposito)
        {
            if (deposito.idDeposito == null)
            {
                int idDeposito = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                    "[dbo].[Proc_save_deposito]",
                   ParameterBase<DepositoModel>.SetParameterValue(deposito));

                deposito.idDeposito = idDeposito;
            }
            else
            {
                UndTrabalho.dbPrincipal.ExecuteScalar(
                    "[dbo].[Proc_update_Deposito]",
                   ParameterBase<DepositoModel>.SetParameterValue(deposito));
            }
        }

        public void Delete(int idDeposito)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
                   "dbo.Proc_delete_deposito",
                    UserData.idUser,
                    idDeposito);
        }


        public int Copy(int idDeposito)
        {
            return (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                       "dbo.Proc_copy_deposito",
                        idDeposito);
        }
    }
}
