using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;
using HLP.Comum.Models;

namespace HLP.Comum.Repository.Interfaces.Configuracao
{
    public interface IConfigComponenteRepository
    {
        void Save(ConfigComponenteModel componente);
        List<ConfigComponenteModel> GetAllCompByTabPage(int idTabPage);
        ConfigComponenteUsuModel GetConfigCompUsu(int idComponente, int idUsuario);
        ConfigCompGridViewUsuModel GetConfigCompGridUsu(int idComponente, int idUsuario);
        InfoField GetInfoField(string table_name, string column_name);
    }
}
