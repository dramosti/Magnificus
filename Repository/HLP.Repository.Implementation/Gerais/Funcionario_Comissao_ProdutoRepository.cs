﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using HLP.Comum.Infrastructure;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Models.Entries.Gerais;

using HLP.Repository.Interfaces.Entries.Gerais;
using HLP.Comum.Infrastructure.Static;

namespace HLP.Repository.Implementation.Entries.Gerais
{
    public class Funcionario_Comissao_ProdutoRepository : IFuncionario_Comissao_ProdutoRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Funcionario_Comissao_ProdutoModel> regAcessor;

        public void Save(Funcionario_Comissao_ProdutoModel objFuncionario_Comissao_Produto)
        {
            objFuncionario_Comissao_Produto.idFuncionarioComissaoProduto = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
           "[dbo].[Proc_save_Funcionario_Comissao_Produto]",
            ParameterBase<Funcionario_Comissao_ProdutoModel>.SetParameterValue(objFuncionario_Comissao_Produto));

            objFuncionario_Comissao_Produto.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Update(Funcionario_Comissao_ProdutoModel objFuncionario_Comissao_Produto)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
            "[dbo].[Proc_update_Funcionario_Comissao_Produto]",
            ParameterBase<Funcionario_Comissao_ProdutoModel>.SetParameterValue(objFuncionario_Comissao_Produto));

            objFuncionario_Comissao_Produto.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Delete(Funcionario_Comissao_ProdutoModel objFuncionario_Comissao_Produto)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar("[dbo].[Proc_delete_Funcionario_Comissao_Produto]",
                  UserData.idUser,
                  objFuncionario_Comissao_Produto.idFuncionarioComissaoProduto);

            objFuncionario_Comissao_Produto.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Delete(int idFuncionario)
        {
            UndTrabalho.dbPrincipal.ExecuteNonQuery(System.Data.CommandType.Text,
              "DELETE Funcionario_Comissao_Produto WHERE idFuncionario = " + idFuncionario);
        }

        public void Copy(Funcionario_Comissao_ProdutoModel objFuncionario_Comissao_Produto)
        {
            objFuncionario_Comissao_Produto.idFuncionarioComissaoProduto = null;
            objFuncionario_Comissao_Produto.idFuncionarioComissaoProduto = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                                           UndTrabalho.dbTransaction,
                                           "[dbo].[Proc_save_Funcionario_Comissao_Produto]",
        ParameterBase<Funcionario_Comissao_ProdutoModel>.SetParameterValue(objFuncionario_Comissao_Produto));
        }

        public Funcionario_Comissao_ProdutoModel GetFuncionario_Comissao_Produto(int idFuncionarioComissaoProduto)
        {
            if (regAcessor == null)
            {
                regAcessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("[dbo].[Proc_sel_Funcionario_Comissao_Produto]",
                   new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idFuncionarioComissaoProduto"),
                   MapBuilder<Funcionario_Comissao_ProdutoModel>.MapAllProperties().Build());
            }
            return regAcessor.Execute(idFuncionarioComissaoProduto).FirstOrDefault();
        }

        public List<Funcionario_Comissao_ProdutoModel> GetAllFuncionario_Comissao_Produto(int idFuncionario)
        {
            DataAccessor<Funcionario_Comissao_ProdutoModel> reg = UndTrabalho.dbPrincipal.CreateSqlStringAccessor
            ("SELECT * FROM Funcionario_Comissao_Produto WHERE idFuncionario = @idFuncionario", new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idFuncionario"),
            MapBuilder<Funcionario_Comissao_ProdutoModel>.MapAllProperties().Build());

            return reg.Execute(idFuncionario).ToList();
        }
    }
}
