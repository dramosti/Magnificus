﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.Gerais;
using Ninject;
using HLP.Comum.Infrastructure;
using HLP.Models.Entries.Gerais;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Models.Entries.Comercial;
using HLP.Comum.Infrastructure.Static;


namespace HLP.Repository.Implementation.Entries.Gerais
{
    public class EmpresaRepository : IEmpresaRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<EmpresaModel> regEmpresaAccessor;
        private DataAccessor<EmpresaModel> regAllEmpresaAccessor;

        public void Save(EmpresaModel objEmpresa)
        {
            if(objEmpresa.idEmpresa == null)
            {
                objEmpresa.idEmpresa = (int)UndTrabalho.dbPrincipal.ExecuteScalar("dbo.Proc_save_Empresa",
            ParameterBase<EmpresaModel>.SetParameterValue(objEmpresa));
            }
            else
            {
                UndTrabalho.dbPrincipal.ExecuteScalar("dbo.Proc_update_Empresa",
            ParameterBase<EmpresaModel>.SetParameterValue(objEmpresa));
            }
            
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

        public void Delete(int idEmpresa)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar("dbo.Proc_delete_Empresa",
                 UserData.idUser,
                 idEmpresa);
        }

        public int Copy(EmpresaModel objModel)
        {
            objModel.idEmpresa =  (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                      "dbo.Proc_copy_Empresa",
                       objModel.idEmpresa);
            return objModel.idEmpresa.Value;
        }

        public EmpresaModel GetEmpresa(int idEmpresa)
        {
            if (regEmpresaAccessor == null)
            {
                regEmpresaAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_Empresa",
                                 new Parameters(UndTrabalho.dbPrincipal)
                                 .AddParameter<int>("idEmpresa"),
                                 MapBuilder<EmpresaModel>.MapAllProperties().Build());
            }

            return regEmpresaAccessor.Execute(idEmpresa).FirstOrDefault();
        }

        public List<EmpresaModel> GetAllEmpresa()
        {
            if (regAllEmpresaAccessor == null)
            {
                regAllEmpresaAccessor = UndTrabalho.dbPrincipal.CreateSqlStringAccessor("SELECT * FROM Empresa",
                                MapBuilder<EmpresaModel>.MapAllProperties().Build());
            }
            return regAllEmpresaAccessor.Execute().ToList();
        }
    }
}
