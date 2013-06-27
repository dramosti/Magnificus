using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Comercial;
using HLP.Models.Entries.Comercial;
using HLP.Repository.Interfaces.Entries.Comercial;
using Ninject;
using HLP.Comum.Infrastructure;

namespace HLP.Services.Implementation.Entries.Comercial
{
    public class ProdutoService : IProdutoService
    {
        [Inject]
        public IProdutoRepository produtoRepository { get; set; }

        [Inject]
        public IProduto_Fornecedor_HomologadoRepository prodFornHomRepository { get; set; }

        [Inject]
        public IProduto_RevisaoRepository produtoRevisaoRepository { get; set; }


        public List<ProdutoModel> GetByProdutoType(int idTipoProduto)
        {
            return produtoRepository.GetByProdutoType(idTipoProduto);
        }

        public ProdutoModel GetProduto(int idProduto, bool bChildren = false)
        {
            ProdutoModel produto = produtoRepository.GetProduto(idProduto);

            if (bChildren)
            {
                produto.lProduto_Fornecedor_Homologado = prodFornHomRepository.GetAllProdForncHom(idProduto);
                produto.lProduto_Revisao = produtoRevisaoRepository.GetAllProdutoRevisao(idProduto);
            }

            return produto;
        }

        public void Save(ProdutoModel produto)
        {
            try
            {
                produtoRepository.BeginTransaction();
                produtoRepository.Save(produto);

                #region Produto_Fornecedor_HomologadoModel
                foreach (Produto_Fornecedor_HomologadoModel prodFornHom in produto.lProduto_Fornecedor_Homologado.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Incluido))
                {
                    prodFornHom.idProduto = (int)produto.idProduto;
                    prodFornHom.idEmpresa = (int)produto.idEmpresa; //Empresa logada?
                    prodFornHomRepository.Save(prodFornHom);
                }
                foreach (Produto_Fornecedor_HomologadoModel prodFornHom in produto.lProduto_Fornecedor_Homologado.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Alterado))
                {
                    prodFornHomRepository.Update(prodFornHom);
                }
                foreach (Produto_Fornecedor_HomologadoModel prodFornHom in produto.lProduto_Fornecedor_Homologado.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Excluido))
                {
                    prodFornHomRepository.Delete(prodFornHom);
                }
                #endregion

                #region Produto_RevisaoModel
                foreach (Produto_RevisaoModel prodRevisao in produto.lProduto_Revisao.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Incluido))
                {
                    prodRevisao.idProduto = (int)produto.idProduto;
                    prodRevisao.idUsuario = (int)produto.idFuncionario;
                    produtoRevisaoRepository.Save(prodRevisao);
                }
                foreach (Produto_RevisaoModel prodRevisao in produto.lProduto_Revisao.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Alterado))
                {
                    produtoRevisaoRepository.Update(prodRevisao);
                }
                foreach (Produto_RevisaoModel prodRevisao in produto.lProduto_Revisao.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Excluido))
                {
                    produtoRevisaoRepository.Delete(prodRevisao);
                }
                #endregion

                produtoRepository.CommitTransaction();

            }
            catch (Exception)
            {
                produtoRepository.RollackTransaction();
                throw;
            }
        }

        public void Delete(ProdutoModel produto)
        {
            try
            {

                produtoRepository.BeginTransaction();

                //Deleta Filho
                prodFornHomRepository.Delete((int)produto.idProduto);

                //Deleta Filho
                produtoRevisaoRepository.Delete((int)produto.idProduto);

                produtoRepository.Delete(produto);
                produtoRepository.CommitTransaction();

            }
            catch (Exception)
            {
                produtoRepository.RollackTransaction();
                throw;
            }
        }

        public void Copy(ProdutoModel produto)
        {
            try
            {

                produtoRepository.BeginTransaction();
                produtoRepository.Copy(produto);

                foreach (Produto_Fornecedor_HomologadoModel prodFornHom in produto.lProduto_Fornecedor_Homologado)
                {
                    prodFornHom.idProduto = (int)produto.idProduto;
                    prodFornHomRepository.Copy(prodFornHom);
                }
                foreach (Produto_RevisaoModel prodRevisao in produto.lProduto_Revisao)
                {
                    prodRevisao.idProduto = (int)produto.idProduto;
                    produtoRevisaoRepository.Copy(prodRevisao);
                }

                produtoRepository.CommitTransaction();
            }
            catch (Exception)
            {
                produtoRepository.RollackTransaction();
                throw;
            }
        }
    }
}
