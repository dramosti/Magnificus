using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;
using HLP.Repository.Interfaces.Entries.Gerais;
using Ninject;
using HLP.Services.Interfaces.Entries.Gerais;

namespace HLP.Services.Implementation.Entries.Gerais
{
    public class Funcionario_Comissao_ProdutoService : IFuncionario_Comissao_ProdutoService
    {
        [Inject]
        public IFuncionario_Comissao_ProdutoRepository _Funcionario_Comissao_ProdutoRepository { get; set; }

        public void Save(Funcionario_Comissao_ProdutoModel objFuncionario_Comissao_Produto)
        {
            _Funcionario_Comissao_ProdutoRepository.Save(objFuncionario_Comissao_Produto);
        }

        public void Update(Funcionario_Comissao_ProdutoModel objFuncionario_Comissao_Produto)
        {
            _Funcionario_Comissao_ProdutoRepository.Update(objFuncionario_Comissao_Produto);
        }

        public void Delete(Funcionario_Comissao_ProdutoModel objFuncionario_Comissao_Produto)
        {
            _Funcionario_Comissao_ProdutoRepository.Delete(objFuncionario_Comissao_Produto);
        }

        public void Delete(int idFuncionario)
        {
            _Funcionario_Comissao_ProdutoRepository.Delete(idFuncionario);
        }

        public void Copy(Funcionario_Comissao_ProdutoModel objFuncionario_Comissao_Produto)
        {
            _Funcionario_Comissao_ProdutoRepository.Copy(objFuncionario_Comissao_Produto);
        }

        public Funcionario_Comissao_ProdutoModel GetFuncionario_Comissao_Produto(int idFuncionarioComissaoProduto)
        {
            return _Funcionario_Comissao_ProdutoRepository.GetFuncionario_Comissao_Produto(idFuncionarioComissaoProduto);
        }

        public List<Funcionario_Comissao_ProdutoModel> GetAllFuncionario_Comissao_Produto(int idFuncionario)
        {
            return _Funcionario_Comissao_ProdutoRepository.GetAllFuncionario_Comissao_Produto(idFuncionario);
        }
    }
}
