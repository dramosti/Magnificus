﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.Financeiro;
using HLP.Models.Entries.Financeiro;
using Ninject;
using HLP.Comum.Infrastructure;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Comum.Infrastructure.Static;


namespace HLP.Repository.Implementation.Entries.Financeiro
{
    public class Conta_bancariaRepository : IConta_bancariaRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Conta_bancariaModel> regContaAccessor;

        private DataAccessor<Conta_bancariaModel> regContaByAgenciaAccessor;

        public List<Conta_bancariaModel> GetByAgencia(int idAgencia)
        {
            if (regContaByAgenciaAccessor == null)
            {
                regContaByAgenciaAccessor = UndTrabalho.dbPrincipal.CreateSqlStringAccessor("SELECT * FROM Conta_bancaria WHERE idAgencia = @idAgencia",
                                  new Parameters(UndTrabalho.dbPrincipal)
                                    .AddParameter<int>("idAgencia"),
                                  MapBuilder<Conta_bancariaModel>.MapAllProperties().Build());
            }


            return regContaByAgenciaAccessor.Execute(idAgencia).ToList();
        }

        public Conta_bancariaModel GetConta(int idContaBancaria)
        {
            if (regContaAccessor == null)
            {
                regContaAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_conta_bancaria",
                                  new Parameters(UndTrabalho.dbPrincipal)
                                    .AddParameter<int>("idContaBancaria"),
                                  MapBuilder<Conta_bancariaModel>.MapAllProperties().Build());
            }
            return regContaAccessor.Execute(idContaBancaria).FirstOrDefault();
        }

        public void Save(Conta_bancariaModel conta)
        {
            if (conta.idContaBancaria == null)
            {

                int idContaBancaria = Convert.ToInt32((UndTrabalho.dbPrincipal.ExecuteScalar("dbo.Proc_save_conta_bancaria",
                 ParameterBase<Conta_bancariaModel>.SetParameterValue(conta))));

                conta.idContaBancaria = idContaBancaria;
            }
            else
            {
                UndTrabalho.dbPrincipal.ExecuteScalar("[dbo].[Proc_update_Conta_bancaria]",
                 ParameterBase<Conta_bancariaModel>.SetParameterValue(conta));
            }
        }

        public void Delete(int idContaBancaria)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar("dbo.Proc_delete_conta_bancaria",
                  UserData.idUser,
                  idContaBancaria);
        }


        public int Copy(int idContaBancaria)
        {
            return (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                        "dbo.Proc_copy_conta_bancaria",
                         idContaBancaria);
        }

        
    }
}
