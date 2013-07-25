using System.Windows.Forms;
namespace HLP.UI.Entries.Financeiro
{
    partial class FormBanco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBanco));
            this.Principal = new System.Windows.Forms.FlowLayoutPanel();
            this.hlP_LabelSeparator1_Principal = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtCodigo = new HLP.Comum.Components.HLP_TextBox();
            this.txtcBanco = new HLP.Comum.Components.HLP_TextBox();
            this.txtxBanco = new HLP.Comum.Components.HLP_TextBox();
            this.txtxBancoResumido = new HLP.Comum.Components.HLP_TextBox();
            this.txtxLinkLogo = new HLP.Comum.Components.HLP_TextBox();
            this.nudvDxMais = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudvDxMenos = new HLP.Comum.Components.HLP_NumericUpDown();
            this.kryptonTabControl1 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kryptonPanel1 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.tabHierarquia = new System.Windows.Forms.TabPage();
            this.kryptonPanel4 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.treeHierarquia = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.async_work = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).BeginInit();
            this.panelPadrao.SuspendLayout();
            this.Principal.SuspendLayout();
            this.kryptonTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.kryptonPanel1.SuspendLayout();
            this.tabHierarquia.SuspendLayout();
            this.kryptonPanel4.SuspendLayout();
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
            this.Principal.Controls.Add(this.hlP_LabelSeparator1_Principal);
            this.Principal.Controls.Add(this.txtCodigo);
            this.Principal.Controls.Add(this.txtcBanco);
            this.Principal.Controls.Add(this.txtxBanco);
            this.Principal.Controls.Add(this.txtxBancoResumido);
            this.Principal.Controls.Add(this.txtxLinkLogo);
            this.Principal.Controls.Add(this.nudvDxMais);
            this.Principal.Controls.Add(this.nudvDxMenos);
            this.Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Principal.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Principal.Location = new System.Drawing.Point(0, 0);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(607, 225);
            this.Principal.TabIndex = 1;
            this.Principal.Tag = "Principal";
            // 
            // hlP_LabelSeparator1_Principal
            // 
            this.hlP_LabelSeparator1_Principal._LabelText = "Principal";
            this.hlP_LabelSeparator1_Principal._TamanhoMaiorLabel = 0;
            this.hlP_LabelSeparator1_Principal.BackColor = System.Drawing.Color.Transparent;
            this.hlP_LabelSeparator1_Principal.Location = new System.Drawing.Point(3, 3);
            this.hlP_LabelSeparator1_Principal.Name = "hlP_LabelSeparator1_Principal";
            this.hlP_LabelSeparator1_Principal.Size = new System.Drawing.Size(376, 18);
            this.hlP_LabelSeparator1_Principal.TabIndex = 12;
            this.hlP_LabelSeparator1_Principal.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo._Field = "idBanco";
            this.txtCodigo._LabelGroup = this.hlP_LabelSeparator1_Principal;
            this.txtCodigo._LabelText = "Código";
            this.txtCodigo._Multiline = false;
            this.txtCodigo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtCodigo._Password = false;
            this.txtCodigo._Regex = null;
            this.txtCodigo._Table = "Banco";
            this.txtCodigo._TamanhoComponente = 72;
            this.txtCodigo._TamanhoMaiorLabel = 120;
            this.txtCodigo._Visible = true;
            this.txtCodigo.BackColor = System.Drawing.Color.Transparent;
            this.txtCodigo.Base = null;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCodigo.Color = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(78, 27);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(78, 3, 15, 3);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(117, 21);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtcBanco
            // 
            this.txtcBanco._Field = "cBanco";
            this.txtcBanco._LabelGroup = this.hlP_LabelSeparator1_Principal;
            this.txtcBanco._LabelText = "Código do banco";
            this.txtcBanco._Multiline = false;
            this.txtcBanco._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtcBanco._Password = false;
            this.txtcBanco._Regex = null;
            this.txtcBanco._Table = "Banco";
            this.txtcBanco._TamanhoComponente = 121;
            this.txtcBanco._TamanhoMaiorLabel = 120;
            this.txtcBanco._Visible = true;
            this.txtcBanco.BackColor = System.Drawing.Color.Transparent;
            this.txtcBanco.Base = null;
            this.txtcBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtcBanco.Color = System.Drawing.Color.White;
            this.txtcBanco.Location = new System.Drawing.Point(26, 54);
            this.txtcBanco.Margin = new System.Windows.Forms.Padding(26, 3, 15, 3);
            this.txtcBanco.MaxLength = 32767;
            this.txtcBanco.Name = "txtcBanco";
            this.txtcBanco.ReadOnly = false;
            this.txtcBanco.Size = new System.Drawing.Size(218, 21);
            this.txtcBanco.TabIndex = 7;
            // 
            // txtxBanco
            // 
            this.txtxBanco._Field = "xBanco";
            this.txtxBanco._LabelGroup = this.hlP_LabelSeparator1_Principal;
            this.txtxBanco._LabelText = "Nome";
            this.txtxBanco._Multiline = false;
            this.txtxBanco._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxBanco._Password = false;
            this.txtxBanco._Regex = null;
            this.txtxBanco._Table = "Banco";
            this.txtxBanco._TamanhoComponente = 256;
            this.txtxBanco._TamanhoMaiorLabel = 120;
            this.txtxBanco._Visible = true;
            this.txtxBanco.BackColor = System.Drawing.Color.Transparent;
            this.txtxBanco.Base = null;
            this.txtxBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxBanco.Color = System.Drawing.Color.White;
            this.txtxBanco.Location = new System.Drawing.Point(86, 81);
            this.txtxBanco.Margin = new System.Windows.Forms.Padding(86, 3, 15, 3);
            this.txtxBanco.MaxLength = 32767;
            this.txtxBanco.Name = "txtxBanco";
            this.txtxBanco.ReadOnly = false;
            this.txtxBanco.Size = new System.Drawing.Size(293, 21);
            this.txtxBanco.TabIndex = 3;
            // 
            // txtxBancoResumido
            // 
            this.txtxBancoResumido._Field = "xBancoResumido";
            this.txtxBancoResumido._LabelGroup = this.hlP_LabelSeparator1_Principal;
            this.txtxBancoResumido._LabelText = "Nome resumido";
            this.txtxBancoResumido._Multiline = false;
            this.txtxBancoResumido._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxBancoResumido._Password = false;
            this.txtxBancoResumido._Regex = null;
            this.txtxBancoResumido._Table = "Banco";
            this.txtxBancoResumido._TamanhoComponente = 256;
            this.txtxBancoResumido._TamanhoMaiorLabel = 120;
            this.txtxBancoResumido._Visible = true;
            this.txtxBancoResumido.BackColor = System.Drawing.Color.Transparent;
            this.txtxBancoResumido.Base = null;
            this.txtxBancoResumido.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxBancoResumido.Color = System.Drawing.Color.White;
            this.txtxBancoResumido.Location = new System.Drawing.Point(35, 108);
            this.txtxBancoResumido.Margin = new System.Windows.Forms.Padding(35, 3, 15, 3);
            this.txtxBancoResumido.MaxLength = 32767;
            this.txtxBancoResumido.Name = "txtxBancoResumido";
            this.txtxBancoResumido.ReadOnly = false;
            this.txtxBancoResumido.Size = new System.Drawing.Size(344, 21);
            this.txtxBancoResumido.TabIndex = 5;
            // 
            // txtxLinkLogo
            // 
            this.txtxLinkLogo._Field = "xLinkLogo";
            this.txtxLinkLogo._LabelGroup = this.hlP_LabelSeparator1_Principal;
            this.txtxLinkLogo._LabelText = "Logotipo";
            this.txtxLinkLogo._Multiline = false;
            this.txtxLinkLogo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxLinkLogo._Password = false;
            this.txtxLinkLogo._Regex = null;
            this.txtxLinkLogo._Table = "Banco";
            this.txtxLinkLogo._TamanhoComponente = 256;
            this.txtxLinkLogo._TamanhoMaiorLabel = 120;
            this.txtxLinkLogo._Visible = true;
            this.txtxLinkLogo.BackColor = System.Drawing.Color.Transparent;
            this.txtxLinkLogo.Base = null;
            this.txtxLinkLogo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxLinkLogo.Color = System.Drawing.Color.White;
            this.txtxLinkLogo.Location = new System.Drawing.Point(69, 135);
            this.txtxLinkLogo.Margin = new System.Windows.Forms.Padding(69, 3, 15, 3);
            this.txtxLinkLogo.MaxLength = 32767;
            this.txtxLinkLogo.Name = "txtxLinkLogo";
            this.txtxLinkLogo.ReadOnly = true;
            this.txtxLinkLogo.Size = new System.Drawing.Size(310, 21);
            this.txtxLinkLogo.TabIndex = 3;
            // 
            // nudvDxMais
            // 
            this.nudvDxMais._Field = "vDxMais";
            this.nudvDxMais._LabelGroup = this.hlP_LabelSeparator1_Principal;
            this.nudvDxMais._LabelText = "D+";
            this.nudvDxMais._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudvDxMais._Regex = null;
            this.nudvDxMais._Table = "Banco";
            this.nudvDxMais._TamanhoComponente = 121;
            this.nudvDxMais._TamanhoMaiorLabel = 120;
            this.nudvDxMais._Visible = true;
            this.nudvDxMais.BackColor = System.Drawing.Color.Transparent;
            this.nudvDxMais.Base = null;
            this.nudvDxMais.Color = System.Drawing.Color.White;
            this.nudvDxMais.DecimalPlaces = 2;
            this.nudvDxMais.Location = new System.Drawing.Point(100, 162);
            this.nudvDxMais.Margin = new System.Windows.Forms.Padding(100, 3, 15, 3);
            this.nudvDxMais.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudvDxMais.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudvDxMais.Name = "nudvDxMais";
            this.nudvDxMais.ReadOnly = false;
            this.nudvDxMais.Size = new System.Drawing.Size(144, 22);
            this.nudvDxMais.TabIndex = 4;
            this.nudvDxMais.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudvDxMais.ValueInt = 0;
            // 
            // nudvDxMenos
            // 
            this.nudvDxMenos._Field = "vDxMenos";
            this.nudvDxMenos._LabelGroup = this.hlP_LabelSeparator1_Principal;
            this.nudvDxMenos._LabelText = "D-";
            this.nudvDxMenos._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudvDxMenos._Regex = null;
            this.nudvDxMenos._Table = "Banco";
            this.nudvDxMenos._TamanhoComponente = 121;
            this.nudvDxMenos._TamanhoMaiorLabel = 120;
            this.nudvDxMenos._Visible = true;
            this.nudvDxMenos.BackColor = System.Drawing.Color.Transparent;
            this.nudvDxMenos.Base = null;
            this.nudvDxMenos.Color = System.Drawing.Color.White;
            this.nudvDxMenos.DecimalPlaces = 2;
            this.nudvDxMenos.Location = new System.Drawing.Point(104, 190);
            this.nudvDxMenos.Margin = new System.Windows.Forms.Padding(104, 3, 15, 3);
            this.nudvDxMenos.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudvDxMenos.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudvDxMenos.Name = "nudvDxMenos";
            this.nudvDxMenos.ReadOnly = false;
            this.nudvDxMenos.Size = new System.Drawing.Size(140, 22);
            this.nudvDxMenos.TabIndex = 6;
            this.nudvDxMenos.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudvDxMenos.ValueInt = 0;
            // 
            // kryptonTabControl1
            // 
            this.kryptonTabControl1.AllowCloseButton = false;
            this.kryptonTabControl1.AllowContextButton = true;
            this.kryptonTabControl1.AllowNavigatorButtons = false;
            this.kryptonTabControl1.AllowSelectedTabHigh = false;
            this.kryptonTabControl1.BorderWidth = 1;
            this.kryptonTabControl1.Controls.Add(this.tabPage1);
            this.kryptonTabControl1.Controls.Add(this.tabHierarquia);
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
            this.kryptonTabControl1.SelectedIndexChanged += new System.EventHandler(this.kryptonTabControl1_SelectedIndexChanged);
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
            // tabHierarquia
            // 
            this.tabHierarquia.BackColor = System.Drawing.SystemColors.Window;
            this.tabHierarquia.Controls.Add(this.kryptonPanel4);
            this.tabHierarquia.Location = new System.Drawing.Point(4, 25);
            this.tabHierarquia.Margin = new System.Windows.Forms.Padding(0);
            this.tabHierarquia.Name = "tabHierarquia";
            this.tabHierarquia.Size = new System.Drawing.Size(607, 225);
            this.tabHierarquia.TabIndex = 3;
            this.tabHierarquia.Tag = false;
            this.tabHierarquia.Text = "Hierarquia";
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.BorderWidth = 0;
            this.kryptonPanel4.Controls.Add(this.treeHierarquia);
            this.kryptonPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel4.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.kryptonPanel4.GradientToogleColors = false;
            this.kryptonPanel4.GradientUseBlend = false;
            this.kryptonPanel4.GradientUseSolid = true;
            this.kryptonPanel4.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.PersistentColors = false;
            this.kryptonPanel4.Size = new System.Drawing.Size(607, 225);
            this.kryptonPanel4.TabIndex = 3;
            // 
            // treeHierarquia
            // 
            this.treeHierarquia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeHierarquia.ImageIndex = 0;
            this.treeHierarquia.ImageList = this.imageList1;
            this.treeHierarquia.ItemHeight = 21;
            this.treeHierarquia.Location = new System.Drawing.Point(0, 0);
            this.treeHierarquia.Name = "treeHierarquia";
            this.treeHierarquia.SelectedImageIndex = 0;
            this.treeHierarquia.Size = new System.Drawing.Size(607, 225);
            this.treeHierarquia.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1348490257_Bank.png");
            this.imageList1.Images.SetKeyName(1, "go_home.ico");
            this.imageList1.Images.SetKeyName(2, "money.ico");
            // 
            // async_work
            // 
            this.async_work.WorkerSupportsCancellation = true;
            this.async_work.DoWork += new System.ComponentModel.DoWorkEventHandler(this.async_work_DoWork);
            // 
            // FormBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 311);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBanco";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = -10;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Text = "Bancos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBanco_FormClosing);
            this.Load += new System.EventHandler(this.FormBanco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).EndInit();
            this.panelPadrao.ResumeLayout(false);
            this.Principal.ResumeLayout(false);
            this.kryptonTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.kryptonPanel1.ResumeLayout(false);
            this.tabHierarquia.ResumeLayout(false);
            this.kryptonPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Principal;
        private Comum.Components.HLP_TextBox txtCodigo;
        private Comum.Components.HLP_NumericUpDown nudvDxMais;
        private Comum.Components.HLP_TextBox txtxBanco;
        private Comum.Components.HLP_TextBox txtxLinkLogo;
        private Comum.Components.HLP_TextBox txtxBancoResumido;
        private Comum.Components.HLP_NumericUpDown nudvDxMenos;
        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.TabPage tabHierarquia;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel4;
        private System.Windows.Forms.ImageList imageList1;
        private Comum.Components.HLP_TextBox txtcBanco;
        private TreeView treeHierarquia;
        private System.ComponentModel.BackgroundWorker async_work;
        private Comum.Components.HLP_LabelSeparator hlP_LabelSeparator1_Principal;
    }
}