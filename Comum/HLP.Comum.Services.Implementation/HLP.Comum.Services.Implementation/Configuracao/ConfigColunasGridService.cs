using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Repository.Interfaces.Configuracao;
using HLP.Comum.Infrastructure;
using Ninject;
using HLP.Comum.Infrastructure.Static;
using HLP.Comum.Models;

namespace HLP.Comum.Services.Implementation.Configuracao
{
    public class ConfigColunasGridService : IConfigColunasGridService
    {
        [Inject]
        public IConfigColunasGridRepository colunasGridRepository { get; set; }

        [Inject]
        public IConfigComponenteRepository icomponenteRepository { get; set; }

        public void Save(ConfigColunasGridModel colunasGrid)
        {
            colunasGridRepository.Save(colunasGrid);
        }

        public List<ConfigColunasGridModel> GetAllColByGrid(int idComponente, int idUsuario, string xTable)
        {
            List<ConfigColunasGridModel> lColunasGrid = colunasGridRepository.GetAllColByGrid(idComponente, xTable);

            foreach (ConfigColunasGridModel colunasGrid in lColunasGrid)
            {
                if (colunasGrid.xDataPropertyName != "" && xTable != "")
                {
                    colunasGrid.Base = icomponenteRepository.GetInfoField(xTable, colunasGrid.xDataPropertyName);
                }               

                if (colunasGrid != null)
                {
                    colunasGrid.objColunasGridUsu = colunasGridRepository.GetConfigColGridUsu((int)colunasGrid.idColunasGrid, idUsuario);

                    if (colunasGrid.Base != null)
                    {
                        if (colunasGrid.xType.Equals("decimal") || (colunasGrid.xType.Equals("numeric")))
                        {
                            colunasGrid.objColunasGridUsu.nMaxLength = colunasGrid.Base.GetMaxLeghtToNumericUpDown();
                            colunasGrid.objColunasGridUsu.nDecimalPlaces = colunasGrid.Base.SCALE.ToInt32();
                        }
                        else
                        {
                            colunasGrid.objColunasGridUsu.nMaxLength = colunasGrid.Base.GetMaxLenghtNormal();
                        }
                    }
                }
            }

            return lColunasGrid;
        }
    }
}
