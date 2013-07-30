using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.Gerais;
using HLP.Models.Entries.Gerais;
using Ninject;
using HLP.Comum.Infrastructure;
using Microsoft.Practices.EnterpriseLibrary.Data;

using System.Data.Common;
using HLP.Comum.Infrastructure.Static;

namespace HLP.Repository.Implementation.Entries.Gerais
{
    public class MoedaRepository : IMoedaRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<MoedaModel> regMoedaAccessor;

        public MoedaModel GetMoeda(int idMoeda)
        {
            if (regMoedaAccessor == null)
            {
                regMoedaAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_moeda",
                                  new Parameters(UndTrabalho.dbPrincipal)
                                    .AddParameter<int>("idMoeda"),
                                  MapBuilder<MoedaModel>.MapAllProperties().Build());
            }


            return regMoedaAccessor.Execute(idMoeda).FirstOrDefault();
        }

        public void Save(MoedaModel moeda)
        {
            if (moeda.idMoeda == null)
            {
                int idMoeda = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                   "[dbo].[Proc_save_moeda]",
                  ParameterBase<MoedaModel>.SetParameterValue(moeda));

                moeda.idMoeda = idMoeda;
            }
            else
            {
                UndTrabalho.dbPrincipal.ExecuteScalar(
                   "[dbo].[Proc_update_Moeda]",
                  ParameterBase<MoedaModel>.SetParameterValue(moeda));
            }
        }

        public void Delete(int idMoeda)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
                     "dbo.Proc_delete_moeda",
                      UserData.idUser,
                      idMoeda);
        }


        public bool IsNew(string xSiglaMoeda)
        {
            DbCommand comand = UndTrabalho.dbPrincipal.GetSqlStringCommand
                              (
                              string.Format("SELECT COUNT(*) FROM Moeda WHERE xSiglaMoeda = '{0}'", xSiglaMoeda)
                              );

            int i = (int)UndTrabalho.dbPrincipal.ExecuteScalar(comand);
            if (i == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public int Copy(int idMoeda)
        {
            return (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                        "dbo.Proc_copy_moeda",
                         idMoeda);
        }
    }
}
