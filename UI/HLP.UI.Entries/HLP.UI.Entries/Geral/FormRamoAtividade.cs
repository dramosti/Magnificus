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
using HLP.Dependencies;
using HLP.Comum.Messages;
using HLP.Comum.UI.Exception;
using System.Threading;

namespace HLP.UI.Entries.Geral
{
    public partial class FormRamoAtividade : FormPadraoCadastro
    {
        [Inject]
        public IRamo_atividadeService ramoService { get; set; }

        Ramo_atividadeModel ramo_atividadeModel = new Ramo_atividadeModel();

        public FormRamoAtividade()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
        }

        private void FormRamoAtividade_Load(object sender, EventArgs e)
        {
            InicializaFormPadrao("vwRamoAtividade");
        }



        public override void Novo()
        {
            base.Novo();
            ramo_atividadeModel = new Ramo_atividadeModel();
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
                ramoService.Save(ramo_atividadeModel);

                txtCodigo.Text = ramo_atividadeModel.idRamoAtividade.ToString();

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
                        ramo_atividadeModel = ramoService.GetRamo(Convert.ToInt32(txtCodigo.Text));
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
                    ramo_atividadeModel = ramoService.GetRamo((int)iRetPesquisa);
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
                    ramo_atividadeModel = ramoService.GetRamo((int)iRetPesquisa);
                    if (ramo_atividadeModel != null)
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
                    ramo_atividadeModel = ramoService.GetRamo((int)iRetPesquisa);
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
                int i = ramoService.Copy(Convert.ToInt32(txtCodigo.Text));
                ramo_atividadeModel = ramoService.GetRamo(i);
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
                    ramoService.Delete((int)lParaExcluir[i]);
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
            ramoService.Delete(Convert.ToInt32(txtCodigo.Text));
            base.Excluir();
            if (iRetPesquisa != null)
            {
                base.MoveProximoItem();
                ramo_atividadeModel = ramoService.GetRamo((int)iRetPesquisa);
                PopulaForm();
            }
        }


        private void PopulaTabela()
        {
            try
            {
                ramo_atividadeModel.xRamo = nudxRamo.Value.ToString();
                ramo_atividadeModel.xDescricao = txtxDescricao.Text;
                ramo_atividadeModel.xCnae = txtxCnae.Text;
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
                txtCodigo.Text = ramo_atividadeModel.idRamoAtividade.ToString();
                nudxRamo.Value = Convert.ToInt32(ramo_atividadeModel.xRamo);
                txtxDescricao.Text = ramo_atividadeModel.xDescricao;
                txtxCnae.Text = ramo_atividadeModel.xCnae;

            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }

        }

        private void nudxRamo_Validating(object sender, CancelEventArgs e)
        {
            //int max = Convert.ToInt32(nudxRamo.Maximum);
        }
    }
}
