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
using HLP.Dependencies;
using HLP.Services.Interfaces.Entries.Gerais;
using HLP.Models.Entries.Gerais;
using HLP.Comum.Messages;
using HLP.Comum.UI.Exception;
using ComponentFactory.Krypton.Toolkit;
using System.Threading;

namespace HLP.UI.Entries.Geral
{
    public partial class FormUnidadeMedida : FormPadraoCadastro
    {
        [Inject]
        public IUnidade_medidaService unidadeService { get; set; }

        Unidade_medidaModel unidadeModel = new Unidade_medidaModel();

        public FormUnidadeMedida()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
        }

        private void FormUnidadeMedida_Load(object sender, EventArgs e)
        {
            InicializaFormPadrao("vwUnidadeMedida");
        }


        public override void Novo()
        {
            base.Novo();
            unidadeModel = new Unidade_medidaModel();
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
                unidadeService.Save(unidadeModel);

                txtCodigo.Text = unidadeModel.idUnidadeMedida.ToString();

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
                        unidadeModel = unidadeService.GetUnidade(Convert.ToInt32(txtCodigo.Text));
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
                    unidadeModel = unidadeService.GetUnidade((int)iRetPesquisa);
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
                    unidadeModel = unidadeService.GetUnidade((int)iRetPesquisa);
                    if (unidadeModel != null)
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
                    unidadeModel = unidadeService.GetUnidade((int)iRetPesquisa);
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
                int i = unidadeService.Copy(Convert.ToInt32(txtCodigo.Text));
                unidadeModel = unidadeService.GetUnidade(i);
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
                    unidadeService.Delete((int)lParaExcluir[i]);
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
            unidadeService.Delete(Convert.ToInt32(txtCodigo.Text));
            base.Excluir();
            if (iRetPesquisa != null)
            {
                base.MoveProximoItem();
                unidadeModel = unidadeService.GetUnidade((int)iRetPesquisa);
                PopulaForm();
            }
        }



        private void PopulaTabela()
        {
            try
            {
                unidadeModel.xSiglaPadrao = txtxSiglaPadrao.Text;
                unidadeModel.xUnidadeMedida = txtxUnidadeMedida.Text;
                unidadeModel.nCasasDecimais = nudnCasasDecimais.ValueInt;
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
                txtCodigo.Text = unidadeModel.idUnidadeMedida.ToString();
                txtxSiglaPadrao.Text = unidadeModel.xSiglaPadrao;
                txtxUnidadeMedida.Text = unidadeModel.xUnidadeMedida;
                nudnCasasDecimais.ValueInt = unidadeModel.nCasasDecimais;
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }

        }
    }
}
