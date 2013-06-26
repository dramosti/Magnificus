using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Comercial;

namespace HLP.Repository.Interfaces.Entries.Comercial
{
    public interface IProdutoRepository
    {
        List<ProdutoModel> GetByProdutoType(int idTipoProduto);
        ProdutoModel GetProduto(int idProduto);
        void Save(ProdutoModel produto);
        void Delete(ProdutoModel produto);
        void Copy(ProdutoModel produto);

        void BeginTransaction();
        void CommitTransaction();
        void RollackTransaction();
    }
}
