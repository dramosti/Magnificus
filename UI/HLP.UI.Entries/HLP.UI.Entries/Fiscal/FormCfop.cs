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
using HLP.Comum.Services.Interface;
using HLP.Dependencies;
using HLP.Comum.Components;
using HLP.Models.Entries.Fiscal;
using HLP.Services.Interfaces.Entries.Fiscal;
using HLP.Comum.Messages;
using HLP.Comum.Models;
using HLP.Comum.UI.Exception;
using System.Threading;

namespace HLP.UI.Entries.Fiscal
{
    public partial class FormCfop : FormPadraoCadastro
    {
        [Inject]
        public ICfopService cfopService { get; set; }

        CfopModel cfopModel = new CfopModel();

        public FormCfop()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
        }

        private void FormCfop_Load(object sender, EventArgs e)
        {
            InicializaFormPadrao("vwCfop");
        }



        public override void Novo()
        {
            base.Novo();
            cfopModel = new CfopModel();

            nudcCodCfop.Text = "";
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
                cfopService.Save(cfopModel);

                txtCodigo.Text = cfopModel.idCfop.ToString();

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
                        cfopModel = cfopService.GetCfop(Convert.ToInt32(txtCodigo.Text));
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
                    cfopModel = cfopService.GetCfop((int)iRetPesquisa);
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
                    cfopModel = cfopService.GetCfop((int)iRetPesquisa);
                    if (cfopModel != null)
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
                    cfopModel = cfopService.GetCfop((int)iRetPesquisa);
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
                int i = cfopService.Copy(Convert.ToInt32(txtCodigo.Text));
                cfopModel = cfopService.GetCfop(i);
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
                    cfopService.Delete((int)lParaExcluir[i]);
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
            cfopService.Delete(Convert.ToInt32(txtCodigo.Text));
            base.Excluir();
            if (iRetPesquisa != null)
            {
                base.MoveProximoItem();
                cfopModel = cfopService.GetCfop((int)iRetPesquisa);
                PopulaForm();
            }
        }



        private void PopulaTabela()
        {
            try
            {
                cfopModel.xCfop = txtxCfop.Text;
                cfopModel.xCfopResumida = txtxCfopResumida.Text;
                cfopModel.cCfop = Convert.ToInt32(nudcCodCfop.Value);

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
                txtCodigo.Text = cfopModel.idCfop.ToString();
                txtxCfop.Text = cfopModel.xCfop;
                txtxCfopResumida.Text = cfopModel.xCfopResumida;
                nudcCodCfop.Value = cfopModel.cCfop;
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }

        }
    }
}
