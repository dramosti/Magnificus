namespace HLP.Comum.UI
{
    partial class FormPesquisaCampo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPesquisaCampo));
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txtValor = new HLP.Comum.Components.HLP_TextBox();
            this.btnFiltro = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.radNaFrase_3 = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.radComecandocom_2 = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.radIgual_1 = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.txtValor);
            this.kryptonPanel.Controls.Add(this.btnFiltro);
            this.kryptonPanel.Controls.Add(this.radNaFrase_3);
            this.kryptonPanel.Controls.Add(this.radComecandocom_2);
            this.kryptonPanel.Controls.Add(this.radIgual_1);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(402, 115);
            this.kryptonPanel.TabIndex = 0;
            // 
            // txtValor
            // 
            this.txtValor._Field = null;
            this.txtValor._Help = "";
            this.txtValor._LabelGroup = null;
            this.txtValor._LabelText = "Valor";
            this.txtValor._Multiline = false;
            this.txtValor._Obrigatorio = HLP.Comum.Components.HLP_TextBox.CampoObrigatorio.NÃO;
            this.txtValor._Password = false;
            this.txtValor._Regex = null;
            this.txtValor._Table = null;
            this.txtValor._TamanhoMaiorLabel = 0;
            this.txtValor._TamanhoComponente = 329;
            this.txtValor._Visible = true;
            this.txtValor.BackColor = System.Drawing.Color.Transparent;
            this.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtValor.Color = System.Drawing.Color.White;
            this.txtValor.Location = new System.Drawing.Point(20, 12);
            this.txtValor.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.txtValor.MaxLength = 32767;
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = false;
            this.txtValor.Size = new System.Drawing.Size(363, 21);
            this.txtValor.TabIndex = 1;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(293, 77);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(90, 25);
            this.btnFiltro.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnFiltro.TabIndex = 5;
            this.btnFiltro.Values.Text = "&Aplicar Filtro";
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // radNaFrase_3
            // 
            this.radNaFrase_3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.radNaFrase_3.Location = new System.Drawing.Point(216, 51);
            this.radNaFrase_3.Name = "radNaFrase_3";
            this.radNaFrase_3.Size = new System.Drawing.Size(65, 19);
            this.radNaFrase_3.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radNaFrase_3.TabIndex = 4;
            this.radNaFrase_3.Values.Text = "Na Frase";
            // 
            // radComecandocom_2
            // 
            this.radComecandocom_2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.radComecandocom_2.Location = new System.Drawing.Point(95, 51);
            this.radComecandocom_2.Name = "radComecandocom_2";
            this.radComecandocom_2.Size = new System.Drawing.Size(107, 19);
            this.radComecandocom_2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radComecandocom_2.TabIndex = 3;
            this.radComecandocom_2.Values.Text = "Começando com";
            // 
            // radIgual_1
            // 
            this.radIgual_1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.radIgual_1.Location = new System.Drawing.Point(40, 51);
            this.radIgual_1.Name = "radIgual_1";
            this.radIgual_1.Size = new System.Drawing.Size(47, 19);
            this.radIgual_1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radIgual_1.TabIndex = 2;
            this.radIgual_1.Values.Text = "Igual";
            // 
            // FormPesquisaCampo
            // 
            this.AllowFormChrome = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 115);
            this.Controls.Add(this.kryptonPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPesquisaCampo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPesquisaCampo_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnFiltro;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton radNaFrase_3;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton radComecandocom_2;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton radIgual_1;
        private Components.HLP_TextBox txtValor;
    }
}

