namespace HLP.UI.Entries.Geral
{
    partial class FormCondicaoPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCondicaoPagamento));
            this.Principal = new System.Windows.Forms.FlowLayoutPanel();
            this.hlP_LabelSeparator1_Geral = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtCodigo = new HLP.Comum.Components.HLP_TextBox();
            this.txtxCondicaoPagamento = new HLP.Comum.Components.HLP_TextBox();
            this.txtxDescricao = new HLP.Comum.Components.HLP_TextBox();
            this.cbostMetodo = new HLP.Comum.Components.HLP_ComboBox();
            this.nudnMeses = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudnSemanas = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudnDias = new HLP.Comum.Components.HLP_NumericUpDown();
            this.hlP_PesquisaidPlanoPagamento = new HLP.Comum.Components.HLP_Pesquisa();
            this.hlP_PesquisaidDiaPagamento = new HLP.Comum.Components.HLP_Pesquisa();
            this.cbostDataVencimento = new HLP.Comum.Components.HLP_ComboBox();
            this.kryptonTabControl1 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kryptonPanel1 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.cbostCondicao = new HLP.Comum.Components.HLP_ComboBox();
            this.hlP_LabelSeparator1_Configuracao = new HLP.Comum.Components.HLP_LabelSeparator();
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
            this.panel1.Size = new System.Drawing.Size(912, 337);
            // 
            // panelPadrao
            // 
            this.panelPadrao.Controls.Add(this.kryptonTabControl1);
            this.panelPadrao.Size = new System.Drawing.Size(910, 313);
            // 
            // Principal
            // 
            this.Principal.AutoScroll = true;
            this.Principal.BackColor = System.Drawing.Color.Transparent;
            this.Principal.Controls.Add(this.hlP_LabelSeparator1_Geral);
            this.Principal.Controls.Add(this.txtCodigo);
            this.Principal.Controls.Add(this.txtxCondicaoPagamento);
            this.Principal.Controls.Add(this.txtxDescricao);
            this.Principal.Controls.Add(this.hlP_LabelSeparator1_Configuracao);
            this.Principal.Controls.Add(this.cbostCondicao);
            this.Principal.Controls.Add(this.cbostMetodo);
            this.Principal.Controls.Add(this.nudnMeses);
            this.Principal.Controls.Add(this.nudnSemanas);
            this.Principal.Controls.Add(this.nudnDias);
            this.Principal.Controls.Add(this.hlP_PesquisaidPlanoPagamento);
            this.Principal.Controls.Add(this.hlP_PesquisaidDiaPagamento);
            this.Principal.Controls.Add(this.cbostDataVencimento);
            this.Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Principal.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Principal.Location = new System.Drawing.Point(0, 0);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(896, 278);
            this.Principal.TabIndex = 2;
            this.Principal.Tag = "Principal";
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
            this.hlP_LabelSeparator1_Geral.TabIndex = 36;
            this.hlP_LabelSeparator1_Geral.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo._Field = "idCondicaoPagamento";
            this.txtCodigo._Help = "Chave principal do registro da condição de pagamento";
            this.txtCodigo._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtCodigo._LabelText = "Código";
            this.txtCodigo._Multiline = false;
            this.txtCodigo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtCodigo._Password = false;
            this.txtCodigo._Regex = null;
            this.txtCodigo._Table = "Condicao_pagamento";
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
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(152, 21);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtxCondicaoPagamento
            // 
            this.txtxCondicaoPagamento._Field = "xCondicaoPagamento";
            this.txtxCondicaoPagamento._Help = "Insira um código ou um nome abreviado para as condições de pagamento";
            this.txtxCondicaoPagamento._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtxCondicaoPagamento._LabelText = "Código da condição ";
            this.txtxCondicaoPagamento._Multiline = false;
            this.txtxCondicaoPagamento._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxCondicaoPagamento._Password = false;
            this.txtxCondicaoPagamento._Regex = null;
            this.txtxCondicaoPagamento._Table = "Condicao_pagamento";
            this.txtxCondicaoPagamento._TamanhoComponente = 150;
            this.txtxCondicaoPagamento._TamanhoMaiorLabel = 200;
            this.txtxCondicaoPagamento._Visible = true;
            this.txtxCondicaoPagamento.BackColor = System.Drawing.Color.Transparent;
            this.txtxCondicaoPagamento.Base = null;
            this.txtxCondicaoPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxCondicaoPagamento.Color = System.Drawing.Color.White;
            this.txtxCondicaoPagamento.Location = new System.Drawing.Point(89, 54);
            this.txtxCondicaoPagamento.Margin = new System.Windows.Forms.Padding(89, 3, 15, 3);
            this.txtxCondicaoPagamento.MaxLength = 32767;
            this.txtxCondicaoPagamento.Name = "txtxCondicaoPagamento";
            this.txtxCondicaoPagamento.ReadOnly = false;
            this.txtxCondicaoPagamento.Size = new System.Drawing.Size(264, 21);
            this.txtxCondicaoPagamento.TabIndex = 3;
            // 
            // txtxDescricao
            // 
            this.txtxDescricao._Field = "xDescricao";
            this.txtxDescricao._Help = "Insira um nome descritivo para os termos de pagamento";
            this.txtxDescricao._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtxDescricao._LabelText = "Descrição ";
            this.txtxDescricao._Multiline = false;
            this.txtxDescricao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxDescricao._Password = false;
            this.txtxDescricao._Regex = null;
            this.txtxDescricao._Table = "Condicao_pagamento";
            this.txtxDescricao._TamanhoComponente = 390;
            this.txtxDescricao._TamanhoMaiorLabel = 200;
            this.txtxDescricao._Visible = true;
            this.txtxDescricao.BackColor = System.Drawing.Color.Transparent;
            this.txtxDescricao.Base = null;
            this.txtxDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxDescricao.Color = System.Drawing.Color.White;
            this.txtxDescricao.Location = new System.Drawing.Point(144, 81);
            this.txtxDescricao.Margin = new System.Windows.Forms.Padding(144, 3, 15, 3);
            this.txtxDescricao.MaxLength = 10;
            this.txtxDescricao.Name = "txtxDescricao";
            this.txtxDescricao.ReadOnly = false;
            this.txtxDescricao.Size = new System.Drawing.Size(449, 21);
            this.txtxDescricao.TabIndex = 2;
            // 
            // cbostMetodo
            // 
            this.cbostMetodo._Field = "stMetodo";
            this.cbostMetodo._Help = "Selecione o método a ser usado para calcular a data de vencimento";
            this.cbostMetodo._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostMetodo._Itens")));
            this.cbostMetodo._LabelGroup = this.hlP_LabelSeparator1_Configuracao;
            this.cbostMetodo._LabelText = "Método de pagamento";
            this.cbostMetodo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostMetodo._Regex = null;
            this.cbostMetodo._situacao = false;
            this.cbostMetodo._Table = "Condicao_pagamento";
            this.cbostMetodo._TamanhoComponente = 150;
            this.cbostMetodo._TamanhoMaiorLabel = 200;
            this.cbostMetodo._Visible = true;
            this.cbostMetodo.BackColor = System.Drawing.Color.Transparent;
            this.cbostMetodo.Base = null;
            this.cbostMetodo.Color = System.Drawing.Color.White;
            this.cbostMetodo.DataSource = null;
            this.cbostMetodo.DisplayMember = "DisplayMember";
            this.cbostMetodo.Location = new System.Drawing.Point(77, 159);
            this.cbostMetodo.Margin = new System.Windows.Forms.Padding(77, 3, 15, 3);
            this.cbostMetodo.Name = "cbostMetodo";
            this.cbostMetodo.SelectedIndex = -1;
            this.cbostMetodo.SelectedValue = 0;
            this.cbostMetodo.Size = new System.Drawing.Size(276, 21);
            this.cbostMetodo.TabIndex = 4;
            this.cbostMetodo.ValueMember = "ValueMember";
            // 
            // nudnMeses
            // 
            this.nudnMeses._Field = "nMeses";
            this.nudnMeses._Help = "Insira o número de meses a ser adicionado ao método de pagamento para calcular a " +
    "data de vencimento";
            this.nudnMeses._LabelGroup = this.hlP_LabelSeparator1_Configuracao;
            this.nudnMeses._LabelText = "Meses";
            this.nudnMeses._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudnMeses._Regex = null;
            this.nudnMeses._Table = "Condicao_pagamento";
            this.nudnMeses._TamanhoComponente = 119;
            this.nudnMeses._TamanhoMaiorLabel = 200;
            this.nudnMeses._Visible = true;
            this.nudnMeses.BackColor = System.Drawing.Color.Transparent;
            this.nudnMeses.Base = null;
            this.nudnMeses.Color = System.Drawing.Color.White;
            this.nudnMeses.DecimalPlaces = 2;
            this.nudnMeses.Location = new System.Drawing.Point(164, 186);
            this.nudnMeses.Margin = new System.Windows.Forms.Padding(164, 3, 15, 3);
            this.nudnMeses.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudnMeses.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudnMeses.Name = "nudnMeses";
            this.nudnMeses.ReadOnly = false;
            this.nudnMeses.Size = new System.Drawing.Size(158, 22);
            this.nudnMeses.TabIndex = 5;
            this.nudnMeses.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudnMeses.ValueInt = 0;
            // 
            // nudnSemanas
            // 
            this.nudnSemanas._Field = "nSemanas";
            this.nudnSemanas._Help = "Insira o número de semanas a ser adicionado ao método de pagamento para calcular " +
    "a data de vencimento";
            this.nudnSemanas._LabelGroup = this.hlP_LabelSeparator1_Configuracao;
            this.nudnSemanas._LabelText = "Semanas";
            this.nudnSemanas._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudnSemanas._Regex = null;
            this.nudnSemanas._Table = "Condicao_pagamento";
            this.nudnSemanas._TamanhoComponente = 120;
            this.nudnSemanas._TamanhoMaiorLabel = 200;
            this.nudnSemanas._Visible = true;
            this.nudnSemanas.BackColor = System.Drawing.Color.Transparent;
            this.nudnSemanas.Base = null;
            this.nudnSemanas.Color = System.Drawing.Color.White;
            this.nudnSemanas.DecimalPlaces = 2;
            this.nudnSemanas.Location = new System.Drawing.Point(151, 214);
            this.nudnSemanas.Margin = new System.Windows.Forms.Padding(151, 3, 15, 3);
            this.nudnSemanas.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudnSemanas.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudnSemanas.Name = "nudnSemanas";
            this.nudnSemanas.ReadOnly = false;
            this.nudnSemanas.Size = new System.Drawing.Size(172, 22);
            this.nudnSemanas.TabIndex = 6;
            this.nudnSemanas.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudnSemanas.ValueInt = 0;
            // 
            // nudnDias
            // 
            this.nudnDias._Field = "nDias";
            this.nudnDias._Help = "Insira o número de dias a ser adicionado ao método de pagamento para calcular a d" +
    "ata de vencimento";
            this.nudnDias._LabelGroup = this.hlP_LabelSeparator1_Configuracao;
            this.nudnDias._LabelText = "Dias";
            this.nudnDias._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudnDias._Regex = null;
            this.nudnDias._Table = "Condicao_pagamento";
            this.nudnDias._TamanhoComponente = 118;
            this.nudnDias._TamanhoMaiorLabel = 160;
            this.nudnDias._Visible = true;
            this.nudnDias.BackColor = System.Drawing.Color.Transparent;
            this.nudnDias.Base = null;
            this.nudnDias.Color = System.Drawing.Color.White;
            this.nudnDias.DecimalPlaces = 2;
            this.nudnDias.Location = new System.Drawing.Point(742, 3);
            this.nudnDias.Margin = new System.Windows.Forms.Padding(134, 3, 15, 3);
            this.nudnDias.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudnDias.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudnDias.Name = "nudnDias";
            this.nudnDias.ReadOnly = false;
            this.nudnDias.Size = new System.Drawing.Size(147, 22);
            this.nudnDias.TabIndex = 7;
            this.nudnDias.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudnDias.ValueInt = 0;
            // 
            // hlP_PesquisaidPlanoPagamento
            // 
            this.hlP_PesquisaidPlanoPagamento._Field = "idPlanoPagamento";
            this.hlP_PesquisaidPlanoPagamento._Help = "Vincule condições de pagamento a um plano de pagamento que define como um valor f" +
    "aturado será dividido em prestações que devem ser pagas em intervalos específico" +
    "s";
            this.hlP_PesquisaidPlanoPagamento._LabelGroup = this.hlP_LabelSeparator1_Configuracao;
            this.hlP_PesquisaidPlanoPagamento._LabelText = "Plano de pagamento";
            this.hlP_PesquisaidPlanoPagamento._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidPlanoPagamento._ListaCamposDisplay")));
            this.hlP_PesquisaidPlanoPagamento._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidPlanoPagamento._ListaValoresDisplay")));
            this.hlP_PesquisaidPlanoPagamento._NomeCampoPK = "ID";
            this.hlP_PesquisaidPlanoPagamento._NomeFormCadastroOriginal = "FormPlanoPagamento";
            this.hlP_PesquisaidPlanoPagamento._NomeView = "vwPlanoPagamento";
            this.hlP_PesquisaidPlanoPagamento._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisaidPlanoPagamento._Regex = null;
            this.hlP_PesquisaidPlanoPagamento._Table = "Condicao_pagamento";
            this.hlP_PesquisaidPlanoPagamento._TamanhoComponente = 300;
            this.hlP_PesquisaidPlanoPagamento._TamanhoMaiorLabel = 160;
            this.hlP_PesquisaidPlanoPagamento._Vinculado = false;
            this.hlP_PesquisaidPlanoPagamento._Visible = true;
            this.hlP_PesquisaidPlanoPagamento.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidPlanoPagamento.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidPlanoPagamento.Base = null;
            this.hlP_PesquisaidPlanoPagamento.Location = new System.Drawing.Point(657, 31);
            this.hlP_PesquisaidPlanoPagamento.Margin = new System.Windows.Forms.Padding(49, 3, 15, 3);
            this.hlP_PesquisaidPlanoPagamento.Name = "hlP_PesquisaidPlanoPagamento";
            this.hlP_PesquisaidPlanoPagamento.ReadOnly = false;
            this.hlP_PesquisaidPlanoPagamento.Size = new System.Drawing.Size(504, 21);
            this.hlP_PesquisaidPlanoPagamento.TabIndex = 33;
            this.hlP_PesquisaidPlanoPagamento.Value = 0;
            // 
            // hlP_PesquisaidDiaPagamento
            // 
            this.hlP_PesquisaidDiaPagamento._Field = "idDiaPagamento";
            this.hlP_PesquisaidDiaPagamento._Help = "Selecione um dia de pagamento a ser usado para calcular a data de vencimento";
            this.hlP_PesquisaidDiaPagamento._LabelGroup = this.hlP_LabelSeparator1_Configuracao;
            this.hlP_PesquisaidDiaPagamento._LabelText = "Dia de pagamento";
            this.hlP_PesquisaidDiaPagamento._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidDiaPagamento._ListaCamposDisplay")));
            this.hlP_PesquisaidDiaPagamento._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidDiaPagamento._ListaValoresDisplay")));
            this.hlP_PesquisaidDiaPagamento._NomeCampoPK = "ID";
            this.hlP_PesquisaidDiaPagamento._NomeFormCadastroOriginal = "FormDiaPagamento";
            this.hlP_PesquisaidDiaPagamento._NomeView = "vwDiaPagamento";
            this.hlP_PesquisaidDiaPagamento._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisaidDiaPagamento._Regex = null;
            this.hlP_PesquisaidDiaPagamento._Table = "Condicao_pagamento";
            this.hlP_PesquisaidDiaPagamento._TamanhoComponente = 300;
            this.hlP_PesquisaidDiaPagamento._TamanhoMaiorLabel = 160;
            this.hlP_PesquisaidDiaPagamento._Vinculado = false;
            this.hlP_PesquisaidDiaPagamento._Visible = true;
            this.hlP_PesquisaidDiaPagamento.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidDiaPagamento.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidDiaPagamento.Base = null;
            this.hlP_PesquisaidDiaPagamento.Location = new System.Drawing.Point(669, 58);
            this.hlP_PesquisaidDiaPagamento.Margin = new System.Windows.Forms.Padding(61, 3, 15, 3);
            this.hlP_PesquisaidDiaPagamento.Name = "hlP_PesquisaidDiaPagamento";
            this.hlP_PesquisaidDiaPagamento.ReadOnly = false;
            this.hlP_PesquisaidDiaPagamento.Size = new System.Drawing.Size(492, 21);
            this.hlP_PesquisaidDiaPagamento.TabIndex = 34;
            this.hlP_PesquisaidDiaPagamento.Value = 0;
            // 
            // cbostDataVencimento
            // 
            this.cbostDataVencimento._Field = "stDataVencimento";
            this.cbostDataVencimento._Help = "Selecione se a data de vencimento irá prorrogar ou adiar sábados, domingos ou fer" +
    "iados";
            this.cbostDataVencimento._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostDataVencimento._Itens")));
            this.cbostDataVencimento._LabelGroup = this.hlP_LabelSeparator1_Configuracao;
            this.cbostDataVencimento._LabelText = "Data de vencimento";
            this.cbostDataVencimento._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostDataVencimento._Regex = null;
            this.cbostDataVencimento._situacao = false;
            this.cbostDataVencimento._Table = "Condicao_pagamento";
            this.cbostDataVencimento._TamanhoComponente = 157;
            this.cbostDataVencimento._TamanhoMaiorLabel = 160;
            this.cbostDataVencimento._Visible = true;
            this.cbostDataVencimento.BackColor = System.Drawing.Color.Transparent;
            this.cbostDataVencimento.Base = null;
            this.cbostDataVencimento.Color = System.Drawing.Color.White;
            this.cbostDataVencimento.DataSource = null;
            this.cbostDataVencimento.DisplayMember = "DisplayMember";
            this.cbostDataVencimento.Location = new System.Drawing.Point(662, 85);
            this.cbostDataVencimento.Margin = new System.Windows.Forms.Padding(54, 3, 15, 3);
            this.cbostDataVencimento.Name = "cbostDataVencimento";
            this.cbostDataVencimento.SelectedIndex = -1;
            this.cbostDataVencimento.SelectedValue = 0;
            this.cbostDataVencimento.Size = new System.Drawing.Size(266, 21);
            this.cbostDataVencimento.TabIndex = 35;
            this.cbostDataVencimento.ValueMember = "ValueMember";
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
            this.kryptonTabControl1.Size = new System.Drawing.Size(904, 307);
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
            this.tabPage1.Size = new System.Drawing.Size(896, 278);
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
            this.kryptonPanel1.Size = new System.Drawing.Size(896, 278);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // cbostCondicao
            // 
            this.cbostCondicao._Field = "stCondicao";
            this.cbostCondicao._Help = "Informar qual é o tipo da condição sendo elas avista ou aprazo";
            this.cbostCondicao._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostCondicao._Itens")));
            this.cbostCondicao._LabelGroup = this.hlP_LabelSeparator1_Configuracao;
            this.cbostCondicao._LabelText = "Condição";
            this.cbostCondicao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostCondicao._Regex = null;
            this.cbostCondicao._situacao = false;
            this.cbostCondicao._Table = "Condicao_pagamento";
            this.cbostCondicao._TamanhoComponente = 125;
            this.cbostCondicao._TamanhoMaiorLabel = 200;
            this.cbostCondicao._Visible = true;
            this.cbostCondicao.BackColor = System.Drawing.Color.Transparent;
            this.cbostCondicao.Base = null;
            this.cbostCondicao.Color = System.Drawing.Color.White;
            this.cbostCondicao.DataSource = null;
            this.cbostCondicao.DisplayMember = "DisplayMember";
            this.cbostCondicao.Location = new System.Drawing.Point(147, 132);
            this.cbostCondicao.Margin = new System.Windows.Forms.Padding(147, 3, 15, 3);
            this.cbostCondicao.Name = "cbostCondicao";
            this.cbostCondicao.SelectedIndex = -1;
            this.cbostCondicao.SelectedValue = 0;
            this.cbostCondicao.Size = new System.Drawing.Size(181, 21);
            this.cbostCondicao.TabIndex = 37;
            this.cbostCondicao.ValueMember = "ValueMember";
            // 
            // hlP_LabelSeparator1_Configuracao
            // 
            this.hlP_LabelSeparator1_Configuracao._LabelText = "Configuração";
            this.hlP_LabelSeparator1_Configuracao._TamanhoMaiorLabel = 0;
            this.hlP_LabelSeparator1_Configuracao.BackColor = System.Drawing.Color.Transparent;
            this.hlP_LabelSeparator1_Configuracao.Location = new System.Drawing.Point(3, 108);
            this.hlP_LabelSeparator1_Configuracao.Name = "hlP_LabelSeparator1_Configuracao";
            this.hlP_LabelSeparator1_Configuracao.Size = new System.Drawing.Size(300, 18);
            this.hlP_LabelSeparator1_Configuracao.TabIndex = 38;
            this.hlP_LabelSeparator1_Configuracao.TabStop = false;
            // 
            // FormCondicaoPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 364);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCondicaoPagamento";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = -10;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Text = "Condições de Pagamento";
            this.Load += new System.EventHandler(this.FormCondicaoPagamento_Load);
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
        private Comum.Components.HLP_TextBox txtxCondicaoPagamento;
        private Comum.Components.HLP_TextBox txtxDescricao;
        private Comum.Components.HLP_ComboBox cbostMetodo;
        private Comum.Components.HLP_NumericUpDown nudnMeses;
        private Comum.Components.HLP_NumericUpDown nudnSemanas;
        private Comum.Components.HLP_NumericUpDown nudnDias;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidPlanoPagamento;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidDiaPagamento;
        private Comum.Components.HLP_ComboBox cbostDataVencimento;
        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel1;
        private Comum.Components.HLP_LabelSeparator hlP_LabelSeparator1_Geral;
        private Comum.Components.HLP_ComboBox cbostCondicao;
        private Comum.Components.HLP_LabelSeparator hlP_LabelSeparator1_Configuracao;
    }
}