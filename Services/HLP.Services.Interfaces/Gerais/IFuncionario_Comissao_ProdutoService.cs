using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;

namespace HLP.Services.Interfaces.Entries.Gerais
{
    public interface IFuncionario_Comissao_ProdutoService
    {
        void Save(Funcionario_Comissao_ProdutoModel objFuncionario_Comissao_Produto);
        void Update(Funcionario_Comissao_ProdutoModel objFuncionario_Comissao_Produto);
        void Delete(Funcionario_Comissao_ProdutoModel objFuncionario_Comissao_Produto);
        void Delete(int idFuncionario);
        void Copy(Funcionario_Comissao_ProdutoModel objFuncionario_Comissao_Produto);
        Funcionario_Comissao_ProdutoModel GetFuncionario_Comissao_Produto(int idFuncionarioComissaoProduto);
        List<Funcionario_Comissao_ProdutoModel> GetAllFuncionario_Comissao_Produto(int idFuncionario);
    }
}
