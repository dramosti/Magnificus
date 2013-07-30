using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.Gerais;
using Ninject;
using HLP.Comum.Infrastructure;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Models.Entries.Gerais;
using HLP.Comum.Infrastructure.Static;


namespace HLP.Repository.Implementation.Entries.Gerais
{
    public class Plano_pagamentoRepository : IPlano_pagamentoRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Plano_pagamentoModel> regPlano_pagamentoAccessor;

        public void Save(Plano_pagamentoModel objPlano_pagamento)
        {
            //Aqui deve-se setar as FK's (se houver)
            //Exemplo:
            //produto.idEmpresa = CompanyData.idEmpresa;

            if (objPlano_pagamento.idPlanoPagamento == null)
            {
                objPlano_pagamento.idPlanoPagamento = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                "[dbo].[Proc_save_Plano_pagamento]",
                ParameterBase<Plano_pagamentoModel>.SetParameterValue(objPlano_pagamento));
            }
            else
            {
                UndTrabalho.dbPrincipal.ExecuteScalar(
                "[dbo].[Proc_update_Plano_pagamento]",
                ParameterBase<Plano_pagamentoModel>.SetParameterValue(objPlano_pagamento));
            }
        }

        public void Delete(Plano_pagamentoModel objPlano_pagamento)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
            UndTrabalho.dbTransaction,
           "[dbo].[Proc_delete_Plano_pagamento]",
            UserData.idUser,
            objPlano_pagamento.idPlanoPagamento);
        }

        public void Copy(Plano_pagamentoModel objPlano_pagamento)
        {
            objPlano_pagamento.idPlanoPagamento = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
            UndTrabalho.dbTransaction,
           "dbo.Proc_copy_Plano_pagamento",
            objPlano_pagamento.idPlanoPagamento);
        }

        public Plano_pagamentoModel GetPlano_pagamento(int idPlanoPagamento)
        {

            if (regPlano_pagamentoAccessor == null)
            {
                regPlano_pagamentoAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_Plano_pagamento",
                                         new Parameters(UndTrabalho.dbPrincipal)
                                         .AddParameter<int>("idPlanoPagamento"),
                                         MapBuilder<Plano_pagamentoModel>.MapAllProperties().Build());
            }

            return regPlano_pagamentoAccessor.Execute(idPlanoPagamento).FirstOrDefault();
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
