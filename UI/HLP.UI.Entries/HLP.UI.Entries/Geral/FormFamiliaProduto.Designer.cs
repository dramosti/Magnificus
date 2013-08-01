using HLP.Comum.Components;
namespace HLP.UI.Entries.Geral
{
    partial class FormFamiliaProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFamiliaProduto));
            this.kryptonTabControl1 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kryptonPanel1 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.Principal = new System.Windows.Forms.FlowLayoutPanel();
            this.sp_Identificação = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtCodigo = new HLP.Comum.Components.HLP_TextBox();
            this.txtxFamiliaProduto = new HLP.Comum.Components.HLP_TextBox();
            this.txtxDescricao = new HLP.Comum.Components.HLP_TextBox();
            this.txtxSigla = new HLP.Comum.Components.HLP_TextBox();
            this.cbxstGrau = new HLP.Comum.Components.HLP_ComboBox();
            this.sp_config = new HLP.Comum.Components.HLP_LabelSeparator();
            this.nudpDescontoMaximo = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudpAcrescimoMaximo = new HLP.Comum.Components.HLP_NumericUpDown();
            this.hlP_PesquisaidContaContabil = new HLP.Comum.Components.HLP_Pesquisa();
            this.hlP_PesquisaidCentroCusto = new HLP.Comum.Components.HLP_Pesquisa();
            this.cbostAlteraDescricaoComercialProdutoVenda = new HLP.Comum.Components.HLP_ComboBox();
            this.sp_representante = new HLP.Comum.Components.HLP_LabelSeparator();
            this.hlP_PesquisaidLinhaProdutoBase = new HLP.Comum.Components.HLP_Pesquisa();
            this.nudpComissaoAvista = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudpComissaoAprazo = new HLP.Comum.Components.HLP_NumericUpDown();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.kryptonPanel2 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.dgvClassificacaoFinanc = new HLP.Comum.Components.HLP_DataGridView();
            this.idTipoOperacao = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idClasseFinanceira = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsFamiliaProduto = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).BeginInit();
            this.panelPadrao.SuspendLayout();
            this.kryptonTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.kryptonPanel1.SuspendLayout();
            this.Principal.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassificacaoFinanc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFamiliaProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(734, 497);
            // 
            // panelPadrao
            // 
            this.panelPadrao.Controls.Add(this.kryptonTabControl1);
            this.panelPadrao.Size = new System.Drawing.Size(732, 473);
            // 
            // kryptonTabControl1
            // 
            this.kryptonTabControl1.AllowCloseButton = false;
            this.kryptonTabControl1.AllowContextButton = false;
            this.kryptonTabControl1.AllowNavigatorButtons = false;
            this.kryptonTabControl1.AllowSelectedTabHigh = false;
            this.kryptonTabControl1.BorderWidth = 1;
            this.kryptonTabControl1.Controls.Add(this.tabPage1);
            this.kryptonTabControl1.Controls.Add(this.tabPage3);
            this.kryptonTabControl1.CornerRoundRadiusWidth = 12;
            this.kryptonTabControl1.CornerSymmetry = AC.ExtendedRenderer.Navigator.KryptonTabControl.CornSymmetry.Both;
            this.kryptonTabControl1.CornerType = AC.ExtendedRenderer.Toolkit.Drawing.DrawingMethods.CornerType.Rounded;
            this.kryptonTabControl1.CornerWidth = AC.ExtendedRenderer.Navigator.KryptonTabControl.CornWidth.Thin;
            this.kryptonTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.kryptonTabControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.kryptonTabControl1.HotTrack = true;
            this.kryptonTabControl1.Location = new System.Drawing.Point(3, 3);
            this.kryptonTabControl1.Name = "kryptonTabControl1";
            this.kryptonTabControl1.PreserveTabColor = false;
            this.kryptonTabControl1.SelectedIndex = 0;
            this.kryptonTabControl1.Size = new System.Drawing.Size(726, 467);
            this.kryptonTabControl1.TabIndex = 6;
            this.kryptonTabControl1.UseExtendedLayout = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Controls.Add(this.kryptonPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(718, 438);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = false;
            this.tabPage1.Text = "Principal";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.BorderWidth = 0;
            this.kryptonPanel1.Controls.Add(this.Principal);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.kryptonPanel1.GradientToogleColors = false;
            this.kryptonPanel1.GradientUseBlend = false;
            this.kryptonPanel1.GradientUseSolid = true;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PersistentColors = false;
            this.kryptonPanel1.Size = new System.Drawing.Size(718, 438);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // Principal
            // 
            this.Principal.AutoScroll = true;
            this.Principal.BackColor = System.Drawing.Color.Transparent;
            this.Principal.Controls.Add(this.sp_Identificação);
            this.Principal.Controls.Add(this.txtCodigo);
            this.Principal.Controls.Add(this.txtxFamiliaProduto);
            this.Principal.Controls.Add(this.txtxDescricao);
            this.Principal.Controls.Add(this.txtxSigla);
            this.Principal.Controls.Add(this.cbxstGrau);
            this.Principal.Controls.Add(this.sp_config);
            this.Principal.Controls.Add(this.nudpDescontoMaximo);
            this.Principal.Controls.Add(this.nudpAcrescimoMaximo);
            this.Principal.Controls.Add(this.hlP_PesquisaidContaContabil);
            this.Principal.Controls.Add(this.hlP_PesquisaidCentroCusto);
            this.Principal.Controls.Add(this.cbostAlteraDescricaoComercialProdutoVenda);
            this.Principal.Controls.Add(this.sp_representante);
            this.Principal.Controls.Add(this.hlP_PesquisaidLinhaProdutoBase);
            this.Principal.Controls.Add(this.nudpComissaoAvista);
            this.Principal.Controls.Add(this.nudpComissaoAprazo);
            this.Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Principal.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Principal.Location = new System.Drawing.Point(0, 0);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(718, 438);
            this.Principal.TabIndex = 1;
            this.Principal.Tag = "Principal";
            // 
            // sp_Identificação
            // 
            this.sp_Identificação._LabelText = "Identificação";
            this.sp_Identificação._TamanhoMaiorLabel = 0;
            this.sp_Identificação.BackColor = System.Drawing.Color.Transparent;
            this.sp_Identificação.Location = new System.Drawing.Point(0, 3);
            this.sp_Identificação.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.sp_Identificação.Name = "sp_Identificação";
            this.sp_Identificação.Size = new System.Drawing.Size(693, 18);
            this.sp_Identificação.TabIndex = 14;
            this.sp_Identificação.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo._Field = "idFamiliaProduto";
            this.txtCodigo._LabelGroup = this.sp_Identificação;
            this.txtCodigo._LabelText = "Código";
            this.txtCodigo._Multiline = false;
            this.txtCodigo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtCodigo._Password = false;
            this.txtCodigo._Regex = null;
            this.txtCodigo._Table = "Familia_Produto";
            this.txtCodigo._TamanhoComponente = 107;
            this.txtCodigo._TamanhoMaiorLabel = 300;
            this.txtCodigo.BackColor = System.Drawing.Color.Transparent;
            this.txtCodigo.Base = null;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCodigo.Color = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(258, 27);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(258, 3, 15, 3);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.objConfigComponenteModel = null;
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(152, 21);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtxFamiliaProduto
            // 
            this.txtxFamiliaProduto._Field = "xFamiliaProduto";
            this.txtxFamiliaProduto._Help = resources.GetString("txtxFamiliaProduto._Help");
            this.txtxFamiliaProduto._LabelGroup = this.sp_Identificação;
            this.txtxFamiliaProduto._LabelText = "Código da família de produto";
            this.txtxFamiliaProduto._Multiline = false;
            this.txtxFamiliaProduto._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxFamiliaProduto._Password = false;
            this.txtxFamiliaProduto._Regex = null;
            this.txtxFamiliaProduto._Table = "Familia_Produto";
            this.txtxFamiliaProduto._TamanhoComponente = 224;
            this.txtxFamiliaProduto._TamanhoMaiorLabel = 300;
            this.txtxFamiliaProduto.BackColor = System.Drawing.Color.Transparent;
            this.txtxFamiliaProduto.Base = null;
            this.txtxFamiliaProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxFamiliaProduto.Color = System.Drawing.Color.White;
            this.txtxFamiliaProduto.Location = new System.Drawing.Point(143, 54);
            this.txtxFamiliaProduto.Margin = new System.Windows.Forms.Padding(143, 3, 15, 3);
            this.txtxFamiliaProduto.MaxLength = 32767;
            this.txtxFamiliaProduto.Name = "txtxFamiliaProduto";
            this.txtxFamiliaProduto.objConfigComponenteModel = null;
            this.txtxFamiliaProduto.ReadOnly = false;
            this.txtxFamiliaProduto.Size = new System.Drawing.Size(384, 21);
            this.txtxFamiliaProduto.TabIndex = 3;
            // 
            // txtxDescricao
            // 
            this.txtxDescricao._Field = "xDescricao";
            this.txtxDescricao._Help = "Esse campo define a descrição para a linha do produto";
            this.txtxDescricao._LabelGroup = this.sp_Identificação;
            this.txtxDescricao._LabelText = "Descrição ";
            this.txtxDescricao._Multiline = false;
            this.txtxDescricao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxDescricao._Password = false;
            this.txtxDescricao._Regex = null;
            this.txtxDescricao._Table = "Familia_Produto";
            this.txtxDescricao._TamanhoComponente = 221;
            this.txtxDescricao._TamanhoMaiorLabel = 300;
            this.txtxDescricao.BackColor = System.Drawing.Color.Transparent;
            this.txtxDescricao.Base = null;
            this.txtxDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxDescricao.Color = System.Drawing.Color.White;
            this.txtxDescricao.Location = new System.Drawing.Point(244, 81);
            this.txtxDescricao.Margin = new System.Windows.Forms.Padding(244, 3, 15, 3);
            this.txtxDescricao.MaxLength = 10;
            this.txtxDescricao.Name = "txtxDescricao";
            this.txtxDescricao.objConfigComponenteModel = null;
            this.txtxDescricao.ReadOnly = false;
            this.txtxDescricao.Size = new System.Drawing.Size(280, 21);
            this.txtxDescricao.TabIndex = 2;
            // 
            // txtxSigla
            // 
            this.txtxSigla._Field = "xSigla";
            this.txtxSigla._Help = "Informar resumidamente em 10 caracteres uma sigla ou apelido para a família de pr" +
    "oduto.";
            this.txtxSigla._LabelGroup = this.sp_Identificação;
            this.txtxSigla._LabelText = "Sigla";
            this.txtxSigla._Multiline = false;
            this.txtxSigla._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxSigla._Password = false;
            this.txtxSigla._Regex = null;
            this.txtxSigla._Table = "Familia_Produto";
            this.txtxSigla._TamanhoComponente = 134;
            this.txtxSigla._TamanhoMaiorLabel = 300;
            this.txtxSigla.BackColor = System.Drawing.Color.Transparent;
            this.txtxSigla.Base = null;
            this.txtxSigla.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxSigla.Color = System.Drawing.Color.White;
            this.txtxSigla.Location = new System.Drawing.Point(271, 108);
            this.txtxSigla.Margin = new System.Windows.Forms.Padding(271, 3, 15, 3);
            this.txtxSigla.MaxLength = 32767;
            this.txtxSigla.Name = "txtxSigla";
            this.txtxSigla.objConfigComponenteModel = null;
            this.txtxSigla.ReadOnly = false;
            this.txtxSigla.Size = new System.Drawing.Size(166, 21);
            this.txtxSigla.TabIndex = 4;
            // 
            // cbxstGrau
            // 
            this.cbxstGrau._Field = "stGrau";
            this.cbxstGrau._Help = resources.GetString("cbxstGrau._Help");
            this.cbxstGrau._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbxstGrau._Itens")));
            this.cbxstGrau._LabelGroup = this.sp_Identificação;
            this.cbxstGrau._LabelText = "Grau";
            this.cbxstGrau._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbxstGrau._Regex = null;
            this.cbxstGrau._situacao = false;
            this.cbxstGrau._Table = "Familia_produto";
            this.cbxstGrau._TamanhoComponente = 104;
            this.cbxstGrau._TamanhoMaiorLabel = 300;
            this.cbxstGrau.BackColor = System.Drawing.Color.Transparent;
            this.cbxstGrau.Base = null;
            this.cbxstGrau.Color = System.Drawing.Color.White;
            this.cbxstGrau.DataSource = null;
            this.cbxstGrau.DisplayMember = "DisplayMember";
            this.cbxstGrau.Location = new System.Drawing.Point(271, 135);
            this.cbxstGrau.Margin = new System.Windows.Forms.Padding(271, 3, 15, 3);
            this.cbxstGrau.Name = "cbxstGrau";
            this.cbxstGrau.objConfigComponenteModel = null;
            this.cbxstGrau.SelectedIndex = -1;
            this.cbxstGrau.SelectedValue = 0;
            this.cbxstGrau.Size = new System.Drawing.Size(136, 21);
            this.cbxstGrau.TabIndex = 17;
            this.cbxstGrau.ValueMember = "ValueMember";
            // 
            // sp_config
            // 
            this.sp_config._LabelText = "Configuração";
            this.sp_config._TamanhoMaiorLabel = 0;
            this.sp_config.BackColor = System.Drawing.Color.Transparent;
            this.sp_config.Location = new System.Drawing.Point(0, 162);
            this.sp_config.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.sp_config.Name = "sp_config";
            this.sp_config.Size = new System.Drawing.Size(693, 18);
            this.sp_config.TabIndex = 15;
            this.sp_config.TabStop = false;
            // 
            // nudpDescontoMaximo
            // 
            this.nudpDescontoMaximo._Field = "pDescontoMaximo";
            this.nudpDescontoMaximo._Help = "Informar um percentual de desconto máximo para a linha inteira de produto";
            this.nudpDescontoMaximo._LabelGroup = this.sp_config;
            this.nudpDescontoMaximo._LabelText = "Percentual de desconto máximo";
            this.nudpDescontoMaximo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudpDescontoMaximo._Regex = null;
            this.nudpDescontoMaximo._Table = "Familia_Produto";
            this.nudpDescontoMaximo._TamanhoComponente = 121;
            this.nudpDescontoMaximo._TamanhoMaiorLabel = 300;
            this.nudpDescontoMaximo.BackColor = System.Drawing.Color.Transparent;
            this.nudpDescontoMaximo.Base = null;
            this.nudpDescontoMaximo.Color = System.Drawing.Color.White;
            this.nudpDescontoMaximo.DecimalPlaces = 2;
            this.nudpDescontoMaximo.Location = new System.Drawing.Point(133, 186);
            this.nudpDescontoMaximo.Margin = new System.Windows.Forms.Padding(133, 3, 15, 3);
            this.nudpDescontoMaximo.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudpDescontoMaximo.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudpDescontoMaximo.Name = "nudpDescontoMaximo";
            this.nudpDescontoMaximo.objConfigComponenteModel = null;
            this.nudpDescontoMaximo.ReadOnly = false;
            this.nudpDescontoMaximo.Size = new System.Drawing.Size(291, 22);
            this.nudpDescontoMaximo.TabIndex = 5;
            this.nudpDescontoMaximo.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudpDescontoMaximo.ValueInt = 0;
            this.nudpDescontoMaximo._Leave += new System.EventHandler(this.nudpDescontoMaximo__Leave);
            // 
            // nudpAcrescimoMaximo
            // 
            this.nudpAcrescimoMaximo._Field = "pAcressimoMaximo";
            this.nudpAcrescimoMaximo._Help = "Informar um percentual de acréscimo máximo para a linha inteira de produto";
            this.nudpAcrescimoMaximo._LabelGroup = this.sp_config;
            this.nudpAcrescimoMaximo._LabelText = "Percentual de acrescimo máximo";
            this.nudpAcrescimoMaximo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudpAcrescimoMaximo._Regex = null;
            this.nudpAcrescimoMaximo._Table = "Familia_Produto";
            this.nudpAcrescimoMaximo._TamanhoComponente = 121;
            this.nudpAcrescimoMaximo._TamanhoMaiorLabel = 300;
            this.nudpAcrescimoMaximo.BackColor = System.Drawing.Color.Transparent;
            this.nudpAcrescimoMaximo.Base = null;
            this.nudpAcrescimoMaximo.Color = System.Drawing.Color.White;
            this.nudpAcrescimoMaximo.DecimalPlaces = 2;
            this.nudpAcrescimoMaximo.Location = new System.Drawing.Point(131, 214);
            this.nudpAcrescimoMaximo.Margin = new System.Windows.Forms.Padding(131, 3, 15, 3);
            this.nudpAcrescimoMaximo.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudpAcrescimoMaximo.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudpAcrescimoMaximo.Name = "nudpAcrescimoMaximo";
            this.nudpAcrescimoMaximo.objConfigComponenteModel = null;
            this.nudpAcrescimoMaximo.ReadOnly = false;
            this.nudpAcrescimoMaximo.Size = new System.Drawing.Size(293, 22);
            this.nudpAcrescimoMaximo.TabIndex = 6;
            this.nudpAcrescimoMaximo.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudpAcrescimoMaximo.ValueInt = 0;
            // 
            // hlP_PesquisaidContaContabil
            // 
            this.hlP_PesquisaidContaContabil._Field = "idContaContabil";
            this.hlP_PesquisaidContaContabil._Help = "Informar a conta contábil para a família de produto, servirá com base padrão para" +
    " todos os itens relacionado a essa família. ";
            this.hlP_PesquisaidContaContabil._LabelGroup = this.sp_config;
            this.hlP_PesquisaidContaContabil._LabelText = "Conta contábil";
            this.hlP_PesquisaidContaContabil._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidContaContabil._ListaCamposDisplay")));
            this.hlP_PesquisaidContaContabil._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidContaContabil._ListaValoresDisplay")));
            this.hlP_PesquisaidContaContabil._NomeCampoPK = "ID";
            this.hlP_PesquisaidContaContabil._NomeFormCadastroOriginal = "FormContaContabil";
            this.hlP_PesquisaidContaContabil._NomeView = "vwContaContabil";
            this.hlP_PesquisaidContaContabil._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisaidContaContabil._Regex = null;
            this.hlP_PesquisaidContaContabil._Table = "Familia_Produto";
            this.hlP_PesquisaidContaContabil._TamanhoComponente = 300;
            this.hlP_PesquisaidContaContabil._TamanhoMaiorLabel = 300;
            this.hlP_PesquisaidContaContabil._Vinculado = false;
            this.hlP_PesquisaidContaContabil.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidContaContabil.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidContaContabil.Base = null;
            this.hlP_PesquisaidContaContabil.Location = new System.Drawing.Point(220, 242);
            this.hlP_PesquisaidContaContabil.Margin = new System.Windows.Forms.Padding(220, 3, 15, 3);
            this.hlP_PesquisaidContaContabil.Name = "hlP_PesquisaidContaContabil";
            this.hlP_PesquisaidContaContabil.objConfigComponenteModel = null;
            this.hlP_PesquisaidContaContabil.ReadOnly = false;
            this.hlP_PesquisaidContaContabil.Size = new System.Drawing.Size(383, 21);
            this.hlP_PesquisaidContaContabil.TabIndex = 9;
            this.hlP_PesquisaidContaContabil.Value = 0;
            // 
            // hlP_PesquisaidCentroCusto
            // 
            this.hlP_PesquisaidCentroCusto._Field = "idCentroCusto";
            this.hlP_PesquisaidCentroCusto._Help = "Informar o centro de custo para a família de produto, servirá com base padrão par" +
    "a todos os itens relacionado a essa família. ";
            this.hlP_PesquisaidCentroCusto._LabelGroup = this.sp_config;
            this.hlP_PesquisaidCentroCusto._LabelText = "Centro de custo";
            this.hlP_PesquisaidCentroCusto._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidCentroCusto._ListaCamposDisplay")));
            this.hlP_PesquisaidCentroCusto._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidCentroCusto._ListaValoresDisplay")));
            this.hlP_PesquisaidCentroCusto._NomeCampoPK = "ID";
            this.hlP_PesquisaidCentroCusto._NomeFormCadastroOriginal = "FormCentroCusto";
            this.hlP_PesquisaidCentroCusto._NomeView = "vwCentroCusto";
            this.hlP_PesquisaidCentroCusto._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisaidCentroCusto._Regex = null;
            this.hlP_PesquisaidCentroCusto._Table = "Familia_Produto";
            this.hlP_PesquisaidCentroCusto._TamanhoComponente = 300;
            this.hlP_PesquisaidCentroCusto._TamanhoMaiorLabel = 300;
            this.hlP_PesquisaidCentroCusto._Vinculado = false;
            this.hlP_PesquisaidCentroCusto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidCentroCusto.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidCentroCusto.Base = null;
            this.hlP_PesquisaidCentroCusto.Location = new System.Drawing.Point(214, 269);
            this.hlP_PesquisaidCentroCusto.Margin = new System.Windows.Forms.Padding(214, 3, 15, 3);
            this.hlP_PesquisaidCentroCusto.Name = "hlP_PesquisaidCentroCusto";
            this.hlP_PesquisaidCentroCusto.objConfigComponenteModel = null;
            this.hlP_PesquisaidCentroCusto.ReadOnly = false;
            this.hlP_PesquisaidCentroCusto.Size = new System.Drawing.Size(389, 21);
            this.hlP_PesquisaidCentroCusto.TabIndex = 10;
            this.hlP_PesquisaidCentroCusto.Value = 0;
            // 
            // cbostAlteraDescricaoComercialProdutoVenda
            // 
            this.cbostAlteraDescricaoComercialProdutoVenda._Field = "stAlteraDescricaoComercialProdutoVenda";
            this.cbostAlteraDescricaoComercialProdutoVenda._Help = "Informar ao sistema se poderá ou não alterar a descrição do produto no módulo com" +
    "ercial (orçamento, vendas, faturamento). 0 - não 1 - sim (default)";
            this.cbostAlteraDescricaoComercialProdutoVenda._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostAlteraDescricaoComercialProdutoVenda._Itens")));
            this.cbostAlteraDescricaoComercialProdutoVenda._LabelGroup = this.sp_config;
            this.cbostAlteraDescricaoComercialProdutoVenda._LabelText = "Altera descrição comercial do produto em vendas";
            this.cbostAlteraDescricaoComercialProdutoVenda._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostAlteraDescricaoComercialProdutoVenda._Regex = null;
            this.cbostAlteraDescricaoComercialProdutoVenda._situacao = true;
            this.cbostAlteraDescricaoComercialProdutoVenda._Table = "Familia_produto";
            this.cbostAlteraDescricaoComercialProdutoVenda._TamanhoComponente = 80;
            this.cbostAlteraDescricaoComercialProdutoVenda._TamanhoMaiorLabel = 300;
            this.cbostAlteraDescricaoComercialProdutoVenda.BackColor = System.Drawing.Color.Transparent;
            this.cbostAlteraDescricaoComercialProdutoVenda.Base = null;
            this.cbostAlteraDescricaoComercialProdutoVenda.Color = System.Drawing.Color.White;
            this.cbostAlteraDescricaoComercialProdutoVenda.DataSource = null;
            this.cbostAlteraDescricaoComercialProdutoVenda.DisplayMember = "DisplayMember";
            this.cbostAlteraDescricaoComercialProdutoVenda.Location = new System.Drawing.Point(44, 296);
            this.cbostAlteraDescricaoComercialProdutoVenda.Margin = new System.Windows.Forms.Padding(44, 3, 15, 3);
            this.cbostAlteraDescricaoComercialProdutoVenda.Name = "cbostAlteraDescricaoComercialProdutoVenda";
            this.cbostAlteraDescricaoComercialProdutoVenda.objConfigComponenteModel = null;
            this.cbostAlteraDescricaoComercialProdutoVenda.SelectedIndex = 1;
            this.cbostAlteraDescricaoComercialProdutoVenda.SelectedValue = 0;
            this.cbostAlteraDescricaoComercialProdutoVenda.Size = new System.Drawing.Size(339, 21);
            this.cbostAlteraDescricaoComercialProdutoVenda.TabIndex = 18;
            this.cbostAlteraDescricaoComercialProdutoVenda.ValueMember = "ValueMember";
            // 
            // sp_representante
            // 
            this.sp_representante._LabelText = "Representante";
            this.sp_representante._TamanhoMaiorLabel = 0;
            this.sp_representante.BackColor = System.Drawing.Color.Transparent;
            this.sp_representante.Location = new System.Drawing.Point(0, 323);
            this.sp_representante.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.sp_representante.Name = "sp_representante";
            this.sp_representante.Size = new System.Drawing.Size(693, 18);
            this.sp_representante.TabIndex = 16;
            this.sp_representante.TabStop = false;
            // 
            // hlP_PesquisaidLinhaProdutoBase
            // 
            this.hlP_PesquisaidLinhaProdutoBase._Field = "idFamiliaProdutoBase";
            this.hlP_PesquisaidLinhaProdutoBase._Help = "Informar a familia de produto que servirá como base para os lançamentos de classe" +
    "s financeira";
            this.hlP_PesquisaidLinhaProdutoBase._LabelGroup = this.sp_representante;
            this.hlP_PesquisaidLinhaProdutoBase._LabelText = "Familia de produto base";
            this.hlP_PesquisaidLinhaProdutoBase._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidLinhaProdutoBase._ListaCamposDisplay")));
            this.hlP_PesquisaidLinhaProdutoBase._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidLinhaProdutoBase._ListaValoresDisplay")));
            this.hlP_PesquisaidLinhaProdutoBase._NomeCampoPK = "ID";
            this.hlP_PesquisaidLinhaProdutoBase._NomeFormCadastroOriginal = "FormFamiliaProduto";
            this.hlP_PesquisaidLinhaProdutoBase._NomeView = "vwFamiliaProduto";
            this.hlP_PesquisaidLinhaProdutoBase._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisaidLinhaProdutoBase._Regex = null;
            this.hlP_PesquisaidLinhaProdutoBase._Table = "Familia_Produto";
            this.hlP_PesquisaidLinhaProdutoBase._TamanhoComponente = 300;
            this.hlP_PesquisaidLinhaProdutoBase._TamanhoMaiorLabel = 300;
            this.hlP_PesquisaidLinhaProdutoBase._Vinculado = false;
            this.hlP_PesquisaidLinhaProdutoBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidLinhaProdutoBase.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidLinhaProdutoBase.Base = null;
            this.hlP_PesquisaidLinhaProdutoBase.Location = new System.Drawing.Point(171, 347);
            this.hlP_PesquisaidLinhaProdutoBase.Margin = new System.Windows.Forms.Padding(171, 3, 15, 3);
            this.hlP_PesquisaidLinhaProdutoBase.Name = "hlP_PesquisaidLinhaProdutoBase";
            this.hlP_PesquisaidLinhaProdutoBase.objConfigComponenteModel = null;
            this.hlP_PesquisaidLinhaProdutoBase.ReadOnly = false;
            this.hlP_PesquisaidLinhaProdutoBase.Size = new System.Drawing.Size(432, 21);
            this.hlP_PesquisaidLinhaProdutoBase.TabIndex = 13;
            this.hlP_PesquisaidLinhaProdutoBase.Value = 0;
            // 
            // nudpComissaoAvista
            // 
            this.nudpComissaoAvista._Field = "pComissaoAvista";
            this.nudpComissaoAvista._Help = "Informar a alíquota em percentual da comissão somente para valores a vista, quand" +
    "o a condução de vendas for por dinheiro.";
            this.nudpComissaoAvista._LabelGroup = this.sp_representante;
            this.nudpComissaoAvista._LabelText = "Percentual comissão avista";
            this.nudpComissaoAvista._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudpComissaoAvista._Regex = null;
            this.nudpComissaoAvista._Table = "Familia_Produto";
            this.nudpComissaoAvista._TamanhoComponente = 121;
            this.nudpComissaoAvista._TamanhoMaiorLabel = 300;
            this.nudpComissaoAvista.BackColor = System.Drawing.Color.Transparent;
            this.nudpComissaoAvista.Base = null;
            this.nudpComissaoAvista.Color = System.Drawing.Color.White;
            this.nudpComissaoAvista.DecimalPlaces = 2;
            this.nudpComissaoAvista.Location = new System.Drawing.Point(160, 374);
            this.nudpComissaoAvista.Margin = new System.Windows.Forms.Padding(160, 3, 15, 3);
            this.nudpComissaoAvista.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudpComissaoAvista.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudpComissaoAvista.Name = "nudpComissaoAvista";
            this.nudpComissaoAvista.objConfigComponenteModel = null;
            this.nudpComissaoAvista.ReadOnly = false;
            this.nudpComissaoAvista.Size = new System.Drawing.Size(264, 22);
            this.nudpComissaoAvista.TabIndex = 11;
            this.nudpComissaoAvista.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudpComissaoAvista.ValueInt = 0;
            // 
            // nudpComissaoAprazo
            // 
            this.nudpComissaoAprazo._Field = "pComissaoAprazo";
            this.nudpComissaoAprazo._Help = "Informar a alíquota em percentual da comissão somente para valores a prazo, quand" +
    "o a condução de vendas for cartão de débito e crédito, cheques e valores líquido" +
    "s ou duplicatas geradas.";
            this.nudpComissaoAprazo._LabelGroup = this.sp_representante;
            this.nudpComissaoAprazo._LabelText = "Percentual comissão aprazo";
            this.nudpComissaoAprazo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudpComissaoAprazo._Regex = null;
            this.nudpComissaoAprazo._Table = "Familia_Produto";
            this.nudpComissaoAprazo._TamanhoComponente = 121;
            this.nudpComissaoAprazo._TamanhoMaiorLabel = 300;
            this.nudpComissaoAprazo.BackColor = System.Drawing.Color.Transparent;
            this.nudpComissaoAprazo.Base = null;
            this.nudpComissaoAprazo.Color = System.Drawing.Color.White;
            this.nudpComissaoAprazo.DecimalPlaces = 2;
            this.nudpComissaoAprazo.Location = new System.Drawing.Point(862, 3);
            this.nudpComissaoAprazo.Margin = new System.Windows.Forms.Padding(154, 3, 15, 3);
            this.nudpComissaoAprazo.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudpComissaoAprazo.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudpComissaoAprazo.Name = "nudpComissaoAprazo";
            this.nudpComissaoAprazo.objConfigComponenteModel = null;
            this.nudpComissaoAprazo.ReadOnly = false;
            this.nudpComissaoAprazo.Size = new System.Drawing.Size(270, 22);
            this.nudpComissaoAprazo.TabIndex = 12;
            this.nudpComissaoAprazo.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudpComissaoAprazo.ValueInt = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.kryptonPanel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1144, 225);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Tag = false;
            this.tabPage3.Text = "Classificação financeira  das Familias de produtos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.BorderWidth = 0;
            this.kryptonPanel2.Controls.Add(this.dgvClassificacaoFinanc);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.kryptonPanel2.GradientToogleColors = false;
            this.kryptonPanel2.GradientUseBlend = false;
            this.kryptonPanel2.GradientUseSolid = true;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.PersistentColors = false;
            this.kryptonPanel2.Size = new System.Drawing.Size(1144, 225);
            this.kryptonPanel2.TabIndex = 1;
            // 
            // dgvClassificacaoFinanc
            // 
            this.dgvClassificacaoFinanc.Altera = false;
            this.dgvClassificacaoFinanc.AutoGenerateColumns = false;
            this.dgvClassificacaoFinanc.cm = null;
            this.dgvClassificacaoFinanc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassificacaoFinanc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTipoOperacao,
            this.idClasseFinanceira});
            this.dgvClassificacaoFinanc.DataSource = this.bsFamiliaProduto;
            this.dgvClassificacaoFinanc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClassificacaoFinanc.DragDropLinha = false;
            this.dgvClassificacaoFinanc.Exclui = false;
            this.dgvClassificacaoFinanc.Inclui = false;
            this.dgvClassificacaoFinanc.Location = new System.Drawing.Point(0, 0);
            this.dgvClassificacaoFinanc.Name = "dgvClassificacaoFinanc";
            this.dgvClassificacaoFinanc.Size = new System.Drawing.Size(1144, 225);
            this.dgvClassificacaoFinanc.TabIndex = 0;
            this.dgvClassificacaoFinanc.Tag = "Familia_Produto_Classes";
            // 
            // idTipoOperacao
            // 
            this.idTipoOperacao.DataPropertyName = "idTipoOperacao";
            this.idTipoOperacao.HeaderText = "Tipo de Operacao";
            this.idTipoOperacao.Name = "idTipoOperacao";
            this.idTipoOperacao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idTipoOperacao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idTipoOperacao.Width = 250;
            // 
            // idClasseFinanceira
            // 
            this.idClasseFinanceira.DataPropertyName = "idClasseFinanceira";
            this.idClasseFinanceira.HeaderText = "Classe Financeira";
            this.idClasseFinanceira.Name = "idClasseFinanceira";
            this.idClasseFinanceira.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idClasseFinanceira.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idClasseFinanceira.Width = 250;
            // 
            // bsFamiliaProduto
            // 
            this.bsFamiliaProduto.DataSource = typeof(HLP.Models.Entries.Gerais.Familia_Produto_ClassesModel);
            // 
            // FormFamiliaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 524);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFamiliaProduto";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = -10;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text = "Familia de Produtos";
            this.Load += new System.EventHandler(this.FormFamiliaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).EndInit();
            this.panelPadrao.ResumeLayout(false);
            this.kryptonTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.kryptonPanel1.ResumeLayout(false);
            this.Principal.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassificacaoFinanc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFamiliaProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.FlowLayoutPanel Principal;
        private Comum.Components.HLP_TextBox txtCodigo;
        private Comum.Components.HLP_TextBox txtxFamiliaProduto;
        private Comum.Components.HLP_TextBox txtxDescricao;
        private Comum.Components.HLP_TextBox txtxSigla;
        private Comum.Components.HLP_NumericUpDown nudpDescontoMaximo;
        private Comum.Components.HLP_NumericUpDown nudpAcrescimoMaximo;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidContaContabil;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidCentroCusto;
        private Comum.Components.HLP_NumericUpDown nudpComissaoAvista;
        private Comum.Components.HLP_NumericUpDown nudpComissaoAprazo;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidLinhaProdutoBase;
        private System.Windows.Forms.BindingSource bsFamiliaProduto;
        private Comum.Components.HLP_LabelSeparator sp_Identificação;
        private Comum.Components.HLP_LabelSeparator sp_config;
        private Comum.Components.HLP_LabelSeparator sp_representante;
        private System.Windows.Forms.TabPage tabPage3;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel2;
        private HLP_DataGridView dgvClassificacaoFinanc;
        private System.Windows.Forms.DataGridViewComboBoxColumn idTipoOperacao;
        private System.Windows.Forms.DataGridViewComboBoxColumn idClasseFinanceira;
        private HLP_ComboBox cbxstGrau;
        private HLP_ComboBox cbostAlteraDescricaoComercialProdutoVenda;
    }
}