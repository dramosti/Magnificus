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
    public class Cliente_fornecedor_ObservacaoRepository : ICliente_Fornecedor_ObservacaoRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Cliente_Fornecedor_ObservacaoModel> regAcessor;

        public void Save(Cliente_Fornecedor_ObservacaoModel objCliente_Fornecedor_Observacao)
        {
            objCliente_Fornecedor_Observacao.idClienteFornecedorObservacao = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
           "[dbo].[Proc_save_Cliente_Fornecedor_Observacao]",
            ParameterBase<Cliente_Fornecedor_ObservacaoModel>.SetParameterValue(objCliente_Fornecedor_Observacao));

            objCliente_Fornecedor_Observacao.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Update(Cliente_Fornecedor_ObservacaoModel objCliente_Fornecedor_Observacao)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
            "[dbo].[Proc_update_Cliente_Fornecedor_Observacao]",
            ParameterBase<Cliente_Fornecedor_ObservacaoModel>.SetParameterValue(objCliente_Fornecedor_Observacao));

            objCliente_Fornecedor_Observacao.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Delete(Cliente_Fornecedor_ObservacaoModel objCliente_Fornecedor_Observacao)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar("[dbo].[Proc_delete_Cliente_Fornecedor_Observacao]",
                  UserData.idUser,
                  objCliente_Fornecedor_Observacao.idClienteFornecedorObservacao);

            objCliente_Fornecedor_Observacao.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Delete(int idClienteFornecedor)
        {
            UndTrabalho.dbPrincipal.ExecuteNonQuery(System.Data.CommandType.Text,
              "DELETE Cliente_Fornecedor_Observacao WHERE idClienteFornecedor = " + idClienteFornecedor);
        }

        public void Copy(Cliente_Fornecedor_ObservacaoModel objCliente_Fornecedor_Observacao)
        {
            objCliente_Fornecedor_Observacao.idClienteFornecedorObservacao = null;
            objCliente_Fornecedor_Observacao.idClienteFornecedorObservacao = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                                           UndTrabalho.dbTransaction,
                                           "[dbo].[Proc_save_Cliente_Fornecedor_Observacao]",
        ParameterBase<Cliente_Fornecedor_ObservacaoModel>.SetParameterValue(objCliente_Fornecedor_Observacao));
        }

        public Cliente_Fornecedor_ObservacaoModel GetCliente_Fornecedor_Observacao(int idClienteFornecedorObservacao)
        {
            if (regAcessor == null)
            {
                regAcessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("[dbo].[Proc_sel_Cliente_Fornecedor_Observacao]",
                   new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idClienteFornecedorObservacao"),
                   MapBuilder<Cliente_Fornecedor_ObservacaoModel>.MapAllProperties().Build());
            }
            return regAcessor.Execute(idClienteFornecedorObservacao).FirstOrDefault();
        }

        public List<Cliente_Fornecedor_ObservacaoModel> GetAllCliente_Fornecedor_Observacao(int idClienteFornecedor)
        {
            DataAccessor<Cliente_Fornecedor_ObservacaoModel> reg = UndTrabalho.dbPrincipal.CreateSqlStringAccessor
            ("SELECT * FROM Cliente_Fornecedor_Observacao WHERE idClienteFornecedor = @idClienteFornecedor", new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idClienteFornecedor"),
            MapBuilder<Cliente_Fornecedor_ObservacaoModel>.MapAllProperties().Build());

            return reg.Execute(idClienteFornecedor).ToList();
        }
    }
}
