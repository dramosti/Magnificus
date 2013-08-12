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
using HLP.Comum.Services.Interface;

using HLP.Comum.Messages;
using HLP.Comum.UI.Exception;
using ComponentFactory.Krypton.Toolkit;
using System.Threading;
using HLP.Comum.Infrastructure.Static;

namespace HLP.UI.Entries.Geral
{
    public partial class FormCalendario : FormPadraoCadastro
    {
        [Inject]
        public ICalendarioService calendarioService { get; set; }

        [Inject]
        public IPesquisaPadraoService pesquisaPadraoService { get; set; }

        CalendarioModel objCalendarioModel = new CalendarioModel();


        public FormCalendario()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
        }


        private void FormCalendario_Load(object sender, EventArgs e)
        {
            InicializaFormPadrao("vwCalendario");

            hlP_Pesquisa1idCalendarioBase.txtPesquisa.Leave += new EventHandler(txtPesquisa_Leave);
        }

        void txtPesquisa_Leave(object sender, EventArgs e)
        {
            habilitaBtnCalendario();
        }

        private void habilitaBtnCalendario()
        {
            if (hlP_Pesquisa1idCalendarioBase.Value == 0)
            {
                btnCalendarioBase.Enabled = false;
            }
            else
            {
                btnCalendarioBase.Enabled = true;
            }
        }


        public override void Novo()
        {
            base.Novo();
            objCalendarioModel = new CalendarioModel();
            bsDetalhe.DataSource = objCalendarioModel.lCalendario_Detalhe;
            habilitaBtnCalendario();
        }
        public override void Atualizar()
        {
            base.Atualizar();
            if (objCalendarioModel.idCalendarioBase != null)
            {
                btnCalendarioBase.Enabled = false;
                btnDetalhamento.Enabled = false;
                dgvItens.ReadOnly = true;
                hlP_Pesquisa1idCalendarioBase.Enabled = false;
            }
            if (hlP_Pesquisa1idCalendarioBase.Value == 0)
            {
                btnCalendarioBase.Enabled = false;
            }
            habilitaBtnCalendario();
        }
        public override void Salvar()
        {
            try
            {
                objValidaCampos.Validar();
                PopulaTabela();

                calendarioService.Save(objCalendarioModel);

                txtCodigo.Text = objCalendarioModel.idCalendario.ToString();
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
                        objCalendarioModel = calendarioService.GetCalendario(Convert.ToInt32(txtCodigo.Text), true);
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
                    objCalendarioModel = calendarioService.GetCalendario((int)iRetPesquisa, true);
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
                    objCalendarioModel = calendarioService.GetCalendario((int)iRetPesquisa, true);
                    if (objCalendarioModel != null)
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
                    objCalendarioModel = calendarioService.GetCalendario((int)iRetPesquisa, true);
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
                calendarioService.Copy(objCalendarioModel);
                PopulaForm();
                base.RegistroDuplicado(idOrigem, (int)objCalendarioModel.idCalendario);
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

        private void ExcluirRegistro()
        {
            //calendarioService.Delete(objCalendarioModel);
            base.Excluir();
            bsDetalhe.DataSource = new List<Calendario_DetalheModel>();

            if (iRetPesquisa != null)
            {
                base.MoveProximoItem();
                objCalendarioModel = calendarioService.GetCalendario((int)iRetPesquisa, true);
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

                    objCalendarioModel = calendarioService.GetCalendario((int)lParaExcluir[i], true);
                    calendarioService.Delete(objCalendarioModel);
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
                objCalendarioModel.idEmpresa = CompanyData.idEmpresa;
                base.CarregaClasse(objCalendarioModel);

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
                base.CarregaPropriedades(objCalendarioModel, true);
                base.CarregaForm();
                bsDetalhe.DataSource = objCalendarioModel.lCalendario_Detalhe;
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }

        }


        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                FormCalendarioDetalhe frm = new FormCalendarioDetalhe();
                frm.ShowDialog();
                if (frm.Aplica)
                {
                    objCalendarioModel.lCalendario_Detalhe = frm.lcalendarioDetalheModel;
                    bsDetalhe.DataSource = new List<Calendario_DetalheModel>();
                    bsDetalhe.DataSource = objCalendarioModel.lCalendario_Detalhe;
                }
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }
        private void btnCalendarioBase_Click(object sender, EventArgs e)
        {
            try
            {
                if (hlP_Pesquisa1idCalendarioBase.Value != 0)
                {
                    objCalendarioModel.lCalendario_Detalhe = calendarioService.GetCalendario((int)hlP_Pesquisa1idCalendarioBase.Value, true).lCalendario_Detalhe;
                    foreach (Calendario_DetalheModel detalhe in objCalendarioModel.lCalendario_Detalhe)
                    {
                        detalhe.idCalendarioDetalhe = null;
                        detalhe.SetStatusRegistro(Comum.Infrastructure.BaseModelFilhos.statusRegistroFilho.Incluido);
                    }

                    bsDetalhe.DataSource = new List<Calendario_DetalheModel>();
                    bsDetalhe.DataSource = objCalendarioModel.lCalendario_Detalhe;

                    btnDetalhamento.Enabled = false;
                    dgvItens.ReadOnly = true;
                }
                else
                {
                    KryptonMessageBox.Show("Selecione o calendário base!", Mensagens.MSG_Aviso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }


        private void dgvItens_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["dCalendario"].Value = DateTime.Now.Date;
        }

    }
}

