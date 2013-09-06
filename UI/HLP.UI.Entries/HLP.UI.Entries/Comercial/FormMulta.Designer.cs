namespace HLP.UI.Entries.Comercial
{
    partial class FormMulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMulta));
            this.Principal = new System.Windows.Forms.FlowLayoutPanel();
            this.hlP_LabelSeparator1 = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtCodigo = new HLP.Comum.Components.HLP_TextBox();
            this.txtxNome = new HLP.Comum.Components.HLP_TextBox();
            this.txtxDescricao = new HLP.Comum.Components.HLP_TextBox();
            this.nudpPercentual = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudnDias = new HLP.Comum.Components.HLP_NumericUpDown();
            this.kryptonTabControl1 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kryptonPanel1 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).BeginInit();
            this.panelPadrao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelAtalhos)).BeginInit();
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
            this.panelPadrao.Size = new System.Drawing.Size(591, 260);
            // 
            // panelAtalhos
            // 
            this.panelAtalhos.Size = new System.Drawing.Size(28, 260);
            // 
            // Principal
            // 
            this.Principal.AutoScroll = true;
            this.Principal.BackColor = System.Drawing.Color.Transparent;
            this.Principal.Controls.Add(this.hlP_LabelSeparator1);
            this.Principal.Controls.Add(this.txtCodigo);
            this.Principal.Controls.Add(this.txtxNome);
            this.Principal.Controls.Add(this.txtxDescricao);
            this.Principal.Controls.Add(this.nudpPercentual);
            this.Principal.Controls.Add(this.nudnDias);
            this.Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Principal.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Principal.Location = new System.Drawing.Point(0, 0);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(577, 225);
            this.Principal.TabIndex = 1;
            this.Principal.Tag = "Principal";
            // 
            // hlP_LabelSeparator1
            // 
            this.hlP_LabelSeparator1._LabelText = "Geral";
            this.hlP_LabelSeparator1._TamanhoMaiorLabel = 0;
            this.hlP_LabelSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.hlP_LabelSeparator1.Location = new System.Drawing.Point(3, 3);
            this.hlP_LabelSeparator1.Name = "hlP_LabelSeparator1";
            this.hlP_LabelSeparator1.Size = new System.Drawing.Size(365, 19);
            this.hlP_LabelSeparator1.TabIndex = 5;
            this.hlP_LabelSeparator1.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo._Field = "idMultas";
            this.txtCodigo._Help = "Chave principal do registro da multa";
            this.txtCodigo._LabelGroup = this.hlP_LabelSeparator1;
            this.txtCodigo._LabelText = "Código";
            this.txtCodigo._Multiline = false;
            this.txtCodigo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtCodigo._Password = false;
            this.txtCodigo._Regex = null;
            this.txtCodigo._Table = "Multas";
            this.txtCodigo._TamanhoComponente = 107;
            this.txtCodigo._TamanhoMaiorLabel = 120;
            this.txtCodigo.BackColor = System.Drawing.Color.Transparent;
            this.txtCodigo.Base = null;
            this.txtCodigo.bConfiguracao = false;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCodigo.Color = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(78, 28);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(78, 3, 15, 3);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.objConfigComponenteModel = null;
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(152, 21);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtxNome
            // 
            this.txtxNome._Field = "xNome";
            this.txtxNome._Help = "Insira o nome do código da multa";
            this.txtxNome._LabelGroup = this.hlP_LabelSeparator1;
            this.txtxNome._LabelText = "Nome";
            this.txtxNome._Multiline = false;
            this.txtxNome._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxNome._Password = false;
            this.txtxNome._Regex = null;
            this.txtxNome._Table = "Multas";
            this.txtxNome._TamanhoComponente = 217;
            this.txtxNome._TamanhoMaiorLabel = 120;
            this.txtxNome.BackColor = System.Drawing.Color.Transparent;
            this.txtxNome.Base = null;
            this.txtxNome.bConfiguracao = false;
            this.txtxNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxNome.Color = System.Drawing.Color.White;
            this.txtxNome.Location = new System.Drawing.Point(86, 55);
            this.txtxNome.Margin = new System.Windows.Forms.Padding(86, 3, 15, 3);
            this.txtxNome.MaxLength = 32767;
            this.txtxNome.Name = "txtxNome";
            this.txtxNome.objConfigComponenteModel = null;
            this.txtxNome.ReadOnly = false;
            this.txtxNome.Size = new System.Drawing.Size(254, 21);
            this.txtxNome.TabIndex = 3;
            // 
            // txtxDescricao
            // 
            this.txtxDescricao._Field = "xDescricao";
            this.txtxDescricao._Help = "Insira a descrição detalhada da multa";
            this.txtxDescricao._LabelGroup = this.hlP_LabelSeparator1;
            this.txtxDescricao._LabelText = "Descrição";
            this.txtxDescricao._Multiline = false;
            this.txtxDescricao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxDescricao._Password = false;
            this.txtxDescricao._Regex = null;
            this.txtxDescricao._Table = "Multas";
            this.txtxDescricao._TamanhoComponente = 245;
            this.txtxDescricao._TamanhoMaiorLabel = 120;
            this.txtxDescricao.BackColor = System.Drawing.Color.Transparent;
            this.txtxDescricao.Base = null;
            this.txtxDescricao.bConfiguracao = false;
            this.txtxDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxDescricao.Color = System.Drawing.Color.White;
            this.txtxDescricao.Location = new System.Drawing.Point(67, 82);
            this.txtxDescricao.Margin = new System.Windows.Forms.Padding(67, 3, 15, 3);
            this.txtxDescricao.MaxLength = 10;
            this.txtxDescricao.Name = "txtxDescricao";
            this.txtxDescricao.objConfigComponenteModel = null;
            this.txtxDescricao.ReadOnly = false;
            this.txtxDescricao.Size = new System.Drawing.Size(301, 21);
            this.txtxDescricao.TabIndex = 2;
            // 
            // nudpPercentual
            // 
            this.nudpPercentual._Field = "pPercentual";
            this.nudpPercentual._Help = "Insira a porcentagem da multa que se aplica ao código da multa";
            this.nudpPercentual._LabelGroup = this.hlP_LabelSeparator1;
            this.nudpPercentual._LabelText = "Percentual da multa ";
            this.nudpPercentual._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudpPercentual._Regex = null;
            this.nudpPercentual._Table = "Multas";
            this.nudpPercentual._TamanhoComponente = 118;
            this.nudpPercentual._TamanhoMaiorLabel = 120;
            this.nudpPercentual.BackColor = System.Drawing.Color.Transparent;
            this.nudpPercentual.Base = null;
            this.nudpPercentual.bConfiguracao = false;
            this.nudpPercentual.Color = System.Drawing.Color.White;
            this.nudpPercentual.DecimalPlaces = 2;
            this.nudpPercentual.Location = new System.Drawing.Point(11, 109);
            this.nudpPercentual.Margin = new System.Windows.Forms.Padding(11, 3, 15, 3);
            this.nudpPercentual.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudpPercentual.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudpPercentual.Name = "nudpPercentual";
            this.nudpPercentual.objConfigComponenteModel = null;
            this.nudpPercentual.ReadOnly = false;
            this.nudpPercentual.Size = new System.Drawing.Size(230, 22);
            this.nudpPercentual.TabIndex = 4;
            this.nudpPercentual.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudpPercentual.ValueInt = 0;
            // 
            // nudnDias
            // 
            this.nudnDias._Field = "nDias";
            this.nudnDias._Help = "Insira o número de dias no período de carência antes da aplicação da porcentagem " +
    "de multa";
            this.nudnDias._LabelGroup = this.hlP_LabelSeparator1;
            this.nudnDias._LabelText = "Dias de carência";
            this.nudnDias._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudnDias._Regex = null;
            this.nudnDias._Table = "Multas";
            this.nudnDias._TamanhoComponente = 117;
            this.nudnDias._TamanhoMaiorLabel = 120;
            this.nudnDias.BackColor = System.Drawing.Color.Transparent;
            this.nudnDias.Base = null;
            this.nudnDias.bConfiguracao = false;
            this.nudnDias.Color = System.Drawing.Color.White;
            this.nudnDias.DecimalPlaces = 2;
            this.nudnDias.Location = new System.Drawing.Point(33, 137);
            this.nudnDias.Margin = new System.Windows.Forms.Padding(33, 3, 15, 3);
            this.nudnDias.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudnDias.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudnDias.Name = "nudnDias";
            this.nudnDias.objConfigComponenteModel = null;
            this.nudnDias.ReadOnly = false;
            this.nudnDias.Size = new System.Drawing.Size(207, 22);
            this.nudnDias.TabIndex = 4;
            this.nudnDias.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudnDias.ValueInt = 0;
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
            this.kryptonTabControl1.Size = new System.Drawing.Size(585, 254);
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
            this.tabPage1.Size = new System.Drawing.Size(577, 225);
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
            this.kryptonPanel1.Size = new System.Drawing.Size(577, 225);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // FormMulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 311);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMulta";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = -10;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text = "Multas";
            this.Load += new System.EventHandler(this.FormMulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).EndInit();
            this.panelPadrao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelAtalhos)).EndInit();
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
        private Comum.Components.HLP_TextBox txtxNome;
        private Comum.Components.HLP_TextBox txtxDescricao;
        private Comum.Components.HLP_NumericUpDown nudpPercentual;
        private Comum.Components.HLP_NumericUpDown nudnDias;
        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel1;
        private Comum.Components.HLP_LabelSeparator hlP_LabelSeparator1;
    }
}