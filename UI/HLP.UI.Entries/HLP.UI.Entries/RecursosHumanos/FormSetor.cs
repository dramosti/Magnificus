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
using HLP.Services.Interfaces.Entries.RecursosHumanos;
using HLP.Models.Entries.RecursosHumanos;
using HLP.Dependencies;
using HLP.Comum.Messages;
using HLP.Comum.UI.Exception;

using System.Threading;
using HLP.Comum.Infrastructure.Static;

namespace HLP.UI.Entries.RecursosHumanos
{
    public partial class FormSetor : FormPadraoCadastro
    {
        [Inject]
        public ISetorService setorService { get; set; }

        [Inject]
        public IDepartamentoService departamentoService { get; set; }

        SetorModel setorModel = new SetorModel();

        public FormSetor()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
        }

        private void FormSetor_Load(object sender, EventArgs e)
        {
            InicializaFormPadrao("vwSetor");
        }

        public override void Novo()
        {
            base.Novo();
            setorModel = new SetorModel();
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
                setorService.Save(setorModel);

                txtCodigo.Text = setorModel.idSetor.ToString();

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
                        setorModel = setorService.GetSetor(Convert.ToInt32(txtCodigo.Text));
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
                    setorModel = setorService.GetSetor((int)iRetPesquisa);
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
                    setorModel = setorService.GetSetor((int)iRetPesquisa);
                    if (setorModel != null)
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
                    setorModel = setorService.GetSetor((int)iRetPesquisa);
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
                int i = setorService.Copy(Convert.ToInt32(txtCodigo.Text));
                setorModel = setorService.GetSetor(i);
                PopulaForm();
                base.RegistroDuplicado(idOrigem, i);
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
                    setorService.Delete((int)lParaExcluir[i]);
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
            setorService.Delete(Convert.ToInt32(txtCodigo.Text));
            base.Excluir();
            if (iRetPesquisa != null)
            {
                base.MoveProximoItem();
                setorModel = setorService.GetSetor((int)iRetPesquisa);
                PopulaForm();
            }
        }

        private void PopulaTabela()
        {
            try
            {
                setorModel.xDescricao = txtxDescricao.Text;
                setorModel.xSetor = txtxSetor.Text;
                setorModel.xEmail = txtxEmail.Text;
                setorModel.idEmpresa = CompanyData.idEmpresa;

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
                txtCodigo.Text = setorModel.idSetor.ToString();
                txtxSetor.Text = setorModel.xSetor;
                txtxDescricao.Text = setorModel.xDescricao;
                txtxEmail.Text = setorModel.xEmail;
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }

        }

        private void bwPrincipal_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            List<SetorModel> objSetor = setorService.GetAll();
            List<DepartamentoModel> objDepart;
            TreeNode node = null;
            TreeNode nodeRaiz = new TreeNode();
            this.Invoke(new MethodInvoker(delegate()
            {
                tvHierarquia.Nodes.Clear();
                tvHierarquia.Nodes.Add("carregando...");
            }));

            int iCountSetor = 0;

            foreach (SetorModel itemSetor in objSetor)
            {
                node = new TreeNode("Setor - " + itemSetor.xDescricao, 0, 0);
                nodeRaiz.Nodes.Add(node);
                objDepart = null;
                objDepart = departamentoService.GetBySetor((int)itemSetor.idSetor);
                foreach (DepartamentoModel itemDepart in objDepart)
                {
                    node = new TreeNode("Departamento - " + itemDepart.xDescricao, 1, 1);
                    nodeRaiz.Nodes[iCountSetor].Nodes.Add(node);
                }
                iCountSetor++;
            }

            if (worker.CancellationPending != true)
            {
                this.Invoke(new MethodInvoker(delegate()
                {
                    tvHierarquia.Nodes.Clear();
                    foreach (TreeNode n in nodeRaiz.Nodes)
                    {
                        tvHierarquia.Nodes.Add(n);
                    }
                    tvHierarquia.Focus();
                    tvHierarquia.SelectedNode = tvHierarquia.Nodes[0];
                    tvHierarquia.Nodes[0].Expand();
                }));
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void kryptonTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kryptonTabControl1.SelectedTab == tpHierarquia)
            {
                if (bwPrincipal.IsBusy != true)
                {
                    bwPrincipal.RunWorkerAsync();
                }
            }
        }
    }
}