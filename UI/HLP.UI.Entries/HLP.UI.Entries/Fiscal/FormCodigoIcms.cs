using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HLP.Comum.UI;
using HLP.Dependencies;
using Ninject;
using HLP.Services.Interfaces.Entries.Gerais;
using HLP.Comum.Services.Interface;
using HLP.Services.Interfaces.Entries.Fiscal;
using HLP.Models.Entries.Fiscal;
using HLP.Comum.Messages;
using HLP.Comum.UI.Exception;

using System.Threading;
using HLP.Comum.Infrastructure.Static;

namespace HLP.UI.Entries.Fiscal
{
    public partial class FormCodigoIcms : FormPadraoCadastro
    {
        [Inject]
        public ICodigo_Icms_paiService codigoTributarioPaiService { get; set; }

        [Inject]
        public IUFService ufService { get; set; }

        [Inject]
        public IPesquisaPadraoService pesquisaPadraoService { get; set; }

        Codigo_Icms_paiModel objCodigoTribPaiModel = new Codigo_Icms_paiModel();
        Action verifBw = null;

        public FormCodigoIcms()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
        }

        private void FormCodigoTributario_Load(object sender, EventArgs e)
        {
            idUf.Tag = "FormUF-vwUF-xSiglaUf";
            InicializaFormPadrao("vwCodigoIcmsPai");
            string teste = nudcIcms.Maximum.ToString();

            verifBw += (() =>
                {
                    CarregaComboBox();
                });

            Thread t1 = new Thread(new ThreadStart(verifBw));
            t1.Start();
        }

        private void CarregaComboBox()
        {
            if (objMetodosForm != null)
            {
                idUf.DataSource = pesquisaPadraoService.GetData(objMetodosForm.GetDisplayMember(idUf), true);
                Thread.CurrentThread.Abort();
            }
            else
            {
                Thread.Sleep(500);
                CarregaComboBox();
            }
        }

        public override void Novo()
        {
            base.Novo();
            objCodigoTribPaiModel = new Codigo_Icms_paiModel();
            bsCodigotributario.DataSource = objCodigoTribPaiModel.lCodigo_Icms;
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

                codigoTributarioPaiService.Save(objCodigoTribPaiModel);

                txtCodigo.Text = objCodigoTribPaiModel.idCodigoIcmsPai.ToString();
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
                        objCodigoTribPaiModel = codigoTributarioPaiService.GetCodigo_Icms_pai(Convert.ToInt32(txtCodigo.Text), true);
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
                    objCodigoTribPaiModel = codigoTributarioPaiService.GetCodigo_Icms_pai((int)iRetPesquisa, true);
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
                    objCodigoTribPaiModel = codigoTributarioPaiService.GetCodigo_Icms_pai((int)iRetPesquisa, true);
                    if (objCodigoTribPaiModel != null)
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
                    objCodigoTribPaiModel = codigoTributarioPaiService.GetCodigo_Icms_pai((int)iRetPesquisa, true);
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
                codigoTributarioPaiService.Copy(objCodigoTribPaiModel);
                PopulaForm();
                base.RegistroDuplicado(idOrigem, (int)objCodigoTribPaiModel.idCodigoIcmsPai);
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
                    objCodigoTribPaiModel = codigoTributarioPaiService.GetCodigo_Icms_pai((int)lParaExcluir[i], true);
                    codigoTributarioPaiService.Delete(objCodigoTribPaiModel);
                    lExcluido.Add(lParaExcluir[i]);
                }
                catch (Exception ex)
                {
                    new HLPexception(ex);
                }
            }
            base.FinalizaExcluirTodos();
        }

        private void ExcluirRegistro()
        {
            codigoTributarioPaiService.Delete(objCodigoTribPaiModel);
            base.Excluir();
            bsCodigotributario.DataSource = new List<Codigo_IcmsModel>();

            if (iRetPesquisa != null)
            {
                base.MoveProximoItem();
                objCodigoTribPaiModel = codigoTributarioPaiService.GetCodigo_Icms_pai((int)iRetPesquisa, true);
                PopulaForm();
            }
        }


        private void PopulaTabela()
        {
            try
            {
                base.CarregaClasse(objCodigoTribPaiModel);
                objCodigoTribPaiModel.idEmpresa = CompanyData.idEmpresa;
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
                base.CarregaPropriedades(objCodigoTribPaiModel, true);
                base.CarregaForm();
                bsCodigotributario.DataSource = objCodigoTribPaiModel.lCodigo_Icms;
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }

        }
    }
}
