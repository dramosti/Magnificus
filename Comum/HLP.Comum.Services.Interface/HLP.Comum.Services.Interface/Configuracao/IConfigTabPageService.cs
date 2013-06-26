using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;
using System.Windows.Forms;

namespace HLP.Comum.Services.Interface.Configuracao
{
    public interface IConfigTabPageService
    {
        List<ConfigComponenteModel> GetListaControlesConfigComponenteModel();
        List<TabPage> lTabPageControl { get; set; }
        List<ConfigTabPageModel> lTabPageModel { get; set; }
        void Save(ConfigTabPageModel tabPage);
        void GetInfoTabPagesRecursiovo(Control.ControlCollection lControles, ConfigTabPageModel objConfigTabPagePai, List<Control> lControl);
        ConfigTabPageModel GetTabPageByForm(int idFormulario, int idUsuario);
        void GetTabPageRecursivo(ConfigTabPageModel objTabPage, int idUsuario);
        void SetConfigToTabPagesRecursivo(ConfigTabPageModel objTabPage, List<Control> lControl);
    }
}
