using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Repository.Interfaces.Configuracao;
using HLP.Comum.Infrastructure;
using Ninject;
using System.Data;
using HLP.Comum.Models.Static;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Comum.Models;

namespace HLP.Comum.Repository.Implementation.Configuracao
{
    public class ConfigComponenteRepository : IConfigComponenteRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }
        [Inject]
        public ConfigColunasGridRepository colunasGridRepository { get; set; }

        private DataAccessor<ConfigComponenteModel> lComponentesAcessor;



        public void Save(ConfigComponenteModel componente)
        {
            try
            {
                if (componente.idComponente == null)
                {
                    componente.idComponente = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                        UndTrabalho.dbTransaction,
                        "dbo.Proc_save_CONFIG_Componente",
                        ParameterBase<ConfigComponenteModel>.SetParameterValue(componente));
                }
                if (componente.xTypeComp != typeof(HLP.Comum.Components.HLP_DataGridView).Name)
                {
                    if ((componente.xTypeComp == typeof(HLP.Comum.Components.HLP_NumericUpDown).Name) && (componente.Base != null))
                        componente.objConfigCompUsu.nMaxLength = Convert.ToDecimal(componente.Base.PRECISION);
                    if (componente.objConfigCompUsu.idComponenteUsuario == null)
                    {
                        componente.objConfigCompUsu.idComponenteUsuario = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                       UndTrabalho.dbTransaction,
                       "dbo.Proc_save_CONFIG_Componente_Usuario",
                       ParameterBase<ConfigComponenteUsuModel>.SetParameterValue(componente.objConfigCompUsu));
                    }
                    else
                    {
                        componente.objConfigCompUsu.idComponenteUsuario = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                      "dbo.Proc_save_CONFIG_Componente_Usuario",
                      ParameterBase<ConfigComponenteUsuModel>.SetParameterValue(componente.objConfigCompUsu));
                    }


                    if ((componente.xTypeComp == typeof(HLP.Comum.Components.HLP_NumericUpDown).Name) && (componente.Base != null))
                        componente.objConfigCompUsu.nMaxLength = componente.Base.GetMaxLeghtToNumericUpDown();
                }
                else
                {
                    if (componente.objConfigCompGridUsu.idCompGridUsuario == null)
                    {
                        componente.objConfigCompGridUsu.idCompGridUsuario = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                            UndTrabalho.dbTransaction,
                            "dbo.Proc_save_CONFIG_CompGridView_Usuario",
                            ParameterBase<ConfigCompGridViewUsuModel>.SetParameterValue(componente.objConfigCompGridUsu));
                    }

                    foreach (ConfigColunasGridModel coluna in componente.lConfigColunasGrid)
                    {
                        colunasGridRepository.Save(coluna);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ConfigComponenteModel> GetAllCompByTabPage(int idTabPage)
        {
            if (lComponentesAcessor == null)
            {
                lComponentesAcessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_CONFIG_Componentes",
                      new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idTabPage"),
                                             MapBuilder<ConfigComponenteModel>.MapAllProperties()
                                             .DoNotMap(c => c.Base)
                                             .Build());
            }
            List<ConfigComponenteModel> lComp = lComponentesAcessor.Execute(idTabPage).ToList();
            foreach (ConfigComponenteModel comp in lComp)
            {
                comp.Base = this.GetInfoField(comp.xTable, comp.xField);
            }
            return lComp;
        }

        public ConfigComponenteUsuModel GetConfigCompUsu(int idComponente, int idUsuario)
        {
            try
            {
                DataAccessor<ConfigComponenteUsuModel> regAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_CONFIG_Componente_Usuario",
                                     new Parameters(UndTrabalho.dbPrincipal)
                                       .AddParameter<int>("idComponente").AddParameter<int>("idUsuario"),
                                     MapBuilder<ConfigComponenteUsuModel>.MapAllProperties().Build());

                return regAccessor.Execute(idComponente, idUsuario).FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ConfigCompGridViewUsuModel GetConfigCompGridUsu(int idComponente, int idUsuario)
        {
            try
            {
                DataAccessor<ConfigCompGridViewUsuModel> regAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_CONFIG_CompGridView_Usuario",
                                     new Parameters(UndTrabalho.dbPrincipal)
                                       .AddParameter<int>("idComponente").AddParameter<int>("idUsuario"),
                                     MapBuilder<ConfigCompGridViewUsuModel>.MapAllProperties().Build());

                return regAccessor.Execute(idComponente, idUsuario).FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public InfoField GetInfoField(string table_name, string column_name)
        {
            try
            {
                DataAccessor<InfoField> regInfoFieldAccessor = null;
                regInfoFieldAccessor = UndTrabalho.dbPrincipal
                  .CreateSprocAccessor("sp_columns",
                                  new Parameters(UndTrabalho.dbPrincipal)
                                  .AddParameter<string>("table_name")
                                  .AddParameter<string>("column_name"),
                                  MapBuilder<InfoField>.MapAllProperties().Build());
                InfoField objInfoField = null;

                try
                {
                    objInfoField = regInfoFieldAccessor.Execute(table_name, column_name).FirstOrDefault();
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao buscar informações do campo " + column_name + " da Tabela " + table_name + " ;" + Environment.NewLine + ex.Message);
                }
                return objInfoField;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
