using System.Windows.Forms;
using HLP.Comum.Components;
namespace HLP.UI.Entries.Financeiro
{
    partial class FormAgencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgencia));
            this.Principal = new System.Windows.Forms.FlowLayoutPanel();
            this.hlP_LabelSeparator1_Principal = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtCodigo = new HLP.Comum.Components.HLP_TextBox();
            this.txtcAgencia = new HLP.Comum.Components.HLP_TextBox();
            this.txtxAgencia = new HLP.Comum.Components.HLP_TextBox();
            this.campoPesquisaidBanco = new HLP.Comum.Components.HLP_Pesquisa();
            this.mskxTelefone = new HLP.Comum.Components.HLP_MaskedTextBox();
            this.txtxFax = new HLP.Comum.Components.HLP_MaskedTextBox();
            this.kryptonTabControl1 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kryptonPanel1 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.kryptonPanel2 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.dgvEnderecos = new HLP.Comum.Components.HLP_DataGridView();
            this.stPrincipal = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.xNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stTipoEndereco = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.stLogradouro = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clxCEP = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewMaskedTextBoxColumn();
            this.clxEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xComplemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clxBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clidCidade = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.xCaixaPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xLatitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xLongitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFusoHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsEndereco = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.kryptonPanel3 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.dgvContato = new HLP.Comum.Components.HLP_DataGridView();
            this.idContato = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsContato = new System.Windows.Forms.BindingSource(this.components);
            this.treeSite = new System.Windows.Forms.TreeView();
            this.tabHierarquia = new System.Windows.Forms.TabPage();
            this.kryptonPanel4 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.treeHierarquia = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.async_work = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).BeginInit();
            this.panelPadrao.SuspendLayout();
            this.Principal.SuspendLayout();
            this.kryptonTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.kryptonPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnderecos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEndereco)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContato)).BeginInit();
            this.tabHierarquia.SuspendLayout();
            this.kryptonPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(926, 284);
            // 
            // panelPadrao
            // 
            this.panelPadrao.Controls.Add(this.kryptonTabControl1);
            this.panelPadrao.Size = new System.Drawing.Size(924, 260);
            // 
            // Principal
            // 
            this.Principal.AutoScroll = true;
            this.Principal.BackColor = System.Drawing.Color.Transparent;
            this.Principal.Controls.Add(this.hlP_LabelSeparator1_Principal);
            this.Principal.Controls.Add(this.txtCodigo);
            this.Principal.Controls.Add(this.txtcAgencia);
            this.Principal.Controls.Add(this.txtxAgencia);
            this.Principal.Controls.Add(this.campoPesquisaidBanco);
            this.Principal.Controls.Add(this.mskxTelefone);
            this.Principal.Controls.Add(this.txtxFax);
            this.Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Principal.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Principal.Location = new System.Drawing.Point(0, 0);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(910, 225);
            this.Principal.TabIndex = 2;
            this.Principal.Tag = "Principal";
            // 
            // hlP_LabelSeparator1_Principal
            // 
            this.hlP_LabelSeparator1_Principal._LabelText = "Principal";
            this.hlP_LabelSeparator1_Principal._TamanhoMaiorLabel = 0;
            this.hlP_LabelSeparator1_Principal.BackColor = System.Drawing.Color.Transparent;
            this.hlP_LabelSeparator1_Principal.Location = new System.Drawing.Point(3, 3);
            this.hlP_LabelSeparator1_Principal.Name = "hlP_LabelSeparator1_Principal";
            this.hlP_LabelSeparator1_Principal.Size = new System.Drawing.Size(510, 18);
            this.hlP_LabelSeparator1_Principal.TabIndex = 11;
            this.hlP_LabelSeparator1_Principal.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo._Field = "idAgencia";
            this.txtCodigo._LabelGroup = this.hlP_LabelSeparator1_Principal;
            this.txtCodigo._LabelText = "Código";
            this.txtCodigo._Multiline = false;
            this.txtCodigo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtCodigo._Password = false;
            this.txtCodigo._Regex = null;
            this.txtCodigo._Table = "Agencia";
            this.txtCodigo._TamanhoComponente = 84;
            this.txtCodigo._TamanhoMaiorLabel = 120;
            this.txtCodigo._Visible = true;
            this.txtCodigo.BackColor = System.Drawing.Color.Transparent;
            this.txtCodigo.Base = null;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCodigo.Color = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(78, 27);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(78, 3, 15, 3);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(129, 21);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtcAgencia
            // 
            this.txtcAgencia._Field = "cAgencia";
            this.txtcAgencia._LabelGroup = this.hlP_LabelSeparator1_Principal;
            this.txtcAgencia._LabelText = "Código da  agência";
            this.txtcAgencia._Multiline = false;
            this.txtcAgencia._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtcAgencia._Password = false;
            this.txtcAgencia._Regex = null;
            this.txtcAgencia._Table = "Agencia";
            this.txtcAgencia._TamanhoComponente = 148;
            this.txtcAgencia._TamanhoMaiorLabel = 120;
            this.txtcAgencia._Visible = true;
            this.txtcAgencia.BackColor = System.Drawing.Color.Transparent;
            this.txtcAgencia.Base = null;
            this.txtcAgencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtcAgencia.Color = System.Drawing.Color.White;
            this.txtcAgencia.Location = new System.Drawing.Point(16, 54);
            this.txtcAgencia.Margin = new System.Windows.Forms.Padding(16, 3, 15, 3);
            this.txtcAgencia.MaxLength = 32767;
            this.txtcAgencia.Name = "txtcAgencia";
            this.txtcAgencia.ReadOnly = false;
            this.txtcAgencia.Size = new System.Drawing.Size(255, 21);
            this.txtcAgencia.TabIndex = 3;
            // 
            // txtxAgencia
            // 
            this.txtxAgencia._Field = "xAgencia";
            this.txtxAgencia._LabelGroup = this.hlP_LabelSeparator1_Principal;
            this.txtxAgencia._LabelText = "Nome";
            this.txtxAgencia._Multiline = false;
            this.txtxAgencia._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxAgencia._Password = false;
            this.txtxAgencia._Regex = null;
            this.txtxAgencia._Table = "Agencia";
            this.txtxAgencia._TamanhoComponente = 305;
            this.txtxAgencia._TamanhoMaiorLabel = 120;
            this.txtxAgencia._Visible = true;
            this.txtxAgencia.BackColor = System.Drawing.Color.Transparent;
            this.txtxAgencia.Base = null;
            this.txtxAgencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxAgencia.Color = System.Drawing.Color.White;
            this.txtxAgencia.Location = new System.Drawing.Point(86, 81);
            this.txtxAgencia.Margin = new System.Windows.Forms.Padding(86, 3, 15, 3);
            this.txtxAgencia.MaxLength = 32767;
            this.txtxAgencia.Name = "txtxAgencia";
            this.txtxAgencia.ReadOnly = false;
            this.txtxAgencia.Size = new System.Drawing.Size(342, 21);
            this.txtxAgencia.TabIndex = 8;
            // 
            // campoPesquisaidBanco
            // 
            this.campoPesquisaidBanco._Field = "idBanco";
            this.campoPesquisaidBanco._LabelGroup = this.hlP_LabelSeparator1_Principal;
            this.campoPesquisaidBanco._LabelText = "Banco";
            this.campoPesquisaidBanco._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("campoPesquisaidBanco._ListaCamposDisplay")));
            this.campoPesquisaidBanco._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("campoPesquisaidBanco._ListaValoresDisplay")));
            this.campoPesquisaidBanco._NomeCampoPK = "ID";
            this.campoPesquisaidBanco._NomeFormCadastroOriginal = "FormBanco";
            this.campoPesquisaidBanco._NomeView = "vwBanco";
            this.campoPesquisaidBanco._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.campoPesquisaidBanco._Regex = null;
            this.campoPesquisaidBanco._Table = "Agencia";
            this.campoPesquisaidBanco._TamanhoComponente = 300;
            this.campoPesquisaidBanco._TamanhoMaiorLabel = 120;
            this.campoPesquisaidBanco._Vinculado = false;
            this.campoPesquisaidBanco._Visible = true;
            this.campoPesquisaidBanco.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.campoPesquisaidBanco.BackColor = System.Drawing.Color.Transparent;
            this.campoPesquisaidBanco.Base = null;
            this.campoPesquisaidBanco.Location = new System.Drawing.Point(84, 108);
            this.campoPesquisaidBanco.Margin = new System.Windows.Forms.Padding(84, 3, 15, 3);
            this.campoPesquisaidBanco.Name = "campoPesquisaidBanco";
            this.campoPesquisaidBanco.ReadOnly = false;
            this.campoPesquisaidBanco.Size = new System.Drawing.Size(429, 21);
            this.campoPesquisaidBanco.TabIndex = 5;
            this.campoPesquisaidBanco.Value = 0;
            // 
            // mskxTelefone
            // 
            this.mskxTelefone._Field = "xTelefone";
            this.mskxTelefone._LabelGroup = this.hlP_LabelSeparator1_Principal;
            this.mskxTelefone._LabelText = "Telefone";
            this.mskxTelefone._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.mskxTelefone._Regex = null;
            this.mskxTelefone._Table = "Agencia";
            this.mskxTelefone._TamanhoComponente = 118;
            this.mskxTelefone._TamanhoMaiorLabel = 120;
            this.mskxTelefone._TpValidacao = HLP.Comum.Components.HLP_MaskedTextBox.TipoValidacao.DEFAULT;
            this.mskxTelefone._UF = null;
            this.mskxTelefone._Visible = true;
            this.mskxTelefone.BackColor = System.Drawing.Color.Transparent;
            this.mskxTelefone.Base = null;
            this.mskxTelefone.Color = System.Drawing.Color.White;
            this.mskxTelefone.Location = new System.Drawing.Point(72, 135);
            this.mskxTelefone.Margin = new System.Windows.Forms.Padding(72, 3, 15, 3);
            this.mskxTelefone.Mask = "(000)0000-0000";
            this.mskxTelefone.MaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mskxTelefone.MaxLength = 32767;
            this.mskxTelefone.Name = "mskxTelefone";
            this.mskxTelefone.ReadOnly = false;
            this.mskxTelefone.Size = new System.Drawing.Size(169, 21);
            this.mskxTelefone.TabIndex = 4;
            // 
            // txtxFax
            // 
            this.txtxFax._Field = "xFax";
            this.txtxFax._LabelGroup = this.hlP_LabelSeparator1_Principal;
            this.txtxFax._LabelText = "Fax";
            this.txtxFax._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxFax._Regex = null;
            this.txtxFax._Table = "Agencia";
            this.txtxFax._TamanhoComponente = 118;
            this.txtxFax._TamanhoMaiorLabel = 120;
            this.txtxFax._TpValidacao = HLP.Comum.Components.HLP_MaskedTextBox.TipoValidacao.DEFAULT;
            this.txtxFax._UF = null;
            this.txtxFax._Visible = true;
            this.txtxFax.BackColor = System.Drawing.Color.Transparent;
            this.txtxFax.Base = null;
            this.txtxFax.Color = System.Drawing.Color.White;
            this.txtxFax.Location = new System.Drawing.Point(99, 162);
            this.txtxFax.Margin = new System.Windows.Forms.Padding(99, 3, 15, 3);
            this.txtxFax.Mask = "(000)0000-0000";
            this.txtxFax.MaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtxFax.MaxLength = 32767;
            this.txtxFax.Name = "txtxFax";
            this.txtxFax.ReadOnly = false;
            this.txtxFax.Size = new System.Drawing.Size(142, 21);
            this.txtxFax.TabIndex = 10;
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
            this.kryptonTabControl1.Size = new System.Drawing.Size(918, 254);
            this.kryptonTabControl1.TabIndex = 3;
            this.kryptonTabControl1.UseExtendedLayout = false;
            this.kryptonTabControl1.SelectedIndexChanged += new System.EventHandler(this.kryptonTabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Controls.Add(this.kryptonPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(910, 225);
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
            this.kryptonPanel1.Size = new System.Drawing.Size(910, 225);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage2.Controls.Add(this.kryptonPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(910, 225);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Tag = false;
            this.tabPage2.Text = "Endereços";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.BorderWidth = 0;
            this.kryptonPanel2.Controls.Add(this.dgvEnderecos);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.kryptonPanel2.GradientToogleColors = false;
            this.kryptonPanel2.GradientUseBlend = false;
            this.kryptonPanel2.GradientUseSolid = true;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.PersistentColors = false;
            this.kryptonPanel2.Size = new System.Drawing.Size(910, 225);
            this.kryptonPanel2.TabIndex = 1;
            // 
            // dgvEnderecos
            // 
            this.dgvEnderecos.Altera = false;
            this.dgvEnderecos.AutoGenerateColumns = false;
            this.dgvEnderecos.cm = null;
            this.dgvEnderecos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnderecos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stPrincipal,
            this.xNome,
            this.stTipoEndereco,
            this.stLogradouro,
            this.clxCEP,
            this.clxEndereco,
            this.nNumero,
            this.xComplemento,
            this.clxBairro,
            this.clidCidade,
            this.xCaixaPostal,
            this.xLatitude,
            this.xLongitude,
            this.xFusoHorario});
            this.dgvEnderecos.DataSource = this.bsEndereco;
            this.dgvEnderecos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEnderecos.DragDropLinha = false;
            this.dgvEnderecos.Exclui = false;
            this.dgvEnderecos.Inclui = false;
            this.dgvEnderecos.Location = new System.Drawing.Point(0, 0);
            this.dgvEnderecos.Name = "dgvEnderecos";
            this.dgvEnderecos.Size = new System.Drawing.Size(910, 225);
            this.dgvEnderecos.TabIndex = 0;
            this.dgvEnderecos.Tag = "Agencia_Endereco";
            this.dgvEnderecos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEnderecos_CellEndEdit);
            // 
            // stPrincipal
            // 
            this.stPrincipal.DataPropertyName = "stPrincipal";
            this.stPrincipal.HeaderText = "Principal";
            this.stPrincipal.Items.AddRange(new object[] {
            "0-NÃO",
            "1-SIM"});
            this.stPrincipal.Name = "stPrincipal";
            // 
            // xNome
            // 
            this.xNome.DataPropertyName = "xNome";
            this.xNome.HeaderText = "Nome";
            this.xNome.Name = "xNome";
            // 
            // stTipoEndereco
            // 
            this.stTipoEndereco.DataPropertyName = "stTipoEndereco";
            this.stTipoEndereco.HeaderText = "Tipo de endereço";
            this.stTipoEndereco.Items.AddRange(new object[] {
            "0 - COMERCIAL ",
            "1 - ENDEREÇO DE REMESSA DE TERCEIROS ",
            "2 - ENTREGA ",
            "3 - ENTREGA ALT.",
            "4 - NOTA FISCAL ",
            "5 - OUTRO ",
            "6 - REMETER-PARA ",
            "7 - RESIDÊNCIA ",
            "8 - SWIFT  "});
            this.stTipoEndereco.Name = "stTipoEndereco";
            this.stTipoEndereco.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stTipoEndereco.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.stTipoEndereco.Width = 150;
            // 
            // stLogradouro
            // 
            this.stLogradouro.DataPropertyName = "stLogradouro";
            this.stLogradouro.HeaderText = "Tipo de logradouro";
            this.stLogradouro.Items.AddRange(new object[] {
            "0 - AER - AEROPORTO",
            "1 - AL - ALAMEDA ",
            "2 - AP - APARTAMENTO ",
            "3 - AV - AVENIDA ",
            "4 - BC - BECO ",
            "5 - BL - BLOCO ",
            "6 - CAM - CAMINHO ",
            "7 - ESCD - ESCADINHA ",
            "8 - EST  - ESTAÇÃO ",
            "9 - ETR - ESTRADA ",
            "10 - FAZ - FAZENDA ",
            "11 - FORT  - FORTALEZA ",
            "12 - GL - GALERIA ",
            "13 - LD - LADEIRA ",
            "14 - LGO  - LARGO ",
            "15 - PÇA - PRAÇA ",
            "16 - PR  - PRAIA ",
            "17 - PRQ - PARQUE ",
            "18 - QD  - QUADRA ",
            "19 - KM - QUILÔMETRO ",
            "20 - QTA  - QUINTA ",
            "21 - ROD  - RODOVIA ",
            "22 - R - RUA ",
            "23 - SQD - SUPER QUADRA ",
            "24 - TRV - TRAVESSA ",
            "25 - VD - VIADUTO ",
            "26 - VL - VILA "});
            this.stLogradouro.Name = "stLogradouro";
            this.stLogradouro.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stLogradouro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.stLogradouro.Width = 150;
            // 
            // clxCEP
            // 
            this.clxCEP.DataPropertyName = "xCEP";
            this.clxCEP.HeaderText = "CEP";
            this.clxCEP.Mask = "00000-000";
            this.clxCEP.Name = "clxCEP";
            this.clxCEP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clxCEP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.clxCEP.Width = 100;
            // 
            // clxEndereco
            // 
            this.clxEndereco.DataPropertyName = "xEndereco";
            this.clxEndereco.HeaderText = "Endereço";
            this.clxEndereco.Name = "clxEndereco";
            this.clxEndereco.Width = 200;
            // 
            // nNumero
            // 
            this.nNumero.DataPropertyName = "nNumero";
            this.nNumero.HeaderText = "Número";
            this.nNumero.Name = "nNumero";
            // 
            // xComplemento
            // 
            this.xComplemento.DataPropertyName = "xComplemento";
            this.xComplemento.HeaderText = "Complemento";
            this.xComplemento.Name = "xComplemento";
            // 
            // clxBairro
            // 
            this.clxBairro.DataPropertyName = "xBairro";
            this.clxBairro.HeaderText = "Bairro";
            this.clxBairro.Name = "clxBairro";
            // 
            // clidCidade
            // 
            this.clidCidade.DataPropertyName = "idCidade";
            this.clidCidade.HeaderText = "Cidade";
            this.clidCidade.Name = "clidCidade";
            this.clidCidade.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clidCidade.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clidCidade.Width = 150;
            // 
            // xCaixaPostal
            // 
            this.xCaixaPostal.DataPropertyName = "xCaixaPostal";
            this.xCaixaPostal.HeaderText = "Caixa Postal";
            this.xCaixaPostal.Name = "xCaixaPostal";
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
            this.xFusoHorario.HeaderText = "Fuso Horário";
            this.xFusoHorario.Name = "xFusoHorario";
            this.xFusoHorario.Width = 110;
            // 
            // bsEndereco
            // 
            this.bsEndereco.DataSource = typeof(HLP.Models.Entries.Financeiro.Agencia_EnderecoModel);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage3.Controls.Add(this.kryptonPanel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(910, 225);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Tag = false;
            this.tabPage3.Text = "Contatos";
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.BorderWidth = 0;
            this.kryptonPanel3.Controls.Add(this.dgvContato);
            this.kryptonPanel3.Controls.Add(this.treeSite);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel3.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.kryptonPanel3.GradientToogleColors = false;
            this.kryptonPanel3.GradientUseBlend = false;
            this.kryptonPanel3.GradientUseSolid = true;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.PersistentColors = false;
            this.kryptonPanel3.Size = new System.Drawing.Size(910, 225);
            this.kryptonPanel3.TabIndex = 2;
            // 
            // dgvContato
            // 
            this.dgvContato.Altera = false;
            this.dgvContato.AutoGenerateColumns = false;
            this.dgvContato.cm = null;
            this.dgvContato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idContato});
            this.dgvContato.DataSource = this.bsContato;
            this.dgvContato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContato.DragDropLinha = false;
            this.dgvContato.Exclui = false;
            this.dgvContato.Inclui = false;
            this.dgvContato.Location = new System.Drawing.Point(0, 0);
            this.dgvContato.Name = "dgvContato";
            this.dgvContato.Size = new System.Drawing.Size(910, 225);
            this.dgvContato.TabIndex = 1;
            this.dgvContato.Tag = "Agencia_Contato";
            this.dgvContato.Enter += new System.EventHandler(this.dgvContato_Enter);
            // 
            // idContato
            // 
            this.idContato.DataPropertyName = "idContato";
            this.idContato.HeaderText = "Contato";
            this.idContato.Name = "idContato";
            this.idContato.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idContato.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idContato.Width = 350;
            // 
            // bsContato
            // 
            this.bsContato.DataSource = typeof(HLP.Models.Entries.Financeiro.Agencia_ContatoModel);
            // 
            // treeSite
            // 
            this.treeSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeSite.ItemHeight = 21;
            this.treeSite.Location = new System.Drawing.Point(0, 0);
            this.treeSite.Name = "treeSite";
            this.treeSite.Size = new System.Drawing.Size(910, 225);
            this.treeSite.TabIndex = 0;
            // 
            // tabHierarquia
            // 
            this.tabHierarquia.BackColor = System.Drawing.SystemColors.Window;
            this.tabHierarquia.Controls.Add(this.kryptonPanel4);
            this.tabHierarquia.Location = new System.Drawing.Point(4, 25);
            this.tabHierarquia.Margin = new System.Windows.Forms.Padding(0);
            this.tabHierarquia.Name = "tabHierarquia";
            this.tabHierarquia.Size = new System.Drawing.Size(910, 225);
            this.tabHierarquia.TabIndex = 3;
            this.tabHierarquia.Tag = false;
            this.tabHierarquia.Text = "Hierarquia";
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.BorderWidth = 0;
            this.kryptonPanel4.Controls.Add(this.treeHierarquia);
            this.kryptonPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel4.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.kryptonPanel4.GradientToogleColors = false;
            this.kryptonPanel4.GradientUseBlend = false;
            this.kryptonPanel4.GradientUseSolid = true;
            this.kryptonPanel4.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.PersistentColors = false;
            this.kryptonPanel4.Size = new System.Drawing.Size(910, 225);
            this.kryptonPanel4.TabIndex = 3;
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
            this.treeHierarquia.Size = new System.Drawing.Size(910, 225);
            this.treeHierarquia.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "bank.ico");
            this.imageList1.Images.SetKeyName(1, "go_home.ico");
            this.imageList1.Images.SetKeyName(2, "money.ico");
            // 
            // async_work
            // 
            this.async_work.WorkerSupportsCancellation = true;
            this.async_work.DoWork += new System.ComponentModel.DoWorkEventHandler(this.async_work_DoWork);
            // 
            // FormAgencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 311);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAgencia";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = -10;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Text = "Agências";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAgencia_FormClosing);
            this.Load += new System.EventHandler(this.FormAgencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).EndInit();
            this.panelPadrao.ResumeLayout(false);
            this.Principal.ResumeLayout(false);
            this.kryptonTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.kryptonPanel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnderecos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEndereco)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.kryptonPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContato)).EndInit();
            this.tabHierarquia.ResumeLayout(false);
            this.kryptonPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Principal;
        private Comum.Components.HLP_TextBox txtCodigo;
        private Comum.Components.HLP_TextBox txtcAgencia;
        private Comum.Components.HLP_MaskedTextBox mskxTelefone;
        private Comum.Components.HLP_Pesquisa campoPesquisaidBanco;
        private Comum.Components.HLP_TextBox txtxAgencia;
        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.TabPage tabPage2;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel2;
        private HLP_DataGridView dgvEnderecos;
        private System.Windows.Forms.TabPage tabPage3;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel3;
        private TreeView treeSite;
        private System.Windows.Forms.BindingSource bsEndereco;
        private HLP_DataGridView dgvContato;
        private System.Windows.Forms.DataGridViewComboBoxColumn idContato;
        private System.Windows.Forms.BindingSource bsContato;
        private System.Windows.Forms.TabPage tabHierarquia;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel4;
        private TreeView treeHierarquia;
        private System.Windows.Forms.ImageList imageList1;
        private System.ComponentModel.BackgroundWorker async_work;
        private DataGridViewComboBoxColumn stPrincipal;
        private DataGridViewTextBoxColumn xNome;
        private DataGridViewComboBoxColumn stTipoEndereco;
        private DataGridViewComboBoxColumn stLogradouro;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewMaskedTextBoxColumn clxCEP;
        private DataGridViewTextBoxColumn clxEndereco;
        private DataGridViewTextBoxColumn nNumero;
        private DataGridViewTextBoxColumn xComplemento;
        private DataGridViewTextBoxColumn clxBairro;
        private DataGridViewComboBoxColumn clidCidade;
        private DataGridViewTextBoxColumn xCaixaPostal;
        private DataGridViewTextBoxColumn xLatitude;
        private DataGridViewTextBoxColumn xLongitude;
        private DataGridViewTextBoxColumn xFusoHorario;
        private Comum.Components.HLP_MaskedTextBox txtxFax;
        private HLP_LabelSeparator hlP_LabelSeparator1_Principal;
    }
}