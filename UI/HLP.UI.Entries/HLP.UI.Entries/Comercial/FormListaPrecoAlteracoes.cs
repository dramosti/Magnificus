using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ninject;
using HLP.Comum.Services.Interface;
using HLP.Dependencies;

namespace HLP.UI.Entries.Comercial
{
    public partial class FormListaPrecoAlteracoes : Form
    {
        [Inject]
        public IPesquisaPadraoService pesquisaPadraoService { get; set; }

        Dictionary<int, string> dValues;
        public bool Aplica = false;

        public FormListaPrecoAlteracoes(Dictionary<int, string> dValues)
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);

            this.dValues = dValues;
        }

        private void FormListaPrecoAlteracoes_Load(object sender, EventArgs e)
        {
            idProduto.Tag = "FormProduto-Produto";
            idProduto.DisplayMember = "xComercial";
            idProduto.ValueMember = "idProduto";
            idProduto.DataSource = pesquisaPadraoService.GetData( "SELECT idProduto, xComercial FROM Produto", true);

            string sOld = "";
            string sNew = "";
            foreach (KeyValuePair<int, string> item in dValues)
            {
                sOld = item.Value.Split('-')[0];
                sNew = item.Value.Split('-')[1];

                dgvItens.Rows.Add(item.Key, sOld, sNew);
                if (Convert.ToDecimal(sOld) != Convert.ToDecimal(sNew))
                {
                    dgvItens[2, dgvItens.RowCount - 1].Style.BackColor = Color.PaleGreen;
                }
            }
        }



        private void FormListaPrecoAlteracoes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            Aplica = true;
            this.Close();
        }


    }
}
