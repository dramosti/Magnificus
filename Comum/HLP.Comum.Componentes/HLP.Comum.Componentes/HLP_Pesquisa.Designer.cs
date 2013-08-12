namespace HLP.Comum.Components
{
    partial class HLP_Pesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HLP_Pesquisa));
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtPesquisa = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDisplay = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
            this.btnPesquisa = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDescricao.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(0, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(52, 13);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Pesquisa";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.AlwaysActive = false;
            this.txtPesquisa.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btnPesquisa});
            this.txtPesquisa.ContextMenuStrip = this.contextMenuStrip1;
            this.txtPesquisa.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtPesquisa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(52, 0);
            this.txtPesquisa.MaxLength = 10;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(90, 20);
            this.txtPesquisa.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.txtPesquisa.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPesquisa.StateActive.Border.Width = 1;
            this.txtPesquisa.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtPesquisa.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.txtPesquisa.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPesquisa.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtPesquisa.StateCommon.Border.Width = 1;
            this.txtPesquisa.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtPesquisa.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.txtPesquisa.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPesquisa.StateDisabled.Border.Width = 1;
            this.txtPesquisa.StateDisabled.Content.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtPesquisa.TabIndex = 3;
            this.txtPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisa_KeyPress);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(214, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(213, 22);
            this.toolStripMenuItem1.Text = "Ir para Formulário Principal";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.AlwaysActive = false;
            this.txtDisplay.ContextMenuStrip = this.contextMenuStrip1;
            this.txtDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDisplay.Location = new System.Drawing.Point(142, 0);
            this.txtDisplay.MinimumSize = new System.Drawing.Size(196, 20);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(278, 20);
            this.txtDisplay.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.txtDisplay.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDisplay.StateActive.Border.Width = 1;
            this.txtDisplay.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtDisplay.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.txtDisplay.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDisplay.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtDisplay.StateCommon.Border.Width = 1;
            this.txtDisplay.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtDisplay.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.txtDisplay.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDisplay.StateDisabled.Border.Width = 1;
            this.txtDisplay.StateDisabled.Content.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtDisplay.TabIndex = 6;
            this.txtDisplay.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Image = global::HLP.Comum.Components.Properties.Resources.filtro;
            this.btnPesquisa.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.InputControl;
            this.btnPesquisa.Tag = "";
            this.btnPesquisa.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Context;
            this.btnPesquisa.UniqueName = "5E20914B52404B8A07B1D788A0D293E2";
            // 
            // HLP_Pesquisa
            // 
            this._TamanhoComponente = 320;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.lblDescricao);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.Name = "HLP_Pesquisa";
            this.Size = new System.Drawing.Size(420, 21);
            this.Load += new System.EventHandler(this.HLP_Pesquisa_Load);
            this.Enter += new System.EventHandler(this.HLP_Pesquisa_Enter);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblDescricao;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPesquisa;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDisplay;
        public System.Windows.Forms.ErrorProvider errorProvider1;
        public ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnPesquisa;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}
