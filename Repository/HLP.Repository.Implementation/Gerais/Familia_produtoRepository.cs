using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.Gerais;
using Ninject;
using HLP.Comum.Infrastructure;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Models.Entries.Gerais;
using HLP.Comum.Models.Static;
using System.Data;

namespace HLP.Repository.Implementation.Entries.Gerais
{
    public class Familia_produtoRepository : IFamilia_ProdutoRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Familia_produtoModel> regFamiliaProdAccessor;



        public Familia_produtoModel GetFamilia_produto(int idFamiliaProduto)
        {
            Familia_produtoModel familia;
            if (regFamiliaProdAccessor == null)
            {
                regFamiliaProdAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_familia_produto",
                                    new Parameters(UndTrabalho.dbPrincipal)
                                    .AddParameter<int>("idFamiliaProduto"),
                                    MapBuilder<Familia_produtoModel>.MapAllProperties().Build());
            }
            familia = regFamiliaProdAccessor.Execute(idFamiliaProduto).FirstOrDefault();
            return familia;
        }
        public void Save(Models.Entries.Gerais.Familia_produtoModel familia_produto)
        {
            try
            {

                if (familia_produto.idFamiliaProduto == null)
                {
                    familia_produto.idFamiliaProduto = (int)UndTrabalho.dbPrincipal.ExecuteScalar(UndTrabalho.dbTransaction,
                                        "dbo.Proc_save_familia_produto",
                                         ParameterBase<Familia_produtoModel>.SetParameterValue(familia_produto));
                }
                else
                {
                    familia_produto.idFamiliaProduto = (int)UndTrabalho.dbPrincipal.ExecuteScalar(UndTrabalho.dbTransaction,
                                          "dbo.Proc_update_Familia_produto",
                                           ParameterBase<Familia_produtoModel>.SetParameterValue(familia_produto));
                }
            }
            catch (Exception ex)
            {
                UndTrabalho.RollBackTransaction();
                throw ex;
            }
        }
        public int Copy(Familia_produtoModel familia_produto)
        {
            try
            {
                familia_produto.idFamiliaProduto = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                    UndTrabalho.dbTransaction,
                           "dbo.Proc_copy_familia_produto",
                            familia_produto.idFamiliaProduto);
                return familia_produto.idFamiliaProduto.ToInt32();

            }
            catch (Exception)
            {
                throw;
            }

        }
        public void Delete(int idFamiliaProduto)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(UndTrabalho.dbTransaction, "dbo.Proc_delete_Familia_produto",
                 UserData.idUser,
                 idFamiliaProduto);
        }



        public void BeginTransaction()
        {
            UndTrabalho.BeginTransaction();
        }
        public void CommitTransaction()
        {
            UndTrabalho.CommitTransaction();
        }
        public void RollackTransaction()
        {
            UndTrabalho.RollBackTransaction();
        }
    }
}
