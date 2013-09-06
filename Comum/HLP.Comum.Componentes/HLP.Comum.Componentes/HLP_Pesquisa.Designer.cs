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
            this.components = new System.ComponentModel.Container();
            this.txtDisplay = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtPesquisa = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnPesquisa = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.AlwaysActive = false;
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
            this.txtDisplay.TabIndex = 9;
            this.txtDisplay.TabStop = false;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.AlwaysActive = false;
            this.txtPesquisa.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btnPesquisa});
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
            this.txtPesquisa.TabIndex = 8;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Image = global::HLP.Comum.Components.Properties.Resources.filtro;
            this.btnPesquisa.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.InputControl;
            this.btnPesquisa.Tag = "";
            this.btnPesquisa.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Context;
            this.btnPesquisa.UniqueName = "5E20914B52404B8A07B1D788A0D293E2";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDescricao.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(0, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(52, 13);
            this.lblDescricao.TabIndex = 7;
            this.lblDescricao.Text = "Pesquisa";
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
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 0;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // HLP_Pesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.lblDescricao);
            this.Name = "HLP_Pesquisa";
            this.Size = new System.Drawing.Size(420, 21);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDisplay;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPesquisa;
        public ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnPesquisa;
        public System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        public System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
