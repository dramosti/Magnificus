namespace HLP.Comum.UI
{
    partial class FormConfiguraBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfiguraBase));
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cboServer = new HLP.Comum.Components.HLP_ComboBox();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.windowsAuthenticationRadioButton = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.sqlAuthenticationRadioButton = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.txtUsuario = new HLP.Comum.Components.HLP_TextBox();
            this.txtSenha = new HLP.Comum.Components.HLP_TextBox();
            this.cboBanco = new HLP.Comum.Components.HLP_ComboBox();
            this.btnTestarConexao = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnSalvar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.flowLayoutPanel1);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(378, 187);
            this.kryptonPanel.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.cboServer);
            this.flowLayoutPanel1.Controls.Add(this.kryptonPanel1);
            this.flowLayoutPanel1.Controls.Add(this.txtUsuario);
            this.flowLayoutPanel1.Controls.Add(this.txtSenha);
            this.flowLayoutPanel1.Controls.Add(this.cboBanco);
            this.flowLayoutPanel1.Controls.Add(this.kryptonPanel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(378, 187);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // cboServer
            // 
            this.cboServer._Field = null;
            this.cboServer._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cboServer._Itens")));
            this.cboServer._LabelText = "Servidor";
            this.cboServer._Obrigatorio = HLP.Comum.Components.HLP_ComboBox.CampoObrigatorio.NÃO;
            this.cboServer._situacao = false;
            this.cboServer._Table = null;
            this.cboServer._TamanhoComboBox = 201;
            this.cboServer._TamanhoMaiorLabel = 104;
            this.cboServer._Visible = true;
            this.cboServer.BackColor = System.Drawing.Color.Transparent;
            this.cboServer.Color = System.Drawing.Color.White;
            this.cboServer.DataSource = null;
            this.cboServer.DisplayMember = "ServerName";
            this.cboServer.Location = new System.Drawing.Point(48, 3);
            this.cboServer.Margin = new System.Windows.Forms.Padding(48, 3, 15, 3);
            this.cboServer.Name = "cboServer";
            this.cboServer.SelectedIndex = -1;
            this.cboServer.SelectedValue = 0;
            this.cboServer.Size = new System.Drawing.Size(260, 21);
            this.cboServer.TabIndex = 1;
            this.cboServer.ValueMember = "ServerName";
            this.cboServer._SelectedIndexChanged += new System.EventHandler(this.cboServer__SelectedIndexChanged);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.windowsAuthenticationRadioButton);
            this.kryptonPanel1.Controls.Add(this.sqlAuthenticationRadioButton);
            this.kryptonPanel1.Location = new System.Drawing.Point(3, 30);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(363, 27);
            this.kryptonPanel1.TabIndex = 2;
            // 
            // windowsAuthenticationRadioButton
            // 
            this.windowsAuthenticationRadioButton.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.windowsAuthenticationRadioButton.Location = new System.Drawing.Point(7, 3);
            this.windowsAuthenticationRadioButton.Name = "windowsAuthenticationRadioButton";
            this.windowsAuthenticationRadioButton.Size = new System.Drawing.Size(167, 20);
            this.windowsAuthenticationRadioButton.TabIndex = 3;
            this.windowsAuthenticationRadioButton.Values.Text = "Windows Authentication";
            this.windowsAuthenticationRadioButton.CheckedChanged += new System.EventHandler(this.sqlAuthenticationRadioButton_CheckedChanged);
            // 
            // sqlAuthenticationRadioButton
            // 
            this.sqlAuthenticationRadioButton.Checked = true;
            this.sqlAuthenticationRadioButton.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.sqlAuthenticationRadioButton.Location = new System.Drawing.Point(180, 3);
            this.sqlAuthenticationRadioButton.Name = "sqlAuthenticationRadioButton";
            this.sqlAuthenticationRadioButton.Size = new System.Drawing.Size(176, 20);
            this.sqlAuthenticationRadioButton.TabIndex = 4;
            this.sqlAuthenticationRadioButton.Values.Text = "SQL Server Authentication";
            this.sqlAuthenticationRadioButton.CheckedChanged += new System.EventHandler(this.sqlAuthenticationRadioButton_CheckedChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario._Field = null;
            this.txtUsuario._LabelText = "Usuário";
            this.txtUsuario._Multiline = false;
            this.txtUsuario._Obrigatorio = HLP.Comum.Components.HLP_TextBox.CampoObrigatorio.NÃO;
            this.txtUsuario._Password = false;
            this.txtUsuario._Regex = null;
            this.txtUsuario._Table = null;
            this.txtUsuario._TamanhoMaiorLabel = 104;
            this.txtUsuario._TamanhoTextBox = 201;
            this.txtUsuario._Visible = true;
            this.txtUsuario.BackColor = System.Drawing.Color.Transparent;
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUsuario.Color = System.Drawing.Color.White;
            this.txtUsuario.Location = new System.Drawing.Point(52, 63);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(52, 3, 15, 3);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = false;
            this.txtUsuario.Size = new System.Drawing.Size(256, 21);
            this.txtUsuario.TabIndex = 5;
            // 
            // txtSenha
            // 
            this.txtSenha._Field = null;
            this.txtSenha._LabelText = "Senha";
            this.txtSenha._Multiline = false;
            this.txtSenha._Obrigatorio = HLP.Comum.Components.HLP_TextBox.CampoObrigatorio.NÃO;
            this.txtSenha._Password = true;
            this.txtSenha._Regex = null;
            this.txtSenha._Table = null;
            this.txtSenha._TamanhoMaiorLabel = 104;
            this.txtSenha._TamanhoTextBox = 201;
            this.txtSenha._Visible = true;
            this.txtSenha.BackColor = System.Drawing.Color.Transparent;
            this.txtSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSenha.Color = System.Drawing.Color.White;
            this.txtSenha.Location = new System.Drawing.Point(61, 90);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(61, 3, 15, 3);
            this.txtSenha.MaxLength = 32767;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.ReadOnly = false;
            this.txtSenha.Size = new System.Drawing.Size(247, 21);
            this.txtSenha.TabIndex = 6;
            // 
            // cboBanco
            // 
            this.cboBanco._Field = null;
            this.cboBanco._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cboBanco._Itens")));
            this.cboBanco._LabelText = "Banco de Dados";
            this.cboBanco._Obrigatorio = HLP.Comum.Components.HLP_ComboBox.CampoObrigatorio.NÃO;
            this.cboBanco._situacao = false;
            this.cboBanco._Table = null;
            this.cboBanco._TamanhoComboBox = 201;
            this.cboBanco._TamanhoMaiorLabel = 104;
            this.cboBanco._Visible = true;
            this.cboBanco.BackColor = System.Drawing.Color.Transparent;
            this.cboBanco.Color = System.Drawing.Color.White;
            this.cboBanco.DataSource = null;
            this.cboBanco.DisplayMember = "name";
            this.cboBanco.Location = new System.Drawing.Point(3, 117);
            this.cboBanco.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.cboBanco.Name = "cboBanco";
            this.cboBanco.SelectedIndex = -1;
            this.cboBanco.SelectedValue = 0;
            this.cboBanco.Size = new System.Drawing.Size(305, 21);
            this.cboBanco.TabIndex = 7;
            this.cboBanco.ValueMember = "name";
            this.cboBanco._Enter += new System.EventHandler(this.cboBanco__Enter);
            // 
            // btnTestarConexao
            // 
            this.btnTestarConexao.Location = new System.Drawing.Point(65, 3);
            this.btnTestarConexao.Name = "btnTestarConexao";
            this.btnTestarConexao.Size = new System.Drawing.Size(113, 25);
            this.btnTestarConexao.TabIndex = 8;
            this.btnTestarConexao.Values.Text = "&Testar Conexão";
            this.btnTestarConexao.Click += new System.EventHandler(this.btnTestarConexao_Click);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.btnSalvar);
            this.kryptonPanel2.Controls.Add(this.btnTestarConexao);
            this.kryptonPanel2.Location = new System.Drawing.Point(3, 144);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(363, 31);
            this.kryptonPanel2.TabIndex = 9;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(184, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(113, 25);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Values.Text = "&Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FormConfiguraBase
            // 
            this.AllowFormChrome = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 187);
            this.Controls.Add(this.kryptonPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConfiguraBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração de Base";
            this.Load += new System.EventHandler(this.FormConfiguraBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private Components.HLP_TextBox txtSenha;
        private Components.HLP_TextBox txtUsuario;
        private Components.HLP_ComboBox cboBanco;
        private Components.HLP_ComboBox cboServer;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnTestarConexao;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton windowsAuthenticationRadioButton;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton sqlAuthenticationRadioButton;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSalvar;
    }
}

