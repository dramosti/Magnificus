namespace HLP.UI.Entries.Geral
{
    partial class FormEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpresa));
            this.kryptonTabControl1 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.hlP_LabelSeparatorGeral = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtCodigo = new HLP.Comum.Components.HLP_TextBox();
            this.txtxNome = new HLP.Comum.Components.HLP_TextBox();
            this.txtxFantasia = new HLP.Comum.Components.HLP_TextBox();
            this.masktxtxCnpj = new HLP.Comum.Components.HLP_MaskedTextBox();
            this.txtxIe = new HLP.Comum.Components.HLP_TextBox();
            this.txtxIm = new HLP.Comum.Components.HLP_TextBox();
            this.txtxSuframa = new HLP.Comum.Components.HLP_TextBox();
            this.txtxTelefone = new HLP.Comum.Components.HLP_MaskedTextBox();
            this.txtxFax = new HLP.Comum.Components.HLP_MaskedTextBox();
            this.txtxEmail = new HLP.Comum.Components.HLP_TextBox();
            this.txtxHttp = new HLP.Comum.Components.HLP_TextBox();
            this.txtxLinkLogoEmpresa = new HLP.Comum.Components.HLP_TextBox();
            this.txtxLinkPastas = new HLP.Comum.Components.HLP_TextBox();
            this.cboAtivo = new HLP.Comum.Components.HLP_ComboBox();
            this.hlP_PesquisaidRamoAtividade = new HLP.Comum.Components.HLP_Pesquisa();
            this.cbostCodigoRegimeTributario = new HLP.Comum.Components.HLP_ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.dgvEnderecoEmpresa = new HLP.Comum.Components.HLP_DataGridView();
            this.stTipoEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.xLgrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCplDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xBairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepDataGridViewTextBoxColumn = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewMaskedTextBoxColumn();
            this.xCxPostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCidade = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsEmpresaEndereco = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).BeginInit();
            this.panelPadrao.SuspendLayout();
            this.kryptonTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnderecoEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmpresaEndereco)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1004, 407);
            // 
            // panelPadrao
            // 
            this.panelPadrao.Controls.Add(this.kryptonTabControl1);
            this.panelPadrao.Size = new System.Drawing.Size(1002, 383);
            // 
            // kryptonTabControl1
            // 
            this.kryptonTabControl1.AllowCloseButton = false;
            this.kryptonTabControl1.AllowContextButton = true;
            this.kryptonTabControl1.AllowNavigatorButtons = false;
            this.kryptonTabControl1.AllowSelectedTabHigh = false;
            this.kryptonTabControl1.BorderWidth = 1;
            this.kryptonTabControl1.Controls.Add(this.tabPage1);
            this.kryptonTabControl1.Controls.Add(this.tabPage2);
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
            this.kryptonTabControl1.Size = new System.Drawing.Size(996, 377);
            this.kryptonTabControl1.TabIndex = 0;
            this.kryptonTabControl1.UseExtendedLayout = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.kryptonPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(988, 348);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = false;
            this.tabPage1.Text = "Principal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.flowLayoutPanel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(988, 348);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.hlP_LabelSeparatorGeral);
            this.flowLayoutPanel1.Controls.Add(this.txtCodigo);
            this.flowLayoutPanel1.Controls.Add(this.txtxNome);
            this.flowLayoutPanel1.Controls.Add(this.txtxFantasia);
            this.flowLayoutPanel1.Controls.Add(this.masktxtxCnpj);
            this.flowLayoutPanel1.Controls.Add(this.txtxIe);
            this.flowLayoutPanel1.Controls.Add(this.txtxIm);
            this.flowLayoutPanel1.Controls.Add(this.txtxSuframa);
            this.flowLayoutPanel1.Controls.Add(this.txtxTelefone);
            this.flowLayoutPanel1.Controls.Add(this.txtxFax);
            this.flowLayoutPanel1.Controls.Add(this.txtxEmail);
            this.flowLayoutPanel1.Controls.Add(this.txtxHttp);
            this.flowLayoutPanel1.Controls.Add(this.txtxLinkLogoEmpresa);
            this.flowLayoutPanel1.Controls.Add(this.txtxLinkPastas);
            this.flowLayoutPanel1.Controls.Add(this.cboAtivo);
            this.flowLayoutPanel1.Controls.Add(this.hlP_PesquisaidRamoAtividade);
            this.flowLayoutPanel1.Controls.Add(this.cbostCodigoRegimeTributario);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(988, 348);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // hlP_LabelSeparatorGeral
            // 
            this.hlP_LabelSeparatorGeral._LabelText = "Geral";
            this.hlP_LabelSeparatorGeral._TamanhoMaiorLabel = 0;
            this.hlP_LabelSeparatorGeral.BackColor = System.Drawing.Color.Transparent;
            this.hlP_LabelSeparatorGeral.Location = new System.Drawing.Point(3, 3);
            this.hlP_LabelSeparatorGeral.Name = "hlP_LabelSeparatorGeral";
            this.hlP_LabelSeparatorGeral.Size = new System.Drawing.Size(415, 19);
            this.hlP_LabelSeparatorGeral.TabIndex = 0;
            this.hlP_LabelSeparatorGeral.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo._Field = "idEmpresa";
            this.txtCodigo._LabelGroup = this.hlP_LabelSeparatorGeral;
            this.txtCodigo._LabelText = "Código";
            this.txtCodigo._Multiline = false;
            this.txtCodigo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtCodigo._Password = false;
            this.txtCodigo._Regex = null;
            this.txtCodigo._Table = "Empresa";
            this.txtCodigo._TamanhoComponente = 72;
            this.txtCodigo._TamanhoMaiorLabel = 140;
            this.txtCodigo.BackColor = System.Drawing.Color.Transparent;
            this.txtCodigo.Base = null;
            this.txtCodigo.bConfiguracao = false;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCodigo.Color = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(98, 28);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(98, 3, 15, 3);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.objConfigComponenteModel = null;
            this.txtCodigo.ReadOnly = false;
            this.txtCodigo.Size = new System.Drawing.Size(117, 21);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtxNome
            // 
            this.txtxNome._Field = "xNome";
            this.txtxNome._LabelGroup = this.hlP_LabelSeparatorGeral;
            this.txtxNome._LabelText = "Nome";
            this.txtxNome._Multiline = false;
            this.txtxNome._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxNome._Password = false;
            this.txtxNome._Regex = null;
            this.txtxNome._Table = "Empresa";
            this.txtxNome._TamanhoComponente = 263;
            this.txtxNome._TamanhoMaiorLabel = 140;
            this.txtxNome.BackColor = System.Drawing.Color.Transparent;
            this.txtxNome.Base = null;
            this.txtxNome.bConfiguracao = false;
            this.txtxNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxNome.Color = System.Drawing.Color.White;
            this.txtxNome.Location = new System.Drawing.Point(106, 55);
            this.txtxNome.Margin = new System.Windows.Forms.Padding(106, 3, 15, 3);
            this.txtxNome.MaxLength = 32767;
            this.txtxNome.Name = "txtxNome";
            this.txtxNome.objConfigComponenteModel = null;
            this.txtxNome.ReadOnly = false;
            this.txtxNome.Size = new System.Drawing.Size(300, 21);
            this.txtxNome.TabIndex = 2;
            // 
            // txtxFantasia
            // 
            this.txtxFantasia._Field = "xFantasia";
            this.txtxFantasia._LabelGroup = this.hlP_LabelSeparatorGeral;
            this.txtxFantasia._LabelText = "Fantasia";
            this.txtxFantasia._Multiline = false;
            this.txtxFantasia._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxFantasia._Password = false;
            this.txtxFantasia._Regex = null;
            this.txtxFantasia._Table = "Empresa";
            this.txtxFantasia._TamanhoComponente = 263;
            this.txtxFantasia._TamanhoMaiorLabel = 140;
            this.txtxFantasia.BackColor = System.Drawing.Color.Transparent;
            this.txtxFantasia.Base = null;
            this.txtxFantasia.bConfiguracao = false;
            this.txtxFantasia.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxFantasia.Color = System.Drawing.Color.White;
            this.txtxFantasia.Location = new System.Drawing.Point(93, 82);
            this.txtxFantasia.Margin = new System.Windows.Forms.Padding(93, 3, 15, 3);
            this.txtxFantasia.MaxLength = 32767;
            this.txtxFantasia.Name = "txtxFantasia";
            this.txtxFantasia.objConfigComponenteModel = null;
            this.txtxFantasia.ReadOnly = false;
            this.txtxFantasia.Size = new System.Drawing.Size(313, 21);
            this.txtxFantasia.TabIndex = 3;
            // 
            // masktxtxCnpj
            // 
            this.masktxtxCnpj._Field = "xCNPJ";
            this.masktxtxCnpj._LabelGroup = this.hlP_LabelSeparatorGeral;
            this.masktxtxCnpj._LabelText = "Cnpj";
            this.masktxtxCnpj._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.masktxtxCnpj._Regex = null;
            this.masktxtxCnpj._Table = "Empresa";
            this.masktxtxCnpj._TamanhoComponente = 146;
            this.masktxtxCnpj._TamanhoMaiorLabel = 140;
            this.masktxtxCnpj._TpValidacao = HLP.Comum.Components.HLP_MaskedTextBox.TipoValidacao.DEFAULT;
            this.masktxtxCnpj._UF = null;
            this.masktxtxCnpj.BackColor = System.Drawing.Color.Transparent;
            this.masktxtxCnpj.Base = null;
            this.masktxtxCnpj.bConfiguracao = false;
            this.masktxtxCnpj.Color = System.Drawing.Color.White;
            this.masktxtxCnpj.Location = new System.Drawing.Point(112, 109);
            this.masktxtxCnpj.Margin = new System.Windows.Forms.Padding(112, 3, 15, 3);
            this.masktxtxCnpj.Mask = "00.000.000/0000-00";
            this.masktxtxCnpj.MaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.masktxtxCnpj.MaxLength = 32767;
            this.masktxtxCnpj.Name = "masktxtxCnpj";
            this.masktxtxCnpj.objConfigComponenteModel = null;
            this.masktxtxCnpj.ReadOnly = false;
            this.masktxtxCnpj.Size = new System.Drawing.Size(177, 21);
            this.masktxtxCnpj.TabIndex = 4;
            // 
            // txtxIe
            // 
            this.txtxIe._Field = "xIE";
            this.txtxIe._LabelGroup = this.hlP_LabelSeparatorGeral;
            this.txtxIe._LabelText = "I. e.";
            this.txtxIe._Multiline = false;
            this.txtxIe._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxIe._Password = false;
            this.txtxIe._Regex = null;
            this.txtxIe._Table = "Empresa";
            this.txtxIe._TamanhoComponente = 146;
            this.txtxIe._TamanhoMaiorLabel = 140;
            this.txtxIe.BackColor = System.Drawing.Color.Transparent;
            this.txtxIe.Base = null;
            this.txtxIe.bConfiguracao = false;
            this.txtxIe.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxIe.Color = System.Drawing.Color.White;
            this.txtxIe.Location = new System.Drawing.Point(118, 136);
            this.txtxIe.Margin = new System.Windows.Forms.Padding(118, 3, 15, 3);
            this.txtxIe.MaxLength = 32767;
            this.txtxIe.Name = "txtxIe";
            this.txtxIe.objConfigComponenteModel = null;
            this.txtxIe.ReadOnly = false;
            this.txtxIe.Size = new System.Drawing.Size(171, 21);
            this.txtxIe.TabIndex = 5;
            // 
            // txtxIm
            // 
            this.txtxIm._Field = "xIM";
            this.txtxIm._LabelGroup = this.hlP_LabelSeparatorGeral;
            this.txtxIm._LabelText = "I. m.";
            this.txtxIm._Multiline = false;
            this.txtxIm._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxIm._Password = false;
            this.txtxIm._Regex = null;
            this.txtxIm._Table = "Empresa";
            this.txtxIm._TamanhoComponente = 146;
            this.txtxIm._TamanhoMaiorLabel = 140;
            this.txtxIm.BackColor = System.Drawing.Color.Transparent;
            this.txtxIm.Base = null;
            this.txtxIm.bConfiguracao = false;
            this.txtxIm.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxIm.Color = System.Drawing.Color.White;
            this.txtxIm.Location = new System.Drawing.Point(115, 163);
            this.txtxIm.Margin = new System.Windows.Forms.Padding(115, 3, 15, 3);
            this.txtxIm.MaxLength = 32767;
            this.txtxIm.Name = "txtxIm";
            this.txtxIm.objConfigComponenteModel = null;
            this.txtxIm.ReadOnly = false;
            this.txtxIm.Size = new System.Drawing.Size(174, 21);
            this.txtxIm.TabIndex = 6;
            // 
            // txtxSuframa
            // 
            this.txtxSuframa._Field = "xSuframa";
            this.txtxSuframa._LabelGroup = this.hlP_LabelSeparatorGeral;
            this.txtxSuframa._LabelText = "Suframa";
            this.txtxSuframa._Multiline = false;
            this.txtxSuframa._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxSuframa._Password = false;
            this.txtxSuframa._Regex = null;
            this.txtxSuframa._Table = "Empresa";
            this.txtxSuframa._TamanhoComponente = 146;
            this.txtxSuframa._TamanhoMaiorLabel = 140;
            this.txtxSuframa.BackColor = System.Drawing.Color.Transparent;
            this.txtxSuframa.Base = null;
            this.txtxSuframa.bConfiguracao = false;
            this.txtxSuframa.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxSuframa.Color = System.Drawing.Color.White;
            this.txtxSuframa.Location = new System.Drawing.Point(94, 190);
            this.txtxSuframa.Margin = new System.Windows.Forms.Padding(94, 3, 15, 3);
            this.txtxSuframa.MaxLength = 32767;
            this.txtxSuframa.Name = "txtxSuframa";
            this.txtxSuframa.objConfigComponenteModel = null;
            this.txtxSuframa.ReadOnly = false;
            this.txtxSuframa.Size = new System.Drawing.Size(195, 21);
            this.txtxSuframa.TabIndex = 7;
            // 
            // txtxTelefone
            // 
            this.txtxTelefone._Field = "xTelefone";
            this.txtxTelefone._LabelGroup = this.hlP_LabelSeparatorGeral;
            this.txtxTelefone._LabelText = "Telefone";
            this.txtxTelefone._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxTelefone._Regex = null;
            this.txtxTelefone._Table = "Empresa";
            this.txtxTelefone._TamanhoComponente = 146;
            this.txtxTelefone._TamanhoMaiorLabel = 140;
            this.txtxTelefone._TpValidacao = HLP.Comum.Components.HLP_MaskedTextBox.TipoValidacao.DEFAULT;
            this.txtxTelefone._UF = null;
            this.txtxTelefone.BackColor = System.Drawing.Color.Transparent;
            this.txtxTelefone.Base = null;
            this.txtxTelefone.bConfiguracao = false;
            this.txtxTelefone.Color = System.Drawing.Color.White;
            this.txtxTelefone.Location = new System.Drawing.Point(92, 217);
            this.txtxTelefone.Margin = new System.Windows.Forms.Padding(92, 3, 15, 3);
            this.txtxTelefone.Mask = "(00)0000-0000";
            this.txtxTelefone.MaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtxTelefone.MaxLength = 32767;
            this.txtxTelefone.Name = "txtxTelefone";
            this.txtxTelefone.objConfigComponenteModel = null;
            this.txtxTelefone.ReadOnly = false;
            this.txtxTelefone.Size = new System.Drawing.Size(197, 21);
            this.txtxTelefone.TabIndex = 8;
            // 
            // txtxFax
            // 
            this.txtxFax._Field = "xFax";
            this.txtxFax._LabelGroup = this.hlP_LabelSeparatorGeral;
            this.txtxFax._LabelText = "Fax";
            this.txtxFax._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxFax._Regex = null;
            this.txtxFax._Table = "Empresa";
            this.txtxFax._TamanhoComponente = 146;
            this.txtxFax._TamanhoMaiorLabel = 140;
            this.txtxFax._TpValidacao = HLP.Comum.Components.HLP_MaskedTextBox.TipoValidacao.DEFAULT;
            this.txtxFax._UF = null;
            this.txtxFax.BackColor = System.Drawing.Color.Transparent;
            this.txtxFax.Base = null;
            this.txtxFax.bConfiguracao = false;
            this.txtxFax.Color = System.Drawing.Color.White;
            this.txtxFax.Location = new System.Drawing.Point(119, 244);
            this.txtxFax.Margin = new System.Windows.Forms.Padding(119, 3, 15, 3);
            this.txtxFax.Mask = "(00)90000-0000";
            this.txtxFax.MaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtxFax.MaxLength = 32767;
            this.txtxFax.Name = "txtxFax";
            this.txtxFax.objConfigComponenteModel = null;
            this.txtxFax.ReadOnly = false;
            this.txtxFax.Size = new System.Drawing.Size(170, 21);
            this.txtxFax.TabIndex = 9;
            // 
            // txtxEmail
            // 
            this.txtxEmail._Field = "xEmail";
            this.txtxEmail._LabelGroup = this.hlP_LabelSeparatorGeral;
            this.txtxEmail._LabelText = "Email";
            this.txtxEmail._Multiline = false;
            this.txtxEmail._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxEmail._Password = false;
            this.txtxEmail._Regex = null;
            this.txtxEmail._Table = "Empresa";
            this.txtxEmail._TamanhoComponente = 263;
            this.txtxEmail._TamanhoMaiorLabel = 140;
            this.txtxEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtxEmail.Base = null;
            this.txtxEmail.bConfiguracao = false;
            this.txtxEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxEmail.Color = System.Drawing.Color.White;
            this.txtxEmail.Location = new System.Drawing.Point(109, 271);
            this.txtxEmail.Margin = new System.Windows.Forms.Padding(109, 3, 15, 3);
            this.txtxEmail.MaxLength = 32767;
            this.txtxEmail.Name = "txtxEmail";
            this.txtxEmail.objConfigComponenteModel = null;
            this.txtxEmail.ReadOnly = false;
            this.txtxEmail.Size = new System.Drawing.Size(297, 21);
            this.txtxEmail.TabIndex = 10;
            // 
            // txtxHttp
            // 
            this.txtxHttp._Field = "xHttp";
            this.txtxHttp._LabelGroup = this.hlP_LabelSeparatorGeral;
            this.txtxHttp._LabelText = "Http";
            this.txtxHttp._Multiline = false;
            this.txtxHttp._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxHttp._Password = false;
            this.txtxHttp._Regex = null;
            this.txtxHttp._Table = "Empresa";
            this.txtxHttp._TamanhoComponente = 263;
            this.txtxHttp._TamanhoMaiorLabel = 140;
            this.txtxHttp.BackColor = System.Drawing.Color.Transparent;
            this.txtxHttp.Base = null;
            this.txtxHttp.bConfiguracao = false;
            this.txtxHttp.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxHttp.Color = System.Drawing.Color.White;
            this.txtxHttp.Location = new System.Drawing.Point(113, 298);
            this.txtxHttp.Margin = new System.Windows.Forms.Padding(113, 3, 15, 3);
            this.txtxHttp.MaxLength = 32767;
            this.txtxHttp.Name = "txtxHttp";
            this.txtxHttp.objConfigComponenteModel = null;
            this.txtxHttp.ReadOnly = false;
            this.txtxHttp.Size = new System.Drawing.Size(293, 21);
            this.txtxHttp.TabIndex = 11;
            // 
            // txtxLinkLogoEmpresa
            // 
            this.txtxLinkLogoEmpresa._Field = "xLinkLogoEmpresa";
            this.txtxLinkLogoEmpresa._LabelGroup = this.hlP_LabelSeparatorGeral;
            this.txtxLinkLogoEmpresa._LabelText = "Logo empresa";
            this.txtxLinkLogoEmpresa._Multiline = false;
            this.txtxLinkLogoEmpresa._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxLinkLogoEmpresa._Password = false;
            this.txtxLinkLogoEmpresa._Regex = null;
            this.txtxLinkLogoEmpresa._Table = "Empresa";
            this.txtxLinkLogoEmpresa._TamanhoComponente = 347;
            this.txtxLinkLogoEmpresa._TamanhoMaiorLabel = 140;
            this.txtxLinkLogoEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.txtxLinkLogoEmpresa.Base = null;
            this.txtxLinkLogoEmpresa.bConfiguracao = false;
            this.txtxLinkLogoEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxLinkLogoEmpresa.Color = System.Drawing.Color.White;
            this.txtxLinkLogoEmpresa.Location = new System.Drawing.Point(485, 3);
            this.txtxLinkLogoEmpresa.Margin = new System.Windows.Forms.Padding(64, 3, 15, 3);
            this.txtxLinkLogoEmpresa.MaxLength = 32767;
            this.txtxLinkLogoEmpresa.Name = "txtxLinkLogoEmpresa";
            this.txtxLinkLogoEmpresa.objConfigComponenteModel = null;
            this.txtxLinkLogoEmpresa.ReadOnly = false;
            this.txtxLinkLogoEmpresa.Size = new System.Drawing.Size(426, 21);
            this.txtxLinkLogoEmpresa.TabIndex = 15;
            // 
            // txtxLinkPastas
            // 
            this.txtxLinkPastas._Field = "xLinkPastas";
            this.txtxLinkPastas._LabelGroup = this.hlP_LabelSeparatorGeral;
            this.txtxLinkPastas._LabelText = "Xlinkpastas";
            this.txtxLinkPastas._Multiline = false;
            this.txtxLinkPastas._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxLinkPastas._Password = false;
            this.txtxLinkPastas._Regex = null;
            this.txtxLinkPastas._Table = "Empresa";
            this.txtxLinkPastas._TamanhoComponente = 347;
            this.txtxLinkPastas._TamanhoMaiorLabel = 140;
            this.txtxLinkPastas.BackColor = System.Drawing.Color.Transparent;
            this.txtxLinkPastas.Base = null;
            this.txtxLinkPastas.bConfiguracao = false;
            this.txtxLinkPastas.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxLinkPastas.Color = System.Drawing.Color.White;
            this.txtxLinkPastas.Location = new System.Drawing.Point(499, 30);
            this.txtxLinkPastas.Margin = new System.Windows.Forms.Padding(78, 3, 15, 3);
            this.txtxLinkPastas.MaxLength = 32767;
            this.txtxLinkPastas.Name = "txtxLinkPastas";
            this.txtxLinkPastas.objConfigComponenteModel = null;
            this.txtxLinkPastas.ReadOnly = false;
            this.txtxLinkPastas.Size = new System.Drawing.Size(412, 21);
            this.txtxLinkPastas.TabIndex = 16;
            // 
            // cboAtivo
            // 
            this.cboAtivo._Field = "Ativo";
            this.cboAtivo._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cboAtivo._Itens")));
            this.cboAtivo._LabelGroup = this.hlP_LabelSeparatorGeral;
            this.cboAtivo._LabelText = "Ativo";
            this.cboAtivo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cboAtivo._Regex = null;
            this.cboAtivo._situacao = true;
            this.cboAtivo._Table = "Empresa";
            this.cboAtivo._TamanhoComponente = 80;
            this.cboAtivo._TamanhoMaiorLabel = 140;
            this.cboAtivo.BackColor = System.Drawing.Color.Transparent;
            this.cboAtivo.Base = null;
            this.cboAtivo.bConfiguracao = false;
            this.cboAtivo.Color = System.Drawing.Color.White;
            this.cboAtivo.DataSource = null;
            this.cboAtivo.DisplayMember = "DisplayMember";
            this.cboAtivo.Location = new System.Drawing.Point(531, 57);
            this.cboAtivo.Margin = new System.Windows.Forms.Padding(110, 3, 15, 3);
            this.cboAtivo.Name = "cboAtivo";
            this.cboAtivo.objConfigComponenteModel = null;
            this.cboAtivo.SelectedIndex = -1;
            this.cboAtivo.SelectedValue = 0;
            this.cboAtivo.Size = new System.Drawing.Size(113, 21);
            this.cboAtivo.TabIndex = 12;
            this.cboAtivo.ValueMember = "ValueMember";
            // 
            // hlP_PesquisaidRamoAtividade
            // 
            this.hlP_PesquisaidRamoAtividade._Field = "idRamoAtividade";
            this.hlP_PesquisaidRamoAtividade._LabelGroup = this.hlP_LabelSeparatorGeral;
            this.hlP_PesquisaidRamoAtividade._LabelText = "Ramo atividade";
            this.hlP_PesquisaidRamoAtividade._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidRamoAtividade._ListaCamposDisplay")));
            this.hlP_PesquisaidRamoAtividade._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidRamoAtividade._ListaValoresDisplay")));
            this.hlP_PesquisaidRamoAtividade._NomeCampoPK = "ID";
            this.hlP_PesquisaidRamoAtividade._NomeFormCadastroOriginal = "FormRamoAtividade";
            this.hlP_PesquisaidRamoAtividade._NomeView = "vwRamoAtividade";
            this.hlP_PesquisaidRamoAtividade._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisaidRamoAtividade._Regex = null;
            this.hlP_PesquisaidRamoAtividade._Table = "Empresa";
            this.hlP_PesquisaidRamoAtividade._TamanhoComponente = 300;
            this.hlP_PesquisaidRamoAtividade._TamanhoMaiorLabel = 140;
            this.hlP_PesquisaidRamoAtividade._Vinculado = false;
            this.hlP_PesquisaidRamoAtividade.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidRamoAtividade.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidRamoAtividade.Base = null;
            this.hlP_PesquisaidRamoAtividade.bConfiguracao = false;
            this.hlP_PesquisaidRamoAtividade.Location = new System.Drawing.Point(478, 84);
            this.hlP_PesquisaidRamoAtividade.Margin = new System.Windows.Forms.Padding(57, 3, 15, 3);
            this.hlP_PesquisaidRamoAtividade.Name = "hlP_PesquisaidRamoAtividade";
            this.hlP_PesquisaidRamoAtividade.objConfigComponenteModel = null;
            this.hlP_PesquisaidRamoAtividade.ReadOnly = false;
            this.hlP_PesquisaidRamoAtividade.Size = new System.Drawing.Size(386, 21);
            this.hlP_PesquisaidRamoAtividade.TabIndex = 13;
            this.hlP_PesquisaidRamoAtividade.Value = 0;
            // 
            // cbostCodigoRegimeTributario
            // 
            this.cbostCodigoRegimeTributario._Field = "stCodigoRegimeTributario";
            this.cbostCodigoRegimeTributario._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostCodigoRegimeTributario._Itens")));
            this.cbostCodigoRegimeTributario._LabelGroup = this.hlP_LabelSeparatorGeral;
            this.cbostCodigoRegimeTributario._LabelText = "Regime tributário";
            this.cbostCodigoRegimeTributario._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostCodigoRegimeTributario._Regex = null;
            this.cbostCodigoRegimeTributario._situacao = true;
            this.cbostCodigoRegimeTributario._Table = "Empresa";
            this.cbostCodigoRegimeTributario._TamanhoComponente = 80;
            this.cbostCodigoRegimeTributario._TamanhoMaiorLabel = 140;
            this.cbostCodigoRegimeTributario.BackColor = System.Drawing.Color.Transparent;
            this.cbostCodigoRegimeTributario.Base = null;
            this.cbostCodigoRegimeTributario.bConfiguracao = false;
            this.cbostCodigoRegimeTributario.Color = System.Drawing.Color.White;
            this.cbostCodigoRegimeTributario.DataSource = null;
            this.cbostCodigoRegimeTributario.DisplayMember = "DisplayMember";
            this.cbostCodigoRegimeTributario.Location = new System.Drawing.Point(467, 111);
            this.cbostCodigoRegimeTributario.Margin = new System.Windows.Forms.Padding(46, 3, 15, 3);
            this.cbostCodigoRegimeTributario.Name = "cbostCodigoRegimeTributario";
            this.cbostCodigoRegimeTributario.objConfigComponenteModel = null;
            this.cbostCodigoRegimeTributario.SelectedIndex = -1;
            this.cbostCodigoRegimeTributario.SelectedValue = 0;
            this.cbostCodigoRegimeTributario.Size = new System.Drawing.Size(177, 21);
            this.cbostCodigoRegimeTributario.TabIndex = 14;
            this.cbostCodigoRegimeTributario.ValueMember = "ValueMember";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.kryptonPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1144, 225);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Tag = false;
            this.tabPage2.Text = "Endereço";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.dgvEnderecoEmpresa);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(1144, 225);
            this.kryptonPanel2.TabIndex = 0;
            // 
            // dgvEnderecoEmpresa
            // 
            this.dgvEnderecoEmpresa.Altera = false;
            this.dgvEnderecoEmpresa.AutoGenerateColumns = false;
            this.dgvEnderecoEmpresa.cm = null;
            this.dgvEnderecoEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnderecoEmpresa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stTipoEndDataGridViewTextBoxColumn,
            this.xLgrDataGridViewTextBoxColumn,
            this.nroDataGridViewTextBoxColumn,
            this.xCplDataGridViewTextBoxColumn,
            this.xBairroDataGridViewTextBoxColumn,
            this.cepDataGridViewTextBoxColumn,
            this.xCxPostalDataGridViewTextBoxColumn,
            this.idCidade});
            this.dgvEnderecoEmpresa.DataSource = this.bsEmpresaEndereco;
            this.dgvEnderecoEmpresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEnderecoEmpresa.DragDropLinha = false;
            this.dgvEnderecoEmpresa.Exclui = false;
            this.dgvEnderecoEmpresa.Inclui = false;
            this.dgvEnderecoEmpresa.Location = new System.Drawing.Point(0, 0);
            this.dgvEnderecoEmpresa.Name = "dgvEnderecoEmpresa";
            this.dgvEnderecoEmpresa.Size = new System.Drawing.Size(1144, 225);
            this.dgvEnderecoEmpresa.TabIndex = 0;
            this.dgvEnderecoEmpresa.Tag = "Empresa_endereco";
            // 
            // stTipoEndDataGridViewTextBoxColumn
            // 
            this.stTipoEndDataGridViewTextBoxColumn.DataPropertyName = "StTipoEnd";
            this.stTipoEndDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.stTipoEndDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "0-COMERCIAL",
            "1-ENTREGA",
            "2-ENTREGA ALT",
            "3-NOTA FISCAL",
            "4-RESIDÊNCIA",
            "5-SERVIÇO",
            "6-SWIFT",
            "PAGAMENTO",
            "9-OUTRO"});
            this.stTipoEndDataGridViewTextBoxColumn.Name = "stTipoEndDataGridViewTextBoxColumn";
            this.stTipoEndDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stTipoEndDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // xLgrDataGridViewTextBoxColumn
            // 
            this.xLgrDataGridViewTextBoxColumn.DataPropertyName = "xLgr";
            this.xLgrDataGridViewTextBoxColumn.HeaderText = "Logradouro";
            this.xLgrDataGridViewTextBoxColumn.Name = "xLgrDataGridViewTextBoxColumn";
            // 
            // nroDataGridViewTextBoxColumn
            // 
            this.nroDataGridViewTextBoxColumn.DataPropertyName = "nro";
            this.nroDataGridViewTextBoxColumn.HeaderText = "Número";
            this.nroDataGridViewTextBoxColumn.Name = "nroDataGridViewTextBoxColumn";
            // 
            // xCplDataGridViewTextBoxColumn
            // 
            this.xCplDataGridViewTextBoxColumn.DataPropertyName = "xCpl";
            this.xCplDataGridViewTextBoxColumn.HeaderText = "Complemento";
            this.xCplDataGridViewTextBoxColumn.Name = "xCplDataGridViewTextBoxColumn";
            // 
            // xBairroDataGridViewTextBoxColumn
            // 
            this.xBairroDataGridViewTextBoxColumn.DataPropertyName = "xBairro";
            this.xBairroDataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.xBairroDataGridViewTextBoxColumn.Name = "xBairroDataGridViewTextBoxColumn";
            // 
            // cepDataGridViewTextBoxColumn
            // 
            this.cepDataGridViewTextBoxColumn.DataPropertyName = "Cep";
            this.cepDataGridViewTextBoxColumn.HeaderText = "Cep";
            this.cepDataGridViewTextBoxColumn.Mask = "00000-000";
            this.cepDataGridViewTextBoxColumn.Name = "cepDataGridViewTextBoxColumn";
            this.cepDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cepDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cepDataGridViewTextBoxColumn.Width = 100;
            // 
            // xCxPostalDataGridViewTextBoxColumn
            // 
            this.xCxPostalDataGridViewTextBoxColumn.DataPropertyName = "xCxPostal";
            this.xCxPostalDataGridViewTextBoxColumn.HeaderText = "Caixa Postal";
            this.xCxPostalDataGridViewTextBoxColumn.Name = "xCxPostalDataGridViewTextBoxColumn";
            // 
            // idCidade
            // 
            this.idCidade.DataPropertyName = "idCidade";
            this.idCidade.HeaderText = "Cidade";
            this.idCidade.Name = "idCidade";
            this.idCidade.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idCidade.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // bsEmpresaEndereco
            // 
            this.bsEmpresaEndereco.DataSource = typeof(HLP.Models.Entries.Gerais.Empresa_EnderecoModel);
            // 
            // FormEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 434);
            this.Name = "FormEmpresa";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = -10;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text = "Empresa";
            this.Load += new System.EventHandler(this.FormEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).EndInit();
            this.panelPadrao.ResumeLayout(false);
            this.kryptonTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnderecoEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmpresaEndereco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Comum.Components.HLP_LabelSeparator hlP_LabelSeparatorGeral;
        private Comum.Components.HLP_TextBox txtCodigo;
        private Comum.Components.HLP_TextBox txtxNome;
        private Comum.Components.HLP_TextBox txtxFantasia;
        private Comum.Components.HLP_MaskedTextBox masktxtxCnpj;
        private Comum.Components.HLP_TextBox txtxIe;
        private Comum.Components.HLP_TextBox txtxIm;
        private Comum.Components.HLP_TextBox txtxSuframa;
        private Comum.Components.HLP_MaskedTextBox txtxTelefone;
        private Comum.Components.HLP_MaskedTextBox txtxFax;
        private Comum.Components.HLP_TextBox txtxEmail;
        private Comum.Components.HLP_TextBox txtxHttp;
        private Comum.Components.HLP_ComboBox cboAtivo;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidRamoAtividade;
        private Comum.Components.HLP_ComboBox cbostCodigoRegimeTributario;
        private System.Windows.Forms.BindingSource bsEmpresaEndereco;
        private System.Windows.Forms.TabPage tabPage2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Comum.Components.HLP_DataGridView dgvEnderecoEmpresa;
        private System.Windows.Forms.DataGridViewComboBoxColumn stTipoEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xLgrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCplDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xBairroDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewMaskedTextBoxColumn cepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCxPostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idCidade;
        private Comum.Components.HLP_TextBox txtxLinkLogoEmpresa;
        private Comum.Components.HLP_TextBox txtxLinkPastas;
    }
}