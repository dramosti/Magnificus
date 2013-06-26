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
using HLP.Comum.Business;
using HLP.Comum.Messages;
using System.Configuration;
using System.IO;

namespace HLP.Comum.UI
{
    public partial class FormConfiguraBase : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        [Inject]
        public IConfiguraBaseService configuraBaseService { get; set; }

        string connectionString = "";
        public bool ConexaoAtiva = false;

        public FormConfiguraBase()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
        }
        private void FormConfiguraBase_Load(object sender, EventArgs e)
        {
            try
            {
                cboServer.DataSource = configuraBaseService.GetServer();
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
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
                if (connectionString != "")
                {
                    cboBanco.DataSource = configuraBaseService.GetDatabases(connectionString).Tables[0];
                }
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show("O sistema não conseguiu encontrar Banco de Dados com as informações fornecidas.", Mensagens.MSG_Aviso, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void cboServer__SelectedIndexChanged(object sender, EventArgs e)
        {
            cboBanco.DataSource = null;
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


        private void btnTestarConexao_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(cboBanco.Text))
                {
                    KryptonMessageBox.Show("Banco de Dados não foi selecionado.", Mensagens.MSG_Aviso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (TestaConexao())
                {
                    KryptonMessageBox.Show("Teste de conexão realizado com sucesso!", Mensagens.MSG_Aviso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    KryptonMessageBox.Show("Teste de conexão não obteve êxito!", Mensagens.MSG_Aviso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
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
                    KryptonMessageBox.Show("Banco de Dados não foi selecionado.", Mensagens.MSG_Aviso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!TestaConexao())
                {
                    KryptonMessageBox.Show("Teste de conexão não obteve êxito!", Mensagens.MSG_Aviso, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.ConnectionStrings.ConnectionStrings["dbPrincipal"].ConnectionString = connectionString;

                Configuration configUser = ConfigurationManager.OpenMappedExeConfiguration(
                             new ExeConfigurationFileMap { ExeConfigFilename = destFilePath }, ConfigurationUserLevel.None);
                configUser.ConnectionStrings.ConnectionStrings["dbPrincipal"].ConnectionString = connectionString;


                config.Save(ConfigurationSaveMode.Modified, false);
                configUser.Save(ConfigurationSaveMode.Modified, false);
                ConfigurationManager.RefreshSection("connectionStrings");

                this.Close();
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }


        private bool TestaConexao()
        {
            string database = cboBanco.Text;
            if (windowsAuthenticationRadioButton.Checked == true)
            {
                connectionString = "Data Source=" + cboServer.Text + ";Initial Catalog=" + database + ";Integrated Security=true;";
            }
            else
            {
                connectionString = "Data Source=" + cboServer.Text + ";Initial Catalog=" + database + ";User Id=" + txtUsuario.Text + ";Password=" + txtSenha.Text + ";";
            }
            if (configuraBaseService.TestConnection(connectionString))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool TestaConexaoExistente()
        {
            try
            {
                Configuration config = null;
                string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string userFilePath = Path.Combine(localAppData, "HLP");


                #region Verifica se o App.config existe no pc do usuario, se existir, ele ja foi configurado

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


                #region Verifica se conexao atual é a que o usuario configurou

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
                        ConexaoAtiva = true;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    ConexaoAtiva = true;
                    return true;
                }

                #endregion

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}