namespace HLP.UI.Entries.Comercial
{
    partial class FormJuros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJuros));
            this.Principal = new System.Windows.Forms.FlowLayoutPanel();
            this.hlP_LabelSeparator1 = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtCodigo = new HLP.Comum.Components.HLP_TextBox();
            this.txtxNome = new HLP.Comum.Components.HLP_TextBox();
            this.txtxDescricao = new HLP.Comum.Components.HLP_TextBox();
            this.nudpJuros = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudnQuantidadeDiasMes = new HLP.Comum.Components.HLP_NumericUpDown();
            this.cbostDiaMes = new HLP.Comum.Components.HLP_ComboBox();
            this.nudnCarencia = new HLP.Comum.Components.HLP_NumericUpDown();
            this.kryptonTabControl1 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kryptonPanel1 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.button1 = new System.Windows.Forms.Button();
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
            this.Principal.Controls.Add(this.hlP_LabelSeparator1);
            this.Principal.Controls.Add(this.txtCodigo);
            this.Principal.Controls.Add(this.txtxNome);
            this.Principal.Controls.Add(this.txtxDescricao);
            this.Principal.Controls.Add(this.nudpJuros);
            this.Principal.Controls.Add(this.nudnQuantidadeDiasMes);
            this.Principal.Controls.Add(this.cbostDiaMes);
            this.Principal.Controls.Add(this.nudnCarencia);
            this.Principal.Controls.Add(this.button1);
            this.Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Principal.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Principal.Location = new System.Drawing.Point(0, 0);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(607, 225);
            this.Principal.TabIndex = 2;
            this.Principal.Tag = "Principal";
            // 
            // hlP_LabelSeparator1
            // 
            this.hlP_LabelSeparator1._LabelText = "Geral";
            this.hlP_LabelSeparator1._TamanhoMaiorLabel = 0;
            this.hlP_LabelSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.hlP_LabelSeparator1.Location = new System.Drawing.Point(3, 3);
            this.hlP_LabelSeparator1.Name = "hlP_LabelSeparator1";
            this.hlP_LabelSeparator1.Size = new System.Drawing.Size(413, 18);
            this.hlP_LabelSeparator1.TabIndex = 9;
            this.hlP_LabelSeparator1.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo._Field = "idJuros";
            this.txtCodigo._Help = "Chave principal do juros";
            this.txtCodigo._LabelGroup = this.hlP_LabelSeparator1;
            this.txtCodigo._LabelText = "Código";
            this.txtCodigo._Multiline = false;
            this.txtCodigo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtCodigo._Password = false;
            this.txtCodigo._Regex = null;
            this.txtCodigo._Table = "Juros";
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
            // txtxNome
            // 
            this.txtxNome._Field = "xNome";
            this.txtxNome._Help = "Insira um código para o juros";
            this.txtxNome._LabelGroup = this.hlP_LabelSeparator1;
            this.txtxNome._LabelText = "Juros";
            this.txtxNome._Multiline = false;
            this.txtxNome._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxNome._Password = false;
            this.txtxNome._Regex = null;
            this.txtxNome._Table = "Juros";
            this.txtxNome._TamanhoComponente = 107;
            this.txtxNome._TamanhoMaiorLabel = 150;
            this.txtxNome._Visible = true;
            this.txtxNome.BackColor = System.Drawing.Color.Transparent;
            this.txtxNome.Base = null;
            this.txtxNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxNome.Color = System.Drawing.Color.White;
            this.txtxNome.Location = new System.Drawing.Point(119, 54);
            this.txtxNome.Margin = new System.Windows.Forms.Padding(119, 3, 15, 3);
            this.txtxNome.MaxLength = 32767;
            this.txtxNome.Name = "txtxNome";
            this.txtxNome.ReadOnly = false;
            this.txtxNome.Size = new System.Drawing.Size(141, 21);
            this.txtxNome.TabIndex = 7;
            // 
            // txtxDescricao
            // 
            this.txtxDescricao._Field = "xDescricao";
            this.txtxDescricao._Help = "Insira a descrição do código de juros";
            this.txtxDescricao._LabelGroup = this.hlP_LabelSeparator1;
            this.txtxDescricao._LabelText = "Descrição";
            this.txtxDescricao._Multiline = false;
            this.txtxDescricao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxDescricao._Password = false;
            this.txtxDescricao._Regex = null;
            this.txtxDescricao._Table = "Juros";
            this.txtxDescricao._TamanhoComponente = 263;
            this.txtxDescricao._TamanhoMaiorLabel = 150;
            this.txtxDescricao._Visible = true;
            this.txtxDescricao.BackColor = System.Drawing.Color.Transparent;
            this.txtxDescricao.Base = null;
            this.txtxDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxDescricao.Color = System.Drawing.Color.White;
            this.txtxDescricao.Location = new System.Drawing.Point(97, 81);
            this.txtxDescricao.Margin = new System.Windows.Forms.Padding(97, 3, 15, 3);
            this.txtxDescricao.MaxLength = 32767;
            this.txtxDescricao.Name = "txtxDescricao";
            this.txtxDescricao.ReadOnly = false;
            this.txtxDescricao.Size = new System.Drawing.Size(319, 21);
            this.txtxDescricao.TabIndex = 3;
            // 
            // nudpJuros
            // 
            this.nudpJuros._Field = "pJuros";
            this.nudpJuros._Help = "Insira a porcentagem de juros que se aplica";
            this.nudpJuros._LabelGroup = this.hlP_LabelSeparator1;
            this.nudpJuros._LabelText = "Percentual de juros";
            this.nudpJuros._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudpJuros._Regex = null;
            this.nudpJuros._Table = "Juros";
            this.nudpJuros._TamanhoComponente = 107;
            this.nudpJuros._TamanhoMaiorLabel = 150;
            this.nudpJuros._Visible = true;
            this.nudpJuros.BackColor = System.Drawing.Color.Transparent;
            this.nudpJuros.Base = null;
            this.nudpJuros.Color = System.Drawing.Color.White;
            this.nudpJuros.DecimalPlaces = 2;
            this.nudpJuros.Location = new System.Drawing.Point(47, 108);
            this.nudpJuros.Margin = new System.Windows.Forms.Padding(47, 3, 15, 3);
            this.nudpJuros.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudpJuros.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudpJuros.Name = "nudpJuros";
            this.nudpJuros.ReadOnly = false;
            this.nudpJuros.Size = new System.Drawing.Size(213, 22);
            this.nudpJuros.TabIndex = 4;
            this.nudpJuros.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudpJuros.ValueInt = 0;
            // 
            // nudnQuantidadeDiasMes
            // 
            this.nudnQuantidadeDiasMes._Field = "nQuantidadeDiasMes";
            this.nudnQuantidadeDiasMes._Help = "Insira o número de dias ou meses para aplicar o código de juros aos pagamentos";
            this.nudnQuantidadeDiasMes._LabelGroup = this.hlP_LabelSeparator1;
            this.nudnQuantidadeDiasMes._LabelText = "Quantidade juros por";
            this.nudnQuantidadeDiasMes._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudnQuantidadeDiasMes._Regex = null;
            this.nudnQuantidadeDiasMes._Table = "Juros";
            this.nudnQuantidadeDiasMes._TamanhoComponente = 107;
            this.nudnQuantidadeDiasMes._TamanhoMaiorLabel = 150;
            this.nudnQuantidadeDiasMes._Visible = true;
            this.nudnQuantidadeDiasMes.BackColor = System.Drawing.Color.Transparent;
            this.nudnQuantidadeDiasMes.Base = null;
            this.nudnQuantidadeDiasMes.Color = System.Drawing.Color.White;
            this.nudnQuantidadeDiasMes.DecimalPlaces = 2;
            this.nudnQuantidadeDiasMes.Location = new System.Drawing.Point(35, 136);
            this.nudnQuantidadeDiasMes.Margin = new System.Windows.Forms.Padding(35, 3, 15, 3);
            this.nudnQuantidadeDiasMes.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudnQuantidadeDiasMes.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudnQuantidadeDiasMes.Name = "nudnQuantidadeDiasMes";
            this.nudnQuantidadeDiasMes.ReadOnly = false;
            this.nudnQuantidadeDiasMes.Size = new System.Drawing.Size(225, 22);
            this.nudnQuantidadeDiasMes.TabIndex = 4;
            this.nudnQuantidadeDiasMes.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudnQuantidadeDiasMes.ValueInt = 0;
            // 
            // cbostDiaMes
            // 
            this.cbostDiaMes._Field = "stDiaMes";
            this.cbostDiaMes._Help = "Selecione se é dia ou mês para aplicar a quantidade informada no campo quantidade" +
    "";
            this.cbostDiaMes._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostDiaMes._Itens")));
            this.cbostDiaMes._LabelGroup = this.hlP_LabelSeparator1;
            this.cbostDiaMes._LabelText = "Dias/mês";
            this.cbostDiaMes._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostDiaMes._Regex = null;
            this.cbostDiaMes._situacao = false;
            this.cbostDiaMes._Table = "Juros";
            this.cbostDiaMes._TamanhoComponente = 107;
            this.cbostDiaMes._TamanhoMaiorLabel = 150;
            this.cbostDiaMes._Visible = true;
            this.cbostDiaMes.BackColor = System.Drawing.Color.Transparent;
            this.cbostDiaMes.Base = null;
            this.cbostDiaMes.Color = System.Drawing.Color.White;
            this.cbostDiaMes.DataSource = null;
            this.cbostDiaMes.DisplayMember = "DisplayMember";
            this.cbostDiaMes.Location = new System.Drawing.Point(100, 164);
            this.cbostDiaMes.Margin = new System.Windows.Forms.Padding(100, 3, 15, 3);
            this.cbostDiaMes.Name = "cbostDiaMes";
            this.cbostDiaMes.SelectedIndex = -1;
            this.cbostDiaMes.SelectedValue = 0;
            this.cbostDiaMes.Size = new System.Drawing.Size(160, 21);
            this.cbostDiaMes.TabIndex = 8;
            this.cbostDiaMes.ValueMember = "ValueMember";
            // 
            // nudnCarencia
            // 
            this.nudnCarencia._Field = "nCarencia";
            this.nudnCarencia._Help = "Insira o número de dias de carência permitidos antes da aplicação do juros";
            this.nudnCarencia._LabelGroup = this.hlP_LabelSeparator1;
            this.nudnCarencia._LabelText = "Carência";
            this.nudnCarencia._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudnCarencia._Regex = null;
            this.nudnCarencia._Table = "Juros";
            this.nudnCarencia._TamanhoComponente = 107;
            this.nudnCarencia._TamanhoMaiorLabel = 150;
            this.nudnCarencia._Visible = true;
            this.nudnCarencia.BackColor = System.Drawing.Color.Transparent;
            this.nudnCarencia.Base = null;
            this.nudnCarencia.Color = System.Drawing.Color.White;
            this.nudnCarencia.DecimalPlaces = 2;
            this.nudnCarencia.Location = new System.Drawing.Point(102, 191);
            this.nudnCarencia.Margin = new System.Windows.Forms.Padding(102, 3, 15, 3);
            this.nudnCarencia.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudnCarencia.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudnCarencia.Name = "nudnCarencia";
            this.nudnCarencia.ReadOnly = false;
            this.nudnCarencia.Size = new System.Drawing.Size(158, 22);
            this.nudnCarencia.TabIndex = 5;
            this.nudnCarencia.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudnCarencia.ValueInt = 0;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(434, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormJuros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 311);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormJuros";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = -10;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Text = "Juros";
            this.Load += new System.EventHandler(this.FormJuros_Load);
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
        private Comum.Components.HLP_TextBox txtxDescricao;
        private Comum.Components.HLP_NumericUpDown nudpJuros;
        private Comum.Components.HLP_NumericUpDown nudnQuantidadeDiasMes;
        private Comum.Components.HLP_NumericUpDown nudnCarencia;
        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel1;
        private Comum.Components.HLP_TextBox txtxNome;
        private Comum.Components.HLP_ComboBox cbostDiaMes;
        private Comum.Components.HLP_LabelSeparator hlP_LabelSeparator1;
        private System.Windows.Forms.Button button1;
    }
}