namespace HLP.UI.Entries.Geral
{
    partial class FormMoeda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMoeda));
            this.Principal = new System.Windows.Forms.FlowLayoutPanel();
            this.hlP_LabelSeparator1_Geral = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtCodigo = new HLP.Comum.Components.HLP_TextBox();
            this.txtxSiglaMoeda = new HLP.Comum.Components.HLP_TextBox();
            this.txtxMoeda = new HLP.Comum.Components.HLP_TextBox();
            this.txtxSimbolo = new HLP.Comum.Components.HLP_TextBox();
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
            this.panel1.Size = new System.Drawing.Size(645, 301);
            // 
            // panelPadrao
            // 
            this.panelPadrao.Controls.Add(this.kryptonTabControl1);
            this.panelPadrao.Size = new System.Drawing.Size(643, 277);
            // 
            // Principal
            // 
            this.Principal.AutoScroll = true;
            this.Principal.BackColor = System.Drawing.Color.Transparent;
            this.Principal.Controls.Add(this.hlP_LabelSeparator1_Geral);
            this.Principal.Controls.Add(this.txtCodigo);
            this.Principal.Controls.Add(this.txtxSiglaMoeda);
            this.Principal.Controls.Add(this.txtxMoeda);
            this.Principal.Controls.Add(this.txtxSimbolo);
            this.Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Principal.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Principal.Location = new System.Drawing.Point(0, 0);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(629, 242);
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
            this.hlP_LabelSeparator1_Geral.Size = new System.Drawing.Size(348, 18);
            this.hlP_LabelSeparator1_Geral.TabIndex = 30;
            this.hlP_LabelSeparator1_Geral.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo._Field = "idMoeda";
            this.txtCodigo._Help = "Chave principal do registro da moeda";
            this.txtCodigo._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtCodigo._LabelText = "Código";
            this.txtCodigo._Multiline = false;
            this.txtCodigo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtCodigo._Password = false;
            this.txtCodigo._Regex = null;
            this.txtCodigo._Table = "Moeda";
            this.txtCodigo._TamanhoComponente = 107;
            this.txtCodigo._TamanhoMaiorLabel = 130;
            this.txtCodigo._Visible = true;
            this.txtCodigo.BackColor = System.Drawing.Color.Transparent;
            this.txtCodigo.Base = null;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCodigo.Color = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(88, 27);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(88, 3, 15, 3);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(152, 21);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtxSiglaMoeda
            // 
            this.txtxSiglaMoeda._Field = "xSiglaMoeda";
            this.txtxSiglaMoeda._Help = "O identificador exclusivo de um código de até três caracteres.";
            this.txtxSiglaMoeda._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtxSiglaMoeda._LabelText = "Moeda";
            this.txtxSiglaMoeda._Multiline = false;
            this.txtxSiglaMoeda._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.SIM;
            this.txtxSiglaMoeda._Password = false;
            this.txtxSiglaMoeda._Regex = null;
            this.txtxSiglaMoeda._Table = "Moeda";
            this.txtxSiglaMoeda._TamanhoComponente = 107;
            this.txtxSiglaMoeda._TamanhoMaiorLabel = 130;
            this.txtxSiglaMoeda._Visible = true;
            this.txtxSiglaMoeda.BackColor = System.Drawing.Color.Transparent;
            this.txtxSiglaMoeda.Base = null;
            this.txtxSiglaMoeda.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxSiglaMoeda.Color = System.Drawing.Color.White;
            this.txtxSiglaMoeda.Location = new System.Drawing.Point(90, 54);
            this.txtxSiglaMoeda.Margin = new System.Windows.Forms.Padding(90, 3, 15, 3);
            this.txtxSiglaMoeda.MaxLength = 32767;
            this.txtxSiglaMoeda.Name = "txtxSiglaMoeda";
            this.txtxSiglaMoeda.ReadOnly = false;
            this.txtxSiglaMoeda.Size = new System.Drawing.Size(150, 21);
            this.txtxSiglaMoeda.TabIndex = 3;
            // 
            // txtxMoeda
            // 
            this.txtxMoeda._Field = "xMoeda";
            this.txtxMoeda._Help = "Um nome para a moeda selecionada,  juntamente com o código da moeda, é impressa e" +
    "m cheques e outros documentos.";
            this.txtxMoeda._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtxMoeda._LabelText = "Nome";
            this.txtxMoeda._Multiline = false;
            this.txtxMoeda._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.SIM;
            this.txtxMoeda._Password = false;
            this.txtxMoeda._Regex = null;
            this.txtxMoeda._Table = "Moeda";
            this.txtxMoeda._TamanhoComponente = 215;
            this.txtxMoeda._TamanhoMaiorLabel = 130;
            this.txtxMoeda._Visible = true;
            this.txtxMoeda.BackColor = System.Drawing.Color.Transparent;
            this.txtxMoeda.Base = null;
            this.txtxMoeda.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxMoeda.Color = System.Drawing.Color.White;
            this.txtxMoeda.Location = new System.Drawing.Point(96, 81);
            this.txtxMoeda.Margin = new System.Windows.Forms.Padding(96, 3, 15, 3);
            this.txtxMoeda.MaxLength = 10;
            this.txtxMoeda.Name = "txtxMoeda";
            this.txtxMoeda.ReadOnly = false;
            this.txtxMoeda.Size = new System.Drawing.Size(252, 21);
            this.txtxMoeda.TabIndex = 2;
            // 
            // txtxSimbolo
            // 
            this.txtxSimbolo._Field = "xSimbolo";
            this.txtxSimbolo._Help = "O símbolo da moeda selecionada. os símbolos são usados frequentemente nos relatór" +
    "ios.";
            this.txtxSimbolo._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtxSimbolo._LabelText = "Símbolo";
            this.txtxSimbolo._Multiline = false;
            this.txtxSimbolo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.SIM;
            this.txtxSimbolo._Password = false;
            this.txtxSimbolo._Regex = null;
            this.txtxSimbolo._Table = "Moeda";
            this.txtxSimbolo._TamanhoComponente = 107;
            this.txtxSimbolo._TamanhoMaiorLabel = 130;
            this.txtxSimbolo._Visible = true;
            this.txtxSimbolo.BackColor = System.Drawing.Color.Transparent;
            this.txtxSimbolo.Base = null;
            this.txtxSimbolo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxSimbolo.Color = System.Drawing.Color.White;
            this.txtxSimbolo.Location = new System.Drawing.Point(84, 108);
            this.txtxSimbolo.Margin = new System.Windows.Forms.Padding(84, 3, 15, 3);
            this.txtxSimbolo.MaxLength = 10;
            this.txtxSimbolo.Name = "txtxSimbolo";
            this.txtxSimbolo.ReadOnly = false;
            this.txtxSimbolo.Size = new System.Drawing.Size(156, 21);
            this.txtxSimbolo.TabIndex = 4;
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
            this.kryptonTabControl1.Size = new System.Drawing.Size(637, 271);
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
            this.tabPage1.Size = new System.Drawing.Size(629, 242);
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
            this.kryptonPanel1.Size = new System.Drawing.Size(629, 242);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // FormMoeda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 328);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMoeda";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = -10;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Text = "Moedas";
            this.Load += new System.EventHandler(this.FormMoeda_Load);
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
        private Comum.Components.HLP_TextBox txtxSiglaMoeda;
        private Comum.Components.HLP_TextBox txtxMoeda;
        private Comum.Components.HLP_TextBox txtxSimbolo;
        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel1;
        private Comum.Components.HLP_LabelSeparator hlP_LabelSeparator1_Geral;
    }
}