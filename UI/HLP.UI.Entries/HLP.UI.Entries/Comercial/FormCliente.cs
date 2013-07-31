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
using HLP.Comum.Services.Interface;
using System.IO;
using ComponentFactory.Krypton.Toolkit;
using HLP.Comum.Messages;
using HLP.Comum.UI.Exception;
using HLP.Services.Interfaces.Entries.Comercial;
using HLP.Models.Entries.Comercial;
using HLP.Services.Interfaces.Entries.Parametros;

using System.Threading;
using HLP.Comum.Infrastructure.Static;

namespace HLP.UI.Entries.Comercial
{
    public partial class FormCliente : FormPadraoCadastro
    {
        [Inject]
        public IPesquisaPadraoService pesquisaPadraoService { get; set; }

        [Inject]
        public IParametro_financeiroService paramFinanceiroService { get; set; }

        [Inject]
        public ICliente_fornecedorService cliforService { get; set; }

        Cliente_fornecedorModel objCliForModel = new Cliente_fornecedorModel();

        Action VerifBw = null;
        Thread t1 = null;
        public FormCliente()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
          
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            idFuncionario.Tag = "FormFuncionario-vwFuncionario-xNome";
            idCidade.Tag = "FormCidade-vwCidade-xCidade_Uf_xRegiao_xPais";
            idContato.Tag = "FormContato-vwContato-xNome";
            idProduto.Tag = "FormProduto-vwProduto-xComercial";
            idListaPrecoPai.Tag = "FormListaPreco-vwListaPrecoPai-xLista";
                        
            InicializaFormPadrao("vwCliente");
            VerifBw += (() =>
            {
                CarregaCombosGrid();
            });
            t1 = new Thread(new ThreadStart(VerifBw));
            t1.Start();
        }
        public override void Novo()
        {
            try
            {
                base.Novo();
                cbostPessoa.SelectedIndex = 0;
                cbostCreditoAprovado.SelectedIndex = paramFinanceiroService.CreditoAprovado() == true ? 1 : 0;
                cbostCreditoAprovado.Enabled = false;
                txtdCadastro.Text = DateTime.Now.ToShortDateString();
                cboAtivo.SelectedIndex = 1;

                objCliForModel = new Cliente_fornecedorModel();
                bsObservacao.DataSource = objCliForModel.lCliente_Fornecedor_Observacao;
                bsRepresentante.DataSource = objCliForModel.lCliente_fornecedor_representante;
                bsEndereco.DataSource = objCliForModel.lCliente_Fornecedor_Endereco;
                bsContato.DataSource = objCliForModel.lCliente_fornecedor_contato;
                bsArquivo.DataSource = objCliForModel.lCliente_fornecedor_arquivo;
                bsProduto.DataSource = objCliForModel.lCliente_fornecedor_produto;

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
                    objCliForModel = cliforService.GetCliente_fornecedor((int)lParaExcluir[i], true);
                    cliforService.Delete(objCliForModel);
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

            cliforService.Delete(objCliForModel);
            base.Excluir();
            if (iRetPesquisa != null)
            {
                base.MoveProximoItem();
                objCliForModel = cliforService.GetCliente_fornecedor((int)iRetPesquisa, true);
                PopulaForm();
            }
        }
        public override void Atualizar()
        {
            base.Atualizar();
            cbostCreditoAprovado.Enabled = false;
            cbostPessoa__SelectedIndexChanged(null, null);
        }
        public override void Salvar()
        {
            try
            {
                objValidaCampos.Validar();
                PopulaTabela();

                cliforService.Save(objCliForModel);

                txtCodigo.Text = objCliForModel.idClienteFornecedor.ToString();
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
                        objCliForModel = cliforService.GetCliente_fornecedor(Convert.ToInt32(txtCodigo.Text), true);

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
                    objCliForModel = cliforService.GetCliente_fornecedor((int)iRetPesquisa, true);

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
                    objCliForModel = cliforService.GetCliente_fornecedor((int)iRetPesquisa, true);
                    if (objCliForModel != null)
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
                    objCliForModel = cliforService.GetCliente_fornecedor((int)iRetPesquisa, true);
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
                cliforService.Copy(objCliForModel);
                PopulaForm();
                base.RegistroDuplicado(idOrigem, (int)objCliForModel.idClienteFornecedor);
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }





        private void PopulaTabela()
        {
            objCliForModel.stCatalogo = 0;
            objCliForModel.idEmpresa = CompanyData.idEmpresa;

            #region Geral

            #region Principal

            if (objCliForModel.idClienteFornecedor == null)
            {
                objCliForModel.dCadastro = DateTime.Now.Date;
            }
            objCliForModel.cAlternativo = txtcAlternativo.Text;
            objCliForModel.xNome = txtxNome.Text;
            objCliForModel.xFantasia = txtxFantasia.Text;
            objCliForModel.idRamoAtividade = hlP_PesquisaidRamoAtividade.Value;
            objCliForModel.idMoeda = hlP_PesquisaidMoeda.Value;
            if (hlP_PesquisaidFuncionario.Value != 0) { objCliForModel.idFuncionario = hlP_PesquisaidFuncionario.Value; } else { objCliForModel.idFuncionario = null; }
            objCliForModel.stPessoa = cbostPessoa.SelectedIndexByte;
            if (objCliForModel.stPessoa == 0)
            {
                objCliForModel.xCpf = mskxCpf.Text;
                objCliForModel.xRg = txtxRg.Text;
                objCliForModel.xCnpj = null;
            }
            else
            {
                objCliForModel.xCpf = null;
                objCliForModel.xRg = null;
                objCliForModel.xCnpj = mskxCNPJ.Text;
            }
            objCliForModel.xIE = txtxIE.Text;
            objCliForModel.xIm = txtxIm.Text;
            objCliForModel.xMemorando = txtxMemorando.Text;
            objCliForModel.xFusoHorario = txtxFusoHorario.Text;
            objCliForModel.xTelefone1 = mskxTelefone1.Text;
            objCliForModel.xTelefone2 = mskxTelefone2.Text;
            objCliForModel.xFax = txtxFax.Text;
            objCliForModel.xEmail = txtxEmail.Text;
            objCliForModel.xHttp = txtxHttp.Text;
            objCliForModel.Ativo = cboAtivo.SelectedIndex == 0 ? false : true;

            #endregion

            #region Endereco Principal

            objCliForModel.xEndereco = txtxEndereco.Text;
            objCliForModel.nNumero = txtnNumero.Text;
            objCliForModel.xComplemento = txtxComplemento.Text;
            objCliForModel.xBairro = txtxBairro.Text;
            objCliForModel.xCEP = mskxCEP.Text;
            objCliForModel.xCaixaPostal = txtxCaixaPostal.Text;
            objCliForModel.xLatitude = txtxLatitude.Text;
            objCliForModel.xLongitude = txtxLongitude.Text;

            #endregion

            #endregion

            #region Comercial

            #region Geral

            objCliForModel.idCanalVenda = hlP_PesquisaidCanalVenda.Value;
            objCliForModel.nFuncionarios = nudnFuncionarios.ValueInt;
            objCliForModel.stCategoria = cbostCategoria.SelectedIndexByte;
            objCliForModel.idListaPrecoPai = hlP_PesquisaidListaPrecoPai.Value;
            objCliForModel.idRota = hlP_PesquisaidRota.Value;
            objCliForModel.stFrete = cbostFrete.SelectedIndexByte;
            if (hlP_PesquisaidSite.Value != 0) { objCliForModel.idSite = hlP_PesquisaidSite.Value; } else { objCliForModel.idSite = null; }
            if (hlP_PesquisaidDeposito.Value != 0) { objCliForModel.idDeposito = hlP_PesquisaidDeposito.Value; } else { objCliForModel.idDeposito = null; }
            objCliForModel.stSpc = cbostSpc.SelectedIndexByte;
            objCliForModel.stAssociacaoComercial = cbostAssociacaoComercial.SelectedIndexByte;
            objCliForModel.stSituacaoSci = cbostSituacaoSci.SelectedIndexByte;


            #endregion

            #region Faturamento

            if (hlP_PesquisaidTransportador.Value != 0) { objCliForModel.idTransportador = hlP_PesquisaidTransportador.Value; } else { objCliForModel.idTransportador = null; }

            #endregion

            #region Pagamento

            objCliForModel.idCondicaoPagamento = hlP_PesquisaidCondicaoPagamento.Value;
            if (hlP_PesquisaidPlanoPagamento.Value != 0) { objCliForModel.idPlanoPagamento = hlP_PesquisaidPlanoPagamento.Value; } else { objCliForModel.idPlanoPagamento = null; }
            if (hlP_PesquisaidDiaPagamento.Value != 0) { objCliForModel.idDiaPagamento = hlP_PesquisaidDiaPagamento.Value; } else { objCliForModel.idDiaPagamento = null; }
            if (hlP_PesquisaidDescontos.Value != 0) { objCliForModel.idDescontos = hlP_PesquisaidDescontos.Value; } else { objCliForModel.idDescontos = null; }

            #endregion

            #endregion

            #region Financeiro

            if (objCliForModel.idClienteFornecedor == null)
            {
                objCliForModel.stCreditoAprovado = cbostCreditoAprovado.SelectedIndexByte;
            }
            objCliForModel.stLimiteCreditoObrigatorio = cbostLimiteCreditoObrigatorio.SelectedIndexByte;
            objCliForModel.vLimiteCredito = nudvLimiteCredito.Value;
            objCliForModel.stParado = cbostParado.SelectedIndexByte;
            objCliForModel.idContaBancaria = hlP_PesquisaidContaBancaria.Value;
            if (hlP_PesquisaidJuros.Value != 0) { objCliForModel.idJuros = hlP_PesquisaidJuros.Value; } else { objCliForModel.idJuros = null; }
            if (hlP_PesquisaidMultas.Value != 0) { objCliForModel.idMultas = hlP_PesquisaidMultas.Value; } else { objCliForModel.idMultas = null; }


            #endregion

            #region Pessoal

            #region Pessoal

            objCliForModel.xSaudacao = txtxSaudacao.Text;
            objCliForModel.stSexo = cbostSexo.SelectedIndexByte;
            objCliForModel.xApelido = txtxApelido.Text;
            objCliForModel.stEstadoCivil = cbostEstadoCivil.SelectedIndexByte;
            objCliForModel.dDataNascimento = dtpdDataNascimento.Value;
            objCliForModel.xLocalNascimento = txtxLocalNascimento.Text;
            objCliForModel.xUFNascimento = txtxUFNascimento.Text;
            objCliForModel.stResidencia = cbostResidencia.SelectedIndexByte;
            objCliForModel.xPontoReferenciaResidencia = txtxPontoReferenciaResidencia.Text;

            #endregion

            #region Conjugue

            objCliForModel.xConjugue = txtxConjugue.Text;
            objCliForModel.xCPFConjugue = mskxCPFConjugue.Text;
            objCliForModel.xRGConjugue = txtxRGConjugue.Text;
            objCliForModel.xProfissaoConjugue = txtxProfissaoConjugue.Text;
            objCliForModel.xEmpresaConjugue = txtxEmpresaConjugue.Text;
            objCliForModel.vSalarioConjugue = nudvSalarioConjugue.Value;
            objCliForModel.xFilhos = txtxFilhos.Text;

            #endregion

            #region Local de Trabalho

            objCliForModel.xEmpresaTrabalha = txtxEmpresaTrabalha.Text;
            objCliForModel.xTelefoneEmpresaTrabalha = mskxTelefoneEmpresaTrabalha.Text;
            objCliForModel.dDataAdmissao = dtpdDataAdmissao.Value;
            objCliForModel.xProfissao = txtxProfissao.Text;
            objCliForModel.vSalario = nudvSalario.Value;

            #endregion

            #region Filiacao

            objCliForModel.xNomePai = txtxNomePai.Text;
            objCliForModel.xCPFPai = mskxCPFPai.Text;
            objCliForModel.xRGPai = txtxRGPai.Text;
            objCliForModel.xNomeMae = txtxNomeMae.Text;
            objCliForModel.xCPFMae = mskxCPFMae.Text;
            objCliForModel.xRGMae = txtxRGMae.Text;

            #endregion

            #region Referencia Comercial

            objCliForModel.xInformacaoComercialNome1 = txtxInformacaoComercialNome1.Text;
            objCliForModel.xInformacaoComercialTelefone1 = mskxInformacaoComercialTelefone1.Text;
            objCliForModel.dInformacaoComercialClienteDesde1 = dtpdInformacaoComercialClienteDesde1.Value;
            objCliForModel.vInformacaoComercialMaiorCompra1 = nudvInformacaoComercialMaiorCompra1.Value;
            objCliForModel.dInformacaoComercialUltimaCompra1 = dtpdInformacaoComercialUltimaCompra1.Value;
            objCliForModel.xInformacaoComercialInformante1 = txtxInformacaoComercialInformante1.Text;

            objCliForModel.xInformacaoComercialNome2 = txtxInformacaoComercialNome2.Text;
            objCliForModel.xInformacaoComercialTelefone2 = mskxInformacaoComercialTelefone2.Text;
            objCliForModel.dInformacaoComercialClienteDesde2 = dtpdInformacaoComercialClienteDesde2.Value;
            objCliForModel.vInformacaoComercialMaiorCompra2 = nudvInformacaoComercialMaiorCompra2.Value;
            objCliForModel.dInformacaoComercialUltimaCompra2 = dtpdInformacaoComercialUltimaCompra2.Value;
            objCliForModel.xInformacaoComercialInformante2 = txtxInformacaoComercialInformante2.Text;

            objCliForModel.xInformacaoComercialNome3 = txtxInformacaoComercialNome3.Text;
            objCliForModel.xInformacaoComercialTelefone3 = mskxInformacaoComercialTelefone3.Text;
            objCliForModel.dInformacaoComercialClienteDesde3 = dtpdInformacaoComercialClienteDesde3.Value;
            objCliForModel.vInformacaoComercialMaiorCompra3 = nudvInformacaoComercialMaiorCompra3.Value;
            objCliForModel.dInformacaoComercialUltimaCompra3 = dtpdInformacaoComercialUltimaCompra3.Value;
            objCliForModel.xInformacaoComercialInformante3 = txtxInformacaoComercialInformante3.Text;

            #endregion

            #endregion

            #region Configuracao

            objCliForModel.stExigeRelacaoProduto = cbostExigeRelacaoProduto.SelectedIndexByte;
            objCliForModel.idCondicaoEntrega = hlP_PesquisaidCondicaoEntrega.Value;
            if (hlP_PesquisaidModosEntrega.Value != 0) { objCliForModel.idModosEntrega = hlP_PesquisaidModosEntrega.Value; } else { objCliForModel.idModosEntrega = null; }
            if (hlP_PesquisaidCalendario.Value != 0) { objCliForModel.idCalendario = hlP_PesquisaidCalendario.Value; } else { objCliForModel.idCalendario = null; }
            if (hlP_PesquisaidTipoDocumento.Value != 0) { objCliForModel.idTipoDocumento = hlP_PesquisaidTipoDocumento.Value; } else { objCliForModel.idTipoDocumento = null; }
            objCliForModel.stMostraProdutosRelacionado = cbostMostraProdutosRelacionado.SelectedIndexByte;

            #endregion

            #region Fiscais

            objCliForModel.cliforFiscalModel.stSimplesNacional = cbostSimplesNacional.SelectedIndexByte;
            objCliForModel.cliforFiscalModel.stProdutorRural = cbostProdutorRural.SelectedIndexByte;
            objCliForModel.cliforFiscalModel.stExportador = cbostExportador.SelectedIndexByte;
            objCliForModel.cliforFiscalModel.stCooperativaAgricola = cbostCooperativaAgricola.SelectedIndexByte;
            objCliForModel.cliforFiscalModel.xCodigoSuframa = txtxCodigoSuframa.Text;
            objCliForModel.cliforFiscalModel.stDescontaIcmsSuframa = cbostDescontaIcmsSuframa.SelectedIndexByte;
            objCliForModel.cliforFiscalModel.pDescontaIcmsSuframa = nudpDescontaIcmsSuframa.Value;
            objCliForModel.cliforFiscalModel.stDescontaPisCofinsSuframa = cbostDescontaPisCofinsSuframa.SelectedIndexByte;
            objCliForModel.cliforFiscalModel.pDescontaPisSuframa = nudpDescontaPisSuframa.Value;
            objCliForModel.cliforFiscalModel.pDescontaCofinsSuframa = nudpDescontaCofinsSuframa.Value;
            objCliForModel.cliforFiscalModel.stCalculaFunrural = cbostCalculaFunrural.SelectedIndexByte;
            objCliForModel.cliforFiscalModel.pFunrural = nudpFunrural.Value;
            objCliForModel.cliforFiscalModel.xCodigoSuspensaoPisCofins = txtxCodigoSuspensaoPisCofins.Text;
            objCliForModel.cliforFiscalModel.stRetemIss = cbostRetemIss.SelectedIndexByte;
            objCliForModel.cliforFiscalModel.stRetemCsll = cbostRetemCsll.SelectedIndexByte;
            objCliForModel.cliforFiscalModel.stRetemInss = cbostRetemInss.SelectedIndexByte;
            objCliForModel.cliforFiscalModel.stRetemPisCofins = cbostRetemPisCofins.SelectedIndexByte;
            objCliForModel.cliforFiscalModel.stRetemIrrf = cbostRetemIrrf.SelectedIndexByte;
            objCliForModel.cliforFiscalModel.stConsumidorFinal = cbostConsumidorFinal.SelectedIndexByte;
            objCliForModel.cliforFiscalModel.stContribuienteIcms = cbostContribuienteIcms.SelectedIndexByte;
            objCliForModel.cliforFiscalModel.stSubsticaoTributariaIcmsDiferenciada = cbostSubsticaoTributariaIcmsDiferenciada.SelectedIndexByte;
            objCliForModel.stCalculaIcms = cbostCalculaIcms.SelectedIndexByte;
            objCliForModel.stCalculaIpi = cbostCalculaIpi.SelectedIndexByte;



            #endregion



        }
        private void PopulaForm()
        {
            try
            {
                txtCodigo.Text = objCliForModel.idClienteFornecedor.ToString();

                #region Geral

                #region Principal

                txtdCadastro.Text = objCliForModel.dCadastro.ToShortDateString();
                txtcAlternativo.Text = objCliForModel.cAlternativo;
                txtxNome.Text = objCliForModel.xNome;
                txtxFantasia.Text = objCliForModel.xFantasia;
                hlP_PesquisaidRamoAtividade.Value = objCliForModel.idRamoAtividade;
                hlP_PesquisaidMoeda.Value = objCliForModel.idMoeda;
                if (objCliForModel.idFuncionario != null) { hlP_PesquisaidFuncionario.Value = (int)objCliForModel.idFuncionario; } else { hlP_PesquisaidFuncionario.Value = 0; }
                cbostPessoa.SelectedIndex = objCliForModel.stPessoa;
                mskxCpf.Text = objCliForModel.xCpf;
                txtxRg.Text = objCliForModel.xRg;
                mskxCNPJ.Text = objCliForModel.xCnpj;
                txtxIE.Text = objCliForModel.xIE;
                txtxIm.Text = objCliForModel.xIm;
                txtxMemorando.Text = objCliForModel.xMemorando;
                txtxFusoHorario.Text = objCliForModel.xFusoHorario;
                mskxTelefone1.Text = objCliForModel.xTelefone1;
                mskxTelefone2.Text = objCliForModel.xTelefone2;
                txtxFax.Text = objCliForModel.xFax;
                txtxEmail.Text = objCliForModel.xEmail;
                txtxHttp.Text = objCliForModel.xHttp;
                cboAtivo.SelectedIndex = objCliForModel.Ativo == true ? 1 : 0;

                #endregion

                #region Endereco Principal

                txtxEndereco.Text = objCliForModel.xEndereco;
                txtnNumero.Text = objCliForModel.nNumero;
                txtxComplemento.Text = objCliForModel.xComplemento;
                txtxBairro.Text = objCliForModel.xBairro;
                mskxCEP.Text = objCliForModel.xCEP;
                txtxCaixaPostal.Text = objCliForModel.xCaixaPostal;
                txtxLatitude.Text = objCliForModel.xLatitude;
                txtxLongitude.Text = objCliForModel.xLongitude;

                #endregion

                #endregion

                #region Comercial

                #region Geral

                hlP_PesquisaidCanalVenda.Value = objCliForModel.idCanalVenda;
                nudnFuncionarios.Value = objCliForModel.nFuncionarios;
                cbostCategoria.SelectedIndex = objCliForModel.stCategoria;
                hlP_PesquisaidListaPrecoPai.Value = objCliForModel.idListaPrecoPai;
                hlP_PesquisaidRota.Value = objCliForModel.idRota;
                cbostFrete.SelectedIndex = objCliForModel.stFrete;
                if (objCliForModel.idSite != null) { hlP_PesquisaidSite.Value = (int)objCliForModel.idSite; } else { hlP_PesquisaidSite.Value = 0; }
                if (objCliForModel.idDeposito != null) { hlP_PesquisaidDeposito.Value = (int)objCliForModel.idDeposito; } else { hlP_PesquisaidDeposito.Value = 0; }
                cbostSpc.SelectedIndex = objCliForModel.stSpc;
                cbostAssociacaoComercial.SelectedIndex = objCliForModel.stAssociacaoComercial;
                cbostSituacaoSci.SelectedIndex = objCliForModel.stSituacaoSci;


                #endregion

                #region Faturamento

                if (objCliForModel.idTransportador != null) { hlP_PesquisaidTransportador.Value = (int)objCliForModel.idTransportador; } else { hlP_PesquisaidTransportador.Value = 0; }

                #endregion

                #region Pagamento

                hlP_PesquisaidCondicaoPagamento.Value = objCliForModel.idCondicaoPagamento;
                if (objCliForModel.idPlanoPagamento != null) { hlP_PesquisaidPlanoPagamento.Value = (int)objCliForModel.idPlanoPagamento; } else { hlP_PesquisaidPlanoPagamento.Value = 0; }
                if (objCliForModel.idDiaPagamento != null) { hlP_PesquisaidDiaPagamento.Value = (int)objCliForModel.idDiaPagamento; } else { hlP_PesquisaidDiaPagamento.Value = 0; }
                if (objCliForModel.idDescontos != null) { hlP_PesquisaidDescontos.Value = (int)objCliForModel.idDescontos; } else { hlP_PesquisaidDescontos.Value = 0; }

                #endregion

                #endregion

                #region Financeiro

                cbostCreditoAprovado.SelectedIndex = objCliForModel.stCreditoAprovado;
                cbostLimiteCreditoObrigatorio.SelectedIndex = objCliForModel.stLimiteCreditoObrigatorio;
                nudvLimiteCredito.Value = objCliForModel.vLimiteCredito;
                cbostParado.SelectedIndex = objCliForModel.stParado;
                hlP_PesquisaidContaBancaria.Value = objCliForModel.idContaBancaria;
                if (objCliForModel.idJuros != null) { hlP_PesquisaidJuros.Value = (int)objCliForModel.idJuros; } else { hlP_PesquisaidJuros.Value = 0; }
                if (objCliForModel.idMultas != null) { hlP_PesquisaidMultas.Value = (int)objCliForModel.idMultas; } else { hlP_PesquisaidMultas.Value = 0; }


                #endregion

                #region Pessoal

                #region Pessoal

                txtxSaudacao.Text = objCliForModel.xSaudacao;
                cbostSexo.SelectedIndex = objCliForModel.stSexo;
                txtxApelido.Text = objCliForModel.xApelido;
                cbostEstadoCivil.SelectedIndex = objCliForModel.stEstadoCivil;
                dtpdDataNascimento.Value = objCliForModel.dDataNascimento;
                txtxLocalNascimento.Text = objCliForModel.xLocalNascimento;
                txtxUFNascimento.Text = objCliForModel.xUFNascimento;
                cbostResidencia.SelectedIndex = objCliForModel.stResidencia;
                txtxPontoReferenciaResidencia.Text = objCliForModel.xPontoReferenciaResidencia;

                #endregion

                #region Conjugue

                txtxConjugue.Text = objCliForModel.xConjugue;
                mskxCPFConjugue.Text = objCliForModel.xCPFConjugue;
                txtxRGConjugue.Text = objCliForModel.xRGConjugue;
                txtxProfissaoConjugue.Text = objCliForModel.xProfissaoConjugue;
                txtxEmpresaConjugue.Text = objCliForModel.xEmpresaConjugue;
                nudvSalarioConjugue.Value = objCliForModel.vSalarioConjugue;
                txtxFilhos.Text = objCliForModel.xFilhos;

                #endregion

                #region Local de Trabalho

                txtxEmpresaTrabalha.Text = objCliForModel.xEmpresaTrabalha;
                mskxTelefoneEmpresaTrabalha.Text = objCliForModel.xTelefoneEmpresaTrabalha;
                dtpdDataAdmissao.Value = objCliForModel.dDataAdmissao;
                txtxProfissao.Text = objCliForModel.xProfissao;
                nudvSalario.Value = objCliForModel.vSalario;

                #endregion

                #region Filiacao

                txtxNomePai.Text = objCliForModel.xNomePai;
                mskxCPFPai.Text = objCliForModel.xCPFPai;
                txtxRGPai.Text = objCliForModel.xRGPai;
                txtxNomeMae.Text = objCliForModel.xNomeMae;
                mskxCPFMae.Text = objCliForModel.xCPFMae;
                txtxRGMae.Text = objCliForModel.xRGMae;

                #endregion

                #region Referencia Comercial

                txtxInformacaoComercialNome1.Text = objCliForModel.xInformacaoComercialNome1;
                mskxInformacaoComercialTelefone1.Text = objCliForModel.xInformacaoComercialTelefone1;
                dtpdInformacaoComercialClienteDesde1.Value = objCliForModel.dInformacaoComercialClienteDesde1;
                nudvInformacaoComercialMaiorCompra1.Value = objCliForModel.vInformacaoComercialMaiorCompra1;
                dtpdInformacaoComercialUltimaCompra1.Value = objCliForModel.dInformacaoComercialUltimaCompra1;
                txtxInformacaoComercialInformante1.Text = objCliForModel.xInformacaoComercialInformante1;

                txtxInformacaoComercialNome2.Text = objCliForModel.xInformacaoComercialNome2;
                mskxInformacaoComercialTelefone2.Text = objCliForModel.xInformacaoComercialTelefone2;
                dtpdInformacaoComercialClienteDesde2.Value = objCliForModel.dInformacaoComercialClienteDesde2;
                nudvInformacaoComercialMaiorCompra2.Value = objCliForModel.vInformacaoComercialMaiorCompra2;
                dtpdInformacaoComercialUltimaCompra2.Value = objCliForModel.dInformacaoComercialUltimaCompra2;
                txtxInformacaoComercialInformante2.Text = objCliForModel.xInformacaoComercialInformante2;

                txtxInformacaoComercialNome3.Text = objCliForModel.xInformacaoComercialNome3;
                mskxInformacaoComercialTelefone3.Text = objCliForModel.xInformacaoComercialTelefone3;
                dtpdInformacaoComercialClienteDesde3.Value = objCliForModel.dInformacaoComercialClienteDesde3;
                nudvInformacaoComercialMaiorCompra3.Value = objCliForModel.vInformacaoComercialMaiorCompra3;
                dtpdInformacaoComercialUltimaCompra3.Value = objCliForModel.dInformacaoComercialUltimaCompra3;
                txtxInformacaoComercialInformante3.Text = objCliForModel.xInformacaoComercialInformante3;

                #endregion

                #endregion

                #region Configuracao

                cbostExigeRelacaoProduto.SelectedIndex = objCliForModel.stExigeRelacaoProduto;
                hlP_PesquisaidCondicaoEntrega.Value = objCliForModel.idCondicaoEntrega;
                if (objCliForModel.idModosEntrega != null) { hlP_PesquisaidModosEntrega.Value = (int)objCliForModel.idModosEntrega; } else { hlP_PesquisaidModosEntrega.Value = 0; }
                if (objCliForModel.idCalendario != null) { hlP_PesquisaidCalendario.Value = (int)objCliForModel.idCalendario; } else { hlP_PesquisaidCalendario.Value = 0; }
                if (objCliForModel.idTipoDocumento != null) { hlP_PesquisaidTipoDocumento.Value = (int)objCliForModel.idTipoDocumento; } else { hlP_PesquisaidTipoDocumento.Value = 0; }
                cbostMostraProdutosRelacionado.SelectedIndex = objCliForModel.stMostraProdutosRelacionado;

                #endregion

                #region Fiscais

                cbostSimplesNacional.SelectedIndex = objCliForModel.cliforFiscalModel.stSimplesNacional;
                cbostProdutorRural.SelectedIndex = objCliForModel.cliforFiscalModel.stProdutorRural;
                cbostExportador.SelectedIndex = objCliForModel.cliforFiscalModel.stExportador;
                cbostCooperativaAgricola.SelectedIndex = objCliForModel.cliforFiscalModel.stCooperativaAgricola;
                txtxCodigoSuframa.Text = objCliForModel.cliforFiscalModel.xCodigoSuframa;
                cbostDescontaIcmsSuframa.SelectedIndex = objCliForModel.cliforFiscalModel.stDescontaIcmsSuframa;
                nudpDescontaIcmsSuframa.Value = objCliForModel.cliforFiscalModel.pDescontaIcmsSuframa;
                cbostDescontaPisCofinsSuframa.SelectedIndex = objCliForModel.cliforFiscalModel.stDescontaPisCofinsSuframa;
                nudpDescontaPisSuframa.Value = objCliForModel.cliforFiscalModel.pDescontaPisSuframa;
                nudpDescontaCofinsSuframa.Value = objCliForModel.cliforFiscalModel.pDescontaCofinsSuframa;
                cbostCalculaFunrural.SelectedIndex = objCliForModel.cliforFiscalModel.stCalculaFunrural;
                nudpFunrural.Value = objCliForModel.cliforFiscalModel.pFunrural;
                txtxCodigoSuspensaoPisCofins.Text = objCliForModel.cliforFiscalModel.xCodigoSuspensaoPisCofins;
                cbostRetemIss.SelectedIndex = objCliForModel.cliforFiscalModel.stRetemIss;
                cbostRetemCsll.SelectedIndex = objCliForModel.cliforFiscalModel.stRetemCsll;
                cbostRetemInss.SelectedIndex = objCliForModel.cliforFiscalModel.stRetemInss;
                cbostRetemPisCofins.SelectedIndex = objCliForModel.cliforFiscalModel.stRetemPisCofins;
                cbostRetemIrrf.SelectedIndex = objCliForModel.cliforFiscalModel.stRetemIrrf;
                cbostConsumidorFinal.SelectedIndex = objCliForModel.cliforFiscalModel.stConsumidorFinal;
                cbostContribuienteIcms.SelectedIndex = objCliForModel.cliforFiscalModel.stContribuienteIcms;
                cbostSubsticaoTributariaIcmsDiferenciada.SelectedIndex = objCliForModel.cliforFiscalModel.stSubsticaoTributariaIcmsDiferenciada;
                cbostCalculaIpi.SelectedIndex = objCliForModel.stCalculaIpi;
                cbostCalculaIcms.SelectedIndex = objCliForModel.stCalculaIcms;


                #endregion

                bsObservacao.DataSource = objCliForModel.lCliente_Fornecedor_Observacao;
                bsRepresentante.DataSource = objCliForModel.lCliente_fornecedor_representante;
                bsEndereco.DataSource = objCliForModel.lCliente_Fornecedor_Endereco;
                bsContato.DataSource = objCliForModel.lCliente_fornecedor_contato;
                bsArquivo.DataSource = objCliForModel.lCliente_fornecedor_arquivo;
                bsProduto.DataSource = objCliForModel.lCliente_fornecedor_produto;

            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }

        }


        private void CarregaCombosGrid()
        {
            if (objMetodosForm == null)
            {
                Thread.Sleep(500);
                CarregaCombosGrid();
            }
            else
            {
                idFuncionario.DataSource = pesquisaPadraoService.GetData(objMetodosForm.GetDisplayMember(idFuncionario), true);
                idCidade.DataSource = pesquisaPadraoService.GetData(objMetodosForm.GetDisplayMember(idCidade), true);
                idContato.DataSource = pesquisaPadraoService.GetData(objMetodosForm.GetDisplayMember(idContato), true);
                idProduto.DataSource = pesquisaPadraoService.GetData(objMetodosForm.GetDisplayMember(idProduto), true);
                idListaPrecoPai.DataSource = pesquisaPadraoService.GetData(objMetodosForm.GetDisplayMember(idListaPrecoPai), true);
                Thread.CurrentThread.Abort();
            }
        }



        private void dgvArquivos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvArquivos.Columns[e.ColumnIndex].DataPropertyName.Equals("xLinkArquivo"))
                {
                    if (dgvArquivos[e.ColumnIndex, e.RowIndex].Value != null)
                    {
                        if (dgvArquivos[e.ColumnIndex, e.RowIndex].Value.ToString() != "")
                        {
                            FileInfo file = new FileInfo(dgvArquivos[e.ColumnIndex, e.RowIndex].Value.ToString());
                            if (file.Exists)
                            {
                                System.Diagnostics.Process.Start(dgvArquivos[e.ColumnIndex, e.RowIndex].Value.ToString());
                            }
                            else
                            {
                                KryptonMessageBox.Show("Arquivo não encontrado", Mensagens.MSG_Alerta, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }

        private void dgvArquivos_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (dgvArquivos.CurrentCell != null)
                {
                    if (dgvArquivos.CurrentCell.ColumnIndex == 1)
                    {
                        if (e.KeyData == Keys.F5)
                        {
                            openFileDialog1.Title = "Caminho do Arquivo";
                            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                if (dgvArquivos[dgvArquivos.CurrentCell.ColumnIndex, dgvArquivos.CurrentCell.RowIndex].Value != null)
                                {
                                    if (openFileDialog1.FileName.Length > 300)
                                    {
                                        dgvArquivos[dgvArquivos.CurrentCell.ColumnIndex, dgvArquivos.CurrentCell.RowIndex].Value = openFileDialog1.FileName.ToString().Substring(0, 300);
                                    }
                                    else
                                    {
                                        dgvArquivos[dgvArquivos.CurrentCell.ColumnIndex, dgvArquivos.CurrentCell.RowIndex].Value = openFileDialog1.FileName.ToString();
                                    }
                                }

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }

        private void cbostPessoa__SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (btnSalvar.Enabled)
                {
                    if (cbostPessoa.SelectedIndex == 0)
                    {
                        mskxCpf.Enabled = true;

                        mskxCNPJ.Text = "";
                        mskxCNPJ.Enabled = false;

                        txtxIE.Text = "ISENTO";
                        txtxIE.Enabled = false;

                        txtxIm.Text = "ISENTO";
                        txtxIm.Enabled = false;

                        txtxRg.Text = "";
                        txtxRg.Enabled = true;
                    }
                    else if (cbostPessoa.SelectedIndex == 1)
                    {
                        mskxCpf.Enabled = false;
                        mskxCpf.Text = "";

                        mskxCNPJ.Enabled = true;

                        txtxIE.Text = "";
                        txtxIE.Enabled = true;

                        txtxIm.Text = "";
                        txtxIm.Enabled = true;

                        txtxRg.Text = "";
                        txtxRg.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }

        private void dgvContato_Enter(object sender, EventArgs e)
        {
            Sistema.contatoStatico.idFkReferencia = (txtCodigo.Text != "") ? Convert.ToInt32(txtCodigo.Text) : 0;
            Sistema.contatoStatico.fkTableReferencia = "idClienteFornecedor";
        }


    }
}
