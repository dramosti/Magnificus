namespace HLP.Comum.UI
{
    partial class FormConfigComp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfigComp));
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeCampos = new ComponentFactory.Krypton.Toolkit.KryptonTreeView();
            this.flpComponentes = new System.Windows.Forms.FlowLayoutPanel();
            this.txtTable = new HLP.Comum.Components.HLP_TextBox();
            this.txtField = new HLP.Comum.Components.HLP_TextBox();
            this.chkRequired = new HLP.Comum.Components.HLP_CheckBox();
            this.txtType = new HLP.Comum.Components.HLP_TextBox();
            this.nudMaxLengthBase = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudDecimalPlacesBase = new HLP.Comum.Components.HLP_NumericUpDown();
            this.txtHelp = new HLP.Comum.Components.HLP_TextBox();
            this.txtLabelText = new HLP.Comum.Components.HLP_TextBox();
            this.txtText = new HLP.Comum.Components.HLP_TextBox();
            this.nudText = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudMaxLength = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudDecimalPlaces = new HLP.Comum.Components.HLP_NumericUpDown();
            this.chkEnabled = new HLP.Comum.Components.HLP_CheckBox();
            this.chkVisible = new HLP.Comum.Components.HLP_CheckBox();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lstOrdem = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.chkDisplayMember = new HLP.Comum.Components.HLP_CheckListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnAlterar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flpComponentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.panel1);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(1000, 594);
            this.kryptonPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.kryptonPanel1);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 594);
            this.panel1.TabIndex = 2;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.splitContainer1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 27);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.kryptonPanel1.Size = new System.Drawing.Size(998, 543);
            this.kryptonPanel1.TabIndex = 110;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeCampos);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flpComponentes);
            this.splitContainer1.Size = new System.Drawing.Size(992, 537);
            this.splitContainer1.SplitterDistance = 267;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 107;
            // 
            // treeCampos
            // 
            this.treeCampos.AllowDrop = true;
            this.treeCampos.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient;
            this.treeCampos.BorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ContextMenuInner;
            this.treeCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeCampos.FullRowSelect = true;
            this.treeCampos.ItemHeight = 21;
            this.treeCampos.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.treeCampos.Location = new System.Drawing.Point(0, 0);
            this.treeCampos.Name = "treeCampos";
            this.treeCampos.OverrideFocus.Node.Content.DrawFocus = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.treeCampos.Size = new System.Drawing.Size(265, 535);
            this.treeCampos.StateCommon.Node.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeCampos.StateCommon.Node.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.treeCampos.TabIndex = 1;
            //this.treeCampos.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeCampos_AfterSelect);
            //this.treeCampos.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeCampos_NodeMouseDoubleClick);
            //this.treeCampos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeCampos_KeyDown);
            // 
            // flpComponentes
            // 
            this.flpComponentes.Controls.Add(this.txtTable);
            this.flpComponentes.Controls.Add(this.txtField);
            this.flpComponentes.Controls.Add(this.chkRequired);
            this.flpComponentes.Controls.Add(this.txtType);
            this.flpComponentes.Controls.Add(this.nudMaxLengthBase);
            this.flpComponentes.Controls.Add(this.nudDecimalPlacesBase);
            this.flpComponentes.Controls.Add(this.txtHelp);
            this.flpComponentes.Controls.Add(this.txtLabelText);
            this.flpComponentes.Controls.Add(this.txtText);
            this.flpComponentes.Controls.Add(this.nudText);
            this.flpComponentes.Controls.Add(this.nudMaxLength);
            this.flpComponentes.Controls.Add(this.nudDecimalPlaces);
            this.flpComponentes.Controls.Add(this.chkEnabled);
            this.flpComponentes.Controls.Add(this.chkVisible);
            this.flpComponentes.Controls.Add(this.kryptonPanel2);
            this.flpComponentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpComponentes.Enabled = false;
            this.flpComponentes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpComponentes.Location = new System.Drawing.Point(0, 0);
            this.flpComponentes.Name = "flpComponentes";
            this.flpComponentes.Size = new System.Drawing.Size(721, 535);
            this.flpComponentes.TabIndex = 0;
            // 
            // txtTable
            // 
            this.txtTable._Field = null;
            this.txtTable._Help = "";
            this.txtTable._LabelGroup = null;
            this.txtTable._LabelText = "Tabela - (base)";
            this.txtTable._Multiline = false;
            this.txtTable._Obrigatorio = HLP.Comum.Components.HLP_TextBox.CampoObrigatorio.NÃO;
            this.txtTable._Password = false;
            this.txtTable._Regex = null;
            this.txtTable._Table = null;
            this.txtTable._TamanhoMaiorLabel = 142;
            this.txtTable._TamanhoComponente = 199;
            this.txtTable._Visible = true;
            this.txtTable.BackColor = System.Drawing.Color.Transparent;
            this.txtTable.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTable.Color = System.Drawing.Color.White;
            this.txtTable.Location = new System.Drawing.Point(65, 3);
            this.txtTable.Margin = new System.Windows.Forms.Padding(65, 3, 15, 3);
            this.txtTable.MaxLength = 32767;
            this.txtTable.Name = "txtTable";
            this.txtTable.ReadOnly = true;
            this.txtTable.Size = new System.Drawing.Size(279, 21);
            this.txtTable.TabIndex = 1;
            // 
            // txtField
            // 
            this.txtField._Field = null;
            this.txtField._Help = "";
            this.txtField._LabelGroup = null;
            this.txtField._LabelText = "Campo - (base)";
            this.txtField._Multiline = false;
            this.txtField._Obrigatorio = HLP.Comum.Components.HLP_TextBox.CampoObrigatorio.NÃO;
            this.txtField._Password = false;
            this.txtField._Regex = null;
            this.txtField._Table = null;
            this.txtField._TamanhoMaiorLabel = 142;
            this.txtField._TamanhoComponente = 198;
            this.txtField._Visible = true;
            this.txtField.BackColor = System.Drawing.Color.Transparent;
            this.txtField.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtField.Color = System.Drawing.Color.White;
            this.txtField.Location = new System.Drawing.Point(62, 30);
            this.txtField.Margin = new System.Windows.Forms.Padding(62, 3, 15, 3);
            this.txtField.MaxLength = 32767;
            this.txtField.Name = "txtField";
            this.txtField.ReadOnly = true;
            this.txtField.Size = new System.Drawing.Size(281, 21);
            this.txtField.TabIndex = 2;
            // 
            // chkRequired
            // 
            this.chkRequired._Field = null;
            this.chkRequired._Help = "";
            this.chkRequired._LabelGroup = null;
            this.chkRequired._LabelText = "Requerido - (base)";
            this.chkRequired._Obrigatorio = Components.UserControlBase.CampoObrigatorio.SIM;
            this.chkRequired._Table = null;
            this.chkRequired._TamanhoMaiorLabel = 142;
            this.chkRequired._Visible = true;
            this.chkRequired.BackColor = System.Drawing.Color.Transparent;
            this.chkRequired.Checked = false;
            this.chkRequired.Enabled = false;
            this.chkRequired.Location = new System.Drawing.Point(44, 57);
            this.chkRequired.Margin = new System.Windows.Forms.Padding(44, 3, 15, 3);
            this.chkRequired.Name = "chkRequired";
            this.chkRequired.Size = new System.Drawing.Size(151, 21);
            this.chkRequired.TabIndex = 3;
            this.chkRequired.Value = false;
            // 
            // txtType
            // 
            this.txtType._Field = null;
            this.txtType._Help = "";
            this.txtType._LabelGroup = null;
            this.txtType._LabelText = "Tipo - (base)";
            this.txtType._Multiline = false;
            this.txtType._Obrigatorio = HLP.Comum.Components.HLP_TextBox.CampoObrigatorio.NÃO;
            this.txtType._Password = false;
            this.txtType._Regex = null;
            this.txtType._Table = null;
            this.txtType._TamanhoMaiorLabel = 142;
            this.txtType._TamanhoComponente = 197;
            this.txtType._Visible = true;
            this.txtType.BackColor = System.Drawing.Color.Transparent;
            this.txtType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtType.Color = System.Drawing.Color.White;
            this.txtType.Location = new System.Drawing.Point(76, 84);
            this.txtType.Margin = new System.Windows.Forms.Padding(76, 3, 15, 3);
            this.txtType.MaxLength = 32767;
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(266, 21);
            this.txtType.TabIndex = 4;
            // 
            // nudMaxLengthBase
            // 
            this.nudMaxLengthBase._Field = null;
            this.nudMaxLengthBase._Help = "";
            this.nudMaxLengthBase._LabelGroup = null;
            this.nudMaxLengthBase._LabelText = "Tamanho máximo - (base)";
            this.nudMaxLengthBase._Obrigatorio = HLP.Comum.Components.HLP_NumericUpDown.CampoObrigatorio.NÃO;
            this.nudMaxLengthBase._Table = null;
            this.nudMaxLengthBase._TamanhoMaiorLabel = 142;
            this.nudMaxLengthBase._TamanhoComponente = 94;
            this.nudMaxLengthBase._Visible = true;
            this.nudMaxLengthBase.BackColor = System.Drawing.Color.Transparent;
            this.nudMaxLengthBase.Color = System.Drawing.Color.White;
            this.nudMaxLengthBase.DecimalPlaces = 0;
            this.nudMaxLengthBase.Location = new System.Drawing.Point(9, 111);
            this.nudMaxLengthBase.Margin = new System.Windows.Forms.Padding(9, 3, 15, 3);
            this.nudMaxLengthBase.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.nudMaxLengthBase.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudMaxLengthBase.Name = "nudMaxLengthBase";
            this.nudMaxLengthBase.ReadOnly = true;
            this.nudMaxLengthBase.Size = new System.Drawing.Size(230, 22);
            this.nudMaxLengthBase.TabIndex = 5;
            this.nudMaxLengthBase.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudMaxLengthBase.ValueInt = 0;
            // 
            // nudDecimalPlacesBase
            // 
            this.nudDecimalPlacesBase._Field = null;
            this.nudDecimalPlacesBase._Help = "";
            this.nudDecimalPlacesBase._LabelGroup = null;
            this.nudDecimalPlacesBase._LabelText = "Casas decimais - (base)";
            this.nudDecimalPlacesBase._Obrigatorio = HLP.Comum.Components.HLP_NumericUpDown.CampoObrigatorio.NÃO;
            this.nudDecimalPlacesBase._Table = null;
            this.nudDecimalPlacesBase._TamanhoMaiorLabel = 142;
            this.nudDecimalPlacesBase._TamanhoComponente = 160;
            this.nudDecimalPlacesBase._Visible = true;
            this.nudDecimalPlacesBase.BackColor = System.Drawing.Color.Transparent;
            this.nudDecimalPlacesBase.Color = System.Drawing.Color.White;
            this.nudDecimalPlacesBase.DecimalPlaces = 0;
            this.nudDecimalPlacesBase.Location = new System.Drawing.Point(22, 139);
            this.nudDecimalPlacesBase.Margin = new System.Windows.Forms.Padding(22, 3, 15, 3);
            this.nudDecimalPlacesBase.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.nudDecimalPlacesBase.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudDecimalPlacesBase.Name = "nudDecimalPlacesBase";
            this.nudDecimalPlacesBase.ReadOnly = true;
            this.nudDecimalPlacesBase.Size = new System.Drawing.Size(283, 22);
            this.nudDecimalPlacesBase.TabIndex = 6;
            this.nudDecimalPlacesBase.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudDecimalPlacesBase.ValueInt = 0;
            this.nudDecimalPlacesBase.Visible = false;
            // 
            // txtHelp
            // 
            this.txtHelp._Field = null;
            this.txtHelp._Help = "";
            this.txtHelp._LabelGroup = null;
            this.txtHelp._LabelText = "Help";
            this.txtHelp._Multiline = false;
            this.txtHelp._Obrigatorio = HLP.Comum.Components.HLP_TextBox.CampoObrigatorio.NÃO;
            this.txtHelp._Password = false;
            this.txtHelp._Regex = null;
            this.txtHelp._Table = null;
            this.txtHelp._TamanhoMaiorLabel = 142;
            this.txtHelp._TamanhoComponente = 464;
            this.txtHelp._Visible = true;
            this.txtHelp.BackColor = System.Drawing.Color.Transparent;
            this.txtHelp.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtHelp.Color = System.Drawing.Color.White;
            this.txtHelp.Location = new System.Drawing.Point(114, 167);
            this.txtHelp.Margin = new System.Windows.Forms.Padding(114, 3, 15, 3);
            this.txtHelp.MaxLength = 32767;
            this.txtHelp.Name = "txtHelp";
            this.txtHelp.ReadOnly = false;
            this.txtHelp.Size = new System.Drawing.Size(495, 21);
            this.txtHelp.TabIndex = 7;
            // 
            // txtLabelText
            // 
            this.txtLabelText._Field = null;
            this.txtLabelText._Help = "";
            this.txtLabelText._LabelGroup = null;
            this.txtLabelText._LabelText = "Texto do label";
            this.txtLabelText._Multiline = false;
            this.txtLabelText._Obrigatorio = HLP.Comum.Components.HLP_TextBox.CampoObrigatorio.NÃO;
            this.txtLabelText._Password = false;
            this.txtLabelText._Regex = null;
            this.txtLabelText._Table = null;
            this.txtLabelText._TamanhoMaiorLabel = 142;
            this.txtLabelText._TamanhoComponente = 464;
            this.txtLabelText._Visible = true;
            this.txtLabelText.BackColor = System.Drawing.Color.Transparent;
            this.txtLabelText.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtLabelText.Color = System.Drawing.Color.White;
            this.txtLabelText.Location = new System.Drawing.Point(66, 194);
            this.txtLabelText.Margin = new System.Windows.Forms.Padding(66, 3, 15, 3);
            this.txtLabelText.MaxLength = 32767;
            this.txtLabelText.Name = "txtLabelText";
            this.txtLabelText.ReadOnly = false;
            this.txtLabelText.Size = new System.Drawing.Size(543, 21);
            this.txtLabelText.TabIndex = 7;
            // 
            // txtText
            // 
            this.txtText._Field = null;
            this.txtText._Help = "";
            this.txtText._LabelGroup = null;
            this.txtText._LabelText = "Valor padrão";
            this.txtText._Multiline = false;
            this.txtText._Obrigatorio = HLP.Comum.Components.HLP_TextBox.CampoObrigatorio.NÃO;
            this.txtText._Password = false;
            this.txtText._Regex = null;
            this.txtText._Table = null;
            this.txtText._TamanhoMaiorLabel = 142;
            this.txtText._TamanhoComponente = 149;
            this.txtText._Visible = true;
            this.txtText.BackColor = System.Drawing.Color.Transparent;
            this.txtText.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtText.Color = System.Drawing.Color.White;
            this.txtText.Location = new System.Drawing.Point(71, 221);
            this.txtText.Margin = new System.Windows.Forms.Padding(71, 3, 15, 3);
            this.txtText.MaxLength = 32767;
            this.txtText.Name = "txtText";
            this.txtText.ReadOnly = false;
            this.txtText.Size = new System.Drawing.Size(223, 21);
            this.txtText.TabIndex = 8;
            this.txtText.Visible = false;
            // 
            // nudText
            // 
            this.nudText._Field = null;
            this.nudText._Help = "";
            this.nudText._LabelGroup = null;
            this.nudText._LabelText = "Valor padrão";
            this.nudText._Obrigatorio = HLP.Comum.Components.HLP_NumericUpDown.CampoObrigatorio.NÃO;
            this.nudText._Table = null;
            this.nudText._TamanhoMaiorLabel = 142;
            this.nudText._TamanhoComponente = 149;
            this.nudText._Visible = true;
            this.nudText.BackColor = System.Drawing.Color.Transparent;
            this.nudText.Color = System.Drawing.Color.White;
            this.nudText.DecimalPlaces = 0;
            this.nudText.Location = new System.Drawing.Point(71, 248);
            this.nudText.Margin = new System.Windows.Forms.Padding(71, 3, 15, 3);
            this.nudText.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.nudText.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudText.Name = "nudText";
            this.nudText.ReadOnly = false;
            this.nudText.Size = new System.Drawing.Size(223, 22);
            this.nudText.TabIndex = 9;
            this.nudText.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudText.ValueInt = 0;
            // 
            // nudMaxLength
            // 
            this.nudMaxLength._Field = null;
            this.nudMaxLength._Help = "";
            this.nudMaxLength._LabelGroup = null;
            this.nudMaxLength._LabelText = "Tamanho máximo";
            this.nudMaxLength._Obrigatorio = HLP.Comum.Components.HLP_NumericUpDown.CampoObrigatorio.NÃO;
            this.nudMaxLength._Table = null;
            this.nudMaxLength._TamanhoMaiorLabel = 142;
            this.nudMaxLength._TamanhoComponente = 86;
            this.nudMaxLength._Visible = true;
            this.nudMaxLength.BackColor = System.Drawing.Color.Transparent;
            this.nudMaxLength.Color = System.Drawing.Color.White;
            this.nudMaxLength.DecimalPlaces = 0;
            this.nudMaxLength.Location = new System.Drawing.Point(49, 276);
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
            this.nudMaxLength.Size = new System.Drawing.Size(182, 22);
            this.nudMaxLength.TabIndex = 10;
            this.nudMaxLength.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudMaxLength.ValueInt = 0;
            // 
            // nudDecimalPlaces
            // 
            this.nudDecimalPlaces._Field = null;
            this.nudDecimalPlaces._Help = "";
            this.nudDecimalPlaces._LabelGroup = null;
            this.nudDecimalPlaces._LabelText = "Casas decimais";
            this.nudDecimalPlaces._Obrigatorio = HLP.Comum.Components.HLP_NumericUpDown.CampoObrigatorio.NÃO;
            this.nudDecimalPlaces._Table = null;
            this.nudDecimalPlaces._TamanhoMaiorLabel = 142;
            this.nudDecimalPlaces._TamanhoComponente = 152;
            this.nudDecimalPlaces._Visible = true;
            this.nudDecimalPlaces.BackColor = System.Drawing.Color.Transparent;
            this.nudDecimalPlaces.Color = System.Drawing.Color.White;
            this.nudDecimalPlaces.DecimalPlaces = 0;
            this.nudDecimalPlaces.Location = new System.Drawing.Point(62, 304);
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
            this.nudDecimalPlaces.Size = new System.Drawing.Size(235, 22);
            this.nudDecimalPlaces.TabIndex = 11;
            this.nudDecimalPlaces.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudDecimalPlaces.ValueInt = 0;
            this.nudDecimalPlaces.Visible = false;
            // 
            // chkEnabled
            // 
            this.chkEnabled._Field = null;
            this.chkEnabled._Help = "";
            this.chkEnabled._LabelGroup = null;
            this.chkEnabled._LabelText = "Habilitado";
            this.chkEnabled._Obrigatorio = Components.UserControlBase.CampoObrigatorio.SIM;
            this.chkEnabled._Table = null;
            this.chkEnabled._TamanhoMaiorLabel = 142;
            this.chkEnabled._Visible = true;
            this.chkEnabled.BackColor = System.Drawing.Color.Transparent;
            this.chkEnabled.Checked = false;
            this.chkEnabled.Location = new System.Drawing.Point(84, 332);
            this.chkEnabled.Margin = new System.Windows.Forms.Padding(84, 3, 15, 3);
            this.chkEnabled.Name = "chkEnabled";
            this.chkEnabled.Size = new System.Drawing.Size(104, 21);
            this.chkEnabled.TabIndex = 12;
            this.chkEnabled.Value = false;
            // 
            // chkVisible
            // 
            this.chkVisible._Field = null;
            this.chkVisible._Help = "";
            this.chkVisible._LabelGroup = null;
            this.chkVisible._LabelText = "Visível";
            this.chkVisible._Obrigatorio = Components.UserControlBase.CampoObrigatorio.SIM;
            this.chkVisible._Table = null;
            this.chkVisible._TamanhoMaiorLabel = 142;
            this.chkVisible._Visible = true;
            this.chkVisible.BackColor = System.Drawing.Color.Transparent;
            this.chkVisible.Checked = false;
            this.chkVisible.Location = new System.Drawing.Point(106, 359);
            this.chkVisible.Margin = new System.Windows.Forms.Padding(106, 3, 15, 3);
            this.chkVisible.Name = "chkVisible";
            this.chkVisible.Size = new System.Drawing.Size(81, 21);
            this.chkVisible.TabIndex = 13;
            this.chkVisible.Value = false;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.lstOrdem);
            this.kryptonPanel2.Controls.Add(this.chkDisplayMember);
            this.kryptonPanel2.Location = new System.Drawing.Point(30, 386);
            this.kryptonPanel2.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(552, 139);
            this.kryptonPanel2.TabIndex = 16;
            // 
            // lstOrdem
            // 
            this.lstOrdem.AllowDrop = true;
            this.lstOrdem.Location = new System.Drawing.Point(313, 0);
            this.lstOrdem.Name = "lstOrdem";
            this.lstOrdem.Size = new System.Drawing.Size(166, 130);
            this.lstOrdem.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOrdem.TabIndex = 16;
            // 
            // chkDisplayMember
            // 
            this.chkDisplayMember._LabelGroup = null;
            this.chkDisplayMember._LabelText = "Campos na descrição";
            this.chkDisplayMember._TamanhoMaiorLabel = 164;
            this.chkDisplayMember._TamanhoComponente = 191;
            this.chkDisplayMember._Visible = true;
            this.chkDisplayMember.AllowDrop = true;
            this.chkDisplayMember.BackColor = System.Drawing.Color.Transparent;
            this.chkDisplayMember.Color = System.Drawing.Color.White;
            this.chkDisplayMember.Location = new System.Drawing.Point(0, 0);
            this.chkDisplayMember.Margin = new System.Windows.Forms.Padding(33, 3, 15, 3);
            this.chkDisplayMember.Name = "chkDisplayMember";
            this.chkDisplayMember.Size = new System.Drawing.Size(306, 130);
            this.chkDisplayMember.TabIndex = 15;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 570);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(998, 22);
            this.statusStrip1.TabIndex = 109;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(217, 17);
            this.toolStripStatusLabel1.Text = "Selecione o componente para configurar";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAlterar,
            this.toolStripSeparator6,
            this.btnSalvar,
            this.toolStripSeparator7,
            this.btnCancelar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(998, 27);
            this.menuStrip1.TabIndex = 105;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(46, 20);
            this.btnAlterar.Text = "Alterar";
            //this.btnAlterar.Click += new System.EventHandler(this.btnControles_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 23);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalvar.ImageTransparentColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(42, 20);
            this.btnSalvar.Text = "Salvar";
            //this.btnSalvar.Click += new System.EventHandler(this.btnControles_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 23);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelar.ImageTransparentColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(55, 20);
            this.btnCancelar.Text = "Cancelar";
            //this.btnCancelar.Click += new System.EventHandler(this.btnControles_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Control_FlowLayoutPanel.bmp");
            this.imageList1.Images.SetKeyName(1, "Control.png");
            // 
            // FormConfigComp
            // 
            this.AllowFormChrome = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 594);
            this.Controls.Add(this.kryptonPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormConfigComp";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração de Componente - {0}";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            //this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConfigComp_FormClosing);
            //this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormConfigComp_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flpComponentes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripButton btnAlterar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ImageList imageList1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flpComponentes;
        private Components.HLP_TextBox txtTable;
        private Components.HLP_TextBox txtField;
        private Components.HLP_CheckBox chkRequired;
        private Components.HLP_TextBox txtType;
        private Components.HLP_NumericUpDown nudMaxLengthBase;
        private Components.HLP_NumericUpDown nudDecimalPlacesBase;
        private Components.HLP_TextBox txtLabelText;
        private Components.HLP_TextBox txtText;
        private Components.HLP_NumericUpDown nudText;
        private Components.HLP_NumericUpDown nudMaxLength;
        private Components.HLP_NumericUpDown nudDecimalPlaces;
        private Components.HLP_CheckBox chkEnabled;
        private Components.HLP_CheckBox chkVisible;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTreeView treeCampos;
        private Components.HLP_CheckListBox chkDisplayMember;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox lstOrdem;
        private Components.HLP_TextBox txtHelp;
    }
}

