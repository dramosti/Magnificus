using HLP.Comum.Components;
namespace HLP.UI.Entries.Fiscal
{
    partial class FormCodigoIcms
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.hlP_LabelSeparator1_Geral = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtCodigo = new HLP.Comum.Components.HLP_TextBox();
            this.nudcIcms = new HLP.Comum.Components.HLP_NumericUpDown();
            this.dgvCodigo_Icms = new HLP.Comum.Components.HLP_DataGridView();
            this.idUf = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pIcmsEstado = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.pIcmsInterna = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.pIcmsSubstituicaoTributaria = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.pIcmsNaoContribruinteForaEstado = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.vCoeficienteIcms = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.xFundamLegalCodTrib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsCodigotributario = new System.Windows.Forms.BindingSource(this.components);
            this.kryptonTabControl1 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kryptonPanel1 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).BeginInit();
            this.panelPadrao.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCodigo_Icms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCodigotributario)).BeginInit();
            this.kryptonTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.kryptonPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(783, 366);
            // 
            // panelPadrao
            // 
            this.panelPadrao.Controls.Add(this.kryptonTabControl1);
            this.panelPadrao.Size = new System.Drawing.Size(781, 342);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.hlP_LabelSeparator1_Geral);
            this.flowLayoutPanel1.Controls.Add(this.txtCodigo);
            this.flowLayoutPanel1.Controls.Add(this.nudcIcms);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(767, 307);
            this.flowLayoutPanel1.TabIndex = 115;
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
            this.txtCodigo._Field = "idCodigoIcmsPai";
            this.txtCodigo._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtCodigo._LabelText = "Código";
            this.txtCodigo._Multiline = false;
            this.txtCodigo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtCodigo._Password = false;
            this.txtCodigo._Regex = null;
            this.txtCodigo._Table = "Codigo_Icms_pai";
            this.txtCodigo._TamanhoComponente = 107;
            this.txtCodigo._TamanhoMaiorLabel = 120;
            this.txtCodigo._Visible = false;
            this.txtCodigo.BackColor = System.Drawing.Color.Transparent;
            this.txtCodigo.Base = null;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCodigo.Color = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(78, 27);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(78, 3, 15, 3);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(152, 21);
            this.txtCodigo.TabIndex = 1;
            // 
            // nudcIcms
            // 
            this.nudcIcms._Field = "cIcms";
            this.nudcIcms._Help = "Informar o código da alíquota";
            this.nudcIcms._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.nudcIcms._LabelText = "Código do icms";
            this.nudcIcms._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudcIcms._Regex = null;
            this.nudcIcms._Table = "Codigo_Icms_pai";
            this.nudcIcms._TamanhoComponente = 124;
            this.nudcIcms._TamanhoMaiorLabel = 120;
            this.nudcIcms._Visible = false;
            this.nudcIcms.BackColor = System.Drawing.Color.Transparent;
            this.nudcIcms.Base = null;
            this.nudcIcms.Color = System.Drawing.Color.White;
            this.nudcIcms.DecimalPlaces = 2;
            this.nudcIcms.Location = new System.Drawing.Point(36, 54);
            this.nudcIcms.Margin = new System.Windows.Forms.Padding(36, 3, 15, 3);
            this.nudcIcms.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudcIcms.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudcIcms.Name = "nudcIcms";
            this.nudcIcms.ReadOnly = false;
            this.nudcIcms.Size = new System.Drawing.Size(211, 22);
            this.nudcIcms.TabIndex = 2;
            this.nudcIcms.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudcIcms.ValueInt = 0;
            // 
            // dgvCodigo_Icms
            // 
            this.dgvCodigo_Icms.Altera = false;
            this.dgvCodigo_Icms.AutoGenerateColumns = false;
            this.dgvCodigo_Icms.cm = null;
            this.dgvCodigo_Icms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCodigo_Icms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUf,
            this.pIcmsEstado,
            this.pIcmsInterna,
            this.pIcmsSubstituicaoTributaria,
            this.pIcmsNaoContribruinteForaEstado,
            this.vCoeficienteIcms,
            this.xFundamLegalCodTrib});
            this.dgvCodigo_Icms.DataSource = this.bsCodigotributario;
            this.dgvCodigo_Icms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCodigo_Icms.DragDropLinha = false;
            this.dgvCodigo_Icms.Exclui = false;
            this.dgvCodigo_Icms.Inclui = false;
            this.dgvCodigo_Icms.Location = new System.Drawing.Point(0, 0);
            this.dgvCodigo_Icms.Name = "dgvCodigo_Icms";
            this.dgvCodigo_Icms.Size = new System.Drawing.Size(804, 225);
            this.dgvCodigo_Icms.TabIndex = 0;
            this.dgvCodigo_Icms.Tag = "Codigo_Icms";
            // 
            // idUf
            // 
            this.idUf.DataPropertyName = "idUf";
            this.idUf.HeaderText = "UF";
            this.idUf.Name = "idUf";
            this.idUf.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idUf.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idUf.ToolTipText = "Informar o Código do Estado para preenchimento dos cálculos de Impostos";
            this.idUf.Width = 150;
            // 
            // pIcmsEstado
            // 
            this.pIcmsEstado.DataPropertyName = "pIcmsEstado";
            this.pIcmsEstado.HeaderText = "Alíquota do Estado";
            this.pIcmsEstado.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pIcmsEstado.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.pIcmsEstado.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.pIcmsEstado.Name = "pIcmsEstado";
            this.pIcmsEstado.ToolTipText = "Informar a porcentagem da alíquota do Estado cadastrado. ";
            this.pIcmsEstado.Width = 150;
            // 
            // pIcmsInterna
            // 
            this.pIcmsInterna.DataPropertyName = "pIcmsInterna";
            this.pIcmsInterna.HeaderText = "Alíquota Interna";
            this.pIcmsInterna.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pIcmsInterna.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.pIcmsInterna.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.pIcmsInterna.Name = "pIcmsInterna";
            this.pIcmsInterna.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pIcmsInterna.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pIcmsInterna.ToolTipText = "Informar a porcentagem de Alíquota Interna do Estado cadastrado";
            this.pIcmsInterna.Width = 150;
            // 
            // pIcmsSubstituicaoTributaria
            // 
            this.pIcmsSubstituicaoTributaria.DataPropertyName = "pIcmsSubstituicaoTributaria";
            this.pIcmsSubstituicaoTributaria.HeaderText = "Alíquota de Subst. Trib. (MVA/IVA)";
            this.pIcmsSubstituicaoTributaria.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pIcmsSubstituicaoTributaria.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.pIcmsSubstituicaoTributaria.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.pIcmsSubstituicaoTributaria.Name = "pIcmsSubstituicaoTributaria";
            this.pIcmsSubstituicaoTributaria.ToolTipText = "Informar o percentual da Substituição Tributário do Estado.";
            this.pIcmsSubstituicaoTributaria.Width = 310;
            // 
            // pIcmsNaoContribruinteForaEstado
            // 
            this.pIcmsNaoContribruinteForaEstado.DataPropertyName = "pIcmsNaoContribruinteForaEstado";
            this.pIcmsNaoContribruinteForaEstado.HeaderText = "Alíquota de ICMS para Não Contribuinte Fora do Estado";
            this.pIcmsNaoContribruinteForaEstado.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pIcmsNaoContribruinteForaEstado.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.pIcmsNaoContribruinteForaEstado.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.pIcmsNaoContribruinteForaEstado.Name = "pIcmsNaoContribruinteForaEstado";
            this.pIcmsNaoContribruinteForaEstado.ToolTipText = "Informar a porcentagem da alíquota do Estado cadastrado para Não contribuintes de" +
    " Outros Estados";
            this.pIcmsNaoContribruinteForaEstado.Width = 310;
            // 
            // vCoeficienteIcms
            // 
            this.vCoeficienteIcms.DataPropertyName = "vCoeficienteIcms";
            this.vCoeficienteIcms.HeaderText = "Coeficiente Icms";
            this.vCoeficienteIcms.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.vCoeficienteIcms.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.vCoeficienteIcms.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.vCoeficienteIcms.Name = "vCoeficienteIcms";
            this.vCoeficienteIcms.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vCoeficienteIcms.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.vCoeficienteIcms.ToolTipText = "Informar o Coeficiente de ICMS";
            this.vCoeficienteIcms.Width = 130;
            // 
            // xFundamLegalCodTrib
            // 
            this.xFundamLegalCodTrib.DataPropertyName = "xFundamLegalCodTrib";
            this.xFundamLegalCodTrib.HeaderText = "Fundamento Legal";
            this.xFundamLegalCodTrib.Name = "xFundamLegalCodTrib";
            this.xFundamLegalCodTrib.ToolTipText = "Informar o Fundamento Legal dessa Condição Tributária.";
            this.xFundamLegalCodTrib.Width = 200;
            // 
            // bsCodigotributario
            // 
            this.bsCodigotributario.DataSource = typeof(HLP.Models.Entries.Fiscal.Codigo_IcmsModel);
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
            this.kryptonTabControl1.Size = new System.Drawing.Size(775, 336);
            this.kryptonTabControl1.TabIndex = 4;
            this.kryptonTabControl1.UseExtendedLayout = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Controls.Add(this.kryptonPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(767, 307);
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
            this.kryptonPanel1.Size = new System.Drawing.Size(767, 307);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvCodigo_Icms);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(804, 225);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Tag = false;
            this.tabPage2.Text = "Tributação";
            // 
            // FormCodigoIcms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 393);
            this.Name = "FormCodigoIcms";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = -10;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Text = "Código de Icms";
            this.Load += new System.EventHandler(this.FormCodigoTributario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).EndInit();
            this.panelPadrao.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCodigo_Icms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCodigotributario)).EndInit();
            this.kryptonTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.kryptonPanel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Comum.Components.HLP_TextBox txtCodigo;
        private Comum.Components.HLP_NumericUpDown nudcIcms;
        private HLP_DataGridView dgvCodigo_Icms;
        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource bsCodigotributario;
        private HLP_LabelSeparator hlP_LabelSeparator1_Geral;
        private System.Windows.Forms.DataGridViewComboBoxColumn idUf;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn pIcmsEstado;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn pIcmsInterna;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn pIcmsSubstituicaoTributaria;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn pIcmsNaoContribruinteForaEstado;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn vCoeficienteIcms;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFundamLegalCodTrib;
    }
}