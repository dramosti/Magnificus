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
using HLP.Services.Interfaces.Entries.Fiscal;
using HLP.Models.Entries.Fiscal;
using HLP.Comum.Messages;
using HLP.Comum.UI.Exception;

using System.Threading;
using HLP.Comum.Infrastructure.Static;

namespace HLP.UI.Entries.Fiscal
{
    public partial class FormClassificacaoFiscal : FormPadraoCadastro
    {
        [Inject]
        public IClassificacao_fiscalService classificacaoService { get; set; }

        Classificacao_fiscalModel classificacao_fiscalModel = new Classificacao_fiscalModel();

        public FormClassificacaoFiscal()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
        }

        private void FormClassificacaoFiscal_Load(object sender, EventArgs e)
        {
            InicializaFormPadrao("vwClassificacaoFiscal");
        }



        public override void Novo()
        {
            base.Novo();
            cboAtivo.SelectedIndex = 1;
            classificacao_fiscalModel = new Classificacao_fiscalModel();
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
                classificacaoService.Save(classificacao_fiscalModel);

                txtCodigo.Text = classificacao_fiscalModel.idClassificacaoFiscal.ToString();

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
                        classificacao_fiscalModel = classificacaoService.GetClassificacao(Convert.ToInt32(txtCodigo.Text));
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
                    classificacao_fiscalModel = classificacaoService.GetClassificacao((int)iRetPesquisa);
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
                    classificacao_fiscalModel = classificacaoService.GetClassificacao((int)iRetPesquisa);
                    if (classificacao_fiscalModel != null)
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
                    classificacao_fiscalModel = classificacaoService.GetClassificacao((int)iRetPesquisa);
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
                int i = classificacaoService.Copy(Convert.ToInt32(txtCodigo.Text));
                classificacao_fiscalModel = classificacaoService.GetClassificacao(i);
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
                    classificacaoService.Delete((int)lParaExcluir[i]);
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
            classificacaoService.Delete(Convert.ToInt32(txtCodigo.Text));
            base.Excluir();
            if (iRetPesquisa != null)
            {
                base.MoveProximoItem();
                classificacao_fiscalModel = classificacaoService.GetClassificacao((int)iRetPesquisa);
                PopulaForm();
            }
        }




        private void PopulaForm()
        {
            try
            {
                base.CarregaPropriedades(classificacao_fiscalModel, true);
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
                base.CarregaClasse(classificacao_fiscalModel);
                classificacao_fiscalModel.idEmpresa = CompanyData.idEmpresa;
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }
    }
}
