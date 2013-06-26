namespace HLP.UI.Entries.Geral
{
    partial class FormRamoAtividade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRamoAtividade));
            this.Principal = new System.Windows.Forms.FlowLayoutPanel();
            this.hlP_LabelSeparator_Principal = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtCodigo = new HLP.Comum.Components.HLP_TextBox();
            this.nudxRamo = new HLP.Comum.Components.HLP_NumericUpDown();
            this.txtxDescricao = new HLP.Comum.Components.HLP_TextBox();
            this.txtxCnae = new HLP.Comum.Components.HLP_TextBox();
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
            this.Principal.Controls.Add(this.hlP_LabelSeparator_Principal);
            this.Principal.Controls.Add(this.txtCodigo);
            this.Principal.Controls.Add(this.nudxRamo);
            this.Principal.Controls.Add(this.txtxDescricao);
            this.Principal.Controls.Add(this.txtxCnae);
            this.Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Principal.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Principal.Location = new System.Drawing.Point(0, 0);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(607, 225);
            this.Principal.TabIndex = 1;
            this.Principal.Tag = "Principal";
            // 
            // hlP_LabelSeparator_Principal
            // 
            this.hlP_LabelSeparator_Principal._LabelText = "Geral";
            this.hlP_LabelSeparator_Principal._TamanhoMaiorLabel = 0;
            this.hlP_LabelSeparator_Principal.BackColor = System.Drawing.Color.Transparent;
            this.hlP_LabelSeparator_Principal.Location = new System.Drawing.Point(3, 3);
            this.hlP_LabelSeparator_Principal.Name = "hlP_LabelSeparator_Principal";
            this.hlP_LabelSeparator_Principal.Size = new System.Drawing.Size(372, 18);
            this.hlP_LabelSeparator_Principal.TabIndex = 5;
            this.hlP_LabelSeparator_Principal.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo._Field = "idRamoAtividade";
            this.txtCodigo._LabelGroup = this.hlP_LabelSeparator_Principal;
            this.txtCodigo._LabelText = "Código";
            this.txtCodigo._Multiline = false;
            this.txtCodigo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtCodigo._Password = false;
            this.txtCodigo._Regex = null;
            this.txtCodigo._Table = "Ramo_atividade";
            this.txtCodigo._TamanhoComponente = 107;
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
            this.txtCodigo.Size = new System.Drawing.Size(152, 21);
            this.txtCodigo.TabIndex = 0;
            // 
            // nudxRamo
            // 
            this.nudxRamo._Field = "xRamo";
            this.nudxRamo._Help = "Digite um código para o ramo de atividade ";
            this.nudxRamo._LabelGroup = this.hlP_LabelSeparator_Principal;
            this.nudxRamo._LabelText = "Ramo de atividade ";
            this.nudxRamo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudxRamo._Regex = null;
            this.nudxRamo._Table = "Ramo_atividade";
            this.nudxRamo._TamanhoComponente = 115;
            this.nudxRamo._TamanhoMaiorLabel = 150;
            this.nudxRamo._Visible = false;
            this.nudxRamo.BackColor = System.Drawing.Color.Transparent;
            this.nudxRamo.Base = null;
            this.nudxRamo.Color = System.Drawing.Color.White;
            this.nudxRamo.DecimalPlaces = 2;
            this.nudxRamo.Location = new System.Drawing.Point(48, 54);
            this.nudxRamo.Margin = new System.Windows.Forms.Padding(48, 3, 15, 3);
            this.nudxRamo.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudxRamo.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudxRamo.Name = "nudxRamo";
            this.nudxRamo.ReadOnly = false;
            this.nudxRamo.Size = new System.Drawing.Size(220, 22);
            this.nudxRamo.TabIndex = 4;
            this.nudxRamo.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudxRamo.ValueInt = 0;
            this.nudxRamo.Validating += new System.ComponentModel.CancelEventHandler(this.nudxRamo_Validating);
            // 
            // txtxDescricao
            // 
            this.txtxDescricao._Field = "xDescricao";
            this.txtxDescricao._Help = "Digite um nome resumido para o ramo de atividade";
            this.txtxDescricao._LabelGroup = this.hlP_LabelSeparator_Principal;
            this.txtxDescricao._LabelText = "Descrição";
            this.txtxDescricao._Multiline = false;
            this.txtxDescricao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxDescricao._Password = false;
            this.txtxDescricao._Regex = null;
            this.txtxDescricao._Table = "Ramo_atividade";
            this.txtxDescricao._TamanhoComponente = 222;
            this.txtxDescricao._TamanhoMaiorLabel = 150;
            this.txtxDescricao._Visible = false;
            this.txtxDescricao.BackColor = System.Drawing.Color.Transparent;
            this.txtxDescricao.Base = null;
            this.txtxDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxDescricao.Color = System.Drawing.Color.White;
            this.txtxDescricao.Location = new System.Drawing.Point(97, 82);
            this.txtxDescricao.Margin = new System.Windows.Forms.Padding(97, 3, 15, 3);
            this.txtxDescricao.MaxLength = 32767;
            this.txtxDescricao.Name = "txtxDescricao";
            this.txtxDescricao.ReadOnly = false;
            this.txtxDescricao.Size = new System.Drawing.Size(278, 21);
            this.txtxDescricao.TabIndex = 3;
            // 
            // txtxCnae
            // 
            this.txtxCnae._Field = "xCnae";
            this.txtxCnae._Help = "Informar a classificação nacional de atividades economicas";
            this.txtxCnae._LabelGroup = this.hlP_LabelSeparator_Principal;
            this.txtxCnae._LabelText = "Cnae";
            this.txtxCnae._Multiline = false;
            this.txtxCnae._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxCnae._Password = false;
            this.txtxCnae._Regex = null;
            this.txtxCnae._Table = "Ramo_atividade";
            this.txtxCnae._TamanhoComponente = 88;
            this.txtxCnae._TamanhoMaiorLabel = 150;
            this.txtxCnae._Visible = false;
            this.txtxCnae.BackColor = System.Drawing.Color.Transparent;
            this.txtxCnae.Base = null;
            this.txtxCnae.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxCnae.Color = System.Drawing.Color.White;
            this.txtxCnae.Location = new System.Drawing.Point(120, 109);
            this.txtxCnae.Margin = new System.Windows.Forms.Padding(120, 3, 15, 3);
            this.txtxCnae.MaxLength = 10;
            this.txtxCnae.Name = "txtxCnae";
            this.txtxCnae.ReadOnly = false;
            this.txtxCnae.Size = new System.Drawing.Size(121, 21);
            this.txtxCnae.TabIndex = 2;
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
            // FormRamoAtividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 311);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRamoAtividade";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = -10;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Text = "Ramos de Atividade";
            this.Load += new System.EventHandler(this.FormRamoAtividade_Load);
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
        private Comum.Components.HLP_NumericUpDown nudxRamo;
        private Comum.Components.HLP_TextBox txtxDescricao;
        private Comum.Components.HLP_TextBox txtxCnae;
        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel1;
        private Comum.Components.HLP_LabelSeparator hlP_LabelSeparator_Principal;
    }
}