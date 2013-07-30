using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.Gerais;
using HLP.Models.Entries.Gerais;
using Ninject;
using HLP.Comum.Infrastructure;
using Microsoft.Practices.EnterpriseLibrary.Data;

using HLP.Services.Interfaces.Entries.Gerais;
using System.Data.Common;
using System.Data;
using HLP.Comum.Infrastructure.Static;

namespace HLP.Repository.Implementation.Entries.Gerais
{
    public class CalendarioRepository : ICalendarioRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<CalendarioModel> regCalendarioAccessor;

        private DataAccessor<CalendarioModel> reglCalendarioAccessor;


        public void Save(CalendarioModel objCalendario)
        {
            //Aqui deve-se setar as FK's (se houver)
            //Exemplo:
            //produto.idEmpresa = CompanyData.idEmpresa;

            if (objCalendario.idCalendario == null)
            {
                objCalendario.idCalendario = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                "[dbo].[Proc_save_Calendario]",
                ParameterBase<CalendarioModel>.SetParameterValue(objCalendario));
            }
            else
            {
                UndTrabalho.dbPrincipal.ExecuteScalar(
                "[dbo].[Proc_update_Calendario]",
                ParameterBase<CalendarioModel>.SetParameterValue(objCalendario));
            }
        }

        public void Delete(CalendarioModel objCalendario)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
            UndTrabalho.dbTransaction,
           "[dbo].[Proc_delete_Calendario]",
            UserData.idUser,
            objCalendario.idCalendario);
        }

        public void Copy(CalendarioModel objCalendario)
        {
            objCalendario.idCalendario = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
            UndTrabalho.dbTransaction,
           "dbo.Proc_copy_Calendario",
            objCalendario.idCalendario);
        }

        public CalendarioModel GetCalendario(int idCalendario)
        {

            if (regCalendarioAccessor == null)
            {
                regCalendarioAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_Calendario",
                                         new Parameters(UndTrabalho.dbPrincipal)
                                         .AddParameter<int>("idCalendario"),
                                         MapBuilder<CalendarioModel>.MapAllProperties().Build());
            }

            return regCalendarioAccessor.Execute(idCalendario).FirstOrDefault();
        }

        public List<CalendarioModel> GetCalendarios(int idEmpresa)
        {
            if (reglCalendarioAccessor == null)
            {
                reglCalendarioAccessor = UndTrabalho.dbPrincipal.CreateSqlStringAccessor("SELECT * FROM Calendario WHERE idEmpresa= @idEmpresa",
                                  new Parameters(UndTrabalho.dbPrincipal)
                                    .AddParameter<int>("idEmpresa"),
                                  MapBuilder<CalendarioModel>.MapAllProperties().Build());
            }


            return reglCalendarioAccessor.Execute(idEmpresa).ToList();
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
