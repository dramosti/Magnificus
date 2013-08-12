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
using HLP.Services.Interfaces.Entries.Gerais;
using HLP.Models.Entries.Gerais;
using HLP.Dependencies;
using HLP.Comum.Messages;
using HLP.Comum.UI.Exception;
using System.Threading;
using ComponentFactory.Krypton.Toolkit;

namespace HLP.UI.Entries.Geral
{
    public partial class FormPlanoPagamento : FormPadraoCadastro
    {
        [Inject]
        public IPlano_pagamentoService planoService { get; set; }

        Plano_pagamentoModel objPlanoModel = new Plano_pagamentoModel();

        Thread threadCarregaGrade = null;

        public FormPlanoPagamento()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
        }

        private void FormPlanoPagamento_Load(object sender, EventArgs e)
        {
            InicializaFormPadrao("vwPlanoPagamento");
            //nudNumParcelas.nud.Leave += new EventHandler(nud_Leave);

        }



        public override void Novo()
        {
            base.Novo();
            objPlanoModel = new Plano_pagamentoModel();
            bsLinhas.DataSource = objPlanoModel.lPlano_pagamento_linhas;
            cbostAlocacao.SelectedIndex = 1;
            cbostFormaPagamento.SelectedIndex = 2;
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
            planoService.Delete(objPlanoModel);
            base.Excluir();
            bsLinhas.DataSource = new List<Plano_pagamento_linhasModel>();

            if (iRetPesquisa != null)
            {
                base.MoveProximoItem();
                objPlanoModel = planoService.GetPlano_pagamento((int)iRetPesquisa, true);
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
                    objPlanoModel = planoService.GetPlano_pagamento((int)lParaExcluir[i], true);
                    planoService.Delete(objPlanoModel);
                    lExcluido.Add(lParaExcluir[i]);
                }
                catch (Exception)
                {
                }
            }
            base.FinalizaExcluirTodos();
        }

        public override void Atualizar()
        {
            base.Atualizar();
            VerificaTipoAlocacao();
        }
        public override void Salvar()
        {
            try
            {
                objValidaCampos.Validar();
                PopulaTabela();

                if (cbostAlocacao.SelectedIndex != 1 && bsLinhas.Count <= 0)
                {
                    throw new Exception("É necessário lançar ao menos um plano de pagamento!");
                }

                planoService.Save(objPlanoModel);

                txtCodigo.Text = objPlanoModel.idPlanoPagamento.ToString();
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
                        objPlanoModel = planoService.GetPlano_pagamento(Convert.ToInt32(txtCodigo.Text), true);
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
                    objPlanoModel = planoService.GetPlano_pagamento((int)iRetPesquisa, true);
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
                    objPlanoModel = planoService.GetPlano_pagamento((int)iRetPesquisa, true);
                    if (objPlanoModel != null)
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
                    objPlanoModel = planoService.GetPlano_pagamento((int)iRetPesquisa, true);
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
                planoService.Copy(objPlanoModel);
                PopulaForm();
                base.RegistroDuplicado(idOrigem, (int)objPlanoModel.idPlanoPagamento);
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
                base.CarregaClasse(objPlanoModel);
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
                base.CarregaPropriedades(objPlanoModel, true);
                base.CarregaForm();
                bsLinhas.DataSource = objPlanoModel.lPlano_pagamento_linhas;
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }

        }

        private void cbostAlocacao__SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificaTipoAlocacao();
        }

        private void VerificaTipoAlocacao()
        {
            if (btnNovo.Enabled == false)
            {
                if (cbostAlocacao.SelectedIndex == 0)
                {
                    nudnAlterar.Enabled = false;
                    nudnAlterar.Text = "";
                    nudnNumerosPagamentos.Enabled = false;
                    nudnNumerosPagamentos.Text = "";
                    nudnValorMoeda.Enabled = false;
                    nudnValorMoeda.Text = "";
                    nudnValorMinimo.Enabled = false;
                    nudnValorMinimo.Text = "";

                    cbostAlocacaoImpostos.Enabled = true;
                    cbostFormaPagamento.Enabled = true;
                    cbostFormaPagamento.SelectedIndex = 2;

                    if (tcPlanosPagamento.TabPages.Count == 1)
                    {
                        tcPlanosPagamento.TabPages.Add(tabPlanPagamento);
                    }
                }
                else if (cbostAlocacao.SelectedIndex == 1)
                {
                    bool bConfirma = true;
                    if (dgvLinhaPagamento.Rows.Count > 1)
                    {
                        tcPlanosPagamento.SelectedTab = tabPlanPagamento;
                        if (KryptonMessageBox.Show("Essa alteração irá excluir os planos de pagamentos, esta certo disso ?", "A V I S O", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {
                            dgvLinhaPagamento.HLP_Clear();
                            cbostAlocacao.Focus();
                        }
                        else
                        {
                            bConfirma = false;
                            cbostAlocacao.Focus();
                        }

                    }
                    if (bConfirma)
                    {
                        nudnValorMoeda.Enabled = false;
                        nudnValorMoeda.Text = "";
                        tcPlanosPagamento.TabPages.Remove(tabPlanPagamento);
                        nudnNumerosPagamentos.Enabled = true;
                        nudnNumerosPagamentos.Text = "0";
                        cbostAlocacaoImpostos.Enabled = true;
                        cbostFormaPagamento.Enabled = true;
                        cbostFormaPagamento.SelectedIndex = 2;
                        nudnAlterar.Enabled = true;
                        nudnAlterar.Text = "0";
                        nudnValorMinimo.Enabled = true;
                        nudnValorMinimo.Text = "0,00";
                    }

                }
                else if (cbostAlocacao.SelectedIndex == 2)
                {
                    nudnNumerosPagamentos.Enabled = false;
                    nudnNumerosPagamentos.Text = "";
                    cbostAlocacaoImpostos.Enabled = false;
                    cbostAlocacaoImpostos.Text = "";
                    cbostAlocacaoImpostos.SelectedIndex = -1;

                    cbostFormaPagamento.Enabled = true;
                    cbostFormaPagamento.SelectedIndex = 2;

                    nudnAlterar.Enabled = false;
                    nudnAlterar.Text = "0";

                    nudnValorMoeda.Enabled = true;
                    nudnValorMoeda.Text = "0,00";
                    nudnValorMinimo.Enabled = true;
                    nudnValorMinimo.Text = "0,00";

                    if (tcPlanosPagamento.TabPages.Count == 1)
                    {
                        tcPlanosPagamento.TabPages.Add(tabPlanPagamento);
                    }
                }
                else if (cbostAlocacao.SelectedIndex == 3)
                {
                    //cbostFormaPagamento.Enabled = false;
                    //cbostFormaPagamento.Text = "";
                    //cbostFormaPagamento.SelectedIndex = -1;
                    nudnAlterar.Enabled = false;
                    nudnAlterar.Text = "";
                    nudnNumerosPagamentos.Enabled = false;
                    nudnNumerosPagamentos.Text = "";
                    nudnValorMoeda.Enabled = false;
                    nudnValorMoeda.Text = "";
                    nudnValorMinimo.Enabled = false;
                    nudnValorMinimo.Text = "";
                    cbostAlocacaoImpostos.Enabled = false;
                    cbostAlocacaoImpostos.Text = "";
                    cbostAlocacaoImpostos.SelectedIndex = -1;

                    if (tcPlanosPagamento.TabPages.Count == 1)
                    {
                        tcPlanosPagamento.TabPages.Add(tabPlanPagamento);
                    }
                }
            }
        }

        private void dgvLinhaPagamento_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (dgvLinhaPagamento.Columns[e.ColumnIndex].Name.Equals("clstValorouPorcentagem"))
                {

                    DataGridViewComboBoxCell cbx = dgvLinhaPagamento[e.ColumnIndex, e.RowIndex] as DataGridViewComboBoxCell;
                    if (Convert.ToInt32(cbx.Value) == 0)
                    {
                        (dgvLinhaPagamento["clnValorouPorcentagem", e.RowIndex] as KryptonDataGridViewNumericUpDownCell).Maximum = 100;
                    }
                    else
                    {
                        (dgvLinhaPagamento["clnValorouPorcentagem", e.RowIndex] as KryptonDataGridViewNumericUpDownCell).Maximum = 10000000000;
                    }
                }
            }
        }


        private void AddGradePlanePgto()
        {
            this.Invoke(new MethodInvoker(delegate()
            {
                if (nudNumParcelas.Value > 0)
                {
                    for (int i = 0; i < nudNumParcelas.Value; i++)
                    {
                        Plano_pagamento_linhasModel item = new Plano_pagamento_linhasModel
                         {
                             nQuantidade = i + 1,
                             stValorouPorcentagem = 0,
                             nValorouPorcentagem = 100 / nudNumParcelas.Value,
                         };
                        item.SetStatusRegistro(Comum.Infrastructure.BaseModelFilhos.statusRegistroFilho.Incluido);
                        objPlanoModel.lPlano_pagamento_linhas.Add(item);
                    }
                }
            }
            ));

            this.BeginInvoke((MethodInvoker)delegate
            {
                bsLinhas.DataSource = null;
                dgvLinhaPagamento.DataSource = null;
                bsLinhas.DataSource = objPlanoModel.lPlano_pagamento_linhas;
                dgvLinhaPagamento.DataSource = bsLinhas;
                dgvLinhaPagamento.HLP_Refresh();
            });



        }

        private void hlP_Button1__btnHlpClick(object sender, EventArgs e)
        {
            try
            {

                List<Plano_pagamento_linhasModel> lPlanos = new List<Plano_pagamento_linhasModel>();
                if (objPlanoModel.lPlano_pagamento_linhas.Where(c => c.idLinhasPagamento != null).Count() > 0)
                {
                    foreach (Plano_pagamento_linhasModel item in objPlanoModel.lPlano_pagamento_linhas.Where(c => c.idLinhasPagamento != null))
                    {
                        item.SetStatusRegistro(Comum.Infrastructure.BaseModelFilhos.statusRegistroFilho.Excluido);
                        lPlanos.Add(item);
                    }
                }
                objPlanoModel.lPlano_pagamento_linhas = lPlanos;

                //bsLinhas.DataSource = objPlanoModel.lPlano_pagamento_linhas;
                //dgvLinhaPagamento.Refresh();

                threadCarregaGrade = new Thread(AddGradePlanePgto);
                threadCarregaGrade.IsBackground = true;
                threadCarregaGrade.Start();
            }
            catch (Exception ex)
            {
                throw new HLPexception(ex);
            }

        }




    }
}
