using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Models.Entries.Gerais;
using HLP.Comum.Infrastructure;

using Ninject;
using HLP.Repository.Interfaces.Entries.Gerais;
using HLP.Comum.Infrastructure.Static;

namespace HLP.Repository.Implementation.Entries.Gerais
{
    public class Contato_EnderecoRepository : IContato_EnderecoRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Contato_EnderecoModel> regAcessor;

        public void Save(Contato_EnderecoModel objContato_Endereco)
        {
            objContato_Endereco.idEndereco = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
           "[dbo].[Proc_save_Contato_Endereco]",
            ParameterBase<Contato_EnderecoModel>.SetParameterValue(objContato_Endereco));

            objContato_Endereco.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Update(Contato_EnderecoModel objContato_Endereco)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
            "[dbo].[Proc_update_Contato_Endereco]",
            ParameterBase<Contato_EnderecoModel>.SetParameterValue(objContato_Endereco));

            objContato_Endereco.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Delete(Contato_EnderecoModel objContato_Endereco)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar("[dbo].[Proc_delete_Contato_Endereco]",
                  UserData.idUser,
                  objContato_Endereco.idEndereco);

            objContato_Endereco.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Delete(int idContato)
        {
            UndTrabalho.dbPrincipal.ExecuteNonQuery(System.Data.CommandType.Text,
              "DELETE Contato_Endereco WHERE idContato = " + idContato);
        }

        public void Copy(Contato_EnderecoModel objContato_Endereco)
        {
            objContato_Endereco.idEndereco = null;
            objContato_Endereco.idEndereco = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                                           UndTrabalho.dbTransaction,
                                           "[dbo].[Proc_save_Contato_Endereco]",
        ParameterBase<Contato_EnderecoModel>.SetParameterValue(objContato_Endereco));
        }

        public Contato_EnderecoModel GetContato_Endereco(int idEndereco)
        {
            if (regAcessor == null)
            {
                regAcessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("[dbo].[Proc_sel_Contato_Endereco]",
                   new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idEndereco"),
                   MapBuilder<Contato_EnderecoModel>.MapAllProperties().Build());
            }
            return regAcessor.Execute(idEndereco).FirstOrDefault();
        }

        public List<Contato_EnderecoModel> GetAllContato_Endereco(int idContato)
        {
            DataAccessor<Contato_EnderecoModel> reg = UndTrabalho.dbPrincipal.CreateSqlStringAccessor
            ("SELECT * FROM Contato_Endereco WHERE idContato = @idContato", new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idContato"),
            MapBuilder<Contato_EnderecoModel>.MapAllProperties().Build());

            return reg.Execute(idContato).ToList();
        }
    }
}
