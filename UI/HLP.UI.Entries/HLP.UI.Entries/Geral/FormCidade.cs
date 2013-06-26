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
using HLP.Dependencies;
using HLP.Models.Entries.Gerais;
using HLP.Comum.Messages;
using HLP.Comum.UI.Exception;
using System.Threading;

namespace HLP.UI.Entries.Geral
{
    public partial class FormCidade : FormPadraoCadastro
    {
        [Inject]
        public IUFService ufService { get; set; }

        [Inject]
        public ICidadeService cidadeService { get; set; }

        CidadeModel cidadeModel = new CidadeModel();


        public FormCidade()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
        }

        private void FormCidade_Load(object sender, EventArgs e)
        {
            InicializaFormPadrao("vwCidade");
            cboidUf.DataSource = ufService.GetAlltoComboBox();
            cboidUf.DisplayMember = "xSiglaUf";
            cboidUf.ValueMember = "ID";
            cboidUf.SelectedIndex = -1;
        }



        public override void Novo()
        {
            base.Novo();
            cidadeModel = new CidadeModel();

            cboidUf.SelectedIndex = -1;
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
                cidadeService.Save(cidadeModel);

                txtCodigo.Text = cidadeModel.idCidade.ToString();

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
                        cidadeModel = cidadeService.GetCidade(Convert.ToInt32(txtCodigo.Text));
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
                    cidadeModel = cidadeService.GetCidade((int)iRetPesquisa);
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
                    cidadeModel = cidadeService.GetCidade((int)iRetPesquisa);
                    if (cidadeModel != null)
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
                    cidadeModel = cidadeService.GetCidade((int)iRetPesquisa);
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
                int i = cidadeService.Copy(Convert.ToInt32(txtCodigo.Text));
                cidadeModel = cidadeService.GetCidade(i);
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
                    cidadeService.Delete((int)lParaExcluir[i]);
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
            cidadeService.Delete(Convert.ToInt32(txtCodigo.Text));
            base.Excluir();
            if (iRetPesquisa != null)
            {
                base.MoveProximoItem();
                cidadeModel = cidadeService.GetCidade((int)iRetPesquisa);
                PopulaForm();
            }
        }



        private void PopulaTabela()
        {
            try
            {
                cidadeModel.xCidade = txtxCidade.Text;
                cidadeModel.cIbge = nudcIbge.ValueInt;
                cidadeModel.idUF = (int)cboidUf.SelectedValue;

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
                txtCodigo.Text = cidadeModel.idCidade.ToString();
                txtxCidade.Text = cidadeModel.xCidade;
                nudcIbge.Value = cidadeModel.cIbge;
                cboidUf.SelectedValue = cidadeModel.idUF;
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }

        }
    }
}