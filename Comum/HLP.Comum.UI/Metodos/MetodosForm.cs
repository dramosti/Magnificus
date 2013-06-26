using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HLP.Comum.Components;
using ComponentFactory.Krypton.Toolkit;
using Ninject;
using HLP.Comum.Services.Interface;
using HLP.Comum.Models;
using HLP.Dependencies;
using HLP.Comum.Models.Static;
using HLP.Comum.Services.Interface.Configuracao;
using HLP.Comum.Infrastructure;

namespace HLP.Comum.UI.Metodos
{
    public class MetodosForm
    {
        List<Control> lControles = null;


        IConfigFormulariosService iConfigFormulario { get; set; }

        [Inject]
        public IPesquisaPadraoService pesquisaPadraoService { get; set; }

        public MetodosForm(IConfigFormulariosService iConfigFormulario)
        {
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);

            this.iConfigFormulario = iConfigFormulario;
            this.lControles = iConfigFormulario.lControl;
        }




        public void HabilitaCampos(bool bHabilita)
        {
            try
            {
                List<ConfigComponenteModel> lobjConfigComp = iConfigFormulario.objConfigFormularioModel.lobjConfigComponente.ToList();

                foreach (Control ctr in lControles)
                {
                    try
                    {
                        if ((ctr.GetType() == typeof(HLP_Pesquisa)) || (ctr.GetType() == typeof(HLP_Observacao)) || (ctr.GetType() == typeof(HLP_Observacao)))
                        {
                            ctr.Enabled = bHabilita;
                        }
                        else if (ctr.GetType() == typeof(HLP_ListBox))
                        {
                            ctr.Enabled = bHabilita;
                            (ctr as HLP_ListBox).btnBuscar.Enabled = bHabilita;
                        }
                        else if (ctr.GetType().BaseType == typeof(UserControlBase) && ctr.Name != "txtCodigo")
                        {
                            if (bHabilita)
                            {
                                ctr.SetPropertyValue("Enabled", Convert.ToBoolean(lobjConfigComp.FirstOrDefault(c => c.xName == ctr.Name).objConfigCompUsu.stEnabled));
                            }
                            else
                            {
                                ctr.SetPropertyValue("Enabled", bHabilita);
                            }
                        }
                    }
                    catch (System.Exception ex)
                    {
                        throw new System.Exception(string.Format("Ocorreu um erro ao habilitar o componente: {0} Tipo:{1} {3} Erro:{4}",
                            ctr.Name,
                            ctr.GetType().Name,
                            Environment.NewLine,
                            ex.Message
                            ));
                    }
                }
                ConfigComponenteModel objCompGrid = null;
                foreach (HLP_DataGridView grid in lControles.Where(c => c.GetType() == typeof(HLP_DataGridView)))
                {
                    if (bHabilita)
                    {
                        objCompGrid = iConfigFormulario.objConfigFormularioModel.lobjConfigComponente.FirstOrDefault(c => c.xName == grid.Name);
                        if (objCompGrid != null)
                        {
                            grid.ReadOnly = !Convert.ToBoolean(objCompGrid.objConfigCompGridUsu.stAlteracao);//  !layoutService.AcessoFormulario.lGrids.FirstOrDefault(C => C.NameGrid == grid.Name).AlteracaoItem;
                            grid.AllowUserToDeleteRows = Convert.ToBoolean(objCompGrid.objConfigCompGridUsu.stInclusao);// layoutService.AcessoFormulario.lGrids.FirstOrDefault(C => C.NameGrid == grid.Name).InclusaoItem;
                            grid.AllowUserToAddRows = Convert.ToBoolean(objCompGrid.objConfigCompGridUsu.stExclusao);// layoutService.AcessoFormulario.lGrids.FirstOrDefault(C => C.NameGrid == grid.Name).ExclusaoItem;
                        }
                        else
                        {
                            grid.ReadOnly = !bHabilita;
                            grid.AllowUserToDeleteRows = bHabilita;
                            grid.AllowUserToAddRows = bHabilita;
                        }
                    }
                    else
                    {
                        grid.ReadOnly = !bHabilita;
                        grid.AllowUserToDeleteRows = bHabilita;
                        grid.AllowUserToAddRows = bHabilita;

                    }
                }
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

        }
        public void HabilitaButtonSpec(bool bHabilita)
        {
            var txt = lControles.OfType<HLP_TextBox>().ToList();
            foreach (HLP_TextBox t in txt)
            {
                t.btnPesquisaCampo.Visible = bHabilita;
            }
        }
        public void LimpaCampos()
        {
            foreach (Control ctr in lControles)
            {

                if (ctr.GetType().BaseType == typeof(UserControlBase))
                {
                    #region Controles Componentes

                    if ((ctr.GetType() == typeof(HLP_TextBox)) || (ctr.GetType() == typeof(HLP_NumericUpDown)) || (ctr.GetType() == typeof(HLP_MaskedTextBox)))
                    {
                        ConfigComponenteModel comp = iConfigFormulario.objConfigFormularioModel.lobjConfigComponente.FirstOrDefault(C => C.xName == ctr.Name);
                        if (comp.objConfigCompGridUsu != null)
                        {
                            ctr.SetPropertyValue("Text", iConfigFormulario.objConfigFormularioModel.lobjConfigComponente.FirstOrDefault(C => C.xName == ctr.Name).objConfigCompUsu.xText);
                        }

                        if (comp.xTable == "" && comp.xField == "" && (ctr.GetType() == typeof(HLP_NumericUpDown)))
                        {
                            ctr.SetPropertyValue("Text", "0");
                        }

                    }
                    else if (ctr.GetType() == typeof(HLP_ComboBox))
                    {
                        (ctr as HLP_ComboBox).SelectedIndex = -1;
                    }
                    else if (ctr.GetType() == typeof(HLP_DateTimePicker))
                    {
                        if ((ctr as HLP_DateTimePicker).dtp.Format == DateTimePickerFormat.Time)
                        {
                            (ctr as HLP_DateTimePicker).Value = DateTime.Today;
                        }
                        else
                        {
                            (ctr as HLP_DateTimePicker).Value = DateTime.Now;
                        }
                    }
                    else if (ctr.GetType() == typeof(HLP_CheckBox))
                    {
                        (ctr as HLP_CheckBox).Value = false;
                    }
                    else if (ctr.GetType() == typeof(HLP_Pesquisa))
                    {
                        ((HLP_Pesquisa)ctr).Value = 0;
                        ((HLP_Pesquisa)ctr).txtPesquisa.Text = "";
                        ((HLP_Pesquisa)ctr).txtDisplay.Text = "";
                        ((HLP_Pesquisa)ctr)._ListaValoresDisplay = new List<string>();
                    }
                    else if (ctr is HLP_ListBox)
                    {
                        (ctr as HLP_ListBox).lst.Items.Clear();
                    }

                    #endregion
                }
                else
                {
                    #region Controles Normais

                    if (ctr.GetType() == typeof(KryptonTextBox))
                    {
                        ctr.Text = "";
                    }
                    else if (ctr.GetType() == typeof(KryptonMaskedTextBox))
                    {
                        ctr.Text = "";
                    }
                    else if (ctr.GetType() == typeof(KryptonComboBox))
                    {
                        ((KryptonComboBox)ctr).SelectedIndex = -1;
                    }
                    else if (ctr.GetType() == typeof(KryptonDateTimePicker))
                    {
                        ((KryptonDateTimePicker)ctr).Value = DateTime.Now;
                    }
                    else if (ctr.GetType() == typeof(KryptonCheckedListBox))
                    {
                        ((KryptonCheckedListBox)ctr).Items.Clear();
                    }
                    else if (ctr.GetType() == typeof(KryptonCheckBox))
                    {
                        ((KryptonCheckBox)ctr).Checked = false;
                    }
                    else if (ctr.GetType() == typeof(KryptonRichTextBox))
                    {
                        ctr.Text = "";
                    }
                    else if (ctr.GetType() == typeof(KryptonNumericUpDown))
                    {
                        ((KryptonNumericUpDown)ctr).Value = 0;
                        ((KryptonNumericUpDown)ctr).Text = "0,00";
                    }
                    #endregion
                }
            }
            foreach (HLP_DataGridView grid in lControles.Where(c => c.GetType() == typeof(HLP_DataGridView)))
            {
                (grid.DataSource as BindingSource).Clear();
            }
        }


        public void JogarFocoPrimeiroComponente()
        {
            List<TabPage> ltabs = iConfigFormulario.GetTabPages();
            if (ltabs.Count() > 0)
            {
                (ltabs[0].Parent as AC.ExtendedRenderer.Navigator.KryptonTabControl).SelectedTab = ltabs[0];
            }
            List<Control> lctr = lControles.Where(C => C.Visible == true && C.GetType() != typeof(HLP_LabelSeparator)).ToList();
            if (lctr.Count > 0)
            {
                lctr[0].Focus();
            }
        }
        public void JogarFocoSegundoComponente()
        {
            List<TabPage> ltabs = iConfigFormulario.GetTabPages();
            if (ltabs.Count() > 0)
            {
                (ltabs[0].Parent as AC.ExtendedRenderer.Navigator.KryptonTabControl).SelectedTab = ltabs[0];
            }

            List<Control> lctr = lControles.Where(C => C.Visible == true && C.GetType() != typeof(HLP_LabelSeparator)).ToList();

            if (lctr.Count > 1)
            {
                lctr[1].Focus();
            }
            else if (lctr.Count() == 1)
            {
                lctr[0].Focus();
            }
        }

        public string GetDisplayMember(DataGridViewComboBoxColumn column)
        {
            try
            {
                string sDisplay = column.Tag.ToString().Split('-')[2];
                string sTable = column.Tag.ToString().Split('-')[1];
                column.DisplayMember = "DISPLAY";
                column.ValueMember = column.DataPropertyName;
                string sFields = "";
                List<PesquisaPadraoModel> listInformation = new List<PesquisaPadraoModel>();
                listInformation = pesquisaPadraoService.GetTableInformation(sTable);
                List<string> sql = new List<string>();
                if (listInformation.Where(C => C.COLUMN_NAME == "idEmpresa").Count() > 0)
                {
                    sql.Add("idEmpresa ='" + CompanyData.idEmpresa + "'");
                }
                if (listInformation.Where(C => C.COLUMN_NAME == "Ativo").Count() > 0)
                {
                    sql.Add("Ativo = 1");
                }

                //if (sWhere != "")
                //{
                //    sql.Add(sWhere);
                //}

                List<ConfigComponenteModel> lobjConfigComp = iConfigFormulario.objConfigFormularioModel.lobjConfigComponente.Where(c => c.xTypeComp == typeof(HLP_DataGridView).Name).ToList();
                //List<ConfigComponenteModel> lobjConfigComp = iConfigFormulario.objConfigFormularioModel.lobjConfigComponente.ToList();

                ConfigColunasGridModel objGridColumn = lobjConfigComp.FirstOrDefault(c => c.xName == column.DataGridView.Name).lConfigColunasGrid.FirstOrDefault(col => col.xDataPropertyName == column.DataPropertyName);

                if (objGridColumn != null)
                {
                    if (!String.IsNullOrEmpty(objGridColumn.objColunasGridUsu.xDisplayMember))
                    {
                        sFields = string.Format("{0}, " + objGridColumn.objColunasGridUsu.xDisplayMember + " as {1} ", "ID AS " + column.ValueMember, column.DisplayMember);
                    }
                    else
                    {
                        sDisplay = sDisplay.Contains('_') ? "concat("+sDisplay.Replace("_", ", ' - ' ,")+")" : sDisplay;
                        sFields = string.Format("{0}, {1} AS DISPLAY ", "ID AS " + column.ValueMember, sDisplay);
                    }
                }
                string sSelect = string.Format("SELECT {0} FROM {1}", sFields, sTable);
                switch (sql.Count)
                {
                    case 1:
                        sSelect += " WHERE " + sql[0].ToString();
                        break;

                    case 2:
                        sSelect += " WHERE " + sql[0].ToString() + " AND " + sql[1].ToString();
                        break;
                }
                return sSelect;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }


    }
}
