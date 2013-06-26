namespace HLP.Comum.Components
{
    partial class HLP_CheckListBox
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
            this.lblDescricao = new System.Windows.Forms.Label();
            this.chk = new ComponentFactory.Krypton.Toolkit.KryptonCheckedListBox();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDescricao.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(0, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(74, 13);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "CheckListBox";
            // 
            // chk
            // 
            this.chk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chk.Location = new System.Drawing.Point(74, 0);
            this.chk.Name = "chk";
            this.chk.Size = new System.Drawing.Size(76, 150);
            this.chk.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.chk.StateDisabled.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.chk.TabIndex = 2;
            // 
            // HLP_CheckListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.chk);
            this.Controls.Add(this.lblDescricao);
            this.DoubleBuffered = true;
            this.Name = "HLP_CheckListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblDescricao;
        public ComponentFactory.Krypton.Toolkit.KryptonCheckedListBox chk;
    }
}
