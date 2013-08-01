using HLP.Comum.Components;
namespace HLP.UI.Entries.Comercial
{
    partial class FormProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduto));
            this.tabControlPrincipal = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kryptonPanel1 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.sep_Identificacao = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtCodigo = new HLP.Comum.Components.HLP_TextBox();
            this.txtxcAlternativo = new HLP.Comum.Components.HLP_TextBox();
            this.txtcEan = new HLP.Comum.Components.HLP_TextBox();
            this.sep_Item = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtxPesquisa = new HLP.Comum.Components.HLP_TextBox();
            this.txtxComercial = new HLP.Comum.Components.HLP_TextBox();
            this.txtxFiscal = new HLP.Comum.Components.HLP_TextBox();
            this.txtxIngles = new HLP.Comum.Components.HLP_TextBox();
            this.txtxFoto = new HLP.Comum.Components.HLP_TextBox();
            this.txtdCadastro = new HLP.Comum.Components.HLP_TextBox();
            this.hlP_PesquisaidTipoProduto = new HLP.Comum.Components.HLP_Pesquisa();
            this.hlP_Observacao1 = new HLP.Comum.Components.HLP_Observacao();
            this.hlP_PesquisaidTipoServico = new HLP.Comum.Components.HLP_Pesquisa();
            this.cbxidUsuario = new HLP.Comum.Components.HLP_ComboBox();
            this.sep_Grupos = new HLP.Comum.Components.HLP_LabelSeparator();
            this.hlP_PesquisaidFamiliaProduto = new HLP.Comum.Components.HLP_Pesquisa();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.sep_Config = new HLP.Comum.Components.HLP_LabelSeparator();
            this.nudnPesoBruto = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudnPesoLiquido = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudnPrazoValidade = new HLP.Comum.Components.HLP_NumericUpDown();
            this.txtdBloqueio = new HLP.Comum.Components.HLP_TextBox();
            this.nudnEstoqueMinimo = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudnEstoqueMaximo = new HLP.Comum.Components.HLP_NumericUpDown();
            this.hlP_PesquisaidUnidadeMedidaEstoque = new HLP.Comum.Components.HLP_Pesquisa();
            this.cbxAtivo = new HLP.Comum.Components.HLP_ComboBox();
            this.sep_Localizacao = new HLP.Comum.Components.HLP_LabelSeparator();
            this.hlP_PesquisaidProdutoLocalizacao = new HLP.Comum.Components.HLP_Pesquisa();
            this.hlP_PesquisaidDeposito = new HLP.Comum.Components.HLP_Pesquisa();
            this.hlP_PesquisaidFabricante = new HLP.Comum.Components.HLP_Pesquisa();
            this.sep_dimensao = new HLP.Comum.Components.HLP_LabelSeparator();
            this.nudnProfundidadeBruta = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudnLarguraBruta = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudnAlturaBruta = new HLP.Comum.Components.HLP_NumericUpDown();
            this.sep_FormacaoCusto = new HLP.Comum.Components.HLP_LabelSeparator();
            this.cbxstCusto = new HLP.Comum.Components.HLP_ComboBox();
            this.cbxstCustoMedio = new HLP.Comum.Components.HLP_ComboBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.sep_GeralDadosFiscais = new HLP.Comum.Components.HLP_LabelSeparator();
            this.nudpInss = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudpImportacao = new HLP.Comum.Components.HLP_NumericUpDown();
            this.cbxstOrigemMercadoria = new HLP.Comum.Components.HLP_ComboBox();
            this.hlP_PesquisaidCSTIcms = new HLP.Comum.Components.HLP_Pesquisa();
            this.cbxstInss = new HLP.Comum.Components.HLP_ComboBox();
            this.sep_OrdemVenda = new HLP.Comum.Components.HLP_LabelSeparator();
            this.hlP_PesquisaidCodigoIcmsPaiVenda = new HLP.Comum.Components.HLP_Pesquisa();
            this.hlP_PesquisaidCSTIpiVenda = new HLP.Comum.Components.HLP_Pesquisa();
            this.hlP_PesquisaidCSTPisVenda = new HLP.Comum.Components.HLP_Pesquisa();
            this.hlP_PesquisaidCSTCofinsVenda = new HLP.Comum.Components.HLP_Pesquisa();
            this.hlP_PesquisaidClassificacaoFiscalVenda = new HLP.Comum.Components.HLP_Pesquisa();
            this.sep_OrdemCompra = new HLP.Comum.Components.HLP_LabelSeparator();
            this.hlP_PesquisaidCodigoIcmsPaiCompra = new HLP.Comum.Components.HLP_Pesquisa();
            this.hlP_PesquisaidCSTIpiCompra = new HLP.Comum.Components.HLP_Pesquisa();
            this.hlP_PesquisaidCSTPisCompra = new HLP.Comum.Components.HLP_Pesquisa();
            this.hlP_PesquisaidCSTCofinsCompra = new HLP.Comum.Components.HLP_Pesquisa();
            this.hlP_PesquisaidClassificacaoFiscalCompra = new HLP.Comum.Components.HLP_Pesquisa();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.kryptonPanel4 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.sep_ConfigOrdemVenda = new HLP.Comum.Components.HLP_LabelSeparator();
            this.nudvVenda = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudpEntregaExcedenteVenda = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudpEntregaInsuficienteVenda = new HLP.Comum.Components.HLP_NumericUpDown();
            this.txtdValorVenda = new HLP.Comum.Components.HLP_TextBox();
            this.hlP_PesquisaidUnidadeMedidaVendas = new HLP.Comum.Components.HLP_Pesquisa();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.kryptonPanel5 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.sep_ConfigOrdemCompra = new HLP.Comum.Components.HLP_LabelSeparator();
            this.nudvCompra = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudnLoteMinimoCompras = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudpEntregaExcedenteCompra = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudpEntregaInsuficienteCompra = new HLP.Comum.Components.HLP_NumericUpDown();
            this.hlP_PesquisaidUnidadeMedidaCompras = new HLP.Comum.Components.HLP_Pesquisa();
            this.cbxstFornecedorHomologado = new HLP.Comum.Components.HLP_ComboBox();
            this.sep_LeadTime = new HLP.Comum.Components.HLP_LabelSeparator();
            this.dtdleadTimeCotacao = new HLP.Comum.Components.HLP_DateTimePicker();
            this.dtdleadTimePedido = new HLP.Comum.Components.HLP_DateTimePicker();
            this.dtdleadTimeRecebimento = new HLP.Comum.Components.HLP_DateTimePicker();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.kryptonPanel6 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.Sep_ConfigProdutucao = new HLP.Comum.Components.HLP_LabelSeparator();
            this.nudvProducao = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudpPerdaConstante = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudpPerdaVariavel = new HLP.Comum.Components.HLP_NumericUpDown();
            this.hlP_PesquisaidUnidadeMedidaProducao = new HLP.Comum.Components.HLP_Pesquisa();
            this.tabPageFornecedores = new System.Windows.Forms.TabPage();
            this.kryptonPanel7 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.dgvProduto_Fornecedor_Homologado = new HLP.Comum.Components.HLP_DataGridView();
            this.idClienteFornecedor = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.nLeadTimeEntregaDataGridViewTextBoxColumn = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.nLoteMinimoCompraDataGridViewTextBoxColumn = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.bsProduto_Fornecedor_Homologado = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.kryptonPanel8 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.dgvProduto_Revisao = new HLP.Comum.Components.HLP_DataGridView();
            this.bsProduto_Revisao = new System.Windows.Forms.BindingSource(this.components);
            this.dInicialDataGridViewTextBoxColumn = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            this.idUsuario = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.xRevisaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dFinalDataGridViewTextBoxColumn = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).BeginInit();
            this.panelPadrao.SuspendLayout();
            this.tabControlPrincipal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.kryptonPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).BeginInit();
            this.kryptonPanel5.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel6)).BeginInit();
            this.kryptonPanel6.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.tabPageFornecedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel7)).BeginInit();
            this.kryptonPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto_Fornecedor_Homologado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProduto_Fornecedor_Homologado)).BeginInit();
            this.tabPage10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel8)).BeginInit();
            this.kryptonPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto_Revisao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProduto_Revisao)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1075, 714);
            // 
            // panelPadrao
            // 
            this.panelPadrao.Controls.Add(this.tabControlPrincipal);
            this.panelPadrao.Size = new System.Drawing.Size(1073, 690);
            // 
            // tabControlPrincipal
            // 
            this.tabControlPrincipal.AllowCloseButton = false;
            this.tabControlPrincipal.AllowContextButton = true;
            this.tabControlPrincipal.AllowNavigatorButtons = false;
            this.tabControlPrincipal.AllowSelectedTabHigh = false;
            this.tabControlPrincipal.BorderWidth = 1;
            this.tabControlPrincipal.Controls.Add(this.tabPage1);
            this.tabControlPrincipal.Controls.Add(this.tabPage4);
            this.tabControlPrincipal.Controls.Add(this.tabPage5);
            this.tabControlPrincipal.Controls.Add(this.tabPage6);
            this.tabControlPrincipal.Controls.Add(this.tabPage7);
            this.tabControlPrincipal.Controls.Add(this.tabPage8);
            this.tabControlPrincipal.Controls.Add(this.tabPageFornecedores);
            this.tabControlPrincipal.Controls.Add(this.tabPage10);
            this.tabControlPrincipal.CornerRoundRadiusWidth = 12;
            this.tabControlPrincipal.CornerSymmetry = AC.ExtendedRenderer.Navigator.KryptonTabControl.CornSymmetry.Both;
            this.tabControlPrincipal.CornerType = AC.ExtendedRenderer.Toolkit.Drawing.DrawingMethods.CornerType.Rounded;
            this.tabControlPrincipal.CornerWidth = AC.ExtendedRenderer.Navigator.KryptonTabControl.CornWidth.Thin;
            this.tabControlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPrincipal.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControlPrincipal.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tabControlPrincipal.HotTrack = true;
            this.tabControlPrincipal.Location = new System.Drawing.Point(3, 3);
            this.tabControlPrincipal.Name = "tabControlPrincipal";
            this.tabControlPrincipal.PreserveTabColor = false;
            this.tabControlPrincipal.SelectedIndex = 0;
            this.tabControlPrincipal.Size = new System.Drawing.Size(1067, 684);
            this.tabControlPrincipal.TabIndex = 1;
            this.tabControlPrincipal.UseExtendedLayout = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Controls.Add(this.kryptonPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1059, 655);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = false;
            this.tabPage1.Text = "Principal";
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
            this.kryptonPanel1.Size = new System.Drawing.Size(1059, 655);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.sep_Identificacao);
            this.flowLayoutPanel1.Controls.Add(this.txtCodigo);
            this.flowLayoutPanel1.Controls.Add(this.txtxcAlternativo);
            this.flowLayoutPanel1.Controls.Add(this.txtcEan);
            this.flowLayoutPanel1.Controls.Add(this.sep_Item);
            this.flowLayoutPanel1.Controls.Add(this.txtxPesquisa);
            this.flowLayoutPanel1.Controls.Add(this.txtxComercial);
            this.flowLayoutPanel1.Controls.Add(this.txtxFiscal);
            this.flowLayoutPanel1.Controls.Add(this.txtxIngles);
            this.flowLayoutPanel1.Controls.Add(this.txtxFoto);
            this.flowLayoutPanel1.Controls.Add(this.txtdCadastro);
            this.flowLayoutPanel1.Controls.Add(this.hlP_PesquisaidTipoProduto);
            this.flowLayoutPanel1.Controls.Add(this.hlP_Observacao1);
            this.flowLayoutPanel1.Controls.Add(this.hlP_PesquisaidTipoServico);
            this.flowLayoutPanel1.Controls.Add(this.cbxidUsuario);
            this.flowLayoutPanel1.Controls.Add(this.sep_Grupos);
            this.flowLayoutPanel1.Controls.Add(this.hlP_PesquisaidFamiliaProduto);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1059, 655);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Tag = "Principal";
            // 
            // sep_Identificacao
            // 
            this.sep_Identificacao._LabelText = "Identificação";
            this.sep_Identificacao._TamanhoMaiorLabel = 0;
            this.sep_Identificacao.BackColor = System.Drawing.Color.Transparent;
            this.sep_Identificacao.Location = new System.Drawing.Point(0, 3);
            this.sep_Identificacao.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.sep_Identificacao.Name = "sep_Identificacao";
            this.sep_Identificacao.Size = new System.Drawing.Size(300, 18);
            this.sep_Identificacao.TabIndex = 27;
            this.sep_Identificacao.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo._Field = "idProduto";
            this.txtCodigo._Help = "Chave principal do registro";
            this.txtCodigo._LabelGroup = this.sep_Identificacao;
            this.txtCodigo._LabelText = "Código";
            this.txtCodigo._Multiline = false;
            this.txtCodigo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtCodigo._Password = false;
            this.txtCodigo._Regex = null;
            this.txtCodigo._Table = "Produto";
            this.txtCodigo._TamanhoComponente = 107;
            this.txtCodigo._TamanhoMaiorLabel = 150;
            this.txtCodigo._Visible = true;
            this.txtCodigo.BackColor = System.Drawing.Color.Transparent;
            this.txtCodigo.Base = null;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCodigo.Color = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(108, 27);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(108, 3, 15, 3);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.objConfigComponenteModel = null;
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(152, 19);
            this.txtCodigo.TabIndex = 3;
            // 
            // txtxcAlternativo
            // 
            this.txtxcAlternativo._Field = "cAlternativo";
            this.txtxcAlternativo._Help = "É o código alternativo do produto/material. ";
            this.txtxcAlternativo._LabelGroup = this.sep_Identificacao;
            this.txtxcAlternativo._LabelText = "Código alternativo";
            this.txtxcAlternativo._Multiline = false;
            this.txtxcAlternativo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxcAlternativo._Password = false;
            this.txtxcAlternativo._Regex = null;
            this.txtxcAlternativo._Table = "Produto";
            this.txtxcAlternativo._TamanhoComponente = 159;
            this.txtxcAlternativo._TamanhoMaiorLabel = 150;
            this.txtxcAlternativo._Visible = true;
            this.txtxcAlternativo.BackColor = System.Drawing.Color.Transparent;
            this.txtxcAlternativo.Base = null;
            this.txtxcAlternativo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxcAlternativo.Color = System.Drawing.Color.White;
            this.txtxcAlternativo.Location = new System.Drawing.Point(50, 52);
            this.txtxcAlternativo.Margin = new System.Windows.Forms.Padding(50, 3, 15, 3);
            this.txtxcAlternativo.MaxLength = 32767;
            this.txtxcAlternativo.Name = "txtxcAlternativo";
            this.txtxcAlternativo.objConfigComponenteModel = null;
            this.txtxcAlternativo.ReadOnly = false;
            this.txtxcAlternativo.Size = new System.Drawing.Size(262, 19);
            this.txtxcAlternativo.TabIndex = 4;
            // 
            // txtcEan
            // 
            this.txtcEan._Field = "cEan";
            this.txtcEan._Help = "Código ean do produto";
            this.txtcEan._LabelGroup = this.sep_Identificacao;
            this.txtcEan._LabelText = "Código ean";
            this.txtcEan._Multiline = false;
            this.txtcEan._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtcEan._Password = false;
            this.txtcEan._Regex = null;
            this.txtcEan._Table = "Produto";
            this.txtcEan._TamanhoComponente = 159;
            this.txtcEan._TamanhoMaiorLabel = 150;
            this.txtcEan._Visible = true;
            this.txtcEan.BackColor = System.Drawing.Color.Transparent;
            this.txtcEan.Base = null;
            this.txtcEan.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtcEan.Color = System.Drawing.Color.White;
            this.txtcEan.Location = new System.Drawing.Point(86, 77);
            this.txtcEan.Margin = new System.Windows.Forms.Padding(86, 3, 15, 3);
            this.txtcEan.MaxLength = 32767;
            this.txtcEan.Name = "txtcEan";
            this.txtcEan.objConfigComponenteModel = null;
            this.txtcEan.ReadOnly = false;
            this.txtcEan.Size = new System.Drawing.Size(226, 20);
            this.txtcEan.TabIndex = 5;
            // 
            // sep_Item
            // 
            this.sep_Item._LabelText = "Item";
            this.sep_Item._TamanhoMaiorLabel = 0;
            this.sep_Item.BackColor = System.Drawing.Color.Transparent;
            this.sep_Item.Location = new System.Drawing.Point(0, 27);
            this.sep_Item.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.sep_Item.Name = "sep_Item";
            this.sep_Item.Size = new System.Drawing.Size(494, 18);
            this.sep_Item.TabIndex = 28;
            this.sep_Item.TabStop = false;
            // 
            // txtxPesquisa
            // 
            this.txtxPesquisa._Field = "xPesquisa";
            this.txtxPesquisa._Help = "Descrição de pesquisa do produto";
            this.txtxPesquisa._LabelGroup = this.sep_Item;
            this.txtxPesquisa._LabelText = "Nome de pesquisa";
            this.txtxPesquisa._Multiline = false;
            this.txtxPesquisa._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxPesquisa._Password = false;
            this.txtxPesquisa._Regex = null;
            this.txtxPesquisa._Table = "Produto";
            this.txtxPesquisa._TamanhoComponente = 341;
            this.txtxPesquisa._TamanhoMaiorLabel = 150;
            this.txtxPesquisa._Visible = true;
            this.txtxPesquisa.BackColor = System.Drawing.Color.Transparent;
            this.txtxPesquisa.Base = null;
            this.txtxPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxPesquisa.Color = System.Drawing.Color.White;
            this.txtxPesquisa.Location = new System.Drawing.Point(51, 127);
            this.txtxPesquisa.Margin = new System.Windows.Forms.Padding(51, 3, 15, 3);
            this.txtxPesquisa.MaxLength = 32767;
            this.txtxPesquisa.Name = "txtxPesquisa";
            this.txtxPesquisa.objConfigComponenteModel = null;
            this.txtxPesquisa.ReadOnly = false;
            this.txtxPesquisa.Size = new System.Drawing.Size(443, 19);
            this.txtxPesquisa.TabIndex = 6;
            // 
            // txtxComercial
            // 
            this.txtxComercial._Field = "xComercial";
            this.txtxComercial._Help = "Descrição comercial do produto";
            this.txtxComercial._LabelGroup = this.sep_Item;
            this.txtxComercial._LabelText = "Nome comercial";
            this.txtxComercial._Multiline = false;
            this.txtxComercial._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxComercial._Password = false;
            this.txtxComercial._Regex = null;
            this.txtxComercial._Table = "Produto";
            this.txtxComercial._TamanhoComponente = 341;
            this.txtxComercial._TamanhoMaiorLabel = 150;
            this.txtxComercial._Visible = true;
            this.txtxComercial.BackColor = System.Drawing.Color.Transparent;
            this.txtxComercial.Base = null;
            this.txtxComercial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxComercial.Color = System.Drawing.Color.White;
            this.txtxComercial.Location = new System.Drawing.Point(65, 152);
            this.txtxComercial.Margin = new System.Windows.Forms.Padding(65, 3, 15, 3);
            this.txtxComercial.MaxLength = 32767;
            this.txtxComercial.Name = "txtxComercial";
            this.txtxComercial.objConfigComponenteModel = null;
            this.txtxComercial.ReadOnly = false;
            this.txtxComercial.Size = new System.Drawing.Size(429, 19);
            this.txtxComercial.TabIndex = 7;
            // 
            // txtxFiscal
            // 
            this.txtxFiscal._Field = "xFiscal";
            this.txtxFiscal._Help = "Descrição fiscal do produto";
            this.txtxFiscal._LabelGroup = this.sep_Item;
            this.txtxFiscal._LabelText = "Nome fiscal";
            this.txtxFiscal._Multiline = false;
            this.txtxFiscal._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxFiscal._Password = false;
            this.txtxFiscal._Regex = null;
            this.txtxFiscal._Table = "Produto";
            this.txtxFiscal._TamanhoComponente = 341;
            this.txtxFiscal._TamanhoMaiorLabel = 150;
            this.txtxFiscal._Visible = true;
            this.txtxFiscal.BackColor = System.Drawing.Color.Transparent;
            this.txtxFiscal.Base = null;
            this.txtxFiscal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxFiscal.Color = System.Drawing.Color.White;
            this.txtxFiscal.Location = new System.Drawing.Point(87, 177);
            this.txtxFiscal.Margin = new System.Windows.Forms.Padding(87, 3, 15, 3);
            this.txtxFiscal.MaxLength = 32767;
            this.txtxFiscal.Name = "txtxFiscal";
            this.txtxFiscal.objConfigComponenteModel = null;
            this.txtxFiscal.ReadOnly = false;
            this.txtxFiscal.Size = new System.Drawing.Size(407, 19);
            this.txtxFiscal.TabIndex = 8;
            // 
            // txtxIngles
            // 
            this.txtxIngles._Field = "xIngles";
            this.txtxIngles._Help = "Descrição em inglês do produto";
            this.txtxIngles._LabelGroup = this.sep_Item;
            this.txtxIngles._LabelText = "Nome inglês";
            this.txtxIngles._Multiline = false;
            this.txtxIngles._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxIngles._Password = false;
            this.txtxIngles._Regex = null;
            this.txtxIngles._Table = "Produto";
            this.txtxIngles._TamanhoComponente = 341;
            this.txtxIngles._TamanhoMaiorLabel = 150;
            this.txtxIngles._Visible = true;
            this.txtxIngles.BackColor = System.Drawing.Color.Transparent;
            this.txtxIngles.Base = null;
            this.txtxIngles.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxIngles.Color = System.Drawing.Color.White;
            this.txtxIngles.Location = new System.Drawing.Point(82, 202);
            this.txtxIngles.Margin = new System.Windows.Forms.Padding(82, 3, 15, 3);
            this.txtxIngles.MaxLength = 32767;
            this.txtxIngles.Name = "txtxIngles";
            this.txtxIngles.objConfigComponenteModel = null;
            this.txtxIngles.ReadOnly = false;
            this.txtxIngles.Size = new System.Drawing.Size(412, 19);
            this.txtxIngles.TabIndex = 9;
            // 
            // txtxFoto
            // 
            this.txtxFoto._Field = "xFoto";
            this.txtxFoto._Help = "Informe o caminho da foto do produto";
            this.txtxFoto._LabelGroup = this.sep_Item;
            this.txtxFoto._LabelText = "Caminho da foto";
            this.txtxFoto._Multiline = false;
            this.txtxFoto._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxFoto._Password = false;
            this.txtxFoto._Regex = null;
            this.txtxFoto._Table = "Produto";
            this.txtxFoto._TamanhoComponente = 341;
            this.txtxFoto._TamanhoMaiorLabel = 150;
            this.txtxFoto._Visible = true;
            this.txtxFoto.BackColor = System.Drawing.Color.Transparent;
            this.txtxFoto.Base = null;
            this.txtxFoto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxFoto.Color = System.Drawing.Color.White;
            this.txtxFoto.Location = new System.Drawing.Point(59, 227);
            this.txtxFoto.Margin = new System.Windows.Forms.Padding(59, 3, 15, 3);
            this.txtxFoto.MaxLength = 32767;
            this.txtxFoto.Name = "txtxFoto";
            this.txtxFoto.objConfigComponenteModel = null;
            this.txtxFoto.ReadOnly = false;
            this.txtxFoto.Size = new System.Drawing.Size(435, 21);
            this.txtxFoto.TabIndex = 10;
            // 
            // txtdCadastro
            // 
            this.txtdCadastro._Field = "dCadastro";
            this.txtdCadastro._Help = "Sistema informará automaticamente quando cadastrado o item, campo desbloqueado pa" +
    "ra o usuário.";
            this.txtdCadastro._LabelGroup = this.sep_Item;
            this.txtdCadastro._LabelText = "Data do cadastro";
            this.txtdCadastro._Multiline = false;
            this.txtdCadastro._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtdCadastro._Password = false;
            this.txtdCadastro._Regex = null;
            this.txtdCadastro._Table = "Produto";
            this.txtdCadastro._TamanhoComponente = 102;
            this.txtdCadastro._TamanhoMaiorLabel = 150;
            this.txtdCadastro._Visible = true;
            this.txtdCadastro.BackColor = System.Drawing.Color.Transparent;
            this.txtdCadastro.Base = null;
            this.txtdCadastro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtdCadastro.Color = System.Drawing.Color.White;
            this.txtdCadastro.Location = new System.Drawing.Point(58, 254);
            this.txtdCadastro.Margin = new System.Windows.Forms.Padding(58, 3, 15, 3);
            this.txtdCadastro.MaxLength = 32767;
            this.txtdCadastro.Name = "txtdCadastro";
            this.txtdCadastro.objConfigComponenteModel = null;
            this.txtdCadastro.ReadOnly = true;
            this.txtdCadastro.Size = new System.Drawing.Size(197, 21);
            this.txtdCadastro.TabIndex = 25;
            this.txtdCadastro.TabStop = false;
            // 
            // hlP_PesquisaidTipoProduto
            // 
            this.hlP_PesquisaidTipoProduto._Field = "idTipoProduto";
            this.hlP_PesquisaidTipoProduto._Help = "Selecione qual é o tipo do produto para a movimentação do mesmo.";
            this.hlP_PesquisaidTipoProduto._LabelGroup = this.sep_Item;
            this.hlP_PesquisaidTipoProduto._LabelText = "Tipo do produto";
            this.hlP_PesquisaidTipoProduto._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidTipoProduto._ListaCamposDisplay")));
            this.hlP_PesquisaidTipoProduto._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidTipoProduto._ListaValoresDisplay")));
            this.hlP_PesquisaidTipoProduto._NomeCampoPK = "ID";
            this.hlP_PesquisaidTipoProduto._NomeFormCadastroOriginal = "FormTipoProduto";
            this.hlP_PesquisaidTipoProduto._NomeView = "vwTipoProduto";
            this.hlP_PesquisaidTipoProduto._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisaidTipoProduto._Regex = null;
            this.hlP_PesquisaidTipoProduto._Table = "Produto";
            this.hlP_PesquisaidTipoProduto._TamanhoComponente = 300;
            this.hlP_PesquisaidTipoProduto._TamanhoMaiorLabel = 150;
            this.hlP_PesquisaidTipoProduto._Vinculado = false;
            this.hlP_PesquisaidTipoProduto._Visible = true;
            this.hlP_PesquisaidTipoProduto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidTipoProduto.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidTipoProduto.Base = null;
            this.hlP_PesquisaidTipoProduto.Location = new System.Drawing.Point(61, 281);
            this.hlP_PesquisaidTipoProduto.Margin = new System.Windows.Forms.Padding(61, 3, 15, 3);
            this.hlP_PesquisaidTipoProduto.Name = "hlP_PesquisaidTipoProduto";
            this.hlP_PesquisaidTipoProduto.objConfigComponenteModel = null;
            this.hlP_PesquisaidTipoProduto.ReadOnly = false;
            this.hlP_PesquisaidTipoProduto.Size = new System.Drawing.Size(392, 21);
            this.hlP_PesquisaidTipoProduto.TabIndex = 30;
            this.hlP_PesquisaidTipoProduto.Value = 0;
            this.hlP_PesquisaidTipoProduto.Leave += new System.EventHandler(this.hlP_PesquisaidTipoProduto_Leave);
            // 
            // hlP_Observacao1
            // 
            this.hlP_Observacao1._Field = "xObs";
            this.hlP_Observacao1._LabelGroup = this.sep_Item;
            this.hlP_Observacao1._LabelText = "Observação";
            this.hlP_Observacao1._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_Observacao1._Regex = null;
            this.hlP_Observacao1._Table = "Produto";
            this.hlP_Observacao1._TamanhoComponente = 88;
            this.hlP_Observacao1._TamanhoMaiorLabel = 0;
            this.hlP_Observacao1._Visible = true;
            this.hlP_Observacao1.BackColor = System.Drawing.Color.Transparent;
            this.hlP_Observacao1.Base = null;
            this.hlP_Observacao1.Location = new System.Drawing.Point(0, 308);
            this.hlP_Observacao1.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.hlP_Observacao1.Name = "hlP_Observacao1";
            this.hlP_Observacao1.objConfigComponenteModel = null;
            this.hlP_Observacao1.ReadOnly = false;
            this.hlP_Observacao1.Size = new System.Drawing.Size(155, 26);
            this.hlP_Observacao1.TabIndex = 16;
            // 
            // hlP_PesquisaidTipoServico
            // 
            this.hlP_PesquisaidTipoServico._Field = "idTipoServico";
            this.hlP_PesquisaidTipoServico._Help = "Campo habilitado somente quando o tipo de documento estiver com a situação de ser" +
    "viço ativada";
            this.hlP_PesquisaidTipoServico._LabelGroup = this.sep_Item;
            this.hlP_PesquisaidTipoServico._LabelText = "Tipo de serviço";
            this.hlP_PesquisaidTipoServico._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidTipoServico._ListaCamposDisplay")));
            this.hlP_PesquisaidTipoServico._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidTipoServico._ListaValoresDisplay")));
            this.hlP_PesquisaidTipoServico._NomeCampoPK = "ID";
            this.hlP_PesquisaidTipoServico._NomeFormCadastroOriginal = "FormTipoServico";
            this.hlP_PesquisaidTipoServico._NomeView = "vwTipoServico";
            this.hlP_PesquisaidTipoServico._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisaidTipoServico._Regex = null;
            this.hlP_PesquisaidTipoServico._Table = "Produto";
            this.hlP_PesquisaidTipoServico._TamanhoComponente = 300;
            this.hlP_PesquisaidTipoServico._TamanhoMaiorLabel = 150;
            this.hlP_PesquisaidTipoServico._Vinculado = false;
            this.hlP_PesquisaidTipoServico._Visible = true;
            this.hlP_PesquisaidTipoServico.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidTipoServico.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidTipoServico.Base = null;
            this.hlP_PesquisaidTipoServico.Location = new System.Drawing.Point(70, 340);
            this.hlP_PesquisaidTipoServico.Margin = new System.Windows.Forms.Padding(70, 3, 15, 3);
            this.hlP_PesquisaidTipoServico.Name = "hlP_PesquisaidTipoServico";
            this.hlP_PesquisaidTipoServico.objConfigComponenteModel = null;
            this.hlP_PesquisaidTipoServico.ReadOnly = false;
            this.hlP_PesquisaidTipoServico.Size = new System.Drawing.Size(383, 21);
            this.hlP_PesquisaidTipoServico.TabIndex = 17;
            this.hlP_PesquisaidTipoServico.Value = 0;
            // 
            // cbxidUsuario
            // 
            this.cbxidUsuario._Field = "idFuncionario";
            this.cbxidUsuario._Help = "Informa o usuário que cadastrou o item";
            this.cbxidUsuario._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbxidUsuario._Itens")));
            this.cbxidUsuario._LabelGroup = this.sep_Item;
            this.cbxidUsuario._LabelText = "Usuário";
            this.cbxidUsuario._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbxidUsuario._Regex = null;
            this.cbxidUsuario._situacao = false;
            this.cbxidUsuario._Table = "Produto";
            this.cbxidUsuario._TamanhoComponente = 320;
            this.cbxidUsuario._TamanhoMaiorLabel = 150;
            this.cbxidUsuario._Visible = true;
            this.cbxidUsuario.BackColor = System.Drawing.Color.Transparent;
            this.cbxidUsuario.Base = null;
            this.cbxidUsuario.Color = System.Drawing.Color.White;
            this.cbxidUsuario.DataSource = null;
            this.cbxidUsuario.DisplayMember = "xNome";
            this.cbxidUsuario.Location = new System.Drawing.Point(106, 367);
            this.cbxidUsuario.Margin = new System.Windows.Forms.Padding(106, 3, 15, 3);
            this.cbxidUsuario.Name = "cbxidUsuario";
            this.cbxidUsuario.objConfigComponenteModel = null;
            this.cbxidUsuario.SelectedIndex = -1;
            this.cbxidUsuario.SelectedValue = 0;
            this.cbxidUsuario.Size = new System.Drawing.Size(367, 21);
            this.cbxidUsuario.TabIndex = 26;
            this.cbxidUsuario.TabStop = false;
            this.cbxidUsuario.ValueMember = "idUsuario";
            // 
            // sep_Grupos
            // 
            this.sep_Grupos._LabelText = "Grupos";
            this.sep_Grupos._TamanhoMaiorLabel = 0;
            this.sep_Grupos.BackColor = System.Drawing.Color.Transparent;
            this.sep_Grupos.Location = new System.Drawing.Point(0, 51);
            this.sep_Grupos.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.sep_Grupos.Name = "sep_Grupos";
            this.sep_Grupos.Size = new System.Drawing.Size(494, 18);
            this.sep_Grupos.TabIndex = 29;
            this.sep_Grupos.TabStop = false;
            // 
            // hlP_PesquisaidFamiliaProduto
            // 
            this.hlP_PesquisaidFamiliaProduto._Field = "idFamiliaProduto";
            this.hlP_PesquisaidFamiliaProduto._Help = "Informar a que família ou grupo o item pertence.";
            this.hlP_PesquisaidFamiliaProduto._LabelGroup = this.sep_Grupos;
            this.hlP_PesquisaidFamiliaProduto._LabelText = "Família do produto";
            this.hlP_PesquisaidFamiliaProduto._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidFamiliaProduto._ListaCamposDisplay")));
            this.hlP_PesquisaidFamiliaProduto._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidFamiliaProduto._ListaValoresDisplay")));
            this.hlP_PesquisaidFamiliaProduto._NomeCampoPK = "ID";
            this.hlP_PesquisaidFamiliaProduto._NomeFormCadastroOriginal = "FormFamiliaProduto";
            this.hlP_PesquisaidFamiliaProduto._NomeView = "vwFamiliaProduto";
            this.hlP_PesquisaidFamiliaProduto._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisaidFamiliaProduto._Regex = null;
            this.hlP_PesquisaidFamiliaProduto._Table = "Produto";
            this.hlP_PesquisaidFamiliaProduto._TamanhoComponente = 300;
            this.hlP_PesquisaidFamiliaProduto._TamanhoMaiorLabel = 150;
            this.hlP_PesquisaidFamiliaProduto._Vinculado = false;
            this.hlP_PesquisaidFamiliaProduto._Visible = true;
            this.hlP_PesquisaidFamiliaProduto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidFamiliaProduto.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidFamiliaProduto.Base = null;
            this.hlP_PesquisaidFamiliaProduto.Location = new System.Drawing.Point(47, 418);
            this.hlP_PesquisaidFamiliaProduto.Margin = new System.Windows.Forms.Padding(47, 3, 15, 3);
            this.hlP_PesquisaidFamiliaProduto.Name = "hlP_PesquisaidFamiliaProduto";
            this.hlP_PesquisaidFamiliaProduto.objConfigComponenteModel = null;
            this.hlP_PesquisaidFamiliaProduto.ReadOnly = false;
            this.hlP_PesquisaidFamiliaProduto.Size = new System.Drawing.Size(406, 21);
            this.hlP_PesquisaidFamiliaProduto.TabIndex = 24;
            this.hlP_PesquisaidFamiliaProduto.Value = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.kryptonPanel2);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1144, 225);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Tag = false;
            this.tabPage4.Text = "Dados de estoque";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.flowLayoutPanel2);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(1144, 225);
            this.kryptonPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.sep_Config);
            this.flowLayoutPanel2.Controls.Add(this.nudnPesoBruto);
            this.flowLayoutPanel2.Controls.Add(this.nudnPesoLiquido);
            this.flowLayoutPanel2.Controls.Add(this.nudnPrazoValidade);
            this.flowLayoutPanel2.Controls.Add(this.txtdBloqueio);
            this.flowLayoutPanel2.Controls.Add(this.nudnEstoqueMinimo);
            this.flowLayoutPanel2.Controls.Add(this.nudnEstoqueMaximo);
            this.flowLayoutPanel2.Controls.Add(this.hlP_PesquisaidUnidadeMedidaEstoque);
            this.flowLayoutPanel2.Controls.Add(this.cbxAtivo);
            this.flowLayoutPanel2.Controls.Add(this.sep_Localizacao);
            this.flowLayoutPanel2.Controls.Add(this.hlP_PesquisaidProdutoLocalizacao);
            this.flowLayoutPanel2.Controls.Add(this.hlP_PesquisaidDeposito);
            this.flowLayoutPanel2.Controls.Add(this.hlP_PesquisaidFabricante);
            this.flowLayoutPanel2.Controls.Add(this.sep_dimensao);
            this.flowLayoutPanel2.Controls.Add(this.nudnProfundidadeBruta);
            this.flowLayoutPanel2.Controls.Add(this.nudnLarguraBruta);
            this.flowLayoutPanel2.Controls.Add(this.nudnAlturaBruta);
            this.flowLayoutPanel2.Controls.Add(this.sep_FormacaoCusto);
            this.flowLayoutPanel2.Controls.Add(this.cbxstCusto);
            this.flowLayoutPanel2.Controls.Add(this.cbxstCustoMedio);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1144, 225);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // sep_Config
            // 
            this.sep_Config._LabelText = "Configuração";
            this.sep_Config._TamanhoMaiorLabel = 0;
            this.sep_Config.BackColor = System.Drawing.Color.Transparent;
            this.sep_Config.Location = new System.Drawing.Point(0, 3);
            this.sep_Config.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.sep_Config.Name = "sep_Config";
            this.sep_Config.Size = new System.Drawing.Size(486, 18);
            this.sep_Config.TabIndex = 60;
            this.sep_Config.TabStop = false;
            // 
            // nudnPesoBruto
            // 
            this.nudnPesoBruto._Field = "nPesoBruto";
            this.nudnPesoBruto._Help = "É o peso bruto do produto. o mesmo será calculado de acordo com as quantidades ve" +
    "ndidas e adicionado nos dados adicionais da nota fiscal.";
            this.nudnPesoBruto._LabelGroup = this.sep_Config;
            this.nudnPesoBruto._LabelText = "Peso bruto";
            this.nudnPesoBruto._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudnPesoBruto._Regex = null;
            this.nudnPesoBruto._Table = "Produto";
            this.nudnPesoBruto._TamanhoComponente = 112;
            this.nudnPesoBruto._TamanhoMaiorLabel = 150;
            this.nudnPesoBruto._Visible = true;
            this.nudnPesoBruto.BackColor = System.Drawing.Color.Transparent;
            this.nudnPesoBruto.Base = null;
            this.nudnPesoBruto.Color = System.Drawing.Color.White;
            this.nudnPesoBruto.DecimalPlaces = 2;
            this.nudnPesoBruto.Location = new System.Drawing.Point(90, 27);
            this.nudnPesoBruto.Margin = new System.Windows.Forms.Padding(90, 3, 15, 3);
            this.nudnPesoBruto.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudnPesoBruto.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudnPesoBruto.Name = "nudnPesoBruto";
            this.nudnPesoBruto.objConfigComponenteModel = null;
            this.nudnPesoBruto.ReadOnly = false;
            this.nudnPesoBruto.Size = new System.Drawing.Size(175, 22);
            this.nudnPesoBruto.TabIndex = 40;
            this.nudnPesoBruto.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudnPesoBruto.ValueInt = 0;
            // 
            // nudnPesoLiquido
            // 
            this.nudnPesoLiquido._Field = "nPesoLiquido";
            this.nudnPesoLiquido._Help = "É o peso líquido do produto. o mesmo será calculado de acordo com as quantidades " +
    "vendidas e adicionado nos dados adicionais da nota fiscal.";
            this.nudnPesoLiquido._LabelGroup = this.sep_Config;
            this.nudnPesoLiquido._LabelText = "Peso líquido";
            this.nudnPesoLiquido._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudnPesoLiquido._Regex = null;
            this.nudnPesoLiquido._Table = "Produto";
            this.nudnPesoLiquido._TamanhoComponente = 112;
            this.nudnPesoLiquido._TamanhoMaiorLabel = 150;
            this.nudnPesoLiquido._Visible = true;
            this.nudnPesoLiquido.BackColor = System.Drawing.Color.Transparent;
            this.nudnPesoLiquido.Base = null;
            this.nudnPesoLiquido.Color = System.Drawing.Color.White;
            this.nudnPesoLiquido.DecimalPlaces = 2;
            this.nudnPesoLiquido.Location = new System.Drawing.Point(82, 55);
            this.nudnPesoLiquido.Margin = new System.Windows.Forms.Padding(82, 3, 15, 3);
            this.nudnPesoLiquido.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudnPesoLiquido.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudnPesoLiquido.Name = "nudnPesoLiquido";
            this.nudnPesoLiquido.objConfigComponenteModel = null;
            this.nudnPesoLiquido.ReadOnly = false;
            this.nudnPesoLiquido.Size = new System.Drawing.Size(183, 22);
            this.nudnPesoLiquido.TabIndex = 41;
            this.nudnPesoLiquido.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudnPesoLiquido.ValueInt = 0;
            // 
            // nudnPrazoValidade
            // 
            this.nudnPrazoValidade._Field = "nPrazoValidade";
            this.nudnPrazoValidade._Help = "Informar o prazo de validade do produto em dias.";
            this.nudnPrazoValidade._LabelGroup = this.sep_Config;
            this.nudnPrazoValidade._LabelText = "Prazo de validade";
            this.nudnPrazoValidade._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudnPrazoValidade._Regex = null;
            this.nudnPrazoValidade._Table = "Produto";
            this.nudnPrazoValidade._TamanhoComponente = 112;
            this.nudnPrazoValidade._TamanhoMaiorLabel = 150;
            this.nudnPrazoValidade._Visible = true;
            this.nudnPrazoValidade.BackColor = System.Drawing.Color.Transparent;
            this.nudnPrazoValidade.Base = null;
            this.nudnPrazoValidade.Color = System.Drawing.Color.White;
            this.nudnPrazoValidade.DecimalPlaces = 2;
            this.nudnPrazoValidade.Location = new System.Drawing.Point(56, 83);
            this.nudnPrazoValidade.Margin = new System.Windows.Forms.Padding(56, 3, 15, 3);
            this.nudnPrazoValidade.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudnPrazoValidade.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudnPrazoValidade.Name = "nudnPrazoValidade";
            this.nudnPrazoValidade.objConfigComponenteModel = null;
            this.nudnPrazoValidade.ReadOnly = false;
            this.nudnPrazoValidade.Size = new System.Drawing.Size(209, 22);
            this.nudnPrazoValidade.TabIndex = 42;
            this.nudnPrazoValidade.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudnPrazoValidade.ValueInt = 0;
            // 
            // txtdBloqueio
            // 
            this.txtdBloqueio._Field = "dBloqueio";
            this.txtdBloqueio._Help = "Informa automaticamente a data de quando o produto foi desativado.";
            this.txtdBloqueio._LabelGroup = this.sep_Config;
            this.txtdBloqueio._LabelText = "Data de bloqueio";
            this.txtdBloqueio._Multiline = false;
            this.txtdBloqueio._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtdBloqueio._Password = false;
            this.txtdBloqueio._Regex = null;
            this.txtdBloqueio._Table = "Produto";
            this.txtdBloqueio._TamanhoComponente = 112;
            this.txtdBloqueio._TamanhoMaiorLabel = 150;
            this.txtdBloqueio._Visible = true;
            this.txtdBloqueio.BackColor = System.Drawing.Color.Transparent;
            this.txtdBloqueio.Base = null;
            this.txtdBloqueio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtdBloqueio.Color = System.Drawing.Color.White;
            this.txtdBloqueio.Enabled = false;
            this.txtdBloqueio.Location = new System.Drawing.Point(56, 111);
            this.txtdBloqueio.Margin = new System.Windows.Forms.Padding(56, 3, 15, 3);
            this.txtdBloqueio.MaxLength = 32767;
            this.txtdBloqueio.Name = "txtdBloqueio";
            this.txtdBloqueio.objConfigComponenteModel = null;
            this.txtdBloqueio.ReadOnly = true;
            this.txtdBloqueio.Size = new System.Drawing.Size(209, 20);
            this.txtdBloqueio.TabIndex = 65;
            this.txtdBloqueio.TabStop = false;
            // 
            // nudnEstoqueMinimo
            // 
            this.nudnEstoqueMinimo._Field = "nEstoqueMinimo";
            this.nudnEstoqueMinimo._Help = "Informar a quantidade mínima que deve permanecer em estoque, para que o sistema f" +
    "aça um controle de estoque crítico através de um relatório padrão.";
            this.nudnEstoqueMinimo._LabelGroup = this.sep_Config;
            this.nudnEstoqueMinimo._LabelText = "Estoque mínimo";
            this.nudnEstoqueMinimo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudnEstoqueMinimo._Regex = null;
            this.nudnEstoqueMinimo._Table = "Produto";
            this.nudnEstoqueMinimo._TamanhoComponente = 112;
            this.nudnEstoqueMinimo._TamanhoMaiorLabel = 150;
            this.nudnEstoqueMinimo._Visible = true;
            this.nudnEstoqueMinimo.BackColor = System.Drawing.Color.Transparent;
            this.nudnEstoqueMinimo.Base = null;
            this.nudnEstoqueMinimo.Color = System.Drawing.Color.White;
            this.nudnEstoqueMinimo.DecimalPlaces = 2;
            this.nudnEstoqueMinimo.Location = new System.Drawing.Point(63, 137);
            this.nudnEstoqueMinimo.Margin = new System.Windows.Forms.Padding(63, 3, 15, 3);
            this.nudnEstoqueMinimo.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudnEstoqueMinimo.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudnEstoqueMinimo.Name = "nudnEstoqueMinimo";
            this.nudnEstoqueMinimo.objConfigComponenteModel = null;
            this.nudnEstoqueMinimo.ReadOnly = false;
            this.nudnEstoqueMinimo.Size = new System.Drawing.Size(202, 22);
            this.nudnEstoqueMinimo.TabIndex = 45;
            this.nudnEstoqueMinimo.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudnEstoqueMinimo.ValueInt = 0;
            // 
            // nudnEstoqueMaximo
            // 
            this.nudnEstoqueMaximo._Field = "nEstoqueMaximo";
            this.nudnEstoqueMaximo._Help = "Informar a quantidade máxima que deve permanecer em estoque, para que o sistema f" +
    "aça um controle de estoque máximo na hora de cotações e compras";
            this.nudnEstoqueMaximo._LabelGroup = this.sep_Config;
            this.nudnEstoqueMaximo._LabelText = "Estoque máximo";
            this.nudnEstoqueMaximo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudnEstoqueMaximo._Regex = null;
            this.nudnEstoqueMaximo._Table = "Produto";
            this.nudnEstoqueMaximo._TamanhoComponente = 111;
            this.nudnEstoqueMaximo._TamanhoMaiorLabel = 150;
            this.nudnEstoqueMaximo._Visible = true;
            this.nudnEstoqueMaximo.BackColor = System.Drawing.Color.Transparent;
            this.nudnEstoqueMaximo.Base = null;
            this.nudnEstoqueMaximo.Color = System.Drawing.Color.White;
            this.nudnEstoqueMaximo.DecimalPlaces = 2;
            this.nudnEstoqueMaximo.Location = new System.Drawing.Point(62, 165);
            this.nudnEstoqueMaximo.Margin = new System.Windows.Forms.Padding(62, 3, 15, 3);
            this.nudnEstoqueMaximo.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudnEstoqueMaximo.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudnEstoqueMaximo.Name = "nudnEstoqueMaximo";
            this.nudnEstoqueMaximo.objConfigComponenteModel = null;
            this.nudnEstoqueMaximo.ReadOnly = false;
            this.nudnEstoqueMaximo.Size = new System.Drawing.Size(202, 22);
            this.nudnEstoqueMaximo.TabIndex = 46;
            this.nudnEstoqueMaximo.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudnEstoqueMaximo.ValueInt = 0;
            // 
            // hlP_PesquisaidUnidadeMedidaEstoque
            // 
            this.hlP_PesquisaidUnidadeMedidaEstoque._Field = "idUnidadeMedidaEstoque";
            this.hlP_PesquisaidUnidadeMedidaEstoque._Help = "Deve ser informado a unidade de medida para as, cotações, ordens de vendas, fatur" +
    "amento";
            this.hlP_PesquisaidUnidadeMedidaEstoque._LabelGroup = this.sep_Config;
            this.hlP_PesquisaidUnidadeMedidaEstoque._LabelText = "Unidade de medida";
            this.hlP_PesquisaidUnidadeMedidaEstoque._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidUnidadeMedidaEstoque._ListaCamposDisplay")));
            this.hlP_PesquisaidUnidadeMedidaEstoque._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidUnidadeMedidaEstoque._ListaValoresDisplay")));
            this.hlP_PesquisaidUnidadeMedidaEstoque._NomeCampoPK = "ID";
            this.hlP_PesquisaidUnidadeMedidaEstoque._NomeFormCadastroOriginal = "FormUnidadeMedida";
            this.hlP_PesquisaidUnidadeMedidaEstoque._NomeView = "vwUnidadeMedida";
            this.hlP_PesquisaidUnidadeMedidaEstoque._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisaidUnidadeMedidaEstoque._Regex = null;
            this.hlP_PesquisaidUnidadeMedidaEstoque._Table = "Produto";
            this.hlP_PesquisaidUnidadeMedidaEstoque._TamanhoComponente = 300;
            this.hlP_PesquisaidUnidadeMedidaEstoque._TamanhoMaiorLabel = 150;
            this.hlP_PesquisaidUnidadeMedidaEstoque._Vinculado = false;
            this.hlP_PesquisaidUnidadeMedidaEstoque._Visible = true;
            this.hlP_PesquisaidUnidadeMedidaEstoque.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidUnidadeMedidaEstoque.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidUnidadeMedidaEstoque.Base = null;
            this.hlP_PesquisaidUnidadeMedidaEstoque.Location = new System.Drawing.Point(45, 193);
            this.hlP_PesquisaidUnidadeMedidaEstoque.Margin = new System.Windows.Forms.Padding(45, 3, 15, 3);
            this.hlP_PesquisaidUnidadeMedidaEstoque.Name = "hlP_PesquisaidUnidadeMedidaEstoque";
            this.hlP_PesquisaidUnidadeMedidaEstoque.objConfigComponenteModel = null;
            this.hlP_PesquisaidUnidadeMedidaEstoque.ReadOnly = false;
            this.hlP_PesquisaidUnidadeMedidaEstoque.Size = new System.Drawing.Size(408, 21);
            this.hlP_PesquisaidUnidadeMedidaEstoque.TabIndex = 59;
            this.hlP_PesquisaidUnidadeMedidaEstoque.Value = 0;
            // 
            // cbxAtivo
            // 
            this.cbxAtivo._Field = "Ativo";
            this.cbxAtivo._Help = "Desmarque a opção se o produto não estiver ativo, desmarcando o produto não será " +
    "mais mostrado em nenhuma tela seja ela de recebimento, estoque, produção ou vend" +
    "as.";
            this.cbxAtivo._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbxAtivo._Itens")));
            this.cbxAtivo._LabelGroup = this.sep_Config;
            this.cbxAtivo._LabelText = "Ativo";
            this.cbxAtivo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbxAtivo._Regex = null;
            this.cbxAtivo._situacao = true;
            this.cbxAtivo._Table = "Produto";
            this.cbxAtivo._TamanhoComponente = 80;
            this.cbxAtivo._TamanhoMaiorLabel = 150;
            this.cbxAtivo._Visible = true;
            this.cbxAtivo.BackColor = System.Drawing.Color.Transparent;
            this.cbxAtivo.Base = null;
            this.cbxAtivo.Color = System.Drawing.Color.White;
            this.cbxAtivo.DataSource = null;
            this.cbxAtivo.DisplayMember = "DisplayMember";
            this.cbxAtivo.Location = new System.Drawing.Point(621, 3);
            this.cbxAtivo.Margin = new System.Windows.Forms.Padding(120, 3, 15, 3);
            this.cbxAtivo.Name = "cbxAtivo";
            this.cbxAtivo.objConfigComponenteModel = null;
            this.cbxAtivo.SelectedIndex = -1;
            this.cbxAtivo.SelectedValue = 0;
            this.cbxAtivo.Size = new System.Drawing.Size(113, 21);
            this.cbxAtivo.TabIndex = 43;
            this.cbxAtivo.ValueMember = "ValueMember";
            // 
            // sep_Localizacao
            // 
            this.sep_Localizacao._LabelText = "Localização";
            this.sep_Localizacao._TamanhoMaiorLabel = 0;
            this.sep_Localizacao.BackColor = System.Drawing.Color.Transparent;
            this.sep_Localizacao.Location = new System.Drawing.Point(0, 27);
            this.sep_Localizacao.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.sep_Localizacao.Name = "sep_Localizacao";
            this.sep_Localizacao.Size = new System.Drawing.Size(486, 18);
            this.sep_Localizacao.TabIndex = 61;
            this.sep_Localizacao.TabStop = false;
            // 
            // hlP_PesquisaidProdutoLocalizacao
            // 
            this.hlP_PesquisaidProdutoLocalizacao._Field = "idProdutoLocalizacao";
            this.hlP_PesquisaidProdutoLocalizacao._Help = "Informar qual a localização do produto dentro do depósito e em seu devido site.";
            this.hlP_PesquisaidProdutoLocalizacao._LabelGroup = this.sep_Localizacao;
            this.hlP_PesquisaidProdutoLocalizacao._LabelText = "Localização";
            this.hlP_PesquisaidProdutoLocalizacao._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidProdutoLocalizacao._ListaCamposDisplay")));
            this.hlP_PesquisaidProdutoLocalizacao._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidProdutoLocalizacao._ListaValoresDisplay")));
            this.hlP_PesquisaidProdutoLocalizacao._NomeCampoPK = "ID";
            this.hlP_PesquisaidProdutoLocalizacao._NomeFormCadastroOriginal = "FormProdutoLocalizacao";
            this.hlP_PesquisaidProdutoLocalizacao._NomeView = "vwProdutoLocalizacao";
            this.hlP_PesquisaidProdutoLocalizacao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisaidProdutoLocalizacao._Regex = null;
            this.hlP_PesquisaidProdutoLocalizacao._Table = "Produto";
            this.hlP_PesquisaidProdutoLocalizacao._TamanhoComponente = 300;
            this.hlP_PesquisaidProdutoLocalizacao._TamanhoMaiorLabel = 150;
            this.hlP_PesquisaidProdutoLocalizacao._Vinculado = false;
            this.hlP_PesquisaidProdutoLocalizacao._Visible = true;
            this.hlP_PesquisaidProdutoLocalizacao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidProdutoLocalizacao.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidProdutoLocalizacao.Base = null;
            this.hlP_PesquisaidProdutoLocalizacao.Location = new System.Drawing.Point(589, 54);
            this.hlP_PesquisaidProdutoLocalizacao.Margin = new System.Windows.Forms.Padding(88, 3, 15, 3);
            this.hlP_PesquisaidProdutoLocalizacao.Name = "hlP_PesquisaidProdutoLocalizacao";
            this.hlP_PesquisaidProdutoLocalizacao.objConfigComponenteModel = null;
            this.hlP_PesquisaidProdutoLocalizacao.ReadOnly = false;
            this.hlP_PesquisaidProdutoLocalizacao.Size = new System.Drawing.Size(365, 21);
            this.hlP_PesquisaidProdutoLocalizacao.TabIndex = 47;
            this.hlP_PesquisaidProdutoLocalizacao.Value = 0;
            // 
            // hlP_PesquisaidDeposito
            // 
            this.hlP_PesquisaidDeposito._Field = "idDeposito";
            this.hlP_PesquisaidDeposito._Help = "Informar o depósito em que o produto está localizado";
            this.hlP_PesquisaidDeposito._LabelGroup = this.sep_Localizacao;
            this.hlP_PesquisaidDeposito._LabelText = "Depósito";
            this.hlP_PesquisaidDeposito._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidDeposito._ListaCamposDisplay")));
            this.hlP_PesquisaidDeposito._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidDeposito._ListaValoresDisplay")));
            this.hlP_PesquisaidDeposito._NomeCampoPK = "ID";
            this.hlP_PesquisaidDeposito._NomeFormCadastroOriginal = "FormDeposito";
            this.hlP_PesquisaidDeposito._NomeView = "vwDeposito";
            this.hlP_PesquisaidDeposito._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisaidDeposito._Regex = null;
            this.hlP_PesquisaidDeposito._Table = "Produto";
            this.hlP_PesquisaidDeposito._TamanhoComponente = 300;
            this.hlP_PesquisaidDeposito._TamanhoMaiorLabel = 150;
            this.hlP_PesquisaidDeposito._Vinculado = false;
            this.hlP_PesquisaidDeposito._Visible = true;
            this.hlP_PesquisaidDeposito.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidDeposito.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidDeposito.Base = null;
            this.hlP_PesquisaidDeposito.Location = new System.Drawing.Point(600, 81);
            this.hlP_PesquisaidDeposito.Margin = new System.Windows.Forms.Padding(99, 3, 15, 3);
            this.hlP_PesquisaidDeposito.Name = "hlP_PesquisaidDeposito";
            this.hlP_PesquisaidDeposito.objConfigComponenteModel = null;
            this.hlP_PesquisaidDeposito.ReadOnly = false;
            this.hlP_PesquisaidDeposito.Size = new System.Drawing.Size(354, 21);
            this.hlP_PesquisaidDeposito.TabIndex = 51;
            this.hlP_PesquisaidDeposito.Value = 0;
            // 
            // hlP_PesquisaidFabricante
            // 
            this.hlP_PesquisaidFabricante._Field = "idFabricante";
            this.hlP_PesquisaidFabricante._Help = "Informe o fabricante do produto.";
            this.hlP_PesquisaidFabricante._LabelGroup = this.sep_Localizacao;
            this.hlP_PesquisaidFabricante._LabelText = "Fabricante";
            this.hlP_PesquisaidFabricante._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidFabricante._ListaCamposDisplay")));
            this.hlP_PesquisaidFabricante._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidFabricante._ListaValoresDisplay")));
            this.hlP_PesquisaidFabricante._NomeCampoPK = "ID";
            this.hlP_PesquisaidFabricante._NomeFormCadastroOriginal = "FormFabricante";
            this.hlP_PesquisaidFabricante._NomeView = "vwFabricante";
            this.hlP_PesquisaidFabricante._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisaidFabricante._Regex = null;
            this.hlP_PesquisaidFabricante._Table = "Produto";
            this.hlP_PesquisaidFabricante._TamanhoComponente = 300;
            this.hlP_PesquisaidFabricante._TamanhoMaiorLabel = 150;
            this.hlP_PesquisaidFabricante._Vinculado = false;
            this.hlP_PesquisaidFabricante._Visible = true;
            this.hlP_PesquisaidFabricante.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidFabricante.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidFabricante.Base = null;
            this.hlP_PesquisaidFabricante.Location = new System.Drawing.Point(593, 108);
            this.hlP_PesquisaidFabricante.Margin = new System.Windows.Forms.Padding(92, 3, 15, 3);
            this.hlP_PesquisaidFabricante.Name = "hlP_PesquisaidFabricante";
            this.hlP_PesquisaidFabricante.objConfigComponenteModel = null;
            this.hlP_PesquisaidFabricante.ReadOnly = false;
            this.hlP_PesquisaidFabricante.Size = new System.Drawing.Size(361, 21);
            this.hlP_PesquisaidFabricante.TabIndex = 52;
            this.hlP_PesquisaidFabricante.Value = 0;
            // 
            // sep_dimensao
            // 
            this.sep_dimensao._LabelText = "Dimensão física";
            this.sep_dimensao._TamanhoMaiorLabel = 0;
            this.sep_dimensao.BackColor = System.Drawing.Color.Transparent;
            this.sep_dimensao.Location = new System.Drawing.Point(0, 51);
            this.sep_dimensao.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.sep_dimensao.Name = "sep_dimensao";
            this.sep_dimensao.Size = new System.Drawing.Size(486, 18);
            this.sep_dimensao.TabIndex = 62;
            this.sep_dimensao.TabStop = false;
            // 
            // nudnProfundidadeBruta
            // 
            this.nudnProfundidadeBruta._Field = "nProfundidadeBruta";
            this.nudnProfundidadeBruta._Help = "Informar profundidade da unidade de estoque que inclui a embalagem.";
            this.nudnProfundidadeBruta._LabelGroup = this.sep_dimensao;
            this.nudnProfundidadeBruta._LabelText = "Profundidade bruta";
            this.nudnProfundidadeBruta._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudnProfundidadeBruta._Regex = null;
            this.nudnProfundidadeBruta._Table = "Produto";
            this.nudnProfundidadeBruta._TamanhoComponente = 188;
            this.nudnProfundidadeBruta._TamanhoMaiorLabel = 150;
            this.nudnProfundidadeBruta._Visible = true;
            this.nudnProfundidadeBruta.BackColor = System.Drawing.Color.Transparent;
            this.nudnProfundidadeBruta.Base = null;
            this.nudnProfundidadeBruta.Color = System.Drawing.Color.White;
            this.nudnProfundidadeBruta.DecimalPlaces = 2;
            this.nudnProfundidadeBruta.Location = new System.Drawing.Point(545, 159);
            this.nudnProfundidadeBruta.Margin = new System.Windows.Forms.Padding(44, 3, 15, 3);
            this.nudnProfundidadeBruta.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudnProfundidadeBruta.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudnProfundidadeBruta.Name = "nudnProfundidadeBruta";
            this.nudnProfundidadeBruta.objConfigComponenteModel = null;
            this.nudnProfundidadeBruta.ReadOnly = false;
            this.nudnProfundidadeBruta.Size = new System.Drawing.Size(297, 22);
            this.nudnProfundidadeBruta.TabIndex = 48;
            this.nudnProfundidadeBruta.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudnProfundidadeBruta.ValueInt = 0;
            // 
            // nudnLarguraBruta
            // 
            this.nudnLarguraBruta._Field = "nLarguraBruta";
            this.nudnLarguraBruta._Help = "A largura de uma unidade que inclui a embalagem";
            this.nudnLarguraBruta._LabelGroup = this.sep_dimensao;
            this.nudnLarguraBruta._LabelText = "Largura bruta";
            this.nudnLarguraBruta._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudnLarguraBruta._Regex = null;
            this.nudnLarguraBruta._Table = "Produto";
            this.nudnLarguraBruta._TamanhoComponente = 188;
            this.nudnLarguraBruta._TamanhoMaiorLabel = 150;
            this.nudnLarguraBruta._Visible = true;
            this.nudnLarguraBruta.BackColor = System.Drawing.Color.Transparent;
            this.nudnLarguraBruta.Base = null;
            this.nudnLarguraBruta.Color = System.Drawing.Color.White;
            this.nudnLarguraBruta.DecimalPlaces = 2;
            this.nudnLarguraBruta.Location = new System.Drawing.Point(577, 187);
            this.nudnLarguraBruta.Margin = new System.Windows.Forms.Padding(76, 3, 15, 3);
            this.nudnLarguraBruta.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudnLarguraBruta.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudnLarguraBruta.Name = "nudnLarguraBruta";
            this.nudnLarguraBruta.objConfigComponenteModel = null;
            this.nudnLarguraBruta.ReadOnly = false;
            this.nudnLarguraBruta.Size = new System.Drawing.Size(265, 22);
            this.nudnLarguraBruta.TabIndex = 49;
            this.nudnLarguraBruta.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudnLarguraBruta.ValueInt = 0;
            // 
            // nudnAlturaBruta
            // 
            this.nudnAlturaBruta._Field = "nAlturaBruta";
            this.nudnAlturaBruta._Help = "A altura de uma unidade que inclui a embalagem";
            this.nudnAlturaBruta._LabelGroup = this.sep_dimensao;
            this.nudnAlturaBruta._LabelText = "Altura bruta";
            this.nudnAlturaBruta._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudnAlturaBruta._Regex = null;
            this.nudnAlturaBruta._Table = "Produto";
            this.nudnAlturaBruta._TamanhoComponente = 188;
            this.nudnAlturaBruta._TamanhoMaiorLabel = 150;
            this.nudnAlturaBruta._Visible = true;
            this.nudnAlturaBruta.BackColor = System.Drawing.Color.Transparent;
            this.nudnAlturaBruta.Base = null;
            this.nudnAlturaBruta.Color = System.Drawing.Color.White;
            this.nudnAlturaBruta.DecimalPlaces = 2;
            this.nudnAlturaBruta.Location = new System.Drawing.Point(1086, 3);
            this.nudnAlturaBruta.Margin = new System.Windows.Forms.Padding(84, 3, 15, 3);
            this.nudnAlturaBruta.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudnAlturaBruta.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudnAlturaBruta.Name = "nudnAlturaBruta";
            this.nudnAlturaBruta.objConfigComponenteModel = null;
            this.nudnAlturaBruta.ReadOnly = false;
            this.nudnAlturaBruta.Size = new System.Drawing.Size(257, 22);
            this.nudnAlturaBruta.TabIndex = 50;
            this.nudnAlturaBruta.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudnAlturaBruta.ValueInt = 0;
            // 
            // sep_FormacaoCusto
            // 
            this.sep_FormacaoCusto._LabelText = "Formação de custo";
            this.sep_FormacaoCusto._TamanhoMaiorLabel = 0;
            this.sep_FormacaoCusto.BackColor = System.Drawing.Color.Transparent;
            this.sep_FormacaoCusto.Location = new System.Drawing.Point(0, 75);
            this.sep_FormacaoCusto.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.sep_FormacaoCusto.Name = "sep_FormacaoCusto";
            this.sep_FormacaoCusto.Size = new System.Drawing.Size(486, 18);
            this.sep_FormacaoCusto.TabIndex = 64;
            this.sep_FormacaoCusto.TabStop = false;
            // 
            // cbxstCusto
            // 
            this.cbxstCusto._Field = "stCusto";
            this.cbxstCusto._Help = "É preenchido com a origem de custo do produto, podendo ser custo manual, por cust" +
    "o automático ou por custo de composição.";
            this.cbxstCusto._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbxstCusto._Itens")));
            this.cbxstCusto._LabelGroup = this.sep_FormacaoCusto;
            this.cbxstCusto._LabelText = "Formação do custo";
            this.cbxstCusto._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbxstCusto._Regex = null;
            this.cbxstCusto._situacao = false;
            this.cbxstCusto._Table = "Produto";
            this.cbxstCusto._TamanhoComponente = 186;
            this.cbxstCusto._TamanhoMaiorLabel = 150;
            this.cbxstCusto._Visible = true;
            this.cbxstCusto.BackColor = System.Drawing.Color.Transparent;
            this.cbxstCusto.Base = null;
            this.cbxstCusto.Color = System.Drawing.Color.White;
            this.cbxstCusto.DataSource = null;
            this.cbxstCusto.DisplayMember = "DisplayMember";
            this.cbxstCusto.Location = new System.Drawing.Point(1050, 55);
            this.cbxstCusto.Margin = new System.Windows.Forms.Padding(48, 3, 15, 3);
            this.cbxstCusto.Name = "cbxstCusto";
            this.cbxstCusto.objConfigComponenteModel = null;
            this.cbxstCusto.SelectedIndex = -1;
            this.cbxstCusto.SelectedValue = 0;
            this.cbxstCusto.Size = new System.Drawing.Size(291, 21);
            this.cbxstCusto.TabIndex = 53;
            this.cbxstCusto.ValueMember = "ValueMember";
            // 
            // cbxstCustoMedio
            // 
            this.cbxstCustoMedio._Field = "stCustoMedio";
            this.cbxstCustoMedio._Help = "Informativo sobre qual custo o produto está usando, podendo ser custo médio ou cu" +
    "sto atual. o campo só é habilitado quando a formação do custo for custo automáti" +
    "co.";
            this.cbxstCustoMedio._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbxstCustoMedio._Itens")));
            this.cbxstCustoMedio._LabelGroup = this.sep_FormacaoCusto;
            this.cbxstCustoMedio._LabelText = "Tipo de custo automático";
            this.cbxstCustoMedio._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbxstCustoMedio._Regex = null;
            this.cbxstCustoMedio._situacao = false;
            this.cbxstCustoMedio._Table = "Produto";
            this.cbxstCustoMedio._TamanhoComponente = 129;
            this.cbxstCustoMedio._TamanhoMaiorLabel = 150;
            this.cbxstCustoMedio._Visible = true;
            this.cbxstCustoMedio.BackColor = System.Drawing.Color.Transparent;
            this.cbxstCustoMedio.Base = null;
            this.cbxstCustoMedio.Color = System.Drawing.Color.White;
            this.cbxstCustoMedio.DataSource = null;
            this.cbxstCustoMedio.DisplayMember = "DisplayMember";
            this.cbxstCustoMedio.Location = new System.Drawing.Point(1018, 82);
            this.cbxstCustoMedio.Margin = new System.Windows.Forms.Padding(16, 3, 15, 3);
            this.cbxstCustoMedio.Name = "cbxstCustoMedio";
            this.cbxstCustoMedio.objConfigComponenteModel = null;
            this.cbxstCustoMedio.SelectedIndex = -1;
            this.cbxstCustoMedio.SelectedValue = 0;
            this.cbxstCustoMedio.Size = new System.Drawing.Size(266, 21);
            this.cbxstCustoMedio.TabIndex = 54;
            this.cbxstCustoMedio.ValueMember = "ValueMember";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.kryptonPanel3);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1144, 225);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Tag = false;
            this.tabPage5.Text = "Dados fiscais";
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.flowLayoutPanel3);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(1144, 225);
            this.kryptonPanel3.TabIndex = 1;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel3.Controls.Add(this.sep_GeralDadosFiscais);
            this.flowLayoutPanel3.Controls.Add(this.nudpInss);
            this.flowLayoutPanel3.Controls.Add(this.nudpImportacao);
            this.flowLayoutPanel3.Controls.Add(this.cbxstOrigemMercadoria);
            this.flowLayoutPanel3.Controls.Add(this.hlP_PesquisaidCSTIcms);
            this.flowLayoutPanel3.Controls.Add(this.cbxstInss);
            this.flowLayoutPanel3.Controls.Add(this.sep_OrdemVenda);
            this.flowLayoutPanel3.Controls.Add(this.hlP_PesquisaidCodigoIcmsPaiVenda);
            this.flowLayoutPanel3.Controls.Add(this.hlP_PesquisaidCSTIpiVenda);
            this.flowLayoutPanel3.Controls.Add(this.hlP_PesquisaidCSTPisVenda);
            this.flowLayoutPanel3.Controls.Add(this.hlP_PesquisaidCSTCofinsVenda);
            this.flowLayoutPanel3.Controls.Add(this.hlP_PesquisaidClassificacaoFiscalVenda);
            this.flowLayoutPanel3.Controls.Add(this.sep_OrdemCompra);
            this.flowLayoutPanel3.Controls.Add(this.hlP_PesquisaidCodigoIcmsPaiCompra);
            this.flowLayoutPanel3.Controls.Add(this.hlP_PesquisaidCSTIpiCompra);
            this.flowLayoutPanel3.Controls.Add(this.hlP_PesquisaidCSTPisCompra);
            this.flowLayoutPanel3.Controls.Add(this.hlP_PesquisaidCSTCofinsCompra);
            this.flowLayoutPanel3.Controls.Add(this.hlP_PesquisaidClassificacaoFiscalCompra);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1144, 225);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // sep_GeralDadosFiscais
            // 
            this.sep_GeralDadosFiscais._LabelText = "Geral";
            this.sep_GeralDadosFiscais._TamanhoMaiorLabel = 0;
            this.sep_GeralDadosFiscais.BackColor = System.Drawing.Color.Transparent;
            this.sep_GeralDadosFiscais.Location = new System.Drawing.Point(0, 3);
            this.sep_GeralDadosFiscais.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.sep_GeralDadosFiscais.Name = "sep_GeralDadosFiscais";
            this.sep_GeralDadosFiscais.Size = new System.Drawing.Size(517, 18);
            this.sep_GeralDadosFiscais.TabIndex = 2;
            this.sep_GeralDadosFiscais.TabStop = false;
            // 
            // nudpInss
            // 
            this.nudpInss._Field = "pInss";
            this.nudpInss._Help = "Informar a alíquota sobre o inss (instituto nacional de seguro social)";
            this.nudpInss._LabelGroup = this.sep_GeralDadosFiscais;
            this.nudpInss._LabelText = "% de inss";
            this.nudpInss._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudpInss._Regex = null;
            this.nudpInss._Table = "Produto";
            this.nudpInss._TamanhoComponente = 127;
            this.nudpInss._TamanhoMaiorLabel = 200;
            this.nudpInss._Visible = true;
            this.nudpInss.BackColor = System.Drawing.Color.Transparent;
            this.nudpInss.Base = null;
            this.nudpInss.Color = System.Drawing.Color.White;
            this.nudpInss.DecimalPlaces = 2;
            this.nudpInss.Location = new System.Drawing.Point(148, 27);
            this.nudpInss.Margin = new System.Windows.Forms.Padding(148, 3, 15, 3);
            this.nudpInss.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudpInss.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudpInss.Name = "nudpInss";
            this.nudpInss.objConfigComponenteModel = null;
            this.nudpInss.ReadOnly = false;
            this.nudpInss.Size = new System.Drawing.Size(182, 22);
            this.nudpInss.TabIndex = 75;
            this.nudpInss.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudpInss.ValueInt = 0;
            // 
            // nudpImportacao
            // 
            this.nudpImportacao._Field = "pImportacao";
            this.nudpImportacao._Help = "É preenchido com a alíquota de importação do produto. ";
            this.nudpImportacao._LabelGroup = this.sep_GeralDadosFiscais;
            this.nudpImportacao._LabelText = "Alíquota de importação";
            this.nudpImportacao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudpImportacao._Regex = null;
            this.nudpImportacao._Table = "Produto";
            this.nudpImportacao._TamanhoComponente = 127;
            this.nudpImportacao._TamanhoMaiorLabel = 200;
            this.nudpImportacao._Visible = true;
            this.nudpImportacao.BackColor = System.Drawing.Color.Transparent;
            this.nudpImportacao.Base = null;
            this.nudpImportacao.Color = System.Drawing.Color.White;
            this.nudpImportacao.DecimalPlaces = 2;
            this.nudpImportacao.Location = new System.Drawing.Point(75, 55);
            this.nudpImportacao.Margin = new System.Windows.Forms.Padding(75, 3, 15, 3);
            this.nudpImportacao.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudpImportacao.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudpImportacao.Name = "nudpImportacao";
            this.nudpImportacao.objConfigComponenteModel = null;
            this.nudpImportacao.ReadOnly = false;
            this.nudpImportacao.Size = new System.Drawing.Size(255, 22);
            this.nudpImportacao.TabIndex = 64;
            this.nudpImportacao.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudpImportacao.ValueInt = 0;
            // 
            // cbxstOrigemMercadoria
            // 
            this.cbxstOrigemMercadoria._Field = "stOrigemMercadoria";
            this.cbxstOrigemMercadoria._Help = "Informar qual é a origem da mercadoria, são elas:";
            this.cbxstOrigemMercadoria._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbxstOrigemMercadoria._Itens")));
            this.cbxstOrigemMercadoria._LabelGroup = this.sep_GeralDadosFiscais;
            this.cbxstOrigemMercadoria._LabelText = "Origem da mercadoria";
            this.cbxstOrigemMercadoria._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbxstOrigemMercadoria._Regex = null;
            this.cbxstOrigemMercadoria._situacao = false;
            this.cbxstOrigemMercadoria._Table = "Produto";
            this.cbxstOrigemMercadoria._TamanhoComponente = 325;
            this.cbxstOrigemMercadoria._TamanhoMaiorLabel = 200;
            this.cbxstOrigemMercadoria._Visible = true;
            this.cbxstOrigemMercadoria.BackColor = System.Drawing.Color.Transparent;
            this.cbxstOrigemMercadoria.Base = null;
            this.cbxstOrigemMercadoria.Color = System.Drawing.Color.White;
            this.cbxstOrigemMercadoria.DataSource = null;
            this.cbxstOrigemMercadoria.DisplayMember = "DisplayMember";
            this.cbxstOrigemMercadoria.Location = new System.Drawing.Point(82, 83);
            this.cbxstOrigemMercadoria.Margin = new System.Windows.Forms.Padding(82, 3, 15, 3);
            this.cbxstOrigemMercadoria.Name = "cbxstOrigemMercadoria";
            this.cbxstOrigemMercadoria.objConfigComponenteModel = null;
            this.cbxstOrigemMercadoria.SelectedIndex = -1;
            this.cbxstOrigemMercadoria.SelectedValue = 0;
            this.cbxstOrigemMercadoria.Size = new System.Drawing.Size(446, 21);
            this.cbxstOrigemMercadoria.TabIndex = 62;
            this.cbxstOrigemMercadoria.ValueMember = "ValueMember";
            // 
            // hlP_PesquisaidCSTIcms
            // 
            this.hlP_PesquisaidCSTIcms._Field = "idCSTIcms";
            this.hlP_PesquisaidCSTIcms._Help = "Informar a situação tributária para o icms (imposto sobre circulação de mercadori" +
    "as e prestação de serviços)";
            this.hlP_PesquisaidCSTIcms._LabelGroup = this.sep_GeralDadosFiscais;
            this.hlP_PesquisaidCSTIcms._LabelText = "Situação tributária sobre icms";
            this.hlP_PesquisaidCSTIcms._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidCSTIcms._ListaCamposDisplay")));
            this.hlP_PesquisaidCSTIcms._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidCSTIcms._ListaValoresDisplay")));
            this.hlP_PesquisaidCSTIcms._NomeCampoPK = "ID";
            this.hlP_PesquisaidCSTIcms._NomeFormCadastroOriginal = "FormStICMS";
            this.hlP_PesquisaidCSTIcms._NomeView = "vwSituacaoTributariaIcms";
            this.hlP_PesquisaidCSTIcms._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisaidCSTIcms._Regex = null;
            this.hlP_PesquisaidCSTIcms._Table = "Produto";
            this.hlP_PesquisaidCSTIcms._TamanhoComponente = 300;
            this.hlP_PesquisaidCSTIcms._TamanhoMaiorLabel = 200;
            this.hlP_PesquisaidCSTIcms._Vinculado = false;
            this.hlP_PesquisaidCSTIcms._Visible = true;
            this.hlP_PesquisaidCSTIcms.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidCSTIcms.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidCSTIcms.Base = null;
            this.hlP_PesquisaidCSTIcms.Location = new System.Drawing.Point(44, 110);
            this.hlP_PesquisaidCSTIcms.Margin = new System.Windows.Forms.Padding(44, 3, 15, 3);
            this.hlP_PesquisaidCSTIcms.Name = "hlP_PesquisaidCSTIcms";
            this.hlP_PesquisaidCSTIcms.objConfigComponenteModel = null;
            this.hlP_PesquisaidCSTIcms.ReadOnly = false;
            this.hlP_PesquisaidCSTIcms.Size = new System.Drawing.Size(459, 21);
            this.hlP_PesquisaidCSTIcms.TabIndex = 63;
            this.hlP_PesquisaidCSTIcms.Value = 0;
            // 
            // cbxstInss
            // 
            this.cbxstInss._Field = "stInss";
            this.cbxstInss._Help = "Informar se o produto/serviço entrara para a base de inss (instituto nacional de " +
    "seguro social) se sim o campo percentual de inss ficará habilitado.";
            this.cbxstInss._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbxstInss._Itens")));
            this.cbxstInss._LabelGroup = this.sep_GeralDadosFiscais;
            this.cbxstInss._LabelText = "Entra para base de inss";
            this.cbxstInss._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbxstInss._Regex = null;
            this.cbxstInss._situacao = true;
            this.cbxstInss._Table = "Produto";
            this.cbxstInss._TamanhoComponente = 80;
            this.cbxstInss._TamanhoMaiorLabel = 200;
            this.cbxstInss._Visible = true;
            this.cbxstInss.BackColor = System.Drawing.Color.Transparent;
            this.cbxstInss.Base = null;
            this.cbxstInss.Color = System.Drawing.Color.White;
            this.cbxstInss.DataSource = null;
            this.cbxstInss.DisplayMember = "DisplayMember";
            this.cbxstInss.Location = new System.Drawing.Point(77, 137);
            this.cbxstInss.Margin = new System.Windows.Forms.Padding(77, 3, 15, 3);
            this.cbxstInss.Name = "cbxstInss";
            this.cbxstInss.objConfigComponenteModel = null;
            this.cbxstInss.SelectedIndex = -1;
            this.cbxstInss.SelectedValue = 0;
            this.cbxstInss.Size = new System.Drawing.Size(206, 21);
            this.cbxstInss.TabIndex = 74;
            this.cbxstInss.ValueMember = "ValueMember";
            // 
            // sep_OrdemVenda
            // 
            this.sep_OrdemVenda._LabelText = "Ordem de venda";
            this.sep_OrdemVenda._TamanhoMaiorLabel = 0;
            this.sep_OrdemVenda.BackColor = System.Drawing.Color.Transparent;
            this.sep_OrdemVenda.Location = new System.Drawing.Point(0, 27);
            this.sep_OrdemVenda.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.sep_OrdemVenda.Name = "sep_OrdemVenda";
            this.sep_OrdemVenda.Size = new System.Drawing.Size(517, 18);
            this.sep_OrdemVenda.TabIndex = 81;
            this.sep_OrdemVenda.TabStop = false;
            // 
            // hlP_PesquisaidCodigoIcmsPaiVenda
            // 
            this.hlP_PesquisaidCodigoIcmsPaiVenda._Field = "idCodigoIcmsPaiVenda";
            this.hlP_PesquisaidCodigoIcmsPaiVenda._Help = "É preenchido com o código de amarração com o estado e alíquota do icms para o pro" +
    "duto.";
            this.hlP_PesquisaidCodigoIcmsPaiVenda._LabelGroup = this.sep_OrdemVenda;
            this.hlP_PesquisaidCodigoIcmsPaiVenda._LabelText = "Código de icms";
            this.hlP_PesquisaidCodigoIcmsPaiVenda._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidCodigoIcmsPaiVenda._ListaCamposDisplay")));
            this.hlP_PesquisaidCodigoIcmsPaiVenda._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidCodigoIcmsPaiVenda._ListaValoresDisplay")));
            this.hlP_PesquisaidCodigoIcmsPaiVenda._NomeCampoPK = "ID";
            this.hlP_PesquisaidCodigoIcmsPaiVenda._NomeFormCadastroOriginal = "FormCodigoIcms";
            this.hlP_PesquisaidCodigoIcmsPaiVenda._NomeView = "vwCodigoIcmsPai";
            this.hlP_PesquisaidCodigoIcmsPaiVenda._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisaidCodigoIcmsPaiVenda._Regex = null;
            this.hlP_PesquisaidCodigoIcmsPaiVenda._Table = "Produto";
            this.hlP_PesquisaidCodigoIcmsPaiVenda._TamanhoComponente = 300;
            this.hlP_PesquisaidCodigoIcmsPaiVenda._TamanhoMaiorLabel = 200;
            this.hlP_PesquisaidCodigoIcmsPaiVenda._Vinculado = false;
            this.hlP_PesquisaidCodigoIcmsPaiVenda._Visible = true;
            this.hlP_PesquisaidCodigoIcmsPaiVenda.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidCodigoIcmsPaiVenda.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidCodigoIcmsPaiVenda.Base = null;
            this.hlP_PesquisaidCodigoIcmsPaiVenda.Location = new System.Drawing.Point(117, 188);
            this.hlP_PesquisaidCodigoIcmsPaiVenda.Margin = new System.Windows.Forms.Padding(117, 3, 15, 3);
            this.hlP_PesquisaidCodigoIcmsPaiVenda.Name = "hlP_PesquisaidCodigoIcmsPaiVenda";
            this.hlP_PesquisaidCodigoIcmsPaiVenda.objConfigComponenteModel = null;
            this.hlP_PesquisaidCodigoIcmsPaiVenda.ReadOnly = false;
            this.hlP_PesquisaidCodigoIcmsPaiVenda.Size = new System.Drawing.Size(386, 21);
            this.hlP_PesquisaidCodigoIcmsPaiVenda.TabIndex = 65;
            this.hlP_PesquisaidCodigoIcmsPaiVenda.Value = 0;
            // 
            // hlP_PesquisaidCSTIpiVenda
            // 
            this.hlP_PesquisaidCSTIpiVenda._Field = "idCSTIpiVenda";
            this.hlP_PesquisaidCSTIpiVenda._Help = "Informar a situação tributária sobre vendas para o ipi (imposto sobre produto ind" +
    "ustrializado)";
            this.hlP_PesquisaidCSTIpiVenda._LabelGroup = this.sep_OrdemVenda;
            this.hlP_PesquisaidCSTIpiVenda._LabelText = "Tributária situação de ipi ";
            this.hlP_PesquisaidCSTIpiVenda._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidCSTIpiVenda._ListaCamposDisplay")));
            this.hlP_PesquisaidCSTIpiVenda._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidCSTIpiVenda._ListaValoresDisplay")));
            this.hlP_PesquisaidCSTIpiVenda._NomeCampoPK = "ID";
            this.hlP_PesquisaidCSTIpiVenda._NomeFormCadastroOriginal = "FormStIPI";
            this.hlP_PesquisaidCSTIpiVenda._NomeView = "vwStIPI";
            this.hlP_PesquisaidCSTIpiVenda._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisaidCSTIpiVenda._Regex = null;
            this.hlP_PesquisaidCSTIpiVenda._Table = "Produto";
            this.hlP_PesquisaidCSTIpiVenda._TamanhoComponente = 300;
            this.hlP_PesquisaidCSTIpiVenda._TamanhoMaiorLabel = 200;
            this.hlP_PesquisaidCSTIpiVenda._Vinculado = false;
            this.hlP_PesquisaidCSTIpiVenda._Visible = true;
            this.hlP_PesquisaidCSTIpiVenda.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidCSTIpiVenda.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidCSTIpiVenda.Base = null;
            this.hlP_PesquisaidCSTIpiVenda.Location = new System.Drawing.Point(609, 3);
            this.hlP_PesquisaidCSTIpiVenda.Margin = new System.Windows.Forms.Padding(66, 3, 15, 3);
            this.hlP_PesquisaidCSTIpiVenda.Name = "hlP_PesquisaidCSTIpiVenda";
            this.hlP_PesquisaidCSTIpiVenda.objConfigComponenteModel = null;
            this.hlP_PesquisaidCSTIpiVenda.ReadOnly = false;
            this.hlP_PesquisaidCSTIpiVenda.Size = new System.Drawing.Size(437, 21);
            this.hlP_PesquisaidCSTIpiVenda.TabIndex = 76;
            this.hlP_PesquisaidCSTIpiVenda.Value = 0;
            // 
            // hlP_PesquisaidCSTPisVenda
            // 
            this.hlP_PesquisaidCSTPisVenda._Field = "idCSTPisVenda";
            this.hlP_PesquisaidCSTPisVenda._Help = "Informar a situação tributária sobre vendas para o pis (programa de integração so" +
    "cial)";
            this.hlP_PesquisaidCSTPisVenda._LabelGroup = this.sep_OrdemVenda;
            this.hlP_PesquisaidCSTPisVenda._LabelText = "Situação tributária de pis ";
            this.hlP_PesquisaidCSTPisVenda._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidCSTPisVenda._ListaCamposDisplay")));
            this.hlP_PesquisaidCSTPisVenda._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidCSTPisVenda._ListaValoresDisplay")));
            this.hlP_PesquisaidCSTPisVenda._NomeCampoPK = "ID";
            this.hlP_PesquisaidCSTPisVenda._NomeFormCadastroOriginal = "FormStPIS";
            this.hlP_PesquisaidCSTPisVenda._NomeView = "vwStPIS";
            this.hlP_PesquisaidCSTPisVenda._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisaidCSTPisVenda._Regex = null;
            this.hlP_PesquisaidCSTPisVenda._Table = "Produto";
            this.hlP_PesquisaidCSTPisVenda._TamanhoComponente = 300;
            this.hlP_PesquisaidCSTPisVenda._TamanhoMaiorLabel = 200;
            this.hlP_PesquisaidCSTPisVenda._Vinculado = false;
            this.hlP_PesquisaidCSTPisVenda._Visible = true;
            this.hlP_PesquisaidCSTPisVenda.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidCSTPisVenda.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidCSTPisVenda.Base = null;
            this.hlP_PesquisaidCSTPisVenda.Location = new System.Drawing.Point(607, 30);
            this.hlP_PesquisaidCSTPisVenda.Margin = new System.Windows.Forms.Padding(64, 3, 15, 3);
            this.hlP_PesquisaidCSTPisVenda.Name = "hlP_PesquisaidCSTPisVenda";
            this.hlP_PesquisaidCSTPisVenda.objConfigComponenteModel = null;
            this.hlP_PesquisaidCSTPisVenda.ReadOnly = false;
            this.hlP_PesquisaidCSTPisVenda.Size = new System.Drawing.Size(439, 21);
            this.hlP_PesquisaidCSTPisVenda.TabIndex = 66;
            this.hlP_PesquisaidCSTPisVenda.Value = 0;
            // 
            // hlP_PesquisaidCSTCofinsVenda
            // 
            this.hlP_PesquisaidCSTCofinsVenda._Field = "idCSTCofinsVenda";
            this.hlP_PesquisaidCSTCofinsVenda._Help = "Informar a situação tributária sobre vendas para o cofins (contribuição para fina" +
    "nciamento da seguridade social)";
            this.hlP_PesquisaidCSTCofinsVenda._LabelGroup = this.sep_OrdemVenda;
            this.hlP_PesquisaidCSTCofinsVenda._LabelText = "Situação tributária de cofins";
            this.hlP_PesquisaidCSTCofinsVenda._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidCSTCofinsVenda._ListaCamposDisplay")));
            this.hlP_PesquisaidCSTCofinsVenda._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidCSTCofinsVenda._ListaValoresDisplay")));
            this.hlP_PesquisaidCSTCofinsVenda._NomeCampoPK = "ID";
            this.hlP_PesquisaidCSTCofinsVenda._NomeFormCadastroOriginal = "FormStCOFINS";
            this.hlP_PesquisaidCSTCofinsVenda._NomeView = "vwStCOFINS";
            this.hlP_PesquisaidCSTCofinsVenda._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisaidCSTCofinsVenda._Regex = null;
            this.hlP_PesquisaidCSTCofinsVenda._Table = "Produto";
            this.hlP_PesquisaidCSTCofinsVenda._TamanhoComponente = 300;
            this.hlP_PesquisaidCSTCofinsVenda._TamanhoMaiorLabel = 200;
            this.hlP_PesquisaidCSTCofinsVenda._Vinculado = false;
            this.hlP_PesquisaidCSTCofinsVenda._Visible = true;
            this.hlP_PesquisaidCSTCofinsVenda.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidCSTCofinsVenda.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidCSTCofinsVenda.Base = null;
            this.hlP_PesquisaidCSTCofinsVenda.Location = new System.Drawing.Point(594, 57);
            this.hlP_PesquisaidCSTCofinsVenda.Margin = new System.Windows.Forms.Padding(51, 3, 15, 3);
            this.hlP_PesquisaidCSTCofinsVenda.Name = "hlP_PesquisaidCSTCofinsVenda";
            this.hlP_PesquisaidCSTCofinsVenda.objConfigComponenteModel = null;
            this.hlP_PesquisaidCSTCofinsVenda.ReadOnly = false;
            this.hlP_PesquisaidCSTCofinsVenda.Size = new System.Drawing.Size(452, 21);
            this.hlP_PesquisaidCSTCofinsVenda.TabIndex = 67;
            this.hlP_PesquisaidCSTCofinsVenda.Value = 0;
            // 
            // hlP_PesquisaidClassificacaoFiscalVenda
            // 
            this.hlP_PesquisaidClassificacaoFiscalVenda._Field = "idClassificacaoFiscalVenda";
            this.hlP_PesquisaidClassificacaoFiscalVenda._Help = "É preenchido com o código da classificação fiscal do produto sobre vendas. ";
            this.hlP_PesquisaidClassificacaoFiscalVenda._LabelGroup = this.sep_OrdemVenda;
            this.hlP_PesquisaidClassificacaoFiscalVenda._LabelText = "Classificação fiscal";
            this.hlP_PesquisaidClassificacaoFiscalVenda._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidClassificacaoFiscalVenda._ListaCamposDisplay")));
            this.hlP_PesquisaidClassificacaoFiscalVenda._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidClassificacaoFiscalVenda._ListaValoresDisplay")));
            this.hlP_PesquisaidClassificacaoFiscalVenda._NomeCampoPK = "ID";
            this.hlP_PesquisaidClassificacaoFiscalVenda._NomeFormCadastroOriginal = "FormClassificacaoFiscal";
            this.hlP_PesquisaidClassificacaoFiscalVenda._NomeView = "vwClassificacaoFiscal";
            this.hlP_PesquisaidClassificacaoFiscalVenda._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisaidClassificacaoFiscalVenda._Regex = null;
            this.hlP_PesquisaidClassificacaoFiscalVenda._Table = "Produto";
            this.hlP_PesquisaidClassificacaoFiscalVenda._TamanhoComponente = 300;
            this.hlP_PesquisaidClassificacaoFiscalVenda._TamanhoMaiorLabel = 200;
            this.hlP_PesquisaidClassificacaoFiscalVenda._Vinculado = false;
            this.hlP_PesquisaidClassificacaoFiscalVenda._Visible = true;
            this.hlP_PesquisaidClassificacaoFiscalVenda.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidClassificacaoFiscalVenda.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidClassificacaoFiscalVenda.Base = null;
            this.hlP_PesquisaidClassificacaoFiscalVenda.Location = new System.Drawing.Point(645, 84);
            this.hlP_PesquisaidClassificacaoFiscalVenda.Margin = new System.Windows.Forms.Padding(102, 3, 15, 3);
            this.hlP_PesquisaidClassificacaoFiscalVenda.Name = "hlP_PesquisaidClassificacaoFiscalVenda";
            this.hlP_PesquisaidClassificacaoFiscalVenda.objConfigComponenteModel = null;
            this.hlP_PesquisaidClassificacaoFiscalVenda.ReadOnly = false;
            this.hlP_PesquisaidClassificacaoFiscalVenda.Size = new System.Drawing.Size(401, 21);
            this.hlP_PesquisaidClassificacaoFiscalVenda.TabIndex = 68;
            this.hlP_PesquisaidClassificacaoFiscalVenda.Value = 0;
            // 
            // sep_OrdemCompra
            // 
            this.sep_OrdemCompra._LabelText = "Ordem de compra";
            this.sep_OrdemCompra._TamanhoMaiorLabel = 0;
            this.sep_OrdemCompra.BackColor = System.Drawing.Color.Transparent;
            this.sep_OrdemCompra.Location = new System.Drawing.Point(0, 51);
            this.sep_OrdemCompra.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.sep_OrdemCompra.Name = "sep_OrdemCompra";
            this.sep_OrdemCompra.Size = new System.Drawing.Size(517, 18);
            this.sep_OrdemCompra.TabIndex = 82;
            this.sep_OrdemCompra.TabStop = false;
            // 
            // hlP_PesquisaidCodigoIcmsPaiCompra
            // 
            this.hlP_PesquisaidCodigoIcmsPaiCompra._Field = "idCodigoIcmsPaiCompra";
            this.hlP_PesquisaidCodigoIcmsPaiCompra._Help = "É preenchido com o código de amarração com o estado e alíquota do icms para o pro" +
    "duto.";
            this.hlP_PesquisaidCodigoIcmsPaiCompra._LabelGroup = this.sep_OrdemCompra;
            this.hlP_PesquisaidCodigoIcmsPaiCompra._LabelText = "Código de icms";
            this.hlP_PesquisaidCodigoIcmsPaiCompra._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidCodigoIcmsPaiCompra._ListaCamposDisplay")));
            this.hlP_PesquisaidCodigoIcmsPaiCompra._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidCodigoIcmsPaiCompra._ListaValoresDisplay")));
            this.hlP_PesquisaidCodigoIcmsPaiCompra._NomeCampoPK = "ID";
            this.hlP_PesquisaidCodigoIcmsPaiCompra._NomeFormCadastroOriginal = "FormCodigoIcms";
            this.hlP_PesquisaidCodigoIcmsPaiCompra._NomeView = "vwCodigoIcmsPai";
            this.hlP_PesquisaidCodigoIcmsPaiCompra._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisaidCodigoIcmsPaiCompra._Regex = null;
            this.hlP_PesquisaidCodigoIcmsPaiCompra._Table = "Produto";
            this.hlP_PesquisaidCodigoIcmsPaiCompra._TamanhoComponente = 300;
            this.hlP_PesquisaidCodigoIcmsPaiCompra._TamanhoMaiorLabel = 200;
            this.hlP_PesquisaidCodigoIcmsPaiCompra._Vinculado = false;
            this.hlP_PesquisaidCodigoIcmsPaiCompra._Visible = true;
            this.hlP_PesquisaidCodigoIcmsPaiCompra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidCodigoIcmsPaiCompra.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidCodigoIcmsPaiCompra.Base = null;
            this.hlP_PesquisaidCodigoIcmsPaiCompra.Location = new System.Drawing.Point(660, 135);
            this.hlP_PesquisaidCodigoIcmsPaiCompra.Margin = new System.Windows.Forms.Padding(117, 3, 15, 3);
            this.hlP_PesquisaidCodigoIcmsPaiCompra.Name = "hlP_PesquisaidCodigoIcmsPaiCompra";
            this.hlP_PesquisaidCodigoIcmsPaiCompra.objConfigComponenteModel = null;
            this.hlP_PesquisaidCodigoIcmsPaiCompra.ReadOnly = false;
            this.hlP_PesquisaidCodigoIcmsPaiCompra.Size = new System.Drawing.Size(386, 21);
            this.hlP_PesquisaidCodigoIcmsPaiCompra.TabIndex = 69;
            this.hlP_PesquisaidCodigoIcmsPaiCompra.Value = 0;
            // 
            // hlP_PesquisaidCSTIpiCompra
            // 
            this.hlP_PesquisaidCSTIpiCompra._Field = "idCSTIpiCompra";
            this.hlP_PesquisaidCSTIpiCompra._Help = "Informar a situação tributária sobre vendas para o ipi (imposto sobre produto ind" +
    "ustrializado)";
            this.hlP_PesquisaidCSTIpiCompra._LabelGroup = this.sep_OrdemCompra;
            this.hlP_PesquisaidCSTIpiCompra._LabelText = "Tributária situação de ipi ";
            this.hlP_PesquisaidCSTIpiCompra._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidCSTIpiCompra._ListaCamposDisplay")));
            this.hlP_PesquisaidCSTIpiCompra._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidCSTIpiCompra._ListaValoresDisplay")));
            this.hlP_PesquisaidCSTIpiCompra._NomeCampoPK = "ID";
            this.hlP_PesquisaidCSTIpiCompra._NomeFormCadastroOriginal = "FormStIPI";
            this.hlP_PesquisaidCSTIpiCompra._NomeView = "vwStIPI";
            this.hlP_PesquisaidCSTIpiCompra._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisaidCSTIpiCompra._Regex = null;
            this.hlP_PesquisaidCSTIpiCompra._Table = "Produto";
            this.hlP_PesquisaidCSTIpiCompra._TamanhoComponente = 300;
            this.hlP_PesquisaidCSTIpiCompra._TamanhoMaiorLabel = 200;
            this.hlP_PesquisaidCSTIpiCompra._Vinculado = false;
            this.hlP_PesquisaidCSTIpiCompra._Visible = true;
            this.hlP_PesquisaidCSTIpiCompra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidCSTIpiCompra.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidCSTIpiCompra.Base = null;
            this.hlP_PesquisaidCSTIpiCompra.Location = new System.Drawing.Point(609, 162);
            this.hlP_PesquisaidCSTIpiCompra.Margin = new System.Windows.Forms.Padding(66, 3, 15, 3);
            this.hlP_PesquisaidCSTIpiCompra.Name = "hlP_PesquisaidCSTIpiCompra";
            this.hlP_PesquisaidCSTIpiCompra.objConfigComponenteModel = null;
            this.hlP_PesquisaidCSTIpiCompra.ReadOnly = false;
            this.hlP_PesquisaidCSTIpiCompra.Size = new System.Drawing.Size(437, 21);
            this.hlP_PesquisaidCSTIpiCompra.TabIndex = 80;
            this.hlP_PesquisaidCSTIpiCompra.Value = 0;
            // 
            // hlP_PesquisaidCSTPisCompra
            // 
            this.hlP_PesquisaidCSTPisCompra._Field = "idCSTPisCompra";
            this.hlP_PesquisaidCSTPisCompra._Help = "Informar a situação tributária sobre vendas para o pis (programa de integração so" +
    "cial)";
            this.hlP_PesquisaidCSTPisCompra._LabelGroup = this.sep_OrdemCompra;
            this.hlP_PesquisaidCSTPisCompra._LabelText = "Situação tributária de pis ";
            this.hlP_PesquisaidCSTPisCompra._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidCSTPisCompra._ListaCamposDisplay")));
            this.hlP_PesquisaidCSTPisCompra._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidCSTPisCompra._ListaValoresDisplay")));
            this.hlP_PesquisaidCSTPisCompra._NomeCampoPK = "ID";
            this.hlP_PesquisaidCSTPisCompra._NomeFormCadastroOriginal = "FormStPIS";
            this.hlP_PesquisaidCSTPisCompra._NomeView = "vwStPIS";
            this.hlP_PesquisaidCSTPisCompra._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisaidCSTPisCompra._Regex = null;
            this.hlP_PesquisaidCSTPisCompra._Table = "Produto";
            this.hlP_PesquisaidCSTPisCompra._TamanhoComponente = 300;
            this.hlP_PesquisaidCSTPisCompra._TamanhoMaiorLabel = 200;
            this.hlP_PesquisaidCSTPisCompra._Vinculado = false;
            this.hlP_PesquisaidCSTPisCompra._Visible = true;
            this.hlP_PesquisaidCSTPisCompra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidCSTPisCompra.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidCSTPisCompra.Base = null;
            this.hlP_PesquisaidCSTPisCompra.Location = new System.Drawing.Point(607, 189);
            this.hlP_PesquisaidCSTPisCompra.Margin = new System.Windows.Forms.Padding(64, 3, 15, 3);
            this.hlP_PesquisaidCSTPisCompra.Name = "hlP_PesquisaidCSTPisCompra";
            this.hlP_PesquisaidCSTPisCompra.objConfigComponenteModel = null;
            this.hlP_PesquisaidCSTPisCompra.ReadOnly = false;
            this.hlP_PesquisaidCSTPisCompra.Size = new System.Drawing.Size(439, 21);
            this.hlP_PesquisaidCSTPisCompra.TabIndex = 77;
            this.hlP_PesquisaidCSTPisCompra.Value = 0;
            // 
            // hlP_PesquisaidCSTCofinsCompra
            // 
            this.hlP_PesquisaidCSTCofinsCompra._Field = "idCSTCofinsCompra";
            this.hlP_PesquisaidCSTCofinsCompra._Help = "Informar a situação tributária sobre vendas para o cofins (contribuição para fina" +
    "nciamento da seguridade social)";
            this.hlP_PesquisaidCSTCofinsCompra._LabelGroup = this.sep_OrdemCompra;
            this.hlP_PesquisaidCSTCofinsCompra._LabelText = "Situação tributária de cofins";
            this.hlP_PesquisaidCSTCofinsCompra._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidCSTCofinsCompra._ListaCamposDisplay")));
            this.hlP_PesquisaidCSTCofinsCompra._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidCSTCofinsCompra._ListaValoresDisplay")));
            this.hlP_PesquisaidCSTCofinsCompra._NomeCampoPK = "ID";
            this.hlP_PesquisaidCSTCofinsCompra._NomeFormCadastroOriginal = "FormStCOFINS";
            this.hlP_PesquisaidCSTCofinsCompra._NomeView = "vwStCOFINS";
            this.hlP_PesquisaidCSTCofinsCompra._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisaidCSTCofinsCompra._Regex = null;
            this.hlP_PesquisaidCSTCofinsCompra._Table = "Produto";
            this.hlP_PesquisaidCSTCofinsCompra._TamanhoComponente = 300;
            this.hlP_PesquisaidCSTCofinsCompra._TamanhoMaiorLabel = 200;
            this.hlP_PesquisaidCSTCofinsCompra._Vinculado = false;
            this.hlP_PesquisaidCSTCofinsCompra._Visible = true;
            this.hlP_PesquisaidCSTCofinsCompra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidCSTCofinsCompra.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidCSTCofinsCompra.Base = null;
            this.hlP_PesquisaidCSTCofinsCompra.Location = new System.Drawing.Point(1126, 3);
            this.hlP_PesquisaidCSTCofinsCompra.Margin = new System.Windows.Forms.Padding(51, 3, 15, 3);
            this.hlP_PesquisaidCSTCofinsCompra.Name = "hlP_PesquisaidCSTCofinsCompra";
            this.hlP_PesquisaidCSTCofinsCompra.objConfigComponenteModel = null;
            this.hlP_PesquisaidCSTCofinsCompra.ReadOnly = false;
            this.hlP_PesquisaidCSTCofinsCompra.Size = new System.Drawing.Size(452, 21);
            this.hlP_PesquisaidCSTCofinsCompra.TabIndex = 78;
            this.hlP_PesquisaidCSTCofinsCompra.Value = 0;
            // 
            // hlP_PesquisaidClassificacaoFiscalCompra
            // 
            this.hlP_PesquisaidClassificacaoFiscalCompra._Field = "idClassificacaoFiscalCompra";
            this.hlP_PesquisaidClassificacaoFiscalCompra._Help = "É preenchido com o código da classificação fiscal do produto sobre vendas. ";
            this.hlP_PesquisaidClassificacaoFiscalCompra._LabelGroup = this.sep_OrdemCompra;
            this.hlP_PesquisaidClassificacaoFiscalCompra._LabelText = "Classificação fiscal";
            this.hlP_PesquisaidClassificacaoFiscalCompra._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidClassificacaoFiscalCompra._ListaCamposDisplay")));
            this.hlP_PesquisaidClassificacaoFiscalCompra._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidClassificacaoFiscalCompra._ListaValoresDisplay")));
            this.hlP_PesquisaidClassificacaoFiscalCompra._NomeCampoPK = "ID";
            this.hlP_PesquisaidClassificacaoFiscalCompra._NomeFormCadastroOriginal = "FormClassificacaoFiscal";
            this.hlP_PesquisaidClassificacaoFiscalCompra._NomeView = "vwClassificacaoFiscal";
            this.hlP_PesquisaidClassificacaoFiscalCompra._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisaidClassificacaoFiscalCompra._Regex = null;
            this.hlP_PesquisaidClassificacaoFiscalCompra._Table = "Produto";
            this.hlP_PesquisaidClassificacaoFiscalCompra._TamanhoComponente = 300;
            this.hlP_PesquisaidClassificacaoFiscalCompra._TamanhoMaiorLabel = 200;
            this.hlP_PesquisaidClassificacaoFiscalCompra._Vinculado = false;
            this.hlP_PesquisaidClassificacaoFiscalCompra._Visible = true;
            this.hlP_PesquisaidClassificacaoFiscalCompra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidClassificacaoFiscalCompra.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidClassificacaoFiscalCompra.Base = null;
            this.hlP_PesquisaidClassificacaoFiscalCompra.Location = new System.Drawing.Point(1177, 30);
            this.hlP_PesquisaidClassificacaoFiscalCompra.Margin = new System.Windows.Forms.Padding(102, 3, 15, 3);
            this.hlP_PesquisaidClassificacaoFiscalCompra.Name = "hlP_PesquisaidClassificacaoFiscalCompra";
            this.hlP_PesquisaidClassificacaoFiscalCompra.objConfigComponenteModel = null;
            this.hlP_PesquisaidClassificacaoFiscalCompra.ReadOnly = false;
            this.hlP_PesquisaidClassificacaoFiscalCompra.Size = new System.Drawing.Size(401, 21);
            this.hlP_PesquisaidClassificacaoFiscalCompra.TabIndex = 79;
            this.hlP_PesquisaidClassificacaoFiscalCompra.Value = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.kryptonPanel4);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1144, 225);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Tag = false;
            this.tabPage6.Text = "Dados de ordem de venda";
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.flowLayoutPanel4);
            this.kryptonPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel4.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(1144, 225);
            this.kryptonPanel4.TabIndex = 1;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel4.Controls.Add(this.sep_ConfigOrdemVenda);
            this.flowLayoutPanel4.Controls.Add(this.nudvVenda);
            this.flowLayoutPanel4.Controls.Add(this.nudpEntregaExcedenteVenda);
            this.flowLayoutPanel4.Controls.Add(this.nudpEntregaInsuficienteVenda);
            this.flowLayoutPanel4.Controls.Add(this.txtdValorVenda);
            this.flowLayoutPanel4.Controls.Add(this.hlP_PesquisaidUnidadeMedidaVendas);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(1144, 225);
            this.flowLayoutPanel4.TabIndex = 0;
            // 
            // sep_ConfigOrdemVenda
            // 
            this.sep_ConfigOrdemVenda._LabelText = "Configuração";
            this.sep_ConfigOrdemVenda._TamanhoMaiorLabel = 0;
            this.sep_ConfigOrdemVenda.BackColor = System.Drawing.Color.Transparent;
            this.sep_ConfigOrdemVenda.Location = new System.Drawing.Point(0, 3);
            this.sep_ConfigOrdemVenda.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.sep_ConfigOrdemVenda.Name = "sep_ConfigOrdemVenda";
            this.sep_ConfigOrdemVenda.Size = new System.Drawing.Size(590, 18);
            this.sep_ConfigOrdemVenda.TabIndex = 7;
            this.sep_ConfigOrdemVenda.TabStop = false;
            // 
            // nudvVenda
            // 
            this.nudvVenda._Field = "vVenda";
            this.nudvVenda._Help = "Preço final de venda do produto, quando preenchido o sistema joga o valor na list" +
    "a de preço padrão, lista 000000001";
            this.nudvVenda._LabelGroup = this.sep_ConfigOrdemVenda;
            this.nudvVenda._LabelText = "Preço de venda";
            this.nudvVenda._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudvVenda._Regex = null;
            this.nudvVenda._Table = "Produto";
            this.nudvVenda._TamanhoComponente = 122;
            this.nudvVenda._TamanhoMaiorLabel = 200;
            this.nudvVenda._Visible = true;
            this.nudvVenda.BackColor = System.Drawing.Color.Transparent;
            this.nudvVenda.Base = null;
            this.nudvVenda.Color = System.Drawing.Color.White;
            this.nudvVenda.DecimalPlaces = 2;
            this.nudvVenda.Location = new System.Drawing.Point(118, 27);
            this.nudvVenda.Margin = new System.Windows.Forms.Padding(118, 3, 15, 3);
            this.nudvVenda.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudvVenda.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudvVenda.Name = "nudvVenda";
            this.nudvVenda.objConfigComponenteModel = null;
            this.nudvVenda.ReadOnly = false;
            this.nudvVenda.Size = new System.Drawing.Size(207, 22);
            this.nudvVenda.TabIndex = 0;
            this.nudvVenda.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudvVenda.ValueInt = 0;
            // 
            // nudpEntregaExcedenteVenda
            // 
            this.nudpEntregaExcedenteVenda._Field = "pEntregaExcedenteVenda";
            this.nudpEntregaExcedenteVenda._Help = "Insira o valor aceitável da entrega excedente como um valor. ";
            this.nudpEntregaExcedenteVenda._LabelGroup = this.sep_ConfigOrdemVenda;
            this.nudpEntregaExcedenteVenda._LabelText = "Entrega excedente";
            this.nudpEntregaExcedenteVenda._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudpEntregaExcedenteVenda._Regex = null;
            this.nudpEntregaExcedenteVenda._Table = "Produto";
            this.nudpEntregaExcedenteVenda._TamanhoComponente = 122;
            this.nudpEntregaExcedenteVenda._TamanhoMaiorLabel = 200;
            this.nudpEntregaExcedenteVenda._Visible = true;
            this.nudpEntregaExcedenteVenda.BackColor = System.Drawing.Color.Transparent;
            this.nudpEntregaExcedenteVenda.Base = null;
            this.nudpEntregaExcedenteVenda.Color = System.Drawing.Color.White;
            this.nudpEntregaExcedenteVenda.DecimalPlaces = 2;
            this.nudpEntregaExcedenteVenda.Location = new System.Drawing.Point(101, 55);
            this.nudpEntregaExcedenteVenda.Margin = new System.Windows.Forms.Padding(101, 3, 15, 3);
            this.nudpEntregaExcedenteVenda.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudpEntregaExcedenteVenda.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudpEntregaExcedenteVenda.Name = "nudpEntregaExcedenteVenda";
            this.nudpEntregaExcedenteVenda.objConfigComponenteModel = null;
            this.nudpEntregaExcedenteVenda.ReadOnly = false;
            this.nudpEntregaExcedenteVenda.Size = new System.Drawing.Size(224, 22);
            this.nudpEntregaExcedenteVenda.TabIndex = 3;
            this.nudpEntregaExcedenteVenda.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudpEntregaExcedenteVenda.ValueInt = 0;
            // 
            // nudpEntregaInsuficienteVenda
            // 
            this.nudpEntregaInsuficienteVenda._Field = "pEntregaInsuficienteVenda";
            this.nudpEntregaInsuficienteVenda._Help = "Insira o valor aceitável da entrega insuficiente como uma porcentagem. ";
            this.nudpEntregaInsuficienteVenda._LabelGroup = this.sep_ConfigOrdemVenda;
            this.nudpEntregaInsuficienteVenda._LabelText = "Entrega insuficiente";
            this.nudpEntregaInsuficienteVenda._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudpEntregaInsuficienteVenda._Regex = null;
            this.nudpEntregaInsuficienteVenda._Table = "Produto";
            this.nudpEntregaInsuficienteVenda._TamanhoComponente = 122;
            this.nudpEntregaInsuficienteVenda._TamanhoMaiorLabel = 200;
            this.nudpEntregaInsuficienteVenda._Visible = true;
            this.nudpEntregaInsuficienteVenda.BackColor = System.Drawing.Color.Transparent;
            this.nudpEntregaInsuficienteVenda.Base = null;
            this.nudpEntregaInsuficienteVenda.Color = System.Drawing.Color.White;
            this.nudpEntregaInsuficienteVenda.DecimalPlaces = 2;
            this.nudpEntregaInsuficienteVenda.Location = new System.Drawing.Point(93, 83);
            this.nudpEntregaInsuficienteVenda.Margin = new System.Windows.Forms.Padding(93, 3, 15, 3);
            this.nudpEntregaInsuficienteVenda.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudpEntregaInsuficienteVenda.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudpEntregaInsuficienteVenda.Name = "nudpEntregaInsuficienteVenda";
            this.nudpEntregaInsuficienteVenda.objConfigComponenteModel = null;
            this.nudpEntregaInsuficienteVenda.ReadOnly = false;
            this.nudpEntregaInsuficienteVenda.Size = new System.Drawing.Size(232, 22);
            this.nudpEntregaInsuficienteVenda.TabIndex = 4;
            this.nudpEntregaInsuficienteVenda.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudpEntregaInsuficienteVenda.ValueInt = 0;
            // 
            // txtdValorVenda
            // 
            this.txtdValorVenda._Field = "dValorvenda";
            this.txtdValorVenda._Help = "Ultima alteração no preço de venda";
            this.txtdValorVenda._LabelGroup = this.sep_ConfigOrdemVenda;
            this.txtdValorVenda._LabelText = "Ultima alteração no preço de venda";
            this.txtdValorVenda._Multiline = false;
            this.txtdValorVenda._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtdValorVenda._Password = false;
            this.txtdValorVenda._Regex = null;
            this.txtdValorVenda._Table = "Produto";
            this.txtdValorVenda._TamanhoComponente = 122;
            this.txtdValorVenda._TamanhoMaiorLabel = 200;
            this.txtdValorVenda._Visible = true;
            this.txtdValorVenda.BackColor = System.Drawing.Color.Transparent;
            this.txtdValorVenda.Base = null;
            this.txtdValorVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtdValorVenda.Color = System.Drawing.Color.White;
            this.txtdValorVenda.Location = new System.Drawing.Point(14, 111);
            this.txtdValorVenda.Margin = new System.Windows.Forms.Padding(14, 3, 15, 3);
            this.txtdValorVenda.MaxLength = 32767;
            this.txtdValorVenda.Name = "txtdValorVenda";
            this.txtdValorVenda.objConfigComponenteModel = null;
            this.txtdValorVenda.ReadOnly = true;
            this.txtdValorVenda.Size = new System.Drawing.Size(311, 21);
            this.txtdValorVenda.TabIndex = 6;
            this.txtdValorVenda.TabStop = false;
            // 
            // hlP_PesquisaidUnidadeMedidaVendas
            // 
            this.hlP_PesquisaidUnidadeMedidaVendas._Field = "idUnidadeMedidaVendas";
            this.hlP_PesquisaidUnidadeMedidaVendas._Help = "Deve ser informado a unidade de medida para as, cotações, ordens de vendas, fatur" +
    "amento";
            this.hlP_PesquisaidUnidadeMedidaVendas._LabelGroup = this.sep_ConfigOrdemVenda;
            this.hlP_PesquisaidUnidadeMedidaVendas._LabelText = "Unidade de medida";
            this.hlP_PesquisaidUnidadeMedidaVendas._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidUnidadeMedidaVendas._ListaCamposDisplay")));
            this.hlP_PesquisaidUnidadeMedidaVendas._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidUnidadeMedidaVendas._ListaValoresDisplay")));
            this.hlP_PesquisaidUnidadeMedidaVendas._NomeCampoPK = "ID";
            this.hlP_PesquisaidUnidadeMedidaVendas._NomeFormCadastroOriginal = "FormUnidadeMedida";
            this.hlP_PesquisaidUnidadeMedidaVendas._NomeView = "vwUnidadeMedida";
            this.hlP_PesquisaidUnidadeMedidaVendas._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisaidUnidadeMedidaVendas._Regex = null;
            this.hlP_PesquisaidUnidadeMedidaVendas._Table = "Produto";
            this.hlP_PesquisaidUnidadeMedidaVendas._TamanhoComponente = 300;
            this.hlP_PesquisaidUnidadeMedidaVendas._TamanhoMaiorLabel = 200;
            this.hlP_PesquisaidUnidadeMedidaVendas._Vinculado = false;
            this.hlP_PesquisaidUnidadeMedidaVendas._Visible = true;
            this.hlP_PesquisaidUnidadeMedidaVendas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidUnidadeMedidaVendas.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidUnidadeMedidaVendas.Base = null;
            this.hlP_PesquisaidUnidadeMedidaVendas.Location = new System.Drawing.Point(95, 138);
            this.hlP_PesquisaidUnidadeMedidaVendas.Margin = new System.Windows.Forms.Padding(95, 3, 15, 3);
            this.hlP_PesquisaidUnidadeMedidaVendas.Name = "hlP_PesquisaidUnidadeMedidaVendas";
            this.hlP_PesquisaidUnidadeMedidaVendas.objConfigComponenteModel = null;
            this.hlP_PesquisaidUnidadeMedidaVendas.ReadOnly = false;
            this.hlP_PesquisaidUnidadeMedidaVendas.Size = new System.Drawing.Size(408, 21);
            this.hlP_PesquisaidUnidadeMedidaVendas.TabIndex = 1;
            this.hlP_PesquisaidUnidadeMedidaVendas.Value = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.kryptonPanel5);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1144, 225);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Tag = false;
            this.tabPage7.Text = "Dados de ordem de compras";
            // 
            // kryptonPanel5
            // 
            this.kryptonPanel5.Controls.Add(this.flowLayoutPanel5);
            this.kryptonPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel5.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel5.Name = "kryptonPanel5";
            this.kryptonPanel5.Size = new System.Drawing.Size(1144, 225);
            this.kryptonPanel5.TabIndex = 1;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel5.Controls.Add(this.sep_ConfigOrdemCompra);
            this.flowLayoutPanel5.Controls.Add(this.nudvCompra);
            this.flowLayoutPanel5.Controls.Add(this.nudnLoteMinimoCompras);
            this.flowLayoutPanel5.Controls.Add(this.nudpEntregaExcedenteCompra);
            this.flowLayoutPanel5.Controls.Add(this.nudpEntregaInsuficienteCompra);
            this.flowLayoutPanel5.Controls.Add(this.hlP_PesquisaidUnidadeMedidaCompras);
            this.flowLayoutPanel5.Controls.Add(this.cbxstFornecedorHomologado);
            this.flowLayoutPanel5.Controls.Add(this.sep_LeadTime);
            this.flowLayoutPanel5.Controls.Add(this.dtdleadTimeCotacao);
            this.flowLayoutPanel5.Controls.Add(this.dtdleadTimePedido);
            this.flowLayoutPanel5.Controls.Add(this.dtdleadTimeRecebimento);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(1144, 225);
            this.flowLayoutPanel5.TabIndex = 0;
            // 
            // sep_ConfigOrdemCompra
            // 
            this.sep_ConfigOrdemCompra._LabelText = "Configuração";
            this.sep_ConfigOrdemCompra._TamanhoMaiorLabel = 0;
            this.sep_ConfigOrdemCompra.BackColor = System.Drawing.Color.Transparent;
            this.sep_ConfigOrdemCompra.Location = new System.Drawing.Point(0, 3);
            this.sep_ConfigOrdemCompra.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.sep_ConfigOrdemCompra.Name = "sep_ConfigOrdemCompra";
            this.sep_ConfigOrdemCompra.Size = new System.Drawing.Size(571, 18);
            this.sep_ConfigOrdemCompra.TabIndex = 19;
            this.sep_ConfigOrdemCompra.TabStop = false;
            // 
            // nudvCompra
            // 
            this.nudvCompra._Field = "vCompra";
            this.nudvCompra._Help = "O magníficus informará automaticamente o valor de aquisição do produto, baseado s" +
    "empre no valor de custo do produto.";
            this.nudvCompra._LabelGroup = this.sep_ConfigOrdemCompra;
            this.nudvCompra._LabelText = "Valor do custo de aquisição";
            this.nudvCompra._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudvCompra._Regex = null;
            this.nudvCompra._Table = "Produto";
            this.nudvCompra._TamanhoComponente = 124;
            this.nudvCompra._TamanhoMaiorLabel = 200;
            this.nudvCompra._Visible = true;
            this.nudvCompra.BackColor = System.Drawing.Color.Transparent;
            this.nudvCompra.Base = null;
            this.nudvCompra.Color = System.Drawing.Color.White;
            this.nudvCompra.DecimalPlaces = 2;
            this.nudvCompra.Location = new System.Drawing.Point(53, 27);
            this.nudvCompra.Margin = new System.Windows.Forms.Padding(53, 3, 15, 3);
            this.nudvCompra.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudvCompra.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudvCompra.Name = "nudvCompra";
            this.nudvCompra.objConfigComponenteModel = null;
            this.nudvCompra.ReadOnly = false;
            this.nudvCompra.Size = new System.Drawing.Size(274, 22);
            this.nudvCompra.TabIndex = 9;
            this.nudvCompra.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudvCompra.ValueInt = 0;
            // 
            // nudnLoteMinimoCompras
            // 
            this.nudnLoteMinimoCompras._Field = "nLoteMinimoCompras";
            this.nudnLoteMinimoCompras._Help = "Informação sobre lote mínimo para compra, baseando sempre na unidade de medida de" +
    " compras.";
            this.nudnLoteMinimoCompras._LabelGroup = this.sep_ConfigOrdemCompra;
            this.nudnLoteMinimoCompras._LabelText = "Lote mínimo para compra";
            this.nudnLoteMinimoCompras._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudnLoteMinimoCompras._Regex = null;
            this.nudnLoteMinimoCompras._Table = "Produto";
            this.nudnLoteMinimoCompras._TamanhoComponente = 124;
            this.nudnLoteMinimoCompras._TamanhoMaiorLabel = 200;
            this.nudnLoteMinimoCompras._Visible = true;
            this.nudnLoteMinimoCompras.BackColor = System.Drawing.Color.Transparent;
            this.nudnLoteMinimoCompras.Base = null;
            this.nudnLoteMinimoCompras.Color = System.Drawing.Color.White;
            this.nudnLoteMinimoCompras.DecimalPlaces = 2;
            this.nudnLoteMinimoCompras.Location = new System.Drawing.Point(66, 55);
            this.nudnLoteMinimoCompras.Margin = new System.Windows.Forms.Padding(66, 3, 15, 3);
            this.nudnLoteMinimoCompras.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudnLoteMinimoCompras.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudnLoteMinimoCompras.Name = "nudnLoteMinimoCompras";
            this.nudnLoteMinimoCompras.objConfigComponenteModel = null;
            this.nudnLoteMinimoCompras.ReadOnly = false;
            this.nudnLoteMinimoCompras.Size = new System.Drawing.Size(261, 22);
            this.nudnLoteMinimoCompras.TabIndex = 12;
            this.nudnLoteMinimoCompras.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudnLoteMinimoCompras.ValueInt = 0;
            // 
            // nudpEntregaExcedenteCompra
            // 
            this.nudpEntregaExcedenteCompra._Field = "pEntregaExcedenteCompra";
            this.nudpEntregaExcedenteCompra._Help = "Insira o valor aceitável da entrega excedente como um valor. ";
            this.nudpEntregaExcedenteCompra._LabelGroup = this.sep_ConfigOrdemCompra;
            this.nudpEntregaExcedenteCompra._LabelText = "Entrega excedente";
            this.nudpEntregaExcedenteCompra._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudpEntregaExcedenteCompra._Regex = null;
            this.nudpEntregaExcedenteCompra._Table = "Produto";
            this.nudpEntregaExcedenteCompra._TamanhoComponente = 124;
            this.nudpEntregaExcedenteCompra._TamanhoMaiorLabel = 200;
            this.nudpEntregaExcedenteCompra._Visible = true;
            this.nudpEntregaExcedenteCompra.BackColor = System.Drawing.Color.Transparent;
            this.nudpEntregaExcedenteCompra.Base = null;
            this.nudpEntregaExcedenteCompra.Color = System.Drawing.Color.White;
            this.nudpEntregaExcedenteCompra.DecimalPlaces = 2;
            this.nudpEntregaExcedenteCompra.Location = new System.Drawing.Point(101, 83);
            this.nudpEntregaExcedenteCompra.Margin = new System.Windows.Forms.Padding(101, 3, 15, 3);
            this.nudpEntregaExcedenteCompra.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudpEntregaExcedenteCompra.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudpEntregaExcedenteCompra.Name = "nudpEntregaExcedenteCompra";
            this.nudpEntregaExcedenteCompra.objConfigComponenteModel = null;
            this.nudpEntregaExcedenteCompra.ReadOnly = false;
            this.nudpEntregaExcedenteCompra.Size = new System.Drawing.Size(226, 22);
            this.nudpEntregaExcedenteCompra.TabIndex = 13;
            this.nudpEntregaExcedenteCompra.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudpEntregaExcedenteCompra.ValueInt = 0;
            // 
            // nudpEntregaInsuficienteCompra
            // 
            this.nudpEntregaInsuficienteCompra._Field = "pEntregaInsuficienteCompra";
            this.nudpEntregaInsuficienteCompra._Help = "Insira o valor aceitável da entrega insuficiente como uma porcentagem";
            this.nudpEntregaInsuficienteCompra._LabelGroup = this.sep_ConfigOrdemCompra;
            this.nudpEntregaInsuficienteCompra._LabelText = "Entrega insuficiente";
            this.nudpEntregaInsuficienteCompra._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudpEntregaInsuficienteCompra._Regex = null;
            this.nudpEntregaInsuficienteCompra._Table = "Produto";
            this.nudpEntregaInsuficienteCompra._TamanhoComponente = 124;
            this.nudpEntregaInsuficienteCompra._TamanhoMaiorLabel = 200;
            this.nudpEntregaInsuficienteCompra._Visible = true;
            this.nudpEntregaInsuficienteCompra.BackColor = System.Drawing.Color.Transparent;
            this.nudpEntregaInsuficienteCompra.Base = null;
            this.nudpEntregaInsuficienteCompra.Color = System.Drawing.Color.White;
            this.nudpEntregaInsuficienteCompra.DecimalPlaces = 2;
            this.nudpEntregaInsuficienteCompra.Location = new System.Drawing.Point(93, 111);
            this.nudpEntregaInsuficienteCompra.Margin = new System.Windows.Forms.Padding(93, 3, 15, 3);
            this.nudpEntregaInsuficienteCompra.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudpEntregaInsuficienteCompra.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudpEntregaInsuficienteCompra.Name = "nudpEntregaInsuficienteCompra";
            this.nudpEntregaInsuficienteCompra.objConfigComponenteModel = null;
            this.nudpEntregaInsuficienteCompra.ReadOnly = false;
            this.nudpEntregaInsuficienteCompra.Size = new System.Drawing.Size(234, 22);
            this.nudpEntregaInsuficienteCompra.TabIndex = 14;
            this.nudpEntregaInsuficienteCompra.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudpEntregaInsuficienteCompra.ValueInt = 0;
            // 
            // hlP_PesquisaidUnidadeMedidaCompras
            // 
            this.hlP_PesquisaidUnidadeMedidaCompras._Field = "idUnidadeMedidaCompras";
            this.hlP_PesquisaidUnidadeMedidaCompras._Help = "Deve ser informado a unidade de medida para as, cotações, ordens de vendas, fatur" +
    "amento";
            this.hlP_PesquisaidUnidadeMedidaCompras._LabelGroup = this.sep_ConfigOrdemCompra;
            this.hlP_PesquisaidUnidadeMedidaCompras._LabelText = "Unidade de medida";
            this.hlP_PesquisaidUnidadeMedidaCompras._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidUnidadeMedidaCompras._ListaCamposDisplay")));
            this.hlP_PesquisaidUnidadeMedidaCompras._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidUnidadeMedidaCompras._ListaValoresDisplay")));
            this.hlP_PesquisaidUnidadeMedidaCompras._NomeCampoPK = "ID";
            this.hlP_PesquisaidUnidadeMedidaCompras._NomeFormCadastroOriginal = "FormUnidadeMedida";
            this.hlP_PesquisaidUnidadeMedidaCompras._NomeView = "vwUnidadeMedida";
            this.hlP_PesquisaidUnidadeMedidaCompras._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisaidUnidadeMedidaCompras._Regex = null;
            this.hlP_PesquisaidUnidadeMedidaCompras._Table = "Produto";
            this.hlP_PesquisaidUnidadeMedidaCompras._TamanhoComponente = 300;
            this.hlP_PesquisaidUnidadeMedidaCompras._TamanhoMaiorLabel = 200;
            this.hlP_PesquisaidUnidadeMedidaCompras._Vinculado = false;
            this.hlP_PesquisaidUnidadeMedidaCompras._Visible = true;
            this.hlP_PesquisaidUnidadeMedidaCompras.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidUnidadeMedidaCompras.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidUnidadeMedidaCompras.Base = null;
            this.hlP_PesquisaidUnidadeMedidaCompras.Location = new System.Drawing.Point(95, 139);
            this.hlP_PesquisaidUnidadeMedidaCompras.Margin = new System.Windows.Forms.Padding(95, 3, 15, 3);
            this.hlP_PesquisaidUnidadeMedidaCompras.Name = "hlP_PesquisaidUnidadeMedidaCompras";
            this.hlP_PesquisaidUnidadeMedidaCompras.objConfigComponenteModel = null;
            this.hlP_PesquisaidUnidadeMedidaCompras.ReadOnly = false;
            this.hlP_PesquisaidUnidadeMedidaCompras.Size = new System.Drawing.Size(408, 21);
            this.hlP_PesquisaidUnidadeMedidaCompras.TabIndex = 18;
            this.hlP_PesquisaidUnidadeMedidaCompras.Value = 0;
            // 
            // cbxstFornecedorHomologado
            // 
            this.cbxstFornecedorHomologado._Field = "stFornecedorHomologado";
            this.cbxstFornecedorHomologado._Help = "Informar se para esse produto é exigido fornecedores homologados, se sim o sistem" +
    "a ativará a aba para lançamentos dos fornecedores homologado.";
            this.cbxstFornecedorHomologado._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbxstFornecedorHomologado._Itens")));
            this.cbxstFornecedorHomologado._LabelGroup = this.sep_ConfigOrdemCompra;
            this.cbxstFornecedorHomologado._LabelText = "Exige fornecedor homologado";
            this.cbxstFornecedorHomologado._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbxstFornecedorHomologado._Regex = null;
            this.cbxstFornecedorHomologado._situacao = true;
            this.cbxstFornecedorHomologado._Table = "Produto";
            this.cbxstFornecedorHomologado._TamanhoComponente = 80;
            this.cbxstFornecedorHomologado._TamanhoMaiorLabel = 200;
            this.cbxstFornecedorHomologado._Visible = true;
            this.cbxstFornecedorHomologado.BackColor = System.Drawing.Color.Transparent;
            this.cbxstFornecedorHomologado.Base = null;
            this.cbxstFornecedorHomologado.Color = System.Drawing.Color.White;
            this.cbxstFornecedorHomologado.DataSource = null;
            this.cbxstFornecedorHomologado.DisplayMember = "DisplayMember";
            this.cbxstFornecedorHomologado.Location = new System.Drawing.Point(39, 166);
            this.cbxstFornecedorHomologado.Margin = new System.Windows.Forms.Padding(39, 3, 15, 3);
            this.cbxstFornecedorHomologado.Name = "cbxstFornecedorHomologado";
            this.cbxstFornecedorHomologado.objConfigComponenteModel = null;
            this.cbxstFornecedorHomologado.SelectedIndex = -1;
            this.cbxstFornecedorHomologado.SelectedValue = 0;
            this.cbxstFornecedorHomologado.Size = new System.Drawing.Size(244, 21);
            this.cbxstFornecedorHomologado.TabIndex = 11;
            this.cbxstFornecedorHomologado.ValueMember = "ValueMember";
            this.cbxstFornecedorHomologado._SelectedIndexChanged += new System.EventHandler(this.cbxstFornecedorHomologado__SelectedIndexChanged);
            // 
            // sep_LeadTime
            // 
            this.sep_LeadTime._LabelText = "Lead time";
            this.sep_LeadTime._TamanhoMaiorLabel = 0;
            this.sep_LeadTime.BackColor = System.Drawing.Color.Transparent;
            this.sep_LeadTime.Location = new System.Drawing.Point(0, 27);
            this.sep_LeadTime.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.sep_LeadTime.Name = "sep_LeadTime";
            this.sep_LeadTime.Size = new System.Drawing.Size(289, 18);
            this.sep_LeadTime.TabIndex = 20;
            this.sep_LeadTime.TabStop = false;
            // 
            // dtdleadTimeCotacao
            // 
            this.dtdleadTimeCotacao._Field = "dleadTimeCotacao";
            this.dtdleadTimeCotacao._Help = "Informar em horas o lead time para cotação de compra";
            this.dtdleadTimeCotacao._LabelGroup = this.sep_LeadTime;
            this.dtdleadTimeCotacao._LabelText = "Cotação";
            this.dtdleadTimeCotacao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.dtdleadTimeCotacao._Regex = null;
            this.dtdleadTimeCotacao._Table = "Produto";
            this.dtdleadTimeCotacao._TamanhoComponente = 72;
            this.dtdleadTimeCotacao._TamanhoMaiorLabel = 200;
            this.dtdleadTimeCotacao._Visible = true;
            this.dtdleadTimeCotacao.BackColor = System.Drawing.Color.Transparent;
            this.dtdleadTimeCotacao.Base = null;
            this.dtdleadTimeCotacao.Color = System.Drawing.Color.Empty;
            this.dtdleadTimeCotacao.CustomFormat = "";
            this.dtdleadTimeCotacao.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtdleadTimeCotacao.Location = new System.Drawing.Point(740, 3);
            this.dtdleadTimeCotacao.Margin = new System.Windows.Forms.Padding(154, 3, 15, 3);
            this.dtdleadTimeCotacao.Name = "dtdleadTimeCotacao";
            this.dtdleadTimeCotacao.objConfigComponenteModel = null;
            this.dtdleadTimeCotacao.Size = new System.Drawing.Size(121, 21);
            this.dtdleadTimeCotacao.TabIndex = 15;
            this.dtdleadTimeCotacao.Value = new System.DateTime(2012, 8, 27, 17, 8, 30, 218);
            // 
            // dtdleadTimePedido
            // 
            this.dtdleadTimePedido._Field = "dleadTimePedido";
            this.dtdleadTimePedido._Help = "Informar em horas o lead time para o pedido de compra";
            this.dtdleadTimePedido._LabelGroup = this.sep_LeadTime;
            this.dtdleadTimePedido._LabelText = "Pedido";
            this.dtdleadTimePedido._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.dtdleadTimePedido._Regex = null;
            this.dtdleadTimePedido._Table = "Produto";
            this.dtdleadTimePedido._TamanhoComponente = 72;
            this.dtdleadTimePedido._TamanhoMaiorLabel = 200;
            this.dtdleadTimePedido._Visible = true;
            this.dtdleadTimePedido.BackColor = System.Drawing.Color.Transparent;
            this.dtdleadTimePedido.Base = null;
            this.dtdleadTimePedido.Color = System.Drawing.Color.Empty;
            this.dtdleadTimePedido.CustomFormat = "";
            this.dtdleadTimePedido.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtdleadTimePedido.Location = new System.Drawing.Point(746, 30);
            this.dtdleadTimePedido.Margin = new System.Windows.Forms.Padding(160, 3, 15, 3);
            this.dtdleadTimePedido.Name = "dtdleadTimePedido";
            this.dtdleadTimePedido.objConfigComponenteModel = null;
            this.dtdleadTimePedido.Size = new System.Drawing.Size(115, 21);
            this.dtdleadTimePedido.TabIndex = 16;
            this.dtdleadTimePedido.Value = new System.DateTime(2012, 8, 27, 17, 8, 30, 218);
            // 
            // dtdleadTimeRecebimento
            // 
            this.dtdleadTimeRecebimento._Field = "dleadTimeRecebimento";
            this.dtdleadTimeRecebimento._Help = "Informar em horas o lead time para recebimento da compra";
            this.dtdleadTimeRecebimento._LabelGroup = this.sep_LeadTime;
            this.dtdleadTimeRecebimento._LabelText = "Recebimento";
            this.dtdleadTimeRecebimento._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.dtdleadTimeRecebimento._Regex = null;
            this.dtdleadTimeRecebimento._Table = "Produto";
            this.dtdleadTimeRecebimento._TamanhoComponente = 72;
            this.dtdleadTimeRecebimento._TamanhoMaiorLabel = 200;
            this.dtdleadTimeRecebimento._Visible = true;
            this.dtdleadTimeRecebimento.BackColor = System.Drawing.Color.Transparent;
            this.dtdleadTimeRecebimento.Base = null;
            this.dtdleadTimeRecebimento.Color = System.Drawing.Color.Empty;
            this.dtdleadTimeRecebimento.CustomFormat = "";
            this.dtdleadTimeRecebimento.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtdleadTimeRecebimento.Location = new System.Drawing.Point(715, 57);
            this.dtdleadTimeRecebimento.Margin = new System.Windows.Forms.Padding(129, 3, 15, 3);
            this.dtdleadTimeRecebimento.Name = "dtdleadTimeRecebimento";
            this.dtdleadTimeRecebimento.objConfigComponenteModel = null;
            this.dtdleadTimeRecebimento.Size = new System.Drawing.Size(146, 21);
            this.dtdleadTimeRecebimento.TabIndex = 17;
            this.dtdleadTimeRecebimento.Value = new System.DateTime(2012, 8, 27, 17, 8, 30, 218);
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.kryptonPanel6);
            this.tabPage8.Location = new System.Drawing.Point(4, 25);
            this.tabPage8.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(1144, 225);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Tag = false;
            this.tabPage8.Text = "Dados de produção";
            // 
            // kryptonPanel6
            // 
            this.kryptonPanel6.Controls.Add(this.flowLayoutPanel6);
            this.kryptonPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel6.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel6.Name = "kryptonPanel6";
            this.kryptonPanel6.Size = new System.Drawing.Size(1144, 225);
            this.kryptonPanel6.TabIndex = 1;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel6.Controls.Add(this.Sep_ConfigProdutucao);
            this.flowLayoutPanel6.Controls.Add(this.nudvProducao);
            this.flowLayoutPanel6.Controls.Add(this.nudpPerdaConstante);
            this.flowLayoutPanel6.Controls.Add(this.nudpPerdaVariavel);
            this.flowLayoutPanel6.Controls.Add(this.hlP_PesquisaidUnidadeMedidaProducao);
            this.flowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(1144, 225);
            this.flowLayoutPanel6.TabIndex = 0;
            // 
            // Sep_ConfigProdutucao
            // 
            this.Sep_ConfigProdutucao._LabelText = "Configuração";
            this.Sep_ConfigProdutucao._TamanhoMaiorLabel = 0;
            this.Sep_ConfigProdutucao.BackColor = System.Drawing.Color.Transparent;
            this.Sep_ConfigProdutucao.Location = new System.Drawing.Point(0, 3);
            this.Sep_ConfigProdutucao.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.Sep_ConfigProdutucao.Name = "Sep_ConfigProdutucao";
            this.Sep_ConfigProdutucao.Size = new System.Drawing.Size(550, 18);
            this.Sep_ConfigProdutucao.TabIndex = 20;
            this.Sep_ConfigProdutucao.TabStop = false;
            // 
            // nudvProducao
            // 
            this.nudvProducao._Field = "vProducao";
            this.nudvProducao._Help = "O magníficus informará automaticamente o valor de aquisição do produto";
            this.nudvProducao._LabelGroup = this.Sep_ConfigProdutucao;
            this.nudvProducao._LabelText = "Valor do custo de transformação";
            this.nudvProducao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudvProducao._Regex = null;
            this.nudvProducao._Table = "Produto";
            this.nudvProducao._TamanhoComponente = 97;
            this.nudvProducao._TamanhoMaiorLabel = 200;
            this.nudvProducao._Visible = true;
            this.nudvProducao.BackColor = System.Drawing.Color.Transparent;
            this.nudvProducao.Base = null;
            this.nudvProducao.Color = System.Drawing.Color.White;
            this.nudvProducao.DecimalPlaces = 2;
            this.nudvProducao.Location = new System.Drawing.Point(28, 27);
            this.nudvProducao.Margin = new System.Windows.Forms.Padding(28, 3, 15, 3);
            this.nudvProducao.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudvProducao.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudvProducao.Name = "nudvProducao";
            this.nudvProducao.objConfigComponenteModel = null;
            this.nudvProducao.ReadOnly = false;
            this.nudvProducao.Size = new System.Drawing.Size(272, 22);
            this.nudvProducao.TabIndex = 0;
            this.nudvProducao.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudvProducao.ValueInt = 0;
            // 
            // nudpPerdaConstante
            // 
            this.nudpPerdaConstante._Field = "pPerdaConstante";
            this.nudpPerdaConstante._Help = "Insira um valor de perda ou sucata produzida constantemente";
            this.nudpPerdaConstante._LabelGroup = this.Sep_ConfigProdutucao;
            this.nudpPerdaConstante._LabelText = "Perda/sucata constante";
            this.nudpPerdaConstante._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudpPerdaConstante._Regex = null;
            this.nudpPerdaConstante._Table = "Produto";
            this.nudpPerdaConstante._TamanhoComponente = 97;
            this.nudpPerdaConstante._TamanhoMaiorLabel = 200;
            this.nudpPerdaConstante._Visible = true;
            this.nudpPerdaConstante.BackColor = System.Drawing.Color.Transparent;
            this.nudpPerdaConstante.Base = null;
            this.nudpPerdaConstante.Color = System.Drawing.Color.White;
            this.nudpPerdaConstante.DecimalPlaces = 2;
            this.nudpPerdaConstante.Location = new System.Drawing.Point(76, 55);
            this.nudpPerdaConstante.Margin = new System.Windows.Forms.Padding(76, 3, 15, 3);
            this.nudpPerdaConstante.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudpPerdaConstante.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudpPerdaConstante.Name = "nudpPerdaConstante";
            this.nudpPerdaConstante.objConfigComponenteModel = null;
            this.nudpPerdaConstante.ReadOnly = false;
            this.nudpPerdaConstante.Size = new System.Drawing.Size(224, 22);
            this.nudpPerdaConstante.TabIndex = 2;
            this.nudpPerdaConstante.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudpPerdaConstante.ValueInt = 0;
            // 
            // nudpPerdaVariavel
            // 
            this.nudpPerdaVariavel._Field = "pPerdaVariavel";
            this.nudpPerdaVariavel._Help = "Este valor é usado como padrão quando o item é inserido em boms, um valor percent" +
    "ual de perda ou sucata produzida variavelmente. ";
            this.nudpPerdaVariavel._LabelGroup = this.Sep_ConfigProdutucao;
            this.nudpPerdaVariavel._LabelText = "Perda/sucata variável";
            this.nudpPerdaVariavel._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudpPerdaVariavel._Regex = null;
            this.nudpPerdaVariavel._Table = "Produto";
            this.nudpPerdaVariavel._TamanhoComponente = 97;
            this.nudpPerdaVariavel._TamanhoMaiorLabel = 200;
            this.nudpPerdaVariavel._Visible = true;
            this.nudpPerdaVariavel.BackColor = System.Drawing.Color.Transparent;
            this.nudpPerdaVariavel.Base = null;
            this.nudpPerdaVariavel.Color = System.Drawing.Color.White;
            this.nudpPerdaVariavel.DecimalPlaces = 2;
            this.nudpPerdaVariavel.Location = new System.Drawing.Point(89, 83);
            this.nudpPerdaVariavel.Margin = new System.Windows.Forms.Padding(89, 3, 15, 3);
            this.nudpPerdaVariavel.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudpPerdaVariavel.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudpPerdaVariavel.Name = "nudpPerdaVariavel";
            this.nudpPerdaVariavel.objConfigComponenteModel = null;
            this.nudpPerdaVariavel.ReadOnly = false;
            this.nudpPerdaVariavel.Size = new System.Drawing.Size(211, 22);
            this.nudpPerdaVariavel.TabIndex = 3;
            this.nudpPerdaVariavel.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudpPerdaVariavel.ValueInt = 0;
            // 
            // hlP_PesquisaidUnidadeMedidaProducao
            // 
            this.hlP_PesquisaidUnidadeMedidaProducao._Field = "idUnidadeMedidaProducao";
            this.hlP_PesquisaidUnidadeMedidaProducao._Help = "Deve ser informado a unidade de medida para as, cotações, ordens de vendas, fatur" +
    "amento";
            this.hlP_PesquisaidUnidadeMedidaProducao._LabelGroup = this.Sep_ConfigProdutucao;
            this.hlP_PesquisaidUnidadeMedidaProducao._LabelText = "Unidade de medida";
            this.hlP_PesquisaidUnidadeMedidaProducao._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidUnidadeMedidaProducao._ListaCamposDisplay")));
            this.hlP_PesquisaidUnidadeMedidaProducao._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidUnidadeMedidaProducao._ListaValoresDisplay")));
            this.hlP_PesquisaidUnidadeMedidaProducao._NomeCampoPK = "ID";
            this.hlP_PesquisaidUnidadeMedidaProducao._NomeFormCadastroOriginal = "FormUnidadeMedida";
            this.hlP_PesquisaidUnidadeMedidaProducao._NomeView = "vwUnidadeMedida";
            this.hlP_PesquisaidUnidadeMedidaProducao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisaidUnidadeMedidaProducao._Regex = null;
            this.hlP_PesquisaidUnidadeMedidaProducao._Table = "Produto";
            this.hlP_PesquisaidUnidadeMedidaProducao._TamanhoComponente = 300;
            this.hlP_PesquisaidUnidadeMedidaProducao._TamanhoMaiorLabel = 200;
            this.hlP_PesquisaidUnidadeMedidaProducao._Vinculado = false;
            this.hlP_PesquisaidUnidadeMedidaProducao._Visible = true;
            this.hlP_PesquisaidUnidadeMedidaProducao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidUnidadeMedidaProducao.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidUnidadeMedidaProducao.Base = null;
            this.hlP_PesquisaidUnidadeMedidaProducao.Location = new System.Drawing.Point(95, 111);
            this.hlP_PesquisaidUnidadeMedidaProducao.Margin = new System.Windows.Forms.Padding(95, 3, 15, 3);
            this.hlP_PesquisaidUnidadeMedidaProducao.Name = "hlP_PesquisaidUnidadeMedidaProducao";
            this.hlP_PesquisaidUnidadeMedidaProducao.objConfigComponenteModel = null;
            this.hlP_PesquisaidUnidadeMedidaProducao.ReadOnly = false;
            this.hlP_PesquisaidUnidadeMedidaProducao.Size = new System.Drawing.Size(408, 21);
            this.hlP_PesquisaidUnidadeMedidaProducao.TabIndex = 19;
            this.hlP_PesquisaidUnidadeMedidaProducao.Value = 0;
            // 
            // tabPageFornecedores
            // 
            this.tabPageFornecedores.Controls.Add(this.kryptonPanel7);
            this.tabPageFornecedores.Location = new System.Drawing.Point(4, 25);
            this.tabPageFornecedores.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageFornecedores.Name = "tabPageFornecedores";
            this.tabPageFornecedores.Size = new System.Drawing.Size(1144, 225);
            this.tabPageFornecedores.TabIndex = 8;
            this.tabPageFornecedores.Tag = false;
            this.tabPageFornecedores.Text = "Fornecedores";
            // 
            // kryptonPanel7
            // 
            this.kryptonPanel7.Controls.Add(this.dgvProduto_Fornecedor_Homologado);
            this.kryptonPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel7.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel7.Name = "kryptonPanel7";
            this.kryptonPanel7.Size = new System.Drawing.Size(1144, 225);
            this.kryptonPanel7.TabIndex = 1;
            // 
            // dgvProduto_Fornecedor_Homologado
            // 
            this.dgvProduto_Fornecedor_Homologado.Altera = false;
            this.dgvProduto_Fornecedor_Homologado.AutoGenerateColumns = false;
            this.dgvProduto_Fornecedor_Homologado.cm = null;
            this.dgvProduto_Fornecedor_Homologado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto_Fornecedor_Homologado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClienteFornecedor,
            this.nLeadTimeEntregaDataGridViewTextBoxColumn,
            this.nLoteMinimoCompraDataGridViewTextBoxColumn});
            this.dgvProduto_Fornecedor_Homologado.DataSource = this.bsProduto_Fornecedor_Homologado;
            this.dgvProduto_Fornecedor_Homologado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduto_Fornecedor_Homologado.DragDropLinha = false;
            this.dgvProduto_Fornecedor_Homologado.Exclui = false;
            this.dgvProduto_Fornecedor_Homologado.Inclui = false;
            this.dgvProduto_Fornecedor_Homologado.Location = new System.Drawing.Point(0, 0);
            this.dgvProduto_Fornecedor_Homologado.Name = "dgvProduto_Fornecedor_Homologado";
            this.dgvProduto_Fornecedor_Homologado.Size = new System.Drawing.Size(1144, 225);
            this.dgvProduto_Fornecedor_Homologado.TabIndex = 1;
            this.dgvProduto_Fornecedor_Homologado.Tag = "Produto_Fornecedor_Homologado";
            // 
            // idClienteFornecedor
            // 
            this.idClienteFornecedor.DataPropertyName = "idClienteFornecedor";
            this.idClienteFornecedor.HeaderText = "Fornecedor";
            this.idClienteFornecedor.Name = "idClienteFornecedor";
            this.idClienteFornecedor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idClienteFornecedor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idClienteFornecedor.ToolTipText = "Informar o fornecedor cadastrado no formulário de fornecedores se ele é ou não ho" +
    "mologado para o fornecimento desse produto.";
            this.idClienteFornecedor.Width = 300;
            // 
            // nLeadTimeEntregaDataGridViewTextBoxColumn
            // 
            this.nLeadTimeEntregaDataGridViewTextBoxColumn.DataPropertyName = "nLeadTimeEntrega";
            this.nLeadTimeEntregaDataGridViewTextBoxColumn.HeaderText = "Lead Time Entrega";
            this.nLeadTimeEntregaDataGridViewTextBoxColumn.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nLeadTimeEntregaDataGridViewTextBoxColumn.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nLeadTimeEntregaDataGridViewTextBoxColumn.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nLeadTimeEntregaDataGridViewTextBoxColumn.Name = "nLeadTimeEntregaDataGridViewTextBoxColumn";
            this.nLeadTimeEntregaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nLeadTimeEntregaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.nLeadTimeEntregaDataGridViewTextBoxColumn.ToolTipText = "Informe em quantidade de dias o tempo de entrega para esse produto.";
            this.nLeadTimeEntregaDataGridViewTextBoxColumn.Width = 300;
            // 
            // nLoteMinimoCompraDataGridViewTextBoxColumn
            // 
            this.nLoteMinimoCompraDataGridViewTextBoxColumn.DataPropertyName = "nLoteMinimoCompra";
            this.nLoteMinimoCompraDataGridViewTextBoxColumn.HeaderText = "Lote Mínimo de Compra";
            this.nLoteMinimoCompraDataGridViewTextBoxColumn.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nLoteMinimoCompraDataGridViewTextBoxColumn.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nLoteMinimoCompraDataGridViewTextBoxColumn.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nLoteMinimoCompraDataGridViewTextBoxColumn.Name = "nLoteMinimoCompraDataGridViewTextBoxColumn";
            this.nLoteMinimoCompraDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nLoteMinimoCompraDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.nLoteMinimoCompraDataGridViewTextBoxColumn.ToolTipText = "Informe o lote mínimo de compra para esse fornecedor e o produto indicado.";
            this.nLoteMinimoCompraDataGridViewTextBoxColumn.Width = 300;
            // 
            // bsProduto_Fornecedor_Homologado
            // 
            this.bsProduto_Fornecedor_Homologado.DataSource = typeof(HLP.Models.Entries.Comercial.Produto_Fornecedor_HomologadoModel);
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.kryptonPanel8);
            this.tabPage10.Location = new System.Drawing.Point(4, 25);
            this.tabPage10.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Size = new System.Drawing.Size(1059, 655);
            this.tabPage10.TabIndex = 9;
            this.tabPage10.Tag = false;
            this.tabPage10.Text = "Log de revisão";
            // 
            // kryptonPanel8
            // 
            this.kryptonPanel8.Controls.Add(this.dgvProduto_Revisao);
            this.kryptonPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel8.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel8.Name = "kryptonPanel8";
            this.kryptonPanel8.Size = new System.Drawing.Size(1059, 655);
            this.kryptonPanel8.TabIndex = 1;
            // 
            // dgvProduto_Revisao
            // 
            this.dgvProduto_Revisao.Altera = false;
            this.dgvProduto_Revisao.AutoGenerateColumns = false;
            this.dgvProduto_Revisao.cm = null;
            this.dgvProduto_Revisao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto_Revisao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dInicialDataGridViewTextBoxColumn,
            this.idUsuario,
            this.xRevisaoDataGridViewTextBoxColumn,
            this.dFinalDataGridViewTextBoxColumn});
            this.dgvProduto_Revisao.DataSource = this.bsProduto_Revisao;
            this.dgvProduto_Revisao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduto_Revisao.DragDropLinha = false;
            this.dgvProduto_Revisao.Exclui = false;
            this.dgvProduto_Revisao.Inclui = false;
            this.dgvProduto_Revisao.Location = new System.Drawing.Point(0, 0);
            this.dgvProduto_Revisao.Name = "dgvProduto_Revisao";
            this.dgvProduto_Revisao.Size = new System.Drawing.Size(1059, 655);
            this.dgvProduto_Revisao.TabIndex = 2;
            this.dgvProduto_Revisao.Tag = "Produto_Revisao";
            this.dgvProduto_Revisao.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvProduto_Revisao_DefaultValuesNeeded);
            // 
            // bsProduto_Revisao
            // 
            this.bsProduto_Revisao.DataSource = typeof(HLP.Models.Entries.Comercial.Produto_RevisaoModel);
            // 
            // dInicialDataGridViewTextBoxColumn
            // 
            this.dInicialDataGridViewTextBoxColumn.CalendarTodayDate = new System.DateTime(2012, 8, 28, 0, 0, 0, 0);
            this.dInicialDataGridViewTextBoxColumn.Checked = false;
            this.dInicialDataGridViewTextBoxColumn.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dInicialDataGridViewTextBoxColumn.DataPropertyName = "dInicial";
            this.dInicialDataGridViewTextBoxColumn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dInicialDataGridViewTextBoxColumn.HeaderText = "Data/Hora inicial da Revisão";
            this.dInicialDataGridViewTextBoxColumn.Name = "dInicialDataGridViewTextBoxColumn";
            this.dInicialDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dInicialDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dInicialDataGridViewTextBoxColumn.ToolTipText = "O Sistema buscará automaticamente a data e hora em que foi solicitado a alteração" +
    " no cadastro de produto, campo desabilitado para alteração.";
            this.dInicialDataGridViewTextBoxColumn.Width = 200;
            // 
            // idUsuario
            // 
            this.idUsuario.DataPropertyName = "idFuncionario";
            this.idUsuario.HeaderText = "idUsuario";
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idUsuario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // xRevisaoDataGridViewTextBoxColumn
            // 
            this.xRevisaoDataGridViewTextBoxColumn.DataPropertyName = "xRevisao";
            this.xRevisaoDataGridViewTextBoxColumn.HeaderText = "Descrição da Revisão";
            this.xRevisaoDataGridViewTextBoxColumn.Name = "xRevisaoDataGridViewTextBoxColumn";
            this.xRevisaoDataGridViewTextBoxColumn.ToolTipText = resources.GetString("xRevisaoDataGridViewTextBoxColumn.ToolTipText");
            this.xRevisaoDataGridViewTextBoxColumn.Width = 200;
            // 
            // dFinalDataGridViewTextBoxColumn
            // 
            this.dFinalDataGridViewTextBoxColumn.CalendarTodayDate = new System.DateTime(2012, 8, 28, 0, 0, 0, 0);
            this.dFinalDataGridViewTextBoxColumn.Checked = false;
            this.dFinalDataGridViewTextBoxColumn.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dFinalDataGridViewTextBoxColumn.DataPropertyName = "dFinal";
            this.dFinalDataGridViewTextBoxColumn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dFinalDataGridViewTextBoxColumn.HeaderText = "Data/Hora inicial da Revisão";
            this.dFinalDataGridViewTextBoxColumn.Name = "dFinalDataGridViewTextBoxColumn";
            this.dFinalDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dFinalDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dFinalDataGridViewTextBoxColumn.ToolTipText = "O Sistema informa a data final de quando foi alterado a engenharia ou qualquer ca" +
    "mpo do cadastro de produto.";
            this.dFinalDataGridViewTextBoxColumn.Width = 200;
            // 
            // FormProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 741);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProduto";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = -10;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text = "Produtos/Serviços";
            this.Load += new System.EventHandler(this.FormProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).EndInit();
            this.panelPadrao.ResumeLayout(false);
            this.tabControlPrincipal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.kryptonPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).EndInit();
            this.kryptonPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel6)).EndInit();
            this.kryptonPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.ResumeLayout(false);
            this.tabPageFornecedores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel7)).EndInit();
            this.kryptonPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto_Fornecedor_Homologado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProduto_Fornecedor_Homologado)).EndInit();
            this.tabPage10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel8)).EndInit();
            this.kryptonPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto_Revisao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProduto_Revisao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AC.ExtendedRenderer.Navigator.KryptonTabControl tabControlPrincipal;
        private System.Windows.Forms.TabPage tabPage1;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Comum.Components.HLP_TextBox txtCodigo;
        private Comum.Components.HLP_TextBox txtxcAlternativo;
        private Comum.Components.HLP_TextBox txtcEan;
        private Comum.Components.HLP_TextBox txtxPesquisa;
        private Comum.Components.HLP_TextBox txtxComercial;
        private Comum.Components.HLP_TextBox txtxFiscal;
        private Comum.Components.HLP_TextBox txtxIngles;
        private Comum.Components.HLP_TextBox txtxFoto;
        private Comum.Components.HLP_Observacao hlP_Observacao1;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidTipoServico;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidFamiliaProduto;
        private System.Windows.Forms.TabPage tabPage4;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPageFornecedores;
        private System.Windows.Forms.TabPage tabPage10;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel7;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel8;
        private Comum.Components.HLP_NumericUpDown nudnPesoBruto;
        private Comum.Components.HLP_NumericUpDown nudnPesoLiquido;
        private Comum.Components.HLP_NumericUpDown nudnPrazoValidade;
        private Comum.Components.HLP_ComboBox cbxAtivo;
        private Comum.Components.HLP_NumericUpDown nudnEstoqueMinimo;
        private Comum.Components.HLP_NumericUpDown nudnEstoqueMaximo;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidProdutoLocalizacao;
        private Comum.Components.HLP_NumericUpDown nudnProfundidadeBruta;
        private Comum.Components.HLP_NumericUpDown nudnLarguraBruta;
        private Comum.Components.HLP_NumericUpDown nudnAlturaBruta;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidDeposito;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidFabricante;
        private Comum.Components.HLP_ComboBox cbxstCusto;
        private Comum.Components.HLP_ComboBox cbxstCustoMedio;
        private Comum.Components.HLP_ComboBox cbxstOrigemMercadoria;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidCSTIcms;
        private Comum.Components.HLP_NumericUpDown nudpImportacao;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidCodigoIcmsPaiVenda;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidCSTPisVenda;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidCSTCofinsVenda;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidClassificacaoFiscalVenda;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidCodigoIcmsPaiCompra;
        private Comum.Components.HLP_NumericUpDown nudvVenda;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidUnidadeMedidaVendas;
        private Comum.Components.HLP_NumericUpDown nudpEntregaExcedenteVenda;
        private Comum.Components.HLP_NumericUpDown nudpEntregaInsuficienteVenda;
        private Comum.Components.HLP_NumericUpDown nudvCompra;
        private Comum.Components.HLP_ComboBox cbxstFornecedorHomologado;
        private Comum.Components.HLP_NumericUpDown nudnLoteMinimoCompras;
        private Comum.Components.HLP_NumericUpDown nudpEntregaExcedenteCompra;
        private Comum.Components.HLP_NumericUpDown nudpEntregaInsuficienteCompra;
        private Comum.Components.HLP_DateTimePicker dtdleadTimeCotacao;
        private Comum.Components.HLP_DateTimePicker dtdleadTimePedido;
        private Comum.Components.HLP_DateTimePicker dtdleadTimeRecebimento;
        private Comum.Components.HLP_NumericUpDown nudvProducao;
        private Comum.Components.HLP_NumericUpDown nudpPerdaConstante;
        private Comum.Components.HLP_NumericUpDown nudpPerdaVariavel;
        private HLP_DataGridView dgvProduto_Fornecedor_Homologado;
        private System.Windows.Forms.BindingSource bsProduto_Fornecedor_Homologado;
        private System.Windows.Forms.DataGridViewComboBoxColumn idClienteFornecedor;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn nLeadTimeEntregaDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn nLoteMinimoCompraDataGridViewTextBoxColumn;
        private HLP_DataGridView dgvProduto_Revisao;
        private System.Windows.Forms.BindingSource bsProduto_Revisao;
        private Comum.Components.HLP_ComboBox cbxstInss;
        private Comum.Components.HLP_NumericUpDown nudpInss;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidCSTIpiVenda;
        private Comum.Components.HLP_TextBox txtdCadastro;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidCSTIpiCompra;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidCSTPisCompra;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidCSTCofinsCompra;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidClassificacaoFiscalCompra;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidUnidadeMedidaCompras;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidUnidadeMedidaProducao;
        private Comum.Components.HLP_ComboBox cbxidUsuario;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidUnidadeMedidaEstoque;
        private Comum.Components.HLP_TextBox txtdValorVenda;
        private Comum.Components.HLP_LabelSeparator sep_Identificacao;
        private Comum.Components.HLP_LabelSeparator sep_Item;
        private Comum.Components.HLP_LabelSeparator sep_Grupos;
        private Comum.Components.HLP_LabelSeparator sep_Config;
        private Comum.Components.HLP_LabelSeparator sep_Localizacao;
        private Comum.Components.HLP_LabelSeparator sep_dimensao;
        private Comum.Components.HLP_LabelSeparator sep_FormacaoCusto;
        private Comum.Components.HLP_LabelSeparator sep_GeralDadosFiscais;
        private Comum.Components.HLP_LabelSeparator sep_OrdemVenda;
        private Comum.Components.HLP_LabelSeparator sep_OrdemCompra;
        private Comum.Components.HLP_LabelSeparator sep_ConfigOrdemVenda;
        private Comum.Components.HLP_LabelSeparator sep_ConfigOrdemCompra;
        private Comum.Components.HLP_LabelSeparator sep_LeadTime;
        private Comum.Components.HLP_LabelSeparator Sep_ConfigProdutucao;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidTipoProduto;
        private HLP_TextBox txtdBloqueio;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn dInicialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn xRevisaoDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn dFinalDataGridViewTextBoxColumn;
    }
}