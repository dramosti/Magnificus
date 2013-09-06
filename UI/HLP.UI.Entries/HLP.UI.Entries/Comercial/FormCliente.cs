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
        public IParametro_FinanceiroService paramFinanceiroService { get; set; }

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
                cbostCreditoAprovado.SelectedIndex = paramFinanceiroService.GetCreditoAprovado() == true ? 1 : 0;
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
            base.CarregaClasse(objCliForModel);
            base.CarregaClasse(objCliForModel.cliforFiscalModel == null ? objCliForModel.cliforFiscalModel =
                new Cliente_fornecedor_fiscalModel() : objCliForModel.cliforFiscalModel);
        }

        private void PopulaForm()
        {
            try
            {
                base.CarregaPropriedades(objCliForModel, true);
                base.CarregaPropriedades(objCliForModel.cliforFiscalModel);
                base.CarregaForm();

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
