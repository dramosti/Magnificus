namespace HLP.Comum.UI
{
    partial class FormPesquisaPadraoHeaderCell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPesquisaPadraoHeaderCell));
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.flpComponentes = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFiltro = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.flpComponentes);
            this.kryptonPanel.Controls.Add(this.btnFiltro);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(498, 76);
            this.kryptonPanel.TabIndex = 0;
            // 
            // flpComponentes
            // 
            this.flpComponentes.BackColor = System.Drawing.Color.Transparent;
            this.flpComponentes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpComponentes.Location = new System.Drawing.Point(0, 0);
            this.flpComponentes.Name = "flpComponentes";
            this.flpComponentes.Size = new System.Drawing.Size(498, 33);
            this.flpComponentes.TabIndex = 7;
            // 
            // btnFiltro
            // 
            this.btnFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltro.Location = new System.Drawing.Point(389, 38);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(90, 25);
            this.btnFiltro.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnFiltro.TabIndex = 6;
            this.btnFiltro.Values.Text = "&Aplicar Filtro";
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // FormPesquisaPadraoHeaderCell
            // 
            this.AllowFormChrome = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 76);
            this.Controls.Add(this.kryptonPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPesquisaPadraoHeaderCell";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar";
            this.Load += new System.EventHandler(this.FormPesquisaPadraoHeaderCell_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPesquisaPadraoHeaderCell_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnFiltro;
        private System.Windows.Forms.FlowLayoutPanel flpComponentes;
    }
}

