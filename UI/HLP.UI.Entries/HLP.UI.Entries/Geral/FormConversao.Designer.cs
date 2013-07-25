using HLP.Comum.Components;
namespace HLP.UI.Entries.Geral
{
    partial class FormConversao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConversao));
            this.kryptonTabControl2 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.kryptonPanel3 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.kryptonTabControl1 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kryptonPanel1 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.dgvConversao = new HLP.Comum.Components.HLP_DataGridView();
            this.idDeUnidadeMedida = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idParaUnidadeMedida = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.stArrendondar = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.nFator = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.nQuantidadeAdicional = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.bsConversao = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.hlP_LabelSeparator1 = new HLP.Comum.Components.HLP_LabelSeparator();
            this.hlP_PesquisaidProduto = new HLP.Comum.Components.HLP_Pesquisa();
            this.btnInserir = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblConversao = new System.Windows.Forms.Label();
            this.kryptonDataGridViewNumericUpDownColumn1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.kryptonDataGridViewNumericUpDownColumn2 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.kryptonDataGridViewNumericUpDownColumn3 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.kryptonDataGridViewNumericUpDownColumn4 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).BeginInit();
            this.panelPadrao.SuspendLayout();
            this.kryptonTabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.kryptonPanel3.SuspendLayout();
            this.kryptonTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConversao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConversao)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(856, 392);
            // 
            // panelPadrao
            // 
            this.panelPadrao.Controls.Add(this.kryptonTabControl2);
            this.panelPadrao.Size = new System.Drawing.Size(854, 368);
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
            this.kryptonTabControl2.Location = new System.Drawing.Point(3, 3);
            this.kryptonTabControl2.Name = "kryptonTabControl2";
            this.kryptonTabControl2.PreserveTabColor = false;
            this.kryptonTabControl2.SelectedIndex = 0;
            this.kryptonTabControl2.Size = new System.Drawing.Size(848, 362);
            this.kryptonTabControl2.TabIndex = 3;
            this.kryptonTabControl2.UseExtendedLayout = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage3.Controls.Add(this.kryptonPanel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(840, 333);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Tag = false;
            this.tabPage3.Text = "Principal";
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.BorderWidth = 0;
            this.kryptonPanel3.Controls.Add(this.kryptonTabControl1);
            this.kryptonPanel3.Controls.Add(this.flowLayoutPanel1);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel3.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.kryptonPanel3.GradientToogleColors = false;
            this.kryptonPanel3.GradientUseBlend = false;
            this.kryptonPanel3.GradientUseSolid = true;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.PersistentColors = false;
            this.kryptonPanel3.Size = new System.Drawing.Size(840, 333);
            this.kryptonPanel3.TabIndex = 0;
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
            this.kryptonTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.kryptonTabControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.kryptonTabControl1.HotTrack = true;
            this.kryptonTabControl1.Location = new System.Drawing.Point(0, 107);
            this.kryptonTabControl1.Name = "kryptonTabControl1";
            this.kryptonTabControl1.PreserveTabColor = false;
            this.kryptonTabControl1.SelectedIndex = 0;
            this.kryptonTabControl1.Size = new System.Drawing.Size(840, 226);
            this.kryptonTabControl1.TabIndex = 26;
            this.kryptonTabControl1.UseExtendedLayout = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Controls.Add(this.kryptonPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(832, 197);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = false;
            this.tabPage1.Text = "Grade";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.BorderWidth = 0;
            this.kryptonPanel1.Controls.Add(this.dgvConversao);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.kryptonPanel1.GradientToogleColors = false;
            this.kryptonPanel1.GradientUseBlend = false;
            this.kryptonPanel1.GradientUseSolid = true;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PersistentColors = false;
            this.kryptonPanel1.Size = new System.Drawing.Size(832, 197);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // dgvConversao
            // 
            this.dgvConversao.Altera = false;
            this.dgvConversao.AutoGenerateColumns = false;
            this.dgvConversao.cm = null;
            this.dgvConversao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConversao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDeUnidadeMedida,
            this.idParaUnidadeMedida,
            this.stArrendondar,
            this.nFator,
            this.nQuantidadeAdicional});
            this.dgvConversao.DataSource = this.bsConversao;
            this.dgvConversao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConversao.DragDropLinha = false;
            this.dgvConversao.Exclui = false;
            this.dgvConversao.Inclui = false;
            this.dgvConversao.Location = new System.Drawing.Point(0, 0);
            this.dgvConversao.Name = "dgvConversao";
            this.dgvConversao.Size = new System.Drawing.Size(832, 197);
            this.dgvConversao.TabIndex = 27;
            this.dgvConversao.Tag = "Conversao";
            this.dgvConversao.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvConversao_DefaultValuesNeeded);
            // 
            // idDeUnidadeMedida
            // 
            this.idDeUnidadeMedida.DataPropertyName = "idDeUnidadeMedida";
            this.idDeUnidadeMedida.HeaderText = "Da Unidade";
            this.idDeUnidadeMedida.Name = "idDeUnidadeMedida";
            this.idDeUnidadeMedida.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idDeUnidadeMedida.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idDeUnidadeMedida.ToolTipText = "Unidade de origem da conversão";
            this.idDeUnidadeMedida.Width = 130;
            // 
            // idParaUnidadeMedida
            // 
            this.idParaUnidadeMedida.DataPropertyName = "idParaUnidadeMedida";
            this.idParaUnidadeMedida.HeaderText = "Para Unidade";
            this.idParaUnidadeMedida.Name = "idParaUnidadeMedida";
            this.idParaUnidadeMedida.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idParaUnidadeMedida.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idParaUnidadeMedida.ToolTipText = "Unidade de destino da conversão";
            this.idParaUnidadeMedida.Width = 130;
            // 
            // stArrendondar
            // 
            this.stArrendondar.DataPropertyName = "stArrendondar";
            this.stArrendondar.HeaderText = "Arrendondar";
            this.stArrendondar.Items.AddRange(new object[] {
            "0-PARA BAIXO",
            "1-PARA CIMA"});
            this.stArrendondar.Name = "stArrendondar";
            this.stArrendondar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stArrendondar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.stArrendondar.ToolTipText = "Utilize se o sistema irá arredondar a conversão para cima ou para baixo";
            this.stArrendondar.Width = 130;
            // 
            // nFator
            // 
            this.nFator.DataPropertyName = "nFator";
            this.nFator.HeaderText = "Fator de Conversão";
            this.nFator.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nFator.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nFator.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nFator.Name = "nFator";
            this.nFator.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nFator.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.nFator.ToolTipText = "Fator de conversão entre a \"unidade de origem\" e a \"unidade de destino";
            this.nFator.Width = 150;
            // 
            // nQuantidadeAdicional
            // 
            this.nQuantidadeAdicional.DataPropertyName = "nQuantidadeAdicional";
            this.nQuantidadeAdicional.HeaderText = "Quantidade Adicional";
            this.nQuantidadeAdicional.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nQuantidadeAdicional.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nQuantidadeAdicional.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nQuantidadeAdicional.Name = "nQuantidadeAdicional";
            this.nQuantidadeAdicional.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nQuantidadeAdicional.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.nQuantidadeAdicional.ToolTipText = "Especifique a quantidade adicionada à unidade mediante a conversão";
            this.nQuantidadeAdicional.Width = 200;
            // 
            // bsConversao
            // 
            this.bsConversao.DataSource = typeof(HLP.Models.Entries.Gerais.ConversaoModel);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.hlP_LabelSeparator1);
            this.flowLayoutPanel1.Controls.Add(this.hlP_PesquisaidProduto);
            this.flowLayoutPanel1.Controls.Add(this.btnInserir);
            this.flowLayoutPanel1.Controls.Add(this.lblConversao);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(840, 107);
            this.flowLayoutPanel1.TabIndex = 25;
            // 
            // hlP_LabelSeparator1
            // 
            this.hlP_LabelSeparator1._LabelText = "Parametro";
            this.hlP_LabelSeparator1._TamanhoMaiorLabel = 0;
            this.hlP_LabelSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.hlP_LabelSeparator1.Location = new System.Drawing.Point(3, 3);
            this.hlP_LabelSeparator1.Name = "hlP_LabelSeparator1";
            this.hlP_LabelSeparator1.Size = new System.Drawing.Size(568, 18);
            this.hlP_LabelSeparator1.TabIndex = 2;
            this.hlP_LabelSeparator1.TabStop = false;
            // 
            // hlP_PesquisaidProduto
            // 
            this.hlP_PesquisaidProduto._Field = "idProduto";
            this.hlP_PesquisaidProduto._Help = "Informar o código do produto para criação das unidades de conversões";
            this.hlP_PesquisaidProduto._LabelGroup = this.hlP_LabelSeparator1;
            this.hlP_PesquisaidProduto._LabelText = "Produto";
            this.hlP_PesquisaidProduto._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidProduto._ListaCamposDisplay")));
            this.hlP_PesquisaidProduto._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidProduto._ListaValoresDisplay")));
            this.hlP_PesquisaidProduto._NomeCampoPK = "ID";
            this.hlP_PesquisaidProduto._NomeFormCadastroOriginal = "FormProduto";
            this.hlP_PesquisaidProduto._NomeView = "vwProduto";
            this.hlP_PesquisaidProduto._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.SIM;
            this.hlP_PesquisaidProduto._Regex = null;
            this.hlP_PesquisaidProduto._Table = "Conversao";
            this.hlP_PesquisaidProduto._TamanhoComponente = 429;
            this.hlP_PesquisaidProduto._TamanhoMaiorLabel = 0;
            this.hlP_PesquisaidProduto._Vinculado = false;
            this.hlP_PesquisaidProduto._Visible = true;
            this.hlP_PesquisaidProduto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidProduto.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidProduto.Base = null;
            this.hlP_PesquisaidProduto.Location = new System.Drawing.Point(3, 27);
            this.hlP_PesquisaidProduto.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.hlP_PesquisaidProduto.Name = "hlP_PesquisaidProduto";
            this.hlP_PesquisaidProduto.ReadOnly = false;
            this.hlP_PesquisaidProduto.Size = new System.Drawing.Size(568, 21);
            this.hlP_PesquisaidProduto.TabIndex = 0;
            this.hlP_PesquisaidProduto.Value = 0;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(3, 54);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(127, 25);
            this.btnInserir.TabIndex = 1;
            this.btnInserir.Values.Text = "Lançar Conversões";
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // lblConversao
            // 
            this.lblConversao.AutoSize = true;
            this.lblConversao.BackColor = System.Drawing.Color.Transparent;
            this.lblConversao.Location = new System.Drawing.Point(3, 82);
            this.lblConversao.Name = "lblConversao";
            this.lblConversao.Size = new System.Drawing.Size(0, 13);
            this.lblConversao.TabIndex = 0;
            // 
            // kryptonDataGridViewNumericUpDownColumn1
            // 
            this.kryptonDataGridViewNumericUpDownColumn1.DataPropertyName = "nFator";
            this.kryptonDataGridViewNumericUpDownColumn1.HeaderText = "Fator de Conversão";
            this.kryptonDataGridViewNumericUpDownColumn1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kryptonDataGridViewNumericUpDownColumn1.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.kryptonDataGridViewNumericUpDownColumn1.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.kryptonDataGridViewNumericUpDownColumn1.Name = "kryptonDataGridViewNumericUpDownColumn1";
            this.kryptonDataGridViewNumericUpDownColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kryptonDataGridViewNumericUpDownColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.kryptonDataGridViewNumericUpDownColumn1.ToolTipText = "Fator de conversão entre a \"unidade de origem\" e a \"unidade de destino";
            this.kryptonDataGridViewNumericUpDownColumn1.Width = 100;
            // 
            // kryptonDataGridViewNumericUpDownColumn2
            // 
            this.kryptonDataGridViewNumericUpDownColumn2.DataPropertyName = "nQuantidadeAdicional";
            this.kryptonDataGridViewNumericUpDownColumn2.HeaderText = "Quantidade Adicional";
            this.kryptonDataGridViewNumericUpDownColumn2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kryptonDataGridViewNumericUpDownColumn2.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.kryptonDataGridViewNumericUpDownColumn2.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.kryptonDataGridViewNumericUpDownColumn2.Name = "kryptonDataGridViewNumericUpDownColumn2";
            this.kryptonDataGridViewNumericUpDownColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kryptonDataGridViewNumericUpDownColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.kryptonDataGridViewNumericUpDownColumn2.ToolTipText = "Especifique a quantidade adicionada à unidade mediante a conversão";
            this.kryptonDataGridViewNumericUpDownColumn2.Width = 100;
            // 
            // kryptonDataGridViewNumericUpDownColumn3
            // 
            this.kryptonDataGridViewNumericUpDownColumn3.DataPropertyName = "nFator";
            this.kryptonDataGridViewNumericUpDownColumn3.HeaderText = "Fator de Conversão";
            this.kryptonDataGridViewNumericUpDownColumn3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kryptonDataGridViewNumericUpDownColumn3.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.kryptonDataGridViewNumericUpDownColumn3.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.kryptonDataGridViewNumericUpDownColumn3.Name = "kryptonDataGridViewNumericUpDownColumn3";
            this.kryptonDataGridViewNumericUpDownColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kryptonDataGridViewNumericUpDownColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.kryptonDataGridViewNumericUpDownColumn3.ToolTipText = "Fator de conversão entre a \"unidade de origem\" e a \"unidade de destino";
            this.kryptonDataGridViewNumericUpDownColumn3.Width = 100;
            // 
            // kryptonDataGridViewNumericUpDownColumn4
            // 
            this.kryptonDataGridViewNumericUpDownColumn4.DataPropertyName = "nQuantidadeAdicional";
            this.kryptonDataGridViewNumericUpDownColumn4.HeaderText = "Quantidade Adicional";
            this.kryptonDataGridViewNumericUpDownColumn4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kryptonDataGridViewNumericUpDownColumn4.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.kryptonDataGridViewNumericUpDownColumn4.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.kryptonDataGridViewNumericUpDownColumn4.Name = "kryptonDataGridViewNumericUpDownColumn4";
            this.kryptonDataGridViewNumericUpDownColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kryptonDataGridViewNumericUpDownColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.kryptonDataGridViewNumericUpDownColumn4.ToolTipText = "Especifique a quantidade adicionada à unidade mediante a conversão";
            this.kryptonDataGridViewNumericUpDownColumn4.Width = 100;
            // 
            // FormConversao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 419);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConversao";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = -10;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text = "Conversões";
            this.Load += new System.EventHandler(this.FormConversao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).EndInit();
            this.panelPadrao.ResumeLayout(false);
            this.kryptonTabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.kryptonPanel3.ResumeLayout(false);
            this.kryptonTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConversao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConversao)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel3;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidProduto;
        private System.Windows.Forms.BindingSource bsConversao;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn kryptonDataGridViewNumericUpDownColumn1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn kryptonDataGridViewNumericUpDownColumn2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn kryptonDataGridViewNumericUpDownColumn3;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn kryptonDataGridViewNumericUpDownColumn4;
        private System.Windows.Forms.Label lblConversao;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnInserir;
        private HLP_DataGridView dgvConversao;
        private System.Windows.Forms.DataGridViewComboBoxColumn idDeUnidadeMedida;
        private System.Windows.Forms.DataGridViewComboBoxColumn idParaUnidadeMedida;
        private System.Windows.Forms.DataGridViewComboBoxColumn stArrendondar;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn nFator;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn nQuantidadeAdicional;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private HLP_LabelSeparator hlP_LabelSeparator1;
        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel1;
    }
}