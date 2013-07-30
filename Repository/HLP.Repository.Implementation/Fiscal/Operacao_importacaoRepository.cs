using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.Fiscal;
using HLP.Models.Entries.Fiscal;
using HLP.Comum.Infrastructure;
using Ninject;
using Microsoft.Practices.EnterpriseLibrary.Data;

using System.Data.Common;
using System.Data;
using HLP.Comum.Infrastructure.Static;

namespace HLP.Repository.Implementation.Entries.Fiscal
{
    public class Operacao_importacaoRepository : IOperacao_importacaoRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Operacao_importacaoModel> regOperacaoImportacaoAccessor;

        public List<Operacao_importacaoModel> GetAll(int idTipoOperacao)
        {
            if (regOperacaoImportacaoAccessor == null)
            {
                regOperacaoImportacaoAccessor = UndTrabalho.dbPrincipal.CreateSqlStringAccessor("SELECT * FROM Operacao_importacao WHERE idTipoOperacao = @idTipoOperacao",
                                  new Parameters(UndTrabalho.dbPrincipal)
                                    .AddParameter<int>("idTipoOperacao"),
                                  MapBuilder<Operacao_importacaoModel>.MapAllProperties().Build());
            }


            return regOperacaoImportacaoAccessor.Execute(idTipoOperacao).ToList();
        }

        public void Save(Operacao_importacaoModel operacaoImportacao)
        {
            int idOperacaoImportacao = Convert.ToInt32((UndTrabalho.dbPrincipal.ExecuteScalar(UndTrabalho.dbTransaction,
                 "dbo.Proc_save_operacao_importacao",
                ParameterBase<Operacao_importacaoModel>.SetParameterValue(operacaoImportacao))));

            operacaoImportacao.idOperacaoImportacao = idOperacaoImportacao;
        }

        public void Delete(int idOperacaoImportacao)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(UndTrabalho.dbTransaction,
              "dbo.Proc_delete_operacao_importacao",
              UserData.idUser, idOperacaoImportacao);
        }

        public void Delete(int idTipoOperacao, List<int?> lidOperacaoImportacao)
        {
            DbCommand cmd;
            string sql = "";
            if (lidOperacaoImportacao.Count() > 0)
            {
                string notIn = String.Join(",", lidOperacaoImportacao);
                sql = "DELETE FROM Operacao_importacao WHERE  idTipoOperacao =" + idTipoOperacao + " AND idOperacaoImportacao NOT IN (" + notIn + ")";
            }
            else
            {
                sql = "DELETE FROM Operacao_importacao WHERE  idTipoOperacao =" + idTipoOperacao;
            }
            cmd = UndTrabalho.dbPrincipal.GetSqlStringCommand(sql);

            UndTrabalho.dbPrincipal.ExecuteScalar(UndTrabalho.dbTransaction, CommandType.Text, sql);
        }
    }
}
