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
using HLP.Models.Entries.Gerais;
using HLP.Services.Interfaces.Entries.Gerais;
using HLP.Dependencies;
using HLP.Comum.Messages;
using HLP.Comum.UI.Exception;
using System.Threading;

namespace HLP.UI.Entries.Geral
{
    public partial class FormCondicaoEntrega : FormPadraoCadastro
    {
        [Inject]
        public ICondicoes_entregaService condicoesService { get; set; }

        Condicoes_entregaModel condicoes_entregaModel = new Condicoes_entregaModel();

        public FormCondicaoEntrega()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
        }

        private void FormCondicaoEntrega_Load(object sender, EventArgs e)
        {
            InicializaFormPadrao("vwCondicaoEntrega");
        }



        public override void Novo()
        {
            base.Novo();
            condicoes_entregaModel = new Condicoes_entregaModel();
            cbostEnderecoImpostoSobreVendas.SelectedIndex = 0;
            cbostAplicarMinGratis.SelectedIndex = 0;
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
            condicoesService.Delete(Convert.ToInt32(txtCodigo.Text));
            base.Excluir();
            if (iRetPesquisa != null)
            {
                base.MoveProximoItem();
                condicoes_entregaModel = condicoesService.GetCondicao((int)iRetPesquisa);
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
                    condicoesService.Delete((int)lParaExcluir[i]);
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
            cbostAplicarMinGratis__SelectedIndexChanged(null, null);
        }
        public override void Salvar()
        {
            try
            {
                objValidaCampos.Validar();

                PopulaTabela();
                condicoesService.Save(condicoes_entregaModel);

                txtCodigo.Text = condicoes_entregaModel.idCondicaoEntrega.ToString();

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
                        condicoes_entregaModel = condicoesService.GetCondicao(Convert.ToInt32(txtCodigo.Text));
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
                    condicoes_entregaModel = condicoesService.GetCondicao((int)iRetPesquisa);
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
                    condicoes_entregaModel = condicoesService.GetCondicao((int)iRetPesquisa);
                    if (condicoes_entregaModel != null)
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
                    condicoes_entregaModel = condicoesService.GetCondicao((int)iRetPesquisa);
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
                int i = condicoesService.Copy(Convert.ToInt32(txtCodigo.Text));
                condicoes_entregaModel = condicoesService.GetCondicao(i);
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
                condicoes_entregaModel.xCondicaoEntrega = txtxCondicaoEntrega.Text;
                condicoes_entregaModel.xDescricao = txtxDescricao.Text;
                condicoes_entregaModel.stEnderecoImpostoSobreVendas = cbostEnderecoImpostoSobreVendas.SelectedIndexByte;
                condicoes_entregaModel.nIntrastat = txtnIntrastat.Text;
                condicoes_entregaModel.stAplicarMinGratis = cbostAplicarMinGratis.SelectedIndexByte;
                condicoes_entregaModel.vMinimoGratis = nudvMinimoGratis.Value;

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
                txtCodigo.Text = condicoes_entregaModel.idCondicaoEntrega.ToString();
                txtxCondicaoEntrega.Text = condicoes_entregaModel.xCondicaoEntrega;
                txtxDescricao.Text = condicoes_entregaModel.xDescricao;
                cbostEnderecoImpostoSobreVendas.SelectedIndex = condicoes_entregaModel.stEnderecoImpostoSobreVendas;
                txtnIntrastat.Text = condicoes_entregaModel.nIntrastat;
                cbostAplicarMinGratis.SelectedIndex = condicoes_entregaModel.stAplicarMinGratis;
                nudvMinimoGratis.Value = condicoes_entregaModel.vMinimoGratis;
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }

        }

        private void cbostAplicarMinGratis__SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnSalvar.Enabled)
            {
                if (cbostAplicarMinGratis.SelectedIndex == 0)
                {
                    nudvMinimoGratis.Value = 0;
                    nudvMinimoGratis.Enabled = false;
                }
                else
                {
                    nudvMinimoGratis.Enabled = true;
                }
            }
        }
    }
}
