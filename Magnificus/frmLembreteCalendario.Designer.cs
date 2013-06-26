namespace Magnificus
{
    partial class frmLembreteCalendario
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
            this.txtLembrete = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.SuspendLayout();
            // 
            // txtLembrete
            // 
            this.txtLembrete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLembrete.Location = new System.Drawing.Point(0, 0);
            this.txtLembrete.Multiline = true;
            this.txtLembrete.Name = "txtLembrete";
            this.txtLembrete.Size = new System.Drawing.Size(260, 147);
            this.txtLembrete.TabIndex = 0;
            // 
            // frmLembreteCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 147);
            this.Controls.Add(this.txtLembrete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmLembreteCalendario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lembrete";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLembreteCalendario_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLembreteCalendario_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtLembrete;
    }
}