namespace HLP.UI.Entries.Financeiro
{
    partial class FormDesconto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDesconto));
            this.async_work = new System.ComponentModel.BackgroundWorker();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kryptonPanel1 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.hlP_LabelSeparator1_Geral = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtCodigo = new HLP.Comum.Components.HLP_TextBox();
            this.txtxDescontos = new HLP.Comum.Components.HLP_TextBox();
            this.txtxDescricao = new HLP.Comum.Components.HLP_TextBox();
            this.cbostLiquidoAtual = new HLP.Comum.Components.HLP_ComboBox();
            this.nudnMeses = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudnDias = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudpDesconto = new HLP.Comum.Components.HLP_NumericUpDown();
            this.kryptonTabControl1 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).BeginInit();
            this.panelPadrao.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.kryptonPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.kryptonTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(619, 321);
            // 
            // panelPadrao
            // 
            this.panelPadrao.Controls.Add(this.kryptonTabControl1);
            this.panelPadrao.Size = new System.Drawing.Size(617, 297);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Controls.Add(this.kryptonPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(603, 262);
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
            this.kryptonPanel1.Size = new System.Drawing.Size(603, 262);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.hlP_LabelSeparator1_Geral);
            this.flowLayoutPanel1.Controls.Add(this.txtCodigo);
            this.flowLayoutPanel1.Controls.Add(this.txtxDescontos);
            this.flowLayoutPanel1.Controls.Add(this.txtxDescricao);
            this.flowLayoutPanel1.Controls.Add(this.cbostLiquidoAtual);
            this.flowLayoutPanel1.Controls.Add(this.nudnMeses);
            this.flowLayoutPanel1.Controls.Add(this.nudnDias);
            this.flowLayoutPanel1.Controls.Add(this.nudpDesconto);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(603, 262);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Tag = "Principal";
            // 
            // hlP_LabelSeparator1_Geral
            // 
            this.hlP_LabelSeparator1_Geral._LabelText = "Geral";
            this.hlP_LabelSeparator1_Geral._TamanhoMaiorLabel = 0;
            this.hlP_LabelSeparator1_Geral.BackColor = System.Drawing.Color.Transparent;
            this.hlP_LabelSeparator1_Geral.Location = new System.Drawing.Point(3, 3);
            this.hlP_LabelSeparator1_Geral.Name = "hlP_LabelSeparator1_Geral";
            this.hlP_LabelSeparator1_Geral.Size = new System.Drawing.Size(300, 18);
            this.hlP_LabelSeparator1_Geral.TabIndex = 27;
            this.hlP_LabelSeparator1_Geral.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo._Field = "idDescontosAvista";
            this.txtCodigo._Help = "Chave principal do registro do desconto";
            this.txtCodigo._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtCodigo._LabelText = "Código";
            this.txtCodigo._Multiline = false;
            this.txtCodigo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtCodigo._Password = false;
            this.txtCodigo._Regex = null;
            this.txtCodigo._Table = "Descontos_Avista";
            this.txtCodigo._TamanhoComponente = 132;
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
            this.txtCodigo.Size = new System.Drawing.Size(177, 24);
            this.txtCodigo.TabIndex = 3;
            // 
            // txtxDescontos
            // 
            this.txtxDescontos._Field = "xDescontos";
            this.txtxDescontos._Help = "Digite o código alfanumérico para o desconto";
            this.txtxDescontos._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtxDescontos._LabelText = "Desconto ";
            this.txtxDescontos._Multiline = false;
            this.txtxDescontos._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxDescontos._Password = false;
            this.txtxDescontos._Regex = null;
            this.txtxDescontos._Table = "Descontos_Avista";
            this.txtxDescontos._TamanhoComponente = 132;
            this.txtxDescontos._TamanhoMaiorLabel = 150;
            this.txtxDescontos._Visible = false;
            this.txtxDescontos.BackColor = System.Drawing.Color.Transparent;
            this.txtxDescontos.Base = null;
            this.txtxDescontos.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxDescontos.Color = System.Drawing.Color.White;
            this.txtxDescontos.Location = new System.Drawing.Point(94, 57);
            this.txtxDescontos.Margin = new System.Windows.Forms.Padding(94, 3, 15, 3);
            this.txtxDescontos.MaxLength = 32767;
            this.txtxDescontos.Name = "txtxDescontos";
            this.txtxDescontos.ReadOnly = false;
            this.txtxDescontos.Size = new System.Drawing.Size(191, 24);
            this.txtxDescontos.TabIndex = 4;
            // 
            // txtxDescricao
            // 
            this.txtxDescricao._Field = "xDescricao";
            this.txtxDescricao._Help = "Digite uma descrição do desconto à vista";
            this.txtxDescricao._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtxDescricao._LabelText = "Descrição ";
            this.txtxDescricao._Multiline = false;
            this.txtxDescricao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxDescricao._Password = false;
            this.txtxDescricao._Regex = null;
            this.txtxDescricao._Table = "Descontos_Avista";
            this.txtxDescricao._TamanhoComponente = 272;
            this.txtxDescricao._TamanhoMaiorLabel = 150;
            this.txtxDescricao._Visible = false;
            this.txtxDescricao.BackColor = System.Drawing.Color.Transparent;
            this.txtxDescricao.Base = null;
            this.txtxDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxDescricao.Color = System.Drawing.Color.White;
            this.txtxDescricao.Location = new System.Drawing.Point(94, 87);
            this.txtxDescricao.Margin = new System.Windows.Forms.Padding(94, 3, 15, 3);
            this.txtxDescricao.MaxLength = 32767;
            this.txtxDescricao.Name = "txtxDescricao";
            this.txtxDescricao.ReadOnly = false;
            this.txtxDescricao.Size = new System.Drawing.Size(331, 22);
            this.txtxDescricao.TabIndex = 5;
            // 
            // cbostLiquidoAtual
            // 
            this.cbostLiquidoAtual._Field = "stLiquidoAtual";
            this.cbostLiquidoAtual._Help = "Escolha o método aplicável ao seu desconto ";
            this.cbostLiquidoAtual._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostLiquidoAtual._Itens")));
            this.cbostLiquidoAtual._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cbostLiquidoAtual._LabelText = "Liquido/atual";
            this.cbostLiquidoAtual._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostLiquidoAtual._Regex = null;
            this.cbostLiquidoAtual._situacao = false;
            this.cbostLiquidoAtual._Table = "Descontos_Avista";
            this.cbostLiquidoAtual._TamanhoComponente = 132;
            this.cbostLiquidoAtual._TamanhoMaiorLabel = 150;
            this.cbostLiquidoAtual._Visible = false;
            this.cbostLiquidoAtual.BackColor = System.Drawing.Color.Transparent;
            this.cbostLiquidoAtual.Base = null;
            this.cbostLiquidoAtual.Color = System.Drawing.Color.White;
            this.cbostLiquidoAtual.DataSource = null;
            this.cbostLiquidoAtual.DisplayMember = "DisplayMember";
            this.cbostLiquidoAtual.Location = new System.Drawing.Point(77, 115);
            this.cbostLiquidoAtual.Margin = new System.Windows.Forms.Padding(77, 3, 15, 3);
            this.cbostLiquidoAtual.Name = "cbostLiquidoAtual";
            this.cbostLiquidoAtual.SelectedIndex = -1;
            this.cbostLiquidoAtual.SelectedValue = 0;
            this.cbostLiquidoAtual.Size = new System.Drawing.Size(208, 21);
            this.cbostLiquidoAtual.TabIndex = 7;
            this.cbostLiquidoAtual.ValueMember = "ValueMember";
            // 
            // nudnMeses
            // 
            this.nudnMeses._Field = "nMeses";
            this.nudnMeses._Help = "Digite o número de meses em que o desconto  será aplicável";
            this.nudnMeses._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.nudnMeses._LabelText = "Meses";
            this.nudnMeses._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudnMeses._Regex = null;
            this.nudnMeses._Table = "Descontos_Avista";
            this.nudnMeses._TamanhoComponente = 118;
            this.nudnMeses._TamanhoMaiorLabel = 150;
            this.nudnMeses._Visible = false;
            this.nudnMeses.BackColor = System.Drawing.Color.Transparent;
            this.nudnMeses.Base = null;
            this.nudnMeses.Color = System.Drawing.Color.White;
            this.nudnMeses.DecimalPlaces = 2;
            this.nudnMeses.Location = new System.Drawing.Point(114, 142);
            this.nudnMeses.Margin = new System.Windows.Forms.Padding(114, 3, 15, 3);
            this.nudnMeses.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudnMeses.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudnMeses.Name = "nudnMeses";
            this.nudnMeses.ReadOnly = false;
            this.nudnMeses.Size = new System.Drawing.Size(157, 22);
            this.nudnMeses.TabIndex = 8;
            this.nudnMeses.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudnMeses.ValueInt = 0;
            // 
            // nudnDias
            // 
            this.nudnDias._Field = "nDias";
            this.nudnDias._Help = "Digite o número de dias em que o desconto será aplicável";
            this.nudnDias._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.nudnDias._LabelText = "Dias";
            this.nudnDias._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudnDias._Regex = null;
            this.nudnDias._Table = "Descontos_Avista";
            this.nudnDias._TamanhoComponente = 118;
            this.nudnDias._TamanhoMaiorLabel = 150;
            this.nudnDias._Visible = false;
            this.nudnDias.BackColor = System.Drawing.Color.Transparent;
            this.nudnDias.Base = null;
            this.nudnDias.Color = System.Drawing.Color.White;
            this.nudnDias.DecimalPlaces = 2;
            this.nudnDias.Location = new System.Drawing.Point(124, 170);
            this.nudnDias.Margin = new System.Windows.Forms.Padding(124, 3, 15, 3);
            this.nudnDias.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudnDias.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudnDias.Name = "nudnDias";
            this.nudnDias.ReadOnly = false;
            this.nudnDias.Size = new System.Drawing.Size(147, 22);
            this.nudnDias.TabIndex = 9;
            this.nudnDias.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudnDias.ValueInt = 0;
            // 
            // nudpDesconto
            // 
            this.nudpDesconto._Field = "pDesconto";
            this.nudpDesconto._Help = "Digite o desconto  como um percentual do valor faturado";
            this.nudpDesconto._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.nudpDesconto._LabelText = "Percentual de desconto";
            this.nudpDesconto._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudpDesconto._Regex = null;
            this.nudpDesconto._Table = "Descontos_Avista";
            this.nudpDesconto._TamanhoComponente = 121;
            this.nudpDesconto._TamanhoMaiorLabel = 150;
            this.nudpDesconto._Visible = false;
            this.nudpDesconto.BackColor = System.Drawing.Color.Transparent;
            this.nudpDesconto.Base = null;
            this.nudpDesconto.Color = System.Drawing.Color.White;
            this.nudpDesconto.DecimalPlaces = 2;
            this.nudpDesconto.Location = new System.Drawing.Point(25, 198);
            this.nudpDesconto.Margin = new System.Windows.Forms.Padding(25, 3, 15, 3);
            this.nudpDesconto.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudpDesconto.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudpDesconto.Name = "nudpDesconto";
            this.nudpDesconto.ReadOnly = false;
            this.nudpDesconto.Size = new System.Drawing.Size(249, 22);
            this.nudpDesconto.TabIndex = 10;
            this.nudpDesconto.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudpDesconto.ValueInt = 0;
            // 
            // kryptonTabControl1
            // 
            this.kryptonTabControl1.AllowCloseButton = false;
            this.kryptonTabControl1.AllowContextButton = true;
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
            this.kryptonTabControl1.Size = new System.Drawing.Size(611, 291);
            this.kryptonTabControl1.TabIndex = 1;
            this.kryptonTabControl1.UseExtendedLayout = false;
            // 
            // FormDesconto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 348);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDesconto";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = -10;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Text = "Descontos";
            this.Load += new System.EventHandler(this.FormDesconto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).EndInit();
            this.panelPadrao.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.kryptonPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.kryptonTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker async_work;
        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Comum.Components.HLP_TextBox txtCodigo;
        private Comum.Components.HLP_TextBox txtxDescontos;
        private Comum.Components.HLP_TextBox txtxDescricao;
        private Comum.Components.HLP_ComboBox cbostLiquidoAtual;
        private Comum.Components.HLP_NumericUpDown nudnMeses;
        private Comum.Components.HLP_NumericUpDown nudnDias;
        private Comum.Components.HLP_NumericUpDown nudpDesconto;
        private Comum.Components.HLP_LabelSeparator hlP_LabelSeparator1_Geral;
    }
}