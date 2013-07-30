using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using HLP.Comum.Infrastructure;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Comum.Infrastructure;

using HLP.Comum.Repository.Interfaces.Configuracao;
using HLP.Comum.Models;

namespace HLP.Comum.Repository.Implementation.Configuracao
{
    public class ConfigPesquisaRepository : IConfigPesquisaRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<PesquisaPadraoModel> regCONFIG_PesquisaByViewAccessor;
        private DataAccessor<CONFIG_PesquisaModel> regCONFIG_PesquisaAccessor;
        private DataAccessor<CONFIG_PesquisaModel> regAllCONFIG_PesquisaAccessor;

        public void Save(CONFIG_PesquisaModel objCONFIG_Pesquisa)
        {
            if (objCONFIG_Pesquisa.idPesquisa == null)
            {

                objCONFIG_Pesquisa.idPesquisa = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                    UndTrabalho.dbTransaction,
                    "[dbo].[Proc_save_CONFIG_Pesquisa]",
                ParameterBase<CONFIG_PesquisaModel>.SetParameterValue(objCONFIG_Pesquisa));
            }
            else
            {
                UndTrabalho.dbPrincipal.ExecuteScalar(
               "[dbo].[Proc_update_CONFIG_Pesquisa]",
              ParameterBase<CONFIG_PesquisaModel>.SetParameterValue(objCONFIG_Pesquisa));
            }
        }

        public List<CONFIG_PesquisaModel> GetAllCONFIG_Pesquisa(int idFormulario, int idUsuario)
        {
            if (regAllCONFIG_PesquisaAccessor == null)
            {
                regAllCONFIG_PesquisaAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_CONFIG_Pesquisa",
                                new Parameters(UndTrabalho.dbPrincipal)
                                .AddParameter<int>("idFormularios")
                                .AddParameter<int>("idUsuario"),
                                MapBuilder<CONFIG_PesquisaModel>.MapAllProperties().Build());
            }
            return regAllCONFIG_PesquisaAccessor.Execute(idFormulario, idUsuario).ToList();
        }

        public List<CONFIG_PesquisaModel> GetCONFIG_PesquisaByView(string sViewName)
        {
            if (regCONFIG_PesquisaByViewAccessor == null)
            {
                regCONFIG_PesquisaByViewAccessor = UndTrabalho.dbPrincipal
                 .CreateSqlStringAccessor(@"select COLUMN_NAME, DATA_TYPE from INFORMATION_SCHEMA.COLUMNS
                                           where TABLE_NAME = @sViewName",
                                new Parameters(UndTrabalho.dbPrincipal)
                                .AddParameter<string>("sViewName"),
                 MapBuilder<PesquisaPadraoModel>.MapAllProperties().DoNotMap(C => C.Operador)
                                                                   .DoNotMap(C => C.Valor)
                                                                   .DoNotMap(C => C.EOU)
                                                                   .DoNotMap(C => C.HeaderText)
                                                                   .Build());

            }

            List<CONFIG_PesquisaModel> lReturn = new List<CONFIG_PesquisaModel>();
            int iCount = 1;
            foreach (PesquisaPadraoModel item in regCONFIG_PesquisaByViewAccessor.Execute(sViewName).ToList())
            {
                lReturn.Add(new CONFIG_PesquisaModel { iOrderData = iCount, iOrderFilter = iCount, stData = true, stFilter = true, xField = item.COLUMN_NAME });
                iCount++;
            }
            return lReturn;
        }


    }
}
