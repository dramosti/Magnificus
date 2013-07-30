using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.Comercial;
using HLP.Models.Entries.Comercial;
using Ninject;
using HLP.Comum.Infrastructure;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Comum.Infrastructure.Static;


namespace HLP.Repository.Implementation.Entries.Comercial
{
    public class Produto_localizacaoRepository : IProduto_localizacaoRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Produto_localizacaoModel> regCanalAccessor;

        public Produto_localizacaoModel GetLocalizacao(int idProdutoLocalizacao)
        {
            if (regCanalAccessor == null)
            {
                regCanalAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_produto_localizacao",
                                    new Parameters(UndTrabalho.dbPrincipal)
                                    .AddParameter<int>("idProdutoLocalizacao"),
                                    MapBuilder<Produto_localizacaoModel>.MapAllProperties().Build());
            }
            return regCanalAccessor.Execute(idProdutoLocalizacao).FirstOrDefault();
        }

        public void Save(Produto_localizacaoModel localizacao)
        {
            if (localizacao.idProdutoLocalizacao == null)
            {
                int idProdutoLocalizacao = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
              "dbo.Proc_save_produto_localizacao",
             ParameterBase<Produto_localizacaoModel>.SetParameterValue(localizacao));

                localizacao.idProdutoLocalizacao = idProdutoLocalizacao;
            }
            else
            {
                UndTrabalho.dbPrincipal.ExecuteScalar(
              "[dbo].[Proc_update_Produto_localizacao]",
             ParameterBase<Produto_localizacaoModel>.SetParameterValue(localizacao));
            }
            
        }

        public void Delete(int idProdutoLocalizacao)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
                      "dbo.Proc_delete_produto_localizacao",
                       UserData.idUser,
                       idProdutoLocalizacao);
        }

        public int Copy(int idProdutoLocalizacao)
        {
            return (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                       "dbo.Proc_copy_produto_localizacao",
                        idProdutoLocalizacao);
        }
    }
}
