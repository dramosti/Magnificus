namespace HLP.UI.Entries.RecursosHumanos
{
    partial class FormDepartamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDepartamento));
            this.kryptonTabControl1 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kryptonPanel1 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.Principal = new System.Windows.Forms.FlowLayoutPanel();
            this.hlP_LabelSeparator1_Geral = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtCodigo = new HLP.Comum.Components.HLP_TextBox();
            this.txtxDepartamento = new HLP.Comum.Components.HLP_TextBox();
            this.txtxDescricao = new HLP.Comum.Components.HLP_TextBox();
            this.hlP_PesquisaidSetor = new HLP.Comum.Components.HLP_Pesquisa();
            this.txtxEmail = new HLP.Comum.Components.HLP_TextBox();
            this.tpHierarquia = new System.Windows.Forms.TabPage();
            this.tvHierarquia = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bwPrincipal = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).BeginInit();
            this.panelPadrao.SuspendLayout();
            this.kryptonTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.kryptonPanel1.SuspendLayout();
            this.Principal.SuspendLayout();
            this.tpHierarquia.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(677, 303);
            // 
            // panelPadrao
            // 
            this.panelPadrao.Controls.Add(this.kryptonTabControl1);
            this.panelPadrao.Size = new System.Drawing.Size(675, 279);
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
            this.kryptonTabControl1.Size = new System.Drawing.Size(669, 273);
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
            this.tabPage1.Size = new System.Drawing.Size(661, 244);
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
            this.kryptonPanel1.Size = new System.Drawing.Size(661, 244);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // Principal
            // 
            this.Principal.AutoScroll = true;
            this.Principal.BackColor = System.Drawing.Color.Transparent;
            this.Principal.Controls.Add(this.hlP_LabelSeparator1_Geral);
            this.Principal.Controls.Add(this.txtCodigo);
            this.Principal.Controls.Add(this.txtxDepartamento);
            this.Principal.Controls.Add(this.txtxDescricao);
            this.Principal.Controls.Add(this.hlP_PesquisaidSetor);
            this.Principal.Controls.Add(this.txtxEmail);
            this.Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Principal.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Principal.Location = new System.Drawing.Point(0, 0);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(661, 244);
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
            this.hlP_LabelSeparator1_Geral.Size = new System.Drawing.Size(209, 18);
            this.hlP_LabelSeparator1_Geral.TabIndex = 31;
            this.hlP_LabelSeparator1_Geral.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo._Field = "idDepartamento";
            this.txtCodigo._Help = "Chave principal do registro departamento";
            this.txtCodigo._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtCodigo._LabelText = "Código";
            this.txtCodigo._Multiline = false;
            this.txtCodigo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.SIM;
            this.txtCodigo._Password = false;
            this.txtCodigo._Regex = null;
            this.txtCodigo._Table = "Departamento";
            this.txtCodigo._TamanhoComponente = 107;
            this.txtCodigo._TamanhoMaiorLabel = 130;
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
            // txtxDepartamento
            // 
            this.txtxDepartamento._Field = "xDepartamento";
            this.txtxDepartamento._Help = "Informe um departamento de forma reduzida";
            this.txtxDepartamento._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtxDepartamento._LabelText = "Departamento";
            this.txtxDepartamento._Multiline = false;
            this.txtxDepartamento._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.SIM;
            this.txtxDepartamento._Password = false;
            this.txtxDepartamento._Regex = null;
            this.txtxDepartamento._Table = "Departamento";
            this.txtxDepartamento._TamanhoComponente = 222;
            this.txtxDepartamento._TamanhoMaiorLabel = 130;
            this.txtxDepartamento.BackColor = System.Drawing.Color.Transparent;
            this.txtxDepartamento.Base = null;
            this.txtxDepartamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxDepartamento.Color = System.Drawing.Color.White;
            this.txtxDepartamento.Location = new System.Drawing.Point(52, 54);
            this.txtxDepartamento.Margin = new System.Windows.Forms.Padding(52, 3, 15, 3);
            this.txtxDepartamento.MaxLength = 32767;
            this.txtxDepartamento.Name = "txtxDepartamento";
            this.txtxDepartamento.ReadOnly = false;
            this.txtxDepartamento.Size = new System.Drawing.Size(303, 21);
            this.txtxDepartamento.TabIndex = 3;
            // 
            // txtxDescricao
            // 
            this.txtxDescricao._Field = "xDescricao";
            this.txtxDescricao._Help = "Descrição do departamento";
            this.txtxDescricao._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtxDescricao._LabelText = "Descrição ";
            this.txtxDescricao._Multiline = false;
            this.txtxDescricao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.SIM;
            this.txtxDescricao._Password = false;
            this.txtxDescricao._Regex = null;
            this.txtxDescricao._Table = "Departamento";
            this.txtxDescricao._TamanhoComponente = 390;
            this.txtxDescricao._TamanhoMaiorLabel = 130;
            this.txtxDescricao.BackColor = System.Drawing.Color.Transparent;
            this.txtxDescricao.Base = null;
            this.txtxDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxDescricao.Color = System.Drawing.Color.White;
            this.txtxDescricao.Location = new System.Drawing.Point(74, 81);
            this.txtxDescricao.Margin = new System.Windows.Forms.Padding(74, 3, 15, 3);
            this.txtxDescricao.MaxLength = 10;
            this.txtxDescricao.Name = "txtxDescricao";
            this.txtxDescricao.ReadOnly = false;
            this.txtxDescricao.Size = new System.Drawing.Size(449, 21);
            this.txtxDescricao.TabIndex = 2;
            // 
            // hlP_PesquisaidSetor
            // 
            this.hlP_PesquisaidSetor._Field = "idSetor";
            this.hlP_PesquisaidSetor._Help = "Selecione um setor da empresa já cadastrado";
            this.hlP_PesquisaidSetor._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.hlP_PesquisaidSetor._LabelText = "Setor";
            this.hlP_PesquisaidSetor._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidSetor._ListaCamposDisplay")));
            this.hlP_PesquisaidSetor._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidSetor._ListaValoresDisplay")));
            this.hlP_PesquisaidSetor._NomeCampoPK = "ID";
            this.hlP_PesquisaidSetor._NomeFormCadastroOriginal = "FormSetor";
            this.hlP_PesquisaidSetor._NomeView = "vwSetor";
            this.hlP_PesquisaidSetor._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.SIM;
            this.hlP_PesquisaidSetor._Regex = null;
            this.hlP_PesquisaidSetor._Table = "Departamento";
            this.hlP_PesquisaidSetor._TamanhoComponente = 300;
            this.hlP_PesquisaidSetor._TamanhoMaiorLabel = 130;
            this.hlP_PesquisaidSetor._Vinculado = false;
            this.hlP_PesquisaidSetor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidSetor.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidSetor.Base = null;
            this.hlP_PesquisaidSetor.Location = new System.Drawing.Point(99, 108);
            this.hlP_PesquisaidSetor.Margin = new System.Windows.Forms.Padding(99, 3, 15, 3);
            this.hlP_PesquisaidSetor.Name = "hlP_PesquisaidSetor";
            this.hlP_PesquisaidSetor.ReadOnly = false;
            this.hlP_PesquisaidSetor.Size = new System.Drawing.Size(424, 21);
            this.hlP_PesquisaidSetor.TabIndex = 4;
            this.hlP_PesquisaidSetor.Value = 0;
            // 
            // txtxEmail
            // 
            this.txtxEmail._Field = "xEmail";
            this.txtxEmail._Help = "Informar o e-mail padrão para o departamento, caso haja";
            this.txtxEmail._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtxEmail._LabelText = "E-mail";
            this.txtxEmail._Multiline = false;
            this.txtxEmail._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.SIM;
            this.txtxEmail._Password = false;
            this.txtxEmail._Regex = "^\\w+([-+.\']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$";
            this.txtxEmail._Table = "Departamento";
            this.txtxEmail._TamanhoComponente = 222;
            this.txtxEmail._TamanhoMaiorLabel = 130;
            this.txtxEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtxEmail.Base = null;
            this.txtxEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxEmail.Color = System.Drawing.Color.White;
            this.txtxEmail.Location = new System.Drawing.Point(95, 135);
            this.txtxEmail.Margin = new System.Windows.Forms.Padding(95, 3, 15, 3);
            this.txtxEmail.MaxLength = 10;
            this.txtxEmail.Name = "txtxEmail";
            this.txtxEmail.ReadOnly = false;
            this.txtxEmail.Size = new System.Drawing.Size(260, 21);
            this.txtxEmail.TabIndex = 5;
            // 
            // tpHierarquia
            // 
            this.tpHierarquia.Controls.Add(this.tvHierarquia);
            this.tpHierarquia.Location = new System.Drawing.Point(4, 25);
            this.tpHierarquia.Margin = new System.Windows.Forms.Padding(0);
            this.tpHierarquia.Name = "tpHierarquia";
            this.tpHierarquia.Size = new System.Drawing.Size(661, 244);
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
            this.tvHierarquia.Size = new System.Drawing.Size(661, 244);
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
            // FormDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 330);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDepartamento";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = -10;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text = "Departamento";
            this.Load += new System.EventHandler(this.FormDepartamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).EndInit();
            this.panelPadrao.ResumeLayout(false);
            this.kryptonTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.kryptonPanel1.ResumeLayout(false);
            this.Principal.ResumeLayout(false);
            this.tpHierarquia.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.FlowLayoutPanel Principal;
        private Comum.Components.HLP_TextBox txtCodigo;
        private Comum.Components.HLP_TextBox txtxDepartamento;
        private Comum.Components.HLP_TextBox txtxDescricao;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidSetor;
        private Comum.Components.HLP_TextBox txtxEmail;
        private Comum.Components.HLP_LabelSeparator hlP_LabelSeparator1_Geral;
        private System.Windows.Forms.TabPage tpHierarquia;
        private System.Windows.Forms.TreeView tvHierarquia;
        private System.ComponentModel.BackgroundWorker bwPrincipal;
        private System.Windows.Forms.ImageList imageList1;
    }
}