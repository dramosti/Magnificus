namespace HLP.Comum.Components
{
    partial class HLP_ComboBox
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
            this.cbx = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // controleBase
            // 
            this.controleBase.Size = new System.Drawing.Size(100, 0);
            // 
            // cbx
            // 
            this.cbx.AlwaysActive = false;
            this.cbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx.DisplayMember = "DisplayMember";
            this.cbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx.DropDownWidth = 116;
            this.cbx.Location = new System.Drawing.Point(63, 0);
            this.cbx.Name = "cbx";
            this.cbx.Size = new System.Drawing.Size(137, 20);
            this.cbx.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.cbx.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbx.StateActive.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cbx.StateActive.ComboBox.Border.Width = 1;
            this.cbx.StateActive.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cbx.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.cbx.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbx.StateCommon.ComboBox.Border.Width = 1;
            this.cbx.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cbx.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cbx.StateDisabled.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.cbx.StateDisabled.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.cbx.StateDisabled.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbx.StateDisabled.ComboBox.Border.Width = 1;
            this.cbx.StateDisabled.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cbx.TabIndex = 7;
            this.cbx.ValueMember = "ValueMember";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDescricao.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(0, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(63, 13);
            this.lblDescricao.TabIndex = 6;
            this.lblDescricao.Text = "ComboBox";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 0;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // HLP_ComboBox
            // 
            this._TamanhoComponente = 100;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbx);
            this.Controls.Add(this.lblDescricao);
            this.Name = "HLP_ComboBox";
            this.Size = new System.Drawing.Size(200, 21);
            ((System.ComponentModel.ISupportInitialize)(this.cbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public ComponentFactory.Krypton.Toolkit.KryptonComboBox cbx;
        public System.Windows.Forms.Label lblDescricao;
        public System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
