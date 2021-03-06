﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using HLP.Comum.Infrastructure;
using HLP.Models.Entries.Financeiro;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Repository.Interfaces.Entries.Financeiro;

using System.Data;
using HLP.Comum.Infrastructure.Static;

namespace HLP.Repository.Implementation.Entries.Financeiro
{
    public class Dia_PagamentoRepository : IDia_PagamentoRepository
    {

        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Dia_pagamentoModel> regDia_pagamentoAccessor;

        public void Save(Dia_pagamentoModel objDia_pagamento)
        {
            //Aqui deve-se setar as FK's (se houver)
            //Exemplo:
            //produto.idEmpresa = CompanyData.idEmpresa;

            if (objDia_pagamento.idDiaPagamento == null)
            {
                objDia_pagamento.idDiaPagamento = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                "[dbo].[Proc_save_Dia_pagamento]",
                ParameterBase<Dia_pagamentoModel>.SetParameterValue(objDia_pagamento));
            }
            else
            {
                UndTrabalho.dbPrincipal.ExecuteScalar(
                "[dbo].[Proc_update_Dia_pagamento]",
                ParameterBase<Dia_pagamentoModel>.SetParameterValue(objDia_pagamento));
            }
        }

        public void Delete(Dia_pagamentoModel objDia_pagamento)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
            UndTrabalho.dbTransaction,
           "[dbo].[Proc_delete_Dia_pagamento]",
            UserData.idUser,
            objDia_pagamento.idDiaPagamento);
        }

        public void Copy(Dia_pagamentoModel objDia_pagamento)
        {
            objDia_pagamento.idDiaPagamento = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
            UndTrabalho.dbTransaction,
           "dbo.Proc_copy_Dia_pagamento",
            objDia_pagamento.idDiaPagamento);
        }

        public Dia_pagamentoModel GetDia_pagamento(int idDiaPagamento)
        {

            if (regDia_pagamentoAccessor == null)
            {
                regDia_pagamentoAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_Dia_pagamento",
                                         new Parameters(UndTrabalho.dbPrincipal)
                                         .AddParameter<int>("idDiaPagamento"),
                                         MapBuilder<Dia_pagamentoModel>.MapAllProperties().Build());
            }

            return regDia_pagamentoAccessor.Execute(idDiaPagamento).FirstOrDefault();
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
