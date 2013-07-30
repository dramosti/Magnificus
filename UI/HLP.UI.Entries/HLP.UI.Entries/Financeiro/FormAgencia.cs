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
using HLP.Models.Entries.Financeiro;
using HLP.Services.Interfaces.Entries.Financeiro;
using HLP.Comum.Messages;
using HLP.Comum.UI.Exception;
using HLP.Services.Interfaces.Entries.Gerais;
using HLP.Dependencies;
using HLP.Comum.Services.Interface;

using System.Threading;
using ComponentFactory.Krypton.Toolkit;
using HLP.Comum.Models;
using HLP.Models.Entries.Gerais;
using HLP.Comum.Infrastructure.Static;

namespace HLP.UI.Entries.Financeiro
{
    public partial class FormAgencia : FormPadraoCadastro
    {
        [Inject]
        public IAgenciaService agenciaService { get; set; }

        [Inject]
        public ICidadeService cidadeService { get; set; }

        [Inject]
        public IBancoService bancoService { get; set; }

        [Inject]
        public IConta_bancariaService contaService { get; set; }


        [Inject]
        public IPesquisaPadraoService pesquisaPadraoService { get; set; }


        Action verifBw = null;
        AgenciaModel objAgencia = new AgenciaModel();

        public FormAgencia()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
        }

        private void FormAgencia_Load(object sender, EventArgs e)
        {
            clidCidade.Tag = "FormCidade-vwCidade-xCidade_Uf_xRegiao_xPais";
            idContato.Tag = "FormContato-vwContato-xNome";
            InicializaFormPadrao("vwAgencia");

            verifBw += (() =>
                {
                    CarregaComboBox();
                });

            Thread t1 = new Thread(new ThreadStart(verifBw));
            t1.Start();
        }

        private void CarregaComboBox()
        {
            if (objMetodosForm != null)
            {
                clidCidade.DataSource = pesquisaPadraoService.GetData(objMetodosForm.GetDisplayMember( clidCidade), true);
                idContato.DataSource = pesquisaPadraoService.GetData(objMetodosForm.GetDisplayMember(idContato), true);
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
            objAgencia = new AgenciaModel();
            bsEndereco.DataSource = objAgencia.lAgencia_Endereco;
            bsContato.DataSource = objAgencia.lAgencia_Contato;
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
            agenciaService.Delete(objAgencia);
            base.Excluir();
            if (iRetPesquisa != null)
            {
                base.MoveProximoItem();
                objAgencia = agenciaService.GetAgencia((int)iRetPesquisa, true);
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
                    objAgencia = agenciaService.GetAgencia((int)lParaExcluir[i], true);
                    agenciaService.Delete(objAgencia);
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
                agenciaService.Save(objAgencia);

                txtCodigo.Text = objAgencia.idAgencia.ToString();
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
                        objAgencia = agenciaService.GetAgencia(Convert.ToInt32(txtCodigo.Text), true);
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
                    objAgencia = agenciaService.GetAgencia((int)iRetPesquisa, true);
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
                    objAgencia = agenciaService.GetAgencia((int)iRetPesquisa, true);
                    if (objAgencia != null)
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
                    objAgencia = agenciaService.GetAgencia((int)iRetPesquisa, true);
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
                agenciaService.Copy(objAgencia);
                PopulaForm();
                base.RegistroDuplicado(idOrigem, (int)objAgencia.idAgencia);
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
                txtCodigo.Text = objAgencia.idAgencia.ToString();
                campoPesquisaidBanco.Value = objAgencia.idBanco;
                txtcAgencia.Text = objAgencia.cAgencia;
                txtxAgencia.Text = objAgencia.xAgencia;
                mskxTelefone.Text = objAgencia.xTelefone;
                txtxFax.Text = objAgencia.xFax;

                bsEndereco.DataSource = objAgencia.lAgencia_Endereco;
                bsContato.DataSource = objAgencia.lAgencia_Contato;
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
                objAgencia.idBanco = campoPesquisaidBanco.Value;
                objAgencia.cAgencia = txtcAgencia.Text;
                objAgencia.xAgencia = txtxAgencia.Text;
                objAgencia.xTelefone = mskxTelefone.Text;
                objAgencia.xFax = txtxFax.Text;
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }


        private void dgvContato_Enter(object sender, EventArgs e)
        {
            Sistema.contatoStatico.idFkReferencia = (txtCodigo.Text != "") ? Convert.ToInt32(txtCodigo.Text) : 0;
            Sistema.contatoStatico.fkTableReferencia = "idAgencia";
        }

        private void FormAgencia_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (async_work.WorkerSupportsCancellation == true)
            {
                async_work.CancelAsync();
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

        private void async_work_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                BackgroundWorker worker = sender as BackgroundWorker;
                List<BancoModel> objListBanco = bancoService.GetAll();
                List<AgenciaModel> objListAgencia = null;
                List<Conta_bancariaModel> objListConta = null;
                TreeNode node;
                this.Invoke(new MethodInvoker(delegate()
                {
                    treeHierarquia.Nodes.Clear();
                    treeHierarquia.Nodes.Add("carregando...");
                }));


                int iCountBanco = 0;
                int iCountAgencia = 0;

                TreeNode nodeRaiz = new TreeNode();
                foreach (BancoModel banco in objListBanco)
                {
                    node = new TreeNode("Banco - " + banco.xBanco, 0, 0);
                    nodeRaiz.Nodes.Add(node);

                    objListAgencia = agenciaService.GetByBanco((int)banco.idBanco);
                    iCountAgencia = 0;
                    foreach (AgenciaModel agencia in objListAgencia)
                    {
                        node = new TreeNode("Agência - " + agencia.cAgencia, 1, 1);
                        nodeRaiz.Nodes[iCountBanco].Nodes.Add(node);

                        objListConta = contaService.GetByAgencia((int)agencia.idAgencia);
                        foreach (Conta_bancariaModel conta in objListConta)
                        {
                            node = new TreeNode("Conta - " + conta.xNumeroConta, 2, 2);
                            nodeRaiz.Nodes[iCountBanco].Nodes[iCountAgencia].Nodes.Add(node);
                        }
                        iCountAgencia++;
                    }
                    iCountBanco++;
                }

                if (worker.CancellationPending != true)
                {
                    this.Invoke(new MethodInvoker(delegate()
                    {
                        treeHierarquia.Nodes.Clear();
                        foreach (TreeNode n in nodeRaiz.Nodes)
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

                        CidadeModel cidade = cidadeService.GetCidadeByName(end.Cidade);
                        if (cidade != null)
                        {
                            (sender as KryptonDataGridView)["clidCidade", e.RowIndex].Value = cidade.idCidade;
                        }
                    }
                }    
            }
        }
    }
}
