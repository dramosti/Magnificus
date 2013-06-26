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
using HLP.Services.Interfaces.Entries.Comercial;
using HLP.Models.Entries.Comercial;
using HLP.Comum.Messages;
using HLP.Comum.UI.Exception;
using System.Threading;

namespace HLP.UI.Entries.Comercial
{
    public partial class FormSite : FormPadraoCadastro
    {
        [Inject]
        public ISiteService siteService { get; set; }

        [Inject]
        public ISite_enderecoService siteEnderecoService { get; set; }

        [Inject]
        public ICidadeService cidadeService { get; set; }

        [Inject]
        public IDepositoService depositoService { get; set; }

        [Inject]
        public IPesquisaPadraoService pesquisaPadraoService { get; set; }

        SiteModel siteModel = new SiteModel();
        List<Site_enderecoModel> lsite_enderecoModel = new List<Site_enderecoModel>();

        public FormSite()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
        }

        private void FormSite_Load(object sender, EventArgs e)
        {
            idCidade.Tag = "FormCidade-Cidade";

            InicializaFormPadrao("vwSite");

            idCidade.DisplayMember = "xCidade";
            idCidade.ValueMember = "idCidade";
            idCidade.DataSource = pesquisaPadraoService.GetData(objMetodosForm.GetDisplayMember(idCidade, "Cidade"), true);

        }


        public override void Novo()
        {
            base.Novo();
            siteModel = new SiteModel();
            bsEndereco.DataSource = new List<Site_enderecoModel>();
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
                siteService.RollBack();
                new HLPexception(ex);
            }
        }
        private void ExcluirRegistro()
        {
            siteService.Begin();

            foreach (Site_enderecoModel endereco in bsEndereco.List)
            {
                siteEnderecoService.Delete((int)endereco.idEndereco);
            }
            siteService.Delete(Convert.ToInt32(txtCodigo.Text));
            siteService.Commit();
            base.Excluir();
            bsEndereco.DataSource = new List<Site_enderecoModel>();

            if (iRetPesquisa != null)
            {
                base.MoveProximoItem();
                siteModel = siteService.GetSite((int)iRetPesquisa);
                lsite_enderecoModel = siteEnderecoService.GetAll((int)iRetPesquisa);
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
                    siteService.Begin();
                    Invoke(new MethodInvoker(delegate
                    {
                        pbProgresso.PerformStep();
                        lblProgresso.Text = (i + 1) + " de " + bsRetPesquisa.List.Count;
                    }));
                    lsite_enderecoModel = siteEnderecoService.GetAll((int)lParaExcluir[i]);
                    foreach (Site_enderecoModel endereco in lsite_enderecoModel)
                    {
                        siteEnderecoService.Delete((int)endereco.idEndereco);
                    }
                    siteService.Delete((int)lParaExcluir[i]);
                    siteService.Commit();
                    lExcluido.Add(lParaExcluir[i]);
                }
                catch (Exception)
                {
                    siteService.RollBack();
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

                siteService.Begin();
                siteService.Save(siteModel);

                foreach (Site_enderecoModel endereco in bsEndereco.List)
                {
                    endereco.idSite = (int)siteModel.idSite;
                    siteEnderecoService.Save(endereco);
                }

                List<int?> lNotInn = ((List<Site_enderecoModel>)bsEndereco.DataSource).Where(C => C.idEndereco != null).Select(C => C.idEndereco).ToList();
                siteEnderecoService.Delete((int)siteModel.idSite, lNotInn);

                siteService.Commit();

                txtCodigo.Text = siteModel.idSite.ToString();
                base.Salvar();

            }
            catch (Exception ex)
            {
                siteService.RollBack();
                new HLPexception(ex);
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
                        siteModel = siteService.GetSite(Convert.ToInt32(txtCodigo.Text));
                        lsite_enderecoModel = siteEnderecoService.GetAll(Convert.ToInt32(txtCodigo.Text));
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
                    siteModel = siteService.GetSite((int)iRetPesquisa);
                    lsite_enderecoModel = siteEnderecoService.GetAll((int)iRetPesquisa);
                    PopulaForm();
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
                    siteModel = siteService.GetSite((int)iRetPesquisa);
                    if (siteModel != null)
                    {
                        lsite_enderecoModel = siteEnderecoService.GetAll((int)iRetPesquisa);
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
                    siteModel = siteService.GetSite((int)iRetPesquisa);
                    lsite_enderecoModel = siteEnderecoService.GetAll((int)iRetPesquisa);
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
                int i = siteService.Copy(Convert.ToInt32(txtCodigo.Text));
                siteModel = siteService.GetSite(i);

                siteService.Begin();
                foreach (Site_enderecoModel endereco in bsEndereco.List)
                {
                    endereco.idSite = (int)siteModel.idSite;
                    endereco.idEndereco = null;
                    siteEnderecoService.Save(endereco);
                }
                siteService.Commit();
                lsite_enderecoModel = siteEnderecoService.GetAll((int)siteModel.idSite);
                PopulaForm();
                base.RegistroDuplicado(idOrigem, i);
            }
            catch (Exception ex)
            {
                siteService.RollBack();
                new HLPexception(ex);
            }
        }




        private void PopulaTabela()
        {
            try
            {
                siteModel.nSite = txtnSite.Text;
                siteModel.xDescricao = txtxDescricao.Text;
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
                txtCodigo.Text = siteModel.idSite.ToString();
                txtnSite.Text = siteModel.nSite;
                txtxDescricao.Text = siteModel.xDescricao;
                bsEndereco.DataSource = lsite_enderecoModel;

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
                    node.Nodes.Add("Site - " + site.nSite, "Site - " + site.nSite, 3, 3);

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
                        treeHierarquia.SelectedNode = treeHierarquia.Nodes[0];
                        treeHierarquia.Nodes[0].Expand();
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
    }
}
