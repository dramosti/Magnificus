﻿using HLP.Comum.Infrastructure;
using HLP.Comum.Infrastructure.Static;
using HLP.Models.Entries.Gerais;
using HLP.Repository.Interfaces.Entries.Gerais;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLP.Repository.Implementation.Entries.Gerais
{
    public class Empresa_EnderecoRepository : IEmpresa_EnderecoRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Empresa_EnderecoModel> regAcessor;

        public void Save(Empresa_EnderecoModel objEmpresa_Endereco)
        {
            objEmpresa_Endereco.idEmpresaEndereco = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
           "[dbo].[Proc_save_Empresa_Endereco]",
            ParameterBase<Empresa_EnderecoModel>.SetParameterValue(objEmpresa_Endereco));

            objEmpresa_Endereco.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Update(Empresa_EnderecoModel objEmpresa_Endereco)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
            "[dbo].[Proc_update_Empresa_Endereco]",
            ParameterBase<Empresa_EnderecoModel>.SetParameterValue(objEmpresa_Endereco));

            objEmpresa_Endereco.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Delete(Empresa_EnderecoModel objEmpresa_Endereco)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar("[dbo].[Proc_delete_Empresa_Endereco]",
                  UserData.idUser,
                  objEmpresa_Endereco.idEmpresaEndereco);

            objEmpresa_Endereco.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Delete(int idEmpresa)
        {
            UndTrabalho.dbPrincipal.ExecuteNonQuery(System.Data.CommandType.Text,
              "DELETE Empresa_Endereco WHERE idEmpresa = " + idEmpresa);
        }

        public void Copy(Empresa_EnderecoModel objEmpresa_Endereco)
        {
            objEmpresa_Endereco.idEmpresaEndereco = null;
            objEmpresa_Endereco.idEmpresaEndereco = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                                           UndTrabalho.dbTransaction,
                                           "[dbo].[Proc_save_Empresa_Endereco]",
        ParameterBase<Empresa_EnderecoModel>.SetParameterValue(objEmpresa_Endereco));
        }

        public Empresa_EnderecoModel GetEmpresa_Endereco(int idEmpresaEndereco)
        {
            if (regAcessor == null)
            {
                regAcessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("[dbo].[Proc_sel_Empresa_Endereco]",
                   new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idEmpresaEndereco"),
                   MapBuilder<Empresa_EnderecoModel>.MapAllProperties().Build());
            }
            return regAcessor.Execute(idEmpresaEndereco).FirstOrDefault();
        }

        public List<Empresa_EnderecoModel> GetAllEmpresa_Endereco(int idEmpresa)
        {
            DataAccessor<Empresa_EnderecoModel> reg = UndTrabalho.dbPrincipal.CreateSqlStringAccessor
            ("SELECT * FROM Empresa_Endereco WHERE idEmpresa = @idEmpresa", new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idEmpresa"),
            MapBuilder<Empresa_EnderecoModel>.MapAllProperties().Build());

            return reg.Execute(idEmpresa).ToList();
        }
    }
}
