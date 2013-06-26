namespace HLP.UI.Entries.Geral
{
    partial class FormCidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCidade));
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.hlP_LabelSeparator1 = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtCodigo = new HLP.Comum.Components.HLP_TextBox();
            this.txtxCidade = new HLP.Comum.Components.HLP_TextBox();
            this.nudcIbge = new HLP.Comum.Components.HLP_NumericUpDown();
            this.cboidUf = new HLP.Comum.Components.HLP_ComboBox();
            this.kryptonTabControl1 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kryptonPanel1 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).BeginInit();
            this.panelPadrao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.kryptonTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(630, 298);
            // 
            // panelPadrao
            // 
            this.panelPadrao.Controls.Add(this.kryptonTabControl1);
            this.panelPadrao.Size = new System.Drawing.Size(628, 274);
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 27);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(630, 298);
            this.kryptonPanel.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.hlP_LabelSeparator1);
            this.flowLayoutPanel1.Controls.Add(this.txtCodigo);
            this.flowLayoutPanel1.Controls.Add(this.txtxCidade);
            this.flowLayoutPanel1.Controls.Add(this.nudcIbge);
            this.flowLayoutPanel1.Controls.Add(this.cboidUf);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(614, 239);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Tag = "Principal";
            // 
            // hlP_LabelSeparator1
            // 
            this.hlP_LabelSeparator1._LabelText = "Geral";
            this.hlP_LabelSeparator1._TamanhoMaiorLabel = 0;
            this.hlP_LabelSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.hlP_LabelSeparator1.Location = new System.Drawing.Point(3, 3);
            this.hlP_LabelSeparator1.Name = "hlP_LabelSeparator1";
            this.hlP_LabelSeparator1.Size = new System.Drawing.Size(384, 18);
            this.hlP_LabelSeparator1.TabIndex = 7;
            this.hlP_LabelSeparator1.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo._Field = "idCidade";
            this.txtCodigo._Help = "É preenchido automaticamente pelo sistema com um código sequencial.";
            this.txtCodigo._LabelGroup = this.hlP_LabelSeparator1;
            this.txtCodigo._LabelText = "Código";
            this.txtCodigo._Multiline = false;
            this.txtCodigo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtCodigo._Password = false;
            this.txtCodigo._Regex = null;
            this.txtCodigo._Table = "Cidade";
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
            this.txtCodigo.TabIndex = 2;
            // 
            // txtxCidade
            // 
            this.txtxCidade._Field = "xCidade";
            this.txtxCidade._Help = "É preenchido com o nome da cidade que está sendo cadastrada.";
            this.txtxCidade._LabelGroup = this.hlP_LabelSeparator1;
            this.txtxCidade._LabelText = "Nome";
            this.txtxCidade._Multiline = false;
            this.txtxCidade._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxCidade._Password = false;
            this.txtxCidade._Regex = null;
            this.txtxCidade._Table = "Cidade";
            this.txtxCidade._TamanhoComponente = 234;
            this.txtxCidade._TamanhoMaiorLabel = 150;
            this.txtxCidade._Visible = false;
            this.txtxCidade.BackColor = System.Drawing.Color.Transparent;
            this.txtxCidade.Base = null;
            this.txtxCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxCidade.Color = System.Drawing.Color.White;
            this.txtxCidade.Location = new System.Drawing.Point(116, 54);
            this.txtxCidade.Margin = new System.Windows.Forms.Padding(116, 3, 15, 3);
            this.txtxCidade.MaxLength = 32767;
            this.txtxCidade.Name = "txtxCidade";
            this.txtxCidade.ReadOnly = false;
            this.txtxCidade.Size = new System.Drawing.Size(271, 21);
            this.txtxCidade.TabIndex = 3;
            // 
            // nudcIbge
            // 
            this.nudcIbge._Field = "cIbge";
            this.nudcIbge._Help = "Código nacional de cidades utilizado pelo ibge";
            this.nudcIbge._LabelGroup = this.hlP_LabelSeparator1;
            this.nudcIbge._LabelText = "Código ibge";
            this.nudcIbge._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudcIbge._Regex = null;
            this.nudcIbge._Table = "Cidade";
            this.nudcIbge._TamanhoComponente = 122;
            this.nudcIbge._TamanhoMaiorLabel = 150;
            this.nudcIbge._Visible = false;
            this.nudcIbge.BackColor = System.Drawing.Color.Transparent;
            this.nudcIbge.Base = null;
            this.nudcIbge.Color = System.Drawing.Color.White;
            this.nudcIbge.DecimalPlaces = 2;
            this.nudcIbge.Location = new System.Drawing.Point(82, 81);
            this.nudcIbge.Margin = new System.Windows.Forms.Padding(82, 3, 15, 3);
            this.nudcIbge.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudcIbge.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudcIbge.Name = "nudcIbge";
            this.nudcIbge.ReadOnly = false;
            this.nudcIbge.Size = new System.Drawing.Size(193, 22);
            this.nudcIbge.TabIndex = 5;
            this.nudcIbge.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudcIbge.ValueInt = 0;
            // 
            // cboidUf
            // 
            this.cboidUf._Field = "idUF";
            this.cboidUf._Help = "Preenchido com a sigla do estado a que a cidade pertence. ";
            this.cboidUf._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cboidUf._Itens")));
            this.cboidUf._LabelGroup = this.hlP_LabelSeparator1;
            this.cboidUf._LabelText = "Uf";
            this.cboidUf._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cboidUf._Regex = null;
            this.cboidUf._situacao = false;
            this.cboidUf._Table = "Cidade";
            this.cboidUf._TamanhoComponente = 83;
            this.cboidUf._TamanhoMaiorLabel = 150;
            this.cboidUf._Visible = false;
            this.cboidUf.BackColor = System.Drawing.Color.Transparent;
            this.cboidUf.Base = null;
            this.cboidUf.Color = System.Drawing.Color.White;
            this.cboidUf.DataSource = null;
            this.cboidUf.DisplayMember = "xSiglaUf";
            this.cboidUf.Location = new System.Drawing.Point(134, 109);
            this.cboidUf.Margin = new System.Windows.Forms.Padding(134, 3, 15, 3);
            this.cboidUf.Name = "cboidUf";
            this.cboidUf.SelectedIndex = -1;
            this.cboidUf.SelectedValue = 0;
            this.cboidUf.Size = new System.Drawing.Size(102, 21);
            this.cboidUf.TabIndex = 6;
            this.cboidUf.ValueMember = "ID";
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
            this.kryptonTabControl1.Size = new System.Drawing.Size(622, 268);
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
            this.tabPage1.Size = new System.Drawing.Size(614, 239);
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
            this.kryptonPanel1.Size = new System.Drawing.Size(614, 239);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // FormCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 325);
            this.Controls.Add(this.kryptonPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCidade";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = -10;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text = "Cidades";
            this.Load += new System.EventHandler(this.FormCidade_Load);
            this.Controls.SetChildIndex(this.kryptonPanel, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).EndInit();
            this.panelPadrao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.kryptonTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.kryptonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Comum.Components.HLP_TextBox txtCodigo;
        private Comum.Components.HLP_TextBox txtxCidade;
        private Comum.Components.HLP_NumericUpDown nudcIbge;
        private Comum.Components.HLP_ComboBox cboidUf;
        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel1;
        private Comum.Components.HLP_LabelSeparator hlP_LabelSeparator1;
    }
}

