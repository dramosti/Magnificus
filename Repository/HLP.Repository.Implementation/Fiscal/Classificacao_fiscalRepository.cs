﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.Fiscal;
using HLP.Comum.Infrastructure;
using Ninject;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Models.Entries.Fiscal;
using HLP.Comum.Infrastructure.Static;


namespace HLP.Repository.Implementation.Entries.Fiscal
{
    public class Classificacao_fiscalRepository : IClassificacao_fiscalRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Classificacao_fiscalModel> regClassificacaoAccessor;

        public Classificacao_fiscalModel GetClassificacao(int idClassificacaoFiscal)
        {
            if (regClassificacaoAccessor == null)
            {
                regClassificacaoAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_classificacao_fiscal",
                                  new Parameters(UndTrabalho.dbPrincipal)
                                    .AddParameter<int>("idClassificacaoFiscal"),
                                  MapBuilder<Classificacao_fiscalModel>.MapAllProperties().Build());
            }


            return regClassificacaoAccessor.Execute(idClassificacaoFiscal).FirstOrDefault();
        }

        public void Save(Classificacao_fiscalModel classificacao)
        {
            if (classificacao.idClassificacaoFiscal == null)
            {
                int idClassificacaoFiscal = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                   "[dbo].[Proc_save_classificacao_fiscal]",
                  ParameterBase<Classificacao_fiscalModel>.SetParameterValue(classificacao));

                classificacao.idClassificacaoFiscal = idClassificacaoFiscal;
            }
            else
            {
                UndTrabalho.dbPrincipal.ExecuteScalar(
                   "[dbo].[Proc_update_Classificacao_fiscal]",
                  ParameterBase<Classificacao_fiscalModel>.SetParameterValue(classificacao));
            }
        }

        public void Delete(int idClassificacaoFiscal)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
                    "dbo.Proc_delete_classificacao_fiscal",
                     UserData.idUser,
                     idClassificacaoFiscal);
        }


        public int Copy(int idClassificacaoFiscal)
        {
            return (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                        "dbo.Proc_copy_classificacao_fiscal",
                         idClassificacaoFiscal);
        }
    }
}
