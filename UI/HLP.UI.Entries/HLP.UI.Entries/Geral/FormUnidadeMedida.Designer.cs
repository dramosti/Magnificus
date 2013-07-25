namespace HLP.UI.Entries.Geral
{
    partial class FormUnidadeMedida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUnidadeMedida));
            this.kryptonTabControl1 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kryptonPanel1 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.Principal = new System.Windows.Forms.FlowLayoutPanel();
            this.hlP_LabelSeparator1_Geral = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtCodigo = new HLP.Comum.Components.HLP_TextBox();
            this.txtxSiglaPadrao = new HLP.Comum.Components.HLP_TextBox();
            this.txtxUnidadeMedida = new HLP.Comum.Components.HLP_TextBox();
            this.nudnCasasDecimais = new HLP.Comum.Components.HLP_NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).BeginInit();
            this.panelPadrao.SuspendLayout();
            this.kryptonTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.kryptonPanel1.SuspendLayout();
            this.Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(684, 286);
            // 
            // panelPadrao
            // 
            this.panelPadrao.Controls.Add(this.kryptonTabControl1);
            this.panelPadrao.Size = new System.Drawing.Size(682, 262);
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
            this.kryptonTabControl1.Size = new System.Drawing.Size(676, 256);
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
            this.tabPage1.Size = new System.Drawing.Size(668, 227);
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
            this.kryptonPanel1.Size = new System.Drawing.Size(668, 227);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // Principal
            // 
            this.Principal.AutoScroll = true;
            this.Principal.BackColor = System.Drawing.Color.Transparent;
            this.Principal.Controls.Add(this.hlP_LabelSeparator1_Geral);
            this.Principal.Controls.Add(this.txtCodigo);
            this.Principal.Controls.Add(this.txtxSiglaPadrao);
            this.Principal.Controls.Add(this.txtxUnidadeMedida);
            this.Principal.Controls.Add(this.nudnCasasDecimais);
            this.Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Principal.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Principal.Location = new System.Drawing.Point(0, 0);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(668, 227);
            this.Principal.TabIndex = 1;
            this.Principal.Tag = "Principal";
            // 
            // hlP_LabelSeparator1_Geral
            // 
            this.hlP_LabelSeparator1_Geral._LabelText = "Geral";
            this.hlP_LabelSeparator1_Geral._TamanhoMaiorLabel = 0;
            this.hlP_LabelSeparator1_Geral.BackColor = System.Drawing.Color.Transparent;
            this.hlP_LabelSeparator1_Geral.Location = new System.Drawing.Point(0, 3);
            this.hlP_LabelSeparator1_Geral.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.hlP_LabelSeparator1_Geral.Name = "hlP_LabelSeparator1_Geral";
            this.hlP_LabelSeparator1_Geral.Size = new System.Drawing.Size(376, 18);
            this.hlP_LabelSeparator1_Geral.TabIndex = 31;
            this.hlP_LabelSeparator1_Geral.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo._Field = "idUnidadeMedida";
            this.txtCodigo._Help = "Chave principal do registro da unidade de medida";
            this.txtCodigo._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtCodigo._LabelText = "Código";
            this.txtCodigo._Multiline = false;
            this.txtCodigo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtCodigo._Password = false;
            this.txtCodigo._Regex = null;
            this.txtCodigo._Table = "Unidade_medida";
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
            // txtxSiglaPadrao
            // 
            this.txtxSiglaPadrao._Field = "xSiglaPadrao";
            this.txtxSiglaPadrao._Help = "Digite a sigla da unidade de medida ";
            this.txtxSiglaPadrao._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtxSiglaPadrao._LabelText = "Sigla";
            this.txtxSiglaPadrao._Multiline = false;
            this.txtxSiglaPadrao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxSiglaPadrao._Password = false;
            this.txtxSiglaPadrao._Regex = null;
            this.txtxSiglaPadrao._Table = "Unidade_medida";
            this.txtxSiglaPadrao._TamanhoComponente = 223;
            this.txtxSiglaPadrao._TamanhoMaiorLabel = 150;
            this.txtxSiglaPadrao._Visible = true;
            this.txtxSiglaPadrao.BackColor = System.Drawing.Color.Transparent;
            this.txtxSiglaPadrao.Base = null;
            this.txtxSiglaPadrao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxSiglaPadrao.Color = System.Drawing.Color.White;
            this.txtxSiglaPadrao.Location = new System.Drawing.Point(121, 54);
            this.txtxSiglaPadrao.Margin = new System.Windows.Forms.Padding(121, 3, 15, 3);
            this.txtxSiglaPadrao.MaxLength = 32767;
            this.txtxSiglaPadrao.Name = "txtxSiglaPadrao";
            this.txtxSiglaPadrao.ReadOnly = false;
            this.txtxSiglaPadrao.Size = new System.Drawing.Size(255, 21);
            this.txtxSiglaPadrao.TabIndex = 3;
            // 
            // txtxUnidadeMedida
            // 
            this.txtxUnidadeMedida._Field = "xUnidadeMedida";
            this.txtxUnidadeMedida._Help = "Informe o nome da unidade de medida ";
            this.txtxUnidadeMedida._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtxUnidadeMedida._LabelText = "Nome";
            this.txtxUnidadeMedida._Multiline = false;
            this.txtxUnidadeMedida._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxUnidadeMedida._Password = false;
            this.txtxUnidadeMedida._Regex = null;
            this.txtxUnidadeMedida._Table = "Unidade_medida";
            this.txtxUnidadeMedida._TamanhoComponente = 223;
            this.txtxUnidadeMedida._TamanhoMaiorLabel = 150;
            this.txtxUnidadeMedida._Visible = true;
            this.txtxUnidadeMedida.BackColor = System.Drawing.Color.Transparent;
            this.txtxUnidadeMedida.Base = null;
            this.txtxUnidadeMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxUnidadeMedida.Color = System.Drawing.Color.White;
            this.txtxUnidadeMedida.Location = new System.Drawing.Point(116, 81);
            this.txtxUnidadeMedida.Margin = new System.Windows.Forms.Padding(116, 3, 15, 3);
            this.txtxUnidadeMedida.MaxLength = 10;
            this.txtxUnidadeMedida.Name = "txtxUnidadeMedida";
            this.txtxUnidadeMedida.ReadOnly = false;
            this.txtxUnidadeMedida.Size = new System.Drawing.Size(260, 21);
            this.txtxUnidadeMedida.TabIndex = 2;
            // 
            // nudnCasasDecimais
            // 
            this.nudnCasasDecimais._Field = "nCasasDecimais";
            this.nudnCasasDecimais._Help = "Informe a quantidade de casas decimais para cada tipo de unidade de medida";
            this.nudnCasasDecimais._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.nudnCasasDecimais._LabelText = "Casas decimais";
            this.nudnCasasDecimais._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudnCasasDecimais._Regex = null;
            this.nudnCasasDecimais._Table = "Unidade_medida";
            this.nudnCasasDecimais._TamanhoComponente = 121;
            this.nudnCasasDecimais._TamanhoMaiorLabel = 150;
            this.nudnCasasDecimais._Visible = true;
            this.nudnCasasDecimais.BackColor = System.Drawing.Color.Transparent;
            this.nudnCasasDecimais.Base = null;
            this.nudnCasasDecimais.Color = System.Drawing.Color.White;
            this.nudnCasasDecimais.DecimalPlaces = 2;
            this.nudnCasasDecimais.Location = new System.Drawing.Point(70, 108);
            this.nudnCasasDecimais.Margin = new System.Windows.Forms.Padding(70, 3, 15, 3);
            this.nudnCasasDecimais.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudnCasasDecimais.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudnCasasDecimais.Name = "nudnCasasDecimais";
            this.nudnCasasDecimais.ReadOnly = false;
            this.nudnCasasDecimais.Size = new System.Drawing.Size(204, 22);
            this.nudnCasasDecimais.TabIndex = 4;
            this.nudnCasasDecimais.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudnCasasDecimais.ValueInt = 0;
            // 
            // FormUnidadeMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 313);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUnidadeMedida";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = -10;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text = "Unidade de Medida";
            this.Load += new System.EventHandler(this.FormUnidadeMedida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).EndInit();
            this.panelPadrao.ResumeLayout(false);
            this.kryptonTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.kryptonPanel1.ResumeLayout(false);
            this.Principal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.FlowLayoutPanel Principal;
        private Comum.Components.HLP_TextBox txtCodigo;
        private Comum.Components.HLP_TextBox txtxSiglaPadrao;
        private Comum.Components.HLP_TextBox txtxUnidadeMedida;
        private Comum.Components.HLP_NumericUpDown nudnCasasDecimais;
        private Comum.Components.HLP_LabelSeparator hlP_LabelSeparator1_Geral;
    }
}