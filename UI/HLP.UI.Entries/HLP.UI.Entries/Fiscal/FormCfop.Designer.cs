﻿namespace HLP.UI.Entries.Fiscal
{
    partial class FormCfop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCfop));
            this.hlP_Group2 = new HLP.Comum.Components.HLP_Group();
            this.kryptonTabControl1 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kryptonPanel1 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtCodigo = new HLP.Comum.Components.HLP_TextBox();
            this.nudcCfop = new HLP.Comum.Components.HLP_NumericUpDown();
            this.txtxCfopResumida = new HLP.Comum.Components.HLP_TextBox();
            this.txtxCfop = new HLP.Comum.Components.HLP_TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).BeginInit();
            this.panelPadrao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelAtalhos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hlP_Group2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hlP_Group2.Panel)).BeginInit();
            this.hlP_Group2.Panel.SuspendLayout();
            this.hlP_Group2.SuspendLayout();
            this.kryptonTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.kryptonPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(833, 474);
            // 
            // panelPadrao
            // 
            this.panelPadrao.Controls.Add(this.kryptonTabControl1);
            this.panelPadrao.Size = new System.Drawing.Size(801, 450);
            // 
            // panelAtalhos
            // 
            this.panelAtalhos.Size = new System.Drawing.Size(28, 450);
            // 
            // hlP_Group2
            // 
            this.hlP_Group2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hlP_Group2.HeaderVisibleSecondary = false;
            this.hlP_Group2.Location = new System.Drawing.Point(0, 0);
            this.hlP_Group2.Name = "hlP_Group2";
            // 
            // hlP_Group2.Panel
            // 
            this.hlP_Group2.Panel.Controls.Add(this.flowLayoutPanel2);
            this.hlP_Group2.PositionComponente = HLP.Comum.Components.HLP_Group.Posicao.TopDown;
            this.hlP_Group2.Size = new System.Drawing.Size(787, 415);
            this.hlP_Group2.StateCommon.OverlayHeaders = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.hlP_Group2.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.hlP_Group2.StateNormal.Border.Color1 = System.Drawing.Color.Transparent;
            this.hlP_Group2.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.hlP_Group2.StateNormal.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hlP_Group2.TabIndex = 121;
            this.hlP_Group2.TextHeader = "Geral";
            this.hlP_Group2.ValuesPrimary.Heading = "Geral";
            this.hlP_Group2.ValuesPrimary.Image = null;
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
            this.kryptonTabControl1.Size = new System.Drawing.Size(795, 444);
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
            this.tabPage1.Size = new System.Drawing.Size(787, 415);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = false;
            this.tabPage1.Text = "Principal";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.BorderWidth = 0;
            this.kryptonPanel1.Controls.Add(this.hlP_Group2);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.kryptonPanel1.GradientToogleColors = false;
            this.kryptonPanel1.GradientUseBlend = false;
            this.kryptonPanel1.GradientUseSolid = true;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PersistentColors = false;
            this.kryptonPanel1.Size = new System.Drawing.Size(787, 415);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.txtCodigo);
            this.flowLayoutPanel2.Controls.Add(this.nudcCfop);
            this.flowLayoutPanel2.Controls.Add(this.txtxCfopResumida);
            this.flowLayoutPanel2.Controls.Add(this.txtxCfop);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(785, 393);
            this.flowLayoutPanel2.TabIndex = 123;
            // 
            // txtCodigo
            // 
            this.txtCodigo._Field = "idCfop";
            this.txtCodigo._Help = "Chave principal do registro da cfop";
            this.txtCodigo._LabelGroup = null;
            this.txtCodigo._LabelSuperior = false;
            this.txtCodigo._LabelText = "Código";
            this.txtCodigo._Multiline = false;
            this.txtCodigo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtCodigo._Password = false;
            this.txtCodigo._Regex = null;
            this.txtCodigo._Table = "Cfop";
            this.txtCodigo._TamanhoComponente = 107;
            this.txtCodigo._TamanhoMaiorLabel = 106;
            this.txtCodigo.BackColor = System.Drawing.Color.Transparent;
            this.txtCodigo.Base = null;
            this.txtCodigo.bConfiguracao = false;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCodigo.Color = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(64, 3);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(64, 3, 15, 3);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.objConfigComponenteModel = null;
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(152, 22);
            this.txtCodigo.TabIndex = 9;
            // 
            // nudcCfop
            // 
            this.nudcCfop._Field = "cCfop";
            this.nudcCfop._Help = "Informar o código padrão da cfop fornecida pelo seu órgão emissor.";
            this.nudcCfop._LabelGroup = null;
            this.nudcCfop._LabelSuperior = false;
            this.nudcCfop._LabelText = "Cfop";
            this.nudcCfop._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudcCfop._Regex = null;
            this.nudcCfop._Table = "Cfop";
            this.nudcCfop._TamanhoComponente = 107;
            this.nudcCfop._TamanhoMaiorLabel = 106;
            this.nudcCfop.BackColor = System.Drawing.Color.Transparent;
            this.nudcCfop.Base = null;
            this.nudcCfop.bConfiguracao = false;
            this.nudcCfop.Color = System.Drawing.Color.White;
            this.nudcCfop.DecimalPlaces = 2;
            this.nudcCfop.Location = new System.Drawing.Point(77, 31);
            this.nudcCfop.Margin = new System.Windows.Forms.Padding(77, 3, 15, 3);
            this.nudcCfop.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudcCfop.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudcCfop.Name = "nudcCfop";
            this.nudcCfop.objConfigComponenteModel = null;
            this.nudcCfop.ReadOnly = false;
            this.nudcCfop.Size = new System.Drawing.Size(139, 22);
            this.nudcCfop.TabIndex = 12;
            this.nudcCfop.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudcCfop.ValueInt = 0;
            // 
            // txtxCfopResumida
            // 
            this.txtxCfopResumida._Field = "xCfopResumida";
            this.txtxCfopResumida._Help = "Informar uma descrição abreviada do cfop. esse campo sairá na nf por isso que há " +
    "necessidade da abreviação da descrição da cfop.";
            this.txtxCfopResumida._LabelGroup = null;
            this.txtxCfopResumida._LabelSuperior = false;
            this.txtxCfopResumida._LabelText = "Descrição resumida";
            this.txtxCfopResumida._Multiline = false;
            this.txtxCfopResumida._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxCfopResumida._Password = false;
            this.txtxCfopResumida._Regex = null;
            this.txtxCfopResumida._Table = "Cfop";
            this.txtxCfopResumida._TamanhoComponente = 208;
            this.txtxCfopResumida._TamanhoMaiorLabel = 106;
            this.txtxCfopResumida.BackColor = System.Drawing.Color.Transparent;
            this.txtxCfopResumida.Base = null;
            this.txtxCfopResumida.bConfiguracao = false;
            this.txtxCfopResumida.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxCfopResumida.Color = System.Drawing.Color.White;
            this.txtxCfopResumida.Location = new System.Drawing.Point(3, 59);
            this.txtxCfopResumida.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.txtxCfopResumida.MaxLength = 32767;
            this.txtxCfopResumida.Name = "txtxCfopResumida";
            this.txtxCfopResumida.objConfigComponenteModel = null;
            this.txtxCfopResumida.ReadOnly = false;
            this.txtxCfopResumida.Size = new System.Drawing.Size(314, 22);
            this.txtxCfopResumida.TabIndex = 11;
            // 
            // txtxCfop
            // 
            this.txtxCfop._Field = "xCfop";
            this.txtxCfop._Help = "Descrição detalhada da cfop.";
            this.txtxCfop._LabelGroup = null;
            this.txtxCfop._LabelSuperior = false;
            this.txtxCfop._LabelText = "Descrição";
            this.txtxCfop._Multiline = false;
            this.txtxCfop._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxCfop._Password = false;
            this.txtxCfop._Regex = null;
            this.txtxCfop._Table = "Cfop";
            this.txtxCfop._TamanhoComponente = 630;
            this.txtxCfop._TamanhoMaiorLabel = 106;
            this.txtxCfop.BackColor = System.Drawing.Color.Transparent;
            this.txtxCfop.Base = null;
            this.txtxCfop.bConfiguracao = false;
            this.txtxCfop.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxCfop.Color = System.Drawing.Color.White;
            this.txtxCfop.Location = new System.Drawing.Point(53, 87);
            this.txtxCfop.Margin = new System.Windows.Forms.Padding(53, 3, 15, 3);
            this.txtxCfop.MaxLength = 44;
            this.txtxCfop.Name = "txtxCfop";
            this.txtxCfop.objConfigComponenteModel = null;
            this.txtxCfop.ReadOnly = false;
            this.txtxCfop.Size = new System.Drawing.Size(686, 22);
            this.txtxCfop.TabIndex = 10;
            // 
            // FormCfop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 501);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCfop";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = -10;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Text = "CFOP - Código Fiscais de Operação e Prestações";
            this.Load += new System.EventHandler(this.FormCfop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).EndInit();
            this.panelPadrao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelAtalhos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hlP_Group2.Panel)).EndInit();
            this.hlP_Group2.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hlP_Group2)).EndInit();
            this.hlP_Group2.ResumeLayout(false);
            this.kryptonTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.kryptonPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel1;
        private Comum.Components.HLP_Group hlP_Group2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Comum.Components.HLP_TextBox txtCodigo;
        private Comum.Components.HLP_NumericUpDown nudcCfop;
        private Comum.Components.HLP_TextBox txtxCfopResumida;
        private Comum.Components.HLP_TextBox txtxCfop;
    }
}