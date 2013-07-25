using HLP.Comum.Components;
namespace HLP.UI.Entries.Geral
{
    partial class FormContato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContato));
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonTabControl1 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kryptonPanel7 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.sp_Identificacao = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtCodigo = new HLP.Comum.Components.HLP_TextBox();
            this.txtxTitulo = new HLP.Comum.Components.HLP_TextBox();
            this.txtxNome = new HLP.Comum.Components.HLP_TextBox();
            this.txtxFuncao = new HLP.Comum.Components.HLP_TextBox();
            this.txtxDepartamento = new HLP.Comum.Components.HLP_TextBox();
            this.txtxApelido = new HLP.Comum.Components.HLP_TextBox();
            this.cbxAtivo = new HLP.Comum.Components.HLP_ComboBox();
            this.mskxCPF = new HLP.Comum.Components.HLP_MaskedTextBox();
            this.cbxstSexo = new HLP.Comum.Components.HLP_ComboBox();
            this.cbxstSensibilidade = new HLP.Comum.Components.HLP_ComboBox();
            this.sp_Superior = new HLP.Comum.Components.HLP_LabelSeparator();
            this.cbxidContatoGerente = new HLP.Comum.Components.HLP_ComboBox();
            this.spContatoPrincipal = new HLP.Comum.Components.HLP_LabelSeparator();
            this.cbxidFuncionario = new HLP.Comum.Components.HLP_ComboBox();
            this.sp_TempDisp = new HLP.Comum.Components.HLP_LabelSeparator();
            this.dtdDisponivelaPartir = new HLP.Comum.Components.HLP_DateTimePicker();
            this.dtdDisponivelAte = new HLP.Comum.Components.HLP_DateTimePicker();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.sp_Personalidade = new HLP.Comum.Components.HLP_LabelSeparator();
            this.hlP_PesquisaidFidelidade = new HLP.Comum.Components.HLP_Pesquisa();
            this.hlP_PesquisaidDecisao = new HLP.Comum.Components.HLP_Pesquisa();
            this.hlP_PesquisaidPersonalidade = new HLP.Comum.Components.HLP_Pesquisa();
            this.sp_vip_maladireta = new HLP.Comum.Components.HLP_LabelSeparator();
            this.cbxstVip = new HLP.Comum.Components.HLP_ComboBox();
            this.cbxstMalaDireta = new HLP.Comum.Components.HLP_ComboBox();
            this.sp_outrosConfig = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtxMemorando = new HLP.Comum.Components.HLP_TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvEndereco = new HLP.Comum.Components.HLP_DataGridView();
            this.stPrincipal = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.xNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stTipoEndereco = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.xCEP = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewMaskedTextBoxColumn();
            this.idCidade = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.stLogradouro = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.xEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xComplemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xLatitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xLongitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFusoHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCaixaPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idContato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsContatoEndereco = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.kryptonPanel5 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.sp_Comercial = new HLP.Comum.Components.HLP_LabelSeparator();
            this.mskxTelefoneComercial = new HLP.Comum.Components.HLP_MaskedTextBox();
            this.txtxRamalComercial = new HLP.Comum.Components.HLP_TextBox();
            this.mskxCelularComercial = new HLP.Comum.Components.HLP_MaskedTextBox();
            this.txtxRadioFoneComercial = new HLP.Comum.Components.HLP_TextBox();
            this.txtxPagerComercial = new HLP.Comum.Components.HLP_TextBox();
            this.mskxFaxComercial = new HLP.Comum.Components.HLP_MaskedTextBox();
            this.txtxEmailComercial = new HLP.Comum.Components.HLP_TextBox();
            this.txtxSkypeComercial = new HLP.Comum.Components.HLP_TextBox();
            this.txtxMSNComercial = new HLP.Comum.Components.HLP_TextBox();
            this.txtxhttpComercial = new HLP.Comum.Components.HLP_TextBox();
            this.sp_Residencial = new HLP.Comum.Components.HLP_LabelSeparator();
            this.mskxTelefoneResidencial = new HLP.Comum.Components.HLP_MaskedTextBox();
            this.mskxCelularResidencial = new HLP.Comum.Components.HLP_MaskedTextBox();
            this.txtxRadioFoneResidencial = new HLP.Comum.Components.HLP_TextBox();
            this.txtxEmailResidencial = new HLP.Comum.Components.HLP_TextBox();
            this.txtxSkypeResidencial = new HLP.Comum.Components.HLP_TextBox();
            this.txtxMsnResidencial = new HLP.Comum.Components.HLP_TextBox();
            this.txtXhttpPessoal = new HLP.Comum.Components.HLP_TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.kryptonPanel6 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.sp_Familia = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtxFilhos = new HLP.Comum.Components.HLP_TextBox();
            this.dtdDataAniversario = new HLP.Comum.Components.HLP_DateTimePicker();
            this.txtxConjuge = new HLP.Comum.Components.HLP_TextBox();
            this.cbxstEstadoCivil = new HLP.Comum.Components.HLP_ComboBox();
            this.sp_Hobbies = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtxHobbies = new HLP.Comum.Components.HLP_TextBox();
            this.sp_Empresa = new HLP.Comum.Components.HLP_LabelSeparator();
            this.dtdAniversarioTempoServico = new HLP.Comum.Components.HLP_DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).BeginInit();
            this.panelPadrao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel7)).BeginInit();
            this.kryptonPanel7.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndereco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContatoEndereco)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).BeginInit();
            this.kryptonPanel5.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel6)).BeginInit();
            this.kryptonPanel6.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(884, 534);
            // 
            // panelPadrao
            // 
            this.panelPadrao.Controls.Add(this.kryptonTabControl1);
            this.panelPadrao.Size = new System.Drawing.Size(882, 510);
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 27);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(884, 534);
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
            this.kryptonTabControl1.Controls.Add(this.tabPage3);
            this.kryptonTabControl1.Controls.Add(this.tabPage2);
            this.kryptonTabControl1.Controls.Add(this.tabPage4);
            this.kryptonTabControl1.Controls.Add(this.tabPage5);
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
            this.kryptonTabControl1.Size = new System.Drawing.Size(876, 504);
            this.kryptonTabControl1.TabIndex = 2;
            this.kryptonTabControl1.UseExtendedLayout = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Controls.Add(this.kryptonPanel7);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(868, 475);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = false;
            this.tabPage1.Text = "Geral";
            // 
            // kryptonPanel7
            // 
            this.kryptonPanel7.Controls.Add(this.flowLayoutPanel1);
            this.kryptonPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel7.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel7.Name = "kryptonPanel7";
            this.kryptonPanel7.Size = new System.Drawing.Size(868, 475);
            this.kryptonPanel7.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.sp_Identificacao);
            this.flowLayoutPanel1.Controls.Add(this.txtCodigo);
            this.flowLayoutPanel1.Controls.Add(this.txtxTitulo);
            this.flowLayoutPanel1.Controls.Add(this.txtxNome);
            this.flowLayoutPanel1.Controls.Add(this.txtxFuncao);
            this.flowLayoutPanel1.Controls.Add(this.txtxDepartamento);
            this.flowLayoutPanel1.Controls.Add(this.txtxApelido);
            this.flowLayoutPanel1.Controls.Add(this.cbxAtivo);
            this.flowLayoutPanel1.Controls.Add(this.mskxCPF);
            this.flowLayoutPanel1.Controls.Add(this.cbxstSexo);
            this.flowLayoutPanel1.Controls.Add(this.cbxstSensibilidade);
            this.flowLayoutPanel1.Controls.Add(this.sp_Superior);
            this.flowLayoutPanel1.Controls.Add(this.cbxidContatoGerente);
            this.flowLayoutPanel1.Controls.Add(this.spContatoPrincipal);
            this.flowLayoutPanel1.Controls.Add(this.cbxidFuncionario);
            this.flowLayoutPanel1.Controls.Add(this.sp_TempDisp);
            this.flowLayoutPanel1.Controls.Add(this.dtdDisponivelaPartir);
            this.flowLayoutPanel1.Controls.Add(this.dtdDisponivelAte);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(868, 475);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Tag = "Principal";
            // 
            // sp_Identificacao
            // 
            this.sp_Identificacao._LabelText = "Identificação";
            this.sp_Identificacao._TamanhoMaiorLabel = 0;
            this.sp_Identificacao.BackColor = System.Drawing.Color.Transparent;
            this.sp_Identificacao.Location = new System.Drawing.Point(0, 3);
            this.sp_Identificacao.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.sp_Identificacao.Name = "sp_Identificacao";
            this.sp_Identificacao.Size = new System.Drawing.Size(568, 18);
            this.sp_Identificacao.TabIndex = 24;
            this.sp_Identificacao.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo._Field = "idContato";
            this.txtCodigo._LabelGroup = this.sp_Identificacao;
            this.txtCodigo._LabelText = "Código";
            this.txtCodigo._Multiline = false;
            this.txtCodigo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtCodigo._Password = false;
            this.txtCodigo._Regex = null;
            this.txtCodigo._Table = "Contato";
            this.txtCodigo._TamanhoComponente = 132;
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
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(177, 24);
            this.txtCodigo.TabIndex = 3;
            // 
            // txtxTitulo
            // 
            this.txtxTitulo._Field = "xTitulo";
            this.txtxTitulo._Help = "Especifique a forma de tratamento preferida do contato";
            this.txtxTitulo._LabelGroup = this.sp_Identificacao;
            this.txtxTitulo._LabelText = "Título";
            this.txtxTitulo._Multiline = false;
            this.txtxTitulo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxTitulo._Password = false;
            this.txtxTitulo._Regex = null;
            this.txtxTitulo._Table = "Contato";
            this.txtxTitulo._TamanhoComponente = 159;
            this.txtxTitulo._TamanhoMaiorLabel = 150;
            this.txtxTitulo._Visible = true;
            this.txtxTitulo.BackColor = System.Drawing.Color.Transparent;
            this.txtxTitulo.Base = null;
            this.txtxTitulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxTitulo.Color = System.Drawing.Color.White;
            this.txtxTitulo.Location = new System.Drawing.Point(117, 57);
            this.txtxTitulo.Margin = new System.Windows.Forms.Padding(117, 3, 15, 3);
            this.txtxTitulo.MaxLength = 32767;
            this.txtxTitulo.Name = "txtxTitulo";
            this.txtxTitulo.ReadOnly = false;
            this.txtxTitulo.Size = new System.Drawing.Size(195, 24);
            this.txtxTitulo.TabIndex = 5;
            // 
            // txtxNome
            // 
            this.txtxNome._Field = "xNome";
            this.txtxNome._Help = "Informe o nome do contato ou pessoa";
            this.txtxNome._LabelGroup = this.sp_Identificacao;
            this.txtxNome._LabelText = "Nome";
            this.txtxNome._Multiline = false;
            this.txtxNome._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxNome._Password = false;
            this.txtxNome._Regex = null;
            this.txtxNome._Table = "Contato";
            this.txtxNome._TamanhoComponente = 415;
            this.txtxNome._TamanhoMaiorLabel = 150;
            this.txtxNome._Visible = true;
            this.txtxNome.BackColor = System.Drawing.Color.Transparent;
            this.txtxNome.Base = null;
            this.txtxNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxNome.Color = System.Drawing.Color.White;
            this.txtxNome.Location = new System.Drawing.Point(116, 87);
            this.txtxNome.Margin = new System.Windows.Forms.Padding(116, 3, 15, 3);
            this.txtxNome.MaxLength = 32767;
            this.txtxNome.Name = "txtxNome";
            this.txtxNome.ReadOnly = false;
            this.txtxNome.Size = new System.Drawing.Size(452, 24);
            this.txtxNome.TabIndex = 6;
            // 
            // txtxFuncao
            // 
            this.txtxFuncao._Field = "xFuncao";
            this.txtxFuncao._Help = "Informar a função do contato ou pessoa dentro da organização";
            this.txtxFuncao._LabelGroup = this.sp_Identificacao;
            this.txtxFuncao._LabelText = "Função";
            this.txtxFuncao._Multiline = false;
            this.txtxFuncao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxFuncao._Password = false;
            this.txtxFuncao._Regex = null;
            this.txtxFuncao._Table = "Contato";
            this.txtxFuncao._TamanhoComponente = 276;
            this.txtxFuncao._TamanhoMaiorLabel = 150;
            this.txtxFuncao._Visible = true;
            this.txtxFuncao.BackColor = System.Drawing.Color.Transparent;
            this.txtxFuncao.Base = null;
            this.txtxFuncao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxFuncao.Color = System.Drawing.Color.White;
            this.txtxFuncao.Location = new System.Drawing.Point(108, 117);
            this.txtxFuncao.Margin = new System.Windows.Forms.Padding(108, 3, 15, 3);
            this.txtxFuncao.MaxLength = 32767;
            this.txtxFuncao.Name = "txtxFuncao";
            this.txtxFuncao.ReadOnly = false;
            this.txtxFuncao.Size = new System.Drawing.Size(321, 24);
            this.txtxFuncao.TabIndex = 30;
            // 
            // txtxDepartamento
            // 
            this.txtxDepartamento._Field = "xDepartamento";
            this.txtxDepartamento._Help = "Insira o departamento em que o contato está localizado.";
            this.txtxDepartamento._LabelGroup = this.sp_Identificacao;
            this.txtxDepartamento._LabelText = "Departamento";
            this.txtxDepartamento._Multiline = false;
            this.txtxDepartamento._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxDepartamento._Password = false;
            this.txtxDepartamento._Regex = null;
            this.txtxDepartamento._Table = "Contato";
            this.txtxDepartamento._TamanhoComponente = 102;
            this.txtxDepartamento._TamanhoMaiorLabel = 150;
            this.txtxDepartamento._Visible = true;
            this.txtxDepartamento.BackColor = System.Drawing.Color.Transparent;
            this.txtxDepartamento.Base = null;
            this.txtxDepartamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxDepartamento.Color = System.Drawing.Color.White;
            this.txtxDepartamento.Location = new System.Drawing.Point(72, 147);
            this.txtxDepartamento.Margin = new System.Windows.Forms.Padding(72, 3, 15, 3);
            this.txtxDepartamento.MaxLength = 32767;
            this.txtxDepartamento.Name = "txtxDepartamento";
            this.txtxDepartamento.ReadOnly = false;
            this.txtxDepartamento.Size = new System.Drawing.Size(183, 24);
            this.txtxDepartamento.TabIndex = 7;
            // 
            // txtxApelido
            // 
            this.txtxApelido._Field = "xApelido";
            this.txtxApelido._Help = "Especifique o apelido do contato";
            this.txtxApelido._LabelGroup = this.sp_Identificacao;
            this.txtxApelido._LabelText = "Apelido";
            this.txtxApelido._Multiline = false;
            this.txtxApelido._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxApelido._Password = false;
            this.txtxApelido._Regex = null;
            this.txtxApelido._Table = "Contato";
            this.txtxApelido._TamanhoComponente = 102;
            this.txtxApelido._TamanhoMaiorLabel = 150;
            this.txtxApelido._Visible = true;
            this.txtxApelido.BackColor = System.Drawing.Color.Transparent;
            this.txtxApelido.Base = null;
            this.txtxApelido.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxApelido.Color = System.Drawing.Color.White;
            this.txtxApelido.Location = new System.Drawing.Point(106, 177);
            this.txtxApelido.Margin = new System.Windows.Forms.Padding(106, 3, 15, 3);
            this.txtxApelido.MaxLength = 32767;
            this.txtxApelido.Name = "txtxApelido";
            this.txtxApelido.ReadOnly = false;
            this.txtxApelido.Size = new System.Drawing.Size(149, 24);
            this.txtxApelido.TabIndex = 10;
            // 
            // cbxAtivo
            // 
            this.cbxAtivo._Field = "Ativo";
            this.cbxAtivo._Help = "Informar se o contato é ativo na organização";
            this.cbxAtivo._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbxAtivo._Itens")));
            this.cbxAtivo._LabelGroup = this.sp_Identificacao;
            this.cbxAtivo._LabelText = "Ativo";
            this.cbxAtivo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbxAtivo._Regex = null;
            this.cbxAtivo._situacao = true;
            this.cbxAtivo._Table = "Contato";
            this.cbxAtivo._TamanhoComponente = 80;
            this.cbxAtivo._TamanhoMaiorLabel = 150;
            this.cbxAtivo._Visible = true;
            this.cbxAtivo.BackColor = System.Drawing.Color.Transparent;
            this.cbxAtivo.Base = null;
            this.cbxAtivo.Color = System.Drawing.Color.White;
            this.cbxAtivo.DataSource = null;
            this.cbxAtivo.DisplayMember = "DisplayMember";
            this.cbxAtivo.Location = new System.Drawing.Point(120, 207);
            this.cbxAtivo.Margin = new System.Windows.Forms.Padding(120, 3, 15, 3);
            this.cbxAtivo.Name = "cbxAtivo";
            this.cbxAtivo.SelectedIndex = -1;
            this.cbxAtivo.SelectedValue = 0;
            this.cbxAtivo.Size = new System.Drawing.Size(113, 21);
            this.cbxAtivo.TabIndex = 16;
            this.cbxAtivo.ValueMember = "ValueMember";
            // 
            // mskxCPF
            // 
            this.mskxCPF._Field = "xCPF";
            this.mskxCPF._Help = "Informar o cpf do contato";
            this.mskxCPF._LabelGroup = this.sp_Identificacao;
            this.mskxCPF._LabelText = "Cpf";
            this.mskxCPF._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.mskxCPF._Regex = null;
            this.mskxCPF._Table = "Contato";
            this.mskxCPF._TamanhoComponente = 125;
            this.mskxCPF._TamanhoMaiorLabel = 150;
            this.mskxCPF._TpValidacao = HLP.Comum.Components.HLP_MaskedTextBox.TipoValidacao.DEFAULT;
            this.mskxCPF._UF = null;
            this.mskxCPF._Visible = true;
            this.mskxCPF.BackColor = System.Drawing.Color.Transparent;
            this.mskxCPF.Base = null;
            this.mskxCPF.Color = System.Drawing.Color.White;
            this.mskxCPF.Location = new System.Drawing.Point(128, 234);
            this.mskxCPF.Margin = new System.Windows.Forms.Padding(128, 3, 15, 3);
            this.mskxCPF.Mask = "000,000,000-00";
            this.mskxCPF.MaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mskxCPF.MaxLength = 32767;
            this.mskxCPF.Name = "mskxCPF";
            this.mskxCPF.ReadOnly = false;
            this.mskxCPF.Size = new System.Drawing.Size(150, 21);
            this.mskxCPF.TabIndex = 17;
            // 
            // cbxstSexo
            // 
            this.cbxstSexo._Field = "stSexo";
            this.cbxstSexo._Help = "Especifique o sexo do contato.";
            this.cbxstSexo._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbxstSexo._Itens")));
            this.cbxstSexo._LabelGroup = this.sp_Identificacao;
            this.cbxstSexo._LabelText = "Sexo";
            this.cbxstSexo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbxstSexo._Regex = null;
            this.cbxstSexo._situacao = false;
            this.cbxstSexo._Table = "Contato";
            this.cbxstSexo._TamanhoComponente = 111;
            this.cbxstSexo._TamanhoMaiorLabel = 150;
            this.cbxstSexo._Visible = true;
            this.cbxstSexo.BackColor = System.Drawing.Color.Transparent;
            this.cbxstSexo.Base = null;
            this.cbxstSexo.Color = System.Drawing.Color.White;
            this.cbxstSexo.DataSource = null;
            this.cbxstSexo.DisplayMember = "DisplayMember";
            this.cbxstSexo.Location = new System.Drawing.Point(122, 261);
            this.cbxstSexo.Margin = new System.Windows.Forms.Padding(122, 3, 15, 3);
            this.cbxstSexo.Name = "cbxstSexo";
            this.cbxstSexo.SelectedIndex = -1;
            this.cbxstSexo.SelectedValue = 0;
            this.cbxstSexo.Size = new System.Drawing.Size(142, 21);
            this.cbxstSexo.TabIndex = 18;
            this.cbxstSexo.ValueMember = "ValueMember";
            // 
            // cbxstSensibilidade
            // 
            this.cbxstSensibilidade._Field = "stSensibilidade";
            this.cbxstSensibilidade._Help = "Selecione a sensibilidade das atividades que envolvem o contato";
            this.cbxstSensibilidade._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbxstSensibilidade._Itens")));
            this.cbxstSensibilidade._LabelGroup = this.sp_Identificacao;
            this.cbxstSensibilidade._LabelText = "Sensibilidade";
            this.cbxstSensibilidade._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbxstSensibilidade._Regex = null;
            this.cbxstSensibilidade._situacao = false;
            this.cbxstSensibilidade._Table = "Contato";
            this.cbxstSensibilidade._TamanhoComponente = 128;
            this.cbxstSensibilidade._TamanhoMaiorLabel = 150;
            this.cbxstSensibilidade._Visible = true;
            this.cbxstSensibilidade.BackColor = System.Drawing.Color.Transparent;
            this.cbxstSensibilidade.Base = null;
            this.cbxstSensibilidade.Color = System.Drawing.Color.White;
            this.cbxstSensibilidade.DataSource = null;
            this.cbxstSensibilidade.DisplayMember = "DisplayMember";
            this.cbxstSensibilidade.Location = new System.Drawing.Point(77, 288);
            this.cbxstSensibilidade.Margin = new System.Windows.Forms.Padding(77, 3, 15, 3);
            this.cbxstSensibilidade.Name = "cbxstSensibilidade";
            this.cbxstSensibilidade.SelectedIndex = -1;
            this.cbxstSensibilidade.SelectedValue = 0;
            this.cbxstSensibilidade.Size = new System.Drawing.Size(204, 21);
            this.cbxstSensibilidade.TabIndex = 19;
            this.cbxstSensibilidade.ValueMember = "ValueMember";
            // 
            // sp_Superior
            // 
            this.sp_Superior._LabelText = "Contato";
            this.sp_Superior._TamanhoMaiorLabel = 0;
            this.sp_Superior.BackColor = System.Drawing.Color.Transparent;
            this.sp_Superior.Location = new System.Drawing.Point(0, 315);
            this.sp_Superior.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.sp_Superior.Name = "sp_Superior";
            this.sp_Superior.Size = new System.Drawing.Size(568, 18);
            this.sp_Superior.TabIndex = 25;
            this.sp_Superior.TabStop = false;
            // 
            // cbxidContatoGerente
            // 
            this.cbxidContatoGerente._Field = "idContatoGerente";
            this.cbxidContatoGerente._Help = "Selecione o gerente do contato principal";
            this.cbxidContatoGerente._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbxidContatoGerente._Itens")));
            this.cbxidContatoGerente._LabelGroup = this.sp_Superior;
            this.cbxidContatoGerente._LabelText = "Gerente";
            this.cbxidContatoGerente._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbxidContatoGerente._Regex = null;
            this.cbxidContatoGerente._situacao = false;
            this.cbxidContatoGerente._Table = "Contato";
            this.cbxidContatoGerente._TamanhoComponente = 239;
            this.cbxidContatoGerente._TamanhoMaiorLabel = 150;
            this.cbxidContatoGerente._Visible = true;
            this.cbxidContatoGerente.BackColor = System.Drawing.Color.Transparent;
            this.cbxidContatoGerente.Base = null;
            this.cbxidContatoGerente.Color = System.Drawing.Color.White;
            this.cbxidContatoGerente.DataSource = null;
            this.cbxidContatoGerente.DisplayMember = "xNome";
            this.cbxidContatoGerente.Location = new System.Drawing.Point(105, 339);
            this.cbxidContatoGerente.Margin = new System.Windows.Forms.Padding(105, 3, 15, 3);
            this.cbxidContatoGerente.Name = "cbxidContatoGerente";
            this.cbxidContatoGerente.SelectedIndex = -1;
            this.cbxidContatoGerente.SelectedValue = 0;
            this.cbxidContatoGerente.Size = new System.Drawing.Size(287, 21);
            this.cbxidContatoGerente.TabIndex = 28;
            this.cbxidContatoGerente.ValueMember = "idContato";
            // 
            // spContatoPrincipal
            // 
            this.spContatoPrincipal._LabelText = "Contato principal";
            this.spContatoPrincipal._TamanhoMaiorLabel = 0;
            this.spContatoPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.spContatoPrincipal.Location = new System.Drawing.Point(0, 366);
            this.spContatoPrincipal.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.spContatoPrincipal.Name = "spContatoPrincipal";
            this.spContatoPrincipal.Size = new System.Drawing.Size(568, 18);
            this.spContatoPrincipal.TabIndex = 31;
            this.spContatoPrincipal.TabStop = false;
            // 
            // cbxidFuncionario
            // 
            this.cbxidFuncionario._Field = "idFuncionario";
            this.cbxidFuncionario._Help = "Selecione o contato principal do parceiro comercial na empresa";
            this.cbxidFuncionario._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbxidFuncionario._Itens")));
            this.cbxidFuncionario._LabelGroup = this.spContatoPrincipal;
            this.cbxidFuncionario._LabelText = "Funcionario";
            this.cbxidFuncionario._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbxidFuncionario._Regex = null;
            this.cbxidFuncionario._situacao = false;
            this.cbxidFuncionario._Table = "Contato";
            this.cbxidFuncionario._TamanhoComponente = 237;
            this.cbxidFuncionario._TamanhoMaiorLabel = 150;
            this.cbxidFuncionario._Visible = true;
            this.cbxidFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.cbxidFuncionario.Base = null;
            this.cbxidFuncionario.Color = System.Drawing.Color.White;
            this.cbxidFuncionario.DataSource = null;
            this.cbxidFuncionario.DisplayMember = "xNome";
            this.cbxidFuncionario.Location = new System.Drawing.Point(84, 390);
            this.cbxidFuncionario.Margin = new System.Windows.Forms.Padding(84, 3, 15, 3);
            this.cbxidFuncionario.Name = "cbxidFuncionario";
            this.cbxidFuncionario.SelectedIndex = -1;
            this.cbxidFuncionario.SelectedValue = 0;
            this.cbxidFuncionario.Size = new System.Drawing.Size(306, 21);
            this.cbxidFuncionario.TabIndex = 29;
            this.cbxidFuncionario.ValueMember = "idContato";
            // 
            // sp_TempDisp
            // 
            this.sp_TempDisp._LabelText = "Tempo disponível";
            this.sp_TempDisp._TamanhoMaiorLabel = 0;
            this.sp_TempDisp.BackColor = System.Drawing.Color.Transparent;
            this.sp_TempDisp.Location = new System.Drawing.Point(0, 417);
            this.sp_TempDisp.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.sp_TempDisp.Name = "sp_TempDisp";
            this.sp_TempDisp.Size = new System.Drawing.Size(568, 18);
            this.sp_TempDisp.TabIndex = 27;
            this.sp_TempDisp.TabStop = false;
            // 
            // dtdDisponivelaPartir
            // 
            this.dtdDisponivelaPartir._Field = "dDisponivelaPartir";
            this.dtdDisponivelaPartir._Help = "Insira a hora inicial da disponibilidade do contato.";
            this.dtdDisponivelaPartir._LabelGroup = this.sp_TempDisp;
            this.dtdDisponivelaPartir._LabelText = "Disponível a partir";
            this.dtdDisponivelaPartir._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.dtdDisponivelaPartir._Regex = null;
            this.dtdDisponivelaPartir._Table = "Contato";
            this.dtdDisponivelaPartir._TamanhoComponente = 69;
            this.dtdDisponivelaPartir._TamanhoMaiorLabel = 150;
            this.dtdDisponivelaPartir._Visible = true;
            this.dtdDisponivelaPartir.BackColor = System.Drawing.Color.Transparent;
            this.dtdDisponivelaPartir.Base = null;
            this.dtdDisponivelaPartir.Color = System.Drawing.Color.Empty;
            this.dtdDisponivelaPartir.CustomFormat = "";
            this.dtdDisponivelaPartir.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtdDisponivelaPartir.Location = new System.Drawing.Point(52, 441);
            this.dtdDisponivelaPartir.Margin = new System.Windows.Forms.Padding(52, 3, 15, 3);
            this.dtdDisponivelaPartir.Name = "dtdDisponivelaPartir";
            this.dtdDisponivelaPartir.Size = new System.Drawing.Size(170, 21);
            this.dtdDisponivelaPartir.TabIndex = 22;
            this.dtdDisponivelaPartir.Value = new System.DateTime(2012, 8, 7, 14, 7, 3, 909);
            // 
            // dtdDisponivelAte
            // 
            this.dtdDisponivelAte._Field = "dDisponivelAte";
            this.dtdDisponivelAte._Help = "Insira a hora final da disponibilidade do contato.";
            this.dtdDisponivelAte._LabelGroup = this.sp_TempDisp;
            this.dtdDisponivelAte._LabelText = "Disponível até as";
            this.dtdDisponivelAte._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.dtdDisponivelAte._Regex = null;
            this.dtdDisponivelAte._Table = "Contato";
            this.dtdDisponivelAte._TamanhoComponente = 71;
            this.dtdDisponivelAte._TamanhoMaiorLabel = 0;
            this.dtdDisponivelAte._Visible = true;
            this.dtdDisponivelAte.BackColor = System.Drawing.Color.Transparent;
            this.dtdDisponivelAte.Base = null;
            this.dtdDisponivelAte.Color = System.Drawing.Color.Empty;
            this.dtdDisponivelAte.CustomFormat = "";
            this.dtdDisponivelAte.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtdDisponivelAte.Location = new System.Drawing.Point(586, 3);
            this.dtdDisponivelAte.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.dtdDisponivelAte.Name = "dtdDisponivelAte";
            this.dtdDisponivelAte.Size = new System.Drawing.Size(165, 21);
            this.dtdDisponivelAte.TabIndex = 23;
            this.dtdDisponivelAte.Value = new System.DateTime(2012, 8, 7, 14, 7, 3, 909);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage3.Controls.Add(this.kryptonPanel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(868, 475);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Tag = false;
            this.tabPage3.Text = "Configuração";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.flowLayoutPanel2);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(868, 475);
            this.kryptonPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.sp_Personalidade);
            this.flowLayoutPanel2.Controls.Add(this.hlP_PesquisaidFidelidade);
            this.flowLayoutPanel2.Controls.Add(this.hlP_PesquisaidDecisao);
            this.flowLayoutPanel2.Controls.Add(this.hlP_PesquisaidPersonalidade);
            this.flowLayoutPanel2.Controls.Add(this.sp_vip_maladireta);
            this.flowLayoutPanel2.Controls.Add(this.cbxstVip);
            this.flowLayoutPanel2.Controls.Add(this.cbxstMalaDireta);
            this.flowLayoutPanel2.Controls.Add(this.sp_outrosConfig);
            this.flowLayoutPanel2.Controls.Add(this.txtxMemorando);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(868, 475);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // sp_Personalidade
            // 
            this.sp_Personalidade._LabelText = "Personalidade e influência";
            this.sp_Personalidade._TamanhoMaiorLabel = 0;
            this.sp_Personalidade.BackColor = System.Drawing.Color.Transparent;
            this.sp_Personalidade.Location = new System.Drawing.Point(0, 3);
            this.sp_Personalidade.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.sp_Personalidade.Name = "sp_Personalidade";
            this.sp_Personalidade.Size = new System.Drawing.Size(543, 18);
            this.sp_Personalidade.TabIndex = 6;
            this.sp_Personalidade.TabStop = false;
            // 
            // hlP_PesquisaidFidelidade
            // 
            this.hlP_PesquisaidFidelidade._Field = "idFidelidade";
            this.hlP_PesquisaidFidelidade._Help = "Selecione a fidelidade percebida do contato em relação à empresa";
            this.hlP_PesquisaidFidelidade._LabelGroup = this.sp_Personalidade;
            this.hlP_PesquisaidFidelidade._LabelText = "Fidelidade";
            this.hlP_PesquisaidFidelidade._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidFidelidade._ListaCamposDisplay")));
            this.hlP_PesquisaidFidelidade._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidFidelidade._ListaValoresDisplay")));
            this.hlP_PesquisaidFidelidade._NomeCampoPK = "ID";
            this.hlP_PesquisaidFidelidade._NomeFormCadastroOriginal = "FormFidelidade";
            this.hlP_PesquisaidFidelidade._NomeView = "vwFidelidade";
            this.hlP_PesquisaidFidelidade._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisaidFidelidade._Regex = null;
            this.hlP_PesquisaidFidelidade._Table = "Fidelidade";
            this.hlP_PesquisaidFidelidade._TamanhoComponente = 300;
            this.hlP_PesquisaidFidelidade._TamanhoMaiorLabel = 150;
            this.hlP_PesquisaidFidelidade._Vinculado = false;
            this.hlP_PesquisaidFidelidade._Visible = true;
            this.hlP_PesquisaidFidelidade.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidFidelidade.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidFidelidade.Base = null;
            this.hlP_PesquisaidFidelidade.Location = new System.Drawing.Point(92, 27);
            this.hlP_PesquisaidFidelidade.Margin = new System.Windows.Forms.Padding(92, 3, 15, 3);
            this.hlP_PesquisaidFidelidade.Name = "hlP_PesquisaidFidelidade";
            this.hlP_PesquisaidFidelidade.ReadOnly = false;
            this.hlP_PesquisaidFidelidade.Size = new System.Drawing.Size(451, 21);
            this.hlP_PesquisaidFidelidade.TabIndex = 0;
            this.hlP_PesquisaidFidelidade.Value = 0;
            // 
            // hlP_PesquisaidDecisao
            // 
            this.hlP_PesquisaidDecisao._Field = "idDecisao";
            this.hlP_PesquisaidDecisao._Help = "Selecione a influência percebida do contato na tomada de decisões";
            this.hlP_PesquisaidDecisao._LabelGroup = this.sp_Personalidade;
            this.hlP_PesquisaidDecisao._LabelText = "Decisão";
            this.hlP_PesquisaidDecisao._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidDecisao._ListaCamposDisplay")));
            this.hlP_PesquisaidDecisao._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidDecisao._ListaValoresDisplay")));
            this.hlP_PesquisaidDecisao._NomeCampoPK = "ID";
            this.hlP_PesquisaidDecisao._NomeFormCadastroOriginal = "FormDecisao";
            this.hlP_PesquisaidDecisao._NomeView = "vwDecisao";
            this.hlP_PesquisaidDecisao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisaidDecisao._Regex = null;
            this.hlP_PesquisaidDecisao._Table = "Decisao";
            this.hlP_PesquisaidDecisao._TamanhoComponente = 300;
            this.hlP_PesquisaidDecisao._TamanhoMaiorLabel = 150;
            this.hlP_PesquisaidDecisao._Vinculado = false;
            this.hlP_PesquisaidDecisao._Visible = true;
            this.hlP_PesquisaidDecisao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidDecisao.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidDecisao.Base = null;
            this.hlP_PesquisaidDecisao.Location = new System.Drawing.Point(106, 54);
            this.hlP_PesquisaidDecisao.Margin = new System.Windows.Forms.Padding(106, 3, 15, 3);
            this.hlP_PesquisaidDecisao.Name = "hlP_PesquisaidDecisao";
            this.hlP_PesquisaidDecisao.ReadOnly = false;
            this.hlP_PesquisaidDecisao.Size = new System.Drawing.Size(437, 21);
            this.hlP_PesquisaidDecisao.TabIndex = 1;
            this.hlP_PesquisaidDecisao.Value = 0;
            // 
            // hlP_PesquisaidPersonalidade
            // 
            this.hlP_PesquisaidPersonalidade._Field = "idPersonalidade";
            this.hlP_PesquisaidPersonalidade._Help = "Selecione a personalidade percebida do contato";
            this.hlP_PesquisaidPersonalidade._LabelGroup = this.sp_Personalidade;
            this.hlP_PesquisaidPersonalidade._LabelText = "Personalidade";
            this.hlP_PesquisaidPersonalidade._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidPersonalidade._ListaCamposDisplay")));
            this.hlP_PesquisaidPersonalidade._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidPersonalidade._ListaValoresDisplay")));
            this.hlP_PesquisaidPersonalidade._NomeCampoPK = "ID";
            this.hlP_PesquisaidPersonalidade._NomeFormCadastroOriginal = "FormPersonalidade";
            this.hlP_PesquisaidPersonalidade._NomeView = "vwPersonalidade";
            this.hlP_PesquisaidPersonalidade._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisaidPersonalidade._Regex = null;
            this.hlP_PesquisaidPersonalidade._Table = "Personalidade";
            this.hlP_PesquisaidPersonalidade._TamanhoComponente = 300;
            this.hlP_PesquisaidPersonalidade._TamanhoMaiorLabel = 150;
            this.hlP_PesquisaidPersonalidade._Vinculado = false;
            this.hlP_PesquisaidPersonalidade._Visible = true;
            this.hlP_PesquisaidPersonalidade.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidPersonalidade.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidPersonalidade.Base = null;
            this.hlP_PesquisaidPersonalidade.Location = new System.Drawing.Point(73, 81);
            this.hlP_PesquisaidPersonalidade.Margin = new System.Windows.Forms.Padding(73, 3, 15, 3);
            this.hlP_PesquisaidPersonalidade.Name = "hlP_PesquisaidPersonalidade";
            this.hlP_PesquisaidPersonalidade.ReadOnly = false;
            this.hlP_PesquisaidPersonalidade.Size = new System.Drawing.Size(470, 21);
            this.hlP_PesquisaidPersonalidade.TabIndex = 2;
            this.hlP_PesquisaidPersonalidade.Value = 0;
            // 
            // sp_vip_maladireta
            // 
            this.sp_vip_maladireta._LabelText = "Vip ou mala direta";
            this.sp_vip_maladireta._TamanhoMaiorLabel = 0;
            this.sp_vip_maladireta.BackColor = System.Drawing.Color.Transparent;
            this.sp_vip_maladireta.Location = new System.Drawing.Point(0, 108);
            this.sp_vip_maladireta.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.sp_vip_maladireta.Name = "sp_vip_maladireta";
            this.sp_vip_maladireta.Size = new System.Drawing.Size(543, 18);
            this.sp_vip_maladireta.TabIndex = 7;
            this.sp_vip_maladireta.TabStop = false;
            // 
            // cbxstVip
            // 
            this.cbxstVip._Field = "stVip";
            this.cbxstVip._Help = "Marque esta caixa de seleção se o contato for vip";
            this.cbxstVip._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbxstVip._Itens")));
            this.cbxstVip._LabelGroup = this.sp_vip_maladireta;
            this.cbxstVip._LabelText = "Vip";
            this.cbxstVip._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbxstVip._Regex = null;
            this.cbxstVip._situacao = true;
            this.cbxstVip._Table = "Contato";
            this.cbxstVip._TamanhoComponente = 80;
            this.cbxstVip._TamanhoMaiorLabel = 150;
            this.cbxstVip._Visible = true;
            this.cbxstVip.BackColor = System.Drawing.Color.Transparent;
            this.cbxstVip.Base = null;
            this.cbxstVip.Color = System.Drawing.Color.White;
            this.cbxstVip.DataSource = null;
            this.cbxstVip.DisplayMember = "DisplayMember";
            this.cbxstVip.Location = new System.Drawing.Point(129, 132);
            this.cbxstVip.Margin = new System.Windows.Forms.Padding(129, 3, 15, 3);
            this.cbxstVip.Name = "cbxstVip";
            this.cbxstVip.SelectedIndex = -1;
            this.cbxstVip.SelectedValue = 0;
            this.cbxstVip.Size = new System.Drawing.Size(104, 21);
            this.cbxstVip.TabIndex = 3;
            this.cbxstVip.ValueMember = "ValueMember";
            // 
            // cbxstMalaDireta
            // 
            this.cbxstMalaDireta._Field = "stMalaDireta";
            this.cbxstMalaDireta._Help = "Marque esta caixa de seleção se o contato for receber mala direta";
            this.cbxstMalaDireta._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbxstMalaDireta._Itens")));
            this.cbxstMalaDireta._LabelGroup = this.sp_vip_maladireta;
            this.cbxstMalaDireta._LabelText = "Mala direta";
            this.cbxstMalaDireta._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbxstMalaDireta._Regex = null;
            this.cbxstMalaDireta._situacao = true;
            this.cbxstMalaDireta._Table = "Contato";
            this.cbxstMalaDireta._TamanhoComponente = 80;
            this.cbxstMalaDireta._TamanhoMaiorLabel = 150;
            this.cbxstMalaDireta._Visible = true;
            this.cbxstMalaDireta.BackColor = System.Drawing.Color.Transparent;
            this.cbxstMalaDireta.Base = null;
            this.cbxstMalaDireta.Color = System.Drawing.Color.White;
            this.cbxstMalaDireta.DataSource = null;
            this.cbxstMalaDireta.DisplayMember = "DisplayMember";
            this.cbxstMalaDireta.Location = new System.Drawing.Point(88, 159);
            this.cbxstMalaDireta.Margin = new System.Windows.Forms.Padding(88, 3, 15, 3);
            this.cbxstMalaDireta.Name = "cbxstMalaDireta";
            this.cbxstMalaDireta.SelectedIndex = -1;
            this.cbxstMalaDireta.SelectedValue = 0;
            this.cbxstMalaDireta.Size = new System.Drawing.Size(145, 21);
            this.cbxstMalaDireta.TabIndex = 4;
            this.cbxstMalaDireta.ValueMember = "ValueMember";
            // 
            // sp_outrosConfig
            // 
            this.sp_outrosConfig._LabelText = "Outros";
            this.sp_outrosConfig._TamanhoMaiorLabel = 0;
            this.sp_outrosConfig.BackColor = System.Drawing.Color.Transparent;
            this.sp_outrosConfig.Location = new System.Drawing.Point(0, 186);
            this.sp_outrosConfig.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.sp_outrosConfig.Name = "sp_outrosConfig";
            this.sp_outrosConfig.Size = new System.Drawing.Size(543, 18);
            this.sp_outrosConfig.TabIndex = 8;
            this.sp_outrosConfig.TabStop = false;
            // 
            // txtxMemorando
            // 
            this.txtxMemorando._Field = "xMemorando";
            this.txtxMemorando._Help = "Redija uma anotação interna ou um memorando sobre o contato.";
            this.txtxMemorando._LabelGroup = this.sp_outrosConfig;
            this.txtxMemorando._LabelText = "Memorando";
            this.txtxMemorando._Multiline = false;
            this.txtxMemorando._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxMemorando._Password = false;
            this.txtxMemorando._Regex = null;
            this.txtxMemorando._Table = "Contato";
            this.txtxMemorando._TamanhoComponente = 133;
            this.txtxMemorando._TamanhoMaiorLabel = 150;
            this.txtxMemorando._Visible = true;
            this.txtxMemorando.BackColor = System.Drawing.Color.Transparent;
            this.txtxMemorando.Base = null;
            this.txtxMemorando.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxMemorando.Color = System.Drawing.Color.White;
            this.txtxMemorando.Location = new System.Drawing.Point(83, 210);
            this.txtxMemorando.Margin = new System.Windows.Forms.Padding(83, 3, 15, 3);
            this.txtxMemorando.MaxLength = 32767;
            this.txtxMemorando.Name = "txtxMemorando";
            this.txtxMemorando.ReadOnly = false;
            this.txtxMemorando.Size = new System.Drawing.Size(203, 21);
            this.txtxMemorando.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvEndereco);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(868, 475);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Tag = false;
            this.tabPage2.Text = "Endereço";
            // 
            // dgvEndereco
            // 
            this.dgvEndereco.Altera = false;
            this.dgvEndereco.AutoGenerateColumns = false;
            this.dgvEndereco.cm = null;
            this.dgvEndereco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEndereco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stPrincipal,
            this.xNome,
            this.stTipoEndereco,
            this.xCEP,
            this.idCidade,
            this.stLogradouro,
            this.xEndereco,
            this.xBairro,
            this.xComplemento,
            this.nNumero,
            this.xLatitude,
            this.xLongitude,
            this.xFusoHorario,
            this.xCaixaPostal,
            this.idContato});
            this.dgvEndereco.DataSource = this.bsContatoEndereco;
            this.dgvEndereco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEndereco.DragDropLinha = false;
            this.dgvEndereco.Exclui = false;
            this.dgvEndereco.Inclui = false;
            this.dgvEndereco.Location = new System.Drawing.Point(0, 0);
            this.dgvEndereco.Name = "dgvEndereco";
            this.dgvEndereco.Size = new System.Drawing.Size(868, 475);
            this.dgvEndereco.TabIndex = 0;
            this.dgvEndereco.Tag = "Contato_Endereco";
            // 
            // stPrincipal
            // 
            this.stPrincipal.DataPropertyName = "stPrincipal";
            this.stPrincipal.HeaderText = "Principal";
            this.stPrincipal.Items.AddRange(new object[] {
            "0-NÃO",
            "1-SIM"});
            this.stPrincipal.Name = "stPrincipal";
            this.stPrincipal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stPrincipal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.stPrincipal.ToolTipText = "Se esta caixa de seleção estiver selecionada, o endereço será o endereço principa" +
    "l para o contato";
            this.stPrincipal.Width = 120;
            // 
            // xNome
            // 
            this.xNome.DataPropertyName = "xNome";
            this.xNome.HeaderText = "Nome";
            this.xNome.Name = "xNome";
            this.xNome.ToolTipText = "O nome da organização ou pessoa de contato para o endereço selecionado";
            this.xNome.Width = 150;
            // 
            // stTipoEndereco
            // 
            this.stTipoEndereco.DataPropertyName = "stTipoEndereco";
            this.stTipoEndereco.HeaderText = "Tipo Endereco";
            this.stTipoEndereco.Items.AddRange(new object[] {
            "0-COMERCIAL",
            "1-ENDEREÇO DE REMESSA DE TERCEIROS",
            "2-ENTREGA",
            "3-ENTREGA ALT",
            "4-NOTA FISCAL",
            "5-REMETER-PARA",
            "6-RESIDÊNCIA",
            "7-SERVIÇO",
            "8-SWIFT",
            "PAGAMENTO",
            "9-OUTRO"});
            this.stTipoEndereco.Name = "stTipoEndereco";
            this.stTipoEndereco.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stTipoEndereco.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.stTipoEndereco.ToolTipText = "Especifique como usar o endereço selecionado";
            this.stTipoEndereco.Width = 150;
            // 
            // xCEP
            // 
            this.xCEP.DataPropertyName = "xCEP";
            this.xCEP.HeaderText = "CEP";
            this.xCEP.Mask = "00000-000";
            this.xCEP.Name = "xCEP";
            this.xCEP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xCEP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.xCEP.ToolTipText = "Informar o Código de Endereçamento Postal principal do contato para o endereço";
            this.xCEP.Width = 100;
            // 
            // idCidade
            // 
            this.idCidade.DataPropertyName = "idCidade";
            this.idCidade.HeaderText = "Cidade";
            this.idCidade.Name = "idCidade";
            this.idCidade.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idCidade.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idCidade.ToolTipText = "Informara Cidade";
            this.idCidade.Width = 150;
            // 
            // stLogradouro
            // 
            this.stLogradouro.DataPropertyName = "stLogradouro";
            this.stLogradouro.HeaderText = "Logradouro";
            this.stLogradouro.Items.AddRange(new object[] {
            "00-AER   - AEROPORTO",
            "01-AL - ALAMEDA ",
            "02-AP - APARTAMENTO ",
            "03-AV - AVENIDA ",
            "04-BC - BECO ",
            "05-BL - BLOCO ",
            "06-CAM - CAMINHO ",
            "07-ESCD - ESCADINHA ",
            "08-EST  - ESTAÇÃO ",
            "09-ETR - ESTRADA ",
            "10-FAZ - FAZENDA ",
            "11-FORT  - FORTALEZA ",
            "12-GL - GALERIA ",
            "13-LD - LADEIRA ",
            "14-LGO  - LARGO ",
            "15-PÇA - PRAÇA ",
            "16-PR  - PRAIA ",
            "17-PRQ - PARQUE ",
            "18-QD  - QUADRA ",
            "19-KM - QUILÔMETRO ",
            "20-QTA  - QUINTA ",
            "21-ROD  - RODOVIA ",
            "22-R - RUA ",
            "23-SQD - SUPER QUADRA ",
            "24-TRV - TRAVESSA "});
            this.stLogradouro.Name = "stLogradouro";
            this.stLogradouro.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stLogradouro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.stLogradouro.ToolTipText = "Informar o Tipo de Logradouro para o endereço correspondente";
            this.stLogradouro.Width = 200;
            // 
            // xEndereco
            // 
            this.xEndereco.DataPropertyName = "xEndereco";
            this.xEndereco.HeaderText = "Endereco";
            this.xEndereco.Name = "xEndereco";
            this.xEndereco.ToolTipText = "Informar o Endereço do contato";
            this.xEndereco.Width = 200;
            // 
            // xBairro
            // 
            this.xBairro.DataPropertyName = "xBairro";
            this.xBairro.HeaderText = "Bairro";
            this.xBairro.Name = "xBairro";
            this.xBairro.ToolTipText = "Informar o barirro do contato";
            this.xBairro.Width = 150;
            // 
            // xComplemento
            // 
            this.xComplemento.DataPropertyName = "xComplemento";
            this.xComplemento.HeaderText = "Complemento";
            this.xComplemento.Name = "xComplemento";
            this.xComplemento.ToolTipText = "Informar o complemento do contato";
            this.xComplemento.Width = 150;
            // 
            // nNumero
            // 
            this.nNumero.DataPropertyName = "nNumero";
            this.nNumero.HeaderText = "Numero";
            this.nNumero.Name = "nNumero";
            this.nNumero.ToolTipText = "Informar o numero";
            this.nNumero.Width = 60;
            // 
            // xLatitude
            // 
            this.xLatitude.DataPropertyName = "xLatitude";
            this.xLatitude.HeaderText = "Latitude";
            this.xLatitude.Name = "xLatitude";
            // 
            // xLongitude
            // 
            this.xLongitude.DataPropertyName = "xLongitude";
            this.xLongitude.HeaderText = "Longitude";
            this.xLongitude.Name = "xLongitude";
            // 
            // xFusoHorario
            // 
            this.xFusoHorario.DataPropertyName = "xFusoHorario";
            this.xFusoHorario.HeaderText = "Fuso horario";
            this.xFusoHorario.Name = "xFusoHorario";
            // 
            // xCaixaPostal
            // 
            this.xCaixaPostal.DataPropertyName = "xCaixaPostal";
            this.xCaixaPostal.HeaderText = "Caixa postal";
            this.xCaixaPostal.Name = "xCaixaPostal";
            // 
            // idContato
            // 
            this.idContato.DataPropertyName = "idContato";
            this.idContato.HeaderText = "Contato";
            this.idContato.Name = "idContato";
            this.idContato.Visible = false;
            // 
            // bsContatoEndereco
            // 
            this.bsContatoEndereco.DataSource = typeof(HLP.Models.Entries.Gerais.Contato_EnderecoModel);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.kryptonPanel5);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(868, 475);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Tag = false;
            this.tabPage4.Text = "Contato";
            // 
            // kryptonPanel5
            // 
            this.kryptonPanel5.Controls.Add(this.flowLayoutPanel3);
            this.kryptonPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel5.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel5.Name = "kryptonPanel5";
            this.kryptonPanel5.Size = new System.Drawing.Size(868, 475);
            this.kryptonPanel5.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel3.Controls.Add(this.sp_Comercial);
            this.flowLayoutPanel3.Controls.Add(this.mskxTelefoneComercial);
            this.flowLayoutPanel3.Controls.Add(this.txtxRamalComercial);
            this.flowLayoutPanel3.Controls.Add(this.mskxCelularComercial);
            this.flowLayoutPanel3.Controls.Add(this.txtxRadioFoneComercial);
            this.flowLayoutPanel3.Controls.Add(this.txtxPagerComercial);
            this.flowLayoutPanel3.Controls.Add(this.mskxFaxComercial);
            this.flowLayoutPanel3.Controls.Add(this.txtxEmailComercial);
            this.flowLayoutPanel3.Controls.Add(this.txtxSkypeComercial);
            this.flowLayoutPanel3.Controls.Add(this.txtxMSNComercial);
            this.flowLayoutPanel3.Controls.Add(this.txtxhttpComercial);
            this.flowLayoutPanel3.Controls.Add(this.sp_Residencial);
            this.flowLayoutPanel3.Controls.Add(this.mskxTelefoneResidencial);
            this.flowLayoutPanel3.Controls.Add(this.mskxCelularResidencial);
            this.flowLayoutPanel3.Controls.Add(this.txtxRadioFoneResidencial);
            this.flowLayoutPanel3.Controls.Add(this.txtxEmailResidencial);
            this.flowLayoutPanel3.Controls.Add(this.txtxSkypeResidencial);
            this.flowLayoutPanel3.Controls.Add(this.txtxMsnResidencial);
            this.flowLayoutPanel3.Controls.Add(this.txtXhttpPessoal);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(868, 475);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // sp_Comercial
            // 
            this.sp_Comercial._LabelText = "Comercial";
            this.sp_Comercial._TamanhoMaiorLabel = 0;
            this.sp_Comercial.BackColor = System.Drawing.Color.Transparent;
            this.sp_Comercial.Location = new System.Drawing.Point(0, 3);
            this.sp_Comercial.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.sp_Comercial.Name = "sp_Comercial";
            this.sp_Comercial.Size = new System.Drawing.Size(425, 18);
            this.sp_Comercial.TabIndex = 10;
            this.sp_Comercial.TabStop = false;
            // 
            // mskxTelefoneComercial
            // 
            this.mskxTelefoneComercial._Field = "xTelefoneComercial";
            this.mskxTelefoneComercial._Help = "Insira o número do telefone comercial do contato.";
            this.mskxTelefoneComercial._LabelGroup = this.sp_Comercial;
            this.mskxTelefoneComercial._LabelText = "Telefone";
            this.mskxTelefoneComercial._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.mskxTelefoneComercial._Regex = null;
            this.mskxTelefoneComercial._Table = "Contato";
            this.mskxTelefoneComercial._TamanhoComponente = 123;
            this.mskxTelefoneComercial._TamanhoMaiorLabel = 150;
            this.mskxTelefoneComercial._TpValidacao = HLP.Comum.Components.HLP_MaskedTextBox.TipoValidacao.DEFAULT;
            this.mskxTelefoneComercial._UF = null;
            this.mskxTelefoneComercial._Visible = true;
            this.mskxTelefoneComercial.BackColor = System.Drawing.Color.Transparent;
            this.mskxTelefoneComercial.Base = null;
            this.mskxTelefoneComercial.Color = System.Drawing.Color.White;
            this.mskxTelefoneComercial.Location = new System.Drawing.Point(102, 27);
            this.mskxTelefoneComercial.Margin = new System.Windows.Forms.Padding(102, 3, 15, 3);
            this.mskxTelefoneComercial.Mask = "(000)0000-0000";
            this.mskxTelefoneComercial.MaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mskxTelefoneComercial.MaxLength = 32767;
            this.mskxTelefoneComercial.Name = "mskxTelefoneComercial";
            this.mskxTelefoneComercial.ReadOnly = false;
            this.mskxTelefoneComercial.Size = new System.Drawing.Size(174, 21);
            this.mskxTelefoneComercial.TabIndex = 0;
            // 
            // txtxRamalComercial
            // 
            this.txtxRamalComercial._Field = "xRamalComercial";
            this.txtxRamalComercial._Help = "Insira o número do ramal do contato.";
            this.txtxRamalComercial._LabelGroup = this.sp_Comercial;
            this.txtxRamalComercial._LabelText = "Ramal";
            this.txtxRamalComercial._Multiline = false;
            this.txtxRamalComercial._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxRamalComercial._Password = false;
            this.txtxRamalComercial._Regex = null;
            this.txtxRamalComercial._Table = "Contato";
            this.txtxRamalComercial._TamanhoComponente = 134;
            this.txtxRamalComercial._TamanhoMaiorLabel = 150;
            this.txtxRamalComercial._Visible = true;
            this.txtxRamalComercial.BackColor = System.Drawing.Color.Transparent;
            this.txtxRamalComercial.Base = null;
            this.txtxRamalComercial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxRamalComercial.Color = System.Drawing.Color.White;
            this.txtxRamalComercial.Location = new System.Drawing.Point(115, 54);
            this.txtxRamalComercial.Margin = new System.Windows.Forms.Padding(115, 3, 15, 3);
            this.txtxRamalComercial.MaxLength = 32767;
            this.txtxRamalComercial.Name = "txtxRamalComercial";
            this.txtxRamalComercial.ReadOnly = false;
            this.txtxRamalComercial.Size = new System.Drawing.Size(172, 21);
            this.txtxRamalComercial.TabIndex = 20;
            // 
            // mskxCelularComercial
            // 
            this.mskxCelularComercial._Field = "xCelularComercial";
            this.mskxCelularComercial._Help = "Insira o número do celular do contato";
            this.mskxCelularComercial._LabelGroup = this.sp_Comercial;
            this.mskxCelularComercial._LabelText = "Celular";
            this.mskxCelularComercial._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.mskxCelularComercial._Regex = null;
            this.mskxCelularComercial._Table = "Contato";
            this.mskxCelularComercial._TamanhoComponente = 123;
            this.mskxCelularComercial._TamanhoMaiorLabel = 150;
            this.mskxCelularComercial._TpValidacao = HLP.Comum.Components.HLP_MaskedTextBox.TipoValidacao.DEFAULT;
            this.mskxCelularComercial._UF = null;
            this.mskxCelularComercial._Visible = true;
            this.mskxCelularComercial.BackColor = System.Drawing.Color.Transparent;
            this.mskxCelularComercial.Base = null;
            this.mskxCelularComercial.Color = System.Drawing.Color.White;
            this.mskxCelularComercial.Location = new System.Drawing.Point(110, 81);
            this.mskxCelularComercial.Margin = new System.Windows.Forms.Padding(110, 3, 15, 3);
            this.mskxCelularComercial.Mask = "(000)0000-0000";
            this.mskxCelularComercial.MaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mskxCelularComercial.MaxLength = 32767;
            this.mskxCelularComercial.Name = "mskxCelularComercial";
            this.mskxCelularComercial.ReadOnly = false;
            this.mskxCelularComercial.Size = new System.Drawing.Size(166, 21);
            this.mskxCelularComercial.TabIndex = 2;
            // 
            // txtxRadioFoneComercial
            // 
            this.txtxRadioFoneComercial._Field = "xRadioFoneComercial";
            this.txtxRadioFoneComercial._Help = "Insira o número do radio do contato";
            this.txtxRadioFoneComercial._LabelGroup = this.sp_Comercial;
            this.txtxRadioFoneComercial._LabelText = "Radio";
            this.txtxRadioFoneComercial._Multiline = false;
            this.txtxRadioFoneComercial._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxRadioFoneComercial._Password = false;
            this.txtxRadioFoneComercial._Regex = null;
            this.txtxRadioFoneComercial._Table = "Contato";
            this.txtxRadioFoneComercial._TamanhoComponente = 133;
            this.txtxRadioFoneComercial._TamanhoMaiorLabel = 150;
            this.txtxRadioFoneComercial._Visible = true;
            this.txtxRadioFoneComercial.BackColor = System.Drawing.Color.Transparent;
            this.txtxRadioFoneComercial.Base = null;
            this.txtxRadioFoneComercial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxRadioFoneComercial.Color = System.Drawing.Color.White;
            this.txtxRadioFoneComercial.Location = new System.Drawing.Point(116, 108);
            this.txtxRadioFoneComercial.Margin = new System.Windows.Forms.Padding(116, 3, 15, 3);
            this.txtxRadioFoneComercial.MaxLength = 32767;
            this.txtxRadioFoneComercial.Name = "txtxRadioFoneComercial";
            this.txtxRadioFoneComercial.ReadOnly = false;
            this.txtxRadioFoneComercial.Size = new System.Drawing.Size(170, 21);
            this.txtxRadioFoneComercial.TabIndex = 3;
            // 
            // txtxPagerComercial
            // 
            this.txtxPagerComercial._Field = "xPagerComercial";
            this.txtxPagerComercial._Help = "Insira o número do pager do contato.";
            this.txtxPagerComercial._LabelGroup = this.sp_Comercial;
            this.txtxPagerComercial._LabelText = "Pager";
            this.txtxPagerComercial._Multiline = false;
            this.txtxPagerComercial._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxPagerComercial._Password = false;
            this.txtxPagerComercial._Regex = null;
            this.txtxPagerComercial._Table = "Contato";
            this.txtxPagerComercial._TamanhoComponente = 134;
            this.txtxPagerComercial._TamanhoMaiorLabel = 150;
            this.txtxPagerComercial._Visible = true;
            this.txtxPagerComercial.BackColor = System.Drawing.Color.Transparent;
            this.txtxPagerComercial.Base = null;
            this.txtxPagerComercial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxPagerComercial.Color = System.Drawing.Color.White;
            this.txtxPagerComercial.Location = new System.Drawing.Point(117, 135);
            this.txtxPagerComercial.Margin = new System.Windows.Forms.Padding(117, 3, 15, 3);
            this.txtxPagerComercial.MaxLength = 32767;
            this.txtxPagerComercial.Name = "txtxPagerComercial";
            this.txtxPagerComercial.ReadOnly = false;
            this.txtxPagerComercial.Size = new System.Drawing.Size(170, 21);
            this.txtxPagerComercial.TabIndex = 4;
            // 
            // mskxFaxComercial
            // 
            this.mskxFaxComercial._Field = "xFaxComercial";
            this.mskxFaxComercial._Help = "Insira o número do fax do contato";
            this.mskxFaxComercial._LabelGroup = this.sp_Comercial;
            this.mskxFaxComercial._LabelText = "Fax";
            this.mskxFaxComercial._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.mskxFaxComercial._Regex = null;
            this.mskxFaxComercial._Table = "Contato";
            this.mskxFaxComercial._TamanhoComponente = 124;
            this.mskxFaxComercial._TamanhoMaiorLabel = 150;
            this.mskxFaxComercial._TpValidacao = HLP.Comum.Components.HLP_MaskedTextBox.TipoValidacao.DEFAULT;
            this.mskxFaxComercial._UF = null;
            this.mskxFaxComercial._Visible = true;
            this.mskxFaxComercial.BackColor = System.Drawing.Color.Transparent;
            this.mskxFaxComercial.Base = null;
            this.mskxFaxComercial.Color = System.Drawing.Color.White;
            this.mskxFaxComercial.Location = new System.Drawing.Point(129, 162);
            this.mskxFaxComercial.Margin = new System.Windows.Forms.Padding(129, 3, 15, 3);
            this.mskxFaxComercial.Mask = "(000)0000-0000";
            this.mskxFaxComercial.MaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mskxFaxComercial.MaxLength = 32767;
            this.mskxFaxComercial.Name = "mskxFaxComercial";
            this.mskxFaxComercial.ReadOnly = false;
            this.mskxFaxComercial.Size = new System.Drawing.Size(148, 21);
            this.mskxFaxComercial.TabIndex = 21;
            // 
            // txtxEmailComercial
            // 
            this.txtxEmailComercial._Field = "xEmailComercial";
            this.txtxEmailComercial._Help = "Insira o e-mail do contato.";
            this.txtxEmailComercial._LabelGroup = this.sp_Comercial;
            this.txtxEmailComercial._LabelText = "E-mail";
            this.txtxEmailComercial._Multiline = false;
            this.txtxEmailComercial._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxEmailComercial._Password = false;
            this.txtxEmailComercial._Regex = "^\\w+([-+.\']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$";
            this.txtxEmailComercial._Table = "Contato";
            this.txtxEmailComercial._TamanhoComponente = 269;
            this.txtxEmailComercial._TamanhoMaiorLabel = 150;
            this.txtxEmailComercial._Visible = true;
            this.txtxEmailComercial.BackColor = System.Drawing.Color.Transparent;
            this.txtxEmailComercial.Base = null;
            this.txtxEmailComercial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxEmailComercial.Color = System.Drawing.Color.White;
            this.txtxEmailComercial.Location = new System.Drawing.Point(115, 189);
            this.txtxEmailComercial.Margin = new System.Windows.Forms.Padding(115, 3, 15, 3);
            this.txtxEmailComercial.MaxLength = 32767;
            this.txtxEmailComercial.Name = "txtxEmailComercial";
            this.txtxEmailComercial.ReadOnly = false;
            this.txtxEmailComercial.Size = new System.Drawing.Size(307, 21);
            this.txtxEmailComercial.TabIndex = 6;
            // 
            // txtxSkypeComercial
            // 
            this.txtxSkypeComercial._Field = "xSkypeComercial";
            this.txtxSkypeComercial._Help = "Insira o skype do contato";
            this.txtxSkypeComercial._LabelGroup = this.sp_Comercial;
            this.txtxSkypeComercial._LabelText = "Skype";
            this.txtxSkypeComercial._Multiline = false;
            this.txtxSkypeComercial._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxSkypeComercial._Password = false;
            this.txtxSkypeComercial._Regex = null;
            this.txtxSkypeComercial._Table = "Contato";
            this.txtxSkypeComercial._TamanhoComponente = 269;
            this.txtxSkypeComercial._TamanhoMaiorLabel = 150;
            this.txtxSkypeComercial._Visible = true;
            this.txtxSkypeComercial.BackColor = System.Drawing.Color.Transparent;
            this.txtxSkypeComercial.Base = null;
            this.txtxSkypeComercial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxSkypeComercial.Color = System.Drawing.Color.White;
            this.txtxSkypeComercial.Location = new System.Drawing.Point(116, 216);
            this.txtxSkypeComercial.Margin = new System.Windows.Forms.Padding(116, 3, 15, 3);
            this.txtxSkypeComercial.MaxLength = 32767;
            this.txtxSkypeComercial.Name = "txtxSkypeComercial";
            this.txtxSkypeComercial.ReadOnly = false;
            this.txtxSkypeComercial.Size = new System.Drawing.Size(306, 21);
            this.txtxSkypeComercial.TabIndex = 7;
            // 
            // txtxMSNComercial
            // 
            this.txtxMSNComercial._Field = "xMSNComercial";
            this.txtxMSNComercial._Help = "Insira o msn do contato";
            this.txtxMSNComercial._LabelGroup = this.sp_Comercial;
            this.txtxMSNComercial._LabelText = "Msn";
            this.txtxMSNComercial._Multiline = false;
            this.txtxMSNComercial._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxMSNComercial._Password = false;
            this.txtxMSNComercial._Regex = "^\\w+([-+.\']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$";
            this.txtxMSNComercial._Table = "Contato";
            this.txtxMSNComercial._TamanhoComponente = 272;
            this.txtxMSNComercial._TamanhoMaiorLabel = 150;
            this.txtxMSNComercial._Visible = true;
            this.txtxMSNComercial.BackColor = System.Drawing.Color.Transparent;
            this.txtxMSNComercial.Base = null;
            this.txtxMSNComercial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxMSNComercial.Color = System.Drawing.Color.White;
            this.txtxMSNComercial.Location = new System.Drawing.Point(124, 243);
            this.txtxMSNComercial.Margin = new System.Windows.Forms.Padding(124, 3, 15, 3);
            this.txtxMSNComercial.MaxLength = 32767;
            this.txtxMSNComercial.Name = "txtxMSNComercial";
            this.txtxMSNComercial.ReadOnly = false;
            this.txtxMSNComercial.Size = new System.Drawing.Size(301, 21);
            this.txtxMSNComercial.TabIndex = 8;
            // 
            // txtxhttpComercial
            // 
            this.txtxhttpComercial._Field = "xhttpComercial";
            this.txtxhttpComercial._Help = "Insira o endereço do site do contato";
            this.txtxhttpComercial._LabelGroup = this.sp_Comercial;
            this.txtxhttpComercial._LabelText = "Endereço na internet";
            this.txtxhttpComercial._Multiline = false;
            this.txtxhttpComercial._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxhttpComercial._Password = false;
            this.txtxhttpComercial._Regex = null;
            this.txtxhttpComercial._Table = "Contato";
            this.txtxhttpComercial._TamanhoComponente = 265;
            this.txtxhttpComercial._TamanhoMaiorLabel = 150;
            this.txtxhttpComercial._Visible = true;
            this.txtxhttpComercial.BackColor = System.Drawing.Color.Transparent;
            this.txtxhttpComercial.Base = null;
            this.txtxhttpComercial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxhttpComercial.Color = System.Drawing.Color.White;
            this.txtxhttpComercial.Location = new System.Drawing.Point(38, 270);
            this.txtxhttpComercial.Margin = new System.Windows.Forms.Padding(38, 3, 15, 3);
            this.txtxhttpComercial.MaxLength = 32767;
            this.txtxhttpComercial.Name = "txtxhttpComercial";
            this.txtxhttpComercial.ReadOnly = false;
            this.txtxhttpComercial.Size = new System.Drawing.Size(380, 21);
            this.txtxhttpComercial.TabIndex = 9;
            // 
            // sp_Residencial
            // 
            this.sp_Residencial._LabelText = "Residencial";
            this.sp_Residencial._TamanhoMaiorLabel = 0;
            this.sp_Residencial.BackColor = System.Drawing.Color.Transparent;
            this.sp_Residencial.Location = new System.Drawing.Point(0, 297);
            this.sp_Residencial.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.sp_Residencial.Name = "sp_Residencial";
            this.sp_Residencial.Size = new System.Drawing.Size(425, 18);
            this.sp_Residencial.TabIndex = 11;
            this.sp_Residencial.TabStop = false;
            // 
            // mskxTelefoneResidencial
            // 
            this.mskxTelefoneResidencial._Field = "xTelefoneResidencial";
            this.mskxTelefoneResidencial._Help = "Insira o número do telefone particular do contato, caso possua.";
            this.mskxTelefoneResidencial._LabelGroup = this.sp_Residencial;
            this.mskxTelefoneResidencial._LabelText = "Telefone resid.";
            this.mskxTelefoneResidencial._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.mskxTelefoneResidencial._Regex = null;
            this.mskxTelefoneResidencial._Table = "Contato";
            this.mskxTelefoneResidencial._TamanhoComponente = 122;
            this.mskxTelefoneResidencial._TamanhoMaiorLabel = 150;
            this.mskxTelefoneResidencial._TpValidacao = HLP.Comum.Components.HLP_MaskedTextBox.TipoValidacao.DEFAULT;
            this.mskxTelefoneResidencial._UF = null;
            this.mskxTelefoneResidencial._Visible = true;
            this.mskxTelefoneResidencial.BackColor = System.Drawing.Color.Transparent;
            this.mskxTelefoneResidencial.Base = null;
            this.mskxTelefoneResidencial.Color = System.Drawing.Color.White;
            this.mskxTelefoneResidencial.Location = new System.Drawing.Point(71, 321);
            this.mskxTelefoneResidencial.Margin = new System.Windows.Forms.Padding(71, 3, 15, 3);
            this.mskxTelefoneResidencial.Mask = "(000)0000-0000";
            this.mskxTelefoneResidencial.MaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mskxTelefoneResidencial.MaxLength = 32767;
            this.mskxTelefoneResidencial.Name = "mskxTelefoneResidencial";
            this.mskxTelefoneResidencial.ReadOnly = false;
            this.mskxTelefoneResidencial.Size = new System.Drawing.Size(204, 21);
            this.mskxTelefoneResidencial.TabIndex = 12;
            // 
            // mskxCelularResidencial
            // 
            this.mskxCelularResidencial._Field = "xCelularResidencial";
            this.mskxCelularResidencial._Help = "Insira o número do celular particular do contato, caso possua";
            this.mskxCelularResidencial._LabelGroup = this.sp_Residencial;
            this.mskxCelularResidencial._LabelText = "Celular resid.";
            this.mskxCelularResidencial._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.mskxCelularResidencial._Regex = null;
            this.mskxCelularResidencial._Table = "Contato";
            this.mskxCelularResidencial._TamanhoComponente = 121;
            this.mskxCelularResidencial._TamanhoMaiorLabel = 150;
            this.mskxCelularResidencial._TpValidacao = HLP.Comum.Components.HLP_MaskedTextBox.TipoValidacao.DEFAULT;
            this.mskxCelularResidencial._UF = null;
            this.mskxCelularResidencial._Visible = true;
            this.mskxCelularResidencial.BackColor = System.Drawing.Color.Transparent;
            this.mskxCelularResidencial.Base = null;
            this.mskxCelularResidencial.Color = System.Drawing.Color.White;
            this.mskxCelularResidencial.Location = new System.Drawing.Point(79, 348);
            this.mskxCelularResidencial.Margin = new System.Windows.Forms.Padding(79, 3, 15, 3);
            this.mskxCelularResidencial.Mask = "(000)0000-0000";
            this.mskxCelularResidencial.MaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mskxCelularResidencial.MaxLength = 32767;
            this.mskxCelularResidencial.Name = "mskxCelularResidencial";
            this.mskxCelularResidencial.ReadOnly = false;
            this.mskxCelularResidencial.Size = new System.Drawing.Size(195, 21);
            this.mskxCelularResidencial.TabIndex = 14;
            // 
            // txtxRadioFoneResidencial
            // 
            this.txtxRadioFoneResidencial._Field = "xRadioFoneComercial";
            this.txtxRadioFoneResidencial._Help = "Insira o endereço do radio  pessoal do contato, caso possua.";
            this.txtxRadioFoneResidencial._LabelGroup = this.sp_Residencial;
            this.txtxRadioFoneResidencial._LabelText = "Radio resid.";
            this.txtxRadioFoneResidencial._Multiline = false;
            this.txtxRadioFoneResidencial._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxRadioFoneResidencial._Password = false;
            this.txtxRadioFoneResidencial._Regex = null;
            this.txtxRadioFoneResidencial._Table = "Contato";
            this.txtxRadioFoneResidencial._TamanhoComponente = 131;
            this.txtxRadioFoneResidencial._TamanhoMaiorLabel = 150;
            this.txtxRadioFoneResidencial._Visible = true;
            this.txtxRadioFoneResidencial.BackColor = System.Drawing.Color.Transparent;
            this.txtxRadioFoneResidencial.Base = null;
            this.txtxRadioFoneResidencial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxRadioFoneResidencial.Color = System.Drawing.Color.White;
            this.txtxRadioFoneResidencial.Location = new System.Drawing.Point(85, 375);
            this.txtxRadioFoneResidencial.Margin = new System.Windows.Forms.Padding(85, 3, 15, 3);
            this.txtxRadioFoneResidencial.MaxLength = 32767;
            this.txtxRadioFoneResidencial.Name = "txtxRadioFoneResidencial";
            this.txtxRadioFoneResidencial.ReadOnly = false;
            this.txtxRadioFoneResidencial.Size = new System.Drawing.Size(199, 21);
            this.txtxRadioFoneResidencial.TabIndex = 15;
            // 
            // txtxEmailResidencial
            // 
            this.txtxEmailResidencial._Field = "xEmailResidencial";
            this.txtxEmailResidencial._Help = "Insira o e-mail particular do contato, caso possua.";
            this.txtxEmailResidencial._LabelGroup = this.sp_Residencial;
            this.txtxEmailResidencial._LabelText = "E-mail resid.";
            this.txtxEmailResidencial._Multiline = false;
            this.txtxEmailResidencial._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxEmailResidencial._Password = false;
            this.txtxEmailResidencial._Regex = "^\\w+([-+.\']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$";
            this.txtxEmailResidencial._Table = "Contato";
            this.txtxEmailResidencial._TamanhoComponente = 268;
            this.txtxEmailResidencial._TamanhoMaiorLabel = 150;
            this.txtxEmailResidencial._Visible = true;
            this.txtxEmailResidencial.BackColor = System.Drawing.Color.Transparent;
            this.txtxEmailResidencial.Base = null;
            this.txtxEmailResidencial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxEmailResidencial.Color = System.Drawing.Color.White;
            this.txtxEmailResidencial.Location = new System.Drawing.Point(84, 402);
            this.txtxEmailResidencial.Margin = new System.Windows.Forms.Padding(84, 3, 15, 3);
            this.txtxEmailResidencial.MaxLength = 32767;
            this.txtxEmailResidencial.Name = "txtxEmailResidencial";
            this.txtxEmailResidencial.ReadOnly = false;
            this.txtxEmailResidencial.Size = new System.Drawing.Size(337, 21);
            this.txtxEmailResidencial.TabIndex = 19;
            // 
            // txtxSkypeResidencial
            // 
            this.txtxSkypeResidencial._Field = "xSkypeResidencial";
            this.txtxSkypeResidencial._Help = "Insira o skype particular do contato, caso possua.";
            this.txtxSkypeResidencial._LabelGroup = this.sp_Residencial;
            this.txtxSkypeResidencial._LabelText = "Skype resid.";
            this.txtxSkypeResidencial._Multiline = false;
            this.txtxSkypeResidencial._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxSkypeResidencial._Password = false;
            this.txtxSkypeResidencial._Regex = null;
            this.txtxSkypeResidencial._Table = "Contato";
            this.txtxSkypeResidencial._TamanhoComponente = 268;
            this.txtxSkypeResidencial._TamanhoMaiorLabel = 150;
            this.txtxSkypeResidencial._Visible = true;
            this.txtxSkypeResidencial.BackColor = System.Drawing.Color.Transparent;
            this.txtxSkypeResidencial.Base = null;
            this.txtxSkypeResidencial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxSkypeResidencial.Color = System.Drawing.Color.White;
            this.txtxSkypeResidencial.Location = new System.Drawing.Point(85, 429);
            this.txtxSkypeResidencial.Margin = new System.Windows.Forms.Padding(85, 3, 15, 3);
            this.txtxSkypeResidencial.MaxLength = 32767;
            this.txtxSkypeResidencial.Name = "txtxSkypeResidencial";
            this.txtxSkypeResidencial.ReadOnly = false;
            this.txtxSkypeResidencial.Size = new System.Drawing.Size(336, 21);
            this.txtxSkypeResidencial.TabIndex = 16;
            // 
            // txtxMsnResidencial
            // 
            this.txtxMsnResidencial._Field = "xMsnResidencial";
            this.txtxMsnResidencial._Help = "Insira o msn particular do contato, caso possua.";
            this.txtxMsnResidencial._LabelGroup = this.sp_Residencial;
            this.txtxMsnResidencial._LabelText = "Msn resid.";
            this.txtxMsnResidencial._Multiline = false;
            this.txtxMsnResidencial._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxMsnResidencial._Password = false;
            this.txtxMsnResidencial._Regex = "^\\w+([-+.\']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$";
            this.txtxMsnResidencial._Table = "Contato";
            this.txtxMsnResidencial._TamanhoComponente = 270;
            this.txtxMsnResidencial._TamanhoMaiorLabel = 150;
            this.txtxMsnResidencial._Visible = true;
            this.txtxMsnResidencial.BackColor = System.Drawing.Color.Transparent;
            this.txtxMsnResidencial.Base = null;
            this.txtxMsnResidencial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxMsnResidencial.Color = System.Drawing.Color.White;
            this.txtxMsnResidencial.Location = new System.Drawing.Point(533, 3);
            this.txtxMsnResidencial.Margin = new System.Windows.Forms.Padding(93, 3, 15, 3);
            this.txtxMsnResidencial.MaxLength = 32767;
            this.txtxMsnResidencial.Name = "txtxMsnResidencial";
            this.txtxMsnResidencial.ReadOnly = false;
            this.txtxMsnResidencial.Size = new System.Drawing.Size(330, 21);
            this.txtxMsnResidencial.TabIndex = 17;
            // 
            // txtXhttpPessoal
            // 
            this.txtXhttpPessoal._Field = "XhttpPessoal";
            this.txtXhttpPessoal._Help = "Insira o endereço de internet  pessoal do contato, caso possua";
            this.txtXhttpPessoal._LabelGroup = this.sp_Residencial;
            this.txtXhttpPessoal._LabelText = "Endereço na internet resid.";
            this.txtXhttpPessoal._Multiline = false;
            this.txtXhttpPessoal._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtXhttpPessoal._Password = false;
            this.txtXhttpPessoal._Regex = null;
            this.txtXhttpPessoal._Table = "Contato";
            this.txtXhttpPessoal._TamanhoComponente = 264;
            this.txtXhttpPessoal._TamanhoMaiorLabel = 150;
            this.txtXhttpPessoal._Visible = true;
            this.txtXhttpPessoal.BackColor = System.Drawing.Color.Transparent;
            this.txtXhttpPessoal.Base = null;
            this.txtXhttpPessoal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtXhttpPessoal.Color = System.Drawing.Color.White;
            this.txtXhttpPessoal.Location = new System.Drawing.Point(447, 30);
            this.txtXhttpPessoal.Margin = new System.Windows.Forms.Padding(7, 3, 15, 3);
            this.txtXhttpPessoal.MaxLength = 32767;
            this.txtXhttpPessoal.Name = "txtXhttpPessoal";
            this.txtXhttpPessoal.ReadOnly = false;
            this.txtXhttpPessoal.Size = new System.Drawing.Size(410, 21);
            this.txtXhttpPessoal.TabIndex = 18;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.kryptonPanel6);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(868, 475);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Tag = false;
            this.tabPage5.Text = "Pessoal";
            // 
            // kryptonPanel6
            // 
            this.kryptonPanel6.Controls.Add(this.flowLayoutPanel4);
            this.kryptonPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel6.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel6.Name = "kryptonPanel6";
            this.kryptonPanel6.Size = new System.Drawing.Size(868, 475);
            this.kryptonPanel6.TabIndex = 0;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel4.Controls.Add(this.sp_Familia);
            this.flowLayoutPanel4.Controls.Add(this.txtxFilhos);
            this.flowLayoutPanel4.Controls.Add(this.dtdDataAniversario);
            this.flowLayoutPanel4.Controls.Add(this.txtxConjuge);
            this.flowLayoutPanel4.Controls.Add(this.cbxstEstadoCivil);
            this.flowLayoutPanel4.Controls.Add(this.sp_Hobbies);
            this.flowLayoutPanel4.Controls.Add(this.txtxHobbies);
            this.flowLayoutPanel4.Controls.Add(this.sp_Empresa);
            this.flowLayoutPanel4.Controls.Add(this.dtdAniversarioTempoServico);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(868, 475);
            this.flowLayoutPanel4.TabIndex = 0;
            // 
            // sp_Familia
            // 
            this.sp_Familia._LabelText = "Familia";
            this.sp_Familia._TamanhoMaiorLabel = 0;
            this.sp_Familia.BackColor = System.Drawing.Color.Transparent;
            this.sp_Familia.Location = new System.Drawing.Point(0, 3);
            this.sp_Familia.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.sp_Familia.Name = "sp_Familia";
            this.sp_Familia.Size = new System.Drawing.Size(48, 18);
            this.sp_Familia.TabIndex = 6;
            this.sp_Familia.TabStop = false;
            // 
            // txtxFilhos
            // 
            this.txtxFilhos._Field = "xFilhos";
            this.txtxFilhos._Help = "Insira o nome dos filhos do contato";
            this.txtxFilhos._LabelGroup = this.sp_Familia;
            this.txtxFilhos._LabelText = "Filhos";
            this.txtxFilhos._Multiline = false;
            this.txtxFilhos._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxFilhos._Password = false;
            this.txtxFilhos._Regex = null;
            this.txtxFilhos._Table = "Contato";
            this.txtxFilhos._TamanhoComponente = 346;
            this.txtxFilhos._TamanhoMaiorLabel = 0;
            this.txtxFilhos._Visible = true;
            this.txtxFilhos.BackColor = System.Drawing.Color.Transparent;
            this.txtxFilhos.Base = null;
            this.txtxFilhos.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxFilhos.Color = System.Drawing.Color.White;
            this.txtxFilhos.Location = new System.Drawing.Point(3, 27);
            this.txtxFilhos.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.txtxFilhos.MaxLength = 32767;
            this.txtxFilhos.Name = "txtxFilhos";
            this.txtxFilhos.ReadOnly = false;
            this.txtxFilhos.Size = new System.Drawing.Size(384, 21);
            this.txtxFilhos.TabIndex = 0;
            // 
            // dtdDataAniversario
            // 
            this.dtdDataAniversario._Field = "dAniversario";
            this.dtdDataAniversario._Help = "Insira a data do aniversário do contato";
            this.dtdDataAniversario._LabelGroup = this.sp_Familia;
            this.dtdDataAniversario._LabelText = "Data de aniversario";
            this.dtdDataAniversario._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.dtdDataAniversario._Regex = null;
            this.dtdDataAniversario._Table = "Contato";
            this.dtdDataAniversario._TamanhoComponente = 114;
            this.dtdDataAniversario._TamanhoMaiorLabel = 0;
            this.dtdDataAniversario._Visible = true;
            this.dtdDataAniversario.BackColor = System.Drawing.Color.Transparent;
            this.dtdDataAniversario.Base = null;
            this.dtdDataAniversario.Color = System.Drawing.Color.Empty;
            this.dtdDataAniversario.CustomFormat = "";
            this.dtdDataAniversario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtdDataAniversario.Location = new System.Drawing.Point(3, 54);
            this.dtdDataAniversario.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.dtdDataAniversario.Name = "dtdDataAniversario";
            this.dtdDataAniversario.Size = new System.Drawing.Size(220, 21);
            this.dtdDataAniversario.TabIndex = 1;
            this.dtdDataAniversario.Value = new System.DateTime(2012, 8, 7, 16, 29, 49, 416);
            // 
            // txtxConjuge
            // 
            this.txtxConjuge._Field = "xConjuge";
            this.txtxConjuge._Help = "Insira o nome do(a) cônjuge do contato.";
            this.txtxConjuge._LabelGroup = this.sp_Familia;
            this.txtxConjuge._LabelText = "Conjugue";
            this.txtxConjuge._Multiline = false;
            this.txtxConjuge._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxConjuge._Password = false;
            this.txtxConjuge._Regex = null;
            this.txtxConjuge._Table = "Contato";
            this.txtxConjuge._TamanhoComponente = 125;
            this.txtxConjuge._TamanhoMaiorLabel = 0;
            this.txtxConjuge._Visible = true;
            this.txtxConjuge.BackColor = System.Drawing.Color.Transparent;
            this.txtxConjuge.Base = null;
            this.txtxConjuge.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxConjuge.Color = System.Drawing.Color.White;
            this.txtxConjuge.Location = new System.Drawing.Point(3, 81);
            this.txtxConjuge.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.txtxConjuge.MaxLength = 32767;
            this.txtxConjuge.Name = "txtxConjuge";
            this.txtxConjuge.ReadOnly = false;
            this.txtxConjuge.Size = new System.Drawing.Size(183, 21);
            this.txtxConjuge.TabIndex = 2;
            // 
            // cbxstEstadoCivil
            // 
            this.cbxstEstadoCivil._Field = "stEstadoCivil";
            this.cbxstEstadoCivil._Help = "Informar o estado civil do contato";
            this.cbxstEstadoCivil._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbxstEstadoCivil._Itens")));
            this.cbxstEstadoCivil._LabelGroup = this.sp_Familia;
            this.cbxstEstadoCivil._LabelText = "Estado civíl";
            this.cbxstEstadoCivil._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbxstEstadoCivil._Regex = null;
            this.cbxstEstadoCivil._situacao = false;
            this.cbxstEstadoCivil._Table = "Contato";
            this.cbxstEstadoCivil._TamanhoComponente = 115;
            this.cbxstEstadoCivil._TamanhoMaiorLabel = 0;
            this.cbxstEstadoCivil._Visible = true;
            this.cbxstEstadoCivil.BackColor = System.Drawing.Color.Transparent;
            this.cbxstEstadoCivil.Base = null;
            this.cbxstEstadoCivil.Color = System.Drawing.Color.White;
            this.cbxstEstadoCivil.DataSource = null;
            this.cbxstEstadoCivil.DisplayMember = "DisplayMember";
            this.cbxstEstadoCivil.Location = new System.Drawing.Point(3, 108);
            this.cbxstEstadoCivil.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.cbxstEstadoCivil.Name = "cbxstEstadoCivil";
            this.cbxstEstadoCivil.SelectedIndex = -1;
            this.cbxstEstadoCivil.SelectedValue = 0;
            this.cbxstEstadoCivil.Size = new System.Drawing.Size(179, 21);
            this.cbxstEstadoCivil.TabIndex = 3;
            this.cbxstEstadoCivil.ValueMember = "ValueMember";
            // 
            // sp_Hobbies
            // 
            this.sp_Hobbies._LabelText = "Hobbies";
            this.sp_Hobbies._TamanhoMaiorLabel = 0;
            this.sp_Hobbies.BackColor = System.Drawing.Color.Transparent;
            this.sp_Hobbies.Location = new System.Drawing.Point(0, 135);
            this.sp_Hobbies.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.sp_Hobbies.Name = "sp_Hobbies";
            this.sp_Hobbies.Size = new System.Drawing.Size(54, 18);
            this.sp_Hobbies.TabIndex = 7;
            this.sp_Hobbies.TabStop = false;
            // 
            // txtxHobbies
            // 
            this.txtxHobbies._Field = "xHobbies";
            this.txtxHobbies._Help = "Insira os hobbies do contato";
            this.txtxHobbies._LabelGroup = this.sp_Hobbies;
            this.txtxHobbies._LabelText = "Hobbies";
            this.txtxHobbies._Multiline = false;
            this.txtxHobbies._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxHobbies._Password = false;
            this.txtxHobbies._Regex = null;
            this.txtxHobbies._Table = "Contato";
            this.txtxHobbies._TamanhoComponente = 133;
            this.txtxHobbies._TamanhoMaiorLabel = 0;
            this.txtxHobbies._Visible = true;
            this.txtxHobbies.BackColor = System.Drawing.Color.Transparent;
            this.txtxHobbies.Base = null;
            this.txtxHobbies.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxHobbies.Color = System.Drawing.Color.White;
            this.txtxHobbies.Location = new System.Drawing.Point(3, 159);
            this.txtxHobbies.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.txtxHobbies.MaxLength = 32767;
            this.txtxHobbies.Name = "txtxHobbies";
            this.txtxHobbies.ReadOnly = false;
            this.txtxHobbies.Size = new System.Drawing.Size(183, 21);
            this.txtxHobbies.TabIndex = 4;
            // 
            // sp_Empresa
            // 
            this.sp_Empresa._LabelText = "Empresa";
            this.sp_Empresa._TamanhoMaiorLabel = 0;
            this.sp_Empresa.BackColor = System.Drawing.Color.Transparent;
            this.sp_Empresa.Location = new System.Drawing.Point(0, 186);
            this.sp_Empresa.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.sp_Empresa.Name = "sp_Empresa";
            this.sp_Empresa.Size = new System.Drawing.Size(55, 18);
            this.sp_Empresa.TabIndex = 8;
            this.sp_Empresa.TabStop = false;
            // 
            // dtdAniversarioTempoServico
            // 
            this.dtdAniversarioTempoServico._Field = "dAniversarioTempoServico";
            this.dtdAniversarioTempoServico._Help = "Insira a data de aniversário de tempo de serviço.";
            this.dtdAniversarioTempoServico._LabelGroup = this.sp_Empresa;
            this.dtdAniversarioTempoServico._LabelText = "Data que começou a trabalhar";
            this.dtdAniversarioTempoServico._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.dtdAniversarioTempoServico._Regex = null;
            this.dtdAniversarioTempoServico._Table = "Contato";
            this.dtdAniversarioTempoServico._TamanhoComponente = 113;
            this.dtdAniversarioTempoServico._TamanhoMaiorLabel = 0;
            this.dtdAniversarioTempoServico._Visible = true;
            this.dtdAniversarioTempoServico.BackColor = System.Drawing.Color.Transparent;
            this.dtdAniversarioTempoServico.Base = null;
            this.dtdAniversarioTempoServico.Color = System.Drawing.Color.Empty;
            this.dtdAniversarioTempoServico.CustomFormat = "";
            this.dtdAniversarioTempoServico.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtdAniversarioTempoServico.Location = new System.Drawing.Point(3, 210);
            this.dtdAniversarioTempoServico.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.dtdAniversarioTempoServico.Name = "dtdAniversarioTempoServico";
            this.dtdAniversarioTempoServico.Size = new System.Drawing.Size(275, 21);
            this.dtdAniversarioTempoServico.TabIndex = 5;
            this.dtdAniversarioTempoServico.Value = new System.DateTime(2012, 8, 7, 16, 29, 49, 416);
            // 
            // FormContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "FormContato";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = -10;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text = "Contato";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormContato_FormClosing);
            this.Load += new System.EventHandler(this.FormContato_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel7)).EndInit();
            this.kryptonPanel7.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndereco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContatoEndereco)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).EndInit();
            this.kryptonPanel5.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel6)).EndInit();
            this.kryptonPanel6.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Comum.Components.HLP_TextBox txtCodigo;
        private Comum.Components.HLP_TextBox txtxTitulo;
        private Comum.Components.HLP_TextBox txtxNome;
        private Comum.Components.HLP_TextBox txtxDepartamento;
        private Comum.Components.HLP_TextBox txtxApelido;
        private Comum.Components.HLP_ComboBox cbxAtivo;
        private Comum.Components.HLP_MaskedTextBox mskxCPF;
        private Comum.Components.HLP_ComboBox cbxstSexo;
        private Comum.Components.HLP_ComboBox cbxstSensibilidade;
        private Comum.Components.HLP_DateTimePicker dtdDisponivelaPartir;
        private Comum.Components.HLP_DateTimePicker dtdDisponivelAte;
        private System.Windows.Forms.TabPage tabPage3;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidFidelidade;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidDecisao;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidPersonalidade;
        private Comum.Components.HLP_ComboBox cbxstVip;
        private Comum.Components.HLP_ComboBox cbxstMalaDireta;
        private Comum.Components.HLP_TextBox txtxMemorando;
        private System.Windows.Forms.TabPage tabPage2;
        private HLP_DataGridView dgvEndereco;
        private System.Windows.Forms.BindingSource bsContatoEndereco;
        private System.Windows.Forms.TabPage tabPage4;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private Comum.Components.HLP_MaskedTextBox mskxTelefoneComercial;
        private Comum.Components.HLP_MaskedTextBox mskxCelularComercial;
        private Comum.Components.HLP_TextBox txtxRadioFoneComercial;
        private Comum.Components.HLP_TextBox txtxPagerComercial;
        private Comum.Components.HLP_TextBox txtxEmailComercial;
        private Comum.Components.HLP_TextBox txtxSkypeComercial;
        private Comum.Components.HLP_TextBox txtxMSNComercial;
        private Comum.Components.HLP_TextBox txtxhttpComercial;
        private Comum.Components.HLP_LabelSeparator sp_Comercial;
        private Comum.Components.HLP_LabelSeparator sp_Residencial;
        private Comum.Components.HLP_MaskedTextBox mskxTelefoneResidencial;
        private Comum.Components.HLP_MaskedTextBox mskxCelularResidencial;
        private Comum.Components.HLP_TextBox txtxRadioFoneResidencial;
        private Comum.Components.HLP_TextBox txtxEmailResidencial;
        private Comum.Components.HLP_TextBox txtxSkypeResidencial;
        private Comum.Components.HLP_TextBox txtxMsnResidencial;
        private Comum.Components.HLP_TextBox txtXhttpPessoal;
        private System.Windows.Forms.TabPage tabPage5;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private Comum.Components.HLP_TextBox txtxFilhos;
        private Comum.Components.HLP_DateTimePicker dtdDataAniversario;
        private Comum.Components.HLP_LabelSeparator sp_Familia;
        private Comum.Components.HLP_TextBox txtxConjuge;
        private Comum.Components.HLP_ComboBox cbxstEstadoCivil;
        private Comum.Components.HLP_LabelSeparator sp_Hobbies;
        private Comum.Components.HLP_TextBox txtxHobbies;
        private Comum.Components.HLP_LabelSeparator sp_Empresa;
        private Comum.Components.HLP_DateTimePicker dtdAniversarioTempoServico;
        private Comum.Components.HLP_LabelSeparator sp_Identificacao;
        private Comum.Components.HLP_LabelSeparator sp_Superior;
        private Comum.Components.HLP_LabelSeparator sp_TempDisp;
        private Comum.Components.HLP_LabelSeparator sp_Personalidade;
        private Comum.Components.HLP_LabelSeparator sp_vip_maladireta;
        private Comum.Components.HLP_LabelSeparator sp_outrosConfig;
        private Comum.Components.HLP_ComboBox cbxidContatoGerente;
        private Comum.Components.HLP_ComboBox cbxidFuncionario;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel7;
        private Comum.Components.HLP_TextBox txtxFuncao;
        private Comum.Components.HLP_TextBox txtxRamalComercial;
        private Comum.Components.HLP_MaskedTextBox mskxFaxComercial;
        private Comum.Components.HLP_LabelSeparator spContatoPrincipal;
        private System.Windows.Forms.DataGridViewComboBoxColumn stPrincipal;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNome;
        private System.Windows.Forms.DataGridViewComboBoxColumn stTipoEndereco;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewMaskedTextBoxColumn xCEP;
        private System.Windows.Forms.DataGridViewComboBoxColumn idCidade;
        private System.Windows.Forms.DataGridViewComboBoxColumn stLogradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn xEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn xBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn xComplemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn xLatitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn xLongitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFusoHorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCaixaPostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn idContato;
    }
}

