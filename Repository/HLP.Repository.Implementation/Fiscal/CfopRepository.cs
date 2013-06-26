using System;
using System.Linq;
using HLP.Comum.Infrastructure;
using HLP.Comum.Models.Static;
using HLP.Models.Entries.Fiscal;
using HLP.Repository.Interfaces.Entries.Fiscal;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Ninject;

namespace HLP.Repository.Implementation.Entries.Fiscal
{
    public class CfopRepository : ICfopRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<CfopModel> regCfopAccessor;


        public CfopModel GetCfop(int idCfop)
        {
            if (regCfopAccessor == null)
            {
                regCfopAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_cfop",
                                  new Parameters(UndTrabalho.dbPrincipal)
                                    .AddParameter<int>("idCfop"),
                                  MapBuilder<CfopModel>.MapAllProperties().Build());
            }


            return regCfopAccessor.Execute(idCfop).FirstOrDefault();
        }

        public void Save(CfopModel cfop)
        {
            if (cfop.idCfop == null)
            {
                int idCfop = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                    "[dbo].[Proc_save_cfop]",
                   ParameterBase<CfopModel>.SetParameterValue(cfop));

                cfop.idCfop = idCfop;
            }
            else
            {
                UndTrabalho.dbPrincipal.ExecuteScalar(
                    "[dbo].[Proc_update_Cfop]",
                   ParameterBase<CfopModel>.SetParameterValue(cfop));
            }


        }

        public void Delete(int idCfop)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
                    "dbo.Proc_delete_cfop",
                     UserData.idUser,
                     idCfop);
        }


        public int Copy(int idCfop)
        {
            return (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                         "dbo.Proc_copy_cfop",
                          idCfop);
        }
    }
}
