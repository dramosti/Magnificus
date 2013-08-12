using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using HLP.Comum.UI;
using HLP.Dependencies;
using Ninject;
using HLP.Services.Interfaces.Entries.Gerais;
using HLP.Comum.Services.Interface;
using HLP.Services.Interfaces.Entries.Fiscal;
using HLP.Models.Entries.Fiscal;
using HLP.Comum.Messages;
using HLP.Comum.UI.Exception;
using System.Linq;

using HLP.Comum.Models;
using System.Threading;
using HLP.Comum.Infrastructure.Static;

namespace HLP.UI.Entries.Fiscal
{
    public partial class FormTipoOperacao : FormPadraoCadastro
    {
        [Inject]
        public IEmpresaService empresaService { get; set; }

        [Inject]
        public ITipo_operacaoService operacaoService { get; set; }

        [Inject]
        public IOperacao_reducao_baseService operacaoReducaoService { get; set; }

        [Inject]
        public IOperacao_importacaoService operacaoImportacaoService { get; set; }

        [Inject]
        public IUFService ufService { get; set; }

        [Inject]
        public IPesquisaPadraoService pesquisaPadraoService { get; set; }

        Tipo_operacaoModel operacaoModel = new Tipo_operacaoModel();
        Operacao_importacaoModel operacaoImportacaoModel = new Operacao_importacaoModel();
        List<Operacao_reducao_baseModel> lOperacao_reducao_baseModel = new List<Operacao_reducao_baseModel>();
        Action verifBw = null;
        int iCodClassificacaoFiscal = 0;


        public FormTipoOperacao()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
        }

        private void FormTipoOperacao_Load(object sender, EventArgs e)
        {
            hlP_PesquisaidClassificacaoFiscal.txtPesquisa.Enter += new EventHandler(campoPesquisaClassificacaoFiscal_Enter);
            hlP_PesquisaidClassificacaoFiscal.txtPesquisa.Leave += new EventHandler(campoPesquisaClassificacaoFiscal_Leave);


            InicializaFormPadrao("vwTipoOperacao");
            idUf.Tag = "FormUF-vwUF-xSiglaUf";

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
            cboAtivo.SelectedIndex = 1;
            operacaoModel = new Tipo_operacaoModel();
            operacaoImportacaoModel = new Operacao_importacaoModel();
            bsOperacaoreducaobase.DataSource = new List<Operacao_reducao_baseModel>();
            iCodClassificacaoFiscal = 0;
            VerificaSuperSimples();
        }

        public override void Atualizar()
        {
            base.Atualizar();
            VerificaSuperSimples();
        }
        public override void Salvar()
        {
            try
            {
                objValidaCampos.Validar();
                PopulaTabela();

                operacaoService.Begin();
                operacaoService.Save(operacaoModel);
                operacaoImportacaoModel.idTipoOperacao = (int)operacaoModel.idTipoOperacao;
                operacaoImportacaoService.Save(operacaoImportacaoModel);
                foreach (Operacao_reducao_baseModel operacaoReducao in bsOperacaoreducaobase.List)
                {
                    operacaoReducao.idTipoOperacao = (int)operacaoModel.idTipoOperacao;
                    operacaoReducaoService.Save(operacaoReducao);
                }

                List<int?> lNotInn = ((List<Operacao_reducao_baseModel>)bsOperacaoreducaobase.DataSource).Where(C => C.idOperacaoReducaoBase != null).Select(C => C.idOperacaoReducaoBase).ToList();
                operacaoReducaoService.Delete((int)operacaoModel.idTipoOperacao, lNotInn);

                operacaoService.Commit();
                txtCodigo.Text = operacaoModel.idTipoOperacao.ToString();
                base.Salvar();

            }
            catch (Exception ex)
            {
                operacaoService.RollBack();
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
                        operacaoModel = operacaoService.GetOperacao(Convert.ToInt32(txtCodigo.Text));
                        operacaoImportacaoModel = operacaoImportacaoService.GetAll(Convert.ToInt32(txtCodigo.Text)).FirstOrDefault();
                        lOperacao_reducao_baseModel = operacaoReducaoService.GetAll(Convert.ToInt32(txtCodigo.Text));
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
                    operacaoModel = operacaoService.GetOperacao((int)iRetPesquisa);
                    operacaoImportacaoModel = operacaoImportacaoService.GetAll((int)iRetPesquisa).FirstOrDefault();
                    lOperacao_reducao_baseModel = operacaoReducaoService.GetAll((int)iRetPesquisa);
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
                    operacaoModel = operacaoService.GetOperacao((int)iRetPesquisa);
                    if (operacaoModel != null)
                    {
                        operacaoImportacaoModel = operacaoImportacaoService.GetAll((int)iRetPesquisa).FirstOrDefault();
                        lOperacao_reducao_baseModel = operacaoReducaoService.GetAll((int)iRetPesquisa);
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
                    operacaoModel = operacaoService.GetOperacao((int)iRetPesquisa);
                    operacaoImportacaoModel = operacaoImportacaoService.GetAll((int)iRetPesquisa).FirstOrDefault();
                    lOperacao_reducao_baseModel = operacaoReducaoService.GetAll((int)iRetPesquisa);
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
                int i = operacaoService.Copy(Convert.ToInt32(txtCodigo.Text));
                operacaoModel = operacaoService.GetOperacao(i);

                operacaoService.Begin();

                operacaoImportacaoModel.idTipoOperacao = (int)operacaoModel.idTipoOperacao;
                operacaoImportacaoModel.idOperacaoImportacao = null;
                operacaoImportacaoService.Save(operacaoImportacaoModel);

                foreach (Operacao_reducao_baseModel operacaoReducao in bsOperacaoreducaobase.List)
                {
                    operacaoReducao.idTipoOperacao = (int)operacaoModel.idTipoOperacao;
                    operacaoReducao.idOperacaoReducaoBase = null;
                    operacaoReducaoService.Save(operacaoReducao);
                }
                operacaoService.Commit();
                operacaoImportacaoModel = operacaoImportacaoService.GetAll((int)operacaoModel.idTipoOperacao).FirstOrDefault();
                lOperacao_reducao_baseModel = operacaoReducaoService.GetAll((int)operacaoModel.idTipoOperacao);
                PopulaForm();

                base.RegistroDuplicado(idOrigem, i);
            }
            catch (Exception ex)
            {
                operacaoService.RollBack();
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
                operacaoService.RollBack();
                new HLPexception(ex);
            }
        }
        private void ExcluirRegistro()
        {
            operacaoService.Begin();

            foreach (Operacao_reducao_baseModel operacaoReducao in bsOperacaoreducaobase.List)
            {
                operacaoReducaoService.Delete((int)operacaoReducao.idOperacaoReducaoBase);
            }
            if (operacaoImportacaoModel != null)
            {
                operacaoImportacaoService.Delete((int)operacaoImportacaoModel.idOperacaoImportacao);
            }
            operacaoService.Delete(Convert.ToInt32(txtCodigo.Text));

            operacaoService.Commit();

            base.Excluir();
            bsOperacaoreducaobase.DataSource = new List<Operacao_reducao_baseModel>();
            if (iRetPesquisa != null)
            {
                base.MoveProximoItem();
                operacaoModel = operacaoService.GetOperacao((int)iRetPesquisa);
                operacaoImportacaoModel = operacaoImportacaoService.GetAll((int)iRetPesquisa).FirstOrDefault();
                lOperacao_reducao_baseModel = operacaoReducaoService.GetAll((int)iRetPesquisa);
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
                    operacaoService.Begin();
                    Invoke(new MethodInvoker(delegate
                    {
                        pbProgresso.PerformStep();
                        lblProgresso.Text = (i + 1) + " de " + bsRetPesquisa.List.Count;
                    }));

                    lOperacao_reducao_baseModel = operacaoReducaoService.GetAll((int)lParaExcluir[i]);
                    foreach (Operacao_reducao_baseModel operacaoReducao in bsOperacaoreducaobase.List)
                    {
                        operacaoReducaoService.Delete((int)operacaoReducao.idOperacaoReducaoBase);
                    }
                    int idOperacaoImportacao = operacaoImportacaoService.GetAll((int)lParaExcluir[i]).FirstOrDefault().idTipoOperacao;
                    if (operacaoImportacaoModel != null)
                    {
                        operacaoImportacaoService.Delete(idOperacaoImportacao);
                    }
                    operacaoService.Delete((int)lParaExcluir[i]);
                    operacaoService.Commit();
                    lExcluido.Add(lParaExcluir[i]);
                }
                catch (Exception)
                {
                    operacaoService.RollBack();
                }
            }
            base.FinalizaExcluirTodos();
        }


        private void PopulaForm()
        {
            try
            {

                base.CarregaPropriedades(operacaoModel, true);
                base.CarregaPropriedades(operacaoImportacaoModel);
                base.CarregaForm();

                bsOperacaoreducaobase.DataSource = lOperacao_reducao_baseModel;
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
                base.CarregaClasse(operacaoModel);
                base.CarregaClasse(operacaoImportacaoModel);
                operacaoModel.idEmpresa = CompanyData.idEmpresa;
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }
        private void PopulaDadosClassificacaoFiscal()
        {
            try
            {
                //HLP.Comum.Edmx.Contextos.Fiscal.Classificacao_fiscal efClassificacaoFiscal = objboClassificacaoFiscal.RetRegistro(campoPesquisaClassificacaoFiscal.Valor);

                //if (efClassificacaoFiscal != null)
                //{
                //    nudpIpi.Value = efClassificacaoFiscal.pIpi;
                //    hlP_PesquisaidStIpi.Value = efClassificacaoFiscal.idStIpi;
                //    cbostCalcPisCofins.SelectedIndex = efClassificacaoFiscal.stCalcPisCofins;

                //    cbostRegimeTributacaoPisCofins.SelectedIndex = efClassificacaoFiscal.stRegimeTributacaoPisCofins;
                //    nudnCoeficienteSubstTributariaPis.Value = efClassificacaoFiscal.vCoeficienteSubstituicaoPis;
                //    nudnCoeficienteSubstTributariaCofins.Value = efClassificacaoFiscal.vCoeficienteSubstituicaoCofins;
                //    nudpPis.Value = efClassificacaoFiscal.pPis;
                //    nudpCofins.Value = efClassificacaoFiscal.pCofins;
                //    hlP_PesquisaidStPis.Value = efClassificacaoFiscal.idStPis;
                //    hlP_PesquisaidStCofins.Value = efClassificacaoFiscal.idStCofins;
                //    cbostCompoeBaseNormalPiscofins.SelectedIndex = efClassificacaoFiscal.stCompoeBaseNormalPisCofins;
                //    cbostCompoeBaseSubtTribPis.SelectedIndex = efClassificacaoFiscal.stCompoeBaseSubstPis;
                //    cbostCompoeBaseSubtTribCofins.SelectedIndex = efClassificacaoFiscal.stCompoeBaseSubstCofins;
                //}
                //else
                //{
                //    hlP_PesquisaidClassificacaoFiscal.Value = 0;
                //}

            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }
        private void VerificaSuperSimples()
        {
            try
            {
                if (empresaService.GetEmpresa(CompanyData.idEmpresa).stCodigoRegimeTributario == 1)
                {
                    cbostDescontaCredicmsCusto.SelectedIndex = 0;
                    cbostDescontaCredsubstCusto.SelectedIndex = 0;
                    cbostDescontaCredipiCusto.SelectedIndex = 0;
                    cbostDescontaCredpiscofinsCusto.SelectedIndex = 0;

                    cbostDescontaCredicmsCusto.Enabled = false;
                    cbostDescontaCredsubstCusto.Enabled = false;
                    cbostDescontaCredipiCusto.Enabled = false;
                    cbostDescontaCredpiscofinsCusto.Enabled = false;

                }
                else
                {
                    cbostDescontaCredicmsCusto.Enabled = true;
                    cbostDescontaCredsubstCusto.Enabled = true;
                    cbostDescontaCredipiCusto.Enabled = true;
                    cbostDescontaCredpiscofinsCusto.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }

        private void campoPesquisaClassificacaoFiscal_Leave(object sender, EventArgs e)
        {
            if (iCodClassificacaoFiscal != hlP_PesquisaidClassificacaoFiscal.Value)
            {
                iCodClassificacaoFiscal = hlP_PesquisaidClassificacaoFiscal.Value;
                PopulaDadosClassificacaoFiscal();
                nudpIpi.Focus();
            }

        }
        private void campoPesquisaClassificacaoFiscal_Enter(object sender, EventArgs e)
        {
            if (hlP_PesquisaidClassificacaoFiscal.Value != 0)
            {
                iCodClassificacaoFiscal = hlP_PesquisaidClassificacaoFiscal.Value;
            }
        }

        private void hlP_LabelSeparator_fiscal_Load(object sender, EventArgs e)
        {

        }
    }
}