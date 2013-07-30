using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using HLP.Comum.UI;
using Ninject;
using HLP.Services.Interfaces.Entries.Gerais;
using HLP.Models.Entries.Gerais;
using HLP.Dependencies;
using HLP.Comum.Services.Interface;
using HLP.Comum.UI.Exception;
using HLP.Comum.Messages;

using System.Threading;
using HLP.Comum.Infrastructure.Static;

namespace HLP.UI.Entries.Geral
{
    public partial class FormFamiliaProduto : FormPadraoCadastro
    {

        [Inject]
        public IFamilia_ProdutoService familiaProdService { get; set; }

        [Inject]
        public IPesquisaPadraoService pesquisaPadraoService { get; set; }

        Action verifBw = null;
        Familia_produtoModel familiaProdModel = new Familia_produtoModel();
        Thread t1;

        public FormFamiliaProduto()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
        }
        private void FormFamiliaProduto_Load(object sender, EventArgs e)
        {
            idClasseFinanceira.Tag = "FormClasseFinanceira-vwClasseFinanceira-xClasseFinanceira";
            idTipoOperacao.Tag = "FormTipoOperacao-vwTipoOperacao-xOperacao";
            InicializaFormPadrao("vwFamiliaProduto");

            verifBw += (() =>
            {
                AfterInitializeHLP();
            });

            t1 = new Thread(new ThreadStart(verifBw));
            t1.Start();
            hlP_PesquisaidLinhaProdutoBase.txtPesquisa.Validating += new CancelEventHandler(txtPesquisa_Validating);
                //+= new EventHandler(hlP_PesquisaidLinhaProdutoBase_Validated);


        }

        void txtPesquisa_Validating(object sender, CancelEventArgs e)
        {
            if (hlP_PesquisaidLinhaProdutoBase.txtPesquisa.Text.Trim().Length > 0)
            {
                if (familiaProdModel.lFamilia_Produto_Classe.Count > 0)
                {
                    HLPMessageBox.ShowAviso("Remova os Itens lançados na aba('Classificação financeira  das Familias de produtos') para poder inserir uma linha de produto base.");
                    e.Cancel = true;
                    hlP_PesquisaidLinhaProdutoBase.txtPesquisa.Text = "";
                    hlP_PesquisaidLinhaProdutoBase.txtDisplay.Text = ""; 
                }
                else
                {
                    dgvClassificacaoFinanc.ReadOnly = true;
                }
            }
            else
            {
                dgvClassificacaoFinanc.ReadOnly = false;
            }
        }

        private void AfterInitializeHLP()
        {
            try
            {
                if (objMetodosForm != null)
                {
                    idClasseFinanceira.DataSource = pesquisaPadraoService.GetData(objMetodosForm.GetDisplayMember(idClasseFinanceira), true);
                    idTipoOperacao.DataSource = pesquisaPadraoService.GetData(objMetodosForm.GetDisplayMember(idTipoOperacao), true);
                    Thread.CurrentThread.Abort();
                    //if (nudpDescontoMaximo.nud.Maximum > 101)
                    //    nudpDescontoMaximo.nud.Maximum = 101;
                    //if (nudpAcrescimoMaximo.nud.Maximum > 101)
                    //    nudpAcrescimoMaximo.nud.Maximum = 101;
                }
                else
                {
                    Thread.Sleep(500);
                    AfterInitializeHLP();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void Novo()
        {
            try
            {
                base.Novo();
                familiaProdModel = new Familia_produtoModel();
                familiaProdModel.lFamilia_Produto_Classe = new List<Familia_Produto_ClassesModel>();
                bsFamiliaProduto.DataSource = familiaProdModel.lFamilia_Produto_Classe;
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }
        public override void Salvar()
        {
            if (hlP_PesquisaidLinhaProdutoBase.txtPesquisa.Text.Trim().Length > 0)
            {
                familiaProdModel.lFamilia_Produto_Classe = new List<Familia_Produto_ClassesModel>();
                bsFamiliaProduto.DataSource = familiaProdModel.lFamilia_Produto_Classe;
                dgvClassificacaoFinanc.ReadOnly = true;
            }
            else
            {
                dgvClassificacaoFinanc.ReadOnly = false;
            }


            try
            {
                objValidaCampos.Validar();
                PopulaTabela();
                familiaProdService.Save(familiaProdModel);
                txtCodigo.Text = familiaProdModel.idFamiliaProduto.ToString();
                base.Salvar();
            }
            catch (Exception ex)
            {
                new HLPexception(ex, this);
            }
        }
        public override void Atualizar()
        {
            base.Atualizar();
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
                    familiaProdModel = familiaProdService.GetFamilia_produto((int)iRetPesquisa, true);
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
                    familiaProdModel = familiaProdService.GetFamilia_produto((int)iRetPesquisa, true);
                    if (familiaProdModel != null)
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
        public override void Duplicar()
        {
            try
            {
                int idOrigem = Convert.ToInt32(txtCodigo.Text);
                familiaProdService.Copy(familiaProdModel);
                int i = familiaProdModel.idFamiliaProduto.ToInt32();
                familiaProdModel = familiaProdService.GetFamilia_produto(i, true);
                PopulaForm();
                base.RegistroDuplicado(idOrigem, i);
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
                    familiaProdModel = familiaProdService.GetFamilia_produto((int)iRetPesquisa, true);
                    PopulaForm();
                }
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
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
                        bsFamiliaProduto.DataSource = new List<Familia_Produto_ClassesModel>();
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
                    familiaProdModel = familiaProdService.GetFamilia_produto((int)lParaExcluir[i], true);
                    familiaProdService.Delete(familiaProdModel);
                    lExcluido.Add(lParaExcluir[i]);
                }
                catch (Exception)
                {
                }
            }

            base.FinalizaExcluirTodos();
        }
        private void ExcluirRegistro()
        {
            familiaProdService.Delete(familiaProdModel);
            base.Excluir();
            if (iRetPesquisa != null)
            {
                base.MoveProximoItem();
                familiaProdModel = familiaProdService.GetFamilia_produto((int)iRetPesquisa, true);
                PopulaForm();
            }
        }


        void PopulaTabela()
        {
            familiaProdModel.idEmpresa = CompanyData.idEmpresa;
            familiaProdModel.xFamiliaProduto = txtxFamiliaProduto.Text;
            familiaProdModel.xDescricao = txtxDescricao.Text;
            familiaProdModel.xSigla = txtxSigla.Text;
            familiaProdModel.pDescontoMaximo = nudpDescontoMaximo.Value;
            familiaProdModel.pAcressimoMaximo = nudpAcrescimoMaximo.Value;
            if (hlP_PesquisaidContaContabil.Value != 0)
                familiaProdModel.idContaContabil = hlP_PesquisaidContaContabil.Value;
            if (hlP_PesquisaidCentroCusto.Value != 0)
                familiaProdModel.idCentroCusto = hlP_PesquisaidCentroCusto.Value;
            familiaProdModel.pComissaoAprazo = nudpComissaoAprazo.Value;
            familiaProdModel.pComissaoAvista = nudpComissaoAvista.Value;
            if (hlP_PesquisaidLinhaProdutoBase.Value != 0)
                familiaProdModel.idFamiliaProdutoBase = hlP_PesquisaidLinhaProdutoBase.Value;
            familiaProdModel.stgrau = cbxstGrau.SelectedIndexByte;
            familiaProdModel.stAlteraDescricaoComercialProdutoVenda = cbostAlteraDescricaoComercialProdutoVenda.SelectedIndexByte;


            bsFamiliaProduto.DataSource = familiaProdModel.lFamilia_Produto_Classe;


        }

        void PopulaForm()
        {
            txtCodigo.Text = familiaProdModel.idFamiliaProduto.ToString();

            txtxFamiliaProduto.Text = familiaProdModel.xFamiliaProduto;
            txtxDescricao.Text = familiaProdModel.xDescricao;
            txtxSigla.Text = familiaProdModel.xSigla;
            nudpDescontoMaximo.Value = familiaProdModel.pDescontoMaximo;
            nudpAcrescimoMaximo.Value = familiaProdModel.pAcressimoMaximo;
            if (familiaProdModel.idContaContabil != null)
                hlP_PesquisaidContaContabil.Value = (int)familiaProdModel.idContaContabil;
            if (familiaProdModel.idCentroCusto != null)
                hlP_PesquisaidCentroCusto.Value = (int)familiaProdModel.idCentroCusto;
            nudpComissaoAprazo.Value = familiaProdModel.pComissaoAprazo;
            nudpComissaoAvista.Value = familiaProdModel.pComissaoAvista;
            if (familiaProdModel.idFamiliaProdutoBase != null)
                hlP_PesquisaidLinhaProdutoBase.Value = (int)familiaProdModel.idFamiliaProdutoBase;
            cbxstGrau.SelectedIndex = familiaProdModel.stgrau;
            cbostAlteraDescricaoComercialProdutoVenda.SelectedIndex= familiaProdModel.stAlteraDescricaoComercialProdutoVenda;
            bsFamiliaProduto.DataSource = familiaProdModel.lFamilia_Produto_Classe;

        }

        private void nudpDescontoMaximo__Leave(object sender, EventArgs e)
        {

        }


    }
}
