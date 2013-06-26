using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Comercial;
using HLP.Models.Entries.Comercial;
using Ninject;
using HLP.Repository.Interfaces.Entries.Comercial;

namespace HLP.Services.Implementation.Entries.Comercial
{
    public class Produto_Fornecedor_HomologadoService : IProduto_Fornecedor_HomologadoService
    {
        [Inject]
        public IProduto_Fornecedor_HomologadoRepository ProdFornHomRepository { get; set; }

        public void Save(Produto_Fornecedor_HomologadoModel produtoFornHom)
        {
            ProdFornHomRepository.Save(produtoFornHom);
        }

        public void Update(Produto_Fornecedor_HomologadoModel produtoFornHom)
        {
            ProdFornHomRepository.Update(produtoFornHom);
        }

        public void Delete(Produto_Fornecedor_HomologadoModel produtoFornHom)
        {
            ProdFornHomRepository.Delete(produtoFornHom);
        }

        public void Delete(int idProduto)
        {
            ProdFornHomRepository.Delete(idProduto);
        }

        public void Copy(Produto_Fornecedor_HomologadoModel produtoFornHom)
        {
            ProdFornHomRepository.Copy(produtoFornHom);
        }

        public Produto_Fornecedor_HomologadoModel GetProdForncHom(int idProdutoFornecedorHomologado)
        {
            return ProdFornHomRepository.GetProdForncHom(idProdutoFornecedorHomologado);
        }

        public List<Produto_Fornecedor_HomologadoModel> GetAllProdForncHom(int idProduto)
        {
            return ProdFornHomRepository.GetAllProdForncHom(idProduto);
        }
    }
}
