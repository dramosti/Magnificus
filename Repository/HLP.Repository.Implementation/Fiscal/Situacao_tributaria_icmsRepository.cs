﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.Fiscal;
using HLP.Models.Entries.Fiscal;
using Ninject;
using HLP.Comum.Infrastructure;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Comum.Infrastructure.Static;


namespace HLP.Repository.Implementation.Entries.Fiscal
{
    public class Situacao_tributaria_icmsRepository : ISituacao_tributaria_icmsRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Situacao_tributaria_icmsModel> regIcmsAccessor;


        public Situacao_tributaria_icmsModel GetStIcms(int idCSTIcms)
        {

            if (regIcmsAccessor == null)
            {
                regIcmsAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_situacao_tributaria_icms",
                                  new Parameters(UndTrabalho.dbPrincipal)
                                    .AddParameter<int>("idCSTIcms"),
                                  MapBuilder<Situacao_tributaria_icmsModel>.MapAllProperties().Build());
            }


            return regIcmsAccessor.Execute(idCSTIcms).FirstOrDefault();
        }

        public void Save(Situacao_tributaria_icmsModel icms)
        {
            if (icms.idCSTIcms == null)
            {
                int idCSTIcms = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                   "[dbo].[Proc_save_situacao_tributaria_icms]",
                  ParameterBase<Situacao_tributaria_icmsModel>.SetParameterValue(icms));

                icms.idCSTIcms = idCSTIcms;
            }
            else
            {
                UndTrabalho.dbPrincipal.ExecuteScalar(
                   "[dbo].[Proc_update_Situacao_tributaria_icms]",
                  ParameterBase<Situacao_tributaria_icmsModel>.SetParameterValue(icms));
            }
        }

        public void Delete(int idCSTIcms)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
                     "dbo.Proc_delete_situacao_tributaria_icms",
                      UserData.idUser,
                      idCSTIcms);
        }


        public int Copy(int idCSTIcms)
        {
            return (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                       "dbo.Proc_copy_situacao_tributaria_icms",
                        idCSTIcms);
        }
    }
}
