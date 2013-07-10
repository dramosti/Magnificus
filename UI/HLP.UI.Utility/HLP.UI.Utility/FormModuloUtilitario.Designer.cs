namespace HLP.UI.Utility
{
    partial class FormModuloUtilitario
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
            this.FormConfigAcessoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormConfigBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormConfigRelatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormSelecionaRelatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formAtualizacaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FormConfigAcessoToolStripMenuItem,
            this.FormConfigBaseToolStripMenuItem,
            this.FormConfigRelatorioToolStripMenuItem,
            this.FormSelecionaRelatorioToolStripMenuItem,
            this.formAtualizacaoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(779, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FormConfigAcessoToolStripMenuItem
            // 
            this.FormConfigAcessoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormConfigAcessoToolStripMenuItem.Name = "FormConfigAcessoToolStripMenuItem";
            this.FormConfigAcessoToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.FormConfigAcessoToolStripMenuItem.Text = "Configuração de Acesso";
            // 
            // FormConfigBaseToolStripMenuItem
            // 
            this.FormConfigBaseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormConfigBaseToolStripMenuItem.Name = "FormConfigBaseToolStripMenuItem";
            this.FormConfigBaseToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.FormConfigBaseToolStripMenuItem.Tag = "Modal";
            this.FormConfigBaseToolStripMenuItem.Text = "Configuração de Base";
            // 
            // FormConfigRelatorioToolStripMenuItem
            // 
            this.FormConfigRelatorioToolStripMenuItem.Name = "FormConfigRelatorioToolStripMenuItem";
            this.FormConfigRelatorioToolStripMenuItem.Size = new System.Drawing.Size(157, 20);
            this.FormConfigRelatorioToolStripMenuItem.Text = "Configuração de Relatório";
            // 
            // FormSelecionaRelatorioToolStripMenuItem
            // 
            this.FormSelecionaRelatorioToolStripMenuItem.Name = "FormSelecionaRelatorioToolStripMenuItem";
            this.FormSelecionaRelatorioToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.FormSelecionaRelatorioToolStripMenuItem.Text = "Relatórios";
            // 
            // formAtualizacaoToolStripMenuItem
            // 
            this.formAtualizacaoToolStripMenuItem.Name = "formAtualizacaoToolStripMenuItem";
            this.formAtualizacaoToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.formAtualizacaoToolStripMenuItem.Text = "Atualização";
            // 
            // FormModuloUtilitario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 302);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormModuloUtilitario";
            this.Text = "FormModuloUtilitario";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FormConfigAcessoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FormConfigBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FormConfigRelatorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FormSelecionaRelatorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formAtualizacaoToolStripMenuItem;
    }
}