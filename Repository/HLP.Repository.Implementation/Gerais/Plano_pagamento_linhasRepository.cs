using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.Gerais;
using HLP.Models.Entries.Gerais;
using Ninject;
using HLP.Comum.Infrastructure;
using Microsoft.Practices.EnterpriseLibrary.Data;

using System.Data.Common;
using System.Data;
using HLP.Comum.Infrastructure.Static;

namespace HLP.Repository.Implementation.Entries.Gerais
{
    public class Plano_pagamento_linhasRepository : IPlano_pagamento_linhasRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Plano_pagamento_linhasModel> regAcessor;

        public void Save(Plano_pagamento_linhasModel objPlano_pagamento_linhas)
        {
            objPlano_pagamento_linhas.idLinhasPagamento = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
           "[dbo].[Proc_save_Plano_pagamento_linhas]",
            ParameterBase<Plano_pagamento_linhasModel>.SetParameterValue(objPlano_pagamento_linhas));

            objPlano_pagamento_linhas.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Update(Plano_pagamento_linhasModel objPlano_pagamento_linhas)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
            "[dbo].[Proc_update_Plano_pagamento_linhas]",
            ParameterBase<Plano_pagamento_linhasModel>.SetParameterValue(objPlano_pagamento_linhas));

            objPlano_pagamento_linhas.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Delete(Plano_pagamento_linhasModel objPlano_pagamento_linhas)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar("[dbo].[Proc_delete_Plano_pagamento_linhas]",
                  UserData.idUser,
                  objPlano_pagamento_linhas.idLinhasPagamento);

            objPlano_pagamento_linhas.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Delete(int idPlanoPagamento)
        {
            UndTrabalho.dbPrincipal.ExecuteNonQuery(System.Data.CommandType.Text,
              "DELETE Plano_pagamento_linhas WHERE idPlanoPagamento = " + idPlanoPagamento);
        }

        public void Copy(Plano_pagamento_linhasModel objPlano_pagamento_linhas)
        {
            objPlano_pagamento_linhas.idLinhasPagamento = null;
            objPlano_pagamento_linhas.idLinhasPagamento = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                                           UndTrabalho.dbTransaction,
                                           "[dbo].[Proc_save_Plano_pagamento_linhas]",
        ParameterBase<Plano_pagamento_linhasModel>.SetParameterValue(objPlano_pagamento_linhas));
        }

        public Plano_pagamento_linhasModel GetPlano_pagamento_linhas(int idLinhasPagamento)
        {
            if (regAcessor == null)
            {
                regAcessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("[dbo].[Proc_sel_Plano_pagamento_linhas]",
                   new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idLinhasPagamento"),
                   MapBuilder<Plano_pagamento_linhasModel>.MapAllProperties().Build());
            }
            return regAcessor.Execute(idLinhasPagamento).FirstOrDefault();
        }

        public List<Plano_pagamento_linhasModel> GetAllPlano_pagamento_linhas(int idPlanoPagamento)
        {
            DataAccessor<Plano_pagamento_linhasModel> reg = UndTrabalho.dbPrincipal.CreateSqlStringAccessor
            ("SELECT * FROM Plano_pagamento_linhas WHERE idPlanoPagamento = @idPlanoPagamento", new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idPlanoPagamento"),
            MapBuilder<Plano_pagamento_linhasModel>.MapAllProperties().Build());

            return reg.Execute(idPlanoPagamento).ToList();
        }
    }
}
