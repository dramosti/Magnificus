using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Ninject;
using HLP.Comum.Services.Interface.Configuracao;
using HLP.Comum.Components;
using System.Linq;
using HLP.Comum.Infrastructure;
using HLP.Comum.Models.Static;
using ComponentFactory.Krypton.Toolkit;
using System.Reflection;
using HLP.Comum.Infrastructure.Extension;

namespace HLP.Comum.Services.Implementation
{
    public class InitializeConfigService : IInitializeConfigService
    {
        [Inject]
        public IConfigFormulariosService configFormularioService { get; set; }

        private List<Control> lControl { get; set; }
        private List<TabPage> lTabPage { get; set; }
        private List<HLP_DataGridView> lDataGridView { get; set; }

        public void Begin(Control.ControlCollection lControles, string sNameView = "")
        {
            try
            {
                lControl = new List<Control>();
                lTabPage = new List<TabPage>();
                lDataGridView = new List<HLP_DataGridView>();
                GetControls(lControles);
                GetTabPages(lControles);
                GetDataGridView(lControles);

                ConfigFormulariosModel formulario = configFormularioService.GetFormulario(lControl.FirstOrDefault().FindForm().Name, UserData.idUser);

                if (formulario == null || formulario.objConfigFormUsu == null)
                {
                    if (formulario == null)
                    {
                        formulario = new ConfigFormulariosModel
                        {
                            xNameFormulario = lControl.FirstOrDefault().FindForm().Name,
                            xTable = (lControl.FirstOrDefault().FindForm().Tag != null) ? lControl.FirstOrDefault().FindForm().Tag.ToString() : "",
                            xNameView = sNameView
                        };
                    }
                    //Carrega Classes com dados do Formulario padrão HLP

                }



            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        #region Métodos privados

        /// <summary>
        /// Busca todos os controles do formulário e armazena em uma Lista, para ficar podermos trabalhar com LINQ e LAMBDA.
        /// </summary>
        /// <param name="lControles"></param>
        /// <returns></returns>
        private List<Control> GetControls(Control.ControlCollection lControles)
        {
            foreach (Control ctr in lControles)
            {
                if (ctr.GetType().BaseType == typeof(UserControlBase))
                {
                    if (!lControl.Contains(ctr))
                    {
                        lControl.Add(ctr);
                    }
                }
                else if (!lControl.Contains(ctr))
                {
                    #region Controles Normais
                    if (ctr.GetType() == typeof(KryptonButton))
                    {
                        lControl.Add(ctr);
                    }
                    else if (ctr.GetType() == typeof(KryptonTextBox))
                    {
                        lControl.Add(ctr);
                    }
                    else if (ctr.GetType() == typeof(KryptonMaskedTextBox))
                    {
                        lControl.Add(ctr);
                    }
                    else if (ctr.GetType() == typeof(KryptonComboBox))
                    {
                        lControl.Add(ctr);
                    }
                    else if (ctr.GetType() == typeof(KryptonDateTimePicker))
                    {
                        lControl.Add(ctr);
                    }
                    else if (ctr.GetType() == typeof(KryptonCheckedListBox))
                    {
                        lControl.Add(ctr);
                    }
                    else if (ctr.GetType() == typeof(KryptonCheckBox))
                    {
                        lControl.Add(ctr);
                    }
                    else if (ctr.GetType() == typeof(KryptonRichTextBox))
                    {
                        lControl.Add(ctr);
                    }
                    else if (ctr.GetType() == typeof(KryptonNumericUpDown))
                    {
                        lControl.Add(ctr);
                    }
                    else if (ctr.GetType() == typeof(AC.ExtendedRenderer.Navigator.KryptonTabControl))
                    {
                        //if (!lTabControl.Contains(ctr))
                        //{
                        //    lTabControl.Add((AC.ExtendedRenderer.Navigator.KryptonTabControl)ctr);
                        //}
                        lControl.Add(ctr);
                    }
                    else if (ctr.HasChildren == true && ctr.GetType().BaseType != typeof(UserControl))
                    {
                        GetControls(ctr.Controls);
                    }


                    #endregion
                }
            }
            return lControl;
        }

        private void GetTabPages(Control.ControlCollection lControles)
        {
            foreach (Control ctr in lControles)
            {
                if (ctr.GetType() == typeof(TabPage))
                {
                    lTabPage.Add(ctr as TabPage);
                    GetTabPages(ctr.Controls);
                }
                else if (ctr.HasChildren)
                {
                    GetTabPages(ctr.Controls);
                }
            }
        }

        /// <summary>
        /// Busca todos os DataGridView do formulário e armazena em uma Lista, para ficar podermos trabalhar com LINQ e LAMBDA.
        /// </summary>
        /// <param name="lControles"></param>
        private void GetDataGridView(Control.ControlCollection lControles)
        {

            foreach (Control ctr in lControles)
            {
                if (ctr.GetType() == typeof(HLP_DataGridView))
                {
                    if (!lDataGridView.Contains((HLP_DataGridView)ctr))
                    {
                        lDataGridView.Add((HLP_DataGridView)ctr);
                    }
                }
                else if (ctr.HasChildren)
                {
                    GetDataGridView(ctr.Controls);
                }
            }
        }

        private void CarregaDadosForm(ConfigFormulariosModel formulario)
        {
            formulario.objConfigFormUsu = new ConfigFormularioUsuModel();
            formulario.objConfigFormUsu.idUsuario = null;
            formulario.objConfigFormUsu.idFormularios = formulario.idFormularios;
            formulario.objConfigFormUsu.xText = lControl.FirstOrDefault().FindForm().Text;

            //formulario.objConfigTabPage = new List<ConfigTabPageModel>();
            ConfigTabPageModel tab;
            foreach (TabPage item in lTabPage)
            {
                tab = new ConfigTabPageModel();
                tab.xNameTab = item.Name;
                tab.objConfigTabPageUsu = new ConfigTabPageUsuModel();
                tab.objConfigTabPageUsu.xTabPage = item.Text;
                tab.objConfigTabPageUsu.xHelp = (item.Tag != null ? item.Tag.ToString() : "");
                tab.objConfigTabPageUsu.stAtivo = true.ToByte();

                List<Control> lControles = lControl.Where(c => c.Parent.Parent == item).ToList();

                foreach (Control controle in lControl.Where(c => c.Parent.Parent == item).ToList())
                {

                    Assembly assembly = (controle as object).GetType().Assembly;
                    Type classe = assembly.GetType((controle as object).ToString());

                    //atribute extension

                    //AttributeExt


                    //object retorno = metodo.Invoke(obj, new object[] { });

                }




            }



        }



        #endregion





    }
}
