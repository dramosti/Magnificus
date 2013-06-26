using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HLP.Comum.UI;
using HLP.Dependencies;
using Ninject;
using HLP.Services.Interfaces.Entries.Gerais;
using HLP.Comum.Messages;
using HLP.Comum.UI.Exception;
using System.Threading;
using HLP.Services.Interfaces.Entries.Comercial;
using HLP.Models.Entries.Gerais;

namespace HLP.UI.Entries.Geral
{
    public partial class FormDeposito : FormPadraoCadastro
    {
        [Inject]
        public IDepositoService depositoService { get; set; }

        [Inject]
        public ISiteService siteService { get; set; }

        DepositoModel DepositoModel = new DepositoModel();

        public FormDeposito()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
        }

        private void FormDeposito_Load(object sender, EventArgs e)
        {
            InicializaFormPadrao("vwDeposito");
        }



        public override void Novo()
        {
            base.Novo();
            DepositoModel = new DepositoModel();
            cbostTipo.SelectedIndex = 0;
            cbostGrupoIdentificacao.SelectedIndex = 1;
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
            depositoService.Delete(Convert.ToInt32(txtCodigo.Text));
            base.Excluir();
            if (iRetPesquisa != null)
            {
                base.MoveProximoItem();
                DepositoModel = depositoService.GetDeposito((int)iRetPesquisa);
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
                    depositoService.Delete((int)lParaExcluir[i]);
                    lExcluido.Add(lParaExcluir[i]);
                }
                catch (Exception)
                {
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
                depositoService.Save(DepositoModel);

                txtCodigo.Text = DepositoModel.idDeposito.ToString();
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
                        DepositoModel = depositoService.GetDeposito(Convert.ToInt32(txtCodigo.Text));
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
                    DepositoModel = depositoService.GetDeposito((int)iRetPesquisa);
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
                    DepositoModel = depositoService.GetDeposito((int)iRetPesquisa);
                    if (DepositoModel != null)
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
                    DepositoModel = depositoService.GetDeposito((int)iRetPesquisa);
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
                int i = depositoService.Copy(Convert.ToInt32(txtCodigo.Text));
                DepositoModel = depositoService.GetDeposito(i);
                PopulaForm();
                base.RegistroDuplicado(idOrigem, i);
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
                DepositoModel.idSite = hlP_PesquisaidSite.Value;
                DepositoModel.xDeposito = txtxDeposito.Text;
                DepositoModel.xDescricao = txtxDescricao.Text;
                DepositoModel.stTipo = cbostTipo.SelectedIndexByte;
                DepositoModel.stGrupoIdentificacao = cbostGrupoIdentificacao.SelectedIndexByte;

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
                txtCodigo.Text = DepositoModel.idDeposito.ToString();
                hlP_PesquisaidSite.Value = DepositoModel.idSite;
                txtxDeposito.Text = DepositoModel.xDeposito;
                txtxDescricao.Text = DepositoModel.xDescricao;
                cbostTipo.SelectedIndex = DepositoModel.stTipo;
                cbostGrupoIdentificacao.SelectedIndex = DepositoModel.stGrupoIdentificacao;
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }

        }


        /* MANIPULAÇÃO DA TREEVIEW */

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

        private void FormDeposito_FormClosing(object sender, FormClosingEventArgs e)
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
                TreeNode node= new TreeNode();

                this.Invoke(new MethodInvoker(delegate()
                {
                    treeSite.Nodes.Clear();
                    treeSite.Nodes.Add("carregando...");
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
                        treeSite.Nodes.Clear();
                        foreach (TreeNode n in node.Nodes)
                        {
                            treeSite.Nodes.Add(n);
                        }
                        treeSite.Focus();
                        treeSite.SelectedNode = treeSite.Nodes[0];
                        treeSite.Nodes[0].Expand();
                    }));
                }
                else
                {
                    e.Cancel = true;
                }

            }
            catch (System.Exception ex)
            {
                new HLPexception(ex);
            }
        }
    }
}
