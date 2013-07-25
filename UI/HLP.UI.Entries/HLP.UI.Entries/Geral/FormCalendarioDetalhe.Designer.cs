using HLP.Comum.Components;
namespace HLP.UI.Entries.Geral
{
    partial class FormCalendarioDetalhe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalendarioDetalhe));
            this.kryptonPanel1 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.btnGerar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonTabControl2 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.kryptonPanel3 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.dgvIntervalo = new HLP.Comum.Components.HLP_DataGridView();
            this.txtDiasSemProgramacao = new HLP.Comum.Components.HLP_TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dtpDataInicial = new HLP.Comum.Components.HLP_DateTimePicker();
            this.dtpDataFinal = new HLP.Comum.Components.HLP_DateTimePicker();
            this.cboConsiderarSabado = new HLP.Comum.Components.HLP_ComboBox();
            this.cboConsiderarDomingo = new HLP.Comum.Components.HLP_ComboBox();
            this.dtpSegSexInicial = new HLP.Comum.Components.HLP_DateTimePicker();
            this.dtpSegSexFinal = new HLP.Comum.Components.HLP_DateTimePicker();
            this.dtpSabadoInicial = new HLP.Comum.Components.HLP_DateTimePicker();
            this.dtpSabadoFinal = new HLP.Comum.Components.HLP_DateTimePicker();
            this.dtpDomingoInicial = new HLP.Comum.Components.HLP_DateTimePicker();
            this.dtpDomingoFinal = new HLP.Comum.Components.HLP_DateTimePicker();
            this.Inicio = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            this.Fim = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            this.kryptonPanel1.SuspendLayout();
            this.kryptonTabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntervalo)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.BorderWidth = 0;
            this.kryptonPanel1.Controls.Add(this.btnGerar);
            this.kryptonPanel1.Controls.Add(this.kryptonTabControl2);
            this.kryptonPanel1.Controls.Add(this.txtDiasSemProgramacao);
            this.kryptonPanel1.Controls.Add(this.flowLayoutPanel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.kryptonPanel1.GradientToogleColors = false;
            this.kryptonPanel1.GradientUseBlend = false;
            this.kryptonPanel1.GradientUseSolid = true;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PersistentColors = false;
            this.kryptonPanel1.Size = new System.Drawing.Size(512, 379);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(325, 180);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(160, 25);
            this.btnGerar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnGerar.TabIndex = 20;
            this.btnGerar.Values.Text = "Gerar Detalhamento";
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
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
            this.kryptonTabControl2.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.kryptonTabControl2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.kryptonTabControl2.HotTrack = true;
            this.kryptonTabControl2.Location = new System.Drawing.Point(3, 211);
            this.kryptonTabControl2.Name = "kryptonTabControl2";
            this.kryptonTabControl2.PreserveTabColor = false;
            this.kryptonTabControl2.SelectedIndex = 0;
            this.kryptonTabControl2.Size = new System.Drawing.Size(482, 153);
            this.kryptonTabControl2.TabIndex = 5;
            this.kryptonTabControl2.UseExtendedLayout = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage3.Controls.Add(this.kryptonPanel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(474, 124);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Tag = false;
            this.tabPage3.Text = "Intervalos de paradas";
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.BorderWidth = 0;
            this.kryptonPanel3.Controls.Add(this.dgvIntervalo);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel3.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.kryptonPanel3.GradientToogleColors = false;
            this.kryptonPanel3.GradientUseBlend = false;
            this.kryptonPanel3.GradientUseSolid = true;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.PersistentColors = false;
            this.kryptonPanel3.Size = new System.Drawing.Size(474, 124);
            this.kryptonPanel3.TabIndex = 0;
            // 
            // dgvIntervalo
            // 
            this.dgvIntervalo.Altera = false;
            this.dgvIntervalo.cm = null;
            this.dgvIntervalo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIntervalo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Inicio,
            this.Fim});
            this.dgvIntervalo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIntervalo.DragDropLinha = false;
            this.dgvIntervalo.Exclui = false;
            this.dgvIntervalo.Inclui = false;
            this.dgvIntervalo.Location = new System.Drawing.Point(0, 0);
            this.dgvIntervalo.Name = "dgvIntervalo";
            this.dgvIntervalo.Size = new System.Drawing.Size(474, 124);
            this.dgvIntervalo.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvIntervalo.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvIntervalo.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvIntervalo.TabIndex = 22;
            this.dgvIntervalo.Tag = "Calendario_Detalhe";
            this.dgvIntervalo.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvIntervalo_DefaultValuesNeeded);
            // 
            // txtDiasSemProgramacao
            // 
            this.txtDiasSemProgramacao._LabelGroup = null;
            this.txtDiasSemProgramacao._LabelText = "Dia/mês sem programação (ex: 01/01)";
            this.txtDiasSemProgramacao._Multiline = false;
            this.txtDiasSemProgramacao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtDiasSemProgramacao._Password = false;
            this.txtDiasSemProgramacao._Regex = null;
            this.txtDiasSemProgramacao._TamanhoComponente = 278;
            this.txtDiasSemProgramacao._TamanhoMaiorLabel = 0;
            this.txtDiasSemProgramacao._Visible = true;
            this.txtDiasSemProgramacao.BackColor = System.Drawing.Color.Transparent;
            this.txtDiasSemProgramacao.Base = null;
            this.txtDiasSemProgramacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDiasSemProgramacao.Color = System.Drawing.Color.White;
            this.txtDiasSemProgramacao.Location = new System.Drawing.Point(11, 153);
            this.txtDiasSemProgramacao.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.txtDiasSemProgramacao.MaxLength = 32767;
            this.txtDiasSemProgramacao.Name = "txtDiasSemProgramacao";
            this.txtDiasSemProgramacao.ReadOnly = false;
            this.txtDiasSemProgramacao.Size = new System.Drawing.Size(474, 21);
            this.txtDiasSemProgramacao.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.dtpDataInicial);
            this.flowLayoutPanel1.Controls.Add(this.dtpDataFinal);
            this.flowLayoutPanel1.Controls.Add(this.cboConsiderarSabado);
            this.flowLayoutPanel1.Controls.Add(this.cboConsiderarDomingo);
            this.flowLayoutPanel1.Controls.Add(this.dtpSegSexInicial);
            this.flowLayoutPanel1.Controls.Add(this.dtpSegSexFinal);
            this.flowLayoutPanel1.Controls.Add(this.dtpSabadoInicial);
            this.flowLayoutPanel1.Controls.Add(this.dtpSabadoFinal);
            this.flowLayoutPanel1.Controls.Add(this.dtpDomingoInicial);
            this.flowLayoutPanel1.Controls.Add(this.dtpDomingoFinal);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(512, 147);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial._LabelGroup = null;
            this.dtpDataInicial._LabelText = "Data inicial";
            this.dtpDataInicial._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.dtpDataInicial._Regex = null;
            this.dtpDataInicial._TamanhoComponente = 91;
            this.dtpDataInicial._TamanhoMaiorLabel = 126;
            this.dtpDataInicial._Visible = true;
            this.dtpDataInicial.BackColor = System.Drawing.Color.Transparent;
            this.dtpDataInicial.Base = null;
            this.dtpDataInicial.Color = System.Drawing.Color.Empty;
            this.dtpDataInicial.CustomFormat = "";
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(64, 3);
            this.dtpDataInicial.Margin = new System.Windows.Forms.Padding(64, 3, 15, 3);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(155, 21);
            this.dtpDataInicial.TabIndex = 0;
            this.dtpDataInicial.Value = new System.DateTime(2012, 8, 13, 16, 28, 57, 168);
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal._LabelGroup = null;
            this.dtpDataFinal._LabelText = "Data final";
            this.dtpDataFinal._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.dtpDataFinal._Regex = null;
            this.dtpDataFinal._TamanhoComponente = 91;
            this.dtpDataFinal._TamanhoMaiorLabel = 126;
            this.dtpDataFinal._Visible = true;
            this.dtpDataFinal.BackColor = System.Drawing.Color.Transparent;
            this.dtpDataFinal.Base = null;
            this.dtpDataFinal.Color = System.Drawing.Color.Empty;
            this.dtpDataFinal.CustomFormat = "";
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(71, 30);
            this.dtpDataFinal.Margin = new System.Windows.Forms.Padding(71, 3, 15, 3);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(148, 21);
            this.dtpDataFinal.TabIndex = 1;
            this.dtpDataFinal.Value = new System.DateTime(2012, 8, 13, 16, 28, 57, 168);
            // 
            // cboConsiderarSabado
            // 
            this.cboConsiderarSabado._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cboConsiderarSabado._Itens")));
            this.cboConsiderarSabado._LabelGroup = null;
            this.cboConsiderarSabado._LabelText = "Considerar sábado?";
            this.cboConsiderarSabado._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cboConsiderarSabado._Regex = null;
            this.cboConsiderarSabado._situacao = true;
            this.cboConsiderarSabado._TamanhoComponente = 68;
            this.cboConsiderarSabado._TamanhoMaiorLabel = 126;
            this.cboConsiderarSabado._Visible = true;
            this.cboConsiderarSabado.BackColor = System.Drawing.Color.Transparent;
            this.cboConsiderarSabado.Base = null;
            this.cboConsiderarSabado.Color = System.Drawing.Color.White;
            this.cboConsiderarSabado.DataSource = null;
            this.cboConsiderarSabado.DisplayMember = "DisplayMember";
            this.cboConsiderarSabado.Location = new System.Drawing.Point(20, 57);
            this.cboConsiderarSabado.Margin = new System.Windows.Forms.Padding(20, 3, 15, 3);
            this.cboConsiderarSabado.Name = "cboConsiderarSabado";
            this.cboConsiderarSabado.SelectedIndex = -1;
            this.cboConsiderarSabado.SelectedValue = 0;
            this.cboConsiderarSabado.Size = new System.Drawing.Size(177, 21);
            this.cboConsiderarSabado.TabIndex = 2;
            this.cboConsiderarSabado.ValueMember = "ValueMember";
            // 
            // cboConsiderarDomingo
            // 
            this.cboConsiderarDomingo._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cboConsiderarDomingo._Itens")));
            this.cboConsiderarDomingo._LabelGroup = null;
            this.cboConsiderarDomingo._LabelText = "Considerar domingo?";
            this.cboConsiderarDomingo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cboConsiderarDomingo._Regex = null;
            this.cboConsiderarDomingo._situacao = true;
            this.cboConsiderarDomingo._TamanhoComponente = 68;
            this.cboConsiderarDomingo._TamanhoMaiorLabel = 126;
            this.cboConsiderarDomingo._Visible = true;
            this.cboConsiderarDomingo.BackColor = System.Drawing.Color.Transparent;
            this.cboConsiderarDomingo.Base = null;
            this.cboConsiderarDomingo.Color = System.Drawing.Color.White;
            this.cboConsiderarDomingo.DataSource = null;
            this.cboConsiderarDomingo.DisplayMember = "DisplayMember";
            this.cboConsiderarDomingo.Location = new System.Drawing.Point(11, 84);
            this.cboConsiderarDomingo.Margin = new System.Windows.Forms.Padding(11, 3, 15, 3);
            this.cboConsiderarDomingo.Name = "cboConsiderarDomingo";
            this.cboConsiderarDomingo.SelectedIndex = -1;
            this.cboConsiderarDomingo.SelectedValue = 0;
            this.cboConsiderarDomingo.Size = new System.Drawing.Size(186, 21);
            this.cboConsiderarDomingo.TabIndex = 8;
            this.cboConsiderarDomingo.ValueMember = "ValueMember";
            // 
            // dtpSegSexInicial
            // 
            this.dtpSegSexInicial._LabelGroup = null;
            this.dtpSegSexInicial._LabelText = "Hora inicial – seg a sex";
            this.dtpSegSexInicial._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.dtpSegSexInicial._Regex = null;
            this.dtpSegSexInicial._TamanhoComponente = 93;
            this.dtpSegSexInicial._TamanhoMaiorLabel = 126;
            this.dtpSegSexInicial._Visible = true;
            this.dtpSegSexInicial.BackColor = System.Drawing.Color.Transparent;
            this.dtpSegSexInicial.Base = null;
            this.dtpSegSexInicial.Color = System.Drawing.Color.Empty;
            this.dtpSegSexInicial.CustomFormat = "";
            this.dtpSegSexInicial.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSegSexInicial.Location = new System.Drawing.Point(3, 111);
            this.dtpSegSexInicial.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.dtpSegSexInicial.Name = "dtpSegSexInicial";
            this.dtpSegSexInicial.Size = new System.Drawing.Size(216, 21);
            this.dtpSegSexInicial.TabIndex = 2;
            this.dtpSegSexInicial.Value = new System.DateTime(2012, 8, 14, 0, 0, 0, 0);
            // 
            // dtpSegSexFinal
            // 
            this.dtpSegSexFinal._LabelGroup = null;
            this.dtpSegSexFinal._LabelText = "Hora final – seg a sex";
            this.dtpSegSexFinal._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.dtpSegSexFinal._Regex = null;
            this.dtpSegSexFinal._TamanhoComponente = 92;
            this.dtpSegSexFinal._TamanhoMaiorLabel = 126;
            this.dtpSegSexFinal._Visible = true;
            this.dtpSegSexFinal.BackColor = System.Drawing.Color.Transparent;
            this.dtpSegSexFinal.Base = null;
            this.dtpSegSexFinal.Color = System.Drawing.Color.Empty;
            this.dtpSegSexFinal.CustomFormat = "";
            this.dtpSegSexFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSegSexFinal.Location = new System.Drawing.Point(245, 3);
            this.dtpSegSexFinal.Margin = new System.Windows.Forms.Padding(11, 3, 15, 3);
            this.dtpSegSexFinal.Name = "dtpSegSexFinal";
            this.dtpSegSexFinal.Size = new System.Drawing.Size(208, 21);
            this.dtpSegSexFinal.TabIndex = 3;
            this.dtpSegSexFinal.Value = new System.DateTime(2012, 8, 14, 0, 0, 0, 0);
            // 
            // dtpSabadoInicial
            // 
            this.dtpSabadoInicial._LabelGroup = null;
            this.dtpSabadoInicial._LabelText = "Hora inicial – sábado";
            this.dtpSabadoInicial._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.dtpSabadoInicial._Regex = null;
            this.dtpSabadoInicial._TamanhoComponente = 90;
            this.dtpSabadoInicial._TamanhoMaiorLabel = 126;
            this.dtpSabadoInicial._Visible = true;
            this.dtpSabadoInicial.BackColor = System.Drawing.Color.Transparent;
            this.dtpSabadoInicial.Base = null;
            this.dtpSabadoInicial.Color = System.Drawing.Color.Empty;
            this.dtpSabadoInicial.CustomFormat = "";
            this.dtpSabadoInicial.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSabadoInicial.Location = new System.Drawing.Point(248, 30);
            this.dtpSabadoInicial.Margin = new System.Windows.Forms.Padding(14, 3, 15, 3);
            this.dtpSabadoInicial.Name = "dtpSabadoInicial";
            this.dtpSabadoInicial.Size = new System.Drawing.Size(205, 21);
            this.dtpSabadoInicial.TabIndex = 4;
            this.dtpSabadoInicial.Value = new System.DateTime(2012, 8, 14, 0, 0, 0, 0);
            // 
            // dtpSabadoFinal
            // 
            this.dtpSabadoFinal._LabelGroup = null;
            this.dtpSabadoFinal._LabelText = "Hora final – sábado";
            this.dtpSabadoFinal._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.dtpSabadoFinal._Regex = null;
            this.dtpSabadoFinal._TamanhoComponente = 90;
            this.dtpSabadoFinal._TamanhoMaiorLabel = 126;
            this.dtpSabadoFinal._Visible = true;
            this.dtpSabadoFinal.BackColor = System.Drawing.Color.Transparent;
            this.dtpSabadoFinal.Base = null;
            this.dtpSabadoFinal.Color = System.Drawing.Color.Empty;
            this.dtpSabadoFinal.CustomFormat = "";
            this.dtpSabadoFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSabadoFinal.Location = new System.Drawing.Point(255, 57);
            this.dtpSabadoFinal.Margin = new System.Windows.Forms.Padding(21, 3, 15, 3);
            this.dtpSabadoFinal.Name = "dtpSabadoFinal";
            this.dtpSabadoFinal.Size = new System.Drawing.Size(198, 21);
            this.dtpSabadoFinal.TabIndex = 5;
            this.dtpSabadoFinal.Value = new System.DateTime(2012, 8, 14, 0, 0, 0, 0);
            // 
            // dtpDomingoInicial
            // 
            this.dtpDomingoInicial._LabelGroup = null;
            this.dtpDomingoInicial._LabelText = "Hora inicial – domingo";
            this.dtpDomingoInicial._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.dtpDomingoInicial._Regex = null;
            this.dtpDomingoInicial._TamanhoComponente = 91;
            this.dtpDomingoInicial._TamanhoMaiorLabel = 126;
            this.dtpDomingoInicial._Visible = true;
            this.dtpDomingoInicial.BackColor = System.Drawing.Color.Transparent;
            this.dtpDomingoInicial.Base = null;
            this.dtpDomingoInicial.Color = System.Drawing.Color.Empty;
            this.dtpDomingoInicial.CustomFormat = "";
            this.dtpDomingoInicial.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDomingoInicial.Location = new System.Drawing.Point(238, 84);
            this.dtpDomingoInicial.Margin = new System.Windows.Forms.Padding(4, 3, 15, 3);
            this.dtpDomingoInicial.Name = "dtpDomingoInicial";
            this.dtpDomingoInicial.Size = new System.Drawing.Size(215, 21);
            this.dtpDomingoInicial.TabIndex = 6;
            this.dtpDomingoInicial.Value = new System.DateTime(2012, 8, 14, 0, 0, 0, 0);
            // 
            // dtpDomingoFinal
            // 
            this.dtpDomingoFinal._LabelGroup = null;
            this.dtpDomingoFinal._LabelText = "Hora final – domingo";
            this.dtpDomingoFinal._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.dtpDomingoFinal._Regex = null;
            this.dtpDomingoFinal._TamanhoComponente = 91;
            this.dtpDomingoFinal._TamanhoMaiorLabel = 126;
            this.dtpDomingoFinal._Visible = true;
            this.dtpDomingoFinal.BackColor = System.Drawing.Color.Transparent;
            this.dtpDomingoFinal.Base = null;
            this.dtpDomingoFinal.Color = System.Drawing.Color.Empty;
            this.dtpDomingoFinal.CustomFormat = "";
            this.dtpDomingoFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDomingoFinal.Location = new System.Drawing.Point(245, 111);
            this.dtpDomingoFinal.Margin = new System.Windows.Forms.Padding(11, 3, 15, 3);
            this.dtpDomingoFinal.Name = "dtpDomingoFinal";
            this.dtpDomingoFinal.Size = new System.Drawing.Size(208, 21);
            this.dtpDomingoFinal.TabIndex = 7;
            this.dtpDomingoFinal.Value = new System.DateTime(2012, 8, 14, 0, 0, 0, 0);
            // 
            // Inicio
            // 
            this.Inicio.AutoShift = true;
            this.Inicio.CalendarTodayDate = new System.DateTime(2012, 8, 13, 0, 0, 0, 0);
            this.Inicio.Checked = false;
            this.Inicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Inicio.HeaderText = "Hora Inicial";
            this.Inicio.Name = "Inicio";
            this.Inicio.ShowUpDown = true;
            this.Inicio.Width = 200;
            // 
            // Fim
            // 
            this.Fim.AutoShift = true;
            this.Fim.CalendarTodayDate = new System.DateTime(2012, 8, 13, 0, 0, 0, 0);
            this.Fim.Checked = false;
            this.Fim.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Fim.HeaderText = "Hora Final";
            this.Fim.Name = "Fim";
            this.Fim.ShowUpDown = true;
            this.Fim.Width = 200;
            // 
            // FormCalendarioDetalhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 379);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalendarioDetalhe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerar Detalhamento";
            this.Load += new System.EventHandler(this.FormCalendarioDetalhe_Load);
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonTabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.kryptonPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntervalo)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Comum.Components.HLP_DateTimePicker dtpDataInicial;
        private Comum.Components.HLP_DateTimePicker dtpDataFinal;
        private Comum.Components.HLP_DateTimePicker dtpSegSexInicial;
        private Comum.Components.HLP_DateTimePicker dtpSegSexFinal;
        private Comum.Components.HLP_DateTimePicker dtpSabadoInicial;
        private Comum.Components.HLP_DateTimePicker dtpSabadoFinal;
        private Comum.Components.HLP_DateTimePicker dtpDomingoInicial;
        private Comum.Components.HLP_DateTimePicker dtpDomingoFinal;
        private Comum.Components.HLP_TextBox txtDiasSemProgramacao;
        private Comum.Components.HLP_ComboBox cboConsiderarSabado;
        private Comum.Components.HLP_ComboBox cboConsiderarDomingo;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnGerar;
        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel3;
        private HLP_DataGridView dgvIntervalo;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn Inicio;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn Fim;
    }
}