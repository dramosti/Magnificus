using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.Comercial;
using Ninject;
using HLP.Comum.Infrastructure;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Models.Entries.Comercial;
using HLP.Comum.Infrastructure.Static;


namespace HLP.Repository.Implementation.Entries.Comercial
{
    public class Produto_RevisaoRepository : IProduto_RevisaoRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Produto_RevisaoModel> regProdutoRevisaoAcessor;

        public void Save(Produto_RevisaoModel produtoRevisao)
        {
            produtoRevisao.idProdutoRevisao = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
            "[dbo].[Proc_save_Produto_Revisao]",
            ParameterBase<Produto_RevisaoModel>.SetParameterValue(produtoRevisao));

            produtoRevisao.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Update(Produto_RevisaoModel produtoRevisao)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
            "[dbo].[Proc_update_Produto_Revisao]",
            ParameterBase<Produto_RevisaoModel>.SetParameterValue(produtoRevisao));

            produtoRevisao.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Delete(Produto_RevisaoModel produtoRevisao)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar("[dbo].[Proc_delete_Produto_Revisao]",
                    UserData.idUser,
                    produtoRevisao.idProdutoRevisao);

            // Tem que setar como sem mudança para que ao excluir, se for atualizar novamente,
            // ao salvar não entre neste método para excluir novamente no banco...
            // OBS: NÃO EXCLUA O OBJETO diaPagamentoLinhaModel DA LISTA diaPagamento.lDiaPagamentoLinhasModel, ISTO DARÁ ERRO POIS
            // O OBJETO AINDA CONTINUA NA GRID, SÓ ESTÁ INVISÍVEL ...
            produtoRevisao.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Copy(Produto_RevisaoModel produtoRevisao)
        {
            produtoRevisao.idProdutoRevisao = null;
            produtoRevisao.idProdutoRevisao = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                                              UndTrabalho.dbTransaction,
                                              "[dbo].[Proc_save_produto_revisao]",
           ParameterBase<Produto_RevisaoModel>.SetParameterValue(produtoRevisao));
        }

        /// <summary>
        /// Deleta todos os registros cujo id seja igual à idProduto
        /// </summary>
        /// <param name="idProduto">Id do registro Pai</param>
        public void Delete(int idProduto)
        {
            UndTrabalho.dbPrincipal.ExecuteNonQuery(System.Data.CommandType.Text,
                "DELETE Produto_Revisao WHERE idProduto = " + idProduto);
        }

        public Produto_RevisaoModel GetProdutoRevisao(int idProdutoRevisao)
        {
            if (regProdutoRevisaoAcessor == null)
            {
                regProdutoRevisaoAcessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("[dbo].[Proc_sel_Produto_Revisao]",
                    new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idProdutoRevisao"),
                    MapBuilder<Produto_RevisaoModel>.MapAllProperties().Build());
            }
            return regProdutoRevisaoAcessor.Execute(idProdutoRevisao).FirstOrDefault();
        }

        public List<Produto_RevisaoModel> GetAllProdutoRevisao(int idProduto)
        {
            DataAccessor<Produto_RevisaoModel> regProdRevisao = UndTrabalho.dbPrincipal.CreateSqlStringAccessor
               ("SELECT * FROM Produto_Revisao WHERE idProduto = @idProduto", new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idProduto"),
               MapBuilder<Produto_RevisaoModel>.MapAllProperties().Build());

            return regProdRevisao.Execute(idProduto).ToList();
        }

    }
}
