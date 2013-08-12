using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using HLP.Comum.UI;
using Ninject;
using HLP.Services.Interfaces.Entries.Gerais;
using HLP.Models.Entries.Gerais;
using HLP.Dependencies;
using HLP.Comum.Services.Interface;
using HLP.Comum.UI.Exception;
using HLP.Comum.Messages;

using System.Threading;
using HLP.Comum.Infrastructure.Static;

namespace HLP.UI.Entries.Geral
{
    public partial class FormContato : FormPadraoCadastro
    {
        [Inject]
        public IContatoService contatoService { get; set; }
        [Inject]
        public IFuncionarioService funcionarioService { get; set; }
        [Inject]
        public IPesquisaPadraoService pesquisaPadraoService { get; set; }


        Action verifBw = null;
        ContatoModel objContatoModel = new ContatoModel();


        public FormContato()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
        }

        private void FormContato_Load(object sender, EventArgs e)
        {
            idCidade.Tag = "FormCidade-vwCidade-xCidade_Uf_xRegiao_xPais";
            InicializaFormPadrao("vwContato");
            dtdDisponivelaPartir.dtp.ShowUpDown = true;
            dtdDisponivelAte.dtp.ShowUpDown = true;
            InitializaComboBox();
            if (Sistema.contatoStatico.idFkContato != 0 && this.Modal)
            {
                objContatoModel = contatoService.GetContato(Sistema.contatoStatico.idFkContato, true);
                PopulaForm();
            }
        }

        private void InitializaComboBox()
        {

            if (Sistema.contatoStatico.idFkReferencia != 0 && this.Modal)
            {
                StringBuilder sQuery = new StringBuilder();
                sQuery.Append("select (cast(c.idContato as varchar) + ' - ' + c.xNome) as xNome, c.idContato from {0} tab inner join Contato c on ");
                sQuery.Append("tab.idContato = c.idContato ");
                sQuery.Append("where tab.{1} = {2} ");
                cbxidContatoGerente.DataSource = pesquisaPadraoService.GetData(string.Format(sQuery.ToString(), Sistema.contatoStatico.nmTable,
                                                                                                               Sistema.contatoStatico.fkTableReferencia,
                                                                                                               Sistema.contatoStatico.idFkReferencia));
            }

            verifBw += (() =>
            {
                CarregaComboBox();
            });

            Thread t1 = new Thread(new ThreadStart(verifBw));
            t1.Start();

            //vwFuncionario
            cbxidFuncionario.DataSource = pesquisaPadraoService.GetData(funcionarioService.GetQueryFuncionarios());
            cbxidContatoGerente.SelectedIndex = -1;
            cbxidFuncionario.SelectedIndex = -1;


        }

        private void CarregaComboBox()
        {
            if (objMetodosForm != null)
            {
                idCidade.DataSource = pesquisaPadraoService.GetData(objMetodosForm.GetDisplayMember(idCidade), true);
                Thread.CurrentThread.Abort();
            }
            else
            {
                Thread.Sleep(500);
                CarregaComboBox();
            }
        }

        public override void Novo()
        {
            try
            {
                base.Novo();
                cbxstSensibilidade.SelectedIndex = 1;
                objContatoModel = new ContatoModel();
                bsContatoEndereco.DataSource = objContatoModel.lContato_Endereco;
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

                contatoService.Save(objContatoModel);

                txtCodigo.Text = objContatoModel.idContato.ToString();
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
                    objContatoModel = contatoService.GetContato((int)iRetPesquisa, true);
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
                    objContatoModel = contatoService.GetContato((int)iRetPesquisa, true);
                    if (objContatoModel != null)
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
                int idOrigem = Convert.ToInt32(txtCodigo.Text);
                contatoService.Copy(objContatoModel);
                PopulaForm();
                base.RegistroDuplicado(idOrigem, (int)objContatoModel.idContato);
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
                    objContatoModel = contatoService.GetContato((int)iRetPesquisa, true);
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
                    objContatoModel = contatoService.GetContato((int)lParaExcluir[i], true);
                    contatoService.Delete(objContatoModel);
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
            contatoService.Delete(objContatoModel);
            base.Excluir();
            if (iRetPesquisa != null)
            {
                base.MoveProximoItem();
                objContatoModel = contatoService.GetContato((int)iRetPesquisa, true);
                PopulaForm();
            }
        }


        void PopulaTabela()
        {
            base.CarregaClasse(objContatoModel);
        }

        void PopulaForm()
        {
            InitializaComboBox();
            bsContatoEndereco.DataSource = objContatoModel.lContato_Endereco;
            base.CarregaPropriedades(objContatoModel, true);
            base.CarregaForm();
        }

        private void FormContato_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sistema.contatoStatico.nmTable = "";
            Sistema.contatoStatico.fkTableReferencia = "";
            Sistema.contatoStatico.idFkReferencia = 0;
        }

    }
}