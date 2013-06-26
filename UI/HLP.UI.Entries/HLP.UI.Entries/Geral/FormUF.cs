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
using HLP.Dependencies;
using HLP.Models.Entries.Gerais;
using HLP.Comum.Messages;
using HLP.Comum.UI.Exception;
using ComponentFactory.Krypton.Toolkit;
using System.Threading;

namespace HLP.UI.Entries.Geral
{
    public partial class FormUF : FormPadraoCadastro
    {
        [Inject]
        public IUFService ufService { get; set; }

        [Inject]
        public IRegiaoService regiaoService { get; set; }

        UFModel ufModel = new UFModel();
        bool bNovo;
        string xSiglaUf;

        public FormUF()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
        }

        private void FormUF_Load(object sender, EventArgs e)
        {
            InicializaFormPadrao("vwUF");
        }

        public override void Novo()
        {
            base.Novo();
            ufModel = new UFModel();
            bNovo = true;
        }
        public override void Atualizar()
        {
            base.Atualizar();
            bNovo = false;
            xSiglaUf = txtxSiglaUf.Text;
        }
        public override void Salvar()
        {
            try
            {
                objValidaCampos.Validar();
                bool Existe = ufService.IsNew(txtxSiglaUf.Text);

                if (bNovo && Existe)
                {
                    KryptonMessageBox.Show(null, "Sigla já Cadastrada", Mensagens.MSG_Alerta, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (!bNovo && (xSiglaUf != txtxSiglaUf.Text) && Existe)
                    {
                        KryptonMessageBox.Show(null, "Sigla já Cadastrada", Mensagens.MSG_Alerta, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        PopulaTabela();
                        ufService.Save(ufModel);

                        txtCodigo.Text = ufModel.idUF.ToString();

                        base.Salvar();
                    }
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
                        ufModel = ufService.GetUF(Convert.ToInt32(txtCodigo.Text));
                        PopulaForm();
                        HabilitaBotoes(1);
                    }
                    base.Cancelar();
                    bNovo = false;
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
                    ufModel = ufService.GetUF((int)iRetPesquisa);
                    PopulaForm();
                    bNovo = false;
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
                    ufModel = ufService.GetUF((int)iRetPesquisa);
                    if (ufModel != null)
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
                    ufModel = ufService.GetUF((int)iRetPesquisa);
                    PopulaForm();
                    bNovo = false;
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
                int i = ufService.Copy(Convert.ToInt32(txtCodigo.Text));
                ufModel = ufService.GetUF(i);
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
                    ufService.Delete((int)lParaExcluir[i]);
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
            ufService.Delete(Convert.ToInt32(txtCodigo.Text));
            base.Excluir();
            if (iRetPesquisa != null)
            {
                base.MoveProximoItem();
                ufModel = ufService.GetUF((int)iRetPesquisa);
                PopulaForm();
                bNovo = false;
            }
        }




        private void PopulaTabela()
        {
            try
            {
                ufModel.xSiglaUf = txtxSiglaUf.Text;
                ufModel.xUf = txtxUf.Text;
                ufModel.cIbgeUf = nudcIbgeUf.ValueInt;
                ufModel.idRegiao = hlP_PesquisaRegiao.Value;

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
                txtCodigo.Text = ufModel.idUF.ToString();
                txtxSiglaUf.Text = ufModel.xSiglaUf;
                txtxUf.Text = ufModel.xUf;
                nudcIbgeUf.ValueInt = ufModel.cIbgeUf;
                hlP_PesquisaRegiao.Value = ufModel.idRegiao;
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }

        }
    }
}
