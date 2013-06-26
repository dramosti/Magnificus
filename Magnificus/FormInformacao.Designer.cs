namespace Magnificus
{
    partial class FormInformacao
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
            this.components = new System.ComponentModel.Container();
            this.timerLoad = new System.Windows.Forms.Timer(this.components);
            this.timerFechaTela = new System.Windows.Forms.Timer(this.components);
            this.lblAviso = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerLoad
            // 
            this.timerLoad.Interval = 1000;
            this.timerLoad.Tick += new System.EventHandler(this.timerLoad_Tick);
            // 
            // timerFechaTela
            // 
            this.timerFechaTela.Tick += new System.EventHandler(this.timerFechaTela_Tick);
            // 
            // lblAviso
            // 
            this.lblAviso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAviso.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.lblAviso.Location = new System.Drawing.Point(0, 0);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(264, 78);
            this.lblAviso.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.StateNormal.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblAviso.StateNormal.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblAviso.TabIndex = 2;
            this.lblAviso.Values.Text = "Aviso";
            this.lblAviso.MouseLeave += new System.EventHandler(this.control_MouseLeave);
            this.lblAviso.MouseMove += new System.Windows.Forms.MouseEventHandler(this.control_MouseMove);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.lblAviso);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(264, 78);
            this.kryptonPanel1.TabIndex = 3;
            // 
            // FormInformacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 78);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInformacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = -10;
            this.Deactivate += new System.EventHandler(this.frmInformacao_Deactivate);
            this.Load += new System.EventHandler(this.FormInformacao_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmInformacao_KeyDown);
            this.MouseLeave += new System.EventHandler(this.control_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.control_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerLoad;
        private System.Windows.Forms.Timer timerFechaTela;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel lblAviso;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;

    }
}

