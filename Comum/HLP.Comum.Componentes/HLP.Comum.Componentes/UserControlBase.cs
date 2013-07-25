using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using HLP.Comum.Models;
using System.Text.RegularExpressions;
using HLP.Comum.Infrastructure;
using HLP.Comum.Models.Static;

namespace HLP.Comum.Components
{
    public partial class UserControlBase : UserControl
    {
        const string CAMPO_OBRIGATORIO = "Campo Obrigatório";
        const string CAMPO_INVALIDO = "Valor do Campo Inválido";


        [Browsable(false)]
        public ConfigComponenteModel objConfigComponenteModel { get; set; }
        [Browsable(false)]
        public Label lblBase = new Label();
        [Browsable(false)]
        public Control controleBase = new Control();


        [Category("HLP")]
        [Description("Separador de Componentes")]
        public HLP_LabelSeparator _LabelGroup { get; set; }

        public int _TamanhoLabel
        {
            get { return lblBase.Width; }
        }
        [Category("HLP")]
        [Description("Tamanho do Componente.")]
        public int _TamanhoComponente
        {
            get { return this.Width - lblBase.Width; }
            set
            {
                this.Width = lblBase.Width + value;
            }
        }

        private int _tamanhoMaiorLabel;
        [Category("HLP")]
        [Description("Tamanho do maior Label dentro do Container.")]
        public int _TamanhoMaiorLabel
        {
            get { return _tamanhoMaiorLabel; }
            set
            {
                _tamanhoMaiorLabel = value;
                int Margem = value - lblBase.Width + 3;
                this.Margin = new System.Windows.Forms.Padding(Margem, 3, 15, 3);

            }
        }

        
        [Category("HLP")]
        [Description("Indica se o componente estará visível para o Usuário")]
        [DefaultValue(true)]
        public virtual bool _Visible
        {
            get { return this.Visible; }
            set
            {
                
                if (objConfigComponenteModel != null && objConfigComponenteModel.Base != null)
                {
                    if (objConfigComponenteModel.Base.NULLABLE == "0")
                    {
                        this.Visible = true;
                    }
                    else
                        this.Visible = value;
                }
                else
                    this.Visible = value;

                //MessageBox.Show(value.ToString());
            }
        }

        private string _table = "";
        [Category("HLP")]
        [Description("Nome da Tabela, caso não tenha referencia com banco, deixar em branco.")]
        [DefaultValue("")]
        public string _Table
        {
            get { return (_table == null ? "" : _table); }
            set { _table = value; }
        }


        private string _field = "";
        [Category("HLP")]
        [Description("Nome do campo na Tabela, caso não tenha referencia com banco, deixar em branco.")]
        [DefaultValue("")]
        public string _Field
        {
            get { return (_field == null ? "" : _field); }
            set { _field = value; }
        }

        [Category("HLP")]
        [Description("Texto do Label")]
        [DefaultValue("")]
        public string _LabelText
        {
            get
            {
                if (controleBase.GetType() == typeof(KryptonButton))
                    return controleBase.Text;
                else
                    return (lblBase != null ? lblBase.Text : "Hlp_Label");
            }
            set
            {
                int i = controleBase.Width;
                controleBase.Dock = DockStyle.None;
                if (controleBase.GetType() == typeof(KryptonButton))
                    controleBase.Text = Util.ToUpperFirstLetter(value);
                else
                    lblBase.Text = Util.ToUpperFirstLetter(value);
                controleBase.Dock = DockStyle.Fill;
                this.Width = _TamanhoLabel + i;
            }
        }

        [Category("HLP")]
        [Description("Help do Componente")]
        [DefaultValue("")]
        public string _Regex { get; set; }

        private string _help = "";
        [Category("HLP")]
        [Description("Help do Componente")]
        [DefaultValue("")]
        public string _Help
        {
            get { return _help; }
            set
            {
                _help = Util.ToUpperFirstLetter(value);
            }
        }

        private CampoObrigatorio _obrigatorio = CampoObrigatorio.NÃO;
        [Category("HLP")]
        [Description("Indica se o componente é obrigatório")]
        public CampoObrigatorio _Obrigatorio
        {
            get { return _obrigatorio; }
            set
            {
                _obrigatorio = value;
            }
        }

        public InfoField Base { get; set; }

        public enum CampoObrigatorio
        {
            SIM,
            NÃO
        }

        public void SetError(string sMessage)
        {
            errorProv.SetError(controleBase, sMessage);
        }

        public bool Validar()
        {
            try
            {
                HLP_MaskedTextBox maskIE = null;
                Regex reg = null;
                Control firstControl = null;
                bool bValida = true;
                try
                {
                    #region ComboBox

                    if (controleBase.GetType() == typeof(HLP_ComboBox))
                    {
                        ((HLP_ComboBox)controleBase).errorProvider1.Dispose();
                        if (((HLP_ComboBox)controleBase)._Obrigatorio == HLP_ComboBox.CampoObrigatorio.SIM && ((HLP_ComboBox)controleBase).SelectedIndex == -1)
                        {
                            ((HLP_ComboBox)controleBase).errorProvider1.SetError(((HLP_ComboBox)controleBase), CAMPO_OBRIGATORIO);
                            if (firstControl == null) { firstControl = controleBase; }
                            bValida = false;
                        }
                    }

                    #endregion

                    #region DateTimePicker

                    else if (controleBase.GetType() == typeof(HLP_DateTimePicker))
                    {
                        ((HLP_DateTimePicker)controleBase).errorProvider1.Dispose();
                        if (((HLP_DateTimePicker)controleBase)._Obrigatorio == CampoObrigatorio.SIM && ((HLP_DateTimePicker)controleBase).Value == null)
                        {
                            ((HLP_DateTimePicker)controleBase).errorProvider1.SetError(((HLP_DateTimePicker)controleBase), CAMPO_OBRIGATORIO);
                            if (firstControl == null) { firstControl = controleBase; }
                            bValida = false;
                        }
                    }

                    #endregion

                    #region MaskedTextBox

                    else if (controleBase.GetType() == typeof(HLP_MaskedTextBox))
                    {

                        ((HLP_MaskedTextBox)controleBase).MaskFormat = MaskFormat.ExcludePromptAndLiterals;
                        string sText = ((HLP_MaskedTextBox)controleBase).Text;
                        ((HLP_MaskedTextBox)controleBase).MaskFormat = MaskFormat.IncludeLiterals;
                        bool MaskValido = true;

                        ((HLP_MaskedTextBox)controleBase).errorProvider1.Dispose();
                        if (((HLP_MaskedTextBox)controleBase)._Obrigatorio == HLP_MaskedTextBox.CampoObrigatorio.SIM && ((HLP_MaskedTextBox)controleBase)._TpValidacao != HLP_MaskedTextBox.TipoValidacao.DEFAULT)
                        {
                            MaskValido = ((HLP_MaskedTextBox)controleBase).Valida();

                            if (((HLP_MaskedTextBox)controleBase)._TpValidacao == HLP_MaskedTextBox.TipoValidacao.IE && !MaskValido)
                            {
                                maskIE = ((HLP_MaskedTextBox)controleBase);
                            }
                            else if (!MaskValido)
                            {
                                ((HLP_MaskedTextBox)controleBase).errorProvider1.SetError(((HLP_MaskedTextBox)controleBase), CAMPO_INVALIDO);
                                bValida = false;
                            }
                        }
                        else if (((HLP_MaskedTextBox)controleBase)._Obrigatorio == HLP_MaskedTextBox.CampoObrigatorio.SIM && sText.Equals(""))
                        {
                            ((HLP_MaskedTextBox)controleBase).errorProvider1.SetError(((HLP_MaskedTextBox)controleBase), CAMPO_OBRIGATORIO);
                            bValida = false;
                            if (firstControl == null) { firstControl = controleBase; }
                            MaskValido = false;
                        }

                        if (MaskValido)
                        {
                            if (((HLP_MaskedTextBox)controleBase)._Obrigatorio == HLP_MaskedTextBox.CampoObrigatorio.NÃO && !sText.Equals(""))
                            {
                                if (((HLP_MaskedTextBox)controleBase).Mask.Length != ((HLP_MaskedTextBox)controleBase).Text.Length)
                                {
                                    ((HLP_MaskedTextBox)controleBase).errorProvider1.SetError(((HLP_MaskedTextBox)controleBase), CAMPO_INVALIDO);
                                    bValida = false;
                                    if (firstControl == null) { firstControl = controleBase; }
                                }
                            }
                            else if (((HLP_MaskedTextBox)controleBase)._Obrigatorio == HLP_MaskedTextBox.CampoObrigatorio.SIM)
                            {
                                if (((HLP_MaskedTextBox)controleBase).Mask != "")
                                {

                                    if (((HLP_MaskedTextBox)controleBase).Mask.Length != ((HLP_MaskedTextBox)controleBase).Text.Length)
                                    {
                                        ((HLP_MaskedTextBox)controleBase).errorProvider1.SetError(((HLP_MaskedTextBox)controleBase), CAMPO_INVALIDO);
                                        bValida = false;
                                        if (firstControl == null) { firstControl = controleBase; }
                                    }
                                }
                            }

                        }
                    }

                    #endregion

                    #region NumericUpDown

                    else if (controleBase.GetType() == typeof(HLP_NumericUpDown))
                    {
                        ((HLP_NumericUpDown)controleBase).errorProvider1.Dispose();
                        if (((HLP_NumericUpDown)controleBase)._Obrigatorio == HLP_NumericUpDown.CampoObrigatorio.SIM && ((HLP_NumericUpDown)controleBase).Text.Equals(""))
                        {
                            ((HLP_NumericUpDown)controleBase).errorProvider1.SetError(((HLP_NumericUpDown)controleBase), CAMPO_OBRIGATORIO);
                            bValida = false;
                            if (firstControl == null) { firstControl = controleBase; }
                        }
                    }

                    #endregion

                    #region TextBox

                    else if (controleBase.GetType() == typeof(HLP_TextBox))
                    {
                        bool TextValido = true;
                        ((HLP_TextBox)controleBase).errorProvider1.Dispose();
                        if (((HLP_TextBox)controleBase)._Obrigatorio == HLP_TextBox.CampoObrigatorio.SIM && ((HLP_TextBox)controleBase).Text.Equals(""))
                        {
                            ((HLP_TextBox)controleBase).errorProvider1.SetError(((HLP_TextBox)controleBase), CAMPO_OBRIGATORIO);
                            bValida = false;
                            if (firstControl == null) { firstControl = controleBase; }
                            TextValido = false;
                        }
                        if (TextValido)
                        {
                            if (!String.IsNullOrEmpty(((HLP_TextBox)controleBase)._Regex))
                            {
                                if (((HLP_TextBox)controleBase)._Obrigatorio == HLP_TextBox.CampoObrigatorio.NÃO && !((HLP_TextBox)controleBase).Text.Equals(""))
                                {
                                    reg = new Regex(((HLP_TextBox)controleBase)._Regex);
                                    if (!reg.IsMatch(((HLP_TextBox)controleBase).Text))
                                    {
                                        ((HLP_TextBox)controleBase).errorProvider1.SetError(((HLP_TextBox)controleBase), CAMPO_INVALIDO);
                                        bValida = false;
                                        if (firstControl == null) { firstControl = controleBase; }
                                    }
                                }
                                else if (((HLP_TextBox)controleBase)._Obrigatorio == HLP_TextBox.CampoObrigatorio.SIM)
                                {
                                    reg = new Regex(((HLP_TextBox)controleBase)._Regex);
                                    if (!reg.IsMatch(((HLP_TextBox)controleBase).Text))
                                    {
                                        ((HLP_TextBox)controleBase).errorProvider1.SetError(((HLP_TextBox)controleBase), CAMPO_INVALIDO);
                                        bValida = false;
                                        if (firstControl == null) { firstControl = controleBase; }
                                    }
                                }
                            }
                        }
                    }

                    #endregion

                    #region Componente Pesquisa

                    else if (controleBase.GetType() == typeof(HLP_Pesquisa))
                    {
                        ((HLP_Pesquisa)controleBase).errorProvider1.Dispose();
                        if (((HLP_Pesquisa)controleBase)._Obrigatorio == HLP_Pesquisa.CampoObrigatorio.SIM && ((HLP_Pesquisa)controleBase).Value == 0)
                        {
                            ((HLP_Pesquisa)controleBase).errorProvider1.SetError(((HLP_Pesquisa)controleBase), CAMPO_OBRIGATORIO);
                            bValida = false;
                            if (firstControl == null) { firstControl = controleBase; }
                        }
                    }

                    #endregion
                }
                catch (System.Exception)
                {
                    throw new System.Exception("erro ao configurar o componente " + controleBase.Name + " - Tipo: " + controleBase.GetType());
                }


                //FAZER NO COMPONENTE DE GRID
                //foreach (KryptonDataGridView grid in layoutService.lKryptonDataGridView)
                //{
                //    #region Grid
                //    Models.Grid objGrid = layoutService.objConfig.DataGrid.FirstOrDefault(C => C.Name == grid.Name);

                //    grid.CurrentCell = grid.FirstDisplayedCell;
                //    if (grid.AllowUserToAddRows)
                //    {
                //        if ((grid.DataSource as BindingSource).List.Count == grid.RowCount)
                //        {
                //            (grid.DataSource as BindingSource).List.RemoveAt((grid.DataSource as BindingSource).List.Count - 1);
                //        }
                //    }
                //    int iRows = grid.AllowUserToAddRows ? grid.RowCount - 1 : grid.RowCount;
                //    for (int row = 0; row < iRows; row++)
                //    {
                //        for (int col = 0; col < grid.ColumnCount; col++)
                //        {
                //            grid[col, row].Style.BackColor = Color.White;

                //            if (objGrid.DataGridColumn.FirstOrDefault(C => C.DataPropertyName == grid.Columns[col].DataPropertyName).BaseConfigGrid.Required)
                //            {
                //                if (grid[col, row].GetType() == typeof(DataGridViewComboBoxCell))
                //                {
                //                    if (((DataGridViewComboBoxCell)grid[col, row]).DataSource != null)
                //                    {
                //                        if (((DataGridViewComboBoxCell)grid[col, row]).Value.GetType() == typeof(Int32))
                //                        {
                //                            if ((int)((DataGridViewComboBoxCell)grid[col, row]).Value == 0)
                //                            {
                //                                grid[col, row].Style.BackColor = Color.Red;
                //                                iErros++;
                //                                if (firstControl == null) { firstControl = grid; }
                //                            }
                //                        }
                //                    }
                //                }
                //                else if (grid[col, row].Value == null)
                //                {
                //                    grid[col, row].Style.BackColor = Color.Red;
                //                    iErros++;
                //                    if (firstControl == null) { firstControl = grid; }
                //                }
                //                else if (grid[col, row].Value.ToString() == "")
                //                {
                //                    grid[col, row].Style.BackColor = Color.Red;
                //                    iErros++;
                //                    if (firstControl == null) { firstControl = grid; }
                //                }

                //            }
                //        }
                //    }
                //    #endregion
                //}


                if (maskIE != null)
                {
                    string sMessage = "Inscrição estadual inválida, ";
                    if (maskIE._UF == "")
                    {
                        sMessage += "Selecione uma cidade no endereço principal.";
                    }


                    if (KryptonMessageBox.Show(null, sMessage + "\ndeseja assim mesmo confirmar o cadastro?", "A V I S O", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        bValida = false;
                        maskIE.errorProvider1.SetError(maskIE, CAMPO_INVALIDO);
                    }
                }

                //if (iErros > 0)
                //{
                //    if (firstControl != null)
                //    {
                //        ProcuraTabPage(firstControl);
                //        firstControl.Focus();
                //    }
                //    throw new System.Exception(Mensagens.CampoVazio_Incorreto);
                //}
                return bValida;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public virtual void CarregaobjConfigComponenteModelByControle()
        {
            try
            {
                if (objConfigComponenteModel != null)
                {
                    objConfigComponenteModel.objConfigCompUsu.xLabelText = this._LabelText;
                    objConfigComponenteModel.objConfigCompUsu.xHelp = this._help;
                    objConfigComponenteModel.objConfigCompUsu.stVisible = this.Visible.ToByte();
                    objConfigComponenteModel.objConfigCompUsu.iTamanhoComponente = this._TamanhoComponente;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual void CarregaComponente()
        {
            try
            {
                if (objConfigComponenteModel != null)
                {
                    this._LabelText = objConfigComponenteModel.objConfigCompUsu.xLabelText;
                    this._help = objConfigComponenteModel.objConfigCompUsu.xHelp;
                    this._Visible = objConfigComponenteModel.objConfigCompUsu.stVisible.ToBoolean();
                    this._TamanhoComponente = objConfigComponenteModel.objConfigCompUsu.iTamanhoComponente.ToInt32();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
