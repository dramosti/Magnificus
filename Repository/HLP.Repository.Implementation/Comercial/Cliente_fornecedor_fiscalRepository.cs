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

namespace HLP.Repository.Implementation.Entries.Comercial
{
    public class Cliente_fornecedor_fiscalRepository : ICliente_fornecedor_fiscalRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Cliente_fornecedor_fiscalModel> regAcessor;

        public Cliente_fornecedor_fiscalModel GetCliente_fornecedor_fiscal(int idClienteFornecedor)
        {
            if (regAcessor == null)
            {
                regAcessor = UndTrabalho.dbPrincipal.CreateSqlStringAccessor
                ("SELECT * FROM Cliente_fornecedor_fiscal WHERE idClienteFornecedor = @idClienteFornecedor", 
                new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idClienteFornecedor"),
                MapBuilder<Cliente_fornecedor_fiscalModel>.MapAllProperties().Build());
            }
            return regAcessor.Execute(idClienteFornecedor).FirstOrDefault();
        }

        public void Save(Cliente_fornecedor_fiscalModel objCliente_fornecedor_fiscal)
        {
            objCliente_fornecedor_fiscal.idClienteFornecedorFiscal = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
            "[dbo].[Proc_save_Cliente_fornecedor_fiscal]",
            ParameterBase<Cliente_fornecedor_fiscalModel>.SetParameterValue(objCliente_fornecedor_fiscal));
        }

        public void Delete(int idClienteFornecedor)
        {
            UndTrabalho.dbPrincipal.ExecuteNonQuery(System.Data.CommandType.Text,
              "DELETE Cliente_fornecedor_fiscal WHERE idClienteFornecedor = " + idClienteFornecedor);
        }

        public void Copy(Cliente_fornecedor_fiscalModel objCliente_fornecedor_fiscal)
        {
            objCliente_fornecedor_fiscal.idClienteFornecedorFiscal = null;
            objCliente_fornecedor_fiscal.idClienteFornecedorFiscal = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                                           UndTrabalho.dbTransaction,
                                           "[dbo].[Proc_save_Cliente_fornecedor_fiscal]",
        ParameterBase<Cliente_fornecedor_fiscalModel>.SetParameterValue(objCliente_fornecedor_fiscal));
        }
    }
}
