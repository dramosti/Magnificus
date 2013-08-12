namespace HLP.UI.Entries.Geral
{
    partial class FormUF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUF));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.hlP_LabelSeparator1_Geral = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtCodigo = new HLP.Comum.Components.HLP_TextBox();
            this.txtxSiglaUf = new HLP.Comum.Components.HLP_TextBox();
            this.txtxUf = new HLP.Comum.Components.HLP_TextBox();
            this.nudcIbgeUf = new HLP.Comum.Components.HLP_NumericUpDown();
            this.hlP_PesquisaRegiao = new HLP.Comum.Components.HLP_Pesquisa();
            this.kryptonTabControl1 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kryptonPanel1 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).BeginInit();
            this.panelPadrao.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.hlP_LabelSeparator1_Geral);
            this.flowLayoutPanel1.Controls.Add(this.txtCodigo);
            this.flowLayoutPanel1.Controls.Add(this.txtxSiglaUf);
            this.flowLayoutPanel1.Controls.Add(this.txtxUf);
            this.flowLayoutPanel1.Controls.Add(this.nudcIbgeUf);
            this.flowLayoutPanel1.Controls.Add(this.hlP_PesquisaRegiao);
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
            this.hlP_LabelSeparator1_Geral.Size = new System.Drawing.Size(530, 19);
            this.hlP_LabelSeparator1_Geral.TabIndex = 31;
            this.hlP_LabelSeparator1_Geral.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo._Field = "idUF";
            this.txtCodigo._Help = "Chave principal do registro da unidade federativa, campo autoinclemental.";
            this.txtCodigo._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtCodigo._LabelText = "Código";
            this.txtCodigo._Multiline = false;
            this.txtCodigo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtCodigo._Password = false;
            this.txtCodigo._Regex = null;
            this.txtCodigo._Table = "UF";
            this.txtCodigo._TamanhoComponente = 107;
            this.txtCodigo._TamanhoMaiorLabel = 150;
            this.txtCodigo.BackColor = System.Drawing.Color.Transparent;
            this.txtCodigo.Base = null;
            this.txtCodigo.bConfiguracao = false;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCodigo.Color = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(108, 28);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(108, 3, 15, 3);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.objConfigComponenteModel = null;
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(152, 19);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtxSiglaUf
            // 
            this.txtxSiglaUf._Field = "xSiglaUf";
            this.txtxSiglaUf._Help = "Informar a sigla da unidade federativa.";
            this.txtxSiglaUf._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtxSiglaUf._LabelText = "Sigla do estado ";
            this.txtxSiglaUf._Multiline = false;
            this.txtxSiglaUf._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxSiglaUf._Password = false;
            this.txtxSiglaUf._Regex = null;
            this.txtxSiglaUf._Table = "UF";
            this.txtxSiglaUf._TamanhoComponente = 192;
            this.txtxSiglaUf._TamanhoMaiorLabel = 150;
            this.txtxSiglaUf.BackColor = System.Drawing.Color.Transparent;
            this.txtxSiglaUf.Base = null;
            this.txtxSiglaUf.bConfiguracao = false;
            this.txtxSiglaUf.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxSiglaUf.Color = System.Drawing.Color.White;
            this.txtxSiglaUf.Location = new System.Drawing.Point(63, 53);
            this.txtxSiglaUf.Margin = new System.Windows.Forms.Padding(63, 3, 15, 3);
            this.txtxSiglaUf.MaxLength = 32767;
            this.txtxSiglaUf.Name = "txtxSiglaUf";
            this.txtxSiglaUf.objConfigComponenteModel = null;
            this.txtxSiglaUf.ReadOnly = false;
            this.txtxSiglaUf.Size = new System.Drawing.Size(282, 21);
            this.txtxSiglaUf.TabIndex = 2;
            // 
            // txtxUf
            // 
            this.txtxUf._Field = "xUf";
            this.txtxUf._Help = "Informar o nome do estado.";
            this.txtxUf._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtxUf._LabelText = "Nome do estado";
            this.txtxUf._Multiline = false;
            this.txtxUf._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxUf._Password = false;
            this.txtxUf._Regex = null;
            this.txtxUf._Table = "UF";
            this.txtxUf._TamanhoComponente = 192;
            this.txtxUf._TamanhoMaiorLabel = 150;
            this.txtxUf.BackColor = System.Drawing.Color.Transparent;
            this.txtxUf.Base = null;
            this.txtxUf.bConfiguracao = false;
            this.txtxUf.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxUf.Color = System.Drawing.Color.White;
            this.txtxUf.Location = new System.Drawing.Point(61, 80);
            this.txtxUf.Margin = new System.Windows.Forms.Padding(61, 3, 15, 3);
            this.txtxUf.MaxLength = 32767;
            this.txtxUf.Name = "txtxUf";
            this.txtxUf.objConfigComponenteModel = null;
            this.txtxUf.ReadOnly = false;
            this.txtxUf.Size = new System.Drawing.Size(284, 21);
            this.txtxUf.TabIndex = 3;
            // 
            // nudcIbgeUf
            // 
            this.nudcIbgeUf._Field = "cIbgeUf";
            this.nudcIbgeUf._Help = "Informar o código do estado conforme métricas definidas pelo ibge.";
            this.nudcIbgeUf._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.nudcIbgeUf._LabelText = "Código do estado ibge";
            this.nudcIbgeUf._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudcIbgeUf._Regex = null;
            this.nudcIbgeUf._Table = "UF";
            this.nudcIbgeUf._TamanhoComponente = 111;
            this.nudcIbgeUf._TamanhoMaiorLabel = 150;
            this.nudcIbgeUf.BackColor = System.Drawing.Color.Transparent;
            this.nudcIbgeUf.Base = null;
            this.nudcIbgeUf.bConfiguracao = false;
            this.nudcIbgeUf.Color = System.Drawing.Color.White;
            this.nudcIbgeUf.DecimalPlaces = 2;
            this.nudcIbgeUf.Location = new System.Drawing.Point(27, 107);
            this.nudcIbgeUf.Margin = new System.Windows.Forms.Padding(27, 3, 15, 3);
            this.nudcIbgeUf.Maximum = new decimal(new int[] {
            53,
            0,
            0,
            0});
            this.nudcIbgeUf.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudcIbgeUf.Name = "nudcIbgeUf";
            this.nudcIbgeUf.objConfigComponenteModel = null;
            this.nudcIbgeUf.ReadOnly = false;
            this.nudcIbgeUf.Size = new System.Drawing.Size(237, 22);
            this.nudcIbgeUf.TabIndex = 4;
            this.nudcIbgeUf.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudcIbgeUf.ValueInt = 0;
            // 
            // hlP_PesquisaRegiao
            // 
            this.hlP_PesquisaRegiao._Field = "idRegiao";
            this.hlP_PesquisaRegiao._Help = "Informar a região nacional em que o estado esta são elas, norte, sul, nordeste, c" +
    "entro-oeste e sudeste.";
            this.hlP_PesquisaRegiao._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.hlP_PesquisaRegiao._LabelText = "Região";
            this.hlP_PesquisaRegiao._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaRegiao._ListaCamposDisplay")));
            this.hlP_PesquisaRegiao._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaRegiao._ListaValoresDisplay")));
            this.hlP_PesquisaRegiao._NomeCampoPK = "ID";
            this.hlP_PesquisaRegiao._NomeFormCadastroOriginal = "";
            this.hlP_PesquisaRegiao._NomeView = "vwRegiao";
            this.hlP_PesquisaRegiao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisaRegiao._Regex = null;
            this.hlP_PesquisaRegiao._Table = "UF";
            this.hlP_PesquisaRegiao._TamanhoComponente = 300;
            this.hlP_PesquisaRegiao._TamanhoMaiorLabel = 150;
            this.hlP_PesquisaRegiao._Vinculado = false;
            this.hlP_PesquisaRegiao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaRegiao.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaRegiao.Base = null;
            this.hlP_PesquisaRegiao.bConfiguracao = false;
            this.hlP_PesquisaRegiao.Location = new System.Drawing.Point(110, 135);
            this.hlP_PesquisaRegiao.Margin = new System.Windows.Forms.Padding(110, 3, 15, 3);
            this.hlP_PesquisaRegiao.Name = "hlP_PesquisaRegiao";
            this.hlP_PesquisaRegiao.objConfigComponenteModel = null;
            this.hlP_PesquisaRegiao.ReadOnly = false;
            this.hlP_PesquisaRegiao.Size = new System.Drawing.Size(343, 21);
            this.hlP_PesquisaRegiao.TabIndex = 5;
            this.hlP_PesquisaRegiao.Value = 0;
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
            // FormUF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 311);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUF";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = -10;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text = "UF – Unidade da Federação";
            this.Load += new System.EventHandler(this.FormUF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).EndInit();
            this.panelPadrao.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.kryptonTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.kryptonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Comum.Components.HLP_NumericUpDown nudcIbgeUf;
        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel1;
        private Comum.Components.HLP_LabelSeparator hlP_LabelSeparator1_Geral;
        private Comum.Components.HLP_TextBox txtCodigo;
        private Comum.Components.HLP_TextBox txtxSiglaUf;
        private Comum.Components.HLP_TextBox txtxUf;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaRegiao;
       
    }
}