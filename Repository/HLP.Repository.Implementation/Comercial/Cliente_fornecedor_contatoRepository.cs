using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.Comercial;
using HLP.Models.Entries.Comercial;
using Ninject;
using HLP.Comum.Infrastructure;
using Microsoft.Practices.EnterpriseLibrary.Data;

using System.Data.Common;
using System.Data;
using HLP.Comum.Infrastructure.Static;

namespace HLP.Repository.Implementation.Entries.Comercial
{
    public class Cliente_fornecedor_contatoRepository : ICliente_fornecedor_contatoRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Cliente_fornecedor_contatoModel> regAcessor;

        public void Save(Cliente_fornecedor_contatoModel objCliente_fornecedor_contato)
        {
            objCliente_fornecedor_contato.idClienteFornecedorContato = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
           "[dbo].[Proc_save_Cliente_fornecedor_contato]",
            ParameterBase<Cliente_fornecedor_contatoModel>.SetParameterValue(objCliente_fornecedor_contato));

            objCliente_fornecedor_contato.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Update(Cliente_fornecedor_contatoModel objCliente_fornecedor_contato)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
            "[dbo].[Proc_update_Cliente_fornecedor_contato]",
            ParameterBase<Cliente_fornecedor_contatoModel>.SetParameterValue(objCliente_fornecedor_contato));

            objCliente_fornecedor_contato.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Delete(Cliente_fornecedor_contatoModel objCliente_fornecedor_contato)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar("[dbo].[Proc_delete_Cliente_fornecedor_contato]",
                  UserData.idUser,
                  objCliente_fornecedor_contato.idClienteFornecedorContato);

            objCliente_fornecedor_contato.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Delete(int idClienteFornecedor)
        {
            UndTrabalho.dbPrincipal.ExecuteNonQuery(System.Data.CommandType.Text,
              "DELETE Cliente_fornecedor_contato WHERE idClienteFornecedor = " + idClienteFornecedor);
        }

        public void Copy(Cliente_fornecedor_contatoModel objCliente_fornecedor_contato)
        {
            objCliente_fornecedor_contato.idClienteFornecedorContato = null;
            objCliente_fornecedor_contato.idClienteFornecedorContato = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                                           UndTrabalho.dbTransaction,
                                           "[dbo].[Proc_save_Cliente_fornecedor_contato]",
        ParameterBase<Cliente_fornecedor_contatoModel>.SetParameterValue(objCliente_fornecedor_contato));
        }

        public Cliente_fornecedor_contatoModel GetCliente_fornecedor_contato(int idClienteFornecedorContato)
        {
            if (regAcessor == null)
            {
                regAcessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("[dbo].[Proc_sel_Cliente_fornecedor_contato]",
                   new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idClienteFornecedorContato"),
                   MapBuilder<Cliente_fornecedor_contatoModel>.MapAllProperties().Build());
            }
            return regAcessor.Execute(idClienteFornecedorContato).FirstOrDefault();
        }

        public List<Cliente_fornecedor_contatoModel> GetAllCliente_fornecedor_contato(int idClienteFornecedor)
        {
            DataAccessor<Cliente_fornecedor_contatoModel> reg = UndTrabalho.dbPrincipal.CreateSqlStringAccessor
            ("SELECT * FROM Cliente_fornecedor_contato WHERE idClienteFornecedor = @idClienteFornecedor", new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idClienteFornecedor"),
            MapBuilder<Cliente_fornecedor_contatoModel>.MapAllProperties().Build());

            return reg.Execute(idClienteFornecedor).ToList();
        }
    }
}
