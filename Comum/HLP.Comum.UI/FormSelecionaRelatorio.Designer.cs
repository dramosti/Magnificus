namespace HLP.Comum.UI
{
    partial class FormSelecionaRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSelecionaRelatorio));
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.treeTelas = new ComponentFactory.Krypton.Toolkit.KryptonTreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtPesquisaForm = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnLimpaPesquisa = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonSplitContainer2 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNome = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblAtivo = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblNomeFisico = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblFuncionalidade = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.crViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPesquisaPadrao = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnVisualizarRelatorio = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.treePesquisa = new ComponentFactory.Krypton.Toolkit.KryptonTreeView();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).BeginInit();
            this.kryptonSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).BeginInit();
            this.kryptonSplitContainer1.Panel2.SuspendLayout();
            this.kryptonSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2.Panel1)).BeginInit();
            this.kryptonSplitContainer2.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2.Panel2)).BeginInit();
            this.kryptonSplitContainer2.Panel2.SuspendLayout();
            this.kryptonSplitContainer2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.kryptonSplitContainer1);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(818, 440);
            this.kryptonPanel.TabIndex = 0;
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
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.treePesquisa);
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.treeTelas);
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.txtPesquisaForm);
            // 
            // kryptonSplitContainer1.Panel2
            // 
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.kryptonSplitContainer2);
            this.kryptonSplitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile;
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(818, 440);
            this.kryptonSplitContainer1.SplitterDistance = 226;
            this.kryptonSplitContainer1.TabIndex = 0;
            // 
            // treeTelas
            // 
            this.treeTelas.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient;
            this.treeTelas.BorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ButtonCluster;
            this.treeTelas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeTelas.FullRowSelect = true;
            this.treeTelas.ImageIndex = 0;
            this.treeTelas.ImageList = this.imageList1;
            this.treeTelas.ItemHeight = 21;
            this.treeTelas.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.treeTelas.Location = new System.Drawing.Point(0, 19);
            this.treeTelas.Name = "treeTelas";
            this.treeTelas.OverrideFocus.Node.Content.DrawFocus = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.treeTelas.SelectedImageIndex = 0;
            this.treeTelas.Size = new System.Drawing.Size(226, 421);
            this.treeTelas.StateCommon.Node.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeTelas.StateCommon.Node.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.treeTelas.TabIndex = 11;
            this.treeTelas.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeTelas_BeforeSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Folder.ico");
            this.imageList1.Images.SetKeyName(1, "1349871595_application_form.ico");
            this.imageList1.Images.SetKeyName(2, "report.ico");
            // 
            // txtPesquisaForm
            // 
            this.txtPesquisaForm.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btnLimpaPesquisa});
            this.txtPesquisaForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPesquisaForm.Location = new System.Drawing.Point(0, 0);
            this.txtPesquisaForm.Name = "txtPesquisaForm";
            this.txtPesquisaForm.Size = new System.Drawing.Size(226, 19);
            this.txtPesquisaForm.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtPesquisaForm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPesquisaForm.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaForm.StateNormal.Border.Color1 = System.Drawing.Color.Black;
            this.txtPesquisaForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPesquisaForm.StateNormal.Border.Width = 1;
            this.txtPesquisaForm.StateNormal.Content.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaForm.TabIndex = 12;
            this.txtPesquisaForm.TextChanged += new System.EventHandler(this.txtPesquisaForm_TextChanged);
            // 
            // btnLimpaPesquisa
            // 
            this.btnLimpaPesquisa.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.btnLimpaPesquisa.UniqueName = "45E1D0505ECF49F843A9007491BEC9EB";
            // 
            // kryptonSplitContainer2
            // 
            this.kryptonSplitContainer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.kryptonSplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonSplitContainer2.Location = new System.Drawing.Point(0, 0);
            this.kryptonSplitContainer2.Name = "kryptonSplitContainer2";
            this.kryptonSplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // kryptonSplitContainer2.Panel1
            // 
            this.kryptonSplitContainer2.Panel1.AutoScroll = true;
            this.kryptonSplitContainer2.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // kryptonSplitContainer2.Panel2
            // 
            this.kryptonSplitContainer2.Panel2.AutoScroll = true;
            this.kryptonSplitContainer2.Panel2.Controls.Add(this.crViewer);
            this.kryptonSplitContainer2.Panel2.Controls.Add(this.panel1);
            this.kryptonSplitContainer2.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile;
            this.kryptonSplitContainer2.Size = new System.Drawing.Size(587, 440);
            this.kryptonSplitContainer2.SplitterDistance = 130;
            this.kryptonSplitContainer2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.lblNome);
            this.flowLayoutPanel1.Controls.Add(this.lblAtivo);
            this.flowLayoutPanel1.Controls.Add(this.lblNomeFisico);
            this.flowLayoutPanel1.Controls.Add(this.lblFuncionalidade);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(587, 130);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel;
            this.lblNome.Location = new System.Drawing.Point(3, 3);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(74, 30);
            this.lblNome.StateNormal.ShortText.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.TabIndex = 10;
            this.lblNome.Values.Text = "lblNome";
            this.lblNome.Visible = false;
            // 
            // lblAtivo
            // 
            this.lblAtivo.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel;
            this.lblAtivo.Location = new System.Drawing.Point(3, 39);
            this.lblAtivo.Name = "lblAtivo";
            this.lblAtivo.Size = new System.Drawing.Size(52, 20);
            this.lblAtivo.TabIndex = 7;
            this.lblAtivo.Values.Text = "lblAtivo";
            this.lblAtivo.Visible = false;
            // 
            // lblNomeFisico
            // 
            this.lblNomeFisico.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel;
            this.lblNomeFisico.Location = new System.Drawing.Point(3, 65);
            this.lblNomeFisico.Name = "lblNomeFisico";
            this.lblNomeFisico.Size = new System.Drawing.Size(88, 20);
            this.lblNomeFisico.TabIndex = 8;
            this.lblNomeFisico.Values.Text = "lblNomeFisico";
            this.lblNomeFisico.Visible = false;
            // 
            // lblFuncionalidade
            // 
            this.lblFuncionalidade.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel;
            this.lblFuncionalidade.Location = new System.Drawing.Point(3, 91);
            this.lblFuncionalidade.Name = "lblFuncionalidade";
            this.lblFuncionalidade.Size = new System.Drawing.Size(96, 20);
            this.lblFuncionalidade.TabIndex = 9;
            this.lblFuncionalidade.Values.Text = "Funcionalidade:";
            this.lblFuncionalidade.Visible = false;
            // 
            // crViewer
            // 
            this.crViewer.ActiveViewIndex = -1;
            this.crViewer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.crViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crViewer.DisplayStatusBar = false;
            this.crViewer.DisplayToolbar = false;
            this.crViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crViewer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crViewer.Location = new System.Drawing.Point(0, 33);
            this.crViewer.Name = "crViewer";
            this.crViewer.SelectionFormula = "";
            this.crViewer.ShowCloseButton = false;
            this.crViewer.ShowCopyButton = false;
            this.crViewer.ShowExportButton = false;
            this.crViewer.ShowGotoPageButton = false;
            this.crViewer.ShowGroupTreeButton = false;
            this.crViewer.ShowPageNavigateButtons = false;
            this.crViewer.ShowParameterPanelButton = false;
            this.crViewer.ShowPrintButton = false;
            this.crViewer.ShowTextSearchButton = false;
            this.crViewer.ShowZoomButton = false;
            this.crViewer.Size = new System.Drawing.Size(587, 272);
            this.crViewer.TabIndex = 10;
            this.crViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crViewer.ViewTimeSelectionFormula = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnPesquisaPadrao);
            this.panel1.Controls.Add(this.btnVisualizarRelatorio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 33);
            this.panel1.TabIndex = 9;
            // 
            // btnPesquisaPadrao
            // 
            this.btnPesquisaPadrao.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPesquisaPadrao.Enabled = false;
            this.btnPesquisaPadrao.Location = new System.Drawing.Point(384, 0);
            this.btnPesquisaPadrao.Name = "btnPesquisaPadrao";
            this.btnPesquisaPadrao.Size = new System.Drawing.Size(201, 31);
            this.btnPesquisaPadrao.TabIndex = 8;
            this.btnPesquisaPadrao.Values.Image = global::HLP.Comum.UI.Properties.Resources.print;
            this.btnPesquisaPadrao.Values.Text = "Filtrar e Visualizar";
            this.btnPesquisaPadrao.Click += new System.EventHandler(this.btnPesquisaPadrao_Click);
            // 
            // btnVisualizarRelatorio
            // 
            this.btnVisualizarRelatorio.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnVisualizarRelatorio.Enabled = false;
            this.btnVisualizarRelatorio.Location = new System.Drawing.Point(0, 0);
            this.btnVisualizarRelatorio.Name = "btnVisualizarRelatorio";
            this.btnVisualizarRelatorio.Size = new System.Drawing.Size(201, 31);
            this.btnVisualizarRelatorio.TabIndex = 7;
            this.btnVisualizarRelatorio.Values.Image = global::HLP.Comum.UI.Properties.Resources.down;
            this.btnVisualizarRelatorio.Values.Text = "Pré Visualizar Relatório";
            this.btnVisualizarRelatorio.Click += new System.EventHandler(this.btnVisualizarRelatorio_Click);
            // 
            // treePesquisa
            // 
            this.treePesquisa.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient;
            this.treePesquisa.BorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ButtonCluster;
            this.treePesquisa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treePesquisa.FullRowSelect = true;
            this.treePesquisa.ImageIndex = 0;
            this.treePesquisa.ImageList = this.imageList1;
            this.treePesquisa.ItemHeight = 21;
            this.treePesquisa.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.treePesquisa.Location = new System.Drawing.Point(0, 19);
            this.treePesquisa.Name = "treePesquisa";
            this.treePesquisa.OverrideFocus.Node.Content.DrawFocus = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.treePesquisa.SelectedImageIndex = 0;
            this.treePesquisa.Size = new System.Drawing.Size(226, 421);
            this.treePesquisa.StateCommon.Node.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treePesquisa.StateCommon.Node.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.treePesquisa.TabIndex = 13;
            this.treePesquisa.Visible = false;
            this.treePesquisa.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeTelas_BeforeSelect);
            // 
            // FormSelecionaRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 440);
            this.Controls.Add(this.kryptonPanel);
            this.Name = "FormSelecionaRelatorio";
            this.ShowIcon = false;
            this.Text = "Seleção de Relatório";
            this.Load += new System.EventHandler(this.FormSelecionaRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).EndInit();
            this.kryptonSplitContainer1.Panel1.ResumeLayout(false);
            this.kryptonSplitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).EndInit();
            this.kryptonSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).EndInit();
            this.kryptonSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2.Panel1)).EndInit();
            this.kryptonSplitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2.Panel2)).EndInit();
            this.kryptonSplitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer2)).EndInit();
            this.kryptonSplitContainer2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        private ComponentFactory.Krypton.Toolkit.KryptonTreeView treeTelas;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPesquisaForm;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnLimpaPesquisa;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblNome;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblFuncionalidade;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblAtivo;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblNomeFisico;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnVisualizarRelatorio;
        private System.Windows.Forms.ImageList imageList1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crViewer;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPesquisaPadrao;
        private ComponentFactory.Krypton.Toolkit.KryptonTreeView treePesquisa;
    }
}

