using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;
using HLP.Comum.Models;

namespace HLP.Comum.Repository.Interfaces.Configuracao
{
    public interface IConfigColunasGridService
    {
        void Save(ConfigColunasGridModel colunasGrid);
        List<ConfigColunasGridModel> GetAllColByGrid(int idComponente, int idUsuario, string xTable);
    }
}
