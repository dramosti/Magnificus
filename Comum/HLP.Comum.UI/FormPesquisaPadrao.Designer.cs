using HLP.Comum.Components;
namespace HLP.Comum.UI
{
    partial class FormPesquisaPadrao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPesquisaPadrao));
            this.dgvFiltro = new HLP.Comum.Components.HLP_DataGridView();
            this.HeaderText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operador = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EOU = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DATA_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmParam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLUMN_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsOpcoesGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportarConteudoPExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnAplica = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLimpar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnImprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCadastrar = new System.Windows.Forms.ToolStripButton();
            this.tsImprimir = new System.Windows.Forms.ToolStripSeparator();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvDados = new HLP.Comum.Components.HLP_DataGridView();
            this.sstripFormPadrao = new System.Windows.Forms.StatusStrip();
            this.lblTotalRegistros = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnConfigurar = new System.Windows.Forms.ToolStripSplitButton();
            this.configurarPesquisaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miniToolStrip = new System.Windows.Forms.StatusStrip();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltro)).BeginInit();
            this.cmsOpcoesGrid.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.sstripFormPadrao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFiltro
            // 
            this.dgvFiltro.AllowUserToAddRows = false;
            this.dgvFiltro.Altera = false;
            this.dgvFiltro.cm = null;
            this.dgvFiltro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HeaderText,
            this.Operador,
            this.Valor,
            this.EOU,
            this.DATA_TYPE,
            this.clmParam,
            this.COLUMN_NAME});
            this.dgvFiltro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFiltro.DragDropLinha = false;
            this.dgvFiltro.Exclui = false;
            this.dgvFiltro.Inclui = false;
            this.dgvFiltro.Location = new System.Drawing.Point(0, 0);
            this.dgvFiltro.Name = "dgvFiltro";
            this.dgvFiltro.RowHeadersWidth = 15;
            this.dgvFiltro.RowTemplate.Height = 23;
            this.dgvFiltro.Size = new System.Drawing.Size(821, 109);
            this.dgvFiltro.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvFiltro.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFiltro.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dgvFiltro.TabIndex = 6;
            this.dgvFiltro.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiltro_CellValidated);
            this.dgvFiltro.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvFiltro_CellValidating);
            // 
            // HeaderText
            // 
            this.HeaderText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.HeaderText.DataPropertyName = "HeaderText";
            this.HeaderText.HeaderText = "Campos";
            this.HeaderText.Name = "HeaderText";
            this.HeaderText.ReadOnly = true;
            this.HeaderText.Width = 77;
            // 
            // Operador
            // 
            this.Operador.DataPropertyName = "Operador";
            this.Operador.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Operador.HeaderText = "Operador";
            this.Operador.Items.AddRange(new object[] {
            "Igual a",
            "Igual na Frase",
            "Começando com",
            "Entre",
            "Não Entre",
            "Na Lista",
            "Não na Lista",
            "Diferente que",
            "Maior que",
            "Maior Igual que",
            "Menor que",
            "Menor Igual que",
            "Branco",
            "Não Branco"});
            this.Operador.Name = "Operador";
            this.Operador.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Operador.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Operador.Width = 130;
            // 
            // Valor
            // 
            this.Valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor(es)  ";
            this.Valor.MaxInputLength = 255;
            this.Valor.Name = "Valor";
            // 
            // EOU
            // 
            this.EOU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EOU.DataPropertyName = "EOU";
            this.EOU.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.EOU.HeaderText = "E/OU";
            this.EOU.Items.AddRange(new object[] {
            "E",
            "OU"});
            this.EOU.Name = "EOU";
            this.EOU.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DATA_TYPE
            // 
            this.DATA_TYPE.DataPropertyName = "DATA_TYPE";
            this.DATA_TYPE.HeaderText = "DATA_TYPE";
            this.DATA_TYPE.Name = "DATA_TYPE";
            this.DATA_TYPE.Visible = false;
            // 
            // clmParam
            // 
            this.clmParam.DataPropertyName = "Param";
            this.clmParam.HeaderText = "Parametro";
            this.clmParam.Name = "clmParam";
            this.clmParam.Visible = false;
            // 
            // COLUMN_NAME
            // 
            this.COLUMN_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.COLUMN_NAME.DataPropertyName = "COLUMN_NAME";
            this.COLUMN_NAME.HeaderText = "COLUMN_NAME";
            this.COLUMN_NAME.Name = "COLUMN_NAME";
            this.COLUMN_NAME.ReadOnly = true;
            this.COLUMN_NAME.Visible = false;
            // 
            // cmsOpcoesGrid
            // 
            this.cmsOpcoesGrid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmsOpcoesGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarConteudoPExcelToolStripMenuItem});
            this.cmsOpcoesGrid.Name = "cmsOpcoesGrid";
            this.cmsOpcoesGrid.Size = new System.Drawing.Size(215, 26);
            // 
            // exportarConteudoPExcelToolStripMenuItem
            // 
            this.exportarConteudoPExcelToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportarConteudoPExcelToolStripMenuItem.Name = "exportarConteudoPExcelToolStripMenuItem";
            this.exportarConteudoPExcelToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.exportarConteudoPExcelToolStripMenuItem.Text = "Exportar Conteúdo p/ Excel";
            this.exportarConteudoPExcelToolStripMenuItem.Click += new System.EventHandler(this.exportarConteudoPExcelToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAplica,
            this.toolStripSeparator4,
            this.btnLimpar,
            this.toolStripSeparator2,
            this.btnImprimir,
            this.toolStripSeparator1,
            this.btnCadastrar,
            this.tsImprimir,
            this.btnNovo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(821, 27);
            this.menuStrip1.TabIndex = 101;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnAplica
            // 
            this.btnAplica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAplica.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAplica.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAplica.Image = global::HLP.Comum.UI.Properties.Resources.filtro;
            this.btnAplica.ImageTransparentColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAplica.Name = "btnAplica";
            this.btnAplica.Size = new System.Drawing.Size(93, 20);
            this.btnAplica.Text = "Aplicar Filtro";
            this.btnAplica.Click += new System.EventHandler(this.btnAplica_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpar.Image = global::HLP.Comum.UI.Properties.Resources.clear;
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(63, 20);
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnImprimir.Image = global::HLP.Comum.UI.Properties.Resources.Impressora;
            this.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(71, 20);
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.Visible = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            this.toolStripSeparator1.Visible = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCadastrar.Image = global::HLP.Comum.UI.Properties.Resources.Inclui;
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(76, 20);
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.Visible = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // tsImprimir
            // 
            this.tsImprimir.Name = "tsImprimir";
            this.tsImprimir.Size = new System.Drawing.Size(6, 23);
            this.tsImprimir.Visible = false;
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnNovo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNovo.Image = global::HLP.Comum.UI.Properties.Resources.Inclui;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(56, 20);
            this.btnNovo.Tag = "0";
            this.btnNovo.Text = "Novo";
            this.btnNovo.Visible = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvFiltro);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvDados);
            this.splitContainer1.Panel2.Controls.Add(this.menuStrip1);
            this.splitContainer1.Panel2.Controls.Add(this.sstripFormPadrao);
            this.splitContainer1.Size = new System.Drawing.Size(823, 389);
            this.splitContainer1.SplitterDistance = 111;
            this.splitContainer1.TabIndex = 103;
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.AllowUserToOrderColumns = true;
            this.dgvDados.Altera = false;
            this.dgvDados.cm = null;
            this.dgvDados.ContextMenuStrip = this.cmsOpcoesGrid;
            this.dgvDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDados.DragDropLinha = false;
            this.dgvDados.Exclui = false;
            this.dgvDados.Inclui = false;
            this.dgvDados.Location = new System.Drawing.Point(0, 27);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowHeadersWidth = 15;
            this.dgvDados.RowTemplate.Height = 21;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(821, 223);
            this.dgvDados.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvDados.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dgvDados.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dgvDados.TabIndex = 103;
            this.dgvDados.DataSourceChanged += new System.EventHandler(this.dgvDados_DataSourceChanged);
            this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
            this.dgvDados.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDados_ColumnHeaderMouseClick);
            this.dgvDados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDados_KeyDown);
            this.dgvDados.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvDados_KeyUp);
            // 
            // sstripFormPadrao
            // 
            this.sstripFormPadrao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sstripFormPadrao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sstripFormPadrao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTotalRegistros,
            this.btnConfigurar});
            this.sstripFormPadrao.Location = new System.Drawing.Point(0, 250);
            this.sstripFormPadrao.Name = "sstripFormPadrao";
            this.sstripFormPadrao.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.sstripFormPadrao.Size = new System.Drawing.Size(821, 22);
            this.sstripFormPadrao.SizingGrip = false;
            this.sstripFormPadrao.TabIndex = 100;
            // 
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalRegistros.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.lblTotalRegistros.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(668, 17);
            this.lblTotalRegistros.Spring = true;
            this.lblTotalRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurarPesquisaToolStripMenuItem});
            this.btnConfigurar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigurar.Image = global::HLP.Comum.UI.Properties.Resources.Utilitarios;
            this.btnConfigurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfigurar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnConfigurar.Size = new System.Drawing.Size(107, 20);
            this.btnConfigurar.Text = "Propriedades";
            this.btnConfigurar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // configurarPesquisaToolStripMenuItem
            // 
            this.configurarPesquisaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configurarPesquisaToolStripMenuItem.Name = "configurarPesquisaToolStripMenuItem";
            this.configurarPesquisaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.configurarPesquisaToolStripMenuItem.Text = "Configurar Pesquisa";
            this.configurarPesquisaToolStripMenuItem.Click += new System.EventHandler(this.configurarPesquisaToolStripMenuItem_Click);
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.miniToolStrip.Location = new System.Drawing.Point(831, 23);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.miniToolStrip.Size = new System.Drawing.Size(829, 22);
            this.miniToolStrip.TabIndex = 100;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.splitContainer1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.kryptonPanel1.Size = new System.Drawing.Size(829, 395);
            this.kryptonPanel1.TabIndex = 104;
            // 
            // FormPesquisaPadrao
            // 
            this.AllowFormChrome = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 395);
            this.Controls.Add(this.kryptonPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormPesquisaPadrao";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = -10;
            this.Text = "Pesquisa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPesquisaPadrao_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPesquisaPadrao_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltro)).EndInit();
            this.cmsOpcoesGrid.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.sstripFormPadrao.ResumeLayout(false);
            this.sstripFormPadrao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private HLP_DataGridView dgvFiltro;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripButton btnAplica;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnLimpar;
        private System.Windows.Forms.ToolStripButton btnImprimir;
        public System.Windows.Forms.ToolStripButton btnCadastrar;
        private System.Windows.Forms.ContextMenuStrip cmsOpcoesGrid;
        private System.Windows.Forms.ToolStripMenuItem exportarConteudoPExcelToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderText;
        private System.Windows.Forms.DataGridViewComboBoxColumn Operador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewComboBoxColumn EOU;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmParam;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLUMN_NAME;
        private System.Windows.Forms.SplitContainer splitContainer1;
        public HLP_DataGridView dgvDados;
        public System.Windows.Forms.StatusStrip sstripFormPadrao;
        public System.Windows.Forms.ToolStripStatusLabel lblTotalRegistros;
        private System.Windows.Forms.StatusStrip miniToolStrip;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.ToolStripSplitButton btnConfigurar;
        private System.Windows.Forms.ToolStripMenuItem configurarPesquisaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator tsImprimir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripButton btnNovo;

    }
}

