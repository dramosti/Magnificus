using HLP.Comum.Messages;
using HLP.Comum.Services.Interface;
using HLP.Comum.UI;
using HLP.Comum.UI.Exception;
using HLP.Dependencies;
using HLP.Models.Entries.Comercial;
using HLP.Models.Entries.Fiscal;
using HLP.Models.Entries.Gerais;
using HLP.Models.Sales.Comercial;
using HLP.Services.Interfaces.Entries.Comercial;
using HLP.Services.Interfaces.Entries.Fiscal;
using HLP.Services.Interfaces.Entries.Gerais;
using HLP.Services.Interfaces.Sales.Comercial;
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
using HLP.Comum.Infrastructure.Static;
using System.Reflection;
using ComponentFactory.Krypton.Toolkit;

namespace HLP.UI.Sales.Comercial
{
    public partial class formOrcamentoVenda : FormPadraoCadastro
    {
        Action VerifBw = null;
        Thread t1 = null;
        Orcamento_ideModel objOrcamento = null;
        Cliente_fornecedorModel objCliente = null;
        Cliente_fornecedor_EnderecoModel objCliente_endereco = null;
        Cliente_fornecedor_representanteModel objCliente_representante = null;
        ContatoModel objContato = null;
        CidadeModel objCidade = null;
        UFModel objUf = null;
        FuncionarioModel objFuncionario = null;
        List<Lista_precoModel> lListaPreco = null;
        List<ItemPorcAcimaListaModel> lItemPorcAcimaListaModel = null;

        const int numCasasDecimaisValor = 4;
        const int numCasasDecimaisPorc = 2;
        private int iIdOrcamento = 0;

        [Inject]
        public IPesquisaPadraoService pesquisaPadraoService { get; set; }

        [Inject]
        public IOrcamento_ideService orcamento_ideService { get; set; }

        [Inject]
        public ICliente_fornecedorService clienteService { get; set; }

        [Inject]
        public IContatoService contatoService { get; set; }

        [Inject]
        public ICidadeService cidadeService { get; set; }

        [Inject]
        public ITipo_documentoService tipo_DocumentoService { get; set; }

        [Inject]
        public IFuncionarioService funcionarioService { get; set; }

        [Inject]
        public IProdutoService produtoService { get; set; }

        [Inject]
        public IConversaoService conversaoService { get; set; }

        [Inject]
        public IUnidade_medidaService unidadeService { get; set; }

        [Inject]
        public ILista_precoService listaPrecoService { get; set; }

        #region Botoes dinâmicos do menu de atalhos
        KryptonButton btnStatus = null;
        KryptonButton btnVersao = null;
        KryptonButton btnConsulta = null;
        #endregion

        public formOrcamentoVenda()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
        }

        public formOrcamentoVenda(int idOrcamento)
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
            this.iIdOrcamento = idOrcamento;
        }

        private void formOrcamentoVenda_Load(object sender, EventArgs e)
        {
            objOrcamento = new Orcamento_ideModel();
            idOperacaoItens.Tag = "FormTipoOperacao-vwTipoOperacao-ID_xOperacao";
            clidProduto.Tag = "FormProduto-vwProduto-ID_xPesquisa";
            idListaPrecoPai.Tag = "FormListaPreco-vwListaPrecoPai-ID_xLista";
            idCfop.Tag = "FormCfop-vwCfop-xCfop";
            idDepositoDataGridViewTextBoxColumn.Tag = "FormDeposito-vwDeposito-ID_xDeposito";
            idSiteDataGridViewTextBoxColumn.Tag = "FormSite-vwSite-ID_xSite";

            idCSTCofinsDataGridViewTextBoxColumn.Tag = "FormStCOFINS-vwStCOFINS-ID_cCSTCofins";
            idCSTIssDataGridViewTextBoxColumn.Tag = "FormStIss-vwStISS-ID_cCSTIss";
            idCSTPisDataGridViewTextBoxColumn.Tag = "FormStPIS-vwStPIS-ID_cCSTPis";
            idClassificacaoFiscalDataGridViewTextBoxColumn.Tag = "FormClassificacaoFiscal-vwClassificacaoFiscal-cNCM";
            idCSTIpi.Tag = "FormStIPI-vwStIPI-ID_cCSTIpi";
            idCodigoIcmsPaiDataGridViewTextBoxColumn.Tag = "FormCodigoIcms-vwCodigoIcmsPai-ID_cIcms";
            idCSTIcmsDataGridViewTextBoxColumn.Tag = "FormStICMS-vwSituacaoTributariaIcms-ID_cCSTIcms";

            idMotivoCanc.Tag = "-vwMotivoPerdaOrcam-ID_xMotivo";


            #region Atribuição de eventos
            cbxstOrcamento.cbx.SelectedIndexChanged += new EventHandler(SelectedIndex_Componentes);
            cbxidContato.cbx.SelectedIndexChanged += new EventHandler(SelectedIndex_Componentes);
            cbxStatusItens.cbx.SelectedIndexChanged += new EventHandler(SelectedIndex_Componentes);
            cbxStatusItensTotais.cbx.SelectedIndexChanged += new EventHandler(SelectedIndex_Componentes);
            nudpDescontoTotal.nud.Leave += new EventHandler(Leave_Componentes);
            nudvDescontoTotal.nud.Leave += new EventHandler(Leave_Componentes);
            txtCodigo.txt.TextChanged += new EventHandler(TextChanged_Componentes);
            #endregion

            InicializaFormPadrao("vwOrcamento");
            AddBotoesAtalho();
            cbxStatusItens.Enabled = cbxStatusItensTotais.Enabled = true;
            this.txtidOrcamentoOrigem.MaxLength = 50;
            VerifBw += (() =>
            {
                CarregaCombosGrid();
            });
            t1 = new Thread(new ThreadStart(VerifBw));
            t1.Start();
        }

        #region Operações básicas

        private void CarregaCombosGrid()
        {
            if (objMetodosForm == null)
            {
                Thread.Sleep(500);
                CarregaCombosGrid();
            }
            else
            {
                idOperacaoItens.DataSource = pesquisaPadraoService.GetData(objMetodosForm.GetDisplayMember(idOperacaoItens), true);
                clidProduto.DataSource = pesquisaPadraoService.GetData(objMetodosForm.GetDisplayMember(clidProduto), true);
                idListaPrecoPai.DataSource = pesquisaPadraoService.GetData(objMetodosForm.GetDisplayMember(idListaPrecoPai));
                idCfop.DataSource = pesquisaPadraoService.GetData(objMetodosForm.GetDisplayMember(idCfop), true);
                idDepositoDataGridViewTextBoxColumn.DataSource = pesquisaPadraoService.GetData(objMetodosForm.GetDisplayMember(idDepositoDataGridViewTextBoxColumn),
                    true);
                idSiteDataGridViewTextBoxColumn.DataSource = pesquisaPadraoService.GetData(objMetodosForm.GetDisplayMember(idSiteDataGridViewTextBoxColumn),
                    true);

                idCSTCofinsDataGridViewTextBoxColumn.DataSource = pesquisaPadraoService.GetData(objMetodosForm.GetDisplayMember(idCSTCofinsDataGridViewTextBoxColumn),
                    true);
                idCSTIssDataGridViewTextBoxColumn.DataSource = pesquisaPadraoService.GetData(objMetodosForm.GetDisplayMember(idCSTIssDataGridViewTextBoxColumn),
                    true);
                idCSTPisDataGridViewTextBoxColumn.DataSource = pesquisaPadraoService.GetData(objMetodosForm.GetDisplayMember(idCSTPisDataGridViewTextBoxColumn),
                    true);
                idClassificacaoFiscalDataGridViewTextBoxColumn.DataSource = pesquisaPadraoService.GetData(
                    objMetodosForm.GetDisplayMember(idClassificacaoFiscalDataGridViewTextBoxColumn), true);
                idCSTIpi.DataSource = pesquisaPadraoService.GetData(objMetodosForm.GetDisplayMember(idCSTIpi), true);
                idCodigoIcmsPaiDataGridViewTextBoxColumn.DataSource = pesquisaPadraoService.GetData(
                    objMetodosForm.GetDisplayMember(idCodigoIcmsPaiDataGridViewTextBoxColumn), true);
                idCSTIcmsDataGridViewTextBoxColumn.DataSource = pesquisaPadraoService.GetData(objMetodosForm.GetDisplayMember(idCSTIcmsDataGridViewTextBoxColumn),
                    true);
                idMotivoCanc.DataSource = pesquisaPadraoService.GetData(objMetodosForm.GetDisplayMember(column: idMotivoCanc),
                    true);

                if (this.iIdOrcamento != 0)
                {
                    BeginInvoke(new MethodInvoker(delegate
                        {
                            this.PopulaForm(idOrcamento: this.iIdOrcamento);
                            HabilitaBotoes(1);
                        }));
                }
                Thread.CurrentThread.Abort();
            }
        }
        public override void Novo()
        {
            try
            {
                base.Novo();
                cbxstOrcamento.SelectedIndex = 0;
                dtpdDataHora.Value = DateTime.Now;
                objOrcamento = new Orcamento_ideModel();
                this.camposBloqueados();
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
                    objOrcamento = orcamento_ideService.GetOrcamento_ide((int)lParaExcluir[i]);
                    orcamento_ideService.Delete(objOrcamento);
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
            orcamento_ideService.Delete(objOrcamento);
            base.Excluir();
            if (iRetPesquisa != null)
            {
                base.MoveProximoItem();
                PopulaForm((int)iRetPesquisa);
            }
        }
        public override void Atualizar()
        {
            if (orcamento_ideService.NodeTreeViewPossuiFilho(tree: this.treeViewOrcamento,
                valor: txtCodigo.Text))
            {
                MessageBox.Show(text: "Orçamento não pode ser alterado. " +
                    Environment.NewLine + "Motivo: Já foi gerada novas versões para este orçamento. Consulte Hierarquia de Orçamentos",
                    caption: "Atenção", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Exclamation);
                return;
            }
            base.Atualizar();
            this.camposBloqueados();
        }
        public override void Salvar()
        {
            try
            {
                this.Leave_Componentes(sender: dgvItens,
                    e: null);
                hlP_PesquisaidMotivo._Obrigatorio = Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
                bsItensOrcamento.DataSource = objOrcamento.LOrcamento_Itens.Where(i =>
                    i.GetStatusRegistro() != Comum.Infrastructure.BaseModelFilhos.statusRegistroFilho.Excluido).ToList();
                objValidaCampos.Validar();
                this.CalculaTotais(lOrcamentoTemp: objOrcamento.LOrcamento_Itens.Where(
                    i => i.stOrcamentoItem == 0 ||
                        i.stOrcamentoItem == 1).ToList());
                PopulaTabela();
                orcamento_ideService.Save(objOrcamento);

                txtCodigo.Text = objOrcamento.idOrcamento.ToString();
                base.Salvar();
                cbxStatusItens.Enabled = cbxStatusItensTotais.Enabled = true;
                this.SelectedIndex_Componentes(cbxStatusItens.cbx, null);
            }
            catch (Exception ex)
            {
                new HLPexception(ex, this);
            }
            finally
            {
                this.SelectedIndex_Componentes(sender: cbxStatusItens.cbx,
                    e: null);
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
                        PopulaForm(Convert.ToInt32(txtCodigo.Text));
                        HabilitaBotoes(1);
                    }
                    base.Cancelar();
                    this.SelectedIndex_Componentes(sender: cbxStatusItens, e: null);
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
                    PopulaForm(idOrcamento: (int)iRetPesquisa);
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
                    objMetodosForm.LimpaCampos();
                    HabilitaBotoes(1);
                    PopulaForm((int)iRetPesquisa);
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
                    PopulaForm((int)iRetPesquisa);
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
                orcamento_ideService.Copy(objOrcamento);
                PopulaForm((int)objOrcamento.idOrcamento);
                base.RegistroDuplicado(idOrigem, (int)objOrcamento.idOrcamento);
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
                cbxstOrcamento.SelectedIndex = orcamento_ideService.GetStatusOrcamento(
                    objOrcamento.LOrcamento_Itens);
                base.CarregaClasse(model: objOrcamento);
                base.CarregaClasse(objOrcamento.Orcamento_retTransp);
                base.CarregaClasse(objOrcamento.Orcamento_Total_Impostos);
                objOrcamento.idEmpresa = CompanyData.idEmpresa;
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }

        }
        private void PopulaForm(int idOrcamento)
        {
            try
            {
                objOrcamento = orcamento_ideService.GetOrcamento_ide(idOrcamento: idOrcamento);
                base.CarregaPropriedades(objOrcamento, true);
                base.CarregaPropriedades(objOrcamento.Orcamento_retTransp);
                base.CarregaPropriedades(objOrcamento.Orcamento_Total_Impostos);
                this.carregaContato_ClienteForn();
                base.CarregaForm();
                bsItensOrcamento.DataSource = objOrcamento.LOrcamento_Itens;
                this.CarregaDadosClienteForn();
                cbxStatusItens.Enabled = cbxStatusItensTotais.Enabled = true;
                tabControlPrincipal.SelectedTab = tabPagePrincipal;
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }

        #endregion

        #region Calculos

        private void CalculaTotais(List<Orcamento_ItemModel> lOrcamentoTemp)
        {
            try
            {
                nudvProdutoTotal.Value = orcamento_ideService.CalculaProdutoTotal(lOrcamento_ItemModel: lOrcamentoTemp);
                nudvServicoTotal.Value = orcamento_ideService.CalculaServicoTotal(lOrcamento_ItemModel: lOrcamentoTemp);
                nudvDescontoTotal.Value = orcamento_ideService.CalculaDescontoTotal(lOrcamento_ItemModel: lOrcamentoTemp);
                nudpDescontoTotal.Value = orcamento_ideService.CalculaPorcDescontoTotal(
                    vDescontoTotal: nudvDescontoTotal.Value, vProdutosTotal: lOrcamentoTemp.Sum(i => i.vTotalSemDescontoItem));
                nudvDescontoSuframaTotal.Value = lOrcamentoTemp.Sum(i => i.vDescontoSuframa) ?? 0;
                nudvFreteTotal.Value = lOrcamentoTemp.Sum(i => i.vFreteItem);
                nudvSeguroTotal.Value = lOrcamentoTemp.Sum(i => i.vSegurosItem);
                nudvOutrasDespesasTotal.Value = lOrcamentoTemp.Sum(i => i.vOutrasDespesasItem);
                nudvBaseCalculoIcmsTotal.Value = lOrcamentoTemp.Sum(i => i.Orcamento_Item_Impostos.ICMS_vBaseCalculo) ?? 0;
                nudvIcmsTotal.Value = lOrcamentoTemp.Sum(i => i.Orcamento_Item_Impostos.ICMS_vICMS) ?? 0;
                nudvBaseCalculoIcmsProprioTotal.Value = lOrcamentoTemp.Sum(i => i.Orcamento_Item_Impostos.ICMS_vBaseCalculoIcmsProprio) ?? 0;
                nudvIcmsProprioTotal.Value = lOrcamentoTemp.Sum(i => i.Orcamento_Item_Impostos.ICMS_vIcmsProprio) ?? 0;
                nudvBaseCalculoIpiTotal.Value = lOrcamentoTemp.Sum(i => i.Orcamento_Item_Impostos.IPI_vBaseCalculo) ?? 0;
                nudvIPITotal.Value = lOrcamentoTemp.Sum(i => i.Orcamento_Item_Impostos.IPI_vIPI) ?? 0;
                nudvBaseCalculoICmsSubstituicaoTributariaTotal.Value = lOrcamentoTemp.Sum(i => i.Orcamento_Item_Impostos.ICMS_vBaseCalculoSubstituicaoTributaria) ?? 0;
                nudvIcmsSubstituicaoTributariaTotal.Value = lOrcamentoTemp.Sum(i => i.Orcamento_Item_Impostos.ICMS_vSubstituicaoTributaria) ?? 0;
                this.CalculaTotalOrcamento();
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }

        }

        private void CalculaTotalOrcamento()
        {
            nudvTotal.Value = orcamento_ideService.CalculaTotalOrcamento(vProdutoTotal: nudvProdutoTotal.Value,
                vServicoTotal: nudvServicoTotal.Value, vIpiTotal: nudvIPITotal.Value, vIcmsSubsTributaria: nudvIcmsSubstituicaoTributariaTotal.Value,
                vSeguroTotal: nudvSeguroTotal.Value, vOutrasDespesasTotal: nudvOutrasDespesasTotal.Value, vDescontoTotal: nudvDescontoTotal.Value,
                vDescontoSuframaTotal: nudvDescontoSuframaTotal.Value);
        }

        private void CalculaPesosTotais()
        {
            nudvPesoLiquido.Value = orcamento_ideService.CalculaPesoLiquido(lOrcamento_ItemModel:
                objOrcamento.LOrcamento_Itens);
            nudvPesoBruto.Value = orcamento_ideService.CalculaPesoBruto(lOrcamento_ItemModel:
                objOrcamento.LOrcamento_Itens);
        }

        #endregion

        #region Popula objetos

        private void GetComissao()
        {
            object o = null;
            if (bsItensOrcamento.Current == null)
                return;

            if ((bsItensOrcamento.Current as Orcamento_ItemModel).idFuncionarioRepresentante == 0
                || (bsItensOrcamento.Current as Orcamento_ItemModel).idFuncionarioRepresentante == null
                || lListaPreco == null)
                return;

            switch (orcamento_ideService.GetTipoComissao(bsItensOrcamento.Current as Orcamento_ItemModel))
            {
                case 0:
                    {
                        o = orcamento_ideService.GetInformacoesFuncionario(idFuncionario:
                            (int)((Orcamento_ItemModel)bsItensOrcamento.Current).idFuncionarioRepresentante);
                    }
                    break;
                case 1:
                    {
                        o = lListaPreco.FirstOrDefault(i => i.idProduto ==
                            ((Orcamento_ItemModel)bsItensOrcamento.Current).idProduto);
                    }
                    break;
                case 2:
                    {
                        o = orcamento_ideService.GetFamiliaProduto(idFamilia_produto:
                            orcamento_ideService.GetInformacoesProduto(idProduto:
                            ((Orcamento_ItemModel)bsItensOrcamento.Current).idProduto).idFamiliaProduto);
                    }
                    break;
                case 3:
                    {
                        o = (orcamento_ideService.GetInformacoesFuncionario(idFuncionario:
                            (int)((Orcamento_ItemModel)bsItensOrcamento.Current).idFuncionarioRepresentante)
                            .lFuncionario_Comissao_Produto).FirstOrDefault((i => i.idProduto ==
                                ((Orcamento_ItemModel)bsItensOrcamento.Current).idProduto));
                    }
                    break;
                case 4:
                    {
                        o = orcamento_ideService.GetInformacoesFuncionario(idFuncionario:
                            (int)((Orcamento_ItemModel)bsItensOrcamento.Current).idFuncionarioRepresentante).
                            lFuncionario_Margem_Lucro_Comissao;
                    }
                    break;
            }

            if (o != null)
                orcamento_ideService.GetComissao(idCondicao_Pagamento: hlP_PesquisaidCondicaoPagamento.Value,
                                itemModel: bsItensOrcamento.Current as Orcamento_ItemModel,
                                objeto: o);
        }
        private void CarregaListaPreco(int idListaPrecoPai)
        {
            lListaPreco = new List<Lista_precoModel>();
            lListaPreco = orcamento_ideService.GetListaPrecoOrcamento(idListaPrecoPai: idListaPrecoPai);
        }
        private void CarregaUnidMedProdutos()
        {
            try
            {
                foreach (DataGridViewRow r in dgvItens.Rows)
                {
                    if (dgvItens[clidProduto.Index,
                        r.Index].Value == null)
                        return;
                    orcamento_ideService.CarregaUnidMedProdutos(idProduto: (int)dgvItens[clidProduto.Index,
                        r.Index].Value, cellDgv: (dgvItens[idUnidadeMedida.Index, r.Index] as DataGridViewComboBoxCell));

                    dgvItens[clidProduto.Index, r.Index].Value = dgvItens[clidProduto.Index, r.Index].Value;
                }
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }
        private void CarregaDadosClienteForn()
        {
            objCliente = new Cliente_fornecedorModel();
            objCliente_endereco = new Cliente_fornecedor_EnderecoModel();
            objCidade = new CidadeModel();
            objUf = new UFModel();
            objCliente_representante = new Cliente_fornecedor_representanteModel();

            objCliente = orcamento_ideService.GetClienteFornOrcamento((int)hlP_PesquisaidClienteFornecedor.Value);
            //Limpar valores dos componentes antes de preenche-los com os objetos            
            LimparComponentePesquisa(hlP_PesquisaidRamoAtividade, hlP_PesquisaidCondicaoPagamento,
                hlP_PesquisaidFuncionarioRepresentante, hlP_PesquisaxCanalVenda);
            cbxstContribuienteIcms.SelectedIndex = -1;
            cbxidContato.cbx.DataSource = null;
            cbxidContato.cbx.Items.Clear();

            if (objCliente != null)
            {
                cbxstContribuienteIcms.SelectedIndex = objCliente.cliforFiscalModel.stContribuienteIcms;
                hlP_PesquisaidRamoAtividade.Value = objCliente.idRamoAtividade;
                hlP_PesquisaidCondicaoPagamento.Value = objCliente.idCondicaoPagamento;
                hlP_PesquisaxCanalVenda.Value = objCliente.idCanalVenda;
                idListaPrecoPai.ReadOnly = objCliente.stObrigaListaPreco == 1;

                objCliente_representante =
                    orcamento_ideService.GetClienteFornRepresentante(idClienteFornecedor: (int)hlP_PesquisaidClienteFornecedor.Value);

                if (objCliente_representante != null)
                    hlP_PesquisaidFuncionarioRepresentante.Value = objCliente_representante.idFuncionario;

                try
                {
                    this.carregaContato_ClienteForn();

                    objCliente_endereco = orcamento_ideService.GetClienteForn_EnderecoOrcamento(
                        idClienteFornecedor: hlP_PesquisaidClienteFornecedor.Value);

                    if (objCliente_endereco != null)
                    {
                        objCidade = orcamento_ideService.GetCidadeClienteForn_Orcamento(
                            idCidade: objCliente_endereco.idCidade);
                        objUf = orcamento_ideService.GetUfByCidadeClienteForn_Orcamento(idCidade: (int)objCidade.idCidade);
                    }
                    txtCidade.txt.Text = objCidade.xCidade ?? "";
                    txtUF.txt.Text = objUf.xUf ?? "";
                }
                catch (Exception ex)
                {
                    new HLPexception(ex);
                }
                cbxidContato.Focus();
            }
        }
        private void carregaContato_ClienteForn()
        {
            cbxidContato.DataSource = orcamento_ideService.GetContatosByClienteForn(
                idClienteForn: hlP_PesquisaidClienteFornecedor.Value != 0 ?
                hlP_PesquisaidClienteFornecedor.Value : objOrcamento.idClienteFornecedor);
            cbxidContato.DisplayMember = "xNome";
            cbxidContato.ValueMember = "idContato";
        }

        #endregion

        #region Validação

        private void ValidaDescontos()
        {
            try
            {
                decimal vDescontoItens = orcamento_ideService.CalculaDescontoTotal(
                    lOrcamento_ItemModel: objOrcamento.LOrcamento_Itens.Where(i => i.stOrcamentoItem == 0 ||
                    i.stOrcamentoItem == 1).ToList());
                if (vDescontoItens != nudvDescontoTotal.Value)
                {
                    if (MessageBox.Show("Valor da soma do desconto dos itens difere do valor total dos descontos. " +
                        Environment.NewLine + "Valor desconto: " + nudvDescontoTotal.Value.ToString() +
                        Environment.NewLine + "Valor total de desconto nos itens: " + vDescontoItens.ToString() +
                        Environment.NewLine + "Deseja que o sistema realize rateio do valor total dos descontos nos itens?",
                        "Atenção!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                    {
                        lItemPorcAcimaListaModel = new List<ItemPorcAcimaListaModel>();
                        orcamento_ideService.ValidaPorcListaPrecoLista(lOrcamento_item: objOrcamento.LOrcamento_Itens
                            .Where(i => i.stOrcamentoItem == 0 || i.stOrcamentoItem == 1).ToList(),
                            porDescAcrTotal: nudvDescontoTotal.Value, lItensPorcAcimaLista: lItemPorcAcimaListaModel);
                        if (lItemPorcAcimaListaModel.Count > 0)
                        {
                            formItensPorcAcimaLista frmItensPorcAcimaLista =
                                new formItensPorcAcimaLista(lItemPorcAcimaListaModel: lItemPorcAcimaListaModel);
                            DataRow dr = null;

                            foreach (ItemPorcAcimaListaModel item in lItemPorcAcimaListaModel)
                            {
                                dr = (clidProduto.DataSource as DataTable).AsEnumerable().FirstOrDefault(c =>
                                    c[clidProduto.DataPropertyName].ToString() == item.idProduto.ToString());
                                item.xNomeProduto = dr["DISPLAY"].ToString();
                            }


                            if (frmItensPorcAcimaLista.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                            {
                                throw new Exception("Operação cancelada pelo supervisor");
                            }
                        }
                        orcamento_ideService.RateiaValorTotalNosItens(vTotal: nudvDescontoTotal.Value,
                            lOrcamento_ItemModel: objOrcamento.LOrcamento_Itens.Where(
                            i => i.stOrcamentoItem == 0 || i.stOrcamentoItem == 1).ToList(),
                            iPropCalculo: PropriedadeCalculo.descontoTotal);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CalculaTotalOrcamento();
            }
        }


        #endregion

        #region Operações específicas

        private void camposBloqueados()
        {
            txtidOrcamentoOrigem.Enabled = dtpdDataHora.Enabled = txtCidade.Enabled =
                txtUF.Enabled = maskTelefoneCliente.Enabled = hlP_PesquisaidMotivo.Enabled =
            hlP_PesquisaidFuncionarioResponsavel.Enabled = hlP_PesquisaxCanalVenda.Enabled = false;
            nudvProdutoTotal.Enabled = nudvServicoTotal.Enabled = nudvBaseCalculoIcmsTotal.Enabled = nudvIcmsTotal.Enabled =
            nudvBaseCalculoIcmsProprioTotal.Enabled = nudvIcmsProprioTotal.Enabled =
            nudvBaseCalculoIpiTotal.Enabled = nudvIPITotal.Enabled = nudvBaseCalculoICmsSubstituicaoTributariaTotal.Enabled =
            nudvIcmsSubstituicaoTributariaTotal.Enabled =
            nudvTotal.Enabled = nudvBaseCalculoPisTotal.Enabled = nudvPisTotal.Enabled = nudvBaseCalculoCofinsTotal.Enabled = nudvCofinsTotal.Enabled =
            nudvBaseCalculoIssTotal.Enabled = nudvIssTotal.Enabled = false;
            nudpDescontoTotal.Enabled = nudvDescontoTotal.Enabled = !(orcamento_ideService.IsNfSuframa(
                idTipoDocumento: hlP_PesquisaidTipoDocumento.Value));
        }
        private void LimparComponentePesquisa(params HLP.Comum.Components.HLP_Pesquisa[] ctrs)
        {
            foreach (HLP.Comum.Components.HLP_Pesquisa ctr in ctrs)
            {
                ((HLP.Comum.Components.HLP_Pesquisa)ctr).Value = 0;
                ((HLP.Comum.Components.HLP_Pesquisa)ctr).txtPesquisa.Text = "";
                ((HLP.Comum.Components.HLP_Pesquisa)ctr).txtDisplay.Text = "";
            }

        }
        private void AddBotoesAtalho()
        {
            btnStatus = new KryptonButton();
            btnStatus.Name = "btnStatus";
            btnStatus.Text = "Status";
            btnStatus.ContextMenuStrip = ctxMenuBtnSt;
            btnStatus.MouseUp += new MouseEventHandler(MouseUp_Componentes);

            btnVersao = new KryptonButton();
            btnVersao.Name = "btnVersao";
            btnVersao.Text = "Versão";
            btnVersao.ContextMenuStrip = ctxMenuBtnVs;
            btnVersao.MouseUp += new MouseEventHandler(MouseUp_Componentes);

            btnConsulta = new KryptonButton(); btnConsulta.Name = "btnConsulta";
            btnConsulta.Text = "Consulta";
            btnConsulta.ContextMenuStrip = ctxMenuBtnConsulta;
            btnConsulta.MouseUp += new MouseEventHandler(MouseUp_Componentes);

            base.AddAtalhosPanel(botoes: new KryptonButton[] { btnStatus, btnVersao, btnConsulta });
        }
        private void SetXversao()
        {
            if (txtCodigo.Text == "")
                return;
            string xVersao = orcamento_ideService.GetVersaoByOrigem(idOrcamento: txtCodigo.Text.ToInt32());
            this.txtidOrcamentoOrigem.MaxLength = xVersao.Count() + 5;
            txtidOrcamentoOrigem.Text = xVersao;
        }
        private void OrganizaDgvItens()
        {
            idMotivoCanc.Visible = cbxStatusItens.SelectedIndex == 4
                || cbxStatusItens.SelectedIndex == 5;
        }

        #endregion

        #region Eventos
        #region Eventos de componentes
        private void SelectedIndex_Componentes(object sender, EventArgs e)
        {
            if (sender.Equals(obj: cbxstOrcamento.cbx))
            {
                switch (cbxstOrcamento.SelectedIndex)
                {
                    case 4:
                    case 5: hlP_PesquisaidMotivo.Enabled = true; break;
                    default: hlP_PesquisaidMotivo.Enabled = false; break;
                }
            }
            else if (sender.Equals(obj: cbxidContato.cbx))
            {
                if (cbxidContato.cbx.SelectedItem != null && cbxidContato.cbx.ValueMember != "ValueMember")
                {
                    objContato = new ContatoModel();
                    objContato = orcamento_ideService.GetInformacoesContato(
                    idContato: (int)cbxidContato.cbx.SelectedValue);
                    txtxDepartamento.txt.Text = objContato.xDepartamento ?? "";
                }
            }
            else if (sender.Equals(obj: cbxStatusItens.cbx))
            {
                if (btnSalvar.Enabled)
                {
                    dgvFiscal.ReadOnly = dgvItens.ReadOnly = cbxStatusItens.SelectedIndex != 0 && cbxStatusItens.SelectedIndex != 1;
                    dgvItens.AllowUserToAddRows = cbxStatusItens.SelectedIndex == 0;
                }
                if (objOrcamento == null)
                    return;

                switch (cbxStatusItens.SelectedIndex)
                {
                    case 0:
                        {
                            bsItensOrcamento.DataSource = this.objOrcamento.LOrcamento_Itens.Where(
                                i => i.stOrcamentoItem == 0).ToList();
                        } break;
                    case 1:
                        {
                            bsItensOrcamento.DataSource = this.objOrcamento.LOrcamento_Itens.Where(
                                i => i.stOrcamentoItem == 1).ToList();
                        } break;
                    case 2:
                        {
                            bsItensOrcamento.DataSource = this.objOrcamento.LOrcamento_Itens.Where(
                                i => i.stOrcamentoItem == 2).ToList();
                        } break;
                    case 3:
                        {
                            bsItensOrcamento.DataSource = this.objOrcamento.LOrcamento_Itens.Where(
                                i => i.stOrcamentoItem == 3).ToList();
                        } break;
                    case 4:
                        {
                            bsItensOrcamento.DataSource = this.objOrcamento.LOrcamento_Itens.Where(
                                i => i.stOrcamentoItem == 4).ToList();
                        } break;
                }
                this.OrganizaDgvItens();
            }
            else if (sender.Equals(cbxStatusItensTotais.cbx))
            {
                nudvDescontoTotal.Enabled = nudpDescontoTotal.Enabled = nudvDescontoSuframaTotal.Enabled =
                    nudvFreteTotal.Enabled = nudvSeguroTotal.Enabled = nudvOutrasDespesasTotal.Enabled =
                    (cbxStatusItensTotais.SelectedIndex == 0 ||
                    cbxStatusItensTotais.SelectedIndex == 1) && btnSalvar.Enabled;

                this.CalculaTotais(lOrcamentoTemp: objOrcamento.LOrcamento_Itens.Where(
                    i => i.stOrcamentoItem == cbxStatusItensTotais.SelectedIndex).ToList());
            }
        }
        private void Leave_Componentes(object sender, EventArgs e)
        {
            if (sender.Equals(obj: nudvOutrasDespesasTotal.nud))
            {
                try
                {
                    if (objOrcamento.LOrcamento_Itens.Sum(i => i.vOutrasDespesasItem)
                        != nudvOutrasDespesasTotal.Value)
                    {
                        if (MessageBox.Show("Valor da soma de outras despesas dos itens difere do valor total de outras despesas. " +
                            Environment.NewLine + "Valor outras despesas: " + nudvOutrasDespesasTotal.Value.ToString() +
                            Environment.NewLine + "Valor total de outras despesas nos itens: "
                            + objOrcamento.LOrcamento_Itens.Sum(i => i.vOutrasDespesasItem).ToString() +
                            Environment.NewLine + "Deseja que o sistema realize rateio do valor de outras despesas nos itens?",
                            "Atenção!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                        {
                            orcamento_ideService.RateiaValorTotalNosItens(vTotal: nudvOutrasDespesasTotal.Value,
                                lOrcamento_ItemModel: objOrcamento.LOrcamento_Itens,
                                iPropCalculo: PropriedadeCalculo.outrasDespesasTotal);
                        }
                    }
                }
                catch (Exception ex)
                {
                    new HLPexception(ex);
                }
                finally
                {
                    this.CalculaTotalOrcamento();
                }
            }
            else if (sender.Equals(obj: nudvDescontoSuframaTotal.nud))
            {
                this.CalculaTotalOrcamento();
            }
            else if (sender.Equals(obj: nudpDescontoTotal.nud))
            {
                try
                {
                    nudvDescontoTotal.Value = objOrcamento.LOrcamento_Itens
                        .Where(i => i.stOrcamentoItem == 0 || i.stOrcamentoItem == 1).ToList()
                        .Sum(i => i.vTotalSemDescontoItem) * (nudpDescontoTotal.Value / 100);
                    this.ValidaDescontos();
                }
                catch (Exception ex)
                {
                    new HLPexception(ex);
                }
            }
            else if (sender.Equals(obj: nudvFreteTotal))
            {
                try
                {
                    if (objOrcamento.LOrcamento_Itens.Sum(i => i.vFreteItem)
                        != nudvFreteTotal.Value)
                    {
                        if (MessageBox.Show("Valor da soma do frete dos itens difere do valor total do frete. " +
                            Environment.NewLine + "Valor frete: " + nudvFreteTotal.Value.ToString() +
                            Environment.NewLine + "Valor total de frete nos itens: " + objOrcamento.LOrcamento_Itens.Sum(i => i.vFreteItem).ToString() +
                            Environment.NewLine + "Deseja que o sistema realize rateio do valor total do frete nos itens?",
                            "Atenção!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                        {
                            orcamento_ideService.RateiaValorTotalNosItens(vTotal: nudvFreteTotal.Value,
                                lOrcamento_ItemModel: objOrcamento.LOrcamento_Itens,
                                iPropCalculo: PropriedadeCalculo.freteTotal);
                        }
                    }
                }
                catch (Exception ex)
                {
                    new HLPexception(ex);
                }
                finally
                {
                    this.CalculaTotalOrcamento();
                }
            }
            else if (sender.Equals(obj: nudvDescontoTotal.nud))
            {
                try
                {
                    nudpDescontoTotal.Value = orcamento_ideService.CalculaPorcDescontoTotal(vDescontoTotal: nudvDescontoTotal.Value,
                        vProdutosTotal: objOrcamento.LOrcamento_Itens.Sum(i => i.vTotalSemDescontoItem));
                    this.ValidaDescontos();
                }
                catch (Exception ex)
                {
                    new HLPexception(ex);
                }
            }
            else if (sender.Equals(obj: nudvSeguroTotal))
            {
                try
                {
                    if (objOrcamento.LOrcamento_Itens.Sum(i => i.vSegurosItem)
                        != nudvSeguroTotal.Value)
                    {
                        if (MessageBox.Show("Valor da soma do seguro dos itens difere do valor total do seguro. " +
                            Environment.NewLine + "Valor seguro: " + nudvSeguroTotal.Value.ToString() +
                            Environment.NewLine + "Valor total de seguro nos itens: " + objOrcamento.LOrcamento_Itens.Sum(i => i.vSegurosItem).ToString() +
                            Environment.NewLine + "Deseja que o sistema realize rateio do valor total do seguro nos itens?",
                            "Atenção!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                        {
                            orcamento_ideService.RateiaValorTotalNosItens(vTotal: nudvSeguroTotal.Value,
                                lOrcamento_ItemModel: objOrcamento.LOrcamento_Itens,
                                iPropCalculo: PropriedadeCalculo.seguroTotal);
                        }
                    }
                }
                catch (Exception ex)
                {
                    new HLPexception(ex);
                }
                finally
                {
                    this.CalculaTotalOrcamento();
                }
            }
            else if (sender.Equals(dgvItens))
            {
                List<Orcamento_ItemModel> lOrcamentoModel = new List<Orcamento_ItemModel>();
                if (objOrcamento.LOrcamento_Itens.Count > 0)
                {
                    lOrcamentoModel = (bsItensOrcamento.List as List<Orcamento_ItemModel>)
                        .Where(i => i.GetStatusRegistro()
                            == Comum.Infrastructure.BaseModelFilhos.statusRegistroFilho.Incluido).ToList()
                        .Where(i => i.idItem != 0).ToList()
                        .Where(i => !objOrcamento.LOrcamento_Itens.Exists(o => o.idItem == i.idItem)).ToList();
                }
                else
                {
                    lOrcamentoModel = (bsItensOrcamento.List as List<Orcamento_ItemModel>)
                        .Where(i => i.GetStatusRegistro()
                            == Comum.Infrastructure.BaseModelFilhos.statusRegistroFilho.Incluido).ToList();
                }
                objOrcamento.LOrcamento_Itens.AddRange(lOrcamentoModel);
            }
        }
        private void Enter_Componentes(object sender, EventArgs e)
        {
            if (sender.Equals(obj: tabPageBaseCalculo))
            {
                if (cbxStatusItensTotais.SelectedIndex == -1)
                    cbxStatusItensTotais.SelectedIndex = 0;

                this.SelectedIndex_Componentes(cbxStatusItensTotais.cbx, null);
            }
            else if (sender.Equals(obj: tabPageTransportes))
            {
                if (btnSalvar.Enabled)
                {
                    Tipo_documentoModel objTipo_documento = null;

                    objTipo_documento = orcamento_ideService.GetInfTipoDocumento(idTipoDocumento: hlP_PesquisaidTipoDocumento.Value);
                    txtxEspecieVolumeNf.txt.Text = objTipo_documento.xEspecieVolumeNf;
                    txtxMarcaVolumeNf.txt.Text = objTipo_documento.xMarcaVolumeNf;

                    CalculaPesosTotais();
                }
            }
            else if (sender.Equals(obj: tabPageItens))
            {
                if (cbxStatusItens.SelectedIndex == -1)
                    cbxStatusItens.SelectedIndex = 0;
                dgvFiscal.AllowUserToAddRows = false;
            }
        }
        private void Validated_Componentes(object sender, EventArgs e)
        {
            if (sender.Equals(obj: hlP_PesquisaidClienteFornecedor))
            {
                CarregaDadosClienteForn();
            }
            else if (sender.Equals(obj: hlP_PesquisaidFuncionario))
            {
                LimparComponentePesquisa(hlP_PesquisaidFuncionarioResponsavel);
                objFuncionario = new FuncionarioModel();
                objFuncionario = orcamento_ideService.GetInformacoesFuncionario(
                    idFuncionario: hlP_PesquisaidFuncionario.Value);

                if (objFuncionario != null)
                {
                    hlP_PesquisaidFuncionarioResponsavel.Value = (int)objFuncionario.idResponsavel;
                    hlP_PesquisaidUnidadeVenda.Focus();
                }
            }
        }
        private void Current_Changed_Componentes(object sender, EventArgs e)
        {
            if (sender is BindingSource)
            {

                if (sender.Equals(bsItensOrcamento))
                {
                    if (bsItensOrcamento.Current != null)
                    {
                        bsFiscal.DataSource = (bsItensOrcamento.Current as Orcamento_ItemModel).Orcamento_Item_Impostos;
                    }
                    else
                    {
                        bsFiscal.DataSource = null;
                    }
                }
            }
        }
        private void DataSourceChanged(object sender, EventArgs e)
        {
            if (sender is BindingSource)
            {
                if (sender.Equals(bsItensOrcamento))
                    this.CarregaUnidMedProdutos();
            }
        }
        private void ValueChanged_Componentes(object sender, EventArgs e)
        {
        }
        private void MouseUp_Componentes(object sender, MouseEventArgs e)
        {
            Point p = new Point(x: Form.MousePosition.X - ctxMenuBtnSt.Width,
                        y: Form.MousePosition.Y);
            if (sender.Equals(obj: btnStatus))
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    ctxMenuBtnSt.Show(screenLocation: p);
                }
            }
            else if (sender.Equals(obj: btnVersao))
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    ctxMenuBtnVs.Show(screenLocation: p);
                }
            }
            else if (sender.Equals(obj: btnConsulta))
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    ctxMenuBtnConsulta.Show(screenLocation: p);
                }
            }
        }
        private void ItemClicked_MenuStripComponentes(object sender, ToolStripItemClickedEventArgs e)
        {
            if (sender.Equals(obj: ctxMenuBtnSt))
            {
                if (this.bsItensOrcamento.List.Count == 0)
                {
                    MessageBox.Show("Não há itens na lista de itens de orçamento", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (!btnSalvar.Enabled)
                {
                    MessageBox.Show("Necessário que cadastro esteja em edição", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                TipoSituacao tpSit;
                if (e.ClickedItem.Equals(obj: menuItemEnviar))
                {
                    tpSit = TipoSituacao.enviado;
                }
                else if (e.ClickedItem.Equals(obj: menuItemConfirmar))
                {
                    tpSit = TipoSituacao.confirmado;
                }
                else if (e.ClickedItem.Equals(obj: menuItemPerdido))
                {
                    tpSit = TipoSituacao.perdido;
                }
                else
                {
                    tpSit = TipoSituacao.cancelado;
                }
                formStItens frmStItens = new formStItens(tpSt: tpSit,
                    lItens: objOrcamento.LOrcamento_Itens,
                    clProdutos: this.clidProduto, clIdMotivo: this.idMotivoCanc);
                frmStItens.ShowDialog();
                foreach (Orcamento_ItemModel orc_item in objOrcamento.LOrcamento_Itens
                    .Where(i => i.GetStatusRegistro() == Comum.Infrastructure.BaseModelFilhos.statusRegistroFilho.Alterado ||
                    i.GetStatusRegistro() == Comum.Infrastructure.BaseModelFilhos.statusRegistroFilho.Incluido).ToList())
                {
                    orcamento_ideService.PopulaObjetoItem(objOrcamento_Item: orc_item,
                        objOrcamento_ide: objOrcamento, stCalculoPrincipal: CalculoDescontoPrincipal.porPorcentagem);
                }

                this.SelectedIndex_Componentes(cbxStatusItens.cbx, null);
            }
            else if (sender.Equals(obj: ctxMenuBtnVs))
            {
                if (e.ClickedItem.Equals(obj: menuItemGeraVersao))
                {
                    if (btnSalvar.Enabled)
                    {
                        MessageBox.Show(text: "Para que seja gerada nova versão o cadastro não pode estar em edição.",
                            caption: "Atenção!", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Exclamation);
                        return;
                    }
                    if (this.objOrcamento.idOrcamento == null)
                    {
                        MessageBox.Show(text: "Não há orçamento selecionado para cópia.",
                            caption: "Atenção!", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Exclamation);
                        return;
                    }
                    orcamento_ideService.Copy(objOrcamento_ide: this.objOrcamento);
                    PopulaForm((int)objOrcamento.idOrcamento);
                }
                else if (e.ClickedItem.Equals(obj: menuItemChecarVersao))
                {
                    formOrcamentoVenda frm = new formOrcamentoVenda(0);
                    frm.ShowDialog();
                }
            }
            else if (sender.Equals(obj: ctxMenuBtnConsulta))
            {
                if (e.ClickedItem.Equals(obj: menuItemEstoque))
                {
                    if (!(bsItensOrcamento.Count > 0))
                    {
                        MessageBox.Show(text: "Não há itens no orçamento.",
                            caption: "Atenção!", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Exclamation);
                        return;
                    }

                    List<stItensModel> lItens = (from l in objOrcamento.LOrcamento_Itens.Where(
                                                i => i.stOrcamentoItem == 0 ||
                                                    i.stOrcamentoItem == 1).ToList()
                                                 select (new stItensModel
                                                 {
                                                     codItem = l.idProduto,
                                                     quantPendente = l.qProduto,

                                                 })).ToList();

                    formEstoqueItensOrcamento frmEstoqueItensOrc = new formEstoqueItensOrcamento(
                        lItens: lItens, clProdutos: this.clidProduto);
                    frmEstoqueItensOrc.ShowDialog();
                }
            }
        }
        private void Node_MouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (sender.Equals(obj: treeViewOrcamento))
            {
                if (e.Node.Tag.ToString() == txtCodigo.Text)
                {
                    MessageBox.Show(text: "Orçamento selecionado é o orçamento atual",
                        caption: "Atenção", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Exclamation);
                    return;
                }

                formOrcamentoVenda frm = new formOrcamentoVenda(idOrcamento: Convert.ToInt32(value: e.Node.Tag));
                frm.WindowState = FormWindowState.Maximized;
                frm.ShowDialog();
            }
        }
        private void TextChanged_Componentes(object sender, EventArgs e)
        {
            if (sender.Equals(txtCodigo.txt))
            {
                this.SetXversao();
                try
                {
                    if (txtCodigo.Text != "")
                    {
                        orcamento_ideService.CarregaTreeViewOrcamentos(idOrcamento: txtCodigo.Text.ToInt32(),
                        tree: this.treeViewOrcamento);
                        orcamento_ideService.DestacarNodeTreeView(tree: this.treeViewOrcamento,
                            valor: txtCodigo.Text);
                        treeViewOrcamento.ExpandAll();
                    }
                }
                catch (Exception ex)
                {
                    new HLPexception(ex: ex);
                }
            }
        }
        #endregion

        #region Eventos de grids
        private void CellValidated_ComponentesGrids(object sender, DataGridViewCellEventArgs e)
        {
            string sSender = (sender as HLP.Comum.Components.HLP_DataGridView).Name.ToString();

            if (sSender == dgvItens.Name.ToString())
            {
                try
                {
                    if (e.ColumnIndex == idOperacaoItens.Index)
                    {
                        try
                        {
                            (bsItensOrcamento.Current as Orcamento_ItemModel).idCfop =
                                (int)orcamento_ideService.GetCfopByOperacao((bsItensOrcamento.Current as Orcamento_ItemModel).idTipoOperacao,
                            hlP_PesquisaidClienteFornecedor.Value);
                        }
                        catch (Exception ex)
                        {
                            new HLPexception(ex);
                        }
                    }
                    else if (e.ColumnIndex == vVendaDataGridViewTextBoxColumn.Index ||
                    e.ColumnIndex == qProdutoDataGridViewTextBoxColumn.Index ||
                    e.ColumnIndex == vDescontoDataGridViewTextBoxColumn.Index ||
                    e.ColumnIndex == pDescontoDataGridViewTextBoxColumn.Index ||
                        e.ColumnIndex == clidProduto.Index)
                    {
                        try
                        {
                            orcamento_ideService.PopulaObjetoItem(objOrcamento_Item: bsItensOrcamento.Current as Orcamento_ItemModel,
                                objOrcamento_ide: base.CarregaClasse(model: objOrcamento) as Orcamento_ideModel,
                                stCalculoPrincipal: e.ColumnIndex == vDescontoDataGridViewTextBoxColumn.Index ?
                                CalculoDescontoPrincipal.porValor : CalculoDescontoPrincipal.porPorcentagem);
                        }
                        catch (Exception ex)
                        {
                            new HLPexception(ex);
                        }
                    }
                }
                catch (Exception ex)
                {
                    new HLPexception(ex);
                }
            }
        }
        private void CellValidating_ComponentesGrids(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string sSender = (sender as HLP.Comum.Components.HLP_DataGridView).Name.ToString();

            if (sSender == dgvItens.Name.ToString())
            {
                if (e.ColumnIndex == pDescontoDataGridViewTextBoxColumn.Index ||
                e.ColumnIndex == vDescontoDataGridViewTextBoxColumn.Index ||
                e.ColumnIndex == vVendaDataGridViewTextBoxColumn.Index)
                {
                    try
                    {
                        if ((bsItensOrcamento.Current as Orcamento_ItemModel).vTotalSemDescontoItem == 0)
                            return;

                        if (Decimal.Round((bsItensOrcamento.Current as Orcamento_ItemModel).pDesconto, numCasasDecimaisPorc) ==
                            Decimal.Round(Convert.ToDecimal(e.FormattedValue), numCasasDecimaisPorc))
                            return;

                        if (Decimal.Round((bsItensOrcamento.Current as Orcamento_ItemModel).vDesconto, numCasasDecimaisValor) ==
                            Decimal.Round(Convert.ToDecimal(e.FormattedValue), numCasasDecimaisValor))
                            return;

                        if (Decimal.Round((bsItensOrcamento.Current as Orcamento_ItemModel).vVenda, numCasasDecimaisValor) ==
                            Decimal.Round(Convert.ToDecimal(e.FormattedValue), numCasasDecimaisValor))
                            return;

                        lItemPorcAcimaListaModel = new List<ItemPorcAcimaListaModel>();
                        decimal porDescAcr = e.ColumnIndex == vDescontoDataGridViewTextBoxColumn.Index ?
                            (100 * Convert.ToDecimal(e.FormattedValue)) / (bsItensOrcamento.Current as Orcamento_ItemModel).vTotalSemDescontoItem :
                            (bsItensOrcamento.Current as Orcamento_ItemModel).pDesconto;
                        orcamento_ideService.ValidaPorcListaPrecoItem(objOrcamento_item: (bsItensOrcamento.Current as Orcamento_ItemModel),
                            porDescAcr: porDescAcr,
                            lItensPorcAcimaLista: lItemPorcAcimaListaModel);
                        if (lItemPorcAcimaListaModel.Count > 0)
                        {
                            if (MessageBox.Show("Porcentagem informada ultrapassa porcentagem permitida na lista de preço, entrar com autorização de supervisor?",
                                "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                            {
                                FormSenhaSupervisor frmSenhaSupervisor = new FormSenhaSupervisor();
                                if (frmSenhaSupervisor.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                                {
                                    throw new Exception("Operação cancelada pelo usuário");
                                }
                                e.Cancel = false;
                            }
                            else
                            {
                                throw new Exception("Operação cancelada pelo usuário");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        e.Cancel = true;
                        new HLPexception(ex);
                    }
                }
                else if (e.ColumnIndex == idOperacaoItens.Index)
                {
                    try
                    {
                        orcamento_ideService.ValidaTipoOperacao(objOrcamento_item: bsItensOrcamento.Current as Orcamento_ItemModel,
                                objClienteForn: objCliente,
                                stContribuinteIcms: cbxstContribuienteIcms.SelectedIndex);
                    }
                    catch (Exception ex)
                    {
                        e.Cancel = true;
                        new HLPexception(ex);
                    }
                }
            }
        }
        private void RowsAdded_ComponentesGrids(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (sender.Equals(dgvItens))
            {
                try
                {
                    if (bsItensOrcamento.Current != null)
                    {
                        if ((bsItensOrcamento.Current as Orcamento_ItemModel).idOrcamentoItem == null)
                        {
                            if (objCliente != null)
                            {
                                ((Orcamento_ItemModel)bsItensOrcamento.Current).stConsumidorFinal = objCliente.cliforFiscalModel.stConsumidorFinal;
                                ((Orcamento_ItemModel)bsItensOrcamento.Current).idListaPrecoPai = objCliente.idListaPrecoPai;
                            }

                            ((Orcamento_ItemModel)bsItensOrcamento.Current).xPedidoCliente = txtxPedidoCliente.Text;
                            ((Orcamento_ItemModel)bsItensOrcamento.Current).idFuncionarioRepresentante = hlP_PesquisaidFuncionarioRepresentante.Value;
                            ((Orcamento_ItemModel)bsItensOrcamento.Current).idEmpresa = CompanyData.idEmpresa;

                            if (hlP_PesquisaidDeposito.Value != 0)
                                ((Orcamento_ItemModel)bsItensOrcamento.Current).idDeposito = hlP_PesquisaidDeposito.Value;

                            if (hlP_PesquisaidSite.Value != 0)
                                ((Orcamento_ItemModel)bsItensOrcamento.Current).idSite = hlP_PesquisaidSite.Value;
                        }
                    }
                }
                catch (Exception ex)
                {
                    new HLPexception(ex);
                }
            }
        }
        private void CellValueChanged_ComponentesGrids(object sender, DataGridViewCellEventArgs e)
        {
            string sSender = (sender as HLP.Comum.Components.HLP_DataGridView).Name;

            if (sSender == dgvItens.Name.ToString())
            {
                if (e.RowIndex > -1)
                {
                    if (e.ColumnIndex == idListaPrecoPai.Index)
                    {
                        CarregaListaPreco(
                            (int)(dgvItens[idListaPrecoPai.Index, e.RowIndex] as DataGridViewComboBoxCell).Value);
                    }
                    else if (e.ColumnIndex == clidProduto.Index)
                    {
                        orcamento_ideService.CarregaUnidMedProdutos(idProduto: (bsItensOrcamento.Current as Orcamento_ItemModel).idProduto,
                            cellDgv: (dgvItens[idUnidadeMedida.Index, e.RowIndex] as DataGridViewComboBoxCell));
                    }
                }
            }
        }
        #endregion

        #endregion
    }
}