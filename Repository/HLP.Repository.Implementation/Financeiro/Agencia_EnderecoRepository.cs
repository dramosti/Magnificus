using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.Financeiro;
using Ninject;
using HLP.Comum.Infrastructure;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Models.Entries.Financeiro;

using System.Data.Common;
using System.Data;
using HLP.Comum.Infrastructure.Static;

namespace HLP.Repository.Implementation.Entries.Financeiro
{
    public class Agencia_EnderecoRepository : IAgencia_EnderecoRepository
    {

        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Agencia_EnderecoModel> regAcessor;

        public void Save(Agencia_EnderecoModel objAgencia_Endereco)
        {
            objAgencia_Endereco.idEndereco = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
           "[dbo].[Proc_save_Agencia_Endereco]",
            ParameterBase<Agencia_EnderecoModel>.SetParameterValue(objAgencia_Endereco));

            objAgencia_Endereco.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Update(Agencia_EnderecoModel objAgencia_Endereco)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
            "[dbo].[Proc_update_Agencia_Endereco]",
            ParameterBase<Agencia_EnderecoModel>.SetParameterValue(objAgencia_Endereco));

            objAgencia_Endereco.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Delete(Agencia_EnderecoModel objAgencia_Endereco)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar("[dbo].[Proc_delete_Agencia_Endereco]",
                  UserData.idUser,
                  objAgencia_Endereco.idEndereco);

            objAgencia_Endereco.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Delete(int idAgencia)
        {
            UndTrabalho.dbPrincipal.ExecuteNonQuery(System.Data.CommandType.Text,
              "DELETE Agencia_Endereco WHERE idAgencia = " + idAgencia);
        }

        public void Copy(Agencia_EnderecoModel objAgencia_Endereco)
        {
            objAgencia_Endereco.idEndereco = null;
            objAgencia_Endereco.idEndereco = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                                           UndTrabalho.dbTransaction,
                                           "[dbo].[Proc_save_Agencia_Endereco]",
        ParameterBase<Agencia_EnderecoModel>.SetParameterValue(objAgencia_Endereco));
        }

        public Agencia_EnderecoModel GetAgencia_Endereco(int idEndereco)
        {
            if (regAcessor == null)
            {
                regAcessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("[dbo].[Proc_sel_Agencia_Endereco]",
                   new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idEndereco"),
                   MapBuilder<Agencia_EnderecoModel>.MapAllProperties().Build());
            }
            return regAcessor.Execute(idEndereco).FirstOrDefault();
        }

        public List<Agencia_EnderecoModel> GetAllAgencia_Endereco(int idAgencia)
        {
            DataAccessor<Agencia_EnderecoModel> reg = UndTrabalho.dbPrincipal.CreateSqlStringAccessor
            ("SELECT * FROM Agencia_Endereco WHERE idAgencia = @idAgencia", new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idAgencia"),
            MapBuilder<Agencia_EnderecoModel>.MapAllProperties().Build());

            return reg.Execute(idAgencia).ToList();
        }

    }
}
