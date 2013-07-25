namespace HLP.UI.Entries.Geral
{
    partial class FormCondicaoEntrega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCondicaoEntrega));
            this.Principal = new System.Windows.Forms.FlowLayoutPanel();
            this.hlP_LabelSeparator1_Geral = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtCodigo = new HLP.Comum.Components.HLP_TextBox();
            this.txtxCondicaoEntrega = new HLP.Comum.Components.HLP_TextBox();
            this.txtxDescricao = new HLP.Comum.Components.HLP_TextBox();
            this.cbostEnderecoImpostoSobreVendas = new HLP.Comum.Components.HLP_ComboBox();
            this.txtnIntrastat = new HLP.Comum.Components.HLP_TextBox();
            this.cbostAplicarMinGratis = new HLP.Comum.Components.HLP_ComboBox();
            this.nudvMinimoGratis = new HLP.Comum.Components.HLP_NumericUpDown();
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
            this.Principal.Controls.Add(this.hlP_LabelSeparator1_Geral);
            this.Principal.Controls.Add(this.txtCodigo);
            this.Principal.Controls.Add(this.txtxCondicaoEntrega);
            this.Principal.Controls.Add(this.txtxDescricao);
            this.Principal.Controls.Add(this.cbostEnderecoImpostoSobreVendas);
            this.Principal.Controls.Add(this.txtnIntrastat);
            this.Principal.Controls.Add(this.cbostAplicarMinGratis);
            this.Principal.Controls.Add(this.nudvMinimoGratis);
            this.Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Principal.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Principal.Location = new System.Drawing.Point(0, 0);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(607, 225);
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
            this.hlP_LabelSeparator1_Geral.Size = new System.Drawing.Size(418, 18);
            this.hlP_LabelSeparator1_Geral.TabIndex = 30;
            this.hlP_LabelSeparator1_Geral.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo._Field = "idCondicaoEntrega";
            this.txtCodigo._Help = "Chave principal do registro da condição de entrega";
            this.txtCodigo._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtCodigo._LabelText = "Código";
            this.txtCodigo._Multiline = false;
            this.txtCodigo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtCodigo._Password = false;
            this.txtCodigo._Regex = null;
            this.txtCodigo._Table = "Condicoes_entrega";
            this.txtCodigo._TamanhoComponente = 107;
            this.txtCodigo._TamanhoMaiorLabel = 200;
            this.txtCodigo._Visible = true;
            this.txtCodigo.BackColor = System.Drawing.Color.Transparent;
            this.txtCodigo.Base = null;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCodigo.Color = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(158, 27);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(158, 3, 15, 3);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(152, 21);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtxCondicaoEntrega
            // 
            this.txtxCondicaoEntrega._Field = "xCondicaoEntrega";
            this.txtxCondicaoEntrega._Help = "Digite um código para a recém-criada condição de entrega";
            this.txtxCondicaoEntrega._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtxCondicaoEntrega._LabelText = "Condição de entrega";
            this.txtxCondicaoEntrega._Multiline = false;
            this.txtxCondicaoEntrega._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxCondicaoEntrega._Password = false;
            this.txtxCondicaoEntrega._Regex = null;
            this.txtxCondicaoEntrega._Table = "Condicoes_entrega";
            this.txtxCondicaoEntrega._TamanhoComponente = 107;
            this.txtxCondicaoEntrega._TamanhoMaiorLabel = 200;
            this.txtxCondicaoEntrega._Visible = true;
            this.txtxCondicaoEntrega.BackColor = System.Drawing.Color.Transparent;
            this.txtxCondicaoEntrega.Base = null;
            this.txtxCondicaoEntrega.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxCondicaoEntrega.Color = System.Drawing.Color.White;
            this.txtxCondicaoEntrega.Location = new System.Drawing.Point(88, 54);
            this.txtxCondicaoEntrega.Margin = new System.Windows.Forms.Padding(88, 3, 15, 3);
            this.txtxCondicaoEntrega.MaxLength = 32767;
            this.txtxCondicaoEntrega.Name = "txtxCondicaoEntrega";
            this.txtxCondicaoEntrega.ReadOnly = false;
            this.txtxCondicaoEntrega.Size = new System.Drawing.Size(222, 21);
            this.txtxCondicaoEntrega.TabIndex = 3;
            // 
            // txtxDescricao
            // 
            this.txtxDescricao._Field = "xDescricao";
            this.txtxDescricao._Help = "Descrição da condição de entrega";
            this.txtxDescricao._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtxDescricao._LabelText = "Descrição ";
            this.txtxDescricao._Multiline = false;
            this.txtxDescricao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxDescricao._Password = false;
            this.txtxDescricao._Regex = null;
            this.txtxDescricao._Table = "Condicoes_entrega";
            this.txtxDescricao._TamanhoComponente = 215;
            this.txtxDescricao._TamanhoMaiorLabel = 200;
            this.txtxDescricao._Visible = true;
            this.txtxDescricao.BackColor = System.Drawing.Color.Transparent;
            this.txtxDescricao.Base = null;
            this.txtxDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxDescricao.Color = System.Drawing.Color.White;
            this.txtxDescricao.Location = new System.Drawing.Point(144, 81);
            this.txtxDescricao.Margin = new System.Windows.Forms.Padding(144, 3, 15, 3);
            this.txtxDescricao.MaxLength = 10;
            this.txtxDescricao.Name = "txtxDescricao";
            this.txtxDescricao.ReadOnly = false;
            this.txtxDescricao.Size = new System.Drawing.Size(274, 21);
            this.txtxDescricao.TabIndex = 2;
            // 
            // cbostEnderecoImpostoSobreVendas
            // 
            this.cbostEnderecoImpostoSobreVendas._Field = "stEnderecoImpostoSobreVendas";
            this.cbostEnderecoImpostoSobreVendas._Help = "Selecione o endereço no qual as mercadorias trocam de propriedade (intrastat)";
            this.cbostEnderecoImpostoSobreVendas._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostEnderecoImpostoSobreVendas._Itens")));
            this.cbostEnderecoImpostoSobreVendas._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cbostEnderecoImpostoSobreVendas._LabelText = "Endereço para imposto sobre vendas";
            this.cbostEnderecoImpostoSobreVendas._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostEnderecoImpostoSobreVendas._Regex = null;
            this.cbostEnderecoImpostoSobreVendas._situacao = false;
            this.cbostEnderecoImpostoSobreVendas._Table = "Condicoes_entrega";
            this.cbostEnderecoImpostoSobreVendas._TamanhoComponente = 193;
            this.cbostEnderecoImpostoSobreVendas._TamanhoMaiorLabel = 200;
            this.cbostEnderecoImpostoSobreVendas._Visible = true;
            this.cbostEnderecoImpostoSobreVendas.BackColor = System.Drawing.Color.Transparent;
            this.cbostEnderecoImpostoSobreVendas.Base = null;
            this.cbostEnderecoImpostoSobreVendas.Color = System.Drawing.Color.White;
            this.cbostEnderecoImpostoSobreVendas.DataSource = null;
            this.cbostEnderecoImpostoSobreVendas.DisplayMember = "DisplayMember";
            this.cbostEnderecoImpostoSobreVendas.Location = new System.Drawing.Point(6, 108);
            this.cbostEnderecoImpostoSobreVendas.Margin = new System.Windows.Forms.Padding(6, 3, 15, 3);
            this.cbostEnderecoImpostoSobreVendas.Name = "cbostEnderecoImpostoSobreVendas";
            this.cbostEnderecoImpostoSobreVendas.SelectedIndex = -1;
            this.cbostEnderecoImpostoSobreVendas.SelectedValue = 0;
            this.cbostEnderecoImpostoSobreVendas.Size = new System.Drawing.Size(390, 21);
            this.cbostEnderecoImpostoSobreVendas.TabIndex = 4;
            this.cbostEnderecoImpostoSobreVendas.ValueMember = "ValueMember";
            // 
            // txtnIntrastat
            // 
            this.txtnIntrastat._Field = "nIntrastat";
            this.txtnIntrastat._Help = "Intrastat é uma declaração estatística de entrega obrigatória ao ine por parte do" +
    "s contribuintes que adquirem ou vendem produtos ao mercado comunitário";
            this.txtnIntrastat._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtnIntrastat._LabelText = "Código intrastat";
            this.txtnIntrastat._Multiline = false;
            this.txtnIntrastat._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtnIntrastat._Password = false;
            this.txtnIntrastat._Regex = null;
            this.txtnIntrastat._Table = "Condicoes_entrega";
            this.txtnIntrastat._TamanhoComponente = 86;
            this.txtnIntrastat._TamanhoMaiorLabel = 200;
            this.txtnIntrastat._Visible = true;
            this.txtnIntrastat.BackColor = System.Drawing.Color.Transparent;
            this.txtnIntrastat.Base = null;
            this.txtnIntrastat.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtnIntrastat.Color = System.Drawing.Color.White;
            this.txtnIntrastat.Location = new System.Drawing.Point(112, 135);
            this.txtnIntrastat.Margin = new System.Windows.Forms.Padding(112, 3, 15, 3);
            this.txtnIntrastat.MaxLength = 10;
            this.txtnIntrastat.Name = "txtnIntrastat";
            this.txtnIntrastat.ReadOnly = false;
            this.txtnIntrastat.Size = new System.Drawing.Size(177, 21);
            this.txtnIntrastat.TabIndex = 5;
            // 
            // cbostAplicarMinGratis
            // 
            this.cbostAplicarMinGratis._Field = "stAplicarMinGratis";
            this.cbostAplicarMinGratis._Help = "Caso esta opção esteja selecionada, os encargos de remessa serão cancelados, se o" +
    " valor da nota fiscal ultrapassar um determinado valor";
            this.cbostAplicarMinGratis._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostAplicarMinGratis._Itens")));
            this.cbostAplicarMinGratis._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cbostAplicarMinGratis._LabelText = "Aplicar mínimo máximo?";
            this.cbostAplicarMinGratis._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostAplicarMinGratis._Regex = null;
            this.cbostAplicarMinGratis._situacao = true;
            this.cbostAplicarMinGratis._Table = "Condicoes_entrega";
            this.cbostAplicarMinGratis._TamanhoComponente = 80;
            this.cbostAplicarMinGratis._TamanhoMaiorLabel = 200;
            this.cbostAplicarMinGratis._Visible = true;
            this.cbostAplicarMinGratis.BackColor = System.Drawing.Color.Transparent;
            this.cbostAplicarMinGratis.Base = null;
            this.cbostAplicarMinGratis.Color = System.Drawing.Color.White;
            this.cbostAplicarMinGratis.DataSource = null;
            this.cbostAplicarMinGratis.DisplayMember = "DisplayMember";
            this.cbostAplicarMinGratis.Location = new System.Drawing.Point(73, 162);
            this.cbostAplicarMinGratis.Margin = new System.Windows.Forms.Padding(73, 3, 15, 3);
            this.cbostAplicarMinGratis.Name = "cbostAplicarMinGratis";
            this.cbostAplicarMinGratis.SelectedIndex = -1;
            this.cbostAplicarMinGratis.SelectedValue = 0;
            this.cbostAplicarMinGratis.Size = new System.Drawing.Size(210, 21);
            this.cbostAplicarMinGratis.TabIndex = 6;
            this.cbostAplicarMinGratis.ValueMember = "ValueMember";
            this.cbostAplicarMinGratis._SelectedIndexChanged += new System.EventHandler(this.cbostAplicarMinGratis__SelectedIndexChanged);
            // 
            // nudvMinimoGratis
            // 
            this.nudvMinimoGratis._Field = "vMinimoGratis";
            this.nudvMinimoGratis._Help = "Se a caixa de seleção aplicar mínimo grátis estiver marcada como sim, insira o va" +
    "lor mínimo da nota fiscal de venda para o qual os encargos de remessa serão canc" +
    "elados";
            this.nudvMinimoGratis._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.nudvMinimoGratis._LabelText = "Valor mínimo grátis";
            this.nudvMinimoGratis._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudvMinimoGratis._Regex = null;
            this.nudvMinimoGratis._Table = "Condicoes_entrega";
            this.nudvMinimoGratis._TamanhoComponente = 125;
            this.nudvMinimoGratis._TamanhoMaiorLabel = 200;
            this.nudvMinimoGratis._Visible = true;
            this.nudvMinimoGratis.BackColor = System.Drawing.Color.Transparent;
            this.nudvMinimoGratis.Base = null;
            this.nudvMinimoGratis.Color = System.Drawing.Color.White;
            this.nudvMinimoGratis.DecimalPlaces = 2;
            this.nudvMinimoGratis.Location = new System.Drawing.Point(96, 189);
            this.nudvMinimoGratis.Margin = new System.Windows.Forms.Padding(96, 3, 15, 3);
            this.nudvMinimoGratis.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudvMinimoGratis.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudvMinimoGratis.Name = "nudvMinimoGratis";
            this.nudvMinimoGratis.ReadOnly = false;
            this.nudvMinimoGratis.Size = new System.Drawing.Size(232, 22);
            this.nudvMinimoGratis.TabIndex = 7;
            this.nudvMinimoGratis.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudvMinimoGratis.ValueInt = 0;
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
            // FormCondicaoEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 311);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCondicaoEntrega";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = -10;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text = "Condições de Entrega";
            this.Load += new System.EventHandler(this.FormCondicaoEntrega_Load);
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
        private Comum.Components.HLP_TextBox txtxCondicaoEntrega;
        private Comum.Components.HLP_TextBox txtxDescricao;
        private Comum.Components.HLP_ComboBox cbostEnderecoImpostoSobreVendas;
        private Comum.Components.HLP_TextBox txtnIntrastat;
        private Comum.Components.HLP_ComboBox cbostAplicarMinGratis;
        private Comum.Components.HLP_NumericUpDown nudvMinimoGratis;
        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel1;
        private Comum.Components.HLP_LabelSeparator hlP_LabelSeparator1_Geral;
    }
}