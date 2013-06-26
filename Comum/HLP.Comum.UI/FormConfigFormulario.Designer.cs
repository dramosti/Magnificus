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
            this.lstProperty = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.kryptonHeader2 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.panelDesign = new System.Windows.Forms.Panel();
            this.infoFieldBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.infoFieldBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // headerConfig
            // 
            this.headerConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerConfig.Location = new System.Drawing.Point(0, 0);
            this.headerConfig.Name = "headerConfig";
            this.headerConfig.Size = new System.Drawing.Size(910, 31);
            this.headerConfig.TabIndex = 1;
            this.headerConfig.Values.Description = "";
            this.headerConfig.Values.Heading = "Configuração";
            // 
            // TreeFormulario
            // 
            this.TreeFormulario.AllowDrop = true;
            this.TreeFormulario.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridDataCellSheet;
            this.TreeFormulario.BorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.FormCustom1;
            this.TreeFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeFormulario.ImageIndex = 0;
            this.TreeFormulario.ImageList = this.imageList1;
            this.TreeFormulario.ItemHeight = 25;
            this.TreeFormulario.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.InputControl;
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
            this.TreeFormulario.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.TreeFormulario.SelectedImageIndex = 0;
            this.TreeFormulario.Size = new System.Drawing.Size(363, 371);
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
            this.kryptonPanel1.Size = new System.Drawing.Size(910, 402);
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
            this.kryptonSplitContainer2.Size = new System.Drawing.Size(910, 371);
            this.kryptonSplitContainer2.SplitterDistance = 363;
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
            this.kryptonSplitContainer3.Size = new System.Drawing.Size(542, 371);
            this.kryptonSplitContainer3.SplitterDistance = 213;
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
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(542, 213);
            this.kryptonSplitContainer1.SplitterDistance = 266;
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
            this.panel2.Size = new System.Drawing.Size(266, 213);
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
            this.lstDados.Size = new System.Drawing.Size(266, 182);
            this.lstDados.TabIndex = 3;
            // 
            // kryptonHeader3
            // 
            this.kryptonHeader3.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader3.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader3.Name = "kryptonHeader3";
            this.kryptonHeader3.Size = new System.Drawing.Size(266, 31);
            this.kryptonHeader3.TabIndex = 2;
            this.kryptonHeader3.Values.Description = "";
            this.kryptonHeader3.Values.Heading = "Base de Dados";
            this.kryptonHeader3.Values.Image = global::HLP.Comum.UI.Properties.Resources.Utilitarios;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lstProperty);
            this.panel1.Controls.Add(this.kryptonHeader2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 213);
            this.panel1.TabIndex = 6;
            // 
            // lstProperty
            // 
            this.lstProperty.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlToolTip;
            this.lstProperty.BorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ButtonNavigatorOverflow;
            this.lstProperty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstProperty.Items.AddRange(new object[] {
            "Cor",
            "Habilitado",
            "Help",
            "Tamanho",
            "Texto do label",
            "Valor Padrão",
            "Visível"});
            this.lstProperty.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.lstProperty.Location = new System.Drawing.Point(0, 31);
            this.lstProperty.Name = "lstProperty";
            this.lstProperty.Size = new System.Drawing.Size(271, 182);
            this.lstProperty.TabIndex = 3;
            // 
            // kryptonHeader2
            // 
            this.kryptonHeader2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader2.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader2.Name = "kryptonHeader2";
            this.kryptonHeader2.Size = new System.Drawing.Size(271, 31);
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
            this.panelDesign.Size = new System.Drawing.Size(542, 153);
            this.panelDesign.TabIndex = 12;
            // 
            // infoFieldBindingSource
            // 
            this.infoFieldBindingSource.DataSource = typeof(HLP.Comum.Models.InfoField);
            // 
            // FormConfigFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 402);
            this.Controls.Add(this.kryptonPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
        private ComponentFactory.Krypton.Toolkit.KryptonListBox lstProperty;
        private System.Windows.Forms.Panel panelDesign;
        private System.Windows.Forms.ImageList imageList1;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox lstDados;

    }
}