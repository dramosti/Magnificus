using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using HLP.Comum.UI;
using Ninject;
using HLP.Services.Interfaces.Entries.Gerais;
using HLP.Models.Entries.Gerais;
using HLP.Dependencies;
using HLP.Comum.Services.Interface;
using HLP.Comum.UI.Exception;
using HLP.Comum.Messages;
using HLP.Comum.Models.Static;
using System.Linq;
using System.IO;
using System.Threading;
using HLP.Comum.Infrastructure;
namespace HLP.UI.Entries.RecursosHumanos
{
    public partial class FormFuncionario : FormPadraoCadastro
    {
        [Inject]
        public IFuncionarioService funcionarioService { get; set; }
        [Inject]
        public IPesquisaPadraoService pesquisaPadraoService { get; set; }

        FuncionarioModel objFuncionarioModel = new FuncionarioModel();
        Action verifBw = null;

        public FormFuncionario()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
        }

        private void FormContato_Load(object sender, EventArgs e)
        {
            idCidade.Tag = "FormCidade-vwCidade-xCidade_Uf_xRegiao_xPais";
            idProduto.Tag = "FormProduto-vwProduto-xPesquisa";            
            InicializaFormPadrao("vwFuncionario");

            verifBw += (() =>
            {
                InitializaComboBox();
            });

            Thread t1 = new Thread(new ThreadStart(verifBw));
            t1.Start();

            CarregaTreeview();
            dtdQtdHorasSegunda.dtp.Validated += new EventHandler(dtp_Validated);
            dtdQtdHorasTerca.dtp.Validated += new EventHandler(dtp_Validated);
            dtdQtdHorasQuarta.dtp.Validated += new EventHandler(dtp_Validated);
            dtdQtdHorasQuinta.dtp.Validated += new EventHandler(dtp_Validated);
            dtdQtdHorasSexta.dtp.Validated += new EventHandler(dtp_Validated);
            dtdQtdHorasSabado.dtp.Validated += new EventHandler(dtp_Validated);
            dtdQtdHorasDomingo.dtp.Validated += new EventHandler(dtp_Validated);
        }


        private void InitializaComboBox()
        {
            if (objMetodosForm != null)
            {
                idCidade.DataSource = pesquisaPadraoService.GetData(objMetodosForm.GetDisplayMember(idCidade), true);
                idProduto.DataSource = pesquisaPadraoService.GetData(objMetodosForm.GetDisplayMember(idProduto), true);
                Thread.CurrentThread.Abort();
            }
            else
            {
                Thread.Sleep(500);
                InitializaComboBox();
            }            
        }

        public override void Novo()
        {
            try
            {
                base.Novo();
                cbxstSalario.SelectedIndex = 1;
                cbxstComissao.SelectedIndex = 0;
                objFuncionarioModel = new FuncionarioModel();
                bsFuncionarioArquivo.DataSource = objFuncionarioModel.lFuncionario_Arquivo;
                bsFuncionarioCertificacao.DataSource = objFuncionarioModel.lFuncionario_Certificacao;
                bsFuncionarioComissaoProduto.DataSource = objFuncionarioModel.lFuncionario_Comissao_Produto;
                bsFuncionarioEndereco.DataSource = objFuncionarioModel.lFuncionario_Endereco;
                bsFuncionarioMargemLucroComissao.DataSource = objFuncionarioModel.lFuncionario_Margem_Lucro_Comissao;                
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }
        public override void Salvar()
        {
            try
            {
                objValidaCampos.Validar();
                PopulaTabela();

                funcionarioService.Save(objFuncionarioModel);

                base.Salvar();
                txtCodigo.Text = objFuncionarioModel.idFuncionario.ToString();
                CarregaTreeview();
            }
            catch (Exception ex)
            {
                new HLPexception(ex, this);
            }
        }
        public override void Atualizar()
        {
            base.Atualizar();            
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
                    objFuncionarioModel = funcionarioService.GetFuncionario((int)iRetPesquisa, true);
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
                    objFuncionarioModel = funcionarioService.GetFuncionario((int)iRetPesquisa, true);
                    if (objFuncionarioModel != null)
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
        public override void Duplicar()
        {
            try
            {
                int idOrigem = Convert.ToInt32(txtCodigo.Text);
                funcionarioService.Copy(objFuncionarioModel);
                PopulaForm();
                base.RegistroDuplicado(idOrigem, (int)objFuncionarioModel.idFuncionario);
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
                    objFuncionarioModel = funcionarioService.GetFuncionario((int)iRetPesquisa, true);
                    PopulaForm();
                }
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
                //if (cbxstUsuario.Text == "0 - HLP")
                //{
                //    throw new Exception("Não é possível excluir usuário do tipo HLP");
                //}
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
                    objFuncionarioModel = funcionarioService.GetFuncionario((int)lParaExcluir[i], true);
                    funcionarioService.Delete(objFuncionarioModel);
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
            funcionarioService.Delete(objFuncionarioModel);
            base.Excluir();
            if (iRetPesquisa != null)
            {
                base.MoveProximoItem();
                objFuncionarioModel = funcionarioService.GetFuncionario((int)iRetPesquisa, true);
                PopulaForm();
            }
        }


        void PopulaForm()
        {
         
            bsFuncionarioArquivo.DataSource = objFuncionarioModel.lFuncionario_Arquivo;
            bsFuncionarioCertificacao.DataSource = objFuncionarioModel.lFuncionario_Certificacao;
            bsFuncionarioComissaoProduto.DataSource = objFuncionarioModel.lFuncionario_Comissao_Produto;
            bsFuncionarioEndereco.DataSource = objFuncionarioModel.lFuncionario_Endereco;
            bsFuncionarioMargemLucroComissao.DataSource = objFuncionarioModel.lFuncionario_Margem_Lucro_Comissao;


            #region Geral
            txtCodigo.Text = objFuncionarioModel.idFuncionario.ToString();
            txtxCodigoAlternativo.Text = objFuncionarioModel.xCodigoAlternativo;
            cbxAtivo.SelectedIndex = objFuncionarioModel.Ativo == true ? 1 : 0;
            txtxSaudacao.Text = objFuncionarioModel.xSaudacao;
            txtxNome.Text = objFuncionarioModel.xNome;
            hlP_PesquisaidCargo.Value = objFuncionarioModel.idCargo;
            hlP_Pesquisa_idDepartamento.Value = objFuncionarioModel.idDepartamento;
            cbxstPerfil.SelectedIndex = objFuncionarioModel.stPerfil;
            if (objFuncionarioModel.idCalendario != null)
                hlP_PesquisaidCalendário.Value = (int)objFuncionarioModel.idCalendario;
            hlP_PesquisaidSite.Value = objFuncionarioModel.idSite;
            hlP_PesquisaidDeposito.Value = objFuncionarioModel.idDeposito;
            txtxInformacaoAtencao.Text = objFuncionarioModel.xInformacaoAtencao;
            #endregion

            #region Informaçoes pessoais
            dtdAniversario.Value = objFuncionarioModel.dAniversario;
            cbxstSexo.SelectedIndex = objFuncionarioModel.stSexo;
            dtdFalecimento.Value = objFuncionarioModel.dFalecimento;
            mskxCpf.Text = objFuncionarioModel.xCpf;
            txtxRg.Text = objFuncionarioModel.xRg;
            txtxConjugue.Text = objFuncionarioModel.xConjugue;
            txtxFilhos.Text = objFuncionarioModel.xFilhos;
            hlP_PesquisaidContaBancaria.Value = objFuncionarioModel.idContaBancaria;
            txtxVisto.Text = objFuncionarioModel.xVisto;
            dtdFinalVisto.Value = objFuncionarioModel.dFinalVisto;
            txtxVistoTrabalho.Text = objFuncionarioModel.xVistoTrabalho;
            dtdFinalVistoTrabalho.Value = objFuncionarioModel.dFinalVistoTrabalho;
            dtdAdmissao.Value = objFuncionarioModel.dAdmissao;
            nudvDiaria.Value = objFuncionarioModel.vDiaria;
            cbxstSalario.SelectedIndex = objFuncionarioModel.stSalario;
            nudvSalario.Value = objFuncionarioModel.vSalario;
            nudvSalarioHora.Value = objFuncionarioModel.vSalarioHora;
            if (objFuncionarioModel.idResponsavel != null)
            {
                hlP_PesquisaidResponsavel.Value = (int)objFuncionarioModel.idResponsavel;
            }
            else
            {
                hlP_PesquisaidResponsavel.Value = 0;
            }
            dtdQtdHorasDomingo.Value = DateTime.Now + objFuncionarioModel.dQtdHorasDomingo;
            dtdQtdHorasSabado.Value = DateTime.Now + objFuncionarioModel.dQtdHorasSabado;
            dtdQtdHorasSegunda.Value = DateTime.Now + objFuncionarioModel.dQtdHorasSegunda;
            dtdQtdHorasTerca.Value = DateTime.Now + objFuncionarioModel.dQtdHorasTerca;
            dtdQtdHorasQuarta.Value = DateTime.Now + objFuncionarioModel.dQtdHorasQuarta;
            dtdQtdHorasQuinta.Value = DateTime.Now + objFuncionarioModel.dQtdHorasQuinta;
            dtdQtdHorasSexta.Value = DateTime.Now + objFuncionarioModel.dQtdHorasSexta;
            #endregion

            #region Inf. de Contato
            txtxTelefoneComercial.Text = objFuncionarioModel.xTelefoneComercial;
            txtxRamalComercial.Text = objFuncionarioModel.xRamalComercial;
            txtxCelularComercial.Text = objFuncionarioModel.xCelularComercial;
            txtxRadioFoneComercial.Text = objFuncionarioModel.xRadioFoneComercial;
            txtxPagerComercial.Text = objFuncionarioModel.xPagerComercial;
            txtxFaxComercial.Text = objFuncionarioModel.xFaxComercial;
            txtxEmailComercial.Text = objFuncionarioModel.xEmailComercial;
            txtxSkypeComercial.Text = objFuncionarioModel.xSkypeComercial;
            txtxMSNComercial.Text = objFuncionarioModel.xMsnComercial;
            txtxhttpComercial.Text = objFuncionarioModel.xHttpComercial;
            txtxCelularResidencial.Text = objFuncionarioModel.xCelularResidencial;
            txtxTelefoneResidencial.Text = objFuncionarioModel.xTelefoneResidencial;
            txtxTelefoneResidencial.Text = objFuncionarioModel.xCelularResidencial;
            txtxRadioFoneResidencial.Text = objFuncionarioModel.xRadioFoneResidencial;
            txtxEmailResidencial.Text = objFuncionarioModel.xEmailResidencial;
            txtxSkypeResidencial.Text = objFuncionarioModel.xSkypeResidencial;
            txtxMsnResidencial.Text = objFuncionarioModel.xMsnResidencial;
            txtXhttpPessoal.Text = objFuncionarioModel.xHttpPessoal;
            #endregion

            #region Representante
            cbxstComissao.SelectedIndex = objFuncionarioModel.stComissao;
            nudpComissaoAvista.Value = objFuncionarioModel.pComissaoAvista;
            nudpComissaoAprazo.Value = objFuncionarioModel.pComissaoAprazo;
            #endregion

            CalcHorasTrab();
        }        

        void PopulaTabela()
        {
            //verificar
            objFuncionarioModel.xFormacaoEducacional = "";
            objFuncionarioModel.xNota = "";

            objFuncionarioModel.idEmpresa = CompanyData.idEmpresa;

            #region Geral
            objFuncionarioModel.xCodigoAlternativo = txtxCodigoAlternativo.Text;
            objFuncionarioModel.Ativo = cbxAtivo.SelectedIndex == 0 ? false : true;
            objFuncionarioModel.xSaudacao = txtxSaudacao.Text;
            objFuncionarioModel.xNome = txtxNome.Text;
            objFuncionarioModel.idCargo = hlP_PesquisaidCargo.Value;
            objFuncionarioModel.idDepartamento = hlP_Pesquisa_idDepartamento.Value;
            objFuncionarioModel.stPerfil = cbxstPerfil.SelectedIndex;
            if (hlP_PesquisaidCalendário.Value != 0)
            {
                objFuncionarioModel.idCalendario = Convert.ToInt32(hlP_PesquisaidCalendário.Value);
            }
            objFuncionarioModel.idSite = hlP_PesquisaidSite.Value;
            objFuncionarioModel.idDeposito = hlP_PesquisaidDeposito.Value;
            objFuncionarioModel.xInformacaoAtencao = txtxInformacaoAtencao.Text;
            #endregion

            #region Informaçoes pessoais
            objFuncionarioModel.dAniversario = dtdAniversario.Value;
            objFuncionarioModel.stSexo = cbxstSexo.SelectedIndexByte;
            objFuncionarioModel.dFalecimento = dtdFalecimento.Value;
            objFuncionarioModel.xCpf = mskxCpf.Text;
            objFuncionarioModel.xRg = txtxRg.Text;
            objFuncionarioModel.xConjugue = txtxConjugue.Text;
            objFuncionarioModel.xFilhos = txtxFilhos.Text;
            objFuncionarioModel.idContaBancaria = hlP_PesquisaidContaBancaria.Value;
            objFuncionarioModel.xVisto = txtxVisto.Text;
            objFuncionarioModel.dFinalVisto = dtdFinalVisto.Value;
            objFuncionarioModel.xVistoTrabalho = txtxVistoTrabalho.Text;
            objFuncionarioModel.dFinalVistoTrabalho = dtdFinalVistoTrabalho.Value;
            objFuncionarioModel.dAdmissao = dtdAdmissao.Value;
            nudvDiaria.Value = objFuncionarioModel.vDiaria;
            objFuncionarioModel.stSalario = cbxstSalario.SelectedIndexByte;
            objFuncionarioModel.vSalario = nudvSalario.Value;
            objFuncionarioModel.vSalarioHora = nudvSalarioHora.Value;
            if (hlP_PesquisaidResponsavel.Value != 0)
            {
                objFuncionarioModel.idResponsavel = hlP_PesquisaidResponsavel.Value;
            }
            objFuncionarioModel.dQtdHorasDomingo = dtdQtdHorasDomingo.Value.TimeOfDay;
            objFuncionarioModel.dQtdHorasSabado = dtdQtdHorasSabado.Value.TimeOfDay;
            objFuncionarioModel.dQtdHorasSegunda = dtdQtdHorasSegunda.Value.TimeOfDay;
            objFuncionarioModel.dQtdHorasTerca = dtdQtdHorasTerca.Value.TimeOfDay;
            objFuncionarioModel.dQtdHorasQuarta = dtdQtdHorasQuarta.Value.TimeOfDay;
            objFuncionarioModel.dQtdHorasQuinta = dtdQtdHorasQuinta.Value.TimeOfDay;
            objFuncionarioModel.dQtdHorasSexta = dtdQtdHorasSexta.Value.TimeOfDay;
            #endregion

            #region Inf. de Contato
            objFuncionarioModel.xTelefoneComercial = txtxTelefoneComercial.Text;
            objFuncionarioModel.xRamalComercial = txtxRamalComercial.Text;
            objFuncionarioModel.xCelularComercial = txtxCelularComercial.Text;
            objFuncionarioModel.xRadioFoneComercial = txtxRadioFoneComercial.Text;
            objFuncionarioModel.xPagerComercial = txtxPagerComercial.Text;
            objFuncionarioModel.xFaxComercial = txtxFaxComercial.Text;
            objFuncionarioModel.xEmailComercial = txtxEmailComercial.Text;
            objFuncionarioModel.xSkypeComercial = txtxSkypeComercial.Text;
            objFuncionarioModel.xMsnComercial = txtxMSNComercial.Text;
            objFuncionarioModel.xHttpComercial = txtxhttpComercial.Text;
            objFuncionarioModel.xTelefoneResidencial = txtxTelefoneResidencial.Text;
            objFuncionarioModel.xCelularResidencial = txtxTelefoneResidencial.Text;
            objFuncionarioModel.xRadioFoneResidencial = txtxRadioFoneResidencial.Text;
            objFuncionarioModel.xEmailResidencial = txtxEmailResidencial.Text;
            objFuncionarioModel.xSkypeResidencial = txtxSkypeResidencial.Text;
            objFuncionarioModel.xMsnResidencial = txtxMsnResidencial.Text;
            objFuncionarioModel.xHttpPessoal = txtXhttpPessoal.Text;
            #endregion

            #region Representante
            objFuncionarioModel.stComissao = cbxstComissao.SelectedIndexByte;
            objFuncionarioModel.pComissaoAvista = nudpComissaoAvista.Value;
            objFuncionarioModel.pComissaoAprazo = nudpComissaoAprazo.Value;
            #endregion

        }

        private void btnCarregarProdutos_Click(object sender, EventArgs e)
        {
            try
            {
                string notIn = String.Join(",", objFuncionarioModel.lFuncionario_Comissao_Produto.Select(c => c.idProduto).ToArray());
                string sWhere = "and p.idProduto not in (" + notIn + ")";

                DataTable dt = pesquisaPadraoService.GetData(string.Format("SELECT p.idProduto, p.xPesquisa from Produto p where p.Ativo = 1 {0}", notIn != "" ? sWhere : ""), false);
                foreach (DataRow row in dt.Rows)
                {
                    bsFuncionarioComissaoProduto.Add(new Funcionario_Comissao_ProdutoModel
                     {
                         idProduto = (int)row["idProduto"],
                         pComissaoAprazo = nudpComissaoAprazo.Value,
                         pComissaoAvista = nudpComissaoAvista.Value
                     });
                }
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }

        }

        private void dgvFuncionario_Comissao_Produto_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    if (dgvFuncionario_Comissao_Produto.Columns[e.ColumnIndex] == idProduto)
                    {
                        if (dgvFuncionario_Comissao_Produto["idProduto", e.RowIndex].Value != null)
                        {
                            int idProd = Convert.ToInt32(dgvFuncionario_Comissao_Produto["idProduto", e.RowIndex].Value);
                            if (idProd != 0)
                            {
                                if (((List<Funcionario_Comissao_ProdutoModel>)bsFuncionarioComissaoProduto.List).Where(C => C.idProduto == idProd).Count() > 1)
                                {
                                    dgvFuncionario_Comissao_Produto["idProduto", e.RowIndex].Value = 0;
                                    KryptonMessageBox.Show("Produto já inserido na lista!", Mensagens.MSG_Aviso, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnAplicarComissao_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (object item in bsFuncionarioComissaoProduto.List)
                {
                    (item as Funcionario_Comissao_ProdutoModel).pComissaoAvista = nudpComissaoAvista.Value;
                    (item as Funcionario_Comissao_ProdutoModel).pComissaoAprazo = nudpComissaoAprazo.Value;
                }
                dgvFuncionario_Comissao_Produto.Refresh();
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonDataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvArquivos.Columns[e.ColumnIndex].DataPropertyName.Equals("xLink"))
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
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }


        private void CarregaTreeview()
        {
            try
            {
                treeHierarquia.Nodes.Clear();
                List<FuncionarioModel> lFuncionarios = funcionarioService.GetAllFuncionario();
                TreeNode node = new TreeNode();
                foreach (FuncionarioModel patrao in lFuncionarios.Where(c => c.idResponsavel == null).ToList())
                {
                    node = new TreeNode();
                    node.Text = patrao.xNome;
                    node.Tag = patrao.idFuncionario;
                    CarregaNodeFilhos(node, lFuncionarios);
                    treeHierarquia.Nodes.Add(node);
                }
                treeHierarquia.ExpandAll();
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }

        void CarregaNodeFilhos(TreeNode nodePai, List<FuncionarioModel> lFuncionarios)
        {
            TreeNode node;
            if (lFuncionarios.Where(c => c.idResponsavel == Convert.ToInt32(nodePai.Tag)).Count() > 0)
            {
                foreach (FuncionarioModel funcinario in lFuncionarios.Where(c => c.idResponsavel == Convert.ToInt32(nodePai.Tag)))
                {
                    node = new TreeNode();
                    node.Text = funcinario.xNome;
                    node.Tag = funcinario.idFuncionario;
                    nodePai.Nodes.Add(node);
                    CarregaNodeFilhos(node, lFuncionarios);
                }
            }
        }
        void dtp_Validated(object sender, EventArgs e)
        {
            CalcHorasTrab();

        }

        private void CalcHorasTrab()
        {
            try
            {
                List<DateTime> lHorasTrab = new List<DateTime>();
                lHorasTrab.Add(dtdQtdHorasDomingo.Value);
                lHorasTrab.Add(dtdQtdHorasSegunda.Value);
                lHorasTrab.Add(dtdQtdHorasTerca.Value);
                lHorasTrab.Add(dtdQtdHorasQuarta.Value);
                lHorasTrab.Add(dtdQtdHorasQuinta.Value);
                lHorasTrab.Add(dtdQtdHorasSexta.Value);
                lHorasTrab.Add(dtdQtdHorasSabado.Value);

                txtTotalHorasTab.Text = funcionarioService.CalculaTotalHorasTrabSemanal(lHorasTrab);
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }

        private void txtxVistoTrabalho_Load(object sender, EventArgs e)
        {

        }

        private void dtdAdmissao_Load(object sender, EventArgs e)
        {

        }

        private void dtdQtdHorasSabado_Load(object sender, EventArgs e)
        {

        }
    }
}