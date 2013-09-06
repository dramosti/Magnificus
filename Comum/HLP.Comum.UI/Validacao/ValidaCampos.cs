using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Messages;
using System.Windows.Forms;
using HLP.Comum.Components;
using System.Text.RegularExpressions;
using ComponentFactory.Krypton.Toolkit;
using HLP.Comum.Services.Interface;
using System.Drawing;
using HLP.Comum.UI.Eventos;
using System.Reflection;
using HLP.Comum.Services.Interface.Configuracao;
using HLP.Comum.Infrastructure;

using HLP.Comum.Models;

namespace HLP.Comum.UI.Validacao
{
    public class ValidaCampos
    {
        public IConfigFormulariosService iConfigFormulario { get; set; }
        EventosForm objEventosForm { get; set; }
        const string CAMPO_OBRIGATORIO = "Campo Obrigatório";
        const string CAMPO_INVALIDO = "Valor do Campo Inválido";


        public ValidaCampos(IConfigFormulariosService iConfigFormulario, EventosForm objEventosForm)
        {
            this.iConfigFormulario = iConfigFormulario;
            this.objEventosForm = objEventosForm;
        }

        public int Validar()
        {
            try
            {
                objEventosForm.ValidaTodosComponentesPesquisa();
                List<Control> lgrids = iConfigFormulario.lControl.Where(c => c.GetType() == typeof(HLP_DataGridView)).ToList();

                foreach (Control controle in lgrids)
                {
                    HLP_DataGridView grid = controle as HLP_DataGridView;
                    grid.EndEdit();
                }

                int iErros = 0;
                HLP_MaskedTextBox maskIE = null;

                Regex reg = null;
                Control firstControl = null;
                foreach (Control ctr in iConfigFormulario.lControl.Where(c => (c.GetType() != typeof(HLP_DataGridView)) && (c.GetType() != typeof(FlowLayoutPanel))))
                {
                    try
                    {
                        if (ctr.GetType().BaseType == typeof(UserControlBase))
                        {
                            Assembly assembly = ctr.GetType().Assembly;
                            Type classe = assembly.GetType(ctr.GetType().FullName);
                            MethodInfo metodo = classe.GetMethod("Validar");
                            object ret = metodo.Invoke((object)ctr, new object[] { });
                            bool b = Convert.ToBoolean(ret);

                            #region ComboBox

                            if (ctr.GetType() == typeof(HLP_ComboBox))
                            {
                                //((HLP_ComboBox)ctr).errorProvider1.Dispose();
                                (ctr as UserControlBase).ChangeColorLabel(false);
                                if (((HLP_ComboBox)ctr)._Obrigatorio == HLP_ComboBox.CampoObrigatorio.SIM && ((HLP_ComboBox)ctr).SelectedIndex == -1)
                                {
                                    //((HLP_ComboBox)ctr).errorProvider1.SetError(((HLP_ComboBox)ctr), CAMPO_OBRIGATORIO);

                                    (ctr as UserControlBase).ChangeColorLabel(true);
                                    iErros++;
                                    if (firstControl == null) { firstControl = ctr; }
                                }
                            }

                            #endregion

                            #region DateTimePicker

                            else if (ctr.GetType() == typeof(HLP_DateTimePicker))
                            {
                                //((HLP_DateTimePicker)ctr).errorProvider1.Dispose();
                                (ctr as UserControlBase).ChangeColorLabel(false);
                                if (((HLP_DateTimePicker)ctr)._Obrigatorio == UserControlBase.CampoObrigatorio.SIM && ((HLP_DateTimePicker)ctr).Value == null)
                                {
                                    //((HLP_DateTimePicker)ctr).errorProvider1.SetError(((HLP_DateTimePicker)ctr), CAMPO_OBRIGATORIO);
                                    (ctr as UserControlBase).ChangeColorLabel(true);
                                    iErros++;
                                    if (firstControl == null) { firstControl = ctr; }
                                }
                            }

                            #endregion

                            #region MaskedTextBox

                            else if (ctr.GetType() == typeof(HLP_MaskedTextBox))
                            {

                                ((HLP_MaskedTextBox)ctr).MaskFormat = MaskFormat.ExcludePromptAndLiterals;
                                string sText = ((HLP_MaskedTextBox)ctr).Text;
                                ((HLP_MaskedTextBox)ctr).MaskFormat = MaskFormat.IncludeLiterals;
                                bool MaskValido = true;

                                //((HLP_MaskedTextBox)ctr).errorProvider1.Dispose();
                                (ctr as UserControlBase).ChangeColorLabel(false);
                                if (((HLP_MaskedTextBox)ctr)._Obrigatorio == HLP_MaskedTextBox.CampoObrigatorio.SIM && ((HLP_MaskedTextBox)ctr)._TpValidacao != HLP_MaskedTextBox.TipoValidacao.DEFAULT)
                                {
                                    MaskValido = ((HLP_MaskedTextBox)ctr).Valida();

                                    if (((HLP_MaskedTextBox)ctr)._TpValidacao == HLP_MaskedTextBox.TipoValidacao.IE && !MaskValido)
                                    {
                                        maskIE = ((HLP_MaskedTextBox)ctr);
                                    }
                                    else if (!MaskValido)
                                    {
                                        //((HLP_MaskedTextBox)ctr).errorProvider1.SetError(((HLP_MaskedTextBox)ctr), CAMPO_INVALIDO);
                                        (ctr as UserControlBase).ChangeColorLabel(true);
                                        iErros++;
                                    }
                                }
                                else if (((HLP_MaskedTextBox)ctr)._Obrigatorio == HLP_MaskedTextBox.CampoObrigatorio.SIM && sText.Equals(""))
                                {
                                    //((HLP_MaskedTextBox)ctr).errorProvider1.SetError(((HLP_MaskedTextBox)ctr), CAMPO_OBRIGATORIO);
                                    (ctr as UserControlBase).ChangeColorLabel(true);
                                    iErros++;
                                    if (firstControl == null) { firstControl = ctr; }
                                    MaskValido = false;
                                }

                                if (MaskValido)
                                {
                                    if (((HLP_MaskedTextBox)ctr)._Obrigatorio == HLP_MaskedTextBox.CampoObrigatorio.NÃO && !sText.Equals(""))
                                    {
                                        if (((HLP_MaskedTextBox)ctr).Mask.Length != ((HLP_MaskedTextBox)ctr).Text.Length)
                                        {
                                            //((HLP_MaskedTextBox)ctr).errorProvider1.SetError(((HLP_MaskedTextBox)ctr), CAMPO_INVALIDO);
                                            (ctr as UserControlBase).ChangeColorLabel(true);
                                            iErros++;
                                            if (firstControl == null) { firstControl = ctr; }
                                        }
                                    }
                                    else if (((HLP_MaskedTextBox)ctr)._Obrigatorio == HLP_MaskedTextBox.CampoObrigatorio.SIM)
                                    {
                                        if (((HLP_MaskedTextBox)ctr).Mask != "")
                                        {

                                            if (((HLP_MaskedTextBox)ctr).Mask.Length != ((HLP_MaskedTextBox)ctr).Text.Length)
                                            {
                                                //((HLP_MaskedTextBox)ctr).errorProvider1.SetError(((HLP_MaskedTextBox)ctr), CAMPO_INVALIDO);
                                                (ctr as UserControlBase).ChangeColorLabel(true);
                                                iErros++;
                                                if (firstControl == null) { firstControl = ctr; }
                                            }
                                        }
                                    }

                                }
                            }

                            #endregion

                            #region NumericUpDown

                            else if (ctr.GetType() == typeof(HLP_NumericUpDown))
                            {
                                //((HLP_NumericUpDown)ctr).errorProvider1.Dispose();
                                (ctr as UserControlBase).ChangeColorLabel(false);
                                if (((HLP_NumericUpDown)ctr)._Obrigatorio == HLP_NumericUpDown.CampoObrigatorio.SIM && ((HLP_NumericUpDown)ctr).Text.Equals(""))
                                {
                                    //((HLP_NumericUpDown)ctr).errorProvider1.SetError(((HLP_NumericUpDown)ctr), CAMPO_OBRIGATORIO);
                                    (ctr as UserControlBase).ChangeColorLabel(true);
                                    iErros++;
                                    if (firstControl == null) { firstControl = ctr; }
                                }
                            }

                            #endregion

                            #region TextBox

                            else if (ctr.GetType() == typeof(HLP_TextBox))
                            {
                                bool TextValido = true;
                                //((HLP_TextBox)ctr).errorProvider1.Dispose();
                                (ctr as UserControlBase).ChangeColorLabel(false);
                                if (((HLP_TextBox)ctr)._Obrigatorio == HLP_TextBox.CampoObrigatorio.SIM && ((HLP_TextBox)ctr).Text.Equals(""))
                                {
                                    //((HLP_TextBox)ctr).errorProvider1.SetError(((HLP_TextBox)ctr), CAMPO_OBRIGATORIO);
                                    (ctr as UserControlBase).ChangeColorLabel(true);
                                    iErros++;
                                    if (firstControl == null) { firstControl = ctr; }
                                    TextValido = false;
                                }
                                if (TextValido)
                                {
                                    if (!String.IsNullOrEmpty(((HLP_TextBox)ctr)._Regex))
                                    {
                                        if (((HLP_TextBox)ctr)._Obrigatorio == HLP_TextBox.CampoObrigatorio.NÃO && !((HLP_TextBox)ctr).Text.Equals(""))
                                        {
                                            reg = new Regex(((HLP_TextBox)ctr)._Regex);
                                            if (!reg.IsMatch(((HLP_TextBox)ctr).Text))
                                            {
                                                //((HLP_TextBox)ctr).errorProvider1.SetError(((HLP_TextBox)ctr), CAMPO_INVALIDO);
                                                (ctr as UserControlBase).ChangeColorLabel(true);
                                                iErros++;
                                                if (firstControl == null) { firstControl = ctr; }
                                            }
                                        }
                                        else if (((HLP_TextBox)ctr)._Obrigatorio == HLP_TextBox.CampoObrigatorio.SIM)
                                        {
                                            reg = new Regex(((HLP_TextBox)ctr)._Regex);
                                            if (!reg.IsMatch(((HLP_TextBox)ctr).Text))
                                            {
                                                //((HLP_TextBox)ctr).errorProvider1.SetError(((HLP_TextBox)ctr), CAMPO_INVALIDO);
                                                (ctr as UserControlBase).ChangeColorLabel(true);
                                                iErros++;
                                                if (firstControl == null) { firstControl = ctr; }
                                            }
                                        }
                                    }
                                }
                            }

                            #endregion

                            #region Componente Pesquisa

                            else if (ctr.GetType() == typeof(HLP_Pesquisa))
                            {
                                //((HLP_Pesquisa)ctr).errorProvider1.Dispose();
                                (ctr as UserControlBase).ChangeColorLabel(false);
                                if (((HLP_Pesquisa)ctr)._Obrigatorio == HLP_Pesquisa.CampoObrigatorio.SIM && ((HLP_Pesquisa)ctr).Value == 0)
                                {
                                    //((HLP_Pesquisa)ctr).errorProvider1.SetError(((HLP_Pesquisa)ctr), CAMPO_OBRIGATORIO);
                                    (ctr as UserControlBase).ChangeColorLabel(true);
                                    iErros++;
                                    if (firstControl == null) { firstControl = ctr; }
                                }
                            }

                            #endregion
                        }
                    }
                    catch (System.Exception ex)
                    {
                        throw new System.Exception("erro ao configurar o componente " + ctr.Name + " - Tipo: " + ctr.GetType());
                    }

                }


                foreach (Control controle in lgrids)
                {
                    HLP_DataGridView grid = controle as HLP_DataGridView;
                    #region Grid
                    ConfigComponenteModel objGrid = iConfigFormulario.objConfigFormularioModel.lobjConfigComponente.FirstOrDefault(c => c.xName == grid.Name);

                    grid.CurrentCell = grid.FirstDisplayedCell;
                    if (grid.AllowUserToAddRows)
                    {
                        if ((grid.DataSource as BindingSource).List.Count == grid.RowCount)
                        {
                            (grid.DataSource as BindingSource).List.RemoveAt((grid.DataSource as BindingSource).List.Count - 1);
                        }
                    }
                    int iRows = grid.AllowUserToAddRows ? grid.RowCount - 1 : grid.RowCount;
                    for (int row = 0; row < iRows; row++)
                    {
                        for (int col = 0; col < grid.ColumnCount; col++)
                        {
                            grid[col, row].Style.BackColor = Color.White;
                            try
                            {
                                if (objGrid.lConfigColunasGrid.FirstOrDefault(c => c.xDataPropertyName == grid.Columns[col].DataPropertyName).Base.NULLABLE == "0")
                                {
                                    if (grid[col, row].GetType() == typeof(DataGridViewComboBoxCell))
                                    {
                                        if (((DataGridViewComboBoxCell)grid[col, row]).DataSource != null)
                                        {
                                            if (((DataGridViewComboBoxCell)grid[col, row]).Value.GetType() == typeof(Int32))
                                            {
                                                if ((int)((DataGridViewComboBoxCell)grid[col, row]).Value == 0)
                                                {
                                                    grid[col, row].Style.BackColor = Color.Red;
                                                    iErros++;
                                                    if (firstControl == null) { firstControl = grid; }
                                                }
                                            }
                                        }
                                    }
                                    else if (grid[col, row].Value == null)
                                    {
                                        grid[col, row].Style.BackColor = Color.Red;
                                        iErros++;
                                        if (firstControl == null) { firstControl = grid; }
                                    }
                                    else if (grid[col, row].Value.ToString() == "")
                                    {
                                        grid[col, row].Style.BackColor = Color.Red;
                                        iErros++;
                                        if (firstControl == null) { firstControl = grid; }
                                    }

                                }
                            }
                            catch (System.Exception ex)
                            {

                                throw;
                            }

                        }
                    }
                    #endregion
                }
                if (maskIE != null)
                {
                    string sMessage = "Inscrição estadual inválida, ";
                    if (maskIE._UF == "")
                    {
                        sMessage += "Selecione uma cidade no endereço principal.";
                    }


                    if (KryptonMessageBox.Show(null, sMessage + "\ndeseja assim mesmo confirmar o cadastro?", "A V I S O", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        iErros++;
                        //maskIE.errorProvider1.SetError(maskIE, CAMPO_INVALIDO);
                        (maskIE as UserControlBase).ChangeColorLabel(true);
                    }

                }

                if (iErros > 0)
                {
                    if (firstControl != null)
                    {
                        ProcuraTabPage(firstControl);
                        firstControl.Focus();
                    }
                    throw new System.Exception(Mensagens.CampoVazio_Incorreto);
                }



                return iErros;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public void LimpaErros()
        {
            try
            {
                foreach (Control ctr in iConfigFormulario.lControl.Where(c=>c.GetType().BaseType == typeof(UserControlBase)))
                {
                    //if (ctr.GetType() == typeof(HLP_ComboBox))
                    //{
                    //    ((HLP_ComboBox)ctr).errorProvider1.Dispose();
                    //}
                    //else if (ctr.GetType() == typeof(HLP_DateTimePicker))
                    //{
                    //    ((HLP_DateTimePicker)ctr).errorProvider1.Dispose();
                    //}
                    //else if (ctr.GetType() == typeof(HLP_MaskedTextBox))
                    //{
                    //    ((HLP_MaskedTextBox)ctr).errorProvider1.Dispose();
                    //}
                    //else if (ctr.GetType() == typeof(HLP_NumericUpDown))
                    //{
                    //    ((HLP_NumericUpDown)ctr).errorProvider1.Dispose();
                    //}
                    //else if (ctr.GetType() == typeof(HLP_TextBox))
                    //{
                    //    ((HLP_TextBox)ctr).errorProvider1.Dispose();
                    //}
                    //else if (ctr.GetType() == typeof(HLP_Pesquisa))
                    //{
                    //    ((HLP_Pesquisa)ctr).errorProvider1.Dispose();
                    //}
                    (ctr as UserControlBase).ChangeColorLabel(false);
                }
            }
            catch (System.Exception)
            {

                throw;
            }

        }

        private void ProcuraTabPage(Control controle)
        {
            if (controle.Parent != null)
            {
                if (controle.Parent.GetType() == typeof(TabPage))
                {
                    (controle.Parent.Parent as TabControl).SelectedTab = (controle.Parent as TabPage);
                }
                ProcuraTabPage(controle.Parent);
            }
        }
    }
}
