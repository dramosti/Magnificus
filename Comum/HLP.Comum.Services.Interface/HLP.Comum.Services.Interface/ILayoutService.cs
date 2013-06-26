using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HLP.Comum.Models;
using ComponentFactory.Krypton.Toolkit;
using HLP.Comum.Components;

namespace HLP.Comum.Services.Interface
{
    public interface ILayoutService
    {
        Formulario AcessoFormulario { get; set; }
        List<Control> lControl { get; set; }
        List<HLP_DataGridView> lKryptonDataGridView { get; set; }
        List<FlowLayoutPanel> lFlowLayoutPanel { get; set; }
        ConfigFormSerializer objConfig { get; set; }
        List<AC.ExtendedRenderer.Navigator.KryptonTabControl> lTabControl { get; set; }
        void ConfigurationForm(Control.ControlCollection lControles, string sViewName = "");
        void ConsistForm();
        ConfigFormSerializer ConfigurationForm(string sFormName);
        void Serialize(ConfigFormSerializer config, string sPath = "");
        ConfigFormSerializer ConfiguracaoInicial(Control.ControlCollection lControles, bool config_sys = false);
        void DeleteXml();
        void ConfigFormBySetting();
        bool isToUpper();

    }
}
