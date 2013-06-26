using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HLP.Models.Entries.Comercial;
using Ninject;
using HLP.Dependencies;
using HLP.Comum.UI;

namespace HLP.UI.Entries.Comercial
{
    public partial class FormListaPrecoAtribuicao : Form
    {
        public bool Aplica = false;
        public List<Lista_precoModel> lLista_precoModel;
        int iTipo;
        public bool bpLucro = false;
        public bool bvVenda = false;

        public FormListaPrecoAtribuicao(List<Lista_precoModel> lLista_precoModel, int iTipo)
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);

            this.lLista_precoModel = lLista_precoModel;
            this.iTipo = iTipo;
        }

        private void FormListaPrecoAtribuicao_Load(object sender, EventArgs e)
        {
            //0 - AUTOMÁTICA
            //1 - MANUAL
            if (iTipo == 0)
            {
                cboTipo.cbx.Items.Add("DESCONTO MÁXIMO");
                cboTipo.cbx.Items.Add("ACRÉSCIMO MÁXIMO");
                cboTipo.cbx.Items.Add("COMISSÃO A VISTA");
                cboTipo.cbx.Items.Add("COMISSÃO A PRAZO");
            }
            else
            {
                cboTipo.cbx.Items.Add("ACRÉSCIMO MÁXIMO");
                cboTipo.cbx.Items.Add("DESCONTO MÁXIMO");
                cboTipo.cbx.Items.Add("COMISSÃO A VISTA");
                cboTipo.cbx.Items.Add("COMISSÃO A PRAZO");
                cboTipo.cbx.Items.Add("CUSTO DE COMISSÃO");
                cboTipo.cbx.Items.Add("MARGEM DE LUCRO");
                cboTipo.cbx.Items.Add("PORCENTAGEM DE DESCONTO");
                cboTipo.cbx.Items.Add("PREÇO DE VENDA");
                cboTipo.cbx.Items.Add("OUTROS");

            }
            cboTipo.SelectedIndex = 0;
        }

        private void FormListaPrecoAtribuicao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> dValues = new Dictionary<int, string>();
            string sOldValue = "";

            for (int i = 0; i < lLista_precoModel.Count; i++)
            {

                if (iTipo == 1)
                {
                    switch (cboTipo.SelectedIndex)
                    {
                        case 0:
                            sOldValue = lLista_precoModel[i].pAcrescimoMaximo.ToString();
                            lLista_precoModel[i].pAcrescimoMaximo = nudPorcentagem.Value;
                            dValues.Add((int)lLista_precoModel[i].idProduto, sOldValue + "-" + lLista_precoModel[i].pAcrescimoMaximo.ToString());
                            break;

                        case 1:
                            sOldValue = lLista_precoModel[i].pDescontoMaximo.ToString();
                            lLista_precoModel[i].pDescontoMaximo = nudPorcentagem.Value;
                            dValues.Add((int)lLista_precoModel[i].idProduto, sOldValue + "-" + lLista_precoModel[i].pDescontoMaximo.ToString());
                            break;

                        case 2:
                            sOldValue = lLista_precoModel[i].pComissaoAvista.ToString();
                            lLista_precoModel[i].pComissaoAvista = nudPorcentagem.Value;
                            dValues.Add((int)lLista_precoModel[i].idProduto, sOldValue + "-" + lLista_precoModel[i].pComissaoAvista.ToString());
                            break;

                        case 3:
                            sOldValue = lLista_precoModel[i].pComissaoAprazo.ToString();
                            lLista_precoModel[i].pComissaoAprazo = nudPorcentagem.Value;
                            dValues.Add((int)lLista_precoModel[i].idProduto, sOldValue + "-" + lLista_precoModel[i].pComissaoAprazo.ToString());
                            break;

                        case 4:
                            sOldValue = lLista_precoModel[i].pComissao.ToString();
                            lLista_precoModel[i].pComissao = nudPorcentagem.Value;
                            dValues.Add((int)lLista_precoModel[i].idProduto, sOldValue + "-" + lLista_precoModel[i].pComissao.ToString());
                            break;

                        case 5:
                            bpLucro = true;
                            bvVenda = false;
                            sOldValue = lLista_precoModel[i].pLucro.ToString();
                            lLista_precoModel[i].pLucro = nudPorcentagem.Value;
                            dValues.Add((int)lLista_precoModel[i].idProduto, sOldValue + "-" + lLista_precoModel[i].pLucro.ToString());
                            break;

                        case 6:
                            sOldValue = lLista_precoModel[i].pDesconto.ToString();
                            lLista_precoModel[i].pDesconto = nudPorcentagem.Value;
                            dValues.Add((int)lLista_precoModel[i].idProduto, sOldValue + "-" + lLista_precoModel[i].pDesconto.ToString());
                            break;

                        case 7:
                            bpLucro = false;
                            bvVenda = true;
                            sOldValue = lLista_precoModel[i].vVenda.ToString();
                            lLista_precoModel[i].vVenda = nudPorcentagem.Value;
                            dValues.Add((int)lLista_precoModel[i].idProduto, sOldValue + "-" + lLista_precoModel[i].vVenda.ToString());
                            break;

                        case 8:
                            sOldValue = lLista_precoModel[i].pOutros.ToString();
                            lLista_precoModel[i].pOutros = nudPorcentagem.Value;
                            dValues.Add((int)lLista_precoModel[i].idProduto, sOldValue + "-" + lLista_precoModel[i].pOutros.ToString());
                            break;
                    }

                }
                else
                {
                    switch (cboTipo.SelectedIndex)
                    {
                        case 0:
                            sOldValue = lLista_precoModel[i].pDescontoMaximo.ToString();
                            lLista_precoModel[i].pDescontoMaximo = nudPorcentagem.Value;
                            dValues.Add((int)lLista_precoModel[i].idProduto, sOldValue + "-" + lLista_precoModel[i].pDescontoMaximo.ToString());
                            break;

                        case 1:
                            sOldValue = lLista_precoModel[i].pAcrescimoMaximo.ToString();
                            lLista_precoModel[i].pAcrescimoMaximo = nudPorcentagem.Value;
                            dValues.Add((int)lLista_precoModel[i].idProduto, sOldValue + "-" + lLista_precoModel[i].pAcrescimoMaximo.ToString());
                            break;

                        case 2:
                            sOldValue = lLista_precoModel[i].pComissaoAvista.ToString();
                            lLista_precoModel[i].pComissaoAvista = nudPorcentagem.Value;
                            dValues.Add((int)lLista_precoModel[i].idProduto, sOldValue + "-" + lLista_precoModel[i].pComissaoAvista.ToString());
                            break;

                        case 3:
                            sOldValue = lLista_precoModel[i].pComissaoAprazo.ToString();
                            lLista_precoModel[i].pComissaoAprazo = nudPorcentagem.Value;
                            dValues.Add((int)lLista_precoModel[i].idProduto, sOldValue + "-" + lLista_precoModel[i].pComissaoAprazo.ToString());
                            break;
                    }
                }
            }
            FormListaPrecoAlteracoes frm = new FormListaPrecoAlteracoes(dValues);
            frm.Text += " - " + cboTipo.Text;
            frm.ShowDialog();
            Aplica = frm.Aplica;
            if (Aplica)
            {
                this.Close();
            }
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
