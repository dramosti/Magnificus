namespace HLP.Comum.UI
{
    partial class FormPadraoCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPadraoCadastro));
            this.stripPadrao = new System.Windows.Forms.StatusStrip();
            this.lblHelp = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTextPadrao1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTextPadrao2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblError = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblProgresso = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbProgresso = new System.Windows.Forms.ToolStripProgressBar();
            this.miniToolStrip = new System.Windows.Forms.MenuStrip();
            this.sepNovo = new System.Windows.Forms.ToolStripSeparator();
            this.sepExcluir = new System.Windows.Forms.ToolStripSeparator();
            this.sepAtualizar = new System.Windows.Forms.ToolStripSeparator();
            this.sepSalvar = new System.Windows.Forms.ToolStripSeparator();
            this.sepCancelar = new System.Windows.Forms.ToolStripSeparator();
            this.sepPesquisar = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sepImprimir = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsConfigurar = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxConfiguracao = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsHabilitar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDesabilitar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCamposVisiveis = new System.Windows.Forms.ToolStripMenuItem();
            this.sepDuplicar = new System.Windows.Forms.ToolStripSeparator();
            this.lblCount = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.panelPadrao = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.panelAtalhos = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btnMinimiza = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.cmsOpcoesGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportarConteudoPExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarTamanhoDasColunasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bwWorkerInicializa = new System.ComponentModel.BackgroundWorker();
            this.bwWorkerRecarregaForm = new System.ComponentModel.BackgroundWorker();
            this.flowPainelBotoes = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.tsConfigComp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsConsistForm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.tsRestaurarPadrao = new System.Windows.Forms.ToolStripMenuItem();
            this.tsArquivoSys = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnAtualizar = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnPesquisar = new System.Windows.Forms.ToolStripButton();
            this.btnImprimir = new System.Windows.Forms.ToolStripButton();
            this.btnDuplicar = new System.Windows.Forms.ToolStripButton();
            this.btnPrimeiro = new System.Windows.Forms.ToolStripButton();
            this.btnAnterior = new System.Windows.Forms.ToolStripButton();
            this.btnProximo = new System.Windows.Forms.ToolStripButton();
            this.btnUltimo = new System.Windows.Forms.ToolStripButton();
            this.stripPadrao.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.ctxConfiguracao.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).BeginInit();
            this.kryptonSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).BeginInit();
            this.kryptonSplitContainer1.Panel2.SuspendLayout();
            this.kryptonSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelAtalhos)).BeginInit();
            this.panelAtalhos.SuspendLayout();
            this.cmsOpcoesGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // stripPadrao
            // 
            this.stripPadrao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stripPadrao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.stripPadrao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblHelp,
            this.lblTextPadrao1,
            this.lblTextPadrao2,
            this.lblError,
            this.lblProgresso,
            this.pbProgresso,
            this.toolStripSplitButton1});
            this.stripPadrao.Location = new System.Drawing.Point(0, 260);
            this.stripPadrao.Name = "stripPadrao";
            this.stripPadrao.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.stripPadrao.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.stripPadrao.Size = new System.Drawing.Size(1158, 22);
            this.stripPadrao.SizingGrip = false;
            this.stripPadrao.TabIndex = 113;
            // 
            // lblHelp
            // 
            this.lblHelp.AutoToolTip = true;
            this.lblHelp.BackColor = System.Drawing.Color.Transparent;
            this.lblHelp.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblHelp.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.lblHelp.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(1034, 17);
            this.lblHelp.Spring = true;
            this.lblHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTextPadrao1
            // 
            this.lblTextPadrao1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextPadrao1.Name = "lblTextPadrao1";
            this.lblTextPadrao1.Size = new System.Drawing.Size(0, 17);
            // 
            // lblTextPadrao2
            // 
            this.lblTextPadrao2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextPadrao2.Name = "lblTextPadrao2";
            this.lblTextPadrao2.Size = new System.Drawing.Size(0, 17);
            // 
            // lblError
            // 
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            // 
            // lblProgresso
            // 
            this.lblProgresso.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgresso.Name = "lblProgresso";
            this.lblProgresso.Size = new System.Drawing.Size(71, 17);
            this.lblProgresso.Text = "lblProgresso";
            this.lblProgresso.Visible = false;
            // 
            // pbProgresso
            // 
            this.pbProgresso.Name = "pbProgresso";
            this.pbProgresso.Size = new System.Drawing.Size(100, 16);
            this.pbProgresso.Step = 1;
            this.pbProgresso.Visible = false;
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.miniToolStrip.Location = new System.Drawing.Point(515, 4);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(623, 27);
            this.miniToolStrip.TabIndex = 104;
            // 
            // sepNovo
            // 
            this.sepNovo.Name = "sepNovo";
            this.sepNovo.Size = new System.Drawing.Size(6, 23);
            // 
            // sepExcluir
            // 
            this.sepExcluir.Name = "sepExcluir";
            this.sepExcluir.Size = new System.Drawing.Size(6, 23);
            // 
            // sepAtualizar
            // 
            this.sepAtualizar.Name = "sepAtualizar";
            this.sepAtualizar.Size = new System.Drawing.Size(6, 23);
            // 
            // sepSalvar
            // 
            this.sepSalvar.Name = "sepSalvar";
            this.sepSalvar.Size = new System.Drawing.Size(6, 23);
            // 
            // sepCancelar
            // 
            this.sepCancelar.Name = "sepCancelar";
            this.sepCancelar.Size = new System.Drawing.Size(6, 23);
            // 
            // sepPesquisar
            // 
            this.sepPesquisar.Name = "sepPesquisar";
            this.sepPesquisar.Size = new System.Drawing.Size(6, 23);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovo,
            this.sepNovo,
            this.btnExcluir,
            this.sepExcluir,
            this.btnAtualizar,
            this.sepAtualizar,
            this.btnSalvar,
            this.sepSalvar,
            this.btnCancelar,
            this.sepCancelar,
            this.btnPesquisar,
            this.sepPesquisar,
            this.btnImprimir,
            this.sepImprimir,
            this.btnDuplicar,
            this.toolStripSeparator1,
            this.tsConfigurar,
            this.sepDuplicar,
            this.btnPrimeiro,
            this.btnAnterior,
            this.lblCount,
            this.btnProximo,
            this.btnUltimo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1160, 27);
            this.menuStrip1.TabIndex = 104;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sepImprimir
            // 
            this.sepImprimir.Name = "sepImprimir";
            this.sepImprimir.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // tsConfigurar
            // 
            this.tsConfigurar.BackColor = System.Drawing.Color.Transparent;
            this.tsConfigurar.DropDown = this.ctxConfiguracao;
            this.tsConfigurar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.tsConfigurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsConfigurar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsConfigurar.Name = "tsConfigurar";
            this.tsConfigurar.Size = new System.Drawing.Size(75, 23);
            this.tsConfigurar.Text = "Con&figurar";
            // 
            // ctxConfiguracao
            // 
            this.ctxConfiguracao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxConfiguracao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsHabilitar,
            this.tsDesabilitar,
            this.tsCamposVisiveis});
            this.ctxConfiguracao.Name = "cmsOpcoesGrid";
            this.ctxConfiguracao.OwnerItem = this.tsConfigurar;
            this.ctxConfiguracao.Size = new System.Drawing.Size(211, 70);
            // 
            // tsHabilitar
            // 
            this.tsHabilitar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsHabilitar.Name = "tsHabilitar";
            this.tsHabilitar.Size = new System.Drawing.Size(210, 22);
            this.tsHabilitar.Text = "Habilitar";
            this.tsHabilitar.Click += new System.EventHandler(this.tsHab_Click);
            // 
            // tsDesabilitar
            // 
            this.tsDesabilitar.Enabled = false;
            this.tsDesabilitar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsDesabilitar.Name = "tsDesabilitar";
            this.tsDesabilitar.Size = new System.Drawing.Size(210, 22);
            this.tsDesabilitar.Text = "Desabilitar";
            this.tsDesabilitar.Click += new System.EventHandler(this.tsHab_Click);
            // 
            // tsCamposVisiveis
            // 
            this.tsCamposVisiveis.Enabled = false;
            this.tsCamposVisiveis.Name = "tsCamposVisiveis";
            this.tsCamposVisiveis.Size = new System.Drawing.Size(210, 22);
            this.tsCamposVisiveis.Text = "Mostrar campos invisíveis";
            this.tsCamposVisiveis.Click += new System.EventHandler(this.tsHab_Click);
            // 
            // sepDuplicar
            // 
            this.sepDuplicar.Name = "sepDuplicar";
            this.sepDuplicar.Size = new System.Drawing.Size(6, 23);
            // 
            // lblCount
            // 
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(42, 20);
            this.lblCount.Text = "0 de 0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.kryptonSplitContainer1);
            this.panel1.Controls.Add(this.stripPadrao);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 284);
            this.panel1.TabIndex = 117;
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
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.panelPadrao);
            // 
            // kryptonSplitContainer1.Panel2
            // 
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.panelAtalhos);
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(1158, 260);
            this.kryptonSplitContainer1.SplitterDistance = 1017;
            this.kryptonSplitContainer1.SplitterWidth = 2;
            this.kryptonSplitContainer1.TabIndex = 119;
            // 
            // panelPadrao
            // 
            this.panelPadrao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPadrao.Location = new System.Drawing.Point(0, 0);
            this.panelPadrao.Name = "panelPadrao";
            this.panelPadrao.Padding = new System.Windows.Forms.Padding(3);
            this.panelPadrao.Size = new System.Drawing.Size(1017, 260);
            this.panelPadrao.TabIndex = 118;
            // 
            // panelAtalhos
            // 
            this.panelAtalhos.Controls.Add(this.flowPainelBotoes);
            this.panelAtalhos.Controls.Add(this.kryptonHeader1);
            this.panelAtalhos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAtalhos.Location = new System.Drawing.Point(0, 0);
            this.panelAtalhos.Name = "panelAtalhos";
            this.panelAtalhos.Size = new System.Drawing.Size(139, 260);
            this.panelAtalhos.TabIndex = 119;
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btnMinimiza});
            this.kryptonHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader1.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Form;
            this.kryptonHeader1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Size = new System.Drawing.Size(139, 28);
            this.kryptonHeader1.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonHeader1.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonHeader1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonHeader1.StateDisabled.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonHeader1.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonHeader1.StateNormal.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonHeader1.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonHeader1.TabIndex = 1;
            this.kryptonHeader1.Values.Description = "";
            this.kryptonHeader1.Values.Heading = "Atalhos";
            this.kryptonHeader1.Values.Image = global::HLP.Comum.UI.Properties.Resources._1376435704_flash;
            // 
            // btnMinimiza
            // 
            this.btnMinimiza.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowRight;
            this.btnMinimiza.UniqueName = "B64FF2A4BCDF49C59895AB8FFFB715A7";
            this.btnMinimiza.Click += new System.EventHandler(this.btnMinimiza_Click);
            // 
            // cmsOpcoesGrid
            // 
            this.cmsOpcoesGrid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmsOpcoesGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarConteudoPExcelToolStripMenuItem,
            this.salvarTamanhoDasColunasToolStripMenuItem});
            this.cmsOpcoesGrid.Name = "cmsOpcoesGrid";
            this.cmsOpcoesGrid.Size = new System.Drawing.Size(244, 48);
            // 
            // exportarConteudoPExcelToolStripMenuItem
            // 
            this.exportarConteudoPExcelToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportarConteudoPExcelToolStripMenuItem.Name = "exportarConteudoPExcelToolStripMenuItem";
            this.exportarConteudoPExcelToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.exportarConteudoPExcelToolStripMenuItem.Text = "Exportar Conteúdo p/ Excel";
            this.exportarConteudoPExcelToolStripMenuItem.Click += new System.EventHandler(this.exportarConteudoPExcelToolStripMenuItem_Click);
            // 
            // salvarTamanhoDasColunasToolStripMenuItem
            // 
            this.salvarTamanhoDasColunasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvarTamanhoDasColunasToolStripMenuItem.Name = "salvarTamanhoDasColunasToolStripMenuItem";
            this.salvarTamanhoDasColunasToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.salvarTamanhoDasColunasToolStripMenuItem.Text = "Salvar Configuração das Colunas";
            this.salvarTamanhoDasColunasToolStripMenuItem.Click += new System.EventHandler(this.salvarTamanhoDasColunasToolStripMenuItem_Click);
            // 
            // bwWorkerInicializa
            // 
            this.bwWorkerInicializa.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwWorker_DoWork);
            // 
            // bwWorkerRecarregaForm
            // 
            this.bwWorkerRecarregaForm.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwWorkerRecarregaForm_DoWork);
            // 
            // flowPainelBotoes
            // 
            this.flowPainelBotoes.BackColor = System.Drawing.Color.Transparent;
            this.flowPainelBotoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPainelBotoes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPainelBotoes.Location = new System.Drawing.Point(0, 28);
            this.flowPainelBotoes.Name = "flowPainelBotoes";
            this.flowPainelBotoes.Size = new System.Drawing.Size(139, 232);
            this.flowPainelBotoes.TabIndex = 2;
            this.flowPainelBotoes.SizeChanged += new System.EventHandler(this.flowPainelBotoes_SizeChanged);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsConfigComp,
            this.tsConsistForm,
            this.toolStripSeparator9,
            this.tsRestaurarPadrao,
            this.tsArquivoSys});
            this.toolStripSplitButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripSplitButton1.Image = global::HLP.Comum.UI.Properties.Resources.Utilitarios;
            this.toolStripSplitButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripSplitButton1.Size = new System.Drawing.Size(107, 20);
            this.toolStripSplitButton1.Text = "Propriedades";
            this.toolStripSplitButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // tsConfigComp
            // 
            this.tsConfigComp.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsConfigComp.Name = "tsConfigComp";
            this.tsConfigComp.Size = new System.Drawing.Size(198, 22);
            this.tsConfigComp.Text = "Configurar Componetes";
            this.tsConfigComp.Click += new System.EventHandler(this.TsUtility_Click);
            // 
            // tsConsistForm
            // 
            this.tsConsistForm.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsConsistForm.Name = "tsConsistForm";
            this.tsConsistForm.Size = new System.Drawing.Size(198, 22);
            this.tsConsistForm.Text = "Consistir Formulário";
            this.tsConsistForm.Click += new System.EventHandler(this.TsUtility_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(195, 6);
            // 
            // tsRestaurarPadrao
            // 
            this.tsRestaurarPadrao.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsRestaurarPadrao.Name = "tsRestaurarPadrao";
            this.tsRestaurarPadrao.Size = new System.Drawing.Size(198, 22);
            this.tsRestaurarPadrao.Text = "Restaurar Padrão HLP";
            this.tsRestaurarPadrao.Click += new System.EventHandler(this.TsUtility_Click);
            // 
            // tsArquivoSys
            // 
            this.tsArquivoSys.Name = "tsArquivoSys";
            this.tsArquivoSys.Size = new System.Drawing.Size(198, 22);
            this.tsArquivoSys.Text = "Criar Arquivo Sys.Form";
            this.tsArquivoSys.Click += new System.EventHandler(this.TsUtility_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNovo.Image = global::HLP.Comum.UI.Properties.Resources.Inclui;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(56, 20);
            this.btnNovo.Text = "&Novo";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExcluir.Image = global::HLP.Comum.UI.Properties.Resources._6239_16x16;
            this.btnExcluir.ImageTransparentColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(61, 20);
            this.btnExcluir.Text = "E&xcluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtualizar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAtualizar.Image = global::HLP.Comum.UI.Properties.Resources.Edita;
            this.btnAtualizar.ImageTransparentColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(73, 20);
            this.btnAtualizar.Text = "&Atualizar";
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalvar.Image = global::HLP.Comum.UI.Properties.Resources.Confirma;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(58, 20);
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelar.Image = global::HLP.Comum.UI.Properties.Resources.Cancela;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(71, 20);
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPesquisar.Image = global::HLP.Comum.UI.Properties.Resources.Pesquisa;
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(77, 20);
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnImprimir.Image = global::HLP.Comum.UI.Properties.Resources.Impressora;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(71, 20);
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnDuplicar
            // 
            this.btnDuplicar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuplicar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDuplicar.Image = global::HLP.Comum.UI.Properties.Resources.Duplicar;
            this.btnDuplicar.Name = "btnDuplicar";
            this.btnDuplicar.Size = new System.Drawing.Size(70, 20);
            this.btnDuplicar.Text = "&Duplicar";
            this.btnDuplicar.Click += new System.EventHandler(this.btnDuplicar_Click);
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.Image = global::HLP.Comum.UI.Properties.Resources.primeiro__2_;
            this.btnPrimeiro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrimeiro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(23, 20);
            this.btnPrimeiro.ToolTipText = "Próximo";
            this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Image = global::HLP.Comum.UI.Properties.Resources.esquerda;
            this.btnAnterior.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(23, 20);
            this.btnAnterior.ToolTipText = "Próximo";
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Image = global::HLP.Comum.UI.Properties.Resources.direita___Cópia;
            this.btnProximo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProximo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(23, 20);
            this.btnProximo.ToolTipText = "Próximo";
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Image = global::HLP.Comum.UI.Properties.Resources.ultimo__4_;
            this.btnUltimo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUltimo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(23, 20);
            this.btnUltimo.ToolTipText = "Próximo";
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // FormPadraoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 311);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormPadraoCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = -10;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPadraoCadastro_FormClosing);
            this.Load += new System.EventHandler(this.FormPadraoCadastro_Load);
            this.ResizeBegin += new System.EventHandler(this.FormPadraoCadastro_ResizeBegin);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPadraoCadastro_KeyDown);
            this.Resize += new System.EventHandler(this.FormPadraoCadastro_Resize);
            this.stripPadrao.ResumeLayout(false);
            this.stripPadrao.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ctxConfiguracao.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).EndInit();
            this.kryptonSplitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).EndInit();
            this.kryptonSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).EndInit();
            this.kryptonSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelAtalhos)).EndInit();
            this.panelAtalhos.ResumeLayout(false);
            this.panelAtalhos.PerformLayout();
            this.cmsOpcoesGrid.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.StatusStrip stripPadrao;
        public System.Windows.Forms.ToolStripStatusLabel lblHelp;
        public System.Windows.Forms.ToolStripStatusLabel lblTextPadrao1;
        public System.Windows.Forms.ToolStripStatusLabel lblTextPadrao2;
        public System.Windows.Forms.ToolStripStatusLabel lblError;
        private System.Windows.Forms.MenuStrip miniToolStrip;
        private System.Windows.Forms.ToolStripSeparator sepExcluir;
        private System.Windows.Forms.ToolStripSeparator sepAtualizar;
        private System.Windows.Forms.ToolStripSeparator sepSalvar;
        private System.Windows.Forms.ToolStripSeparator sepCancelar;
        private System.Windows.Forms.ToolStripSeparator sepPesquisar;
        private System.Windows.Forms.ToolStripButton btnPrimeiro;
        public System.Windows.Forms.ToolStripButton btnAnterior;
        public System.Windows.Forms.ToolStripButton btnProximo;
        public System.Windows.Forms.ToolStripButton btnUltimo;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem tsConsistForm;
        private System.Windows.Forms.ToolStripMenuItem tsConfigComp;
        private System.Windows.Forms.ToolStripMenuItem tsRestaurarPadrao;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip cmsOpcoesGrid;
        private System.Windows.Forms.ToolStripMenuItem exportarConteudoPExcelToolStripMenuItem;
        public System.Windows.Forms.ToolStripButton btnNovo;
        public System.Windows.Forms.ToolStripButton btnExcluir;
        public System.Windows.Forms.ToolStripButton btnAtualizar;
        public System.Windows.Forms.ToolStripButton btnSalvar;
        public System.Windows.Forms.ToolStripButton btnCancelar;
        public System.Windows.Forms.ToolStripButton btnPesquisar;
        public System.Windows.Forms.ToolStripButton btnImprimir;
        public System.Windows.Forms.ToolStripButton btnDuplicar;
        private System.Windows.Forms.ToolStripSeparator sepImprimir;
        private System.Windows.Forms.ToolStripMenuItem tsArquivoSys;
        private System.Windows.Forms.ToolStripMenuItem salvarTamanhoDasColunasToolStripMenuItem;
        public System.Windows.Forms.ToolStripButton lblCount;
        public System.Windows.Forms.ToolStripProgressBar pbProgresso;
        public System.Windows.Forms.ToolStripStatusLabel lblProgresso;
        public System.Windows.Forms.ToolStripSeparator sepNovo;
        private System.ComponentModel.BackgroundWorker bwWorkerInicializa;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.ComponentModel.BackgroundWorker bwWorkerRecarregaForm;
        private System.Windows.Forms.ToolStripMenuItem tsConfigurar;
        public System.Windows.Forms.ToolStripSeparator sepDuplicar;
        private System.Windows.Forms.ContextMenuStrip ctxConfiguracao;
        private System.Windows.Forms.ToolStripMenuItem tsHabilitar;
        private System.Windows.Forms.ToolStripMenuItem tsDesabilitar;
        private System.Windows.Forms.ToolStripMenuItem tsCamposVisiveis;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        public ComponentFactory.Krypton.Toolkit.KryptonPanel panelPadrao;
        public ComponentFactory.Krypton.Toolkit.KryptonPanel panelAtalhos;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnMinimiza;
        private System.Windows.Forms.FlowLayoutPanel flowPainelBotoes;
    }
}