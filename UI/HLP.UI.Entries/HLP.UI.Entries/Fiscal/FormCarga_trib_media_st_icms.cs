using HLP.Comum.Messages;
using HLP.Comum.UI;
using HLP.Comum.UI.Exception;
using HLP.Dependencies;
using HLP.Models.Entries.Fiscal;
using HLP.Services.Interfaces.Entries.Fiscal;
using Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HLP.UI.Entries.Fiscal
{
    public partial class FormCarga_trib_media_st_icms : FormPadraoCadastro
    {
        [Inject]
        public ICarga_trib_media_st_icmsService carga_trib_mediaService { get; set; }

        Carga_trib_media_st_icmsModel carga_tribModel = new Carga_trib_media_st_icmsModel();
        Action VerifBw = null;
        Thread t1 = null;

        public FormCarga_trib_media_st_icms()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
        }

        private void FormCarga_trib_media_st_icms_Load(object sender, EventArgs e)
        {
            InicializaFormPadrao("vwCarga_trib_media_st_icms");
        }

        public override void Novo()
        {
            base.Novo();
            carga_tribModel = new Carga_trib_media_st_icmsModel();
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
                carga_trib_mediaService.Save(carga_tribModel);
                txtCodigo.Text = carga_tribModel.idCargaTribMediaStIcms.ToString();
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
                        carga_tribModel = carga_trib_mediaService.GetCarga_trib_media_st_icms(Convert.ToInt32(txtCodigo.Text));
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
                    carga_tribModel = carga_trib_mediaService.GetCarga_trib_media_st_icms((int)iRetPesquisa);
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
                    carga_tribModel = carga_trib_mediaService.GetCarga_trib_media_st_icms((int)iRetPesquisa);
                    if (carga_tribModel != null)
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
                    carga_tribModel = carga_trib_mediaService.GetCarga_trib_media_st_icms((int)iRetPesquisa);
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
                int i = carga_trib_mediaService.Copy(Convert.ToInt32(txtCodigo.Text));
                carga_tribModel = carga_trib_mediaService.GetCarga_trib_media_st_icms(i);
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
                    carga_trib_mediaService.Delete((int)lParaExcluir[i]);
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
            carga_trib_mediaService.Delete(Convert.ToInt32(txtCodigo.Text));
            base.Excluir();
            if (iRetPesquisa != null)
            {
                base.MoveProximoItem();
                carga_tribModel = carga_trib_mediaService.GetCarga_trib_media_st_icms((int)iRetPesquisa);
                PopulaForm();
            }
        }



        private void PopulaTabela()
        {
            try
            {
                base.CarregaClasse(carga_tribModel);
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
                base.CarregaPropriedades(carga_tribModel, true);
                base.CarregaForm();
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }

        }
    }
}
