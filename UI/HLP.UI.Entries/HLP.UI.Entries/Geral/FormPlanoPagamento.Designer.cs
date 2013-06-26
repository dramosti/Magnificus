using HLP.Comum.Components;
namespace HLP.UI.Entries.Geral
{
    partial class FormPlanoPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlanoPagamento));
            this.tcPlanosPagamento = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kryptonPanel1 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.hlP_LabelSeparator1_Geral = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtCodigo = new HLP.Comum.Components.HLP_TextBox();
            this.txtxPlanoPagamento = new HLP.Comum.Components.HLP_TextBox();
            this.txtxDescricao = new HLP.Comum.Components.HLP_TextBox();
            this.cbostAlocacao = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostFormaPagamento = new HLP.Comum.Components.HLP_ComboBox();
            this.nudnAlterar = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudnNumerosPagamentos = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudnValorMoeda = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudnValorMinimo = new HLP.Comum.Components.HLP_NumericUpDown();
            this.cbostAlocacaoImpostos = new HLP.Comum.Components.HLP_ComboBox();
            this.txtxNota = new HLP.Comum.Components.HLP_TextBox();
            this.tabPlanPagamento = new System.Windows.Forms.TabPage();
            this.kryptonPanel2 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.kryptonTabControl1 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.kryptonPanel3 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.dgvLinhaPagamento = new HLP.Comum.Components.HLP_DataGridView();
            this.nQuantidade = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.clstValorouPorcentagem = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clnValorouPorcentagem = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.bsLinhas = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.sp_PlanoPgto = new HLP.Comum.Components.HLP_LabelSeparator();
            this.nudNumParcelas = new HLP.Comum.Components.HLP_NumericUpDown();
            this.hlP_Button1 = new HLP.Comum.Components.HLP_Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).BeginInit();
            this.panelPadrao.SuspendLayout();
            this.tcPlanosPagamento.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.kryptonPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabPlanPagamento.SuspendLayout();
            this.kryptonPanel2.SuspendLayout();
            this.kryptonTabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinhaPagamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLinhas)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1126, 595);
            // 
            // panelPadrao
            // 
            this.panelPadrao.Controls.Add(this.tcPlanosPagamento);
            this.panelPadrao.Size = new System.Drawing.Size(1124, 571);
            // 
            // tcPlanosPagamento
            // 
            this.tcPlanosPagamento.AllowCloseButton = false;
            this.tcPlanosPagamento.AllowContextButton = true;
            this.tcPlanosPagamento.AllowNavigatorButtons = false;
            this.tcPlanosPagamento.AllowSelectedTabHigh = false;
            this.tcPlanosPagamento.BorderWidth = 1;
            this.tcPlanosPagamento.Controls.Add(this.tabPage1);
            this.tcPlanosPagamento.Controls.Add(this.tabPlanPagamento);
            this.tcPlanosPagamento.CornerRoundRadiusWidth = 12;
            this.tcPlanosPagamento.CornerSymmetry = AC.ExtendedRenderer.Navigator.KryptonTabControl.CornSymmetry.Both;
            this.tcPlanosPagamento.CornerType = AC.ExtendedRenderer.Toolkit.Drawing.DrawingMethods.CornerType.Rounded;
            this.tcPlanosPagamento.CornerWidth = AC.ExtendedRenderer.Navigator.KryptonTabControl.CornWidth.Thin;
            this.tcPlanosPagamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPlanosPagamento.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tcPlanosPagamento.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tcPlanosPagamento.HotTrack = true;
            this.tcPlanosPagamento.Location = new System.Drawing.Point(3, 3);
            this.tcPlanosPagamento.Name = "tcPlanosPagamento";
            this.tcPlanosPagamento.PreserveTabColor = false;
            this.tcPlanosPagamento.SelectedIndex = 0;
            this.tcPlanosPagamento.Size = new System.Drawing.Size(1118, 565);
            this.tcPlanosPagamento.TabIndex = 1;
            this.tcPlanosPagamento.UseExtendedLayout = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Controls.Add(this.kryptonPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1110, 536);
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
            this.kryptonPanel1.Size = new System.Drawing.Size(1110, 536);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.hlP_LabelSeparator1_Geral);
            this.flowLayoutPanel1.Controls.Add(this.txtCodigo);
            this.flowLayoutPanel1.Controls.Add(this.txtxPlanoPagamento);
            this.flowLayoutPanel1.Controls.Add(this.txtxDescricao);
            this.flowLayoutPanel1.Controls.Add(this.cbostAlocacao);
            this.flowLayoutPanel1.Controls.Add(this.cbostFormaPagamento);
            this.flowLayoutPanel1.Controls.Add(this.nudnAlterar);
            this.flowLayoutPanel1.Controls.Add(this.nudnNumerosPagamentos);
            this.flowLayoutPanel1.Controls.Add(this.nudnValorMoeda);
            this.flowLayoutPanel1.Controls.Add(this.nudnValorMinimo);
            this.flowLayoutPanel1.Controls.Add(this.cbostAlocacaoImpostos);
            this.flowLayoutPanel1.Controls.Add(this.txtxNota);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1110, 536);
            this.flowLayoutPanel1.TabIndex = 0;
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
            this.hlP_LabelSeparator1_Geral.Size = new System.Drawing.Size(398, 18);
            this.hlP_LabelSeparator1_Geral.TabIndex = 30;
            this.hlP_LabelSeparator1_Geral.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo._Field = "idPlanoPagamento";
            this.txtCodigo._Help = "Chave principal do registro do plano de pagamento";
            this.txtCodigo._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtCodigo._LabelText = "Código";
            this.txtCodigo._Multiline = false;
            this.txtCodigo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtCodigo._Password = false;
            this.txtCodigo._Regex = null;
            this.txtCodigo._Table = "Plano_pagamento";
            this.txtCodigo._TamanhoComponente = 97;
            this.txtCodigo._TamanhoMaiorLabel = 200;
            this.txtCodigo._Visible = false;
            this.txtCodigo.BackColor = System.Drawing.Color.Transparent;
            this.txtCodigo.Base = null;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCodigo.Color = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(158, 27);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(158, 3, 15, 3);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(142, 19);
            this.txtCodigo.TabIndex = 3;
            // 
            // txtxPlanoPagamento
            // 
            this.txtxPlanoPagamento._Field = "xPlanoPagamento";
            this.txtxPlanoPagamento._Help = "Insira um código ou uma breve descrição para identificar o plano de pagamento";
            this.txtxPlanoPagamento._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtxPlanoPagamento._LabelText = "Plano de pagamento ";
            this.txtxPlanoPagamento._Multiline = false;
            this.txtxPlanoPagamento._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxPlanoPagamento._Password = false;
            this.txtxPlanoPagamento._Regex = null;
            this.txtxPlanoPagamento._Table = "Plano_pagamento";
            this.txtxPlanoPagamento._TamanhoComponente = 194;
            this.txtxPlanoPagamento._TamanhoMaiorLabel = 200;
            this.txtxPlanoPagamento._Visible = false;
            this.txtxPlanoPagamento.BackColor = System.Drawing.Color.Transparent;
            this.txtxPlanoPagamento.Base = null;
            this.txtxPlanoPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxPlanoPagamento.Color = System.Drawing.Color.White;
            this.txtxPlanoPagamento.Location = new System.Drawing.Point(86, 52);
            this.txtxPlanoPagamento.Margin = new System.Windows.Forms.Padding(86, 3, 15, 3);
            this.txtxPlanoPagamento.MaxLength = 32767;
            this.txtxPlanoPagamento.Name = "txtxPlanoPagamento";
            this.txtxPlanoPagamento.ReadOnly = false;
            this.txtxPlanoPagamento.Size = new System.Drawing.Size(311, 19);
            this.txtxPlanoPagamento.TabIndex = 4;
            // 
            // txtxDescricao
            // 
            this.txtxDescricao._Field = "xDescricao";
            this.txtxDescricao._Help = "Insira a descrição do plano de pagamento";
            this.txtxDescricao._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtxDescricao._LabelText = "Descrição ";
            this.txtxDescricao._Multiline = false;
            this.txtxDescricao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxDescricao._Password = false;
            this.txtxDescricao._Regex = null;
            this.txtxDescricao._Table = "Plano_pagamento";
            this.txtxDescricao._TamanhoComponente = 194;
            this.txtxDescricao._TamanhoMaiorLabel = 200;
            this.txtxDescricao._Visible = false;
            this.txtxDescricao.BackColor = System.Drawing.Color.Transparent;
            this.txtxDescricao.Base = null;
            this.txtxDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxDescricao.Color = System.Drawing.Color.White;
            this.txtxDescricao.Location = new System.Drawing.Point(144, 77);
            this.txtxDescricao.Margin = new System.Windows.Forms.Padding(144, 3, 15, 3);
            this.txtxDescricao.MaxLength = 32767;
            this.txtxDescricao.Name = "txtxDescricao";
            this.txtxDescricao.ReadOnly = false;
            this.txtxDescricao.Size = new System.Drawing.Size(253, 19);
            this.txtxDescricao.TabIndex = 5;
            // 
            // cbostAlocacao
            // 
            this.cbostAlocacao._Field = "stAlocacao";
            this.cbostAlocacao._Help = "Selecione a forma como os pagamentos são alocados dentro do plano de pagamento";
            this.cbostAlocacao._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostAlocacao._Itens")));
            this.cbostAlocacao._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cbostAlocacao._LabelText = "Alocação";
            this.cbostAlocacao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostAlocacao._Regex = null;
            this.cbostAlocacao._situacao = false;
            this.cbostAlocacao._Table = "Plano_pagamento";
            this.cbostAlocacao._TamanhoComponente = 194;
            this.cbostAlocacao._TamanhoMaiorLabel = 200;
            this.cbostAlocacao._Visible = false;
            this.cbostAlocacao.BackColor = System.Drawing.Color.Transparent;
            this.cbostAlocacao.Base = null;
            this.cbostAlocacao.Color = System.Drawing.Color.White;
            this.cbostAlocacao.DataSource = null;
            this.cbostAlocacao.DisplayMember = "DisplayMember";
            this.cbostAlocacao.Location = new System.Drawing.Point(150, 102);
            this.cbostAlocacao.Margin = new System.Windows.Forms.Padding(150, 3, 15, 3);
            this.cbostAlocacao.Name = "cbostAlocacao";
            this.cbostAlocacao.SelectedIndex = -1;
            this.cbostAlocacao.SelectedValue = 0;
            this.cbostAlocacao.Size = new System.Drawing.Size(247, 21);
            this.cbostAlocacao.TabIndex = 6;
            this.cbostAlocacao.ValueMember = "ValueMember";
            this.cbostAlocacao._SelectedIndexChanged += new System.EventHandler(this.cbostAlocacao__SelectedIndexChanged);
            // 
            // cbostFormaPagamento
            // 
            this.cbostFormaPagamento._Field = "stFormaPagamento";
            this.cbostFormaPagamento._Help = "Selecione o intervalo de datas em dias, meses ou anos a ser usado no cálculo da d" +
    "ata de vencimento de cada prestação";
            this.cbostFormaPagamento._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostFormaPagamento._Itens")));
            this.cbostFormaPagamento._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cbostFormaPagamento._LabelText = "Forma de pagamento";
            this.cbostFormaPagamento._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostFormaPagamento._Regex = null;
            this.cbostFormaPagamento._situacao = false;
            this.cbostFormaPagamento._Table = "Plano_pagamento";
            this.cbostFormaPagamento._TamanhoComponente = 194;
            this.cbostFormaPagamento._TamanhoMaiorLabel = 200;
            this.cbostFormaPagamento._Visible = false;
            this.cbostFormaPagamento.BackColor = System.Drawing.Color.Transparent;
            this.cbostFormaPagamento.Base = null;
            this.cbostFormaPagamento.Color = System.Drawing.Color.White;
            this.cbostFormaPagamento.DataSource = null;
            this.cbostFormaPagamento.DisplayMember = "DisplayMember";
            this.cbostFormaPagamento.Location = new System.Drawing.Point(86, 129);
            this.cbostFormaPagamento.Margin = new System.Windows.Forms.Padding(86, 3, 15, 3);
            this.cbostFormaPagamento.Name = "cbostFormaPagamento";
            this.cbostFormaPagamento.SelectedIndex = -1;
            this.cbostFormaPagamento.SelectedValue = 0;
            this.cbostFormaPagamento.Size = new System.Drawing.Size(311, 21);
            this.cbostFormaPagamento.TabIndex = 7;
            this.cbostFormaPagamento.ValueMember = "ValueMember";
            // 
            // nudnAlterar
            // 
            this.nudnAlterar._Field = "nAlterar";
            this.nudnAlterar._Help = "Insira o número de unidades entre as datas de vencimento de cada prestação no cam" +
    "po forma de pagamento";
            this.nudnAlterar._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.nudnAlterar._LabelText = "Alterar";
            this.nudnAlterar._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudnAlterar._Regex = null;
            this.nudnAlterar._Table = "Plano_pagamento";
            this.nudnAlterar._TamanhoComponente = 119;
            this.nudnAlterar._TamanhoMaiorLabel = 200;
            this.nudnAlterar._Visible = false;
            this.nudnAlterar.BackColor = System.Drawing.Color.Transparent;
            this.nudnAlterar.Base = null;
            this.nudnAlterar.Color = System.Drawing.Color.White;
            this.nudnAlterar.DecimalPlaces = 2;
            this.nudnAlterar.Location = new System.Drawing.Point(162, 156);
            this.nudnAlterar.Margin = new System.Windows.Forms.Padding(162, 3, 15, 3);
            this.nudnAlterar.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudnAlterar.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudnAlterar.Name = "nudnAlterar";
            this.nudnAlterar.ReadOnly = false;
            this.nudnAlterar.Size = new System.Drawing.Size(160, 21);
            this.nudnAlterar.TabIndex = 8;
            this.nudnAlterar.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudnAlterar.ValueInt = 0;
            // 
            // nudnNumerosPagamentos
            // 
            this.nudnNumerosPagamentos._Field = "nNumerosPagamentos";
            this.nudnNumerosPagamentos._Help = "Se você selecionou a opção quantidade fixa no campo alocação, especifique o númer" +
    "o de prestações para o plano de pagamento";
            this.nudnNumerosPagamentos._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.nudnNumerosPagamentos._LabelText = "Número de pagamentos";
            this.nudnNumerosPagamentos._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudnNumerosPagamentos._Regex = null;
            this.nudnNumerosPagamentos._Table = "Plano_pagamento";
            this.nudnNumerosPagamentos._TamanhoComponente = 119;
            this.nudnNumerosPagamentos._TamanhoMaiorLabel = 200;
            this.nudnNumerosPagamentos._Visible = false;
            this.nudnNumerosPagamentos.BackColor = System.Drawing.Color.Transparent;
            this.nudnNumerosPagamentos.Base = null;
            this.nudnNumerosPagamentos.Color = System.Drawing.Color.White;
            this.nudnNumerosPagamentos.DecimalPlaces = 2;
            this.nudnNumerosPagamentos.Location = new System.Drawing.Point(72, 183);
            this.nudnNumerosPagamentos.Margin = new System.Windows.Forms.Padding(72, 3, 15, 3);
            this.nudnNumerosPagamentos.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudnNumerosPagamentos.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudnNumerosPagamentos.Name = "nudnNumerosPagamentos";
            this.nudnNumerosPagamentos.ReadOnly = false;
            this.nudnNumerosPagamentos.Size = new System.Drawing.Size(250, 21);
            this.nudnNumerosPagamentos.TabIndex = 9;
            this.nudnNumerosPagamentos.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudnNumerosPagamentos.ValueInt = 0;
            // 
            // nudnValorMoeda
            // 
            this.nudnValorMoeda._Field = "nValorMoeda";
            this.nudnValorMoeda._Help = "Se você selecionou a opção valor fixo no campo alocação , especifique o valor da " +
    "moeda de cada prestação";
            this.nudnValorMoeda._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.nudnValorMoeda._LabelText = "Valor na moeda";
            this.nudnValorMoeda._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudnValorMoeda._Regex = null;
            this.nudnValorMoeda._Table = "Plano_pagamento";
            this.nudnValorMoeda._TamanhoComponente = 119;
            this.nudnValorMoeda._TamanhoMaiorLabel = 200;
            this.nudnValorMoeda._Visible = false;
            this.nudnValorMoeda.BackColor = System.Drawing.Color.Transparent;
            this.nudnValorMoeda.Base = null;
            this.nudnValorMoeda.Color = System.Drawing.Color.White;
            this.nudnValorMoeda.DecimalPlaces = 2;
            this.nudnValorMoeda.Location = new System.Drawing.Point(115, 210);
            this.nudnValorMoeda.Margin = new System.Windows.Forms.Padding(115, 3, 15, 3);
            this.nudnValorMoeda.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudnValorMoeda.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudnValorMoeda.Name = "nudnValorMoeda";
            this.nudnValorMoeda.ReadOnly = false;
            this.nudnValorMoeda.Size = new System.Drawing.Size(207, 22);
            this.nudnValorMoeda.TabIndex = 10;
            this.nudnValorMoeda.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudnValorMoeda.ValueInt = 0;
            // 
            // nudnValorMinimo
            // 
            this.nudnValorMinimo._Field = "nValorMinimo";
            this.nudnValorMinimo._Help = "Especifique o menor valor da prestação";
            this.nudnValorMinimo._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.nudnValorMinimo._LabelText = "Valor mínimo";
            this.nudnValorMinimo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudnValorMinimo._Regex = null;
            this.nudnValorMinimo._Table = "Plano_pagamento";
            this.nudnValorMinimo._TamanhoComponente = 119;
            this.nudnValorMinimo._TamanhoMaiorLabel = 200;
            this.nudnValorMinimo._Visible = false;
            this.nudnValorMinimo.BackColor = System.Drawing.Color.Transparent;
            this.nudnValorMinimo.Base = null;
            this.nudnValorMinimo.Color = System.Drawing.Color.White;
            this.nudnValorMinimo.DecimalPlaces = 2;
            this.nudnValorMinimo.Location = new System.Drawing.Point(128, 238);
            this.nudnValorMinimo.Margin = new System.Windows.Forms.Padding(128, 3, 15, 3);
            this.nudnValorMinimo.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudnValorMinimo.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudnValorMinimo.Name = "nudnValorMinimo";
            this.nudnValorMinimo.ReadOnly = false;
            this.nudnValorMinimo.Size = new System.Drawing.Size(194, 22);
            this.nudnValorMinimo.TabIndex = 11;
            this.nudnValorMinimo.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudnValorMinimo.ValueInt = 0;
            // 
            // cbostAlocacaoImpostos
            // 
            this.cbostAlocacaoImpostos._Field = "stAlocacaoImpostos";
            this.cbostAlocacaoImpostos._Help = "Selecione um método de distribuição do valor do imposto sobre vendas para prestaç" +
    "ões do plano de pagamento";
            this.cbostAlocacaoImpostos._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostAlocacaoImpostos._Itens")));
            this.cbostAlocacaoImpostos._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cbostAlocacaoImpostos._LabelText = "Alocação de imposto sobre vendas";
            this.cbostAlocacaoImpostos._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostAlocacaoImpostos._Regex = null;
            this.cbostAlocacaoImpostos._situacao = false;
            this.cbostAlocacaoImpostos._Table = "Plano_pagamento";
            this.cbostAlocacaoImpostos._TamanhoComponente = 195;
            this.cbostAlocacaoImpostos._TamanhoMaiorLabel = 200;
            this.cbostAlocacaoImpostos._Visible = false;
            this.cbostAlocacaoImpostos.BackColor = System.Drawing.Color.Transparent;
            this.cbostAlocacaoImpostos.Base = null;
            this.cbostAlocacaoImpostos.Color = System.Drawing.Color.White;
            this.cbostAlocacaoImpostos.DataSource = null;
            this.cbostAlocacaoImpostos.DisplayMember = "DisplayMember";
            this.cbostAlocacaoImpostos.Location = new System.Drawing.Point(18, 266);
            this.cbostAlocacaoImpostos.Margin = new System.Windows.Forms.Padding(18, 3, 15, 3);
            this.cbostAlocacaoImpostos.Name = "cbostAlocacaoImpostos";
            this.cbostAlocacaoImpostos.SelectedIndex = -1;
            this.cbostAlocacaoImpostos.SelectedValue = 0;
            this.cbostAlocacaoImpostos.Size = new System.Drawing.Size(380, 21);
            this.cbostAlocacaoImpostos.TabIndex = 12;
            this.cbostAlocacaoImpostos.ValueMember = "ValueMember";
            // 
            // txtxNota
            // 
            this.txtxNota._Field = "xNota";
            this.txtxNota._Help = "Insira uma nota que explica como e quando usar o plano de pagamento";
            this.txtxNota._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtxNota._LabelText = "Nota";
            this.txtxNota._Multiline = false;
            this.txtxNota._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxNota._Password = false;
            this.txtxNota._Regex = null;
            this.txtxNota._Table = "Plano_pagamento";
            this.txtxNota._TamanhoComponente = 195;
            this.txtxNota._TamanhoMaiorLabel = 200;
            this.txtxNota._Visible = false;
            this.txtxNota.BackColor = System.Drawing.Color.Transparent;
            this.txtxNota.Base = null;
            this.txtxNota.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxNota.Color = System.Drawing.Color.White;
            this.txtxNota.Location = new System.Drawing.Point(171, 293);
            this.txtxNota.Margin = new System.Windows.Forms.Padding(171, 3, 15, 3);
            this.txtxNota.MaxLength = 32767;
            this.txtxNota.Name = "txtxNota";
            this.txtxNota.ReadOnly = false;
            this.txtxNota.Size = new System.Drawing.Size(227, 22);
            this.txtxNota.TabIndex = 13;
            // 
            // tabPlanPagamento
            // 
            this.tabPlanPagamento.BackColor = System.Drawing.SystemColors.Window;
            this.tabPlanPagamento.Controls.Add(this.kryptonPanel2);
            this.tabPlanPagamento.Location = new System.Drawing.Point(4, 25);
            this.tabPlanPagamento.Margin = new System.Windows.Forms.Padding(0);
            this.tabPlanPagamento.Name = "tabPlanPagamento";
            this.tabPlanPagamento.Size = new System.Drawing.Size(1110, 536);
            this.tabPlanPagamento.TabIndex = 1;
            this.tabPlanPagamento.Tag = false;
            this.tabPlanPagamento.Text = "Plano de Pagamento";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.BorderWidth = 0;
            this.kryptonPanel2.Controls.Add(this.kryptonTabControl1);
            this.kryptonPanel2.Controls.Add(this.flowLayoutPanel2);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.kryptonPanel2.GradientToogleColors = false;
            this.kryptonPanel2.GradientUseBlend = false;
            this.kryptonPanel2.GradientUseSolid = true;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.PersistentColors = false;
            this.kryptonPanel2.Size = new System.Drawing.Size(1110, 536);
            this.kryptonPanel2.TabIndex = 1;
            // 
            // kryptonTabControl1
            // 
            this.kryptonTabControl1.AllowCloseButton = false;
            this.kryptonTabControl1.AllowContextButton = false;
            this.kryptonTabControl1.AllowNavigatorButtons = false;
            this.kryptonTabControl1.AllowSelectedTabHigh = false;
            this.kryptonTabControl1.BorderWidth = 1;
            this.kryptonTabControl1.Controls.Add(this.tabPage2);
            this.kryptonTabControl1.CornerRoundRadiusWidth = 12;
            this.kryptonTabControl1.CornerSymmetry = AC.ExtendedRenderer.Navigator.KryptonTabControl.CornSymmetry.Both;
            this.kryptonTabControl1.CornerType = AC.ExtendedRenderer.Toolkit.Drawing.DrawingMethods.CornerType.Rounded;
            this.kryptonTabControl1.CornerWidth = AC.ExtendedRenderer.Navigator.KryptonTabControl.CornWidth.Thin;
            this.kryptonTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.kryptonTabControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.kryptonTabControl1.HotTrack = true;
            this.kryptonTabControl1.Location = new System.Drawing.Point(0, 93);
            this.kryptonTabControl1.Name = "kryptonTabControl1";
            this.kryptonTabControl1.PreserveTabColor = false;
            this.kryptonTabControl1.SelectedIndex = 0;
            this.kryptonTabControl1.Size = new System.Drawing.Size(1110, 443);
            this.kryptonTabControl1.TabIndex = 29;
            this.kryptonTabControl1.UseExtendedLayout = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage2.Controls.Add(this.kryptonPanel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1102, 414);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Tag = false;
            this.tabPage2.Text = "Grade";
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.BorderWidth = 0;
            this.kryptonPanel3.Controls.Add(this.dgvLinhaPagamento);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel3.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.kryptonPanel3.GradientToogleColors = false;
            this.kryptonPanel3.GradientUseBlend = false;
            this.kryptonPanel3.GradientUseSolid = true;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.PersistentColors = false;
            this.kryptonPanel3.Size = new System.Drawing.Size(1102, 414);
            this.kryptonPanel3.TabIndex = 0;
            // 
            // dgvLinhaPagamento
            // 
            this.dgvLinhaPagamento.Altera = false;
            this.dgvLinhaPagamento.AutoGenerateColumns = false;
            this.dgvLinhaPagamento.cm = null;
            this.dgvLinhaPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLinhaPagamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nQuantidade,
            this.clstValorouPorcentagem,
            this.clnValorouPorcentagem});
            this.dgvLinhaPagamento.DataSource = this.bsLinhas;
            this.dgvLinhaPagamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLinhaPagamento.DragDropLinha = false;
            this.dgvLinhaPagamento.Exclui = false;
            this.dgvLinhaPagamento.Inclui = false;
            this.dgvLinhaPagamento.Location = new System.Drawing.Point(0, 0);
            this.dgvLinhaPagamento.Name = "dgvLinhaPagamento";
            this.dgvLinhaPagamento.Size = new System.Drawing.Size(1102, 414);
            this.dgvLinhaPagamento.TabIndex = 2;
            this.dgvLinhaPagamento.Tag = "Plano_pagamento_linhas";
            // 
            // nQuantidade
            // 
            this.nQuantidade.DataPropertyName = "nQuantidade";
            this.nQuantidade.HeaderText = "Parcelas";
            this.nQuantidade.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nQuantidade.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nQuantidade.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nQuantidade.Name = "nQuantidade";
            this.nQuantidade.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nQuantidade.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.nQuantidade.ToolTipText = "o número de dias, meses ou anos após a data de vencimento que é definida pelas co" +
    "ndições de pagamento para a nota fiscal ";
            this.nQuantidade.Width = 100;
            // 
            // clstValorouPorcentagem
            // 
            this.clstValorouPorcentagem.DataPropertyName = "stValorouPorcentagem";
            this.clstValorouPorcentagem.HeaderText = "Tipo";
            this.clstValorouPorcentagem.Items.AddRange(new object[] {
            "0 - PORCENTAGEM  ",
            "1 - VALOR ESPECÍFICO"});
            this.clstValorouPorcentagem.Name = "clstValorouPorcentagem";
            this.clstValorouPorcentagem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clstValorouPorcentagem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clstValorouPorcentagem.ToolTipText = "Indique se o valor inserido é uma Porcentagem ou um  Valor Específico.";
            this.clstValorouPorcentagem.Width = 160;
            // 
            // clnValorouPorcentagem
            // 
            this.clnValorouPorcentagem.DataPropertyName = "nValorouPorcentagem";
            this.clnValorouPorcentagem.HeaderText = "Valor ou Porcentagem";
            this.clnValorouPorcentagem.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.clnValorouPorcentagem.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.clnValorouPorcentagem.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.clnValorouPorcentagem.Name = "clnValorouPorcentagem";
            this.clnValorouPorcentagem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnValorouPorcentagem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clnValorouPorcentagem.ToolTipText = "Insira o valor da prestação como uma porcentagem do valor faturado ou como um val" +
    "or de moeda";
            this.clnValorouPorcentagem.Width = 180;
            // 
            // bsLinhas
            // 
            this.bsLinhas.DataSource = typeof(HLP.Models.Entries.Gerais.Plano_pagamento_linhasModel);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.sp_PlanoPgto);
            this.flowLayoutPanel2.Controls.Add(this.nudNumParcelas);
            this.flowLayoutPanel2.Controls.Add(this.hlP_Button1);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1110, 93);
            this.flowLayoutPanel2.TabIndex = 28;
            // 
            // sp_PlanoPgto
            // 
            this.sp_PlanoPgto._LabelText = "Plano de pagamento";
            this.sp_PlanoPgto._TamanhoMaiorLabel = 0;
            this.sp_PlanoPgto.BackColor = System.Drawing.Color.Transparent;
            this.sp_PlanoPgto.Location = new System.Drawing.Point(3, 3);
            this.sp_PlanoPgto.Name = "sp_PlanoPgto";
            this.sp_PlanoPgto.Size = new System.Drawing.Size(251, 18);
            this.sp_PlanoPgto.TabIndex = 3;
            this.sp_PlanoPgto.TabStop = false;
            // 
            // nudNumParcelas
            // 
            this.nudNumParcelas._Help = "Numero de parcelas para gerar a grade";
            this.nudNumParcelas._LabelGroup = this.sp_PlanoPgto;
            this.nudNumParcelas._LabelText = "Quantidade de parcelas";
            this.nudNumParcelas._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudNumParcelas._Regex = null;
            this.nudNumParcelas._TamanhoComponente = 56;
            this.nudNumParcelas._TamanhoMaiorLabel = 0;
            this.nudNumParcelas._Visible = false;
            this.nudNumParcelas.BackColor = System.Drawing.Color.Transparent;
            this.nudNumParcelas.Base = null;
            this.nudNumParcelas.Color = System.Drawing.Color.White;
            this.nudNumParcelas.DecimalPlaces = 0;
            this.nudNumParcelas.Location = new System.Drawing.Point(0, 27);
            this.nudNumParcelas.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.nudNumParcelas.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudNumParcelas.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudNumParcelas.Name = "nudNumParcelas";
            this.nudNumParcelas.ReadOnly = false;
            this.nudNumParcelas.Size = new System.Drawing.Size(185, 22);
            this.nudNumParcelas.TabIndex = 0;
            this.nudNumParcelas.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudNumParcelas.ValueInt = 0;
            // 
            // hlP_Button1
            // 
            this.hlP_Button1._LabelGroup = this.sp_PlanoPgto;
            this.hlP_Button1._LabelText = "Gerar gride";
            this.hlP_Button1._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_Button1._Regex = null;
            this.hlP_Button1._TamanhoComponente = 111;
            this.hlP_Button1._TamanhoMaiorLabel = 0;
            this.hlP_Button1._Visible = false;
            this.hlP_Button1.Base = null;
            this.hlP_Button1.Location = new System.Drawing.Point(0, 55);
            this.hlP_Button1.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.hlP_Button1.Name = "hlP_Button1";
            this.hlP_Button1.Size = new System.Drawing.Size(111, 24);
            this.hlP_Button1.TabIndex = 5;
            this.hlP_Button1._btnHlpClick += new System.EventHandler(this.hlP_Button1__btnHlpClick);
            // 
            // FormPlanoPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 622);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPlanoPagamento";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = -10;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Text = "Planos de Pagamento";
            this.Load += new System.EventHandler(this.FormPlanoPagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).EndInit();
            this.panelPadrao.ResumeLayout(false);
            this.tcPlanosPagamento.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.kryptonPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabPlanPagamento.ResumeLayout(false);
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonTabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.kryptonPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinhaPagamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLinhas)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AC.ExtendedRenderer.Navigator.KryptonTabControl tcPlanosPagamento;
        private System.Windows.Forms.TabPage tabPage1;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Comum.Components.HLP_TextBox txtCodigo;
        private Comum.Components.HLP_TextBox txtxPlanoPagamento;
        private Comum.Components.HLP_TextBox txtxDescricao;
        private System.Windows.Forms.TabPage tabPlanPagamento;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel2;
        private Comum.Components.HLP_ComboBox cbostAlocacao;
        private Comum.Components.HLP_ComboBox cbostFormaPagamento;
        private Comum.Components.HLP_NumericUpDown nudnAlterar;
        private Comum.Components.HLP_NumericUpDown nudnNumerosPagamentos;
        private Comum.Components.HLP_NumericUpDown nudnValorMoeda;
        private Comum.Components.HLP_NumericUpDown nudnValorMinimo;
        private Comum.Components.HLP_ComboBox cbostAlocacaoImpostos;
        private Comum.Components.HLP_TextBox txtxNota;
        private System.Windows.Forms.BindingSource bsLinhas;
        private HLP_LabelSeparator hlP_LabelSeparator1_Geral;
        private HLP_NumericUpDown nudNumParcelas;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel3;
        private HLP_DataGridView dgvLinhaPagamento;
        private HLP_LabelSeparator sp_PlanoPgto;
        private HLP_Button hlP_Button1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn nQuantidade;
        private System.Windows.Forms.DataGridViewComboBoxColumn clstValorouPorcentagem;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn clnValorouPorcentagem;
    }
}