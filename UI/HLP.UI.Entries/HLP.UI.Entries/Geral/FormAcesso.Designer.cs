﻿namespace HLP.UI.Entries.Geral
{
    partial class FormAcesso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAcesso));
            this.bsAcesso = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kryptonTabControl2 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvAcesso = new HLP.Comum.Components.HLP_DataGridView();
            this.idEmpresa = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idSetor = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vCompraAprovaAutoDataGridViewTextBoxColumn = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.hlP_LabelSeparatorPrincipal = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtIdFuncionario = new HLP.Comum.Components.HLP_TextBox();
            this.txtxCodigoAlternativo = new HLP.Comum.Components.HLP_TextBox();
            this.txtxNome = new HLP.Comum.Components.HLP_TextBox();
            this.hlP_LabelSeparatorLogin = new HLP.Comum.Components.HLP_LabelSeparator();
            this.chkstUsuarioAtivo = new HLP.Comum.Components.HLP_CheckBox();
            this.txtxId = new HLP.Comum.Components.HLP_TextBox();
            this.txtxSenha = new HLP.Comum.Components.HLP_TextBox();
            this.cbxstUsuario = new HLP.Comum.Components.HLP_ComboBox();
            this.btnVerificar = new HLP.Comum.Components.HLP_Button();
            this.kryptonTabControl1 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).BeginInit();
            this.panelPadrao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAcesso)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.kryptonTabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcesso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.kryptonTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(652, 484);
            // 
            // panelPadrao
            // 
            this.panelPadrao.Controls.Add(this.kryptonTabControl1);
            this.panelPadrao.Size = new System.Drawing.Size(650, 460);
            // 
            // bsAcesso
            // 
            this.bsAcesso.DataSource = typeof(HLP.Models.Entries.Gerais.Funcionario_AcessoModel);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.kryptonTabControl2);
            this.tabPage1.Controls.Add(this.kryptonPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(636, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = false;
            this.tabPage1.Text = "Principal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // kryptonTabControl2
            // 
            this.kryptonTabControl2.AllowCloseButton = false;
            this.kryptonTabControl2.AllowContextButton = true;
            this.kryptonTabControl2.AllowNavigatorButtons = false;
            this.kryptonTabControl2.AllowSelectedTabHigh = false;
            this.kryptonTabControl2.BorderWidth = 1;
            this.kryptonTabControl2.Controls.Add(this.tabPage2);
            this.kryptonTabControl2.CornerRoundRadiusWidth = 12;
            this.kryptonTabControl2.CornerSymmetry = AC.ExtendedRenderer.Navigator.KryptonTabControl.CornSymmetry.Both;
            this.kryptonTabControl2.CornerType = AC.ExtendedRenderer.Toolkit.Drawing.DrawingMethods.CornerType.Rounded;
            this.kryptonTabControl2.CornerWidth = AC.ExtendedRenderer.Navigator.KryptonTabControl.CornWidth.Thin;
            this.kryptonTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonTabControl2.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.kryptonTabControl2.HotTrack = true;
            this.kryptonTabControl2.Location = new System.Drawing.Point(0, 271);
            this.kryptonTabControl2.Name = "kryptonTabControl2";
            this.kryptonTabControl2.PreserveTabColor = false;
            this.kryptonTabControl2.SelectedIndex = 0;
            this.kryptonTabControl2.Size = new System.Drawing.Size(636, 154);
            this.kryptonTabControl2.TabIndex = 1;
            this.kryptonTabControl2.UseExtendedLayout = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvAcesso);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(628, 125);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Tag = false;
            this.tabPage2.Text = "Acesso";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvAcesso
            // 
            this.dgvAcesso.Altera = false;
            this.dgvAcesso.AutoGenerateColumns = false;
            this.dgvAcesso.cm = null;
            this.dgvAcesso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcesso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmpresa,
            this.idSetor,
            this.vCompraAprovaAutoDataGridViewTextBoxColumn});
            this.dgvAcesso.DataSource = this.bsAcesso;
            this.dgvAcesso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAcesso.DragDropLinha = false;
            this.dgvAcesso.Exclui = false;
            this.dgvAcesso.Inclui = false;
            this.dgvAcesso.Location = new System.Drawing.Point(0, 0);
            this.dgvAcesso.Name = "dgvAcesso";
            this.dgvAcesso.Size = new System.Drawing.Size(628, 125);
            this.dgvAcesso.TabIndex = 10;
            this.dgvAcesso.Tag = "Acesso";
            // 
            // idEmpresa
            // 
            this.idEmpresa.DataPropertyName = "idEmpresa";
            this.idEmpresa.HeaderText = "Empresa";
            this.idEmpresa.Name = "idEmpresa";
            this.idEmpresa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idEmpresa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // idSetor
            // 
            this.idSetor.DataPropertyName = "idSetor";
            this.idSetor.HeaderText = "Setor";
            this.idSetor.Name = "idSetor";
            this.idSetor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idSetor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // vCompraAprovaAutoDataGridViewTextBoxColumn
            // 
            this.vCompraAprovaAutoDataGridViewTextBoxColumn.DataPropertyName = "vCompraAprovaAuto";
            this.vCompraAprovaAutoDataGridViewTextBoxColumn.HeaderText = "Valor Compra";
            this.vCompraAprovaAutoDataGridViewTextBoxColumn.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.vCompraAprovaAutoDataGridViewTextBoxColumn.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.vCompraAprovaAutoDataGridViewTextBoxColumn.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.vCompraAprovaAutoDataGridViewTextBoxColumn.Name = "vCompraAprovaAutoDataGridViewTextBoxColumn";
            this.vCompraAprovaAutoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vCompraAprovaAutoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.vCompraAprovaAutoDataGridViewTextBoxColumn.Width = 100;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.flowLayoutPanel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(636, 271);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.hlP_LabelSeparatorPrincipal);
            this.flowLayoutPanel1.Controls.Add(this.txtIdFuncionario);
            this.flowLayoutPanel1.Controls.Add(this.txtxCodigoAlternativo);
            this.flowLayoutPanel1.Controls.Add(this.txtxNome);
            this.flowLayoutPanel1.Controls.Add(this.hlP_LabelSeparatorLogin);
            this.flowLayoutPanel1.Controls.Add(this.chkstUsuarioAtivo);
            this.flowLayoutPanel1.Controls.Add(this.txtxId);
            this.flowLayoutPanel1.Controls.Add(this.txtxSenha);
            this.flowLayoutPanel1.Controls.Add(this.cbxstUsuario);
            this.flowLayoutPanel1.Controls.Add(this.btnVerificar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(636, 271);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // hlP_LabelSeparatorPrincipal
            // 
            this.hlP_LabelSeparatorPrincipal._LabelText = "Principal";
            this.hlP_LabelSeparatorPrincipal._TamanhoMaiorLabel = 0;
            this.hlP_LabelSeparatorPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.hlP_LabelSeparatorPrincipal.Location = new System.Drawing.Point(3, 3);
            this.hlP_LabelSeparatorPrincipal.Name = "hlP_LabelSeparatorPrincipal";
            this.hlP_LabelSeparatorPrincipal.Size = new System.Drawing.Size(505, 18);
            this.hlP_LabelSeparatorPrincipal.TabIndex = 2;
            this.hlP_LabelSeparatorPrincipal.TabStop = false;
            // 
            // txtIdFuncionario
            // 
            this.txtIdFuncionario._Field = "IdFuncionario";
            this.txtIdFuncionario._LabelGroup = this.hlP_LabelSeparatorPrincipal;
            this.txtIdFuncionario._LabelText = "Id funcionário";
            this.txtIdFuncionario._Multiline = false;
            this.txtIdFuncionario._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtIdFuncionario._Password = false;
            this.txtIdFuncionario._Regex = null;
            this.txtIdFuncionario._Table = "Funcionario";
            this.txtIdFuncionario._TamanhoComponente = 98;
            this.txtIdFuncionario._TamanhoMaiorLabel = 100;
            this.txtIdFuncionario._Visible = false;
            this.txtIdFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.txtIdFuncionario.Base = null;
            this.txtIdFuncionario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtIdFuncionario.Color = System.Drawing.Color.White;
            this.txtIdFuncionario.Location = new System.Drawing.Point(23, 27);
            this.txtIdFuncionario.Margin = new System.Windows.Forms.Padding(23, 3, 15, 3);
            this.txtIdFuncionario.MaxLength = 32767;
            this.txtIdFuncionario.Name = "txtIdFuncionario";
            this.txtIdFuncionario.ReadOnly = false;
            this.txtIdFuncionario.Size = new System.Drawing.Size(178, 23);
            this.txtIdFuncionario.TabIndex = 3;
            this.txtIdFuncionario._TextChanged += new System.EventHandler(this.txtIdFuncionario__TextChanged);
            // 
            // txtxCodigoAlternativo
            // 
            this.txtxCodigoAlternativo._Field = "xCodigoAlternativo";
            this.txtxCodigoAlternativo._LabelGroup = this.hlP_LabelSeparatorPrincipal;
            this.txtxCodigoAlternativo._LabelText = "Código alternativo";
            this.txtxCodigoAlternativo._Multiline = false;
            this.txtxCodigoAlternativo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxCodigoAlternativo._Password = false;
            this.txtxCodigoAlternativo._Regex = null;
            this.txtxCodigoAlternativo._Table = "Funcionario";
            this.txtxCodigoAlternativo._TamanhoComponente = 159;
            this.txtxCodigoAlternativo._TamanhoMaiorLabel = 100;
            this.txtxCodigoAlternativo._Visible = false;
            this.txtxCodigoAlternativo.BackColor = System.Drawing.Color.Transparent;
            this.txtxCodigoAlternativo.Base = null;
            this.txtxCodigoAlternativo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxCodigoAlternativo.Color = System.Drawing.Color.White;
            this.txtxCodigoAlternativo.Location = new System.Drawing.Point(0, 56);
            this.txtxCodigoAlternativo.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.txtxCodigoAlternativo.MaxLength = 32767;
            this.txtxCodigoAlternativo.Name = "txtxCodigoAlternativo";
            this.txtxCodigoAlternativo.ReadOnly = false;
            this.txtxCodigoAlternativo.Size = new System.Drawing.Size(262, 21);
            this.txtxCodigoAlternativo.TabIndex = 4;
            // 
            // txtxNome
            // 
            this.txtxNome._Field = "xNome";
            this.txtxNome._LabelGroup = this.hlP_LabelSeparatorPrincipal;
            this.txtxNome._LabelText = "Nome";
            this.txtxNome._Multiline = false;
            this.txtxNome._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxNome._Password = false;
            this.txtxNome._Regex = null;
            this.txtxNome._Table = "Funcionario";
            this.txtxNome._TamanhoComponente = 405;
            this.txtxNome._TamanhoMaiorLabel = 100;
            this.txtxNome._Visible = false;
            this.txtxNome.BackColor = System.Drawing.Color.Transparent;
            this.txtxNome.Base = null;
            this.txtxNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxNome.Color = System.Drawing.Color.White;
            this.txtxNome.Location = new System.Drawing.Point(66, 83);
            this.txtxNome.Margin = new System.Windows.Forms.Padding(66, 3, 15, 3);
            this.txtxNome.MaxLength = 32767;
            this.txtxNome.Name = "txtxNome";
            this.txtxNome.ReadOnly = false;
            this.txtxNome.Size = new System.Drawing.Size(442, 21);
            this.txtxNome.TabIndex = 5;
            // 
            // hlP_LabelSeparatorLogin
            // 
            this.hlP_LabelSeparatorLogin._LabelText = "Login";
            this.hlP_LabelSeparatorLogin._TamanhoMaiorLabel = 0;
            this.hlP_LabelSeparatorLogin.BackColor = System.Drawing.Color.Transparent;
            this.hlP_LabelSeparatorLogin.Location = new System.Drawing.Point(3, 110);
            this.hlP_LabelSeparatorLogin.Name = "hlP_LabelSeparatorLogin";
            this.hlP_LabelSeparatorLogin.Size = new System.Drawing.Size(505, 18);
            this.hlP_LabelSeparatorLogin.TabIndex = 6;
            this.hlP_LabelSeparatorLogin.TabStop = false;
            // 
            // chkstUsuarioAtivo
            // 
            this.chkstUsuarioAtivo._Field = "stUsuarioAtivo";
            this.chkstUsuarioAtivo._LabelGroup = this.hlP_LabelSeparatorLogin;
            this.chkstUsuarioAtivo._LabelText = "Utiliza sistema";
            this.chkstUsuarioAtivo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.chkstUsuarioAtivo._Regex = null;
            this.chkstUsuarioAtivo._Table = "Funcionario";
            this.chkstUsuarioAtivo._TamanhoComponente = 43;
            this.chkstUsuarioAtivo._TamanhoMaiorLabel = 100;
            this.chkstUsuarioAtivo._Visible = false;
            this.chkstUsuarioAtivo.BackColor = System.Drawing.Color.Transparent;
            this.chkstUsuarioAtivo.Base = null;
            this.chkstUsuarioAtivo.Checked = false;
            this.chkstUsuarioAtivo.Location = new System.Drawing.Point(23, 134);
            this.chkstUsuarioAtivo.Margin = new System.Windows.Forms.Padding(23, 3, 15, 3);
            this.chkstUsuarioAtivo.Name = "chkstUsuarioAtivo";
            this.chkstUsuarioAtivo.Size = new System.Drawing.Size(123, 21);
            this.chkstUsuarioAtivo.TabIndex = 10;
            this.chkstUsuarioAtivo.Value = false;
            this.chkstUsuarioAtivo._CheckedChanged += new System.EventHandler(this.chkstUsuarioAtivo__CheckedChanged);
            // 
            // txtxId
            // 
            this.txtxId._Field = "xId";
            this.txtxId._LabelGroup = this.hlP_LabelSeparatorLogin;
            this.txtxId._LabelText = "Login";
            this.txtxId._Multiline = false;
            this.txtxId._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxId._Password = false;
            this.txtxId._Regex = null;
            this.txtxId._Table = "Funcionario";
            this.txtxId._TamanhoComponente = 174;
            this.txtxId._TamanhoMaiorLabel = 100;
            this.txtxId._Visible = false;
            this.txtxId.BackColor = System.Drawing.Color.Transparent;
            this.txtxId.Base = null;
            this.txtxId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtxId.Color = System.Drawing.Color.White;
            this.txtxId.Location = new System.Drawing.Point(67, 161);
            this.txtxId.Margin = new System.Windows.Forms.Padding(67, 3, 15, 3);
            this.txtxId.MaxLength = 32767;
            this.txtxId.Name = "txtxId";
            this.txtxId.ReadOnly = false;
            this.txtxId.Size = new System.Drawing.Size(210, 21);
            this.txtxId.TabIndex = 6;
            this.txtxId._TextChanged += new System.EventHandler(this.txtxId__TextChanged);
            // 
            // txtxSenha
            // 
            this.txtxSenha._Field = "xSenha";
            this.txtxSenha._LabelGroup = this.hlP_LabelSeparatorLogin;
            this.txtxSenha._LabelText = "Senha";
            this.txtxSenha._Multiline = false;
            this.txtxSenha._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxSenha._Password = true;
            this.txtxSenha._Regex = null;
            this.txtxSenha._Table = "Funcionario";
            this.txtxSenha._TamanhoComponente = 174;
            this.txtxSenha._TamanhoMaiorLabel = 100;
            this.txtxSenha._Visible = false;
            this.txtxSenha.BackColor = System.Drawing.Color.Transparent;
            this.txtxSenha.Base = null;
            this.txtxSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxSenha.Color = System.Drawing.Color.White;
            this.txtxSenha.Location = new System.Drawing.Point(64, 188);
            this.txtxSenha.Margin = new System.Windows.Forms.Padding(64, 3, 15, 3);
            this.txtxSenha.MaxLength = 32767;
            this.txtxSenha.Name = "txtxSenha";
            this.txtxSenha.ReadOnly = false;
            this.txtxSenha.Size = new System.Drawing.Size(213, 21);
            this.txtxSenha.TabIndex = 7;
            this.txtxSenha._TextChanged += new System.EventHandler(this.txtxId__TextChanged);
            // 
            // cbxstUsuario
            // 
            this.cbxstUsuario._Field = "stUsuario";
            this.cbxstUsuario._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbxstUsuario._Itens")));
            this.cbxstUsuario._LabelGroup = this.hlP_LabelSeparatorLogin;
            this.cbxstUsuario._LabelText = "Tipo usuário";
            this.cbxstUsuario._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbxstUsuario._Regex = null;
            this.cbxstUsuario._situacao = false;
            this.cbxstUsuario._Table = "Funcionario";
            this.cbxstUsuario._TamanhoComponente = 199;
            this.cbxstUsuario._TamanhoMaiorLabel = 100;
            this.cbxstUsuario._Visible = false;
            this.cbxstUsuario.BackColor = System.Drawing.Color.Transparent;
            this.cbxstUsuario.Base = null;
            this.cbxstUsuario.Color = System.Drawing.Color.White;
            this.cbxstUsuario.DataSource = null;
            this.cbxstUsuario.DisplayMember = "DisplayMember";
            this.cbxstUsuario.Location = new System.Drawing.Point(32, 215);
            this.cbxstUsuario.Margin = new System.Windows.Forms.Padding(32, 3, 15, 3);
            this.cbxstUsuario.Name = "cbxstUsuario";
            this.cbxstUsuario.SelectedIndex = -1;
            this.cbxstUsuario.SelectedValue = 0;
            this.cbxstUsuario.Size = new System.Drawing.Size(270, 21);
            this.cbxstUsuario.TabIndex = 8;
            this.cbxstUsuario.ValueMember = "ValueMember";
            this.cbxstUsuario._SelectedIndexChanged += new System.EventHandler(this.txtxId__TextChanged);
            // 
            // btnVerificar
            // 
            this.btnVerificar._LabelGroup = null;
            this.btnVerificar._LabelText = "Verificar";
            this.btnVerificar._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.btnVerificar._Regex = null;
            this.btnVerificar._TamanhoComponente = 164;
            this.btnVerificar._TamanhoMaiorLabel = 0;
            this.btnVerificar._Visible = false;
            this.btnVerificar.Base = null;
            this.btnVerificar.Location = new System.Drawing.Point(3, 242);
            this.btnVerificar.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(164, 24);
            this.btnVerificar.TabIndex = 9;
            this.btnVerificar._btnHlpClick += new System.EventHandler(this.btnVerificar__btnHlpClick);
            // 
            // kryptonTabControl1
            // 
            this.kryptonTabControl1.AllowCloseButton = false;
            this.kryptonTabControl1.AllowContextButton = true;
            this.kryptonTabControl1.AllowNavigatorButtons = false;
            this.kryptonTabControl1.AllowSelectedTabHigh = false;
            this.kryptonTabControl1.BorderWidth = 1;
            this.kryptonTabControl1.Controls.Add(this.tabPage1);
            this.kryptonTabControl1.CornerRoundRadiusWidth = 12;
            this.kryptonTabControl1.CornerSymmetry = AC.ExtendedRenderer.Navigator.KryptonTabControl.CornSymmetry.Both;
            this.kryptonTabControl1.CornerType = AC.ExtendedRenderer.Toolkit.Drawing.DrawingMethods.CornerType.Rounded;
            this.kryptonTabControl1.CornerWidth = AC.ExtendedRenderer.Navigator.KryptonTabControl.CornWidth.Thin;
            this.kryptonTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.kryptonTabControl1.HotTrack = true;
            this.kryptonTabControl1.Location = new System.Drawing.Point(3, 3);
            this.kryptonTabControl1.Name = "kryptonTabControl1";
            this.kryptonTabControl1.PreserveTabColor = false;
            this.kryptonTabControl1.SelectedIndex = 0;
            this.kryptonTabControl1.Size = new System.Drawing.Size(644, 454);
            this.kryptonTabControl1.TabIndex = 0;
            this.kryptonTabControl1.UseExtendedLayout = false;
            // 
            // FormAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 511);
            this.Name = "FormAcesso";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = -10;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text = "Acesso";
            this.Load += new System.EventHandler(this.FormAcesso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).EndInit();
            this.panelPadrao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsAcesso)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.kryptonTabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcesso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.kryptonTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsAcesso;
        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private Comum.Components.HLP_DataGridView dgvAcesso;
        private System.Windows.Forms.DataGridViewComboBoxColumn idEmpresa;
        private System.Windows.Forms.DataGridViewComboBoxColumn idSetor;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn vCompraAprovaAutoDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Comum.Components.HLP_LabelSeparator hlP_LabelSeparatorPrincipal;
        private Comum.Components.HLP_TextBox txtIdFuncionario;
        private Comum.Components.HLP_TextBox txtxCodigoAlternativo;
        private Comum.Components.HLP_TextBox txtxNome;
        private Comum.Components.HLP_LabelSeparator hlP_LabelSeparatorLogin;
        private Comum.Components.HLP_TextBox txtxId;
        private Comum.Components.HLP_TextBox txtxSenha;
        private Comum.Components.HLP_ComboBox cbxstUsuario;
        private Comum.Components.HLP_Button btnVerificar;
        private Comum.Components.HLP_CheckBox chkstUsuarioAtivo;

    }
}