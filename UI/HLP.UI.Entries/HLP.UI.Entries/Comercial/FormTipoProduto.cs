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
using HLP.Services.Interfaces.Entries.Comercial;
using HLP.Models.Entries.Comercial;
using HLP.Dependencies;
using HLP.Comum.Messages;
using HLP.Comum.UI.Exception;
using System.Threading;

namespace HLP.UI.Entries.Comercial
{
    public partial class FormTipoProduto : FormPadraoCadastro
    {
        [Inject]
        public ITipo_produtoService tipoService { get; set; }

        [Inject]
        public IProdutoService produtoService { get; set; }

        Tipo_produtoModel tipoModel = new Tipo_produtoModel();


        public FormTipoProduto()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
        }

        private void FormTipoProduto_Load(object sender, EventArgs e)
        {
            InicializaFormPadrao("vwTipoProduto");
        }



        public override void Novo()
        {
            base.Novo();
            tipoModel = new Tipo_produtoModel();
            bsProduto.DataSource = new List<ProdutoModel>();
            btnVisualizar.Enabled = false;
            dgvProdutos.ReadOnly = true;
            dgvProdutos.AllowUserToAddRows = false;

            cbostPatrimonio.SelectedIndex = 0;
            cbostProducao.SelectedIndex = 0;
            cbostEstoque.SelectedIndex = 0;
            cbostCompras.SelectedIndex = 0;
            cbostComercial.SelectedIndex = 0;
            cbostTerceiros.SelectedIndex = 0;
            cbostServicos.SelectedIndex = 0;
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
            tipoService.Delete(Convert.ToInt32(txtCodigo.Text));
            base.Excluir();
            bsProduto.DataSource = new List<ProdutoModel>();

            if (iRetPesquisa != null)
            {
                base.MoveProximoItem();
                tipoModel = tipoService.GetTipo((int)iRetPesquisa);
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
                    tipoService.Delete((int)lParaExcluir[i]);
                    lExcluido.Add(lParaExcluir[i]);
                }
                catch (Exception ex)
                {
                }
            }
            base.FinalizaExcluirTodos();
        }

        public override void Atualizar()
        {
            base.Atualizar();
            btnVisualizar.Enabled = true;
            dgvProdutos.ReadOnly = true;
            dgvProdutos.AllowUserToAddRows = false;
        }
        public override void Salvar()
        {
            try
            {
                objValidaCampos.Validar();

                PopulaTabela();
                tipoService.Save(tipoModel);

                txtCodigo.Text = tipoModel.idTipoProduto.ToString();

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
                        tipoModel = tipoService.GetTipo(Convert.ToInt32(txtCodigo.Text));
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
                    tipoModel = tipoService.GetTipo((int)iRetPesquisa);
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
                    tipoModel = tipoService.GetTipo((int)iRetPesquisa);
                    if (tipoModel != null)
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
                    tipoModel = tipoService.GetTipo((int)iRetPesquisa);
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
                int i = tipoService.Copy(Convert.ToInt32(txtCodigo.Text));
                tipoModel = tipoService.GetTipo(i);
                PopulaForm();
                base.RegistroDuplicado(idOrigem, i);
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
                tipoModel.xTipo = txtxTipo.Text;
                tipoModel.xDescricao = txtxDescricao.Text;
                tipoModel.stPatrimonio = cbostPatrimonio.SelectedIndexByte;
                tipoModel.stProducao = cbostProducao.SelectedIndexByte;
                tipoModel.stEstoque = cbostEstoque.SelectedIndexByte;
                tipoModel.stCompras = cbostCompras.SelectedIndexByte;
                tipoModel.stComercial = cbostComercial.SelectedIndexByte;
                tipoModel.stTerceiros = cbostTerceiros.SelectedIndexByte;
                tipoModel.stServicos = cbostServicos.SelectedIndexByte;


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
                txtCodigo.Text = tipoModel.idTipoProduto.ToString();
                txtxTipo.Text = tipoModel.xTipo;
                txtxDescricao.Text = tipoModel.xDescricao;
                cbostPatrimonio.SelectedIndex = tipoModel.stPatrimonio;
                cbostProducao.SelectedIndex = tipoModel.stProducao;
                cbostEstoque.SelectedIndex = tipoModel.stEstoque;
                cbostCompras.SelectedIndex = tipoModel.stCompras;
                cbostComercial.SelectedIndex = tipoModel.stComercial;
                cbostTerceiros.SelectedIndex = tipoModel.stTerceiros;
                cbostServicos.SelectedIndex = tipoModel.stServicos;

                btnVisualizar.Enabled = true;
                dgvProdutos.ReadOnly = true;
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }

        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtCodigo.Text.Equals(""))
                {
                    bsProduto.DataSource = produtoService.GetByProdutoType(Convert.ToInt32(txtCodigo.Text));
                }
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }
    }
}
