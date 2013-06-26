using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Comercial;

namespace HLP.Services.Interfaces.Entries.Comercial
{
    public interface IProdutoService
    {
        List<ProdutoModel> GetByProdutoType(int idTipoProduto);
        ProdutoModel GetProduto(int idProduto, bool bChildren = false);
        void Save(ProdutoModel produto);
        void Delete(ProdutoModel produto);
        void Copy(ProdutoModel produto);
    }
}
