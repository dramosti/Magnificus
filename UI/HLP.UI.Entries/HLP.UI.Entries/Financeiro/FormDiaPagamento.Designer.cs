using HLP.Comum.Components;
namespace HLP.UI.Entries.Financeiro
{
    partial class FormDiaPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDiaPagamento));
            this.kryptonTabControl1 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kryptonPanel1 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.hlP_LabelSeparator1_Geral = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtCodigo = new HLP.Comum.Components.HLP_TextBox();
            this.txtxDiaPagamento = new HLP.Comum.Components.HLP_TextBox();
            this.txtxDescricao = new HLP.Comum.Components.HLP_TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.dgvDiaPagamento = new HLP.Comum.Components.HLP_DataGridView();
            this.clstSemanaMes = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clstDiaUtil = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clnDia = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.bsdiaPagamentoLinhas = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).BeginInit();
            this.panelPadrao.SuspendLayout();
            this.kryptonTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.kryptonPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiaPagamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsdiaPagamentoLinhas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPadrao
            // 
            this.panelPadrao.Controls.Add(this.kryptonTabControl1);
            // 
            // kryptonTabControl1
            // 
            this.kryptonTabControl1.AllowCloseButton = false;
            this.kryptonTabControl1.AllowContextButton = true;
            this.kryptonTabControl1.AllowNavigatorButtons = false;
            this.kryptonTabControl1.AllowSelectedTabHigh = false;
            this.kryptonTabControl1.BorderWidth = 1;
            this.kryptonTabControl1.Controls.Add(this.tabPage1);
            this.kryptonTabControl1.Controls.Add(this.tabPage2);
            this.kryptonTabControl1.CornerRoundRadiusWidth = 12;
            this.kryptonTabControl1.CornerSymmetry = AC.ExtendedRenderer.Navigator.KryptonTabControl.CornSymmetry.Both;
            this.kryptonTabControl1.CornerType = AC.ExtendedRenderer.Toolkit.Drawing.DrawingMethods.CornerType.Rounded;
            this.kryptonTabControl1.CornerWidth = AC.ExtendedRenderer.Navigator.KryptonTabControl.CornWidth.Thin;
            this.kryptonTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.kryptonTabControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.kryptonTabControl1.HotTrack = true;
            this.kryptonTabControl1.Location = new System.Drawing.Point(3, 3);
            this.kryptonTabControl1.Name = "kryptonTabControl1";
            this.kryptonTabControl1.PreserveTabColor = false;
            this.kryptonTabControl1.SelectedIndex = 0;
            this.kryptonTabControl1.Size = new System.Drawing.Size(812, 254);
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
            this.tabPage1.Size = new System.Drawing.Size(804, 225);
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
            this.kryptonPanel1.Size = new System.Drawing.Size(804, 225);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.hlP_LabelSeparator1_Geral);
            this.flowLayoutPanel1.Controls.Add(this.txtCodigo);
            this.flowLayoutPanel1.Controls.Add(this.txtxDiaPagamento);
            this.flowLayoutPanel1.Controls.Add(this.txtxDescricao);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(804, 225);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Tag = "Principal";
            // 
            // hlP_LabelSeparator1_Geral
            // 
            this.hlP_LabelSeparator1_Geral._LabelText = "Geral";
            this.hlP_LabelSeparator1_Geral._TamanhoMaiorLabel = 0;
            this.hlP_LabelSeparator1_Geral.BackColor = System.Drawing.Color.Transparent;
            this.hlP_LabelSeparator1_Geral.Location = new System.Drawing.Point(3, 3);
            this.hlP_LabelSeparator1_Geral.Name = "hlP_LabelSeparator1_Geral";
            this.hlP_LabelSeparator1_Geral.Size = new System.Drawing.Size(300, 18);
            this.hlP_LabelSeparator1_Geral.TabIndex = 28;
            this.hlP_LabelSeparator1_Geral.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo._Field = "idDiaPagamento";
            this.txtCodigo._Help = "Chave principal do registro dia de pagamento";
            this.txtCodigo._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtCodigo._LabelText = "Código";
            this.txtCodigo._Multiline = false;
            this.txtCodigo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtCodigo._Password = false;
            this.txtCodigo._Regex = null;
            this.txtCodigo._Table = "Dia_pagamento";
            this.txtCodigo._TamanhoComponente = 132;
            this.txtCodigo._TamanhoMaiorLabel = 150;
            this.txtCodigo._Visible = false;
            this.txtCodigo.BackColor = System.Drawing.Color.Transparent;
            this.txtCodigo.Base = null;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCodigo.Color = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(108, 27);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(108, 3, 15, 3);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(177, 19);
            this.txtCodigo.TabIndex = 3;
            // 
            // txtxDiaPagamento
            // 
            this.txtxDiaPagamento._Field = "xDiaPagamento";
            this.txtxDiaPagamento._Help = "Insira uma breve identificação para o dia de pagamento. ";
            this.txtxDiaPagamento._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtxDiaPagamento._LabelText = "Dia de pagamento";
            this.txtxDiaPagamento._Multiline = false;
            this.txtxDiaPagamento._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxDiaPagamento._Password = false;
            this.txtxDiaPagamento._Regex = null;
            this.txtxDiaPagamento._Table = "Dia_pagamento";
            this.txtxDiaPagamento._TamanhoComponente = 134;
            this.txtxDiaPagamento._TamanhoMaiorLabel = 150;
            this.txtxDiaPagamento._Visible = false;
            this.txtxDiaPagamento.BackColor = System.Drawing.Color.Transparent;
            this.txtxDiaPagamento.Base = null;
            this.txtxDiaPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxDiaPagamento.Color = System.Drawing.Color.White;
            this.txtxDiaPagamento.Location = new System.Drawing.Point(51, 52);
            this.txtxDiaPagamento.Margin = new System.Windows.Forms.Padding(51, 3, 15, 3);
            this.txtxDiaPagamento.MaxLength = 32767;
            this.txtxDiaPagamento.Name = "txtxDiaPagamento";
            this.txtxDiaPagamento.ReadOnly = false;
            this.txtxDiaPagamento.Size = new System.Drawing.Size(236, 19);
            this.txtxDiaPagamento.TabIndex = 4;
            // 
            // txtxDescricao
            // 
            this.txtxDescricao._Field = "xDescricao";
            this.txtxDescricao._Help = "Insira uma descrição da identificação do dia de pagamento.";
            this.txtxDescricao._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtxDescricao._LabelText = "Descrição";
            this.txtxDescricao._Multiline = false;
            this.txtxDescricao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxDescricao._Password = false;
            this.txtxDescricao._Regex = null;
            this.txtxDescricao._Table = "Dia_pagamento";
            this.txtxDescricao._TamanhoComponente = 351;
            this.txtxDescricao._TamanhoMaiorLabel = 150;
            this.txtxDescricao._Visible = false;
            this.txtxDescricao.BackColor = System.Drawing.Color.Transparent;
            this.txtxDescricao.Base = null;
            this.txtxDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxDescricao.Color = System.Drawing.Color.White;
            this.txtxDescricao.Location = new System.Drawing.Point(97, 77);
            this.txtxDescricao.Margin = new System.Windows.Forms.Padding(97, 3, 15, 3);
            this.txtxDescricao.MaxLength = 32767;
            this.txtxDescricao.Name = "txtxDescricao";
            this.txtxDescricao.ReadOnly = false;
            this.txtxDescricao.Size = new System.Drawing.Size(407, 19);
            this.txtxDescricao.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.kryptonPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(804, 225);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Tag = false;
            this.tabPage2.Text = "Dia do Pagamento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.dgvDiaPagamento);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(804, 225);
            this.kryptonPanel2.TabIndex = 0;
            // 
            // dgvDiaPagamento
            // 
            this.dgvDiaPagamento.Altera = false;
            this.dgvDiaPagamento.AutoGenerateColumns = false;
            this.dgvDiaPagamento.cm = null;
            this.dgvDiaPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiaPagamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clstSemanaMes,
            this.clstDiaUtil,
            this.clnDia});
            this.dgvDiaPagamento.DataSource = this.bsdiaPagamentoLinhas;
            this.dgvDiaPagamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDiaPagamento.DragDropLinha = false;
            this.dgvDiaPagamento.Exclui = false;
            this.dgvDiaPagamento.Inclui = false;
            this.dgvDiaPagamento.Location = new System.Drawing.Point(0, 0);
            this.dgvDiaPagamento.Name = "dgvDiaPagamento";
            this.dgvDiaPagamento.Size = new System.Drawing.Size(804, 225);
            this.dgvDiaPagamento.TabIndex = 0;
            this.dgvDiaPagamento.Tag = "Dia_pagamento_linhas";
            this.dgvDiaPagamento.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvDiaPagamento_CellBeginEdit);
            this.dgvDiaPagamento.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiaPagamento_CellValidated);
            // 
            // clstSemanaMes
            // 
            this.clstSemanaMes.DataPropertyName = "stSemanaMes";
            this.clstSemanaMes.HeaderText = "Semana/Mes";
            this.clstSemanaMes.Items.AddRange(new object[] {
            "0 - SEMANA",
            "1 - MÊS"});
            this.clstSemanaMes.Name = "clstSemanaMes";
            this.clstSemanaMes.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clstSemanaMes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clstSemanaMes.ToolTipText = "Selecione se deseja que o dia de pagamento seja repetido toda semana ou todo mês." +
    "";
            // 
            // clstDiaUtil
            // 
            this.clstDiaUtil.DataPropertyName = "stDiaUtil";
            this.clstDiaUtil.HeaderText = "Dia Útil";
            this.clstDiaUtil.Items.AddRange(new object[] {
            "0 - NÃO SE APLICA",
            "1 - SEGUNDA",
            "2 - TERÇA",
            "3 - QUARTA",
            "4 - QUINTA",
            "5 - SEXTA"});
            this.clstDiaUtil.Name = "clstDiaUtil";
            this.clstDiaUtil.ReadOnly = true;
            this.clstDiaUtil.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clstDiaUtil.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clstDiaUtil.ToolTipText = "Se você selecionar Semana na linha de pagamento, selecione um dia da semana na li" +
    "sta.";
            // 
            // clnDia
            // 
            this.clnDia.DataPropertyName = "nDia";
            this.clnDia.HeaderText = "Dia";
            this.clnDia.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.clnDia.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.clnDia.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.clnDia.Name = "clnDia";
            this.clnDia.ReadOnly = true;
            this.clnDia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnDia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clnDia.ToolTipText = "Se você selecionar Mês na linha de pagamento, insira um número entre 1 e 31.";
            this.clnDia.Width = 100;
            // 
            // bsdiaPagamentoLinhas
            // 
            this.bsdiaPagamentoLinhas.DataSource = typeof(HLP.Models.Entries.Financeiro.Dia_pagamento_linhasModel);
            // 
            // FormDiaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 311);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDiaPagamento";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = -10;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text = "FormDiaPagamento";
            this.Load += new System.EventHandler(this.FormDiaPagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).EndInit();
            this.panelPadrao.ResumeLayout(false);
            this.kryptonTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.kryptonPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiaPagamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsdiaPagamentoLinhas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Comum.Components.HLP_TextBox txtCodigo;
        private Comum.Components.HLP_TextBox txtxDiaPagamento;
        private Comum.Components.HLP_TextBox txtxDescricao;
        private System.Windows.Forms.TabPage tabPage2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private HLP_DataGridView dgvDiaPagamento;
        private System.Windows.Forms.BindingSource bsdiaPagamentoLinhas;
        private System.Windows.Forms.DataGridViewComboBoxColumn clstSemanaMes;
        private System.Windows.Forms.DataGridViewComboBoxColumn clstDiaUtil;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn clnDia;
        private HLP_LabelSeparator hlP_LabelSeparator1_Geral;

    }
}