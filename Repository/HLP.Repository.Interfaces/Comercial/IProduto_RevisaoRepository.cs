using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Comercial;

namespace HLP.Repository.Interfaces.Entries.Comercial
{
    public interface IProduto_RevisaoRepository
    {
        void Save(Produto_RevisaoModel produtoRevisao);

        void Update(Produto_RevisaoModel produtoRevisao);

        void Delete(Produto_RevisaoModel produtoRevisao);

        void Delete(int idProduto);

        void Copy(Produto_RevisaoModel produtoRevisao);

        Produto_RevisaoModel GetProdutoRevisao(int idProdutoRevisao);

        List<Produto_RevisaoModel> GetAllProdutoRevisao(int idProduto);
    }
}
