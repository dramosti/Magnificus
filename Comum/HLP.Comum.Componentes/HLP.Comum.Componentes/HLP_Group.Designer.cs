namespace HLP.Comum.Components
{
    partial class HLP_Group
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
            components = new System.ComponentModel.Container();
            this.HeaderVisibleSecondary = false;
            this.buttonSpecHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();

            this.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup[] {
            this.buttonSpecHeaderGroup1});
            // 
            // buttonSpecHeaderGroup1
            // 
            this.buttonSpecHeaderGroup1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowUp;
            this.buttonSpecHeaderGroup1.UniqueName = "BE729386D6D0493307B6C2D72DE133FB";
            this.buttonSpecHeaderGroup1.Click += new System.EventHandler(this.buttonSpecHeaderGroup1_Click);
            // 
            // KryptonHeaderGroup1.Panel
            // 
            //this.Size = new System.Drawing.Size(176, 129);
            //this.StateCommon.OverlayHeaders = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            //this.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            //this.StateNormal.Border.Color1 = System.Drawing.Color.Transparent;
            //this.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            //| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            //| ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Size = new System.Drawing.Size(176, 129);
            this.StateCommon.OverlayHeaders = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.StateNormal.Back.ColorAngle = 180F;
            this.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateNormal.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.StateNormal.Border.Rounding = 6;
            this.StateNormal.HeaderPrimary.Back.ColorAngle = 180F;
            this.StateNormal.HeaderPrimary.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.StateNormal.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabIndex = 120;
            this.ValuesPrimary.Heading = "Detalhes";
            this.ValuesPrimary.Image = null;
        }

        #endregion

    }
}
