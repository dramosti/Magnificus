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
using HLP.Services.Interfaces.Entries.Financeiro;
using HLP.Models.Entries.Financeiro;
using HLP.Dependencies;
using HLP.Comum.UI.Exception;
using HLP.Comum.Messages;
using System.Threading;
using HLP.Comum.Models;
using HLP.Comum.Infrastructure;

namespace HLP.UI.Entries.Financeiro
{
    public partial class FormDiaPagamento : FormPadraoCadastro
    {
        [Inject]
        public IDia_PagamentoService diaPagamentoService { get; set; }

        Dia_pagamentoModel objDiaPagamento = new Dia_pagamentoModel();


        public FormDiaPagamento()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
        }

        private void FormDiaPagamento_Load(object sender, EventArgs e)
        {
            InicializaFormPadrao("vwDiaPagamento");
        }


        public override void Novo()
        {
            base.Novo();
            objDiaPagamento = new Dia_pagamentoModel();
            bsdiaPagamentoLinhas.DataSource = objDiaPagamento.lDia_pagamento_linhas;
            clnDia.Maximum = 31;
        }

        public override void Salvar()
        {
            try
            {
                objValidaCampos.Validar();

                PopulaTabela();
                diaPagamentoService.Save(objDiaPagamento);

                txtCodigo.Text = objDiaPagamento.idDiaPagamento.ToString();

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
                        objDiaPagamento = diaPagamentoService.GetDia_pagamento(Convert.ToInt32(txtCodigo.Text), true);
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
                    objDiaPagamento = diaPagamentoService.GetDia_pagamento((int)iRetPesquisa, true);
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
                    objDiaPagamento = diaPagamentoService.GetDia_pagamento((int)iRetPesquisa, true);
                    if (objDiaPagamento != null)
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
                    objDiaPagamento = diaPagamentoService.GetDia_pagamento((int)iRetPesquisa, true);
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
                diaPagamentoService.Copy(objDiaPagamento);
                PopulaForm();
                base.RegistroDuplicado(idOrigem, (int)objDiaPagamento.idDiaPagamento);

            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }

        public override void Atualizar()
        {
            base.Atualizar();
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
            diaPagamentoService.Delete(objDiaPagamento);
            base.Excluir();
            if (iRetPesquisa != null)
            {
                base.MoveProximoItem();
                objDiaPagamento = diaPagamentoService.GetDia_pagamento((int)iRetPesquisa, true);
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
                    objDiaPagamento = diaPagamentoService.GetDia_pagamento((int)lParaExcluir[i], true);
                    diaPagamentoService.Delete(objDiaPagamento);
                    lExcluido.Add(lParaExcluir[i]);
                }
                catch (Exception ex)
                {
                    new HLPexception(ex);
                }
            }
            base.FinalizaExcluirTodos();
        }

        private void PopulaTabela()
        {
            try
            {
                base.CarregaClasse(objDiaPagamento);
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
                base.CarregaPropriedades(objDiaPagamento, true);
                base.CarregaForm();

                bsdiaPagamentoLinhas.DataSource = objDiaPagamento.lDia_pagamento_linhas;
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }

        }


        private void dgvDiaPagamento_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {

                if (e.RowIndex > -1)
                {
                    if (dgvDiaPagamento.Columns[e.ColumnIndex].Name == "clstDiaUtil" && dgvDiaPagamento["clstSemanaMes", e.RowIndex].Value.ToString() == "1")
                    {
                        e.Cancel = true;
                    }
                    else if (dgvDiaPagamento.Columns[e.ColumnIndex].Name == "clnDia" && dgvDiaPagamento["clstSemanaMes", e.RowIndex].Value.ToString() == "0")
                    {
                        e.Cancel = true;
                    }
                }
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }

        private void dgvDiaPagamento_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex > -1)
                {
                    if (dgvDiaPagamento.Columns[e.ColumnIndex].Name.Equals("clstSemanaMes"))
                    {
                        if (dgvDiaPagamento[e.ColumnIndex, e.RowIndex].Value != null)
                        {
                            if (dgvDiaPagamento[e.ColumnIndex, e.RowIndex].Value.ToString() == "0") // 0 - semana
                            {
                                if (dgvDiaPagamento["clnDia", e.RowIndex].Value != null)
                                {
                                    dgvDiaPagamento["clnDia", e.RowIndex].Value = 0;
                                }
                            }
                            else if (dgvDiaPagamento[e.ColumnIndex, e.RowIndex].Value.ToString() == "1") // 1 - Mes
                            {
                                if (dgvDiaPagamento["clstDiaUtil", e.RowIndex].Value != null)
                                {
                                    dgvDiaPagamento["clstDiaUtil", e.RowIndex].Value = (Byte)0;
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

    }
}
