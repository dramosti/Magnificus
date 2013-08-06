namespace HLP.Comum.Components
{
    partial class UserControlBase
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
            this.errorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctxConfig = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmConfigurar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMoveUp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMoveDown = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).BeginInit();
            this.ctxConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProv
            // 
            this.errorProv.ContainerControl = this;
            // 
            // ctxConfig
            // 
            this.ctxConfig.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxConfig.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.tsmConfigurar,
            this.tsmMoveUp,
            this.tsmMoveDown});
            this.ctxConfig.Name = "contextMenuStrip1";
            this.ctxConfig.Size = new System.Drawing.Size(166, 98);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // tsmConfigurar
            // 
            this.tsmConfigurar.Name = "tsmConfigurar";
            this.tsmConfigurar.Size = new System.Drawing.Size(165, 22);
            this.tsmConfigurar.Text = "Propriedades";
            // 
            // tsmMoveUp
            // 
            this.tsmMoveUp.Name = "tsmMoveUp";
            this.tsmMoveUp.Size = new System.Drawing.Size(165, 22);
            this.tsmMoveUp.Text = "Mover para cima";
            // 
            // tsmMoveDown
            // 
            this.tsmMoveDown.Name = "tsmMoveDown";
            this.tsmMoveDown.Size = new System.Drawing.Size(165, 22);
            this.tsmMoveDown.Text = "Mover para baixo";
            // 
            // UserControlBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UserControlBase";
            this.Size = new System.Drawing.Size(143, 24);
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).EndInit();
            this.ctxConfig.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProv;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmMoveUp;
        private System.Windows.Forms.ToolStripMenuItem tsmMoveDown;
        public System.Windows.Forms.ToolStripMenuItem tsmConfigurar;
        public System.Windows.Forms.ContextMenuStrip ctxConfig;
    }
}
