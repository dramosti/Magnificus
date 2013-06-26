using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using HLP.Comum.Messages;
using HLP.Comum.Models.Static;
using HLP.Comum.Services.Interface;
using HLP.Comum.UI;
using HLP.Comum.UI.Exception;
using HLP.Dependencies;
using HLP.Models.Entries.Gerais;
using HLP.Services.Interfaces.Entries.Comercial;
using HLP.Services.Interfaces.Entries.Gerais;
using Ninject;

namespace HLP.UI.Entries.Geral
{
    public partial class FormConversao : FormPadraoCadastro
    {
        [Inject]
        public IConversaoService conversaoService { get; set; }

        [Inject]
        public IProdutoService produtoService { get; set; }

        [Inject]
        public IPesquisaPadraoService pesquisaPadraoService { get; set; }

        List<ConversaoModel> lConversao = new List<ConversaoModel>();
        ConversaoModel objConversao = new ConversaoModel();

        int idUnidadeMedida = 0;
        Action verifBw = null;

        public FormConversao()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
            sepDuplicar.Visible = btnDuplicar.Visible = false;
        }

        private void FormConversao_Load(object sender, EventArgs e)
        {
            try
            {
                idDeUnidadeMedida.Tag = "FormUnidadeMedida-vwUnidadeMedida-xSiglaPadrao";
                idParaUnidadeMedida.Tag = "FormUnidadeMedida-vwUnidadeMedida-xSiglaPadrao";

                InicializaFormPadrao("vwProduto");

                verifBw += (() =>
                    {
                        CarregaCombosGrid();
                    });

                Thread t1 = new Thread(new ThreadStart(verifBw));
                t1.Start();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void CarregaCombosGrid()
        {
            if (objMetodosForm != null)
            {
                idDeUnidadeMedida.DataSource = pesquisaPadraoService.GetData(objMetodosForm.GetDisplayMember(idDeUnidadeMedida), true);
                idParaUnidadeMedida.DataSource = pesquisaPadraoService.GetData(objMetodosForm.GetDisplayMember(idParaUnidadeMedida), true);
                Thread.CurrentThread.Abort();
            }
            else
            {
                Thread.Sleep(500);
                CarregaCombosGrid();
            }
        }


        public override void Novo()
        {
            base.Novo();
            bsConversao.DataSource = new List<ConversaoModel>();
            dgvConversao.ReadOnly = true;
            hlP_PesquisaidProduto.Value = 0;
            hlP_PesquisaidProduto.Enabled = true;
            hlP_PesquisaidProduto.Focus();
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
                    objConversao = conversaoService.GetConversao((int)lParaExcluir[i]);
                    conversaoService.Delete(objConversao);
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
            conversaoService.Delete(hlP_PesquisaidProduto.Value);
            base.Excluir();
            if (iRetPesquisa != null)
            {
                base.MoveProximoItem();
                lConversao = conversaoService.GetAll((int)iRetPesquisa);
                bsConversao.DataSource = lConversao;
                hlP_PesquisaidProduto.Value = (int)iRetPesquisa;
            }
        }

        public override void Atualizar()
        {
            base.Atualizar();
            hlP_PesquisaidProduto.Enabled = false;
            btnInserir.Enabled = false;
            idDeUnidadeMedida.ReadOnly = true;
            idUnidadeMedida = produtoService.GetProduto(hlP_PesquisaidProduto.Value).idUnidadeMedidaEstoque;
        }
        public override void Salvar()
        {
            try
            {
                objValidaCampos.Validar();
                foreach (ConversaoModel conversao in bsConversao.List)
                {
                    conversao.idEmpresa = CompanyData.idEmpresa;
                    conversao.idProduto = hlP_PesquisaidProduto.Value;
                    conversaoService.Save(conversao);
                }

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
                    lConversao = conversaoService.GetAll(hlP_PesquisaidProduto.Value);
                    bsConversao.DataSource = lConversao;
                    HabilitaBotoes(1);
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
                    lConversao = conversaoService.GetAll((int)iRetPesquisa);
                    bsConversao.DataSource = lConversao;
                    hlP_PesquisaidProduto.Value = (int)iRetPesquisa;
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
                    lConversao = conversaoService.GetAll((int)iRetPesquisa);
                    bsConversao.DataSource = lConversao;
                    hlP_PesquisaidProduto.Value = (int)iRetPesquisa;
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


        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (hlP_PesquisaidProduto.Value != 0)
            {
                hlP_PesquisaidProduto.Enabled = false;
                btnInserir.Enabled = false;
                dgvConversao.ReadOnly = false;
                idDeUnidadeMedida.ReadOnly = true;

                idUnidadeMedida = produtoService.GetProduto(hlP_PesquisaidProduto.Value).idUnidadeMedidaEstoque;

                lConversao = conversaoService.GetAll(hlP_PesquisaidProduto.Value);
                bsConversao.DataSource = new List<ConversaoModel>();
                bsConversao.DataSource = lConversao;
            }
            else
            {
                HLPMessageBox.ShowAviso("Selecione primeiro um produto para lançar as conversões.");
                hlP_PesquisaidProduto.Focus();
            }
        }

        private void dgvConversao_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            //if (e.Row.Cells["idDeUnidadeMedida"].Value != null)
            e.Row.Cells["idDeUnidadeMedida"].Value = idUnidadeMedida;
            //if (e.Row.Cells["nFator"].Value != null)
            e.Row.Cells["nFator"].Value = "0".ToDecimal();
            //if (e.Row.Cells["nQuantidadeAdicional"].Value != null)
            e.Row.Cells["nQuantidadeAdicional"].Value = "0".ToDecimal();
        }

        private void dgvConversao_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //0-PARA BAIXO
                //1-PARA CIMA

                decimal dFator = 0;
                int Soma = 0;
                if (dgvConversao.Columns[e.ColumnIndex] == nFator)
                {
                    if (dgvConversao["nFator", e.RowIndex].Value != null)
                    {
                        dFator = Convert.ToDecimal(dgvConversao["nFator", e.RowIndex].Value);
                    }
                    if (dFator != 0)
                    {
                        if (Convert.ToInt32(dgvConversao["stArrendondar", e.RowIndex].Value) == 0)
                        {
                            dgvConversao["nFator", e.RowIndex].Value = Math.Floor(dFator);
                        }
                        else
                        {
                            dgvConversao["nFator", e.RowIndex].Value = Math.Ceiling(dFator);
                        }
                    }
                }
                else if (dgvConversao.Columns[e.ColumnIndex] == nQuantidadeAdicional)
                {
                    if (dgvConversao["nQuantidadeAdicional", e.RowIndex].Value != null)
                    {
                        dFator = Convert.ToDecimal(dgvConversao["nQuantidadeAdicional", e.RowIndex].Value);
                    }
                    if (dFator != 0)
                    {
                        if (Convert.ToInt32(dgvConversao["stArrendondar", e.RowIndex].Value) == 0)
                        {
                            dgvConversao["nQuantidadeAdicional", e.RowIndex].Value = Math.Floor(dFator);
                        }
                        else
                        {
                            dgvConversao["nQuantidadeAdicional", e.RowIndex].Value = Math.Ceiling(dFator);
                        }
                    }
                }
                decimal inQuantidadeAdicional = dgvConversao["nQuantidadeAdicional", e.RowIndex].Value == null ? 0 : Convert.ToDecimal(dgvConversao["nQuantidadeAdicional", e.RowIndex].Value);
                decimal inFator = dgvConversao["nFator", e.RowIndex].Value == null ? 0 : Convert.ToDecimal(dgvConversao["nFator", e.RowIndex].Value);

                Soma = Convert.ToInt32(inQuantidadeAdicional + inFator);
                lblConversao.Text = "Conversão: 1 " + dgvConversao["idParaUnidadeMedida", e.RowIndex].EditedFormattedValue.ToString() +
                     " = " + Soma + " " + dgvConversao["idDeUnidadeMedida", e.RowIndex].EditedFormattedValue.ToString();
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }

        private void dgvConversao_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                decimal inQuantidadeAdicional = dgvConversao["nQuantidadeAdicional", e.RowIndex].Value == null ? 0 : Convert.ToDecimal(dgvConversao["nQuantidadeAdicional", e.RowIndex].Value);
                decimal inFator = dgvConversao["nFator", e.RowIndex].Value == null ? 0 : Convert.ToDecimal(dgvConversao["nFator", e.RowIndex].Value);

                int Soma = Convert.ToInt32(inQuantidadeAdicional + inFator);
                lblConversao.Text = "Conversão: 1 " + dgvConversao["idParaUnidadeMedida", e.RowIndex].EditedFormattedValue.ToString() +
                     " = " + Soma + " " + dgvConversao["idDeUnidadeMedida", e.RowIndex].EditedFormattedValue.ToString();
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }



    }
}

