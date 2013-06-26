using HLP.Comum.Components;
namespace HLP.Comum.UI
{
    partial class FormConfigRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfigRelatorio));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonTabControl1 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.treePesquisa = new ComponentFactory.Krypton.Toolkit.KryptonTreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.treeTelas = new ComponentFactory.Krypton.Toolkit.KryptonTreeView();
            this.btnSincronizar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtPesquisaForm = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnLimpaPesquisa = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFormSelecionado = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmDuplicar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.editarRelatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tempo = new System.Windows.Forms.Timer(this.components);
            this.dgvReports = new HLP.Comum.Components.HLP_DataGridView();
            this.stAtivoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clxNomeRelatorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDestalhes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clxNomeFisico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsReports = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.kryptonTabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).BeginInit();
            this.kryptonSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).BeginInit();
            this.kryptonSplitContainer1.Panel2.SuspendLayout();
            this.kryptonSplitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsReports)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonTabControl1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(781, 369);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonTabControl1
            // 
            this.kryptonTabControl1.AllowCloseButton = false;
            this.kryptonTabControl1.AllowContextButton = false;
            this.kryptonTabControl1.AllowNavigatorButtons = false;
            this.kryptonTabControl1.AllowSelectedTabHigh = false;
            this.kryptonTabControl1.BorderWidth = 1;
            this.kryptonTabControl1.Controls.Add(this.tabPage2);
            this.kryptonTabControl1.CornerRoundRadiusWidth = 12;
            this.kryptonTabControl1.CornerSymmetry = AC.ExtendedRenderer.Navigator.KryptonTabControl.CornSymmetry.Both;
            this.kryptonTabControl1.CornerType = AC.ExtendedRenderer.Toolkit.Drawing.DrawingMethods.CornerType.Rounded;
            this.kryptonTabControl1.CornerWidth = AC.ExtendedRenderer.Navigator.KryptonTabControl.CornWidth.Thin;
            this.kryptonTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.kryptonTabControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.kryptonTabControl1.HotTrack = true;
            this.kryptonTabControl1.Location = new System.Drawing.Point(0, 0);
            this.kryptonTabControl1.Name = "kryptonTabControl1";
            this.kryptonTabControl1.PreserveTabColor = false;
            this.kryptonTabControl1.SelectedIndex = 0;
            this.kryptonTabControl1.Size = new System.Drawing.Size(781, 369);
            this.kryptonTabControl1.TabIndex = 6;
            this.kryptonTabControl1.UseExtendedLayout = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage2.Controls.Add(this.kryptonSplitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(773, 340);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Tag = false;
            this.tabPage2.Text = "Telas do sistema";
            // 
            // kryptonSplitContainer1
            // 
            this.kryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.kryptonSplitContainer1.Name = "kryptonSplitContainer1";
            // 
            // kryptonSplitContainer1.Panel1
            // 
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // kryptonSplitContainer1.Panel2
            // 
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.dgvReports);
            this.kryptonSplitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile;
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(773, 340);
            this.kryptonSplitContainer1.SplitterDistance = 197;
            this.kryptonSplitContainer1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.treePesquisa);
            this.panel1.Controls.Add(this.treeTelas);
            this.panel1.Controls.Add(this.btnSincronizar);
            this.panel1.Controls.Add(this.txtPesquisaForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 340);
            this.panel1.TabIndex = 0;
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
            this.treePesquisa.Size = new System.Drawing.Size(195, 294);
            this.treePesquisa.StateCommon.Node.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treePesquisa.StateCommon.Node.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.treePesquisa.TabIndex = 12;
            this.treePesquisa.Visible = false;
            this.treePesquisa.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeTelas_BeforeSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Folder.ico");
            this.imageList1.Images.SetKeyName(1, "1349871595_application_form.ico");
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
            this.treeTelas.Size = new System.Drawing.Size(195, 294);
            this.treeTelas.StateCommon.Node.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeTelas.StateCommon.Node.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.treeTelas.TabIndex = 9;
            this.treeTelas.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeTelas_BeforeSelect);
            // 
            // btnSincronizar
            // 
            this.btnSincronizar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSincronizar.Location = new System.Drawing.Point(0, 313);
            this.btnSincronizar.Name = "btnSincronizar";
            this.btnSincronizar.Size = new System.Drawing.Size(195, 25);
            this.btnSincronizar.TabIndex = 11;
            this.btnSincronizar.Values.Text = "Sincronizar Relatórios";
            this.btnSincronizar.Click += new System.EventHandler(this.btnSincronizar_Click);
            // 
            // txtPesquisaForm
            // 
            this.txtPesquisaForm.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btnLimpaPesquisa});
            this.txtPesquisaForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPesquisaForm.Location = new System.Drawing.Point(0, 0);
            this.txtPesquisaForm.Name = "txtPesquisaForm";
            this.txtPesquisaForm.Size = new System.Drawing.Size(195, 19);
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
            this.txtPesquisaForm.TabIndex = 10;
            this.txtPesquisaForm.TextChanged += new System.EventHandler(this.txtPesquisaForm_TextChanged);
            // 
            // btnLimpaPesquisa
            // 
            this.btnLimpaPesquisa.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.btnLimpaPesquisa.UniqueName = "45E1D0505ECF49F843A9007491BEC9EB";
            this.btnLimpaPesquisa.Click += new System.EventHandler(this.btnLimpaPesquisa_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblFormSelecionado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 317);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(571, 23);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(158, 18);
            this.toolStripStatusLabel1.Text = "Relatórios disponíveis para:";
            // 
            // lblFormSelecionado
            // 
            this.lblFormSelecionado.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormSelecionado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFormSelecionado.Name = "lblFormSelecionado";
            this.lblFormSelecionado.Size = new System.Drawing.Size(398, 18);
            this.lblFormSelecionado.Spring = true;
            this.lblFormSelecionado.Text = "-";
            this.lblFormSelecionado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDuplicar,
            this.tsmExcluir,
            this.editarRelatórioToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 70);
            // 
            // tsmDuplicar
            // 
            this.tsmDuplicar.Name = "tsmDuplicar";
            this.tsmDuplicar.Size = new System.Drawing.Size(168, 22);
            this.tsmDuplicar.Text = "Duplicar Relatório";
            this.tsmDuplicar.Click += new System.EventHandler(this.tsmDuplicar_Click);
            // 
            // tsmExcluir
            // 
            this.tsmExcluir.Name = "tsmExcluir";
            this.tsmExcluir.Size = new System.Drawing.Size(168, 22);
            this.tsmExcluir.Text = "Excluir Relatório";
            this.tsmExcluir.Click += new System.EventHandler(this.tsmExcluir_Click);
            // 
            // editarRelatórioToolStripMenuItem
            // 
            this.editarRelatórioToolStripMenuItem.Name = "editarRelatórioToolStripMenuItem";
            this.editarRelatórioToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.editarRelatórioToolStripMenuItem.Text = "Editar Relatório";
            this.editarRelatórioToolStripMenuItem.Click += new System.EventHandler(this.editarRelatórioToolStripMenuItem_Click);
            // 
            // tempo
            // 
            this.tempo.Tick += new System.EventHandler(this.tempo_Tick);
            // 
            // dgvReports
            // 
            this.dgvReports.AllowUserToAddRows = false;
            this.dgvReports.AllowUserToDeleteRows = false;
            this.dgvReports.AutoGenerateColumns = false;
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stAtivoDataGridViewCheckBoxColumn,
            this.clxNomeRelatorio,
            this.xDestalhes,
            this.clxNomeFisico});
            this.dgvReports.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvReports.DataSource = this.bsReports;
            this.dgvReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReports.Location = new System.Drawing.Point(0, 0);
            this.dgvReports.MultiSelect = false;
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.RowHeadersWidth = 25;
            this.dgvReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvReports.Size = new System.Drawing.Size(571, 340);
            this.dgvReports.TabIndex = 0;
            this.dgvReports.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvReports_CellBeginEdit);
            this.dgvReports.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReports_CellValidated);
            // 
            // stAtivoDataGridViewCheckBoxColumn
            // 
            this.stAtivoDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.stAtivoDataGridViewCheckBoxColumn.DataPropertyName = "stAtivo";
            this.stAtivoDataGridViewCheckBoxColumn.HeaderText = "Ativo";
            this.stAtivoDataGridViewCheckBoxColumn.Name = "stAtivoDataGridViewCheckBoxColumn";
            this.stAtivoDataGridViewCheckBoxColumn.Width = 45;
            // 
            // clxNomeRelatorio
            // 
            this.clxNomeRelatorio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clxNomeRelatorio.DataPropertyName = "xNomeRelatorio";
            this.clxNomeRelatorio.HeaderText = "Nome do Relatorio";
            this.clxNomeRelatorio.MaxInputLength = 150;
            this.clxNomeRelatorio.Name = "clxNomeRelatorio";
            // 
            // xDestalhes
            // 
            this.xDestalhes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xDestalhes.DataPropertyName = "xDestalhes";
            this.xDestalhes.HeaderText = "Detalhes do Relatório";
            this.xDestalhes.Name = "xDestalhes";
            // 
            // clxNomeFisico
            // 
            this.clxNomeFisico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clxNomeFisico.DataPropertyName = "xNomeFisico";
            this.clxNomeFisico.HeaderText = "Nome Físico";
            this.clxNomeFisico.MaxInputLength = 100;
            this.clxNomeFisico.Name = "clxNomeFisico";
            this.clxNomeFisico.ReadOnly = true;
            // 
            // bsReports
            // 
            this.bsReports.DataSource = typeof(HLP.Comum.Infrastructure.RelatoriosModel);
            // 
            // FormConfigRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 369);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "FormConfigRelatorio";
            this.ShowIcon = false;
            this.Text = "Configurações de relatórios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConfigRelatorio_FormClosing);
            this.Load += new System.EventHandler(this.FormConfigRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonTabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).EndInit();
            this.kryptonSplitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).EndInit();
            this.kryptonSplitContainer1.Panel2.ResumeLayout(false);
            this.kryptonSplitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).EndInit();
            this.kryptonSplitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTreeView treeTelas;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSincronizar;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPesquisaForm;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnLimpaPesquisa;
        private HLP_DataGridView dgvReports;
        private System.Windows.Forms.BindingSource bsReports;
        private ComponentFactory.Krypton.Toolkit.KryptonTreeView treePesquisa;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblFormSelecionado;
        private System.Windows.Forms.Timer tempo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmDuplicar;
        private System.Windows.Forms.ToolStripMenuItem tsmExcluir;
        private System.Windows.Forms.ToolStripMenuItem editarRelatórioToolStripMenuItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn stAtivoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clxNomeRelatorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDestalhes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clxNomeFisico;

    }
}

