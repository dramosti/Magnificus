using HLP.Comum.Messages;
using HLP.Comum.Services.Interface;
using HLP.Comum.UI;
using HLP.Comum.UI.Exception;
using HLP.Dependencies;
using HLP.Models.Entries.Gerais;
using HLP.Services.Interfaces.Entries.Gerais;
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

namespace HLP.UI.Entries.Geral
{
    public partial class FormAcesso : FormPadraoCadastro
    {
        [Inject]
        public IFuncionarioService funcionarioService { get; set; }
        [Inject]
        public IPesquisaPadraoService pesquisaPadraoService { get; set; }
        [Inject]
        public IAcessoService acessoService { get; set; }

        FuncionarioModel objFuncionarioModel = new FuncionarioModel();
        Action verifBw = null;

        public FormAcesso()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
        }

        private void FormAcesso_Load(object sender, EventArgs e)
        {
            idEmpresa.Tag = "FormEmpresa-vwEmpresa-ID_xNome";
            idSetor.Tag = "FormSetor-vwSetor-xSetor";
            InicializaFormPadrao("vwFuncionario");
            btnNovo.Visible = false;
            btnDuplicar.Visible = false;
            btnExcluir.Visible = false;
            verifBw += (() =>
            {
                InitializaComboBox();
            });

            Thread t1 = new Thread(new ThreadStart(verifBw));
            t1.Start();
        }

        private void InitializaComboBox()
        {
            if (objMetodosForm != null)
            {
                idEmpresa.DataSource = pesquisaPadraoService.GetData(sSelect: objMetodosForm.GetDisplayMember(idEmpresa), addDefault: true, bOrdena: false);
                idSetor.DataSource = pesquisaPadraoService.GetData(objMetodosForm.GetDisplayMember(idSetor), true);
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
                objFuncionarioModel = new FuncionarioModel();
                bsAcesso.DataSource = objFuncionarioModel.lFuncionario_Acesso;
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
            }
            catch (Exception ex)
            {
                new HLPexception(ex, this);
            }
        }

        public override void Atualizar()
        {
            base.Atualizar();
            txtIdFuncionario.Enabled = txtxCodigoAlternativo.Enabled = txtxNome.Enabled = false;

        }
        public override void Cancelar()
        {
            try
            {
                if (HLPMessageBox.MsgCancelar())
                {
                    PopulaForm();
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
                //int idOrigem = Convert.ToInt32(txtCodigo.Text);
                //funcionarioService.Copy(objFuncionarioModel);
                //PopulaForm();
                //base.RegistroDuplicado(idOrigem, (int)objFuncionarioModel.idFuncionario);
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
            
            txtIdFuncionario.Text = objFuncionarioModel.idFuncionario.Value.ToString();
            txtxCodigoAlternativo.Text = objFuncionarioModel.xCodigoAlternativo;
            txtxNome.Text = objFuncionarioModel.xNome;
        }

        void CarregaAcesso()
        {
            objFuncionarioModel.lFuncionario_Acesso = acessoService.GetAllAcesso_Funcionario(objFuncionarioModel.idFuncionario.Value);
            bsAcesso.DataSource = objFuncionarioModel.lFuncionario_Acesso;            
        }

        void PopulaTabela()
        {
        }

        private void txtIdFuncionario__TextChanged(object sender, EventArgs e)
        {
            if (txtIdFuncionario.Text != "")
            {
                CarregaAcesso();
            }
        }
    }
}
