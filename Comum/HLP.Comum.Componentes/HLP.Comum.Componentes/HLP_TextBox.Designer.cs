namespace HLP.Comum.Components
{
    partial class HLP_TextBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HLP_TextBox));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnPesquisaCampo = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnConfig = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "HLP - Info";
            // 
            // txt
            // 
            this.txt.AlwaysActive = false;
            this.txt.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btnPesquisaCampo,
            this.btnConfig});
            this.txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt.Location = new System.Drawing.Point(46, 0);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(134, 20);
            this.txt.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.txt.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt.StateActive.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txt.StateActive.Border.Width = 1;
            this.txt.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt.StateCommon.Border.Width = 1;
            this.txt.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txt.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.txt.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.txt.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt.StateDisabled.Border.Width = 1;
            this.txt.StateDisabled.Content.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txt.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.txt.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.txt.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt.StateNormal.Border.Width = 1;
            this.txt.TabIndex = 5;
            this.txt.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txt.Enter += new System.EventHandler(this.txt_Enter);
            this.txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            this.txt.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // btnPesquisaCampo
            // 
            this.btnPesquisaCampo.Image = global::HLP.Comum.Components.Properties.Resources.Pesquisa;
            this.btnPesquisaCampo.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.InputControl;
            this.btnPesquisaCampo.UniqueName = "48E09EA72DFA415A4F99CE0538C9FBB2";
            // 
            // btnConfig
            // 
            this.btnConfig.Image = global::HLP.Comum.Components.Properties.Resources._1374622719_70556;
            this.btnConfig.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.InputControl;
            this.btnConfig.UniqueName = "06CA02F59824458249B89DE168D264CF";
            this.btnConfig.Visible = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDescricao.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(0, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(46, 13);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "TextBox";
            this.lblDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // HLP_TextBox
            // 
            this._TamanhoComponente = 80;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.txt);
            this.Controls.Add(this.lblDescricao);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.Name = "HLP_TextBox";
            this.Size = new System.Drawing.Size(180, 22);
            this.Load += new System.EventHandler(this.HLP_TextBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblDescricao;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txt;
        public ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnPesquisaCampo;
        public ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnConfig;

    }
}
