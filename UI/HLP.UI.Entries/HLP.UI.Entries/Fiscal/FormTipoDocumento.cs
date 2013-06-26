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
using HLP.Services.Interfaces.Entries.Fiscal;
using HLP.Models.Entries.Fiscal;
using HLP.Comum.Messages;
using HLP.Comum.UI.Exception;
using HLP.Comum.Models.Static;
using HLP.Comum.Models;
using System.Threading;

namespace HLP.UI.Entries.Fiscal
{
    public partial class FormTipoDocumento : FormPadraoCadastro
    {
        [Inject]
        public ITipo_documentoService documentoService { get; set; }

        [Inject]
        public ITipo_documento_oper_validaService documentoOperService { get; set; }

        [Inject]
        public ITipo_operacaoService operacaoService { get; set; }

        Tipo_documentoModel documentoModel = new Tipo_documentoModel();
        List<Tipo_documento_oper_validaModel> ldocumentoOperModel = new List<Tipo_documento_oper_validaModel>();


        public FormTipoDocumento()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
        }

        private void FormTipoDocumento_Load(object sender, EventArgs e)
        {
            InicializaFormPadrao("vwTipoDocumento");
            lsOperacoesValidas.btnBuscar.Click += new EventHandler(btnBuscar_Click);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ////ConfigFormSerializer config = layoutService.ConfigurationForm("FormTipoOperacao");
            //FormPesquisaPadrao objfrmPesquisaPadrao = new FormPesquisaPadrao("vwTipoOperacao", config, "FormTipoOperacao", true, true);
            //objfrmPesquisaPadrao.sListComponentePesquisa = new List<string>();
            //objfrmPesquisaPadrao.sListComponentePesquisa.Add("ID");
            //objfrmPesquisaPadrao.sListComponentePesquisa.Add("xOperacao");
            //objfrmPesquisaPadrao.dgvDados.MultiSelect = false;
            //objfrmPesquisaPadrao.ShowDialog();

            //if (objfrmPesquisaPadrao.ListIdSelecionados.Count > 0)
            //{
            //    if (!lsOperacoesValidas.lst.Items.Contains(objfrmPesquisaPadrao.ValorComponentePesquisa))
            //    {
            //        lsOperacoesValidas.lst.Items.Add(objfrmPesquisaPadrao.ValorComponentePesquisa);
            //    }
            //}
        }



        public override void Novo()
        {
            base.Novo();
            cboAtivo.SelectedIndex = 1;
            documentoModel = new Tipo_documentoModel();
            ldocumentoOperModel = new List<Tipo_documento_oper_validaModel>();
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

                documentoService.Begin();
                documentoService.Save(documentoModel);

                foreach (Tipo_documento_oper_validaModel documentoOper in ldocumentoOperModel)
                {
                    documentoOper.idTipoDocumento = (int)documentoModel.idTipoDocumento;
                    documentoOperService.Save(documentoOper);
                }

                List<int?> lNotInn = ldocumentoOperModel.Where(C => C.idTipoDocumentoOperValida != null).Select(C => C.idTipoDocumentoOperValida).ToList();
                documentoOperService.Delete((int)documentoModel.idTipoDocumento, lNotInn);

                documentoService.Commit();

                txtCodigo.Text = documentoModel.idTipoDocumento.ToString();
                base.Salvar();

            }
            catch (Exception ex)
            {
                documentoService.RollBack();
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
                        documentoModel = documentoService.GetDocumento(Convert.ToInt32(txtCodigo.Text));
                        ldocumentoOperModel = documentoOperService.GetAll(Convert.ToInt32(txtCodigo.Text));
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
                    documentoModel = documentoService.GetDocumento((int)iRetPesquisa);
                    ldocumentoOperModel = documentoOperService.GetAll((int)iRetPesquisa);
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
                    documentoModel = documentoService.GetDocumento((int)iRetPesquisa);
                    if (documentoModel != null)
                    {
                        ldocumentoOperModel = documentoOperService.GetAll((int)iRetPesquisa);
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
                    documentoModel = documentoService.GetDocumento((int)iRetPesquisa);
                    ldocumentoOperModel = documentoOperService.GetAll((int)iRetPesquisa);
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
                int i = documentoService.Copy(Convert.ToInt32(txtCodigo.Text));
                documentoModel = documentoService.GetDocumento(i);

                documentoService.Begin();
                foreach (Tipo_documento_oper_validaModel documentoOper in ldocumentoOperModel)
                {
                    documentoOper.idTipoDocumento = (int)documentoModel.idTipoDocumento;
                    documentoOper.idTipoDocumentoOperValida = null;
                    documentoOperService.Save(documentoOper);
                }
                documentoService.Commit();
                ldocumentoOperModel = documentoOperService.GetAll((int)documentoModel.idTipoDocumento);
                PopulaForm();

                base.RegistroDuplicado(idOrigem, i);
            }
            catch (Exception ex)
            {
                documentoService.RollBack();
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
                documentoService.RollBack();
                new HLPexception(ex);
            }
        }
        private void ExcluirRegistro()
        {
            documentoService.Begin();

            foreach (Tipo_documento_oper_validaModel documentoOper in ldocumentoOperModel)
            {
                documentoOperService.Delete((int)documentoOper.idTipoDocumentoOperValida);
            }
            documentoService.Delete(Convert.ToInt32(txtCodigo.Text));

            documentoService.Commit();

            base.Excluir();

            if (iRetPesquisa != null)
            {
                base.MoveProximoItem();
                documentoModel = documentoService.GetDocumento((int)iRetPesquisa);
                ldocumentoOperModel = documentoOperService.GetAll((int)iRetPesquisa);
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
                    documentoService.Begin();
                    Invoke(new MethodInvoker(delegate
                    {
                        pbProgresso.PerformStep();
                        lblProgresso.Text = (i + 1) + " de " + bsRetPesquisa.List.Count;
                    }));
                    ldocumentoOperModel = documentoOperService.GetAll((int)lParaExcluir[i]);
                    foreach (Tipo_documento_oper_validaModel codIcms in ldocumentoOperModel)
                    {
                        documentoOperService.Delete((int)codIcms.idTipoDocumentoOperValida);
                    }
                    documentoService.Delete((int)lParaExcluir[i]);
                    documentoService.Commit();
                    lExcluido.Add(lParaExcluir[i]);
                }
                catch (Exception)
                {
                    documentoService.RollBack();
                }
            }
            base.FinalizaExcluirTodos();
        }

        private void PopulaTabela()
        {
            try
            {
                documentoModel.idEmpresa = CompanyData.idEmpresa;
                documentoModel.xTpdoc = txtxTpdoc.Text;
                documentoModel.tpDocumento = cbotpDocumento.SelectedIndexByte;

                documentoModel.stRelacaoPedidoxorcamento = cbostRelacaoPedidoxorcamento.SelectedIndexByte;
                documentoModel.stRelacaoPedidoxnf = cbostRelacaoPedidoxnf.SelectedIndexByte;
                documentoModel.stRelacaoPedidoxproducao = cbostRelacaoPedidoxproducao.SelectedIndexByte;
                documentoModel.stGrupoFaturamento = Convert.ToByte(cbostGrupoFaturamento.SelectedIndex + 1);
                documentoModel.xSerieNf = txtxSerieNf.Text;
                documentoModel.xEspecieVolNf = txtxEspecieVolNf.Text;
                documentoModel.xMarcaVolNf = txtxMarcaVolNf.Text;
                documentoModel.stSomaIpi1Dup = cbostSomaIpi1Dup.SelectedIndexByte;
                documentoModel.stSomaSt1Dup = cbostSomaSt1Dup.SelectedIndexByte;
                documentoModel.xObs = campoxObs.Text;
                documentoModel.stNfComplementar = cbostNfComplementar.SelectedIndexByte;
                documentoModel.stNfImportacao = cbostNfImportacao.SelectedIndexByte;
                documentoModel.stNfExportacao = cbostNfExportacao.SelectedIndexByte;
                documentoModel.stNfIndustrializacao = cbostNfIndustrializacao.SelectedIndexByte;
                documentoModel.stNfSuframa = cbostNfSuframa.SelectedIndexByte;
                documentoModel.stCompoeVlTotalProdutos = cbostCompoeVlTotalProdutos.SelectedIndexByte;
                documentoModel.stSomaDevolucaoVlTotalNf = cbostSomaDevolucaoVlTotalNf.SelectedIndexByte;
                documentoModel.stImprimeIcmsProprioComNormal = cbostImprimeIcmsProprioComNormal.SelectedIndexByte;
                documentoModel.stRelacaoRecebimentoPedidocpa = cbostRelacaoRecebimentoPedidocpa.SelectedIndexByte;
                documentoModel.stRelacaoPedidocpaCotacao = cbostRelacaoPedidocpaCotacao.SelectedIndexByte;
                documentoModel.stNFdevolucao = cbostNFdevolucao.SelectedIndexByte;
                documentoModel.stNfAtivo = cbostNfAtivo.SelectedIndexByte;

                documentoModel.Ativo = cboAtivo.SelectedIndex == 0 ? false : true;
                documentoModel.idModeloDocFiscal = campoPesquisaidModeloDocFiscal.Value;

                int id = 0;
                List<Tipo_documento_oper_validaModel> newldocumentoOperModel = new List<Tipo_documento_oper_validaModel>();

                if (lsOperacoesValidas.lst.Items.Count > 0)
                {
                    foreach (string item in lsOperacoesValidas.lst.Items)
                    {
                        id = Convert.ToInt32(item.Split('-')[0]);
                        newldocumentoOperModel.Add(new Tipo_documento_oper_validaModel
                        {
                            idTipoOperacao = id,
                        });
                    }
                    foreach (Tipo_documento_oper_validaModel oper in newldocumentoOperModel)
                    {
                        if (ldocumentoOperModel.Where(C => C.idTipoOperacao == oper.idTipoOperacao).Count() > 0)
                        {
                            oper.idTipoDocumentoOperValida = ldocumentoOperModel.FirstOrDefault(C => C.idTipoOperacao == oper.idTipoOperacao).idTipoDocumentoOperValida;
                        }
                    }
                    ldocumentoOperModel = newldocumentoOperModel;
                }
                else
                {
                    ldocumentoOperModel.Clear();
                }


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

                txtCodigo.Text = documentoModel.idTipoDocumento.ToString();
                txtxTpdoc.Text = documentoModel.xTpdoc;
                cbotpDocumento.SelectedIndex = (documentoModel.tpDocumento);
                cbostRelacaoPedidoxorcamento.SelectedIndex = (documentoModel.stRelacaoPedidoxorcamento);
                cbostRelacaoPedidoxnf.SelectedIndex = (documentoModel.stRelacaoPedidoxnf);
                cbostRelacaoPedidoxproducao.SelectedIndex = (documentoModel.stRelacaoPedidoxproducao);
                cbostGrupoFaturamento.SelectedIndex = (documentoModel.stGrupoFaturamento - 1);
                txtxSerieNf.Text = documentoModel.xSerieNf;
                txtxEspecieVolNf.Text = documentoModel.xEspecieVolNf;
                txtxMarcaVolNf.Text = documentoModel.xMarcaVolNf;
                cbostSomaIpi1Dup.SelectedIndex = (documentoModel.stSomaIpi1Dup);
                cbostSomaSt1Dup.SelectedIndex = (documentoModel.stSomaSt1Dup);
                campoxObs.Text = documentoModel.xObs;
                cbostNfComplementar.SelectedIndex = (documentoModel.stNfComplementar);
                cbostNfAtivo.SelectedIndex = (documentoModel.stNfAtivo);
                cbostNFdevolucao.SelectedIndex = (Convert.ToByte(documentoModel.stNFdevolucao));
                cbostNfImportacao.SelectedIndex = (documentoModel.stNfImportacao);
                cbostNfExportacao.SelectedIndex = (documentoModel.stNfExportacao);
                cbostNfIndustrializacao.SelectedIndex = (documentoModel.stNfIndustrializacao);
                cbostNfSuframa.SelectedIndex = (documentoModel.stNfSuframa);
                cbostCompoeVlTotalProdutos.SelectedIndex = (documentoModel.stCompoeVlTotalProdutos);
                cbostSomaDevolucaoVlTotalNf.SelectedIndex = (documentoModel.stSomaDevolucaoVlTotalNf);
                cbostImprimeIcmsProprioComNormal.SelectedIndex = (documentoModel.stImprimeIcmsProprioComNormal);
                cbostRelacaoRecebimentoPedidocpa.SelectedIndex = (documentoModel.stRelacaoRecebimentoPedidocpa);
                cbostRelacaoPedidocpaCotacao.SelectedIndex = (documentoModel.stRelacaoPedidocpaCotacao);
                cboAtivo.SelectedIndex = (documentoModel.Ativo == false ? 0 : 1);
                campoPesquisaidModeloDocFiscal.Value = documentoModel.idModeloDocFiscal;


                lsOperacoesValidas.lst.Items.Clear();
                foreach (Tipo_documento_oper_validaModel oper in ldocumentoOperModel)
                {
                    lsOperacoesValidas.lst.Items.Add(oper.idTipoOperacao + " - " + operacaoService.GetOperacao(Convert.ToInt32(oper.idTipoOperacao)).xOperacao);
                }

            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }

    }
}
