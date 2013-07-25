namespace HLP.UI.Entries.Comercial
{
    partial class FormCanalVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCanalVenda));
            this.Principal = new System.Windows.Forms.FlowLayoutPanel();
            this.hlP_LabelSeparator1 = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtCodigo = new HLP.Comum.Components.HLP_TextBox();
            this.txtcCanalVenda = new HLP.Comum.Components.HLP_TextBox();
            this.txtxCanalVenda = new HLP.Comum.Components.HLP_TextBox();
            this.kryptonTabControl1 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).BeginInit();
            this.panelPadrao.SuspendLayout();
            this.Principal.SuspendLayout();
            this.kryptonTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
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
            this.Principal.Controls.Add(this.hlP_LabelSeparator1);
            this.Principal.Controls.Add(this.txtCodigo);
            this.Principal.Controls.Add(this.txtcCanalVenda);
            this.Principal.Controls.Add(this.txtxCanalVenda);
            this.Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Principal.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Principal.Location = new System.Drawing.Point(0, 0);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(607, 225);
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
            this.hlP_LabelSeparator1.Size = new System.Drawing.Size(300, 18);
            this.hlP_LabelSeparator1.TabIndex = 4;
            this.hlP_LabelSeparator1.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo._Field = "idCanalVenda";
            this.txtCodigo._Help = "Chave principal do registro canal de vendas";
            this.txtCodigo._LabelGroup = this.hlP_LabelSeparator1;
            this.txtCodigo._LabelText = "Código";
            this.txtCodigo._Multiline = false;
            this.txtCodigo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtCodigo._Password = false;
            this.txtCodigo._Regex = null;
            this.txtCodigo._Table = "Canal_venda";
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
            // txtcCanalVenda
            // 
            this.txtcCanalVenda._Field = "cCanalVenda";
            this.txtcCanalVenda._Help = "Digite um código para o canal de vendas";
            this.txtcCanalVenda._LabelGroup = this.hlP_LabelSeparator1;
            this.txtcCanalVenda._LabelText = "Código do canal de venda";
            this.txtcCanalVenda._Multiline = false;
            this.txtcCanalVenda._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtcCanalVenda._Password = false;
            this.txtcCanalVenda._Regex = null;
            this.txtcCanalVenda._Table = "Canal_venda";
            this.txtcCanalVenda._TamanhoComponente = 107;
            this.txtcCanalVenda._TamanhoMaiorLabel = 150;
            this.txtcCanalVenda._Visible = true;
            this.txtcCanalVenda.BackColor = System.Drawing.Color.Transparent;
            this.txtcCanalVenda.Base = null;
            this.txtcCanalVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtcCanalVenda.Color = System.Drawing.Color.White;
            this.txtcCanalVenda.Location = new System.Drawing.Point(11, 54);
            this.txtcCanalVenda.Margin = new System.Windows.Forms.Padding(11, 3, 15, 3);
            this.txtcCanalVenda.MaxLength = 32767;
            this.txtcCanalVenda.Name = "txtcCanalVenda";
            this.txtcCanalVenda.ReadOnly = false;
            this.txtcCanalVenda.Size = new System.Drawing.Size(249, 21);
            this.txtcCanalVenda.TabIndex = 3;
            // 
            // txtxCanalVenda
            // 
            this.txtxCanalVenda._Field = "xCanalVenda";
            this.txtxCanalVenda._Help = "Descrição detalhada do canal de vendas ";
            this.txtxCanalVenda._LabelGroup = this.hlP_LabelSeparator1;
            this.txtxCanalVenda._LabelText = "Descrição ";
            this.txtxCanalVenda._Multiline = false;
            this.txtxCanalVenda._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxCanalVenda._Password = false;
            this.txtxCanalVenda._Regex = null;
            this.txtxCanalVenda._Table = "Canal_venda";
            this.txtxCanalVenda._TamanhoComponente = 278;
            this.txtxCanalVenda._TamanhoMaiorLabel = 150;
            this.txtxCanalVenda._Visible = true;
            this.txtxCanalVenda.BackColor = System.Drawing.Color.Transparent;
            this.txtxCanalVenda.Base = null;
            this.txtxCanalVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxCanalVenda.Color = System.Drawing.Color.White;
            this.txtxCanalVenda.Location = new System.Drawing.Point(94, 81);
            this.txtxCanalVenda.Margin = new System.Windows.Forms.Padding(94, 3, 15, 3);
            this.txtxCanalVenda.MaxLength = 10;
            this.txtxCanalVenda.Name = "txtxCanalVenda";
            this.txtxCanalVenda.ReadOnly = false;
            this.txtxCanalVenda.Size = new System.Drawing.Size(337, 21);
            this.txtxCanalVenda.TabIndex = 2;
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
            this.tabPage1.Size = new System.Drawing.Size(607, 225);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = false;
            this.tabPage1.Text = "Principal";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.Principal);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(607, 225);
            this.kryptonPanel1.TabIndex = 2;
            // 
            // FormCanalVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 311);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCanalVenda";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = -10;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text = "Canais de Venda";
            this.Load += new System.EventHandler(this.FormCanalVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).EndInit();
            this.panelPadrao.ResumeLayout(false);
            this.Principal.ResumeLayout(false);
            this.kryptonTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Principal;
        private Comum.Components.HLP_TextBox txtCodigo;
        private Comum.Components.HLP_TextBox txtcCanalVenda;
        private Comum.Components.HLP_TextBox txtxCanalVenda;
        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Comum.Components.HLP_LabelSeparator hlP_LabelSeparator1;
    }
}