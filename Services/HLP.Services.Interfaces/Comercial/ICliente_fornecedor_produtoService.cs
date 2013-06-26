using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Comercial;

namespace HLP.Services.Interfaces.Entries.Comercial
{
    public interface ICliente_fornecedor_produtoService
    {
        void Save(Cliente_fornecedor_produtoModel objCliente_fornecedor_produto);
        void Update(Cliente_fornecedor_produtoModel objCliente_fornecedor_produto);
        void Delete(Cliente_fornecedor_produtoModel objCliente_fornecedor_produto);
        void Delete(int idClienteFornecedor);
        void Copy(Cliente_fornecedor_produtoModel objCliente_fornecedor_produto);
        Cliente_fornecedor_produtoModel GetCliente_fornecedor_produto(int idClienteFornecedorProduto);
        List<Cliente_fornecedor_produtoModel> GetAllCliente_fornecedor_produto(int idClienteFornecedor);
    }
}
