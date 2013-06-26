using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Services.Interface.Configuracao;
using HLP.Comum.Infrastructure;
using Ninject;
using HLP.Comum.Repository.Interfaces.Configuracao;
using System.Windows.Forms;
using HLP.Comum.Models.Static;
using HLP.Comum.Models;
using HLP.Comum.Components;

namespace HLP.Comum.Services.Implementation.Configuracao
{
    public class ConfigTabPageService : IConfigTabPageService
    {
        [Inject]
        public IConfigTabPageRepository iTabPageRepository { get; set; }

        [Inject]
        public IConfigComponenteService iComponenteService { get; set; }



        public List<TabPage> lTabPageControl { get; set; }
        public List<ConfigTabPageModel> lTabPageModel { get; set; }

        public void Save(ConfigTabPageModel tabPage)
        {
            iTabPageRepository.Save(tabPage);
        }

        public void GetInfoTabPagesRecursiovo(Control.ControlCollection lControles, ConfigTabPageModel objConfigTabPagePai, List<Control> lControl)
        {
            foreach (Control ctr in lControles)
            {
                if (ctr.GetType() == typeof(TabPage))
                {
                    //Verificação para desconciderar o objteto inicial que é HLP, e carregar a primeira TAB .
                    if (objConfigTabPagePai.xNameTab.Equals("HLP"))
                    {
                        this.GetInfoTabPage(ctr, objConfigTabPagePai);
                        iComponenteService.GetInfoCompByTabePage(objConfigTabPagePai, lControl);
                        GetInfoTabPagesRecursiovo(ctr.Controls, objConfigTabPagePai, lControl);
                    }
                    else
                    {
                        ConfigTabPageModel tab = new ConfigTabPageModel();
                        this.GetInfoTabPage(ctr, tab);
                        iComponenteService.GetInfoCompByTabePage(tab, lControl);
                        objConfigTabPagePai.lConfigTabPageModel.Add(tab);
                        GetInfoTabPagesRecursiovo(ctr.Controls, tab, lControl);
                    }
                }
                else if (ctr.HasChildren)
                {
                    GetInfoTabPagesRecursiovo(ctr.Controls, objConfigTabPagePai, lControl);
                }
            }
        }

        /// <summary>
        /// Método que carrega informações sobre a TabPage
        /// </summary>
        /// <param name="ctr"></param>
        /// <param name="tab"></param>
        private void GetInfoTabPage(Control ctr, ConfigTabPageModel tab)
        {
            //Config Tab
            tab.xNameTab = ctr.Name;
            //Config Tab Usu
            //tab.objConfigTabPageUsu.idUsuario = UserData.idUserHLP;
            tab.objConfigTabPageUsu.xTabPage = ctr.Text;
            tab.objConfigTabPageUsu.xHelp = (ctr as TabPage).Tag != null ? (ctr as TabPage).Tag.ToString() : "";
            tab.objConfigTabPageUsu.stAtivo = true.ToByte();
            if (lTabPageControl == null)
                lTabPageControl = new List<TabPage>();
            lTabPageControl.Add(ctr as TabPage);
        }

        public ConfigTabPageModel GetTabPageByForm(int idFormulario, int idUsuario)
        {
            ConfigTabPageModel objConfigTabPage = iTabPageRepository.GetTabPageByForm(idFormulario, idUsuario);

            this.GetTabPageRecursivo(objConfigTabPage, idUsuario);



            return objConfigTabPage;
        }

        public void GetTabPageRecursivo(ConfigTabPageModel objTabPage, int idUsuario)
        {
            objTabPage.objConfigTabPageUsu = iTabPageRepository.GetConfigTabPageUsu(objTabPage.idTabPage.ToInt32(), idUsuario); // carrega configuração do usuário
            objTabPage.lConfigTabPageModel = iTabPageRepository.GetListTabPage(objTabPage, idUsuario);

            objTabPage.lConfigComponente = iComponenteService.GetAllCompByTabPage(objTabPage.idTabPage.ToInt32(), idUsuario);

            if (lTabPageModel == null)
                lTabPageModel = new List<ConfigTabPageModel>();
            lTabPageModel.Add(objTabPage);

            foreach (ConfigTabPageModel objTab in objTabPage.lConfigTabPageModel)
            {
                // carrega componentes

                this.GetTabPageRecursivo(objTab, idUsuario);
            }

        }

        public void SetConfigToTabPagesRecursivo(ConfigTabPageModel objTabPage, List<Control> lControl)
        {
            try
            {
                TabPage tab = lTabPageControl.FirstOrDefault(c => c.Name == objTabPage.xNameTab);
                //Configura TabPage
                tab.Text = Util.ToUpperFirstLetter(objTabPage.objConfigTabPageUsu.xTabPage);
                tab.ToolTipText = Util.ToUpperFirstLetter(objTabPage.objConfigTabPageUsu.xHelp);

                //Busca o maior label
                TabPage Tab = lTabPageControl.FirstOrDefault(c => c.Name == objTabPage.xNameTab);
                //Configura Componentes;
                iComponenteService.SetConfigToComp(objTabPage.lConfigComponente, lControl);

                iComponenteService.SetTamanhoComponentes(tab);

                if (objTabPage.lConfigTabPageModel.Count() > 0)
                {
                    foreach (ConfigTabPageModel objtab in objTabPage.lConfigTabPageModel)
                    {
                        SetConfigToTabPagesRecursivo(objtab, lControl);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public List<ConfigComponenteModel> GetListaControlesConfigComponenteModel()
        {
            return iComponenteService.GetListaControlesConfigComponenteModel();
        }


        public void ConfigLabelSeparator()
        {

        }

    }
}
