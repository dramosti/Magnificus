using System.Windows.Forms;
using HLP.Comum.Components;
namespace HLP.UI.Entries.Geral.Basico
{
    partial class FormSite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSite));
            this.kryptonTabControl1 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabPrincipal = new System.Windows.Forms.TabPage();
            this.kryptonPanel1 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.hlP_LabelSeparator1_Geral = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtCodigo = new HLP.Comum.Components.HLP_TextBox();
            this.txtxSite = new HLP.Comum.Components.HLP_TextBox();
            this.txtxDescricao = new HLP.Comum.Components.HLP_TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.kryptonPanel2 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.dgvEnderecos = new HLP.Comum.Components.HLP_DataGridView();
            this.stPrincipalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.stTipoEndereco = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clxCEP = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewMaskedTextBoxColumn();
            this.stLogradouro = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clxEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clidCidade = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.xCaixaPostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xLatitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xLongitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFusoHorarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clxBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nNumeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xComplementoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsEndereco = new System.Windows.Forms.BindingSource(this.components);
            this.tabHierarquia = new System.Windows.Forms.TabPage();
            this.kryptonPanel3 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.treeHierarquia = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.async_work = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).BeginInit();
            this.panelPadrao.SuspendLayout();
            this.kryptonTabControl1.SuspendLayout();
            this.tabPrincipal.SuspendLayout();
            this.kryptonPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnderecos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEndereco)).BeginInit();
            this.tabHierarquia.SuspendLayout();
            this.kryptonPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1075, 318);
            // 
            // panelPadrao
            // 
            this.panelPadrao.Controls.Add(this.kryptonTabControl1);
            this.panelPadrao.Size = new System.Drawing.Size(1073, 294);
            // 
            // kryptonTabControl1
            // 
            this.kryptonTabControl1.AllowCloseButton = false;
            this.kryptonTabControl1.AllowContextButton = true;
            this.kryptonTabControl1.AllowNavigatorButtons = false;
            this.kryptonTabControl1.AllowSelectedTabHigh = false;
            this.kryptonTabControl1.BorderWidth = 1;
            this.kryptonTabControl1.Controls.Add(this.tabPrincipal);
            this.kryptonTabControl1.Controls.Add(this.tabPage2);
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
            this.kryptonTabControl1.Size = new System.Drawing.Size(1067, 288);
            this.kryptonTabControl1.TabIndex = 0;
            this.kryptonTabControl1.UseExtendedLayout = false;
            this.kryptonTabControl1.SelectedIndexChanged += new System.EventHandler(this.kryptonTabControl1_SelectedIndexChanged);
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.BackColor = System.Drawing.SystemColors.Window;
            this.tabPrincipal.Controls.Add(this.kryptonPanel1);
            this.tabPrincipal.Location = new System.Drawing.Point(4, 25);
            this.tabPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.Size = new System.Drawing.Size(1059, 259);
            this.tabPrincipal.TabIndex = 0;
            this.tabPrincipal.Tag = false;
            this.tabPrincipal.Text = "Principal";
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
            this.kryptonPanel1.Size = new System.Drawing.Size(1059, 259);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.hlP_LabelSeparator1_Geral);
            this.flowLayoutPanel1.Controls.Add(this.txtCodigo);
            this.flowLayoutPanel1.Controls.Add(this.txtxSite);
            this.flowLayoutPanel1.Controls.Add(this.txtxDescricao);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1059, 259);
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
            this.hlP_LabelSeparator1_Geral.Size = new System.Drawing.Size(300, 18);
            this.hlP_LabelSeparator1_Geral.TabIndex = 30;
            this.hlP_LabelSeparator1_Geral.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo._Field = "idSite";
            this.txtCodigo._Help = "Chave principal do registro do site";
            this.txtCodigo._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtCodigo._LabelText = "Código";
            this.txtCodigo._Multiline = false;
            this.txtCodigo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtCodigo._Password = false;
            this.txtCodigo._Regex = null;
            this.txtCodigo._Table = "Site";
            this.txtCodigo._TamanhoComponente = 132;
            this.txtCodigo._TamanhoMaiorLabel = 120;
            this.txtCodigo._Visible = false;
            this.txtCodigo.BackColor = System.Drawing.Color.Transparent;
            this.txtCodigo.Base = null;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCodigo.Color = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(78, 27);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(78, 3, 15, 3);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(177, 24);
            this.txtCodigo.TabIndex = 3;
            // 
            // txtxSite
            // 
            this.txtxSite._Field = "xSite";
            this.txtxSite._Help = "Informe de forma resumida o nome do site";
            this.txtxSite._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtxSite._LabelText = "Site";
            this.txtxSite._Multiline = false;
            this.txtxSite._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxSite._Password = false;
            this.txtxSite._Regex = null;
            this.txtxSite._Table = "Site";
            this.txtxSite._TamanhoComponente = 159;
            this.txtxSite._TamanhoMaiorLabel = 120;
            this.txtxSite._Visible = false;
            this.txtxSite.BackColor = System.Drawing.Color.Transparent;
            this.txtxSite.Base = null;
            this.txtxSite.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxSite.Color = System.Drawing.Color.White;
            this.txtxSite.Location = new System.Drawing.Point(97, 57);
            this.txtxSite.Margin = new System.Windows.Forms.Padding(97, 3, 15, 3);
            this.txtxSite.MaxLength = 32767;
            this.txtxSite.Name = "txtxSite";
            this.txtxSite.ReadOnly = false;
            this.txtxSite.Size = new System.Drawing.Size(185, 24);
            this.txtxSite.TabIndex = 4;
            // 
            // txtxDescricao
            // 
            this.txtxDescricao._Field = "xDescricao";
            this.txtxDescricao._Help = "Descrição detalhada do site";
            this.txtxDescricao._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtxDescricao._LabelText = "Descrição do site";
            this.txtxDescricao._Multiline = false;
            this.txtxDescricao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxDescricao._Password = false;
            this.txtxDescricao._Regex = null;
            this.txtxDescricao._Table = "Site";
            this.txtxDescricao._TamanhoComponente = 199;
            this.txtxDescricao._TamanhoMaiorLabel = 120;
            this.txtxDescricao._Visible = false;
            this.txtxDescricao.BackColor = System.Drawing.Color.Transparent;
            this.txtxDescricao.Base = null;
            this.txtxDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxDescricao.Color = System.Drawing.Color.White;
            this.txtxDescricao.Location = new System.Drawing.Point(29, 87);
            this.txtxDescricao.Margin = new System.Windows.Forms.Padding(29, 3, 15, 3);
            this.txtxDescricao.MaxLength = 32767;
            this.txtxDescricao.Name = "txtxDescricao";
            this.txtxDescricao.ReadOnly = false;
            this.txtxDescricao.Size = new System.Drawing.Size(293, 22);
            this.txtxDescricao.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage2.Controls.Add(this.kryptonPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1059, 259);
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
            this.kryptonPanel2.Size = new System.Drawing.Size(1059, 259);
            this.kryptonPanel2.TabIndex = 1;
            // 
            // dgvEnderecos
            // 
            this.dgvEnderecos.Altera = false;
            this.dgvEnderecos.AutoGenerateColumns = false;
            this.dgvEnderecos.cm = null;
            this.dgvEnderecos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnderecos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stPrincipalDataGridViewTextBoxColumn,
            this.stTipoEndereco,
            this.clxCEP,
            this.stLogradouro,
            this.clxEndereco,
            this.clidCidade,
            this.xCaixaPostalDataGridViewTextBoxColumn,
            this.xLatitudeDataGridViewTextBoxColumn,
            this.xLongitudeDataGridViewTextBoxColumn,
            this.xFusoHorarioDataGridViewTextBoxColumn,
            this.xNomeDataGridViewTextBoxColumn,
            this.clxBairro,
            this.nNumeroDataGridViewTextBoxColumn,
            this.xComplementoDataGridViewTextBoxColumn});
            this.dgvEnderecos.DataSource = this.bsEndereco;
            this.dgvEnderecos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEnderecos.DragDropLinha = false;
            this.dgvEnderecos.Exclui = false;
            this.dgvEnderecos.Inclui = false;
            this.dgvEnderecos.Location = new System.Drawing.Point(0, 0);
            this.dgvEnderecos.Name = "dgvEnderecos";
            this.dgvEnderecos.Size = new System.Drawing.Size(1059, 259);
            this.dgvEnderecos.TabIndex = 0;
            this.dgvEnderecos.Tag = "Site_Endereco";
            this.dgvEnderecos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEnderecos_CellEndEdit);
            // 
            // stPrincipalDataGridViewTextBoxColumn
            // 
            this.stPrincipalDataGridViewTextBoxColumn.DataPropertyName = "stPrincipal";
            this.stPrincipalDataGridViewTextBoxColumn.HeaderText = "Principal";
            this.stPrincipalDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "0-NÃO",
            "1-SIM"});
            this.stPrincipalDataGridViewTextBoxColumn.Name = "stPrincipalDataGridViewTextBoxColumn";
            this.stPrincipalDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stPrincipalDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.stPrincipalDataGridViewTextBoxColumn.ToolTipText = "Se esta caixa de seleção estiver selecionada, o endereço será o endereço principa" +
    "l para o site.";
            this.stPrincipalDataGridViewTextBoxColumn.Width = 140;
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
            "5-OUTRO",
            "6-REMETER-PARA",
            "7-RESIDÊNCIA ",
            "8-SWIFT"});
            this.stTipoEndereco.Name = "stTipoEndereco";
            this.stTipoEndereco.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stTipoEndereco.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.stTipoEndereco.ToolTipText = resources.GetString("stTipoEndereco.ToolTipText");
            this.stTipoEndereco.Width = 150;
            // 
            // clxCEP
            // 
            this.clxCEP.DataPropertyName = "xCEP";
            this.clxCEP.HeaderText = "xCEP";
            this.clxCEP.Mask = "00000-000";
            this.clxCEP.Name = "clxCEP";
            this.clxCEP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clxCEP.ToolTipText = "Informar o Código de Endereçamento Postal do Site";
            this.clxCEP.Width = 100;
            // 
            // stLogradouro
            // 
            this.stLogradouro.DataPropertyName = "stLogradouro";
            this.stLogradouro.HeaderText = "Tipo Logradouro";
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
            "24-TRV - TRAVESSA ",
            "25-VD - VIADUTO ",
            "26-VL - VILA "});
            this.stLogradouro.Name = "stLogradouro";
            this.stLogradouro.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stLogradouro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.stLogradouro.ToolTipText = "Informar o Tipo de Logradouro para o endereço correspondente.";
            this.stLogradouro.Width = 160;
            // 
            // clxEndereco
            // 
            this.clxEndereco.DataPropertyName = "xEndereco";
            this.clxEndereco.HeaderText = "Endereço";
            this.clxEndereco.Name = "clxEndereco";
            this.clxEndereco.ToolTipText = "Informar o nome da Rua do Site";
            this.clxEndereco.Width = 150;
            // 
            // clidCidade
            // 
            this.clidCidade.DataPropertyName = "idCidade";
            this.clidCidade.HeaderText = "Cidade";
            this.clidCidade.Name = "clidCidade";
            this.clidCidade.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clidCidade.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clidCidade.ToolTipText = "Informar a Cidade/Municipio do Site";
            this.clidCidade.Width = 300;
            // 
            // xCaixaPostalDataGridViewTextBoxColumn
            // 
            this.xCaixaPostalDataGridViewTextBoxColumn.DataPropertyName = "xCaixaPostal";
            this.xCaixaPostalDataGridViewTextBoxColumn.HeaderText = "Caixa Postal";
            this.xCaixaPostalDataGridViewTextBoxColumn.Name = "xCaixaPostalDataGridViewTextBoxColumn";
            this.xCaixaPostalDataGridViewTextBoxColumn.ToolTipText = "Informe a Caixa Postal do Endereço";
            this.xCaixaPostalDataGridViewTextBoxColumn.Width = 150;
            // 
            // xLatitudeDataGridViewTextBoxColumn
            // 
            this.xLatitudeDataGridViewTextBoxColumn.DataPropertyName = "xLatitude";
            this.xLatitudeDataGridViewTextBoxColumn.HeaderText = "Latitude";
            this.xLatitudeDataGridViewTextBoxColumn.Name = "xLatitudeDataGridViewTextBoxColumn";
            this.xLatitudeDataGridViewTextBoxColumn.ToolTipText = "Informe a Longitude do Endereço";
            this.xLatitudeDataGridViewTextBoxColumn.Width = 150;
            // 
            // xLongitudeDataGridViewTextBoxColumn
            // 
            this.xLongitudeDataGridViewTextBoxColumn.DataPropertyName = "xLongitude";
            this.xLongitudeDataGridViewTextBoxColumn.HeaderText = "Longitude";
            this.xLongitudeDataGridViewTextBoxColumn.Name = "xLongitudeDataGridViewTextBoxColumn";
            this.xLongitudeDataGridViewTextBoxColumn.ToolTipText = "Informe a Latitude do Endereço";
            this.xLongitudeDataGridViewTextBoxColumn.Width = 150;
            // 
            // xFusoHorarioDataGridViewTextBoxColumn
            // 
            this.xFusoHorarioDataGridViewTextBoxColumn.DataPropertyName = "xFusoHorario";
            this.xFusoHorarioDataGridViewTextBoxColumn.HeaderText = "Fuso Horário";
            this.xFusoHorarioDataGridViewTextBoxColumn.Name = "xFusoHorarioDataGridViewTextBoxColumn";
            this.xFusoHorarioDataGridViewTextBoxColumn.ToolTipText = "Informe o Fuso Horário do Endereço";
            this.xFusoHorarioDataGridViewTextBoxColumn.Width = 150;
            // 
            // xNomeDataGridViewTextBoxColumn
            // 
            this.xNomeDataGridViewTextBoxColumn.DataPropertyName = "xNome";
            this.xNomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.xNomeDataGridViewTextBoxColumn.Name = "xNomeDataGridViewTextBoxColumn";
            this.xNomeDataGridViewTextBoxColumn.ToolTipText = "Nome";
            this.xNomeDataGridViewTextBoxColumn.Width = 140;
            // 
            // clxBairro
            // 
            this.clxBairro.DataPropertyName = "xBairro";
            this.clxBairro.HeaderText = "Bairro";
            this.clxBairro.Name = "clxBairro";
            this.clxBairro.ToolTipText = "Bairro";
            this.clxBairro.Width = 150;
            // 
            // nNumeroDataGridViewTextBoxColumn
            // 
            this.nNumeroDataGridViewTextBoxColumn.DataPropertyName = "nNumero";
            this.nNumeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.nNumeroDataGridViewTextBoxColumn.Name = "nNumeroDataGridViewTextBoxColumn";
            this.nNumeroDataGridViewTextBoxColumn.ToolTipText = "Numero";
            this.nNumeroDataGridViewTextBoxColumn.Width = 150;
            // 
            // xComplementoDataGridViewTextBoxColumn
            // 
            this.xComplementoDataGridViewTextBoxColumn.DataPropertyName = "xComplemento";
            this.xComplementoDataGridViewTextBoxColumn.HeaderText = "Complemento";
            this.xComplementoDataGridViewTextBoxColumn.Name = "xComplementoDataGridViewTextBoxColumn";
            this.xComplementoDataGridViewTextBoxColumn.ToolTipText = "Complemento";
            this.xComplementoDataGridViewTextBoxColumn.Width = 150;
            // 
            // bsEndereco
            // 
            this.bsEndereco.DataSource = typeof(HLP.Models.Entries.Gerais.Site_enderecoModel);
            // 
            // tabHierarquia
            // 
            this.tabHierarquia.BackColor = System.Drawing.SystemColors.Window;
            this.tabHierarquia.Controls.Add(this.kryptonPanel3);
            this.tabHierarquia.Location = new System.Drawing.Point(4, 25);
            this.tabHierarquia.Margin = new System.Windows.Forms.Padding(0);
            this.tabHierarquia.Name = "tabHierarquia";
            this.tabHierarquia.Size = new System.Drawing.Size(1059, 259);
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
            this.kryptonPanel3.Size = new System.Drawing.Size(1059, 259);
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
            this.treeHierarquia.Size = new System.Drawing.Size(1059, 259);
            this.treeHierarquia.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1345830422_factory.ico");
            this.imageList1.Images.SetKeyName(1, "1345830899_nuclear.ico");
            this.imageList1.Images.SetKeyName(2, "1345831034_lorry.ico");
            this.imageList1.Images.SetKeyName(3, "1346243459_sitemap_color.ico");
            // 
            // async_work
            // 
            this.async_work.WorkerSupportsCancellation = true;
            this.async_work.DoWork += new System.ComponentModel.DoWorkEventHandler(this.async_work_DoWork);
            // 
            // FormSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 345);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSite";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = -10;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Text = "Sites";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSite_FormClosing);
            this.Load += new System.EventHandler(this.FormSite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).EndInit();
            this.panelPadrao.ResumeLayout(false);
            this.kryptonTabControl1.ResumeLayout(false);
            this.tabPrincipal.ResumeLayout(false);
            this.kryptonPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnderecos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEndereco)).EndInit();
            this.tabHierarquia.ResumeLayout(false);
            this.kryptonPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl1;
        private System.Windows.Forms.TabPage tabPrincipal;
        private System.Windows.Forms.TabPage tabPage2;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel1;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel2;
        private System.Windows.Forms.TabPage tabHierarquia;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Comum.Components.HLP_TextBox txtCodigo;
        private Comum.Components.HLP_TextBox txtxSite;
        private Comum.Components.HLP_TextBox txtxDescricao;
        private HLP_DataGridView dgvEnderecos;
        private TreeView treeHierarquia;
        private System.Windows.Forms.ImageList imageList1;
        private System.ComponentModel.BackgroundWorker async_work;
        private BindingSource bsEndereco;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewMaskedTextBoxColumn xCEPDataGridViewTextBoxColumn;
        private HLP_LabelSeparator hlP_LabelSeparator1_Geral;
        private DataGridViewComboBoxColumn stPrincipalDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn stTipoEndereco;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewMaskedTextBoxColumn clxCEP;
        private DataGridViewComboBoxColumn stLogradouro;
        private DataGridViewTextBoxColumn clxEndereco;
        private DataGridViewComboBoxColumn clidCidade;
        private DataGridViewTextBoxColumn xCaixaPostalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn xLatitudeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn xLongitudeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn xFusoHorarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn xNomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clxBairro;
        private DataGridViewTextBoxColumn nNumeroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn xComplementoDataGridViewTextBoxColumn;
    }
}