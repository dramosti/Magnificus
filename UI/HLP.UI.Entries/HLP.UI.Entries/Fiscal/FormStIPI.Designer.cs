﻿namespace HLP.UI.Entries.Fiscal
{
    partial class FormStIPI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStIPI));
            this.Principal = new System.Windows.Forms.FlowLayoutPanel();
            this.hlP_LabelSeparator1_Geral = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtCodigo = new HLP.Comum.Components.HLP_TextBox();
            this.txtcCSTIpi = new HLP.Comum.Components.HLP_TextBox();
            this.txtxCSTIpi = new HLP.Comum.Components.HLP_TextBox();
            this.cbostSimplesNacional = new HLP.Comum.Components.HLP_ComboBox();
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
            this.Principal.Controls.Add(this.txtcCSTIpi);
            this.Principal.Controls.Add(this.txtxCSTIpi);
            this.Principal.Controls.Add(this.cbostSimplesNacional);
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
            this.hlP_LabelSeparator1_Geral.Location = new System.Drawing.Point(3, 3);
            this.hlP_LabelSeparator1_Geral.Name = "hlP_LabelSeparator1_Geral";
            this.hlP_LabelSeparator1_Geral.Size = new System.Drawing.Size(468, 18);
            this.hlP_LabelSeparator1_Geral.TabIndex = 29;
            this.hlP_LabelSeparator1_Geral.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo._Field = "idCSTIpi";
            this.txtCodigo._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtCodigo._LabelText = "Código";
            this.txtCodigo._Multiline = false;
            this.txtCodigo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtCodigo._Password = false;
            this.txtCodigo._Regex = null;
            this.txtCodigo._Table = "Situacao_tributaria_ipi";
            this.txtCodigo._TamanhoComponente = 107;
            this.txtCodigo._TamanhoMaiorLabel = 160;
            this.txtCodigo._Visible = true;
            this.txtCodigo.BackColor = System.Drawing.Color.Transparent;
            this.txtCodigo.Base = null;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCodigo.Color = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(118, 27);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(118, 3, 15, 3);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(152, 21);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtcCSTIpi
            // 
            this.txtcCSTIpi._Field = "cCSTIpi";
            this.txtcCSTIpi._Help = "Digite o código da situação tributária de ipi definida pela legislação";
            this.txtcCSTIpi._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtcCSTIpi._LabelText = "Código da situação tributária";
            this.txtcCSTIpi._Multiline = false;
            this.txtcCSTIpi._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtcCSTIpi._Password = false;
            this.txtcCSTIpi._Regex = null;
            this.txtcCSTIpi._Table = "Situacao_tributaria_ipi";
            this.txtcCSTIpi._TamanhoComponente = 220;
            this.txtcCSTIpi._TamanhoMaiorLabel = 160;
            this.txtcCSTIpi._Visible = true;
            this.txtcCSTIpi.BackColor = System.Drawing.Color.Transparent;
            this.txtcCSTIpi.Base = null;
            this.txtcCSTIpi.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtcCSTIpi.Color = System.Drawing.Color.White;
            this.txtcCSTIpi.Location = new System.Drawing.Point(5, 54);
            this.txtcCSTIpi.Margin = new System.Windows.Forms.Padding(5, 3, 15, 3);
            this.txtcCSTIpi.MaxLength = 32767;
            this.txtcCSTIpi.Name = "txtcCSTIpi";
            this.txtcCSTIpi.ReadOnly = false;
            this.txtcCSTIpi.Size = new System.Drawing.Size(378, 21);
            this.txtcCSTIpi.TabIndex = 3;
            // 
            // txtxCSTIpi
            // 
            this.txtxCSTIpi._Field = "xCSTIpi";
            this.txtxCSTIpi._Help = "Descrição do código da situação tributária de ipi";
            this.txtxCSTIpi._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtxCSTIpi._LabelText = "Descrição";
            this.txtxCSTIpi._Multiline = false;
            this.txtxCSTIpi._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxCSTIpi._Password = false;
            this.txtxCSTIpi._Regex = null;
            this.txtxCSTIpi._Table = "Situacao_tributaria_ipi";
            this.txtxCSTIpi._TamanhoComponente = 308;
            this.txtxCSTIpi._TamanhoMaiorLabel = 160;
            this.txtxCSTIpi._Visible = true;
            this.txtxCSTIpi.BackColor = System.Drawing.Color.Transparent;
            this.txtxCSTIpi.Base = null;
            this.txtxCSTIpi.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxCSTIpi.Color = System.Drawing.Color.White;
            this.txtxCSTIpi.Location = new System.Drawing.Point(107, 81);
            this.txtxCSTIpi.Margin = new System.Windows.Forms.Padding(107, 3, 15, 3);
            this.txtxCSTIpi.MaxLength = 10;
            this.txtxCSTIpi.Name = "txtxCSTIpi";
            this.txtxCSTIpi.ReadOnly = false;
            this.txtxCSTIpi.Size = new System.Drawing.Size(364, 21);
            this.txtxCSTIpi.TabIndex = 2;
            // 
            // cbostSimplesNacional
            // 
            this.cbostSimplesNacional._Field = "stSimplesNacional";
            this.cbostSimplesNacional._Help = "Informar se a situação tributária de ipi é de simples nacional";
            this.cbostSimplesNacional._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostSimplesNacional._Itens")));
            this.cbostSimplesNacional._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cbostSimplesNacional._LabelText = "Simples nacional?";
            this.cbostSimplesNacional._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostSimplesNacional._Regex = null;
            this.cbostSimplesNacional._situacao = true;
            this.cbostSimplesNacional._Table = "Situacao_tributaria_ipi";
            this.cbostSimplesNacional._TamanhoComponente = 80;
            this.cbostSimplesNacional._TamanhoMaiorLabel = 160;
            this.cbostSimplesNacional._Visible = true;
            this.cbostSimplesNacional.BackColor = System.Drawing.Color.Transparent;
            this.cbostSimplesNacional.Base = null;
            this.cbostSimplesNacional.Color = System.Drawing.Color.White;
            this.cbostSimplesNacional.DataSource = null;
            this.cbostSimplesNacional.DisplayMember = "DisplayMember";
            this.cbostSimplesNacional.Location = new System.Drawing.Point(65, 108);
            this.cbostSimplesNacional.Margin = new System.Windows.Forms.Padding(65, 3, 15, 3);
            this.cbostSimplesNacional.Name = "cbostSimplesNacional";
            this.cbostSimplesNacional.SelectedIndex = -1;
            this.cbostSimplesNacional.SelectedValue = 0;
            this.cbostSimplesNacional.Size = new System.Drawing.Size(178, 21);
            this.cbostSimplesNacional.TabIndex = 5;
            this.cbostSimplesNacional.ValueMember = "ValueMember";
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
            // FormStIPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 311);
            this.Name = "FormStIPI";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = -10;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Text = "Situação Tributária de Ipi";
            this.Load += new System.EventHandler(this.FormStCOFINS_Load);
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
        private Comum.Components.HLP_TextBox txtcCSTIpi;
        private Comum.Components.HLP_TextBox txtxCSTIpi;
        private Comum.Components.HLP_ComboBox cbostSimplesNacional;
        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel1;
        private Comum.Components.HLP_LabelSeparator hlP_LabelSeparator1_Geral;
    }
}