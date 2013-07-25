namespace HLP.UI.Entries.RecursosHumanos
{
    partial class FormSetor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSetor));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.hlP_LabelSeparator1_Geral = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtCodigo = new HLP.Comum.Components.HLP_TextBox();
            this.txtxSetor = new HLP.Comum.Components.HLP_TextBox();
            this.txtxDescricao = new HLP.Comum.Components.HLP_TextBox();
            this.txtxEmail = new HLP.Comum.Components.HLP_TextBox();
            this.kryptonTabControl1 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kryptonPanel1 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.tpHierarquia = new System.Windows.Forms.TabPage();
            this.tvHierarquia = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bwPrincipal = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).BeginInit();
            this.panelPadrao.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.kryptonTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.kryptonPanel1.SuspendLayout();
            this.tpHierarquia.SuspendLayout();
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.hlP_LabelSeparator1_Geral);
            this.flowLayoutPanel1.Controls.Add(this.txtCodigo);
            this.flowLayoutPanel1.Controls.Add(this.txtxSetor);
            this.flowLayoutPanel1.Controls.Add(this.txtxDescricao);
            this.flowLayoutPanel1.Controls.Add(this.txtxEmail);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(607, 225);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Tag = "Principal";
            // 
            // hlP_LabelSeparator1_Geral
            // 
            this.hlP_LabelSeparator1_Geral._LabelText = "Geral";
            this.hlP_LabelSeparator1_Geral._TamanhoMaiorLabel = 0;
            this.hlP_LabelSeparator1_Geral.BackColor = System.Drawing.Color.Transparent;
            this.hlP_LabelSeparator1_Geral.Location = new System.Drawing.Point(0, 3);
            this.hlP_LabelSeparator1_Geral.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.hlP_LabelSeparator1_Geral.Name = "hlP_LabelSeparator1_Geral";
            this.hlP_LabelSeparator1_Geral.Size = new System.Drawing.Size(209, 18);
            this.hlP_LabelSeparator1_Geral.TabIndex = 31;
            this.hlP_LabelSeparator1_Geral.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo._Field = "idSetor";
            this.txtCodigo._Help = "Chave principal do registro setor";
            this.txtCodigo._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtCodigo._LabelText = "Código";
            this.txtCodigo._Multiline = false;
            this.txtCodigo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtCodigo._Password = false;
            this.txtCodigo._Regex = null;
            this.txtCodigo._Table = "Setor";
            this.txtCodigo._TamanhoComponente = 107;
            this.txtCodigo._TamanhoMaiorLabel = 100;
            this.txtCodigo._Visible = true;
            this.txtCodigo.BackColor = System.Drawing.Color.Transparent;
            this.txtCodigo.Base = null;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCodigo.Color = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(58, 27);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(58, 3, 15, 3);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(152, 21);
            this.txtCodigo.TabIndex = 2;
            // 
            // txtxSetor
            // 
            this.txtxSetor._Field = "xSetor";
            this.txtxSetor._Help = "Informar um código para o setor";
            this.txtxSetor._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtxSetor._LabelText = "Código do setor";
            this.txtxSetor._Multiline = false;
            this.txtxSetor._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxSetor._Password = false;
            this.txtxSetor._Regex = null;
            this.txtxSetor._Table = "Setor";
            this.txtxSetor._TamanhoComponente = 134;
            this.txtxSetor._TamanhoMaiorLabel = 100;
            this.txtxSetor._Visible = true;
            this.txtxSetor.BackColor = System.Drawing.Color.Transparent;
            this.txtxSetor.Base = null;
            this.txtxSetor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxSetor.Color = System.Drawing.Color.White;
            this.txtxSetor.Location = new System.Drawing.Point(12, 54);
            this.txtxSetor.Margin = new System.Windows.Forms.Padding(12, 3, 15, 3);
            this.txtxSetor.MaxLength = 32767;
            this.txtxSetor.Name = "txtxSetor";
            this.txtxSetor.ReadOnly = false;
            this.txtxSetor.Size = new System.Drawing.Size(225, 21);
            this.txtxSetor.TabIndex = 4;
            // 
            // txtxDescricao
            // 
            this.txtxDescricao._Field = "xDescricao";
            this.txtxDescricao._Help = "Informar uma descrição mais detalhada do setor da empresa";
            this.txtxDescricao._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtxDescricao._LabelText = "Descrição";
            this.txtxDescricao._Multiline = false;
            this.txtxDescricao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxDescricao._Password = false;
            this.txtxDescricao._Regex = null;
            this.txtxDescricao._Table = "Setor";
            this.txtxDescricao._TamanhoComponente = 344;
            this.txtxDescricao._TamanhoMaiorLabel = 100;
            this.txtxDescricao._Visible = true;
            this.txtxDescricao.BackColor = System.Drawing.Color.Transparent;
            this.txtxDescricao.Base = null;
            this.txtxDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxDescricao.Color = System.Drawing.Color.White;
            this.txtxDescricao.Location = new System.Drawing.Point(47, 81);
            this.txtxDescricao.Margin = new System.Windows.Forms.Padding(47, 3, 15, 3);
            this.txtxDescricao.MaxLength = 32767;
            this.txtxDescricao.Name = "txtxDescricao";
            this.txtxDescricao.ReadOnly = false;
            this.txtxDescricao.Size = new System.Drawing.Size(400, 21);
            this.txtxDescricao.TabIndex = 5;
            // 
            // txtxEmail
            // 
            this.txtxEmail._Field = "xEmail";
            this.txtxEmail._Help = "Informar um e-mail geral caso tenha do setor";
            this.txtxEmail._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtxEmail._LabelText = "E-mail";
            this.txtxEmail._Multiline = false;
            this.txtxEmail._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxEmail._Password = false;
            this.txtxEmail._Regex = "\\w+([-+.\']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            this.txtxEmail._Table = "Setor";
            this.txtxEmail._TamanhoComponente = 131;
            this.txtxEmail._TamanhoMaiorLabel = 100;
            this.txtxEmail._Visible = true;
            this.txtxEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtxEmail.Base = null;
            this.txtxEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxEmail.Color = System.Drawing.Color.White;
            this.txtxEmail.Location = new System.Drawing.Point(65, 108);
            this.txtxEmail.Margin = new System.Windows.Forms.Padding(65, 3, 15, 3);
            this.txtxEmail.MaxLength = 32767;
            this.txtxEmail.Name = "txtxEmail";
            this.txtxEmail.ReadOnly = false;
            this.txtxEmail.Size = new System.Drawing.Size(169, 21);
            this.txtxEmail.TabIndex = 3;
            // 
            // kryptonTabControl1
            // 
            this.kryptonTabControl1.AllowCloseButton = false;
            this.kryptonTabControl1.AllowContextButton = false;
            this.kryptonTabControl1.AllowNavigatorButtons = false;
            this.kryptonTabControl1.AllowSelectedTabHigh = false;
            this.kryptonTabControl1.BorderWidth = 1;
            this.kryptonTabControl1.Controls.Add(this.tabPage1);
            this.kryptonTabControl1.Controls.Add(this.tpHierarquia);
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
            this.kryptonPanel1.Controls.Add(this.flowLayoutPanel1);
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
            // tpHierarquia
            // 
            this.tpHierarquia.Controls.Add(this.tvHierarquia);
            this.tpHierarquia.Location = new System.Drawing.Point(4, 25);
            this.tpHierarquia.Margin = new System.Windows.Forms.Padding(0);
            this.tpHierarquia.Name = "tpHierarquia";
            this.tpHierarquia.Size = new System.Drawing.Size(804, 225);
            this.tpHierarquia.TabIndex = 1;
            this.tpHierarquia.Tag = false;
            this.tpHierarquia.Text = "Hierarquia";
            this.tpHierarquia.UseVisualStyleBackColor = true;
            // 
            // tvHierarquia
            // 
            this.tvHierarquia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvHierarquia.ImageIndex = 0;
            this.tvHierarquia.ImageList = this.imageList1;
            this.tvHierarquia.Location = new System.Drawing.Point(0, 0);
            this.tvHierarquia.Name = "tvHierarquia";
            this.tvHierarquia.SelectedImageIndex = 0;
            this.tvHierarquia.Size = new System.Drawing.Size(804, 225);
            this.tvHierarquia.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1346183365_Usercard_01.ico");
            this.imageList1.Images.SetKeyName(1, "Department 24.ico");
            // 
            // bwPrincipal
            // 
            this.bwPrincipal.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwPrincipal_DoWork);
            // 
            // FormSetor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 311);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSetor";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = -10;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text = "Setores";
            this.Load += new System.EventHandler(this.FormSetor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).EndInit();
            this.panelPadrao.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.kryptonTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.kryptonPanel1.ResumeLayout(false);
            this.tpHierarquia.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Comum.Components.HLP_TextBox txtCodigo;
        private Comum.Components.HLP_TextBox txtxEmail;
        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel1;
        private Comum.Components.HLP_TextBox txtxSetor;
        private Comum.Components.HLP_TextBox txtxDescricao;
        private Comum.Components.HLP_LabelSeparator hlP_LabelSeparator1_Geral;
        private System.ComponentModel.BackgroundWorker bwPrincipal;
        private System.Windows.Forms.TabPage tpHierarquia;
        private System.Windows.Forms.TreeView tvHierarquia;
        private System.Windows.Forms.ImageList imageList1;
    }
}