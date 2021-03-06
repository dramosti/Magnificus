﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Comum.Infrastructure;
using Ninject;

using HLP.Repository.Interfaces.Entries.Gerais;
using HLP.Comum.Infrastructure.Static;

namespace HLP.Repository.Implementation.Entries.Gerais
{
    public class Funcionario_Margem_LucroComissaoRepository : IFuncionario_Margem_Lucro_ComissaoRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Funcionario_Margem_Lucro_ComissaoModel> regAcessor;

        public void Save(Funcionario_Margem_Lucro_ComissaoModel objFuncionario_Margem_Lucro_Comissao)
        {
            objFuncionario_Margem_Lucro_Comissao.idFuncionarioMargemLucroComissao = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
           "[dbo].[Proc_save_Funcionario_Margem_Lucro_Comissao]",
            ParameterBase<Funcionario_Margem_Lucro_ComissaoModel>.SetParameterValue(objFuncionario_Margem_Lucro_Comissao));

            objFuncionario_Margem_Lucro_Comissao.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Update(Funcionario_Margem_Lucro_ComissaoModel objFuncionario_Margem_Lucro_Comissao)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
            "[dbo].[Proc_update_Funcionario_Margem_Lucro_Comissao]",
            ParameterBase<Funcionario_Margem_Lucro_ComissaoModel>.SetParameterValue(objFuncionario_Margem_Lucro_Comissao));

            objFuncionario_Margem_Lucro_Comissao.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Delete(Funcionario_Margem_Lucro_ComissaoModel objFuncionario_Margem_Lucro_Comissao)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar("[dbo].[Proc_delete_Funcionario_Margem_Lucro_Comissao]",
                  UserData.idUser,
                  objFuncionario_Margem_Lucro_Comissao.idFuncionarioMargemLucroComissao);

            objFuncionario_Margem_Lucro_Comissao.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Delete(int idFuncionario)
        {
            UndTrabalho.dbPrincipal.ExecuteNonQuery(System.Data.CommandType.Text,
              "DELETE Funcionario_Margem_Lucro_Comissao WHERE idFuncionario = " + idFuncionario);
        }

        public void Copy(Funcionario_Margem_Lucro_ComissaoModel objFuncionario_Margem_Lucro_Comissao)
        {
            objFuncionario_Margem_Lucro_Comissao.idFuncionarioMargemLucroComissao = null;
            objFuncionario_Margem_Lucro_Comissao.idFuncionarioMargemLucroComissao = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                                           UndTrabalho.dbTransaction,
                                           "[dbo].[Proc_save_Funcionario_Margem_Lucro_Comissao]",
        ParameterBase<Funcionario_Margem_Lucro_ComissaoModel>.SetParameterValue(objFuncionario_Margem_Lucro_Comissao));
        }

        public Funcionario_Margem_Lucro_ComissaoModel GetFuncionario_Margem_Lucro_Comissao(int idFuncionarioMargemLucroComissao)
        {
            if (regAcessor == null)
            {
                regAcessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("[dbo].[Proc_sel_Funcionario_Margem_Lucro_Comissao]",
                   new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idFuncionarioMargemLucroComissao"),
                   MapBuilder<Funcionario_Margem_Lucro_ComissaoModel>.MapAllProperties().Build());
            }
            return regAcessor.Execute(idFuncionarioMargemLucroComissao).FirstOrDefault();
        }

        public List<Funcionario_Margem_Lucro_ComissaoModel> GetAllFuncionario_Margem_Lucro_Comissao(int idFuncionario)
        {
            DataAccessor<Funcionario_Margem_Lucro_ComissaoModel> reg = UndTrabalho.dbPrincipal.CreateSqlStringAccessor
            ("SELECT * FROM Funcionario_Margem_Lucro_Comissao WHERE idFuncionario = @idFuncionario", new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idFuncionario"),
            MapBuilder<Funcionario_Margem_Lucro_ComissaoModel>.MapAllProperties().Build());

            return reg.Execute(idFuncionario).ToList();
        }
    }
}
