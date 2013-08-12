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
using HLP.Services.Interfaces.Entries.Financeiro;
using HLP.Models.Entries.Financeiro;
using HLP.Comum.Messages;
using HLP.Comum.UI.Exception;

using System.Threading;
using HLP.Comum.Infrastructure.Static;

namespace HLP.UI.Entries.Financeiro
{
    public partial class FormContaBancaria : FormPadraoCadastro
    {
        [Inject]
        public IConta_bancariaService contaService { get; set; }

        [Inject]
        public IBancoService bancoService { get; set; }

        [Inject]
        public IAgenciaService agenciaService { get; set; }

        Conta_bancariaModel contaModel = new Conta_bancariaModel();


        public FormContaBancaria()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
        }

        private void FormContaBancaria_Load(object sender, EventArgs e)
        {
            InicializaFormPadrao("vwContaBancaria");
        }




        public override void Novo()
        {

            base.Novo();
            cbostConta.SelectedIndex = 1;
            cbostBloquete.SelectedIndex = 0;
            cbxstPessoa.SelectedIndex = 0;
            cbostAceite.SelectedIndex = 0;
            cbostZeraNossoNumero.SelectedIndex = 0;
            contaModel = new Conta_bancariaModel();
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
            contaService.Delete(Convert.ToInt32(txtCodigo.Text));
            base.Excluir();
            if (iRetPesquisa != null)
            {
                base.MoveProximoItem();
                contaModel = contaService.GetConta((int)iRetPesquisa);
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
                    contaService.Delete((int)lParaExcluir[i]);
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
                contaService.Save(contaModel);

                txtCodigo.Text = contaModel.idContaBancaria.ToString();
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
                        contaModel = contaService.GetConta(Convert.ToInt32(txtCodigo.Text));
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
                    contaModel = contaService.GetConta((int)iRetPesquisa);
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
                    contaModel = contaService.GetConta((int)iRetPesquisa);
                    if (contaModel != null)
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
                    contaModel = contaService.GetConta((int)iRetPesquisa);
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
                int i = contaService.Copy(Convert.ToInt32(txtCodigo.Text));
                contaModel = contaService.GetConta(i);
                PopulaForm();
                base.RegistroDuplicado(idOrigem, i);
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
                base.CarregaPropriedades(contaModel, true);
                base.CarregaForm();
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
                base.CarregaClasse(contaModel);
                contaModel.idEmpresa = CompanyData.idEmpresa;
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

        private void FormContaBancaria_FormClosing(object sender, FormClosingEventArgs e)
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
                List<BancoModel> objListBanco = bancoService.GetAll();
                List<AgenciaModel> objListAgencia = null;
                List<Conta_bancariaModel> objListConta = null;

                this.Invoke(new MethodInvoker(delegate()
                {
                    treeHierarquia.Nodes.Clear();
                    treeHierarquia.Nodes.Add("carregando...");
                }));

                int iCountBanco = 0;
                int iCountAgencia = 0;

                TreeNode tNode = new TreeNode();
                foreach (BancoModel banco in objListBanco)
                {
                    TreeNode node = new TreeNode("Banco - " + banco.xBanco, 0, 0);
                    tNode.Nodes.Add(node);

                    objListAgencia = agenciaService.GetByBanco((int)banco.idBanco);
                    iCountAgencia = 0;
                    foreach (AgenciaModel agencia in objListAgencia)
                    {
                        node = new TreeNode("Agência - " + agencia.cAgencia, 1, 1);
                        tNode.Nodes[iCountBanco].Nodes.Add(node);

                        objListConta = contaService.GetByAgencia((int)agencia.idAgencia);
                        foreach (Conta_bancariaModel conta in objListConta)
                        {
                            node = new TreeNode("Conta - " + conta.xNumeroConta, 2, 2);
                            tNode.Nodes[iCountBanco].Nodes[iCountAgencia].Nodes.Add(node);
                        }
                        iCountAgencia++;
                    }
                    iCountBanco++;
                }

                if (async_work.CancellationPending != true)
                {
                    this.Invoke(new MethodInvoker(delegate()
                    {
                        treeHierarquia.Nodes.Clear();
                        foreach (TreeNode n in tNode.Nodes)
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

        private void cbxstPessoa__SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxstPessoa.SelectedIndex == 0)
            {
                mskxCNPJouCPFTitular._TpValidacao = Comum.Components.HLP_MaskedTextBox.TipoValidacao.CPF;
            }
            else if (cbxstPessoa.SelectedIndex == 1)
            {
                mskxCNPJouCPFTitular._TpValidacao = Comum.Components.HLP_MaskedTextBox.TipoValidacao.CNPJ;
            }
        }

        private void Principal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbostConta__SelectedValueChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Enabled = ((btnSalvar.Enabled) && !(cbostConta.Text.Contains("CAIXA")));
        }


    }
}
