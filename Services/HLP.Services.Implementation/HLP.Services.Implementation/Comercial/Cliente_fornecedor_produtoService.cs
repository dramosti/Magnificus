using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Comercial;
using HLP.Repository.Interfaces.Entries.Comercial;
using Ninject;
using HLP.Models.Entries.Comercial;

namespace HLP.Services.Implementation.Entries.Comercial
{
    public class Cliente_fornecedor_produtoService : ICliente_fornecedor_produtoService
    {
        [Inject]
        public ICliente_fornecedor_produtoRepository _Cliente_fornecedor_produtoRepository { get; set; }

        public void Save(Cliente_fornecedor_produtoModel objCliente_fornecedor_produto)
        {
            _Cliente_fornecedor_produtoRepository.Save(objCliente_fornecedor_produto);
        }

        public void Update(Cliente_fornecedor_produtoModel objCliente_fornecedor_produto)
        {
            _Cliente_fornecedor_produtoRepository.Update(objCliente_fornecedor_produto);
        }

        public void Delete(Cliente_fornecedor_produtoModel objCliente_fornecedor_produto)
        {
            _Cliente_fornecedor_produtoRepository.Delete(objCliente_fornecedor_produto);
        }

        public void Delete(int idClienteFornecedor)
        {
            _Cliente_fornecedor_produtoRepository.Delete(idClienteFornecedor);
        }

        public void Copy(Cliente_fornecedor_produtoModel objCliente_fornecedor_produto)
        {
            _Cliente_fornecedor_produtoRepository.Copy(objCliente_fornecedor_produto);
        }

        public Cliente_fornecedor_produtoModel GetCliente_fornecedor_produto(int idClienteFornecedorProduto)
        {
            return _Cliente_fornecedor_produtoRepository.GetCliente_fornecedor_produto(idClienteFornecedorProduto);
        }

        public List<Cliente_fornecedor_produtoModel> GetAllCliente_fornecedor_produto(int idClienteFornecedor)
        {
            return _Cliente_fornecedor_produtoRepository.GetAllCliente_fornecedor_produto(idClienteFornecedor);
        }
    }
}
