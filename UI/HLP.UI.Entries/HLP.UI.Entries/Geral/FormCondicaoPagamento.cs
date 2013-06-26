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
    public partial class FormCondicaoPagamento : FormPadraoCadastro
    {
        [Inject]
        public ICondicao_pagamentoService condicaoService { get; set; }

        Condicao_pagamentoModel condicaoModel = new Condicao_pagamentoModel();

        public FormCondicaoPagamento()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
        }

        private void FormCondicaoPagamento_Load(object sender, EventArgs e)
        {
            InicializaFormPadrao("vwCondicaoPagamento");

            nudnMeses.nud.Validated += new EventHandler(nud_Validated);
            nudnSemanas.nud.Validated += new EventHandler(nud_Validated);
            nudnDias.nud.Validated += new EventHandler(nud_Validated);

        }

        void nud_Validated(object sender, EventArgs e)
        {
            KryptonNumericUpDown nud = sender as KryptonNumericUpDown;
            if (nud == null)
            {
                nudnDias.ReadOnly = false;
                nudnDias.Text = "";
                nudnDias.Value = 0;
                nudnSemanas.ReadOnly = false;
                nudnSemanas.Text = "";
                nudnSemanas.Value = 0;
                nudnMeses.ReadOnly = false;
                nudnMeses.Text = "";
                nudnMeses.Value = 0;
            }
            else
            {
                if (nud == nudnMeses.nud && nud.Value != 0)
                {
                    nudnDias.ReadOnly = true;
                    nudnDias.Value = 0;
                    nudnSemanas.ReadOnly = true;
                    nudnSemanas.Value = 0;
                }
                else if (nud == nudnSemanas.nud && nud.Value != 0)
                {
                    nudnMeses.ReadOnly = true;
                    nudnMeses.Value = 0;
                    nudnDias.ReadOnly = true;
                    nudnDias.Value = 0;
                }
                else if (nud == nudnDias.nud && nud.Value != 0)
                {
                    nudnMeses.ReadOnly = true;
                    nudnMeses.Value = 0;
                    nudnSemanas.ReadOnly = true;
                    nudnSemanas.Value = 0;
                }

                if (nud == nudnMeses.nud && (nud.Value == 0 || nudnMeses.Text == ""))
                {
                    if (nudnMeses.ReadOnly == false)
                    {
                        nudnDias.ReadOnly = false;
                        nudnSemanas.ReadOnly = false;
                    }
                }
                else if (nud == nudnSemanas.nud && (nud.Value == 0 || nudnSemanas.Text == ""))
                {
                    if (nudnSemanas.ReadOnly == false)
                    {
                        nudnMeses.ReadOnly = false;
                        nudnDias.ReadOnly = false;
                    }
                }
                else if (nud == nudnDias.nud && (nud.Value == 0 || nudnDias.Text == ""))
                {
                    if (nudnDias.ReadOnly == false)
                    {
                        nudnMeses.ReadOnly = false;
                        nudnSemanas.ReadOnly = false;
                    }
                }
            }

        }



        public override void Novo()
        {
            base.Novo();
            condicaoModel = new Condicao_pagamentoModel();
            cbostMetodo.SelectedIndex = 4;
            cbostDataVencimento.SelectedIndex = 0;
            nud_Validated(nudnMeses, null);            
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
            condicaoService.Delete(Convert.ToInt32(txtCodigo.Text));
            base.Excluir();
            if (iRetPesquisa != null)
            {
                base.MoveProximoItem();
                condicaoModel = condicaoService.GetCondicao((int)iRetPesquisa);
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
                    condicaoService.Delete((int)lParaExcluir[i]);
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
        }
        public override void Salvar()
        {
            try
            {
                objValidaCampos.Validar();

                PopulaTabela();
                condicaoService.Save(condicaoModel);

                txtCodigo.Text = condicaoModel.idCondicaoPagamento.ToString();

                base.Salvar();

            }
            catch (Exception ex)
            {
                new HLPexception(ex);
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
                        condicaoModel = condicaoService.GetCondicao(Convert.ToInt32(txtCodigo.Text));
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
                    condicaoModel = condicaoService.GetCondicao((int)iRetPesquisa);
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
                    condicaoModel = condicaoService.GetCondicao((int)iRetPesquisa);
                    if (condicaoModel != null)
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
                    condicaoModel = condicaoService.GetCondicao((int)iRetPesquisa);
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
                int i = condicaoService.Copy(Convert.ToInt32(txtCodigo.Text));
                condicaoModel = condicaoService.GetCondicao(i);
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
                condicaoModel.xCondicaoPagamento = txtxCondicaoPagamento.Text;
                condicaoModel.xDescricao = txtxDescricao.Text;
                condicaoModel.stMetodo = cbostMetodo.SelectedIndexByte;
                condicaoModel.nMeses = nudnMeses.ValueInt;
                condicaoModel.nSemanas = nudnSemanas.ValueInt;
                condicaoModel.nDias = nudnDias.ValueInt;
                condicaoModel.stCondicao = cbostCondicao.SelectedIndexByte;

                if (hlP_PesquisaidPlanoPagamento.Value != 0)
                {
                    condicaoModel.idPlanoPagamento = hlP_PesquisaidPlanoPagamento.Value;
                }
                if (hlP_PesquisaidDiaPagamento.Value != 0)
                {
                    condicaoModel.idDiaPagamento = hlP_PesquisaidDiaPagamento.Value;
                }
                condicaoModel.stDataVencimento = cbostDataVencimento.SelectedIndexByte;

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
                txtCodigo.Text = condicaoModel.idCondicaoPagamento.ToString();
                txtxCondicaoPagamento.Text = condicaoModel.xCondicaoPagamento;
                txtxDescricao.Text = condicaoModel.xDescricao;
                cbostMetodo.SelectedIndex = condicaoModel.stMetodo;
                nudnMeses.Value = (int)condicaoModel.nMeses;
                nudnSemanas.Value = (int)condicaoModel.nSemanas;
                nudnDias.Value = (int)condicaoModel.nDias;
                cbostCondicao.SelectedIndex = condicaoModel.stCondicao;
                if (condicaoModel.idPlanoPagamento != null)
                {
                    hlP_PesquisaidPlanoPagamento.Value = (int)condicaoModel.idPlanoPagamento;
                }
                if (condicaoModel.idDiaPagamento != null)
                {
                    hlP_PesquisaidDiaPagamento.Value = (int)condicaoModel.idDiaPagamento;
                }
                cbostDataVencimento.SelectedIndex = (int)condicaoModel.stDataVencimento;
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }

        }

    }
}
