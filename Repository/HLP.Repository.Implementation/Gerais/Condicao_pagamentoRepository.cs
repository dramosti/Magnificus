using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.Gerais;
using HLP.Models.Entries.Gerais;
using Ninject;
using HLP.Comum.Infrastructure;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Comum.Models.Static;

namespace HLP.Repository.Implementation.Entries.Gerais
{
    public class Condicao_pagamentoRepository : ICondicao_pagamentoRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Condicao_pagamentoModel> regCondicaoAccessor;

        public Condicao_pagamentoModel GetCondicao(int idCondicaoPagamento)
        {
            if (regCondicaoAccessor == null)
            {
                regCondicaoAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_condicao_pagamento",
                                  new Parameters(UndTrabalho.dbPrincipal)
                                    .AddParameter<int>("idCondicaoPagamento"),
                                  MapBuilder<Condicao_pagamentoModel>.MapAllProperties().Build());
            }


            return regCondicaoAccessor.Execute(idCondicaoPagamento).FirstOrDefault();
        }

        public void Save(Condicao_pagamentoModel condicao)
        {
            if (condicao.idCondicaoPagamento == null)
            {
                int idCondicaoPagamento = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
             "dbo.Proc_save_condicao_pagamento",
            ParameterBase<Condicao_pagamentoModel>.SetParameterValue(condicao));

                condicao.idCondicaoPagamento = idCondicaoPagamento;
            }
            else
            {
                UndTrabalho.dbPrincipal.ExecuteScalar(
             "dbo.Proc_update_Condicao_pagamento",
            ParameterBase<Condicao_pagamentoModel>.SetParameterValue(condicao));                
            }
            
        }

        public void Delete(int idCondicaoPagamento)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
                      "dbo.Proc_delete_condicao_pagamento",
                       UserData.idUser,
                       idCondicaoPagamento);
        }


        public int Copy(int idCondicaoPagamento)
        {
            return (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                         "dbo.Proc_copy_condicao_pagamento",
                          idCondicaoPagamento);
        }
    }
}
