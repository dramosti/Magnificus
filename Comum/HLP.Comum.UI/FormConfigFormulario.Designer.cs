namespace HLP.Comum.UI
{
    partial class FormConfigFormulario
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node0");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node3", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node1", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node5", new System.Windows.Forms.TreeNode[] {
            treeNode6});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfigFormulario));
            this.headerConfig = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.TreeFormulario = new ComponentFactory.Krypton.Toolkit.KryptonTreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonSplitContainer2 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.kryptonSplitContainer3 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstDados = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.kryptonHeader3 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FlowConfig = new System.Windows.Forms.FlowLayoutPanel();
            this.kryptonHeader2 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.panelDesign = new System.Windows.Forms.Panel();
            this.infoFieldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtHelp = new HLP.Comum.Components.HLP_TextBox();
            this.txtLabelText = new HLP.Comum.Components.HLP_TextBox();
            this.nudDecimalPlaces = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudMaxLength = new HLP.Comum.Components.HLP_NumericUpDown();
            this.chkEnabled = new HLP.Comum.Components.HLP_CheckBox();
            this.chkVisible = new HLP.Comum.Components.HLP_CheckBox();
            this.nudComprimento = new HLP.Comum.Components.HLP_NumericUpDown();
            this.btnValorPadrao = new HLP.Comum.Components.HLP_Button();
            this.btnCor = new HLP.Comum.Components.HLP_Button();
            this.listDisplay = new HLP.Comum.Components.HLP_ListBox2();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2.Panel1)).BeginInit();
            this.kryptonSplitContainer2.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2.Panel2)).BeginInit();
            this.kryptonSplitContainer2.Panel2.SuspendLayout();
            this.kryptonSplitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer3.Panel1)).BeginInit();
            this.kryptonSplitContainer3.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer3.Panel2)).BeginInit();
            this.kryptonSplitContainer3.Panel2.SuspendLayout();
            this.kryptonSplitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).BeginInit();
            this.kryptonSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).BeginInit();
            this.kryptonSplitContainer1.Panel2.SuspendLayout();
            this.kryptonSplitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.FlowConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoFieldBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // headerConfig
            // 
            this.headerConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerConfig.Location = new System.Drawing.Point(0, 0);
            this.headerConfig.Name = "headerConfig";
            this.headerConfig.Size = new System.Drawing.Size(1214, 31);
            this.headerConfig.TabIndex = 1;
            this.headerConfig.Values.Description = "";
            this.headerConfig.Values.Heading = "Configuração";
            // 
            // TreeFormulario
            // 
            this.TreeFormulario.AllowDrop = true;
            this.TreeFormulario.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlAlternate;
            this.TreeFormulario.BorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.FormCustom1;
            this.TreeFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeFormulario.FullRowSelect = true;
            this.TreeFormulario.HideSelection = false;
            this.TreeFormulario.ImageIndex = 0;
            this.TreeFormulario.ImageList = this.imageList1;
            this.TreeFormulario.ItemHeight = 25;
            this.TreeFormulario.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorOverflow;
            this.TreeFormulario.Location = new System.Drawing.Point(0, 0);
            this.TreeFormulario.Name = "TreeFormulario";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Node0";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Node2";
            treeNode3.Name = "Node4";
            treeNode3.Text = "Node4";
            treeNode4.Name = "Node3";
            treeNode4.Text = "Node3";
            treeNode5.Name = "Node1";
            treeNode5.Text = "Node1";
            treeNode6.Name = "Node6";
            treeNode6.Text = "Node6";
            treeNode7.Name = "Node5";
            treeNode7.Text = "Node5";
            this.TreeFormulario.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode5,
            treeNode7});
            this.TreeFormulario.SelectedImageIndex = 0;
            this.TreeFormulario.ShowNodeToolTips = true;
            this.TreeFormulario.Size = new System.Drawing.Size(315, 478);
            this.TreeFormulario.TabIndex = 2;
            this.TreeFormulario.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeFormulario_AfterSelect);
            this.TreeFormulario.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.TreeFormulario_ItemDrag);
            this.TreeFormulario.DragDrop += new System.Windows.Forms.DragEventHandler(this.TreeFormulario_DragDrop);
            this.TreeFormulario.DragEnter += new System.Windows.Forms.DragEventHandler(this.TreeFormulario_DragEnter);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1349871595_application_form.ico");
            this.imageList1.Images.SetKeyName(1, "Control_FlowLayoutPanel.bmp");
            this.imageList1.Images.SetKeyName(2, "1371680346_58418.ico");
            this.imageList1.Images.SetKeyName(3, "Control.png");
            this.imageList1.Images.SetKeyName(4, "gridView.ico");
            this.imageList1.Images.SetKeyName(5, "coluna.ico");
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonSplitContainer2);
            this.kryptonPanel1.Controls.Add(this.headerConfig);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1214, 509);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // kryptonSplitContainer2
            // 
            this.kryptonSplitContainer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.kryptonSplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonSplitContainer2.Location = new System.Drawing.Point(0, 31);
            this.kryptonSplitContainer2.Name = "kryptonSplitContainer2";
            // 
            // kryptonSplitContainer2.Panel1
            // 
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.TreeFormulario);
            // 
            // kryptonSplitContainer2.Panel2
            // 
            this.kryptonSplitContainer2.Panel2.Controls.Add(this.kryptonSplitContainer3);
            this.kryptonSplitContainer2.Size = new System.Drawing.Size(1214, 478);
            this.kryptonSplitContainer2.SplitterDistance = 315;
            this.kryptonSplitContainer2.TabIndex = 13;
            // 
            // kryptonSplitContainer3
            // 
            this.kryptonSplitContainer3.Cursor = System.Windows.Forms.Cursors.Default;
            this.kryptonSplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonSplitContainer3.Location = new System.Drawing.Point(0, 0);
            this.kryptonSplitContainer3.Name = "kryptonSplitContainer3";
            this.kryptonSplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // kryptonSplitContainer3.Panel1
            // 
            this.kryptonSplitContainer3.Panel1.Controls.Add(this.kryptonSplitContainer1);
            // 
            // kryptonSplitContainer3.Panel2
            // 
            this.kryptonSplitContainer3.Panel2.Controls.Add(this.panelDesign);
            this.kryptonSplitContainer3.Size = new System.Drawing.Size(894, 478);
            this.kryptonSplitContainer3.SplitterDistance = 396;
            this.kryptonSplitContainer3.TabIndex = 0;
            // 
            // kryptonSplitContainer1
            // 
            this.kryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.kryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.kryptonSplitContainer1.Name = "kryptonSplitContainer1";
            // 
            // kryptonSplitContainer1.Panel1
            // 
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // kryptonSplitContainer1.Panel2
            // 
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.panel1);
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(894, 396);
            this.kryptonSplitContainer1.SplitterDistance = 280;
            this.kryptonSplitContainer1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lstDados);
            this.panel2.Controls.Add(this.kryptonHeader3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 396);
            this.panel2.TabIndex = 7;
            // 
            // lstDados
            // 
            this.lstDados.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbonAppMenu;
            this.lstDados.BorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ButtonNavigatorOverflow;
            this.lstDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDados.Items.AddRange(new object[] {
            "Tabela   -   (CLIENTE)",
            "Campo  -   (xProd)",
            "Requerido - (True)"});
            this.lstDados.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom1;
            this.lstDados.Location = new System.Drawing.Point(0, 31);
            this.lstDados.Name = "lstDados";
            this.lstDados.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.lstDados.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstDados.Size = new System.Drawing.Size(280, 365);
            this.lstDados.TabIndex = 3;
            // 
            // kryptonHeader3
            // 
            this.kryptonHeader3.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader3.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader3.Name = "kryptonHeader3";
            this.kryptonHeader3.Size = new System.Drawing.Size(280, 31);
            this.kryptonHeader3.TabIndex = 2;
            this.kryptonHeader3.Values.Description = "";
            this.kryptonHeader3.Values.Heading = "Base de Dados";
            this.kryptonHeader3.Values.Image = global::HLP.Comum.UI.Properties.Resources.Utilitarios;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.FlowConfig);
            this.panel1.Controls.Add(this.kryptonHeader2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 396);
            this.panel1.TabIndex = 6;
            // 
            // FlowConfig
            // 
            this.FlowConfig.AutoScroll = true;
            this.FlowConfig.Controls.Add(this.txtHelp);
            this.FlowConfig.Controls.Add(this.txtLabelText);
            this.FlowConfig.Controls.Add(this.nudDecimalPlaces);
            this.FlowConfig.Controls.Add(this.nudMaxLength);
            this.FlowConfig.Controls.Add(this.chkEnabled);
            this.FlowConfig.Controls.Add(this.chkVisible);
            this.FlowConfig.Controls.Add(this.nudComprimento);
            this.FlowConfig.Controls.Add(this.btnValorPadrao);
            this.FlowConfig.Controls.Add(this.btnCor);
            this.FlowConfig.Controls.Add(this.listDisplay);
            this.FlowConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowConfig.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlowConfig.Location = new System.Drawing.Point(0, 31);
            this.FlowConfig.Name = "FlowConfig";
            this.FlowConfig.Size = new System.Drawing.Size(609, 365);
            this.FlowConfig.TabIndex = 3;
            // 
            // kryptonHeader2
            // 
            this.kryptonHeader2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader2.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader2.Name = "kryptonHeader2";
            this.kryptonHeader2.Size = new System.Drawing.Size(609, 31);
            this.kryptonHeader2.TabIndex = 2;
            this.kryptonHeader2.Values.Description = "";
            this.kryptonHeader2.Values.Heading = "Propriedades";
            // 
            // panelDesign
            // 
            this.panelDesign.BackColor = System.Drawing.Color.Transparent;
            this.panelDesign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDesign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesign.Location = new System.Drawing.Point(0, 0);
            this.panelDesign.Name = "panelDesign";
            this.panelDesign.Size = new System.Drawing.Size(894, 77);
            this.panelDesign.TabIndex = 12;
            // 
            // infoFieldBindingSource
            // 
            this.infoFieldBindingSource.DataSource = typeof(HLP.Comum.Models.InfoFieldModel);
            // 
            // txtHelp
            // 
            this.txtHelp._LabelGroup = null;
            this.txtHelp._LabelText = "Help";
            this.txtHelp._Multiline = false;
            this.txtHelp._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtHelp._Password = false;
            this.txtHelp._Regex = null;
            this.txtHelp._TamanhoComponente = 600;
            this.txtHelp._TamanhoMaiorLabel = 142;
            this.txtHelp._Visible = true;
            this.txtHelp.BackColor = System.Drawing.Color.Transparent;
            this.txtHelp.Base = null;
            this.txtHelp.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtHelp.Color = System.Drawing.Color.White;
            this.txtHelp.Location = new System.Drawing.Point(114, 3);
            this.txtHelp.Margin = new System.Windows.Forms.Padding(114, 3, 15, 3);
            this.txtHelp.MaxLength = 5000;
            this.txtHelp.Name = "txtHelp";
            this.txtHelp.ReadOnly = false;
            this.txtHelp.Size = new System.Drawing.Size(631, 19);
            this.txtHelp.TabIndex = 0;
            this.txtHelp.Tag = "_Help";
            this.txtHelp._TextChanged += new System.EventHandler(this.Componentes__TextChanged);
            // 
            // txtLabelText
            // 
            this.txtLabelText._LabelGroup = null;
            this.txtLabelText._LabelText = "Texto do label";
            this.txtLabelText._Multiline = false;
            this.txtLabelText._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtLabelText._Password = false;
            this.txtLabelText._Regex = null;
            this.txtLabelText._TamanhoComponente = 600;
            this.txtLabelText._TamanhoMaiorLabel = 142;
            this.txtLabelText._Visible = true;
            this.txtLabelText.BackColor = System.Drawing.Color.Transparent;
            this.txtLabelText.Base = null;
            this.txtLabelText.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtLabelText.Color = System.Drawing.Color.White;
            this.txtLabelText.Location = new System.Drawing.Point(66, 28);
            this.txtLabelText.Margin = new System.Windows.Forms.Padding(66, 3, 15, 3);
            this.txtLabelText.MaxLength = 500;
            this.txtLabelText.Name = "txtLabelText";
            this.txtLabelText.ReadOnly = false;
            this.txtLabelText.Size = new System.Drawing.Size(679, 19);
            this.txtLabelText.TabIndex = 1;
            this.txtLabelText.Tag = "_LabelText";
            this.txtLabelText._TextChanged += new System.EventHandler(this.Componentes__TextChanged);
            // 
            // nudDecimalPlaces
            // 
            this.nudDecimalPlaces._LabelGroup = null;
            this.nudDecimalPlaces._LabelText = "Casas decimais";
            this.nudDecimalPlaces._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudDecimalPlaces._Regex = null;
            this.nudDecimalPlaces._TamanhoComponente = 86;
            this.nudDecimalPlaces._TamanhoMaiorLabel = 142;
            this.nudDecimalPlaces._Visible = true;
            this.nudDecimalPlaces.BackColor = System.Drawing.Color.Transparent;
            this.nudDecimalPlaces.Base = null;
            this.nudDecimalPlaces.Color = System.Drawing.Color.White;
            this.nudDecimalPlaces.DecimalPlaces = 0;
            this.nudDecimalPlaces.Location = new System.Drawing.Point(62, 53);
            this.nudDecimalPlaces.Margin = new System.Windows.Forms.Padding(62, 3, 15, 3);
            this.nudDecimalPlaces.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.nudDecimalPlaces.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudDecimalPlaces.Name = "nudDecimalPlaces";
            this.nudDecimalPlaces.ReadOnly = false;
            this.nudDecimalPlaces.Size = new System.Drawing.Size(169, 21);
            this.nudDecimalPlaces.TabIndex = 2;
            this.nudDecimalPlaces.Tag = "DecimalPlaces";
            this.nudDecimalPlaces.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudDecimalPlaces.ValueInt = 0;
            this.nudDecimalPlaces.Visible = false;
            this.nudDecimalPlaces._ValueChanged += new System.EventHandler(this.Componentes__TextChanged);
            // 
            // nudMaxLength
            // 
            this.nudMaxLength._LabelGroup = null;
            this.nudMaxLength._LabelText = "Tamanho máximo";
            this.nudMaxLength._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudMaxLength._Regex = null;
            this.nudMaxLength._TamanhoComponente = 86;
            this.nudMaxLength._TamanhoMaiorLabel = 142;
            this.nudMaxLength._Visible = true;
            this.nudMaxLength.BackColor = System.Drawing.Color.Transparent;
            this.nudMaxLength.Base = null;
            this.nudMaxLength.Color = System.Drawing.Color.White;
            this.nudMaxLength.DecimalPlaces = 0;
            this.nudMaxLength.Location = new System.Drawing.Point(49, 80);
            this.nudMaxLength.Margin = new System.Windows.Forms.Padding(49, 3, 15, 3);
            this.nudMaxLength.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.nudMaxLength.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudMaxLength.Name = "nudMaxLength";
            this.nudMaxLength.ReadOnly = false;
            this.nudMaxLength.Size = new System.Drawing.Size(182, 21);
            this.nudMaxLength.TabIndex = 3;
            this.nudMaxLength.Tag = "_TamanhoComponente";
            this.nudMaxLength.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudMaxLength.ValueInt = 0;
            this.nudMaxLength._ValueChanged += new System.EventHandler(this.Componentes__TextChanged);
            // 
            // chkEnabled
            // 
            this.chkEnabled._LabelGroup = null;
            this.chkEnabled._LabelText = "Habilitado";
            this.chkEnabled._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.SIM;
            this.chkEnabled._Regex = null;
            this.chkEnabled._TamanhoComponente = 43;
            this.chkEnabled._TamanhoMaiorLabel = 142;
            this.chkEnabled._Visible = true;
            this.chkEnabled.BackColor = System.Drawing.Color.Transparent;
            this.chkEnabled.Base = null;
            this.chkEnabled.Checked = false;
            this.chkEnabled.Location = new System.Drawing.Point(84, 107);
            this.chkEnabled.Margin = new System.Windows.Forms.Padding(84, 3, 15, 3);
            this.chkEnabled.Name = "chkEnabled";
            this.chkEnabled.Size = new System.Drawing.Size(104, 21);
            this.chkEnabled.TabIndex = 4;
            this.chkEnabled.Tag = "Enabled";
            this.chkEnabled.Value = false;
            this.chkEnabled._CheckedChanged += new System.EventHandler(this.Componentes__TextChanged);
            // 
            // chkVisible
            // 
            this.chkVisible._LabelGroup = null;
            this.chkVisible._LabelText = "Visível";
            this.chkVisible._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.SIM;
            this.chkVisible._Regex = null;
            this.chkVisible._TamanhoComponente = 42;
            this.chkVisible._TamanhoMaiorLabel = 142;
            this.chkVisible._Visible = true;
            this.chkVisible.BackColor = System.Drawing.Color.Transparent;
            this.chkVisible.Base = null;
            this.chkVisible.Checked = false;
            this.chkVisible.Location = new System.Drawing.Point(106, 134);
            this.chkVisible.Margin = new System.Windows.Forms.Padding(106, 3, 15, 3);
            this.chkVisible.Name = "chkVisible";
            this.chkVisible.Size = new System.Drawing.Size(81, 21);
            this.chkVisible.TabIndex = 5;
            this.chkVisible.Tag = "_Visible";
            this.chkVisible.Value = false;
            this.chkVisible._CheckedChanged += new System.EventHandler(this.Componentes__TextChanged);
            // 
            // nudComprimento
            // 
            this.nudComprimento._LabelGroup = null;
            this.nudComprimento._LabelText = "Comprimento";
            this.nudComprimento._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudComprimento._Regex = null;
            this.nudComprimento._TamanhoComponente = 86;
            this.nudComprimento._TamanhoMaiorLabel = 142;
            this.nudComprimento._Visible = true;
            this.nudComprimento.BackColor = System.Drawing.Color.Transparent;
            this.nudComprimento.Base = null;
            this.nudComprimento.Color = System.Drawing.Color.White;
            this.nudComprimento.DecimalPlaces = 0;
            this.nudComprimento.Location = new System.Drawing.Point(68, 161);
            this.nudComprimento.Margin = new System.Windows.Forms.Padding(68, 3, 15, 3);
            this.nudComprimento.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.nudComprimento.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudComprimento.Name = "nudComprimento";
            this.nudComprimento.ReadOnly = false;
            this.nudComprimento.Size = new System.Drawing.Size(163, 21);
            this.nudComprimento.TabIndex = 6;
            this.nudComprimento.Tag = "MaxLength";
            this.nudComprimento.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudComprimento.ValueInt = 0;
            this.nudComprimento._ValueChanged += new System.EventHandler(this.Componentes__TextChanged);
            // 
            // btnValorPadrao
            // 
            this.btnValorPadrao._LabelGroup = null;
            this.btnValorPadrao._LabelText = "Valor padrão";
            this.btnValorPadrao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.btnValorPadrao._Regex = null;
            this.btnValorPadrao._TamanhoComponente = 86;
            this.btnValorPadrao._TamanhoMaiorLabel = 142;
            this.btnValorPadrao._Visible = true;
            this.btnValorPadrao.Base = null;
            this.btnValorPadrao.Location = new System.Drawing.Point(145, 188);
            this.btnValorPadrao.Margin = new System.Windows.Forms.Padding(145, 3, 15, 3);
            this.btnValorPadrao.Name = "btnValorPadrao";
            this.btnValorPadrao.Size = new System.Drawing.Size(86, 24);
            this.btnValorPadrao.TabIndex = 7;
            this.btnValorPadrao._btnHlpClick += new System.EventHandler(this.btnValorPadrao__btnHlpClick);
            // 
            // btnCor
            // 
            this.btnCor._LabelGroup = null;
            this.btnCor._LabelText = "Cor";
            this.btnCor._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.btnCor._Regex = null;
            this.btnCor._TamanhoComponente = 86;
            this.btnCor._TamanhoMaiorLabel = 142;
            this.btnCor._Visible = true;
            this.btnCor.Base = null;
            this.btnCor.Location = new System.Drawing.Point(145, 218);
            this.btnCor.Margin = new System.Windows.Forms.Padding(145, 3, 15, 3);
            this.btnCor.Name = "btnCor";
            this.btnCor.Size = new System.Drawing.Size(86, 24);
            this.btnCor.TabIndex = 8;
            this.btnCor._btnHlpClick += new System.EventHandler(this.btnCor__btnHlpClick);
            // 
            // listDisplay
            // 
            this.listDisplay._LabelGroup = null;
            this.listDisplay._LabelText = "Display";
            this.listDisplay._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.listDisplay._Regex = null;
            this.listDisplay._TamanhoComponente = 307;
            this.listDisplay._TamanhoMaiorLabel = 142;
            this.listDisplay._Visible = true;
            this.listDisplay.Base = null;
            this.listDisplay.HeaderGroup1 = "Possibilidades";
            this.listDisplay.HeaderGroup2 = "Itens selecionados";
            this.listDisplay.Location = new System.Drawing.Point(861, 3);
            this.listDisplay.Margin = new System.Windows.Forms.Padding(101, 3, 15, 3);
            this.listDisplay.Name = "listDisplay";
            this.listDisplay.Size = new System.Drawing.Size(351, 108);
            this.listDisplay.TabIndex = 9;
            // 
            // FormConfigFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 509);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormConfigFormulario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2.Panel1)).EndInit();
            this.kryptonSplitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2.Panel2)).EndInit();
            this.kryptonSplitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2)).EndInit();
            this.kryptonSplitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer3.Panel1)).EndInit();
            this.kryptonSplitContainer3.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer3.Panel2)).EndInit();
            this.kryptonSplitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer3)).EndInit();
            this.kryptonSplitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).EndInit();
            this.kryptonSplitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).EndInit();
            this.kryptonSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).EndInit();
            this.kryptonSplitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.FlowConfig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoFieldBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource infoFieldBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader headerConfig;
        private ComponentFactory.Krypton.Toolkit.KryptonTreeView TreeFormulario;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader3;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader2;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer2;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer3;
        private System.Windows.Forms.Panel panelDesign;
        private System.Windows.Forms.ImageList imageList1;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox lstDados;
        private System.Windows.Forms.FlowLayoutPanel FlowConfig;
        private Components.HLP_TextBox txtHelp;
        private Components.HLP_TextBox txtLabelText;
        private Components.HLP_NumericUpDown nudMaxLength;
        private Components.HLP_NumericUpDown nudDecimalPlaces;
        private Components.HLP_NumericUpDown nudComprimento;
        private Components.HLP_CheckBox chkEnabled;
        private Components.HLP_CheckBox chkVisible;
        private Components.HLP_Button btnValorPadrao;
        private Components.HLP_ListBox2 listDisplay;
        private Components.HLP_Button btnCor;

    }
}