namespace HLP.UI.Entries.Fiscal
{
    partial class FormCfop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCfop));
            this.Principal = new System.Windows.Forms.FlowLayoutPanel();
            this.hlP_LabelSeparator1_Geral = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtCodigo = new HLP.Comum.Components.HLP_TextBox();
            this.nudcCodCfop = new HLP.Comum.Components.HLP_NumericUpDown();
            this.txtxCfopResumida = new HLP.Comum.Components.HLP_TextBox();
            this.txtxCfop = new HLP.Comum.Components.HLP_TextBox();
            this.kryptonTabControl1 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kryptonPanel1 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).BeginInit();
            this.panelPadrao.SuspendLayout();
            this.Principal.SuspendLayout();
            this.kryptonTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(623, 284);
            // 
            // panelPadrao
            // 
            this.panelPadrao.Controls.Add(this.kryptonTabControl1);
            this.panelPadrao.Size = new System.Drawing.Size(621, 260);
            // 
            // Principal
            // 
            this.Principal.AutoScroll = true;
            this.Principal.BackColor = System.Drawing.Color.Transparent;
            this.Principal.Controls.Add(this.hlP_LabelSeparator1_Geral);
            this.Principal.Controls.Add(this.txtCodigo);
            this.Principal.Controls.Add(this.nudcCodCfop);
            this.Principal.Controls.Add(this.txtxCfopResumida);
            this.Principal.Controls.Add(this.txtxCfop);
            this.Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Principal.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Principal.Location = new System.Drawing.Point(0, 0);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(607, 225);
            this.Principal.TabIndex = 0;
            this.Principal.Tag = "Principal";
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
            this.txtCodigo._Field = "idCfop";
            this.txtCodigo._Help = "Chave principal do registro da cfop";
            this.txtCodigo._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtCodigo._LabelText = "Código";
            this.txtCodigo._Multiline = false;
            this.txtCodigo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtCodigo._Password = false;
            this.txtCodigo._Regex = null;
            this.txtCodigo._Table = "Cfop";
            this.txtCodigo._TamanhoComponente = 107;
            this.txtCodigo._TamanhoMaiorLabel = 150;
            this.txtCodigo._Visible = true;
            this.txtCodigo.BackColor = System.Drawing.Color.Transparent;
            this.txtCodigo.Base = null;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCodigo.Color = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(108, 27);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(108, 3, 15, 3);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(152, 21);
            this.txtCodigo.TabIndex = 0;
            // 
            // nudcCodCfop
            // 
            this.nudcCodCfop._Field = "cCfop";
            this.nudcCodCfop._Help = "Informar o código padrão da cfop fornecida pelo seu órgão emissor.";
            this.nudcCodCfop._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.nudcCodCfop._LabelText = "Cfop";
            this.nudcCodCfop._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudcCodCfop._Regex = null;
            this.nudcCodCfop._Table = "Cfop";
            this.nudcCodCfop._TamanhoComponente = 107;
            this.nudcCodCfop._TamanhoMaiorLabel = 150;
            this.nudcCodCfop._Visible = true;
            this.nudcCodCfop.BackColor = System.Drawing.Color.Transparent;
            this.nudcCodCfop.Base = null;
            this.nudcCodCfop.Color = System.Drawing.Color.White;
            this.nudcCodCfop.DecimalPlaces = 2;
            this.nudcCodCfop.Location = new System.Drawing.Point(121, 54);
            this.nudcCodCfop.Margin = new System.Windows.Forms.Padding(121, 3, 15, 3);
            this.nudcCodCfop.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudcCodCfop.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudcCodCfop.Name = "nudcCodCfop";
            this.nudcCodCfop.ReadOnly = false;
            this.nudcCodCfop.Size = new System.Drawing.Size(139, 22);
            this.nudcCodCfop.TabIndex = 4;
            this.nudcCodCfop.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudcCodCfop.ValueInt = 0;
            // 
            // txtxCfopResumida
            // 
            this.txtxCfopResumida._Field = "xCfopResumida";
            this.txtxCfopResumida._Help = "Informar uma descrição abreviada do cfop. esse campo sairá na nf por isso que há " +
    "necessidade da abreviação da descrição da cfop.";
            this.txtxCfopResumida._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtxCfopResumida._LabelText = "Descrição resumida";
            this.txtxCfopResumida._Multiline = false;
            this.txtxCfopResumida._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxCfopResumida._Password = false;
            this.txtxCfopResumida._Regex = null;
            this.txtxCfopResumida._Table = "Cfop";
            this.txtxCfopResumida._TamanhoComponente = 222;
            this.txtxCfopResumida._TamanhoMaiorLabel = 150;
            this.txtxCfopResumida._Visible = true;
            this.txtxCfopResumida.BackColor = System.Drawing.Color.Transparent;
            this.txtxCfopResumida.Base = null;
            this.txtxCfopResumida.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxCfopResumida.Color = System.Drawing.Color.White;
            this.txtxCfopResumida.Location = new System.Drawing.Point(47, 82);
            this.txtxCfopResumida.Margin = new System.Windows.Forms.Padding(47, 3, 15, 3);
            this.txtxCfopResumida.MaxLength = 32767;
            this.txtxCfopResumida.Name = "txtxCfopResumida";
            this.txtxCfopResumida.ReadOnly = false;
            this.txtxCfopResumida.Size = new System.Drawing.Size(328, 21);
            this.txtxCfopResumida.TabIndex = 3;
            // 
            // txtxCfop
            // 
            this.txtxCfop._Field = "xCfop";
            this.txtxCfop._Help = "Descrição detalhada da cfop.";
            this.txtxCfop._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtxCfop._LabelText = "Descrição";
            this.txtxCfop._Multiline = false;
            this.txtxCfop._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxCfop._Password = false;
            this.txtxCfop._Regex = null;
            this.txtxCfop._Table = "Cfop";
            this.txtxCfop._TamanhoComponente = 222;
            this.txtxCfop._TamanhoMaiorLabel = 150;
            this.txtxCfop._Visible = true;
            this.txtxCfop.BackColor = System.Drawing.Color.Transparent;
            this.txtxCfop.Base = null;
            this.txtxCfop.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxCfop.Color = System.Drawing.Color.White;
            this.txtxCfop.Location = new System.Drawing.Point(97, 109);
            this.txtxCfop.Margin = new System.Windows.Forms.Padding(97, 3, 15, 3);
            this.txtxCfop.MaxLength = 10;
            this.txtxCfop.Name = "txtxCfop";
            this.txtxCfop.ReadOnly = false;
            this.txtxCfop.Size = new System.Drawing.Size(278, 21);
            this.txtxCfop.TabIndex = 2;
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
            this.kryptonTabControl1.Location = new System.Drawing.Point(3, 3);
            this.kryptonTabControl1.Name = "kryptonTabControl1";
            this.kryptonTabControl1.PreserveTabColor = false;
            this.kryptonTabControl1.SelectedIndex = 0;
            this.kryptonTabControl1.Size = new System.Drawing.Size(615, 254);
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
            this.tabPage1.Size = new System.Drawing.Size(607, 225);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = false;
            this.tabPage1.Text = "Principal";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.BorderWidth = 0;
            this.kryptonPanel1.Controls.Add(this.Principal);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.kryptonPanel1.GradientToogleColors = false;
            this.kryptonPanel1.GradientUseBlend = false;
            this.kryptonPanel1.GradientUseSolid = true;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PersistentColors = false;
            this.kryptonPanel1.Size = new System.Drawing.Size(607, 225);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // FormCfop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 311);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCfop";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = -10;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Text = "CFOP - Código Fiscais de Operação e Prestações";
            this.Load += new System.EventHandler(this.FormCfop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).EndInit();
            this.panelPadrao.ResumeLayout(false);
            this.Principal.ResumeLayout(false);
            this.kryptonTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.kryptonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Principal;
        private Comum.Components.HLP_TextBox txtCodigo;
        private Comum.Components.HLP_TextBox txtxCfop;
        private Comum.Components.HLP_TextBox txtxCfopResumida;
        private Comum.Components.HLP_NumericUpDown nudcCodCfop;
        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel1;
        private Comum.Components.HLP_LabelSeparator hlP_LabelSeparator1_Geral;
    }
}