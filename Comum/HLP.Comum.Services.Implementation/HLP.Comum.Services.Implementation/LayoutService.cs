using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Services.Interface;
using System.Windows.Forms;
using HLP.Comum.Repository.Interfaces;
using Ninject;
using HLP.Comum.Models;
using ComponentFactory.Krypton.Toolkit;
using HLP.Comum.Components;

namespace HLP.Comum.Services.Implementation
{
    public class LayoutService : ILayoutService
    {
        [Inject]
        public ILayoutRepository layoutRepository { get; set; }

        public List<Control> lControl
        {
            get
            {
                return layoutRepository.lControl;
            }
            set
            {
                layoutRepository.lControl = value;
            }
        }
        public List<FlowLayoutPanel> lFlowLayoutPanel
        {
            get
            {
                return layoutRepository.lFlowLayoutPanel;
            }
            set
            {
                layoutRepository.lFlowLayoutPanel = value;
            }
        }
        public ConfigFormSerializer objConfig
        {
            get
            {
                return layoutRepository.objConfig;
            }
            set
            {
                layoutRepository.objConfig = value;
            }
        }
        public List<AC.ExtendedRenderer.Navigator.KryptonTabControl> lTabControl
        {
            get
            {
                return layoutRepository.lTabControl;
            }
            set
            {
                layoutRepository.lTabControl = value;
            }
        }
        public ConfigFormSerializer ConfigurationForm(string sFormName)
        {
            return layoutRepository.ConfigurationForm(sFormName);
        }
        public void ConfigurationForm(Control.ControlCollection lControles, string sViewName = "")
        {
            layoutRepository.ConfigurationForm(lControles, sViewName);
        }
        public void ConsistForm()
        {
            layoutRepository.ConsistForm();
        }
        public void Serialize(ConfigFormSerializer config, string sPath = "")
        {
            layoutRepository.Serialize(config, sPath);
        }


        public void DeleteXml()
        {
            layoutRepository.DeleteXml();
        }


        public void ConfigFormBySetting()
        {
            layoutRepository.ConfigFormBySetting();
        }


        public List<HLP_DataGridView> lKryptonDataGridView
        {
            get
            {
                return layoutRepository.lKryptonDataGridView;
            }
            set
            {
                layoutRepository.lKryptonDataGridView = value;
            }
        }


        public ConfigFormSerializer ConfiguracaoInicial(Control.ControlCollection lControles, bool config_sys = false)
        {
            return layoutRepository.ConfiguracaoInicial(lControles, config_sys);
        }

        public Formulario AcessoFormulario
        {
            get
            {
                return layoutRepository.AcessoFormulario;
            }
            set
            {
                value = layoutRepository.AcessoFormulario;
            }
        }


        public bool isToUpper()
        {
            return layoutRepository.isToUpper();
        }
    }
}
