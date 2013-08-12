using HLP.Comum.Components;
namespace HLP.UI.Entries.Fiscal
{
    partial class FormTipoOperacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTipoOperacao));
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonTabControl1 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kryptonPanel1 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.hlP_LabelSeparator1_Geral = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtCodigo = new HLP.Comum.Components.HLP_TextBox();
            this.txtxOperacao = new HLP.Comum.Components.HLP_TextBox();
            this.cbotpOperacao = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostRepresentaFaturamento = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostGeraFinanceiro = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostGeraComissao = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostServico = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostOrigemMercadoria = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostEstoque = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostEstoqueClientes = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostEstoqueFornecedores = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostEntregaFutura = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostTpIndustrializacao = new HLP.Comum.Components.HLP_ComboBox();
            this.hlP_PesquisacCfopNaUf = new HLP.Comum.Components.HLP_Pesquisa();
            this.hlP_PesquisacCfopOutraUf = new HLP.Comum.Components.HLP_Pesquisa();
            this.hlP_PesquisacCfopNcontribuinte = new HLP.Comum.Components.HLP_Pesquisa();
            this.cboAtivo = new HLP.Comum.Components.HLP_ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.kryptonPanel2 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.hlP_LabelSeparator_entrada = new HLP.Comum.Components.HLP_LabelSeparator();
            this.cbostRelacaoRecebimentoInspecao = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostCalcCustoEntrada = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostDescontaCredicmsCusto = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostDescontaCredsubstCusto = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostDescontaCredipiCusto = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostDescontaCredpiscofinsCusto = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostDescontaDifIcmsCusto = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostObrigaOpNaCompra = new HLP.Comum.Components.HLP_ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.kryptonPanel3 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.hlP_LabelSeparator_saida = new HLP.Comum.Components.HLP_LabelSeparator();
            this.nudpInsumoIndustrializacao = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudpMoIndustrializacao = new HLP.Comum.Components.HLP_NumericUpDown();
            this.cbostCalcImportacao = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostCalcCredicmsSs = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostCalcCredicmsSsSt = new HLP.Comum.Components.HLP_ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.kryptonPanel4 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.hlP_LabelSeparator_fiscal = new HLP.Comum.Components.HLP_LabelSeparator();
            this.cbostReduzBase = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostNaoReduzBase = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostCalcIcms = new HLP.Comum.Components.HLP_ComboBox();
            this.hlP_PesquisaidCodigoIcmsPai = new HLP.Comum.Components.HLP_Pesquisa();
            this.hlP_PesquisaidCSTIcms = new HLP.Comum.Components.HLP_Pesquisa();
            this.cbostCompoeBaseIcms = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostCalcIpi = new HLP.Comum.Components.HLP_ComboBox();
            this.hlP_PesquisaidClassificacaoFiscal = new HLP.Comum.Components.HLP_Pesquisa();
            this.hlP_LabelSeparator_IPI = new HLP.Comum.Components.HLP_LabelSeparator();
            this.nudpIpi = new HLP.Comum.Components.HLP_NumericUpDown();
            this.hlP_PesquisaidCSTIpi = new HLP.Comum.Components.HLP_Pesquisa();
            this.cbostCompoeBaseIpi = new HLP.Comum.Components.HLP_ComboBox();
            this.hlP_LabelSeparator_icms = new HLP.Comum.Components.HLP_LabelSeparator();
            this.cbostCalcIcmsSubstTributaria = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostCompoeBaseIcmsSubstTributaria = new HLP.Comum.Components.HLP_ComboBox();
            this.hlP_LabelSeparator_piscof = new HLP.Comum.Components.HLP_LabelSeparator();
            this.nudnCoeficienteSubstTributariaPis = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudnCoeficienteSubstTributariaCofins = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudpPis = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudpCofins = new HLP.Comum.Components.HLP_NumericUpDown();
            this.cbostCalcPisCofins = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostRegimeTributacaoPisCofins = new HLP.Comum.Components.HLP_ComboBox();
            this.hlP_PesquisaidCSTPis = new HLP.Comum.Components.HLP_Pesquisa();
            this.hlP_PesquisaidCSTCofins = new HLP.Comum.Components.HLP_Pesquisa();
            this.cbostCompoeBaseNormalPiscofins = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostCompoeBaseSubtTribPis = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostCompoeBaseSubtTribCofins = new HLP.Comum.Components.HLP_ComboBox();
            this.hlP_LabelSeparatorServico = new HLP.Comum.Components.HLP_LabelSeparator();
            this.nudpIss = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudpReducaoBaseIrrf = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudpIrrf = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudpReducaoBaseInss = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudpInss = new HLP.Comum.Components.HLP_NumericUpDown();
            this.cbostCalcIss = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostCalcIrrf = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostCalcCsll = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostCalcInss = new HLP.Comum.Components.HLP_ComboBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dgvReducao = new HLP.Comum.Components.HLP_DataGridView();
            this.idUf = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pReducaoIcms = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.pReducaoIcmsSubstTributaria = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.bsOperacaoreducaobase = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.kryptonPanel5 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.hlP_LabelSeparatorProducao = new HLP.Comum.Components.HLP_LabelSeparator();
            this.cbostBaixaMaterialOp = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostExplosaoMatOp = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostEstoqueProdFimOP = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostVinculaPedVenda = new HLP.Comum.Components.HLP_ComboBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.kryptonPanel7 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.hlP_LabelSeparator_Importacao = new HLP.Comum.Components.HLP_LabelSeparator();
            this.nudImppII = new HLP.Comum.Components.HLP_NumericUpDown();
            this.cboImpstCompoeBaseIpi = new HLP.Comum.Components.HLP_ComboBox();
            this.cboImpstCompoeFatorIcms = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostCompoeBaseIcmsOculto = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostCompoeIcmsOculto = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostCompoeFatorPisCofins = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostCompoeBasePis = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostCompoePis = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostCompoeBaseCofins = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostCompoeCofins = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostCompoeBaseIcmsNormal = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostCompoeIcmsNormal = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostCompoeValorProdutos = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostCompoeValorNf = new HLP.Comum.Components.HLP_ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).BeginInit();
            this.panelPadrao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.kryptonPanel1.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.kryptonPanel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.kryptonPanel3.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.kryptonPanel4.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReducao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOperacaoreducaobase)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.kryptonPanel5.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.kryptonPanel7.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1362, 628);
            // 
            // panelPadrao
            // 
            this.panelPadrao.Controls.Add(this.kryptonTabControl1);
            this.panelPadrao.Size = new System.Drawing.Size(1360, 604);
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 27);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(1362, 628);
            this.kryptonPanel.TabIndex = 0;
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
            this.kryptonTabControl1.Controls.Add(this.tabPage3);
            this.kryptonTabControl1.Controls.Add(this.tabPage4);
            this.kryptonTabControl1.Controls.Add(this.tabPage5);
            this.kryptonTabControl1.Controls.Add(this.tabPage6);
            this.kryptonTabControl1.Controls.Add(this.tabPage7);
            this.kryptonTabControl1.CornerRoundRadiusWidth = 12;
            this.kryptonTabControl1.CornerSymmetry = AC.ExtendedRenderer.Navigator.KryptonTabControl.CornSymmetry.Both;
            this.kryptonTabControl1.CornerType = AC.ExtendedRenderer.Toolkit.Drawing.DrawingMethods.CornerType.Rounded;
            this.kryptonTabControl1.CornerWidth = AC.ExtendedRenderer.Navigator.KryptonTabControl.CornWidth.Thin;
            this.kryptonTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.kryptonTabControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTabControl1.HotTrack = true;
            this.kryptonTabControl1.Location = new System.Drawing.Point(3, 3);
            this.kryptonTabControl1.Name = "kryptonTabControl1";
            this.kryptonTabControl1.PreserveTabColor = false;
            this.kryptonTabControl1.SelectedIndex = 0;
            this.kryptonTabControl1.Size = new System.Drawing.Size(1354, 598);
            this.kryptonTabControl1.TabIndex = 0;
            this.kryptonTabControl1.Tag = "Saídas";
            this.kryptonTabControl1.UseExtendedLayout = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Controls.Add(this.kryptonPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1346, 569);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = false;
            this.tabPage1.Text = "Principal";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.BorderWidth = 0;
            this.kryptonPanel1.Controls.Add(this.flowLayoutPanel5);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.kryptonPanel1.GradientToogleColors = false;
            this.kryptonPanel1.GradientUseBlend = false;
            this.kryptonPanel1.GradientUseSolid = true;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PersistentColors = false;
            this.kryptonPanel1.Size = new System.Drawing.Size(1346, 569);
            this.kryptonPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoScroll = true;
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel5.Controls.Add(this.hlP_LabelSeparator1_Geral);
            this.flowLayoutPanel5.Controls.Add(this.txtCodigo);
            this.flowLayoutPanel5.Controls.Add(this.txtxOperacao);
            this.flowLayoutPanel5.Controls.Add(this.cbotpOperacao);
            this.flowLayoutPanel5.Controls.Add(this.cbostRepresentaFaturamento);
            this.flowLayoutPanel5.Controls.Add(this.cbostGeraFinanceiro);
            this.flowLayoutPanel5.Controls.Add(this.cbostGeraComissao);
            this.flowLayoutPanel5.Controls.Add(this.cbostServico);
            this.flowLayoutPanel5.Controls.Add(this.cbostOrigemMercadoria);
            this.flowLayoutPanel5.Controls.Add(this.cbostEstoque);
            this.flowLayoutPanel5.Controls.Add(this.cbostEstoqueClientes);
            this.flowLayoutPanel5.Controls.Add(this.cbostEstoqueFornecedores);
            this.flowLayoutPanel5.Controls.Add(this.cbostEntregaFutura);
            this.flowLayoutPanel5.Controls.Add(this.cbostTpIndustrializacao);
            this.flowLayoutPanel5.Controls.Add(this.hlP_PesquisacCfopNaUf);
            this.flowLayoutPanel5.Controls.Add(this.hlP_PesquisacCfopOutraUf);
            this.flowLayoutPanel5.Controls.Add(this.hlP_PesquisacCfopNcontribuinte);
            this.flowLayoutPanel5.Controls.Add(this.cboAtivo);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(1346, 569);
            this.flowLayoutPanel5.TabIndex = 1;
            this.flowLayoutPanel5.Tag = "Principal";
            // 
            // hlP_LabelSeparator1_Geral
            // 
            this.hlP_LabelSeparator1_Geral._LabelText = "Geral";
            this.hlP_LabelSeparator1_Geral._TamanhoMaiorLabel = 0;
            this.hlP_LabelSeparator1_Geral.BackColor = System.Drawing.Color.Transparent;
            this.hlP_LabelSeparator1_Geral.Location = new System.Drawing.Point(0, 3);
            this.hlP_LabelSeparator1_Geral.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.hlP_LabelSeparator1_Geral.Name = "hlP_LabelSeparator1_Geral";
            this.hlP_LabelSeparator1_Geral.Size = new System.Drawing.Size(541, 18);
            this.hlP_LabelSeparator1_Geral.TabIndex = 29;
            this.hlP_LabelSeparator1_Geral.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo._Field = "idTipoOperacao";
            this.txtCodigo._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtCodigo._LabelText = "Código";
            this.txtCodigo._Multiline = false;
            this.txtCodigo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtCodigo._Password = false;
            this.txtCodigo._Regex = null;
            this.txtCodigo._Table = "Tipo_operacao";
            this.txtCodigo._TamanhoComponente = 107;
            this.txtCodigo._TamanhoMaiorLabel = 200;
            this.txtCodigo._Visible = true;
            this.txtCodigo.BackColor = System.Drawing.Color.Transparent;
            this.txtCodigo.Base = null;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCodigo.Color = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(158, 27);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(158, 3, 15, 3);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.objConfigComponenteModel = null;
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(152, 21);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtxOperacao
            // 
            this.txtxOperacao._Field = "xOperacao";
            this.txtxOperacao._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtxOperacao._LabelText = "Nome";
            this.txtxOperacao._Multiline = false;
            this.txtxOperacao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxOperacao._Password = false;
            this.txtxOperacao._Regex = null;
            this.txtxOperacao._Table = "Tipo_operacao";
            this.txtxOperacao._TamanhoComponente = 338;
            this.txtxOperacao._TamanhoMaiorLabel = 200;
            this.txtxOperacao._Visible = true;
            this.txtxOperacao.BackColor = System.Drawing.Color.Transparent;
            this.txtxOperacao.Base = null;
            this.txtxOperacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxOperacao.Color = System.Drawing.Color.White;
            this.txtxOperacao.Location = new System.Drawing.Point(166, 54);
            this.txtxOperacao.Margin = new System.Windows.Forms.Padding(166, 3, 15, 3);
            this.txtxOperacao.MaxLength = 32767;
            this.txtxOperacao.Name = "txtxOperacao";
            this.txtxOperacao.objConfigComponenteModel = null;
            this.txtxOperacao.ReadOnly = false;
            this.txtxOperacao.Size = new System.Drawing.Size(375, 21);
            this.txtxOperacao.TabIndex = 2;
            // 
            // cbotpOperacao
            // 
            this.cbotpOperacao._Field = "tpOperacao";
            this.cbotpOperacao._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbotpOperacao._Itens")));
            this.cbotpOperacao._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cbotpOperacao._LabelText = "Tipo de operação";
            this.cbotpOperacao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbotpOperacao._Regex = null;
            this.cbotpOperacao._situacao = false;
            this.cbotpOperacao._Table = "Tipo_operacao";
            this.cbotpOperacao._TamanhoComponente = 236;
            this.cbotpOperacao._TamanhoMaiorLabel = 200;
            this.cbotpOperacao._Visible = true;
            this.cbotpOperacao.BackColor = System.Drawing.Color.Transparent;
            this.cbotpOperacao.Base = null;
            this.cbotpOperacao.Color = System.Drawing.Color.White;
            this.cbotpOperacao.DataSource = null;
            this.cbotpOperacao.DisplayMember = "DisplayMember";
            this.cbotpOperacao.Location = new System.Drawing.Point(107, 81);
            this.cbotpOperacao.Margin = new System.Windows.Forms.Padding(107, 3, 15, 3);
            this.cbotpOperacao.Name = "cbotpOperacao";
            this.cbotpOperacao.objConfigComponenteModel = null;
            this.cbotpOperacao.SelectedIndex = -1;
            this.cbotpOperacao.SelectedValue = 0;
            this.cbotpOperacao.Size = new System.Drawing.Size(332, 21);
            this.cbotpOperacao.TabIndex = 3;
            this.cbotpOperacao.ValueMember = "ValueMember";
            // 
            // cbostRepresentaFaturamento
            // 
            this.cbostRepresentaFaturamento._Field = "stRepresentaFaturamento";
            this.cbostRepresentaFaturamento._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostRepresentaFaturamento._Itens")));
            this.cbostRepresentaFaturamento._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cbostRepresentaFaturamento._LabelText = "Representa faturamento?";
            this.cbostRepresentaFaturamento._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostRepresentaFaturamento._Regex = null;
            this.cbostRepresentaFaturamento._situacao = true;
            this.cbostRepresentaFaturamento._Table = "Tipo_operacao";
            this.cbostRepresentaFaturamento._TamanhoComponente = 80;
            this.cbostRepresentaFaturamento._TamanhoMaiorLabel = 200;
            this.cbostRepresentaFaturamento._Visible = true;
            this.cbostRepresentaFaturamento.BackColor = System.Drawing.Color.Transparent;
            this.cbostRepresentaFaturamento.Base = null;
            this.cbostRepresentaFaturamento.Color = System.Drawing.Color.White;
            this.cbostRepresentaFaturamento.DataSource = null;
            this.cbostRepresentaFaturamento.DisplayMember = "DisplayMember";
            this.cbostRepresentaFaturamento.Location = new System.Drawing.Point(66, 108);
            this.cbostRepresentaFaturamento.Margin = new System.Windows.Forms.Padding(66, 3, 15, 3);
            this.cbostRepresentaFaturamento.Name = "cbostRepresentaFaturamento";
            this.cbostRepresentaFaturamento.objConfigComponenteModel = null;
            this.cbostRepresentaFaturamento.SelectedIndex = -1;
            this.cbostRepresentaFaturamento.SelectedValue = 0;
            this.cbostRepresentaFaturamento.Size = new System.Drawing.Size(217, 21);
            this.cbostRepresentaFaturamento.TabIndex = 6;
            this.cbostRepresentaFaturamento.ValueMember = "ValueMember";
            // 
            // cbostGeraFinanceiro
            // 
            this.cbostGeraFinanceiro._Field = "stGeraFinanceiro";
            this.cbostGeraFinanceiro._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostGeraFinanceiro._Itens")));
            this.cbostGeraFinanceiro._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cbostGeraFinanceiro._LabelText = "Gera compromisso financeiro?";
            this.cbostGeraFinanceiro._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostGeraFinanceiro._Regex = null;
            this.cbostGeraFinanceiro._situacao = true;
            this.cbostGeraFinanceiro._Table = "Tipo_operacao";
            this.cbostGeraFinanceiro._TamanhoComponente = 80;
            this.cbostGeraFinanceiro._TamanhoMaiorLabel = 200;
            this.cbostGeraFinanceiro._Visible = true;
            this.cbostGeraFinanceiro.BackColor = System.Drawing.Color.Transparent;
            this.cbostGeraFinanceiro.Base = null;
            this.cbostGeraFinanceiro.Color = System.Drawing.Color.White;
            this.cbostGeraFinanceiro.DataSource = null;
            this.cbostGeraFinanceiro.DisplayMember = "DisplayMember";
            this.cbostGeraFinanceiro.Location = new System.Drawing.Point(41, 135);
            this.cbostGeraFinanceiro.Margin = new System.Windows.Forms.Padding(41, 3, 15, 3);
            this.cbostGeraFinanceiro.Name = "cbostGeraFinanceiro";
            this.cbostGeraFinanceiro.objConfigComponenteModel = null;
            this.cbostGeraFinanceiro.SelectedIndex = -1;
            this.cbostGeraFinanceiro.SelectedValue = 0;
            this.cbostGeraFinanceiro.Size = new System.Drawing.Size(242, 21);
            this.cbostGeraFinanceiro.TabIndex = 7;
            this.cbostGeraFinanceiro.ValueMember = "ValueMember";
            // 
            // cbostGeraComissao
            // 
            this.cbostGeraComissao._Field = "stGeraComissao";
            this.cbostGeraComissao._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostGeraComissao._Itens")));
            this.cbostGeraComissao._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cbostGeraComissao._LabelText = "Gera comissão de representante?";
            this.cbostGeraComissao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostGeraComissao._Regex = null;
            this.cbostGeraComissao._situacao = true;
            this.cbostGeraComissao._Table = "Tipo_operacao";
            this.cbostGeraComissao._TamanhoComponente = 80;
            this.cbostGeraComissao._TamanhoMaiorLabel = 200;
            this.cbostGeraComissao._Visible = true;
            this.cbostGeraComissao.BackColor = System.Drawing.Color.Transparent;
            this.cbostGeraComissao.Base = null;
            this.cbostGeraComissao.Color = System.Drawing.Color.White;
            this.cbostGeraComissao.DataSource = null;
            this.cbostGeraComissao.DisplayMember = "DisplayMember";
            this.cbostGeraComissao.Location = new System.Drawing.Point(26, 162);
            this.cbostGeraComissao.Margin = new System.Windows.Forms.Padding(26, 3, 15, 3);
            this.cbostGeraComissao.Name = "cbostGeraComissao";
            this.cbostGeraComissao.objConfigComponenteModel = null;
            this.cbostGeraComissao.SelectedIndex = -1;
            this.cbostGeraComissao.SelectedValue = 0;
            this.cbostGeraComissao.Size = new System.Drawing.Size(257, 21);
            this.cbostGeraComissao.TabIndex = 8;
            this.cbostGeraComissao.ValueMember = "ValueMember";
            // 
            // cbostServico
            // 
            this.cbostServico._Field = "stServico";
            this.cbostServico._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostServico._Itens")));
            this.cbostServico._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cbostServico._LabelText = "É serviço?";
            this.cbostServico._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostServico._Regex = null;
            this.cbostServico._situacao = true;
            this.cbostServico._Table = "Tipo_operacao";
            this.cbostServico._TamanhoComponente = 80;
            this.cbostServico._TamanhoMaiorLabel = 200;
            this.cbostServico._Visible = true;
            this.cbostServico.BackColor = System.Drawing.Color.Transparent;
            this.cbostServico.Base = null;
            this.cbostServico.Color = System.Drawing.Color.White;
            this.cbostServico.DataSource = null;
            this.cbostServico.DisplayMember = "DisplayMember";
            this.cbostServico.Location = new System.Drawing.Point(147, 189);
            this.cbostServico.Margin = new System.Windows.Forms.Padding(147, 3, 15, 3);
            this.cbostServico.Name = "cbostServico";
            this.cbostServico.objConfigComponenteModel = null;
            this.cbostServico.SelectedIndex = -1;
            this.cbostServico.SelectedValue = 0;
            this.cbostServico.Size = new System.Drawing.Size(136, 21);
            this.cbostServico.TabIndex = 9;
            this.cbostServico.ValueMember = "ValueMember";
            // 
            // cbostOrigemMercadoria
            // 
            this.cbostOrigemMercadoria._Field = "stOrigemMercadoria";
            this.cbostOrigemMercadoria._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostOrigemMercadoria._Itens")));
            this.cbostOrigemMercadoria._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cbostOrigemMercadoria._LabelText = "Origem da mercadoria";
            this.cbostOrigemMercadoria._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostOrigemMercadoria._Regex = null;
            this.cbostOrigemMercadoria._situacao = false;
            this.cbostOrigemMercadoria._Table = "Tipo_operacao";
            this.cbostOrigemMercadoria._TamanhoComponente = 338;
            this.cbostOrigemMercadoria._TamanhoMaiorLabel = 200;
            this.cbostOrigemMercadoria._Visible = true;
            this.cbostOrigemMercadoria.BackColor = System.Drawing.Color.Transparent;
            this.cbostOrigemMercadoria.Base = null;
            this.cbostOrigemMercadoria.Color = System.Drawing.Color.White;
            this.cbostOrigemMercadoria.DataSource = null;
            this.cbostOrigemMercadoria.DisplayMember = "DisplayMember";
            this.cbostOrigemMercadoria.Location = new System.Drawing.Point(82, 216);
            this.cbostOrigemMercadoria.Margin = new System.Windows.Forms.Padding(82, 3, 15, 3);
            this.cbostOrigemMercadoria.Name = "cbostOrigemMercadoria";
            this.cbostOrigemMercadoria.objConfigComponenteModel = null;
            this.cbostOrigemMercadoria.SelectedIndex = -1;
            this.cbostOrigemMercadoria.SelectedValue = 0;
            this.cbostOrigemMercadoria.Size = new System.Drawing.Size(459, 21);
            this.cbostOrigemMercadoria.TabIndex = 17;
            this.cbostOrigemMercadoria.ValueMember = "ValueMember";
            // 
            // cbostEstoque
            // 
            this.cbostEstoque._Field = "stEstoque";
            this.cbostEstoque._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostEstoque._Itens")));
            this.cbostEstoque._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cbostEstoque._LabelText = "Movimenta estoque próprio?";
            this.cbostEstoque._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostEstoque._Regex = null;
            this.cbostEstoque._situacao = false;
            this.cbostEstoque._Table = "Tipo_operacao";
            this.cbostEstoque._TamanhoComponente = 139;
            this.cbostEstoque._TamanhoMaiorLabel = 200;
            this.cbostEstoque._Visible = true;
            this.cbostEstoque.BackColor = System.Drawing.Color.Transparent;
            this.cbostEstoque.Base = null;
            this.cbostEstoque.Color = System.Drawing.Color.White;
            this.cbostEstoque.DataSource = null;
            this.cbostEstoque.DisplayMember = "DisplayMember";
            this.cbostEstoque.Location = new System.Drawing.Point(47, 243);
            this.cbostEstoque.Margin = new System.Windows.Forms.Padding(47, 3, 15, 3);
            this.cbostEstoque.Name = "cbostEstoque";
            this.cbostEstoque.objConfigComponenteModel = null;
            this.cbostEstoque.SelectedIndex = -1;
            this.cbostEstoque.SelectedValue = 0;
            this.cbostEstoque.Size = new System.Drawing.Size(295, 21);
            this.cbostEstoque.TabIndex = 10;
            this.cbostEstoque.ValueMember = "ValueMember";
            // 
            // cbostEstoqueClientes
            // 
            this.cbostEstoqueClientes._Field = "stEstoqueClientes";
            this.cbostEstoqueClientes._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostEstoqueClientes._Itens")));
            this.cbostEstoqueClientes._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cbostEstoqueClientes._LabelText = "Movimenta estoque de clientes?";
            this.cbostEstoqueClientes._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostEstoqueClientes._Regex = null;
            this.cbostEstoqueClientes._situacao = false;
            this.cbostEstoqueClientes._Table = "Tipo_operacao";
            this.cbostEstoqueClientes._TamanhoComponente = 139;
            this.cbostEstoqueClientes._TamanhoMaiorLabel = 200;
            this.cbostEstoqueClientes._Visible = true;
            this.cbostEstoqueClientes.BackColor = System.Drawing.Color.Transparent;
            this.cbostEstoqueClientes.Base = null;
            this.cbostEstoqueClientes.Color = System.Drawing.Color.White;
            this.cbostEstoqueClientes.DataSource = null;
            this.cbostEstoqueClientes.DisplayMember = "DisplayMember";
            this.cbostEstoqueClientes.Location = new System.Drawing.Point(31, 270);
            this.cbostEstoqueClientes.Margin = new System.Windows.Forms.Padding(31, 3, 15, 3);
            this.cbostEstoqueClientes.Name = "cbostEstoqueClientes";
            this.cbostEstoqueClientes.objConfigComponenteModel = null;
            this.cbostEstoqueClientes.SelectedIndex = -1;
            this.cbostEstoqueClientes.SelectedValue = 0;
            this.cbostEstoqueClientes.Size = new System.Drawing.Size(311, 21);
            this.cbostEstoqueClientes.TabIndex = 11;
            this.cbostEstoqueClientes.ValueMember = "ValueMember";
            // 
            // cbostEstoqueFornecedores
            // 
            this.cbostEstoqueFornecedores._Field = "stEstoqueFornecedores";
            this.cbostEstoqueFornecedores._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostEstoqueFornecedores._Itens")));
            this.cbostEstoqueFornecedores._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cbostEstoqueFornecedores._LabelText = "Movimenta estoque de fornecedores?";
            this.cbostEstoqueFornecedores._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostEstoqueFornecedores._Regex = null;
            this.cbostEstoqueFornecedores._situacao = false;
            this.cbostEstoqueFornecedores._Table = "Tipo_operacao";
            this.cbostEstoqueFornecedores._TamanhoComponente = 139;
            this.cbostEstoqueFornecedores._TamanhoMaiorLabel = 200;
            this.cbostEstoqueFornecedores._Visible = true;
            this.cbostEstoqueFornecedores.BackColor = System.Drawing.Color.Transparent;
            this.cbostEstoqueFornecedores.Base = null;
            this.cbostEstoqueFornecedores.Color = System.Drawing.Color.White;
            this.cbostEstoqueFornecedores.DataSource = null;
            this.cbostEstoqueFornecedores.DisplayMember = "DisplayMember";
            this.cbostEstoqueFornecedores.Location = new System.Drawing.Point(2, 297);
            this.cbostEstoqueFornecedores.Margin = new System.Windows.Forms.Padding(2, 3, 15, 3);
            this.cbostEstoqueFornecedores.Name = "cbostEstoqueFornecedores";
            this.cbostEstoqueFornecedores.objConfigComponenteModel = null;
            this.cbostEstoqueFornecedores.SelectedIndex = -1;
            this.cbostEstoqueFornecedores.SelectedValue = 0;
            this.cbostEstoqueFornecedores.Size = new System.Drawing.Size(340, 21);
            this.cbostEstoqueFornecedores.TabIndex = 12;
            this.cbostEstoqueFornecedores.ValueMember = "ValueMember";
            // 
            // cbostEntregaFutura
            // 
            this.cbostEntregaFutura._Field = "stEntregaFutura";
            this.cbostEntregaFutura._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostEntregaFutura._Itens")));
            this.cbostEntregaFutura._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cbostEntregaFutura._LabelText = "É entrega futura?";
            this.cbostEntregaFutura._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostEntregaFutura._Regex = null;
            this.cbostEntregaFutura._situacao = true;
            this.cbostEntregaFutura._Table = "Tipo_operacao";
            this.cbostEntregaFutura._TamanhoComponente = 80;
            this.cbostEntregaFutura._TamanhoMaiorLabel = 200;
            this.cbostEntregaFutura._Visible = true;
            this.cbostEntregaFutura.BackColor = System.Drawing.Color.Transparent;
            this.cbostEntregaFutura.Base = null;
            this.cbostEntregaFutura.Color = System.Drawing.Color.White;
            this.cbostEntregaFutura.DataSource = null;
            this.cbostEntregaFutura.DisplayMember = "DisplayMember";
            this.cbostEntregaFutura.Location = new System.Drawing.Point(107, 324);
            this.cbostEntregaFutura.Margin = new System.Windows.Forms.Padding(107, 3, 15, 3);
            this.cbostEntregaFutura.Name = "cbostEntregaFutura";
            this.cbostEntregaFutura.objConfigComponenteModel = null;
            this.cbostEntregaFutura.SelectedIndex = -1;
            this.cbostEntregaFutura.SelectedValue = 0;
            this.cbostEntregaFutura.Size = new System.Drawing.Size(176, 21);
            this.cbostEntregaFutura.TabIndex = 13;
            this.cbostEntregaFutura.ValueMember = "ValueMember";
            // 
            // cbostTpIndustrializacao
            // 
            this.cbostTpIndustrializacao._Field = "stTipoIndustrializacao";
            this.cbostTpIndustrializacao._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostTpIndustrializacao._Itens")));
            this.cbostTpIndustrializacao._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cbostTpIndustrializacao._LabelText = "Tipo de industrialização";
            this.cbostTpIndustrializacao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostTpIndustrializacao._Regex = null;
            this.cbostTpIndustrializacao._situacao = false;
            this.cbostTpIndustrializacao._Table = "Tipo_operacao";
            this.cbostTpIndustrializacao._TamanhoComponente = 101;
            this.cbostTpIndustrializacao._TamanhoMaiorLabel = 200;
            this.cbostTpIndustrializacao._Visible = true;
            this.cbostTpIndustrializacao.BackColor = System.Drawing.Color.Transparent;
            this.cbostTpIndustrializacao.Base = null;
            this.cbostTpIndustrializacao.Color = System.Drawing.Color.White;
            this.cbostTpIndustrializacao.DataSource = null;
            this.cbostTpIndustrializacao.DisplayMember = "DisplayMember";
            this.cbostTpIndustrializacao.Location = new System.Drawing.Point(74, 351);
            this.cbostTpIndustrializacao.Margin = new System.Windows.Forms.Padding(74, 3, 15, 3);
            this.cbostTpIndustrializacao.Name = "cbostTpIndustrializacao";
            this.cbostTpIndustrializacao.objConfigComponenteModel = null;
            this.cbostTpIndustrializacao.SelectedIndex = -1;
            this.cbostTpIndustrializacao.SelectedValue = 0;
            this.cbostTpIndustrializacao.Size = new System.Drawing.Size(230, 21);
            this.cbostTpIndustrializacao.TabIndex = 14;
            this.cbostTpIndustrializacao.ValueMember = "ValueMember";
            // 
            // hlP_PesquisacCfopNaUf
            // 
            this.hlP_PesquisacCfopNaUf._Field = "cCfopNaUf";
            this.hlP_PesquisacCfopNaUf._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.hlP_PesquisacCfopNaUf._LabelText = "Cfop dentro do uf";
            this.hlP_PesquisacCfopNaUf._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisacCfopNaUf._ListaCamposDisplay")));
            this.hlP_PesquisacCfopNaUf._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisacCfopNaUf._ListaValoresDisplay")));
            this.hlP_PesquisacCfopNaUf._NomeCampoPK = "ID";
            this.hlP_PesquisacCfopNaUf._NomeFormCadastroOriginal = "FormCfop";
            this.hlP_PesquisacCfopNaUf._NomeView = "vwCfop";
            this.hlP_PesquisacCfopNaUf._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisacCfopNaUf._Regex = null;
            this.hlP_PesquisacCfopNaUf._Table = "Tipo_operacao";
            this.hlP_PesquisacCfopNaUf._TamanhoComponente = 300;
            this.hlP_PesquisacCfopNaUf._TamanhoMaiorLabel = 200;
            this.hlP_PesquisacCfopNaUf._Vinculado = false;
            this.hlP_PesquisacCfopNaUf._Visible = true;
            this.hlP_PesquisacCfopNaUf.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisacCfopNaUf.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisacCfopNaUf.Base = null;
            this.hlP_PesquisacCfopNaUf.Location = new System.Drawing.Point(102, 378);
            this.hlP_PesquisacCfopNaUf.Margin = new System.Windows.Forms.Padding(102, 3, 15, 3);
            this.hlP_PesquisacCfopNaUf.Name = "hlP_PesquisacCfopNaUf";
            this.hlP_PesquisacCfopNaUf.objConfigComponenteModel = null;
            this.hlP_PesquisacCfopNaUf.ReadOnly = false;
            this.hlP_PesquisacCfopNaUf.Size = new System.Drawing.Size(401, 21);
            this.hlP_PesquisacCfopNaUf.TabIndex = 15;
            this.hlP_PesquisacCfopNaUf.Value = 0;
            // 
            // hlP_PesquisacCfopOutraUf
            // 
            this.hlP_PesquisacCfopOutraUf._Field = "cCfopOutraUf";
            this.hlP_PesquisacCfopOutraUf._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.hlP_PesquisacCfopOutraUf._LabelText = "Cfop fora do uf";
            this.hlP_PesquisacCfopOutraUf._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisacCfopOutraUf._ListaCamposDisplay")));
            this.hlP_PesquisacCfopOutraUf._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisacCfopOutraUf._ListaValoresDisplay")));
            this.hlP_PesquisacCfopOutraUf._NomeCampoPK = "ID";
            this.hlP_PesquisacCfopOutraUf._NomeFormCadastroOriginal = "FormCfop";
            this.hlP_PesquisacCfopOutraUf._NomeView = "vwCfop";
            this.hlP_PesquisacCfopOutraUf._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisacCfopOutraUf._Regex = null;
            this.hlP_PesquisacCfopOutraUf._Table = "Tipo_operacao";
            this.hlP_PesquisacCfopOutraUf._TamanhoComponente = 300;
            this.hlP_PesquisacCfopOutraUf._TamanhoMaiorLabel = 200;
            this.hlP_PesquisacCfopOutraUf._Vinculado = false;
            this.hlP_PesquisacCfopOutraUf._Visible = true;
            this.hlP_PesquisacCfopOutraUf.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisacCfopOutraUf.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisacCfopOutraUf.Base = null;
            this.hlP_PesquisacCfopOutraUf.Location = new System.Drawing.Point(116, 405);
            this.hlP_PesquisacCfopOutraUf.Margin = new System.Windows.Forms.Padding(116, 3, 15, 3);
            this.hlP_PesquisacCfopOutraUf.Name = "hlP_PesquisacCfopOutraUf";
            this.hlP_PesquisacCfopOutraUf.objConfigComponenteModel = null;
            this.hlP_PesquisacCfopOutraUf.ReadOnly = false;
            this.hlP_PesquisacCfopOutraUf.Size = new System.Drawing.Size(387, 21);
            this.hlP_PesquisacCfopOutraUf.TabIndex = 15;
            this.hlP_PesquisacCfopOutraUf.Value = 0;
            // 
            // hlP_PesquisacCfopNcontribuinte
            // 
            this.hlP_PesquisacCfopNcontribuinte._Field = "cCfopNaoContribuinte";
            this.hlP_PesquisacCfopNcontribuinte._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.hlP_PesquisacCfopNcontribuinte._LabelText = "Cfop para não contribuinte";
            this.hlP_PesquisacCfopNcontribuinte._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisacCfopNcontribuinte._ListaCamposDisplay")));
            this.hlP_PesquisacCfopNcontribuinte._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisacCfopNcontribuinte._ListaValoresDisplay")));
            this.hlP_PesquisacCfopNcontribuinte._NomeCampoPK = "ID";
            this.hlP_PesquisacCfopNcontribuinte._NomeFormCadastroOriginal = "FormCfop";
            this.hlP_PesquisacCfopNcontribuinte._NomeView = "vwCfop";
            this.hlP_PesquisacCfopNcontribuinte._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisacCfopNcontribuinte._Regex = null;
            this.hlP_PesquisacCfopNcontribuinte._Table = "Tipo_operacao";
            this.hlP_PesquisacCfopNcontribuinte._TamanhoComponente = 300;
            this.hlP_PesquisacCfopNcontribuinte._TamanhoMaiorLabel = 200;
            this.hlP_PesquisacCfopNcontribuinte._Vinculado = false;
            this.hlP_PesquisacCfopNcontribuinte._Visible = true;
            this.hlP_PesquisacCfopNcontribuinte.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisacCfopNcontribuinte.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisacCfopNcontribuinte.Base = null;
            this.hlP_PesquisacCfopNcontribuinte.Location = new System.Drawing.Point(55, 432);
            this.hlP_PesquisacCfopNcontribuinte.Margin = new System.Windows.Forms.Padding(55, 3, 15, 3);
            this.hlP_PesquisacCfopNcontribuinte.Name = "hlP_PesquisacCfopNcontribuinte";
            this.hlP_PesquisacCfopNcontribuinte.objConfigComponenteModel = null;
            this.hlP_PesquisacCfopNcontribuinte.ReadOnly = false;
            this.hlP_PesquisacCfopNcontribuinte.Size = new System.Drawing.Size(448, 21);
            this.hlP_PesquisacCfopNcontribuinte.TabIndex = 15;
            this.hlP_PesquisacCfopNcontribuinte.Value = 0;
            // 
            // cboAtivo
            // 
            this.cboAtivo._Field = "Ativo";
            this.cboAtivo._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cboAtivo._Itens")));
            this.cboAtivo._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cboAtivo._LabelText = "Cadastro ativo?";
            this.cboAtivo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cboAtivo._Regex = null;
            this.cboAtivo._situacao = true;
            this.cboAtivo._Table = "Tipo_operacao";
            this.cboAtivo._TamanhoComponente = 80;
            this.cboAtivo._TamanhoMaiorLabel = 200;
            this.cboAtivo._Visible = true;
            this.cboAtivo.BackColor = System.Drawing.Color.Transparent;
            this.cboAtivo.Base = null;
            this.cboAtivo.Color = System.Drawing.Color.White;
            this.cboAtivo.DataSource = null;
            this.cboAtivo.DisplayMember = "DisplayMember";
            this.cboAtivo.Location = new System.Drawing.Point(117, 459);
            this.cboAtivo.Margin = new System.Windows.Forms.Padding(117, 3, 15, 3);
            this.cboAtivo.Name = "cboAtivo";
            this.cboAtivo.objConfigComponenteModel = null;
            this.cboAtivo.SelectedIndex = -1;
            this.cboAtivo.SelectedValue = 0;
            this.cboAtivo.Size = new System.Drawing.Size(166, 21);
            this.cboAtivo.TabIndex = 16;
            this.cboAtivo.ValueMember = "ValueMember";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage2.Controls.Add(this.kryptonPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1346, 569);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Tag = false;
            this.tabPage2.Text = "Entradas";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.BorderWidth = 0;
            this.kryptonPanel2.Controls.Add(this.flowLayoutPanel2);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.kryptonPanel2.GradientToogleColors = false;
            this.kryptonPanel2.GradientUseBlend = false;
            this.kryptonPanel2.GradientUseSolid = true;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.PersistentColors = false;
            this.kryptonPanel2.Size = new System.Drawing.Size(1346, 569);
            this.kryptonPanel2.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.hlP_LabelSeparator_entrada);
            this.flowLayoutPanel2.Controls.Add(this.cbostRelacaoRecebimentoInspecao);
            this.flowLayoutPanel2.Controls.Add(this.cbostCalcCustoEntrada);
            this.flowLayoutPanel2.Controls.Add(this.cbostDescontaCredicmsCusto);
            this.flowLayoutPanel2.Controls.Add(this.cbostDescontaCredsubstCusto);
            this.flowLayoutPanel2.Controls.Add(this.cbostDescontaCredipiCusto);
            this.flowLayoutPanel2.Controls.Add(this.cbostDescontaCredpiscofinsCusto);
            this.flowLayoutPanel2.Controls.Add(this.cbostDescontaDifIcmsCusto);
            this.flowLayoutPanel2.Controls.Add(this.cbostObrigaOpNaCompra);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1346, 569);
            this.flowLayoutPanel2.TabIndex = 1;
            this.flowLayoutPanel2.Tag = "Entradas";
            // 
            // hlP_LabelSeparator_entrada
            // 
            this.hlP_LabelSeparator_entrada._LabelText = "Parametro de entrada";
            this.hlP_LabelSeparator_entrada._TamanhoMaiorLabel = 0;
            this.hlP_LabelSeparator_entrada.BackColor = System.Drawing.Color.Transparent;
            this.hlP_LabelSeparator_entrada.Location = new System.Drawing.Point(0, 3);
            this.hlP_LabelSeparator_entrada.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.hlP_LabelSeparator_entrada.Name = "hlP_LabelSeparator_entrada";
            this.hlP_LabelSeparator_entrada.Size = new System.Drawing.Size(540, 18);
            this.hlP_LabelSeparator_entrada.TabIndex = 29;
            this.hlP_LabelSeparator_entrada.TabStop = false;
            // 
            // cbostRelacaoRecebimentoInspecao
            // 
            this.cbostRelacaoRecebimentoInspecao._Field = "stRelacaoRecebimentoInspecao";
            this.cbostRelacaoRecebimentoInspecao._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostRelacaoRecebimentoInspecao._Itens")));
            this.cbostRelacaoRecebimentoInspecao._LabelGroup = this.hlP_LabelSeparator_entrada;
            this.cbostRelacaoRecebimentoInspecao._LabelText = "Relação do recebimento com inspeção de qualidade";
            this.cbostRelacaoRecebimentoInspecao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostRelacaoRecebimentoInspecao._Regex = null;
            this.cbostRelacaoRecebimentoInspecao._situacao = false;
            this.cbostRelacaoRecebimentoInspecao._Table = "Tipo_operacao";
            this.cbostRelacaoRecebimentoInspecao._TamanhoComponente = 137;
            this.cbostRelacaoRecebimentoInspecao._TamanhoMaiorLabel = 400;
            this.cbostRelacaoRecebimentoInspecao._Visible = true;
            this.cbostRelacaoRecebimentoInspecao.BackColor = System.Drawing.Color.Transparent;
            this.cbostRelacaoRecebimentoInspecao.Base = null;
            this.cbostRelacaoRecebimentoInspecao.Color = System.Drawing.Color.White;
            this.cbostRelacaoRecebimentoInspecao.DataSource = null;
            this.cbostRelacaoRecebimentoInspecao.DisplayMember = "DisplayMember";
            this.cbostRelacaoRecebimentoInspecao.Location = new System.Drawing.Point(128, 27);
            this.cbostRelacaoRecebimentoInspecao.Margin = new System.Windows.Forms.Padding(128, 3, 15, 3);
            this.cbostRelacaoRecebimentoInspecao.Name = "cbostRelacaoRecebimentoInspecao";
            this.cbostRelacaoRecebimentoInspecao.objConfigComponenteModel = null;
            this.cbostRelacaoRecebimentoInspecao.SelectedIndex = -1;
            this.cbostRelacaoRecebimentoInspecao.SelectedValue = 0;
            this.cbostRelacaoRecebimentoInspecao.Size = new System.Drawing.Size(412, 21);
            this.cbostRelacaoRecebimentoInspecao.TabIndex = 4;
            this.cbostRelacaoRecebimentoInspecao.ValueMember = "ValueMember";
            // 
            // cbostCalcCustoEntrada
            // 
            this.cbostCalcCustoEntrada._Field = "stCalculaCustoEntrada";
            this.cbostCalcCustoEntrada._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostCalcCustoEntrada._Itens")));
            this.cbostCalcCustoEntrada._LabelGroup = this.hlP_LabelSeparator_entrada;
            this.cbostCalcCustoEntrada._LabelText = "Calcula o custo final no recebimento?";
            this.cbostCalcCustoEntrada._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostCalcCustoEntrada._Regex = null;
            this.cbostCalcCustoEntrada._situacao = true;
            this.cbostCalcCustoEntrada._Table = "Tipo_operacao";
            this.cbostCalcCustoEntrada._TamanhoComponente = 80;
            this.cbostCalcCustoEntrada._TamanhoMaiorLabel = 400;
            this.cbostCalcCustoEntrada._Visible = true;
            this.cbostCalcCustoEntrada.BackColor = System.Drawing.Color.Transparent;
            this.cbostCalcCustoEntrada.Base = null;
            this.cbostCalcCustoEntrada.Color = System.Drawing.Color.White;
            this.cbostCalcCustoEntrada.DataSource = null;
            this.cbostCalcCustoEntrada.DisplayMember = "DisplayMember";
            this.cbostCalcCustoEntrada.Location = new System.Drawing.Point(203, 54);
            this.cbostCalcCustoEntrada.Margin = new System.Windows.Forms.Padding(203, 3, 15, 3);
            this.cbostCalcCustoEntrada.Name = "cbostCalcCustoEntrada";
            this.cbostCalcCustoEntrada.objConfigComponenteModel = null;
            this.cbostCalcCustoEntrada.SelectedIndex = -1;
            this.cbostCalcCustoEntrada.SelectedValue = 0;
            this.cbostCalcCustoEntrada.Size = new System.Drawing.Size(280, 21);
            this.cbostCalcCustoEntrada.TabIndex = 7;
            this.cbostCalcCustoEntrada.ValueMember = "ValueMember";
            // 
            // cbostDescontaCredicmsCusto
            // 
            this.cbostDescontaCredicmsCusto._Field = "stDescontaCreditoIcmsCusto";
            this.cbostDescontaCredicmsCusto._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostDescontaCredicmsCusto._Itens")));
            this.cbostDescontaCredicmsCusto._LabelGroup = this.hlP_LabelSeparator_entrada;
            this.cbostDescontaCredicmsCusto._LabelText = "Desconta o crédito de icms na formação de custo final?";
            this.cbostDescontaCredicmsCusto._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostDescontaCredicmsCusto._Regex = null;
            this.cbostDescontaCredicmsCusto._situacao = true;
            this.cbostDescontaCredicmsCusto._Table = "Tipo_operacao";
            this.cbostDescontaCredicmsCusto._TamanhoComponente = 80;
            this.cbostDescontaCredicmsCusto._TamanhoMaiorLabel = 400;
            this.cbostDescontaCredicmsCusto._Visible = true;
            this.cbostDescontaCredicmsCusto.BackColor = System.Drawing.Color.Transparent;
            this.cbostDescontaCredicmsCusto.Base = null;
            this.cbostDescontaCredicmsCusto.Color = System.Drawing.Color.White;
            this.cbostDescontaCredicmsCusto.DataSource = null;
            this.cbostDescontaCredicmsCusto.DisplayMember = "DisplayMember";
            this.cbostDescontaCredicmsCusto.Location = new System.Drawing.Point(113, 81);
            this.cbostDescontaCredicmsCusto.Margin = new System.Windows.Forms.Padding(113, 3, 15, 3);
            this.cbostDescontaCredicmsCusto.Name = "cbostDescontaCredicmsCusto";
            this.cbostDescontaCredicmsCusto.objConfigComponenteModel = null;
            this.cbostDescontaCredicmsCusto.SelectedIndex = -1;
            this.cbostDescontaCredicmsCusto.SelectedValue = 0;
            this.cbostDescontaCredicmsCusto.Size = new System.Drawing.Size(370, 21);
            this.cbostDescontaCredicmsCusto.TabIndex = 8;
            this.cbostDescontaCredicmsCusto.ValueMember = "ValueMember";
            // 
            // cbostDescontaCredsubstCusto
            // 
            this.cbostDescontaCredsubstCusto._Field = "stDescontaCreditoSubstituicaoTributariaCusto";
            this.cbostDescontaCredsubstCusto._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostDescontaCredsubstCusto._Itens")));
            this.cbostDescontaCredsubstCusto._LabelGroup = this.hlP_LabelSeparator_entrada;
            this.cbostDescontaCredsubstCusto._LabelText = "Desconta o crédito de subst. tributária de icms na formação de custo final?";
            this.cbostDescontaCredsubstCusto._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostDescontaCredsubstCusto._Regex = null;
            this.cbostDescontaCredsubstCusto._situacao = true;
            this.cbostDescontaCredsubstCusto._Table = "Tipo_operacao";
            this.cbostDescontaCredsubstCusto._TamanhoComponente = 80;
            this.cbostDescontaCredsubstCusto._TamanhoMaiorLabel = 400;
            this.cbostDescontaCredsubstCusto._Visible = true;
            this.cbostDescontaCredsubstCusto.BackColor = System.Drawing.Color.Transparent;
            this.cbostDescontaCredsubstCusto.Base = null;
            this.cbostDescontaCredsubstCusto.Color = System.Drawing.Color.White;
            this.cbostDescontaCredsubstCusto.DataSource = null;
            this.cbostDescontaCredsubstCusto.DisplayMember = "DisplayMember";
            this.cbostDescontaCredsubstCusto.Location = new System.Drawing.Point(12, 108);
            this.cbostDescontaCredsubstCusto.Margin = new System.Windows.Forms.Padding(12, 3, 15, 3);
            this.cbostDescontaCredsubstCusto.Name = "cbostDescontaCredsubstCusto";
            this.cbostDescontaCredsubstCusto.objConfigComponenteModel = null;
            this.cbostDescontaCredsubstCusto.SelectedIndex = -1;
            this.cbostDescontaCredsubstCusto.SelectedValue = 0;
            this.cbostDescontaCredsubstCusto.Size = new System.Drawing.Size(471, 21);
            this.cbostDescontaCredsubstCusto.TabIndex = 9;
            this.cbostDescontaCredsubstCusto.ValueMember = "ValueMember";
            // 
            // cbostDescontaCredipiCusto
            // 
            this.cbostDescontaCredipiCusto._Field = "stDescontaCreditoIpiCusto";
            this.cbostDescontaCredipiCusto._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostDescontaCredipiCusto._Itens")));
            this.cbostDescontaCredipiCusto._LabelGroup = this.hlP_LabelSeparator_entrada;
            this.cbostDescontaCredipiCusto._LabelText = "Desconta o crédito de ipi na formação de custo final?";
            this.cbostDescontaCredipiCusto._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostDescontaCredipiCusto._Regex = null;
            this.cbostDescontaCredipiCusto._situacao = true;
            this.cbostDescontaCredipiCusto._Table = "Tipo_operacao";
            this.cbostDescontaCredipiCusto._TamanhoComponente = 80;
            this.cbostDescontaCredipiCusto._TamanhoMaiorLabel = 400;
            this.cbostDescontaCredipiCusto._Visible = true;
            this.cbostDescontaCredipiCusto.BackColor = System.Drawing.Color.Transparent;
            this.cbostDescontaCredipiCusto.Base = null;
            this.cbostDescontaCredipiCusto.Color = System.Drawing.Color.White;
            this.cbostDescontaCredipiCusto.DataSource = null;
            this.cbostDescontaCredipiCusto.DisplayMember = "DisplayMember";
            this.cbostDescontaCredipiCusto.Location = new System.Drawing.Point(122, 135);
            this.cbostDescontaCredipiCusto.Margin = new System.Windows.Forms.Padding(122, 3, 15, 3);
            this.cbostDescontaCredipiCusto.Name = "cbostDescontaCredipiCusto";
            this.cbostDescontaCredipiCusto.objConfigComponenteModel = null;
            this.cbostDescontaCredipiCusto.SelectedIndex = -1;
            this.cbostDescontaCredipiCusto.SelectedValue = 0;
            this.cbostDescontaCredipiCusto.Size = new System.Drawing.Size(361, 21);
            this.cbostDescontaCredipiCusto.TabIndex = 10;
            this.cbostDescontaCredipiCusto.ValueMember = "ValueMember";
            // 
            // cbostDescontaCredpiscofinsCusto
            // 
            this.cbostDescontaCredpiscofinsCusto._Field = "stDescontaCreditoPiscofinsCusto";
            this.cbostDescontaCredpiscofinsCusto._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostDescontaCredpiscofinsCusto._Itens")));
            this.cbostDescontaCredpiscofinsCusto._LabelGroup = this.hlP_LabelSeparator_entrada;
            this.cbostDescontaCredpiscofinsCusto._LabelText = "Desconta o crédito de pis/cofins na formação de custo final?";
            this.cbostDescontaCredpiscofinsCusto._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostDescontaCredpiscofinsCusto._Regex = null;
            this.cbostDescontaCredpiscofinsCusto._situacao = true;
            this.cbostDescontaCredpiscofinsCusto._Table = "Tipo_operacao";
            this.cbostDescontaCredpiscofinsCusto._TamanhoComponente = 80;
            this.cbostDescontaCredpiscofinsCusto._TamanhoMaiorLabel = 400;
            this.cbostDescontaCredpiscofinsCusto._Visible = true;
            this.cbostDescontaCredpiscofinsCusto.BackColor = System.Drawing.Color.Transparent;
            this.cbostDescontaCredpiscofinsCusto.Base = null;
            this.cbostDescontaCredpiscofinsCusto.Color = System.Drawing.Color.White;
            this.cbostDescontaCredpiscofinsCusto.DataSource = null;
            this.cbostDescontaCredpiscofinsCusto.DisplayMember = "DisplayMember";
            this.cbostDescontaCredpiscofinsCusto.Location = new System.Drawing.Point(85, 162);
            this.cbostDescontaCredpiscofinsCusto.Margin = new System.Windows.Forms.Padding(85, 3, 15, 3);
            this.cbostDescontaCredpiscofinsCusto.Name = "cbostDescontaCredpiscofinsCusto";
            this.cbostDescontaCredpiscofinsCusto.objConfigComponenteModel = null;
            this.cbostDescontaCredpiscofinsCusto.SelectedIndex = -1;
            this.cbostDescontaCredpiscofinsCusto.SelectedValue = 0;
            this.cbostDescontaCredpiscofinsCusto.Size = new System.Drawing.Size(398, 21);
            this.cbostDescontaCredpiscofinsCusto.TabIndex = 11;
            this.cbostDescontaCredpiscofinsCusto.ValueMember = "ValueMember";
            // 
            // cbostDescontaDifIcmsCusto
            // 
            this.cbostDescontaDifIcmsCusto._Field = "stDescontaDiferencialIcmsCusto";
            this.cbostDescontaDifIcmsCusto._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostDescontaDifIcmsCusto._Itens")));
            this.cbostDescontaDifIcmsCusto._LabelGroup = this.hlP_LabelSeparator_entrada;
            this.cbostDescontaDifIcmsCusto._LabelText = "Desconta o custo da diferença de icms  na formação de custo final?";
            this.cbostDescontaDifIcmsCusto._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostDescontaDifIcmsCusto._Regex = null;
            this.cbostDescontaDifIcmsCusto._situacao = true;
            this.cbostDescontaDifIcmsCusto._Table = "Tipo_operacao";
            this.cbostDescontaDifIcmsCusto._TamanhoComponente = 80;
            this.cbostDescontaDifIcmsCusto._TamanhoMaiorLabel = 400;
            this.cbostDescontaDifIcmsCusto._Visible = true;
            this.cbostDescontaDifIcmsCusto.BackColor = System.Drawing.Color.Transparent;
            this.cbostDescontaDifIcmsCusto.Base = null;
            this.cbostDescontaDifIcmsCusto.Color = System.Drawing.Color.White;
            this.cbostDescontaDifIcmsCusto.DataSource = null;
            this.cbostDescontaDifIcmsCusto.DisplayMember = "DisplayMember";
            this.cbostDescontaDifIcmsCusto.Location = new System.Drawing.Point(51, 189);
            this.cbostDescontaDifIcmsCusto.Margin = new System.Windows.Forms.Padding(51, 3, 15, 3);
            this.cbostDescontaDifIcmsCusto.Name = "cbostDescontaDifIcmsCusto";
            this.cbostDescontaDifIcmsCusto.objConfigComponenteModel = null;
            this.cbostDescontaDifIcmsCusto.SelectedIndex = -1;
            this.cbostDescontaDifIcmsCusto.SelectedValue = 0;
            this.cbostDescontaDifIcmsCusto.Size = new System.Drawing.Size(432, 21);
            this.cbostDescontaDifIcmsCusto.TabIndex = 12;
            this.cbostDescontaDifIcmsCusto.ValueMember = "ValueMember";
            // 
            // cbostObrigaOpNaCompra
            // 
            this.cbostObrigaOpNaCompra._Field = "stObrigaOpNaCompra";
            this.cbostObrigaOpNaCompra._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostObrigaOpNaCompra._Itens")));
            this.cbostObrigaOpNaCompra._LabelGroup = this.hlP_LabelSeparator_entrada;
            this.cbostObrigaOpNaCompra._LabelText = "Obriga informa ordem de produção no processo de compra?";
            this.cbostObrigaOpNaCompra._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostObrigaOpNaCompra._Regex = null;
            this.cbostObrigaOpNaCompra._situacao = true;
            this.cbostObrigaOpNaCompra._Table = "Tipo_operacao";
            this.cbostObrigaOpNaCompra._TamanhoComponente = 80;
            this.cbostObrigaOpNaCompra._TamanhoMaiorLabel = 400;
            this.cbostObrigaOpNaCompra._Visible = true;
            this.cbostObrigaOpNaCompra.BackColor = System.Drawing.Color.Transparent;
            this.cbostObrigaOpNaCompra.Base = null;
            this.cbostObrigaOpNaCompra.Color = System.Drawing.Color.White;
            this.cbostObrigaOpNaCompra.DataSource = null;
            this.cbostObrigaOpNaCompra.DisplayMember = "DisplayMember";
            this.cbostObrigaOpNaCompra.Location = new System.Drawing.Point(84, 216);
            this.cbostObrigaOpNaCompra.Margin = new System.Windows.Forms.Padding(84, 3, 15, 3);
            this.cbostObrigaOpNaCompra.Name = "cbostObrigaOpNaCompra";
            this.cbostObrigaOpNaCompra.objConfigComponenteModel = null;
            this.cbostObrigaOpNaCompra.SelectedIndex = -1;
            this.cbostObrigaOpNaCompra.SelectedValue = 0;
            this.cbostObrigaOpNaCompra.Size = new System.Drawing.Size(399, 21);
            this.cbostObrigaOpNaCompra.TabIndex = 13;
            this.cbostObrigaOpNaCompra.ValueMember = "ValueMember";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage3.Controls.Add(this.kryptonPanel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1346, 569);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Tag = false;
            this.tabPage3.Text = "Saídas";
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.BorderWidth = 0;
            this.kryptonPanel3.Controls.Add(this.flowLayoutPanel3);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel3.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.kryptonPanel3.GradientToogleColors = false;
            this.kryptonPanel3.GradientUseBlend = false;
            this.kryptonPanel3.GradientUseSolid = true;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.PersistentColors = false;
            this.kryptonPanel3.Size = new System.Drawing.Size(1346, 569);
            this.kryptonPanel3.TabIndex = 2;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel3.Controls.Add(this.hlP_LabelSeparator_saida);
            this.flowLayoutPanel3.Controls.Add(this.nudpInsumoIndustrializacao);
            this.flowLayoutPanel3.Controls.Add(this.nudpMoIndustrializacao);
            this.flowLayoutPanel3.Controls.Add(this.cbostCalcImportacao);
            this.flowLayoutPanel3.Controls.Add(this.cbostCalcCredicmsSs);
            this.flowLayoutPanel3.Controls.Add(this.cbostCalcCredicmsSsSt);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1346, 569);
            this.flowLayoutPanel3.TabIndex = 1;
            this.flowLayoutPanel3.Tag = "Saídas";
            // 
            // hlP_LabelSeparator_saida
            // 
            this.hlP_LabelSeparator_saida._LabelText = "Parametro de saída";
            this.hlP_LabelSeparator_saida._TamanhoMaiorLabel = 0;
            this.hlP_LabelSeparator_saida.BackColor = System.Drawing.Color.Transparent;
            this.hlP_LabelSeparator_saida.Location = new System.Drawing.Point(0, 3);
            this.hlP_LabelSeparator_saida.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.hlP_LabelSeparator_saida.Name = "hlP_LabelSeparator_saida";
            this.hlP_LabelSeparator_saida.Size = new System.Drawing.Size(506, 18);
            this.hlP_LabelSeparator_saida.TabIndex = 30;
            this.hlP_LabelSeparator_saida.TabStop = false;
            // 
            // nudpInsumoIndustrializacao
            // 
            this.nudpInsumoIndustrializacao._Field = "pInsumoIndustrializacao";
            this.nudpInsumoIndustrializacao._LabelGroup = this.hlP_LabelSeparator_saida;
            this.nudpInsumoIndustrializacao._LabelText = "Porcentagem de insumo no item de industrialização";
            this.nudpInsumoIndustrializacao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudpInsumoIndustrializacao._Regex = null;
            this.nudpInsumoIndustrializacao._Table = "Tipo_operacao";
            this.nudpInsumoIndustrializacao._TamanhoComponente = 149;
            this.nudpInsumoIndustrializacao._TamanhoMaiorLabel = 350;
            this.nudpInsumoIndustrializacao._Visible = true;
            this.nudpInsumoIndustrializacao.BackColor = System.Drawing.Color.Transparent;
            this.nudpInsumoIndustrializacao.Base = null;
            this.nudpInsumoIndustrializacao.Color = System.Drawing.Color.White;
            this.nudpInsumoIndustrializacao.DecimalPlaces = 2;
            this.nudpInsumoIndustrializacao.Location = new System.Drawing.Point(80, 27);
            this.nudpInsumoIndustrializacao.Margin = new System.Windows.Forms.Padding(80, 3, 15, 3);
            this.nudpInsumoIndustrializacao.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudpInsumoIndustrializacao.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudpInsumoIndustrializacao.Name = "nudpInsumoIndustrializacao";
            this.nudpInsumoIndustrializacao.objConfigComponenteModel = null;
            this.nudpInsumoIndustrializacao.ReadOnly = false;
            this.nudpInsumoIndustrializacao.Size = new System.Drawing.Size(422, 22);
            this.nudpInsumoIndustrializacao.TabIndex = 0;
            this.nudpInsumoIndustrializacao.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudpInsumoIndustrializacao.ValueInt = 0;
            // 
            // nudpMoIndustrializacao
            // 
            this.nudpMoIndustrializacao._Field = "pMaoObraIndustrializacao";
            this.nudpMoIndustrializacao._LabelGroup = this.hlP_LabelSeparator_saida;
            this.nudpMoIndustrializacao._LabelText = "Porcentagem de mão de obra no item de industrialização";
            this.nudpMoIndustrializacao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudpMoIndustrializacao._Regex = null;
            this.nudpMoIndustrializacao._Table = "Tipo_operacao";
            this.nudpMoIndustrializacao._TamanhoComponente = 153;
            this.nudpMoIndustrializacao._TamanhoMaiorLabel = 350;
            this.nudpMoIndustrializacao._Visible = true;
            this.nudpMoIndustrializacao.BackColor = System.Drawing.Color.Transparent;
            this.nudpMoIndustrializacao.Base = null;
            this.nudpMoIndustrializacao.Color = System.Drawing.Color.White;
            this.nudpMoIndustrializacao.DecimalPlaces = 2;
            this.nudpMoIndustrializacao.Location = new System.Drawing.Point(53, 55);
            this.nudpMoIndustrializacao.Margin = new System.Windows.Forms.Padding(53, 3, 15, 3);
            this.nudpMoIndustrializacao.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudpMoIndustrializacao.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudpMoIndustrializacao.Name = "nudpMoIndustrializacao";
            this.nudpMoIndustrializacao.objConfigComponenteModel = null;
            this.nudpMoIndustrializacao.ReadOnly = false;
            this.nudpMoIndustrializacao.Size = new System.Drawing.Size(453, 22);
            this.nudpMoIndustrializacao.TabIndex = 1;
            this.nudpMoIndustrializacao.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudpMoIndustrializacao.ValueInt = 0;
            // 
            // cbostCalcImportacao
            // 
            this.cbostCalcImportacao._Field = "stCalculaImportacao";
            this.cbostCalcImportacao._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostCalcImportacao._Itens")));
            this.cbostCalcImportacao._LabelGroup = this.hlP_LabelSeparator_saida;
            this.cbostCalcImportacao._LabelText = "Calculo de importação?";
            this.cbostCalcImportacao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostCalcImportacao._Regex = null;
            this.cbostCalcImportacao._situacao = true;
            this.cbostCalcImportacao._Table = "Tipo_operacao";
            this.cbostCalcImportacao._TamanhoComponente = 80;
            this.cbostCalcImportacao._TamanhoMaiorLabel = 350;
            this.cbostCalcImportacao._Visible = true;
            this.cbostCalcImportacao.BackColor = System.Drawing.Color.Transparent;
            this.cbostCalcImportacao.Base = null;
            this.cbostCalcImportacao.Color = System.Drawing.Color.White;
            this.cbostCalcImportacao.DataSource = null;
            this.cbostCalcImportacao.DisplayMember = "DisplayMember";
            this.cbostCalcImportacao.Location = new System.Drawing.Point(226, 83);
            this.cbostCalcImportacao.Margin = new System.Windows.Forms.Padding(226, 3, 15, 3);
            this.cbostCalcImportacao.Name = "cbostCalcImportacao";
            this.cbostCalcImportacao.objConfigComponenteModel = null;
            this.cbostCalcImportacao.SelectedIndex = -1;
            this.cbostCalcImportacao.SelectedValue = 0;
            this.cbostCalcImportacao.Size = new System.Drawing.Size(207, 21);
            this.cbostCalcImportacao.TabIndex = 8;
            this.cbostCalcImportacao.ValueMember = "ValueMember";
            // 
            // cbostCalcCredicmsSs
            // 
            this.cbostCalcCredicmsSs._Field = "stCalculaCreditoIcmsSuperSimples";
            this.cbostCalcCredicmsSs._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostCalcCredicmsSs._Itens")));
            this.cbostCalcCredicmsSs._LabelGroup = this.hlP_LabelSeparator_saida;
            this.cbostCalcCredicmsSs._LabelText = "Calcula crédito de icms no super simples?";
            this.cbostCalcCredicmsSs._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostCalcCredicmsSs._Regex = null;
            this.cbostCalcCredicmsSs._situacao = true;
            this.cbostCalcCredicmsSs._Table = "Tipo_operacao";
            this.cbostCalcCredicmsSs._TamanhoComponente = 80;
            this.cbostCalcCredicmsSs._TamanhoMaiorLabel = 350;
            this.cbostCalcCredicmsSs._Visible = true;
            this.cbostCalcCredicmsSs.BackColor = System.Drawing.Color.Transparent;
            this.cbostCalcCredicmsSs.Base = null;
            this.cbostCalcCredicmsSs.Color = System.Drawing.Color.White;
            this.cbostCalcCredicmsSs.DataSource = null;
            this.cbostCalcCredicmsSs.DisplayMember = "DisplayMember";
            this.cbostCalcCredicmsSs.Location = new System.Drawing.Point(134, 110);
            this.cbostCalcCredicmsSs.Margin = new System.Windows.Forms.Padding(134, 3, 15, 3);
            this.cbostCalcCredicmsSs.Name = "cbostCalcCredicmsSs";
            this.cbostCalcCredicmsSs.objConfigComponenteModel = null;
            this.cbostCalcCredicmsSs.SelectedIndex = -1;
            this.cbostCalcCredicmsSs.SelectedValue = 0;
            this.cbostCalcCredicmsSs.Size = new System.Drawing.Size(299, 21);
            this.cbostCalcCredicmsSs.TabIndex = 9;
            this.cbostCalcCredicmsSs.ValueMember = "ValueMember";
            // 
            // cbostCalcCredicmsSsSt
            // 
            this.cbostCalcCredicmsSsSt._Field = "stCalculaCreditoIcmsSubstituicaoTributariaSuperSimples";
            this.cbostCalcCredicmsSsSt._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostCalcCredicmsSsSt._Itens")));
            this.cbostCalcCredicmsSsSt._LabelGroup = this.hlP_LabelSeparator_saida;
            this.cbostCalcCredicmsSsSt._LabelText = "Calcula crédito de icms no super simples e com subst. tributária?";
            this.cbostCalcCredicmsSsSt._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostCalcCredicmsSsSt._Regex = null;
            this.cbostCalcCredicmsSsSt._situacao = true;
            this.cbostCalcCredicmsSsSt._Table = "Tipo_operacao";
            this.cbostCalcCredicmsSsSt._TamanhoComponente = 80;
            this.cbostCalcCredicmsSsSt._TamanhoMaiorLabel = 350;
            this.cbostCalcCredicmsSsSt._Visible = true;
            this.cbostCalcCredicmsSsSt.BackColor = System.Drawing.Color.Transparent;
            this.cbostCalcCredicmsSsSt.Base = null;
            this.cbostCalcCredicmsSsSt.Color = System.Drawing.Color.White;
            this.cbostCalcCredicmsSsSt.DataSource = null;
            this.cbostCalcCredicmsSsSt.DisplayMember = "DisplayMember";
            this.cbostCalcCredicmsSsSt.Location = new System.Drawing.Point(16, 137);
            this.cbostCalcCredicmsSsSt.Margin = new System.Windows.Forms.Padding(16, 3, 15, 3);
            this.cbostCalcCredicmsSsSt.Name = "cbostCalcCredicmsSsSt";
            this.cbostCalcCredicmsSsSt.objConfigComponenteModel = null;
            this.cbostCalcCredicmsSsSt.SelectedIndex = -1;
            this.cbostCalcCredicmsSsSt.SelectedValue = 0;
            this.cbostCalcCredicmsSsSt.Size = new System.Drawing.Size(417, 21);
            this.cbostCalcCredicmsSsSt.TabIndex = 10;
            this.cbostCalcCredicmsSsSt.ValueMember = "ValueMember";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage4.Controls.Add(this.kryptonPanel4);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1346, 569);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Tag = false;
            this.tabPage4.Text = "Fiscal Geral";
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.BorderWidth = 0;
            this.kryptonPanel4.Controls.Add(this.flowLayoutPanel4);
            this.kryptonPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel4.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.kryptonPanel4.GradientToogleColors = false;
            this.kryptonPanel4.GradientUseBlend = false;
            this.kryptonPanel4.GradientUseSolid = true;
            this.kryptonPanel4.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.PersistentColors = false;
            this.kryptonPanel4.Size = new System.Drawing.Size(1346, 569);
            this.kryptonPanel4.TabIndex = 2;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoScroll = true;
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel4.Controls.Add(this.hlP_LabelSeparator_fiscal);
            this.flowLayoutPanel4.Controls.Add(this.cbostReduzBase);
            this.flowLayoutPanel4.Controls.Add(this.cbostNaoReduzBase);
            this.flowLayoutPanel4.Controls.Add(this.cbostCalcIcms);
            this.flowLayoutPanel4.Controls.Add(this.hlP_PesquisaidCodigoIcmsPai);
            this.flowLayoutPanel4.Controls.Add(this.hlP_PesquisaidCSTIcms);
            this.flowLayoutPanel4.Controls.Add(this.cbostCompoeBaseIcms);
            this.flowLayoutPanel4.Controls.Add(this.cbostCalcIpi);
            this.flowLayoutPanel4.Controls.Add(this.hlP_PesquisaidClassificacaoFiscal);
            this.flowLayoutPanel4.Controls.Add(this.hlP_LabelSeparator_IPI);
            this.flowLayoutPanel4.Controls.Add(this.nudpIpi);
            this.flowLayoutPanel4.Controls.Add(this.hlP_PesquisaidCSTIpi);
            this.flowLayoutPanel4.Controls.Add(this.cbostCompoeBaseIpi);
            this.flowLayoutPanel4.Controls.Add(this.hlP_LabelSeparator_icms);
            this.flowLayoutPanel4.Controls.Add(this.cbostCalcIcmsSubstTributaria);
            this.flowLayoutPanel4.Controls.Add(this.cbostCompoeBaseIcmsSubstTributaria);
            this.flowLayoutPanel4.Controls.Add(this.hlP_LabelSeparator_piscof);
            this.flowLayoutPanel4.Controls.Add(this.nudnCoeficienteSubstTributariaPis);
            this.flowLayoutPanel4.Controls.Add(this.nudnCoeficienteSubstTributariaCofins);
            this.flowLayoutPanel4.Controls.Add(this.nudpPis);
            this.flowLayoutPanel4.Controls.Add(this.nudpCofins);
            this.flowLayoutPanel4.Controls.Add(this.cbostCalcPisCofins);
            this.flowLayoutPanel4.Controls.Add(this.cbostRegimeTributacaoPisCofins);
            this.flowLayoutPanel4.Controls.Add(this.hlP_PesquisaidCSTPis);
            this.flowLayoutPanel4.Controls.Add(this.hlP_PesquisaidCSTCofins);
            this.flowLayoutPanel4.Controls.Add(this.cbostCompoeBaseNormalPiscofins);
            this.flowLayoutPanel4.Controls.Add(this.cbostCompoeBaseSubtTribPis);
            this.flowLayoutPanel4.Controls.Add(this.cbostCompoeBaseSubtTribCofins);
            this.flowLayoutPanel4.Controls.Add(this.hlP_LabelSeparatorServico);
            this.flowLayoutPanel4.Controls.Add(this.nudpIss);
            this.flowLayoutPanel4.Controls.Add(this.nudpReducaoBaseIrrf);
            this.flowLayoutPanel4.Controls.Add(this.nudpIrrf);
            this.flowLayoutPanel4.Controls.Add(this.nudpReducaoBaseInss);
            this.flowLayoutPanel4.Controls.Add(this.nudpInss);
            this.flowLayoutPanel4.Controls.Add(this.cbostCalcIss);
            this.flowLayoutPanel4.Controls.Add(this.cbostCalcIrrf);
            this.flowLayoutPanel4.Controls.Add(this.cbostCalcCsll);
            this.flowLayoutPanel4.Controls.Add(this.cbostCalcInss);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(1346, 569);
            this.flowLayoutPanel4.TabIndex = 1;
            this.flowLayoutPanel4.Tag = "Fiscal Geral";
            // 
            // hlP_LabelSeparator_fiscal
            // 
            this.hlP_LabelSeparator_fiscal._LabelText = "Fiscal";
            this.hlP_LabelSeparator_fiscal._TamanhoMaiorLabel = 0;
            this.hlP_LabelSeparator_fiscal.BackColor = System.Drawing.Color.Transparent;
            this.hlP_LabelSeparator_fiscal.Location = new System.Drawing.Point(0, 3);
            this.hlP_LabelSeparator_fiscal.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.hlP_LabelSeparator_fiscal.Name = "hlP_LabelSeparator_fiscal";
            this.hlP_LabelSeparator_fiscal.Size = new System.Drawing.Size(693, 18);
            this.hlP_LabelSeparator_fiscal.TabIndex = 60;
            this.hlP_LabelSeparator_fiscal.TabStop = false;
            this.hlP_LabelSeparator_fiscal.Load += new System.EventHandler(this.hlP_LabelSeparator_fiscal_Load);
            // 
            // cbostReduzBase
            // 
            this.cbostReduzBase._Field = "stReduzBase";
            this.cbostReduzBase._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostReduzBase._Itens")));
            this.cbostReduzBase._LabelGroup = this.hlP_LabelSeparator_fiscal;
            this.cbostReduzBase._LabelText = "Reduz base de cálculo?";
            this.cbostReduzBase._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostReduzBase._Regex = null;
            this.cbostReduzBase._situacao = false;
            this.cbostReduzBase._Table = "Tipo_operacao";
            this.cbostReduzBase._TamanhoComponente = 178;
            this.cbostReduzBase._TamanhoMaiorLabel = 300;
            this.cbostReduzBase.BackColor = System.Drawing.Color.Transparent;
            this.cbostReduzBase.Base = null;
            this.cbostReduzBase.Color = System.Drawing.Color.White;
            this.cbostReduzBase.DataSource = null;
            this.cbostReduzBase.DisplayMember = "DisplayMember";
            this.cbostReduzBase.Location = new System.Drawing.Point(177, 27);
            this.cbostReduzBase.Margin = new System.Windows.Forms.Padding(177, 3, 15, 3);
            this.cbostReduzBase.Name = "cbostReduzBase";
            this.cbostReduzBase.objConfigComponenteModel = null;
            this.cbostReduzBase.SelectedIndex = -1;
            this.cbostReduzBase.SelectedValue = 0;
            this.cbostReduzBase.Size = new System.Drawing.Size(304, 21);
            this.cbostReduzBase.TabIndex = 4;
            this.cbostReduzBase.ValueMember = "ValueMember";
            // 
            // cbostNaoReduzBase
            // 
            this.cbostNaoReduzBase._Field = "stNaoReduzBase";
            this.cbostNaoReduzBase._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostNaoReduzBase._Itens")));
            this.cbostNaoReduzBase._LabelGroup = this.hlP_LabelSeparator_fiscal;
            this.cbostNaoReduzBase._LabelText = "Quando não reduz base de cálculo?";
            this.cbostNaoReduzBase._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostNaoReduzBase._Regex = null;
            this.cbostNaoReduzBase._situacao = false;
            this.cbostNaoReduzBase._Table = "Tipo_operacao";
            this.cbostNaoReduzBase._TamanhoComponente = 151;
            this.cbostNaoReduzBase._TamanhoMaiorLabel = 300;
            this.cbostNaoReduzBase.BackColor = System.Drawing.Color.Transparent;
            this.cbostNaoReduzBase.Base = null;
            this.cbostNaoReduzBase.Color = System.Drawing.Color.White;
            this.cbostNaoReduzBase.DataSource = null;
            this.cbostNaoReduzBase.DisplayMember = "DisplayMember";
            this.cbostNaoReduzBase.Location = new System.Drawing.Point(112, 54);
            this.cbostNaoReduzBase.Margin = new System.Windows.Forms.Padding(112, 3, 15, 3);
            this.cbostNaoReduzBase.Name = "cbostNaoReduzBase";
            this.cbostNaoReduzBase.objConfigComponenteModel = null;
            this.cbostNaoReduzBase.SelectedIndex = -1;
            this.cbostNaoReduzBase.SelectedValue = 0;
            this.cbostNaoReduzBase.Size = new System.Drawing.Size(342, 21);
            this.cbostNaoReduzBase.TabIndex = 4;
            this.cbostNaoReduzBase.ValueMember = "ValueMember";
            // 
            // cbostCalcIcms
            // 
            this.cbostCalcIcms._Field = "stCalculaIcms";
            this.cbostCalcIcms._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostCalcIcms._Itens")));
            this.cbostCalcIcms._LabelGroup = this.hlP_LabelSeparator_fiscal;
            this.cbostCalcIcms._LabelText = "Calcula icms?";
            this.cbostCalcIcms._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostCalcIcms._Regex = null;
            this.cbostCalcIcms._situacao = true;
            this.cbostCalcIcms._Table = "Tipo_operacao";
            this.cbostCalcIcms._TamanhoComponente = 80;
            this.cbostCalcIcms._TamanhoMaiorLabel = 300;
            this.cbostCalcIcms.BackColor = System.Drawing.Color.Transparent;
            this.cbostCalcIcms.Base = null;
            this.cbostCalcIcms.Color = System.Drawing.Color.White;
            this.cbostCalcIcms.DataSource = null;
            this.cbostCalcIcms.DisplayMember = "DisplayMember";
            this.cbostCalcIcms.Location = new System.Drawing.Point(229, 81);
            this.cbostCalcIcms.Margin = new System.Windows.Forms.Padding(229, 3, 15, 3);
            this.cbostCalcIcms.Name = "cbostCalcIcms";
            this.cbostCalcIcms.objConfigComponenteModel = null;
            this.cbostCalcIcms.SelectedIndex = -1;
            this.cbostCalcIcms.SelectedValue = 0;
            this.cbostCalcIcms.Size = new System.Drawing.Size(154, 21);
            this.cbostCalcIcms.TabIndex = 9;
            this.cbostCalcIcms.ValueMember = "ValueMember";
            // 
            // hlP_PesquisaidCodigoIcmsPai
            // 
            this.hlP_PesquisaidCodigoIcmsPai._Field = "idCodigoIcmsPai";
            this.hlP_PesquisaidCodigoIcmsPai._LabelGroup = this.hlP_LabelSeparator_fiscal;
            this.hlP_PesquisaidCodigoIcmsPai._LabelText = "Código de icms";
            this.hlP_PesquisaidCodigoIcmsPai._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidCodigoIcmsPai._ListaCamposDisplay")));
            this.hlP_PesquisaidCodigoIcmsPai._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidCodigoIcmsPai._ListaValoresDisplay")));
            this.hlP_PesquisaidCodigoIcmsPai._NomeCampoPK = "ID";
            this.hlP_PesquisaidCodigoIcmsPai._NomeFormCadastroOriginal = "FormCodigoIcms";
            this.hlP_PesquisaidCodigoIcmsPai._NomeView = "vwCodigoIcmsPai";
            this.hlP_PesquisaidCodigoIcmsPai._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisaidCodigoIcmsPai._Regex = null;
            this.hlP_PesquisaidCodigoIcmsPai._Table = "Tipo_operacao";
            this.hlP_PesquisaidCodigoIcmsPai._TamanhoComponente = 300;
            this.hlP_PesquisaidCodigoIcmsPai._TamanhoMaiorLabel = 300;
            this.hlP_PesquisaidCodigoIcmsPai._Vinculado = false;
            this.hlP_PesquisaidCodigoIcmsPai.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidCodigoIcmsPai.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidCodigoIcmsPai.Base = null;
            this.hlP_PesquisaidCodigoIcmsPai.Location = new System.Drawing.Point(217, 108);
            this.hlP_PesquisaidCodigoIcmsPai.Margin = new System.Windows.Forms.Padding(217, 3, 15, 3);
            this.hlP_PesquisaidCodigoIcmsPai.Name = "hlP_PesquisaidCodigoIcmsPai";
            this.hlP_PesquisaidCodigoIcmsPai.objConfigComponenteModel = null;
            this.hlP_PesquisaidCodigoIcmsPai.ReadOnly = false;
            this.hlP_PesquisaidCodigoIcmsPai.Size = new System.Drawing.Size(386, 21);
            this.hlP_PesquisaidCodigoIcmsPai.TabIndex = 16;
            this.hlP_PesquisaidCodigoIcmsPai.Value = 0;
            // 
            // hlP_PesquisaidCSTIcms
            // 
            this.hlP_PesquisaidCSTIcms._Field = "idCSTIcms";
            this.hlP_PesquisaidCSTIcms._LabelGroup = this.hlP_LabelSeparator_fiscal;
            this.hlP_PesquisaidCSTIcms._LabelText = "Situação tributária de icms";
            this.hlP_PesquisaidCSTIcms._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidCSTIcms._ListaCamposDisplay")));
            this.hlP_PesquisaidCSTIcms._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidCSTIcms._ListaValoresDisplay")));
            this.hlP_PesquisaidCSTIcms._NomeCampoPK = "ID";
            this.hlP_PesquisaidCSTIcms._NomeFormCadastroOriginal = "FormStICMS";
            this.hlP_PesquisaidCSTIcms._NomeView = "vwStICMS";
            this.hlP_PesquisaidCSTIcms._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisaidCSTIcms._Regex = null;
            this.hlP_PesquisaidCSTIcms._Table = "Tipo_operacao";
            this.hlP_PesquisaidCSTIcms._TamanhoComponente = 300;
            this.hlP_PesquisaidCSTIcms._TamanhoMaiorLabel = 300;
            this.hlP_PesquisaidCSTIcms._Vinculado = false;
            this.hlP_PesquisaidCSTIcms.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidCSTIcms.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidCSTIcms.Base = null;
            this.hlP_PesquisaidCSTIcms.Location = new System.Drawing.Point(160, 135);
            this.hlP_PesquisaidCSTIcms.Margin = new System.Windows.Forms.Padding(160, 3, 15, 3);
            this.hlP_PesquisaidCSTIcms.Name = "hlP_PesquisaidCSTIcms";
            this.hlP_PesquisaidCSTIcms.objConfigComponenteModel = null;
            this.hlP_PesquisaidCSTIcms.ReadOnly = false;
            this.hlP_PesquisaidCSTIcms.Size = new System.Drawing.Size(443, 21);
            this.hlP_PesquisaidCSTIcms.TabIndex = 17;
            this.hlP_PesquisaidCSTIcms.Value = 0;
            // 
            // cbostCompoeBaseIcms
            // 
            this.cbostCompoeBaseIcms._Field = "stCompoeBaseIcms";
            this.cbostCompoeBaseIcms._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostCompoeBaseIcms._Itens")));
            this.cbostCompoeBaseIcms._LabelGroup = this.hlP_LabelSeparator_fiscal;
            this.cbostCompoeBaseIcms._LabelText = "Compõe a base de cálculo de icms?";
            this.cbostCompoeBaseIcms._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostCompoeBaseIcms._Regex = null;
            this.cbostCompoeBaseIcms._situacao = false;
            this.cbostCompoeBaseIcms._Table = "Tipo_operacao";
            this.cbostCompoeBaseIcms._TamanhoComponente = 314;
            this.cbostCompoeBaseIcms._TamanhoMaiorLabel = 300;
            this.cbostCompoeBaseIcms.BackColor = System.Drawing.Color.Transparent;
            this.cbostCompoeBaseIcms.Base = null;
            this.cbostCompoeBaseIcms.Color = System.Drawing.Color.White;
            this.cbostCompoeBaseIcms.DataSource = null;
            this.cbostCompoeBaseIcms.DisplayMember = "DisplayMember";
            this.cbostCompoeBaseIcms.Location = new System.Drawing.Point(116, 162);
            this.cbostCompoeBaseIcms.Margin = new System.Windows.Forms.Padding(116, 3, 15, 3);
            this.cbostCompoeBaseIcms.Name = "cbostCompoeBaseIcms";
            this.cbostCompoeBaseIcms.objConfigComponenteModel = null;
            this.cbostCompoeBaseIcms.SelectedIndex = -1;
            this.cbostCompoeBaseIcms.SelectedValue = 0;
            this.cbostCompoeBaseIcms.Size = new System.Drawing.Size(501, 21);
            this.cbostCompoeBaseIcms.TabIndex = 18;
            this.cbostCompoeBaseIcms.ValueMember = "ValueMember";
            // 
            // cbostCalcIpi
            // 
            this.cbostCalcIpi._Field = "stCalculaIpi";
            this.cbostCalcIpi._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostCalcIpi._Itens")));
            this.cbostCalcIpi._LabelGroup = this.hlP_LabelSeparator_fiscal;
            this.cbostCalcIpi._LabelText = "Calcula ipi?";
            this.cbostCalcIpi._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostCalcIpi._Regex = null;
            this.cbostCalcIpi._situacao = true;
            this.cbostCalcIpi._Table = "Tipo_operacao";
            this.cbostCalcIpi._TamanhoComponente = 80;
            this.cbostCalcIpi._TamanhoMaiorLabel = 300;
            this.cbostCalcIpi.BackColor = System.Drawing.Color.Transparent;
            this.cbostCalcIpi.Base = null;
            this.cbostCalcIpi.Color = System.Drawing.Color.White;
            this.cbostCalcIpi.DataSource = null;
            this.cbostCalcIpi.DisplayMember = "DisplayMember";
            this.cbostCalcIpi.Location = new System.Drawing.Point(238, 189);
            this.cbostCalcIpi.Margin = new System.Windows.Forms.Padding(238, 3, 15, 3);
            this.cbostCalcIpi.Name = "cbostCalcIpi";
            this.cbostCalcIpi.objConfigComponenteModel = null;
            this.cbostCalcIpi.SelectedIndex = -1;
            this.cbostCalcIpi.SelectedValue = 0;
            this.cbostCalcIpi.Size = new System.Drawing.Size(145, 21);
            this.cbostCalcIpi.TabIndex = 19;
            this.cbostCalcIpi.ValueMember = "ValueMember";
            // 
            // hlP_PesquisaidClassificacaoFiscal
            // 
            this.hlP_PesquisaidClassificacaoFiscal._Field = "idClassificacaoFiscal";
            this.hlP_PesquisaidClassificacaoFiscal._LabelGroup = this.hlP_LabelSeparator_fiscal;
            this.hlP_PesquisaidClassificacaoFiscal._LabelText = "Classificação fiscal";
            this.hlP_PesquisaidClassificacaoFiscal._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidClassificacaoFiscal._ListaCamposDisplay")));
            this.hlP_PesquisaidClassificacaoFiscal._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidClassificacaoFiscal._ListaValoresDisplay")));
            this.hlP_PesquisaidClassificacaoFiscal._NomeCampoPK = "ID";
            this.hlP_PesquisaidClassificacaoFiscal._NomeFormCadastroOriginal = "FormClassificacaoFiscal";
            this.hlP_PesquisaidClassificacaoFiscal._NomeView = "vwClassificacaoFiscal";
            this.hlP_PesquisaidClassificacaoFiscal._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisaidClassificacaoFiscal._Regex = null;
            this.hlP_PesquisaidClassificacaoFiscal._Table = "Tipo_operacao";
            this.hlP_PesquisaidClassificacaoFiscal._TamanhoComponente = 300;
            this.hlP_PesquisaidClassificacaoFiscal._TamanhoMaiorLabel = 300;
            this.hlP_PesquisaidClassificacaoFiscal._Vinculado = false;
            this.hlP_PesquisaidClassificacaoFiscal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidClassificacaoFiscal.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidClassificacaoFiscal.Base = null;
            this.hlP_PesquisaidClassificacaoFiscal.Location = new System.Drawing.Point(202, 216);
            this.hlP_PesquisaidClassificacaoFiscal.Margin = new System.Windows.Forms.Padding(202, 3, 15, 3);
            this.hlP_PesquisaidClassificacaoFiscal.Name = "hlP_PesquisaidClassificacaoFiscal";
            this.hlP_PesquisaidClassificacaoFiscal.objConfigComponenteModel = null;
            this.hlP_PesquisaidClassificacaoFiscal.ReadOnly = false;
            this.hlP_PesquisaidClassificacaoFiscal.Size = new System.Drawing.Size(401, 21);
            this.hlP_PesquisaidClassificacaoFiscal.TabIndex = 20;
            this.hlP_PesquisaidClassificacaoFiscal.Value = 0;
            // 
            // hlP_LabelSeparator_IPI
            // 
            this.hlP_LabelSeparator_IPI._LabelText = "Ipi";
            this.hlP_LabelSeparator_IPI._TamanhoMaiorLabel = 0;
            this.hlP_LabelSeparator_IPI.BackColor = System.Drawing.Color.Transparent;
            this.hlP_LabelSeparator_IPI.Location = new System.Drawing.Point(3, 243);
            this.hlP_LabelSeparator_IPI.Name = "hlP_LabelSeparator_IPI";
            this.hlP_LabelSeparator_IPI.Size = new System.Drawing.Size(690, 18);
            this.hlP_LabelSeparator_IPI.TabIndex = 61;
            this.hlP_LabelSeparator_IPI.TabStop = false;
            // 
            // nudpIpi
            // 
            this.nudpIpi._Field = "pIpi";
            this.nudpIpi._LabelGroup = this.hlP_LabelSeparator_IPI;
            this.nudpIpi._LabelText = "Alíquota de ipi";
            this.nudpIpi._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudpIpi._Regex = null;
            this.nudpIpi._Table = "Tipo_operacao";
            this.nudpIpi._TamanhoComponente = 124;
            this.nudpIpi._TamanhoMaiorLabel = 300;
            this.nudpIpi.BackColor = System.Drawing.Color.Transparent;
            this.nudpIpi.Base = null;
            this.nudpIpi.Color = System.Drawing.Color.White;
            this.nudpIpi.DecimalPlaces = 2;
            this.nudpIpi.Location = new System.Drawing.Point(220, 267);
            this.nudpIpi.Margin = new System.Windows.Forms.Padding(220, 3, 15, 3);
            this.nudpIpi.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudpIpi.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudpIpi.Name = "nudpIpi";
            this.nudpIpi.objConfigComponenteModel = null;
            this.nudpIpi.ReadOnly = false;
            this.nudpIpi.Size = new System.Drawing.Size(207, 22);
            this.nudpIpi.TabIndex = 21;
            this.nudpIpi.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudpIpi.ValueInt = 0;
            // 
            // hlP_PesquisaidCSTIpi
            // 
            this.hlP_PesquisaidCSTIpi._Field = "idCSTIpi";
            this.hlP_PesquisaidCSTIpi._LabelGroup = this.hlP_LabelSeparator_IPI;
            this.hlP_PesquisaidCSTIpi._LabelText = "Situação tributária de ipi";
            this.hlP_PesquisaidCSTIpi._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidCSTIpi._ListaCamposDisplay")));
            this.hlP_PesquisaidCSTIpi._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidCSTIpi._ListaValoresDisplay")));
            this.hlP_PesquisaidCSTIpi._NomeCampoPK = "ID";
            this.hlP_PesquisaidCSTIpi._NomeFormCadastroOriginal = "FormStIPI";
            this.hlP_PesquisaidCSTIpi._NomeView = "vwStIPI";
            this.hlP_PesquisaidCSTIpi._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisaidCSTIpi._Regex = null;
            this.hlP_PesquisaidCSTIpi._Table = "Tipo_operacao";
            this.hlP_PesquisaidCSTIpi._TamanhoComponente = 300;
            this.hlP_PesquisaidCSTIpi._TamanhoMaiorLabel = 300;
            this.hlP_PesquisaidCSTIpi._Vinculado = false;
            this.hlP_PesquisaidCSTIpi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidCSTIpi.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidCSTIpi.Base = null;
            this.hlP_PesquisaidCSTIpi.Location = new System.Drawing.Point(169, 295);
            this.hlP_PesquisaidCSTIpi.Margin = new System.Windows.Forms.Padding(169, 3, 15, 3);
            this.hlP_PesquisaidCSTIpi.Name = "hlP_PesquisaidCSTIpi";
            this.hlP_PesquisaidCSTIpi.objConfigComponenteModel = null;
            this.hlP_PesquisaidCSTIpi.ReadOnly = false;
            this.hlP_PesquisaidCSTIpi.Size = new System.Drawing.Size(434, 21);
            this.hlP_PesquisaidCSTIpi.TabIndex = 22;
            this.hlP_PesquisaidCSTIpi.Value = 0;
            // 
            // cbostCompoeBaseIpi
            // 
            this.cbostCompoeBaseIpi._Field = "stCompoeBaseIpi";
            this.cbostCompoeBaseIpi._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostCompoeBaseIpi._Itens")));
            this.cbostCompoeBaseIpi._LabelGroup = this.hlP_LabelSeparator_IPI;
            this.cbostCompoeBaseIpi._LabelText = "Compõe a base de cálculo de ipi?";
            this.cbostCompoeBaseIpi._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostCompoeBaseIpi._Regex = null;
            this.cbostCompoeBaseIpi._situacao = false;
            this.cbostCompoeBaseIpi._Table = "Tipo_operacao";
            this.cbostCompoeBaseIpi._TamanhoComponente = 294;
            this.cbostCompoeBaseIpi._TamanhoMaiorLabel = 300;
            this.cbostCompoeBaseIpi.BackColor = System.Drawing.Color.Transparent;
            this.cbostCompoeBaseIpi.Base = null;
            this.cbostCompoeBaseIpi.Color = System.Drawing.Color.White;
            this.cbostCompoeBaseIpi.DataSource = null;
            this.cbostCompoeBaseIpi.DisplayMember = "DisplayMember";
            this.cbostCompoeBaseIpi.Location = new System.Drawing.Point(125, 322);
            this.cbostCompoeBaseIpi.Margin = new System.Windows.Forms.Padding(125, 3, 15, 3);
            this.cbostCompoeBaseIpi.Name = "cbostCompoeBaseIpi";
            this.cbostCompoeBaseIpi.objConfigComponenteModel = null;
            this.cbostCompoeBaseIpi.SelectedIndex = -1;
            this.cbostCompoeBaseIpi.SelectedValue = 0;
            this.cbostCompoeBaseIpi.Size = new System.Drawing.Size(472, 21);
            this.cbostCompoeBaseIpi.TabIndex = 23;
            this.cbostCompoeBaseIpi.ValueMember = "ValueMember";
            // 
            // hlP_LabelSeparator_icms
            // 
            this.hlP_LabelSeparator_icms._LabelText = "Icms";
            this.hlP_LabelSeparator_icms._TamanhoMaiorLabel = 0;
            this.hlP_LabelSeparator_icms.BackColor = System.Drawing.Color.Transparent;
            this.hlP_LabelSeparator_icms.Location = new System.Drawing.Point(3, 349);
            this.hlP_LabelSeparator_icms.Name = "hlP_LabelSeparator_icms";
            this.hlP_LabelSeparator_icms.Size = new System.Drawing.Size(690, 18);
            this.hlP_LabelSeparator_icms.TabIndex = 62;
            this.hlP_LabelSeparator_icms.TabStop = false;
            // 
            // cbostCalcIcmsSubstTributaria
            // 
            this.cbostCalcIcmsSubstTributaria._Field = "stCalculaIcmsSubstituicaoTributaria";
            this.cbostCalcIcmsSubstTributaria._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostCalcIcmsSubstTributaria._Itens")));
            this.cbostCalcIcmsSubstTributaria._LabelGroup = this.hlP_LabelSeparator_icms;
            this.cbostCalcIcmsSubstTributaria._LabelText = "Calcula icms subst. tributária?";
            this.cbostCalcIcmsSubstTributaria._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostCalcIcmsSubstTributaria._Regex = null;
            this.cbostCalcIcmsSubstTributaria._situacao = true;
            this.cbostCalcIcmsSubstTributaria._Table = "Tipo_operacao";
            this.cbostCalcIcmsSubstTributaria._TamanhoComponente = 80;
            this.cbostCalcIcmsSubstTributaria._TamanhoMaiorLabel = 300;
            this.cbostCalcIcmsSubstTributaria.BackColor = System.Drawing.Color.Transparent;
            this.cbostCalcIcmsSubstTributaria.Base = null;
            this.cbostCalcIcmsSubstTributaria.Color = System.Drawing.Color.White;
            this.cbostCalcIcmsSubstTributaria.DataSource = null;
            this.cbostCalcIcmsSubstTributaria.DisplayMember = "DisplayMember";
            this.cbostCalcIcmsSubstTributaria.Location = new System.Drawing.Point(144, 373);
            this.cbostCalcIcmsSubstTributaria.Margin = new System.Windows.Forms.Padding(144, 3, 15, 3);
            this.cbostCalcIcmsSubstTributaria.Name = "cbostCalcIcmsSubstTributaria";
            this.cbostCalcIcmsSubstTributaria.objConfigComponenteModel = null;
            this.cbostCalcIcmsSubstTributaria.SelectedIndex = -1;
            this.cbostCalcIcmsSubstTributaria.SelectedValue = 0;
            this.cbostCalcIcmsSubstTributaria.Size = new System.Drawing.Size(239, 21);
            this.cbostCalcIcmsSubstTributaria.TabIndex = 24;
            this.cbostCalcIcmsSubstTributaria.ValueMember = "ValueMember";
            // 
            // cbostCompoeBaseIcmsSubstTributaria
            // 
            this.cbostCompoeBaseIcmsSubstTributaria._Field = "stCompoeBaseIcmsSubstituicaoTributaria";
            this.cbostCompoeBaseIcmsSubstTributaria._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostCompoeBaseIcmsSubstTributaria._Itens")));
            this.cbostCompoeBaseIcmsSubstTributaria._LabelGroup = this.hlP_LabelSeparator_icms;
            this.cbostCompoeBaseIcmsSubstTributaria._LabelText = "Compõe a base de cálculo de icms subst. tributária icms?";
            this.cbostCompoeBaseIcmsSubstTributaria._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostCompoeBaseIcmsSubstTributaria._Regex = null;
            this.cbostCompoeBaseIcmsSubstTributaria._situacao = false;
            this.cbostCompoeBaseIcmsSubstTributaria._Table = "Tipo_operacao";
            this.cbostCompoeBaseIcmsSubstTributaria._TamanhoComponente = 314;
            this.cbostCompoeBaseIcmsSubstTributaria._TamanhoMaiorLabel = 300;
            this.cbostCompoeBaseIcmsSubstTributaria.BackColor = System.Drawing.Color.Transparent;
            this.cbostCompoeBaseIcmsSubstTributaria.Base = null;
            this.cbostCompoeBaseIcmsSubstTributaria.Color = System.Drawing.Color.White;
            this.cbostCompoeBaseIcmsSubstTributaria.DataSource = null;
            this.cbostCompoeBaseIcmsSubstTributaria.DisplayMember = "DisplayMember";
            this.cbostCompoeBaseIcmsSubstTributaria.Location = new System.Drawing.Point(6, 400);
            this.cbostCompoeBaseIcmsSubstTributaria.Margin = new System.Windows.Forms.Padding(6, 3, 15, 3);
            this.cbostCompoeBaseIcmsSubstTributaria.Name = "cbostCompoeBaseIcmsSubstTributaria";
            this.cbostCompoeBaseIcmsSubstTributaria.objConfigComponenteModel = null;
            this.cbostCompoeBaseIcmsSubstTributaria.SelectedIndex = -1;
            this.cbostCompoeBaseIcmsSubstTributaria.SelectedValue = 0;
            this.cbostCompoeBaseIcmsSubstTributaria.Size = new System.Drawing.Size(611, 21);
            this.cbostCompoeBaseIcmsSubstTributaria.TabIndex = 25;
            this.cbostCompoeBaseIcmsSubstTributaria.ValueMember = "ValueMember";
            // 
            // hlP_LabelSeparator_piscof
            // 
            this.hlP_LabelSeparator_piscof._LabelText = "Pis e cofins";
            this.hlP_LabelSeparator_piscof._TamanhoMaiorLabel = 0;
            this.hlP_LabelSeparator_piscof.BackColor = System.Drawing.Color.Transparent;
            this.hlP_LabelSeparator_piscof.Location = new System.Drawing.Point(3, 427);
            this.hlP_LabelSeparator_piscof.Name = "hlP_LabelSeparator_piscof";
            this.hlP_LabelSeparator_piscof.Size = new System.Drawing.Size(690, 18);
            this.hlP_LabelSeparator_piscof.TabIndex = 63;
            this.hlP_LabelSeparator_piscof.TabStop = false;
            // 
            // nudnCoeficienteSubstTributariaPis
            // 
            this.nudnCoeficienteSubstTributariaPis._Field = "nCoeficienteSubstituicaoTributariaPis";
            this.nudnCoeficienteSubstTributariaPis._LabelGroup = this.hlP_LabelSeparator_piscof;
            this.nudnCoeficienteSubstTributariaPis._LabelText = "Coeficiente de subst. tributária do pis";
            this.nudnCoeficienteSubstTributariaPis._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudnCoeficienteSubstTributariaPis._Regex = null;
            this.nudnCoeficienteSubstTributariaPis._Table = "Tipo_operacao";
            this.nudnCoeficienteSubstTributariaPis._TamanhoComponente = 137;
            this.nudnCoeficienteSubstTributariaPis._TamanhoMaiorLabel = 300;
            this.nudnCoeficienteSubstTributariaPis.BackColor = System.Drawing.Color.Transparent;
            this.nudnCoeficienteSubstTributariaPis.Base = null;
            this.nudnCoeficienteSubstTributariaPis.Color = System.Drawing.Color.White;
            this.nudnCoeficienteSubstTributariaPis.DecimalPlaces = 2;
            this.nudnCoeficienteSubstTributariaPis.Location = new System.Drawing.Point(102, 451);
            this.nudnCoeficienteSubstTributariaPis.Margin = new System.Windows.Forms.Padding(102, 3, 15, 3);
            this.nudnCoeficienteSubstTributariaPis.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudnCoeficienteSubstTributariaPis.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudnCoeficienteSubstTributariaPis.Name = "nudnCoeficienteSubstTributariaPis";
            this.nudnCoeficienteSubstTributariaPis.objConfigComponenteModel = null;
            this.nudnCoeficienteSubstTributariaPis.ReadOnly = false;
            this.nudnCoeficienteSubstTributariaPis.Size = new System.Drawing.Size(338, 22);
            this.nudnCoeficienteSubstTributariaPis.TabIndex = 28;
            this.nudnCoeficienteSubstTributariaPis.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudnCoeficienteSubstTributariaPis.ValueInt = 0;
            // 
            // nudnCoeficienteSubstTributariaCofins
            // 
            this.nudnCoeficienteSubstTributariaCofins._Field = "nCoeficienteSubstituicaoTributariaCofins";
            this.nudnCoeficienteSubstTributariaCofins._LabelGroup = this.hlP_LabelSeparator_piscof;
            this.nudnCoeficienteSubstTributariaCofins._LabelText = "Coeficiente de subst. tributária do cofins";
            this.nudnCoeficienteSubstTributariaCofins._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudnCoeficienteSubstTributariaCofins._Regex = null;
            this.nudnCoeficienteSubstTributariaCofins._Table = "Tipo_operacao";
            this.nudnCoeficienteSubstTributariaCofins._TamanhoComponente = 141;
            this.nudnCoeficienteSubstTributariaCofins._TamanhoMaiorLabel = 300;
            this.nudnCoeficienteSubstTributariaCofins.BackColor = System.Drawing.Color.Transparent;
            this.nudnCoeficienteSubstTributariaCofins.Base = null;
            this.nudnCoeficienteSubstTributariaCofins.Color = System.Drawing.Color.White;
            this.nudnCoeficienteSubstTributariaCofins.DecimalPlaces = 2;
            this.nudnCoeficienteSubstTributariaCofins.Location = new System.Drawing.Point(86, 479);
            this.nudnCoeficienteSubstTributariaCofins.Margin = new System.Windows.Forms.Padding(86, 3, 15, 3);
            this.nudnCoeficienteSubstTributariaCofins.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudnCoeficienteSubstTributariaCofins.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudnCoeficienteSubstTributariaCofins.Name = "nudnCoeficienteSubstTributariaCofins";
            this.nudnCoeficienteSubstTributariaCofins.objConfigComponenteModel = null;
            this.nudnCoeficienteSubstTributariaCofins.ReadOnly = false;
            this.nudnCoeficienteSubstTributariaCofins.Size = new System.Drawing.Size(358, 22);
            this.nudnCoeficienteSubstTributariaCofins.TabIndex = 29;
            this.nudnCoeficienteSubstTributariaCofins.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudnCoeficienteSubstTributariaCofins.ValueInt = 0;
            // 
            // nudpPis
            // 
            this.nudpPis._Field = "pPis";
            this.nudpPis._LabelGroup = this.hlP_LabelSeparator_piscof;
            this.nudpPis._LabelText = "Alíquota de pis";
            this.nudpPis._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudpPis._Regex = null;
            this.nudpPis._Table = "Tipo_operacao";
            this.nudpPis._TamanhoComponente = 159;
            this.nudpPis._TamanhoMaiorLabel = 300;
            this.nudpPis.BackColor = System.Drawing.Color.Transparent;
            this.nudpPis.Base = null;
            this.nudpPis.Color = System.Drawing.Color.White;
            this.nudpPis.DecimalPlaces = 2;
            this.nudpPis.Location = new System.Drawing.Point(218, 507);
            this.nudpPis.Margin = new System.Windows.Forms.Padding(218, 3, 15, 3);
            this.nudpPis.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudpPis.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudpPis.Name = "nudpPis";
            this.nudpPis.objConfigComponenteModel = null;
            this.nudpPis.ReadOnly = false;
            this.nudpPis.Size = new System.Drawing.Size(244, 25);
            this.nudpPis.TabIndex = 44;
            this.nudpPis.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudpPis.ValueInt = 0;
            // 
            // nudpCofins
            // 
            this.nudpCofins._Field = "pCofins";
            this.nudpCofins._LabelGroup = this.hlP_LabelSeparator_piscof;
            this.nudpCofins._LabelText = "Alíquota de cofins";
            this.nudpCofins._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudpCofins._Regex = null;
            this.nudpCofins._Table = "Tipo_operacao";
            this.nudpCofins._TamanhoComponente = 204;
            this.nudpCofins._TamanhoMaiorLabel = 300;
            this.nudpCofins.BackColor = System.Drawing.Color.Transparent;
            this.nudpCofins.Base = null;
            this.nudpCofins.Color = System.Drawing.Color.White;
            this.nudpCofins.DecimalPlaces = 2;
            this.nudpCofins.Location = new System.Drawing.Point(910, 3);
            this.nudpCofins.Margin = new System.Windows.Forms.Padding(202, 3, 15, 3);
            this.nudpCofins.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudpCofins.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudpCofins.Name = "nudpCofins";
            this.nudpCofins.objConfigComponenteModel = null;
            this.nudpCofins.ReadOnly = false;
            this.nudpCofins.Size = new System.Drawing.Size(305, 29);
            this.nudpCofins.TabIndex = 45;
            this.nudpCofins.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudpCofins.ValueInt = 0;
            // 
            // cbostCalcPisCofins
            // 
            this.cbostCalcPisCofins._Field = "stCalculaPisCofins";
            this.cbostCalcPisCofins._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostCalcPisCofins._Itens")));
            this.cbostCalcPisCofins._LabelGroup = this.hlP_LabelSeparator_piscof;
            this.cbostCalcPisCofins._LabelText = "Calcula pis e cofins?";
            this.cbostCalcPisCofins._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostCalcPisCofins._Regex = null;
            this.cbostCalcPisCofins._situacao = false;
            this.cbostCalcPisCofins._Table = "Tipo_operacao";
            this.cbostCalcPisCofins._TamanhoComponente = 140;
            this.cbostCalcPisCofins._TamanhoMaiorLabel = 300;
            this.cbostCalcPisCofins.BackColor = System.Drawing.Color.Transparent;
            this.cbostCalcPisCofins.Base = null;
            this.cbostCalcPisCofins.Color = System.Drawing.Color.White;
            this.cbostCalcPisCofins.DataSource = null;
            this.cbostCalcPisCofins.DisplayMember = "DisplayMember";
            this.cbostCalcPisCofins.Location = new System.Drawing.Point(901, 38);
            this.cbostCalcPisCofins.Margin = new System.Windows.Forms.Padding(193, 3, 15, 3);
            this.cbostCalcPisCofins.Name = "cbostCalcPisCofins";
            this.cbostCalcPisCofins.objConfigComponenteModel = null;
            this.cbostCalcPisCofins.SelectedIndex = -1;
            this.cbostCalcPisCofins.SelectedValue = 0;
            this.cbostCalcPisCofins.Size = new System.Drawing.Size(250, 21);
            this.cbostCalcPisCofins.TabIndex = 26;
            this.cbostCalcPisCofins.ValueMember = "ValueMember";
            // 
            // cbostRegimeTributacaoPisCofins
            // 
            this.cbostRegimeTributacaoPisCofins._Field = "stRegimeTributacaoPisCofins";
            this.cbostRegimeTributacaoPisCofins._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostRegimeTributacaoPisCofins._Itens")));
            this.cbostRegimeTributacaoPisCofins._LabelGroup = this.hlP_LabelSeparator_piscof;
            this.cbostRegimeTributacaoPisCofins._LabelText = "Regime do pis e cofins";
            this.cbostRegimeTributacaoPisCofins._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostRegimeTributacaoPisCofins._Regex = null;
            this.cbostRegimeTributacaoPisCofins._situacao = false;
            this.cbostRegimeTributacaoPisCofins._Table = "Tipo_operacao";
            this.cbostRegimeTributacaoPisCofins._TamanhoComponente = 141;
            this.cbostRegimeTributacaoPisCofins._TamanhoMaiorLabel = 300;
            this.cbostRegimeTributacaoPisCofins.BackColor = System.Drawing.Color.Transparent;
            this.cbostRegimeTributacaoPisCofins.Base = null;
            this.cbostRegimeTributacaoPisCofins.Color = System.Drawing.Color.White;
            this.cbostRegimeTributacaoPisCofins.DataSource = null;
            this.cbostRegimeTributacaoPisCofins.DisplayMember = "DisplayMember";
            this.cbostRegimeTributacaoPisCofins.Location = new System.Drawing.Point(888, 65);
            this.cbostRegimeTributacaoPisCofins.Margin = new System.Windows.Forms.Padding(180, 3, 15, 3);
            this.cbostRegimeTributacaoPisCofins.Name = "cbostRegimeTributacaoPisCofins";
            this.cbostRegimeTributacaoPisCofins.objConfigComponenteModel = null;
            this.cbostRegimeTributacaoPisCofins.SelectedIndex = -1;
            this.cbostRegimeTributacaoPisCofins.SelectedValue = 0;
            this.cbostRegimeTributacaoPisCofins.Size = new System.Drawing.Size(264, 21);
            this.cbostRegimeTributacaoPisCofins.TabIndex = 27;
            this.cbostRegimeTributacaoPisCofins.ValueMember = "ValueMember";
            // 
            // hlP_PesquisaidCSTPis
            // 
            this.hlP_PesquisaidCSTPis._Field = "idCSTPis";
            this.hlP_PesquisaidCSTPis._LabelGroup = this.hlP_LabelSeparator_piscof;
            this.hlP_PesquisaidCSTPis._LabelText = "Situação tributária do pis";
            this.hlP_PesquisaidCSTPis._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidCSTPis._ListaCamposDisplay")));
            this.hlP_PesquisaidCSTPis._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidCSTPis._ListaValoresDisplay")));
            this.hlP_PesquisaidCSTPis._NomeCampoPK = "ID";
            this.hlP_PesquisaidCSTPis._NomeFormCadastroOriginal = "FormStPIS";
            this.hlP_PesquisaidCSTPis._NomeView = "vwStPIS";
            this.hlP_PesquisaidCSTPis._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisaidCSTPis._Regex = null;
            this.hlP_PesquisaidCSTPis._Table = "Tipo_operacao";
            this.hlP_PesquisaidCSTPis._TamanhoComponente = 300;
            this.hlP_PesquisaidCSTPis._TamanhoMaiorLabel = 300;
            this.hlP_PesquisaidCSTPis._Vinculado = false;
            this.hlP_PesquisaidCSTPis.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidCSTPis.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidCSTPis.Base = null;
            this.hlP_PesquisaidCSTPis.Location = new System.Drawing.Point(874, 92);
            this.hlP_PesquisaidCSTPis.Margin = new System.Windows.Forms.Padding(166, 3, 15, 3);
            this.hlP_PesquisaidCSTPis.Name = "hlP_PesquisaidCSTPis";
            this.hlP_PesquisaidCSTPis.objConfigComponenteModel = null;
            this.hlP_PesquisaidCSTPis.ReadOnly = false;
            this.hlP_PesquisaidCSTPis.Size = new System.Drawing.Size(437, 21);
            this.hlP_PesquisaidCSTPis.TabIndex = 46;
            this.hlP_PesquisaidCSTPis.Value = 0;
            // 
            // hlP_PesquisaidCSTCofins
            // 
            this.hlP_PesquisaidCSTCofins._Field = "idCSTCofins";
            this.hlP_PesquisaidCSTCofins._LabelGroup = this.hlP_LabelSeparator_piscof;
            this.hlP_PesquisaidCSTCofins._LabelText = "Situação tributária do cofins";
            this.hlP_PesquisaidCSTCofins._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidCSTCofins._ListaCamposDisplay")));
            this.hlP_PesquisaidCSTCofins._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidCSTCofins._ListaValoresDisplay")));
            this.hlP_PesquisaidCSTCofins._NomeCampoPK = "ID";
            this.hlP_PesquisaidCSTCofins._NomeFormCadastroOriginal = "FormStCOFINS";
            this.hlP_PesquisaidCSTCofins._NomeView = "vwStCOFINS";
            this.hlP_PesquisaidCSTCofins._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisaidCSTCofins._Regex = null;
            this.hlP_PesquisaidCSTCofins._Table = "Tipo_operacao";
            this.hlP_PesquisaidCSTCofins._TamanhoComponente = 300;
            this.hlP_PesquisaidCSTCofins._TamanhoMaiorLabel = 300;
            this.hlP_PesquisaidCSTCofins._Vinculado = false;
            this.hlP_PesquisaidCSTCofins.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidCSTCofins.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidCSTCofins.Base = null;
            this.hlP_PesquisaidCSTCofins.Location = new System.Drawing.Point(858, 119);
            this.hlP_PesquisaidCSTCofins.Margin = new System.Windows.Forms.Padding(150, 3, 15, 3);
            this.hlP_PesquisaidCSTCofins.Name = "hlP_PesquisaidCSTCofins";
            this.hlP_PesquisaidCSTCofins.objConfigComponenteModel = null;
            this.hlP_PesquisaidCSTCofins.ReadOnly = false;
            this.hlP_PesquisaidCSTCofins.Size = new System.Drawing.Size(453, 21);
            this.hlP_PesquisaidCSTCofins.TabIndex = 47;
            this.hlP_PesquisaidCSTCofins.Value = 0;
            // 
            // cbostCompoeBaseNormalPiscofins
            // 
            this.cbostCompoeBaseNormalPiscofins._Field = "stCompoeBaseNormalPiscofins";
            this.cbostCompoeBaseNormalPiscofins._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostCompoeBaseNormalPiscofins._Itens")));
            this.cbostCompoeBaseNormalPiscofins._LabelGroup = this.hlP_LabelSeparator_piscof;
            this.cbostCompoeBaseNormalPiscofins._LabelText = "Compõe a base de cálculo normal do pis e cofins";
            this.cbostCompoeBaseNormalPiscofins._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostCompoeBaseNormalPiscofins._Regex = null;
            this.cbostCompoeBaseNormalPiscofins._situacao = false;
            this.cbostCompoeBaseNormalPiscofins._Table = "Tipo_operacao";
            this.cbostCompoeBaseNormalPiscofins._TamanhoComponente = 314;
            this.cbostCompoeBaseNormalPiscofins._TamanhoMaiorLabel = 300;
            this.cbostCompoeBaseNormalPiscofins.BackColor = System.Drawing.Color.Transparent;
            this.cbostCompoeBaseNormalPiscofins.Base = null;
            this.cbostCompoeBaseNormalPiscofins.Color = System.Drawing.Color.White;
            this.cbostCompoeBaseNormalPiscofins.DataSource = null;
            this.cbostCompoeBaseNormalPiscofins.DisplayMember = "DisplayMember";
            this.cbostCompoeBaseNormalPiscofins.Location = new System.Drawing.Point(753, 146);
            this.cbostCompoeBaseNormalPiscofins.Margin = new System.Windows.Forms.Padding(45, 3, 15, 3);
            this.cbostCompoeBaseNormalPiscofins.Name = "cbostCompoeBaseNormalPiscofins";
            this.cbostCompoeBaseNormalPiscofins.objConfigComponenteModel = null;
            this.cbostCompoeBaseNormalPiscofins.SelectedIndex = -1;
            this.cbostCompoeBaseNormalPiscofins.SelectedValue = 0;
            this.cbostCompoeBaseNormalPiscofins.Size = new System.Drawing.Size(572, 21);
            this.cbostCompoeBaseNormalPiscofins.TabIndex = 48;
            this.cbostCompoeBaseNormalPiscofins.ValueMember = "ValueMember";
            // 
            // cbostCompoeBaseSubtTribPis
            // 
            this.cbostCompoeBaseSubtTribPis._Field = "stCompoeBaseSubtTribPis";
            this.cbostCompoeBaseSubtTribPis._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostCompoeBaseSubtTribPis._Itens")));
            this.cbostCompoeBaseSubtTribPis._LabelGroup = this.hlP_LabelSeparator_piscof;
            this.cbostCompoeBaseSubtTribPis._LabelText = "Compõe a base de cálculo da subst. tributária do pis";
            this.cbostCompoeBaseSubtTribPis._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostCompoeBaseSubtTribPis._Regex = null;
            this.cbostCompoeBaseSubtTribPis._situacao = false;
            this.cbostCompoeBaseSubtTribPis._Table = "Tipo_operacao";
            this.cbostCompoeBaseSubtTribPis._TamanhoComponente = 396;
            this.cbostCompoeBaseSubtTribPis._TamanhoMaiorLabel = 300;
            this.cbostCompoeBaseSubtTribPis.BackColor = System.Drawing.Color.Transparent;
            this.cbostCompoeBaseSubtTribPis.Base = null;
            this.cbostCompoeBaseSubtTribPis.Color = System.Drawing.Color.White;
            this.cbostCompoeBaseSubtTribPis.DataSource = null;
            this.cbostCompoeBaseSubtTribPis.DisplayMember = "DisplayMember";
            this.cbostCompoeBaseSubtTribPis.Location = new System.Drawing.Point(734, 173);
            this.cbostCompoeBaseSubtTribPis.Margin = new System.Windows.Forms.Padding(26, 3, 15, 3);
            this.cbostCompoeBaseSubtTribPis.Name = "cbostCompoeBaseSubtTribPis";
            this.cbostCompoeBaseSubtTribPis.objConfigComponenteModel = null;
            this.cbostCompoeBaseSubtTribPis.SelectedIndex = -1;
            this.cbostCompoeBaseSubtTribPis.SelectedValue = 0;
            this.cbostCompoeBaseSubtTribPis.Size = new System.Drawing.Size(673, 21);
            this.cbostCompoeBaseSubtTribPis.TabIndex = 49;
            this.cbostCompoeBaseSubtTribPis.ValueMember = "ValueMember";
            // 
            // cbostCompoeBaseSubtTribCofins
            // 
            this.cbostCompoeBaseSubtTribCofins._Field = "stCompoeBaseSubtTribCofins";
            this.cbostCompoeBaseSubtTribCofins._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostCompoeBaseSubtTribCofins._Itens")));
            this.cbostCompoeBaseSubtTribCofins._LabelGroup = this.hlP_LabelSeparator_piscof;
            this.cbostCompoeBaseSubtTribCofins._LabelText = "Compõe a base de cálculo da subst. tributária do cofins";
            this.cbostCompoeBaseSubtTribCofins._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostCompoeBaseSubtTribCofins._Regex = null;
            this.cbostCompoeBaseSubtTribCofins._situacao = false;
            this.cbostCompoeBaseSubtTribCofins._Table = "Tipo_operacao";
            this.cbostCompoeBaseSubtTribCofins._TamanhoComponente = 396;
            this.cbostCompoeBaseSubtTribCofins._TamanhoMaiorLabel = 300;
            this.cbostCompoeBaseSubtTribCofins.BackColor = System.Drawing.Color.Transparent;
            this.cbostCompoeBaseSubtTribCofins.Base = null;
            this.cbostCompoeBaseSubtTribCofins.Color = System.Drawing.Color.White;
            this.cbostCompoeBaseSubtTribCofins.DataSource = null;
            this.cbostCompoeBaseSubtTribCofins.DisplayMember = "DisplayMember";
            this.cbostCompoeBaseSubtTribCofins.Location = new System.Drawing.Point(718, 200);
            this.cbostCompoeBaseSubtTribCofins.Margin = new System.Windows.Forms.Padding(10, 3, 15, 3);
            this.cbostCompoeBaseSubtTribCofins.Name = "cbostCompoeBaseSubtTribCofins";
            this.cbostCompoeBaseSubtTribCofins.objConfigComponenteModel = null;
            this.cbostCompoeBaseSubtTribCofins.SelectedIndex = -1;
            this.cbostCompoeBaseSubtTribCofins.SelectedValue = 0;
            this.cbostCompoeBaseSubtTribCofins.Size = new System.Drawing.Size(689, 21);
            this.cbostCompoeBaseSubtTribCofins.TabIndex = 50;
            this.cbostCompoeBaseSubtTribCofins.ValueMember = "ValueMember";
            // 
            // hlP_LabelSeparatorServico
            // 
            this.hlP_LabelSeparatorServico._LabelText = "Serviço";
            this.hlP_LabelSeparatorServico._TamanhoMaiorLabel = 0;
            this.hlP_LabelSeparatorServico.BackColor = System.Drawing.Color.Transparent;
            this.hlP_LabelSeparatorServico.Location = new System.Drawing.Point(711, 227);
            this.hlP_LabelSeparatorServico.Name = "hlP_LabelSeparatorServico";
            this.hlP_LabelSeparatorServico.Size = new System.Drawing.Size(696, 18);
            this.hlP_LabelSeparatorServico.TabIndex = 64;
            this.hlP_LabelSeparatorServico.TabStop = false;
            // 
            // nudpIss
            // 
            this.nudpIss._Field = "pIss";
            this.nudpIss._LabelGroup = this.hlP_LabelSeparatorServico;
            this.nudpIss._LabelText = "Alíquota de iss";
            this.nudpIss._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudpIss._Regex = null;
            this.nudpIss._Table = "Tipo_operacao";
            this.nudpIss._TamanhoComponente = 157;
            this.nudpIss._TamanhoMaiorLabel = 300;
            this.nudpIss.BackColor = System.Drawing.Color.Transparent;
            this.nudpIss.Base = null;
            this.nudpIss.Color = System.Drawing.Color.White;
            this.nudpIss.DecimalPlaces = 2;
            this.nudpIss.Location = new System.Drawing.Point(928, 251);
            this.nudpIss.Margin = new System.Windows.Forms.Padding(220, 3, 15, 3);
            this.nudpIss.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudpIss.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudpIss.Name = "nudpIss";
            this.nudpIss.objConfigComponenteModel = null;
            this.nudpIss.ReadOnly = false;
            this.nudpIss.Size = new System.Drawing.Size(240, 25);
            this.nudpIss.TabIndex = 52;
            this.nudpIss.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudpIss.ValueInt = 0;
            // 
            // nudpReducaoBaseIrrf
            // 
            this.nudpReducaoBaseIrrf._Field = "pReducaoBaseIrrf";
            this.nudpReducaoBaseIrrf._LabelGroup = this.hlP_LabelSeparatorServico;
            this.nudpReducaoBaseIrrf._LabelText = "Alíquota de redução de base de cálculo de irrf";
            this.nudpReducaoBaseIrrf._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudpReducaoBaseIrrf._Regex = null;
            this.nudpReducaoBaseIrrf._Table = "Tipo_operacao";
            this.nudpReducaoBaseIrrf._TamanhoComponente = 207;
            this.nudpReducaoBaseIrrf._TamanhoMaiorLabel = 300;
            this.nudpReducaoBaseIrrf.BackColor = System.Drawing.Color.Transparent;
            this.nudpReducaoBaseIrrf.Base = null;
            this.nudpReducaoBaseIrrf.Color = System.Drawing.Color.White;
            this.nudpReducaoBaseIrrf.DecimalPlaces = 2;
            this.nudpReducaoBaseIrrf.Location = new System.Drawing.Point(767, 282);
            this.nudpReducaoBaseIrrf.Margin = new System.Windows.Forms.Padding(59, 3, 15, 3);
            this.nudpReducaoBaseIrrf.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudpReducaoBaseIrrf.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudpReducaoBaseIrrf.Name = "nudpReducaoBaseIrrf";
            this.nudpReducaoBaseIrrf.objConfigComponenteModel = null;
            this.nudpReducaoBaseIrrf.ReadOnly = false;
            this.nudpReducaoBaseIrrf.Size = new System.Drawing.Size(451, 25);
            this.nudpReducaoBaseIrrf.TabIndex = 54;
            this.nudpReducaoBaseIrrf.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudpReducaoBaseIrrf.ValueInt = 0;
            // 
            // nudpIrrf
            // 
            this.nudpIrrf._Field = "pIrrf";
            this.nudpIrrf._LabelGroup = this.hlP_LabelSeparatorServico;
            this.nudpIrrf._LabelText = "Alíquota de irrf";
            this.nudpIrrf._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudpIrrf._Regex = null;
            this.nudpIrrf._Table = "Tipo_operacao";
            this.nudpIrrf._TamanhoComponente = 160;
            this.nudpIrrf._TamanhoMaiorLabel = 300;
            this.nudpIrrf.BackColor = System.Drawing.Color.Transparent;
            this.nudpIrrf.Base = null;
            this.nudpIrrf.Color = System.Drawing.Color.White;
            this.nudpIrrf.DecimalPlaces = 2;
            this.nudpIrrf.Location = new System.Drawing.Point(926, 313);
            this.nudpIrrf.Margin = new System.Windows.Forms.Padding(218, 3, 15, 3);
            this.nudpIrrf.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudpIrrf.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudpIrrf.Name = "nudpIrrf";
            this.nudpIrrf.objConfigComponenteModel = null;
            this.nudpIrrf.ReadOnly = false;
            this.nudpIrrf.Size = new System.Drawing.Size(245, 25);
            this.nudpIrrf.TabIndex = 55;
            this.nudpIrrf.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudpIrrf.ValueInt = 0;
            // 
            // nudpReducaoBaseInss
            // 
            this.nudpReducaoBaseInss._Field = "pReducaoBaseInss";
            this.nudpReducaoBaseInss._LabelGroup = this.hlP_LabelSeparatorServico;
            this.nudpReducaoBaseInss._LabelText = "Alíquota de redução de base de cálculo de inss";
            this.nudpReducaoBaseInss._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudpReducaoBaseInss._Regex = null;
            this.nudpReducaoBaseInss._Table = "Tipo_operacao";
            this.nudpReducaoBaseInss._TamanhoComponente = 207;
            this.nudpReducaoBaseInss._TamanhoMaiorLabel = 300;
            this.nudpReducaoBaseInss.BackColor = System.Drawing.Color.Transparent;
            this.nudpReducaoBaseInss.Base = null;
            this.nudpReducaoBaseInss.Color = System.Drawing.Color.White;
            this.nudpReducaoBaseInss.DecimalPlaces = 2;
            this.nudpReducaoBaseInss.Location = new System.Drawing.Point(762, 344);
            this.nudpReducaoBaseInss.Margin = new System.Windows.Forms.Padding(54, 3, 15, 3);
            this.nudpReducaoBaseInss.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudpReducaoBaseInss.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudpReducaoBaseInss.Name = "nudpReducaoBaseInss";
            this.nudpReducaoBaseInss.objConfigComponenteModel = null;
            this.nudpReducaoBaseInss.ReadOnly = false;
            this.nudpReducaoBaseInss.Size = new System.Drawing.Size(456, 25);
            this.nudpReducaoBaseInss.TabIndex = 58;
            this.nudpReducaoBaseInss.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudpReducaoBaseInss.ValueInt = 0;
            // 
            // nudpInss
            // 
            this.nudpInss._Field = "pInss";
            this.nudpInss._LabelGroup = this.hlP_LabelSeparatorServico;
            this.nudpInss._LabelText = "Alíquota de inss";
            this.nudpInss._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudpInss._Regex = null;
            this.nudpInss._Table = "Tipo_operacao";
            this.nudpInss._TamanhoComponente = 160;
            this.nudpInss._TamanhoMaiorLabel = 300;
            this.nudpInss.BackColor = System.Drawing.Color.Transparent;
            this.nudpInss.Base = null;
            this.nudpInss.Color = System.Drawing.Color.White;
            this.nudpInss.DecimalPlaces = 2;
            this.nudpInss.Location = new System.Drawing.Point(921, 375);
            this.nudpInss.Margin = new System.Windows.Forms.Padding(213, 3, 15, 3);
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
            this.nudpInss.Size = new System.Drawing.Size(250, 25);
            this.nudpInss.TabIndex = 59;
            this.nudpInss.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudpInss.ValueInt = 0;
            // 
            // cbostCalcIss
            // 
            this.cbostCalcIss._Field = "stCalculaIss";
            this.cbostCalcIss._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostCalcIss._Itens")));
            this.cbostCalcIss._LabelGroup = this.hlP_LabelSeparatorServico;
            this.cbostCalcIss._LabelText = "Calcula iss?";
            this.cbostCalcIss._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostCalcIss._Regex = null;
            this.cbostCalcIss._situacao = true;
            this.cbostCalcIss._Table = "Tipo_operacao";
            this.cbostCalcIss._TamanhoComponente = 80;
            this.cbostCalcIss._TamanhoMaiorLabel = 300;
            this.cbostCalcIss.BackColor = System.Drawing.Color.Transparent;
            this.cbostCalcIss.Base = null;
            this.cbostCalcIss.Color = System.Drawing.Color.White;
            this.cbostCalcIss.DataSource = null;
            this.cbostCalcIss.DisplayMember = "DisplayMember";
            this.cbostCalcIss.Location = new System.Drawing.Point(946, 406);
            this.cbostCalcIss.Margin = new System.Windows.Forms.Padding(238, 3, 15, 3);
            this.cbostCalcIss.Name = "cbostCalcIss";
            this.cbostCalcIss.objConfigComponenteModel = null;
            this.cbostCalcIss.SelectedIndex = -1;
            this.cbostCalcIss.SelectedValue = 0;
            this.cbostCalcIss.Size = new System.Drawing.Size(145, 21);
            this.cbostCalcIss.TabIndex = 51;
            this.cbostCalcIss.ValueMember = "ValueMember";
            // 
            // cbostCalcIrrf
            // 
            this.cbostCalcIrrf._Field = "stCalculaIrrf";
            this.cbostCalcIrrf._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostCalcIrrf._Itens")));
            this.cbostCalcIrrf._LabelGroup = this.hlP_LabelSeparatorServico;
            this.cbostCalcIrrf._LabelText = "Calcula irrf?";
            this.cbostCalcIrrf._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostCalcIrrf._Regex = null;
            this.cbostCalcIrrf._situacao = true;
            this.cbostCalcIrrf._Table = "Tipo_operacao";
            this.cbostCalcIrrf._TamanhoComponente = 80;
            this.cbostCalcIrrf._TamanhoMaiorLabel = 300;
            this.cbostCalcIrrf.BackColor = System.Drawing.Color.Transparent;
            this.cbostCalcIrrf.Base = null;
            this.cbostCalcIrrf.Color = System.Drawing.Color.White;
            this.cbostCalcIrrf.DataSource = null;
            this.cbostCalcIrrf.DisplayMember = "DisplayMember";
            this.cbostCalcIrrf.Location = new System.Drawing.Point(944, 433);
            this.cbostCalcIrrf.Margin = new System.Windows.Forms.Padding(236, 3, 15, 3);
            this.cbostCalcIrrf.Name = "cbostCalcIrrf";
            this.cbostCalcIrrf.objConfigComponenteModel = null;
            this.cbostCalcIrrf.SelectedIndex = -1;
            this.cbostCalcIrrf.SelectedValue = 0;
            this.cbostCalcIrrf.Size = new System.Drawing.Size(147, 21);
            this.cbostCalcIrrf.TabIndex = 53;
            this.cbostCalcIrrf.ValueMember = "ValueMember";
            // 
            // cbostCalcCsll
            // 
            this.cbostCalcCsll._Field = "stCalculaCsll";
            this.cbostCalcCsll._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostCalcCsll._Itens")));
            this.cbostCalcCsll._LabelGroup = this.hlP_LabelSeparatorServico;
            this.cbostCalcCsll._LabelText = "Calcula csll?";
            this.cbostCalcCsll._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostCalcCsll._Regex = null;
            this.cbostCalcCsll._situacao = true;
            this.cbostCalcCsll._Table = "Tipo_operacao";
            this.cbostCalcCsll._TamanhoComponente = 80;
            this.cbostCalcCsll._TamanhoMaiorLabel = 300;
            this.cbostCalcCsll.BackColor = System.Drawing.Color.Transparent;
            this.cbostCalcCsll.Base = null;
            this.cbostCalcCsll.Color = System.Drawing.Color.White;
            this.cbostCalcCsll.DataSource = null;
            this.cbostCalcCsll.DisplayMember = "DisplayMember";
            this.cbostCalcCsll.Location = new System.Drawing.Point(943, 460);
            this.cbostCalcCsll.Margin = new System.Windows.Forms.Padding(235, 3, 15, 3);
            this.cbostCalcCsll.Name = "cbostCalcCsll";
            this.cbostCalcCsll.objConfigComponenteModel = null;
            this.cbostCalcCsll.SelectedIndex = -1;
            this.cbostCalcCsll.SelectedValue = 0;
            this.cbostCalcCsll.Size = new System.Drawing.Size(148, 21);
            this.cbostCalcCsll.TabIndex = 56;
            this.cbostCalcCsll.ValueMember = "ValueMember";
            // 
            // cbostCalcInss
            // 
            this.cbostCalcInss._Field = "stCalculaInss";
            this.cbostCalcInss._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostCalcInss._Itens")));
            this.cbostCalcInss._LabelGroup = this.hlP_LabelSeparatorServico;
            this.cbostCalcInss._LabelText = "Calcula inss?";
            this.cbostCalcInss._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostCalcInss._Regex = null;
            this.cbostCalcInss._situacao = true;
            this.cbostCalcInss._Table = "Tipo_operacao";
            this.cbostCalcInss._TamanhoComponente = 80;
            this.cbostCalcInss._TamanhoMaiorLabel = 300;
            this.cbostCalcInss.BackColor = System.Drawing.Color.Transparent;
            this.cbostCalcInss.Base = null;
            this.cbostCalcInss.Color = System.Drawing.Color.White;
            this.cbostCalcInss.DataSource = null;
            this.cbostCalcInss.DisplayMember = "DisplayMember";
            this.cbostCalcInss.Location = new System.Drawing.Point(939, 487);
            this.cbostCalcInss.Margin = new System.Windows.Forms.Padding(231, 3, 15, 3);
            this.cbostCalcInss.Name = "cbostCalcInss";
            this.cbostCalcInss.objConfigComponenteModel = null;
            this.cbostCalcInss.SelectedIndex = -1;
            this.cbostCalcInss.SelectedValue = 0;
            this.cbostCalcInss.Size = new System.Drawing.Size(152, 21);
            this.cbostCalcInss.TabIndex = 57;
            this.cbostCalcInss.ValueMember = "ValueMember";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage5.Controls.Add(this.dgvReducao);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1346, 569);
            this.tabPage5.TabIndex = 7;
            this.tabPage5.Tag = false;
            this.tabPage5.Text = "Redução base cálculo";
            // 
            // dgvReducao
            // 
            this.dgvReducao.Altera = false;
            this.dgvReducao.AutoGenerateColumns = false;
            this.dgvReducao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvReducao.cm = null;
            this.dgvReducao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReducao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUf,
            this.pReducaoIcms,
            this.pReducaoIcmsSubstTributaria});
            this.dgvReducao.DataSource = this.bsOperacaoreducaobase;
            this.dgvReducao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReducao.DragDropLinha = false;
            this.dgvReducao.Exclui = false;
            this.dgvReducao.Inclui = false;
            this.dgvReducao.Location = new System.Drawing.Point(0, 0);
            this.dgvReducao.Name = "dgvReducao";
            this.dgvReducao.RowHeadersWidth = 15;
            this.dgvReducao.Size = new System.Drawing.Size(1346, 569);
            this.dgvReducao.TabIndex = 5;
            this.dgvReducao.Tag = "Operacao_reducao_base";
            // 
            // idUf
            // 
            this.idUf.DataPropertyName = "idUf";
            this.idUf.HeaderText = "UF";
            this.idUf.Name = "idUf";
            this.idUf.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idUf.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idUf.Width = 50;
            // 
            // pReducaoIcms
            // 
            this.pReducaoIcms.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.pReducaoIcms.DataPropertyName = "pReducaoIcms";
            this.pReducaoIcms.HeaderText = "% de Redução de base icms";
            this.pReducaoIcms.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pReducaoIcms.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.pReducaoIcms.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.pReducaoIcms.Name = "pReducaoIcms";
            this.pReducaoIcms.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pReducaoIcms.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pReducaoIcms.Width = 200;
            // 
            // pReducaoIcmsSubstTributaria
            // 
            this.pReducaoIcmsSubstTributaria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.pReducaoIcmsSubstTributaria.DataPropertyName = "pReducaoIcmsSubstTributaria";
            this.pReducaoIcmsSubstTributaria.HeaderText = "% de Redução de base icms subst. tributária";
            this.pReducaoIcmsSubstTributaria.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pReducaoIcmsSubstTributaria.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.pReducaoIcmsSubstTributaria.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.pReducaoIcmsSubstTributaria.Name = "pReducaoIcmsSubstTributaria";
            this.pReducaoIcmsSubstTributaria.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pReducaoIcmsSubstTributaria.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pReducaoIcmsSubstTributaria.Width = 300;
            // 
            // bsOperacaoreducaobase
            // 
            this.bsOperacaoreducaobase.DataSource = typeof(HLP.Models.Entries.Fiscal.Operacao_reducao_baseModel);
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage6.Controls.Add(this.kryptonPanel5);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1346, 569);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Tag = false;
            this.tabPage6.Text = "Produção";
            // 
            // kryptonPanel5
            // 
            this.kryptonPanel5.BorderWidth = 0;
            this.kryptonPanel5.Controls.Add(this.flowLayoutPanel1);
            this.kryptonPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel5.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.kryptonPanel5.GradientToogleColors = false;
            this.kryptonPanel5.GradientUseBlend = false;
            this.kryptonPanel5.GradientUseSolid = true;
            this.kryptonPanel5.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel5.Name = "kryptonPanel5";
            this.kryptonPanel5.PersistentColors = false;
            this.kryptonPanel5.Size = new System.Drawing.Size(1346, 569);
            this.kryptonPanel5.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.hlP_LabelSeparatorProducao);
            this.flowLayoutPanel1.Controls.Add(this.cbostBaixaMaterialOp);
            this.flowLayoutPanel1.Controls.Add(this.cbostExplosaoMatOp);
            this.flowLayoutPanel1.Controls.Add(this.cbostEstoqueProdFimOP);
            this.flowLayoutPanel1.Controls.Add(this.cbostVinculaPedVenda);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1346, 569);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Tag = "Produção";
            // 
            // hlP_LabelSeparatorProducao
            // 
            this.hlP_LabelSeparatorProducao._LabelText = "Produção";
            this.hlP_LabelSeparatorProducao._TamanhoMaiorLabel = 0;
            this.hlP_LabelSeparatorProducao.BackColor = System.Drawing.Color.Transparent;
            this.hlP_LabelSeparatorProducao.Location = new System.Drawing.Point(3, 3);
            this.hlP_LabelSeparatorProducao.Name = "hlP_LabelSeparatorProducao";
            this.hlP_LabelSeparatorProducao.Size = new System.Drawing.Size(476, 18);
            this.hlP_LabelSeparatorProducao.TabIndex = 62;
            this.hlP_LabelSeparatorProducao.TabStop = false;
            // 
            // cbostBaixaMaterialOp
            // 
            this.cbostBaixaMaterialOp._Field = "stBaixaMaterialOp";
            this.cbostBaixaMaterialOp._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostBaixaMaterialOp._Itens")));
            this.cbostBaixaMaterialOp._LabelGroup = this.hlP_LabelSeparatorProducao;
            this.cbostBaixaMaterialOp._LabelText = "Quando baixa o material na ordem de produção?";
            this.cbostBaixaMaterialOp._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostBaixaMaterialOp._Regex = null;
            this.cbostBaixaMaterialOp._situacao = false;
            this.cbostBaixaMaterialOp._Table = "Tipo_operacao";
            this.cbostBaixaMaterialOp._TamanhoComponente = 188;
            this.cbostBaixaMaterialOp._TamanhoMaiorLabel = 280;
            this.cbostBaixaMaterialOp._Visible = true;
            this.cbostBaixaMaterialOp.BackColor = System.Drawing.Color.Transparent;
            this.cbostBaixaMaterialOp.Base = null;
            this.cbostBaixaMaterialOp.Color = System.Drawing.Color.White;
            this.cbostBaixaMaterialOp.DataSource = null;
            this.cbostBaixaMaterialOp.DisplayMember = "DisplayMember";
            this.cbostBaixaMaterialOp.Location = new System.Drawing.Point(24, 27);
            this.cbostBaixaMaterialOp.Margin = new System.Windows.Forms.Padding(24, 3, 15, 3);
            this.cbostBaixaMaterialOp.Name = "cbostBaixaMaterialOp";
            this.cbostBaixaMaterialOp.objConfigComponenteModel = null;
            this.cbostBaixaMaterialOp.SelectedIndex = -1;
            this.cbostBaixaMaterialOp.SelectedValue = 0;
            this.cbostBaixaMaterialOp.Size = new System.Drawing.Size(447, 21);
            this.cbostBaixaMaterialOp.TabIndex = 4;
            this.cbostBaixaMaterialOp.ValueMember = "ValueMember";
            // 
            // cbostExplosaoMatOp
            // 
            this.cbostExplosaoMatOp._Field = "stExplosaoMatOp";
            this.cbostExplosaoMatOp._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostExplosaoMatOp._Itens")));
            this.cbostExplosaoMatOp._LabelGroup = this.hlP_LabelSeparatorProducao;
            this.cbostExplosaoMatOp._LabelText = "Explosão de material na op";
            this.cbostExplosaoMatOp._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostExplosaoMatOp._Regex = null;
            this.cbostExplosaoMatOp._situacao = false;
            this.cbostExplosaoMatOp._Table = "Tipo_operacao";
            this.cbostExplosaoMatOp._TamanhoComponente = 135;
            this.cbostExplosaoMatOp._TamanhoMaiorLabel = 280;
            this.cbostExplosaoMatOp._Visible = true;
            this.cbostExplosaoMatOp.BackColor = System.Drawing.Color.Transparent;
            this.cbostExplosaoMatOp.Base = null;
            this.cbostExplosaoMatOp.Color = System.Drawing.Color.White;
            this.cbostExplosaoMatOp.DataSource = null;
            this.cbostExplosaoMatOp.DisplayMember = "DisplayMember";
            this.cbostExplosaoMatOp.Location = new System.Drawing.Point(137, 54);
            this.cbostExplosaoMatOp.Margin = new System.Windows.Forms.Padding(137, 3, 15, 3);
            this.cbostExplosaoMatOp.Name = "cbostExplosaoMatOp";
            this.cbostExplosaoMatOp.objConfigComponenteModel = null;
            this.cbostExplosaoMatOp.SelectedIndex = -1;
            this.cbostExplosaoMatOp.SelectedValue = 0;
            this.cbostExplosaoMatOp.Size = new System.Drawing.Size(281, 21);
            this.cbostExplosaoMatOp.TabIndex = 5;
            this.cbostExplosaoMatOp.ValueMember = "ValueMember";
            // 
            // cbostEstoqueProdFimOP
            // 
            this.cbostEstoqueProdFimOP._Field = "stEstoqueProdFimOP";
            this.cbostEstoqueProdFimOP._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostEstoqueProdFimOP._Itens")));
            this.cbostEstoqueProdFimOP._LabelGroup = this.hlP_LabelSeparatorProducao;
            this.cbostEstoqueProdFimOP._LabelText = "Estoque de produto no encerramento da op?";
            this.cbostEstoqueProdFimOP._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostEstoqueProdFimOP._Regex = null;
            this.cbostEstoqueProdFimOP._situacao = true;
            this.cbostEstoqueProdFimOP._Table = "Tipo_operacao";
            this.cbostEstoqueProdFimOP._TamanhoComponente = 80;
            this.cbostEstoqueProdFimOP._TamanhoMaiorLabel = 280;
            this.cbostEstoqueProdFimOP._Visible = true;
            this.cbostEstoqueProdFimOP.BackColor = System.Drawing.Color.Transparent;
            this.cbostEstoqueProdFimOP.Base = null;
            this.cbostEstoqueProdFimOP.Color = System.Drawing.Color.White;
            this.cbostEstoqueProdFimOP.DataSource = null;
            this.cbostEstoqueProdFimOP.DisplayMember = "DisplayMember";
            this.cbostEstoqueProdFimOP.Location = new System.Drawing.Point(43, 81);
            this.cbostEstoqueProdFimOP.Margin = new System.Windows.Forms.Padding(43, 3, 15, 3);
            this.cbostEstoqueProdFimOP.Name = "cbostEstoqueProdFimOP";
            this.cbostEstoqueProdFimOP.objConfigComponenteModel = null;
            this.cbostEstoqueProdFimOP.SelectedIndex = -1;
            this.cbostEstoqueProdFimOP.SelectedValue = 0;
            this.cbostEstoqueProdFimOP.Size = new System.Drawing.Size(320, 21);
            this.cbostEstoqueProdFimOP.TabIndex = 9;
            this.cbostEstoqueProdFimOP.ValueMember = "ValueMember";
            // 
            // cbostVinculaPedVenda
            // 
            this.cbostVinculaPedVenda._Field = "stVinculaPedidoVenda";
            this.cbostVinculaPedVenda._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostVinculaPedVenda._Itens")));
            this.cbostVinculaPedVenda._LabelGroup = this.hlP_LabelSeparatorProducao;
            this.cbostVinculaPedVenda._LabelText = "Vincular pedido de vendas?";
            this.cbostVinculaPedVenda._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostVinculaPedVenda._Regex = null;
            this.cbostVinculaPedVenda._situacao = true;
            this.cbostVinculaPedVenda._Table = "Tipo_operacao";
            this.cbostVinculaPedVenda._TamanhoComponente = 80;
            this.cbostVinculaPedVenda._TamanhoMaiorLabel = 280;
            this.cbostVinculaPedVenda._Visible = true;
            this.cbostVinculaPedVenda.BackColor = System.Drawing.Color.Transparent;
            this.cbostVinculaPedVenda.Base = null;
            this.cbostVinculaPedVenda.Color = System.Drawing.Color.White;
            this.cbostVinculaPedVenda.DataSource = null;
            this.cbostVinculaPedVenda.DisplayMember = "DisplayMember";
            this.cbostVinculaPedVenda.Location = new System.Drawing.Point(134, 108);
            this.cbostVinculaPedVenda.Margin = new System.Windows.Forms.Padding(134, 3, 15, 3);
            this.cbostVinculaPedVenda.Name = "cbostVinculaPedVenda";
            this.cbostVinculaPedVenda.objConfigComponenteModel = null;
            this.cbostVinculaPedVenda.SelectedIndex = -1;
            this.cbostVinculaPedVenda.SelectedValue = 0;
            this.cbostVinculaPedVenda.Size = new System.Drawing.Size(229, 21);
            this.cbostVinculaPedVenda.TabIndex = 10;
            this.cbostVinculaPedVenda.ValueMember = "ValueMember";
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage7.Controls.Add(this.kryptonPanel7);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1346, 569);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Tag = false;
            this.tabPage7.Text = "Importação";
            // 
            // kryptonPanel7
            // 
            this.kryptonPanel7.BorderWidth = 0;
            this.kryptonPanel7.Controls.Add(this.flowLayoutPanel6);
            this.kryptonPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel7.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.kryptonPanel7.GradientToogleColors = false;
            this.kryptonPanel7.GradientUseBlend = false;
            this.kryptonPanel7.GradientUseSolid = true;
            this.kryptonPanel7.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel7.Name = "kryptonPanel7";
            this.kryptonPanel7.PersistentColors = false;
            this.kryptonPanel7.Size = new System.Drawing.Size(1346, 569);
            this.kryptonPanel7.TabIndex = 1;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel6.Controls.Add(this.hlP_LabelSeparator_Importacao);
            this.flowLayoutPanel6.Controls.Add(this.nudImppII);
            this.flowLayoutPanel6.Controls.Add(this.cboImpstCompoeBaseIpi);
            this.flowLayoutPanel6.Controls.Add(this.cboImpstCompoeFatorIcms);
            this.flowLayoutPanel6.Controls.Add(this.cbostCompoeBaseIcmsOculto);
            this.flowLayoutPanel6.Controls.Add(this.cbostCompoeIcmsOculto);
            this.flowLayoutPanel6.Controls.Add(this.cbostCompoeFatorPisCofins);
            this.flowLayoutPanel6.Controls.Add(this.cbostCompoeBasePis);
            this.flowLayoutPanel6.Controls.Add(this.cbostCompoePis);
            this.flowLayoutPanel6.Controls.Add(this.cbostCompoeBaseCofins);
            this.flowLayoutPanel6.Controls.Add(this.cbostCompoeCofins);
            this.flowLayoutPanel6.Controls.Add(this.cbostCompoeBaseIcmsNormal);
            this.flowLayoutPanel6.Controls.Add(this.cbostCompoeIcmsNormal);
            this.flowLayoutPanel6.Controls.Add(this.cbostCompoeValorProdutos);
            this.flowLayoutPanel6.Controls.Add(this.cbostCompoeValorNf);
            this.flowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(1346, 569);
            this.flowLayoutPanel6.TabIndex = 1;
            this.flowLayoutPanel6.Tag = "Importação";
            // 
            // hlP_LabelSeparator_Importacao
            // 
            this.hlP_LabelSeparator_Importacao._LabelText = "Importação";
            this.hlP_LabelSeparator_Importacao._TamanhoMaiorLabel = 0;
            this.hlP_LabelSeparator_Importacao.BackColor = System.Drawing.Color.Transparent;
            this.hlP_LabelSeparator_Importacao.Location = new System.Drawing.Point(3, 3);
            this.hlP_LabelSeparator_Importacao.Name = "hlP_LabelSeparator_Importacao";
            this.hlP_LabelSeparator_Importacao.Size = new System.Drawing.Size(657, 18);
            this.hlP_LabelSeparator_Importacao.TabIndex = 62;
            this.hlP_LabelSeparator_Importacao.TabStop = false;
            // 
            // nudImppII
            // 
            this.nudImppII._Field = "pII";
            this.nudImppII._LabelGroup = this.hlP_LabelSeparator_Importacao;
            this.nudImppII._LabelText = "Alíquota de ii";
            this.nudImppII._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudImppII._Regex = null;
            this.nudImppII._Table = "Operacao_importacao";
            this.nudImppII._TamanhoComponente = 102;
            this.nudImppII._TamanhoMaiorLabel = 250;
            this.nudImppII._Visible = true;
            this.nudImppII.BackColor = System.Drawing.Color.Transparent;
            this.nudImppII.Base = null;
            this.nudImppII.Color = System.Drawing.Color.White;
            this.nudImppII.DecimalPlaces = 2;
            this.nudImppII.Location = new System.Drawing.Point(177, 27);
            this.nudImppII.Margin = new System.Windows.Forms.Padding(177, 3, 15, 3);
            this.nudImppII.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudImppII.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudImppII.Name = "nudImppII";
            this.nudImppII.objConfigComponenteModel = null;
            this.nudImppII.ReadOnly = false;
            this.nudImppII.Size = new System.Drawing.Size(178, 29);
            this.nudImppII.TabIndex = 1;
            this.nudImppII.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudImppII.ValueInt = 0;
            // 
            // cboImpstCompoeBaseIpi
            // 
            this.cboImpstCompoeBaseIpi._Field = "stCompoeBaseIpi";
            this.cboImpstCompoeBaseIpi._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cboImpstCompoeBaseIpi._Itens")));
            this.cboImpstCompoeBaseIpi._LabelGroup = this.hlP_LabelSeparator_Importacao;
            this.cboImpstCompoeBaseIpi._LabelText = "Compõe a base de cálculo do ipi?";
            this.cboImpstCompoeBaseIpi._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cboImpstCompoeBaseIpi._Regex = null;
            this.cboImpstCompoeBaseIpi._situacao = false;
            this.cboImpstCompoeBaseIpi._Table = "Operacao_importacao";
            this.cboImpstCompoeBaseIpi._TamanhoComponente = 374;
            this.cboImpstCompoeBaseIpi._TamanhoMaiorLabel = 250;
            this.cboImpstCompoeBaseIpi._Visible = true;
            this.cboImpstCompoeBaseIpi.BackColor = System.Drawing.Color.Transparent;
            this.cboImpstCompoeBaseIpi.Base = null;
            this.cboImpstCompoeBaseIpi.Color = System.Drawing.Color.White;
            this.cboImpstCompoeBaseIpi.DataSource = null;
            this.cboImpstCompoeBaseIpi.DisplayMember = "DisplayMember";
            this.cboImpstCompoeBaseIpi.Location = new System.Drawing.Point(74, 62);
            this.cboImpstCompoeBaseIpi.Margin = new System.Windows.Forms.Padding(74, 3, 15, 3);
            this.cboImpstCompoeBaseIpi.Name = "cboImpstCompoeBaseIpi";
            this.cboImpstCompoeBaseIpi.objConfigComponenteModel = null;
            this.cboImpstCompoeBaseIpi.SelectedIndex = -1;
            this.cboImpstCompoeBaseIpi.SelectedValue = 0;
            this.cboImpstCompoeBaseIpi.Size = new System.Drawing.Size(553, 21);
            this.cboImpstCompoeBaseIpi.TabIndex = 5;
            this.cboImpstCompoeBaseIpi.ValueMember = "ValueMember";
            // 
            // cboImpstCompoeFatorIcms
            // 
            this.cboImpstCompoeFatorIcms._Field = "stCompoeFatorIcms";
            this.cboImpstCompoeFatorIcms._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cboImpstCompoeFatorIcms._Itens")));
            this.cboImpstCompoeFatorIcms._LabelGroup = this.hlP_LabelSeparator_Importacao;
            this.cboImpstCompoeFatorIcms._LabelText = "Compõe o cálculo do fator de icms?";
            this.cboImpstCompoeFatorIcms._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cboImpstCompoeFatorIcms._Regex = null;
            this.cboImpstCompoeFatorIcms._situacao = false;
            this.cboImpstCompoeFatorIcms._Table = "Operacao_importacao";
            this.cboImpstCompoeFatorIcms._TamanhoComponente = 151;
            this.cboImpstCompoeFatorIcms._TamanhoMaiorLabel = 250;
            this.cboImpstCompoeFatorIcms._Visible = true;
            this.cboImpstCompoeFatorIcms.BackColor = System.Drawing.Color.Transparent;
            this.cboImpstCompoeFatorIcms.Base = null;
            this.cboImpstCompoeFatorIcms.Color = System.Drawing.Color.White;
            this.cboImpstCompoeFatorIcms.DataSource = null;
            this.cboImpstCompoeFatorIcms.DisplayMember = "DisplayMember";
            this.cboImpstCompoeFatorIcms.Location = new System.Drawing.Point(63, 89);
            this.cboImpstCompoeFatorIcms.Margin = new System.Windows.Forms.Padding(63, 3, 15, 3);
            this.cboImpstCompoeFatorIcms.Name = "cboImpstCompoeFatorIcms";
            this.cboImpstCompoeFatorIcms.objConfigComponenteModel = null;
            this.cboImpstCompoeFatorIcms.SelectedIndex = -1;
            this.cboImpstCompoeFatorIcms.SelectedValue = 0;
            this.cboImpstCompoeFatorIcms.Size = new System.Drawing.Size(341, 21);
            this.cboImpstCompoeFatorIcms.TabIndex = 6;
            this.cboImpstCompoeFatorIcms.ValueMember = "ValueMember";
            // 
            // cbostCompoeBaseIcmsOculto
            // 
            this.cbostCompoeBaseIcmsOculto._Field = "stCompoeBaseIcmsOculto";
            this.cbostCompoeBaseIcmsOculto._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostCompoeBaseIcmsOculto._Itens")));
            this.cbostCompoeBaseIcmsOculto._LabelGroup = this.hlP_LabelSeparator_Importacao;
            this.cbostCompoeBaseIcmsOculto._LabelText = "Compõe a base de cálculo do icms oculto?";
            this.cbostCompoeBaseIcmsOculto._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostCompoeBaseIcmsOculto._Regex = null;
            this.cbostCompoeBaseIcmsOculto._situacao = false;
            this.cbostCompoeBaseIcmsOculto._Table = "Operacao_importacao";
            this.cbostCompoeBaseIcmsOculto._TamanhoComponente = 374;
            this.cbostCompoeBaseIcmsOculto._TamanhoMaiorLabel = 250;
            this.cbostCompoeBaseIcmsOculto._Visible = true;
            this.cbostCompoeBaseIcmsOculto.BackColor = System.Drawing.Color.Transparent;
            this.cbostCompoeBaseIcmsOculto.Base = null;
            this.cbostCompoeBaseIcmsOculto.Color = System.Drawing.Color.White;
            this.cbostCompoeBaseIcmsOculto.DataSource = null;
            this.cbostCompoeBaseIcmsOculto.DisplayMember = "DisplayMember";
            this.cbostCompoeBaseIcmsOculto.Location = new System.Drawing.Point(29, 116);
            this.cbostCompoeBaseIcmsOculto.Margin = new System.Windows.Forms.Padding(29, 3, 15, 3);
            this.cbostCompoeBaseIcmsOculto.Name = "cbostCompoeBaseIcmsOculto";
            this.cbostCompoeBaseIcmsOculto.objConfigComponenteModel = null;
            this.cbostCompoeBaseIcmsOculto.SelectedIndex = -1;
            this.cbostCompoeBaseIcmsOculto.SelectedValue = 0;
            this.cbostCompoeBaseIcmsOculto.Size = new System.Drawing.Size(598, 21);
            this.cbostCompoeBaseIcmsOculto.TabIndex = 7;
            this.cbostCompoeBaseIcmsOculto.ValueMember = "ValueMember";
            // 
            // cbostCompoeIcmsOculto
            // 
            this.cbostCompoeIcmsOculto._Field = "stCompoeIcmsOculto";
            this.cbostCompoeIcmsOculto._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostCompoeIcmsOculto._Itens")));
            this.cbostCompoeIcmsOculto._LabelGroup = this.hlP_LabelSeparator_Importacao;
            this.cbostCompoeIcmsOculto._LabelText = "Compõe o cálculo do icms oculto?";
            this.cbostCompoeIcmsOculto._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostCompoeIcmsOculto._Regex = null;
            this.cbostCompoeIcmsOculto._situacao = false;
            this.cbostCompoeIcmsOculto._Table = "Operacao_importacao";
            this.cbostCompoeIcmsOculto._TamanhoComponente = 192;
            this.cbostCompoeIcmsOculto._TamanhoMaiorLabel = 250;
            this.cbostCompoeIcmsOculto._Visible = true;
            this.cbostCompoeIcmsOculto.BackColor = System.Drawing.Color.Transparent;
            this.cbostCompoeIcmsOculto.Base = null;
            this.cbostCompoeIcmsOculto.Color = System.Drawing.Color.White;
            this.cbostCompoeIcmsOculto.DataSource = null;
            this.cbostCompoeIcmsOculto.DisplayMember = "DisplayMember";
            this.cbostCompoeIcmsOculto.Location = new System.Drawing.Point(71, 143);
            this.cbostCompoeIcmsOculto.Margin = new System.Windows.Forms.Padding(71, 3, 15, 3);
            this.cbostCompoeIcmsOculto.Name = "cbostCompoeIcmsOculto";
            this.cbostCompoeIcmsOculto.objConfigComponenteModel = null;
            this.cbostCompoeIcmsOculto.SelectedIndex = -1;
            this.cbostCompoeIcmsOculto.SelectedValue = 0;
            this.cbostCompoeIcmsOculto.Size = new System.Drawing.Size(374, 21);
            this.cbostCompoeIcmsOculto.TabIndex = 8;
            this.cbostCompoeIcmsOculto.ValueMember = "ValueMember";
            // 
            // cbostCompoeFatorPisCofins
            // 
            this.cbostCompoeFatorPisCofins._Field = "stCompoeFatorPisCofins";
            this.cbostCompoeFatorPisCofins._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostCompoeFatorPisCofins._Itens")));
            this.cbostCompoeFatorPisCofins._LabelGroup = this.hlP_LabelSeparator_Importacao;
            this.cbostCompoeFatorPisCofins._LabelText = "Compõe o cálculo do fator de pis e cofins?";
            this.cbostCompoeFatorPisCofins._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostCompoeFatorPisCofins._Regex = null;
            this.cbostCompoeFatorPisCofins._situacao = false;
            this.cbostCompoeFatorPisCofins._Table = "Operacao_importacao";
            this.cbostCompoeFatorPisCofins._TamanhoComponente = 202;
            this.cbostCompoeFatorPisCofins._TamanhoMaiorLabel = 250;
            this.cbostCompoeFatorPisCofins._Visible = true;
            this.cbostCompoeFatorPisCofins.BackColor = System.Drawing.Color.Transparent;
            this.cbostCompoeFatorPisCofins.Base = null;
            this.cbostCompoeFatorPisCofins.Color = System.Drawing.Color.White;
            this.cbostCompoeFatorPisCofins.DataSource = null;
            this.cbostCompoeFatorPisCofins.DisplayMember = "DisplayMember";
            this.cbostCompoeFatorPisCofins.Location = new System.Drawing.Point(27, 170);
            this.cbostCompoeFatorPisCofins.Margin = new System.Windows.Forms.Padding(27, 3, 15, 3);
            this.cbostCompoeFatorPisCofins.Name = "cbostCompoeFatorPisCofins";
            this.cbostCompoeFatorPisCofins.objConfigComponenteModel = null;
            this.cbostCompoeFatorPisCofins.SelectedIndex = -1;
            this.cbostCompoeFatorPisCofins.SelectedValue = 0;
            this.cbostCompoeFatorPisCofins.Size = new System.Drawing.Size(428, 21);
            this.cbostCompoeFatorPisCofins.TabIndex = 9;
            this.cbostCompoeFatorPisCofins.ValueMember = "ValueMember";
            // 
            // cbostCompoeBasePis
            // 
            this.cbostCompoeBasePis._Field = "stCompoeBasePis";
            this.cbostCompoeBasePis._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostCompoeBasePis._Itens")));
            this.cbostCompoeBasePis._LabelGroup = this.hlP_LabelSeparator_Importacao;
            this.cbostCompoeBasePis._LabelText = "Compõe a base de cálculo do pis?";
            this.cbostCompoeBasePis._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostCompoeBasePis._Regex = null;
            this.cbostCompoeBasePis._situacao = false;
            this.cbostCompoeBasePis._Table = "Operacao_importacao";
            this.cbostCompoeBasePis._TamanhoComponente = 271;
            this.cbostCompoeBasePis._TamanhoMaiorLabel = 250;
            this.cbostCompoeBasePis._Visible = true;
            this.cbostCompoeBasePis.BackColor = System.Drawing.Color.Transparent;
            this.cbostCompoeBasePis.Base = null;
            this.cbostCompoeBasePis.Color = System.Drawing.Color.White;
            this.cbostCompoeBasePis.DataSource = null;
            this.cbostCompoeBasePis.DisplayMember = "DisplayMember";
            this.cbostCompoeBasePis.Location = new System.Drawing.Point(72, 197);
            this.cbostCompoeBasePis.Margin = new System.Windows.Forms.Padding(72, 3, 15, 3);
            this.cbostCompoeBasePis.Name = "cbostCompoeBasePis";
            this.cbostCompoeBasePis.objConfigComponenteModel = null;
            this.cbostCompoeBasePis.SelectedIndex = -1;
            this.cbostCompoeBasePis.SelectedValue = 0;
            this.cbostCompoeBasePis.Size = new System.Drawing.Size(452, 21);
            this.cbostCompoeBasePis.TabIndex = 10;
            this.cbostCompoeBasePis.ValueMember = "ValueMember";
            // 
            // cbostCompoePis
            // 
            this.cbostCompoePis._Field = "stCompoePis";
            this.cbostCompoePis._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostCompoePis._Itens")));
            this.cbostCompoePis._LabelGroup = this.hlP_LabelSeparator_Importacao;
            this.cbostCompoePis._LabelText = "Compõe o cálculo do pis?";
            this.cbostCompoePis._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostCompoePis._Regex = null;
            this.cbostCompoePis._situacao = false;
            this.cbostCompoePis._Table = "Operacao_importacao";
            this.cbostCompoePis._TamanhoComponente = 143;
            this.cbostCompoePis._TamanhoMaiorLabel = 250;
            this.cbostCompoePis._Visible = true;
            this.cbostCompoePis.BackColor = System.Drawing.Color.Transparent;
            this.cbostCompoePis.Base = null;
            this.cbostCompoePis.Color = System.Drawing.Color.White;
            this.cbostCompoePis.DataSource = null;
            this.cbostCompoePis.DisplayMember = "DisplayMember";
            this.cbostCompoePis.Location = new System.Drawing.Point(114, 224);
            this.cbostCompoePis.Margin = new System.Windows.Forms.Padding(114, 3, 15, 3);
            this.cbostCompoePis.Name = "cbostCompoePis";
            this.cbostCompoePis.objConfigComponenteModel = null;
            this.cbostCompoePis.SelectedIndex = -1;
            this.cbostCompoePis.SelectedValue = 0;
            this.cbostCompoePis.Size = new System.Drawing.Size(282, 21);
            this.cbostCompoePis.TabIndex = 11;
            this.cbostCompoePis.ValueMember = "ValueMember";
            // 
            // cbostCompoeBaseCofins
            // 
            this.cbostCompoeBaseCofins._Field = "stCompoeBaseCofins";
            this.cbostCompoeBaseCofins._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostCompoeBaseCofins._Itens")));
            this.cbostCompoeBaseCofins._LabelGroup = this.hlP_LabelSeparator_Importacao;
            this.cbostCompoeBaseCofins._LabelText = "Compõe a base de cálculo do cofins?";
            this.cbostCompoeBaseCofins._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostCompoeBaseCofins._Regex = null;
            this.cbostCompoeBaseCofins._situacao = false;
            this.cbostCompoeBaseCofins._Table = "Operacao_importacao";
            this.cbostCompoeBaseCofins._TamanhoComponente = 271;
            this.cbostCompoeBaseCofins._TamanhoMaiorLabel = 250;
            this.cbostCompoeBaseCofins._Visible = true;
            this.cbostCompoeBaseCofins.BackColor = System.Drawing.Color.Transparent;
            this.cbostCompoeBaseCofins.Base = null;
            this.cbostCompoeBaseCofins.Color = System.Drawing.Color.White;
            this.cbostCompoeBaseCofins.DataSource = null;
            this.cbostCompoeBaseCofins.DisplayMember = "DisplayMember";
            this.cbostCompoeBaseCofins.Location = new System.Drawing.Point(56, 251);
            this.cbostCompoeBaseCofins.Margin = new System.Windows.Forms.Padding(56, 3, 15, 3);
            this.cbostCompoeBaseCofins.Name = "cbostCompoeBaseCofins";
            this.cbostCompoeBaseCofins.objConfigComponenteModel = null;
            this.cbostCompoeBaseCofins.SelectedIndex = -1;
            this.cbostCompoeBaseCofins.SelectedValue = 0;
            this.cbostCompoeBaseCofins.Size = new System.Drawing.Size(468, 21);
            this.cbostCompoeBaseCofins.TabIndex = 12;
            this.cbostCompoeBaseCofins.ValueMember = "ValueMember";
            // 
            // cbostCompoeCofins
            // 
            this.cbostCompoeCofins._Field = "stCompoeCofins";
            this.cbostCompoeCofins._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostCompoeCofins._Itens")));
            this.cbostCompoeCofins._LabelGroup = this.hlP_LabelSeparator_Importacao;
            this.cbostCompoeCofins._LabelText = "Compõe o cálculo do cofins?";
            this.cbostCompoeCofins._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostCompoeCofins._Regex = null;
            this.cbostCompoeCofins._situacao = false;
            this.cbostCompoeCofins._Table = "Operacao_importacao";
            this.cbostCompoeCofins._TamanhoComponente = 271;
            this.cbostCompoeCofins._TamanhoMaiorLabel = 250;
            this.cbostCompoeCofins._Visible = true;
            this.cbostCompoeCofins.BackColor = System.Drawing.Color.Transparent;
            this.cbostCompoeCofins.Base = null;
            this.cbostCompoeCofins.Color = System.Drawing.Color.White;
            this.cbostCompoeCofins.DataSource = null;
            this.cbostCompoeCofins.DisplayMember = "DisplayMember";
            this.cbostCompoeCofins.Location = new System.Drawing.Point(98, 278);
            this.cbostCompoeCofins.Margin = new System.Windows.Forms.Padding(98, 3, 15, 3);
            this.cbostCompoeCofins.Name = "cbostCompoeCofins";
            this.cbostCompoeCofins.objConfigComponenteModel = null;
            this.cbostCompoeCofins.SelectedIndex = -1;
            this.cbostCompoeCofins.SelectedValue = 0;
            this.cbostCompoeCofins.Size = new System.Drawing.Size(426, 21);
            this.cbostCompoeCofins.TabIndex = 17;
            this.cbostCompoeCofins.ValueMember = "ValueMember";
            // 
            // cbostCompoeBaseIcmsNormal
            // 
            this.cbostCompoeBaseIcmsNormal._Field = "stCompoeBaseIcmsNormal";
            this.cbostCompoeBaseIcmsNormal._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostCompoeBaseIcmsNormal._Itens")));
            this.cbostCompoeBaseIcmsNormal._LabelGroup = this.hlP_LabelSeparator_Importacao;
            this.cbostCompoeBaseIcmsNormal._LabelText = "Compõe a base de cálculo do icms normal?";
            this.cbostCompoeBaseIcmsNormal._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostCompoeBaseIcmsNormal._Regex = null;
            this.cbostCompoeBaseIcmsNormal._situacao = false;
            this.cbostCompoeBaseIcmsNormal._Table = "Operacao_importacao";
            this.cbostCompoeBaseIcmsNormal._TamanhoComponente = 851;
            this.cbostCompoeBaseIcmsNormal._TamanhoMaiorLabel = 250;
            this.cbostCompoeBaseIcmsNormal._Visible = true;
            this.cbostCompoeBaseIcmsNormal.BackColor = System.Drawing.Color.Transparent;
            this.cbostCompoeBaseIcmsNormal.Base = null;
            this.cbostCompoeBaseIcmsNormal.Color = System.Drawing.Color.White;
            this.cbostCompoeBaseIcmsNormal.DataSource = null;
            this.cbostCompoeBaseIcmsNormal.DisplayMember = "DisplayMember";
            this.cbostCompoeBaseIcmsNormal.Location = new System.Drawing.Point(26, 305);
            this.cbostCompoeBaseIcmsNormal.Margin = new System.Windows.Forms.Padding(26, 3, 15, 3);
            this.cbostCompoeBaseIcmsNormal.Name = "cbostCompoeBaseIcmsNormal";
            this.cbostCompoeBaseIcmsNormal.objConfigComponenteModel = null;
            this.cbostCompoeBaseIcmsNormal.SelectedIndex = -1;
            this.cbostCompoeBaseIcmsNormal.SelectedValue = 0;
            this.cbostCompoeBaseIcmsNormal.Size = new System.Drawing.Size(1078, 21);
            this.cbostCompoeBaseIcmsNormal.TabIndex = 13;
            this.cbostCompoeBaseIcmsNormal.ValueMember = "ValueMember";
            // 
            // cbostCompoeIcmsNormal
            // 
            this.cbostCompoeIcmsNormal._Field = "stCompoeIcmsNormal";
            this.cbostCompoeIcmsNormal._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostCompoeIcmsNormal._Itens")));
            this.cbostCompoeIcmsNormal._LabelGroup = this.hlP_LabelSeparator_Importacao;
            this.cbostCompoeIcmsNormal._LabelText = "Compõe o cálculo do icms normal?";
            this.cbostCompoeIcmsNormal._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostCompoeIcmsNormal._Regex = null;
            this.cbostCompoeIcmsNormal._situacao = false;
            this.cbostCompoeIcmsNormal._Table = "Operacao_importacao";
            this.cbostCompoeIcmsNormal._TamanhoComponente = 195;
            this.cbostCompoeIcmsNormal._TamanhoMaiorLabel = 250;
            this.cbostCompoeIcmsNormal._Visible = true;
            this.cbostCompoeIcmsNormal.BackColor = System.Drawing.Color.Transparent;
            this.cbostCompoeIcmsNormal.Base = null;
            this.cbostCompoeIcmsNormal.Color = System.Drawing.Color.White;
            this.cbostCompoeIcmsNormal.DataSource = null;
            this.cbostCompoeIcmsNormal.DisplayMember = "DisplayMember";
            this.cbostCompoeIcmsNormal.Location = new System.Drawing.Point(68, 332);
            this.cbostCompoeIcmsNormal.Margin = new System.Windows.Forms.Padding(68, 3, 15, 3);
            this.cbostCompoeIcmsNormal.Name = "cbostCompoeIcmsNormal";
            this.cbostCompoeIcmsNormal.objConfigComponenteModel = null;
            this.cbostCompoeIcmsNormal.SelectedIndex = -1;
            this.cbostCompoeIcmsNormal.SelectedValue = 0;
            this.cbostCompoeIcmsNormal.Size = new System.Drawing.Size(380, 21);
            this.cbostCompoeIcmsNormal.TabIndex = 14;
            this.cbostCompoeIcmsNormal.ValueMember = "ValueMember";
            // 
            // cbostCompoeValorProdutos
            // 
            this.cbostCompoeValorProdutos._Field = "stCompoeValorProdutos";
            this.cbostCompoeValorProdutos._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostCompoeValorProdutos._Itens")));
            this.cbostCompoeValorProdutos._LabelGroup = this.hlP_LabelSeparator_Importacao;
            this.cbostCompoeValorProdutos._LabelText = "Compõe o valor total dos produtos?";
            this.cbostCompoeValorProdutos._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostCompoeValorProdutos._Regex = null;
            this.cbostCompoeValorProdutos._situacao = false;
            this.cbostCompoeValorProdutos._Table = "Operacao_importacao";
            this.cbostCompoeValorProdutos._TamanhoComponente = 175;
            this.cbostCompoeValorProdutos._TamanhoMaiorLabel = 250;
            this.cbostCompoeValorProdutos._Visible = true;
            this.cbostCompoeValorProdutos.BackColor = System.Drawing.Color.Transparent;
            this.cbostCompoeValorProdutos.Base = null;
            this.cbostCompoeValorProdutos.Color = System.Drawing.Color.White;
            this.cbostCompoeValorProdutos.DataSource = null;
            this.cbostCompoeValorProdutos.DisplayMember = "DisplayMember";
            this.cbostCompoeValorProdutos.Location = new System.Drawing.Point(60, 359);
            this.cbostCompoeValorProdutos.Margin = new System.Windows.Forms.Padding(60, 3, 15, 3);
            this.cbostCompoeValorProdutos.Name = "cbostCompoeValorProdutos";
            this.cbostCompoeValorProdutos.objConfigComponenteModel = null;
            this.cbostCompoeValorProdutos.SelectedIndex = -1;
            this.cbostCompoeValorProdutos.SelectedValue = 0;
            this.cbostCompoeValorProdutos.Size = new System.Drawing.Size(368, 21);
            this.cbostCompoeValorProdutos.TabIndex = 15;
            this.cbostCompoeValorProdutos.ValueMember = "ValueMember";
            // 
            // cbostCompoeValorNf
            // 
            this.cbostCompoeValorNf._Field = "stCompoeValorNf";
            this.cbostCompoeValorNf._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostCompoeValorNf._Itens")));
            this.cbostCompoeValorNf._LabelGroup = this.hlP_LabelSeparator_Importacao;
            this.cbostCompoeValorNf._LabelText = "Compõe o valor total da nf?";
            this.cbostCompoeValorNf._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostCompoeValorNf._Regex = null;
            this.cbostCompoeValorNf._situacao = false;
            this.cbostCompoeValorNf._Table = "Operacao_importacao";
            this.cbostCompoeValorNf._TamanhoComponente = 184;
            this.cbostCompoeValorNf._TamanhoMaiorLabel = 250;
            this.cbostCompoeValorNf._Visible = true;
            this.cbostCompoeValorNf.BackColor = System.Drawing.Color.Transparent;
            this.cbostCompoeValorNf.Base = null;
            this.cbostCompoeValorNf.Color = System.Drawing.Color.White;
            this.cbostCompoeValorNf.DataSource = null;
            this.cbostCompoeValorNf.DisplayMember = "DisplayMember";
            this.cbostCompoeValorNf.Location = new System.Drawing.Point(103, 386);
            this.cbostCompoeValorNf.Margin = new System.Windows.Forms.Padding(103, 3, 15, 3);
            this.cbostCompoeValorNf.Name = "cbostCompoeValorNf";
            this.cbostCompoeValorNf.objConfigComponenteModel = null;
            this.cbostCompoeValorNf.SelectedIndex = -1;
            this.cbostCompoeValorNf.SelectedValue = 0;
            this.cbostCompoeValorNf.Size = new System.Drawing.Size(334, 21);
            this.cbostCompoeValorNf.TabIndex = 16;
            this.cbostCompoeValorNf.ValueMember = "ValueMember";
            // 
            // FormTipoOperacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 655);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "FormTipoOperacao";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = -10;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Text = "Tipos de Operação";
            this.Load += new System.EventHandler(this.FormTipoOperacao_Load);
            this.Controls.SetChildIndex(this.kryptonPanel, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).EndInit();
            this.panelPadrao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.kryptonPanel1.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.kryptonPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.kryptonPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.kryptonPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReducao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOperacaoreducaobase)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.kryptonPanel5.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.kryptonPanel7.ResumeLayout(false);
            this.flowLayoutPanel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.TabPage tabPage5;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private Comum.Components.HLP_TextBox txtCodigo;
        private Comum.Components.HLP_TextBox txtxOperacao;
        private Comum.Components.HLP_ComboBox cbotpOperacao;
        private Comum.Components.HLP_ComboBox cbostRepresentaFaturamento;
        private Comum.Components.HLP_ComboBox cbostGeraFinanceiro;
        private Comum.Components.HLP_ComboBox cbostGeraComissao;
        private Comum.Components.HLP_ComboBox cbostServico;
        private Comum.Components.HLP_ComboBox cbostEstoque;
        private Comum.Components.HLP_ComboBox cbostEstoqueClientes;
        private Comum.Components.HLP_ComboBox cbostEstoqueFornecedores;
        private Comum.Components.HLP_ComboBox cbostEntregaFutura;
        private Comum.Components.HLP_ComboBox cbostTpIndustrializacao;
        private Comum.Components.HLP_Pesquisa hlP_PesquisacCfopNaUf;
        private Comum.Components.HLP_Pesquisa hlP_PesquisacCfopOutraUf;
        private Comum.Components.HLP_Pesquisa hlP_PesquisacCfopNcontribuinte;
        private Comum.Components.HLP_ComboBox cboAtivo;
        private Comum.Components.HLP_ComboBox cbostRelacaoRecebimentoInspecao;
        private Comum.Components.HLP_ComboBox cbostCalcCustoEntrada;
        private Comum.Components.HLP_ComboBox cbostDescontaCredicmsCusto;
        private Comum.Components.HLP_ComboBox cbostDescontaCredsubstCusto;
        private Comum.Components.HLP_ComboBox cbostDescontaCredipiCusto;
        private Comum.Components.HLP_ComboBox cbostDescontaCredpiscofinsCusto;
        private Comum.Components.HLP_ComboBox cbostDescontaDifIcmsCusto;
        private Comum.Components.HLP_ComboBox cbostObrigaOpNaCompra;
        private Comum.Components.HLP_NumericUpDown nudpInsumoIndustrializacao;
        private Comum.Components.HLP_NumericUpDown nudpMoIndustrializacao;
        private Comum.Components.HLP_ComboBox cbostCalcImportacao;
        private Comum.Components.HLP_ComboBox cbostCalcCredicmsSs;
        private Comum.Components.HLP_ComboBox cbostCalcCredicmsSsSt;
        private Comum.Components.HLP_ComboBox cbostBaixaMaterialOp;
        private Comum.Components.HLP_ComboBox cbostExplosaoMatOp;
        private Comum.Components.HLP_ComboBox cbostEstoqueProdFimOP;
        private Comum.Components.HLP_ComboBox cbostVinculaPedVenda;
        private Comum.Components.HLP_ComboBox cbostReduzBase;
        private Comum.Components.HLP_ComboBox cbostNaoReduzBase;
        private Comum.Components.HLP_ComboBox cbostCalcIcms;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidCodigoIcmsPai;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidCSTIcms;
        private Comum.Components.HLP_ComboBox cbostCompoeBaseIcms;
        private Comum.Components.HLP_ComboBox cbostCalcIpi;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidClassificacaoFiscal;
        private Comum.Components.HLP_NumericUpDown nudpIpi;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidCSTIpi;
        private Comum.Components.HLP_ComboBox cbostCompoeBaseIpi;
        private Comum.Components.HLP_ComboBox cbostCalcIcmsSubstTributaria;
        private Comum.Components.HLP_ComboBox cbostCompoeBaseIcmsSubstTributaria;
        private Comum.Components.HLP_ComboBox cbostCalcPisCofins;
        private Comum.Components.HLP_ComboBox cbostRegimeTributacaoPisCofins;
        private Comum.Components.HLP_NumericUpDown nudnCoeficienteSubstTributariaPis;
        private Comum.Components.HLP_NumericUpDown nudnCoeficienteSubstTributariaCofins;
        private Comum.Components.HLP_ComboBox cboImpstCompoeBaseIpi;
        private Comum.Components.HLP_ComboBox cboImpstCompoeFatorIcms;
        private Comum.Components.HLP_ComboBox cbostCompoeBaseIcmsOculto;
        private Comum.Components.HLP_ComboBox cbostCompoeIcmsOculto;
        private Comum.Components.HLP_ComboBox cbostCompoeFatorPisCofins;
        private Comum.Components.HLP_ComboBox cbostCompoeBasePis;
        private Comum.Components.HLP_ComboBox cbostCompoePis;
        private Comum.Components.HLP_ComboBox cbostCompoeBaseCofins;
        private Comum.Components.HLP_ComboBox cbostCompoeBaseIcmsNormal;
        private Comum.Components.HLP_ComboBox cbostCompoeIcmsNormal;
        private Comum.Components.HLP_ComboBox cbostCompoeValorProdutos;
        private Comum.Components.HLP_ComboBox cbostCompoeValorNf;
        private Comum.Components.HLP_ComboBox cbostCompoeCofins;
        private Comum.Components.HLP_NumericUpDown nudImppII;
        private HLP_DataGridView dgvReducao;
        private System.Windows.Forms.BindingSource bsOperacaoreducaobase;
        private Comum.Components.HLP_NumericUpDown nudpPis;
        private Comum.Components.HLP_NumericUpDown nudpCofins;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidCSTPis;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidCSTCofins;
        private Comum.Components.HLP_ComboBox cbostCompoeBaseNormalPiscofins;
        private Comum.Components.HLP_ComboBox cbostCompoeBaseSubtTribPis;
        private Comum.Components.HLP_ComboBox cbostCompoeBaseSubtTribCofins;
        private Comum.Components.HLP_ComboBox cbostCalcIss;
        private Comum.Components.HLP_NumericUpDown nudpIss;
        private Comum.Components.HLP_ComboBox cbostCalcIrrf;
        private Comum.Components.HLP_NumericUpDown nudpReducaoBaseIrrf;
        private Comum.Components.HLP_NumericUpDown nudpIrrf;
        private Comum.Components.HLP_ComboBox cbostCalcCsll;
        private Comum.Components.HLP_ComboBox cbostCalcInss;
        private Comum.Components.HLP_NumericUpDown nudpReducaoBaseInss;
        private Comum.Components.HLP_NumericUpDown nudpInss;
        private System.Windows.Forms.DataGridViewComboBoxColumn idUf;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn pReducaoIcms;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn pReducaoIcmsSubstTributaria;
        private Comum.Components.HLP_ComboBox cbostOrigemMercadoria;
        private HLP_LabelSeparator hlP_LabelSeparator1_Geral;
        private HLP_LabelSeparator hlP_LabelSeparator_entrada;
        private HLP_LabelSeparator hlP_LabelSeparator_saida;
        private HLP_LabelSeparator hlP_LabelSeparator_fiscal;
        private HLP_LabelSeparator hlP_LabelSeparator_IPI;
        private HLP_LabelSeparator hlP_LabelSeparator_icms;
        private HLP_LabelSeparator hlP_LabelSeparator_piscof;
        private HLP_LabelSeparator hlP_LabelSeparatorServico;
        private HLP_LabelSeparator hlP_LabelSeparatorProducao;
        private HLP_LabelSeparator hlP_LabelSeparator_Importacao;
    }
}

