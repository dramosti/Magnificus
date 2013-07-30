using System;
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
    public class Funcionario_EnderecoRepository : IFuncionario_EnderecoRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Funcionario_EnderecoModel> regAcessor;

        public void Save(Funcionario_EnderecoModel objFuncionario_Endereco)
        {
            objFuncionario_Endereco.idEndereco = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
           "[dbo].[Proc_save_Funcionario_Endereco]",
            ParameterBase<Funcionario_EnderecoModel>.SetParameterValue(objFuncionario_Endereco));

            objFuncionario_Endereco.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Update(Funcionario_EnderecoModel objFuncionario_Endereco)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
            "[dbo].[Proc_update_Funcionario_Endereco]",
            ParameterBase<Funcionario_EnderecoModel>.SetParameterValue(objFuncionario_Endereco));

            objFuncionario_Endereco.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Delete(Funcionario_EnderecoModel objFuncionario_Endereco)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar("[dbo].[Proc_delete_Funcionario_Endereco]",
                  UserData.idUser,
                  objFuncionario_Endereco.idEndereco);

            objFuncionario_Endereco.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Delete(int idFuncionario)
        {
            UndTrabalho.dbPrincipal.ExecuteNonQuery(System.Data.CommandType.Text,
              "DELETE Funcionario_Endereco WHERE idFuncionario = " + idFuncionario);
        }

        public void Copy(Funcionario_EnderecoModel objFuncionario_Endereco)
        {
            objFuncionario_Endereco.idEndereco = null;
            objFuncionario_Endereco.idEndereco = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                                           UndTrabalho.dbTransaction,
                                           "[dbo].[Proc_save_Funcionario_Endereco]",
        ParameterBase<Funcionario_EnderecoModel>.SetParameterValue(objFuncionario_Endereco));
        }

        public Funcionario_EnderecoModel GetFuncionario_Endereco(int idEndereco)
        {
            if (regAcessor == null)
            {
                regAcessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("[dbo].[Proc_sel_Funcionario_Endereco]",
                   new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idEndereco"),
                   MapBuilder<Funcionario_EnderecoModel>.MapAllProperties().Build());
            }
            return regAcessor.Execute(idEndereco).FirstOrDefault();
        }

        public List<Funcionario_EnderecoModel> GetAllFuncionario_Endereco(int idFuncionario)
        {
            DataAccessor<Funcionario_EnderecoModel> reg = UndTrabalho.dbPrincipal.CreateSqlStringAccessor
            ("SELECT * FROM Funcionario_Endereco WHERE idFuncionario = @idFuncionario", new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idFuncionario"),
            MapBuilder<Funcionario_EnderecoModel>.MapAllProperties().Build());

            return reg.Execute(idFuncionario).ToList();
        }
    }
}
