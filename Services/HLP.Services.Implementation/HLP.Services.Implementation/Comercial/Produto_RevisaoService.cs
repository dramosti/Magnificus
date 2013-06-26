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
    public class Produto_RevisaoService : IProduto_RevisaoService
    {
        [Inject]
        public IProduto_RevisaoRepository produtoRevisaoRepository { get; set; }


        public void Save(Produto_RevisaoModel produtoRevisao)
        {
            produtoRevisaoRepository.Save(produtoRevisao);
        }

        public void Update(Produto_RevisaoModel produtoRevisao)
        {
            produtoRevisaoRepository.Update(produtoRevisao);
        }

        public void Delete(Produto_RevisaoModel produtoRevisao)
        {
            produtoRevisaoRepository.Delete(produtoRevisao);
        }

        public void Delete(int idProduto)
        {
            produtoRevisaoRepository.Delete(idProduto);
        }

        public void Copy(Produto_RevisaoModel produtoRevisao)
        {
            produtoRevisaoRepository.Copy(produtoRevisao);
        }

        public Produto_RevisaoModel GetProdutoRevisao(int idProdutoRevisao)
        {
            return produtoRevisaoRepository.GetProdutoRevisao(idProdutoRevisao);
        }

        public List<Produto_RevisaoModel> GetAllProdutoRevisao(int idProduto)
        {
            return produtoRevisaoRepository.GetAllProdutoRevisao(idProduto);
        }

    }
}
