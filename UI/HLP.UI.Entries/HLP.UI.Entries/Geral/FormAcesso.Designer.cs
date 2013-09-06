namespace HLP.UI.Entries.Geral
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
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.dgvAcesso = new HLP.Comum.Components.HLP_DataGridView();
            this.idEmpresa = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idSetor = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vCompraAprovaAutoDataGridViewTextBoxColumn = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.hlP_Group2 = new HLP.Comum.Components.HLP_Group();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbxstUsuario = new HLP.Comum.Components.HLP_ComboBox();
            this.txtxSenha = new HLP.Comum.Components.HLP_TextBox();
            this.txtxId = new HLP.Comum.Components.HLP_TextBox();
            this.cbxstUsuarioAtivo = new HLP.Comum.Components.HLP_ComboBox();
            this.btnVerificar = new HLP.Comum.Components.HLP_Button();
            this.hlP_Group1 = new HLP.Comum.Components.HLP_Group();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtIdFuncionario = new HLP.Comum.Components.HLP_TextBox();
            this.txtxNome = new HLP.Comum.Components.HLP_TextBox();
            this.txtxCodigoAlternativo = new HLP.Comum.Components.HLP_TextBox();
            this.kryptonTabControl1 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).BeginInit();
            this.panelPadrao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelAtalhos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAcesso)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcesso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hlP_Group2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hlP_Group2.Panel)).BeginInit();
            this.hlP_Group2.Panel.SuspendLayout();
            this.hlP_Group2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hlP_Group1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hlP_Group1.Panel)).BeginInit();
            this.hlP_Group1.Panel.SuspendLayout();
            this.hlP_Group1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.kryptonTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(804, 484);
            // 
            // panelPadrao
            // 
            this.panelPadrao.Controls.Add(this.kryptonTabControl1);
            this.panelPadrao.Size = new System.Drawing.Size(772, 460);
            // 
            // panelAtalhos
            // 
            this.panelAtalhos.Size = new System.Drawing.Size(28, 460);
            // 
            // bsAcesso
            // 
            this.bsAcesso.DataSource = typeof(HLP.Models.Entries.Gerais.Funcionario_AcessoModel);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.kryptonPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(758, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = false;
            this.tabPage1.Text = "Principal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.dgvAcesso);
            this.kryptonPanel1.Controls.Add(this.hlP_Group2);
            this.kryptonPanel1.Controls.Add(this.hlP_Group1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(758, 425);
            this.kryptonPanel1.TabIndex = 0;
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
            this.dgvAcesso.Location = new System.Drawing.Point(0, 238);
            this.dgvAcesso.Name = "dgvAcesso";
            this.dgvAcesso.Size = new System.Drawing.Size(758, 187);
            this.dgvAcesso.TabIndex = 122;
            this.dgvAcesso.Tag = "Acesso";
            // 
            // idEmpresa
            // 
            this.idEmpresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idEmpresa.DataPropertyName = "idEmpresa";
            this.idEmpresa.HeaderText = "Empresa";
            this.idEmpresa.Name = "idEmpresa";
            this.idEmpresa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idEmpresa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // idSetor
            // 
            this.idSetor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idSetor.DataPropertyName = "idSetor";
            this.idSetor.HeaderText = "Setor";
            this.idSetor.Name = "idSetor";
            this.idSetor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idSetor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // vCompraAprovaAutoDataGridViewTextBoxColumn
            // 
            this.vCompraAprovaAutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
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
            this.vCompraAprovaAutoDataGridViewTextBoxColumn.Width = 109;
            // 
            // hlP_Group2
            // 
            this.hlP_Group2.Dock = System.Windows.Forms.DockStyle.Top;
            this.hlP_Group2.HeaderVisibleSecondary = false;
            this.hlP_Group2.Location = new System.Drawing.Point(0, 129);
            this.hlP_Group2.Name = "hlP_Group2";
            // 
            // hlP_Group2.Panel
            // 
            this.hlP_Group2.Panel.Controls.Add(this.flowLayoutPanel3);
            this.hlP_Group2.PositionComponente = HLP.Comum.Components.HLP_Group.Posicao.TopDown;
            this.hlP_Group2.Size = new System.Drawing.Size(758, 109);
            this.hlP_Group2.StateCommon.OverlayHeaders = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.hlP_Group2.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.hlP_Group2.StateNormal.Back.ColorAngle = 180F;
            this.hlP_Group2.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.hlP_Group2.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.hlP_Group2.StateNormal.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.hlP_Group2.StateNormal.Border.Rounding = 6;
            this.hlP_Group2.StateNormal.HeaderPrimary.Back.ColorAngle = 180F;
            this.hlP_Group2.StateNormal.HeaderPrimary.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.hlP_Group2.StateNormal.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hlP_Group2.TabIndex = 121;
            this.hlP_Group2.TextHeader = "Login";
            this.hlP_Group2.ValuesPrimary.Heading = "Login";
            this.hlP_Group2.ValuesPrimary.Image = null;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel3.Controls.Add(this.cbxstUsuario);
            this.flowLayoutPanel3.Controls.Add(this.txtxSenha);
            this.flowLayoutPanel3.Controls.Add(this.txtxId);
            this.flowLayoutPanel3.Controls.Add(this.cbxstUsuarioAtivo);
            this.flowLayoutPanel3.Controls.Add(this.btnVerificar);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(752, 85);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // cbxstUsuario
            // 
            this.cbxstUsuario._Field = "stUsuario";
            this.cbxstUsuario._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbxstUsuario._Itens")));
            this.cbxstUsuario._LabelGroup = null;
            this.cbxstUsuario._LabelSuperior = false;
            this.cbxstUsuario._LabelText = "Tipo usuário";
            this.cbxstUsuario._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbxstUsuario._Regex = null;
            this.cbxstUsuario._situacao = false;
            this.cbxstUsuario._Table = "Funcionario";
            this.cbxstUsuario._TamanhoComponente = 199;
            this.cbxstUsuario._TamanhoMaiorLabel = 80;
            this.cbxstUsuario.BackColor = System.Drawing.Color.Transparent;
            this.cbxstUsuario.Base = null;
            this.cbxstUsuario.bConfiguracao = false;
            this.cbxstUsuario.Color = System.Drawing.Color.White;
            this.cbxstUsuario.DataSource = null;
            this.cbxstUsuario.DisplayMember = "DisplayMember";
            this.cbxstUsuario.Location = new System.Drawing.Point(12, 3);
            this.cbxstUsuario.Margin = new System.Windows.Forms.Padding(12, 3, 15, 3);
            this.cbxstUsuario.Name = "cbxstUsuario";
            this.cbxstUsuario.objConfigComponenteModel = null;
            this.cbxstUsuario.SelectedIndex = -1;
            this.cbxstUsuario.SelectedValue = 0;
            this.cbxstUsuario.Size = new System.Drawing.Size(270, 21);
            this.cbxstUsuario.TabIndex = 8;
            this.cbxstUsuario.ValueMember = "ValueMember";
            this.cbxstUsuario._SelectedIndexChanged += new System.EventHandler(this.txtxId__TextChanged);
            // 
            // txtxSenha
            // 
            this.txtxSenha._Field = "xSenha";
            this.txtxSenha._LabelGroup = null;
            this.txtxSenha._LabelSuperior = false;
            this.txtxSenha._LabelText = "Senha";
            this.txtxSenha._Multiline = false;
            this.txtxSenha._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxSenha._Password = true;
            this.txtxSenha._Regex = null;
            this.txtxSenha._Table = "Funcionario";
            this.txtxSenha._TamanhoComponente = 149;
            this.txtxSenha._TamanhoMaiorLabel = 80;
            this.txtxSenha.BackColor = System.Drawing.Color.Transparent;
            this.txtxSenha.Base = null;
            this.txtxSenha.bConfiguracao = false;
            this.txtxSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxSenha.Color = System.Drawing.Color.White;
            this.txtxSenha.Location = new System.Drawing.Point(44, 30);
            this.txtxSenha.Margin = new System.Windows.Forms.Padding(44, 3, 15, 3);
            this.txtxSenha.MaxLength = 32767;
            this.txtxSenha.Name = "txtxSenha";
            this.txtxSenha.objConfigComponenteModel = null;
            this.txtxSenha.ReadOnly = false;
            this.txtxSenha.Size = new System.Drawing.Size(188, 22);
            this.txtxSenha.TabIndex = 7;
            this.txtxSenha._TextChanged += new System.EventHandler(this.txtxId__TextChanged);
            // 
            // txtxId
            // 
            this.txtxId._Field = "xID";
            this.txtxId._LabelGroup = null;
            this.txtxId._LabelSuperior = false;
            this.txtxId._LabelText = "Login";
            this.txtxId._Multiline = false;
            this.txtxId._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxId._Password = false;
            this.txtxId._Regex = null;
            this.txtxId._Table = "Funcionario";
            this.txtxId._TamanhoComponente = 149;
            this.txtxId._TamanhoMaiorLabel = 80;
            this.txtxId.BackColor = System.Drawing.Color.Transparent;
            this.txtxId.Base = null;
            this.txtxId.bConfiguracao = false;
            this.txtxId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtxId.Color = System.Drawing.Color.White;
            this.txtxId.Location = new System.Drawing.Point(47, 58);
            this.txtxId.Margin = new System.Windows.Forms.Padding(47, 3, 15, 3);
            this.txtxId.MaxLength = 32767;
            this.txtxId.Name = "txtxId";
            this.txtxId.objConfigComponenteModel = null;
            this.txtxId.ReadOnly = false;
            this.txtxId.Size = new System.Drawing.Size(185, 22);
            this.txtxId.TabIndex = 6;
            this.txtxId._TextChanged += new System.EventHandler(this.txtxId__TextChanged);
            // 
            // cbxstUsuarioAtivo
            // 
            this.cbxstUsuarioAtivo._Field = "stUsuarioAtivo";
            this.cbxstUsuarioAtivo._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbxstUsuarioAtivo._Itens")));
            this.cbxstUsuarioAtivo._LabelGroup = null;
            this.cbxstUsuarioAtivo._LabelSuperior = false;
            this.cbxstUsuarioAtivo._LabelText = "Utiliza sistema";
            this.cbxstUsuarioAtivo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbxstUsuarioAtivo._Regex = null;
            this.cbxstUsuarioAtivo._situacao = true;
            this.cbxstUsuarioAtivo._Table = "Funcionario";
            this.cbxstUsuarioAtivo._TamanhoComponente = 80;
            this.cbxstUsuarioAtivo._TamanhoMaiorLabel = 80;
            this.cbxstUsuarioAtivo.Base = null;
            this.cbxstUsuarioAtivo.bConfiguracao = false;
            this.cbxstUsuarioAtivo.Color = System.Drawing.Color.White;
            this.cbxstUsuarioAtivo.DataSource = null;
            this.cbxstUsuarioAtivo.DisplayMember = "DisplayMember";
            this.cbxstUsuarioAtivo.Location = new System.Drawing.Point(300, 3);
            this.cbxstUsuarioAtivo.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.cbxstUsuarioAtivo.Name = "cbxstUsuarioAtivo";
            this.cbxstUsuarioAtivo.objConfigComponenteModel = null;
            this.cbxstUsuarioAtivo.SelectedIndex = -1;
            this.cbxstUsuarioAtivo.SelectedValue = 0;
            this.cbxstUsuarioAtivo.Size = new System.Drawing.Size(160, 21);
            this.cbxstUsuarioAtivo.TabIndex = 11;
            this.cbxstUsuarioAtivo.ValueMember = "ValueMember";
            // 
            // btnVerificar
            // 
            this.btnVerificar._LabelGroup = null;
            this.btnVerificar._LabelSuperior = false;
            this.btnVerificar._LabelText = "Verificar";
            this.btnVerificar._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.btnVerificar._Regex = null;
            this.btnVerificar._TamanhoComponente = 160;
            this.btnVerificar._TamanhoMaiorLabel = 80;
            this.btnVerificar.Base = null;
            this.btnVerificar.bConfiguracao = false;
            this.btnVerificar.Location = new System.Drawing.Point(380, 30);
            this.btnVerificar.Margin = new System.Windows.Forms.Padding(83, 3, 15, 3);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.objConfigComponenteModel = null;
            this.btnVerificar.Size = new System.Drawing.Size(160, 24);
            this.btnVerificar.TabIndex = 12;
            this.btnVerificar._btnHlpClick += new System.EventHandler(this.btnVerificar__btnHlpClick_1);
            // 
            // hlP_Group1
            // 
            this.hlP_Group1.Dock = System.Windows.Forms.DockStyle.Top;
            this.hlP_Group1.HeaderVisibleSecondary = false;
            this.hlP_Group1.Location = new System.Drawing.Point(0, 0);
            this.hlP_Group1.Name = "hlP_Group1";
            // 
            // hlP_Group1.Panel
            // 
            this.hlP_Group1.Panel.Controls.Add(this.flowLayoutPanel2);
            this.hlP_Group1.PositionComponente = HLP.Comum.Components.HLP_Group.Posicao.TopDown;
            this.hlP_Group1.Size = new System.Drawing.Size(758, 129);
            this.hlP_Group1.StateCommon.OverlayHeaders = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.hlP_Group1.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.hlP_Group1.StateNormal.Back.ColorAngle = 180F;
            this.hlP_Group1.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.hlP_Group1.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.hlP_Group1.StateNormal.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.hlP_Group1.StateNormal.Border.Rounding = 6;
            this.hlP_Group1.StateNormal.HeaderPrimary.Back.ColorAngle = 180F;
            this.hlP_Group1.StateNormal.HeaderPrimary.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.hlP_Group1.StateNormal.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hlP_Group1.TabIndex = 120;
            this.hlP_Group1.TextHeader = "Funcinário";
            this.hlP_Group1.ValuesPrimary.Heading = "Funcinário";
            this.hlP_Group1.ValuesPrimary.Image = null;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.txtIdFuncionario);
            this.flowLayoutPanel2.Controls.Add(this.txtxNome);
            this.flowLayoutPanel2.Controls.Add(this.txtxCodigoAlternativo);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(752, 105);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // txtIdFuncionario
            // 
            this.txtIdFuncionario._Field = "idFuncionario";
            this.txtIdFuncionario._LabelGroup = null;
            this.txtIdFuncionario._LabelSuperior = false;
            this.txtIdFuncionario._LabelText = "Id funcionário";
            this.txtIdFuncionario._Multiline = false;
            this.txtIdFuncionario._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtIdFuncionario._Password = false;
            this.txtIdFuncionario._Regex = null;
            this.txtIdFuncionario._Table = "Funcionario";
            this.txtIdFuncionario._TamanhoComponente = 98;
            this.txtIdFuncionario._TamanhoMaiorLabel = 103;
            this.txtIdFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.txtIdFuncionario.Base = null;
            this.txtIdFuncionario.bConfiguracao = false;
            this.txtIdFuncionario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtIdFuncionario.Color = System.Drawing.Color.White;
            this.txtIdFuncionario.Location = new System.Drawing.Point(26, 3);
            this.txtIdFuncionario.Margin = new System.Windows.Forms.Padding(26, 3, 15, 3);
            this.txtIdFuncionario.MaxLength = 32767;
            this.txtIdFuncionario.Name = "txtIdFuncionario";
            this.txtIdFuncionario.objConfigComponenteModel = null;
            this.txtIdFuncionario.ReadOnly = false;
            this.txtIdFuncionario.Size = new System.Drawing.Size(178, 22);
            this.txtIdFuncionario.TabIndex = 3;
            this.txtIdFuncionario._TextChanged += new System.EventHandler(this.txtIdFuncionario__TextChanged);
            // 
            // txtxNome
            // 
            this.txtxNome._Field = "xNome";
            this.txtxNome._LabelGroup = null;
            this.txtxNome._LabelSuperior = false;
            this.txtxNome._LabelText = "Nome";
            this.txtxNome._Multiline = false;
            this.txtxNome._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxNome._Password = false;
            this.txtxNome._Regex = null;
            this.txtxNome._Table = "Funcionario";
            this.txtxNome._TamanhoComponente = 405;
            this.txtxNome._TamanhoMaiorLabel = 103;
            this.txtxNome.BackColor = System.Drawing.Color.Transparent;
            this.txtxNome.Base = null;
            this.txtxNome.bConfiguracao = false;
            this.txtxNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxNome.Color = System.Drawing.Color.White;
            this.txtxNome.Location = new System.Drawing.Point(69, 31);
            this.txtxNome.Margin = new System.Windows.Forms.Padding(69, 3, 15, 3);
            this.txtxNome.MaxLength = 32767;
            this.txtxNome.Name = "txtxNome";
            this.txtxNome.objConfigComponenteModel = null;
            this.txtxNome.ReadOnly = false;
            this.txtxNome.Size = new System.Drawing.Size(442, 22);
            this.txtxNome.TabIndex = 5;
            // 
            // txtxCodigoAlternativo
            // 
            this.txtxCodigoAlternativo._Field = "xCodigoAlternativo";
            this.txtxCodigoAlternativo._LabelGroup = null;
            this.txtxCodigoAlternativo._LabelSuperior = false;
            this.txtxCodigoAlternativo._LabelText = "Código alternativo";
            this.txtxCodigoAlternativo._Multiline = false;
            this.txtxCodigoAlternativo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxCodigoAlternativo._Password = false;
            this.txtxCodigoAlternativo._Regex = null;
            this.txtxCodigoAlternativo._Table = "Funcionario";
            this.txtxCodigoAlternativo._TamanhoComponente = 159;
            this.txtxCodigoAlternativo._TamanhoMaiorLabel = 103;
            this.txtxCodigoAlternativo.BackColor = System.Drawing.Color.Transparent;
            this.txtxCodigoAlternativo.Base = null;
            this.txtxCodigoAlternativo.bConfiguracao = false;
            this.txtxCodigoAlternativo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxCodigoAlternativo.Color = System.Drawing.Color.White;
            this.txtxCodigoAlternativo.Location = new System.Drawing.Point(3, 59);
            this.txtxCodigoAlternativo.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.txtxCodigoAlternativo.MaxLength = 32767;
            this.txtxCodigoAlternativo.Name = "txtxCodigoAlternativo";
            this.txtxCodigoAlternativo.objConfigComponenteModel = null;
            this.txtxCodigoAlternativo.ReadOnly = false;
            this.txtxCodigoAlternativo.Size = new System.Drawing.Size(262, 22);
            this.txtxCodigoAlternativo.TabIndex = 4;
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
            this.kryptonTabControl1.Size = new System.Drawing.Size(766, 454);
            this.kryptonTabControl1.TabIndex = 0;
            this.kryptonTabControl1.UseExtendedLayout = false;
            // 
            // FormAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 511);
            this.Name = "FormAcesso";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = -10;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text = "Acesso";
            this.Load += new System.EventHandler(this.FormAcesso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).EndInit();
            this.panelPadrao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelAtalhos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAcesso)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcesso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hlP_Group2.Panel)).EndInit();
            this.hlP_Group2.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hlP_Group2)).EndInit();
            this.hlP_Group2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hlP_Group1.Panel)).EndInit();
            this.hlP_Group1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hlP_Group1)).EndInit();
            this.hlP_Group1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.kryptonTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsAcesso;
        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Comum.Components.HLP_TextBox txtIdFuncionario;
        private Comum.Components.HLP_TextBox txtxCodigoAlternativo;
        private Comum.Components.HLP_TextBox txtxNome;
        private Comum.Components.HLP_TextBox txtxId;
        private Comum.Components.HLP_TextBox txtxSenha;
        private Comum.Components.HLP_ComboBox cbxstUsuario;
        private Comum.Components.HLP_Group hlP_Group2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private Comum.Components.HLP_ComboBox cbxstUsuarioAtivo;
        private Comum.Components.HLP_Group hlP_Group1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Comum.Components.HLP_DataGridView dgvAcesso;
        private System.Windows.Forms.DataGridViewComboBoxColumn idEmpresa;
        private System.Windows.Forms.DataGridViewComboBoxColumn idSetor;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn vCompraAprovaAutoDataGridViewTextBoxColumn;
        private Comum.Components.HLP_Button btnVerificar;

    }
}