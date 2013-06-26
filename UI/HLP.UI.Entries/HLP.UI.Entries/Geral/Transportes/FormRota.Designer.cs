using HLP.Comum.Components;
namespace HLP.UI.Entries.Geral.Transportes
{
    partial class FormRota
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRota));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.hlP_LabelSeparator1_Geral = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtCodigo = new HLP.Comum.Components.HLP_TextBox();
            this.txtxRota = new HLP.Comum.Components.HLP_TextBox();
            this.campoPesquisaListaPreco = new HLP.Comum.Components.HLP_Pesquisa();
            this.cboAtivo = new HLP.Comum.Components.HLP_ComboBox();
            this.dgvRotaPraca = new HLP.Comum.Components.HLP_DataGridView();
            this.clnOrdem = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.clnDistanciaProximaCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clidCidade = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsRotaPraca = new System.Windows.Forms.BindingSource(this.components);
            this.kryptonTabControl2 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.kryptonPanel1 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).BeginInit();
            this.panelPadrao.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRotaPraca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRotaPraca)).BeginInit();
            this.kryptonTabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.kryptonPanel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(623, 284);
            // 
            // panelPadrao
            // 
            this.panelPadrao.Controls.Add(this.kryptonTabControl2);
            this.panelPadrao.Size = new System.Drawing.Size(621, 260);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.hlP_LabelSeparator1_Geral);
            this.flowLayoutPanel1.Controls.Add(this.txtCodigo);
            this.flowLayoutPanel1.Controls.Add(this.txtxRota);
            this.flowLayoutPanel1.Controls.Add(this.campoPesquisaListaPreco);
            this.flowLayoutPanel1.Controls.Add(this.cboAtivo);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(607, 225);
            this.flowLayoutPanel1.TabIndex = 114;
            this.flowLayoutPanel1.Tag = "Principal";
            // 
            // hlP_LabelSeparator1_Geral
            // 
            this.hlP_LabelSeparator1_Geral._LabelText = "Geral";
            this.hlP_LabelSeparator1_Geral._TamanhoMaiorLabel = 0;
            this.hlP_LabelSeparator1_Geral.BackColor = System.Drawing.Color.Transparent;
            this.hlP_LabelSeparator1_Geral.Location = new System.Drawing.Point(0, 3);
            this.hlP_LabelSeparator1_Geral.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.hlP_LabelSeparator1_Geral.Name = "hlP_LabelSeparator1_Geral";
            this.hlP_LabelSeparator1_Geral.Size = new System.Drawing.Size(300, 18);
            this.hlP_LabelSeparator1_Geral.TabIndex = 30;
            this.hlP_LabelSeparator1_Geral.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo._Field = "idRota";
            this.txtCodigo._Help = "Chave principal da rota";
            this.txtCodigo._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtCodigo._LabelText = "Código";
            this.txtCodigo._Multiline = false;
            this.txtCodigo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtCodigo._Password = false;
            this.txtCodigo._Regex = null;
            this.txtCodigo._Table = "Rota";
            this.txtCodigo._TamanhoComponente = 107;
            this.txtCodigo._TamanhoMaiorLabel = 140;
            this.txtCodigo._Visible = false;
            this.txtCodigo.BackColor = System.Drawing.Color.Transparent;
            this.txtCodigo.Base = null;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCodigo.Color = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(98, 27);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(98, 3, 15, 3);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(152, 21);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtxRota
            // 
            this.txtxRota._Field = "xRota";
            this.txtxRota._Help = "Informe a descrição desejada para essa rota";
            this.txtxRota._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtxRota._LabelText = "Descrição";
            this.txtxRota._Multiline = false;
            this.txtxRota._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxRota._Password = false;
            this.txtxRota._Regex = null;
            this.txtxRota._Table = "Rota";
            this.txtxRota._TamanhoComponente = 284;
            this.txtxRota._TamanhoMaiorLabel = 140;
            this.txtxRota._Visible = false;
            this.txtxRota.BackColor = System.Drawing.Color.Transparent;
            this.txtxRota.Base = null;
            this.txtxRota.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxRota.Color = System.Drawing.Color.White;
            this.txtxRota.Location = new System.Drawing.Point(87, 54);
            this.txtxRota.Margin = new System.Windows.Forms.Padding(87, 3, 15, 3);
            this.txtxRota.MaxLength = 32767;
            this.txtxRota.Name = "txtxRota";
            this.txtxRota.ReadOnly = false;
            this.txtxRota.Size = new System.Drawing.Size(340, 21);
            this.txtxRota.TabIndex = 2;
            // 
            // campoPesquisaListaPreco
            // 
            this.campoPesquisaListaPreco._Field = "idListaPrecoPai";
            this.campoPesquisaListaPreco._Help = "Informe a lista de preço desejada para essa rota";
            this.campoPesquisaListaPreco._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.campoPesquisaListaPreco._LabelText = "Lista de preço";
            this.campoPesquisaListaPreco._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("campoPesquisaListaPreco._ListaCamposDisplay")));
            this.campoPesquisaListaPreco._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("campoPesquisaListaPreco._ListaValoresDisplay")));
            this.campoPesquisaListaPreco._NomeCampoPK = "ID";
            this.campoPesquisaListaPreco._NomeFormCadastroOriginal = "FormListaPreco";
            this.campoPesquisaListaPreco._NomeView = "vwListaPrecoPai";
            this.campoPesquisaListaPreco._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.campoPesquisaListaPreco._Regex = null;
            this.campoPesquisaListaPreco._Table = "Rota";
            this.campoPesquisaListaPreco._TamanhoComponente = 300;
            this.campoPesquisaListaPreco._TamanhoMaiorLabel = 140;
            this.campoPesquisaListaPreco._Vinculado = false;
            this.campoPesquisaListaPreco._Visible = false;
            this.campoPesquisaListaPreco.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.campoPesquisaListaPreco.BackColor = System.Drawing.Color.Transparent;
            this.campoPesquisaListaPreco.Base = null;
            this.campoPesquisaListaPreco.Location = new System.Drawing.Point(65, 81);
            this.campoPesquisaListaPreco.Margin = new System.Windows.Forms.Padding(65, 3, 15, 3);
            this.campoPesquisaListaPreco.Name = "campoPesquisaListaPreco";
            this.campoPesquisaListaPreco.ReadOnly = false;
            this.campoPesquisaListaPreco.Size = new System.Drawing.Size(468, 21);
            this.campoPesquisaListaPreco.TabIndex = 4;
            this.campoPesquisaListaPreco.Value = 0;
            // 
            // cboAtivo
            // 
            this.cboAtivo._Field = "Ativo";
            this.cboAtivo._Help = "Informar se rota esta ativa para a utilização";
            this.cboAtivo._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cboAtivo._Itens")));
            this.cboAtivo._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cboAtivo._LabelText = "Ativo?";
            this.cboAtivo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cboAtivo._Regex = null;
            this.cboAtivo._situacao = true;
            this.cboAtivo._Table = "Rota";
            this.cboAtivo._TamanhoComponente = 80;
            this.cboAtivo._TamanhoMaiorLabel = 140;
            this.cboAtivo._Visible = false;
            this.cboAtivo.BackColor = System.Drawing.Color.Transparent;
            this.cboAtivo.Base = null;
            this.cboAtivo.Color = System.Drawing.Color.White;
            this.cboAtivo.DataSource = null;
            this.cboAtivo.DisplayMember = "DisplayMember";
            this.cboAtivo.Location = new System.Drawing.Point(105, 108);
            this.cboAtivo.Margin = new System.Windows.Forms.Padding(105, 3, 15, 3);
            this.cboAtivo.Name = "cboAtivo";
            this.cboAtivo.SelectedIndex = -1;
            this.cboAtivo.SelectedValue = 0;
            this.cboAtivo.Size = new System.Drawing.Size(118, 21);
            this.cboAtivo.TabIndex = 3;
            this.cboAtivo.ValueMember = "ValueMember";
            // 
            // dgvRotaPraca
            // 
            this.dgvRotaPraca.AllowDrop = true;
            this.dgvRotaPraca.Altera = false;
            this.dgvRotaPraca.AutoGenerateColumns = false;
            this.dgvRotaPraca.cm = null;
            this.dgvRotaPraca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRotaPraca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnOrdem,
            this.clnDistanciaProximaCidade,
            this.clidCidade});
            this.dgvRotaPraca.DataSource = this.bsRotaPraca;
            this.dgvRotaPraca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRotaPraca.DragDropLinha = true;
            this.dgvRotaPraca.Exclui = false;
            this.dgvRotaPraca.Inclui = false;
            this.dgvRotaPraca.Location = new System.Drawing.Point(0, 0);
            this.dgvRotaPraca.Name = "dgvRotaPraca";
            this.dgvRotaPraca.Size = new System.Drawing.Size(804, 225);
            this.dgvRotaPraca.TabIndex = 5;
            this.dgvRotaPraca.Tag = "Rota_Praca";
            this.dgvRotaPraca.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvRotaPraca_DefaultValuesNeeded);
            this.dgvRotaPraca.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvRotaPraca_RowsAdded);
            this.dgvRotaPraca.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvRotaPraca_DragDrop);
            // 
            // clnOrdem
            // 
            this.clnOrdem.DataPropertyName = "nOrdem";
            this.clnOrdem.HeaderText = "Ordem";
            this.clnOrdem.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.clnOrdem.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.clnOrdem.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.clnOrdem.Name = "clnOrdem";
            this.clnOrdem.ReadOnly = true;
            this.clnOrdem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnOrdem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clnOrdem.ToolTipText = "Ordem que o trajeto seguirá.";
            this.clnOrdem.Width = 100;
            // 
            // clnDistanciaProximaCidade
            // 
            this.clnDistanciaProximaCidade.DataPropertyName = "nDistanciaProximaCidade";
            this.clnDistanciaProximaCidade.HeaderText = "Distancia Proxima Cidade";
            this.clnDistanciaProximaCidade.Name = "clnDistanciaProximaCidade";
            this.clnDistanciaProximaCidade.ToolTipText = "Distancia que será utilizada para calcular o KM rodado dessa ordem ou cidade até " +
    "a próxima cidade da rota e assim sucessivamente.";
            this.clnDistanciaProximaCidade.Width = 200;
            // 
            // clidCidade
            // 
            this.clidCidade.DataPropertyName = "idCidade";
            this.clidCidade.HeaderText = "Cidade";
            this.clidCidade.Name = "clidCidade";
            this.clidCidade.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clidCidade.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clidCidade.ToolTipText = "Cidade que pertencerá a rota destinada";
            this.clidCidade.Width = 250;
            // 
            // bsRotaPraca
            // 
            this.bsRotaPraca.DataSource = typeof(HLP.Models.Entries.Gerais.Rota_pracaModel);
            // 
            // kryptonTabControl2
            // 
            this.kryptonTabControl2.AllowCloseButton = false;
            this.kryptonTabControl2.AllowContextButton = true;
            this.kryptonTabControl2.AllowNavigatorButtons = false;
            this.kryptonTabControl2.AllowSelectedTabHigh = false;
            this.kryptonTabControl2.BorderWidth = 1;
            this.kryptonTabControl2.Controls.Add(this.tabPage2);
            this.kryptonTabControl2.Controls.Add(this.tabPage3);
            this.kryptonTabControl2.CornerRoundRadiusWidth = 12;
            this.kryptonTabControl2.CornerSymmetry = AC.ExtendedRenderer.Navigator.KryptonTabControl.CornSymmetry.Both;
            this.kryptonTabControl2.CornerType = AC.ExtendedRenderer.Toolkit.Drawing.DrawingMethods.CornerType.Rounded;
            this.kryptonTabControl2.CornerWidth = AC.ExtendedRenderer.Navigator.KryptonTabControl.CornWidth.Thin;
            this.kryptonTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonTabControl2.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.kryptonTabControl2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.kryptonTabControl2.HotTrack = true;
            this.kryptonTabControl2.Location = new System.Drawing.Point(3, 3);
            this.kryptonTabControl2.Name = "kryptonTabControl2";
            this.kryptonTabControl2.PreserveTabColor = false;
            this.kryptonTabControl2.SelectedIndex = 0;
            this.kryptonTabControl2.Size = new System.Drawing.Size(615, 254);
            this.kryptonTabControl2.TabIndex = 116;
            this.kryptonTabControl2.UseExtendedLayout = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage2.Controls.Add(this.kryptonPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(607, 225);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Tag = false;
            this.tabPage2.Text = "Principal";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.BorderWidth = 0;
            this.kryptonPanel1.Controls.Add(this.flowLayoutPanel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.kryptonPanel1.GradientToogleColors = false;
            this.kryptonPanel1.GradientUseBlend = false;
            this.kryptonPanel1.GradientUseSolid = true;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PersistentColors = false;
            this.kryptonPanel1.Size = new System.Drawing.Size(607, 225);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvRotaPraca);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(804, 225);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Tag = false;
            this.tabPage3.Text = "Praça";
            // 
            // FormRota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 311);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRota";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = -10;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Text = "Rotas";
            this.Load += new System.EventHandler(this.FormRota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).EndInit();
            this.panelPadrao.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRotaPraca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRotaPraca)).EndInit();
            this.kryptonTabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.kryptonPanel1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Comum.Components.HLP_TextBox txtCodigo;
        private Comum.Components.HLP_TextBox txtxRota;
        private Comum.Components.HLP_ComboBox cboAtivo;
        private Comum.Components.HLP_Pesquisa campoPesquisaListaPreco;
        private HLP_DataGridView dgvRotaPraca;
        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.BindingSource bsRotaPraca;
        private HLP_LabelSeparator hlP_LabelSeparator1_Geral;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn clnOrdem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDistanciaProximaCidade;
        private System.Windows.Forms.DataGridViewComboBoxColumn clidCidade;
    }
}