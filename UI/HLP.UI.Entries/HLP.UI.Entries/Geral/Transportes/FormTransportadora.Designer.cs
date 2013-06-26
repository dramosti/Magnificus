using HLP.Comum.Components;
namespace HLP.UI.Entries.Geral.Transportes
{
    partial class FormTransportadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransportadora));
            this.kryptonTabControl1 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kryptonPanel1 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.sp_Identificacao = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtCodigo = new HLP.Comum.Components.HLP_TextBox();
            this.txtxCodigoAlternativo = new HLP.Comum.Components.HLP_TextBox();
            this.txtxNome = new HLP.Comum.Components.HLP_TextBox();
            this.txtxFantasia = new HLP.Comum.Components.HLP_TextBox();
            this.cbxstPessoa = new HLP.Comum.Components.HLP_ComboBox();
            this.sp_Documentacao = new HLP.Comum.Components.HLP_LabelSeparator();
            this.mskxCnpj = new HLP.Comum.Components.HLP_MaskedTextBox();
            this.mskxIe = new HLP.Comum.Components.HLP_MaskedTextBox();
            this.txtxIm = new HLP.Comum.Components.HLP_TextBox();
            this.mskxCpf = new HLP.Comum.Components.HLP_MaskedTextBox();
            this.txtxRg = new HLP.Comum.Components.HLP_TextBox();
            this.txtxRntrc = new HLP.Comum.Components.HLP_TextBox();
            this.sp_Telefones = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtxTelefone1 = new HLP.Comum.Components.HLP_TextBox();
            this.txtxTelefone2 = new HLP.Comum.Components.HLP_TextBox();
            this.txtxFax = new HLP.Comum.Components.HLP_TextBox();
            this.sp_identf_eletronica = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtxEmail = new HLP.Comum.Components.HLP_TextBox();
            this.txtxHttp = new HLP.Comum.Components.HLP_TextBox();
            this.cboAtivo = new HLP.Comum.Components.HLP_ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.kryptonPanel4 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.dgvEndereco = new HLP.Comum.Components.HLP_DataGridView();
            this.stPrincipal = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.xNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stTipoEndereco = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.xCEP = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewMaskedTextBoxColumn();
            this.stLogradouro = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.xEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xComplemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xLatitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xLongitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFusoHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCaixaPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCidade = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsTransportadorEnderecoModel = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonTabControl2 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.kryptonPanel6 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.dgvContato = new HLP.Comum.Components.HLP_DataGridView();
            this.idContato_Contato = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsTransportadorContatoModel = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.dgvMotorista = new HLP.Comum.Components.HLP_DataGridView();
            this.idContato_Motorista = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.xRntrcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsTransportadorMotoristaModel = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.kryptonPanel5 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.dgvVeiculos = new HLP.Comum.Components.HLP_DataGridView();
            this.xPlacaVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUf = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.xMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsTransportadorVeiculosModel = new System.Windows.Forms.BindingSource(this.components);
            this.xRntrc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).BeginInit();
            this.panelPadrao.SuspendLayout();
            this.kryptonTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.kryptonPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndereco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransportadorEnderecoModel)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            this.kryptonTabControl2.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.kryptonPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransportadorContatoModel)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotorista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransportadorMotoristaModel)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).BeginInit();
            this.kryptonPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransportadorVeiculosModel)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(810, 371);
            // 
            // panelPadrao
            // 
            this.panelPadrao.Controls.Add(this.kryptonTabControl1);
            this.panelPadrao.Size = new System.Drawing.Size(808, 347);
            // 
            // kryptonTabControl1
            // 
            this.kryptonTabControl1.AllowCloseButton = false;
            this.kryptonTabControl1.AllowContextButton = false;
            this.kryptonTabControl1.AllowNavigatorButtons = false;
            this.kryptonTabControl1.AllowSelectedTabHigh = false;
            this.kryptonTabControl1.BorderWidth = 1;
            this.kryptonTabControl1.Controls.Add(this.tabPage1);
            this.kryptonTabControl1.Controls.Add(this.tabPage2);
            this.kryptonTabControl1.Controls.Add(this.tabPage3);
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
            this.kryptonTabControl1.Size = new System.Drawing.Size(802, 341);
            this.kryptonTabControl1.TabIndex = 5;
            this.kryptonTabControl1.UseExtendedLayout = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Controls.Add(this.kryptonPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(794, 312);
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
            this.kryptonPanel1.Size = new System.Drawing.Size(794, 312);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.sp_Identificacao);
            this.flowLayoutPanel1.Controls.Add(this.txtCodigo);
            this.flowLayoutPanel1.Controls.Add(this.txtxCodigoAlternativo);
            this.flowLayoutPanel1.Controls.Add(this.txtxNome);
            this.flowLayoutPanel1.Controls.Add(this.txtxFantasia);
            this.flowLayoutPanel1.Controls.Add(this.cbxstPessoa);
            this.flowLayoutPanel1.Controls.Add(this.sp_Documentacao);
            this.flowLayoutPanel1.Controls.Add(this.mskxCnpj);
            this.flowLayoutPanel1.Controls.Add(this.mskxIe);
            this.flowLayoutPanel1.Controls.Add(this.txtxIm);
            this.flowLayoutPanel1.Controls.Add(this.mskxCpf);
            this.flowLayoutPanel1.Controls.Add(this.txtxRg);
            this.flowLayoutPanel1.Controls.Add(this.txtxRntrc);
            this.flowLayoutPanel1.Controls.Add(this.sp_Telefones);
            this.flowLayoutPanel1.Controls.Add(this.txtxTelefone1);
            this.flowLayoutPanel1.Controls.Add(this.txtxTelefone2);
            this.flowLayoutPanel1.Controls.Add(this.txtxFax);
            this.flowLayoutPanel1.Controls.Add(this.sp_identf_eletronica);
            this.flowLayoutPanel1.Controls.Add(this.txtxEmail);
            this.flowLayoutPanel1.Controls.Add(this.txtxHttp);
            this.flowLayoutPanel1.Controls.Add(this.cboAtivo);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(794, 312);
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
            this.sp_Identificacao.Size = new System.Drawing.Size(359, 18);
            this.sp_Identificacao.TabIndex = 21;
            this.sp_Identificacao.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo._Field = "idTransportador";
            this.txtCodigo._LabelGroup = this.sp_Identificacao;
            this.txtCodigo._LabelText = "Código";
            this.txtCodigo._Multiline = false;
            this.txtCodigo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtCodigo._Password = false;
            this.txtCodigo._Regex = null;
            this.txtCodigo._Table = "Transportador";
            this.txtCodigo._TamanhoComponente = 107;
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
            this.txtCodigo.Size = new System.Drawing.Size(152, 21);
            this.txtCodigo.TabIndex = 2;
            // 
            // txtxCodigoAlternativo
            // 
            this.txtxCodigoAlternativo._Field = "xCodigoAlternativo";
            this.txtxCodigoAlternativo._Help = "O sistema traz o mesmo código da transportadora, mas dá a opção para o usuário mu" +
    "dar.";
            this.txtxCodigoAlternativo._LabelGroup = this.sp_Identificacao;
            this.txtxCodigoAlternativo._LabelText = "Código alternativo";
            this.txtxCodigoAlternativo._Multiline = false;
            this.txtxCodigoAlternativo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxCodigoAlternativo._Password = false;
            this.txtxCodigoAlternativo._Regex = null;
            this.txtxCodigoAlternativo._Table = "Transportador";
            this.txtxCodigoAlternativo._TamanhoComponente = 107;
            this.txtxCodigoAlternativo._TamanhoMaiorLabel = 200;
            this.txtxCodigoAlternativo._Visible = false;
            this.txtxCodigoAlternativo.BackColor = System.Drawing.Color.Transparent;
            this.txtxCodigoAlternativo.Base = null;
            this.txtxCodigoAlternativo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxCodigoAlternativo.Color = System.Drawing.Color.White;
            this.txtxCodigoAlternativo.Location = new System.Drawing.Point(100, 54);
            this.txtxCodigoAlternativo.Margin = new System.Windows.Forms.Padding(100, 3, 15, 3);
            this.txtxCodigoAlternativo.MaxLength = 32767;
            this.txtxCodigoAlternativo.Name = "txtxCodigoAlternativo";
            this.txtxCodigoAlternativo.ReadOnly = false;
            this.txtxCodigoAlternativo.Size = new System.Drawing.Size(210, 21);
            this.txtxCodigoAlternativo.TabIndex = 3;
            // 
            // txtxNome
            // 
            this.txtxNome._Field = "xNome";
            this.txtxNome._Help = "É preenchido com a razão social da transportadora.";
            this.txtxNome._LabelGroup = this.sp_Identificacao;
            this.txtxNome._LabelText = "Razão social";
            this.txtxNome._Multiline = false;
            this.txtxNome._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxNome._Password = false;
            this.txtxNome._Regex = null;
            this.txtxNome._Table = "Transportador";
            this.txtxNome._TamanhoComponente = 154;
            this.txtxNome._TamanhoMaiorLabel = 200;
            this.txtxNome._Visible = false;
            this.txtxNome.BackColor = System.Drawing.Color.Transparent;
            this.txtxNome.Base = null;
            this.txtxNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxNome.Color = System.Drawing.Color.White;
            this.txtxNome.Location = new System.Drawing.Point(133, 81);
            this.txtxNome.Margin = new System.Windows.Forms.Padding(133, 3, 15, 3);
            this.txtxNome.MaxLength = 32767;
            this.txtxNome.Name = "txtxNome";
            this.txtxNome.ReadOnly = false;
            this.txtxNome.Size = new System.Drawing.Size(224, 21);
            this.txtxNome.TabIndex = 5;
            this.txtxNome._Leave += new System.EventHandler(this.txtxNome__Leave);
            // 
            // txtxFantasia
            // 
            this.txtxFantasia._Field = "xFantasia";
            this.txtxFantasia._Help = "É preenchido com o nome fantasia da transportadora.";
            this.txtxFantasia._LabelGroup = this.sp_Identificacao;
            this.txtxFantasia._LabelText = "Nome fantasia";
            this.txtxFantasia._Multiline = false;
            this.txtxFantasia._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxFantasia._Password = false;
            this.txtxFantasia._Regex = null;
            this.txtxFantasia._Table = "Transportador";
            this.txtxFantasia._TamanhoComponente = 156;
            this.txtxFantasia._TamanhoMaiorLabel = 200;
            this.txtxFantasia._Visible = false;
            this.txtxFantasia.BackColor = System.Drawing.Color.Transparent;
            this.txtxFantasia.Base = null;
            this.txtxFantasia.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxFantasia.Color = System.Drawing.Color.White;
            this.txtxFantasia.Location = new System.Drawing.Point(122, 108);
            this.txtxFantasia.Margin = new System.Windows.Forms.Padding(122, 3, 15, 3);
            this.txtxFantasia.MaxLength = 32767;
            this.txtxFantasia.Name = "txtxFantasia";
            this.txtxFantasia.ReadOnly = false;
            this.txtxFantasia.Size = new System.Drawing.Size(237, 21);
            this.txtxFantasia.TabIndex = 6;
            // 
            // cbxstPessoa
            // 
            this.cbxstPessoa._Field = "stPessoa";
            this.cbxstPessoa._Help = "Este campo define se a transportadora é pessoa jurídica ou física";
            this.cbxstPessoa._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbxstPessoa._Itens")));
            this.cbxstPessoa._LabelGroup = this.sp_Identificacao;
            this.cbxstPessoa._LabelText = "Pessoa jurídica?";
            this.cbxstPessoa._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbxstPessoa._Regex = null;
            this.cbxstPessoa._situacao = true;
            this.cbxstPessoa._Table = "Transportador";
            this.cbxstPessoa._TamanhoComponente = 80;
            this.cbxstPessoa._TamanhoMaiorLabel = 200;
            this.cbxstPessoa._Visible = false;
            this.cbxstPessoa.BackColor = System.Drawing.Color.Transparent;
            this.cbxstPessoa.Base = null;
            this.cbxstPessoa.Color = System.Drawing.Color.White;
            this.cbxstPessoa.DataSource = null;
            this.cbxstPessoa.DisplayMember = "DisplayMember";
            this.cbxstPessoa.Location = new System.Drawing.Point(115, 135);
            this.cbxstPessoa.Margin = new System.Windows.Forms.Padding(115, 3, 15, 3);
            this.cbxstPessoa.Name = "cbxstPessoa";
            this.cbxstPessoa.SelectedIndex = -1;
            this.cbxstPessoa.SelectedValue = 0;
            this.cbxstPessoa.Size = new System.Drawing.Size(168, 21);
            this.cbxstPessoa.TabIndex = 4;
            this.cbxstPessoa.ValueMember = "ValueMember";
            this.cbxstPessoa._SelectedIndexChanged += new System.EventHandler(this.cbxstPessoa__SelectedIndexChanged);
            // 
            // sp_Documentacao
            // 
            this.sp_Documentacao._LabelText = "Documentação";
            this.sp_Documentacao._TamanhoMaiorLabel = 0;
            this.sp_Documentacao.BackColor = System.Drawing.Color.Transparent;
            this.sp_Documentacao.Location = new System.Drawing.Point(0, 162);
            this.sp_Documentacao.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.sp_Documentacao.Name = "sp_Documentacao";
            this.sp_Documentacao.Size = new System.Drawing.Size(338, 18);
            this.sp_Documentacao.TabIndex = 22;
            this.sp_Documentacao.TabStop = false;
            // 
            // mskxCnpj
            // 
            this.mskxCnpj._Field = "xCnpj";
            this.mskxCnpj._Help = "No caso de pessoa jurídica, deverá ser preenchido o cnpj (cadastro nacional de pe" +
    "ssoa jurídica) da transportadora";
            this.mskxCnpj._LabelGroup = this.sp_Documentacao;
            this.mskxCnpj._LabelText = "Cnpj";
            this.mskxCnpj._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.mskxCnpj._Regex = null;
            this.mskxCnpj._Table = "Transportador";
            this.mskxCnpj._TamanhoComponente = 126;
            this.mskxCnpj._TamanhoMaiorLabel = 200;
            this.mskxCnpj._TpValidacao = HLP.Comum.Components.HLP_MaskedTextBox.TipoValidacao.CNPJ;
            this.mskxCnpj._UF = null;
            this.mskxCnpj._Visible = false;
            this.mskxCnpj.BackColor = System.Drawing.Color.Transparent;
            this.mskxCnpj.Base = null;
            this.mskxCnpj.Color = System.Drawing.Color.White;
            this.mskxCnpj.Location = new System.Drawing.Point(172, 186);
            this.mskxCnpj.Margin = new System.Windows.Forms.Padding(172, 3, 15, 3);
            this.mskxCnpj.Mask = "99,999,999/9999-99";
            this.mskxCnpj.MaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mskxCnpj.MaxLength = 32767;
            this.mskxCnpj.Name = "mskxCnpj";
            this.mskxCnpj.ReadOnly = false;
            this.mskxCnpj.Size = new System.Drawing.Size(157, 21);
            this.mskxCnpj.TabIndex = 9;
            // 
            // mskxIe
            // 
            this.mskxIe._Field = "xIe";
            this.mskxIe._Help = "No caso de pessoa jurídica deverá ser preenchido com a inscrição estadual da tran" +
    "sportadora. ";
            this.mskxIe._LabelGroup = this.sp_Documentacao;
            this.mskxIe._LabelText = "Incrição estadual";
            this.mskxIe._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.mskxIe._Regex = null;
            this.mskxIe._Table = "Transportador";
            this.mskxIe._TamanhoComponente = 125;
            this.mskxIe._TamanhoMaiorLabel = 200;
            this.mskxIe._TpValidacao = HLP.Comum.Components.HLP_MaskedTextBox.TipoValidacao.IE;
            this.mskxIe._UF = null;
            this.mskxIe._Visible = false;
            this.mskxIe.BackColor = System.Drawing.Color.Transparent;
            this.mskxIe.Base = null;
            this.mskxIe.Color = System.Drawing.Color.White;
            this.mskxIe.Location = new System.Drawing.Point(109, 213);
            this.mskxIe.Margin = new System.Windows.Forms.Padding(109, 3, 15, 3);
            this.mskxIe.Mask = "";
            this.mskxIe.MaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mskxIe.MaxLength = 32767;
            this.mskxIe.Name = "mskxIe";
            this.mskxIe.ReadOnly = false;
            this.mskxIe.Size = new System.Drawing.Size(219, 21);
            this.mskxIe.TabIndex = 29;
            // 
            // txtxIm
            // 
            this.txtxIm._Field = "xIm";
            this.txtxIm._Help = "No caso de pessoa jurídica deverá ser preenchido com a inscrição municipal da tra" +
    "nsportadora.";
            this.txtxIm._LabelGroup = this.sp_Documentacao;
            this.txtxIm._LabelText = "Inscrição municipal";
            this.txtxIm._Multiline = false;
            this.txtxIm._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxIm._Password = false;
            this.txtxIm._Regex = null;
            this.txtxIm._Table = "Transportador";
            this.txtxIm._TamanhoComponente = 132;
            this.txtxIm._TamanhoMaiorLabel = 200;
            this.txtxIm._Visible = false;
            this.txtxIm.BackColor = System.Drawing.Color.Transparent;
            this.txtxIm.Base = null;
            this.txtxIm.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxIm.Color = System.Drawing.Color.White;
            this.txtxIm.Location = new System.Drawing.Point(98, 240);
            this.txtxIm.Margin = new System.Windows.Forms.Padding(98, 3, 15, 3);
            this.txtxIm.MaxLength = 32767;
            this.txtxIm.Name = "txtxIm";
            this.txtxIm.ReadOnly = false;
            this.txtxIm.Size = new System.Drawing.Size(237, 21);
            this.txtxIm.TabIndex = 8;
            // 
            // mskxCpf
            // 
            this.mskxCpf._Field = "xCpf";
            this.mskxCpf._Help = "No caso de pessoa física, este campo deverá ser preenchido com o cpf (cadastro de" +
    " pessoa física) da pessoa";
            this.mskxCpf._LabelGroup = this.sp_Documentacao;
            this.mskxCpf._LabelText = "Cpf";
            this.mskxCpf._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.mskxCpf._Regex = null;
            this.mskxCpf._Table = "Transportador";
            this.mskxCpf._TamanhoComponente = 125;
            this.mskxCpf._TamanhoMaiorLabel = 200;
            this.mskxCpf._TpValidacao = HLP.Comum.Components.HLP_MaskedTextBox.TipoValidacao.CPF;
            this.mskxCpf._UF = null;
            this.mskxCpf._Visible = false;
            this.mskxCpf.BackColor = System.Drawing.Color.Transparent;
            this.mskxCpf.Base = null;
            this.mskxCpf.Color = System.Drawing.Color.White;
            this.mskxCpf.Location = new System.Drawing.Point(178, 267);
            this.mskxCpf.Margin = new System.Windows.Forms.Padding(178, 3, 15, 3);
            this.mskxCpf.Mask = "999,999,999-99";
            this.mskxCpf.MaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mskxCpf.MaxLength = 32767;
            this.mskxCpf.Name = "mskxCpf";
            this.mskxCpf.ReadOnly = false;
            this.mskxCpf.Size = new System.Drawing.Size(150, 21);
            this.mskxCpf.TabIndex = 15;
            // 
            // txtxRg
            // 
            this.txtxRg._Field = "xRg";
            this.txtxRg._Help = "No caso de pessoa física, deverá ser preenchido com o rg (registro geral) da pess" +
    "oa.";
            this.txtxRg._LabelGroup = this.sp_Documentacao;
            this.txtxRg._LabelText = "Rg";
            this.txtxRg._Multiline = false;
            this.txtxRg._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxRg._Password = false;
            this.txtxRg._Regex = null;
            this.txtxRg._Table = "Transportador";
            this.txtxRg._TamanhoComponente = 135;
            this.txtxRg._TamanhoMaiorLabel = 200;
            this.txtxRg._Visible = false;
            this.txtxRg.BackColor = System.Drawing.Color.Transparent;
            this.txtxRg.Base = null;
            this.txtxRg.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxRg.Color = System.Drawing.Color.White;
            this.txtxRg.Location = new System.Drawing.Point(556, 3);
            this.txtxRg.Margin = new System.Windows.Forms.Padding(182, 3, 15, 3);
            this.txtxRg.MaxLength = 32767;
            this.txtxRg.Name = "txtxRg";
            this.txtxRg.ReadOnly = false;
            this.txtxRg.Size = new System.Drawing.Size(156, 21);
            this.txtxRg.TabIndex = 10;
            // 
            // txtxRntrc
            // 
            this.txtxRntrc._Field = "xRntrc";
            this.txtxRntrc._Help = "Informar o registro nacional de transportadores rodoviários de carga";
            this.txtxRntrc._LabelGroup = this.sp_Documentacao;
            this.txtxRntrc._LabelText = "Rntrc";
            this.txtxRntrc._Multiline = false;
            this.txtxRntrc._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxRntrc._Password = false;
            this.txtxRntrc._Regex = null;
            this.txtxRntrc._Table = "Transportador";
            this.txtxRntrc._TamanhoComponente = 142;
            this.txtxRntrc._TamanhoMaiorLabel = 200;
            this.txtxRntrc._Visible = false;
            this.txtxRntrc.BackColor = System.Drawing.Color.Transparent;
            this.txtxRntrc.Base = null;
            this.txtxRntrc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxRntrc.Color = System.Drawing.Color.White;
            this.txtxRntrc.Location = new System.Drawing.Point(543, 30);
            this.txtxRntrc.Margin = new System.Windows.Forms.Padding(169, 3, 15, 3);
            this.txtxRntrc.MaxLength = 32767;
            this.txtxRntrc.Name = "txtxRntrc";
            this.txtxRntrc.ReadOnly = false;
            this.txtxRntrc.Size = new System.Drawing.Size(176, 21);
            this.txtxRntrc.TabIndex = 11;
            // 
            // sp_Telefones
            // 
            this.sp_Telefones._LabelText = "Telefones";
            this.sp_Telefones._TamanhoMaiorLabel = 0;
            this.sp_Telefones.BackColor = System.Drawing.Color.Transparent;
            this.sp_Telefones.Location = new System.Drawing.Point(374, 57);
            this.sp_Telefones.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.sp_Telefones.Name = "sp_Telefones";
            this.sp_Telefones.Size = new System.Drawing.Size(380, 18);
            this.sp_Telefones.TabIndex = 23;
            this.sp_Telefones.TabStop = false;
            // 
            // txtxTelefone1
            // 
            this.txtxTelefone1._Field = "xTelefone1";
            this.txtxTelefone1._Help = "É preenchido com o telefone principal da transport";
            this.txtxTelefone1._LabelGroup = this.sp_Telefones;
            this.txtxTelefone1._LabelText = "1º telefone";
            this.txtxTelefone1._Multiline = false;
            this.txtxTelefone1._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxTelefone1._Password = false;
            this.txtxTelefone1._Regex = null;
            this.txtxTelefone1._Table = "Transportador";
            this.txtxTelefone1._TamanhoComponente = 134;
            this.txtxTelefone1._TamanhoMaiorLabel = 200;
            this.txtxTelefone1._Visible = false;
            this.txtxTelefone1.BackColor = System.Drawing.Color.Transparent;
            this.txtxTelefone1.Base = null;
            this.txtxTelefone1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxTelefone1.Color = System.Drawing.Color.White;
            this.txtxTelefone1.Location = new System.Drawing.Point(513, 81);
            this.txtxTelefone1.Margin = new System.Windows.Forms.Padding(139, 3, 15, 3);
            this.txtxTelefone1.MaxLength = 32767;
            this.txtxTelefone1.Name = "txtxTelefone1";
            this.txtxTelefone1.ReadOnly = false;
            this.txtxTelefone1.Size = new System.Drawing.Size(198, 21);
            this.txtxTelefone1.TabIndex = 25;
            // 
            // txtxTelefone2
            // 
            this.txtxTelefone2._Field = "xTelefone2";
            this.txtxTelefone2._Help = "É preenchido com o segundo telefone da transportadora, se houver.";
            this.txtxTelefone2._LabelGroup = this.sp_Telefones;
            this.txtxTelefone2._LabelText = "2º telefone";
            this.txtxTelefone2._Multiline = false;
            this.txtxTelefone2._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxTelefone2._Password = false;
            this.txtxTelefone2._Regex = null;
            this.txtxTelefone2._Table = "Transportador";
            this.txtxTelefone2._TamanhoComponente = 134;
            this.txtxTelefone2._TamanhoMaiorLabel = 200;
            this.txtxTelefone2._Visible = false;
            this.txtxTelefone2.BackColor = System.Drawing.Color.Transparent;
            this.txtxTelefone2.Base = null;
            this.txtxTelefone2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxTelefone2.Color = System.Drawing.Color.White;
            this.txtxTelefone2.Location = new System.Drawing.Point(513, 108);
            this.txtxTelefone2.Margin = new System.Windows.Forms.Padding(139, 3, 15, 3);
            this.txtxTelefone2.MaxLength = 32767;
            this.txtxTelefone2.Name = "txtxTelefone2";
            this.txtxTelefone2.ReadOnly = false;
            this.txtxTelefone2.Size = new System.Drawing.Size(198, 21);
            this.txtxTelefone2.TabIndex = 26;
            // 
            // txtxFax
            // 
            this.txtxFax._Field = "xFax";
            this.txtxFax._Help = "É preenchido com o fax principal da transportadora.";
            this.txtxFax._LabelGroup = this.sp_Telefones;
            this.txtxFax._LabelText = "Fax";
            this.txtxFax._Multiline = false;
            this.txtxFax._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxFax._Password = false;
            this.txtxFax._Regex = null;
            this.txtxFax._Table = "Transportador";
            this.txtxFax._TamanhoComponente = 134;
            this.txtxFax._TamanhoMaiorLabel = 200;
            this.txtxFax._Visible = false;
            this.txtxFax.BackColor = System.Drawing.Color.Transparent;
            this.txtxFax.Base = null;
            this.txtxFax.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxFax.Color = System.Drawing.Color.White;
            this.txtxFax.Location = new System.Drawing.Point(553, 135);
            this.txtxFax.Margin = new System.Windows.Forms.Padding(179, 3, 15, 3);
            this.txtxFax.MaxLength = 32767;
            this.txtxFax.Name = "txtxFax";
            this.txtxFax.ReadOnly = false;
            this.txtxFax.Size = new System.Drawing.Size(158, 21);
            this.txtxFax.TabIndex = 27;
            // 
            // sp_identf_eletronica
            // 
            this.sp_identf_eletronica._LabelText = "Identificação eletrônica";
            this.sp_identf_eletronica._TamanhoMaiorLabel = 0;
            this.sp_identf_eletronica.BackColor = System.Drawing.Color.Transparent;
            this.sp_identf_eletronica.Location = new System.Drawing.Point(374, 162);
            this.sp_identf_eletronica.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.sp_identf_eletronica.Name = "sp_identf_eletronica";
            this.sp_identf_eletronica.Size = new System.Drawing.Size(402, 18);
            this.sp_identf_eletronica.TabIndex = 24;
            this.sp_identf_eletronica.TabStop = false;
            // 
            // txtxEmail
            // 
            this.txtxEmail._Field = "xEmail";
            this.txtxEmail._Help = "Preencher o e-mail da transportadora";
            this.txtxEmail._LabelGroup = this.sp_identf_eletronica;
            this.txtxEmail._LabelText = "E-mail";
            this.txtxEmail._Multiline = false;
            this.txtxEmail._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxEmail._Password = false;
            this.txtxEmail._Regex = "^\\w+([-+.\']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$";
            this.txtxEmail._Table = "Transportador";
            this.txtxEmail._TamanhoComponente = 209;
            this.txtxEmail._TamanhoMaiorLabel = 200;
            this.txtxEmail._Visible = false;
            this.txtxEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtxEmail.Base = null;
            this.txtxEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxEmail.Color = System.Drawing.Color.White;
            this.txtxEmail.Location = new System.Drawing.Point(539, 186);
            this.txtxEmail.Margin = new System.Windows.Forms.Padding(165, 3, 15, 3);
            this.txtxEmail.MaxLength = 32767;
            this.txtxEmail.Name = "txtxEmail";
            this.txtxEmail.ReadOnly = false;
            this.txtxEmail.Size = new System.Drawing.Size(247, 21);
            this.txtxEmail.TabIndex = 19;
            // 
            // txtxHttp
            // 
            this.txtxHttp._Field = "xHttp";
            this.txtxHttp._Help = "Informar o endereço da internet da transportadora.";
            this.txtxHttp._LabelGroup = this.sp_identf_eletronica;
            this.txtxHttp._LabelText = "Endereço da internet";
            this.txtxHttp._Multiline = false;
            this.txtxHttp._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxHttp._Password = false;
            this.txtxHttp._Regex = null;
            this.txtxHttp._Table = "Transportador";
            this.txtxHttp._TamanhoComponente = 209;
            this.txtxHttp._TamanhoMaiorLabel = 200;
            this.txtxHttp._Visible = false;
            this.txtxHttp.BackColor = System.Drawing.Color.Transparent;
            this.txtxHttp.Base = null;
            this.txtxHttp.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxHttp.Color = System.Drawing.Color.White;
            this.txtxHttp.Location = new System.Drawing.Point(462, 213);
            this.txtxHttp.Margin = new System.Windows.Forms.Padding(88, 3, 15, 3);
            this.txtxHttp.MaxLength = 32767;
            this.txtxHttp.Name = "txtxHttp";
            this.txtxHttp.ReadOnly = false;
            this.txtxHttp.Size = new System.Drawing.Size(324, 21);
            this.txtxHttp.TabIndex = 20;
            // 
            // cboAtivo
            // 
            this.cboAtivo._Field = "Ativo";
            this.cboAtivo._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cboAtivo._Itens")));
            this.cboAtivo._LabelGroup = null;
            this.cboAtivo._LabelText = "Ativo?";
            this.cboAtivo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cboAtivo._Regex = null;
            this.cboAtivo._situacao = true;
            this.cboAtivo._Table = "Transportador";
            this.cboAtivo._TamanhoComponente = 80;
            this.cboAtivo._TamanhoMaiorLabel = 200;
            this.cboAtivo._Visible = false;
            this.cboAtivo.BackColor = System.Drawing.Color.Transparent;
            this.cboAtivo.Base = null;
            this.cboAtivo.Color = System.Drawing.Color.White;
            this.cboAtivo.DataSource = null;
            this.cboAtivo.DisplayMember = "DisplayMember";
            this.cboAtivo.Location = new System.Drawing.Point(539, 240);
            this.cboAtivo.Margin = new System.Windows.Forms.Padding(165, 3, 15, 3);
            this.cboAtivo.Name = "cboAtivo";
            this.cboAtivo.SelectedIndex = -1;
            this.cboAtivo.SelectedValue = 0;
            this.cboAtivo.Size = new System.Drawing.Size(118, 21);
            this.cboAtivo.TabIndex = 28;
            this.cboAtivo.ValueMember = "ValueMember";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.kryptonPanel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(794, 312);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Tag = false;
            this.tabPage2.Text = "Endereços";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.dgvEndereco);
            this.kryptonPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel4.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(794, 312);
            this.kryptonPanel4.TabIndex = 1;
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
            this.stLogradouro,
            this.xEndereco,
            this.nNumero,
            this.xComplemento,
            this.xBairro,
            this.xLatitude,
            this.xLongitude,
            this.xFusoHorario,
            this.xCaixaPostal,
            this.idCidade});
            this.dgvEndereco.DataSource = this.bsTransportadorEnderecoModel;
            this.dgvEndereco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEndereco.DragDropLinha = false;
            this.dgvEndereco.Exclui = false;
            this.dgvEndereco.Inclui = false;
            this.dgvEndereco.Location = new System.Drawing.Point(0, 0);
            this.dgvEndereco.Name = "dgvEndereco";
            this.dgvEndereco.Size = new System.Drawing.Size(794, 312);
            this.dgvEndereco.TabIndex = 0;
            this.dgvEndereco.Tag = "Transportador_Endereco";
            this.dgvEndereco.Enter += new System.EventHandler(this.dgvEndereco_Enter);
            // 
            // stPrincipal
            // 
            this.stPrincipal.DataPropertyName = "stPrincipal";
            this.stPrincipal.HeaderText = "Principal ";
            this.stPrincipal.Items.AddRange(new object[] {
            "0-NÃO",
            "1-SIM"});
            this.stPrincipal.Name = "stPrincipal";
            this.stPrincipal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stPrincipal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.stPrincipal.ToolTipText = "Se esta caixa de seleção estiver selecionada, o endereço será o endereço principa" +
    "l para a Transportadora.";
            this.stPrincipal.Width = 140;
            // 
            // xNome
            // 
            this.xNome.DataPropertyName = "xNome";
            this.xNome.HeaderText = "Nome";
            this.xNome.Name = "xNome";
            this.xNome.ToolTipText = "O nome da organização ou pessoa de contato para o endereço selecionado";
            this.xNome.Width = 200;
            // 
            // stTipoEndereco
            // 
            this.stTipoEndereco.DataPropertyName = "stTipoEndereco";
            this.stTipoEndereco.HeaderText = "Tipo Endereco";
            this.stTipoEndereco.Items.AddRange(new object[] {
            "0-COMERCIAL",
            "1-ENTREGA",
            "2-ENTREGA ALT",
            "3-NOTA FISCAL",
            "4-REMETER-PARA",
            "5-RESIDÊNCIA",
            "6-SERVIÇO",
            "9-OUTRO"});
            this.stTipoEndereco.Name = "stTipoEndereco";
            this.stTipoEndereco.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stTipoEndereco.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.stTipoEndereco.ToolTipText = "Especifique como usar o endereço selecionado";
            this.stTipoEndereco.Width = 140;
            // 
            // xCEP
            // 
            this.xCEP.DataPropertyName = "xCEP";
            this.xCEP.HeaderText = "CEP";
            this.xCEP.Mask = "00000-000";
            this.xCEP.Name = "xCEP";
            this.xCEP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xCEP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.xCEP.ToolTipText = "Informar o Código de Endereçamento Postal principal da Organização ou Pessoa para" +
    " o endereço";
            this.xCEP.Width = 100;
            // 
            // stLogradouro
            // 
            this.stLogradouro.DataPropertyName = "stLogradouro";
            this.stLogradouro.HeaderText = "Logradouro";
            this.stLogradouro.Items.AddRange(new object[] {
            "00-AER - AEROPORTO",
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
            "11-FORT - FORTALEZA ",
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
            "24-TRV - TRAVESSA ",
            "25-VD - VIADUTO ",
            "26-VL - VILA"});
            this.stLogradouro.Name = "stLogradouro";
            this.stLogradouro.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stLogradouro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.stLogradouro.ToolTipText = "Informar o Tipo de Logradouro para o endereço correspondente";
            // 
            // xEndereco
            // 
            this.xEndereco.DataPropertyName = "xEndereco";
            this.xEndereco.HeaderText = "Endereco";
            this.xEndereco.Name = "xEndereco";
            this.xEndereco.ToolTipText = "Informar o Endereço da organização ou pessoa.";
            // 
            // nNumero
            // 
            this.nNumero.DataPropertyName = "nNumero";
            this.nNumero.HeaderText = "Numero";
            this.nNumero.Name = "nNumero";
            this.nNumero.ToolTipText = "Informar a Cidade/Município da organização ou pessoa";
            // 
            // xComplemento
            // 
            this.xComplemento.DataPropertyName = "xComplemento";
            this.xComplemento.HeaderText = "Complemento";
            this.xComplemento.Name = "xComplemento";
            // 
            // xBairro
            // 
            this.xBairro.DataPropertyName = "xBairro";
            this.xBairro.HeaderText = "Bairro";
            this.xBairro.Name = "xBairro";
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
            this.xFusoHorario.HeaderText = "FusoHorario";
            this.xFusoHorario.Name = "xFusoHorario";
            // 
            // xCaixaPostal
            // 
            this.xCaixaPostal.DataPropertyName = "xCaixaPostal";
            this.xCaixaPostal.HeaderText = "Caixa Postal";
            this.xCaixaPostal.Name = "xCaixaPostal";
            // 
            // idCidade
            // 
            this.idCidade.DataPropertyName = "idCidade";
            this.idCidade.HeaderText = "Cidade";
            this.idCidade.Name = "idCidade";
            this.idCidade.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idCidade.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idCidade.Width = 200;
            // 
            // bsTransportadorEnderecoModel
            // 
            this.bsTransportadorEnderecoModel.DataSource = typeof(HLP.Models.Entries.Gerais.Transportador_EnderecoModel);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.kryptonPanel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(794, 312);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Tag = false;
            this.tabPage3.Text = "Contatos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.kryptonTabControl2);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(794, 312);
            this.kryptonPanel3.TabIndex = 1;
            // 
            // kryptonTabControl2
            // 
            this.kryptonTabControl2.AllowCloseButton = false;
            this.kryptonTabControl2.AllowContextButton = false;
            this.kryptonTabControl2.AllowNavigatorButtons = false;
            this.kryptonTabControl2.AllowSelectedTabHigh = false;
            this.kryptonTabControl2.BorderWidth = 1;
            this.kryptonTabControl2.Controls.Add(this.tabPage6);
            this.kryptonTabControl2.CornerRoundRadiusWidth = 12;
            this.kryptonTabControl2.CornerSymmetry = AC.ExtendedRenderer.Navigator.KryptonTabControl.CornSymmetry.Both;
            this.kryptonTabControl2.CornerType = AC.ExtendedRenderer.Toolkit.Drawing.DrawingMethods.CornerType.Rounded;
            this.kryptonTabControl2.CornerWidth = AC.ExtendedRenderer.Navigator.KryptonTabControl.CornWidth.Thin;
            this.kryptonTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonTabControl2.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.kryptonTabControl2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.kryptonTabControl2.HotTrack = true;
            this.kryptonTabControl2.Location = new System.Drawing.Point(0, 0);
            this.kryptonTabControl2.Name = "kryptonTabControl2";
            this.kryptonTabControl2.PreserveTabColor = false;
            this.kryptonTabControl2.SelectedIndex = 0;
            this.kryptonTabControl2.Size = new System.Drawing.Size(794, 312);
            this.kryptonTabControl2.TabIndex = 7;
            this.kryptonTabControl2.UseExtendedLayout = false;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage6.Controls.Add(this.kryptonPanel6);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(786, 283);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Tag = false;
            this.tabPage6.Text = "Contatos";
            // 
            // kryptonPanel6
            // 
            this.kryptonPanel6.BorderWidth = 0;
            this.kryptonPanel6.Controls.Add(this.dgvContato);
            this.kryptonPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel6.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.kryptonPanel6.GradientToogleColors = false;
            this.kryptonPanel6.GradientUseBlend = false;
            this.kryptonPanel6.GradientUseSolid = true;
            this.kryptonPanel6.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel6.Name = "kryptonPanel6";
            this.kryptonPanel6.PersistentColors = false;
            this.kryptonPanel6.Size = new System.Drawing.Size(786, 283);
            this.kryptonPanel6.TabIndex = 0;
            // 
            // dgvContato
            // 
            this.dgvContato.Altera = false;
            this.dgvContato.AutoGenerateColumns = false;
            this.dgvContato.cm = null;
            this.dgvContato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idContato_Contato});
            this.dgvContato.DataSource = this.bsTransportadorContatoModel;
            this.dgvContato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContato.DragDropLinha = false;
            this.dgvContato.Exclui = false;
            this.dgvContato.Inclui = false;
            this.dgvContato.Location = new System.Drawing.Point(0, 0);
            this.dgvContato.Name = "dgvContato";
            this.dgvContato.ReadOnly = true;
            this.dgvContato.Size = new System.Drawing.Size(786, 283);
            this.dgvContato.TabIndex = 0;
            this.dgvContato.Tag = "Transportador_Contato";
            // 
            // idContato_Contato
            // 
            this.idContato_Contato.DataPropertyName = "idContato";
            this.idContato_Contato.HeaderText = "Contato";
            this.idContato_Contato.Name = "idContato_Contato";
            this.idContato_Contato.ReadOnly = true;
            this.idContato_Contato.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idContato_Contato.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idContato_Contato.ToolTipText = "Selecione a pessoa de contato que está associada com a transportadora e cujos det" +
    "alhes são inseridos no formulário Detalhes do Contato.";
            this.idContato_Contato.Width = 350;
            // 
            // bsTransportadorContatoModel
            // 
            this.bsTransportadorContatoModel.DataSource = typeof(HLP.Models.Entries.Gerais.Transportador_ContatoModel);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.kryptonPanel2);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(794, 312);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Tag = false;
            this.tabPage4.Text = "Motoristas";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.dgvMotorista);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(794, 312);
            this.kryptonPanel2.TabIndex = 0;
            // 
            // dgvMotorista
            // 
            this.dgvMotorista.Altera = false;
            this.dgvMotorista.AutoGenerateColumns = false;
            this.dgvMotorista.cm = null;
            this.dgvMotorista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMotorista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idContato_Motorista,
            this.xRntrcDataGridViewTextBoxColumn});
            this.dgvMotorista.DataSource = this.bsTransportadorMotoristaModel;
            this.dgvMotorista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMotorista.DragDropLinha = false;
            this.dgvMotorista.Exclui = false;
            this.dgvMotorista.Inclui = false;
            this.dgvMotorista.Location = new System.Drawing.Point(0, 0);
            this.dgvMotorista.Name = "dgvMotorista";
            this.dgvMotorista.Size = new System.Drawing.Size(794, 312);
            this.dgvMotorista.TabIndex = 1;
            this.dgvMotorista.Tag = "Transportador_Motorista";
            // 
            // idContato_Motorista
            // 
            this.idContato_Motorista.DataPropertyName = "idContato";
            this.idContato_Motorista.HeaderText = "Contato";
            this.idContato_Motorista.Name = "idContato_Motorista";
            this.idContato_Motorista.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idContato_Motorista.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idContato_Motorista.ToolTipText = "Infome o Motorista buscando da tabela de contatos";
            this.idContato_Motorista.Width = 350;
            // 
            // xRntrcDataGridViewTextBoxColumn
            // 
            this.xRntrcDataGridViewTextBoxColumn.DataPropertyName = "xRntrc";
            this.xRntrcDataGridViewTextBoxColumn.HeaderText = "Rntrc";
            this.xRntrcDataGridViewTextBoxColumn.Name = "xRntrcDataGridViewTextBoxColumn";
            this.xRntrcDataGridViewTextBoxColumn.ToolTipText = "Informar o Registro Nacional de Transportadores Rodoviários de Carga";
            // 
            // bsTransportadorMotoristaModel
            // 
            this.bsTransportadorMotoristaModel.DataSource = typeof(HLP.Models.Entries.Gerais.Transportador_MotoristaModel);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.kryptonPanel5);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(794, 312);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Tag = false;
            this.tabPage5.Text = "Veículos";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // kryptonPanel5
            // 
            this.kryptonPanel5.Controls.Add(this.dgvVeiculos);
            this.kryptonPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel5.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel5.Name = "kryptonPanel5";
            this.kryptonPanel5.Size = new System.Drawing.Size(794, 312);
            this.kryptonPanel5.TabIndex = 0;
            // 
            // dgvVeiculos
            // 
            this.dgvVeiculos.Altera = false;
            this.dgvVeiculos.AutoGenerateColumns = false;
            this.dgvVeiculos.cm = null;
            this.dgvVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xPlacaVeiculo,
            this.idUf,
            this.xMarca,
            this.xModelo});
            this.dgvVeiculos.DataSource = this.bsTransportadorVeiculosModel;
            this.dgvVeiculos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVeiculos.DragDropLinha = false;
            this.dgvVeiculos.Exclui = false;
            this.dgvVeiculos.Inclui = false;
            this.dgvVeiculos.Location = new System.Drawing.Point(0, 0);
            this.dgvVeiculos.Name = "dgvVeiculos";
            this.dgvVeiculos.Size = new System.Drawing.Size(794, 312);
            this.dgvVeiculos.TabIndex = 0;
            this.dgvVeiculos.Tag = "Transportador_Veiculos";
            // 
            // xPlacaVeiculo
            // 
            this.xPlacaVeiculo.DataPropertyName = "xPlacaVeiculo";
            this.xPlacaVeiculo.HeaderText = "Placa Veiculo";
            this.xPlacaVeiculo.Name = "xPlacaVeiculo";
            this.xPlacaVeiculo.ToolTipText = "Informar a Placa do veículo, reboque, carreta, truck, etc";
            this.xPlacaVeiculo.Width = 110;
            // 
            // idUf
            // 
            this.idUf.DataPropertyName = "idUf";
            this.idUf.HeaderText = "UF";
            this.idUf.Name = "idUf";
            this.idUf.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idUf.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idUf.ToolTipText = "Informar o Unidade Federativa da placa do veículo, reboque, carreta, truck, etc.";
            this.idUf.Width = 130;
            // 
            // xMarca
            // 
            this.xMarca.DataPropertyName = "xMarca";
            this.xMarca.HeaderText = "Marca";
            this.xMarca.Name = "xMarca";
            this.xMarca.ToolTipText = "Informar a Marca ou tipo do veículo, reboque, carreta, truck, etc.";
            // 
            // xModelo
            // 
            this.xModelo.DataPropertyName = "xModelo";
            this.xModelo.HeaderText = "Modelo";
            this.xModelo.Name = "xModelo";
            this.xModelo.ToolTipText = "Informar a modelo do veículo, reboque, carreta, truck, etc.";
            // 
            // bsTransportadorVeiculosModel
            // 
            this.bsTransportadorVeiculosModel.DataSource = typeof(HLP.Models.Entries.Gerais.Transportador_VeiculosModel);
            // 
            // xRntrc
            // 
            this.xRntrc.DataPropertyName = "xRntrc";
            this.xRntrc.HeaderText = "xRntrc";
            this.xRntrc.Name = "xRntrc";
            // 
            // FormTransportadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 398);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTransportadora";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = -10;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text = "Transportador";
            this.Load += new System.EventHandler(this.FormTransportador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).EndInit();
            this.panelPadrao.ResumeLayout(false);
            this.kryptonTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.kryptonPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndereco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransportadorEnderecoModel)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.kryptonTabControl2.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.kryptonPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransportadorContatoModel)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotorista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransportadorMotoristaModel)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).EndInit();
            this.kryptonPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransportadorVeiculosModel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Comum.Components.HLP_LabelSeparator sp_Identificacao;
        private Comum.Components.HLP_TextBox txtCodigo;
        private Comum.Components.HLP_TextBox txtxCodigoAlternativo;
        private Comum.Components.HLP_TextBox txtxNome;
        private Comum.Components.HLP_TextBox txtxFantasia;
        private Comum.Components.HLP_ComboBox cbxstPessoa;
        private Comum.Components.HLP_LabelSeparator sp_Documentacao;
        private Comum.Components.HLP_MaskedTextBox mskxCnpj;
        private Comum.Components.HLP_TextBox txtxIm;
        private Comum.Components.HLP_MaskedTextBox mskxCpf;
        private Comum.Components.HLP_TextBox txtxRg;
        private Comum.Components.HLP_TextBox txtxRntrc;
        private Comum.Components.HLP_LabelSeparator sp_Telefones;
        private Comum.Components.HLP_LabelSeparator sp_identf_eletronica;
        private Comum.Components.HLP_TextBox txtxEmail;
        private Comum.Components.HLP_TextBox txtxHttp;
        private System.Windows.Forms.TabPage tabPage2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private HLP_DataGridView dgvEndereco;
        private System.Windows.Forms.BindingSource bsTransportadorEnderecoModel;
        private System.Windows.Forms.TabPage tabPage3;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private System.Windows.Forms.BindingSource bsTransportadorContatoModel;
        private System.Windows.Forms.TabPage tabPage4;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private HLP_DataGridView dgvMotorista;
        private System.Windows.Forms.TabPage tabPage5;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel5;
        private HLP_DataGridView dgvVeiculos;
        private System.Windows.Forms.BindingSource bsTransportadorVeiculosModel;
        private System.Windows.Forms.BindingSource bsTransportadorMotoristaModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn xRntrc;
        private Comum.Components.HLP_TextBox txtxTelefone1;
        private Comum.Components.HLP_TextBox txtxTelefone2;
        private Comum.Components.HLP_TextBox txtxFax;
        private System.Windows.Forms.DataGridViewComboBoxColumn stPrincipal;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNome;
        private System.Windows.Forms.DataGridViewComboBoxColumn stTipoEndereco;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewMaskedTextBoxColumn xCEP;
        private System.Windows.Forms.DataGridViewComboBoxColumn stLogradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn xEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn nNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn xComplemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn xBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn xLatitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn xLongitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFusoHorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCaixaPostal;
        private System.Windows.Forms.DataGridViewComboBoxColumn idCidade;
        private System.Windows.Forms.DataGridViewComboBoxColumn idContato_Motorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn xRntrcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xPlacaVeiculo;
        private System.Windows.Forms.DataGridViewComboBoxColumn idUf;
        private System.Windows.Forms.DataGridViewTextBoxColumn xMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn xModelo;
        private Comum.Components.HLP_ComboBox cboAtivo;
        private Comum.Components.HLP_MaskedTextBox mskxIe;
        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl2;
        private System.Windows.Forms.TabPage tabPage6;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel6;
        private HLP_DataGridView dgvContato;
        private System.Windows.Forms.DataGridViewComboBoxColumn idContato_Contato;
    }
}