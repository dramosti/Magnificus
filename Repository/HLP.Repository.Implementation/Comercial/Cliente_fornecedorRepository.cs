using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.Comercial;
using HLP.Models.Entries.Comercial;
using HLP.Comum.Infrastructure;
using Ninject;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Comum.Infrastructure.Static;


namespace HLP.Repository.Implementation.Entries.Comercial
{
    public class Cliente_fornecedorRepository : ICliente_fornecedorRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Cliente_fornecedorModel> regCliente_fornecedorAccessor;

        public void Save(Cliente_fornecedorModel objCliente_fornecedor)
        {
            //Aqui deve-se setar as FK's (se houver)
            //Exemplo:
            //produto.idEmpresa = CompanyData.idEmpresa;

            if (objCliente_fornecedor.idClienteFornecedor == null)
            {
                objCliente_fornecedor.idClienteFornecedor = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                "[dbo].[Proc_save_Cliente_fornecedor]",
                ParameterBase<Cliente_fornecedorModel>.SetParameterValue(objCliente_fornecedor));
            }
            else
            {
                UndTrabalho.dbPrincipal.ExecuteScalar(
                "[dbo].[Proc_update_Cliente_fornecedor]",
                ParameterBase<Cliente_fornecedorModel>.SetParameterValue(objCliente_fornecedor));
            }
        }

        public void Delete(Cliente_fornecedorModel objCliente_fornecedor)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
            UndTrabalho.dbTransaction,
           "[dbo].[Proc_delete_Cliente_fornecedor]",
            UserData.idUser,
            objCliente_fornecedor.idClienteFornecedor);
        }

        public void Copy(Cliente_fornecedorModel objCliente_fornecedor)
        {
            objCliente_fornecedor.idClienteFornecedor = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
            UndTrabalho.dbTransaction,
           "dbo.Proc_copy_Cliente_fornecedor",
            objCliente_fornecedor.idClienteFornecedor);
        }

        public Cliente_fornecedorModel GetCliente_fornecedor(int idClienteFornecedor)
        {

            if (regCliente_fornecedorAccessor == null)
            {
                regCliente_fornecedorAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_Cliente_fornecedor",
                                         new Parameters(UndTrabalho.dbPrincipal)
                                         .AddParameter<int>("idClienteFornecedor"),
                                         MapBuilder<Cliente_fornecedorModel>.MapAllProperties().Build());
            }

            return regCliente_fornecedorAccessor.Execute(idClienteFornecedor).FirstOrDefault();
        }

        public Cliente_fornecedor_EnderecoModel GetCliente_fornecedor_EnderecoPrincipal(int idCliente_fornecedor)
        {
            DataAccessor<Cliente_fornecedor_EnderecoModel> reg = UndTrabalho.dbPrincipal.CreateSqlStringAccessor
            ("SELECT * FROM Cliente_Fornecedor_Endereco WHERE idClienteFornecedor = @idCliente_fornecedor",
            new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idCliente_fornecedor"),
            MapBuilder<Cliente_fornecedor_EnderecoModel>.MapAllProperties().Build());
            return reg.Execute(idCliente_fornecedor).FirstOrDefault();
        }

        public List<Cliente_fornecedor_representanteModel> GetCliente_fornecedor_Representante(int idCliente_fornecedor)
        {
            DataAccessor<Cliente_fornecedor_representanteModel> reg = UndTrabalho.dbPrincipal.CreateSqlStringAccessor
            ("select * from Cliente_fornecedor_representante r " +
             "inner join Cliente_fornecedor c on r.idClienteFornecedor = c.idClienteFornecedor " +
             "where r.idClienteFornecedor = @idClienteFornecedor and c.idEmpresa = @idEmpresa",
            new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idClienteFornecedor").AddParameter<int>("idEmpresa"),
            MapBuilder<Cliente_fornecedor_representanteModel>.MapAllProperties().Build());
            return reg.Execute(idCliente_fornecedor, CompanyData.idEmpresa).ToList();
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
    }
}
