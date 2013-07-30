using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Gerais;
using Ninject;
using HLP.Repository.Interfaces.Entries.Gerais;
using HLP.Models.Entries.Gerais;
using HLP.Comum.Infrastructure.Static;
namespace HLP.Services.Implementation.Entries.Gerais
{
    public class Familia_produtoService : IFamilia_ProdutoService
    {

        [Inject]
        public IFamilia_ProdutoRepository ifamiliaProdutoRepository { get; set; }
        [Inject]
        public IFamilia_Produto_ClassesService ifamiliaProdutoService { get; set; }


        public Familia_produtoModel GetFamilia_produto(int idfamilia_produto, bool bChildren)
        {
            Familia_produtoModel objfamiliaProdModel =  ifamiliaProdutoRepository.GetFamilia_produto(idfamilia_produto);

            if (bChildren)
            {
                objfamiliaProdModel.lFamilia_Produto_Classe = ifamiliaProdutoService.GetAllFamilia_Produto_Classes(objfamiliaProdModel.idFamiliaProduto.ToInt32());                
            }

            return objfamiliaProdModel;
        }

        public void Save(Familia_produtoModel familia_produto)
        {
            ifamiliaProdutoRepository.BeginTransaction();
            try
            {
                ifamiliaProdutoRepository.Save(familia_produto);
                foreach (Familia_Produto_ClassesModel item in familia_produto.lFamilia_Produto_Classe.Where(c => c.GetStatusRegistro() == Comum.Infrastructure.BaseModelFilhos.statusRegistroFilho.Incluido))
                {
                    item.idFamiliaProduto = familia_produto.idFamiliaProduto.ToInt32();
                    ifamiliaProdutoService.Save(item);
                }
                foreach (Familia_Produto_ClassesModel item in familia_produto.lFamilia_Produto_Classe.Where(c => c.GetStatusRegistro() == Comum.Infrastructure.BaseModelFilhos.statusRegistroFilho.Alterado))
                {
                    ifamiliaProdutoService.Update(item);
                }
                foreach (Familia_Produto_ClassesModel item in familia_produto.lFamilia_Produto_Classe.Where(c => c.GetStatusRegistro() == Comum.Infrastructure.BaseModelFilhos.statusRegistroFilho.Excluido))
                {
                    ifamiliaProdutoService.Delete(Convert.ToInt32(item.idFamilia_Produto_Classes));
                }
                ifamiliaProdutoRepository.CommitTransaction();

            }
            catch (Exception ex)
            {
                ifamiliaProdutoRepository.RollackTransaction();
                throw ex;
            }


        }

        public void Delete(Familia_produtoModel familia_produto)
        {
            try
            {
                ifamiliaProdutoRepository.BeginTransaction();

                foreach (Familia_Produto_ClassesModel item in familia_produto.lFamilia_Produto_Classe)
                {
                    ifamiliaProdutoService.Delete(item.idFamilia_Produto_Classes.ToInt32());
                }
                ifamiliaProdutoRepository.Delete(familia_produto.idFamiliaProduto.ToInt32());
                ifamiliaProdutoRepository.CommitTransaction();
            }
            catch (Exception ex)
            {
                ifamiliaProdutoRepository.RollackTransaction();
                throw ex;
            }
        }

        public void Copy(Familia_produtoModel familia_produto)
        {
            try
            {
                ifamiliaProdutoRepository.BeginTransaction();
                ifamiliaProdutoRepository.Copy(familia_produto);
                foreach (Familia_Produto_ClassesModel item in familia_produto.lFamilia_Produto_Classe)
                {
                    item.idFamiliaProduto = familia_produto.idFamiliaProduto.ToInt32();
                    ifamiliaProdutoService.Copy(item);
                }
                ifamiliaProdutoRepository.CommitTransaction();
            }
            catch (Exception ex)
            {
                ifamiliaProdutoRepository.RollackTransaction();
                throw;
            }
        }

    }
}
