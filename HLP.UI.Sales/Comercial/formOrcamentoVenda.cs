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

        public formOrcamentoVenda()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
        }

        private void formOrcamentoVenda_Load(object sender, EventArgs e)
        {
            objOrcamento = new Orcamento_ideModel();
            idOperacaoItens.Tag = "FormTipoOperacao-vwTipoOperacao-ID_xOperacao";
            clidProduto.Tag = "FormProduto-vwProduto-ID_xPesquisa";
            idListaPrecoPai.Tag = "FormListaPreco-vwListaPrecoPai-ID_xLista";
            idCfop.Tag = "FormCfop-vwCfop-xCfop";
            idClassificacaoFiscalDataGridViewTextBoxColumn.Tag = "FormClassificacaoFiscal-vwClassificacaoFiscal-cNCM";
            idCSTIpi.Tag = "FormStIPI-vwStIPI-cCSTIpi";
            InicializaFormPadrao("vwOrcamento");
            VerifBw += (() =>
            {
                CarregaCombosGrid();
            });
            t1 = new Thread(new ThreadStart(VerifBw));
            t1.Start();
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
                idOperacaoItens.DataSource = pesquisaPadraoService.GetData(objMetodosForm.GetDisplayMember(idOperacaoItens), true);
                clidProduto.DataSource = pesquisaPadraoService.GetData(objMetodosForm.GetDisplayMember(clidProduto), true);
                idListaPrecoPai.DataSource = pesquisaPadraoService.GetData(objMetodosForm.GetDisplayMember(idListaPrecoPai));
                idCfop.DataSource = pesquisaPadraoService.GetData(objMetodosForm.GetDisplayMember(idCfop), true);
                idClassificacaoFiscalDataGridViewTextBoxColumn.DataSource = pesquisaPadraoService.GetData(
                    objMetodosForm.GetDisplayMember(idClassificacaoFiscalDataGridViewTextBoxColumn), true);
                idCSTIpi.DataSource = pesquisaPadraoService.GetData(objMetodosForm.GetDisplayMember(idCSTIpi), true);
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
                bsItensOrcamento.DataSource = objOrcamento.LOrcamento_Itens;
                bsItensCancelados.DataSource = objOrcamento.LOrcamento_ItensCancelPerd;
                bsItensVendidos.DataSource = objOrcamento.LOrcamento_ItensVendidos;
                camposBloqueados();
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
                objOrcamento = orcamento_ideService.GetOrcamento_ide((int)iRetPesquisa);
                PopulaForm();
            }
        }
        public override void Atualizar()
        {
            base.Atualizar();
            camposBloqueados();
        }
        public override void Salvar()
        {
            try
            {
                objValidaCampos.Validar();
                PopulaTabela();

                orcamento_ideService.Save(objOrcamento);

                txtCodigo.Text = objOrcamento.idOrcamento.ToString();
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
                        objOrcamento = orcamento_ideService.GetOrcamento_ide(Convert.ToInt32(txtCodigo.Text));

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
                    objOrcamento = orcamento_ideService.GetOrcamento_ide((int)iRetPesquisa);

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
                    objOrcamento = orcamento_ideService.GetOrcamento_ide((int)iRetPesquisa);
                    if (objOrcamento != null)
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
                    objOrcamento = orcamento_ideService.GetOrcamento_ide((int)iRetPesquisa);
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
                orcamento_ideService.Copy(objOrcamento);
                PopulaForm();
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
                    bsItensOrcamento.DataSource as List<Orcamento_ItemModel>,
                    bsItensVendidos.DataSource as List<Orcamento_ItemModel>,
                    bsItensCancelados.DataSource as List<Orcamento_ItemModel>);
                base.CarregaClasse(objOrcamento);
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
                base.CarregaPropriedades(orcamento_ideService, true);
                base.CarregaForm();
                bsItensOrcamento.DataSource = objOrcamento.LOrcamento_Itens;
                bsItensVendidos.DataSource = objOrcamento.LOrcamento_ItensVendidos;
                bsItensCancelados.DataSource = objOrcamento.LOrcamento_ItensCancelPerd;
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }

        private void cbxidContato__SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxidContato.cbx.SelectedItem != null && cbxidContato.cbx.ValueMember != "ValueMember")
            {
                objContato = new ContatoModel();
                objContato = orcamento_ideService.GetInformacoesContato(
                idContato: (int)cbxidContato.cbx.SelectedValue);
                txtxDepartamento.txt.Text = objContato.xDepartamento ?? "";
            }
        }

        private void camposBloqueados()
        {
            txtidOrcamentoOrigem.Enabled = dtpdDataHora.Enabled = txtCidade.Enabled =
                txtUF.Enabled = maskTelefoneCliente.Enabled = hlP_PesquisaidMotivo.Enabled =
            hlP_PesquisaidFuncionarioResponsavel.Enabled = hlP_PesquisaxCanalVenda.Enabled = false;
        }

        private void cbxstOrcamento__SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxstOrcamento.SelectedIndex)
            {
                case 4:
                case 5: hlP_PesquisaidMotivo.Enabled = true; break;
                default: hlP_PesquisaidMotivo.Enabled = false; break;
            }

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

        private void hlP_DataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clidProduto.Index)
            {
                try
                {
                    if (objCliente == null)
                        objCliente = new Cliente_fornecedorModel();

                    List<Unidade_medidaModel> lUnidadeMedida = new List<Unidade_medidaModel>();
                    lUnidadeMedida.Add(orcamento_ideService.GetInformacoesUnidade(idUnidadeMedida:
                        (bsItensOrcamento.Current as Orcamento_ItemModel).idProduto));

                    List<Unidade_medidaModel> lUnidadeMedidaProduto = (bsItensOrcamento.Current as Orcamento_ItemModel).idProduto != 0 ?
                        orcamento_ideService.GetUnidadeByConversaoProduto(
                        orcamento_ideService.GetInformacoesProduto(
                        idProduto: (bsItensOrcamento.Current as Orcamento_ItemModel).idProduto).idUnidadeMedidaVendas
                        , (bsItensOrcamento.Current as Orcamento_ItemModel).idProduto) : null;

                    if (lUnidadeMedidaProduto != null)
                    {
                        foreach (Unidade_medidaModel un in lUnidadeMedidaProduto)
                        {
                            lUnidadeMedida.Add(un);
                        }
                        (dgvItens[idUnidadeMedida.Index, e.RowIndex] as DataGridViewComboBoxCell).Items.Clear();
                        foreach (Unidade_medidaModel un in lUnidadeMedida)
                        {
                            (dgvItens[idUnidadeMedida.Index, e.RowIndex] as DataGridViewComboBoxCell).Items.Add(item: un.xUnidadeMedida);
                        }
                    }

                    GetComissao();
                    dgvItens.Refresh();
                    dgvFiscal.Refresh();
                }
                catch (Exception ex)
                {
                    new HLPexception(ex);
                }
            }

            try
            {
                orcamento_ideService.PopulaObjetoItem(objOrcamento_Item: bsItensOrcamento.Current as Orcamento_ItemModel,
                objOrcamento_ide: objOrcamento
                );
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }

        private void hlP_DataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                if (bsItensOrcamento.Current != null)
                {
                    if (objCliente != null)
                    {
                        int? cont = (bsItensOrcamento.DataSource as List<Orcamento_ItemModel>).Max(i => i.idOrcamentoItem);
                        ((Orcamento_ItemModel)bsItensOrcamento.Current).idOrcamentoItem = cont == null ? 1 : cont++;
                        ((Orcamento_ItemModel)bsItensOrcamento.Current).stConsumidorFinal = objCliente.cliforFiscalModel.stConsumidorFinal;
                        ((Orcamento_ItemModel)bsItensOrcamento.Current).idListaPrecoPai = objCliente.idListaPrecoPai;
                    }
                    ((Orcamento_ItemModel)bsItensOrcamento.Current).stOrcamentoItem = 0;
                    ((Orcamento_ItemModel)bsItensOrcamento.Current).xPedidoCliente = txtxPedidoCliente.Text;
                    ((Orcamento_ItemModel)bsItensOrcamento.Current).idFuncionarioRepresentante = hlP_PesquisaidFuncionarioRepresentante.Value;
                }
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }

        }

        private void GetComissao()
        {
            object o = null;
            if ((bsItensOrcamento.Current as Orcamento_ItemModel).idFuncionarioRepresentante == 0
                || (bsItensOrcamento.Current as Orcamento_ItemModel).idFuncionarioRepresentante == null)
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

        private void hlP_PesquisaidClienteFornecedor_Validated(object sender, EventArgs e)
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
                CarregaListaPreco((int)objCliente.idClienteFornecedor);

                objCliente_representante =
                    orcamento_ideService.GetClienteFornRepresentante(idClienteFornecedor: (int)hlP_PesquisaidClienteFornecedor.Value);

                if (objCliente_representante != null)
                    hlP_PesquisaidFuncionarioRepresentante.Value = objCliente_representante.idFuncionario;

                try
                {
                    cbxidContato.DataSource = orcamento_ideService.GetContatosByClienteForn(
                        idClienteForn: hlP_PesquisaidClienteFornecedor.Value);
                    cbxidContato.DisplayMember = "xNome";
                    cbxidContato.ValueMember = "idContato";

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

        private void hlP_PesquisaidFuncionario_Validated(object sender, EventArgs e)
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

        private void CarregaListaPreco(int idListaPrecoPai)
        {
            lListaPreco = new List<Lista_precoModel>();
            lListaPreco = orcamento_ideService.GetListaPrecoOrcamento(idListaPrecoPai: idListaPrecoPai);
        }

        private void hlP_DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (btnSalvar.Enabled && e.RowIndex > -1)
            {
                if (e.ColumnIndex == idListaPrecoPai.Index)
                {
                    CarregaListaPreco(
                        (int)(dgvItens[idListaPrecoPai.Index, e.RowIndex] as DataGridViewComboBoxCell).Value);
                }
                else if (e.ColumnIndex == idOperacaoItens.Index)
                {
                    try
                    {
                        orcamento_ideService.ValidaTipoOperacao(objOrcamento_item: bsItensOrcamento.Current as Orcamento_ItemModel,
                            objClienteForn: objCliente,
                            stContribuinteIcms: cbxstContribuienteIcms.SelectedIndex);
                        (bsItensOrcamento.Current as Orcamento_ItemModel).idCfop =
                            (int)orcamento_ideService.GetCfopByOperacao((bsItensOrcamento.Current as Orcamento_ItemModel).idTipoOperacao,
                        hlP_PesquisaidClienteFornecedor.Value);
                    }
                    catch (Exception ex)
                    {
                        (bsItensOrcamento.Current as Orcamento_ItemModel).idTipoOperacao = 0;
                        new HLPexception(ex);
                    }

                }
                else if (e.ColumnIndex == vVendaDataGridViewTextBoxColumn.Index ||
                e.ColumnIndex == qProdutoDataGridViewTextBoxColumn.Index ||
                e.ColumnIndex == vDescontoDataGridViewTextBoxColumn.Index ||
                e.ColumnIndex == pDescontoDataGridViewTextBoxColumn.Index)
                {
                    try
                    {
                        orcamento_ideService.CalculaTotaisOrcamento(objItem: bsItensOrcamento.Current as Orcamento_ItemModel,
                        objClienteForn: objCliente, stCalculoPrincipal:
                        e.ColumnIndex == vDescontoDataGridViewTextBoxColumn.Index ? CalculoDescontoPrincipal.porValor : CalculoDescontoPrincipal.porPorcentagem);
                    }
                    catch (Exception ex)
                    {
                        new HLPexception(ex);
                    }
                }
            }
        }

        private void dgvItens_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
        }

        private void dgvItens_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgvItens_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            bsFiscal.DataSource = (bsItensOrcamento.Current as Orcamento_ItemModel).Orcamento_Item_Impostos;
        }

        private void CalculaTotais()
        {
            try
            {
                nudvProdutoTotal.Value = orcamento_ideService.CalculaProdutoTotal(lOrcamento_ItemModel: bsItensOrcamento.DataSource as List<Orcamento_ItemModel>);
                nudvServicoTotal.Value = orcamento_ideService.CalculaServicoTotal(lOrcamento_ItemModel: bsItensOrcamento.DataSource as List<Orcamento_ItemModel>);
                nudvDescontoTotal.Value = orcamento_ideService.CalculaDescontoTotal(lOrcamento_ItemModel: bsItensOrcamento.DataSource as List<Orcamento_ItemModel>);
                nudvDescontoSuframaTotal.Value = (bsItensOrcamento.DataSource as List<Orcamento_ItemModel>).Sum(i => i.vDescontoSuframa) ?? 0;
                nudvFreteTotal.Value = (bsItensOrcamento.DataSource as List<Orcamento_ItemModel>).Sum(i => i.vFreteItem);
                nudvSeguroTotal.Value = (bsItensOrcamento.DataSource as List<Orcamento_ItemModel>).Sum(i => i.vSegurosItem);
                nudvOutrasDespesasTotal.Value = (bsItensOrcamento.DataSource as List<Orcamento_ItemModel>).Sum(i => i.vOutrasDespesasItem);
                nudvBaseCalculoIcmsTotal.Value = (bsItensOrcamento.DataSource as List<Orcamento_ItemModel>).Sum(i => i.Orcamento_Item_Impostos.ICMS_vBaseCalculo) ?? 0;
                nudvIcmsTotal.Value = (bsItensOrcamento.DataSource as List<Orcamento_ItemModel>).Sum(i => i.Orcamento_Item_Impostos.ICMS_vICMS) ?? 0;
                nudvBaseCalculoIcmsProprioTotal.Value = (bsItensOrcamento.DataSource as List<Orcamento_ItemModel>).Sum(i => i.Orcamento_Item_Impostos.ICMS_vBaseCalculoIcmsProprio) ?? 0;
                nudvIcmsProprioTotal.Value = (bsItensOrcamento.DataSource as List<Orcamento_ItemModel>).Sum(i => i.Orcamento_Item_Impostos.ICMS_vIcmsProprio) ?? 0;
                nudvBaseCalculoIpiTotal.Value = (bsItensOrcamento.DataSource as List<Orcamento_ItemModel>).Sum(i => i.Orcamento_Item_Impostos.IPI_vBaseCalculo) ?? 0;
                nudvIPITotal.Value = (bsItensOrcamento.DataSource as List<Orcamento_ItemModel>).Sum(i => i.Orcamento_Item_Impostos.IPI_vIPI) ?? 0;
                nudvBaseCalculoICmsSubstituicaoTributariaTotal.Value = (bsItensOrcamento.DataSource as List<Orcamento_ItemModel>).Sum(i => i.Orcamento_Item_Impostos.ICMS_vBaseCalculoSubstituicaoTributaria) ?? 0;
                nudvIcmsSubstituicaoTributariaTotal.Value = (bsItensOrcamento.DataSource as List<Orcamento_ItemModel>).Sum(i => i.Orcamento_Item_Impostos.ICMS_vSubstituicaoTributaria) ?? 0;
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
                (bsItensOrcamento.DataSource as List<Orcamento_ItemModel>));
            nudvPesoBruto.Value = orcamento_ideService.CalculaPesoBruto(lOrcamento_ItemModel:
                (bsItensOrcamento.DataSource as List<Orcamento_ItemModel>));
        }

        private void nudvDescontoTotal__ValueChanged(object sender, EventArgs e)
        {


        }

        private void nudpDescontoTotal__ValueChanged(object sender, EventArgs e)
        {
        }

        private void dgvItens_CellValidating_1(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == pDescontoDataGridViewTextBoxColumn.Index ||
                e.ColumnIndex == vDescontoDataGridViewTextBoxColumn.Index)
            {
                try
                {
                    if ((bsItensOrcamento.Current as Orcamento_ItemModel).vTotalSemDescontoItem == 0)
                        return;

                    if ((bsItensOrcamento.Current as Orcamento_ItemModel).pDesconto == Convert.ToDecimal(e.FormattedValue))
                        return;

                    if ((bsItensOrcamento.Current as Orcamento_ItemModel).vDesconto == Convert.ToDecimal(e.FormattedValue))
                        return;

                    lItemPorcAcimaListaModel = new List<ItemPorcAcimaListaModel>();
                    decimal porDescAcr = e.ColumnIndex == vDescontoDataGridViewTextBoxColumn.Index ?
                        (100 * Convert.ToDecimal(e.FormattedValue)) / (bsItensOrcamento.Current as Orcamento_ItemModel).vTotalSemDescontoItem :
                        Convert.ToDecimal(e.FormattedValue);
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
        }

        private void tabPageBaseCalculo_Enter(object sender, EventArgs e)
        {
            if (btnSalvar.Enabled)
            {
                nudvProdutoTotal.Enabled = nudvServicoTotal.Enabled = nudvBaseCalculoIcmsTotal.Enabled = nudvIcmsTotal.Enabled
                    = nudvBaseCalculoIcmsProprioTotal.Enabled = nudvIcmsProprioTotal.Enabled =
                    nudvBaseCalculoIpiTotal.Enabled = nudvIPITotal.Enabled = nudvBaseCalculoICmsSubstituicaoTributariaTotal.Enabled = nudvIcmsSubstituicaoTributariaTotal.Enabled =
                    nudvTotal.Enabled = nudvBaseCalculoPisTotal.Enabled = nudvPisTotal.Enabled = nudvBaseCalculoCofinsTotal.Enabled = nudvCofinsTotal.Enabled =
                    nudvBaseCalculoIssTotal.Enabled = nudvIssTotal.Enabled = false;
                nudpDescontoTotal.Enabled = nudvDescontoTotal.Enabled = !(orcamento_ideService.IsNfSuframa(
                    idTipoDocumento: hlP_PesquisaidTipoDocumento.Value));
                this.CalculaTotais();
            }
        }

        private void nudvFreteTotal_Leave(object sender, EventArgs e)
        {
            try
            {
                if ((bsItensOrcamento.DataSource as List<Orcamento_ItemModel>).Sum(i => i.vFreteItem)
                    != nudvFreteTotal.Value)
                {
                    if (MessageBox.Show("Valor da soma do frete dos itens difere do valor total do frete. " +
                        Environment.NewLine + "Valor frete: " + nudvFreteTotal.Value.ToString() +
                        Environment.NewLine + "Valor total de frete nos itens: " + (bsItensOrcamento.DataSource as List<Orcamento_ItemModel>).Sum(i => i.vFreteItem).ToString() +
                        Environment.NewLine + "Deseja que o sistema realize rateio do valor total do frete nos itens?",
                        "Atenção!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                    {
                        orcamento_ideService.RateiaValorTotalNosItens(vTotal: nudvFreteTotal.Value,
                            lOrcamento_ItemModel: (bsItensOrcamento.DataSource as List<Orcamento_ItemModel>),
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

        private void nudvDescontoTotal_Leave(object sender, EventArgs e)
        {
            try
            {
                nudpDescontoTotal.Value = orcamento_ideService.CalculaPorcDescontoTotal(vDescontoTotal: nudvDescontoTotal.Value,
                    vProdutosTotal: (bsItensOrcamento.DataSource as List<Orcamento_ItemModel>).Sum(i => i.vTotalSemDescontoItem));
                this.ValidaDescontos();
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }

        private void ValidaDescontos()
        {
            try
            {
                decimal vDescontoItens = orcamento_ideService.CalculaDescontoTotal(lOrcamento_ItemModel: bsItensOrcamento.DataSource as List<Orcamento_ItemModel>);
                if (vDescontoItens != nudvDescontoTotal.Value)
                {
                    if (MessageBox.Show("Valor da soma do desconto dos itens difere do valor total dos descontos. " +
                        Environment.NewLine + "Valor desconto: " + nudvDescontoTotal.Value.ToString() +
                        Environment.NewLine + "Valor total de desconto nos itens: " + vDescontoItens.ToString() +
                        Environment.NewLine + "Deseja que o sistema realize rateio do valor total dos descontos nos itens?",
                        "Atenção!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                    {
                        lItemPorcAcimaListaModel = new List<ItemPorcAcimaListaModel>();
                        orcamento_ideService.ValidaPorcListaPrecoLista(lOrcamento_item: (bsItensOrcamento.DataSource as List<Orcamento_ItemModel>),
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
                            lOrcamento_ItemModel: bsItensOrcamento.DataSource as List<Orcamento_ItemModel>,
                            iPropCalculo: PropriedadeCalculo.descontoTotal);
                        foreach (Orcamento_ItemModel item in (bsItensOrcamento.DataSource as List<Orcamento_ItemModel>))
                        {
                            orcamento_ideService.CalculaTotaisOrcamento(objItem: item,
                                objClienteForn: objCliente, stCalculoPrincipal: CalculoDescontoPrincipal.porValor);
                        }
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

        private void nudvSeguroTotal_Leave(object sender, EventArgs e)
        {
            try
            {
                if ((bsItensOrcamento.DataSource as List<Orcamento_ItemModel>).Sum(i => i.vSegurosItem)
                    != nudvSeguroTotal.Value)
                {
                    if (MessageBox.Show("Valor da soma do seguro dos itens difere do valor total do seguro. " +
                        Environment.NewLine + "Valor seguro: " + nudvSeguroTotal.Value.ToString() +
                        Environment.NewLine + "Valor total de seguro nos itens: " + (bsItensOrcamento.DataSource as List<Orcamento_ItemModel>).Sum(i => i.vSegurosItem).ToString() +
                        Environment.NewLine + "Deseja que o sistema realize rateio do valor total do seguro nos itens?",
                        "Atenção!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                    {
                        orcamento_ideService.RateiaValorTotalNosItens(vTotal: nudvSeguroTotal.Value,
                            lOrcamento_ItemModel: (bsItensOrcamento.DataSource as List<Orcamento_ItemModel>),
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

        private void nudvOutrasDespesasTotal_Leave(object sender, EventArgs e)
        {
            try
            {
                if ((bsItensOrcamento.DataSource as List<Orcamento_ItemModel>).Sum(i => i.vOutrasDespesasItem)
                    != nudvOutrasDespesasTotal.Value)
                {
                    if (MessageBox.Show("Valor da soma de outras despesas dos itens difere do valor total de outras despesas. " +
                        Environment.NewLine + "Valor outras despesas: " + nudvOutrasDespesasTotal.Value.ToString() +
                        Environment.NewLine + "Valor total de outras despesas nos itens: "
                        + (bsItensOrcamento.DataSource as List<Orcamento_ItemModel>).Sum(i => i.vOutrasDespesasItem).ToString() +
                        Environment.NewLine + "Deseja que o sistema realize rateio do valor de outras despesas nos itens?",
                        "Atenção!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                    {
                        orcamento_ideService.RateiaValorTotalNosItens(vTotal: nudvOutrasDespesasTotal.Value,
                            lOrcamento_ItemModel: (bsItensOrcamento.DataSource as List<Orcamento_ItemModel>),
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

        private void nudvDescontoSuframaTotal_Leave(object sender, EventArgs e)
        {
            this.CalculaTotalOrcamento();
        }

        private void nudpDescontoTotal_Leave(object sender, EventArgs e)
        {
            try
            {
                nudvDescontoTotal.Value = (bsItensOrcamento.DataSource as List<Orcamento_ItemModel>).Sum(i => i.vTotalSemDescontoItem) * (nudpDescontoTotal.Value / 100);
                this.ValidaDescontos();
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }

        private void tabPageTransportes_Enter(object sender, EventArgs e)
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
    }

}