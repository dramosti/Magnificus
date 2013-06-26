using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HLP.Comum.UI;
using Ninject;
using HLP.Dependencies;
using HLP.Services.Interfaces.Entries.Comercial;
using HLP.Comum.Services.Interface;
using HLP.Models.Entries.Comercial;
using HLP.Comum.Messages;
using HLP.Comum.UI.Exception;
using HLP.Comum.Models.Static;
using ComponentFactory.Krypton.Toolkit;
using System.Threading;
using HLP.Comum.Infrastructure;

namespace HLP.UI.Entries.Comercial
{
    public partial class FormListaPreco : FormPadraoCadastro
    {
        [Inject]
        public ILista_Preco_PaiService listaPaiService { get; set; }

        [Inject]
        public ILista_precoService listaPrecoService { get; set; }

        [Inject]
        public IProdutoService produtoService { get; set; }

        [Inject]
        public IPesquisaPadraoService pesquisaPadraoService { get; set; }

        Lista_Preco_PaiModel lista_Preco_PaiModel = new Lista_Preco_PaiModel();
        Action verifBw = null;

        public FormListaPreco()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
        }

        private void FormListaPreco_Load(object sender, EventArgs e)
        {
            idProduto.Tag = "FormProduto-vwProduto-xComercial";
            idUnidadeMedida.Tag = "FormUnidadeMedida-vwUnidadeMedida-xSiglaPadrao";

            verifBw += (() =>
                {
                    CarregaGrids();
                });
            Thread t1 = new Thread(new ThreadStart(verifBw));
            t1.Start();
            InicializaFormPadrao("vwListaPrecoPai");
            
        }

        private void CarregaGrids()
        {
            if (objMetodosForm == null)
            {
                Thread.Sleep(500);
                CarregaGrids();
            }
            else
            {
                idProduto.DataSource = pesquisaPadraoService.GetData(objMetodosForm.GetDisplayMember(idProduto), true);
                idUnidadeMedida.DataSource = pesquisaPadraoService.GetData(objMetodosForm.GetDisplayMember(idUnidadeMedida), true);
                Thread.CurrentThread.Abort();
            }
        }





        public override void Novo()
        {
            base.Novo();

            cboAtivo.SelectedIndex = 1;
            cbostAtualizacao.SelectedIndex = 0;

            cbostContrato.SelectedIndex = 0;

            lista_Preco_PaiModel = new Lista_Preco_PaiModel();
            bsListaPreco.DataSource = lista_Preco_PaiModel.lLista_preco;
            dAlteracaoCusto.ReadOnly = true;
            txtdListaPreco.Text = DateTime.Now.ToString();

            VerificaCamposHabilitar();
        }

        public override void Excluir()
        {
            try
            {
                if (bsRetPesquisa.List.Count > 1)
                {
                    int iRet = HLPMessageBox.MsgExcluirTodos();
                    if (iRet == 1)
                    {
                        ExcluirRegistro();
                    }
                    else if (iRet == 2)
                    {
                        objMetodosForm.LimpaCampos();
                        Thread T = new Thread(ExcluirTodos);
                        T.Start();
                    }
                }
                else
                {
                    if (HLPMessageBox.MsgExcluir())
                    {
                        ExcluirRegistro();
                    }
                }
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }
        private void ExcluirTodos()
        {
            base.IniciaExcluirTodos();
            for (int i = 0; i < lParaExcluir.Count; i++)
            {
                try
                {
                    Invoke(new MethodInvoker(delegate
                    {
                        pbProgresso.PerformStep();
                        lblProgresso.Text = (i + 1) + " de " + bsRetPesquisa.List.Count;
                    }));
                    lista_Preco_PaiModel = listaPaiService.GetLista_Preco_Pai((int)lParaExcluir[i], true);
                    listaPaiService.Delete(lista_Preco_PaiModel);
                    lExcluido.Add(lParaExcluir[i]);
                }
                catch (Exception ex)
                {
                    new HLPexception(ex);
                }
            }
            base.FinalizaExcluirTodos();
        }
        private void ExcluirRegistro()
        {

            foreach (Lista_precoModel listaItem in bsListaPreco.List)
            {
                listaPaiService.Delete(lista_Preco_PaiModel);
            }

            base.Excluir();
            bsListaPreco.DataSource = new List<Lista_precoModel>();

            if (iRetPesquisa != null)
            {
                base.MoveProximoItem();
                lista_Preco_PaiModel = listaPaiService.GetLista_Preco_Pai((int)iRetPesquisa, true);
                PopulaForm();
            }
        }

        public override void Atualizar()
        {
            base.Atualizar();
            dAlteracaoCusto.ReadOnly = true;
            cbostAtualizacao.Enabled = false;
            VerificaCamposHabilitar();
        }
        public override void Salvar()
        {
            try
            {
                objValidaCampos.Validar();
                PopulaTabela();

                listaPaiService.Save(lista_Preco_PaiModel);

                txtCodigo.Text = lista_Preco_PaiModel.idListaPrecoPai.ToString();
                VerificaProdutosSemAlteracaoCusto();

                base.Salvar();

            }
            catch (Exception ex)
            {
                new HLPexception(ex, this);
            }
        }
        public override void Cancelar()
        {
            try
            {
                if (HLPMessageBox.MsgCancelar())
                {
                    if (txtCodigo.Text.Equals(""))
                    {
                        objMetodosForm.LimpaCampos();
                        HabilitaBotoes(2);
                    }
                    else
                    {
                        lista_Preco_PaiModel = listaPaiService.GetLista_Preco_Pai(Convert.ToInt32(txtCodigo.Text), true);
                        PopulaForm();
                        HabilitaBotoes(1);
                    }
                    base.Cancelar();
                }
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }
        public override void Pesquisar()
        {
            try
            {
                base.Pesquisar();
                if (iRetPesquisa != null)
                {
                    lista_Preco_PaiModel = listaPaiService.GetLista_Preco_Pai((int)iRetPesquisa, true);
                    PopulaForm();
                }
                else if (base.bNovoPesquisa)
                {
                    Novo();
                }
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }

        }
        public override void Navegacao()
        {
            try
            {
                base.Navegacao();
                if (iRetPesquisa != null)
                {
                    lista_Preco_PaiModel = listaPaiService.GetLista_Preco_Pai((int)iRetPesquisa, true);
                    if (lista_Preco_PaiModel != null)
                    {
                        objMetodosForm.LimpaCampos();
                        HabilitaBotoes(1);
                        PopulaForm();
                    }
                }
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }
        public override void PesquisaCampo()
        {
            try
            {
                base.PesquisaCampo();
                if (iRetPesquisa != null)
                {
                    HabilitaBotoes(1);
                    lista_Preco_PaiModel = listaPaiService.GetLista_Preco_Pai((int)iRetPesquisa, true);
                    PopulaForm();
                }
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }
        public override void Imprimir()
        {
            base.Imprimir();
        }
        public override void Duplicar()
        {
            try
            {
                int idOrigem = Convert.ToInt32(txtCodigo.Text);
                listaPaiService.Copy(lista_Preco_PaiModel);
                PopulaForm();
                base.RegistroDuplicado(idOrigem, (int)lista_Preco_PaiModel.idListaPrecoPai);
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }




        private void PopulaTabela()
        {
            try
            {
                lista_Preco_PaiModel.idEmpresa = CompanyData.idEmpresa;
                lista_Preco_PaiModel.xLista = txtxLista.Text;
                lista_Preco_PaiModel.stContrato = cbostContrato.SelectedIndexByte;
                lista_Preco_PaiModel.xNrContrato = txtxNrContrato.Text;
                if (cbostContrato.SelectedIndex == 0)
                {
                    lista_Preco_PaiModel.dValidadeContrato = null;
                }
                else
                {
                    lista_Preco_PaiModel.dValidadeContrato = dtpdValidadeContrato.Value;
                }
                lista_Preco_PaiModel.Ativo = cboAtivo.SelectedIndex == 1 ? true : false;
                if (lista_Preco_PaiModel.idListaPrecoPai == null)
                {
                    lista_Preco_PaiModel.dListaPreco = DateTime.Now;
                }
                lista_Preco_PaiModel.stAtualizacao = cbostAtualizacao.SelectedIndexByte;
                lista_Preco_PaiModel.nDiasSemAtualicao = nudnDiasSemAtualicao.ValueInt;
                lista_Preco_PaiModel.pDescontoMaximo = nudpDescontoMaximo.Value;
                lista_Preco_PaiModel.pAcressimoMaximo = nudpAcressimoMaximo.Value;
                lista_Preco_PaiModel.xCodigoListaPreco = txtxCodigoListaPreco.Text;
                if (cbostAtualizacao.SelectedIndex == 0)
                {
                    if (txtpPercentual.Text == "")
                    {
                        txtpPercentual.Text = "0";
                    }
                    lista_Preco_PaiModel.pPercentual = Convert.ToDecimal(txtpPercentual.Text.Replace(".", ","));
                    lista_Preco_PaiModel.idListaPrecoOrigem = (int)hlP_PesquisaidListaPrecoOrigem.Value;
                }
                else
                {
                    lista_Preco_PaiModel.pPercentual = null;
                    lista_Preco_PaiModel.idListaPrecoOrigem = null;
                }


            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }
        private void PopulaForm()
        {
            try
            {
                txtCodigo.Text = lista_Preco_PaiModel.idListaPrecoPai.ToString();
                txtxLista.Text = lista_Preco_PaiModel.xLista;
                cbostContrato.SelectedIndex = lista_Preco_PaiModel.stContrato;
                txtxNrContrato.Text = lista_Preco_PaiModel.xNrContrato;
                if (lista_Preco_PaiModel.dValidadeContrato != null)
                {
                    dtpdValidadeContrato.Value = (DateTime)lista_Preco_PaiModel.dValidadeContrato;
                }
                cboAtivo.SelectedIndex = lista_Preco_PaiModel.Ativo == true ? 1 : 0;
                txtdListaPreco.Text = lista_Preco_PaiModel.dListaPreco.ToShortDateString();
                cbostAtualizacao.SelectedIndex = lista_Preco_PaiModel.stAtualizacao;
                nudnDiasSemAtualicao.Value = (decimal)lista_Preco_PaiModel.nDiasSemAtualicao;
                nudpDescontoMaximo.Value = (decimal)lista_Preco_PaiModel.pDescontoMaximo;
                nudpAcressimoMaximo.Value = (decimal)lista_Preco_PaiModel.pAcressimoMaximo;
                txtxCodigoListaPreco.Text = lista_Preco_PaiModel.xCodigoListaPreco;
                txtpPercentual.Text = lista_Preco_PaiModel.pPercentual.ToString();
                if (lista_Preco_PaiModel.idListaPrecoOrigem != null)
                {
                    hlP_PesquisaidListaPrecoOrigem.Value = (int)lista_Preco_PaiModel.idListaPrecoOrigem;
                }

                bsListaPreco.DataSource = lista_Preco_PaiModel.lLista_preco;
                VerificaProdutosSemAlteracaoCusto();
                VerificaCamposHabilitar();
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }

        }
        private void VerificaProdutosSemAlteracaoCusto()
        {
            try
            {
                DateTime dAlteracaoCusto;
                DateTime data;
                for (int i = 0; i < dgvItens.RowCount; i++)
                {
                    if (dgvItens["dAlteracaoCusto", i].Value != null)
                    {
                        dAlteracaoCusto = Convert.ToDateTime(dgvItens["dAlteracaoCusto", i].Value).Date;
                        data = dAlteracaoCusto.AddDays((double)lista_Preco_PaiModel.nDiasSemAtualicao);
                        if (data <= DateTime.Now.Date)
                        {
                            dgvItens["dAlteracaoCusto", i].Style.BackColor = Color.Red;
                        }
                        else
                        {
                            dgvItens["dAlteracaoCusto", i].Style.BackColor = Color.White;
                        }
                    }
                }
                dgvItens.Refresh();

            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }
        private void VerificaCamposHabilitar()
        {
            //if (hlP_PesquisaidListaPrecoOrigem.Value == 0)
            //{
            //    cbostAtualizacao.SelectedIndex = 1;
            //    hlP_PesquisaidListaPrecoOrigem.Enabled = false;
            //    txtpPercentual.ReadOnly = true;
            //    btnGerar.Enabled = false;
            //}
            //else
            {
                if (lista_Preco_PaiModel.idListaPrecoPai == null)
                {
                    cbostAtualizacao.Enabled = true;
                    hlP_PesquisaidListaPrecoOrigem.Enabled = true;
                    txtpPercentual.ReadOnly = false;
                    btnGerar.Enabled = true;
                }
                else
                {
                    cbostAtualizacao.Enabled = false;
                    hlP_PesquisaidListaPrecoOrigem.Enabled = false;
                    txtpPercentual.ReadOnly = true;
                    btnGerar.Enabled = false;
                }
            }
            if (btnSalvar.Enabled)
            {
                if (cbostAtualizacao.SelectedIndex == 1)
                {
                    btnInserir.Enabled = true;
                }
                else
                {
                    btnInserir.Enabled = false;
                }
            }
            ProdutoModel produto;
            for (int i = 0; i < dgvItens.RowCount; i++)
            {
                produto = produtoService.GetProduto(Convert.ToInt32(dgvItens["idProduto", i].Value));
                if (produto != null)
                {
                    if (produto.stCusto == 2)
                    {
                        dgvItens["vCustoProduto", i].ReadOnly = true;
                    }
                    else
                    {
                        dgvItens["vCustoProduto", i].ReadOnly = false;
                    }
                }
            }
        }
        private bool GeraListaAutomatica()
        {
            bool ret = false;

            try
            {
                if (cbostAtualizacao.SelectedIndex == 0)
                {
                    if (hlP_PesquisaidListaPrecoOrigem.Value != 0)
                    {
                        decimal dPercentual = 0;
                        decimal dpLucro = 0;
                        decimal dvCustoProduto = 0;
                        decimal dvVenda = 0;
                        try
                        {
                            dPercentual = Convert.ToDecimal(txtpPercentual.Text.Replace(".", ","));  
                            Lista_Preco_PaiModel lPrecoOrigem = listaPaiService.GetLista_Preco_Pai((int)hlP_PesquisaidListaPrecoOrigem.Value, true);
                            foreach (Lista_precoModel listaItem in lPrecoOrigem.lLista_preco)
                            {
                                listaItem.idListaPreco = null;
                                dpLucro = (listaItem.vVenda * dPercentual) / 100;
                                listaItem.vVenda += dpLucro;

                                dvCustoProduto = listaItem.vCustoProduto;
                                dvVenda = listaItem.vVenda;
                                if (dvCustoProduto != 0 && dvVenda > 0)
                                {
                                    listaItem.pLucro = ((dvVenda - dvCustoProduto) * 100) / dvCustoProduto;
                                }


                            }
                            bsListaPreco.DataSource = lPrecoOrigem.lLista_preco;

                            ret = true;
                        }
                        catch (Exception ex)
                        {
                            KryptonMessageBox.Show("Percentual inválido!", Mensagens.MSG_Aviso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        KryptonMessageBox.Show("Lista de preço origem não foi selecionada!", Mensagens.MSG_Aviso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    ret = true;
                }
                return ret;
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
                return ret;
            }
        }


        private void cbostAtualizacao__SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnSalvar.Enabled)
            {
                if (cbostAtualizacao.SelectedIndex == 0)
                {
                    hlP_PesquisaidListaPrecoOrigem.Enabled = true;
                    txtpPercentual.ReadOnly = false;
                    dgvItens.ReadOnly = true;
                    btnGerar.Enabled = true;
                    btnInserir.Enabled = false;
                    lista_Preco_PaiModel.lLista_preco = new List<Lista_precoModel>();
                    bsListaPreco.DataSource = lista_Preco_PaiModel.lLista_preco;
                }
                else if (cbostAtualizacao.SelectedIndex == 1)
                {
                    hlP_PesquisaidListaPrecoOrigem.Enabled = false;
                    txtpPercentual.ReadOnly = true;
                    btnGerar.Enabled = false;
                    hlP_PesquisaidListaPrecoOrigem.Value = 0;
                    txtpPercentual.Text = "";
                    dgvItens.ReadOnly = false;
                    btnInserir.Enabled = true;
                }
            }
        }
        private void btnGerar_Click(object sender, EventArgs e)
        {
            GeraListaAutomatica();
            VerificaProdutosSemAlteracaoCusto();
        }



        private void dgvItens_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                decimal dvCustoProdutoImpostos = 0;
                decimal dvCustoProduto = 0;
                decimal dpLucro = 0;
                decimal dvVenda = 0;
                decimal dpDesconto = 0;
                decimal dpComissao = 0;
                decimal dpOutros = 0;
                decimal dValorTaxa = 0;

                if (dgvItens.Columns[e.ColumnIndex] == pLucro || dgvItens.Columns[e.ColumnIndex] == vVenda)
                {
                    dvCustoProduto = Convert.ToDecimal(dgvItens["vCustoProduto", e.RowIndex].Value);
                    dpLucro = Convert.ToDecimal(dgvItens["pLucro", e.RowIndex].Value);
                    dvVenda = Convert.ToDecimal(dgvItens["vVenda", e.RowIndex].Value);

                    dpDesconto = Convert.ToDecimal(dgvItens["pDesconto", e.RowIndex].Value);
                    dpComissao = Convert.ToDecimal(dgvItens["pComissao", e.RowIndex].Value);
                    dpOutros = Convert.ToDecimal(dgvItens["pOutros", e.RowIndex].Value);

                    dValorTaxa = listaPrecoService.CalculaValorTaxa(dpComissao, dpOutros, dpDesconto);
                    dvCustoProdutoImpostos = listaPrecoService.CalculaValorCustoComTaxa(dvCustoProduto, dValorTaxa);

                    if (dgvItens.Columns[e.ColumnIndex] == pLucro)
                    {
                        dgvItens["vVenda", e.RowIndex].Value = listaPrecoService.CalculaValorVenda(dvCustoProdutoImpostos, dvCustoProduto, dpLucro);
                    }
                    else
                    {
                        if (dvCustoProduto > 0)
                        {
                            dgvItens["pLucro", e.RowIndex].Value = listaPrecoService.CalculaPorcentagemLucro(dvVenda, dvCustoProdutoImpostos, dvCustoProduto);
                        }
                    }
                }
                else if (dgvItens.Columns[e.ColumnIndex] == pDesconto || dgvItens.Columns[e.ColumnIndex] == pComissao || dgvItens.Columns[e.ColumnIndex] == pOutros)
                {
                    dvCustoProduto = Convert.ToDecimal(dgvItens["vCustoProduto", e.RowIndex].Value);
                    dpLucro = Convert.ToDecimal(dgvItens["pLucro", e.RowIndex].Value);

                    dpDesconto = Convert.ToDecimal(dgvItens["pDesconto", e.RowIndex].Value);
                    dpComissao = Convert.ToDecimal(dgvItens["pComissao", e.RowIndex].Value);
                    dpOutros = Convert.ToDecimal(dgvItens["pOutros", e.RowIndex].Value);

                    dValorTaxa = listaPrecoService.CalculaValorTaxa(dpComissao, dpOutros, dpDesconto);
                    dvCustoProdutoImpostos = listaPrecoService.CalculaValorCustoComTaxa(dvCustoProduto, dValorTaxa);

                    dgvItens["vVenda", e.RowIndex].Value = listaPrecoService.CalculaValorVenda(dvCustoProdutoImpostos, dvCustoProduto, dpLucro);
                }
                else if (dgvItens.Columns[e.ColumnIndex] == vCustoProduto)
                {
                    dvCustoProduto = Convert.ToDecimal(dgvItens["vCustoProduto", e.RowIndex].Value);
                    dpLucro = Convert.ToDecimal(dgvItens["pLucro", e.RowIndex].Value);
                    dvVenda = Convert.ToDecimal(dgvItens["vVenda", e.RowIndex].Value);

                    dpDesconto = Convert.ToDecimal(dgvItens["pDesconto", e.RowIndex].Value);
                    dpComissao = Convert.ToDecimal(dgvItens["pComissao", e.RowIndex].Value);
                    dpOutros = Convert.ToDecimal(dgvItens["pOutros", e.RowIndex].Value);

                    dValorTaxa = listaPrecoService.CalculaValorTaxa(dpComissao, dpOutros, dpDesconto);
                    dvCustoProdutoImpostos = listaPrecoService.CalculaValorCustoComTaxa(dvCustoProduto, dValorTaxa);

                    if (dpLucro > 0)
                    {
                        dgvItens["vVenda", e.RowIndex].Value = listaPrecoService.CalculaValorVenda(dvCustoProdutoImpostos, dvCustoProduto, dpLucro);
                    }
                    else if (dvVenda > 0)
                    {
                        dgvItens["pLucro", e.RowIndex].Value = listaPrecoService.CalculaPorcentagemLucro(dvVenda, dvCustoProdutoImpostos, dvCustoProduto);
                    }
                }
                else if (dgvItens.Columns[e.ColumnIndex] == idProduto)
                {
                    int idProd = Convert.ToInt32(dgvItens["idProduto", e.RowIndex].Value);
                    if (idProd != 0)
                    {
                        if (((List<Lista_precoModel>)bsListaPreco.List).Where(C => C.idProduto == idProd && C.GetStatusRegistro() != BaseModelFilhos.statusRegistroFilho.Excluido).Count() > 1)
                        {
                            dgvItens["idProduto", e.RowIndex].Value = 0;
                            KryptonMessageBox.Show("Produto já inserido na lista!", Mensagens.MSG_Aviso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            ProdutoModel produto = produtoService.GetProduto(idProd);
                            if (produto != null)
                            {
                                dgvItens["vCustoProduto", e.RowIndex].Value = produto.vProducao;
                                dgvItens["vVenda", e.RowIndex].Value = produto.vVenda;
                                dgvItens["idUnidadeMedida", e.RowIndex].Value = produto.idUnidadeMedidaEstoque;
                                if (produto.stCusto == 2)
                                {
                                    dgvItens["vCustoProduto", e.RowIndex].ReadOnly = true;
                                }
                                else
                                {
                                    dgvItens["vCustoProduto", e.RowIndex].ReadOnly = false;
                                }

                                dvCustoProduto = Convert.ToDecimal(dgvItens["vCustoProduto", e.RowIndex].Value);
                                dpLucro = Convert.ToDecimal(dgvItens["pLucro", e.RowIndex].Value);
                                if (dvCustoProduto > 0)
                                {
                                    if (dpLucro > 0)
                                    {
                                        dgvItens["vVenda", e.RowIndex].Value = listaPrecoService.CalculaValorVendaAposTrocarProdutoLista(dvCustoProduto, dvCustoProdutoImpostos, dpLucro);
                                    }
                                    else
                                    {
                                        if (dvVenda > 0)
                                        {
                                            //Este calculo não está com os parametros errados. A variavel dvCustoProduto é passada 2 vezes para o calculo.
                                            dgvItens["pLucro", e.RowIndex].Value = listaPrecoService.CalculaPorcentagemLucro(dvVenda, dvCustoProduto, dvCustoProduto);
                                        }
                                    }
                                }
                                else
                                {
                                    dgvItens["vVenda", e.RowIndex].Value = 0m;
                                    dgvItens["pLucro", e.RowIndex].Value = 0m;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }


        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> lInn = ((List<Lista_precoModel>)bsListaPreco.DataSource).Select(C => C.idProduto).ToList();
                List<int> lOut = listaPrecoService.ReturnProducts(lInn);

                Lista_precoModel obj;
                ProdutoModel produto;
                foreach (int i in lOut)
                {
                    obj = new Lista_precoModel();
                    obj.idProduto = i;
                    produto = produtoService.GetProduto(i);
                    if (produto != null)
                    {
                        obj.vCustoProduto = produto.vProducao;
                        obj.vVenda = produto.vVenda;
                        obj.idUnidadeMedida = produto.idUnidadeMedidaEstoque;

                        obj.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.Incluido);
                    }
                    lista_Preco_PaiModel.lLista_preco.Add(obj);
                }
                bsListaPreco.DataSource = new List<Lista_precoModel>();
                bsListaPreco.DataSource = lista_Preco_PaiModel.lLista_preco;

            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }
        private void btnAumentoPreco_Click(object sender, EventArgs e)
        {
            try
            {
                if (bsListaPreco.List.Count > 0)
                {
                    //lLista_precoModel = (List<Lista_precoModel>)bsListaPreco.List;
                    FormListaPrecoAumento frm = new FormListaPrecoAumento(lista_Preco_PaiModel.lLista_preco);
                    frm.ShowDialog();
                    if (frm.Aplica)
                    {
                        decimal dValor = 0;
                        decimal dvCustoProdutoComImpostos = 0;

                        if (frm.bPrecoVenda)
                        {
                            foreach (Lista_precoModel listaItem in frm.lLista_precoModel)
                            {
                                if (listaItem.vCustoProduto > 0)
                                {
                                    dValor = (decimal)listaItem.pComissao + (decimal)listaItem.pOutros - (decimal)listaItem.pDesconto;
                                    dvCustoProdutoComImpostos = listaItem.vCustoProduto + ((listaItem.vCustoProduto * dValor) / 100);
                                    listaItem.pLucro = ((listaItem.vVenda - dvCustoProdutoComImpostos) * 100) / listaItem.vCustoProduto;
                                }
                            }
                        }
                        else
                        {
                            foreach (Lista_precoModel listaItem in frm.lLista_precoModel)
                            {
                                dValor = (decimal)listaItem.pComissao + (decimal)listaItem.pOutros - (decimal)listaItem.pDesconto;
                                dvCustoProdutoComImpostos = listaItem.vCustoProduto + ((listaItem.vCustoProduto * dValor) / 100);

                                if (listaItem.pLucro > 0)
                                {
                                    listaItem.vVenda = dvCustoProdutoComImpostos + ((listaItem.vCustoProduto * listaItem.pLucro) / 100);
                                }
                                else if (listaItem.vVenda > 0)
                                {
                                    listaItem.pLucro = ((listaItem.vVenda - dvCustoProdutoComImpostos) * 100) / listaItem.vCustoProduto;
                                }
                            }
                        }
                        Lista_precoModel item;
                        foreach (Lista_precoModel listaItem in frm.lLista_precoModel)
                        {
                            if (listaItem.idListaPreco != null)
                            {
                                item = lista_Preco_PaiModel.lLista_preco.FirstOrDefault(C => C.idListaPreco == listaItem.idListaPreco);
                            }
                            else
                            {
                                item = lista_Preco_PaiModel.lLista_preco.FirstOrDefault(C => C.idProduto == listaItem.idProduto);
                            }
                            lista_Preco_PaiModel.lLista_preco[lista_Preco_PaiModel.lLista_preco.IndexOf(item)].pAcrescimoMaximo = listaItem.pAcrescimoMaximo;
                            lista_Preco_PaiModel.lLista_preco[lista_Preco_PaiModel.lLista_preco.IndexOf(item)].pComissao = listaItem.pComissao;
                            lista_Preco_PaiModel.lLista_preco[lista_Preco_PaiModel.lLista_preco.IndexOf(item)].pComissaoAprazo = listaItem.pComissaoAprazo;
                            lista_Preco_PaiModel.lLista_preco[lista_Preco_PaiModel.lLista_preco.IndexOf(item)].pComissaoAvista = listaItem.pComissaoAvista;
                            lista_Preco_PaiModel.lLista_preco[lista_Preco_PaiModel.lLista_preco.IndexOf(item)].pDesconto = listaItem.pDesconto;
                            lista_Preco_PaiModel.lLista_preco[lista_Preco_PaiModel.lLista_preco.IndexOf(item)].pDescontoMaximo = listaItem.pDescontoMaximo;
                            lista_Preco_PaiModel.lLista_preco[lista_Preco_PaiModel.lLista_preco.IndexOf(item)].pLucro = listaItem.pLucro;
                            lista_Preco_PaiModel.lLista_preco[lista_Preco_PaiModel.lLista_preco.IndexOf(item)].pOutros = listaItem.pOutros;
                            lista_Preco_PaiModel.lLista_preco[lista_Preco_PaiModel.lLista_preco.IndexOf(item)].vCustoProduto = listaItem.vCustoProduto;
                            lista_Preco_PaiModel.lLista_preco[lista_Preco_PaiModel.lLista_preco.IndexOf(item)].vVenda = listaItem.vVenda;

                        }
                        bsListaPreco.DataSource = new List<Lista_precoModel>();
                        bsListaPreco.DataSource = lista_Preco_PaiModel.lLista_preco;
                    }
                }
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }
        private void btnAtribuicao_Click(object sender, EventArgs e)
        {
            try
            {
                if (bsListaPreco.List.Count > 0)
                {
                    //lLista_precoModel = (List<Lista_precoModel>)bsListaPreco.List;
                    FormListaPrecoAtribuicao frm = new FormListaPrecoAtribuicao(lista_Preco_PaiModel.lLista_preco, cbostAtualizacao.SelectedIndex);
                    frm.ShowDialog();
                    if (frm.Aplica)
                    {
                        decimal dValor = 0;
                        decimal dvCustoProdutoComImpostos = 0;
                        if (frm.bpLucro)
                        {
                            foreach (Lista_precoModel listaItem in frm.lLista_precoModel)
                            {
                                dValor = (decimal)listaItem.pComissao + (decimal)listaItem.pOutros - (decimal)listaItem.pDesconto;
                                dvCustoProdutoComImpostos = listaItem.vCustoProduto + ((listaItem.vCustoProduto * dValor) / 100);

                                listaItem.vVenda = dvCustoProdutoComImpostos + ((listaItem.vCustoProduto * listaItem.pLucro) / 100);
                                listaItem.pLucro = ((listaItem.vVenda - dvCustoProdutoComImpostos) * 100) / listaItem.vCustoProduto;
                            }
                        }
                        else if (frm.bvVenda)
                        {
                            foreach (Lista_precoModel listaItem in frm.lLista_precoModel)
                            {
                                if (listaItem.vCustoProduto > 0)
                                {
                                    dValor = (decimal)listaItem.pComissao + (decimal)listaItem.pOutros - (decimal)listaItem.pDesconto;
                                    dvCustoProdutoComImpostos = listaItem.vCustoProduto + ((listaItem.vCustoProduto * dValor) / 100);

                                    listaItem.pLucro = ((listaItem.vVenda - dvCustoProdutoComImpostos) * 100) / listaItem.vCustoProduto;
                                }
                            }
                        }
                        else
                        {
                            foreach (Lista_precoModel listaItem in frm.lLista_precoModel)
                            {
                                dValor = (decimal)listaItem.pComissao + (decimal)listaItem.pOutros - (decimal)listaItem.pDesconto;
                                dvCustoProdutoComImpostos = listaItem.vCustoProduto + ((listaItem.vCustoProduto * dValor) / 100);

                                listaItem.vVenda = dvCustoProdutoComImpostos + ((listaItem.vCustoProduto * listaItem.pLucro) / 100);
                                listaItem.pLucro = ((listaItem.vVenda - dvCustoProdutoComImpostos) * 100) / listaItem.vCustoProduto;
                            }
                        }
                        Lista_precoModel item;
                        foreach (Lista_precoModel listaItem in frm.lLista_precoModel)
                        {
                            if (listaItem.idListaPreco != null)
                            {
                                item = lista_Preco_PaiModel.lLista_preco.FirstOrDefault(C => C.idListaPreco == listaItem.idListaPreco);
                            }
                            else
                            {
                                item = lista_Preco_PaiModel.lLista_preco.FirstOrDefault(C => C.idProduto == listaItem.idProduto);
                            }

                            lista_Preco_PaiModel.lLista_preco[lista_Preco_PaiModel.lLista_preco.IndexOf(item)].pAcrescimoMaximo = listaItem.pAcrescimoMaximo;
                            lista_Preco_PaiModel.lLista_preco[lista_Preco_PaiModel.lLista_preco.IndexOf(item)].pComissao = listaItem.pComissao;
                            lista_Preco_PaiModel.lLista_preco[lista_Preco_PaiModel.lLista_preco.IndexOf(item)].pComissaoAprazo = listaItem.pComissaoAprazo;
                            lista_Preco_PaiModel.lLista_preco[lista_Preco_PaiModel.lLista_preco.IndexOf(item)].pComissaoAvista = listaItem.pComissaoAvista;
                            lista_Preco_PaiModel.lLista_preco[lista_Preco_PaiModel.lLista_preco.IndexOf(item)].pDesconto = listaItem.pDesconto;
                            lista_Preco_PaiModel.lLista_preco[lista_Preco_PaiModel.lLista_preco.IndexOf(item)].pDescontoMaximo = listaItem.pDescontoMaximo;
                            lista_Preco_PaiModel.lLista_preco[lista_Preco_PaiModel.lLista_preco.IndexOf(item)].pLucro = listaItem.pLucro;
                            lista_Preco_PaiModel.lLista_preco[lista_Preco_PaiModel.lLista_preco.IndexOf(item)].pOutros = listaItem.pOutros;
                            lista_Preco_PaiModel.lLista_preco[lista_Preco_PaiModel.lLista_preco.IndexOf(item)].vCustoProduto = listaItem.vCustoProduto;
                            lista_Preco_PaiModel.lLista_preco[lista_Preco_PaiModel.lLista_preco.IndexOf(item)].vVenda = listaItem.vVenda;

                        }
                        bsListaPreco.DataSource = new List<Lista_precoModel>();
                        bsListaPreco.DataSource = lista_Preco_PaiModel.lLista_preco;
                    }
                }
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }



    }
}
