using System;
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
    public class Tipo_operacaoRepository : ITipo_operacaoRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Tipo_operacaoModel> regOperacaoAccessor;

        public Tipo_operacaoModel GetOperacao(int idTipoOperacao)
        {
            if (regOperacaoAccessor == null)
            {
                regOperacaoAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_tipo_operacao",
                                  new Parameters(UndTrabalho.dbPrincipal)
                                    .AddParameter<int>("idTipoOperacao"),
                                  MapBuilder<Tipo_operacaoModel>.MapAllProperties().Build());
            }


            return regOperacaoAccessor.Execute(idTipoOperacao).FirstOrDefault();
        }

        public void Save(Tipo_operacaoModel operacao)
        {
            if (operacao.idTipoOperacao == null)
            {
                int idTipoOperacao = Convert.ToInt32((UndTrabalho.dbPrincipal.ExecuteScalar(UndTrabalho.dbTransaction,
                "dbo.Proc_save_tipo_operacao",
                 ParameterBase<Tipo_operacaoModel>.SetParameterValue(operacao))));

                operacao.idTipoOperacao = idTipoOperacao;
            }
            else
            {
                UndTrabalho.dbPrincipal.ExecuteScalar(UndTrabalho.dbTransaction,
                "[dbo].[Proc_update_Tipo_operacao]",
                 ParameterBase<Tipo_operacaoModel>.SetParameterValue(operacao));
            }
        }

        public void Delete(int idTipoOperacao)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(UndTrabalho.dbTransaction, "dbo.Proc_delete_tipo_operacao",
                UserData.idUser,
                idTipoOperacao);
        }


        public void Begin()
        {
            UndTrabalho.BeginTransaction();
        }

        public void Commit()
        {
            UndTrabalho.CommitTransaction();
        }

        public void RollBack()
        {
            UndTrabalho.RollBackTransaction();
        }


        public int Copy(int idTipoOperacao)
        {
            return (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                         "dbo.Proc_copy_tipo_operacao",
                          idTipoOperacao);
        }
    }
}
