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
using System.Threading;

namespace HLP.UI.Entries.Geral
{
    public partial class FormFabricante : FormPadraoCadastro
    {
        [Inject]
        public IFabricanteService fabricanteService { get; set; }

        FabricanteModel fabricanteModel = new FabricanteModel();


        public FormFabricante()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
        }

        private void FormFabricante_Load(object sender, EventArgs e)
        {
            InicializaFormPadrao("vwFabricante");
        }

        public override void Novo()
        {
            base.Novo();
            fabricanteModel = new FabricanteModel();
        }

        public override void Salvar()
        {
            try
            {
                objValidaCampos.Validar();
                PopulaTabela();
                fabricanteService.Save(fabricanteModel);

                txtCodigo.Text = fabricanteModel.idFabricante.ToString();

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
                        fabricanteModel = fabricanteService.GetFabricante(Convert.ToInt32(txtCodigo.Text));
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
                    fabricanteModel = fabricanteService.GetFabricante((int)iRetPesquisa);
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
                    fabricanteModel = fabricanteService.GetFabricante((int)iRetPesquisa);
                    if (fabricanteModel != null)
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
                    fabricanteModel = fabricanteService.GetFabricante((int)iRetPesquisa);
                    PopulaForm();
                }
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }
        public override void Duplicar()
        {
            try
            {
                int idOrigem = Convert.ToInt32(txtCodigo.Text);
                int i = fabricanteService.Copy(Convert.ToInt32(txtCodigo.Text));
                fabricanteModel = fabricanteService.GetFabricante(i);
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
                    fabricanteService.Delete((int)lParaExcluir[i]);
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
            fabricanteService.Delete(Convert.ToInt32(txtCodigo.Text));
            base.Excluir();
            if (iRetPesquisa != null)
            {
                base.MoveProximoItem();
                fabricanteModel = fabricanteService.GetFabricante((int)iRetPesquisa);
                PopulaForm();
            }
        }

        private void PopulaTabela()
        {
            try
            {
                base.CarregaClasse(fabricanteModel);
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
                base.CarregaPropriedades(fabricanteModel, true);
                base.CarregaForm();
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }

        }

        private void txtxxRazao__Leave(object sender, EventArgs e)
        {
            if (txtxFantasia.Text == String.Empty)
            {
                txtxFantasia.Text = txtxxRazao.Text;
            }
        }
    }
}
