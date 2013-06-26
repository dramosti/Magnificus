namespace HLP.UI.Entries.Fiscal
{
    partial class FormClassificacaoFiscal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClassificacaoFiscal));
            this.Principal = new System.Windows.Forms.FlowLayoutPanel();
            this.hlP_LabelSeparator1_Geral = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtCodigo = new HLP.Comum.Components.HLP_TextBox();
            this.txtxCassificacaoFiscal = new HLP.Comum.Components.HLP_TextBox();
            this.txtcNCM = new HLP.Comum.Components.HLP_TextBox();
            this.txtcClassifcacaoFiscal = new HLP.Comum.Components.HLP_TextBox();
            this.txtxFundamentoLegal = new HLP.Comum.Components.HLP_TextBox();
            this.nudpIPI = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudpPis = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudpII = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudpCofins = new HLP.Comum.Components.HLP_NumericUpDown();
            this.cbostCalculaPisCofins = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostRegimeTributacaoPisCofins = new HLP.Comum.Components.HLP_ComboBox();
            this.nudvCoeficienteSubstituicaoPis = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudvCoeficienteSubstituicaoCofins = new HLP.Comum.Components.HLP_NumericUpDown();
            this.cbostCompoeBaseNormalPisCofins = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostCompoeBaseSubstPis = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostCompoeBaseSubstCofins = new HLP.Comum.Components.HLP_ComboBox();
            this.cboAtivo = new HLP.Comum.Components.HLP_ComboBox();
            this.kryptonTabControl1 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kryptonPanel1 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).BeginInit();
            this.panelPadrao.SuspendLayout();
            this.Principal.SuspendLayout();
            this.kryptonTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(818, 436);
            // 
            // panelPadrao
            // 
            this.panelPadrao.Controls.Add(this.kryptonTabControl1);
            this.panelPadrao.Size = new System.Drawing.Size(816, 412);
            // 
            // Principal
            // 
            this.Principal.AutoScroll = true;
            this.Principal.BackColor = System.Drawing.Color.Transparent;
            this.Principal.Controls.Add(this.hlP_LabelSeparator1_Geral);
            this.Principal.Controls.Add(this.txtCodigo);
            this.Principal.Controls.Add(this.txtxCassificacaoFiscal);
            this.Principal.Controls.Add(this.txtcNCM);
            this.Principal.Controls.Add(this.txtcClassifcacaoFiscal);
            this.Principal.Controls.Add(this.txtxFundamentoLegal);
            this.Principal.Controls.Add(this.nudpIPI);
            this.Principal.Controls.Add(this.nudpPis);
            this.Principal.Controls.Add(this.nudpII);
            this.Principal.Controls.Add(this.nudpCofins);
            this.Principal.Controls.Add(this.cbostCalculaPisCofins);
            this.Principal.Controls.Add(this.cbostRegimeTributacaoPisCofins);
            this.Principal.Controls.Add(this.nudvCoeficienteSubstituicaoPis);
            this.Principal.Controls.Add(this.nudvCoeficienteSubstituicaoCofins);
            this.Principal.Controls.Add(this.cbostCompoeBaseNormalPisCofins);
            this.Principal.Controls.Add(this.cbostCompoeBaseSubstPis);
            this.Principal.Controls.Add(this.cbostCompoeBaseSubstCofins);
            this.Principal.Controls.Add(this.cboAtivo);
            this.Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Principal.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Principal.Location = new System.Drawing.Point(0, 0);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(802, 377);
            this.Principal.TabIndex = 1;
            this.Principal.Tag = "Principal";
            // 
            // hlP_LabelSeparator1_Geral
            // 
            this.hlP_LabelSeparator1_Geral._LabelText = "Geral";
            this.hlP_LabelSeparator1_Geral._TamanhoMaiorLabel = 0;
            this.hlP_LabelSeparator1_Geral.BackColor = System.Drawing.Color.Transparent;
            this.hlP_LabelSeparator1_Geral.Location = new System.Drawing.Point(3, 3);
            this.hlP_LabelSeparator1_Geral.Name = "hlP_LabelSeparator1_Geral";
            this.hlP_LabelSeparator1_Geral.Size = new System.Drawing.Size(300, 18);
            this.hlP_LabelSeparator1_Geral.TabIndex = 54;
            this.hlP_LabelSeparator1_Geral.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo._Field = "idClassificacaoFiscal";
            this.txtCodigo._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtCodigo._LabelText = "Código";
            this.txtCodigo._Multiline = false;
            this.txtCodigo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtCodigo._Password = false;
            this.txtCodigo._Regex = null;
            this.txtCodigo._Table = "Classificacao_fiscal";
            this.txtCodigo._TamanhoComponente = 107;
            this.txtCodigo._TamanhoMaiorLabel = 225;
            this.txtCodigo._Visible = false;
            this.txtCodigo.BackColor = System.Drawing.Color.Transparent;
            this.txtCodigo.Base = null;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCodigo.Color = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(183, 27);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(183, 3, 15, 3);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(152, 21);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtxCassificacaoFiscal
            // 
            this.txtxCassificacaoFiscal._Field = "xClassificacaoFiscal";
            this.txtxCassificacaoFiscal._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtxCassificacaoFiscal._LabelText = "Nome";
            this.txtxCassificacaoFiscal._Multiline = false;
            this.txtxCassificacaoFiscal._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxCassificacaoFiscal._Password = false;
            this.txtxCassificacaoFiscal._Regex = null;
            this.txtxCassificacaoFiscal._Table = "Classificacao_fiscal";
            this.txtxCassificacaoFiscal._TamanhoComponente = 209;
            this.txtxCassificacaoFiscal._TamanhoMaiorLabel = 225;
            this.txtxCassificacaoFiscal._Visible = false;
            this.txtxCassificacaoFiscal.BackColor = System.Drawing.Color.Transparent;
            this.txtxCassificacaoFiscal.Base = null;
            this.txtxCassificacaoFiscal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxCassificacaoFiscal.Color = System.Drawing.Color.White;
            this.txtxCassificacaoFiscal.Location = new System.Drawing.Point(191, 54);
            this.txtxCassificacaoFiscal.Margin = new System.Windows.Forms.Padding(191, 3, 15, 3);
            this.txtxCassificacaoFiscal.MaxLength = 32767;
            this.txtxCassificacaoFiscal.Name = "txtxCassificacaoFiscal";
            this.txtxCassificacaoFiscal.ReadOnly = false;
            this.txtxCassificacaoFiscal.Size = new System.Drawing.Size(246, 21);
            this.txtxCassificacaoFiscal.TabIndex = 3;
            // 
            // txtcNCM
            // 
            this.txtcNCM._Field = "cNCM";
            this.txtcNCM._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtcNCM._LabelText = "Código ncm";
            this.txtcNCM._Multiline = false;
            this.txtcNCM._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtcNCM._Password = false;
            this.txtcNCM._Regex = null;
            this.txtcNCM._Table = "Classificacao_fiscal";
            this.txtcNCM._TamanhoComponente = 209;
            this.txtcNCM._TamanhoMaiorLabel = 225;
            this.txtcNCM._Visible = false;
            this.txtcNCM.BackColor = System.Drawing.Color.Transparent;
            this.txtcNCM.Base = null;
            this.txtcNCM.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtcNCM.Color = System.Drawing.Color.White;
            this.txtcNCM.Location = new System.Drawing.Point(159, 81);
            this.txtcNCM.Margin = new System.Windows.Forms.Padding(159, 3, 15, 3);
            this.txtcNCM.MaxLength = 10;
            this.txtcNCM.Name = "txtcNCM";
            this.txtcNCM.ReadOnly = false;
            this.txtcNCM.Size = new System.Drawing.Size(278, 21);
            this.txtcNCM.TabIndex = 2;
            // 
            // txtcClassifcacaoFiscal
            // 
            this.txtcClassifcacaoFiscal._Field = "cClassifcacaoFiscal";
            this.txtcClassifcacaoFiscal._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtcClassifcacaoFiscal._LabelText = "Código abreviado";
            this.txtcClassifcacaoFiscal._Multiline = false;
            this.txtcClassifcacaoFiscal._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtcClassifcacaoFiscal._Password = false;
            this.txtcClassifcacaoFiscal._Regex = null;
            this.txtcClassifcacaoFiscal._Table = "Classificacao_fiscal";
            this.txtcClassifcacaoFiscal._TamanhoComponente = 87;
            this.txtcClassifcacaoFiscal._TamanhoMaiorLabel = 225;
            this.txtcClassifcacaoFiscal._Visible = false;
            this.txtcClassifcacaoFiscal.BackColor = System.Drawing.Color.Transparent;
            this.txtcClassifcacaoFiscal.Base = null;
            this.txtcClassifcacaoFiscal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtcClassifcacaoFiscal.Color = System.Drawing.Color.White;
            this.txtcClassifcacaoFiscal.Location = new System.Drawing.Point(129, 108);
            this.txtcClassifcacaoFiscal.Margin = new System.Windows.Forms.Padding(129, 3, 15, 3);
            this.txtcClassifcacaoFiscal.MaxLength = 10;
            this.txtcClassifcacaoFiscal.Name = "txtcClassifcacaoFiscal";
            this.txtcClassifcacaoFiscal.ReadOnly = false;
            this.txtcClassifcacaoFiscal.Size = new System.Drawing.Size(186, 21);
            this.txtcClassifcacaoFiscal.TabIndex = 4;
            // 
            // txtxFundamentoLegal
            // 
            this.txtxFundamentoLegal._Field = "xFundamentoLegal";
            this.txtxFundamentoLegal._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtxFundamentoLegal._LabelText = "Fundamento legal";
            this.txtxFundamentoLegal._Multiline = false;
            this.txtxFundamentoLegal._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxFundamentoLegal._Password = false;
            this.txtxFundamentoLegal._Regex = null;
            this.txtxFundamentoLegal._Table = "Classificacao_fiscal";
            this.txtxFundamentoLegal._TamanhoComponente = 214;
            this.txtxFundamentoLegal._TamanhoMaiorLabel = 225;
            this.txtxFundamentoLegal._Visible = false;
            this.txtxFundamentoLegal.BackColor = System.Drawing.Color.Transparent;
            this.txtxFundamentoLegal.Base = null;
            this.txtxFundamentoLegal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxFundamentoLegal.Color = System.Drawing.Color.White;
            this.txtxFundamentoLegal.Location = new System.Drawing.Point(127, 135);
            this.txtxFundamentoLegal.Margin = new System.Windows.Forms.Padding(127, 3, 15, 3);
            this.txtxFundamentoLegal.MaxLength = 32767;
            this.txtxFundamentoLegal.Name = "txtxFundamentoLegal";
            this.txtxFundamentoLegal.ReadOnly = false;
            this.txtxFundamentoLegal.Size = new System.Drawing.Size(315, 21);
            this.txtxFundamentoLegal.TabIndex = 6;
            // 
            // nudpIPI
            // 
            this.nudpIPI._Field = "pIPI";
            this.nudpIPI._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.nudpIPI._LabelText = "Alíquota de ipi";
            this.nudpIPI._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudpIPI._Regex = null;
            this.nudpIPI._Table = "Classificacao_fiscal";
            this.nudpIPI._TamanhoComponente = 124;
            this.nudpIPI._TamanhoMaiorLabel = 225;
            this.nudpIPI._Visible = false;
            this.nudpIPI.BackColor = System.Drawing.Color.Transparent;
            this.nudpIPI.Base = null;
            this.nudpIPI.Color = System.Drawing.Color.White;
            this.nudpIPI.DecimalPlaces = 2;
            this.nudpIPI.Location = new System.Drawing.Point(145, 162);
            this.nudpIPI.Margin = new System.Windows.Forms.Padding(145, 3, 15, 3);
            this.nudpIPI.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudpIPI.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudpIPI.Name = "nudpIPI";
            this.nudpIPI.ReadOnly = false;
            this.nudpIPI.Size = new System.Drawing.Size(207, 22);
            this.nudpIPI.TabIndex = 5;
            this.nudpIPI.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudpIPI.ValueInt = 0;
            // 
            // nudpPis
            // 
            this.nudpPis._Field = "pPis";
            this.nudpPis._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.nudpPis._LabelText = "Alíquota de pis";
            this.nudpPis._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudpPis._Regex = null;
            this.nudpPis._Table = "Classificacao_fiscal";
            this.nudpPis._TamanhoComponente = 123;
            this.nudpPis._TamanhoMaiorLabel = 225;
            this.nudpPis._Visible = false;
            this.nudpPis.BackColor = System.Drawing.Color.Transparent;
            this.nudpPis.Base = null;
            this.nudpPis.Color = System.Drawing.Color.White;
            this.nudpPis.DecimalPlaces = 2;
            this.nudpPis.Location = new System.Drawing.Point(143, 190);
            this.nudpPis.Margin = new System.Windows.Forms.Padding(143, 3, 15, 3);
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
            this.nudpPis.ReadOnly = false;
            this.nudpPis.Size = new System.Drawing.Size(208, 22);
            this.nudpPis.TabIndex = 29;
            this.nudpPis.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudpPis.ValueInt = 0;
            // 
            // nudpII
            // 
            this.nudpII._Field = "pII";
            this.nudpII._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.nudpII._LabelText = "Alíquota de ii";
            this.nudpII._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudpII._Regex = null;
            this.nudpII._Table = "Classificacao_fiscal";
            this.nudpII._TamanhoComponente = 123;
            this.nudpII._TamanhoMaiorLabel = 225;
            this.nudpII._Visible = false;
            this.nudpII.BackColor = System.Drawing.Color.Transparent;
            this.nudpII.Base = null;
            this.nudpII.Color = System.Drawing.Color.White;
            this.nudpII.DecimalPlaces = 2;
            this.nudpII.Location = new System.Drawing.Point(152, 218);
            this.nudpII.Margin = new System.Windows.Forms.Padding(152, 3, 15, 3);
            this.nudpII.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudpII.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudpII.Name = "nudpII";
            this.nudpII.ReadOnly = false;
            this.nudpII.Size = new System.Drawing.Size(199, 22);
            this.nudpII.TabIndex = 24;
            this.nudpII.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudpII.ValueInt = 0;
            // 
            // nudpCofins
            // 
            this.nudpCofins._Field = "pCofins";
            this.nudpCofins._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.nudpCofins._LabelText = "Alíquota de cofins";
            this.nudpCofins._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudpCofins._Regex = null;
            this.nudpCofins._Table = "Classificacao_fiscal";
            this.nudpCofins._TamanhoComponente = 127;
            this.nudpCofins._TamanhoMaiorLabel = 225;
            this.nudpCofins._Visible = false;
            this.nudpCofins.BackColor = System.Drawing.Color.Transparent;
            this.nudpCofins.Base = null;
            this.nudpCofins.Color = System.Drawing.Color.White;
            this.nudpCofins.DecimalPlaces = 2;
            this.nudpCofins.Location = new System.Drawing.Point(127, 246);
            this.nudpCofins.Margin = new System.Windows.Forms.Padding(127, 3, 15, 3);
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
            this.nudpCofins.ReadOnly = false;
            this.nudpCofins.Size = new System.Drawing.Size(228, 22);
            this.nudpCofins.TabIndex = 30;
            this.nudpCofins.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudpCofins.ValueInt = 0;
            // 
            // cbostCalculaPisCofins
            // 
            this.cbostCalculaPisCofins._Field = "stCalculaPisCofins";
            this.cbostCalculaPisCofins._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostCalculaPisCofins._Itens")));
            this.cbostCalculaPisCofins._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cbostCalculaPisCofins._LabelText = "Calcula pis/cofins?";
            this.cbostCalculaPisCofins._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostCalculaPisCofins._Regex = null;
            this.cbostCalculaPisCofins._situacao = false;
            this.cbostCalculaPisCofins._Table = "Classificacao_fiscal";
            this.cbostCalculaPisCofins._TamanhoComponente = 197;
            this.cbostCalculaPisCofins._TamanhoMaiorLabel = 225;
            this.cbostCalculaPisCofins._Visible = false;
            this.cbostCalculaPisCofins.BackColor = System.Drawing.Color.Transparent;
            this.cbostCalculaPisCofins.Base = null;
            this.cbostCalculaPisCofins.Color = System.Drawing.Color.White;
            this.cbostCalculaPisCofins.DataSource = null;
            this.cbostCalculaPisCofins.DisplayMember = "DisplayMember";
            this.cbostCalculaPisCofins.Location = new System.Drawing.Point(126, 274);
            this.cbostCalculaPisCofins.Margin = new System.Windows.Forms.Padding(126, 3, 15, 3);
            this.cbostCalculaPisCofins.Name = "cbostCalculaPisCofins";
            this.cbostCalculaPisCofins.SelectedIndex = -1;
            this.cbostCalculaPisCofins.SelectedValue = 0;
            this.cbostCalculaPisCofins.Size = new System.Drawing.Size(299, 21);
            this.cbostCalculaPisCofins.TabIndex = 25;
            this.cbostCalculaPisCofins.ValueMember = "ValueMember";
            // 
            // cbostRegimeTributacaoPisCofins
            // 
            this.cbostRegimeTributacaoPisCofins._Field = "stRegimeTributacaoPisCofins";
            this.cbostRegimeTributacaoPisCofins._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostRegimeTributacaoPisCofins._Itens")));
            this.cbostRegimeTributacaoPisCofins._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cbostRegimeTributacaoPisCofins._LabelText = "Regime de tributação do pis e cofins";
            this.cbostRegimeTributacaoPisCofins._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostRegimeTributacaoPisCofins._Regex = null;
            this.cbostRegimeTributacaoPisCofins._situacao = false;
            this.cbostRegimeTributacaoPisCofins._Table = "Classificacao_fiscal";
            this.cbostRegimeTributacaoPisCofins._TamanhoComponente = 145;
            this.cbostRegimeTributacaoPisCofins._TamanhoMaiorLabel = 225;
            this.cbostRegimeTributacaoPisCofins._Visible = false;
            this.cbostRegimeTributacaoPisCofins.BackColor = System.Drawing.Color.Transparent;
            this.cbostRegimeTributacaoPisCofins.Base = null;
            this.cbostRegimeTributacaoPisCofins.Color = System.Drawing.Color.White;
            this.cbostRegimeTributacaoPisCofins.DataSource = null;
            this.cbostRegimeTributacaoPisCofins.DisplayMember = "DisplayMember";
            this.cbostRegimeTributacaoPisCofins.Location = new System.Drawing.Point(33, 301);
            this.cbostRegimeTributacaoPisCofins.Margin = new System.Windows.Forms.Padding(33, 3, 15, 3);
            this.cbostRegimeTributacaoPisCofins.Name = "cbostRegimeTributacaoPisCofins";
            this.cbostRegimeTributacaoPisCofins.SelectedIndex = -1;
            this.cbostRegimeTributacaoPisCofins.SelectedValue = 0;
            this.cbostRegimeTributacaoPisCofins.Size = new System.Drawing.Size(340, 21);
            this.cbostRegimeTributacaoPisCofins.TabIndex = 26;
            this.cbostRegimeTributacaoPisCofins.ValueMember = "ValueMember";
            // 
            // nudvCoeficienteSubstituicaoPis
            // 
            this.nudvCoeficienteSubstituicaoPis._Field = "vCoeficienteSubstituicaoPis";
            this.nudvCoeficienteSubstituicaoPis._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.nudvCoeficienteSubstituicaoPis._LabelText = "Coeficiente substituição tributária do pis";
            this.nudvCoeficienteSubstituicaoPis._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudvCoeficienteSubstituicaoPis._Regex = null;
            this.nudvCoeficienteSubstituicaoPis._Table = "Classificacao_fiscal";
            this.nudvCoeficienteSubstituicaoPis._TamanhoComponente = 139;
            this.nudvCoeficienteSubstituicaoPis._TamanhoMaiorLabel = 225;
            this.nudvCoeficienteSubstituicaoPis._Visible = false;
            this.nudvCoeficienteSubstituicaoPis.BackColor = System.Drawing.Color.Transparent;
            this.nudvCoeficienteSubstituicaoPis.Base = null;
            this.nudvCoeficienteSubstituicaoPis.Color = System.Drawing.Color.White;
            this.nudvCoeficienteSubstituicaoPis.DecimalPlaces = 2;
            this.nudvCoeficienteSubstituicaoPis.Location = new System.Drawing.Point(11, 328);
            this.nudvCoeficienteSubstituicaoPis.Margin = new System.Windows.Forms.Padding(11, 3, 15, 3);
            this.nudvCoeficienteSubstituicaoPis.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudvCoeficienteSubstituicaoPis.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudvCoeficienteSubstituicaoPis.Name = "nudvCoeficienteSubstituicaoPis";
            this.nudvCoeficienteSubstituicaoPis.ReadOnly = false;
            this.nudvCoeficienteSubstituicaoPis.Size = new System.Drawing.Size(356, 22);
            this.nudvCoeficienteSubstituicaoPis.TabIndex = 27;
            this.nudvCoeficienteSubstituicaoPis.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudvCoeficienteSubstituicaoPis.ValueInt = 0;
            // 
            // nudvCoeficienteSubstituicaoCofins
            // 
            this.nudvCoeficienteSubstituicaoCofins._Field = "vCoeficienteSubstituicaoCofins";
            this.nudvCoeficienteSubstituicaoCofins._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.nudvCoeficienteSubstituicaoCofins._LabelText = "Coeficiente substituição tributária do cofins";
            this.nudvCoeficienteSubstituicaoCofins._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudvCoeficienteSubstituicaoCofins._Regex = null;
            this.nudvCoeficienteSubstituicaoCofins._Table = "Classificacao_fiscal";
            this.nudvCoeficienteSubstituicaoCofins._TamanhoComponente = 143;
            this.nudvCoeficienteSubstituicaoCofins._TamanhoMaiorLabel = 280;
            this.nudvCoeficienteSubstituicaoCofins._Visible = false;
            this.nudvCoeficienteSubstituicaoCofins.BackColor = System.Drawing.Color.Transparent;
            this.nudvCoeficienteSubstituicaoCofins.Base = null;
            this.nudvCoeficienteSubstituicaoCofins.Color = System.Drawing.Color.White;
            this.nudvCoeficienteSubstituicaoCofins.DecimalPlaces = 2;
            this.nudvCoeficienteSubstituicaoCofins.Location = new System.Drawing.Point(507, 3);
            this.nudvCoeficienteSubstituicaoCofins.Margin = new System.Windows.Forms.Padding(50, 3, 15, 3);
            this.nudvCoeficienteSubstituicaoCofins.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudvCoeficienteSubstituicaoCofins.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudvCoeficienteSubstituicaoCofins.Name = "nudvCoeficienteSubstituicaoCofins";
            this.nudvCoeficienteSubstituicaoCofins.ReadOnly = false;
            this.nudvCoeficienteSubstituicaoCofins.Size = new System.Drawing.Size(376, 22);
            this.nudvCoeficienteSubstituicaoCofins.TabIndex = 28;
            this.nudvCoeficienteSubstituicaoCofins.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudvCoeficienteSubstituicaoCofins.ValueInt = 0;
            // 
            // cbostCompoeBaseNormalPisCofins
            // 
            this.cbostCompoeBaseNormalPisCofins._Field = "stCompoeBaseNormalPisCofins";
            this.cbostCompoeBaseNormalPisCofins._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostCompoeBaseNormalPisCofins._Itens")));
            this.cbostCompoeBaseNormalPisCofins._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cbostCompoeBaseNormalPisCofins._LabelText = "Compõe a base de pis/cofins normal?";
            this.cbostCompoeBaseNormalPisCofins._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostCompoeBaseNormalPisCofins._Regex = null;
            this.cbostCompoeBaseNormalPisCofins._situacao = false;
            this.cbostCompoeBaseNormalPisCofins._Table = "Classificacao_fiscal";
            this.cbostCompoeBaseNormalPisCofins._TamanhoComponente = 197;
            this.cbostCompoeBaseNormalPisCofins._TamanhoMaiorLabel = 280;
            this.cbostCompoeBaseNormalPisCofins._Visible = false;
            this.cbostCompoeBaseNormalPisCofins.BackColor = System.Drawing.Color.Transparent;
            this.cbostCompoeBaseNormalPisCofins.Base = null;
            this.cbostCompoeBaseNormalPisCofins.Color = System.Drawing.Color.White;
            this.cbostCompoeBaseNormalPisCofins.DataSource = null;
            this.cbostCompoeBaseNormalPisCofins.DisplayMember = "DisplayMember";
            this.cbostCompoeBaseNormalPisCofins.Location = new System.Drawing.Point(541, 31);
            this.cbostCompoeBaseNormalPisCofins.Margin = new System.Windows.Forms.Padding(84, 3, 15, 3);
            this.cbostCompoeBaseNormalPisCofins.Name = "cbostCompoeBaseNormalPisCofins";
            this.cbostCompoeBaseNormalPisCofins.SelectedIndex = -1;
            this.cbostCompoeBaseNormalPisCofins.SelectedValue = 0;
            this.cbostCompoeBaseNormalPisCofins.Size = new System.Drawing.Size(396, 21);
            this.cbostCompoeBaseNormalPisCofins.TabIndex = 50;
            this.cbostCompoeBaseNormalPisCofins.ValueMember = "ValueMember";
            // 
            // cbostCompoeBaseSubstPis
            // 
            this.cbostCompoeBaseSubstPis._Field = "stCompoeBaseSubstPis";
            this.cbostCompoeBaseSubstPis._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostCompoeBaseSubstPis._Itens")));
            this.cbostCompoeBaseSubstPis._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cbostCompoeBaseSubstPis._LabelText = "Compõe a base de pis por substituição tributária?";
            this.cbostCompoeBaseSubstPis._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostCompoeBaseSubstPis._Regex = null;
            this.cbostCompoeBaseSubstPis._situacao = false;
            this.cbostCompoeBaseSubstPis._Table = "Classificacao_fiscal";
            this.cbostCompoeBaseSubstPis._TamanhoComponente = 438;
            this.cbostCompoeBaseSubstPis._TamanhoMaiorLabel = 280;
            this.cbostCompoeBaseSubstPis._Visible = false;
            this.cbostCompoeBaseSubstPis.BackColor = System.Drawing.Color.Transparent;
            this.cbostCompoeBaseSubstPis.Base = null;
            this.cbostCompoeBaseSubstPis.Color = System.Drawing.Color.White;
            this.cbostCompoeBaseSubstPis.DataSource = null;
            this.cbostCompoeBaseSubstPis.DisplayMember = "DisplayMember";
            this.cbostCompoeBaseSubstPis.Location = new System.Drawing.Point(477, 58);
            this.cbostCompoeBaseSubstPis.Margin = new System.Windows.Forms.Padding(20, 3, 15, 3);
            this.cbostCompoeBaseSubstPis.Name = "cbostCompoeBaseSubstPis";
            this.cbostCompoeBaseSubstPis.SelectedIndex = -1;
            this.cbostCompoeBaseSubstPis.SelectedValue = 0;
            this.cbostCompoeBaseSubstPis.Size = new System.Drawing.Size(701, 21);
            this.cbostCompoeBaseSubstPis.TabIndex = 51;
            this.cbostCompoeBaseSubstPis.ValueMember = "ValueMember";
            // 
            // cbostCompoeBaseSubstCofins
            // 
            this.cbostCompoeBaseSubstCofins._Field = "stCompoeBaseSubstCofins";
            this.cbostCompoeBaseSubstCofins._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostCompoeBaseSubstCofins._Itens")));
            this.cbostCompoeBaseSubstCofins._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cbostCompoeBaseSubstCofins._LabelText = "Compõe a base de cofins por substituição tributária?";
            this.cbostCompoeBaseSubstCofins._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostCompoeBaseSubstCofins._Regex = null;
            this.cbostCompoeBaseSubstCofins._situacao = false;
            this.cbostCompoeBaseSubstCofins._Table = "Classificacao_fiscal";
            this.cbostCompoeBaseSubstCofins._TamanhoComponente = 438;
            this.cbostCompoeBaseSubstCofins._TamanhoMaiorLabel = 280;
            this.cbostCompoeBaseSubstCofins._Visible = false;
            this.cbostCompoeBaseSubstCofins.BackColor = System.Drawing.Color.Transparent;
            this.cbostCompoeBaseSubstCofins.Base = null;
            this.cbostCompoeBaseSubstCofins.Color = System.Drawing.Color.White;
            this.cbostCompoeBaseSubstCofins.DataSource = null;
            this.cbostCompoeBaseSubstCofins.DisplayMember = "DisplayMember";
            this.cbostCompoeBaseSubstCofins.Location = new System.Drawing.Point(461, 85);
            this.cbostCompoeBaseSubstCofins.Margin = new System.Windows.Forms.Padding(4, 3, 15, 3);
            this.cbostCompoeBaseSubstCofins.Name = "cbostCompoeBaseSubstCofins";
            this.cbostCompoeBaseSubstCofins.SelectedIndex = -1;
            this.cbostCompoeBaseSubstCofins.SelectedValue = 0;
            this.cbostCompoeBaseSubstCofins.Size = new System.Drawing.Size(717, 21);
            this.cbostCompoeBaseSubstCofins.TabIndex = 52;
            this.cbostCompoeBaseSubstCofins.ValueMember = "ValueMember";
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
            this.cboAtivo._Table = "Classificacao_fiscal";
            this.cboAtivo._TamanhoComponente = 80;
            this.cboAtivo._TamanhoMaiorLabel = 280;
            this.cboAtivo._Visible = false;
            this.cboAtivo.BackColor = System.Drawing.Color.Transparent;
            this.cboAtivo.Base = null;
            this.cboAtivo.Color = System.Drawing.Color.White;
            this.cboAtivo.DataSource = null;
            this.cboAtivo.DisplayMember = "DisplayMember";
            this.cboAtivo.Location = new System.Drawing.Point(654, 112);
            this.cboAtivo.Margin = new System.Windows.Forms.Padding(197, 3, 15, 3);
            this.cboAtivo.Name = "cboAtivo";
            this.cboAtivo.SelectedIndex = -1;
            this.cboAtivo.SelectedValue = 0;
            this.cboAtivo.Size = new System.Drawing.Size(166, 21);
            this.cboAtivo.TabIndex = 53;
            this.cboAtivo.ValueMember = "ValueMember";
            // 
            // kryptonTabControl1
            // 
            this.kryptonTabControl1.AllowCloseButton = false;
            this.kryptonTabControl1.AllowContextButton = false;
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
            this.kryptonTabControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.kryptonTabControl1.HotTrack = true;
            this.kryptonTabControl1.Location = new System.Drawing.Point(3, 3);
            this.kryptonTabControl1.Name = "kryptonTabControl1";
            this.kryptonTabControl1.PreserveTabColor = false;
            this.kryptonTabControl1.SelectedIndex = 0;
            this.kryptonTabControl1.Size = new System.Drawing.Size(810, 406);
            this.kryptonTabControl1.TabIndex = 4;
            this.kryptonTabControl1.UseExtendedLayout = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Controls.Add(this.kryptonPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(802, 377);
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
            this.kryptonPanel1.Size = new System.Drawing.Size(802, 377);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // FormClassificacaoFiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 463);
            this.Name = "FormClassificacaoFiscal";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = -10;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Text = "Classificações Fiscais";
            this.Load += new System.EventHandler(this.FormClassificacaoFiscal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).EndInit();
            this.panelPadrao.ResumeLayout(false);
            this.Principal.ResumeLayout(false);
            this.kryptonTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.kryptonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Principal;
        private Comum.Components.HLP_TextBox txtCodigo;
        private Comum.Components.HLP_TextBox txtxCassificacaoFiscal;
        private Comum.Components.HLP_TextBox txtcNCM;
        private Comum.Components.HLP_TextBox txtcClassifcacaoFiscal;
        private Comum.Components.HLP_TextBox txtxFundamentoLegal;
        private Comum.Components.HLP_NumericUpDown nudpIPI;
        private Comum.Components.HLP_NumericUpDown nudpII;
        private Comum.Components.HLP_ComboBox cbostCalculaPisCofins;
        private Comum.Components.HLP_ComboBox cbostRegimeTributacaoPisCofins;
        private Comum.Components.HLP_NumericUpDown nudvCoeficienteSubstituicaoPis;
        private Comum.Components.HLP_NumericUpDown nudvCoeficienteSubstituicaoCofins;
        private Comum.Components.HLP_NumericUpDown nudpPis;
        private Comum.Components.HLP_NumericUpDown nudpCofins;
        private Comum.Components.HLP_ComboBox cbostCompoeBaseNormalPisCofins;
        private Comum.Components.HLP_ComboBox cbostCompoeBaseSubstPis;
        private Comum.Components.HLP_ComboBox cbostCompoeBaseSubstCofins;
        private Comum.Components.HLP_ComboBox cboAtivo;
        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel1;
        private Comum.Components.HLP_LabelSeparator hlP_LabelSeparator1_Geral;
    }
}