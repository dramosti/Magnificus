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

using HLP.Models.Entries.Comercial;
using HLP.Comum.UI.Exception;
using HLP.Comum.Messages;
using System.Threading;
using HLP.Services.Interfaces.Entries.Gerais;
using HLP.Models.Entries.Gerais;
using HLP.Comum.Infrastructure.Static;

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
            CarregaPropriedades(objProduto, true);
            CarregaForm();
        }

        void PopulaTabela()
        {
            CarregaClasse(objProduto);

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
