using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using HLP.Comum.Messages;
using HLP.Comum.Models;
using HLP.Comum.Models.Static;
using HLP.Comum.UI.Exception;

namespace HLP.Comum.UI
{
    public partial class FormPesquisaCampo : ComponentFactory.Krypton.Toolkit.KryptonForm
    {

        List<PesquisaPadraoModel> listInformation = null;
        string sTabela = "";
        string sTipoCampo = "";
        string sCampo = "";
        string sIdentityName = "";
        public string sql = null;



        public FormPesquisaCampo(string sTabela, string sCampo, string sLabel, string sIdentityName, List<PesquisaPadraoModel> listInformation)
        {
            InitializeComponent();
            txtValor.txt.KeyDown += new KeyEventHandler(txt_KeyDown);

            this.listInformation = listInformation;
            this.sTabela = sTabela;
            this.sCampo = sCampo;
            this.sIdentityName = sIdentityName;
            this.sTipoCampo = listInformation.FirstOrDefault(C => C.COLUMN_NAME.ToUpper() == sCampo.ToUpper()).DATA_TYPE;


            radIgual_1.Checked = true;
            if (sTipoCampo == "int" || sTipoCampo == "tinyint" || sTipoCampo == "decimal")
            {
                radNaFrase_3.Visible = false;
                radComecandocom_2.Visible = false;
            }

            this.Text = this.Text + " por " + sLabel;
        }

        void txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnFiltro_Click(null, null);
            }
        }



        private void btnFiltro_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "";
                if (txtValor.Text != "")
                {
                    if (sTipoCampo == "int" || sTipoCampo == "tinyint")
                    {
                        if (!Util.ValidaNumeroInteiro(txtValor.Text))
                        {
                            KryptonMessageBox.Show("Valor Inválido para a Pesquisa. É esperado um Valor Numérico Inteiro.", Mensagens.MSG_Aviso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    if (radIgual_1.Checked)
                    {
                        sql = "SELECT " + sIdentityName + " FROM " + sTabela + " WHERE " + sCampo + " ='" + txtValor.Text + "'";
                    }
                    else if (radNaFrase_3.Checked)
                    {
                        sql = "SELECT " + sIdentityName + " FROM " + sTabela + " WHERE " + sCampo + " LIKE '%" + txtValor.Text + "%'";
                    }
                    else
                    {
                        sql = "SELECT " + sIdentityName + " FROM " + sTabela + " WHERE " + sCampo + "  LIKE '" + txtValor.Text + "%'";
                    }
                    if (listInformation.Where(C => C.COLUMN_NAME == "idEmpresa").Count() > 0)
                    {
                        sql += " AND idEmpresa = " + CompanyData.idEmpresa;
                    }
                }
                this.Close();
            }
            catch (System.Exception ex)
            {
                new HLPexception(ex);
            }
        }

        private void FormPesquisaCampo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnFiltro.PerformClick(); 
            }
        }
    }
}