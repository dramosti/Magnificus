using System.Windows.Forms;
namespace HLP.UI.Entries.Financeiro
{
    partial class FormContaBancaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContaBancaria));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.async_work = new System.ComponentModel.BackgroundWorker();
            this.tabHierarquia = new System.Windows.Forms.TabPage();
            this.kryptonPanel3 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.treeHierarquia = new System.Windows.Forms.TreeView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kryptonPanel1 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.Principal = new System.Windows.Forms.FlowLayoutPanel();
            this.hlP_LabelSeparator1_Principal = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtCodigo = new HLP.Comum.Components.HLP_TextBox();
            this.txtxNumeroConta = new HLP.Comum.Components.HLP_TextBox();
            this.txtxDescricao = new HLP.Comum.Components.HLP_TextBox();
            this.cbostConta = new HLP.Comum.Components.HLP_ComboBox();
            this.campoPesquisaidAgencia = new HLP.Comum.Components.HLP_Pesquisa();
            this.txtxTitular = new HLP.Comum.Components.HLP_TextBox();
            this.cbxstPessoa = new HLP.Comum.Components.HLP_ComboBox();
            this.mskxCNPJouCPFTitular = new HLP.Comum.Components.HLP_MaskedTextBox();
            this.cbostBloquete = new HLP.Comum.Components.HLP_ComboBox();
            this.nudnDigitosConvenio = new HLP.Comum.Components.HLP_NumericUpDown();
            this.kryptonTabControl1 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabHomeBank = new System.Windows.Forms.TabPage();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.hlP_LabelSeparator1_HomeBanking = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtxNumeroContaHomeBanking = new HLP.Comum.Components.HLP_TextBox();
            this.txtxCodigoEmpresaHomeBanking = new HLP.Comum.Components.HLP_TextBox();
            this.nudnConvenio = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudnDiasProtesto = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudnSequenciaNossoNumero = new HLP.Comum.Components.HLP_NumericUpDown();
            this.cbostZeraNossoNumero = new HLP.Comum.Components.HLP_ComboBox();
            this.nudnCarteira = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudnVariacaoCarteira = new HLP.Comum.Components.HLP_NumericUpDown();
            this.txtxEspecie = new HLP.Comum.Components.HLP_TextBox();
            this.nudnRemessaHomeBanking = new HLP.Comum.Components.HLP_NumericUpDown();
            this.cbostAceite = new HLP.Comum.Components.HLP_ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).BeginInit();
            this.panelPadrao.SuspendLayout();
            this.tabHierarquia.SuspendLayout();
            this.kryptonPanel3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.kryptonPanel1.SuspendLayout();
            this.Principal.SuspendLayout();
            this.kryptonTabControl1.SuspendLayout();
            this.tabHomeBank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(945, 460);
            // 
            // panelPadrao
            // 
            this.panelPadrao.Controls.Add(this.kryptonTabControl1);
            this.panelPadrao.Size = new System.Drawing.Size(943, 436);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1347893340_Bank.ico");
            this.imageList1.Images.SetKeyName(1, "1347891492_bank.ico");
            this.imageList1.Images.SetKeyName(2, "1346873929_open_safety_box.ico");
            // 
            // async_work
            // 
            this.async_work.WorkerSupportsCancellation = true;
            this.async_work.DoWork += new System.ComponentModel.DoWorkEventHandler(this.async_work_DoWork);
            // 
            // tabHierarquia
            // 
            this.tabHierarquia.BackColor = System.Drawing.SystemColors.Window;
            this.tabHierarquia.Controls.Add(this.kryptonPanel3);
            this.tabHierarquia.Location = new System.Drawing.Point(4, 25);
            this.tabHierarquia.Margin = new System.Windows.Forms.Padding(0);
            this.tabHierarquia.Name = "tabHierarquia";
            this.tabHierarquia.Size = new System.Drawing.Size(804, 225);
            this.tabHierarquia.TabIndex = 2;
            this.tabHierarquia.Tag = false;
            this.tabHierarquia.Text = "Hierarquia";
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.BorderWidth = 0;
            this.kryptonPanel3.Controls.Add(this.treeHierarquia);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel3.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.kryptonPanel3.GradientToogleColors = false;
            this.kryptonPanel3.GradientUseBlend = false;
            this.kryptonPanel3.GradientUseSolid = true;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.PersistentColors = false;
            this.kryptonPanel3.Size = new System.Drawing.Size(804, 225);
            this.kryptonPanel3.TabIndex = 2;
            // 
            // treeHierarquia
            // 
            this.treeHierarquia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeHierarquia.ImageIndex = 0;
            this.treeHierarquia.ImageList = this.imageList1;
            this.treeHierarquia.ItemHeight = 21;
            this.treeHierarquia.Location = new System.Drawing.Point(0, 0);
            this.treeHierarquia.Name = "treeHierarquia";
            this.treeHierarquia.SelectedImageIndex = 0;
            this.treeHierarquia.Size = new System.Drawing.Size(804, 225);
            this.treeHierarquia.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Controls.Add(this.kryptonPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(929, 401);
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
            this.kryptonPanel1.Size = new System.Drawing.Size(929, 401);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // Principal
            // 
            this.Principal.AutoScroll = true;
            this.Principal.BackColor = System.Drawing.Color.Transparent;
            this.Principal.Controls.Add(this.hlP_LabelSeparator1_Principal);
            this.Principal.Controls.Add(this.txtCodigo);
            this.Principal.Controls.Add(this.txtxNumeroConta);
            this.Principal.Controls.Add(this.txtxDescricao);
            this.Principal.Controls.Add(this.cbostConta);
            this.Principal.Controls.Add(this.campoPesquisaidAgencia);
            this.Principal.Controls.Add(this.txtxTitular);
            this.Principal.Controls.Add(this.cbxstPessoa);
            this.Principal.Controls.Add(this.mskxCNPJouCPFTitular);
            this.Principal.Controls.Add(this.cbostBloquete);
            this.Principal.Controls.Add(this.nudnDigitosConvenio);
            this.Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Principal.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Principal.Location = new System.Drawing.Point(0, 0);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(929, 401);
            this.Principal.TabIndex = 3;
            this.Principal.Tag = "Principal";
            this.Principal.Paint += new System.Windows.Forms.PaintEventHandler(this.Principal_Paint);
            // 
            // hlP_LabelSeparator1_Principal
            // 
            this.hlP_LabelSeparator1_Principal._LabelText = "Principal";
            this.hlP_LabelSeparator1_Principal._TamanhoMaiorLabel = 0;
            this.hlP_LabelSeparator1_Principal.BackColor = System.Drawing.Color.Transparent;
            this.hlP_LabelSeparator1_Principal.Location = new System.Drawing.Point(3, 3);
            this.hlP_LabelSeparator1_Principal.Name = "hlP_LabelSeparator1_Principal";
            this.hlP_LabelSeparator1_Principal.Size = new System.Drawing.Size(540, 18);
            this.hlP_LabelSeparator1_Principal.TabIndex = 26;
            this.hlP_LabelSeparator1_Principal.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo._Field = "idContaBancaria";
            this.txtCodigo._LabelGroup = this.hlP_LabelSeparator1_Principal;
            this.txtCodigo._LabelText = "Código";
            this.txtCodigo._Multiline = false;
            this.txtCodigo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtCodigo._Password = false;
            this.txtCodigo._Regex = null;
            this.txtCodigo._Table = "Conta_bancaria";
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
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(152, 21);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtxNumeroConta
            // 
            this.txtxNumeroConta._Field = "xNumeroConta";
            this.txtxNumeroConta._LabelGroup = this.hlP_LabelSeparator1_Principal;
            this.txtxNumeroConta._LabelText = "Número da conta";
            this.txtxNumeroConta._Multiline = false;
            this.txtxNumeroConta._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxNumeroConta._Password = false;
            this.txtxNumeroConta._Regex = null;
            this.txtxNumeroConta._Table = "Conta_bancaria";
            this.txtxNumeroConta._TamanhoComponente = 210;
            this.txtxNumeroConta._TamanhoMaiorLabel = 150;
            this.txtxNumeroConta._Visible = true;
            this.txtxNumeroConta.BackColor = System.Drawing.Color.Transparent;
            this.txtxNumeroConta.Base = null;
            this.txtxNumeroConta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxNumeroConta.Color = System.Drawing.Color.White;
            this.txtxNumeroConta.Location = new System.Drawing.Point(57, 54);
            this.txtxNumeroConta.Margin = new System.Windows.Forms.Padding(57, 3, 15, 3);
            this.txtxNumeroConta.MaxLength = 32767;
            this.txtxNumeroConta.Name = "txtxNumeroConta";
            this.txtxNumeroConta.ReadOnly = false;
            this.txtxNumeroConta.Size = new System.Drawing.Size(306, 21);
            this.txtxNumeroConta.TabIndex = 3;
            // 
            // txtxDescricao
            // 
            this.txtxDescricao._Field = "xDescricao";
            this.txtxDescricao._LabelGroup = this.hlP_LabelSeparator1_Principal;
            this.txtxDescricao._LabelText = "Descrição ";
            this.txtxDescricao._Multiline = false;
            this.txtxDescricao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxDescricao._Password = false;
            this.txtxDescricao._Regex = null;
            this.txtxDescricao._Table = "Conta_bancaria";
            this.txtxDescricao._TamanhoComponente = 312;
            this.txtxDescricao._TamanhoMaiorLabel = 150;
            this.txtxDescricao._Visible = true;
            this.txtxDescricao.BackColor = System.Drawing.Color.Transparent;
            this.txtxDescricao.Base = null;
            this.txtxDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxDescricao.Color = System.Drawing.Color.White;
            this.txtxDescricao.Location = new System.Drawing.Point(94, 81);
            this.txtxDescricao.Margin = new System.Windows.Forms.Padding(94, 3, 15, 3);
            this.txtxDescricao.MaxLength = 32767;
            this.txtxDescricao.Name = "txtxDescricao";
            this.txtxDescricao.ReadOnly = false;
            this.txtxDescricao.Size = new System.Drawing.Size(371, 21);
            this.txtxDescricao.TabIndex = 9;
            // 
            // cbostConta
            // 
            this.cbostConta._Field = "stConta";
            this.cbostConta._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostConta._Itens")));
            this.cbostConta._LabelGroup = this.hlP_LabelSeparator1_Principal;
            this.cbostConta._LabelText = "Tipo da conta";
            this.cbostConta._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostConta._Regex = null;
            this.cbostConta._situacao = false;
            this.cbostConta._Table = "Conta_bancaria";
            this.cbostConta._TamanhoComponente = 149;
            this.cbostConta._TamanhoMaiorLabel = 150;
            this.cbostConta._Visible = true;
            this.cbostConta.BackColor = System.Drawing.Color.Transparent;
            this.cbostConta.Base = null;
            this.cbostConta.Color = System.Drawing.Color.White;
            this.cbostConta.DataSource = null;
            this.cbostConta.DisplayMember = "DisplayMember";
            this.cbostConta.Location = new System.Drawing.Point(76, 108);
            this.cbostConta.Margin = new System.Windows.Forms.Padding(76, 3, 15, 3);
            this.cbostConta.Name = "cbostConta";
            this.cbostConta.SelectedIndex = -1;
            this.cbostConta.SelectedValue = 0;
            this.cbostConta.Size = new System.Drawing.Size(226, 21);
            this.cbostConta.TabIndex = 8;
            this.cbostConta.ValueMember = "ValueMember";
            this.cbostConta._SelectedValueChanged += new System.EventHandler(this.cbostConta__SelectedValueChanged);
            // 
            // campoPesquisaidAgencia
            // 
            this.campoPesquisaidAgencia._Field = "idAgencia";
            this.campoPesquisaidAgencia._LabelGroup = this.hlP_LabelSeparator1_Principal;
            this.campoPesquisaidAgencia._LabelText = "Agência";
            this.campoPesquisaidAgencia._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("campoPesquisaidAgencia._ListaCamposDisplay")));
            this.campoPesquisaidAgencia._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("campoPesquisaidAgencia._ListaValoresDisplay")));
            this.campoPesquisaidAgencia._NomeCampoPK = "ID";
            this.campoPesquisaidAgencia._NomeFormCadastroOriginal = "FormAgencia";
            this.campoPesquisaidAgencia._NomeView = "vwAgencia";
            this.campoPesquisaidAgencia._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.campoPesquisaidAgencia._Regex = null;
            this.campoPesquisaidAgencia._Table = "Conta_bancaria";
            this.campoPesquisaidAgencia._TamanhoComponente = 300;
            this.campoPesquisaidAgencia._TamanhoMaiorLabel = 150;
            this.campoPesquisaidAgencia._Vinculado = false;
            this.campoPesquisaidAgencia._Visible = true;
            this.campoPesquisaidAgencia.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.campoPesquisaidAgencia.BackColor = System.Drawing.Color.Transparent;
            this.campoPesquisaidAgencia.Base = null;
            this.campoPesquisaidAgencia.Location = new System.Drawing.Point(105, 135);
            this.campoPesquisaidAgencia.Margin = new System.Windows.Forms.Padding(105, 3, 15, 3);
            this.campoPesquisaidAgencia.Name = "campoPesquisaidAgencia";
            this.campoPesquisaidAgencia.ReadOnly = false;
            this.campoPesquisaidAgencia.Size = new System.Drawing.Size(438, 21);
            this.campoPesquisaidAgencia.TabIndex = 5;
            this.campoPesquisaidAgencia.Value = 0;
            // 
            // txtxTitular
            // 
            this.txtxTitular._Field = "xTitular";
            this.txtxTitular._LabelGroup = this.hlP_LabelSeparator1_Principal;
            this.txtxTitular._LabelText = "Titular";
            this.txtxTitular._Multiline = false;
            this.txtxTitular._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxTitular._Password = false;
            this.txtxTitular._Regex = null;
            this.txtxTitular._Table = "Conta_bancaria";
            this.txtxTitular._TamanhoComponente = 210;
            this.txtxTitular._TamanhoMaiorLabel = 150;
            this.txtxTitular._Visible = true;
            this.txtxTitular.BackColor = System.Drawing.Color.Transparent;
            this.txtxTitular.Base = null;
            this.txtxTitular.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxTitular.Color = System.Drawing.Color.White;
            this.txtxTitular.Location = new System.Drawing.Point(114, 162);
            this.txtxTitular.Margin = new System.Windows.Forms.Padding(114, 3, 15, 3);
            this.txtxTitular.MaxLength = 32767;
            this.txtxTitular.Name = "txtxTitular";
            this.txtxTitular.ReadOnly = false;
            this.txtxTitular.Size = new System.Drawing.Size(249, 21);
            this.txtxTitular.TabIndex = 3;
            // 
            // cbxstPessoa
            // 
            this.cbxstPessoa._Help = "Este campo define se é pessoa jurídica ou física";
            this.cbxstPessoa._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbxstPessoa._Itens")));
            this.cbxstPessoa._LabelGroup = this.hlP_LabelSeparator1_Principal;
            this.cbxstPessoa._LabelText = "Pessoa jurídica?";
            this.cbxstPessoa._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbxstPessoa._Regex = null;
            this.cbxstPessoa._situacao = true;
            this.cbxstPessoa._TamanhoComponente = 80;
            this.cbxstPessoa._TamanhoMaiorLabel = 150;
            this.cbxstPessoa._Visible = true;
            this.cbxstPessoa.BackColor = System.Drawing.Color.Transparent;
            this.cbxstPessoa.Base = null;
            this.cbxstPessoa.Color = System.Drawing.Color.White;
            this.cbxstPessoa.DataSource = null;
            this.cbxstPessoa.DisplayMember = "DisplayMember";
            this.cbxstPessoa.Location = new System.Drawing.Point(65, 189);
            this.cbxstPessoa.Margin = new System.Windows.Forms.Padding(65, 3, 15, 3);
            this.cbxstPessoa.Name = "cbxstPessoa";
            this.cbxstPessoa.SelectedIndex = -1;
            this.cbxstPessoa.SelectedValue = 0;
            this.cbxstPessoa.Size = new System.Drawing.Size(168, 21);
            this.cbxstPessoa.TabIndex = 24;
            this.cbxstPessoa.ValueMember = "ValueMember";
            this.cbxstPessoa._SelectedIndexChanged += new System.EventHandler(this.cbxstPessoa__SelectedIndexChanged);
            // 
            // mskxCNPJouCPFTitular
            // 
            this.mskxCNPJouCPFTitular._Field = "xCNPJouCPFTitular";
            this.mskxCNPJouCPFTitular._Help = "Número do cnpj ou do cpf titular";
            this.mskxCNPJouCPFTitular._LabelGroup = this.hlP_LabelSeparator1_Principal;
            this.mskxCNPJouCPFTitular._LabelText = "Cnpj ou cpf titular";
            this.mskxCNPJouCPFTitular._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.mskxCNPJouCPFTitular._Regex = null;
            this.mskxCNPJouCPFTitular._Table = "Conta_bancaria";
            this.mskxCNPJouCPFTitular._TamanhoComponente = 124;
            this.mskxCNPJouCPFTitular._TamanhoMaiorLabel = 150;
            this.mskxCNPJouCPFTitular._TpValidacao = HLP.Comum.Components.HLP_MaskedTextBox.TipoValidacao.DEFAULT;
            this.mskxCNPJouCPFTitular._UF = null;
            this.mskxCNPJouCPFTitular._Visible = true;
            this.mskxCNPJouCPFTitular.BackColor = System.Drawing.Color.Transparent;
            this.mskxCNPJouCPFTitular.Base = null;
            this.mskxCNPJouCPFTitular.Color = System.Drawing.Color.White;
            this.mskxCNPJouCPFTitular.Location = new System.Drawing.Point(52, 216);
            this.mskxCNPJouCPFTitular.Margin = new System.Windows.Forms.Padding(52, 3, 15, 3);
            this.mskxCNPJouCPFTitular.Mask = "";
            this.mskxCNPJouCPFTitular.MaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mskxCNPJouCPFTitular.MaxLength = 32767;
            this.mskxCNPJouCPFTitular.Name = "mskxCNPJouCPFTitular";
            this.mskxCNPJouCPFTitular.ReadOnly = false;
            this.mskxCNPJouCPFTitular.Size = new System.Drawing.Size(225, 21);
            this.mskxCNPJouCPFTitular.TabIndex = 25;
            // 
            // cbostBloquete
            // 
            this.cbostBloquete._Field = "stBloquete";
            this.cbostBloquete._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostBloquete._Itens")));
            this.cbostBloquete._LabelGroup = this.hlP_LabelSeparator1_Principal;
            this.cbostBloquete._LabelText = "Reemite bloquete?";
            this.cbostBloquete._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostBloquete._Regex = null;
            this.cbostBloquete._situacao = true;
            this.cbostBloquete._Table = "Conta_bancaria";
            this.cbostBloquete._TamanhoComponente = 80;
            this.cbostBloquete._TamanhoMaiorLabel = 150;
            this.cbostBloquete._Visible = true;
            this.cbostBloquete.BackColor = System.Drawing.Color.Transparent;
            this.cbostBloquete.Base = null;
            this.cbostBloquete.Color = System.Drawing.Color.White;
            this.cbostBloquete.DataSource = null;
            this.cbostBloquete.DisplayMember = "DisplayMember";
            this.cbostBloquete.Location = new System.Drawing.Point(50, 243);
            this.cbostBloquete.Margin = new System.Windows.Forms.Padding(50, 3, 15, 3);
            this.cbostBloquete.Name = "cbostBloquete";
            this.cbostBloquete.SelectedIndex = -1;
            this.cbostBloquete.SelectedValue = 0;
            this.cbostBloquete.Size = new System.Drawing.Size(183, 21);
            this.cbostBloquete.TabIndex = 14;
            this.cbostBloquete.ValueMember = "ValueMember";
            // 
            // nudnDigitosConvenio
            // 
            this.nudnDigitosConvenio._Field = "nDigitosConvenio";
            this.nudnDigitosConvenio._LabelGroup = this.hlP_LabelSeparator1_Principal;
            this.nudnDigitosConvenio._LabelText = "Digito convênio";
            this.nudnDigitosConvenio._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudnDigitosConvenio._Regex = null;
            this.nudnDigitosConvenio._Table = "Conta_bancaria";
            this.nudnDigitosConvenio._TamanhoComponente = 121;
            this.nudnDigitosConvenio._TamanhoMaiorLabel = 150;
            this.nudnDigitosConvenio._Visible = true;
            this.nudnDigitosConvenio.BackColor = System.Drawing.Color.Transparent;
            this.nudnDigitosConvenio.Base = null;
            this.nudnDigitosConvenio.Color = System.Drawing.Color.White;
            this.nudnDigitosConvenio.DecimalPlaces = 2;
            this.nudnDigitosConvenio.Location = new System.Drawing.Point(64, 270);
            this.nudnDigitosConvenio.Margin = new System.Windows.Forms.Padding(64, 3, 15, 3);
            this.nudnDigitosConvenio.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudnDigitosConvenio.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudnDigitosConvenio.Name = "nudnDigitosConvenio";
            this.nudnDigitosConvenio.ReadOnly = false;
            this.nudnDigitosConvenio.Size = new System.Drawing.Size(210, 22);
            this.nudnDigitosConvenio.TabIndex = 15;
            this.nudnDigitosConvenio.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudnDigitosConvenio.ValueInt = 0;
            // 
            // kryptonTabControl1
            // 
            this.kryptonTabControl1.AllowCloseButton = false;
            this.kryptonTabControl1.AllowContextButton = true;
            this.kryptonTabControl1.AllowNavigatorButtons = false;
            this.kryptonTabControl1.AllowSelectedTabHigh = false;
            this.kryptonTabControl1.BorderWidth = 1;
            this.kryptonTabControl1.Controls.Add(this.tabPage1);
            this.kryptonTabControl1.Controls.Add(this.tabHomeBank);
            this.kryptonTabControl1.Controls.Add(this.tabHierarquia);
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
            this.kryptonTabControl1.Size = new System.Drawing.Size(937, 430);
            this.kryptonTabControl1.TabIndex = 4;
            this.kryptonTabControl1.UseExtendedLayout = false;
            this.kryptonTabControl1.SelectedIndexChanged += new System.EventHandler(this.kryptonTabControl1_SelectedIndexChanged);
            // 
            // tabHomeBank
            // 
            this.tabHomeBank.Controls.Add(this.kryptonPanel2);
            this.tabHomeBank.Location = new System.Drawing.Point(4, 25);
            this.tabHomeBank.Margin = new System.Windows.Forms.Padding(0);
            this.tabHomeBank.Name = "tabHomeBank";
            this.tabHomeBank.Size = new System.Drawing.Size(804, 225);
            this.tabHomeBank.TabIndex = 3;
            this.tabHomeBank.Tag = false;
            this.tabHomeBank.Text = "Home Banking";
            this.tabHomeBank.UseVisualStyleBackColor = true;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.flowLayoutPanel1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(804, 225);
            this.kryptonPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.hlP_LabelSeparator1_HomeBanking);
            this.flowLayoutPanel1.Controls.Add(this.txtxNumeroContaHomeBanking);
            this.flowLayoutPanel1.Controls.Add(this.txtxCodigoEmpresaHomeBanking);
            this.flowLayoutPanel1.Controls.Add(this.nudnConvenio);
            this.flowLayoutPanel1.Controls.Add(this.nudnDiasProtesto);
            this.flowLayoutPanel1.Controls.Add(this.nudnSequenciaNossoNumero);
            this.flowLayoutPanel1.Controls.Add(this.cbostZeraNossoNumero);
            this.flowLayoutPanel1.Controls.Add(this.nudnCarteira);
            this.flowLayoutPanel1.Controls.Add(this.nudnVariacaoCarteira);
            this.flowLayoutPanel1.Controls.Add(this.txtxEspecie);
            this.flowLayoutPanel1.Controls.Add(this.nudnRemessaHomeBanking);
            this.flowLayoutPanel1.Controls.Add(this.cbostAceite);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(804, 225);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // hlP_LabelSeparator1_HomeBanking
            // 
            this.hlP_LabelSeparator1_HomeBanking._LabelText = "Home banking";
            this.hlP_LabelSeparator1_HomeBanking._TamanhoMaiorLabel = 0;
            this.hlP_LabelSeparator1_HomeBanking.BackColor = System.Drawing.Color.Transparent;
            this.hlP_LabelSeparator1_HomeBanking.Location = new System.Drawing.Point(3, 3);
            this.hlP_LabelSeparator1_HomeBanking.Name = "hlP_LabelSeparator1_HomeBanking";
            this.hlP_LabelSeparator1_HomeBanking.Size = new System.Drawing.Size(300, 18);
            this.hlP_LabelSeparator1_HomeBanking.TabIndex = 39;
            this.hlP_LabelSeparator1_HomeBanking.TabStop = false;
            // 
            // txtxNumeroContaHomeBanking
            // 
            this.txtxNumeroContaHomeBanking._Field = "xNumeroContaHomeBanking";
            this.txtxNumeroContaHomeBanking._LabelGroup = this.hlP_LabelSeparator1_HomeBanking;
            this.txtxNumeroContaHomeBanking._LabelText = "Nº conta para home banking";
            this.txtxNumeroContaHomeBanking._Multiline = false;
            this.txtxNumeroContaHomeBanking._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxNumeroContaHomeBanking._Password = false;
            this.txtxNumeroContaHomeBanking._Regex = null;
            this.txtxNumeroContaHomeBanking._Table = "Conta_bancaria";
            this.txtxNumeroContaHomeBanking._TamanhoComponente = 216;
            this.txtxNumeroContaHomeBanking._TamanhoMaiorLabel = 250;
            this.txtxNumeroContaHomeBanking._Visible = true;
            this.txtxNumeroContaHomeBanking.BackColor = System.Drawing.Color.Transparent;
            this.txtxNumeroContaHomeBanking.Base = null;
            this.txtxNumeroContaHomeBanking.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxNumeroContaHomeBanking.Color = System.Drawing.Color.White;
            this.txtxNumeroContaHomeBanking.Location = new System.Drawing.Point(97, 27);
            this.txtxNumeroContaHomeBanking.Margin = new System.Windows.Forms.Padding(97, 3, 15, 3);
            this.txtxNumeroContaHomeBanking.MaxLength = 32767;
            this.txtxNumeroContaHomeBanking.Name = "txtxNumeroContaHomeBanking";
            this.txtxNumeroContaHomeBanking.ReadOnly = false;
            this.txtxNumeroContaHomeBanking.Size = new System.Drawing.Size(372, 21);
            this.txtxNumeroContaHomeBanking.TabIndex = 28;
            // 
            // txtxCodigoEmpresaHomeBanking
            // 
            this.txtxCodigoEmpresaHomeBanking._Field = "xCodigoEmpresaHomeBanking";
            this.txtxCodigoEmpresaHomeBanking._LabelGroup = this.hlP_LabelSeparator1_HomeBanking;
            this.txtxCodigoEmpresaHomeBanking._LabelText = "Código da empresa para o home banking";
            this.txtxCodigoEmpresaHomeBanking._Multiline = false;
            this.txtxCodigoEmpresaHomeBanking._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxCodigoEmpresaHomeBanking._Password = false;
            this.txtxCodigoEmpresaHomeBanking._Regex = null;
            this.txtxCodigoEmpresaHomeBanking._Table = "Conta_bancaria";
            this.txtxCodigoEmpresaHomeBanking._TamanhoComponente = 220;
            this.txtxCodigoEmpresaHomeBanking._TamanhoMaiorLabel = 250;
            this.txtxCodigoEmpresaHomeBanking._Visible = true;
            this.txtxCodigoEmpresaHomeBanking.BackColor = System.Drawing.Color.Transparent;
            this.txtxCodigoEmpresaHomeBanking.Base = null;
            this.txtxCodigoEmpresaHomeBanking.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxCodigoEmpresaHomeBanking.Color = System.Drawing.Color.White;
            this.txtxCodigoEmpresaHomeBanking.Location = new System.Drawing.Point(32, 54);
            this.txtxCodigoEmpresaHomeBanking.Margin = new System.Windows.Forms.Padding(32, 3, 15, 3);
            this.txtxCodigoEmpresaHomeBanking.MaxLength = 32767;
            this.txtxCodigoEmpresaHomeBanking.Name = "txtxCodigoEmpresaHomeBanking";
            this.txtxCodigoEmpresaHomeBanking.ReadOnly = false;
            this.txtxCodigoEmpresaHomeBanking.Size = new System.Drawing.Size(441, 21);
            this.txtxCodigoEmpresaHomeBanking.TabIndex = 29;
            // 
            // nudnConvenio
            // 
            this.nudnConvenio._Field = "nConvenio";
            this.nudnConvenio._LabelGroup = this.hlP_LabelSeparator1_HomeBanking;
            this.nudnConvenio._LabelText = "Convênio home banking";
            this.nudnConvenio._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudnConvenio._Regex = null;
            this.nudnConvenio._Table = "Conta_bancaria";
            this.nudnConvenio._TamanhoComponente = 123;
            this.nudnConvenio._TamanhoMaiorLabel = 250;
            this.nudnConvenio._Visible = true;
            this.nudnConvenio.BackColor = System.Drawing.Color.Transparent;
            this.nudnConvenio.Base = null;
            this.nudnConvenio.Color = System.Drawing.Color.White;
            this.nudnConvenio.DecimalPlaces = 2;
            this.nudnConvenio.Location = new System.Drawing.Point(119, 81);
            this.nudnConvenio.Margin = new System.Windows.Forms.Padding(119, 3, 15, 3);
            this.nudnConvenio.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudnConvenio.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudnConvenio.Name = "nudnConvenio";
            this.nudnConvenio.ReadOnly = false;
            this.nudnConvenio.Size = new System.Drawing.Size(257, 22);
            this.nudnConvenio.TabIndex = 30;
            this.nudnConvenio.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudnConvenio.ValueInt = 0;
            // 
            // nudnDiasProtesto
            // 
            this.nudnDiasProtesto._Field = "nDiasProtesto";
            this.nudnDiasProtesto._LabelGroup = this.hlP_LabelSeparator1_HomeBanking;
            this.nudnDiasProtesto._LabelText = "Dias para protesto";
            this.nudnDiasProtesto._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudnDiasProtesto._Regex = null;
            this.nudnDiasProtesto._Table = "Conta_bancaria";
            this.nudnDiasProtesto._TamanhoComponente = 122;
            this.nudnDiasProtesto._TamanhoMaiorLabel = 250;
            this.nudnDiasProtesto._Visible = true;
            this.nudnDiasProtesto.BackColor = System.Drawing.Color.Transparent;
            this.nudnDiasProtesto.Base = null;
            this.nudnDiasProtesto.Color = System.Drawing.Color.White;
            this.nudnDiasProtesto.DecimalPlaces = 2;
            this.nudnDiasProtesto.Location = new System.Drawing.Point(151, 109);
            this.nudnDiasProtesto.Margin = new System.Windows.Forms.Padding(151, 3, 15, 3);
            this.nudnDiasProtesto.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudnDiasProtesto.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudnDiasProtesto.Name = "nudnDiasProtesto";
            this.nudnDiasProtesto.ReadOnly = false;
            this.nudnDiasProtesto.Size = new System.Drawing.Size(224, 22);
            this.nudnDiasProtesto.TabIndex = 31;
            this.nudnDiasProtesto.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudnDiasProtesto.ValueInt = 0;
            // 
            // nudnSequenciaNossoNumero
            // 
            this.nudnSequenciaNossoNumero._Field = "nSequenciaNossoNumero";
            this.nudnSequenciaNossoNumero._LabelGroup = this.hlP_LabelSeparator1_HomeBanking;
            this.nudnSequenciaNossoNumero._LabelText = "Sequência do nosso número";
            this.nudnSequenciaNossoNumero._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudnSequenciaNossoNumero._Regex = null;
            this.nudnSequenciaNossoNumero._Table = "Conta_bancaria";
            this.nudnSequenciaNossoNumero._TamanhoComponente = 125;
            this.nudnSequenciaNossoNumero._TamanhoMaiorLabel = 250;
            this.nudnSequenciaNossoNumero._Visible = true;
            this.nudnSequenciaNossoNumero.BackColor = System.Drawing.Color.Transparent;
            this.nudnSequenciaNossoNumero.Base = null;
            this.nudnSequenciaNossoNumero.Color = System.Drawing.Color.White;
            this.nudnSequenciaNossoNumero.DecimalPlaces = 2;
            this.nudnSequenciaNossoNumero.Location = new System.Drawing.Point(99, 137);
            this.nudnSequenciaNossoNumero.Margin = new System.Windows.Forms.Padding(99, 3, 15, 3);
            this.nudnSequenciaNossoNumero.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudnSequenciaNossoNumero.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudnSequenciaNossoNumero.Name = "nudnSequenciaNossoNumero";
            this.nudnSequenciaNossoNumero.ReadOnly = false;
            this.nudnSequenciaNossoNumero.Size = new System.Drawing.Size(279, 22);
            this.nudnSequenciaNossoNumero.TabIndex = 32;
            this.nudnSequenciaNossoNumero.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudnSequenciaNossoNumero.ValueInt = 0;
            // 
            // cbostZeraNossoNumero
            // 
            this.cbostZeraNossoNumero._Field = "stZeraNossoNumero";
            this.cbostZeraNossoNumero._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostZeraNossoNumero._Itens")));
            this.cbostZeraNossoNumero._LabelGroup = this.hlP_LabelSeparator1_HomeBanking;
            this.cbostZeraNossoNumero._LabelText = "Zera a sequência do nosso número?";
            this.cbostZeraNossoNumero._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostZeraNossoNumero._Regex = null;
            this.cbostZeraNossoNumero._situacao = true;
            this.cbostZeraNossoNumero._Table = "Conta_bancaria";
            this.cbostZeraNossoNumero._TamanhoComponente = 80;
            this.cbostZeraNossoNumero._TamanhoMaiorLabel = 250;
            this.cbostZeraNossoNumero._Visible = true;
            this.cbostZeraNossoNumero.BackColor = System.Drawing.Color.Transparent;
            this.cbostZeraNossoNumero.Base = null;
            this.cbostZeraNossoNumero.Color = System.Drawing.Color.White;
            this.cbostZeraNossoNumero.DataSource = null;
            this.cbostZeraNossoNumero.DisplayMember = "DisplayMember";
            this.cbostZeraNossoNumero.Location = new System.Drawing.Point(61, 165);
            this.cbostZeraNossoNumero.Margin = new System.Windows.Forms.Padding(61, 3, 15, 3);
            this.cbostZeraNossoNumero.Name = "cbostZeraNossoNumero";
            this.cbostZeraNossoNumero.SelectedIndex = -1;
            this.cbostZeraNossoNumero.SelectedValue = 0;
            this.cbostZeraNossoNumero.Size = new System.Drawing.Size(272, 21);
            this.cbostZeraNossoNumero.TabIndex = 33;
            this.cbostZeraNossoNumero.ValueMember = "ValueMember";
            // 
            // nudnCarteira
            // 
            this.nudnCarteira._Field = "nCarteira";
            this.nudnCarteira._LabelGroup = this.hlP_LabelSeparator1_HomeBanking;
            this.nudnCarteira._LabelText = "Carteira";
            this.nudnCarteira._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudnCarteira._Regex = null;
            this.nudnCarteira._Table = "Conta_bancaria";
            this.nudnCarteira._TamanhoComponente = 119;
            this.nudnCarteira._TamanhoMaiorLabel = 250;
            this.nudnCarteira._Visible = true;
            this.nudnCarteira.BackColor = System.Drawing.Color.Transparent;
            this.nudnCarteira.Base = null;
            this.nudnCarteira.Color = System.Drawing.Color.White;
            this.nudnCarteira.DecimalPlaces = 2;
            this.nudnCarteira.Location = new System.Drawing.Point(206, 192);
            this.nudnCarteira.Margin = new System.Windows.Forms.Padding(206, 3, 15, 3);
            this.nudnCarteira.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudnCarteira.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudnCarteira.Name = "nudnCarteira";
            this.nudnCarteira.ReadOnly = false;
            this.nudnCarteira.Size = new System.Drawing.Size(166, 22);
            this.nudnCarteira.TabIndex = 34;
            this.nudnCarteira.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudnCarteira.ValueInt = 0;
            // 
            // nudnVariacaoCarteira
            // 
            this.nudnVariacaoCarteira._Field = "nVariacaoCarteira";
            this.nudnVariacaoCarteira._LabelGroup = this.hlP_LabelSeparator1_HomeBanking;
            this.nudnVariacaoCarteira._LabelText = "Variação da carteira";
            this.nudnVariacaoCarteira._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudnVariacaoCarteira._Regex = null;
            this.nudnVariacaoCarteira._Table = "Conta_bancaria";
            this.nudnVariacaoCarteira._TamanhoComponente = 123;
            this.nudnVariacaoCarteira._TamanhoMaiorLabel = 250;
            this.nudnVariacaoCarteira._Visible = true;
            this.nudnVariacaoCarteira.BackColor = System.Drawing.Color.Transparent;
            this.nudnVariacaoCarteira.Base = null;
            this.nudnVariacaoCarteira.Color = System.Drawing.Color.White;
            this.nudnVariacaoCarteira.DecimalPlaces = 2;
            this.nudnVariacaoCarteira.Location = new System.Drawing.Point(633, 3);
            this.nudnVariacaoCarteira.Margin = new System.Windows.Forms.Padding(145, 3, 15, 3);
            this.nudnVariacaoCarteira.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudnVariacaoCarteira.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudnVariacaoCarteira.Name = "nudnVariacaoCarteira";
            this.nudnVariacaoCarteira.ReadOnly = false;
            this.nudnVariacaoCarteira.Size = new System.Drawing.Size(231, 22);
            this.nudnVariacaoCarteira.TabIndex = 35;
            this.nudnVariacaoCarteira.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudnVariacaoCarteira.ValueInt = 0;
            // 
            // txtxEspecie
            // 
            this.txtxEspecie._Field = "xEspecie";
            this.txtxEspecie._LabelGroup = this.hlP_LabelSeparator1_HomeBanking;
            this.txtxEspecie._LabelText = "Espécie";
            this.txtxEspecie._Multiline = false;
            this.txtxEspecie._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxEspecie._Password = false;
            this.txtxEspecie._Regex = null;
            this.txtxEspecie._Table = "Conta_bancaria";
            this.txtxEspecie._TamanhoComponente = 210;
            this.txtxEspecie._TamanhoMaiorLabel = 250;
            this.txtxEspecie._Visible = true;
            this.txtxEspecie.BackColor = System.Drawing.Color.Transparent;
            this.txtxEspecie.Base = null;
            this.txtxEspecie.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxEspecie.Color = System.Drawing.Color.White;
            this.txtxEspecie.Location = new System.Drawing.Point(696, 31);
            this.txtxEspecie.Margin = new System.Windows.Forms.Padding(208, 3, 15, 3);
            this.txtxEspecie.MaxLength = 32767;
            this.txtxEspecie.Name = "txtxEspecie";
            this.txtxEspecie.ReadOnly = false;
            this.txtxEspecie.Size = new System.Drawing.Size(255, 21);
            this.txtxEspecie.TabIndex = 37;
            // 
            // nudnRemessaHomeBanking
            // 
            this.nudnRemessaHomeBanking._Field = "nRemessaHomeBanking";
            this.nudnRemessaHomeBanking._LabelGroup = this.hlP_LabelSeparator1_HomeBanking;
            this.nudnRemessaHomeBanking._LabelText = "Numero da remessa";
            this.nudnRemessaHomeBanking._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudnRemessaHomeBanking._Regex = null;
            this.nudnRemessaHomeBanking._Table = "Conta_bancaria";
            this.nudnRemessaHomeBanking._TamanhoComponente = 125;
            this.nudnRemessaHomeBanking._TamanhoMaiorLabel = 250;
            this.nudnRemessaHomeBanking._Visible = true;
            this.nudnRemessaHomeBanking.BackColor = System.Drawing.Color.Transparent;
            this.nudnRemessaHomeBanking.Base = null;
            this.nudnRemessaHomeBanking.Color = System.Drawing.Color.White;
            this.nudnRemessaHomeBanking.DecimalPlaces = 2;
            this.nudnRemessaHomeBanking.Location = new System.Drawing.Point(633, 58);
            this.nudnRemessaHomeBanking.Margin = new System.Windows.Forms.Padding(145, 3, 15, 3);
            this.nudnRemessaHomeBanking.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudnRemessaHomeBanking.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudnRemessaHomeBanking.Name = "nudnRemessaHomeBanking";
            this.nudnRemessaHomeBanking.ReadOnly = false;
            this.nudnRemessaHomeBanking.Size = new System.Drawing.Size(233, 22);
            this.nudnRemessaHomeBanking.TabIndex = 38;
            this.nudnRemessaHomeBanking.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudnRemessaHomeBanking.ValueInt = 0;
            // 
            // cbostAceite
            // 
            this.cbostAceite._Field = "stAceite";
            this.cbostAceite._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostAceite._Itens")));
            this.cbostAceite._LabelGroup = this.hlP_LabelSeparator1_HomeBanking;
            this.cbostAceite._LabelText = "Aceite";
            this.cbostAceite._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostAceite._Regex = null;
            this.cbostAceite._situacao = true;
            this.cbostAceite._Table = "Conta_bancaria";
            this.cbostAceite._TamanhoComponente = 80;
            this.cbostAceite._TamanhoMaiorLabel = 250;
            this.cbostAceite._Visible = true;
            this.cbostAceite.BackColor = System.Drawing.Color.Transparent;
            this.cbostAceite.Base = null;
            this.cbostAceite.Color = System.Drawing.Color.White;
            this.cbostAceite.DataSource = null;
            this.cbostAceite.DisplayMember = "DisplayMember";
            this.cbostAceite.Location = new System.Drawing.Point(703, 86);
            this.cbostAceite.Margin = new System.Windows.Forms.Padding(215, 3, 15, 3);
            this.cbostAceite.Name = "cbostAceite";
            this.cbostAceite.SelectedIndex = -1;
            this.cbostAceite.SelectedValue = 0;
            this.cbostAceite.Size = new System.Drawing.Size(118, 21);
            this.cbostAceite.TabIndex = 36;
            this.cbostAceite.ValueMember = "ValueMember";
            // 
            // FormContaBancaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 487);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormContaBancaria";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = -10;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Text = "Contas Bancárias";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormContaBancaria_FormClosing);
            this.Load += new System.EventHandler(this.FormContaBancaria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).EndInit();
            this.panelPadrao.ResumeLayout(false);
            this.tabHierarquia.ResumeLayout(false);
            this.kryptonPanel3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.kryptonPanel1.ResumeLayout(false);
            this.Principal.ResumeLayout(false);
            this.kryptonTabControl1.ResumeLayout(false);
            this.tabHomeBank.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.ComponentModel.BackgroundWorker async_work;
        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl1;
        private TabPage tabPage1;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel1;
        private FlowLayoutPanel Principal;
        private Comum.Components.HLP_LabelSeparator hlP_LabelSeparator1_Principal;
        private Comum.Components.HLP_TextBox txtCodigo;
        private Comum.Components.HLP_TextBox txtxNumeroConta;
        private Comum.Components.HLP_TextBox txtxDescricao;
        private Comum.Components.HLP_ComboBox cbostConta;
        private Comum.Components.HLP_Pesquisa campoPesquisaidAgencia;
        private Comum.Components.HLP_TextBox txtxTitular;
        private Comum.Components.HLP_ComboBox cbxstPessoa;
        private Comum.Components.HLP_MaskedTextBox mskxCNPJouCPFTitular;
        private Comum.Components.HLP_ComboBox cbostBloquete;
        private Comum.Components.HLP_NumericUpDown nudnDigitosConvenio;
        private TabPage tabHomeBank;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private TabPage tabHierarquia;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel3;
        private TreeView treeHierarquia;
        private FlowLayoutPanel flowLayoutPanel1;
        private Comum.Components.HLP_LabelSeparator hlP_LabelSeparator1_HomeBanking;
        private Comum.Components.HLP_TextBox txtxNumeroContaHomeBanking;
        private Comum.Components.HLP_TextBox txtxCodigoEmpresaHomeBanking;
        private Comum.Components.HLP_NumericUpDown nudnConvenio;
        private Comum.Components.HLP_NumericUpDown nudnDiasProtesto;
        private Comum.Components.HLP_NumericUpDown nudnSequenciaNossoNumero;
        private Comum.Components.HLP_ComboBox cbostZeraNossoNumero;
        private Comum.Components.HLP_NumericUpDown nudnCarteira;
        private Comum.Components.HLP_NumericUpDown nudnVariacaoCarteira;
        private Comum.Components.HLP_ComboBox cbostAceite;
        private Comum.Components.HLP_TextBox txtxEspecie;
        private Comum.Components.HLP_NumericUpDown nudnRemessaHomeBanking;
    }
}