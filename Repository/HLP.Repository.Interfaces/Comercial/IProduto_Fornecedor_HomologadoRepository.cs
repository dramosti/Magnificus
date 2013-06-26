using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Comercial;

namespace HLP.Repository.Interfaces.Entries.Comercial
{
    public interface IProduto_Fornecedor_HomologadoRepository
    {
        void Save(Produto_Fornecedor_HomologadoModel produtoFornHom);

        void Update(Produto_Fornecedor_HomologadoModel produtoFornHom);

        void Delete(Produto_Fornecedor_HomologadoModel produtoFornHom);

        void Delete(int idProduto);

        void Copy(Produto_Fornecedor_HomologadoModel produtoFornHom);

        Produto_Fornecedor_HomologadoModel GetProdForncHom(int idProdutoFornecedorHomologado);

        List<Produto_Fornecedor_HomologadoModel> GetAllProdForncHom(int idProduto);
    }
}
