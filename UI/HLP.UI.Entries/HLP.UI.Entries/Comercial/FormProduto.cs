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
using HLP.Comum.Services.Interface;
using HLP.Dependencies;
using HLP.Services.Interfaces.Entries.Comercial;
using HLP.Comum.Models.Static;
using HLP.Models.Entries.Comercial;
using HLP.Comum.UI.Exception;
using HLP.Comum.Messages;
using System.Threading;
using HLP.Services.Interfaces.Entries.Gerais;
using HLP.Models.Entries.Gerais;

/* DIEGO_RAMOS - Criado uma Trigger (Tr_Produto_Data_Alter_Valor_Venda.sql) para alterar o campo dValorVenda com a data atual quando o valor de venda (vVenda) do produto for alterado. 
 * 
 * 
 * */

namespace HLP.UI.Entries.Comercial
{
    public partial class FormProduto : FormPadraoCadastro
    {
        [Inject]
        public IPesquisaPadraoService pesquisaPadraoService { get; set; }

        [Inject]
        public IUsuarioService usuarioService { get; set; }

        [Inject]
        public IProdutoService produtoService { get; set; }

        [Inject]
        public IEmpresaService empresaService { get; set; }

        [Inject]
        public ILista_precoService listaItemService { get; set; }

        [Inject]
        public ITipo_produtoService tipoProdutoService { get; set; }

        [Inject]
        public IFuncionarioService funcionarioService { get; set; }

        ProdutoModel objProduto = new ProdutoModel();
        ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnImage = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
        Action verifBw = null;

        public FormProduto()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
        }

        private void FormProduto_Load(object sender, EventArgs e)
        {
            idClienteFornecedor.Tag = "FormFornecedor-vwCliente-xNome";
            idUsuario.Tag = "FormUsuario-Usuario";
            InicializaFormPadrao("vwProduto");
            txtxPesquisa.txt.Validated += new EventHandler(txt_Validated);
            btnImage.Image = HLP.UI.Entries.Properties.Resources.Pasta;
            btnImage.Click += new EventHandler(btn_Click);
            txtxFoto.txt.ButtonSpecs.Add(btnImage);
            cbxidUsuario.DataSource = idUsuario.DataSource = pesquisaPadraoService.GetData(
                            funcionarioService.GetQueryUserByEmpresaToComboBox(),
                            false);
            idUsuario.DisplayMember = "xNome";
            idUsuario.ValueMember = "idUsuario";
            idUsuario.DataSource = pesquisaPadraoService.GetData(
                       funcionarioService.GetQueryUserByEmpresaToComboBox(),
                       true
                       );

            verifBw += (() =>
                {
                    CarregaCombobox();
                });

            Thread t1 = new Thread(new ThreadStart(verifBw));
            t1.Start();
        }

        void btn_Click(object sender, EventArgs e)
        {
            if (btnNovo.Enabled == false)
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Title = "Imagem do produto";
                fileDialog.Filter = "Imagem (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";
                if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    txtxFoto.Text = fileDialog.FileName;
            }
        }

        void txt_Validated(object sender, EventArgs e)
        {
            if (txtxComercial.Text == "")
                txtxComercial.Text = txtxPesquisa.Text;

            if (txtxFiscal.Text == "")
                txtxFiscal.Text = txtxPesquisa.Text;
        }

        public override void Novo()
        {
            base.Novo();
            objProduto = new ProdutoModel();
            bsProduto_Fornecedor_Homologado.DataSource = objProduto.lProduto_Fornecedor_Homologado;
            bsProduto_Revisao.DataSource = objProduto.lProduto_Revisao;

            EmpresaModel empresa = empresaService.GetEmpresa(CompanyData.idEmpresa);
            if (empresa.lparametroEstoque != null)
            {
                if (empresa.lparametroEstoque.Count() > 0)
                {
                    cbxstCusto.SelectedIndex = empresa.lparametroEstoque.FirstOrDefault().stCusto;
                    cbxstCustoMedio.SelectedIndex = empresa.lparametroEstoque.FirstOrDefault().stCustoMedio;
                }
            }

            cbxAtivo.SelectedIndex = 1;
            cbxstInss.SelectedIndex = 0;
            cbxstFornecedorHomologado.SelectedIndex = 0;
            //CarregaCombobox();
            txtdCadastro.Text = DateTime.Today.ToShortDateString();
            cbxidUsuario.Enabled = false;
            cbxidUsuario.SelectedValue = UserData.idUser;
            txtdValorVenda.Text = DateTime.Today.ToString();
        }

        public override void Salvar()
        {
            try
            {

                this.ValidaTipoServico();
                objValidaCampos.Validar();

                PopulaTabela();
                produtoService.Save(objProduto);

                if (txtCodigo.Text.Equals(""))
                {
                    //Adicionar produto as listas padrões.
                }
                else
                {
                    //alterar preço do produto nas listas padrões.
                }

                txtCodigo.Text = objProduto.idProduto.ToString();

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
                        objProduto = produtoService.GetProduto(Convert.ToInt32(txtCodigo.Text), true);
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
                    objProduto = produtoService.GetProduto((int)iRetPesquisa, true);
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
                    objProduto = produtoService.GetProduto((int)iRetPesquisa, true);
                    if (objProduto != null)
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
                    objProduto = produtoService.GetProduto((int)iRetPesquisa, true);
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
                produtoService.Copy(objProduto);
                PopulaForm();
                base.RegistroDuplicado(idOrigem, (int)objProduto.idProduto);

            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }
        public override void Atualizar()
        {
            base.Atualizar();
            cbxidUsuario.Enabled = false;
            if (objProduto.idTipoProduto != 8)
                hlP_PesquisaidTipoServico.Enabled = false;
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
        private void ExcluirRegistro()
        {
            produtoService.Delete(objProduto);
            base.Excluir();
            if (iRetPesquisa != null)
            {
                base.MoveProximoItem();
                objProduto = produtoService.GetProduto((int)iRetPesquisa, true);
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
                    Invoke(new MethodInvoker(delegate
                    {
                        pbProgresso.PerformStep();
                        lblProgresso.Text = (i + 1) + " de " + bsRetPesquisa.List.Count;
                    }));
                    objProduto = produtoService.GetProduto((int)lParaExcluir[i], true);
                    produtoService.Delete(objProduto);
                    lExcluido.Add(lParaExcluir[i]);
                }
                catch (Exception)
                {
                }
            }
            base.FinalizaExcluirTodos();
        }


        private void CarregaCombobox()
        {
            if (objMetodosForm != null)
            {
                idClienteFornecedor.DataSource = pesquisaPadraoService.GetData(
                        objMetodosForm.GetDisplayMember(idClienteFornecedor),
                        true, "stCatalogo=1");
                Thread.CurrentThread.Abort();
            }
            else
            {
                Thread.Sleep(500);
                CarregaCombobox();
            }

        }

        void PopulaForm()
        {
            txtCodigo.Text = objProduto.idProduto.ToString();

            #region Geral
            txtxcAlternativo.Text = objProduto.cAlternativo.ToString();
            txtcEan.Text = objProduto.cEan;
            txtxPesquisa.Text = objProduto.xPesquisa;
            txtxComercial.Text = objProduto.xComercial;
            txtxFiscal.Text = objProduto.xFiscal;
            txtxIngles.Text = objProduto.xIngles;
            hlP_PesquisaidTipoProduto.Value = objProduto.idTipoProduto;
            txtxFoto.Text = objProduto.xFoto;
            hlP_Observacao1.Text = objProduto.xObs;
            if (objProduto.idTipoServico != null)
                hlP_PesquisaidTipoServico.Value = (int)objProduto.idTipoServico;
            txtdCadastro.Text = objProduto.dCadastro.ToString("dd/MM/yyyy");
            cbxidUsuario.SelectedValue = objProduto.idUsuario;
            #endregion

            #region Dados de estoque
            hlP_PesquisaidFamiliaProduto.Value = objProduto.idFamiliaProduto;
            hlP_PesquisaidUnidadeMedidaEstoque.Value = objProduto.idUnidadeMedidaEstoque;
            nudnPesoBruto.Value = objProduto.nPesoBruto;
            nudnPesoLiquido.Value = objProduto.nPesoLiquido;
            nudnPrazoValidade.Value = objProduto.nPrazoValidade;
            cbxAtivo.SelectedIndex = (objProduto.Ativo ? 1 : 0);
            if (objProduto.Ativo)
            {
                txtdBloqueio.Text = "";
            }
            else
            {
                txtdBloqueio.Text = Convert.ToDateTime(objProduto.dBloqueio).ToShortDateString();
            }


            nudnEstoqueMinimo.Value = objProduto.nEstoqueMinimo;
            nudnEstoqueMaximo.Value = objProduto.nEstoqueMaximo;
            if (objProduto.idProdutoLocalizacao != null)
                hlP_PesquisaidProdutoLocalizacao.Value = (int)objProduto.idProdutoLocalizacao;
            nudnProfundidadeBruta.Value = objProduto.nProfundidadeBruta;
            nudnLarguraBruta.Value = objProduto.nLarguraBruta;
            nudnAlturaBruta.Value = objProduto.nAlturaBruta;
            hlP_PesquisaidDeposito.Value = objProduto.idDeposito;
            hlP_PesquisaidFabricante.Value = objProduto.idFabricante;
            cbxstCusto.SelectedIndex = objProduto.stCusto;
            cbxstCustoMedio.SelectedIndex = objProduto.stCustoMedio;

            #endregion

            #region Dados Fiscais

            cbxstOrigemMercadoria.SelectedIndex = objProduto.stOrigemMercadoria;
            if (objProduto.idCSTIcms != null)
                hlP_PesquisaidCSTIcms.Value = (int)objProduto.idCSTIcms;
            cbxstInss.SelectedIndex = objProduto.stInss;
            nudpInss.Value = objProduto.pInss;
            nudpImportacao.Value = objProduto.pImportacao;
            if (objProduto.idCodigoIcmsPaiVenda != null)
                hlP_PesquisaidCodigoIcmsPaiVenda.Value = (int)objProduto.idCodigoIcmsPaiVenda;
            if (objProduto.idCSTIpiVenda != null)
                hlP_PesquisaidCSTIpiVenda.Value = (int)objProduto.idCSTIpiVenda;
            if (objProduto.idCSTIpiVenda != null)
                hlP_PesquisaidCSTIpiVenda.Value = (int)objProduto.idCSTIpiVenda;
            if (objProduto.idCSTPisVenda != null)
                hlP_PesquisaidCSTPisVenda.Value = (int)objProduto.idCSTPisVenda;
            if (objProduto.idCSTCofinsVenda != null)
                hlP_PesquisaidCSTCofinsVenda.Value = (int)objProduto.idCSTCofinsVenda;
            if (objProduto.idClassificacaoFiscalVenda != null)
                hlP_PesquisaidClassificacaoFiscalVenda.Value = (int)objProduto.idClassificacaoFiscalVenda;
            if (objProduto.idCodigoIcmsPaiCompra != null)
                hlP_PesquisaidCodigoIcmsPaiCompra.Value = (int)objProduto.idCodigoIcmsPaiCompra;

            if (objProduto.idCSTIpiCompra != null)
                hlP_PesquisaidCSTIpiCompra.Value = (int)objProduto.idCSTIpiCompra;
            if (objProduto.idCSTPisCompra != null)
                hlP_PesquisaidCSTPisCompra.Value = (int)objProduto.idCSTPisCompra;
            if (objProduto.idCSTCofinsCompra != null)
                hlP_PesquisaidCSTCofinsCompra.Value = (int)objProduto.idCSTCofinsCompra;
            if (objProduto.idClassificacaoFiscalCompra != null)
                hlP_PesquisaidClassificacaoFiscalCompra.Value = (int)objProduto.idClassificacaoFiscalCompra;
            #endregion

            #region Dados de Ordem de Vendas

            nudvVenda.Value = objProduto.vVenda;
            hlP_PesquisaidUnidadeMedidaVendas.Value = objProduto.idUnidadeMedidaVendas;
            txtdValorVenda.Text = objProduto.dValorVenda.ToShortDateString();
            nudpEntregaExcedenteVenda.Value = objProduto.pEntregaExcedenteVenda;
            nudpEntregaInsuficienteVenda.Value = objProduto.pEntregaInsuficienteVenda;
            #endregion

            #region Dados de Ordem de Compras

            nudvCompra.Value = objProduto.vCompra;
            hlP_PesquisaidUnidadeMedidaCompras.Value = objProduto.idUnidadeMedidaCompras;
            cbxstFornecedorHomologado.SelectedIndex = objProduto.stFornecedorHomologado;
            nudnLoteMinimoCompras.Value = objProduto.nLoteMinimoCompras;
            nudpEntregaExcedenteCompra.Value = objProduto.pEntregaExcedenteCompra;
            nudpEntregaInsuficienteCompra.Value = objProduto.pEntregaInsuficienteCompra;
            dtdleadTimeCotacao.Value = DateTime.Today + objProduto.dleadTimeCotacao;
            dtdleadTimePedido.Value = DateTime.Today + objProduto.dleadTimePedido;
            dtdleadTimeRecebimento.Value = DateTime.Today + objProduto.dleadTimeRecebimento;
            #endregion

            #region Dados de Produção
            nudvProducao.Value = objProduto.vProducao;
            hlP_PesquisaidUnidadeMedidaProducao.Value = objProduto.idUnidadeMedidaProducao;
            nudpPerdaConstante.Value = objProduto.pPerdaConstante;
            nudpPerdaVariavel.Value = objProduto.pPerdaVariavel;
            #endregion

            bsProduto_Fornecedor_Homologado.DataSource = objProduto.lProduto_Fornecedor_Homologado;
            bsProduto_Revisao.DataSource = objProduto.lProduto_Revisao;
        }

        void PopulaTabela()
        {

            #region Geral
            objProduto.cAlternativo = txtxcAlternativo.Text;
            objProduto.cEan = txtcEan.Text;
            objProduto.xPesquisa = txtxPesquisa.Text;
            objProduto.xComercial = txtxComercial.Text;
            objProduto.xFiscal = txtxFiscal.Text;
            objProduto.xIngles = txtxIngles.Text;
            objProduto.idTipoProduto = hlP_PesquisaidTipoProduto.Value;
            objProduto.xFoto = txtxFoto.Text;
            objProduto.xObs = hlP_Observacao1.Text;
            if (hlP_PesquisaidTipoServico.Value != 0)
                objProduto.idTipoServico = hlP_PesquisaidTipoServico.Value;
            objProduto.dCadastro = Convert.ToDateTime(txtdCadastro.Text.ToString());
            objProduto.idUsuario = (int)cbxidUsuario.SelectedValue;
            #endregion

            #region Dados de estoque
            objProduto.idFamiliaProduto = hlP_PesquisaidFamiliaProduto.Value;
            objProduto.idUnidadeMedidaEstoque = hlP_PesquisaidUnidadeMedidaEstoque.Value;
            objProduto.nPesoBruto = nudnPesoBruto.Value;
            objProduto.nPesoLiquido = nudnPesoLiquido.Value;
            objProduto.nPrazoValidade = Convert.ToInt32(nudnPrazoValidade.Value);
            objProduto.Ativo = cbxAtivo.SelectedIndex == 0 ? false : true;
            if (cbxAtivo.SelectedIndex == 0 && objProduto.dBloqueio == null)
            {
                objProduto.dBloqueio = DateTime.Now;
            }
            else if (cbxAtivo.SelectedIndex == 1)
            {
                objProduto.dBloqueio = null;
            }
            objProduto.nEstoqueMinimo = nudnEstoqueMinimo.Value;
            objProduto.nEstoqueMaximo = nudnEstoqueMaximo.Value;
            if (hlP_PesquisaidProdutoLocalizacao.Value != 0)
                objProduto.idProdutoLocalizacao = hlP_PesquisaidProdutoLocalizacao.Value;
            objProduto.nProfundidadeBruta = nudnProfundidadeBruta.Value;
            objProduto.nLarguraBruta = nudnLarguraBruta.Value;
            objProduto.nAlturaBruta = nudnAlturaBruta.Value;
            objProduto.idDeposito = hlP_PesquisaidDeposito.Value;
            objProduto.idFabricante = hlP_PesquisaidFabricante.Value;
            objProduto.stCusto = cbxstCusto.SelectedIndexByte;
            objProduto.stCustoMedio = cbxstCustoMedio.SelectedIndexByte;
            #endregion

            #region Dados Fiscais

            objProduto.stOrigemMercadoria = cbxstOrigemMercadoria.SelectedIndexByte;
            if (hlP_PesquisaidCSTIcms.Value != 0)
                objProduto.idCSTIcms = hlP_PesquisaidCSTIcms.Value;
            objProduto.stInss = cbxstInss.SelectedIndexByte;
            objProduto.pInss = nudpInss.Value;
            objProduto.pImportacao = nudpImportacao.Value;

            if (hlP_PesquisaidCodigoIcmsPaiVenda.Value != 0)
                objProduto.idCodigoIcmsPaiVenda = hlP_PesquisaidCodigoIcmsPaiVenda.Value;

            if (hlP_PesquisaidCSTIpiVenda.Value != 0)
                objProduto.idCSTIpiVenda = hlP_PesquisaidCSTIpiVenda.Value;

            if (hlP_PesquisaidCSTIpiVenda.Value != 0)
                objProduto.idCSTIpiVenda = hlP_PesquisaidCSTIpiVenda.Value;

            if (hlP_PesquisaidCSTPisVenda.Value != 0)
                objProduto.idCSTPisVenda = hlP_PesquisaidCSTPisVenda.Value;

            if (hlP_PesquisaidCSTCofinsVenda.Value != 0)
                objProduto.idCSTCofinsVenda = hlP_PesquisaidCSTCofinsVenda.Value;

            if (hlP_PesquisaidClassificacaoFiscalVenda.Value != 0)
                objProduto.idClassificacaoFiscalVenda = hlP_PesquisaidClassificacaoFiscalVenda.Value;

            if (hlP_PesquisaidCodigoIcmsPaiCompra.Value != 0)
                objProduto.idCodigoIcmsPaiCompra = hlP_PesquisaidCodigoIcmsPaiCompra.Value;

            if (hlP_PesquisaidCSTIpiCompra.Value != 0)
                objProduto.idCSTIpiCompra = hlP_PesquisaidCSTIpiCompra.Value;

            if (hlP_PesquisaidCSTPisCompra.Value != 0)
                objProduto.idCSTPisCompra = hlP_PesquisaidCSTPisCompra.Value;

            if (hlP_PesquisaidCSTCofinsCompra.Value != 0)
                objProduto.idCSTCofinsCompra = hlP_PesquisaidCSTCofinsCompra.Value;

            if (hlP_PesquisaidClassificacaoFiscalCompra.Value != 0)
                objProduto.idClassificacaoFiscalCompra = hlP_PesquisaidClassificacaoFiscalCompra.Value;

            #endregion

            #region Dados de Ordem de Vendas

            objProduto.vVenda = nudvVenda.Value;
            objProduto.idUnidadeMedidaVendas = hlP_PesquisaidUnidadeMedidaVendas.Value;
            objProduto.pEntregaExcedenteVenda = nudpEntregaExcedenteVenda.Value;
            objProduto.pEntregaInsuficienteVenda = nudpEntregaInsuficienteVenda.Value;
            objProduto.dValorVenda = Convert.ToDateTime(txtdValorVenda.Text);

            #endregion

            #region Dados de Ordem de Compras

            objProduto.vCompra = nudvCompra.Value;
            objProduto.idUnidadeMedidaCompras = hlP_PesquisaidUnidadeMedidaCompras.Value;
            objProduto.stFornecedorHomologado = cbxstFornecedorHomologado.SelectedIndexByte;
            objProduto.nLoteMinimoCompras = nudnLoteMinimoCompras.Value;
            objProduto.pEntregaExcedenteCompra = nudpEntregaExcedenteCompra.Value;
            objProduto.pEntregaInsuficienteCompra = nudpEntregaInsuficienteCompra.Value;
            objProduto.dleadTimeCotacao = dtdleadTimeCotacao.Value.TimeOfDay;
            objProduto.dleadTimePedido = dtdleadTimePedido.Value.TimeOfDay;
            objProduto.dleadTimeRecebimento = dtdleadTimeRecebimento.Value.TimeOfDay;
            #endregion

            #region Dados de Produção
            objProduto.vProducao = nudvProducao.Value;
            objProduto.idUnidadeMedidaProducao = hlP_PesquisaidUnidadeMedidaProducao.Value;
            objProduto.pPerdaConstante = nudpPerdaConstante.Value;
            objProduto.pPerdaVariavel = nudpPerdaVariavel.Value;
            #endregion
        }


        private void dgvProduto_Revisao_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                List<DataGridViewColumn> lColunas = (from c in dgvProduto_Revisao.Columns.Cast<DataGridViewColumn>()
                                                     where c.GetType() == typeof(ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn)
                                                     select c).ToList();

                foreach (DataGridViewColumn coluna in lColunas)
                {
                    e.Row.Cells[coluna.Name].Value = DateTime.Now;
                }

                e.Row.Cells["idUsuario"].Value = 1;

            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }

        private void hlP_PesquisaidTipoProduto_Leave(object sender, EventArgs e)
        {
            ValidaTipoServico();
        }

        private void ValidaTipoServico()
        {
            try
            {
                hlP_PesquisaidTipoServico.Enabled = false;

                if (hlP_PesquisaidTipoProduto.Value != 0)
                {
                    Tipo_produtoModel objTpProd = tipoProdutoService.GetTipo(hlP_PesquisaidTipoProduto.Value);
                    if (objTpProd.stServicos == 1)
                    {
                        hlP_PesquisaidTipoServico._Obrigatorio = Comum.Components.UserControlBase.CampoObrigatorio.SIM;
                        hlP_PesquisaidTipoServico.Enabled = true;
                    }
                    else
                    {
                        hlP_PesquisaidTipoServico._Obrigatorio = Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
                        hlP_PesquisaidTipoServico.txtPesquisa.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }

        private void cbxstFornecedorHomologado__SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxstFornecedorHomologado.SelectedIndex == 0)
                {
                    if (tabControlPrincipal.TabPages.Contains(tabPageFornecedores))
                    {
                        tabControlPrincipal.TabPages.Remove(tabPageFornecedores);
                    }
                }
                else
                {
                    if (!tabControlPrincipal.TabPages.Contains(tabPageFornecedores))
                    {
                        tabControlPrincipal.TabPages.Add(tabPageFornecedores);
                    }
                }

            }
            catch (Exception ex)
            {
                throw new HLPexception(ex);
            }
        }
    }
}
