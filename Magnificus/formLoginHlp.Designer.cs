namespace Magnificus
{
    partial class formLoginHlp
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtxSenha = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lTimer = new System.Windows.Forms.Label();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbxIdEmpresa = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtxID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxIdEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.txtxSenha);
            this.panel2.Controls.Add(this.lTimer);
            this.panel2.Controls.Add(this.kryptonLabel3);
            this.panel2.Controls.Add(this.cbxIdEmpresa);
            this.panel2.Controls.Add(this.kryptonLabel2);
            this.panel2.Controls.Add(this.txtxID);
            this.panel2.Controls.Add(this.kryptonLabel1);
            this.panel2.Location = new System.Drawing.Point(24, 209);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 229);
            this.panel2.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(300, 181);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(90, 25);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Values.Text = "Entrar";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtxSenha
            // 
            this.txtxSenha.Location = new System.Drawing.Point(133, 144);
            this.txtxSenha.Name = "txtxSenha";
            this.txtxSenha.PasswordChar = '●';
            this.txtxSenha.Size = new System.Drawing.Size(257, 20);
            this.txtxSenha.TabIndex = 3;
            this.txtxSenha.UseSystemPasswordChar = true;
            this.txtxSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxIdEmpresa_KeyPress);
            // 
            // lTimer
            // 
            this.lTimer.AutoSize = true;
            this.lTimer.BackColor = System.Drawing.Color.Transparent;
            this.lTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTimer.ForeColor = System.Drawing.Color.White;
            this.lTimer.Location = new System.Drawing.Point(3, 200);
            this.lTimer.Name = "lTimer";
            this.lTimer.Size = new System.Drawing.Size(80, 24);
            this.lTimer.TabIndex = 4;
            this.lTimer.Text = "00:00:00";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(133, 128);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(46, 20);
            this.kryptonLabel3.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel3.TabIndex = 4;
            this.kryptonLabel3.Values.Text = "Senha:";
            // 
            // cbxIdEmpresa
            // 
            this.cbxIdEmpresa.DropDownWidth = 228;
            this.cbxIdEmpresa.Location = new System.Drawing.Point(133, 38);
            this.cbxIdEmpresa.Name = "cbxIdEmpresa";
            this.cbxIdEmpresa.Size = new System.Drawing.Size(257, 21);
            this.cbxIdEmpresa.TabIndex = 1;
            this.cbxIdEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxIdEmpresa_KeyPress);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(133, 22);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(60, 20);
            this.kryptonLabel2.StateNormal.LongText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel2.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel2.TabIndex = 2;
            this.kryptonLabel2.Values.Text = "Empresa:";
            // 
            // txtxID
            // 
            this.txtxID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtxID.Location = new System.Drawing.Point(133, 91);
            this.txtxID.Name = "txtxID";
            this.txtxID.Size = new System.Drawing.Size(257, 20);
            this.txtxID.TabIndex = 2;
            this.txtxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxIdEmpresa_KeyPress);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(133, 74);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(55, 20);
            this.kryptonLabel1.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Usuário:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(2, 438);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(329, 20);
            this.kryptonLabel5.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel5.TabIndex = 6;
            this.kryptonLabel5.Values.Text = "HLP Estratégia em Sistemas. Todos os Direitos Reservados.";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.AutoSize = true;
            this.kryptonButton1.Location = new System.Drawing.Point(543, 18);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kryptonButton1.Size = new System.Drawing.Size(28, 28);
            this.kryptonButton1.TabIndex = 7;
            this.kryptonButton1.Values.Image = global::Magnificus.Properties.Resources._1371238391_exit;
            this.kryptonButton1.Values.Text = "";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // formLoginHlp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Magnificus.Properties.Resources.hlp_bg_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(583, 463);
            this.ControlBox = false;
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formLoginHlp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formLoginHlp_FormClosed);
            this.Load += new System.EventHandler(this.formLoginHlp_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formLoginHlp_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxIdEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLogin;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtxSenha;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbxIdEmpresa;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtxID;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.Label lTimer;
        private System.Windows.Forms.Timer timer1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}