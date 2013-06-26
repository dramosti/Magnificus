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
    public partial class FormJuros : FormPadraoCadastro
    {
        [Inject]
        public IJurosService jurosService { get; set; }

        JurosModel jurosModel = new JurosModel();

        public FormJuros()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
        }

        private void FormJuros_Load(object sender, EventArgs e)
        {
            InicializaFormPadrao("vwJuros");
        }



        public override void Novo()
        {
            base.Novo();
            cbostDiaMes.SelectedIndex = 0;
            jurosModel = new JurosModel();
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
            jurosService.Delete(Convert.ToInt32(txtCodigo.Text));
            base.Excluir();
            if (iRetPesquisa != null)
            {
                base.MoveProximoItem();
                jurosModel = jurosService.GetJuros((int)iRetPesquisa);
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
                    jurosService.Delete((int)lParaExcluir[i]);
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
                jurosService.Save(jurosModel);

                txtCodigo.Text = jurosModel.idJuros.ToString();

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
                        jurosModel = jurosService.GetJuros(Convert.ToInt32(txtCodigo.Text));
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
                    jurosModel = jurosService.GetJuros((int)iRetPesquisa);
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
                    jurosModel = jurosService.GetJuros((int)iRetPesquisa);
                    if (jurosModel != null)
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
                    jurosModel = jurosService.GetJuros((int)iRetPesquisa);
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
                int i = jurosService.Copy(Convert.ToInt32(txtCodigo.Text));
                jurosModel = jurosService.GetJuros(i);
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
                jurosModel.xNome = txtxNome.Text;
                jurosModel.xDescricao = txtxDescricao.Text;
                jurosModel.pJuros = nudpJuros.Value;
                jurosModel.nQuantidadeDiasMes = nudnQuantidadeDiasMes.ValueInt;
                jurosModel.stDiaMes = cbostDiaMes.SelectedIndexByte;
                jurosModel.nCarencia = nudnCarencia.ValueInt;

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
                txtCodigo.Text = jurosModel.idJuros.ToString();
                txtxNome.Text = jurosModel.xNome;
                txtxDescricao.Text = jurosModel.xDescricao;
                nudpJuros.Value = jurosModel.pJuros;
                nudnQuantidadeDiasMes.Value = jurosModel.nQuantidadeDiasMes;
                cbostDiaMes.SelectedIndex = jurosModel.stDiaMes;
                nudnCarencia.Value = jurosModel.nCarencia;
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInt32(txtCodigo.Text);
            while (true)
            {
                try
                {
                    int idOrigem = Convert.ToInt32(txtCodigo.Text);
                    int i = jurosService.Copy(cod);
                }
                catch (Exception ex)
                {
                    new HLPexception(ex);
                }
            }
        }
    }
}