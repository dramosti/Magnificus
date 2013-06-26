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
using HLP.Models.Entries.Financeiro;
using HLP.Services.Interfaces.Entries.Financeiro;
using HLP.Comum.Messages;
using HLP.Comum.UI.Exception;
using System.Threading;
using ComponentFactory.Krypton.Toolkit;
using HLP.Comum.Models.Static;

namespace HLP.UI.Entries.Financeiro
{
    public partial class FormBanco : FormPadraoCadastro
    {
        [Inject]
        public IBancoService bancoService { get; set; }

        [Inject]
        public IConta_bancariaService contaService { get; set; }

        [Inject]
        public IAgenciaService agenciaService { get; set; }

        BancoModel bancoModel = new BancoModel();
        ButtonSpecAny btnLinkLogo; //Botão do textbox de pesquisa de imagem

        public FormBanco()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
        }

        private void FormBanco_Load(object sender, EventArgs e)
        {
            InicializaFormPadrao("vwBanco");

            btnLinkLogo = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            btnLinkLogo.Image = HLP.UI.Entries.Properties.Resources.Pasta;
            btnLinkLogo.Click += new EventHandler(btnLinkLogo_Click);
        }

        void btnLinkLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog linkLogo = new OpenFileDialog();
            linkLogo.Title = "Selecione a imagem para o logo";
            linkLogo.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG) | *.BMP;*.JPG;*.GIF;*.PNG";
            linkLogo.ShowDialog();

            txtxLinkLogo.Text = linkLogo.FileName;
        }




        public override void Novo()
        {
            txtxLinkLogo.txt.ButtonSpecs.Add(btnLinkLogo); //adiciona o botão de pesquisa para o textbox
            
            base.Novo();
            bancoModel = new BancoModel();

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
            bancoService.Delete(Convert.ToInt32(txtCodigo.Text));
            base.Excluir();
            if (iRetPesquisa != null)
            {
                base.MoveProximoItem();
                bancoModel = bancoService.GetBanco((int)iRetPesquisa);
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
                    bancoService.Delete((int)lParaExcluir[i]);
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
            txtxLinkLogo.txt.ButtonSpecs.Add(btnLinkLogo); //adiciona o botão de pesquisa para o textbox

            base.Atualizar();
        }
        public override void Salvar()
        {
            try
            {
                objValidaCampos.Validar();

                PopulaTabela();
                bancoService.Save(bancoModel);

                txtCodigo.Text = bancoModel.idBanco.ToString();
                base.Salvar();

                txtxLinkLogo.txt.ButtonSpecs.Remove(btnLinkLogo); //Remove o botão se cancelar

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
                        bancoModel = bancoService.GetBanco(Convert.ToInt32(txtCodigo.Text));
                        PopulaForm();
                        HabilitaBotoes(1);
                    }
                    txtxLinkLogo.txt.ButtonSpecs.Remove(btnLinkLogo); //Remove o botão se cancelar
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
                    bancoModel = bancoService.GetBanco((int)iRetPesquisa);
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
                    bancoModel = bancoService.GetBanco((int)iRetPesquisa);
                    if (bancoModel != null)
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
                    bancoModel = bancoService.GetBanco((int)iRetPesquisa);
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
                int i = bancoService.Copy(Convert.ToInt32(txtCodigo.Text));
                bancoModel = bancoService.GetBanco(i);
                PopulaForm();
                base.RegistroDuplicado(idOrigem, i);
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }



        public void PopulaTabela()
        {
            try
            {
                bancoModel.cBanco = txtcBanco.Text;
                bancoModel.xBancoResumido = txtxBancoResumido.Text;
                bancoModel.xBanco = txtxBanco.Text;
                bancoModel.xLinkLogo = txtxLinkLogo.Text;
                bancoModel.vDxMais = Convert.ToByte(nudvDxMais.Value);
                bancoModel.vDxMenos = Convert.ToByte(nudvDxMenos.Value);
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }

        }
        public void PopulaForm()
        {
            txtCodigo.Text = bancoModel.idBanco.ToString();
            txtcBanco.Text = bancoModel.cBanco;
            txtxBancoResumido.Text = bancoModel.xBancoResumido;
            txtxBanco.Text = bancoModel.xBanco;
            txtxLinkLogo.Text = bancoModel.xLinkLogo;
            nudvDxMais.Value = bancoModel.vDxMais;
            nudvDxMenos.Value = bancoModel.vDxMenos;
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

        private void FormBanco_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
