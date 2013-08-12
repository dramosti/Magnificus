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
using HLP.Services.Interfaces.Entries.Financeiro;
using HLP.Dependencies;
using HLP.Models.Entries.Financeiro;
using HLP.Comum.Messages;
using HLP.Comum.UI.Exception;
using System.Threading;
using HLP.Comum.Services.Interface;

namespace HLP.UI.Entries.Financeiro
{
    public partial class FormDesconto : FormPadraoCadastro
    {
        [Inject]
        public IDescontos_AvistaService descontoService { get; set; }

        [Inject]
        public IPesquisaPadraoService pesquisaPadraoService { get; set; }

        Descontos_AvistaModel decontoModel = new Descontos_AvistaModel();


        public FormDesconto()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
        }

        private void FormDesconto_Load(object sender, EventArgs e)
        {
            InicializaFormPadrao("vwDescontosAvista");
        }


        public override void Novo()
        {
            base.Novo();
            decontoModel = new Descontos_AvistaModel();
            cbostLiquidoAtual.SelectedIndex = 0;
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
            descontoService.Delete(Convert.ToInt32(txtCodigo.Text));
            base.Excluir();
            if (iRetPesquisa != null)
            {
                base.MoveProximoItem();
                decontoModel = descontoService.GetDesconto((int)iRetPesquisa);
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
                    descontoService.Delete((int)lParaExcluir[i]);
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
                if (nudpDesconto.Value < 0 || nudpDesconto.Value > 100)
                {
                    nudpDesconto.errorProvider1.SetError(nudpDesconto, "Valor de desconto deve estar entre 0 e 100");
                }
                else
                {
                    objValidaCampos.Validar();
                    PopulaTabela();

                    descontoService.Save(decontoModel);

                    txtCodigo.Text = decontoModel.idDescontosAvista.ToString();
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
                        decontoModel = descontoService.GetDesconto(Convert.ToInt32(txtCodigo.Text));
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
                    decontoModel = descontoService.GetDesconto((int)iRetPesquisa);
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
                    decontoModel = descontoService.GetDesconto((int)iRetPesquisa);
                    if (decontoModel != null)
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
                    decontoModel = descontoService.GetDesconto((int)iRetPesquisa);
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
                int i = descontoService.Copy(Convert.ToInt32(txtCodigo.Text));
                decontoModel = descontoService.GetDesconto(i);
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
                base.CarregaClasse(decontoModel);
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
                base.CarregaPropriedades(decontoModel, true);
                base.CarregaForm();

            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }

        }
    }
}
