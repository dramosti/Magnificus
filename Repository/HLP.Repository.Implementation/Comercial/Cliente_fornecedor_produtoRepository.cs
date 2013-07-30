using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.Comercial;
using HLP.Models.Entries.Comercial;
using Ninject;
using HLP.Comum.Infrastructure;
using Microsoft.Practices.EnterpriseLibrary.Data;

using System.Data.Common;
using System.Data;
using HLP.Comum.Infrastructure.Static;

namespace HLP.Repository.Implementation.Entries.Comercial
{
    public class Cliente_fornecedor_produtoRepository : ICliente_fornecedor_produtoRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Cliente_fornecedor_produtoModel> regAcessor;

        public void Save(Cliente_fornecedor_produtoModel objCliente_fornecedor_produto)
        {
            objCliente_fornecedor_produto.idClienteFornecedorProduto = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
           "[dbo].[Proc_save_Cliente_fornecedor_produto]",
            ParameterBase<Cliente_fornecedor_produtoModel>.SetParameterValue(objCliente_fornecedor_produto));

            objCliente_fornecedor_produto.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Update(Cliente_fornecedor_produtoModel objCliente_fornecedor_produto)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
            "[dbo].[Proc_update_Cliente_fornecedor_produto]",
            ParameterBase<Cliente_fornecedor_produtoModel>.SetParameterValue(objCliente_fornecedor_produto));

            objCliente_fornecedor_produto.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Delete(Cliente_fornecedor_produtoModel objCliente_fornecedor_produto)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar("[dbo].[Proc_delete_Cliente_fornecedor_produto]",
                  UserData.idUser,
                  objCliente_fornecedor_produto.idClienteFornecedorProduto);

            objCliente_fornecedor_produto.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Delete(int idClienteFornecedor)
        {
            UndTrabalho.dbPrincipal.ExecuteNonQuery(System.Data.CommandType.Text,
              "DELETE Cliente_fornecedor_produto WHERE idClienteFornecedor = " + idClienteFornecedor);
        }

        public void Copy(Cliente_fornecedor_produtoModel objCliente_fornecedor_produto)
        {
            objCliente_fornecedor_produto.idClienteFornecedorProduto = null;
            objCliente_fornecedor_produto.idClienteFornecedorProduto = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                                           UndTrabalho.dbTransaction,
                                           "[dbo].[Proc_save_Cliente_fornecedor_produto]",
        ParameterBase<Cliente_fornecedor_produtoModel>.SetParameterValue(objCliente_fornecedor_produto));
        }

        public Cliente_fornecedor_produtoModel GetCliente_fornecedor_produto(int idClienteFornecedorProduto)
        {
            if (regAcessor == null)
            {
                regAcessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("[dbo].[Proc_sel_Cliente_fornecedor_produto]",
                   new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idClienteFornecedorProduto"),
                   MapBuilder<Cliente_fornecedor_produtoModel>.MapAllProperties().Build());
            }
            return regAcessor.Execute(idClienteFornecedorProduto).FirstOrDefault();
        }

        public List<Cliente_fornecedor_produtoModel> GetAllCliente_fornecedor_produto(int idClienteFornecedor)
        {
            DataAccessor<Cliente_fornecedor_produtoModel> reg = UndTrabalho.dbPrincipal.CreateSqlStringAccessor
            ("SELECT * FROM Cliente_fornecedor_produto WHERE idClienteFornecedor = @idClienteFornecedor", new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idClienteFornecedor"),
            MapBuilder<Cliente_fornecedor_produtoModel>.MapAllProperties().Build());

            return reg.Execute(idClienteFornecedor).ToList();
        }
    }
}
