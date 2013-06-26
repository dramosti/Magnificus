using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Ninject;
using HLP.Services.Interfaces.Entries.Gerais;
using HLP.Comum.UI.Exception;
using HLP.Dependencies;
using HLP.Comum.Models.Static;
using HLP.Models.Entries.Gerais;

namespace Magnificus
{
    public partial class FormLogin : Form
    {
        [Inject]
        public IFuncionarioService usuarioService { get; set; }

        [Inject]
        public IEmpresaService empresaService { get; set; }

        public FormLogin()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
            cbxIdEmpresa.DisplayMember = "xFantasia";
            cbxIdEmpresa.ValueMember = "idEmpresa";
            cbxIdEmpresa.DataSource = empresaService.GetAllEmpresa(true);
        }


        private void FormLogin_Load(object sender, EventArgs e)
        {
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Dispose();
                if (txtxID.Text == "")
                {
                    errorProvider1.SetError(txtxID, "Campo Obrigatório!");
                    txtxID.txt.Focus();
                }
                else if (txtxSenha.Text == "")
                {
                    errorProvider1.SetError(txtxSenha, "Campo Obrigatório!");
                    txtxSenha.txt.Focus();
                }
                else
                {
                    //Login();
                }
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }

        //void Login()
        //{
        //    UserData.bLogado = false;
        //    if (usuarioService.ValidaNomeUsuario(txtxID.Text.Trim()))
        //    {
        //         objUsuario = usuarioService.ValidaUsuario(txtxID.Text, txtxSenha.Text);

        //        if (objUsuario != null)
        //        {
        //            if (usuarioService.ValidaAcesso(Convert.ToInt32(cbxIdEmpresa.SelectedValue), objUsuario.idUsuario))
        //            {
        //                CompanyData.idEmpresa = Convert.ToInt32(cbxIdEmpresa.SelectedValue);
        //                CompanyData.xNome = (cbxIdEmpresa.cbx.SelectedItem as EmpresaModel).xNome.Split('-')[1].Trim();
        //                CompanyData.xFantasia = (cbxIdEmpresa.cbx.SelectedItem as EmpresaModel).xFantasia.Split('-')[1].Trim();
        //                CompanyData.xLinqLogoEmpresa = (cbxIdEmpresa.cbx.SelectedItem as EmpresaModel).xLinkLogoEmpresa;

        //                Pastas.Path_SettingsEmpresa = (cbxIdEmpresa.cbx.SelectedItem as EmpresaModel).xLinkPastas;
                     
        //                UserData.xNome = objUsuario.xNome;                        
        //                UserData.idUser = objUsuario.idUsuario;
        //                UserData.idGrupoUsuario = objUsuario.idGrupoUsuario;
        //                UserData.bLogado = true;
        //                UserData.idUserHLP = usuarioService.GetIdUserHLP();
        //                UserData.idUserDEFAULT = usuarioService.GetIdUserDEFAULT();
        //                this.Close();
        //            }
        //            else
        //            {
        //                errorProvider1.SetError(cbxIdEmpresa, "Usuário sem acesso a essa Empresa: " + cbxIdEmpresa.Text + " !");
        //            }
        //        }
        //        else
        //        {
        //            errorProvider1.SetError(txtxSenha, "Senha Incorreta!");
        //            txtxSenha.txt.Focus();
        //            txtxSenha.txt.SelectAll();
        //        }
        //    }
        //    else
        //    {
        //        errorProvider1.SetError(txtxID, "Usuário não encontrado!");
        //        txtxID.txt.Focus();
        //        txtxID.txt.SelectAll();
        //    }
        //}

        void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers == Keys.Alt && e.KeyValue == (char)70) || e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}