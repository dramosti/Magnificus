using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ninject;
using HLP.Dependencies;
using HLP.Comum.Models;
using HLP.Models.Entries.Comercial;
using HLP.Comum.Services.Interface;
using HLP.Comum.Messages;
using ComponentFactory.Krypton.Toolkit;
using System.Linq.Expressions;
using HLP.Comum.UI;
using HLP.Comum.UI.Exception;

namespace HLP.UI.Entries.Comercial
{
    public partial class FormListaPrecoFiltro : Form
    {
        public bool bFiltrou = false;
        List<Lista_precoModel> lLista_precoModel;
      public   List<Lista_precoModel> lFiltrada = new List<Lista_precoModel>();

        string[] listaInt = new string[] { "Igual a", "Entre", "Não Entre", "Na Lista", "Não na Lista", "Diferente que", "Maior que", "Maior Igual que", "Menor que", "Menor Igual que" };
        string[] listaString = new string[] { "Igual a", "Igual na Frase", "Começando com", "Diferente que", "Branco", "Não Branco" };
        string[] listaDecimal = new string[] { "Igual a", "Entre", "Não Entre", "Na Lista", "Não na Lista", "Diferente que", "Maior que", "Maior Igual que", "Menor que", "Menor Igual que" };
        string[] listaData = new string[] { "Igual a", "Maior que", "Maior Igual que", "Menor que", "Menor Igual que", "Entre", "Não Entre", "Diferente que" };
        string[] listaBool = new string[] { "Igual a" };

        [Inject]
        public IPesquisaPadraoService pesquisaPadraoService { get; set; }

        public FormListaPrecoFiltro()
        {
            InitializeComponent();
        }

        public FormListaPrecoFiltro(List<Lista_precoModel> lLista_precoModel)
        {
            InitializeComponent();

            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
            this.lLista_precoModel = lLista_precoModel;
        }

        private void FormListaPrecoFiltro_Load(object sender, EventArgs e)
        {
            idProduto.Tag = "FormProduto-Produto";

            idProduto.DisplayMember = "xComercial";
            idProduto.ValueMember = "idProduto";
            idProduto.DataSource = pesquisaPadraoService.GetData("SELECT * FROM Produto", true);

            bsListaPreco.DataSource = lLista_precoModel;
            dgvItens.DataSource = bsListaPreco;
        }







        private void dgvItens_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                FormPesquisaPadraoHeaderCell frm = new FormPesquisaPadraoHeaderCell(dgvItens.Columns[e.ColumnIndex]);
                frm.ShowDialog();
                string sOper = frm.sOperadorTela;
                string sValor = frm.sValorTela;

                if (sOper != "")
                {


                    switch (e.ColumnIndex)
                    {
                        case 0:
                            if (sOper == "=")
                            {
                                lFiltrada = lLista_precoModel.Where(C => C.idProduto == Convert.ToInt32(sValor)).ToList();

                            }
                            else if (sOper == ">")
                            {
                                lFiltrada = lLista_precoModel.Where(C => C.idProduto > Convert.ToInt32(sValor)).ToList();
                            }
                            else if (sOper == "<")
                            {
                                lFiltrada = lLista_precoModel.Where(C => C.idProduto < Convert.ToInt32(sValor)).ToList();
                            }
                            break;

                        case 1:
                            if (sOper == "=")
                            {
                                lFiltrada = lLista_precoModel.Where(C => C.vCustoProduto == Convert.ToDecimal(sValor)).ToList();

                            }
                            else if (sOper == ">")
                            {
                                lFiltrada = lLista_precoModel.Where(C => C.vCustoProduto > Convert.ToDecimal(sValor)).ToList();
                            }
                            else if (sOper == "<")
                            {
                                lFiltrada = lLista_precoModel.Where(C => C.vCustoProduto < Convert.ToDecimal(sValor)).ToList();
                            }

                            break;

                        case 2:
                            if (sOper == "=")
                            {
                                lFiltrada = lLista_precoModel.Where(C => C.pDesconto == Convert.ToDecimal(sValor)).ToList();

                            }
                            else if (sOper == ">")
                            {
                                lFiltrada = lLista_precoModel.Where(C => C.pDesconto > Convert.ToDecimal(sValor)).ToList();
                            }
                            else if (sOper == "<")
                            {
                                lFiltrada = lLista_precoModel.Where(C => C.pDesconto < Convert.ToDecimal(sValor)).ToList();
                            }

                            break;

                        case 3:
                            if (sOper == "=")
                            {
                                lFiltrada = lLista_precoModel.Where(C => C.pComissao == Convert.ToDecimal(sValor)).ToList().ToList();

                            }
                            else if (sOper == ">")
                            {
                                lFiltrada = lLista_precoModel.Where(C => C.pComissao > Convert.ToDecimal(sValor)).ToList();
                            }
                            else if (sOper == "<")
                            {
                                lFiltrada = lLista_precoModel.Where(C => C.pComissao < Convert.ToDecimal(sValor)).ToList();
                            }

                            break;

                        case 4:
                            if (sOper == "=")
                            {
                                lFiltrada = lLista_precoModel.Where(C => C.pOutros == Convert.ToDecimal(sValor)).ToList();

                            }
                            else if (sOper == ">")
                            {
                                lFiltrada = lLista_precoModel.Where(C => C.pOutros > Convert.ToDecimal(sValor)).ToList();
                            }
                            else if (sOper == "<")
                            {
                                lFiltrada = lLista_precoModel.Where(C => C.pOutros < Convert.ToDecimal(sValor)).ToList();
                            }

                            break;
                        case 5:
                            if (sOper == "=")
                            {
                                lFiltrada = lLista_precoModel.Where(C => C.pLucro == Convert.ToDecimal(sValor)).ToList();

                            }
                            else if (sOper == ">")
                            {
                                lFiltrada = lLista_precoModel.Where(C => C.pLucro > Convert.ToDecimal(sValor)).ToList();
                            }
                            else if (sOper == "<")
                            {
                                lFiltrada = lLista_precoModel.Where(C => C.pLucro < Convert.ToDecimal(sValor)).ToList();
                            }

                            break;

                        case 6:
                            if (sOper == "=")
                            {
                                lFiltrada = lLista_precoModel.Where(C => C.vVenda == Convert.ToDecimal(sValor)).ToList();

                            }
                            else if (sOper == ">")
                            {
                                lFiltrada = lLista_precoModel.Where(C => C.vVenda > Convert.ToDecimal(sValor)).ToList();
                            }
                            else if (sOper == "<")
                            {
                                lFiltrada = lLista_precoModel.Where(C => C.vVenda < Convert.ToDecimal(sValor)).ToList();
                            }

                            break;

                        case 7:
                            if (sOper == "=")
                            {
                                lFiltrada = lLista_precoModel.Where(C => C.pDescontoMaximo == Convert.ToDecimal(sValor)).ToList();

                            }
                            else if (sOper == ">")
                            {
                                lFiltrada = lLista_precoModel.Where(C => C.pDescontoMaximo > Convert.ToDecimal(sValor)).ToList();
                            }
                            else if (sOper == "<")
                            {
                                lFiltrada = lLista_precoModel.Where(C => C.pDescontoMaximo < Convert.ToDecimal(sValor)).ToList();
                            }

                            break;
                        case 8:
                            if (sOper == "=")
                            {
                                lFiltrada = lLista_precoModel.Where(C => C.pAcrescimoMaximo == Convert.ToDecimal(sValor)).ToList();

                            }
                            else if (sOper == ">")
                            {
                                lFiltrada = lLista_precoModel.Where(C => C.pAcrescimoMaximo > Convert.ToDecimal(sValor)).ToList();
                            }
                            else if (sOper == "<")
                            {
                                lFiltrada = lLista_precoModel.Where(C => C.pAcrescimoMaximo < Convert.ToDecimal(sValor)).ToList();
                            }

                            break;
                        case 9:
                            if (sOper == "=")
                            {
                                lFiltrada = lLista_precoModel.Where(C => C.pComissaoAvista == Convert.ToDecimal(sValor)).ToList();

                            }
                            else if (sOper == ">")
                            {
                                lFiltrada = lLista_precoModel.Where(C => C.pComissaoAvista > Convert.ToDecimal(sValor)).ToList();
                            }
                            else if (sOper == "<")
                            {
                                lFiltrada = lLista_precoModel.Where(C => C.pComissaoAvista < Convert.ToDecimal(sValor)).ToList();
                            }

                            break;
                        case 10:
                            if (sOper == "=")
                            {
                                lFiltrada = lLista_precoModel.Where(C => C.pComissaoAprazo == Convert.ToDecimal(sValor)).ToList();

                            }
                            else if (sOper == ">")
                            {
                                lFiltrada = lLista_precoModel.Where(C => C.pComissaoAprazo > Convert.ToDecimal(sValor)).ToList();
                            }
                            else if (sOper == "<")
                            {
                                lFiltrada = lLista_precoModel.Where(C => C.pComissaoAprazo < Convert.ToDecimal(sValor)).ToList();
                            }

                            break;
                        case 11:
                            if (sOper == "=")
                            {
                                lFiltrada = lLista_precoModel.Where(C => C.dAlteracaoCusto == Convert.ToDateTime(sValor)).ToList();

                            }
                            else if (sOper == ">")
                            {
                                lFiltrada = lLista_precoModel.Where(C => C.dAlteracaoCusto > Convert.ToDateTime(sValor)).ToList();
                            }
                            else if (sOper == "<")
                            {
                                lFiltrada = lLista_precoModel.Where(C => C.dAlteracaoCusto < Convert.ToDateTime(sValor)).ToList();
                            }

                            break;
                    }
                    bsListaPreco.DataSource = lFiltrada;
                }
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            lFiltrada = lLista_precoModel;
            bsListaPreco.DataSource = lLista_precoModel;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            lFiltrada = (List<Lista_precoModel>)bsListaPreco.DataSource;
            bFiltrou = true;
            this.Close();
        }
    }
}
