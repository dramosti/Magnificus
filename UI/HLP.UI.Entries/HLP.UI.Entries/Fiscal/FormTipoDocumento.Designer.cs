namespace HLP.UI.Entries.Fiscal
{
    partial class FormTipoDocumento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTipoDocumento));
            this.Principal = new System.Windows.Forms.FlowLayoutPanel();
            this.hlP_LabelSeparator1_Geral = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtCodigo = new HLP.Comum.Components.HLP_TextBox();
            this.txtxTpdoc = new HLP.Comum.Components.HLP_TextBox();
            this.cbotpDocumento = new HLP.Comum.Components.HLP_ComboBox();
            this.lsOperacoesValidas = new HLP.Comum.Components.HLP_ListBox();
            this.cbostRelacaoPedidoxorcamento = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostRelacaoPedidoxnf = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostRelacaoPedidoxproducao = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostGrupoFaturamento = new HLP.Comum.Components.HLP_ComboBox();
            this.txtxSerieNf = new HLP.Comum.Components.HLP_TextBox();
            this.txtxEspecieVolNf = new HLP.Comum.Components.HLP_TextBox();
            this.txtxMarcaVolNf = new HLP.Comum.Components.HLP_TextBox();
            this.cbostSomaIpi1Dup = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostSomaSt1Dup = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostNfComplementar = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostNfImportacao = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostNfExportacao = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostNfIndustrializacao = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostNfSuframa = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostNfAtivo = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostNFdevolucao = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostCompoeVlTotalProdutos = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostSomaDevolucaoVlTotalNf = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostImprimeIcmsProprioComNormal = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostRelacaoRecebimentoPedidocpa = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostRelacaoPedidocpaCotacao = new HLP.Comum.Components.HLP_ComboBox();
            this.campoPesquisaidModeloDocFiscal = new HLP.Comum.Components.HLP_Pesquisa();
            this.campoxObs = new HLP.Comum.Components.HLP_Observacao();
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
            this.panel1.Size = new System.Drawing.Size(1370, 453);
            // 
            // panelPadrao
            // 
            this.panelPadrao.Controls.Add(this.kryptonTabControl1);
            this.panelPadrao.Size = new System.Drawing.Size(1368, 429);
            // 
            // Principal
            // 
            this.Principal.AutoScroll = true;
            this.Principal.BackColor = System.Drawing.Color.Transparent;
            this.Principal.Controls.Add(this.hlP_LabelSeparator1_Geral);
            this.Principal.Controls.Add(this.txtCodigo);
            this.Principal.Controls.Add(this.txtxTpdoc);
            this.Principal.Controls.Add(this.cbotpDocumento);
            this.Principal.Controls.Add(this.lsOperacoesValidas);
            this.Principal.Controls.Add(this.cbostRelacaoPedidoxorcamento);
            this.Principal.Controls.Add(this.cbostRelacaoPedidoxnf);
            this.Principal.Controls.Add(this.cbostRelacaoPedidoxproducao);
            this.Principal.Controls.Add(this.cbostGrupoFaturamento);
            this.Principal.Controls.Add(this.txtxSerieNf);
            this.Principal.Controls.Add(this.txtxEspecieVolNf);
            this.Principal.Controls.Add(this.txtxMarcaVolNf);
            this.Principal.Controls.Add(this.cbostSomaIpi1Dup);
            this.Principal.Controls.Add(this.cbostSomaSt1Dup);
            this.Principal.Controls.Add(this.cbostNfComplementar);
            this.Principal.Controls.Add(this.cbostNfImportacao);
            this.Principal.Controls.Add(this.cbostNfExportacao);
            this.Principal.Controls.Add(this.cbostNfIndustrializacao);
            this.Principal.Controls.Add(this.cbostNfSuframa);
            this.Principal.Controls.Add(this.cbostNfAtivo);
            this.Principal.Controls.Add(this.cbostNFdevolucao);
            this.Principal.Controls.Add(this.cbostCompoeVlTotalProdutos);
            this.Principal.Controls.Add(this.cbostSomaDevolucaoVlTotalNf);
            this.Principal.Controls.Add(this.cbostImprimeIcmsProprioComNormal);
            this.Principal.Controls.Add(this.cbostRelacaoRecebimentoPedidocpa);
            this.Principal.Controls.Add(this.cbostRelacaoPedidocpaCotacao);
            this.Principal.Controls.Add(this.campoPesquisaidModeloDocFiscal);
            this.Principal.Controls.Add(this.campoxObs);
            this.Principal.Controls.Add(this.cboAtivo);
            this.Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Principal.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Principal.Location = new System.Drawing.Point(0, 0);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(1354, 394);
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
            this.hlP_LabelSeparator1_Geral.TabIndex = 29;
            this.hlP_LabelSeparator1_Geral.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo._Field = "idTipoDocumento";
            this.txtCodigo._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtCodigo._LabelText = "Código";
            this.txtCodigo._Multiline = false;
            this.txtCodigo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtCodigo._Password = false;
            this.txtCodigo._Regex = null;
            this.txtCodigo._Table = "Tipo_documento";
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
            // txtxTpdoc
            // 
            this.txtxTpdoc._Field = "xTpdoc";
            this.txtxTpdoc._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtxTpdoc._LabelText = "Nome";
            this.txtxTpdoc._Multiline = false;
            this.txtxTpdoc._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxTpdoc._Password = false;
            this.txtxTpdoc._Regex = null;
            this.txtxTpdoc._Table = "Tipo_documento";
            this.txtxTpdoc._TamanhoComponente = 312;
            this.txtxTpdoc._TamanhoMaiorLabel = 200;
            this.txtxTpdoc._Visible = true;
            this.txtxTpdoc.BackColor = System.Drawing.Color.Transparent;
            this.txtxTpdoc.Base = null;
            this.txtxTpdoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxTpdoc.Color = System.Drawing.Color.White;
            this.txtxTpdoc.Location = new System.Drawing.Point(166, 54);
            this.txtxTpdoc.Margin = new System.Windows.Forms.Padding(166, 3, 15, 3);
            this.txtxTpdoc.MaxLength = 32767;
            this.txtxTpdoc.Name = "txtxTpdoc";
            this.txtxTpdoc.ReadOnly = false;
            this.txtxTpdoc.Size = new System.Drawing.Size(349, 21);
            this.txtxTpdoc.TabIndex = 1;
            // 
            // cbotpDocumento
            // 
            this.cbotpDocumento._Field = "tpDocumento";
            this.cbotpDocumento._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbotpDocumento._Itens")));
            this.cbotpDocumento._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cbotpDocumento._LabelText = "Tipo de documento";
            this.cbotpDocumento._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbotpDocumento._Regex = null;
            this.cbotpDocumento._situacao = false;
            this.cbotpDocumento._Table = "Tipo_documento";
            this.cbotpDocumento._TamanhoComponente = 197;
            this.cbotpDocumento._TamanhoMaiorLabel = 200;
            this.cbotpDocumento._Visible = true;
            this.cbotpDocumento.BackColor = System.Drawing.Color.Transparent;
            this.cbotpDocumento.Base = null;
            this.cbotpDocumento.Color = System.Drawing.Color.White;
            this.cbotpDocumento.DataSource = null;
            this.cbotpDocumento.DisplayMember = "DisplayMember";
            this.cbotpDocumento.Location = new System.Drawing.Point(96, 81);
            this.cbotpDocumento.Margin = new System.Windows.Forms.Padding(96, 3, 15, 3);
            this.cbotpDocumento.Name = "cbotpDocumento";
            this.cbotpDocumento.SelectedIndex = -1;
            this.cbotpDocumento.SelectedValue = 0;
            this.cbotpDocumento.Size = new System.Drawing.Size(304, 21);
            this.cbotpDocumento.TabIndex = 2;
            this.cbotpDocumento.ValueMember = "ValueMember";
            // 
            // lsOperacoesValidas
            // 
            this.lsOperacoesValidas._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("lsOperacoesValidas._Itens")));
            this.lsOperacoesValidas._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.lsOperacoesValidas._LabelText = "Operações válidas";
            this.lsOperacoesValidas._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.lsOperacoesValidas._Regex = null;
            this.lsOperacoesValidas._TamanhoComponente = 291;
            this.lsOperacoesValidas._TamanhoMaiorLabel = 200;
            this.lsOperacoesValidas._Visible = true;
            this.lsOperacoesValidas.BackColor = System.Drawing.Color.Transparent;
            this.lsOperacoesValidas.Base = null;
            this.lsOperacoesValidas.Color = System.Drawing.Color.White;
            this.lsOperacoesValidas.DataSource = null;
            this.lsOperacoesValidas.DisplayMember = "DisplayMember";
            this.lsOperacoesValidas.Location = new System.Drawing.Point(103, 108);
            this.lsOperacoesValidas.Margin = new System.Windows.Forms.Padding(103, 3, 15, 3);
            this.lsOperacoesValidas.Name = "lsOperacoesValidas";
            this.lsOperacoesValidas.Size = new System.Drawing.Size(416, 102);
            this.lsOperacoesValidas.TabIndex = 9;
            this.lsOperacoesValidas.ValueMember = "ValueMember";
            // 
            // cbostRelacaoPedidoxorcamento
            // 
            this.cbostRelacaoPedidoxorcamento._Field = "stRelacaoPedidoxorcamento";
            this.cbostRelacaoPedidoxorcamento._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostRelacaoPedidoxorcamento._Itens")));
            this.cbostRelacaoPedidoxorcamento._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cbostRelacaoPedidoxorcamento._LabelText = "Relação do pedido com orçamento";
            this.cbostRelacaoPedidoxorcamento._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostRelacaoPedidoxorcamento._Regex = null;
            this.cbostRelacaoPedidoxorcamento._situacao = false;
            this.cbostRelacaoPedidoxorcamento._Table = "Tipo_documento";
            this.cbostRelacaoPedidoxorcamento._TamanhoComponente = 240;
            this.cbostRelacaoPedidoxorcamento._TamanhoMaiorLabel = 200;
            this.cbostRelacaoPedidoxorcamento._Visible = true;
            this.cbostRelacaoPedidoxorcamento.BackColor = System.Drawing.Color.Transparent;
            this.cbostRelacaoPedidoxorcamento.Base = null;
            this.cbostRelacaoPedidoxorcamento.Color = System.Drawing.Color.White;
            this.cbostRelacaoPedidoxorcamento.DataSource = null;
            this.cbostRelacaoPedidoxorcamento.DisplayMember = "DisplayMember";
            this.cbostRelacaoPedidoxorcamento.Location = new System.Drawing.Point(17, 216);
            this.cbostRelacaoPedidoxorcamento.Margin = new System.Windows.Forms.Padding(17, 3, 15, 3);
            this.cbostRelacaoPedidoxorcamento.Name = "cbostRelacaoPedidoxorcamento";
            this.cbostRelacaoPedidoxorcamento.SelectedIndex = -1;
            this.cbostRelacaoPedidoxorcamento.SelectedValue = 0;
            this.cbostRelacaoPedidoxorcamento.Size = new System.Drawing.Size(426, 21);
            this.cbostRelacaoPedidoxorcamento.TabIndex = 3;
            this.cbostRelacaoPedidoxorcamento.ValueMember = "ValueMember";
            // 
            // cbostRelacaoPedidoxnf
            // 
            this.cbostRelacaoPedidoxnf._Field = "stRelacaoPedidoxnf";
            this.cbostRelacaoPedidoxnf._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostRelacaoPedidoxnf._Itens")));
            this.cbostRelacaoPedidoxnf._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cbostRelacaoPedidoxnf._LabelText = "Relação do pedido com faturamento";
            this.cbostRelacaoPedidoxnf._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostRelacaoPedidoxnf._Regex = null;
            this.cbostRelacaoPedidoxnf._situacao = false;
            this.cbostRelacaoPedidoxnf._Table = "Tipo_documento";
            this.cbostRelacaoPedidoxnf._TamanhoComponente = 312;
            this.cbostRelacaoPedidoxnf._TamanhoMaiorLabel = 200;
            this.cbostRelacaoPedidoxnf._Visible = true;
            this.cbostRelacaoPedidoxnf.BackColor = System.Drawing.Color.Transparent;
            this.cbostRelacaoPedidoxnf.Base = null;
            this.cbostRelacaoPedidoxnf.Color = System.Drawing.Color.White;
            this.cbostRelacaoPedidoxnf.DataSource = null;
            this.cbostRelacaoPedidoxnf.DisplayMember = "DisplayMember";
            this.cbostRelacaoPedidoxnf.Location = new System.Drawing.Point(8, 243);
            this.cbostRelacaoPedidoxnf.Margin = new System.Windows.Forms.Padding(8, 3, 15, 3);
            this.cbostRelacaoPedidoxnf.Name = "cbostRelacaoPedidoxnf";
            this.cbostRelacaoPedidoxnf.SelectedIndex = -1;
            this.cbostRelacaoPedidoxnf.SelectedValue = 0;
            this.cbostRelacaoPedidoxnf.Size = new System.Drawing.Size(507, 21);
            this.cbostRelacaoPedidoxnf.TabIndex = 3;
            this.cbostRelacaoPedidoxnf.ValueMember = "ValueMember";
            // 
            // cbostRelacaoPedidoxproducao
            // 
            this.cbostRelacaoPedidoxproducao._Field = "stRelacaoPedidoxproducao";
            this.cbostRelacaoPedidoxproducao._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostRelacaoPedidoxproducao._Itens")));
            this.cbostRelacaoPedidoxproducao._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cbostRelacaoPedidoxproducao._LabelText = "Relação do pedido com produção";
            this.cbostRelacaoPedidoxproducao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostRelacaoPedidoxproducao._Regex = null;
            this.cbostRelacaoPedidoxproducao._situacao = false;
            this.cbostRelacaoPedidoxproducao._Table = "Tipo_documento";
            this.cbostRelacaoPedidoxproducao._TamanhoComponente = 254;
            this.cbostRelacaoPedidoxproducao._TamanhoMaiorLabel = 200;
            this.cbostRelacaoPedidoxproducao._Visible = true;
            this.cbostRelacaoPedidoxproducao.BackColor = System.Drawing.Color.Transparent;
            this.cbostRelacaoPedidoxproducao.Base = null;
            this.cbostRelacaoPedidoxproducao.Color = System.Drawing.Color.White;
            this.cbostRelacaoPedidoxproducao.DataSource = null;
            this.cbostRelacaoPedidoxproducao.DisplayMember = "DisplayMember";
            this.cbostRelacaoPedidoxproducao.Location = new System.Drawing.Point(22, 270);
            this.cbostRelacaoPedidoxproducao.Margin = new System.Windows.Forms.Padding(22, 3, 15, 3);
            this.cbostRelacaoPedidoxproducao.Name = "cbostRelacaoPedidoxproducao";
            this.cbostRelacaoPedidoxproducao.SelectedIndex = -1;
            this.cbostRelacaoPedidoxproducao.SelectedValue = 0;
            this.cbostRelacaoPedidoxproducao.Size = new System.Drawing.Size(435, 21);
            this.cbostRelacaoPedidoxproducao.TabIndex = 3;
            this.cbostRelacaoPedidoxproducao.ValueMember = "ValueMember";
            // 
            // cbostGrupoFaturamento
            // 
            this.cbostGrupoFaturamento._Field = "stGrupoFaturamento";
            this.cbostGrupoFaturamento._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostGrupoFaturamento._Itens")));
            this.cbostGrupoFaturamento._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cbostGrupoFaturamento._LabelText = "Grupo de faturamento";
            this.cbostGrupoFaturamento._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostGrupoFaturamento._Regex = null;
            this.cbostGrupoFaturamento._situacao = false;
            this.cbostGrupoFaturamento._Table = "Tipo_documento";
            this.cbostGrupoFaturamento._TamanhoComponente = 39;
            this.cbostGrupoFaturamento._TamanhoMaiorLabel = 200;
            this.cbostGrupoFaturamento._Visible = true;
            this.cbostGrupoFaturamento.BackColor = System.Drawing.Color.Transparent;
            this.cbostGrupoFaturamento.Base = null;
            this.cbostGrupoFaturamento.Color = System.Drawing.Color.White;
            this.cbostGrupoFaturamento.DataSource = null;
            this.cbostGrupoFaturamento.DisplayMember = "DisplayMember";
            this.cbostGrupoFaturamento.Location = new System.Drawing.Point(80, 297);
            this.cbostGrupoFaturamento.Margin = new System.Windows.Forms.Padding(80, 3, 15, 3);
            this.cbostGrupoFaturamento.Name = "cbostGrupoFaturamento";
            this.cbostGrupoFaturamento.SelectedIndex = -1;
            this.cbostGrupoFaturamento.SelectedValue = 0;
            this.cbostGrupoFaturamento.Size = new System.Drawing.Size(162, 21);
            this.cbostGrupoFaturamento.TabIndex = 3;
            this.cbostGrupoFaturamento.ValueMember = "ValueMember";
            // 
            // txtxSerieNf
            // 
            this.txtxSerieNf._Field = "xSerieNf";
            this.txtxSerieNf._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtxSerieNf._LabelText = "Série da nf";
            this.txtxSerieNf._Multiline = false;
            this.txtxSerieNf._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxSerieNf._Password = false;
            this.txtxSerieNf._Regex = null;
            this.txtxSerieNf._Table = "Tipo_documento";
            this.txtxSerieNf._TamanhoComponente = 137;
            this.txtxSerieNf._TamanhoMaiorLabel = 200;
            this.txtxSerieNf._Visible = true;
            this.txtxSerieNf.BackColor = System.Drawing.Color.Transparent;
            this.txtxSerieNf.Base = null;
            this.txtxSerieNf.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxSerieNf.Color = System.Drawing.Color.White;
            this.txtxSerieNf.Location = new System.Drawing.Point(141, 324);
            this.txtxSerieNf.Margin = new System.Windows.Forms.Padding(141, 3, 15, 3);
            this.txtxSerieNf.MaxLength = 32767;
            this.txtxSerieNf.Name = "txtxSerieNf";
            this.txtxSerieNf.ReadOnly = false;
            this.txtxSerieNf.Size = new System.Drawing.Size(199, 21);
            this.txtxSerieNf.TabIndex = 4;
            // 
            // txtxEspecieVolNf
            // 
            this.txtxEspecieVolNf._Field = "xEspecieVolNf";
            this.txtxEspecieVolNf._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtxEspecieVolNf._LabelText = "Espécie de volume da nf";
            this.txtxEspecieVolNf._Multiline = false;
            this.txtxEspecieVolNf._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxEspecieVolNf._Password = false;
            this.txtxEspecieVolNf._Regex = null;
            this.txtxEspecieVolNf._Table = "Tipo_documento";
            this.txtxEspecieVolNf._TamanhoComponente = 146;
            this.txtxEspecieVolNf._TamanhoMaiorLabel = 200;
            this.txtxEspecieVolNf._Visible = true;
            this.txtxEspecieVolNf.BackColor = System.Drawing.Color.Transparent;
            this.txtxEspecieVolNf.Base = null;
            this.txtxEspecieVolNf.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxEspecieVolNf.Color = System.Drawing.Color.White;
            this.txtxEspecieVolNf.Location = new System.Drawing.Point(72, 351);
            this.txtxEspecieVolNf.Margin = new System.Windows.Forms.Padding(72, 3, 15, 3);
            this.txtxEspecieVolNf.MaxLength = 32767;
            this.txtxEspecieVolNf.Name = "txtxEspecieVolNf";
            this.txtxEspecieVolNf.ReadOnly = false;
            this.txtxEspecieVolNf.Size = new System.Drawing.Size(277, 21);
            this.txtxEspecieVolNf.TabIndex = 4;
            // 
            // txtxMarcaVolNf
            // 
            this.txtxMarcaVolNf._Field = "xMarcaVolNf";
            this.txtxMarcaVolNf._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtxMarcaVolNf._LabelText = "Marca do volume da nf";
            this.txtxMarcaVolNf._Multiline = false;
            this.txtxMarcaVolNf._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxMarcaVolNf._Password = false;
            this.txtxMarcaVolNf._Regex = null;
            this.txtxMarcaVolNf._Table = "Tipo_documento";
            this.txtxMarcaVolNf._TamanhoComponente = 146;
            this.txtxMarcaVolNf._TamanhoMaiorLabel = 300;
            this.txtxMarcaVolNf._Visible = true;
            this.txtxMarcaVolNf.BackColor = System.Drawing.Color.Transparent;
            this.txtxMarcaVolNf.Base = null;
            this.txtxMarcaVolNf.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxMarcaVolNf.Color = System.Drawing.Color.White;
            this.txtxMarcaVolNf.Location = new System.Drawing.Point(712, 3);
            this.txtxMarcaVolNf.Margin = new System.Windows.Forms.Padding(178, 3, 15, 3);
            this.txtxMarcaVolNf.MaxLength = 32767;
            this.txtxMarcaVolNf.Name = "txtxMarcaVolNf";
            this.txtxMarcaVolNf.ReadOnly = false;
            this.txtxMarcaVolNf.Size = new System.Drawing.Size(271, 21);
            this.txtxMarcaVolNf.TabIndex = 4;
            // 
            // cbostSomaIpi1Dup
            // 
            this.cbostSomaIpi1Dup._Field = "stSomaIpi1Dup";
            this.cbostSomaIpi1Dup._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostSomaIpi1Dup._Itens")));
            this.cbostSomaIpi1Dup._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cbostSomaIpi1Dup._LabelText = "Soma valor do ipi somente na 1ª duplicata?";
            this.cbostSomaIpi1Dup._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostSomaIpi1Dup._Regex = null;
            this.cbostSomaIpi1Dup._situacao = true;
            this.cbostSomaIpi1Dup._Table = "Tipo_documento";
            this.cbostSomaIpi1Dup._TamanhoComponente = 79;
            this.cbostSomaIpi1Dup._TamanhoMaiorLabel = 300;
            this.cbostSomaIpi1Dup._Visible = true;
            this.cbostSomaIpi1Dup.BackColor = System.Drawing.Color.Transparent;
            this.cbostSomaIpi1Dup.Base = null;
            this.cbostSomaIpi1Dup.Color = System.Drawing.Color.White;
            this.cbostSomaIpi1Dup.DataSource = null;
            this.cbostSomaIpi1Dup.DisplayMember = "DisplayMember";
            this.cbostSomaIpi1Dup.Location = new System.Drawing.Point(609, 30);
            this.cbostSomaIpi1Dup.Margin = new System.Windows.Forms.Padding(75, 3, 15, 3);
            this.cbostSomaIpi1Dup.Name = "cbostSomaIpi1Dup";
            this.cbostSomaIpi1Dup.SelectedIndex = -1;
            this.cbostSomaIpi1Dup.SelectedValue = 0;
            this.cbostSomaIpi1Dup.Size = new System.Drawing.Size(307, 21);
            this.cbostSomaIpi1Dup.TabIndex = 5;
            this.cbostSomaIpi1Dup.ValueMember = "ValueMember";
            // 
            // cbostSomaSt1Dup
            // 
            this.cbostSomaSt1Dup._Field = "stSomaSt1Dup";
            this.cbostSomaSt1Dup._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostSomaSt1Dup._Itens")));
            this.cbostSomaSt1Dup._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cbostSomaSt1Dup._LabelText = "Soma valor da subs. tributária somente na 1ª duplicata?";
            this.cbostSomaSt1Dup._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostSomaSt1Dup._Regex = null;
            this.cbostSomaSt1Dup._situacao = true;
            this.cbostSomaSt1Dup._Table = "Tipo_documento";
            this.cbostSomaSt1Dup._TamanhoComponente = 80;
            this.cbostSomaSt1Dup._TamanhoMaiorLabel = 300;
            this.cbostSomaSt1Dup._Visible = true;
            this.cbostSomaSt1Dup.BackColor = System.Drawing.Color.Transparent;
            this.cbostSomaSt1Dup.Base = null;
            this.cbostSomaSt1Dup.Color = System.Drawing.Color.White;
            this.cbostSomaSt1Dup.DataSource = null;
            this.cbostSomaSt1Dup.DisplayMember = "DisplayMember";
            this.cbostSomaSt1Dup.Location = new System.Drawing.Point(545, 57);
            this.cbostSomaSt1Dup.Margin = new System.Windows.Forms.Padding(11, 3, 15, 3);
            this.cbostSomaSt1Dup.Name = "cbostSomaSt1Dup";
            this.cbostSomaSt1Dup.SelectedIndex = -1;
            this.cbostSomaSt1Dup.SelectedValue = 0;
            this.cbostSomaSt1Dup.Size = new System.Drawing.Size(372, 21);
            this.cbostSomaSt1Dup.TabIndex = 5;
            this.cbostSomaSt1Dup.ValueMember = "ValueMember";
            // 
            // cbostNfComplementar
            // 
            this.cbostNfComplementar._Field = "stNfComplementar";
            this.cbostNfComplementar._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostNfComplementar._Itens")));
            this.cbostNfComplementar._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cbostNfComplementar._LabelText = "É nf complementar?";
            this.cbostNfComplementar._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostNfComplementar._Regex = null;
            this.cbostNfComplementar._situacao = true;
            this.cbostNfComplementar._Table = "Tipo_documento";
            this.cbostNfComplementar._TamanhoComponente = 83;
            this.cbostNfComplementar._TamanhoMaiorLabel = 300;
            this.cbostNfComplementar._Visible = true;
            this.cbostNfComplementar.BackColor = System.Drawing.Color.Transparent;
            this.cbostNfComplementar.Base = null;
            this.cbostNfComplementar.Color = System.Drawing.Color.White;
            this.cbostNfComplementar.DataSource = null;
            this.cbostNfComplementar.DisplayMember = "DisplayMember";
            this.cbostNfComplementar.Location = new System.Drawing.Point(729, 84);
            this.cbostNfComplementar.Margin = new System.Windows.Forms.Padding(195, 3, 15, 3);
            this.cbostNfComplementar.Name = "cbostNfComplementar";
            this.cbostNfComplementar.SelectedIndex = -1;
            this.cbostNfComplementar.SelectedValue = 0;
            this.cbostNfComplementar.Size = new System.Drawing.Size(191, 21);
            this.cbostNfComplementar.TabIndex = 5;
            this.cbostNfComplementar.ValueMember = "ValueMember";
            // 
            // cbostNfImportacao
            // 
            this.cbostNfImportacao._Field = "stNfImportacao";
            this.cbostNfImportacao._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostNfImportacao._Itens")));
            this.cbostNfImportacao._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cbostNfImportacao._LabelText = "É nf de importação?";
            this.cbostNfImportacao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostNfImportacao._Regex = null;
            this.cbostNfImportacao._situacao = true;
            this.cbostNfImportacao._Table = "Tipo_documento";
            this.cbostNfImportacao._TamanhoComponente = 83;
            this.cbostNfImportacao._TamanhoMaiorLabel = 300;
            this.cbostNfImportacao._Visible = true;
            this.cbostNfImportacao.BackColor = System.Drawing.Color.Transparent;
            this.cbostNfImportacao.Base = null;
            this.cbostNfImportacao.Color = System.Drawing.Color.White;
            this.cbostNfImportacao.DataSource = null;
            this.cbostNfImportacao.DisplayMember = "DisplayMember";
            this.cbostNfImportacao.Location = new System.Drawing.Point(728, 111);
            this.cbostNfImportacao.Margin = new System.Windows.Forms.Padding(194, 3, 15, 3);
            this.cbostNfImportacao.Name = "cbostNfImportacao";
            this.cbostNfImportacao.SelectedIndex = -1;
            this.cbostNfImportacao.SelectedValue = 0;
            this.cbostNfImportacao.Size = new System.Drawing.Size(192, 21);
            this.cbostNfImportacao.TabIndex = 5;
            this.cbostNfImportacao.ValueMember = "ValueMember";
            // 
            // cbostNfExportacao
            // 
            this.cbostNfExportacao._Field = "stNfExportacao";
            this.cbostNfExportacao._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostNfExportacao._Itens")));
            this.cbostNfExportacao._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cbostNfExportacao._LabelText = "É nf de exportação?";
            this.cbostNfExportacao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostNfExportacao._Regex = null;
            this.cbostNfExportacao._situacao = false;
            this.cbostNfExportacao._Table = "Tipo_documento";
            this.cbostNfExportacao._TamanhoComponente = 181;
            this.cbostNfExportacao._TamanhoMaiorLabel = 300;
            this.cbostNfExportacao._Visible = true;
            this.cbostNfExportacao.BackColor = System.Drawing.Color.Transparent;
            this.cbostNfExportacao.Base = null;
            this.cbostNfExportacao.Color = System.Drawing.Color.White;
            this.cbostNfExportacao.DataSource = null;
            this.cbostNfExportacao.DisplayMember = "DisplayMember";
            this.cbostNfExportacao.Location = new System.Drawing.Point(729, 138);
            this.cbostNfExportacao.Margin = new System.Windows.Forms.Padding(195, 3, 15, 3);
            this.cbostNfExportacao.Name = "cbostNfExportacao";
            this.cbostNfExportacao.SelectedIndex = -1;
            this.cbostNfExportacao.SelectedValue = 0;
            this.cbostNfExportacao.Size = new System.Drawing.Size(289, 21);
            this.cbostNfExportacao.TabIndex = 5;
            this.cbostNfExportacao.ValueMember = "ValueMember";
            // 
            // cbostNfIndustrializacao
            // 
            this.cbostNfIndustrializacao._Field = "stNfIndustrializacao";
            this.cbostNfIndustrializacao._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostNfIndustrializacao._Itens")));
            this.cbostNfIndustrializacao._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cbostNfIndustrializacao._LabelText = "É nf de industrialização?";
            this.cbostNfIndustrializacao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostNfIndustrializacao._Regex = null;
            this.cbostNfIndustrializacao._situacao = true;
            this.cbostNfIndustrializacao._Table = "Tipo_documento";
            this.cbostNfIndustrializacao._TamanhoComponente = 83;
            this.cbostNfIndustrializacao._TamanhoMaiorLabel = 300;
            this.cbostNfIndustrializacao._Visible = true;
            this.cbostNfIndustrializacao.BackColor = System.Drawing.Color.Transparent;
            this.cbostNfIndustrializacao.Base = null;
            this.cbostNfIndustrializacao.Color = System.Drawing.Color.White;
            this.cbostNfIndustrializacao.DataSource = null;
            this.cbostNfIndustrializacao.DisplayMember = "DisplayMember";
            this.cbostNfIndustrializacao.Location = new System.Drawing.Point(705, 165);
            this.cbostNfIndustrializacao.Margin = new System.Windows.Forms.Padding(171, 3, 15, 3);
            this.cbostNfIndustrializacao.Name = "cbostNfIndustrializacao";
            this.cbostNfIndustrializacao.SelectedIndex = -1;
            this.cbostNfIndustrializacao.SelectedValue = 0;
            this.cbostNfIndustrializacao.Size = new System.Drawing.Size(215, 21);
            this.cbostNfIndustrializacao.TabIndex = 5;
            this.cbostNfIndustrializacao.ValueMember = "ValueMember";
            // 
            // cbostNfSuframa
            // 
            this.cbostNfSuframa._Field = "stNfSuframa";
            this.cbostNfSuframa._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostNfSuframa._Itens")));
            this.cbostNfSuframa._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cbostNfSuframa._LabelText = "É nf de suframa?";
            this.cbostNfSuframa._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostNfSuframa._Regex = null;
            this.cbostNfSuframa._situacao = true;
            this.cbostNfSuframa._Table = "Tipo_documento";
            this.cbostNfSuframa._TamanhoComponente = 83;
            this.cbostNfSuframa._TamanhoMaiorLabel = 300;
            this.cbostNfSuframa._Visible = true;
            this.cbostNfSuframa.BackColor = System.Drawing.Color.Transparent;
            this.cbostNfSuframa.Base = null;
            this.cbostNfSuframa.Color = System.Drawing.Color.White;
            this.cbostNfSuframa.DataSource = null;
            this.cbostNfSuframa.DisplayMember = "DisplayMember";
            this.cbostNfSuframa.Location = new System.Drawing.Point(745, 192);
            this.cbostNfSuframa.Margin = new System.Windows.Forms.Padding(211, 3, 15, 3);
            this.cbostNfSuframa.Name = "cbostNfSuframa";
            this.cbostNfSuframa.SelectedIndex = -1;
            this.cbostNfSuframa.SelectedValue = 0;
            this.cbostNfSuframa.Size = new System.Drawing.Size(175, 21);
            this.cbostNfSuframa.TabIndex = 5;
            this.cbostNfSuframa.ValueMember = "ValueMember";
            // 
            // cbostNfAtivo
            // 
            this.cbostNfAtivo._Field = "stNfAtivo";
            this.cbostNfAtivo._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostNfAtivo._Itens")));
            this.cbostNfAtivo._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cbostNfAtivo._LabelText = "É nf de ativo?";
            this.cbostNfAtivo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostNfAtivo._Regex = null;
            this.cbostNfAtivo._situacao = true;
            this.cbostNfAtivo._Table = "Tipo_documento";
            this.cbostNfAtivo._TamanhoComponente = 83;
            this.cbostNfAtivo._TamanhoMaiorLabel = 300;
            this.cbostNfAtivo._Visible = true;
            this.cbostNfAtivo.BackColor = System.Drawing.Color.Transparent;
            this.cbostNfAtivo.Base = null;
            this.cbostNfAtivo.Color = System.Drawing.Color.White;
            this.cbostNfAtivo.DataSource = null;
            this.cbostNfAtivo.DisplayMember = "DisplayMember";
            this.cbostNfAtivo.Location = new System.Drawing.Point(761, 219);
            this.cbostNfAtivo.Margin = new System.Windows.Forms.Padding(227, 3, 15, 3);
            this.cbostNfAtivo.Name = "cbostNfAtivo";
            this.cbostNfAtivo.SelectedIndex = -1;
            this.cbostNfAtivo.SelectedValue = 0;
            this.cbostNfAtivo.Size = new System.Drawing.Size(159, 21);
            this.cbostNfAtivo.TabIndex = 5;
            this.cbostNfAtivo.ValueMember = "ValueMember";
            // 
            // cbostNFdevolucao
            // 
            this.cbostNFdevolucao._Field = "stNFdevolucao";
            this.cbostNFdevolucao._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostNFdevolucao._Itens")));
            this.cbostNFdevolucao._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cbostNFdevolucao._LabelText = "É nf de devolução?";
            this.cbostNFdevolucao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostNFdevolucao._Regex = null;
            this.cbostNFdevolucao._situacao = true;
            this.cbostNFdevolucao._Table = "Tipo_documento";
            this.cbostNFdevolucao._TamanhoComponente = 83;
            this.cbostNFdevolucao._TamanhoMaiorLabel = 300;
            this.cbostNFdevolucao._Visible = true;
            this.cbostNFdevolucao.BackColor = System.Drawing.Color.Transparent;
            this.cbostNFdevolucao.Base = null;
            this.cbostNFdevolucao.Color = System.Drawing.Color.White;
            this.cbostNFdevolucao.DataSource = null;
            this.cbostNFdevolucao.DisplayMember = "DisplayMember";
            this.cbostNFdevolucao.Location = new System.Drawing.Point(733, 246);
            this.cbostNFdevolucao.Margin = new System.Windows.Forms.Padding(199, 3, 15, 3);
            this.cbostNFdevolucao.Name = "cbostNFdevolucao";
            this.cbostNFdevolucao.SelectedIndex = -1;
            this.cbostNFdevolucao.SelectedValue = 0;
            this.cbostNFdevolucao.Size = new System.Drawing.Size(187, 21);
            this.cbostNFdevolucao.TabIndex = 5;
            this.cbostNFdevolucao.ValueMember = "ValueMember";
            // 
            // cbostCompoeVlTotalProdutos
            // 
            this.cbostCompoeVlTotalProdutos._Field = "stCompoeVlTotalProdutos";
            this.cbostCompoeVlTotalProdutos._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostCompoeVlTotalProdutos._Itens")));
            this.cbostCompoeVlTotalProdutos._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cbostCompoeVlTotalProdutos._LabelText = "Compõe o valor total dos produtos?";
            this.cbostCompoeVlTotalProdutos._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostCompoeVlTotalProdutos._Regex = null;
            this.cbostCompoeVlTotalProdutos._situacao = false;
            this.cbostCompoeVlTotalProdutos._Table = "Tipo_documento";
            this.cbostCompoeVlTotalProdutos._TamanhoComponente = 134;
            this.cbostCompoeVlTotalProdutos._TamanhoMaiorLabel = 300;
            this.cbostCompoeVlTotalProdutos._Visible = true;
            this.cbostCompoeVlTotalProdutos.BackColor = System.Drawing.Color.Transparent;
            this.cbostCompoeVlTotalProdutos.Base = null;
            this.cbostCompoeVlTotalProdutos.Color = System.Drawing.Color.White;
            this.cbostCompoeVlTotalProdutos.DataSource = null;
            this.cbostCompoeVlTotalProdutos.DisplayMember = "DisplayMember";
            this.cbostCompoeVlTotalProdutos.Location = new System.Drawing.Point(644, 273);
            this.cbostCompoeVlTotalProdutos.Margin = new System.Windows.Forms.Padding(110, 3, 15, 3);
            this.cbostCompoeVlTotalProdutos.Name = "cbostCompoeVlTotalProdutos";
            this.cbostCompoeVlTotalProdutos.SelectedIndex = -1;
            this.cbostCompoeVlTotalProdutos.SelectedValue = 0;
            this.cbostCompoeVlTotalProdutos.Size = new System.Drawing.Size(327, 21);
            this.cbostCompoeVlTotalProdutos.TabIndex = 5;
            this.cbostCompoeVlTotalProdutos.ValueMember = "ValueMember";
            // 
            // cbostSomaDevolucaoVlTotalNf
            // 
            this.cbostSomaDevolucaoVlTotalNf._Field = "stSomaDevolucaoVlTotalNf";
            this.cbostSomaDevolucaoVlTotalNf._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostSomaDevolucaoVlTotalNf._Itens")));
            this.cbostSomaDevolucaoVlTotalNf._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cbostSomaDevolucaoVlTotalNf._LabelText = "Soma a devolução no total da nf?";
            this.cbostSomaDevolucaoVlTotalNf._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostSomaDevolucaoVlTotalNf._Regex = null;
            this.cbostSomaDevolucaoVlTotalNf._situacao = true;
            this.cbostSomaDevolucaoVlTotalNf._Table = "Tipo_documento";
            this.cbostSomaDevolucaoVlTotalNf._TamanhoComponente = 83;
            this.cbostSomaDevolucaoVlTotalNf._TamanhoMaiorLabel = 300;
            this.cbostSomaDevolucaoVlTotalNf._Visible = true;
            this.cbostSomaDevolucaoVlTotalNf.BackColor = System.Drawing.Color.Transparent;
            this.cbostSomaDevolucaoVlTotalNf.Base = null;
            this.cbostSomaDevolucaoVlTotalNf.Color = System.Drawing.Color.White;
            this.cbostSomaDevolucaoVlTotalNf.DataSource = null;
            this.cbostSomaDevolucaoVlTotalNf.DisplayMember = "DisplayMember";
            this.cbostSomaDevolucaoVlTotalNf.Location = new System.Drawing.Point(658, 300);
            this.cbostSomaDevolucaoVlTotalNf.Margin = new System.Windows.Forms.Padding(124, 3, 15, 3);
            this.cbostSomaDevolucaoVlTotalNf.Name = "cbostSomaDevolucaoVlTotalNf";
            this.cbostSomaDevolucaoVlTotalNf.SelectedIndex = -1;
            this.cbostSomaDevolucaoVlTotalNf.SelectedValue = 0;
            this.cbostSomaDevolucaoVlTotalNf.Size = new System.Drawing.Size(262, 21);
            this.cbostSomaDevolucaoVlTotalNf.TabIndex = 5;
            this.cbostSomaDevolucaoVlTotalNf.ValueMember = "ValueMember";
            // 
            // cbostImprimeIcmsProprioComNormal
            // 
            this.cbostImprimeIcmsProprioComNormal._Field = "stImprimeIcmsProprioComNormal";
            this.cbostImprimeIcmsProprioComNormal._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostImprimeIcmsProprioComNormal._Itens")));
            this.cbostImprimeIcmsProprioComNormal._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cbostImprimeIcmsProprioComNormal._LabelText = "Imprime icms próprio com normal na nf?";
            this.cbostImprimeIcmsProprioComNormal._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostImprimeIcmsProprioComNormal._Regex = null;
            this.cbostImprimeIcmsProprioComNormal._situacao = true;
            this.cbostImprimeIcmsProprioComNormal._Table = "Tipo_documento";
            this.cbostImprimeIcmsProprioComNormal._TamanhoComponente = 87;
            this.cbostImprimeIcmsProprioComNormal._TamanhoMaiorLabel = 300;
            this.cbostImprimeIcmsProprioComNormal._Visible = true;
            this.cbostImprimeIcmsProprioComNormal.BackColor = System.Drawing.Color.Transparent;
            this.cbostImprimeIcmsProprioComNormal.Base = null;
            this.cbostImprimeIcmsProprioComNormal.Color = System.Drawing.Color.White;
            this.cbostImprimeIcmsProprioComNormal.DataSource = null;
            this.cbostImprimeIcmsProprioComNormal.DisplayMember = "DisplayMember";
            this.cbostImprimeIcmsProprioComNormal.Location = new System.Drawing.Point(624, 327);
            this.cbostImprimeIcmsProprioComNormal.Margin = new System.Windows.Forms.Padding(90, 3, 15, 3);
            this.cbostImprimeIcmsProprioComNormal.Name = "cbostImprimeIcmsProprioComNormal";
            this.cbostImprimeIcmsProprioComNormal.SelectedIndex = -1;
            this.cbostImprimeIcmsProprioComNormal.SelectedValue = 0;
            this.cbostImprimeIcmsProprioComNormal.Size = new System.Drawing.Size(300, 21);
            this.cbostImprimeIcmsProprioComNormal.TabIndex = 5;
            this.cbostImprimeIcmsProprioComNormal.ValueMember = "ValueMember";
            // 
            // cbostRelacaoRecebimentoPedidocpa
            // 
            this.cbostRelacaoRecebimentoPedidocpa._Field = "stRelacaoRecebimentoPedidocpa";
            this.cbostRelacaoRecebimentoPedidocpa._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostRelacaoRecebimentoPedidocpa._Itens")));
            this.cbostRelacaoRecebimentoPedidocpa._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cbostRelacaoRecebimentoPedidocpa._LabelText = "Relação do recebimento com pedido de compra";
            this.cbostRelacaoRecebimentoPedidocpa._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostRelacaoRecebimentoPedidocpa._Regex = null;
            this.cbostRelacaoRecebimentoPedidocpa._situacao = true;
            this.cbostRelacaoRecebimentoPedidocpa._Table = "Tipo_documento";
            this.cbostRelacaoRecebimentoPedidocpa._TamanhoComponente = 80;
            this.cbostRelacaoRecebimentoPedidocpa._TamanhoMaiorLabel = 300;
            this.cbostRelacaoRecebimentoPedidocpa._Visible = true;
            this.cbostRelacaoRecebimentoPedidocpa.BackColor = System.Drawing.Color.Transparent;
            this.cbostRelacaoRecebimentoPedidocpa.Base = null;
            this.cbostRelacaoRecebimentoPedidocpa.Color = System.Drawing.Color.White;
            this.cbostRelacaoRecebimentoPedidocpa.DataSource = null;
            this.cbostRelacaoRecebimentoPedidocpa.DisplayMember = "DisplayMember";
            this.cbostRelacaoRecebimentoPedidocpa.Location = new System.Drawing.Point(585, 354);
            this.cbostRelacaoRecebimentoPedidocpa.Margin = new System.Windows.Forms.Padding(51, 3, 15, 3);
            this.cbostRelacaoRecebimentoPedidocpa.Name = "cbostRelacaoRecebimentoPedidocpa";
            this.cbostRelacaoRecebimentoPedidocpa.SelectedIndex = -1;
            this.cbostRelacaoRecebimentoPedidocpa.SelectedValue = 0;
            this.cbostRelacaoRecebimentoPedidocpa.Size = new System.Drawing.Size(332, 21);
            this.cbostRelacaoRecebimentoPedidocpa.TabIndex = 5;
            this.cbostRelacaoRecebimentoPedidocpa.ValueMember = "ValueMember";
            // 
            // cbostRelacaoPedidocpaCotacao
            // 
            this.cbostRelacaoPedidocpaCotacao._Field = "stRelacaoPedidocpaCotacao";
            this.cbostRelacaoPedidocpaCotacao._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostRelacaoPedidocpaCotacao._Itens")));
            this.cbostRelacaoPedidocpaCotacao._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cbostRelacaoPedidocpaCotacao._LabelText = "Relação do pedido de compra com cotação de compra";
            this.cbostRelacaoPedidocpaCotacao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostRelacaoPedidocpaCotacao._Regex = null;
            this.cbostRelacaoPedidocpaCotacao._situacao = true;
            this.cbostRelacaoPedidocpaCotacao._Table = "Tipo_documento";
            this.cbostRelacaoPedidocpaCotacao._TamanhoComponente = 80;
            this.cbostRelacaoPedidocpaCotacao._TamanhoMaiorLabel = 300;
            this.cbostRelacaoPedidocpaCotacao._Visible = true;
            this.cbostRelacaoPedidocpaCotacao.BackColor = System.Drawing.Color.Transparent;
            this.cbostRelacaoPedidocpaCotacao.Base = null;
            this.cbostRelacaoPedidocpaCotacao.Color = System.Drawing.Color.White;
            this.cbostRelacaoPedidocpaCotacao.DataSource = null;
            this.cbostRelacaoPedidocpaCotacao.DisplayMember = "DisplayMember";
            this.cbostRelacaoPedidocpaCotacao.Location = new System.Drawing.Point(1051, 3);
            this.cbostRelacaoPedidocpaCotacao.Margin = new System.Windows.Forms.Padding(18, 3, 15, 3);
            this.cbostRelacaoPedidocpaCotacao.Name = "cbostRelacaoPedidocpaCotacao";
            this.cbostRelacaoPedidocpaCotacao.SelectedIndex = -1;
            this.cbostRelacaoPedidocpaCotacao.SelectedValue = 0;
            this.cbostRelacaoPedidocpaCotacao.Size = new System.Drawing.Size(365, 21);
            this.cbostRelacaoPedidocpaCotacao.TabIndex = 5;
            this.cbostRelacaoPedidocpaCotacao.ValueMember = "ValueMember";
            // 
            // campoPesquisaidModeloDocFiscal
            // 
            this.campoPesquisaidModeloDocFiscal._Field = "idModeloDocFiscal";
            this.campoPesquisaidModeloDocFiscal._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.campoPesquisaidModeloDocFiscal._LabelText = "Modelo do documento fiscal";
            this.campoPesquisaidModeloDocFiscal._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("campoPesquisaidModeloDocFiscal._ListaCamposDisplay")));
            this.campoPesquisaidModeloDocFiscal._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("campoPesquisaidModeloDocFiscal._ListaValoresDisplay")));
            this.campoPesquisaidModeloDocFiscal._NomeCampoPK = "ID";
            this.campoPesquisaidModeloDocFiscal._NomeFormCadastroOriginal = "";
            this.campoPesquisaidModeloDocFiscal._NomeView = "vwModeloDocFiscal";
            this.campoPesquisaidModeloDocFiscal._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.campoPesquisaidModeloDocFiscal._Regex = null;
            this.campoPesquisaidModeloDocFiscal._Table = "Tipo_documento";
            this.campoPesquisaidModeloDocFiscal._TamanhoComponente = 200;
            this.campoPesquisaidModeloDocFiscal._TamanhoMaiorLabel = 300;
            this.campoPesquisaidModeloDocFiscal._Vinculado = false;
            this.campoPesquisaidModeloDocFiscal._Visible = true;
            this.campoPesquisaidModeloDocFiscal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.campoPesquisaidModeloDocFiscal.BackColor = System.Drawing.Color.Transparent;
            this.campoPesquisaidModeloDocFiscal.Base = null;
            this.campoPesquisaidModeloDocFiscal.Location = new System.Drawing.Point(1181, 30);
            this.campoPesquisaidModeloDocFiscal.Margin = new System.Windows.Forms.Padding(148, 3, 15, 3);
            this.campoPesquisaidModeloDocFiscal.Name = "campoPesquisaidModeloDocFiscal";
            this.campoPesquisaidModeloDocFiscal.ReadOnly = false;
            this.campoPesquisaidModeloDocFiscal.Size = new System.Drawing.Size(445, 21);
            this.campoPesquisaidModeloDocFiscal.TabIndex = 6;
            this.campoPesquisaidModeloDocFiscal.Value = 0;
            // 
            // campoxObs
            // 
            this.campoxObs._Field = "xObs";
            this.campoxObs._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.campoxObs._LabelText = "Observação";
            this.campoxObs._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.campoxObs._Regex = null;
            this.campoxObs._Table = "Tipo_documento";
            this.campoxObs._TamanhoComponente = 109;
            this.campoxObs._TamanhoMaiorLabel = 300;
            this.campoxObs._Visible = true;
            this.campoxObs.BackColor = System.Drawing.Color.Transparent;
            this.campoxObs.Base = null;
            this.campoxObs.Location = new System.Drawing.Point(1269, 57);
            this.campoxObs.Margin = new System.Windows.Forms.Padding(236, 3, 15, 3);
            this.campoxObs.Name = "campoxObs";
            this.campoxObs.Size = new System.Drawing.Size(176, 26);
            this.campoxObs.TabIndex = 7;
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
            this.cboAtivo._Table = "Tipo_documento";
            this.cboAtivo._TamanhoComponente = 80;
            this.cboAtivo._TamanhoMaiorLabel = 300;
            this.cboAtivo._Visible = true;
            this.cboAtivo.BackColor = System.Drawing.Color.Transparent;
            this.cboAtivo.Base = null;
            this.cboAtivo.Color = System.Drawing.Color.White;
            this.cboAtivo.DataSource = null;
            this.cboAtivo.DisplayMember = "DisplayMember";
            this.cboAtivo.Location = new System.Drawing.Point(1250, 89);
            this.cboAtivo.Margin = new System.Windows.Forms.Padding(217, 3, 15, 3);
            this.cboAtivo.Name = "cboAtivo";
            this.cboAtivo.SelectedIndex = -1;
            this.cboAtivo.SelectedValue = 0;
            this.cboAtivo.Size = new System.Drawing.Size(166, 21);
            this.cboAtivo.TabIndex = 5;
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
            this.kryptonTabControl1.Size = new System.Drawing.Size(1362, 423);
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
            this.tabPage1.Size = new System.Drawing.Size(1354, 394);
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
            this.kryptonPanel1.Size = new System.Drawing.Size(1354, 394);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // FormTipoDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 480);
            this.Name = "FormTipoDocumento";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = -10;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Text = "Tipos de Documento";
            this.Load += new System.EventHandler(this.FormTipoDocumento_Load);
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
        private Comum.Components.HLP_TextBox txtxTpdoc;
        private Comum.Components.HLP_ComboBox cbotpDocumento;
        private Comum.Components.HLP_ComboBox cbostRelacaoPedidoxorcamento;
        private Comum.Components.HLP_ComboBox cbostRelacaoPedidoxnf;
        private Comum.Components.HLP_ComboBox cbostRelacaoPedidoxproducao;
        private Comum.Components.HLP_ComboBox cbostGrupoFaturamento;
        private Comum.Components.HLP_TextBox txtxSerieNf;
        private Comum.Components.HLP_TextBox txtxEspecieVolNf;
        private Comum.Components.HLP_TextBox txtxMarcaVolNf;
        private Comum.Components.HLP_ComboBox cbostSomaIpi1Dup;
        private Comum.Components.HLP_ComboBox cbostSomaSt1Dup;
        private Comum.Components.HLP_ComboBox cbostNfComplementar;
        private Comum.Components.HLP_ComboBox cbostNfImportacao;
        private Comum.Components.HLP_ComboBox cbostNfExportacao;
        private Comum.Components.HLP_ComboBox cbostNfIndustrializacao;
        private Comum.Components.HLP_ComboBox cbostNfSuframa;
        private Comum.Components.HLP_ComboBox cbostNfAtivo;
        private Comum.Components.HLP_ComboBox cbostNFdevolucao;
        private Comum.Components.HLP_ComboBox cbostCompoeVlTotalProdutos;
        private Comum.Components.HLP_ComboBox cbostSomaDevolucaoVlTotalNf;
        private Comum.Components.HLP_ComboBox cbostImprimeIcmsProprioComNormal;
        private Comum.Components.HLP_ComboBox cbostRelacaoRecebimentoPedidocpa;
        private Comum.Components.HLP_ComboBox cbostRelacaoPedidocpaCotacao;
        private Comum.Components.HLP_Pesquisa campoPesquisaidModeloDocFiscal;
        private Comum.Components.HLP_ComboBox cboAtivo;
        private Comum.Components.HLP_Observacao campoxObs;
        private Comum.Components.HLP_ListBox lsOperacoesValidas;
        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel1;
        private Comum.Components.HLP_LabelSeparator hlP_LabelSeparator1_Geral;
    }
}