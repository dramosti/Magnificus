﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HLP.Comum.UI;
using HLP.Models.Entries.RecursosHumanos;
using Ninject;
using HLP.Dependencies;
using HLP.Comum.Messages;
using HLP.Comum.UI.Exception;
using HLP.Services.Interfaces.Entries.RecursosHumanos;
using System.Threading;

namespace HLP.UI.Entries.RecursosHumanos
{
    public partial class FormDepartamento : FormPadraoCadastro
    {
        [Inject]
        public IDepartamentoService departamentoService { get; set; }

        [Inject]
        public ISetorService setorService { get; set; }


        DepartamentoModel departamentoModel = new DepartamentoModel();
        public FormDepartamento()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
        }

        private void FormDepartamento_Load(object sender, EventArgs e)
        {
            InicializaFormPadrao("vwDepartamento");
        }



        public override void Novo()
        {
            base.Novo();
            departamentoModel = new DepartamentoModel();
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
                departamentoService.Save(departamentoModel);

                txtCodigo.Text = departamentoModel.idDepartamento.ToString();

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
                        departamentoModel = departamentoService.GetDepartamento(Convert.ToInt32(txtCodigo.Text));
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
                    departamentoModel = departamentoService.GetDepartamento((int)iRetPesquisa);
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
                    departamentoModel = departamentoService.GetDepartamento((int)iRetPesquisa);
                    if (departamentoModel != null)
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
                    departamentoModel = departamentoService.GetDepartamento((int)iRetPesquisa);
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
                int i = departamentoService.Copy(Convert.ToInt32(txtCodigo.Text));
                departamentoModel = departamentoService.GetDepartamento(i);
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
                    departamentoService.Delete((int)lParaExcluir[i]);
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
            departamentoService.Delete(Convert.ToInt32(txtCodigo.Text));
            base.Excluir();
            if (iRetPesquisa != null)
            {
                base.MoveProximoItem();
                departamentoModel = departamentoService.GetDepartamento((int)iRetPesquisa);
                PopulaForm();
            }
        }



        private void PopulaTabela()
        {
            try
            {
                base.CarregaClasse(departamentoModel);
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
                base.CarregaPropriedades(departamentoModel, true);
                base.CarregaForm();
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
