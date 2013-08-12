using HLP.Comum.Infrastructure.Static;
using HLP.Comum.Messages;
using HLP.Comum.Services.Interface;
using HLP.Comum.UI;
using HLP.Comum.UI.Exception;
using HLP.Dependencies;
using HLP.Models.Entries.Gerais;
using HLP.Services.Interfaces.Entries.Gerais;
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

namespace HLP.UI.Entries.Parametrizacao
{
    public partial class formParametrizacao : FormPadraoCadastro
    {
        [Inject]
        public IPesquisaPadraoService pesquisaPadraoService { get; set; }

        [Inject]
        public IEmpresaService empresaService { get; set; }

        private EmpresaParametrosModel objEmpresaParametrosModel;
        private EmpresaModel objEmpresaModel;
        Action VerifBw = null;
        Thread t1 = null;

        public formParametrizacao()
        {
            InitializeComponent();

            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
            objEmpresaParametrosModel = new EmpresaParametrosModel();

            try
            {
                objEmpresaParametrosModel = empresaService.GetParametrosEmpresa();
            }
            catch (Exception ex)
            {
            }

        }

        public override void Atualizar()
        {
            base.Atualizar();
            txtCodigo.Enabled = txtxNome.Enabled = false;
        }

        public override void Salvar()
        {
            try
            {
                objValidaCampos.Validar();
                PopulaTabela();

                empresaService.SalvarParametrosEmpresa(objEmpresaParametrosModel);

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

                    objEmpresaParametrosModel = empresaService.GetParametrosEmpresa();

                    if (objEmpresaParametrosModel != null)
                    {
                        PopulaForm();
                    }
                    else
                    {
                        objMetodosForm.LimpaCampos();
                    }
                    HabilitaBotoes(1);
                    base.Cancelar();
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

        //private void PopulaTabela()
        //{
        //    #region Parametro_Estoque
        //    objEmpresaParametrosModel.ObjParametro_EstoqueModel.stEstoqueMinimo = cbxstEstoqueMinimo.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_EstoqueModel.stEstoqueMaximo = cbxstEstoqueMaximo.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_EstoqueModel.stMediaConsumo = cbxstMediaConsumo.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_EstoqueModel.stVendasGera = cbxstVendasGera.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_EstoqueModel.stGradeEstoque = cbxstGradeEstoque.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_EstoqueModel.stRastreabilidadeMaterial = cbxstRastreabilidadeMaterial.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_EstoqueModel.stRastreabilidadeProdutoAcabado = cbxstRastreabilidadeProdutoAcabado.SelectedIndexByte;
        //    #endregion

        //    #region Parametro_Custos
        //    objEmpresaParametrosModel.ObjParametro_CustosModel.xHorasTrabalhadasDia = nudxHorasTrabalhadasDia.Text;
        //    objEmpresaParametrosModel.ObjParametro_CustosModel.xDiasTrabalhadasSemana = nudxDiasTrabalhadasSemana.Text;
        //    objEmpresaParametrosModel.ObjParametro_CustosModel.stCustoComposicao = cbxstCustoComposicao.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_CustosModel.stValorVenda = cbxstValorVenda.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_CustosModel.stAtualizaValorCusto = cbxstAtualizaValorCusto.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_CustosModel.stAtualizaValorVenda = cbxstAtualizaValorVenda.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_CustosModel.stCustoDefault = cbxstCustoDefault.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_CustosModel.stCustoMedio = cbxstCustoMedio.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_CustosModel.stCompoeBaseCalculoCustoOperacional = cbxstCompoeBaseCalculoCustoOperacional.SelectedIndexByte;
        //    if (hlP_Pesquisa1idTipoOperacaoparaOPProduto.Value != 0)
        //        objEmpresaParametrosModel.ObjParametro_CustosModel.idTipoOperacao = hlP_Pesquisa1idTipoOperacaoparaOPProduto.Value;
        //    #endregion

        //    #region Parametro_Compras
        //    objEmpresaParametrosModel.ObjParametro_ComprasModel.vAprovacaoAutomaticaPedidoCompras = Convert.ToDecimal(nudvAprovacaoAutomaticaPedidoCompras.Value);
        //    objEmpresaParametrosModel.ObjParametro_ComprasModel.stAprovacaoRequisicao = cbxstAprovacaoRequisicao.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_ComprasModel.stAprovacaoCotacaoCompras = cbxstAprovacaoCotacaoCompras.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_ComprasModel.stAprovacaoPedidoCompras = cbxstAprovacaoPedidoCompras.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_ComprasModel.stIgnoraSaldoRequisicao = cbxstIgnoraSaldoRequisicao.SelectedIndexByte;
        //    #endregion

        //    #region Parametro Ordem de Produção
        //    objEmpresaParametrosModel.ObjParametro_Ordem_ProducaoModel.stProducaoGera = cbxstProducaoGera.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_Ordem_ProducaoModel.stGeraOPFilhas = cbxstGeraOPFilhas.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_Ordem_ProducaoModel.stFechaOPSaldoAproduzir = cbxstFechaOPSaldoAproduzir.SelectedIndexByte;
        //    if (hlP_Pesquisa1idTipoOperacaoparaOPProduto.Value != 0)
        //        objEmpresaParametrosModel.ObjParametro_Ordem_ProducaoModel.idTipoOperacaoparaOPProduto = hlP_Pesquisa1idTipoOperacaoparaOPProduto.Value;
        //    if (hlP_PesquisaidTipoOperacaoparaOPServico.Value != 0)
        //        objEmpresaParametrosModel.ObjParametro_Ordem_ProducaoModel.idTipoOperacaoparaOPServico = hlP_PesquisaidTipoOperacaoparaOPServico.Value;
        //    if (hlP_PesquisaidTipoOperacaoparaOPBenificiamento.Value != 0)
        //        objEmpresaParametrosModel.ObjParametro_Ordem_ProducaoModel.idTipoOperacaoparaOPBenificiamento = hlP_PesquisaidTipoOperacaoparaOPBenificiamento.Value;
        //    #endregion

        //    #region Parametro Fiscal Geral
        //    objEmpresaParametrosModel.ObjParametro_FiscalModel.pPIS = nudpAliquotaPIS.Value;
        //    objEmpresaParametrosModel.ObjParametro_FiscalModel.pCOFINS = nudpAliquotaCOFINS.Value;
        //    objEmpresaParametrosModel.ObjParametro_FiscalModel.pAliquotaCSLL = nudpAliquotaCSLL.Value;
        //    objEmpresaParametrosModel.ObjParametro_FiscalModel.stRegimeApuracaoIRPJ = cbxstRegimeApuracaoIRPJ.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_FiscalModel.stRegimeApuracaoIPI = cbxstRegimeApuracaoIPI.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_FiscalModel.stRegimeTributacaoPISCOFINS = cbxstRegimeTributacaoPISCOFINS.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_FiscalModel.stRegimeApuracaoPISCOFINS = cbxstRegimeApuracaoPISCOFINS.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_FiscalModel.stProdutorRural = cbxstProdutorRural.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_FiscalModel.stCooperativaAgricola = cbxstCooperativaAgricola.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_FiscalModel.stDestacaISSnfServico = cbxstDestacaISSnfServico.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_FiscalModel.stDestacaCSLLnfServico = cbxstDestacaCSLLnfServico.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_FiscalModel.stDestacaIRRFnfServico = cbxstDestacaIRRFnfServico.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_FiscalModel.stDestacaPISCOFINSnfServico = cbxstDestacaPISCOFINSnfServico.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_FiscalModel.stDestacaINSSnfServico = cbxstDestacaINSSnfServico.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_FiscalModel.stAmbienteNfeProdutos = cbxstAmbienteNfeProdutos.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_FiscalModel.stAmbienteNfeServicos = cbxstAmbienteNfeServicos.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_FiscalModel.stImprimeMsgSuframaNf = cbxstImprimeMsgSuframaNf.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_FiscalModel.stImprimeCodigoNf = cbxstImprimeCodigoNf.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_FiscalModel.stIcmsSubstDif = cbxstIcmsSubstDif.SelectedIndexByte;
        //    #endregion

        //    #region Parametro Fiscal Super Simples
        //    objEmpresaParametrosModel.ObjParametro_FiscalModel.pICMSss = nudpICMSss.Value;
        //    objEmpresaParametrosModel.ObjParametro_FiscalModel.pISSss = nudpISSss.Value;
        //    objEmpresaParametrosModel.ObjParametro_FiscalModel.pCSLLss = nudpCSLLss.Value;
        //    objEmpresaParametrosModel.ObjParametro_FiscalModel.pIRRFss = nudpIRRFss.Value;
        //    objEmpresaParametrosModel.ObjParametro_FiscalModel.pPISss = nudpPISss.Value;
        //    objEmpresaParametrosModel.ObjParametro_FiscalModel.pCOFINSss = nudpCOFINSss.Value;
        //    objEmpresaParametrosModel.ObjParametro_FiscalModel.nItensNfProduto = nudnItensNfProduto.ValueInt;
        //    objEmpresaParametrosModel.ObjParametro_FiscalModel.nItensNfServico = nudnItensNfServico.ValueInt;
        //    objEmpresaParametrosModel.ObjParametro_FiscalModel.stSuperSimples = cbxstSuperSimples.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_FiscalModel.stCRT = cbxstCRT.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_FiscalModel.stImprimeMsgPadraoSs = cbxstImprimeMsgPadraoSs.SelectedIndexByte;
        //    if (hlP_PesquisaidObservacaoMsgSuperSimples.Value != 0)
        //        objEmpresaParametrosModel.ObjParametro_FiscalModel.idObservacaoMsgSuperSimples = hlP_PesquisaidObservacaoMsgSuperSimples.Value;
        //    objEmpresaParametrosModel.ObjParametro_FiscalModel.stImprimeMsgCreditoIcmsSs = cbxstImprimeMsgCreditoIcmsSs.SelectedIndexByte;
        //    if (hlP_PesquisaidObservacaoMsgCreditoSuperSimples.Value != 0)
        //        objEmpresaParametrosModel.ObjParametro_FiscalModel.idObservacaoMsgCreditoSuperSimples = hlP_PesquisaidObservacaoMsgCreditoSuperSimples.Value;
        //    objEmpresaParametrosModel.ObjParametro_FiscalModel.pINSSss = nudpINSSss.Value;
        //    #endregion

        //    #region Parametro Comercial
        //    objEmpresaParametrosModel.ObjParametro_ComercialModel.xMaskCentroCusto = txtxMaskCentroCusto.Text;
        //    objEmpresaParametrosModel.ObjParametro_ComercialModel.nQuantidadeDiasOrcamento = nudnQuantidadeDiasOrcamento.ValueInt;
        //    objEmpresaParametrosModel.ObjParametro_ComercialModel.stObrigaCreditoAprovado = cbxstObrigaCreditoAprovado.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_ComercialModel.stObrigaAnaliseFinanceiraOrcamento = cbxstObrigaAnaliseFinanceiraOrcamento.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_ComercialModel.stObrigaAnaliseFinanceiraPedidoVenda = cbxstObrigaAnaliseFinanceiraPedidoVenda.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_ComercialModel.stObrigaAnaliseFinanceiraFaturamento = cbxstObrigaAnaliseFinanceiraFaturamento.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_ComercialModel.stObrigaUsoListaPreco = cbxstOrigemListaPreco.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_ComercialModel.stDescontoPor = cbxstDescontoPor.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_ComercialModel.stDesconto = cbxstDesconto.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_ComercialModel.stOrcamentoProjeto = cbxstOrcamentoProjeto.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_ComercialModel.stObrigaAprovacaoPedidoVenda = cbxstObrigaAprovacaoPedidoVenda.SelectedIndexByte;
        //    if (hlP_PesquisaidMoeda.Value != 0)
        //        objEmpresaParametrosModel.ObjParametro_ComercialModel.idMoeda = hlP_PesquisaidMoeda.Value;
        //    objEmpresaParametrosModel.ObjParametro_ComercialModel.stOrigemListaPreco = cbxstOrigemListaPreco.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_ComercialModel.stUtilizaVendaCasada = cbxstUtilizaVendaCasada.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_ComercialModel.stUtilizaVendaKitMaterial = cbxstUtilizaVendaKitMateria.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_ComercialModel.stRateioFrete = cbxstRateioFrete.SelectedIndexByte;
        //    #endregion

        //    #region Parametro Financeiro
        //    objEmpresaParametrosModel.ObjParametro_FinanceiroModel.xMaskClasseFinanceira = txtxMaskClasseFinanceira.Text;
        //    objEmpresaParametrosModel.ObjParametro_FinanceiroModel.stPedidoCompraGeraPrevisao = cbxstPedidoCompraGeraPrevisao.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_FinanceiroModel.stPedidoVendaGeraPrevisao = cbxstPedidoVendaGeraPrevisao.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_FinanceiroModel.stPagaComissaoPor = cbxstPagaComissaoPor.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_FinanceiroModel.stCreditoAprovado = cbxstCreditoAprovado.SelectedIndexByte;
        //    objEmpresaParametrosModel.ObjParametro_FinanceiroModel.stBloqueiaClientePosCartaCobranca = cbxstBloqueiaClientePosCartaCobranca.SelectedIndexByte;
        //    #endregion
        //}

        private void PopulaTabela()
        {
            base.CarregaClasse(objEmpresaParametrosModel.ObjParametro_ComercialModel);
            base.CarregaClasse(objEmpresaParametrosModel.ObjParametro_ComprasModel);
            base.CarregaClasse(objEmpresaParametrosModel.ObjParametro_CustosModel);
            base.CarregaClasse(objEmpresaParametrosModel.ObjParametro_EstoqueModel);
            base.CarregaClasse(objEmpresaParametrosModel.ObjParametro_FinanceiroModel);
            base.CarregaClasse(objEmpresaParametrosModel.ObjParametro_FiscalModel);
            base.CarregaClasse(objEmpresaParametrosModel.ObjParametro_Ordem_ProducaoModel);
        }

        //private void PopulaForm()
        //{
        //    #region Parametro_Estoque
        //    if (objEmpresaParametrosModel.ObjParametro_EstoqueModel.idParametroEstoque != null)
        //    {
        //        cbxstEstoqueMinimo.SelectedIndex = objEmpresaParametrosModel.ObjParametro_EstoqueModel.stEstoqueMinimo;
        //        cbxstEstoqueMaximo.SelectedIndex = objEmpresaParametrosModel.ObjParametro_EstoqueModel.stEstoqueMaximo;
        //        cbxstMediaConsumo.SelectedIndex = objEmpresaParametrosModel.ObjParametro_EstoqueModel.stMediaConsumo;
        //        cbxstVendasGera.SelectedIndex = objEmpresaParametrosModel.ObjParametro_EstoqueModel.stVendasGera;
        //        cbxstGradeEstoque.SelectedIndex = objEmpresaParametrosModel.ObjParametro_EstoqueModel.stGradeEstoque;
        //        cbxstRastreabilidadeMaterial.SelectedIndex = objEmpresaParametrosModel.ObjParametro_EstoqueModel.stRastreabilidadeMaterial;
        //        cbxstRastreabilidadeProdutoAcabado.SelectedIndex = objEmpresaParametrosModel.ObjParametro_EstoqueModel.stRastreabilidadeProdutoAcabado;
        //    }
        //    #endregion

        //    #region Parametro_Custos
        //    if (objEmpresaParametrosModel.ObjParametro_CustosModel.idParametroCustos != null)
        //    {
        //        nudxHorasTrabalhadasDia.Value = Convert.ToDecimal(objEmpresaParametrosModel.ObjParametro_CustosModel.xHorasTrabalhadasDia);
        //        nudxDiasTrabalhadasSemana.Value = Convert.ToDecimal(objEmpresaParametrosModel.ObjParametro_CustosModel.xDiasTrabalhadasSemana);
        //        cbxstCustoComposicao.SelectedIndex = objEmpresaParametrosModel.ObjParametro_CustosModel.stCustoComposicao;
        //        cbxstValorVenda.SelectedIndex = objEmpresaParametrosModel.ObjParametro_CustosModel.stValorVenda;
        //        cbxstAtualizaValorCusto.SelectedIndex = objEmpresaParametrosModel.ObjParametro_CustosModel.stAtualizaValorCusto;
        //        cbxstAtualizaValorVenda.SelectedIndex = objEmpresaParametrosModel.ObjParametro_CustosModel.stValorVenda;
        //        cbxstCustoDefault.SelectedIndex = objEmpresaParametrosModel.ObjParametro_CustosModel.stCustoDefault;
        //        cbxstCustoMedio.SelectedIndex = objEmpresaParametrosModel.ObjParametro_CustosModel.stCustoMedio;
        //        cbxstCompoeBaseCalculoCustoOperacional.SelectedIndex = objEmpresaParametrosModel.ObjParametro_CustosModel.stCompoeBaseCalculoCustoOperacional;
        //        hlP_Pesquisa1idTipoOperacaoparaOPProduto.Value = objEmpresaParametrosModel.ObjParametro_CustosModel.idTipoOperacao ?? 0;

        //    }
        //    #endregion

        //    #region Parametro_Compras
        //    if (objEmpresaParametrosModel.ObjParametro_ComprasModel.idParametro_Compras != null)
        //    {
        //        nudvAprovacaoAutomaticaPedidoCompras.Value = objEmpresaParametrosModel.ObjParametro_ComprasModel.vAprovacaoAutomaticaPedidoCompras;
        //        cbxstAprovacaoRequisicao.SelectedIndex = objEmpresaParametrosModel.ObjParametro_ComprasModel.stIgnoraSaldoRequisicao;
        //        cbxstAprovacaoCotacaoCompras.SelectedIndex = objEmpresaParametrosModel.ObjParametro_ComprasModel.stAprovacaoCotacaoCompras;
        //        cbxstAprovacaoPedidoCompras.SelectedIndex = objEmpresaParametrosModel.ObjParametro_ComprasModel.stAprovacaoPedidoCompras;
        //        cbxstIgnoraSaldoRequisicao.SelectedIndex = objEmpresaParametrosModel.ObjParametro_ComprasModel.stIgnoraSaldoRequisicao;
        //    }
        //    #endregion

        //    #region Parametro Ordem de Produção
        //    if (objEmpresaParametrosModel.ObjParametro_Ordem_ProducaoModel.idParametroOrdemProducao != null)
        //    {
        //        cbxstProducaoGera.SelectedIndex = objEmpresaParametrosModel.ObjParametro_Ordem_ProducaoModel.stProducaoGera;
        //        cbxstGeraOPFilhas.SelectedIndex = objEmpresaParametrosModel.ObjParametro_Ordem_ProducaoModel.stGeraOPFilhas;
        //        cbxstFechaOPSaldoAproduzir.SelectedIndex = objEmpresaParametrosModel.ObjParametro_Ordem_ProducaoModel.stFechaOPSaldoAproduzir;
        //        hlP_Pesquisa1idTipoOperacaoparaOPProduto.Value = objEmpresaParametrosModel.ObjParametro_Ordem_ProducaoModel.idTipoOperacaoparaOPProduto ?? 0;
        //        hlP_PesquisaidTipoOperacaoparaOPServico.Value = objEmpresaParametrosModel.ObjParametro_Ordem_ProducaoModel.idTipoOperacaoparaOPServico ?? 0;
        //        hlP_PesquisaidTipoOperacaoparaOPBenificiamento.Value = objEmpresaParametrosModel.ObjParametro_Ordem_ProducaoModel.idTipoOperacaoparaOPBenificiamento ?? 0;
        //    }
        //    #endregion

        //    #region Parametro Fiscal Geral
        //    if (objEmpresaParametrosModel.ObjParametro_FiscalModel.idParametroFiscal != null)
        //    {
        //        nudpAliquotaPIS.Value = objEmpresaParametrosModel.ObjParametro_FiscalModel.pPIS;
        //        nudpAliquotaCOFINS.Value = objEmpresaParametrosModel.ObjParametro_FiscalModel.pCOFINS;
        //        nudpAliquotaCSLL.Value = objEmpresaParametrosModel.ObjParametro_FiscalModel.pAliquotaCSLL;
        //        cbxstRegimeApuracaoIRPJ.SelectedIndex = objEmpresaParametrosModel.ObjParametro_FiscalModel.stRegimeApuracaoIRPJ;
        //        cbxstRegimeApuracaoIPI.SelectedIndex = objEmpresaParametrosModel.ObjParametro_FiscalModel.stRegimeApuracaoIPI;
        //        cbxstRegimeTributacaoPISCOFINS.SelectedIndex = objEmpresaParametrosModel.ObjParametro_FiscalModel.stRegimeTributacaoPISCOFINS;
        //        cbxstRegimeApuracaoPISCOFINS.SelectedIndex = objEmpresaParametrosModel.ObjParametro_FiscalModel.stRegimeApuracaoPISCOFINS;
        //        cbxstProdutorRural.SelectedIndex = objEmpresaParametrosModel.ObjParametro_FiscalModel.stProdutorRural;
        //        cbxstCooperativaAgricola.SelectedIndex = objEmpresaParametrosModel.ObjParametro_FiscalModel.stCooperativaAgricola;
        //        cbxstDestacaISSnfServico.SelectedIndex = objEmpresaParametrosModel.ObjParametro_FiscalModel.stDestacaISSnfServico;
        //        cbxstDestacaCSLLnfServico.SelectedIndex = objEmpresaParametrosModel.ObjParametro_FiscalModel.stDestacaCSLLnfServico;
        //        cbxstDestacaIRRFnfServico.SelectedIndex = objEmpresaParametrosModel.ObjParametro_FiscalModel.stDestacaIRRFnfServico;
        //        cbxstDestacaPISCOFINSnfServico.SelectedIndex = objEmpresaParametrosModel.ObjParametro_FiscalModel.stDestacaPISCOFINSnfServico;
        //        cbxstDestacaINSSnfServico.SelectedIndex = objEmpresaParametrosModel.ObjParametro_FiscalModel.stDestacaINSSnfServico;
        //        cbxstAmbienteNfeProdutos.SelectedIndex = objEmpresaParametrosModel.ObjParametro_FiscalModel.stAmbienteNfeProdutos;
        //        cbxstAmbienteNfeServicos.SelectedIndex = objEmpresaParametrosModel.ObjParametro_FiscalModel.stAmbienteNfeServicos;
        //        cbxstImprimeMsgSuframaNf.SelectedIndex = objEmpresaParametrosModel.ObjParametro_FiscalModel.stImprimeMsgSuframaNf;
        //        cbxstImprimeCodigoNf.SelectedIndex = objEmpresaParametrosModel.ObjParametro_FiscalModel.stImprimeCodigoNf;
        //        cbxstIcmsSubstDif.SelectedIndex = objEmpresaParametrosModel.ObjParametro_FiscalModel.stIcmsSubstDif;
        //    }

        //    #endregion

        //    #region Parametro Fiscal Super Simples
        //    if (objEmpresaParametrosModel.ObjParametro_FiscalModel.idParametroFiscal != null)
        //    {
        //        nudpICMSss.Value = (decimal)objEmpresaParametrosModel.ObjParametro_FiscalModel.pICMSss;
        //        nudpISSss.Value = (decimal)objEmpresaParametrosModel.ObjParametro_FiscalModel.pISSss;
        //        nudpCSLLss.Value = (decimal)objEmpresaParametrosModel.ObjParametro_FiscalModel.pCSLLss;
        //        nudpIRRFss.Value = (decimal)objEmpresaParametrosModel.ObjParametro_FiscalModel.pIRRFss;
        //        nudpPISss.Value = (decimal)objEmpresaParametrosModel.ObjParametro_FiscalModel.pPISss;
        //        nudpCOFINSss.Value = (decimal)objEmpresaParametrosModel.ObjParametro_FiscalModel.pCOFINSss;
        //        nudnItensNfProduto.ValueInt = objEmpresaParametrosModel.ObjParametro_FiscalModel.nItensNfProduto;
        //        nudnItensNfServico.ValueInt = objEmpresaParametrosModel.ObjParametro_FiscalModel.nItensNfServico;
        //        cbxstSuperSimples.SelectedIndex = objEmpresaParametrosModel.ObjParametro_FiscalModel.stSuperSimples;
        //        cbxstCRT.SelectedIndex = objEmpresaParametrosModel.ObjParametro_FiscalModel.stCRT;
        //        cbxstImprimeMsgPadraoSs.SelectedIndex = objEmpresaParametrosModel.ObjParametro_FiscalModel.stImprimeMsgPadraoSs;
        //        hlP_PesquisaidObservacaoMsgSuperSimples.Value = objEmpresaParametrosModel.ObjParametro_FiscalModel.idObservacaoMsgSuperSimples ?? 0;
        //        cbxstImprimeMsgCreditoIcmsSs.SelectedIndex = objEmpresaParametrosModel.ObjParametro_FiscalModel.stImprimeMsgCreditoIcmsSs;
        //        hlP_PesquisaidObservacaoMsgCreditoSuperSimples.Value = objEmpresaParametrosModel.ObjParametro_FiscalModel.idObservacaoMsgCreditoSuperSimples ?? 0;
        //        nudpINSSss.Value = (decimal)objEmpresaParametrosModel.ObjParametro_FiscalModel.pINSSss;
        //    }
        //    #endregion

        //    #region Parametro Comercial
        //    if (objEmpresaParametrosModel.ObjParametro_ComercialModel.idParametroComercial != null)
        //    {
        //        txtxMaskCentroCusto.Text = objEmpresaParametrosModel.ObjParametro_ComercialModel.xMaskCentroCusto;
        //        nudnQuantidadeDiasOrcamento.ValueInt = objEmpresaParametrosModel.ObjParametro_ComercialModel.nQuantidadeDiasOrcamento;
        //        cbxstObrigaCreditoAprovado.SelectedIndex = objEmpresaParametrosModel.ObjParametro_ComercialModel.stObrigaCreditoAprovado;
        //        cbxstObrigaAnaliseFinanceiraOrcamento.SelectedIndex = objEmpresaParametrosModel.ObjParametro_ComercialModel.stObrigaAnaliseFinanceiraOrcamento;
        //        cbxstObrigaAnaliseFinanceiraPedidoVenda.SelectedIndex = objEmpresaParametrosModel.ObjParametro_ComercialModel.stObrigaAnaliseFinanceiraPedidoVenda;
        //        cbxstObrigaAnaliseFinanceiraFaturamento.SelectedIndex = objEmpresaParametrosModel.ObjParametro_ComercialModel.stObrigaAnaliseFinanceiraFaturamento;
        //        cbxstObrigaUsoListaPreco.SelectedIndex = objEmpresaParametrosModel.ObjParametro_ComercialModel.stObrigaUsoListaPreco;
        //        cbxstDescontoPor.SelectedIndex = objEmpresaParametrosModel.ObjParametro_ComercialModel.stDescontoPor;
        //        cbxstDesconto.SelectedIndex = objEmpresaParametrosModel.ObjParametro_ComercialModel.stDesconto;
        //        cbxstOrcamentoProjeto.SelectedIndex = objEmpresaParametrosModel.ObjParametro_ComercialModel.stOrcamentoProjeto;
        //        cbxstObrigaAprovacaoPedidoVenda.SelectedIndex = objEmpresaParametrosModel.ObjParametro_ComercialModel.stObrigaAprovacaoPedidoVenda;
        //        hlP_PesquisaidMoeda.Value = objEmpresaParametrosModel.ObjParametro_ComercialModel.idMoeda;
        //        cbxstOrigemListaPreco.SelectedIndex = objEmpresaParametrosModel.ObjParametro_ComercialModel.stOrigemListaPreco;
        //        cbxstUtilizaVendaCasada.SelectedIndex = objEmpresaParametrosModel.ObjParametro_ComercialModel.stUtilizaVendaCasada;
        //        cbxstUtilizaVendaKitMateria.SelectedIndex = objEmpresaParametrosModel.ObjParametro_ComercialModel.stUtilizaVendaKitMaterial;
        //        cbxstRateioFrete.SelectedIndex = objEmpresaParametrosModel.ObjParametro_ComercialModel.stRateioFrete;
        //    }
        //    #endregion

        //    #region Parametro Financeiro
        //    if (objEmpresaParametrosModel.ObjParametro_FinanceiroModel.idParametroFinanceiro != null)
        //    {
        //        txtxMaskClasseFinanceira.Text = objEmpresaParametrosModel.ObjParametro_FinanceiroModel.xMaskClasseFinanceira;
        //        cbxstPedidoCompraGeraPrevisao.SelectedIndex = objEmpresaParametrosModel.ObjParametro_FinanceiroModel.stPedidoCompraGeraPrevisao;
        //        cbxstPedidoVendaGeraPrevisao.SelectedIndex = objEmpresaParametrosModel.ObjParametro_FinanceiroModel.stPedidoVendaGeraPrevisao;
        //        cbxstPagaComissaoPor.SelectedIndex = objEmpresaParametrosModel.ObjParametro_FinanceiroModel.stPagaComissaoPor;
        //        cbxstCreditoAprovado.SelectedIndex = objEmpresaParametrosModel.ObjParametro_FinanceiroModel.stCreditoAprovado;
        //        cbxstBloqueiaClientePosCartaCobranca.SelectedIndex = objEmpresaParametrosModel.ObjParametro_FinanceiroModel.stBloqueiaClientePosCartaCobranca;
        //    }
        //    #endregion
        //}

        private void PopulaForm()
        {
            base.CarregaPropriedades(objEmpresaParametrosModel.ObjParametro_ComercialModel, true);
            base.CarregaPropriedades(objEmpresaParametrosModel.ObjParametro_ComprasModel);
            base.CarregaPropriedades(objEmpresaParametrosModel.ObjParametro_CustosModel);
            base.CarregaPropriedades(objEmpresaParametrosModel.ObjParametro_EstoqueModel);
            base.CarregaPropriedades(objEmpresaParametrosModel.ObjParametro_FinanceiroModel);
            base.CarregaPropriedades(objEmpresaParametrosModel.ObjParametro_FiscalModel);
            base.CarregaPropriedades(objEmpresaParametrosModel.ObjParametro_Ordem_ProducaoModel);
            base.CarregaForm();
        }

        private void formParametrizacao_Load(object sender, EventArgs e)
        {
            InicializaFormPadrao("");

            VerifBw += (() =>
            {
                CarregaDadosEmpresa();
            });
            t1 = new Thread(new ThreadStart(VerifBw));
            t1.Start();
            btnNovo.Visible = false;
            btnPesquisar.Visible = false;
            btnExcluir.Visible = false;
            btnDuplicar.Visible = false;
        }

        private void CarregaDadosEmpresa()
        {
            if (objMetodosForm == null)
            {
                Thread.Sleep(500);
                CarregaDadosEmpresa();
            }
            else
            {
                objEmpresaModel = new EmpresaModel();
                objEmpresaModel = empresaService.GetEmpresa(CompanyData.idEmpresa);
                Invoke(new MethodInvoker(delegate
                    {
                        txtCodigo.Text = objEmpresaModel.idEmpresa.ToString();
                    }));

                Invoke(new MethodInvoker(delegate
                {
                    txtxNome.Text = objEmpresaModel.xNome;
                }));

                Invoke(new MethodInvoker(delegate
                {
                    PopulaForm();
                }));

                Invoke(new MethodInvoker(delegate
                {
                    HabilitaBotoes(1);
                }));
                Thread.CurrentThread.Abort();
            }
        }

    }
}
