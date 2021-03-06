﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;
using HLP.Models.Entries.Gerais;

using Ninject;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Repository.Interfaces.Entries.Gerais;
using HLP.Comum.Infrastructure.Static;

namespace HLP.Repository.Implementation.Entries.Gerais
{
    public class Funcionario_ArquivoRepository : IFuncionario_ArquivoRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Funcionario_ArquivoModel> regAcessor;

        public void Save(Funcionario_ArquivoModel objFuncionario_Arquivo)
        {
            objFuncionario_Arquivo.idFuncionarioArquivo = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
           "[dbo].[Proc_save_Funcionario_Arquivo]",
            ParameterBase<Funcionario_ArquivoModel>.SetParameterValue(objFuncionario_Arquivo));

            objFuncionario_Arquivo.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Update(Funcionario_ArquivoModel objFuncionario_Arquivo)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
            "[dbo].[Proc_update_Funcionario_Arquivo]",
            ParameterBase<Funcionario_ArquivoModel>.SetParameterValue(objFuncionario_Arquivo));

            objFuncionario_Arquivo.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Delete(Funcionario_ArquivoModel objFuncionario_Arquivo)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar("[dbo].[Proc_delete_Funcionario_Arquivo]",
                  UserData.idUser,
                  objFuncionario_Arquivo.idFuncionarioArquivo);

            objFuncionario_Arquivo.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Delete(int idFuncionario)
        {
            UndTrabalho.dbPrincipal.ExecuteNonQuery(System.Data.CommandType.Text,
              "DELETE Funcionario_Arquivo WHERE idFuncionario = " + idFuncionario);
        }

        public void Copy(Funcionario_ArquivoModel objFuncionario_Arquivo)
        {
            objFuncionario_Arquivo.idFuncionarioArquivo = null;
            objFuncionario_Arquivo.idFuncionarioArquivo = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                                           UndTrabalho.dbTransaction,
                                           "[dbo].[Proc_save_Funcionario_Arquivo]",
        ParameterBase<Funcionario_ArquivoModel>.SetParameterValue(objFuncionario_Arquivo));
        }

        public Funcionario_ArquivoModel GetFuncionario_Arquivo(int idFuncionarioArquivo)
        {
            if (regAcessor == null)
            {
                regAcessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("[dbo].[Proc_sel_Funcionario_Arquivo]",
                   new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idFuncionarioArquivo"),
                   MapBuilder<Funcionario_ArquivoModel>.MapAllProperties().Build());
            }
            return regAcessor.Execute(idFuncionarioArquivo).FirstOrDefault();
        }

        public List<Funcionario_ArquivoModel> GetAllFuncionario_Arquivo(int idFuncionario)
        {
            DataAccessor<Funcionario_ArquivoModel> reg = UndTrabalho.dbPrincipal.CreateSqlStringAccessor
            ("SELECT * FROM Funcionario_Arquivo WHERE idFuncionario = @idFuncionario", new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idFuncionario"),
            MapBuilder<Funcionario_ArquivoModel>.MapAllProperties().Build());

            return reg.Execute(idFuncionario).ToList();
        }
    }
}
