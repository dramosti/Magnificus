using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.CRM;
using HLP.Models.Entries.CRM;
using Ninject;
using HLP.Comum.Infrastructure;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Comum.Infrastructure.Static;


namespace HLP.Repository.Implementation.Entries.CRM
{
    public class DecisaoRepository : IDecisaoRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<DecisaoModel> regDecisaoAccessor;

        public DecisaoModel GetDecisao(int idDecisao)
        {
            if (regDecisaoAccessor == null)
            {
                regDecisaoAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_decisao",
                                    new Parameters(UndTrabalho.dbPrincipal)
                                    .AddParameter<int>("idDecisao"),
                                    MapBuilder<DecisaoModel>.MapAllProperties().Build());
            }
            return regDecisaoAccessor.Execute(idDecisao).FirstOrDefault();
        }

        public void Save(DecisaoModel decisao)
        {
            if (decisao.idDecisao == null)
            {
                int idDecisao = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                  "dbo.Proc_save_decisao",
                 ParameterBase<DecisaoModel>.SetParameterValue(decisao));

                decisao.idDecisao = idDecisao;
            }
            else
            {
                UndTrabalho.dbPrincipal.ExecuteScalar(
                  "dbo.Proc_update_Decisao",
                 ParameterBase<DecisaoModel>.SetParameterValue(decisao));
            }
        }

        public void Delete(int idDecisao)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
                     "dbo.Proc_delete_decisao",
                      UserData.idUser,
                      idDecisao);
        }

        public int Copy(int idDecisao)
        {
            return (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                         "dbo.Proc_copy_decisao",
                          idDecisao);
        }
    }
}
