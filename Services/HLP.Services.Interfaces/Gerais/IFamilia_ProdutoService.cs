using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;

namespace HLP.Services.Interfaces.Entries.Gerais
{
    public interface IFamilia_ProdutoService
    {
        Familia_produtoModel GetFamilia_produto(int idfamilia_produto, bool bChildren);
        void Save(Familia_produtoModel familia_produto);
        void Delete(Familia_produtoModel familia_produto);
        void Copy(Familia_produtoModel familia_produto);
    }
}
