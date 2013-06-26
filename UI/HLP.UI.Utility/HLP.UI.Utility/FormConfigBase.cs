using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Data.Common;
using Ninject;
using HLP.Comum.Services.Interface;
using HLP.Dependencies;
using HLP.Comum.Messages;
using System.IO;
using System.Configuration;
using HLP.Comum.Models;
using HLP.Comum.UI.Exception;

namespace HLP.UI.Utility
{
    public partial class FormConfigBase : KryptonForm
    {
        [Inject]
        public IConfiguraBaseService configuraBaseService { get; set; }

        public bool ConnectionActivated = false;

        string connectionString;

        public FormConfigBase()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
        }
        private void FormConfiguraBase_Load(object sender, EventArgs e)
        {
                cboServer.DataSource = configuraBaseService.GetServer();
                cboServer.cbx.DropDownStyle = ComboBoxStyle.DropDown;
        }



        private void sqlAuthenticationRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sqlAuthenticationRadioButton.Checked == true)
            {
                txtUsuario.Enabled = true;
                txtSenha.Enabled = true;
            }
            else
            {
                txtUsuario.Enabled = false;
                txtSenha.Enabled = false;

                txtUsuario.Text = "";
                txtSenha.Text = "";
            }
        }


        private void cboBanco__Enter(object sender, EventArgs e)
        {
            try
            {
                connectionString = "";
                if (windowsAuthenticationRadioButton.Checked == true)
                {
                    connectionString = "Data Source=" + cboServer.Text + ";Initial Catalog=master;Integrated Security=true;";
                }
                else
                {
                    if (!String.IsNullOrEmpty(txtUsuario.Text) && !String.IsNullOrEmpty(txtSenha.Text))
                    {
                        connectionString = "Data Source=" + cboServer.Text + ";Initial Catalog=master;User Id=" + txtUsuario.Text + ";Password=" + txtSenha.Text + ";";
                    }
                }
                if (!String.IsNullOrEmpty(connectionString))
                {
                    cboBanco.DataSource = null;
                    cboBanco.DataSource = configuraBaseService.GetDatabases(connectionString).Tables[0];
                }
            }
            catch (System.Exception)
            {
                KryptonMessageBox.Show("Não foi possível encontrar Banco de Dados essas informações.", Mensagens.MSG_Aviso, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void cboServer__SelectedIndexChanged(object sender, EventArgs e)
        {
            cboBanco.DataSource = null;
        }


        private void btnTestarConexao_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(cboBanco.Text))
                {
                    KryptonMessageBox.Show("Banco de Dados não foi selecionado", Mensagens.MSG_Aviso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (TestConnection())
                {
                    KryptonMessageBox.Show("Teste de conexão realizado com sucesso!", Mensagens.MSG_Aviso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    KryptonMessageBox.Show("Teste de Conexão não obteve êxito!", Mensagens.MSG_Aviso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (System.Exception ex)
            {
                new HLPexception(ex);
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(cboBanco.Text))
                {
                    KryptonMessageBox.Show("Banco de Dados não foi selecionado", Mensagens.MSG_Aviso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!TestConnection())
                {
                    KryptonMessageBox.Show("Teste de Conexão não obteve êxito!", Mensagens.MSG_Aviso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string userFilePath = Path.Combine(localAppData, "HLP");

                if (!Directory.Exists(userFilePath))
                {
                    Directory.CreateDirectory(userFilePath);
                }

                string sourceFilePath = Path.Combine(System.Windows.Forms.Application.StartupPath, "App.config");
                string destFilePath = Path.Combine(userFilePath, "App.config");

                if (!File.Exists(destFilePath))
                {
                    File.Copy(sourceFilePath, destFilePath);
                }

                Configuration configUser = ConfigurationManager.OpenMappedExeConfiguration(
                    new ExeConfigurationFileMap { ExeConfigFilename = destFilePath }, ConfigurationUserLevel.None);
                configUser.ConnectionStrings.ConnectionStrings["dbPrincipal"].ConnectionString = connectionString;

                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.ConnectionStrings.ConnectionStrings["dbPrincipal"].ConnectionString = connectionString;


                configUser.Save(ConfigurationSaveMode.Modified, false);
                config.Save(ConfigurationSaveMode.Modified, false);
                ConfigurationManager.RefreshSection("connectionStrings");
                ConnectionActivated = true;
                Application.Restart();

            }
            catch (System.Exception ex)
            {
                new HLPexception(ex);
            }
        }


        private bool TestConnection()
        {
            connectionString = "";
            if (windowsAuthenticationRadioButton.Checked == true)
            {
                connectionString = "Data Source=" + cboServer.Text + ";Initial Catalog=" + cboBanco.Text + ";Integrated Security=true;";
            }
            else
            {
                if (!String.IsNullOrEmpty(txtUsuario.Text) && !String.IsNullOrEmpty(txtSenha.Text))
                {
                    connectionString = "Data Source=" + cboServer.Text + ";Initial Catalog=" + cboBanco.Text + ";User Id=" + txtUsuario.Text + ";Password=" + txtSenha.Text + ";";
                }
            }
            if (connectionString != "")
            {
                if (configuraBaseService.TestConnection(connectionString))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool TestCurrentConnection()
        {
                connectionString = "";
                Configuration config = null;

                #region Verifica se o usuario ja tem conexao configurada

                string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string userFilePath = Path.Combine(localAppData, "HLP");

                if (!Directory.Exists(userFilePath))
                {
                    Directory.CreateDirectory(userFilePath);
                }

                string sourceFilePath = Path.Combine(System.Windows.Forms.Application.StartupPath, "App.config");
                string destFilePath = Path.Combine(userFilePath, "App.config");

                if (!File.Exists(destFilePath))
                {
                    File.Copy(sourceFilePath, destFilePath);
                    return false;
                }

                #endregion

                #region Testa a conexao do usuario

                config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                connectionString = config.ConnectionStrings.ConnectionStrings["dbPrincipal"].ConnectionString;

                if (!configuraBaseService.TestConnection(connectionString))
                {
                    config = ConfigurationManager.OpenMappedExeConfiguration(
                    new ExeConfigurationFileMap { ExeConfigFilename = destFilePath }, ConfigurationUserLevel.None);
                    connectionString = config.ConnectionStrings.ConnectionStrings["dbPrincipal"].ConnectionString;

                    if (configuraBaseService.TestConnection(connectionString))
                    {
                        File.Copy(destFilePath, sourceFilePath, true);
                        ConfigurationManager.RefreshSection("connectionStrings");
                        ConnectionActivated = true;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    ConnectionActivated = true;
                    return true;
                }


                #endregion
        }

        private void FormConfigBase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }


    }
}