namespace HLP.Comum.Components
{
    partial class HLP_MaskedTextBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HLP_MaskedTextBox));
            this.msk = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.btnPesquisaCampo = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // msk
            // 
            this.msk.AlwaysActive = false;
            this.msk.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btnPesquisaCampo});
            this.msk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msk.Location = new System.Drawing.Point(73, 0);
            this.msk.Name = "msk";
            this.msk.Size = new System.Drawing.Size(124, 19);
            this.msk.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.msk.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.msk.StateActive.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.msk.StateActive.Border.Width = 1;
            this.msk.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.msk.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.msk.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.msk.StateCommon.Border.Width = 1;
            this.msk.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.msk.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.msk.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.msk.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.msk.StateDisabled.Border.Width = 1;
            this.msk.StateDisabled.Content.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.msk.TabIndex = 3;
            this.msk.TextChanged += new System.EventHandler(this.msk_TextChanged);
            this.msk.Enter += new System.EventHandler(this.msk_Enter);
            this.msk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.msk_KeyPress);
            this.msk.Leave += new System.EventHandler(this.msk_Leave);
            // 
            // btnPesquisaCampo
            // 
            this.btnPesquisaCampo.Image = global::HLP.Comum.Components.Properties.Resources.pesq_azul;
            this.btnPesquisaCampo.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.InputControl;
            this.btnPesquisaCampo.UniqueName = "D972B9CBFAB847E4708C12FFF44D431E";
            this.btnPesquisaCampo.Visible = false;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDescricao.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(0, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(73, 13);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "MaskTextBox";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "HLP - Info";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // HLP_MaskedTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.msk);
            this.Controls.Add(this.lblDescricao);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.Name = "HLP_MaskedTextBox";
            this.Size = new System.Drawing.Size(197, 21);
            this.Load += new System.EventHandler(this.HLP_MaskedTextBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox msk;
        public System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.ErrorProvider errorProvider1;
        public ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnPesquisaCampo;
    }
}
