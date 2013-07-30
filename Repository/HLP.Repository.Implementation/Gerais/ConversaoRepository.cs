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
    public class ConversaoRepository : IConversaoRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<ConversaoModel> regConversaoAccessor;

        private DataAccessor<ConversaoModel> regAllConversaoAccessor;

        public ConversaoModel GetConversao(int idConversao)
        {
            if (regConversaoAccessor == null)
            {
                regConversaoAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_conversao",
                                    new Parameters(UndTrabalho.dbPrincipal)
                                    .AddParameter<int>("idConversao"),
                                    MapBuilder<ConversaoModel>.MapAllProperties().Build());
            }
            return regConversaoAccessor.Execute(idConversao).FirstOrDefault();
        }

        public List<ConversaoModel> GetAll(int idProduto)
        {
            if (regAllConversaoAccessor == null)
            {
                regAllConversaoAccessor = UndTrabalho.dbPrincipal.CreateSqlStringAccessor("SELECT * FROM Conversao WHERE idProduto = @idProduto",
                                  new Parameters(UndTrabalho.dbPrincipal)
                                    .AddParameter<int>("idProduto"),
                                  MapBuilder<ConversaoModel>.MapAllProperties().Build());
            }


            return regAllConversaoAccessor.Execute(idProduto).ToList();
        }

        public void Save(ConversaoModel conversao)
        {
            try
            {
                UndTrabalho.BeginTransaction();

                if (conversao.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Incluido)
                {
                    conversao.idConversao = (int)UndTrabalho.dbPrincipal.ExecuteScalar(UndTrabalho.dbTransaction,
                                        "[dbo].[Proc_save_Conversao]",
                                        ParameterBase<ConversaoModel>.SetParameterValue(conversao));

                    conversao.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
                }
                else if (conversao.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Alterado)
                {
                    UndTrabalho.dbPrincipal.ExecuteScalar(UndTrabalho.dbTransaction,
                                        "[dbo].[Proc_update_Conversao]",
                                        ParameterBase<ConversaoModel>.SetParameterValue(conversao));

                    conversao.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
                }
                else if (conversao.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Excluido)
                {
                    UndTrabalho.dbPrincipal.ExecuteScalar("[dbo].[Proc_delete_Conversao]",
                                UserData.idUser,
                                conversao.idConversao);

                    conversao.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
                }

                


                UndTrabalho.CommitTransaction();
            }
            catch (Exception ex)
            {
                UndTrabalho.RollBackTransaction();
                throw ex;
            }
        }

        public void Delete(int idProduto)
        {
            try
            {
                UndTrabalho.dbPrincipal.ExecuteNonQuery(System.Data.CommandType.Text,
                "DELETE Conversao WHERE idProduto = " + idProduto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(ConversaoModel conversao)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar("[dbo].[Proc_delete_Conversao]",
                  UserData.idUser,
                  conversao.idConversao);

            conversao.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Copy(ConversaoModel objConversao)
        {
            objConversao.idConversao = null;
            objConversao.idConversao = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                                           UndTrabalho.dbTransaction,
                                           "[dbo].[Proc_save_Conversao]",

            ParameterBase<ConversaoModel>.SetParameterValue(objConversao));
        }
    }
}
