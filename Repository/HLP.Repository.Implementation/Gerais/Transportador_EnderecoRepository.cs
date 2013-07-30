using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;
using HLP.Comum.Infrastructure;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Ninject;
using HLP.Repository.Interfaces.Entries.Gerais;
using HLP.Comum.Infrastructure.Static;

namespace HLP.Repository.Implementation.Entries.Gerais
{
    public class Transportador_EnderecoRepository : ITransportador_EnderecoRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Transportador_EnderecoModel> regAcessor;

        public void Save(Transportador_EnderecoModel objTransportador_Endereco)
        {
            objTransportador_Endereco.idEndereco = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
           "[dbo].[Proc_save_Transportador_Endereco]",
            ParameterBase<Transportador_EnderecoModel>.SetParameterValue(objTransportador_Endereco));

            objTransportador_Endereco.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Update(Transportador_EnderecoModel objTransportador_Endereco)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
            "[dbo].[Proc_update_Transportador_Endereco]",
            ParameterBase<Transportador_EnderecoModel>.SetParameterValue(objTransportador_Endereco));

            objTransportador_Endereco.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Delete(Transportador_EnderecoModel objTransportador_Endereco)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar("[dbo].[Proc_delete_Transportador_Endereco]",
                  UserData.idUser,
                  objTransportador_Endereco.idEndereco);

            objTransportador_Endereco.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Delete(int idTransportador)
        {
            UndTrabalho.dbPrincipal.ExecuteNonQuery(System.Data.CommandType.Text,
              "DELETE Transportador_Endereco WHERE idTransportador = " + idTransportador);
        }

        public void Copy(Transportador_EnderecoModel objTransportador_Endereco)
        {
            objTransportador_Endereco.idEndereco = null;
            objTransportador_Endereco.idEndereco = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                                           UndTrabalho.dbTransaction,
                                           "[dbo].[Proc_save_Transportador_Endereco]",
        ParameterBase<Transportador_EnderecoModel>.SetParameterValue(objTransportador_Endereco));
        }

        public Transportador_EnderecoModel GetTransportador_Endereco(int idEndereco)
        {
            if (regAcessor == null)
            {
                regAcessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("[dbo].[Proc_sel_Transportador_Endereco]",
                   new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idEndereco"),
                   MapBuilder<Transportador_EnderecoModel>.MapAllProperties().Build());
            }
            return regAcessor.Execute(idEndereco).FirstOrDefault();
        }

        public List<Transportador_EnderecoModel> GetAllTransportador_Endereco(int idTransportador)
        {
            DataAccessor<Transportador_EnderecoModel> reg = UndTrabalho.dbPrincipal.CreateSqlStringAccessor
            ("SELECT * FROM Transportador_Endereco WHERE idTransportador = @idTransportador", new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idTransportador"),
            MapBuilder<Transportador_EnderecoModel>.MapAllProperties().Build());

            return reg.Execute(idTransportador).ToList();
        }
    }
}
