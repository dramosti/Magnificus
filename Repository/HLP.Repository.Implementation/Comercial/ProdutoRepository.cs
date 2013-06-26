using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.Comercial;
using HLP.Models.Entries.Comercial;
using Ninject;
using HLP.Comum.Infrastructure;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Comum.Models.Static;
using System.Data;

namespace HLP.Repository.Implementation.Entries.Comercial
{
    public class ProdutoRepository : IProdutoRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<ProdutoModel> regProduToAccessor;

        private DataAccessor<ProdutoModel> regProdutoByTypeAccessor;

        public ProdutoModel GetProduto(int idProduto)
        {

            if (regProduToAccessor == null)
            {
                regProduToAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_produto",
                                     new Parameters(UndTrabalho.dbPrincipal)
                                    .AddParameter<int>("idProduto"),
                                    MapBuilder<ProdutoModel>.MapAllProperties().Build());
            }

            return regProduToAccessor.Execute(idProduto).FirstOrDefault();
        }

        public void Save(ProdutoModel produto)
        {
            produto.idEmpresa = CompanyData.idEmpresa;

            if (produto.idProduto == null)
            {
                produto.idProduto = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                "[dbo].[Proc_save_produto]",
                ParameterBase<ProdutoModel>.SetParameterValue(produto));
            }
            else
            {
                UndTrabalho.dbPrincipal.ExecuteScalar(
                "[dbo].[Proc_update_Produto]",
                ParameterBase<ProdutoModel>.SetParameterValue(produto));
            }

        }

        public void Delete(ProdutoModel produto)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
            UndTrabalho.dbTransaction,
            "[dbo].[Proc_delete_Produto]",
            UserData.idUser,
            produto.idProduto);
        }

        public void Copy(ProdutoModel produto)
        {
            produto.idProduto = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                                UndTrabalho.dbTransaction,
                                "dbo.Proc_copy_produto",
                                produto.idProduto);
        }

        public List<ProdutoModel> GetByProdutoType(int idTipoProduto)
        {
            if (regProdutoByTypeAccessor == null)
            {
                regProdutoByTypeAccessor = UndTrabalho.dbPrincipal.CreateSqlStringAccessor("SELECT * FROM Produto WHERE idTipoProduto = @idTipoProduto",
                                  new Parameters(UndTrabalho.dbPrincipal)
                                    .AddParameter<int>("idTipoProduto"),
                                  MapBuilder<ProdutoModel>.MapAllProperties().Build());
            }


            return regProdutoByTypeAccessor.Execute(idTipoProduto).ToList();
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
