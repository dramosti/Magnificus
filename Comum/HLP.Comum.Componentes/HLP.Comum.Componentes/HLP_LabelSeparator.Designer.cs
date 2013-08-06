namespace HLP.Comum.Components
{
    partial class HLP_LabelSeparator
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
            this.headerSep = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btnStatus = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.SuspendLayout();
            // 
            // headerSep
            // 
            this.headerSep.AllowButtonSpecToolTips = true;
            this.headerSep.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.headerSep.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btnStatus});
            this.headerSep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerSep.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary;
            this.headerSep.Location = new System.Drawing.Point(0, 0);
            this.headerSep.Name = "headerSep";
            this.headerSep.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.headerSep.Size = new System.Drawing.Size(159, 19);
            this.headerSep.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerSep.TabIndex = 6;
            this.headerSep.TabStop = false;
            this.headerSep.Values.Description = "";
            this.headerSep.Values.Heading = "Sort";
            this.headerSep.Values.Image = null;
            // 
            // btnStatus
            // 
            this.btnStatus.Image = global::HLP.Comum.Components.Properties.Resources.seta_up;
            this.btnStatus.UniqueName = "07BE7E87F23641F7DC8ADC4B59E713DB";
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // HLP_LabelSeparator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.headerSep);
            this.Name = "HLP_LabelSeparator";
            this.Size = new System.Drawing.Size(159, 19);
            this.Load += new System.EventHandler(this.HLP_LabelSeparator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeader headerSep;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnStatus;





    }
}
