﻿using System;
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
    public class SiteRepository : ISiteRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<SiteModel> regSiteAccessor;

        private DataAccessor<SiteModel> regAllSiteAccessor;

        public void Save(SiteModel objSite)
        {
            //Aqui deve-se setar as FK's (se houver)
            //Exemplo:
            //produto.idEmpresa = CompanyData.idEmpresa;

            if (objSite.idSite == null)
            {
                objSite.idSite = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                "[dbo].[Proc_save_Site]",
                ParameterBase<SiteModel>.SetParameterValue(objSite));
            }
            else
            {
                UndTrabalho.dbPrincipal.ExecuteScalar(
                "[dbo].[Proc_update_Site]",
                ParameterBase<SiteModel>.SetParameterValue(objSite));
            }
        }

        public void Delete(SiteModel objSite)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
            UndTrabalho.dbTransaction,
           "[dbo].[Proc_delete_Site]",
            UserData.idUser,
            objSite.idSite);
        }

        public void Copy(SiteModel objSite)
        {
            objSite.idSite = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
            UndTrabalho.dbTransaction,
           "dbo.Proc_copy_Site",
            objSite.idSite);
        }

        public SiteModel GetSite(int idSite)
        {

            if (regSiteAccessor == null)
            {
                regSiteAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_Site",
                                         new Parameters(UndTrabalho.dbPrincipal)
                                         .AddParameter<int>("idSite"),
                                         MapBuilder<SiteModel>.MapAllProperties().Build());
            }

            return regSiteAccessor.Execute(idSite).FirstOrDefault();
        }

        public List<SiteModel> GetAll()
        {
            if (regAllSiteAccessor == null)
            {
                regAllSiteAccessor = UndTrabalho.dbPrincipal.CreateSqlStringAccessor("SELECT * FROM Site",
                                  MapBuilder<SiteModel>.MapAllProperties().Build());
            }
            return regAllSiteAccessor.Execute().ToList();
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
