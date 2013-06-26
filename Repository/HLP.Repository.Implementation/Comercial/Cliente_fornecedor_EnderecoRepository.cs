using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.Comercial;
using HLP.Models.Entries.Comercial;
using Ninject;
using HLP.Comum.Infrastructure;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Comum.Models.Static;
using System.Data.Common;
using System.Data;

namespace HLP.Repository.Implementation.Entries.Comercial
{
    public class Cliente_fornecedor_EnderecoRepository : ICliente_fornecedor_EnderecoRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Cliente_fornecedor_EnderecoModel> regAcessor;

        public void Save(Cliente_fornecedor_EnderecoModel objCliente_Fornecedor_Endereco)
        {
            objCliente_Fornecedor_Endereco.idEndereco = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
           "[dbo].[Proc_save_Cliente_Fornecedor_Endereco]",
            ParameterBase<Cliente_fornecedor_EnderecoModel>.SetParameterValue(objCliente_Fornecedor_Endereco));

            objCliente_Fornecedor_Endereco.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Update(Cliente_fornecedor_EnderecoModel objCliente_Fornecedor_Endereco)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
            "[dbo].[Proc_update_Cliente_Fornecedor_Endereco]",
            ParameterBase<Cliente_fornecedor_EnderecoModel>.SetParameterValue(objCliente_Fornecedor_Endereco));

            objCliente_Fornecedor_Endereco.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Delete(Cliente_fornecedor_EnderecoModel objCliente_Fornecedor_Endereco)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar("[dbo].[Proc_delete_Cliente_Fornecedor_Endereco]",
                  UserData.idUser,
                  objCliente_Fornecedor_Endereco.idEndereco);

            objCliente_Fornecedor_Endereco.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Delete(int idClienteFornecedor)
        {
            UndTrabalho.dbPrincipal.ExecuteNonQuery(System.Data.CommandType.Text,
              "DELETE Cliente_Fornecedor_Endereco WHERE idClienteFornecedor = " + idClienteFornecedor);
        }

        public void Copy(Cliente_fornecedor_EnderecoModel objCliente_Fornecedor_Endereco)
        {
            objCliente_Fornecedor_Endereco.idEndereco = null;
            objCliente_Fornecedor_Endereco.idEndereco = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                                           UndTrabalho.dbTransaction,
                                           "[dbo].[Proc_save_Cliente_Fornecedor_Endereco]",
        ParameterBase<Cliente_fornecedor_EnderecoModel>.SetParameterValue(objCliente_Fornecedor_Endereco));
        }

        public Cliente_fornecedor_EnderecoModel GetCliente_Fornecedor_Endereco(int idEndereco)
        {
            if (regAcessor == null)
            {
                regAcessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("[dbo].[Proc_sel_Cliente_Fornecedor_Endereco]",
                   new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idEndereco"),
                   MapBuilder<Cliente_fornecedor_EnderecoModel>.MapAllProperties().Build());
            }
            return regAcessor.Execute(idEndereco).FirstOrDefault();
        }

        public List<Cliente_fornecedor_EnderecoModel> GetAllCliente_Fornecedor_Endereco(int idClienteFornecedor)
        {
            DataAccessor<Cliente_fornecedor_EnderecoModel> reg = UndTrabalho.dbPrincipal.CreateSqlStringAccessor
            ("SELECT * FROM Cliente_Fornecedor_Endereco WHERE idClienteFornecedor = @idClienteFornecedor", new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idClienteFornecedor"),
            MapBuilder<Cliente_fornecedor_EnderecoModel>.MapAllProperties().Build());

            return reg.Execute(idClienteFornecedor).ToList();
        }
    }
}
