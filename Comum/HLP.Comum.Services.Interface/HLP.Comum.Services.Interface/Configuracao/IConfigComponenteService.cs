using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;
using HLP.Comum.Models;
using System.Windows.Forms;

namespace HLP.Comum.Services.Interface.Configuracao
{
    public interface IConfigComponenteService
    {

        List<ConfigComponenteModel> GetListaControlesConfigComponenteModel();
        List<ConfigComponenteModel> GetAllCompByTabPage(int idTabPage, int idUsuario);
        InfoFieldModel GetInfoField(string table_name, string column_name);
        void GetInfoCompByTabePage(ConfigTabPageModel tab, List<Control> lControl);
        void SetConfigToComp(List<ConfigComponenteModel> lCompModel, List<Control> lControl);
        void Save(ConfigComponenteModel componente);
    }
}
