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

namespace HLP.Comum.Repository.Implementation.Configuracao
{
    public class ConfigColunasGridRepository : IConfigColunasGridRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }
        //[Inject]
        //public ConfigComponenteRepository configComponenteRepository { get; set; }

        public void Save(ConfigColunasGridModel colunasGrid)
        {
            try
            {
                if (colunasGrid.idColunasGrid == null)
                {
                    colunasGrid.idColunasGrid = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                        UndTrabalho.dbTransaction,
                           "[dbo].[Proc_save_CONFIG_ColunasGrid]",
                          ParameterBase<ConfigColunasGridModel>.SetParameterValue(colunasGrid));
                }

                colunasGrid.objColunasGridUsu.idColunasGrid = colunasGrid.idColunasGrid;

                if (colunasGrid.xType.ToUpper().Equals("DECIMAL") && (colunasGrid.Base != null))
                    colunasGrid.objColunasGridUsu.nMaxLength = Convert.ToDecimal(colunasGrid.Base.PRECISION);

                colunasGrid.objColunasGridUsu.idColunasGridUsuario = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                    UndTrabalho.dbTransaction,
                    "dbo.Proc_save_CONFIG_ColunasGrid_Usuario",
                    ParameterBase<ConfigColunasGridUsuModel>.SetParameterValue(colunasGrid.objColunasGridUsu));

                if (colunasGrid.xType.ToUpper().Equals("DECIMAL") && (colunasGrid.Base != null))
                    colunasGrid.objColunasGridUsu.nMaxLength = colunasGrid.Base.GetMaxLeghtToNumericUpDown();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ConfigColunasGridModel> GetAllColByGrid(int idComponente, string xTable)
        {
            List<ConfigColunasGridModel> lColunas = UndTrabalho.dbPrincipal.CreateSqlStringAccessor("SELECT * FROM CONFIG_ColunasGrid WHERE idComponente = " + idComponente,
                                        MapBuilder<ConfigColunasGridModel>.MapAllProperties().DoNotMap(c => c.Base).Build()).Execute().ToList();

            return lColunas;
        }

        public ConfigColunasGridUsuModel GetConfigColGridUsu(int idColunasGrid, int idUsuario)
        {
            try
            {
                DataAccessor<ConfigColunasGridUsuModel> regAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_CONFIG_ColunasGrid_Usuario",
                                     new Parameters(UndTrabalho.dbPrincipal)
                                     .AddParameter<int>("idColunasGrid").AddParameter<int>("idUsuario"),
                                     MapBuilder<ConfigColunasGridUsuModel>.MapAllProperties().Build());

                ConfigColunasGridUsuModel objCol = null;

                objCol = regAccessor.Execute(idColunasGrid, idUsuario).FirstOrDefault();

                return objCol;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
