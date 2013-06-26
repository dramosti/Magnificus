using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HLP.Comum.UI;
using HLP.Services.Interfaces.Entries.Fiscal;
using Ninject;
using HLP.Models.Entries.Fiscal;
using HLP.Comum.Messages;
using HLP.Comum.UI.Exception;
using HLP.Dependencies;
using System.Threading;

namespace HLP.UI.Entries.Fiscal
{
    public partial class FormStCOFINS : FormPadraoCadastro
    {
        [Inject]
        public ISituacao_tributaria_cofinsService cofinsService { get; set; }

        Situacao_tributaria_cofinsModel cofinsModel = new Situacao_tributaria_cofinsModel();

        public FormStCOFINS()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
        }

        private void FormStCOFINS_Load(object sender, EventArgs e)
        {
            InicializaFormPadrao("vwStCOFINS");
        }



        public override void Novo()
        {
            base.Novo();
            cofinsModel = new Situacao_tributaria_cofinsModel();
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
                cofinsService.Save(cofinsModel);

                txtCodigo.Text = cofinsModel.idCSTCofins.ToString();

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
                        cofinsModel = cofinsService.GetStCofins(Convert.ToInt32(txtCodigo.Text));
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
                    cofinsModel = cofinsService.GetStCofins((int)iRetPesquisa);
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
                    cofinsModel = cofinsService.GetStCofins((int)iRetPesquisa);
                    if (cofinsModel != null)
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
                    cofinsModel = cofinsService.GetStCofins((int)iRetPesquisa);
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
                int i = cofinsService.Copy(Convert.ToInt32(txtCodigo.Text));
                cofinsModel = cofinsService.GetStCofins(i);
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
            base.FinalizaExcluirTodos();
            for (int i = 0; i < lParaExcluir.Count; i++)
            {
                try
                {
                    Invoke(new MethodInvoker(delegate
                    {
                        pbProgresso.PerformStep();
                        lblProgresso.Text = (i + 1) + " de " + bsRetPesquisa.List.Count;
                    }));
                    cofinsService.Delete((int)lParaExcluir[i]);
                    lExcluido.Add(lParaExcluir[i]);
                }
                catch (Exception)
                {
                }
            }
        }
        private void ExcluirRegistro()
        {
            cofinsService.Delete(Convert.ToInt32(txtCodigo.Text));
            base.Excluir();
            if (iRetPesquisa != null)
            {
                base.MoveProximoItem();
                cofinsModel = cofinsService.GetStCofins((int)iRetPesquisa);
                PopulaForm();
            }
        }

        private void PopulaTabela()
        {
            try
            {
                cofinsModel.cCSTCofins = txtcCSTCofins.Text;
                cofinsModel.xCSTCofins = txtxCSTCofins.Text;
                cofinsModel.stSimplesNacional = cbostSimplesNacional.SelectedIndexByte;
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
                txtCodigo.Text = cofinsModel.idCSTCofins.ToString();
                txtcCSTCofins.Text = cofinsModel.cCSTCofins;
                txtxCSTCofins.Text = cofinsModel.xCSTCofins;
                cbostSimplesNacional.SelectedIndex = cofinsModel.stSimplesNacional;
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }

        }
    }
}
