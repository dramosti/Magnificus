using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HLP.Comum.Models;
using ComponentFactory.Krypton.Toolkit;
using HLP.Comum.Components;

namespace HLP.Comum.Repository.Interfaces
{
    public interface ILayoutRepository
    {
        List<Control> lControl { get; set; }
        List<FlowLayoutPanel> lFlowLayoutPanel { get; set; }
        List<HLP_DataGridView> lKryptonDataGridView { get; set; }
        ConfigFormSerializer objConfig { get; set; }
        List<AC.ExtendedRenderer.Navigator.KryptonTabControl> lTabControl { get; set; }
        Formulario AcessoFormulario { get; set; }

        bool isToUpper();
        void ConfigurationForm(Control.ControlCollection lControles, string sViewName = "");
        ConfigFormSerializer ConfigurationForm(string sFormName);
        void ConsistForm();
        void Serialize(ConfigFormSerializer config, string sPath="");
        ConfigFormSerializer ConfiguracaoInicial(Control.ControlCollection lControles, bool config_sys = false);
        void DeleteXml();
        void ConfigFormBySetting();

    }
}
