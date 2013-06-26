namespace Magnificus
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.cbxIdEmpresa = new HLP.Comum.Components.HLP_ComboBox();
            this.txtxID = new HLP.Comum.Components.HLP_TextBox();
            this.txtxSenha = new HLP.Comum.Components.HLP_TextBox();
            this.btnLogin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxIdEmpresa
            // 
            this.cbxIdEmpresa._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbxIdEmpresa._Itens")));
            this.cbxIdEmpresa._LabelGroup = null;
            this.cbxIdEmpresa._LabelText = "Empresa";
            this.cbxIdEmpresa._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbxIdEmpresa._Regex = null;
            this.cbxIdEmpresa._situacao = false;
            this.cbxIdEmpresa._TamanhoComponente = 200;
            this.cbxIdEmpresa._TamanhoMaiorLabel = 70;
            this.cbxIdEmpresa._Visible = false;
            this.cbxIdEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.cbxIdEmpresa.Base = null;
            this.cbxIdEmpresa.Color = System.Drawing.Color.White;
            this.cbxIdEmpresa.DataSource = null;
            this.cbxIdEmpresa.DisplayMember = "DisplayMember";
            this.cbxIdEmpresa.Location = new System.Drawing.Point(23, 36);
            this.cbxIdEmpresa.Margin = new System.Windows.Forms.Padding(23, 3, 15, 3);
            this.cbxIdEmpresa.Name = "cbxIdEmpresa";
            this.cbxIdEmpresa.SelectedIndex = -1;
            this.cbxIdEmpresa.SelectedValue = 0;
            this.cbxIdEmpresa.Size = new System.Drawing.Size(250, 21);
            this.cbxIdEmpresa.TabIndex = 0;
            this.cbxIdEmpresa.ValueMember = "ValueMember";
            // 
            // txtxID
            // 
            this.txtxID._LabelGroup = null;
            this.txtxID._LabelText = "Usuário";
            this.txtxID._Multiline = false;
            this.txtxID._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxID._Password = false;
            this.txtxID._Regex = null;
            this.txtxID._TamanhoComponente = 165;
            this.txtxID._TamanhoMaiorLabel = 70;
            this.txtxID._Visible = false;
            this.txtxID.BackColor = System.Drawing.Color.Transparent;
            this.txtxID.Base = null;
            this.txtxID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxID.Color = System.Drawing.Color.White;
            this.txtxID.Location = new System.Drawing.Point(26, 63);
            this.txtxID.Margin = new System.Windows.Forms.Padding(26, 3, 15, 3);
            this.txtxID.MaxLength = 32767;
            this.txtxID.Name = "txtxID";
            this.txtxID.ReadOnly = false;
            this.txtxID.Size = new System.Drawing.Size(212, 21);
            this.txtxID.TabIndex = 1;
            // 
            // txtxSenha
            // 
            this.txtxSenha._LabelGroup = null;
            this.txtxSenha._LabelText = "Senha";
            this.txtxSenha._Multiline = false;
            this.txtxSenha._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxSenha._Password = false;
            this.txtxSenha._Regex = null;
            this.txtxSenha._TamanhoComponente = 164;
            this.txtxSenha._TamanhoMaiorLabel = 70;
            this.txtxSenha._Visible = false;
            this.txtxSenha.BackColor = System.Drawing.Color.Transparent;
            this.txtxSenha.Base = null;
            this.txtxSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxSenha.Color = System.Drawing.Color.White;
            this.txtxSenha.Location = new System.Drawing.Point(34, 90);
            this.txtxSenha.Margin = new System.Windows.Forms.Padding(34, 3, 15, 3);
            this.txtxSenha.MaxLength = 32767;
            this.txtxSenha.Name = "txtxSenha";
            this.txtxSenha.ReadOnly = false;
            this.txtxSenha.Size = new System.Drawing.Size(203, 21);
            this.txtxSenha.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(144, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(90, 25);
            this.btnLogin.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Values.Text = "&Entrar";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Magnificus.Properties.Resources.icone_hlp2;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 27);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.flowLayoutPanel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(293, 160);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.cbxIdEmpresa);
            this.flowLayoutPanel1.Controls.Add(this.txtxID);
            this.flowLayoutPanel1.Controls.Add(this.txtxSenha);
            this.flowLayoutPanel1.Controls.Add(this.kryptonPanel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(293, 160);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.btnLogin);
            this.kryptonPanel2.Location = new System.Drawing.Point(3, 117);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(270, 36);
            this.kryptonPanel2.TabIndex = 5;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 160);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login - Magnificus 2012";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormLogin_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLogin;
        private HLP.Comum.Components.HLP_ComboBox cbxIdEmpresa;
        private HLP.Comum.Components.HLP_TextBox txtxID;
        private HLP.Comum.Components.HLP_TextBox txtxSenha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;

    }
}

