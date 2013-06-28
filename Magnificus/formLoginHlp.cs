using ComponentFactory.Krypton.Toolkit;
using HLP.Comum.Models.Static;
using HLP.Comum.UI;
using HLP.Comum.UI.Exception;
using HLP.Dependencies;
using HLP.Models.Entries.Gerais;
using HLP.Services.Interfaces.Entries.Gerais;
using Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magnificus
{
    public partial class formLoginHlp : Form
    {
        [Inject]
        public IFuncionarioService usuarioService { get; set; }

        [Inject]
        public IEmpresaService empresaService { get; set; }

        public formLoginHlp()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
            cbxIdEmpresa.DisplayMember = "xFantasia";
            cbxIdEmpresa.ValueMember = "idEmpresa";
            cbxIdEmpresa.DataSource = empresaService.GetAllEmpresa(true);
            lTimer.Text = DateTime.Now.TimeOfDay.ToString().Remove(8);
            timer1.Start();
        }

        void Login()
        {
            UserData.bLogado = false;
            if (usuarioService.ValidaNomeUsuario(txtxID.Text.Trim()))
            {
                FuncionarioModel objUsuario = usuarioService.ValidaUsuario(txtxID.Text, txtxSenha.Text);

                if (objUsuario != null)
                {

                    if (objUsuario.stUsuarioAtivo)
                    {
                        if (usuarioService.ValidaAcesso(Convert.ToInt32(cbxIdEmpresa.SelectedValue), (int)objUsuario.idFuncionario))
                        {
                            CompanyData.idEmpresa = Convert.ToInt32(cbxIdEmpresa.SelectedValue);
                            CompanyData.xNome = (cbxIdEmpresa.SelectedItem as EmpresaModel).xNome.Split('-')[1].Trim();
                            CompanyData.xFantasia = (cbxIdEmpresa.SelectedItem as EmpresaModel).xFantasia.Split('-')[1].Trim();
                            CompanyData.xLinqLogoEmpresa = (cbxIdEmpresa.SelectedItem as EmpresaModel).xLinkLogoEmpresa;

                            Pastas.Path_SettingsEmpresa = (cbxIdEmpresa.SelectedItem as EmpresaModel).xLinkPastas;

                            UserData.xNome = objUsuario.xNome;
                            UserData.idUser = (int)objUsuario.idFuncionario;
                            //UserData.idGrupoUsuario = objUsuario.;
                            UserData.bLogado = true;
                            try
                            {
                                UserData.idUserHLP = usuarioService.GetIdUserHLP();
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Não foi localizado usuário Hlp", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            try
                            {
                                UserData.idUserDEFAULT = usuarioService.GetIdUserDEFAULT();
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Não foi localizado usuário Administrador/Default", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }




                            this.Close();
                        }
                        else
                        {
                            errorProvider1.SetError(cbxIdEmpresa, "Usuário sem acesso a essa Empresa: " + cbxIdEmpresa.Text + " !");
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(txtxID, "Usuário não está ativo para utilizar o sistema!!");
                    }
                }
                else
                {
                    errorProvider1.SetError(txtxSenha, "Senha Incorreta!");
                    txtxSenha.Focus();
                    txtxSenha.SelectAll();
                }
            }
            else
            {
                errorProvider1.SetError(txtxID, "Usuário não encontrado!");
                txtxID.Focus();
                txtxID.SelectAll();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Dispose();
                if (txtxID.Text == "")
                {
                    errorProvider1.SetError(txtxID, "Campo Obrigatório!");
                    txtxID.Focus();
                }
                else if (txtxSenha.Text == "")
                {
                    errorProvider1.SetError(txtxSenha, "Campo Obrigatório!");
                    txtxSenha.Focus();
                }
                else
                {
                    Login();
                }
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }

        private void formLoginHlp_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if ((e.Modifiers == Keys.Alt && e.KeyValue == (char)70) || e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //lTimer.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
            lTimer.Text = DateTime.Now.TimeOfDay.ToString().Remove(8);
        }

        private void cbxIdEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                SendKeys.Send("{tab}");
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
