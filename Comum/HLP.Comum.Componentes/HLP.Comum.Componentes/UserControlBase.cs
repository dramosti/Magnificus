﻿using System;
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
using HLP.Comum.Infrastructure.Static;


namespace HLP.Comum.Components
{
    public partial class UserControlBase : UserControl
    {
        const string CAMPO_OBRIGATORIO = "Campo Obrigatório";
        const string CAMPO_INVALIDO = "Valor do Campo Inválido";

        [Browsable(false)]
        public bool _labelSuperior = false;

        [Browsable(false)]
        public ConfigComponenteModel objConfigComponenteModel { get; set; }
        [Browsable(false)]
        public Label lblBase = new Label();
        [Browsable(false)]
        public Control controleBase = new Control();
        [Browsable(false)]
        public bool _bConfiguracao;

        private void GetHLPGroup(Control value)
        {
            if (value.GetType() == typeof(HLP_Group))
            {
                this._hlpGroup = value as HLP_Group;
            }
            else if (value.Parent != null)
            {
                GetHLPGroup(value.Parent);
            }
        }
        private HLP_Group _hlpGroup;
        [Category("HLP")]
        [Description("HLP_Group em que o Componente se encontra.")]
        public HLP_Group _HlpGroup
        {
            get
            {
                _hlpGroup = null;
                GetHLPGroup(this);
                return _hlpGroup;
            }
        }


        [Browsable(false)]
        public bool bConfiguracao
        {
            get { return _bConfiguracao; }
            set
            {
                _bConfiguracao = value;
                if (value)
                    lblBase.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                else
                    lblBase.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }

        private void GetNameTabPage(Control value)
        {
            if (value.GetType() == typeof(TabPage))
            {
                sNameTabPage = value.Name;
            }
            else if (value.Parent != null)
            {
                GetNameTabPage(value.Parent);
            }
        }
        private string sNameTabPage = "";
        [Category("HLP")]
        [Description("TabPage em que o Componente se encontra.")]
        public string _sNameTabPage
        {
            get
            {
                sNameTabPage = "";
                GetNameTabPage(this);
                return sNameTabPage;
            }
        }

        private HLP_LabelSeparator _labelGroup;
        [Category("HLP")]
        [Description("Separador de Componentes")]
        public HLP_LabelSeparator _LabelGroup
        {
            get { return _labelGroup; }
            set
            {
                if (_labelGroup != null)
                {
                    if (value != _labelGroup)
                    {
                        _labelGroup.lComponentesBySerparador.Remove(this);
                    }
                }
                _labelGroup = value;
                if (_labelGroup != null)
                {
                    if (_labelGroup.lComponentesBySerparador.Where(c => c == this).Count() == 0)
                    {
                        _labelGroup.lComponentesBySerparador.Add(this);
                    }
                    _labelGroup.ConfigMaiorLabel();
                }
            }
        }

        public string SetSeparador
        {
            set
            {
                HLP_LabelSeparator sep = (this.Parent as FlowLayoutPanel).Controls.OfType<HLP_LabelSeparator>().ToList().FirstOrDefault(C => C.Name == value);
                if (sep != null)
                {
                    this._LabelGroup = sep;
                }
            }
        }


        public int _TamanhoLabel
        {
            get { return lblBase.Width; }
        }
        [Category("HLP")]
        [Description("Tamanho do Componente.")]
        public int _TamanhoComponente
        {
            get { return controleBase.Width; }
            set
            {
                controleBase.Width = value;
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
                try
                {
                    this.Visible = value;
                    if (bConfiguracao)
                    {
                        if (objConfigComponenteModel != null && objConfigComponenteModel.Base != null)
                        {
                            if (objConfigComponenteModel.Base.NULLABLE == "0")
                            {
                                this.Visible = true;
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    this.Visible = true;
                }
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
                if (value != "")
                {
                    if (!_labelSuperior)
                    {
                        int i = this.Width - lblBase.Width + 4;// controleBase.Width;
                        controleBase.Dock = DockStyle.None;
                        if (controleBase.GetType() == typeof(KryptonButton))
                            controleBase.Text = Util.ToUpperFirstLetter(value);
                        else
                            lblBase.Text = Util.ToUpperFirstLetter(value);
                        controleBase.Dock = DockStyle.Fill;
                        this.Width = _TamanhoLabel + i;
                    }
                    else
                    {
                        if (controleBase.GetType() == typeof(KryptonButton))
                            controleBase.Text = Util.ToUpperFirstLetter(value);
                        else
                            lblBase.Text = Util.ToUpperFirstLetter(value);

                        if (lblBase.Width > controleBase.Width)
                        {
                            this.Width = lblBase.Width;
                        }
                    }
                }
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

        public InfoFieldModel Base { get; set; }

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
                    objConfigComponenteModel.objConfigCompUsu.nOrder = (this.Parent as FlowLayoutPanel).Controls.GetChildIndex(this);
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
                    this.SetSeparador = objConfigComponenteModel.objConfigCompUsu.xLabelGroup;
                    this.TabIndex = objConfigComponenteModel.objConfigCompUsu.nOrder;
                    (this.Parent as FlowLayoutPanel).Controls.SetChildIndex(this, this.TabIndex);

                    if (!objConfigComponenteModel.xName.Equals("txtCodigo") && (objConfigComponenteModel.Base != null))
                    {
                        if (objConfigComponenteModel.Base.NULLABLE.Equals("0"))
                        {
                            this.SetPropertyValue("_Obrigatorio", HLP_TextBox.CampoObrigatorio.SIM);
                        }
                    }
                    else
                    {
                        this.SetPropertyValue("_Obrigatorio", HLP_TextBox.CampoObrigatorio.NÃO);
                    }
                }
                else
                {
                    this.SetPropertyValue("_Obrigatorio", HLP_TextBox.CampoObrigatorio.NÃO);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// True - Red
        /// False - Black
        /// </summary>
        /// <param name="bValor"></param>
        public void ChangeColorLabel(bool bValor)
        {
            try
            {
                if (bValor)
                    lblBase.ForeColor = Color.Red;
                else
                    lblBase.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public void lblBase_Click(object sender, EventArgs e)
        {
            controleBase.Focus();
            if (lblBase.ForeColor == Color.Red)
            {
                ctxConfig.Show(MousePosition.X, MousePosition.Y);
            }
        }

        public void MoveDown()
        {
            try
            {
                if (!this.Name.ToUpper().Equals("TXTCODIGO"))
                {
                    if ((this.Parent as FlowLayoutPanel).Controls.GetChildIndex(this) < ((this.Parent as FlowLayoutPanel).Controls.Count - 1))
                    {
                        if (((this.Parent as FlowLayoutPanel).Controls[((this.Parent as FlowLayoutPanel).Controls.GetChildIndex(this) + 1)]).GetType() != typeof(HLP_LabelSeparator))
                        {
                            (this.Parent as FlowLayoutPanel).Controls.SetChildIndex(this, (this.Parent as FlowLayoutPanel).Controls.GetChildIndex(this) + 1);

                            this.TabIndex = (this.Parent as FlowLayoutPanel).Controls.GetChildIndex(this);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void MoveUp()
        {
            try
            {
                if (!this.Name.ToUpper().Equals("TXTCODIGO"))
                {
                    int index = (this.Parent as FlowLayoutPanel).Controls.GetChildIndex(this) - 1;
                    if (!((this.Parent as FlowLayoutPanel).Controls[index].Name.ToUpper().Equals("TXTCODIGO")))
                    {
                        if ((this.Parent as FlowLayoutPanel).Controls.GetChildIndex(this) > 0)
                        {
                            //if (((this.Parent as FlowLayoutPanel).Controls[(index)]).GetType() != typeof(HLP_LabelSeparator))
                            {
                                (this.Parent as FlowLayoutPanel).Controls.SetChildIndex(this, index);
                                this.TabIndex = index;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal void Initialize()
        {
            this.InitializeComponent();
            if ((controleBase.GetType() != typeof(KryptonButton)))
            {
                this.SizeChanged -= UserControlBase_SizeChanged;
                this.SizeChanged += UserControlBase_SizeChanged;
                controleBase.SizeChanged -= UserControlBase_SizeChanged;
                controleBase.SizeChanged += UserControlBase_SizeChanged;
            }          
        }

        private void UserControlBase_SizeChanged(object sender, EventArgs e)
        {
            if (_labelSuperior)
            {
                if (controleBase.Width > this.Width)
                {
                    controleBase.Width = this.Width - 2;
                }
            }
            else
            {
                if (this._hlpGroup != null)
                {
                    this._hlpGroup.ConfigMaiorLabel();
                }
            }
        }
    }
}
