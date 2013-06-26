using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HLP.Models.Entries.Comercial;
using ComponentFactory.Krypton.Toolkit;
using HLP.Services.Interfaces.Entries.Comercial;
using Ninject;
using HLP.Dependencies;

namespace HLP.UI.Entries.Comercial
{
    public partial class FormListaPrecoAumento : Form
    {
        [Inject]
        public IProdutoService produtoService { get; set; }

        public bool Aplica = false;
        public List<Lista_precoModel> lLista_precoModel;

        public bool bPrecoVenda = false;

        public FormListaPrecoAumento(List<Lista_precoModel> lLista_precoModel)
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);

            this.lLista_precoModel = lLista_precoModel;
        }

        private void FormListaPrecoAumento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void FormListaPrecoAumento_Load(object sender, EventArgs e)
        {
            cboTipo.SelectedIndex = 0;
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> dValues = new Dictionary<int, string>();
            string sOldValue = "";

            ProdutoModel produto;
            for (int i = 0; i < lLista_precoModel.Count; i++)
            {
                produto = produtoService.GetProduto(lLista_precoModel[i].idProduto);
                if (produto != null)
                {
                    //PREÇO DE VENDA  
                    //CUSTO DO PRODUTO 
                    if (cboTipo.SelectedIndex == 0)
                    {
                        sOldValue = lLista_precoModel[i].vVenda.ToString();
                        lLista_precoModel[i].vVenda = lLista_precoModel[i].vVenda + ((lLista_precoModel[i].vVenda * nudPorcentagem.Value) / 100);
                        dValues.Add((int)produto.idProduto, sOldValue + "-" + lLista_precoModel[i].vVenda.ToString());
                    }
                    else
                    {
                        sOldValue = lLista_precoModel[i].vCustoProduto.ToString();
                        if (produto.stCusto != 2)
                        {
                            lLista_precoModel[i].vCustoProduto = lLista_precoModel[i].vCustoProduto + ((lLista_precoModel[i].vCustoProduto * nudPorcentagem.Value) / 100);
                        }
                        dValues.Add((int)produto.idProduto, sOldValue + "-" + lLista_precoModel[i].vCustoProduto.ToString());
                    }

                }
            }
            FormListaPrecoAlteracoes frm = new FormListaPrecoAlteracoes(dValues);
            frm.Text += " - " + cboTipo.Text;
            frm.ShowDialog();
            Aplica = frm.Aplica;
            if (Aplica)
            {
                if (cboTipo.SelectedIndex == 0)
                {
                    bPrecoVenda = true;
                }
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            FormListaPrecoFiltro frm = new FormListaPrecoFiltro(lLista_precoModel);
            frm.ShowDialog();
            if (frm.bFiltrou)
            {
                lLista_precoModel = frm.lFiltrada;
            }
        }


    }
}
