using System;
using System.Collections.Generic;
using System.Linq;
using HLP.Comum.Repository.Interfaces.Configuracao;
using Ninject;
using HLP.Comum.Infrastructure;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using HLP.Comum.Models.Static;

namespace HLP.Comum.Repository.Implementation.Configuracao
{
    public class RelatoriosRepository : IRelatoriosRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        public bool ReportExistInDataBase(string xName)
        {
            try
            {
                DbCommand comand = UndTrabalho.dbPrincipal.GetSqlStringCommand
                            (
                            string.Format("SELECT  COUNT(*)  FROM RELATORIOS WHERE xNomeFisico = '{0}'", xName)
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
            catch (Exception)
            {
                throw;
            }
        }
        public List<RelatoriosModel> GetRelatorioByFormulario(int idFormulario)
        {
            return UndTrabalho.dbPrincipal.CreateSqlStringAccessor("SELECT * FROM  RELATORIOS WHERE idFormularios = " + idFormulario,
                                        MapBuilder<RelatoriosModel>.MapAllProperties().Build()).Execute().ToList();
        }
        public List<RelatoriosModel> GetAllRelatorio()
        {
            try
            {
                return UndTrabalho.dbPrincipal.CreateSqlStringAccessor("SELECT * FROM  RELATORIOS",
                                        MapBuilder<RelatoriosModel>.MapAllProperties().Build()).Execute().ToList();

            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Save(RelatoriosModel relatorio)
        {
            relatorio.idRelatorio = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                   "[dbo].[Proc_save_Relatorios]",
                  ParameterBase<RelatoriosModel>.SetParameterValue(relatorio));
        }
        public void DeleteItens(int? idPai, string snotIn = "")
        {
            string sql = string.Empty;
            if (snotIn == "")
            {
                sql = string.Format("DELETE FROM Relatorios WHERE  idFormulario = {1}", idPai);
            }
            else
            {
                sql = string.Format("DELETE FROM Relatorios WHERE  idFormulario = {1} AND idRelatorio NOT IN ({2})", idPai, snotIn);
            }
            UndTrabalho.dbPrincipal.ExecuteScalar(UndTrabalho.dbTransaction, CommandType.Text, sql);
        }
        public void Delete(int idRelatorio)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(UndTrabalho.dbTransaction,
           "dbo.Proc_delete_Relatorios",
           UserData.idUser, idRelatorio);
        }
    }
}
