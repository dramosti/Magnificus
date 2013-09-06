namespace HLP.Comum.UI
{
    partial class FormSenhaSupervisor
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
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txtSenha = new HLP.Comum.Components.HLP_TextBox();
            this.btnCancelar = new HLP.Comum.Components.HLP_Button();
            this.btnConfirmar = new HLP.Comum.Components.HLP_Button();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btnConfirmar);
            this.kryptonPanel1.Controls.Add(this.btnCancelar);
            this.kryptonPanel1.Controls.Add(this.txtSenha);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(487, 162);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // txtSenha
            // 
            this.txtSenha._LabelGroup = null;
            this.txtSenha._LabelText = "Senha:";
            this.txtSenha._Multiline = false;
            this.txtSenha._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtSenha._Password = false;
            this.txtSenha._Regex = null;
            this.txtSenha._TamanhoComponente = 382;
            this.txtSenha._TamanhoMaiorLabel = 0;
            this.txtSenha.BackColor = System.Drawing.Color.Transparent;
            this.txtSenha.Base = null;
            this.txtSenha.bConfiguracao = false;
            this.txtSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSenha.Color = System.Drawing.Color.White;
            this.txtSenha.Location = new System.Drawing.Point(30, 85);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.txtSenha.MaxLength = 32767;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.objConfigComponenteModel = null;
            this.txtSenha.ReadOnly = false;
            this.txtSenha.Size = new System.Drawing.Size(424, 22);
            this.txtSenha.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar._LabelGroup = null;
            this.btnCancelar._LabelText = "Cancelar";
            this.btnCancelar._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.btnCancelar._Regex = null;
            this.btnCancelar._TamanhoComponente = 168;
            this.btnCancelar._TamanhoMaiorLabel = 0;
            this.btnCancelar.Base = null;
            this.btnCancelar.bConfiguracao = false;
            this.btnCancelar.Location = new System.Drawing.Point(307, 127);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.objConfigComponenteModel = null;
            this.btnCancelar.Size = new System.Drawing.Size(168, 24);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar._btnHlpClick += new System.EventHandler(this.btnCancelar__btnHlpClick);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar._LabelGroup = null;
            this.btnConfirmar._LabelText = "Confirmar";
            this.btnConfirmar._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.btnConfirmar._Regex = null;
            this.btnConfirmar._TamanhoComponente = 168;
            this.btnConfirmar._TamanhoMaiorLabel = 0;
            this.btnConfirmar.Base = null;
            this.btnConfirmar.bConfiguracao = false;
            this.btnConfirmar.Location = new System.Drawing.Point(123, 127);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.objConfigComponenteModel = null;
            this.btnConfirmar.Size = new System.Drawing.Size(168, 24);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar._btnHlpClick += new System.EventHandler(this.btnConfirmar__btnHlpClick);
            // 
            // FormSenhaSupervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 162);
            this.Controls.Add(this.kryptonPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSenhaSupervisor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Senha do Supervisor";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Components.HLP_TextBox txtSenha;
        private Components.HLP_Button btnConfirmar;
        private Components.HLP_Button btnCancelar;
    }
}