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
using HLP.Services.Interfaces.Entries.Gerais;
using HLP.Comum.Services.Interface;
using HLP.Dependencies;
using HLP.Models.Entries.Comercial;
using HLP.Comum.Messages;
using HLP.Comum.UI.Exception;
using System.Threading;
using ComponentFactory.Krypton.Toolkit;
using HLP.Comum.Models;
using HLP.Models.Entries.Gerais;
using HLP.Services.Interfaces.Entries.Comercial;


namespace HLP.UI.Entries.Geral.Basico
{
    public partial class FormSite : FormPadraoCadastro
    {
        [Inject]
        public ISiteService siteService { get; set; }

        [Inject]
        public ICidadeService cidadeService { get; set; }

        [Inject]
        public IDepositoService depositoService { get; set; }

        [Inject]
        public IPesquisaPadraoService pesquisaPadraoService { get; set; }

        SiteModel objSiteModel = new SiteModel();
        Action verBw = null;

        public FormSite()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
        }

        void FormSite_Leave(object sender, EventArgs e)
        {
            SendKeys.Send("{RIGHT}");
        }

        private void FormSite_Load(object sender, EventArgs e)
        {
            clidCidade.Tag = "FormCidade-vwCidade-xCidade_Uf_xRegiao_xPais";
            InicializaFormPadrao("vwSite");

            verBw += (() =>
                {
                    CarregaComboBox();
                });

            Thread t1 = new Thread(new ThreadStart(verBw));
            t1.Start();
        }

        private void CarregaComboBox()
        {
            if (objMetodosForm != null)
            {
                clidCidade.DataSource = pesquisaPadraoService.GetData(objMetodosForm.GetDisplayMember(clidCidade), true);
                Thread.CurrentThread.Abort();
            }
            else
            {
                Thread.Sleep(500);
                CarregaComboBox();
            }
        }


        public override void Novo()
        {
            base.Novo();
            objSiteModel = new SiteModel();
            bsEndereco.DataSource = objSiteModel.lSite_Endereco;
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
        private void ExcluirRegistro()
        {
            siteService.Delete(objSiteModel);
            base.Excluir();
            bsEndereco.DataSource = new List<Site_enderecoModel>();

            if (iRetPesquisa != null)
            {
                base.MoveProximoItem();
                objSiteModel = siteService.GetSite((int)iRetPesquisa, true);
                PopulaForm();
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
                    objSiteModel = siteService.GetSite((int)lParaExcluir[i], true);
                    siteService.Delete(objSiteModel);
                    lExcluido.Add(lParaExcluir[i]);
                }
                catch (Exception ex)
                {
                    new HLPexception(ex);
                }
            }
            base.FinalizaExcluirTodos();
        }

        public override void Atualizar()
        {
            base.Atualizar();
        }
        public override void Salvar()
        {
            try
            {
                objValidaCampos.Validar();
                PopulaTabela();

                siteService.Save(objSiteModel);

                txtCodigo.Text = objSiteModel.idSite.ToString();
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
                        objSiteModel = siteService.GetSite(Convert.ToInt32(txtCodigo.Text), true);
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
                    objSiteModel = siteService.GetSite((int)iRetPesquisa, true);
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
                    objSiteModel = siteService.GetSite((int)iRetPesquisa, true);
                    if (objSiteModel != null)
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
                    objSiteModel = siteService.GetSite((int)iRetPesquisa, true);
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
                siteService.Copy(objSiteModel);
                PopulaForm();
                base.RegistroDuplicado(idOrigem, (int)objSiteModel.idSite);
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
                objSiteModel.xSite = txtxSite.Text;
                objSiteModel.xDescricao = txtxDescricao.Text;
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
                txtCodigo.Text = objSiteModel.idSite.ToString();
                txtxSite.Text = objSiteModel.xSite;
                txtxDescricao.Text = objSiteModel.xDescricao;
                bsEndereco.DataSource = objSiteModel.lSite_Endereco;

            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }

        }

        private void kryptonTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (kryptonTabControl1.SelectedTab == tabHierarquia)
            {
                if (async_work.IsBusy != true)
                {
                    async_work.RunWorkerAsync();
                }
            }
        }

        private void FormSite_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (async_work.WorkerSupportsCancellation == true)
            {
                async_work.CancelAsync();
            }
        }

        private void async_work_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                BackgroundWorker worker = sender as BackgroundWorker;
                List<SiteModel> objListSite = siteService.GetAll();
                List<DepositoModel> objListDeposito = null;
                TreeNode node = new TreeNode();
                this.Invoke(new MethodInvoker(delegate()
                {
                    treeHierarquia.Nodes.Clear();
                    treeHierarquia.Nodes.Add("carregando...");
                }));

                int iCount = 0;
                foreach (SiteModel site in objListSite)
                {
                    node.Nodes.Add("Site - " + site.xSite, "Site - " + site.xSite, 3, 3);

                    objListDeposito = depositoService.GetBySite((int)site.idSite);
                    foreach (DepositoModel deposito in objListDeposito)
                    {
                        if (deposito.stTipo == 0)
                        {
                            node.Nodes[iCount].Nodes.Add(deposito.idDeposito + ", " + deposito.xDeposito, "Depósito - " + deposito.xDeposito, 0, 0);
                        }
                        else if (deposito.stTipo == 1)
                        {
                            node.Nodes[iCount].Nodes.Add(deposito.idDeposito + ", " + deposito.xDeposito, "Depósito - " + deposito.xDeposito, 1, 1);
                        }
                        else
                        {
                            node.Nodes[iCount].Nodes.Add(deposito.idDeposito + ", " + deposito.xDeposito, "Depósito - " + deposito.xDeposito, 2, 2);
                        }
                    }
                    iCount++;
                }
                if (worker.CancellationPending != true)
                {
                    this.Invoke(new MethodInvoker(delegate()
                    {
                        treeHierarquia.Nodes.Clear();
                        foreach (TreeNode n in node.Nodes)
                        {
                            treeHierarquia.Nodes.Add(n);
                        }
                        treeHierarquia.Focus();
                        if (treeHierarquia.Nodes.Count > 0)
                        {
                            treeHierarquia.SelectedNode = treeHierarquia.Nodes[0];
                            treeHierarquia.Nodes[0].Expand();
                        }
                    }));
                }
                else
                {
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }

        }

        private void dgvEnderecos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if ((sender as KryptonDataGridView).Columns[e.ColumnIndex] == clxCEP)
                {
                    HLP.Comum.Ws.Endereco end = HLP.Comum.Ws.ServiceCep.BuscaEndereco((sender as KryptonDataGridView)[e.ColumnIndex, e.RowIndex].Value.ToString());
                    if (end != null)
                    {
                        (sender as KryptonDataGridView)["clxEndereco", e.RowIndex].Value = end.Logradouro;
                        (sender as KryptonDataGridView)["clxBairro", e.RowIndex].Value = end.Bairro;

                        CidadeModel city = cidadeService.GetCidadeByName(end.Cidade);
                        if (city != null)
                        {
                            (sender as KryptonDataGridView)["clidCidade", e.RowIndex].Value = city.idCidade; ;
                        }
                    }
                }
            }
        }
    }
}
