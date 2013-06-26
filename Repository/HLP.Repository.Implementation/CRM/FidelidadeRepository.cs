using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.CRM;
using HLP.Comum.Infrastructure;
using Ninject;
using HLP.Models.Entries.CRM;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Comum.Models.Static;
namespace HLP.Repository.Implementation.Entries.CRM
{
    public class FidelidadeRepository : IFidelidadeRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<FidelidadeModel> regFidelidadeAccessor;

        public Models.Entries.CRM.FidelidadeModel GetFidelidade(int idFidelidade)
        {
            if (regFidelidadeAccessor == null)
            {
                regFidelidadeAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_fidelidade",
                                    new Parameters(UndTrabalho.dbPrincipal)
                                    .AddParameter<int>("idFidelidade"),
                                    MapBuilder<FidelidadeModel>.MapAllProperties().Build());
            }
            return regFidelidadeAccessor.Execute(idFidelidade).FirstOrDefault();
        }

        public void Save(Models.Entries.CRM.FidelidadeModel fidelidade)
        {
            if (fidelidade.idFidelidade == null)
            {
                int idFidelidade = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                   "dbo.Proc_save_fidelidade",
                  ParameterBase<FidelidadeModel>.SetParameterValue(fidelidade));

                fidelidade.idFidelidade = idFidelidade;
            }
            else
            {
                UndTrabalho.dbPrincipal.ExecuteScalar(
                   "[dbo].[Proc_update_Fidelidade]",
                  ParameterBase<FidelidadeModel>.SetParameterValue(fidelidade));
            }
        }

        public void Delete(int idFidelidade)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
            "dbo.Proc_delete_fidelidade",
             UserData.idUser,
             idFidelidade);
        }

        public int Copy(int idFidelidade)
        {
            return (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                      "dbo.Proc_copy_fidelidade",
                       idFidelidade);
        }
    }
}
