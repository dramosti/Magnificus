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
using HLP.Models.Entries.Gerais;
using HLP.Comum.Messages;
using HLP.Comum.UI.Exception;
using HLP.Dependencies;
using ComponentFactory.Krypton.Toolkit;
using System.Threading;

namespace HLP.UI.Entries.Geral.Transportes
{
    public partial class FormModoEntrega : FormPadraoCadastro
    {
        [Inject]
        public IModos_entregaService modoService { get; set; }

        Modos_entregaModel modos_entregaModel = new Modos_entregaModel();


        public FormModoEntrega()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
        }

        private void FormModoEntrega_Load(object sender, EventArgs e)
        {
            InicializaFormPadrao("vwModoEntrega");
        }




        public override void Novo()
        {
            base.Novo();
            cbostServico.SelectedIndex = 2;
            modos_entregaModel = new Modos_entregaModel();
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
            modoService.Delete(Convert.ToInt32(txtCodigo.Text));
            base.Excluir();
            if (iRetPesquisa != null)
            {
                base.MoveProximoItem();
                modos_entregaModel = modoService.GetModo((int)iRetPesquisa);
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
                    modoService.Delete((int)lParaExcluir[i]);
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
            cbostServico__SelectedIndexChanged(null, null);
        }
        public override void Salvar()
        {
            try
            {
                objValidaCampos.Validar();
                if (cbostServico.SelectedIndex != 1 && hlP_PesquisaidTransportador.Value == 0)
                {
                    KryptonMessageBox.Show("É necessário selecionar um Transportador quando  o Tipo de serviço não for igual à '1 - RETIRADA'", Mensagens.MSG_Aviso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    PopulaTabela();
                    modoService.Save(modos_entregaModel);

                    txtCodigo.Text = modos_entregaModel.idModosEntrega.ToString();
                    base.Salvar();
                }

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
                        modos_entregaModel = modoService.GetModo(Convert.ToInt32(txtCodigo.Text));
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
                    modos_entregaModel = modoService.GetModo((int)iRetPesquisa);
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
                    modos_entregaModel = modoService.GetModo((int)iRetPesquisa);
                    if (modos_entregaModel != null)
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
                    modos_entregaModel = modoService.GetModo((int)iRetPesquisa);
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
                int i = modoService.Copy(Convert.ToInt32(txtCodigo.Text));
                modos_entregaModel = modoService.GetModo(i);
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
                base.CarregaClasse(modos_entregaModel);
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
                base.CarregaPropriedades(modos_entregaModel, true);
                base.CarregaForm();
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }

        }

        private void cbostServico__SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnSalvar.Enabled)
            {
                if (cbostServico.SelectedIndex == 1)
                {
                    hlP_PesquisaidTransportador.Enabled = false;
                    hlP_PesquisaidTransportador.Value = 0;
                    hlP_PesquisaidTransportador.txtPesquisa.Text = "";
                    hlP_PesquisaidTransportador.txtDisplay.Text = "";
                }
                else
                {
                    hlP_PesquisaidTransportador.Enabled = true;
                }
            }
        }
    }
}
