﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using HLP.Comum.Components;
using HLP.Comum.Services.Interface;
using HLP.Comum.UI.Eventos;
using HLP.Comum.UI.Metodos;
using HLP.Comum.UI.Validacao;
using HLP.Dependencies;
using Ninject;
using HLP.Comum.Models;
using HLP.Comum.UI.Exception;
using HLP.Comum.Messages;
using HLP.Comum.Services.Interface.Configuracao;
using HLP.Comum.Infrastructure;
using HLP.Comum.Infrastructure.Static;
using System.Reflection;

namespace HLP.Comum.UI
{
    public partial class FormPadraoCadastro : KryptonForm
    {
        [Inject]
        public IConfigFormulariosService iConfigFormularioService { get; set; }
        [Inject]
        public IConfiguraBaseService testeconn { get; set; }

        public BindingSource bsRetPesquisa = new BindingSource();
        public int? iRetPesquisa;
        public bool bNovoPesquisa = false;
        public ValidaCampos objValidaCampos = null;
        public MetodosForm objMetodosForm = null;


        private string sBotaoNavegacao = "";
        private object objSender;
        private bool bVisualizaBotoesNavegacao = false;
        private string sView = "";
        public EventosForm objEventosForm = null;

        public List<int> lParaExcluir = new List<int>();
        public List<int> lExcluido = new List<int>();
        bool bLoad = true;
        private int _cacheWidth;

        private struct Propriedades
        {
            public string xnome;
            public object value;
            public string xtabela;
        }
        List<Propriedades> lPropriedades = new List<Propriedades>();

        public FormPadraoCadastro()
        {
            InitializeComponent();
        }

        public void InicializaFormPadrao(string sView)
        {
            try
            {
                bwWorkerInicializa.RunWorkerAsync();
                this.sView = sView;
                this.BringToFront();
            }
            catch (System.Exception ex)
            {
                new HLPexception(ex);
            }
        }

        #region Botoes

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }
        public virtual void Novo()
        {
            try
            {
                if (btnNovo.Enabled)
                {
                    ExecutaEventoNovo();
                }
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        private void ExecutaEventoNovo()
        {
            HabilitaBotoes(3);
            objValidaCampos.LimpaErros();
            objMetodosForm.HabilitaCampos(true);
            objMetodosForm.LimpaCampos();
            bsRetPesquisa.DataSource = null;
            lblCount.Text = "0 de 0";
            iRetPesquisa = null;
            objMetodosForm.HabilitaButtonSpecPesquisa(false);
            //iConfigFormularioService.MudaPosicaoScrollFlowPanelTabControl(); **VERIFICAR**
            objMetodosForm.JogarFocoSegundoComponente();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }
        public virtual void Excluir()
        {
            objMetodosForm.LimpaCampos();
            HabilitaBotoes(2);
            objMetodosForm.HabilitaCampos(false);
            objMetodosForm.HabilitaButtonSpecPesquisa(true);
            if ((bsRetPesquisa.DataSource as List<int>) != null)
            {
                if ((bsRetPesquisa.DataSource as List<int>).Count > 0)
                {
                    (bsRetPesquisa.DataSource as List<int>).Remove((int)bsRetPesquisa.Current);
                    if ((bsRetPesquisa.DataSource as List<int>).Count > 0)
                    {
                        try
                        {
                            iRetPesquisa = (int)bsRetPesquisa.Current;
                        }
                        catch (System.Exception)
                        {
                            bsRetPesquisa.MovePrevious();
                            iRetPesquisa = (int)bsRetPesquisa.Current;
                        }
                        HabilitaBotoesNavegacao(true);
                        lblCount.Text = (bsRetPesquisa.IndexOf(bsRetPesquisa.Current) + 1).ToString() + " de " + bsRetPesquisa.Count.ToString();
                    }
                    else
                    {
                        iRetPesquisa = null;
                        lblCount.Text = "0 de 0";
                        HabilitaBotoesNavegacao(false);
                    }
                }
                else
                {
                    iRetPesquisa = null;
                    lblCount.Text = "0 de 0";
                    HabilitaBotoesNavegacao(false);
                }
            }
            else
            {
                iRetPesquisa = null;
                lblCount.Text = "0 de 0";
                HabilitaBotoesNavegacao(false);
            }
            //iConfigFormularioService.MudaPosicaoScrollFlowPanelTabControl();**VERIFICAR**
            objMetodosForm.JogarFocoPrimeiroComponente();
        }
        public virtual void IniciaExcluirTodos()
        {
            int iTotal = bsRetPesquisa.List.Count;
            Invoke(new MethodInvoker(delegate
            {
                pbProgresso.Value = 0;
                pbProgresso.Visible = true;
                lblProgresso.Visible = true;
                lblProgresso.Text = "0 de " + iTotal;
                pbProgresso.Maximum = iTotal;
            }));

            lParaExcluir = (List<int>)bsRetPesquisa.List;
            lExcluido = new List<int>();
        }
        public virtual void FinalizaExcluirTodos()
        {

            var dados = (from c in lParaExcluir
                         where !(from p in lExcluido select p).Contains(c)
                         select c);
            List<int> lNaoExcluidos = new List<int>();

            foreach (int iRegistro in dados)
            {
                lNaoExcluidos.Add(iRegistro);
            }
            HLPMessageBox.MsgExclusaoFinalizada(lNaoExcluidos.ToArray());
            foreach (int i in lExcluido)
            {
                bsRetPesquisa.List.Remove(i);
            }
            Invoke(new MethodInvoker(delegate
            {
                lblProgresso.Text = "";
                lblProgresso.Visible = false;
                pbProgresso.Visible = false;
                lblCount.Text = "0 de " + bsRetPesquisa.List.Count;
            }));
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Atualizar();
        }
        public virtual void Atualizar()
        {
            HabilitaBotoes(3);
            objMetodosForm.HabilitaCampos(true);
            objMetodosForm.HabilitaButtonSpecPesquisa(false);
            //iConfigFormularioService.MudaPosicaoScrollFlowPanelTabControl();**VERIFICAR**
            objMetodosForm.JogarFocoSegundoComponente();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            Salvar();
        }
        public virtual void Salvar()
        {
            HabilitaBotoes(1);
            //iConfigFormularioService.MudaPosicaoScrollFlowPanelTabControl();**VERIFICAR**
            objMetodosForm.HabilitaCampos(false);
            objMetodosForm.HabilitaButtonSpecPesquisa(true);
            objMetodosForm.JogarFocoPrimeiroComponente();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }
        public virtual void Cancelar()
        {
            objValidaCampos.LimpaErros();
            objMetodosForm.HabilitaCampos(false);
            objMetodosForm.HabilitaButtonSpecPesquisa(true);
            //iConfigFormularioService.MudaPosicaoScrollFlowPanelTabControl();**VERIFICAR**
            objMetodosForm.JogarFocoPrimeiroComponente();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }
        public virtual void Pesquisar()
        {
            try
            {
                if (btnPesquisar.Enabled)
                {
                    FormPesquisaPadrao objfrmPesquisaPadrao = new FormPesquisaPadrao(iConfigFormularioService.objConfigFormularioModel);
                    objfrmPesquisaPadrao.ShowDialog();
                    if (objfrmPesquisaPadrao.Alterou)
                    {
                        // layoutService.Serialize(layoutService.objConfig); Verificar para salvar
                    }
                    if (objfrmPesquisaPadrao.ListIdSelecionados.Count > 0)
                    {
                        bsRetPesquisa.DataSource = objfrmPesquisaPadrao.ListIdSelecionados;
                        bsRetPesquisa.MoveFirst();
                        objMetodosForm.LimpaCampos();
                        iRetPesquisa = (int)bsRetPesquisa.Current;
                        if (objfrmPesquisaPadrao.ListIdSelecionados.Count() > 1) { bVisualizaBotoesNavegacao = true; } else { bVisualizaBotoesNavegacao = false; }
                        HabilitaBotoes(1);
                        objMetodosForm.HabilitaButtonSpecPesquisa(true);
                        lblCount.Text = "1 de " + objfrmPesquisaPadrao.ListIdSelecionados.Count().ToString();
                    }
                    else
                    {
                        iRetPesquisa = null;
                        if (objfrmPesquisaPadrao.btnNovo.Tag.ToString().Equals("1"))
                        {
                            bNovoPesquisa = true;
                        }
                        else
                        {
                            lblCount.Text = "0 de 0";
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                new HLPexception(ex);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
        }
        public virtual void Imprimir()
        { }

        private void btnDuplicar_Click(object sender, EventArgs e)
        {
            Duplicar();
        }
        public virtual void Duplicar()
        {
        }
        public virtual void RegistroDuplicado(int idOrigem, int idNovo)
        {
            KryptonMessageBox.Show(string.Format("Registro Duplicado com sucesso!" + Environment.NewLine + Environment.NewLine
                           + "Registro Origem: {0}" + Environment.NewLine +
                            "Novo Registro: {1}", idOrigem, idNovo), Mensagens.MSG_Aviso, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPesquisaCampo_Click(object sender, EventArgs e)
        {
            this.objSender = sender;
            PesquisaCampo();
        }
        public virtual void PesquisaCampo()
        {
            List<int> ListIdSelecionados = objEventosForm.PesquisaCampo(this.objSender);
            if (ListIdSelecionados.Count > 0)
            {
                bsRetPesquisa.DataSource = ListIdSelecionados;
                bsRetPesquisa.MoveFirst();
                objMetodosForm.LimpaCampos();
                iRetPesquisa = (int)bsRetPesquisa.Current;
                if (ListIdSelecionados.Count() > 1) { bVisualizaBotoesNavegacao = true; } else { bVisualizaBotoesNavegacao = false; }
                HabilitaBotoes(1);
                objMetodosForm.HabilitaButtonSpecPesquisa(true);
                lblCount.Text = "1 de " + ListIdSelecionados.Count().ToString();
            }
            else
            {
                iRetPesquisa = null;
                lblCount.Text = "0 de 0";
                KryptonMessageBox.Show("Nenhum registro localizado!", Mensagens.MSG_Aviso, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public virtual void MoveProximoItem()
        {
            try
            {
                objMetodosForm.LimpaCampos();
                HabilitaBotoes(1);
            }
            catch (System.Exception ex)
            {
                new HLPexception(ex);
            }
        }


        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            this.sBotaoNavegacao = "btnPrimeiro";
            Navegacao();
        }
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            this.sBotaoNavegacao = "btnAnterior";
            Navegacao();
        }
        private void btnProximo_Click(object sender, EventArgs e)
        {
            this.sBotaoNavegacao = "btnProximo";
            Navegacao();
        }
        private void btnUltimo_Click(object sender, EventArgs e)
        {
            this.sBotaoNavegacao = "btnUltimo";
            Navegacao();
        }
        public virtual void Navegacao()
        {
            if (bsRetPesquisa.Count > 0)
            {
                switch (sBotaoNavegacao)
                {
                    case "btnPrimeiro":
                        bsRetPesquisa.MoveFirst();
                        iRetPesquisa = (int)bsRetPesquisa.Current;
                        break;

                    case "btnAnterior":
                        bsRetPesquisa.MovePrevious();
                        iRetPesquisa = (int)bsRetPesquisa.Current;
                        break;

                    case "btnProximo":
                        bsRetPesquisa.MoveNext();
                        iRetPesquisa = (int)bsRetPesquisa.Current;
                        break;

                    case "btnUltimo":
                        bsRetPesquisa.MoveLast();
                        iRetPesquisa = (int)bsRetPesquisa.Current;
                        break;
                }

                lblCount.Text = (bsRetPesquisa.IndexOf(bsRetPesquisa.Current) + 1).ToString() + " de " + bsRetPesquisa.Count.ToString();
            }
            else
            {
                iRetPesquisa = null;
                lblCount.Text = "0 de 0";
                HabilitaBotoesNavegacao(false);
            }
        }

        private void Componente_Enter(object sender, EventArgs e)
        {
            try
            {
                Control c = (Control)sender;

                UserControlBase objcomp = null;

                if (c.GetType().BaseType == typeof(UserControlBase))
                    objcomp = c as UserControlBase;
                else if (c.Parent.GetType().BaseType == typeof(UserControlBase))
                    objcomp = c.Parent as UserControlBase;

                lblHelp.Text = "";
                if (objcomp != null)
                {
                    if (objcomp.objConfigComponenteModel != null)
                    {
                        lblHelp.Text = objcomp.objConfigComponenteModel.objConfigCompUsu.xHelp;
                    }
                }

            }
            catch (System.Exception ex)
            {
                HLPMessageBox.ShowAviso("Erro ao buscar o help do componente");
            }


            //if (c.Parent.GetType() == typeof(HLP_TextBox))
            //{
            //    if (!String.IsNullOrEmpty(((HLP_TextBox)c.Parent)._Help))
            //    {
            //        lblHelp.Text = ((HLP_TextBox)c.Parent)._Help;
            //    }
            //    else
            //    {
            //        lblHelp.Text = "";
            //    }
            //}
            //else if (c.Parent.GetType() == typeof(HLP_CheckBox))
            //{
            //    if (!String.IsNullOrEmpty(((HLP_CheckBox)c.Parent)._Help))
            //    {
            //        lblHelp.Text = ((HLP_CheckBox)c.Parent)._Help;
            //    }
            //    else
            //    {
            //        lblHelp.Text = "";
            //    }
            //}
            //else if (c.Parent.GetType() == typeof(HLP_ComboBox))
            //{
            //    if (!String.IsNullOrEmpty(((HLP_ComboBox)c.Parent)._Help))
            //    {
            //        lblHelp.Text = ((HLP_ComboBox)c.Parent)._Help;
            //    }
            //    else
            //    {
            //        lblHelp.Text = "";
            //    }
            //}
            //else if (c.Parent.GetType() == typeof(HLP_DateTimePicker))
            //{
            //    if (!String.IsNullOrEmpty(((HLP_DateTimePicker)c.Parent)._Help))
            //    {
            //        lblHelp.Text = ((HLP_DateTimePicker)c.Parent)._Help;
            //    }
            //    else
            //    {
            //        lblHelp.Text = "";
            //    }
            //}
            //else if (c.Parent.GetType() == typeof(HLP_ListBox))
            //{
            //    if (!String.IsNullOrEmpty(((HLP_ListBox)c.Parent)._Help))
            //    {
            //        lblHelp.Text = ((HLP_ListBox)c.Parent)._Help;
            //    }
            //    else
            //    {
            //        lblHelp.Text = "";
            //    }
            //}
            //else if (c.Parent.GetType() == typeof(HLP_MaskedTextBox))
            //{
            //    if (!String.IsNullOrEmpty(((HLP_MaskedTextBox)c.Parent)._Help))
            //    {
            //        lblHelp.Text = ((HLP_MaskedTextBox)c.Parent)._Help;
            //    }
            //    else
            //    {
            //        lblHelp.Text = "";
            //    }
            //}
            //else if (c.Parent.GetType() == typeof(HLP_NumericUpDown))
            //{
            //    if (!String.IsNullOrEmpty(((HLP_NumericUpDown)c.Parent)._Help))
            //    {
            //        lblHelp.Text = ((HLP_NumericUpDown)c.Parent)._Help;
            //    }
            //    else
            //    {
            //        lblHelp.Text = "";
            //    }
            //}
            //else if (c.Parent.GetType() == typeof(HLP_Observacao))
            //{
            //    if (!String.IsNullOrEmpty(((HLP_Observacao)c.Parent)._Help))
            //    {
            //        lblHelp.Text = ((HLP_Observacao)c.Parent)._Help;
            //    }
            //    else
            //    {
            //        lblHelp.Text = "";
            //    }
            //}
            //else if (c.GetType() == typeof(HLP_Pesquisa))
            //{
            //    if (!String.IsNullOrEmpty(((HLP_Pesquisa)c)._Help))
            //    {
            //        lblHelp.Text = ((HLP_Pesquisa)c)._Help;
            //    }
            //    else
            //    {
            //        lblHelp.Text = "";
            //    }
            //}
        }
        void tabPage_Enter(object sender, EventArgs e)
        {
            //TabPage tabPage = sender as TabPage;
            //if (layoutService.objConfig.Hierarquia.Tabs.Where(c => c.NameTab == tabPage.Name).Count() > 0)
            //{
            //    lblHelp.Text = layoutService.objConfig.Hierarquia.Tabs.FirstOrDefault(c => c.NameTab == tabPage.Name).HelpTab;
            //}
            //else
            //{
            //    lblHelp.Text = "";
            //}
        }
        private void grid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            KryptonDataGridView grid = (KryptonDataGridView)sender;
            if (!String.IsNullOrEmpty(grid.Columns[e.ColumnIndex].ToolTipText))
            {
                lblHelp.Text = grid.Columns[e.ColumnIndex].ToolTipText;
            }
            else
            {
                lblHelp.Text = "";
            }
        }
        #endregion

        #region Metodos Privados
        private void ConfiguraAcoesPermitidas()
        {
            //if (layoutService.AcessoFormulario != null)
            //{
            //    if (!layoutService.AcessoFormulario.Inclusao)
            //    {
            //        btnNovo.Visible = false;
            //        sepNovo.Visible = false;
            //    }
            //    if (!layoutService.AcessoFormulario.Alteracao)
            //    {
            //        btnAtualizar.Visible = false;
            //        sepAtualizar.Visible = false;
            //    }
            //    if (!layoutService.AcessoFormulario.Exclusao)
            //    {
            //        btnExcluir.Visible = false;
            //        sepExcluir.Visible = false;
            //    }
            //    if (!layoutService.AcessoFormulario.Pesquisar)
            //    {
            //        btnPesquisar.Visible = false;
            //        sepPesquisar.Visible = false;
            //    }
            //    if (!layoutService.AcessoFormulario.Duplicar)
            //    {
            //        btnDuplicar.Visible = false;
            //        sepDuplicar.Visible = false;
            //    }
            //}

        }
        private void HabilitaBotoesNavegacao(bool bHabilita)
        {
            btnAnterior.Enabled = bHabilita;
            btnPrimeiro.Enabled = bHabilita;
            btnProximo.Enabled = bHabilita;
            btnUltimo.Enabled = bHabilita;
        }
        private void SetaEventos()
        {
            SetaEventoSalvarUltimoCampo();
            SetaEventoHelpPesquisaButtonSpec();
            SetaEventoGrid();
        }
        private void SetaEventoSalvarUltimoCampo()
        {

            if (iConfigFormularioService.lControl.Where(c => c.GetType() == typeof(HLP_DataGridView)).Count() == 0)
            {
                if (iConfigFormularioService.lControl.Where(C => C.Visible == true).Count() > 0)
                {
                    List<ConfigComponenteModel> lComponentes = iConfigFormularioService.objConfigFormularioModel.lobjConfigComponente.
                                Where(C => C.objConfigCompUsu.stVisible.ToBoolean() == true).ToList();

                    if (lComponentes.Count() > 0)
                    {
                        int i = lComponentes.Max(C => C.objConfigCompUsu.nOrder);

                        ConfigComponenteModel objComponente = lComponentes.FirstOrDefault(C => C.objConfigCompUsu.nOrder == i);

                        Control ctr = iConfigFormularioService.lControl.FirstOrDefault(C => C.Name == objComponente.xName);
                        if (ctr.GetType() == typeof(HLP_TextBox))
                        {
                            ((KryptonTextBox)ctr.Controls[0]).KeyDown -= new KeyEventHandler(UltimoCampo_KeyDown);
                            ((KryptonTextBox)ctr.Controls[0]).KeyDown += new KeyEventHandler(UltimoCampo_KeyDown);
                        }
                        else if (ctr.GetType() == typeof(HLP_ComboBox))
                        {
                            ((KryptonComboBox)ctr.Controls[0]).KeyDown -= new KeyEventHandler(UltimoCampo_KeyDown);
                            ((KryptonComboBox)ctr.Controls[0]).KeyDown += new KeyEventHandler(UltimoCampo_KeyDown);
                        }
                        else if (ctr.GetType() == typeof(HLP_NumericUpDown))
                        {
                            ((KryptonNumericUpDown)ctr.Controls[0]).KeyDown -= new KeyEventHandler(UltimoCampo_KeyDown);
                            ((KryptonNumericUpDown)ctr.Controls[0]).KeyDown += new KeyEventHandler(UltimoCampo_KeyDown);
                        }
                        else if (ctr.GetType() == typeof(HLP_MaskedTextBox))
                        {
                            ((KryptonMaskedTextBox)ctr.Controls[0]).KeyDown -= new KeyEventHandler(UltimoCampo_KeyDown);
                            ((KryptonMaskedTextBox)ctr.Controls[0]).KeyDown += new KeyEventHandler(UltimoCampo_KeyDown);
                        }
                        else if (ctr.GetType() == typeof(HLP_DateTimePicker))
                        {
                            ((KryptonDateTimePicker)ctr.Controls[0]).KeyDown -= new KeyEventHandler(UltimoCampo_KeyDown);
                            ((KryptonDateTimePicker)ctr.Controls[0]).KeyDown += new KeyEventHandler(UltimoCampo_KeyDown);
                        }
                        else if (ctr.GetType() == typeof(HLP_CheckBox))
                        {
                            ((KryptonCheckBox)ctr.Controls[0]).KeyDown -= new KeyEventHandler(UltimoCampo_KeyDown);
                            ((KryptonCheckBox)ctr.Controls[0]).KeyDown += new KeyEventHandler(UltimoCampo_KeyDown);
                        }
                        else if (ctr.GetType() == typeof(HLP_Pesquisa))
                        {
                            ((HLP_Pesquisa)ctr).txtPesquisa.KeyDown -= new KeyEventHandler(UltimoCampo_KeyDown);
                            ((HLP_Pesquisa)ctr).txtPesquisa.KeyDown += new KeyEventHandler(UltimoCampo_KeyDown);

                        }
                    }
                }
            }
        }
        private void SetaEventoHelpPesquisaButtonSpec()
        {
            var chk = iConfigFormularioService.lControl.OfType<HLP_CheckBox>().ToList();
            foreach (HLP_CheckBox c in chk)
            {
                c._Enter -= new EventHandler(Componente_Enter);
                c._Enter += new EventHandler(Componente_Enter);
            }

            var cbo = iConfigFormularioService.lControl.OfType<HLP_ComboBox>().ToList();
            foreach (HLP_ComboBox c in cbo)
            {
                c._Enter -= new EventHandler(Componente_Enter);
                c._Enter += new EventHandler(Componente_Enter);
            }

            var dtp = iConfigFormularioService.lControl.OfType<HLP_DateTimePicker>().ToList();
            foreach (HLP_DateTimePicker c in dtp)
            {
                c._Enter -= new EventHandler(Componente_Enter);
                c._Enter += new EventHandler(Componente_Enter);
            }

            var msk = iConfigFormularioService.lControl.OfType<HLP_MaskedTextBox>().ToList();
            foreach (HLP_MaskedTextBox m in msk)
            {
                m.btnPesquisaCampo.Click -= new EventHandler(btnPesquisaCampo_Click);
                m.btnPesquisaCampo.Click += new EventHandler(btnPesquisaCampo_Click);

                m._Enter -= new EventHandler(Componente_Enter);
                m._Enter += new EventHandler(Componente_Enter);
            }

            var nud = iConfigFormularioService.lControl.OfType<HLP_NumericUpDown>().ToList();
            foreach (HLP_NumericUpDown c in nud)
            {
                c._Enter -= new EventHandler(Componente_Enter);
                c._Enter += new EventHandler(Componente_Enter);
            }

            var obs = iConfigFormularioService.lControl.OfType<HLP_Observacao>().ToList();
            foreach (HLP_Observacao c in obs)
            {
                c._Enter -= new EventHandler(Componente_Enter);
                c._Enter += new EventHandler(Componente_Enter);
            }

            var pes = iConfigFormularioService.lControl.OfType<HLP_Pesquisa>().ToList();
            foreach (HLP_Pesquisa c in pes)
            {
                c._Enter -= new EventHandler(Componente_Enter);
                c._Enter += new EventHandler(Componente_Enter);
            }

            var txt = iConfigFormularioService.lControl.OfType<HLP_TextBox>().ToList();
            foreach (HLP_TextBox t in txt)
            {
                t.btnPesquisaCampo.Click -= new EventHandler(btnPesquisaCampo_Click);
                t.btnPesquisaCampo.Click += new EventHandler(btnPesquisaCampo_Click);

                t._Enter -= new EventHandler(Componente_Enter);
                t._Enter += new EventHandler(Componente_Enter);
            }

            var ltabControl = iConfigFormularioService.GetTabPages().Select(c => c.Parent).Distinct();

            foreach (AC.ExtendedRenderer.Navigator.KryptonTabControl tab in ltabControl)
            {
                foreach (TabPage tabPage in tab.TabPages)
                {
                    tabPage.Enter -= new EventHandler(tabPage_Enter);
                    tabPage.Enter += new EventHandler(tabPage_Enter);
                }
            }


            foreach (KryptonDataGridView grid in iConfigFormularioService.lControl.Where(c => c.GetType() == typeof(HLP_DataGridView)))
            {
                //grid.CellEnter -= new DataGridViewCellEventHandler(grid_CellEnter);
                //grid.CellEnter += new DataGridViewCellEventHandler(grid_CellEnter);
            }

        }
        private void SetaEventoGrid()
        {
            bool Upper = CompanyData.stMaiusculo;

            ContextMenuStrip cms = new ContextMenuStrip();
            ToolStripMenuItem ti = new ToolStripMenuItem();
            ti.Text = "Ir para Formulário Principal";
            ti.Click -= new EventHandler(ContextMenuColunaFkGrid_Click);
            ti.Click += new EventHandler(ContextMenuColunaFkGrid_Click);
            cms.Opening -= new System.ComponentModel.CancelEventHandler(cms_Opening);
            cms.Opening += new System.ComponentModel.CancelEventHandler(cms_Opening);
            cms.Items.Add(ti);

            foreach (KryptonDataGridView grid in iConfigFormularioService.lControl.Where(c => c.GetType() == typeof(HLP_DataGridView)))
            {
                if (Upper)
                {
                    grid.EditingControlShowing -= new DataGridViewEditingControlShowingEventHandler(grid_EditingControlShowing);
                    grid.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(grid_EditingControlShowing);
                }
                grid.ColumnHeaderMouseClick -= new DataGridViewCellMouseEventHandler(grid_ColumnHeaderMouseClick);
                grid.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(grid_ColumnHeaderMouseClick);
                grid.ContextMenuStrip = cmsOpcoesGrid;
                foreach (DataGridViewColumn col in grid.Columns)
                {
                    if (col.GetType() == typeof(DataGridViewComboBoxColumn))
                    {
                        if (((DataGridViewComboBoxColumn)col).Tag != null)
                        {
                            string[] dados = ((DataGridViewComboBoxColumn)col).Tag.ToString().Split('-');
                            if (dados.Count() >= 2)
                            {
                                col.ContextMenuStrip = cms;
                            }
                        }
                    }
                }
            }
        }
        private void FecharFormulario()
        {
            if (btnSalvar.Enabled)
            {
                if ((KryptonMessageBox.Show("Deseja realmente sair desse formulário?", Mensagens.MSG_Aviso, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }


        #endregion

        #region Metodos Publicos

        /// <summary>
        /// 1 -> Após pesquisar e Salvar
        /// 2 -> Após Cancelar e Excluir e Iniciar
        /// 3 -> Após Novo e Atualizar
        /// 4 -> 
        /// 5 -> Desabilita todos os botões
        /// </summary>
        /// <param name="intTipo"></param>
        public void HabilitaBotoes(int intTipo)
        {

            switch (intTipo)
            {
                case 1: this.btnSalvar.Enabled = false;
                    this.btnCancelar.Enabled = false;
                    this.btnExcluir.Enabled = true;
                    this.btnPesquisar.Enabled = true;
                    this.btnImprimir.Enabled = true;
                    this.btnNovo.Enabled = true;
                    this.btnAtualizar.Enabled = true;
                    this.btnDuplicar.Enabled = true;
                    if (bsRetPesquisa.DataSource != null)
                    {
                        if (bVisualizaBotoesNavegacao && (bsRetPesquisa.DataSource as List<int>).Count > 0) { HabilitaBotoesNavegacao(true); } else { HabilitaBotoesNavegacao(false); }
                    }
                    this.tsConfigurar.Enabled = true;
                    break;
                case 2: this.btnSalvar.Enabled = false;
                    this.btnCancelar.Enabled = false;
                    this.btnExcluir.Enabled = false;
                    this.btnPesquisar.Enabled = true;
                    this.btnImprimir.Enabled = true;
                    this.btnNovo.Enabled = true;
                    this.btnAtualizar.Enabled = false;
                    this.btnDuplicar.Enabled = false;
                    if (bsRetPesquisa.DataSource != null)
                    {
                        if (bVisualizaBotoesNavegacao && (bsRetPesquisa.DataSource as List<int>).Count > 0) { HabilitaBotoesNavegacao(true); } else { HabilitaBotoesNavegacao(false); }
                    }
                    this.tsConfigurar.Enabled = true;
                    break;
                case 3: this.btnSalvar.Enabled = true;
                    this.btnCancelar.Enabled = true;
                    this.btnExcluir.Enabled = false;
                    this.btnPesquisar.Enabled = false;
                    this.btnImprimir.Enabled = false;
                    this.btnNovo.Enabled = false;
                    this.btnAtualizar.Enabled = false;
                    this.btnDuplicar.Enabled = false;
                    this.tsConfigurar.Enabled = false;
                    HabilitaBotoesNavegacao(false);
                    break;
                case 4: this.btnSalvar.Enabled = false;
                    this.btnCancelar.Enabled = false;
                    this.btnExcluir.Enabled = true;
                    this.btnPesquisar.Enabled = true;
                    this.btnImprimir.Enabled = true;
                    this.btnNovo.Enabled = false;
                    this.btnAtualizar.Enabled = true;
                    this.btnDuplicar.Enabled = true;
                    break;
                case 5: this.btnSalvar.Enabled = false;
                    this.btnCancelar.Enabled = false;
                    this.btnExcluir.Enabled = false;
                    this.btnPesquisar.Enabled = false;
                    this.btnImprimir.Enabled = false;
                    this.btnNovo.Enabled = false;
                    this.btnAtualizar.Enabled = false;
                    this.btnDuplicar.Enabled = false;
                    this.tsConfigurar.Enabled = true;
                    break;
            }

        }



        #endregion

        private void FormPadraoCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FecharFormulario();
            }
        }
        private void UltimoCampo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (btnSalvar.Enabled)
                {
                    btnSalvar_Click(sender, e);
                }
            }
        }
        private void TsUtility_Click(object sender, EventArgs e)
        {
            //CONFIGURAÇÃO DE COMPONENTE.
            try
            {
                this.objMetodosForm.HabilitaCampos(true);
                FormConfigFormulario fc = new FormConfigFormulario(iConfigFormularioService.objConfigFormularioModel, iConfigFormularioService.lControl);
                fc.ShowDialog();

                iConfigFormularioService.Save(iConfigFormularioService.objConfigFormularioModel);

            }
            catch (System.Exception ex)
            {
                new HLPexception(ex);
            }

            //try
            //{
            //    ToolStripMenuItem ts = sender as ToolStripMenuItem;
            //    string sNameForm = "";
            //    if (ts == tsConfigComp)
            //    {
            //        FormConfigComp frm = new FormConfigComp(layoutService);
            //        frm.ShowDialog();
            //        if (frm.bAlterou)
            //            if (layoutService.lKryptonDataGridView.Count == 0)
            //            {
            //                layoutService.ConfigFormBySetting();
            //                objMetodosForm.HabilitaCampos(false);
            //                HabilitaBotoes(2);
            //            }
            //            else
            //            {
            //                sNameForm = layoutService.lControl.FirstOrDefault().FindForm().Name;
            //                this.Close();
            //                HLP.Comum.Modules.GerenciadorModulo.Instancia.ExibirForm(sNameForm, Modules.TipoExibeForm.Normal);
            //            }
            //    }
            //    else if (ts == tsConsistForm)
            //    {
            //        layoutService.ConsistForm();
            //        objMetodosForm.HabilitaCampos(false);
            //        HabilitaBotoes(2);
            //    }
            //    else if (ts == tsRestaurarPadrao)
            //    {
            //        sNameForm = layoutService.lControl.FirstOrDefault().FindForm().Name;
            //        layoutService.DeleteXml();
            //        this.Close();
            //        HLP.Comum.Modules.GerenciadorModulo.Instancia.ExibirForm(sNameForm, Modules.TipoExibeForm.Normal);
            //    }
            //    else if (ts == tsArquivoSys)
            //    {
            //        layoutService.ConfiguracaoInicial(this.panelPadrao.Controls, true);
            //        HLPMessageBox.ShowAviso("Arquivo Gerado com Sucesso!");
            //    }
            //}
            //catch (System.Exception ex)
            //{
            //    new HLPexception(ex);
            //}
        }
        private void exportarConteudoPExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem menuItem = sender as ToolStripItem;
            ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
            KryptonDataGridView dgvDados = owner.SourceControl as KryptonDataGridView;
            if (dgvDados.RowCount > 0)
            {
                Util.ExportarExcel(dgvDados);
            }
        }
        private void salvarTamanhoDasColunasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{

            //    ToolStripItem menuItem = sender as ToolStripItem;
            //    ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
            //    KryptonDataGridView grid = owner.SourceControl as KryptonDataGridView;

            //    Grid objGrid = layoutService.objConfig.DataGrid.FirstOrDefault(C => C.Name == grid.Name);
            //    foreach (GridColumn col in objGrid.DataGridColumn)
            //    {
            //        col.Width = grid.Columns[col.Name].Width;
            //        col.DisplayIndex = grid.Columns[col.Name].DisplayIndex;
            //    }
            //    layoutService.Serialize(layoutService.objConfig);
            //}
            //catch (System.Exception ex)
            //{
            //    new HLPexception(ex);
            //}
        }
        private void ContextMenuColunaFkGrid_Click(object sender, EventArgs e)
        {
            objEventosForm.AbreFormGrid(sender);
        }
        private void FormPadraoCadastro_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized && !this.Modal)
            {
                this.WindowState = FormWindowState.Normal;
                this.Dock = DockStyle.Fill;
            }
        }
        private void FormPadraoCadastro_ResizeBegin(object sender, EventArgs e)
        {
            if (this.Dock == DockStyle.Fill)
            {
                this.Dock = DockStyle.None;
            }
        }
        private void grid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            objEventosForm.PesquisaHeaderGrid(sender, e.ColumnIndex);
        }
        private void grid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is System.Windows.Forms.TextBox)
            {
                ((System.Windows.Forms.TextBox)(e.Control)).CharacterCasing = CharacterCasing.Upper;
            }
        }
        private void cms_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ContextMenuStrip owner = sender as ContextMenuStrip;
            KryptonDataGridView grid = owner.SourceControl as KryptonDataGridView;
            if (grid.CurrentCell != null)
            {
                if (grid.CurrentCell.GetType() != typeof(DataGridViewComboBoxCell))
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }
        private void FormPadraoCadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnSalvar.Enabled)
            {
                if ((KryptonMessageBox.Show("Deseja realmente sair desse formulário?", Mensagens.MSG_Aviso, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.No))
                {
                    e.Cancel = true;
                }
            }
        }
        private void bwWorkerRecarregaForm_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                if (this.InvokeRequired)
                    this.BeginInvoke((MethodInvoker)delegate
                    {
                        // iConfigFormularioService.InitializeFormulario(this.panelPadrao, sView);
                        ConfiguraAcoesPermitidas();
                        HabilitaBotoesNavegacao(false);
                        objMetodosForm.HabilitaCampos(false);
                        objMetodosForm.HabilitaButtonSpecPesquisa(true);
                        objMetodosForm.HabilitaButtonSpecConfig(false);
                        tsCamposVisiveis.Enabled = false;
                        tsDesabilitar.Enabled = false;
                        tsHabilitar.Enabled = true;
                        HabilitaBotoes(2);
                    });

            }
            catch (System.Exception ex)
            {
                bwWorkerRecarregaForm.Dispose();
                throw ex;
            }

        }
        private void bwWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                if (this.InvokeRequired)
                    this.BeginInvoke((MethodInvoker)delegate
                    {
                        iConfigFormularioService.InitializeFormulario(this.panelPadrao, sView);
                        objMetodosForm = new MetodosForm(iConfigFormularioService);
                        objMetodosForm.JogarFocoPrimeiroComponente();
                        objEventosForm = new EventosForm(iConfigFormularioService);
                        objValidaCampos = new ValidaCampos(iConfigFormularioService, objEventosForm);
                        ConfiguraAcoesPermitidas();
                        HabilitaBotoes(2);
                        HabilitaBotoesNavegacao(false);
                        objMetodosForm.HabilitaCampos(false);
                        objMetodosForm.HabilitaButtonSpecPesquisa(true);
                        SetaEventos();
                        if (this.Modal == true)  // executa os métodos novo ao iniciar form modal 
                        {
                            //ExecutaEventoNovo();
                        }
                    });

            }
            catch (System.Exception ex)
            {
                bwWorkerInicializa.Dispose();
                throw ex;
            }

        }

        protected bool GetStatusBw()
        {
            return bwWorkerInicializa.IsBusy;
        }

        private void tsHab_Click(object sender, EventArgs e)
        {
            if (sender == tsHabilitar)
            {
                this.ExecutaEventoNovo();
                HabilitaBotoes(5);
                objMetodosForm.HabilitaButtonSpecConfig(true);
                tsCamposVisiveis.Enabled = true;
                tsDesabilitar.Enabled = true;
                tsHabilitar.Enabled = false;
            }
            else if (sender == tsDesabilitar)
            {
                bwWorkerRecarregaForm.RunWorkerAsync();
            }
            else if (sender == tsCamposVisiveis)
            {

            }
        }

        #region CarregaValores
        protected void CarregaPropriedades<T>(T model, bool inicio = false) where T : class
        {
            if (inicio)
            {
                lPropriedades = new List<Propriedades>();
            }
            Type tipo = model.GetType();
            Propriedades objPropriedades;
            foreach (PropertyInfo property in tipo.GetProperties())
            {
                objPropriedades = new Propriedades();
                objPropriedades.xnome = property.Name;
                objPropriedades.value = property.GetValue(model);
                objPropriedades.xtabela = model.GetType().Name.ToString().Replace("Model", "");

                lPropriedades.Add(objPropriedades);
            }
        }

        protected void CarregaForm()
        {
            string nomeProp = null;
            Type tipo = null;
            foreach (Control c in iConfigFormularioService.lControl.Where(c => c.GetType().BaseType == typeof(UserControlBase)))
            {
                tipo = c.GetType();
                if (c.GetType() != typeof(HLP.Comum.Components.HLP_DataGridView) &&
                    c.GetType() != typeof(HLP.Comum.Components.HLP_Button))
                {
                    nomeProp = ((HLP.Comum.Components.UserControlBase)c)._Field;

                    try
                    {
                        Propriedades teste = new Propriedades();
                        teste = lPropriedades.FirstOrDefault(i => i.xnome ==
                               nomeProp);

                        object valor = lPropriedades.FirstOrDefault(i => i.xnome ==
                               nomeProp && i.xtabela == ((HLP.Comum.Components.UserControlBase)c)._Table).value;


                        if (c.GetType() == typeof(HLP.Comum.Components.HLP_TextBox))
                            ((HLP.Comum.Components.HLP_TextBox)c).Text = valor != null ? valor.ToString() : "";
                        else if (c.GetType() == typeof(HLP.Comum.Components.HLP_MaskedTextBox))
                            ((HLP.Comum.Components.HLP_MaskedTextBox)c).Text = valor != null ? valor.ToString() : "";
                        else if (c.GetType() == typeof(HLP.Comum.Components.HLP_ComboBox))
                        {
                            if (valor.GetType().Name == "Boolean")
                            {
                                ((HLP.Comum.Components.HLP_ComboBox)c).SelectedIndex = Convert.ToBoolean(valor) ? 1 : 0;
                            }
                            else
                                if (((HLP.Comum.Components.HLP_ComboBox)c).DataSource == null)
                                    ((HLP.Comum.Components.HLP_ComboBox)c).SelectedIndex = valor != null ? valor.ToInt32() : -1;
                                else
                                    ((HLP.Comum.Components.HLP_ComboBox)c).SelectedValue = valor != null ? valor.ToInt32() : -1;
                        }
                        else if (c.GetType() == typeof(HLP.Comum.Components.HLP_NumericUpDown))
                        {
                            ((HLP.Comum.Components.HLP_NumericUpDown)c).Value = valor != null ?
                                valor.ToString() != "0" ? Convert.ToDecimal(valor) : decimal.Zero : decimal.Zero;
                        }
                        else if (c.GetType() == typeof(HLP.Comum.Components.HLP_Pesquisa))
                        {
                            if (lPropriedades.FirstOrDefault(i => i.xnome ==
                               nomeProp && i.xtabela == ((HLP.Comum.Components.UserControlBase)c)._Table).value != null)
                                ((HLP.Comum.Components.HLP_Pesquisa)c).Value = lPropriedades.FirstOrDefault(i => i.xnome ==
                                   nomeProp && i.xtabela == ((HLP.Comum.Components.UserControlBase)c)._Table).value.ToInt32();
                        }
                        else if (c.GetType() == typeof(HLP.Comum.Components.HLP_CheckBox))
                            ((HLP.Comum.Components.HLP_CheckBox)c).Checked = Convert.ToBoolean(valor);
                    }
                    catch (System.Exception ex)
                    {
                    }
                }

            }
        }

        protected object CarregaClasse<T>(T model) where T : class
        {
            string sTabela = model.GetType().Name.ToString().Replace("Model", "");
            Type tipo = model.GetType();
            Control controle = null;
            List<Control> lControles = new List<Control>();
            lControles = iConfigFormularioService.lControl.Where(c => c.GetType() !=
                typeof(HLP.Comum.Components.HLP_DataGridView)).ToList();
            //List<Control> lControlsTemp = new List<Control>();
            //lControlsTemp = iConfigFormularioService.lControl.Where(i => ((UserControlBase)i)._Table == sTabela).ToList();
            foreach (PropertyInfo item in tipo.GetProperties())
            {
                controle = (lControles.Where(c => c.GetType().BaseType == typeof(UserControlBase))).
                    FirstOrDefault(c =>
                   ((UserControlBase)c)._Table == sTabela
                     && ((UserControlBase)c)._Field == item.Name);

                if (controle != null && controle.Name != "txtCodigo")
                {
                    try
                    {
                        if (controle.GetType() == typeof(HLP.Comum.Components.HLP_TextBox))
                        {
                            if (item.PropertyType == typeof(DateTime))
                                item.SetValue(model, Convert.ToDateTime(((HLP.Comum.Components.HLP_TextBox)controle).Text));
                            else if (item.PropertyType == typeof(string))
                                item.SetValue(model, ((HLP.Comum.Components.HLP_TextBox)controle).Text);
                        }

                        else if (controle.GetType() == typeof(HLP.Comum.Components.HLP_MaskedTextBox))
                        {
                            item.SetValue(model, ((HLP.Comum.Components.HLP_MaskedTextBox)controle).Text);
                        }

                        else if (controle.GetType() == typeof(HLP.Comum.Components.HLP_NumericUpDown))
                        {
                            if (item.PropertyType == typeof(Int32))
                                item.SetValue(model, ((HLP.Comum.Components.HLP_NumericUpDown)controle).Value.ToInt32());
                            else if (item.PropertyType == typeof(decimal?))
                                item.SetValue(model, ((HLP.Comum.Components.HLP_NumericUpDown)controle).Value);
                            else if (item.PropertyType == typeof(decimal))
                                item.SetValue(model, ((HLP.Comum.Components.HLP_NumericUpDown)controle).Value);
                            else if (item.PropertyType == typeof(string))
                                item.SetValue(model, ((HLP.Comum.Components.HLP_NumericUpDown)controle).Value.ToString());
                            else if (item.PropertyType == typeof(byte))
                                item.SetValue(model, (Convert.ToByte(((HLP.Comum.Components.HLP_NumericUpDown)controle).ValueInt)));
                        }

                        else if (controle.GetType() == typeof(HLP.Comum.Components.HLP_ComboBox))
                        {
                            if (item.PropertyType == typeof(bool))
                                item.SetValue(model,
                                    ((HLP.Comum.Components.HLP_ComboBox)controle).Text.Contains("SIM") ? true : false);
                            else if (item.PropertyType == typeof(byte) || item.PropertyType == typeof(Nullable<byte>))
                                item.SetValue(model, ((HLP.Comum.Components.HLP_ComboBox)controle).SelectedIndexByte);
                            else if (item.PropertyType == typeof(Int32))
                                item.SetValue(model, ((HLP.Comum.Components.HLP_ComboBox)controle).SelectedValue);
                        }
                        else if (controle.GetType() == typeof(HLP.Comum.Components.HLP_Pesquisa))
                        {
                            if (((HLP.Comum.Components.HLP_Pesquisa)controle).Value != 0)
                                item.SetValue(model, ((HLP.Comum.Components.HLP_Pesquisa)controle).Value);
                        }
                        else if (controle.GetType() == typeof(HLP.Comum.Components.HLP_DateTimePicker))
                        {
                            item.SetValue(model, ((HLP.Comum.Components.HLP_DateTimePicker)controle).Value);
                        }
                        else if (controle.GetType() == typeof(HLP.Comum.Components.HLP_CheckBox))
                        {
                            item.SetValue(model, ((HLP.Comum.Components.HLP_CheckBox)controle).Value);
                        }
                    }
                    catch (System.Exception ex)
                    {
                    }
                }

                //item.SetValue(model, 
            }

            return model;
        }
        #endregion

        #region Eventos Painel de atalho

        public void AddAtalhosPanel(params KryptonButton[] botoes)
        {
            ConfiguraBotoes(botoes);
        }

        private void ConfiguraBotoes(params KryptonButton[] botoes)
        {
            foreach (KryptonButton b in botoes.OrderBy(but => but.Text))
            {
                flowPainelBotoes.Controls.Add(b);
                b.ButtonStyle = ButtonStyle.Form;
                b.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
                b.StateCommon.Content.ShortText.TextH = PaletteRelativeAlign.Near;
                b.StateCommon.Content.Image.ImageH = PaletteRelativeAlign.Near;
                b.Height = 25;
                b.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            }
            AjustarBotoesFlow();
        }

        private void AjustarBotoesFlow()
        {
            foreach (KryptonButton b in flowPainelBotoes.Controls)
            {
                if (b.GetType() == typeof(KryptonButton))
                {
                    b.Width = flowPainelBotoes.Width;
                }

            }
        }

        private void btnMinimiza_Click(object sender, EventArgs e)
        {
            if (bLoad)
            {
                kryptonSplitContainer1.FixedPanel = FixedPanel.None;
                bLoad = false;
            }
            kryptonSplitContainer1.SuspendLayout();
            if (kryptonSplitContainer1.FixedPanel == FixedPanel.None)
            {
                kryptonSplitContainer1.FixedPanel = FixedPanel.Panel2;
                kryptonSplitContainer1.IsSplitterFixed = true;

                _cacheWidth = kryptonSplitContainer1.Panel2.Width;
                int newWidth = kryptonHeader1.PreferredSize.Height;

                kryptonSplitContainer1.Panel2MinSize = newWidth;
                kryptonSplitContainer1.SplitterDistance = kryptonSplitContainer1.Width - newWidth;

                kryptonHeader1.Orientation = VisualOrientation.Right;
                kryptonHeader1.ButtonSpecs[0].Edge = PaletteRelativeEdgeAlign.Near;
                kryptonHeader1.ButtonSpecs[0].Type = PaletteButtonSpecStyle.ArrowLeft;


                OcultaMostraCompon(panelAtalhos, false);
            }
            else
            {
                kryptonSplitContainer1.FixedPanel = FixedPanel.None;
                kryptonSplitContainer1.IsSplitterFixed = false;
                kryptonSplitContainer1.Panel2MinSize = 25;
                kryptonSplitContainer1.SplitterDistance = kryptonSplitContainer1.Width - _cacheWidth;

                kryptonHeader1.Orientation = VisualOrientation.Top;
                kryptonHeader1.ButtonSpecs[0].Edge = PaletteRelativeEdgeAlign.Far;
                kryptonHeader1.ButtonSpecs[0].Type = PaletteButtonSpecStyle.ArrowRight;


                OcultaMostraCompon(panelAtalhos, true);
            }
            kryptonSplitContainer1.ResumeLayout();
        }

        private void OcultaMostraCompon(Control controle, bool bVisible)
        {
            foreach (Control c in controle.Controls)
            {
                if (c.Controls.Count > 0)
                    OcultaMostraCompon(c, bVisible);

                if (c.GetType() != typeof(KryptonHeader))
                    c.Visible = bVisible;
            }
        }


        #endregion

        private void flowPainelBotoes_SizeChanged(object sender, EventArgs e)
        {
            AjustarBotoesFlow();
        }

        private void FormPadraoCadastro_Load(object sender, EventArgs e)
        {
            bLoad = true;
            btnMinimiza_Click(this, null);
        }

    }
}
