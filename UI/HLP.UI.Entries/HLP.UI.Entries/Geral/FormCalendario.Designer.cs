using HLP.Comum.Components;
namespace HLP.UI.Entries.Geral
{
    partial class FormCalendario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalendario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonTabControl1 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kryptonPanel1 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.sp_Geral = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtCodigo = new HLP.Comum.Components.HLP_TextBox();
            this.txtxNome = new HLP.Comum.Components.HLP_TextBox();
            this.txtxDescricao = new HLP.Comum.Components.HLP_TextBox();
            this.hlP_Pesquisa1idCalendarioBase = new HLP.Comum.Components.HLP_Pesquisa();
            this.btnCalendarioBase = new HLP.Comum.Components.HLP_Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.kryptonTabControl2 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.kryptonPanel3 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.dgvItens = new HLP.Comum.Components.HLP_DataGridView();
            this.dCalendario = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            this.dHoraInicio = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            this.dHoraTermino = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            this.bsDetalhe = new System.Windows.Forms.BindingSource(this.components);
            this.btnDetalhamento = new HLP.Comum.Components.HLP_Button();
            this.kryptonDataGridViewDateTimePickerColumn1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            this.kryptonDataGridViewDateTimePickerColumn2 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            this.kryptonDataGridViewDateTimePickerColumn3 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).BeginInit();
            this.panelPadrao.SuspendLayout();
            this.kryptonTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.kryptonPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.kryptonTabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetalhe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(577, 404);
            // 
            // panelPadrao
            // 
            this.panelPadrao.Controls.Add(this.kryptonTabControl2);
            this.panelPadrao.Controls.Add(this.splitter1);
            this.panelPadrao.Controls.Add(this.kryptonTabControl1);
            this.panelPadrao.Size = new System.Drawing.Size(575, 380);
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
            this.kryptonTabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.kryptonTabControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.kryptonTabControl1.HotTrack = true;
            this.kryptonTabControl1.Location = new System.Drawing.Point(3, 3);
            this.kryptonTabControl1.Name = "kryptonTabControl1";
            this.kryptonTabControl1.PreserveTabColor = false;
            this.kryptonTabControl1.SelectedIndex = 0;
            this.kryptonTabControl1.Size = new System.Drawing.Size(569, 201);
            this.kryptonTabControl1.TabIndex = 2;
            this.kryptonTabControl1.UseExtendedLayout = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Controls.Add(this.kryptonPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(561, 172);
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
            this.kryptonPanel1.Size = new System.Drawing.Size(561, 172);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.sp_Geral);
            this.flowLayoutPanel1.Controls.Add(this.txtCodigo);
            this.flowLayoutPanel1.Controls.Add(this.txtxNome);
            this.flowLayoutPanel1.Controls.Add(this.txtxDescricao);
            this.flowLayoutPanel1.Controls.Add(this.hlP_Pesquisa1idCalendarioBase);
            this.flowLayoutPanel1.Controls.Add(this.btnCalendarioBase);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(561, 172);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Tag = "Principal";
            // 
            // sp_Geral
            // 
            this.sp_Geral._LabelText = "Geral";
            this.sp_Geral._TamanhoMaiorLabel = 0;
            this.sp_Geral.BackColor = System.Drawing.Color.Transparent;
            this.sp_Geral.Location = new System.Drawing.Point(3, 3);
            this.sp_Geral.Name = "sp_Geral";
            this.sp_Geral.Size = new System.Drawing.Size(540, 18);
            this.sp_Geral.TabIndex = 23;
            this.sp_Geral.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo._Field = "idCalendario";
            this.txtCodigo._Help = "Chave principal do registro calendário";
            this.txtCodigo._LabelGroup = this.sp_Geral;
            this.txtCodigo._LabelText = "Código";
            this.txtCodigo._Multiline = false;
            this.txtCodigo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtCodigo._Password = false;
            this.txtCodigo._Regex = null;
            this.txtCodigo._Table = "Calendario";
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
            // txtxNome
            // 
            this.txtxNome._Field = "xNome";
            this.txtxNome._Help = "Insira resumidamente o nome do calendário";
            this.txtxNome._LabelGroup = this.sp_Geral;
            this.txtxNome._LabelText = "Nome";
            this.txtxNome._Multiline = false;
            this.txtxNome._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxNome._Password = false;
            this.txtxNome._Regex = null;
            this.txtxNome._Table = "Calendario";
            this.txtxNome._TamanhoComponente = 197;
            this.txtxNome._TamanhoMaiorLabel = 150;
            this.txtxNome._Visible = true;
            this.txtxNome.BackColor = System.Drawing.Color.Transparent;
            this.txtxNome.Base = null;
            this.txtxNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxNome.Color = System.Drawing.Color.White;
            this.txtxNome.Location = new System.Drawing.Point(116, 57);
            this.txtxNome.Margin = new System.Windows.Forms.Padding(116, 3, 15, 3);
            this.txtxNome.MaxLength = 32767;
            this.txtxNome.Name = "txtxNome";
            this.txtxNome.ReadOnly = false;
            this.txtxNome.Size = new System.Drawing.Size(234, 24);
            this.txtxNome.TabIndex = 4;
            // 
            // txtxDescricao
            // 
            this.txtxDescricao._Field = "xDescricao";
            this.txtxDescricao._Help = "Descrição do calendário";
            this.txtxDescricao._LabelGroup = this.sp_Geral;
            this.txtxDescricao._LabelText = "Descrição ";
            this.txtxDescricao._Multiline = false;
            this.txtxDescricao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxDescricao._Password = false;
            this.txtxDescricao._Regex = null;
            this.txtxDescricao._Table = "Calendario";
            this.txtxDescricao._TamanhoComponente = 271;
            this.txtxDescricao._TamanhoMaiorLabel = 150;
            this.txtxDescricao._Visible = true;
            this.txtxDescricao.BackColor = System.Drawing.Color.Transparent;
            this.txtxDescricao.Base = null;
            this.txtxDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxDescricao.Color = System.Drawing.Color.White;
            this.txtxDescricao.Location = new System.Drawing.Point(94, 87);
            this.txtxDescricao.Margin = new System.Windows.Forms.Padding(94, 3, 15, 3);
            this.txtxDescricao.MaxLength = 32767;
            this.txtxDescricao.Name = "txtxDescricao";
            this.txtxDescricao.ReadOnly = false;
            this.txtxDescricao.Size = new System.Drawing.Size(330, 22);
            this.txtxDescricao.TabIndex = 5;
            // 
            // hlP_Pesquisa1idCalendarioBase
            // 
            this.hlP_Pesquisa1idCalendarioBase._Field = "idCalendarioBase";
            this.hlP_Pesquisa1idCalendarioBase._Help = "Informar o calendário base que esse novo calendário irá usar";
            this.hlP_Pesquisa1idCalendarioBase._LabelGroup = this.sp_Geral;
            this.hlP_Pesquisa1idCalendarioBase._LabelText = "Calendário base";
            this.hlP_Pesquisa1idCalendarioBase._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_Pesquisa1idCalendarioBase._ListaCamposDisplay")));
            this.hlP_Pesquisa1idCalendarioBase._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_Pesquisa1idCalendarioBase._ListaValoresDisplay")));
            this.hlP_Pesquisa1idCalendarioBase._NomeCampoPK = "ID";
            this.hlP_Pesquisa1idCalendarioBase._NomeFormCadastroOriginal = "FormCalendario";
            this.hlP_Pesquisa1idCalendarioBase._NomeView = "vwCalendario";
            this.hlP_Pesquisa1idCalendarioBase._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_Pesquisa1idCalendarioBase._Regex = null;
            this.hlP_Pesquisa1idCalendarioBase._Table = "Calendario";
            this.hlP_Pesquisa1idCalendarioBase._TamanhoComponente = 300;
            this.hlP_Pesquisa1idCalendarioBase._TamanhoMaiorLabel = 150;
            this.hlP_Pesquisa1idCalendarioBase._Vinculado = false;
            this.hlP_Pesquisa1idCalendarioBase._Visible = true;
            this.hlP_Pesquisa1idCalendarioBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_Pesquisa1idCalendarioBase.BackColor = System.Drawing.Color.Transparent;
            this.hlP_Pesquisa1idCalendarioBase.Base = null;
            this.hlP_Pesquisa1idCalendarioBase.Location = new System.Drawing.Point(63, 115);
            this.hlP_Pesquisa1idCalendarioBase.Margin = new System.Windows.Forms.Padding(63, 3, 15, 3);
            this.hlP_Pesquisa1idCalendarioBase.Name = "hlP_Pesquisa1idCalendarioBase";
            this.hlP_Pesquisa1idCalendarioBase.ReadOnly = false;
            this.hlP_Pesquisa1idCalendarioBase.Size = new System.Drawing.Size(480, 21);
            this.hlP_Pesquisa1idCalendarioBase.TabIndex = 22;
            this.hlP_Pesquisa1idCalendarioBase.Value = 0;
            // 
            // btnCalendarioBase
            // 
            this.btnCalendarioBase._LabelGroup = this.sp_Geral;
            this.btnCalendarioBase._LabelText = "Gerar";
            this.btnCalendarioBase._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.btnCalendarioBase._Regex = null;
            this.btnCalendarioBase._TamanhoComponente = 76;
            this.btnCalendarioBase._TamanhoMaiorLabel = 150;
            this.btnCalendarioBase._Visible = true;
            this.btnCalendarioBase.Base = null;
            this.btnCalendarioBase.Location = new System.Drawing.Point(153, 142);
            this.btnCalendarioBase.Margin = new System.Windows.Forms.Padding(153, 3, 15, 3);
            this.btnCalendarioBase.Name = "btnCalendarioBase";
            this.btnCalendarioBase.Size = new System.Drawing.Size(76, 24);
            this.btnCalendarioBase.TabIndex = 24;
            this.btnCalendarioBase._btnHlpClick += new System.EventHandler(this.btnCalendarioBase_Click);
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(3, 204);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(569, 3);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // kryptonTabControl2
            // 
            this.kryptonTabControl2.AllowCloseButton = false;
            this.kryptonTabControl2.AllowContextButton = false;
            this.kryptonTabControl2.AllowNavigatorButtons = false;
            this.kryptonTabControl2.AllowSelectedTabHigh = false;
            this.kryptonTabControl2.BorderWidth = 1;
            this.kryptonTabControl2.Controls.Add(this.tabPage3);
            this.kryptonTabControl2.CornerRoundRadiusWidth = 12;
            this.kryptonTabControl2.CornerSymmetry = AC.ExtendedRenderer.Navigator.KryptonTabControl.CornSymmetry.Both;
            this.kryptonTabControl2.CornerType = AC.ExtendedRenderer.Toolkit.Drawing.DrawingMethods.CornerType.Rounded;
            this.kryptonTabControl2.CornerWidth = AC.ExtendedRenderer.Navigator.KryptonTabControl.CornWidth.Thin;
            this.kryptonTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonTabControl2.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.kryptonTabControl2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.kryptonTabControl2.HotTrack = true;
            this.kryptonTabControl2.Location = new System.Drawing.Point(3, 207);
            this.kryptonTabControl2.Name = "kryptonTabControl2";
            this.kryptonTabControl2.PreserveTabColor = false;
            this.kryptonTabControl2.SelectedIndex = 0;
            this.kryptonTabControl2.Size = new System.Drawing.Size(569, 170);
            this.kryptonTabControl2.TabIndex = 4;
            this.kryptonTabControl2.UseExtendedLayout = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage3.Controls.Add(this.kryptonPanel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(561, 141);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Tag = false;
            this.tabPage3.Text = "Detalhamento";
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.BorderWidth = 0;
            this.kryptonPanel3.Controls.Add(this.dgvItens);
            this.kryptonPanel3.Controls.Add(this.btnDetalhamento);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel3.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.kryptonPanel3.GradientToogleColors = false;
            this.kryptonPanel3.GradientUseBlend = false;
            this.kryptonPanel3.GradientUseSolid = true;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.PersistentColors = false;
            this.kryptonPanel3.Size = new System.Drawing.Size(561, 141);
            this.kryptonPanel3.TabIndex = 0;
            // 
            // dgvItens
            // 
            this.dgvItens.Altera = false;
            this.dgvItens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItens.AutoGenerateColumns = false;
            this.dgvItens.cm = null;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dCalendario,
            this.dHoraInicio,
            this.dHoraTermino});
            this.dgvItens.DataSource = this.bsDetalhe;
            this.dgvItens.DragDropLinha = false;
            this.dgvItens.Exclui = false;
            this.dgvItens.Inclui = false;
            this.dgvItens.Location = new System.Drawing.Point(0, 26);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.Size = new System.Drawing.Size(561, 120);
            this.dgvItens.TabIndex = 23;
            this.dgvItens.Tag = "Calendario_Detalhe";
            // 
            // dCalendario
            // 
            this.dCalendario.AutoShift = true;
            this.dCalendario.CalendarTodayDate = new System.DateTime(2012, 8, 14, 0, 0, 0, 0);
            this.dCalendario.Checked = false;
            this.dCalendario.DataPropertyName = "dCalendario";
            this.dCalendario.HeaderText = "Data";
            this.dCalendario.Name = "dCalendario";
            this.dCalendario.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dCalendario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dCalendario.Width = 200;
            // 
            // dHoraInicio
            // 
            this.dHoraInicio.CalendarTodayDate = new System.DateTime(2012, 8, 14, 0, 0, 0, 0);
            this.dHoraInicio.Checked = false;
            this.dHoraInicio.DataPropertyName = "dHoraInicio";
            dataGridViewCellStyle1.Format = "t";
            this.dHoraInicio.DefaultCellStyle = dataGridViewCellStyle1;
            this.dHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dHoraInicio.HeaderText = "Hora Início";
            this.dHoraInicio.Name = "dHoraInicio";
            this.dHoraInicio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dHoraInicio.ShowUpDown = true;
            this.dHoraInicio.Width = 100;
            // 
            // dHoraTermino
            // 
            this.dHoraTermino.CalendarTodayDate = new System.DateTime(2012, 8, 14, 0, 0, 0, 0);
            this.dHoraTermino.Checked = false;
            this.dHoraTermino.DataPropertyName = "dHoraTermino";
            dataGridViewCellStyle2.Format = "t";
            this.dHoraTermino.DefaultCellStyle = dataGridViewCellStyle2;
            this.dHoraTermino.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dHoraTermino.HeaderText = "Hora Término";
            this.dHoraTermino.Name = "dHoraTermino";
            this.dHoraTermino.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dHoraTermino.ShowUpDown = true;
            this.dHoraTermino.Width = 100;
            // 
            // bsDetalhe
            // 
            this.bsDetalhe.DataSource = typeof(HLP.Models.Entries.Gerais.Calendario_DetalheModel);
            // 
            // btnDetalhamento
            // 
            this.btnDetalhamento._LabelGroup = null;
            this.btnDetalhamento._LabelText = "Gerar detalhamento";
            this.btnDetalhamento._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.btnDetalhamento._Regex = null;
            this.btnDetalhamento._TamanhoComponente = 164;
            this.btnDetalhamento._TamanhoMaiorLabel = 5;
            this.btnDetalhamento._Visible = true;
            this.btnDetalhamento.Base = null;
            this.btnDetalhamento.Location = new System.Drawing.Point(4, 1);
            this.btnDetalhamento.Margin = new System.Windows.Forms.Padding(8, 3, 15, 3);
            this.btnDetalhamento.Name = "btnDetalhamento";
            this.btnDetalhamento.Size = new System.Drawing.Size(164, 24);
            this.btnDetalhamento.TabIndex = 21;
            this.btnDetalhamento._btnHlpClick += new System.EventHandler(this.btnInserir_Click);
            // 
            // kryptonDataGridViewDateTimePickerColumn1
            // 
            this.kryptonDataGridViewDateTimePickerColumn1.CalendarTodayDate = new System.DateTime(2012, 8, 13, 0, 0, 0, 0);
            this.kryptonDataGridViewDateTimePickerColumn1.Checked = false;
            this.kryptonDataGridViewDateTimePickerColumn1.DataPropertyName = "dCalendario";
            this.kryptonDataGridViewDateTimePickerColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.kryptonDataGridViewDateTimePickerColumn1.HeaderText = "Data";
            this.kryptonDataGridViewDateTimePickerColumn1.Name = "kryptonDataGridViewDateTimePickerColumn1";
            this.kryptonDataGridViewDateTimePickerColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kryptonDataGridViewDateTimePickerColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.kryptonDataGridViewDateTimePickerColumn1.Width = 100;
            // 
            // kryptonDataGridViewDateTimePickerColumn2
            // 
            this.kryptonDataGridViewDateTimePickerColumn2.CalendarTodayDate = new System.DateTime(2012, 8, 13, 0, 0, 0, 0);
            this.kryptonDataGridViewDateTimePickerColumn2.Checked = false;
            this.kryptonDataGridViewDateTimePickerColumn2.DataPropertyName = "dHoraInicio";
            this.kryptonDataGridViewDateTimePickerColumn2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.kryptonDataGridViewDateTimePickerColumn2.HeaderText = "Hora Início";
            this.kryptonDataGridViewDateTimePickerColumn2.Name = "kryptonDataGridViewDateTimePickerColumn2";
            this.kryptonDataGridViewDateTimePickerColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kryptonDataGridViewDateTimePickerColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.kryptonDataGridViewDateTimePickerColumn2.Width = 120;
            // 
            // kryptonDataGridViewDateTimePickerColumn3
            // 
            this.kryptonDataGridViewDateTimePickerColumn3.CalendarTodayDate = new System.DateTime(2012, 8, 13, 0, 0, 0, 0);
            this.kryptonDataGridViewDateTimePickerColumn3.Checked = false;
            this.kryptonDataGridViewDateTimePickerColumn3.DataPropertyName = "dHoraTermino";
            this.kryptonDataGridViewDateTimePickerColumn3.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.kryptonDataGridViewDateTimePickerColumn3.HeaderText = "Hora Término";
            this.kryptonDataGridViewDateTimePickerColumn3.Name = "kryptonDataGridViewDateTimePickerColumn3";
            this.kryptonDataGridViewDateTimePickerColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kryptonDataGridViewDateTimePickerColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.kryptonDataGridViewDateTimePickerColumn3.Width = 120;
            // 
            // FormCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 431);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCalendario";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = -10;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text = "Calendário";
            this.Load += new System.EventHandler(this.FormCalendario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).EndInit();
            this.panelPadrao.ResumeLayout(false);
            this.kryptonTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.kryptonPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.kryptonTabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.kryptonPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetalhe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Comum.Components.HLP_TextBox txtCodigo;
        private Comum.Components.HLP_TextBox txtxNome;
        private Comum.Components.HLP_TextBox txtxDescricao;
        private System.Windows.Forms.Splitter splitter1;
        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel3;
        private System.Windows.Forms.BindingSource bsDetalhe;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn kryptonDataGridViewDateTimePickerColumn1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn kryptonDataGridViewDateTimePickerColumn2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn kryptonDataGridViewDateTimePickerColumn3;
        private Comum.Components.HLP_Pesquisa hlP_Pesquisa1idCalendarioBase;
        private HLP_LabelSeparator sp_Geral;
        private HLP_Button btnCalendarioBase;
        private HLP_Button btnDetalhamento;
        private HLP_DataGridView dgvItens;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn dCalendario;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn dHoraInicio;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn dHoraTermino;
    }
}