using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.Fiscal;
using HLP.Models.Entries.Fiscal;
using HLP.Comum.Infrastructure;
using Ninject;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Comum.Models.Static;
using System.Data.Common;
using System.Data;

namespace HLP.Repository.Implementation.Entries.Fiscal
{
    public class Operacao_reducao_baseRepository : IOperacao_reducao_baseRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Operacao_reducao_baseModel> regOperacaoReducaoAccessor;

        public List<Operacao_reducao_baseModel> GetAll(int idTipoOperacao)
        {
            if (regOperacaoReducaoAccessor == null)
            {
                regOperacaoReducaoAccessor = UndTrabalho.dbPrincipal.CreateSqlStringAccessor("SELECT * FROM Operacao_reducao_base WHERE idTipoOperacao = @idTipoOperacao",
                                  new Parameters(UndTrabalho.dbPrincipal)
                                    .AddParameter<int>("idTipoOperacao"),
                                  MapBuilder<Operacao_reducao_baseModel>.MapAllProperties().Build());
            }


            return regOperacaoReducaoAccessor.Execute(idTipoOperacao).ToList();
        }

        public void Save(Operacao_reducao_baseModel operacaoReducao)
        {
            int idOperacaoReducaoBase = Convert.ToInt32((UndTrabalho.dbPrincipal.ExecuteScalar(UndTrabalho.dbTransaction,
               "dbo.Proc_save_operacao_reducao_base",
              ParameterBase<Operacao_reducao_baseModel>.SetParameterValue(operacaoReducao))));

            operacaoReducao.idOperacaoReducaoBase = idOperacaoReducaoBase;
        }

        public void Delete(int idOperacaoReducaoBase)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(UndTrabalho.dbTransaction,
             "dbo.Proc_delete_operacao_reducao_base",
             UserData.idUser, idOperacaoReducaoBase);
        }

        public void Delete(int idTipoOperacao, List<int?> lidOperacaoReducaoBase)
        {
            DbCommand cmd;
            string sql = "";
            if (lidOperacaoReducaoBase.Count() > 0)
            {
                string notIn = String.Join(",", lidOperacaoReducaoBase);
                sql = "DELETE FROM Operacao_reducao_base WHERE  idTipoOperacao =" + idTipoOperacao + " AND idOperacaoReducaoBase NOT IN (" + notIn + ")";
            }
            else
            {
                sql = "DELETE FROM Operacao_reducao_base WHERE  idTipoOperacao =" + idTipoOperacao;
            }
            cmd = UndTrabalho.dbPrincipal.GetSqlStringCommand(sql);

            UndTrabalho.dbPrincipal.ExecuteScalar(UndTrabalho.dbTransaction, CommandType.Text, sql);
        }
    }
}
