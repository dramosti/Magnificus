using HLP.Comum.Infrastructure;
using HLP.Models.Entries.Gerais;
using HLP.Repository.Interfaces.Entries.Gerais;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Ninject;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Configuration;

namespace HLP.Repository.Implementation.Entries.Gerais
{
    public class Log_ScriptsRepository : ILog_ScriptsRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Log_ScriptsModel> regLog_ScriptsAccessor;
        private DataAccessor<Log_ScriptsModel> regAllLog_ScriptsAccessor;


        public void Save(Log_ScriptsModel objLog_Scripts)
        {
            objLog_Scripts.idLog = (int)UndTrabalho.dbPrincipal.ExecuteScalar("dbo.Proc_save_Log_Scripts",
            ParameterBase<Log_ScriptsModel>.SetParameterValue(objLog_Scripts));
        }

        public void Update(Log_ScriptsModel objLog_Scripts)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
            "[dbo].[Proc_update_Log_Scripts]",
            ParameterBase<Log_ScriptsModel>.SetParameterValue(objLog_Scripts));

            objLog_Scripts.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public Log_ScriptsModel GetLog_Scripts(int idLog)
        {
            if (regLog_ScriptsAccessor == null)
            {
                regLog_ScriptsAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_Log_Scripts",
                                 new Parameters(UndTrabalho.dbPrincipal)
                                 .AddParameter<int>("idLog"),
                                 MapBuilder<Log_ScriptsModel>.MapAllProperties().Build());
            }

            return regLog_ScriptsAccessor.Execute(idLog).FirstOrDefault();
        }

        public List<Log_ScriptsModel> GetAllLog_Scripts()
        {
            if (regAllLog_ScriptsAccessor == null)
            {
                regAllLog_ScriptsAccessor = UndTrabalho.dbPrincipal.CreateSqlStringAccessor("SELECT * FROM Log_Scripts",
                                MapBuilder<Log_ScriptsModel>.MapAllProperties().Build());
            }
            return regAllLog_ScriptsAccessor.Execute().ToList();
        }

        public int GetLog_ScriptCount(string xNome)
        {
            regAllLog_ScriptsAccessor = UndTrabalho.dbPrincipal.CreateSqlStringAccessor("SELECT * FROM Log_Scripts where "
                +"xVersao = '"+xNome+"'",
                                MapBuilder<Log_ScriptsModel>.MapAllProperties().Build());
            return regAllLog_ScriptsAccessor.Execute().Count();
        }

        public bool ExecutaScritp(string sScript)
        {
            try
            {
                SqlCommand command = new SqlCommand(sScript);
                UndTrabalho.dbPrincipal.ExecuteNonQuery(command);
                return true;
            }
            catch (System.Exception ex)
            {
                return false;
            }           
        }

        public void BackupDataBase(string xPath, string xNameBackup)
        {
            try
            {
                UndTrabalho.BackupDatabase(xPath: xPath, xNameBackup: xNameBackup);
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public int RetornaPorcBkp()
        {
            return UndTrabalho.pPorcentagem;
        }
    }
}
