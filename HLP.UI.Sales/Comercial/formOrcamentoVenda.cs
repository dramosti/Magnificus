using HLP.Comum.Messages;
using HLP.Comum.Services.Interface;
using HLP.Comum.UI;
using HLP.Comum.UI.Exception;
using HLP.Dependencies;
using HLP.Models.Sales.Comercial;
using HLP.Services.Interfaces.Sales.Comercial;
using Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HLP.UI.Sales.Comercial
{
    public partial class formOrcamentoVenda : FormPadraoCadastro
    {
        Action VerifBw = null;
        Thread t1 = null;
        Orcamento_ideModel objOrcamento = null;

        [Inject]
        public IPesquisaPadraoService pesquisaPadraoService { get; set; }

        [Inject]
        public IOrcamento_ideService orcamento_ideService { get; set; }

        public formOrcamentoVenda()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
        }

        private void formOrcamentoVenda_Load(object sender, EventArgs e)
        {
            objOrcamento = new Orcamento_ideModel();
            //idFuncionario.Tag = "FormFuncionario-vwFuncionario-xNome";
            InicializaFormPadrao("vwOrcamento");
            VerifBw += (() =>
            {
                CarregaCombosGrid();
            });
            t1 = new Thread(new ThreadStart(VerifBw));
            t1.Start();
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
                //idFuncionario.DataSource = pesquisaPadraoService.GetData(objMetodosForm.GetDisplayMember(idFuncionario), true);
                Thread.CurrentThread.Abort();
            }
        }

        public override void Novo()
        {
            try
            {
                base.Novo();
                objOrcamento = new Orcamento_ideModel();
                bsFiscal.DataSource = objOrcamento.lOrcamento_Itens.FirstOrDefault().orcamento_Item_Impostos;
                bsItensCancelados.DataSource = objOrcamento.lOrcamento_ItensCancelPerd;
                bsItensVendidos.DataSource = objOrcamento.lOrcamento_ItensVendidos;
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
                    objOrcamento = orcamento_ideService.GetOrcamento_ide((int)lParaExcluir[i]);
                    orcamento_ideService.Delete(objOrcamento);
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
            orcamento_ideService.Delete(objOrcamento);
            base.Excluir();
            if (iRetPesquisa != null)
            {
                base.MoveProximoItem();
                objOrcamento = orcamento_ideService.GetOrcamento_ide((int)iRetPesquisa);
                PopulaForm();
            }
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

                orcamento_ideService.Save(objOrcamento);

                txtCodigo.Text = objOrcamento.idOrcamento.ToString();
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
                        objOrcamento = orcamento_ideService.GetOrcamento_ide(Convert.ToInt32(txtCodigo.Text));

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
                    objOrcamento = orcamento_ideService.GetOrcamento_ide((int)iRetPesquisa);

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
                    objOrcamento = orcamento_ideService.GetOrcamento_ide((int)iRetPesquisa);
                    if (objOrcamento != null)
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
                    objOrcamento = orcamento_ideService.GetOrcamento_ide((int)iRetPesquisa);
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
                orcamento_ideService.Copy(objOrcamento);
                PopulaForm();
                base.RegistroDuplicado(idOrigem, (int)objOrcamento.idOrcamento);
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
                base.CarregaClasse(orcamento_ideService);
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
                base.CarregaPropriedades(orcamento_ideService, true);
                base.CarregaForm();
                bsItensOrcamento.DataSource = objOrcamento.lOrcamento_Itens;
                bsItensVendidos.DataSource = objOrcamento.lOrcamento_ItensVendidos;
                bsItensCancelados.DataSource = objOrcamento.lOrcamento_ItensCancelPerd;
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }
    }
}
