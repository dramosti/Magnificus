namespace HLP.Comum.Components
{
    partial class FormObservacao
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.importarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.arquivoWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arquivoTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(520, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // importarToolStripMenuItem1
            // 
            this.importarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoWordToolStripMenuItem,
            this.arquivoTextoToolStripMenuItem});
            this.importarToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importarToolStripMenuItem1.Name = "importarToolStripMenuItem1";
            this.importarToolStripMenuItem1.Size = new System.Drawing.Size(63, 20);
            this.importarToolStripMenuItem1.Text = "Importar";
            // 
            // arquivoWordToolStripMenuItem
            // 
            this.arquivoWordToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arquivoWordToolStripMenuItem.Name = "arquivoWordToolStripMenuItem";
            this.arquivoWordToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.arquivoWordToolStripMenuItem.Text = "Arquivo Word";
            this.arquivoWordToolStripMenuItem.Click += new System.EventHandler(this.arquivoWordToolStripMenuItem_Click);
            // 
            // arquivoTextoToolStripMenuItem
            // 
            this.arquivoTextoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arquivoTextoToolStripMenuItem.Name = "arquivoTextoToolStripMenuItem";
            this.arquivoTextoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.arquivoTextoToolStripMenuItem.Text = "Arquivo Texto";
            this.arquivoTextoToolStripMenuItem.Click += new System.EventHandler(this.arquivoTextoToolStripMenuItem_Click);
            // 
            // rtbText
            // 
            this.rtbText.BackColor = System.Drawing.SystemColors.Window;
            this.rtbText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbText.Location = new System.Drawing.Point(0, 24);
            this.rtbText.MaxLength = 5000;
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(520, 325);
            this.rtbText.TabIndex = 4;
            this.rtbText.Text = "";
            // 
            // FormObservacao
            // 
            this.AllowFormChrome = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 349);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.Name = "FormObservacao";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Observação";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormObservacao_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormObservacao_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem arquivoWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arquivoTextoToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.OpenFileDialog openFileDialog;

    }
}

