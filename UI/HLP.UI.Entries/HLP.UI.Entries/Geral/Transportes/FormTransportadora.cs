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
using HLP.Services.Interfaces.Entries;
using HLP.Comum.Services.Interface;
using HLP.Models.Entries.Gerais;
using HLP.Dependencies;
using HLP.Comum.Models.Static;
using HLP.Comum.UI.Exception;
using HLP.Comum.Messages;
using System.Threading;

namespace HLP.UI.Entries.Geral.Transportes
{
    public partial class FormTransportadora : FormPadraoCadastro
    {
        [Inject]
        public ITransportadorService transportadorService { get; set; }
        [Inject]
        public IPesquisaPadraoService pesquisaPadraoService { get; set; }

        [Inject]
        public ICidadeService cidadeService { get; set; }

        TransportadorModel objTransportador = new TransportadorModel();
        Action verifBw = null;

        public FormTransportadora()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
        }

        private void FormTransportador_Load(object sender, EventArgs e)
        {
            idCidade.Tag = "FormCidade-vwCidade-xCidade_Uf_xRegiao_xPais";
            idContato_Contato.Tag = "FormContato-vwContato-xNome";
            idContato_Motorista.Tag = "FormContato-vwContato-xNome";
            idUf.Tag = "FormUF-vwUF-xSiglaUf";
            InicializaFormPadrao("vwTransportador");
            verifBw += (() =>
                {
                    InitializeComboBox();
                });
            Thread t1 = new Thread(new ThreadStart(verifBw));
            t1.Start();
        }

        void InitializeComboBox()
        {
            if(objMetodosForm != null)
            {
                idCidade.DataSource = pesquisaPadraoService.GetData(objMetodosForm.GetDisplayMember(idCidade), true);
                idContato_Contato.DataSource = pesquisaPadraoService.GetData(objMetodosForm.GetDisplayMember(idContato_Contato), true);
                idContato_Motorista.DataSource = pesquisaPadraoService.GetData(objMetodosForm.GetDisplayMember(idContato_Motorista), true);
                idUf.DataSource = pesquisaPadraoService.GetData(objMetodosForm.GetDisplayMember(idUf), true);
                Thread.CurrentThread.Abort();
            }
            else
            {
                Thread.Sleep(500);
                InitializeComboBox();
            }
            
        }

        public override void Novo()
        {
            try
            {
                base.Novo();
                cbxstPessoa.SelectedIndex = 1;
                cboAtivo.SelectedIndex = 1;
                objTransportador = new TransportadorModel();
                bsTransportadorContatoModel.DataSource = objTransportador.lTransportador_Contato;
                bsTransportadorEnderecoModel.DataSource = objTransportador.lTransportador_Endereco;
                bsTransportadorMotoristaModel.DataSource = objTransportador.lTransportador_Motorista;
                bsTransportadorVeiculosModel.DataSource = objTransportador.lTransportador_Veiculos;
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
                if (cbxstPessoa.SelectedIndex == 0)
                {
                    mskxCnpj._Obrigatorio = Comum.Components.HLP_MaskedTextBox.CampoObrigatorio.NÃO;
                    mskxIe._Obrigatorio = Comum.Components.HLP_MaskedTextBox.CampoObrigatorio.NÃO;
                    mskxCpf._Obrigatorio = Comum.Components.HLP_MaskedTextBox.CampoObrigatorio.SIM;
                    txtxRg._Obrigatorio = Comum.Components.HLP_TextBox.CampoObrigatorio.SIM;

                }
                else
                {
                    mskxCnpj._Obrigatorio = Comum.Components.HLP_MaskedTextBox.CampoObrigatorio.SIM;
                    mskxIe._Obrigatorio = Comum.Components.HLP_MaskedTextBox.CampoObrigatorio.SIM;
                    mskxCpf._Obrigatorio = Comum.Components.HLP_MaskedTextBox.CampoObrigatorio.NÃO;
                    txtxRg._Obrigatorio = Comum.Components.HLP_TextBox.CampoObrigatorio.NÃO;
                }

                mskxIe._UF = "";
                if (objTransportador.lTransportador_Endereco.Where(c => c.stPrincipal == 1).Count() > 0)
                {
                    int? idCidade = objTransportador.lTransportador_Endereco.FirstOrDefault(c => c.stPrincipal == 1).idCidade;
                    if (idCidade != 0)
                    {
                        mskxIe._UF = cidadeService.GetUfByCidade((int)idCidade).xSiglaUf;
                    }
                }

                objValidaCampos.Validar();
                PopulaTabela();
                
                transportadorService.Save(objTransportador);

                base.Salvar();
                PopulaForm();
            }
            catch (Exception ex)
            {
                new HLPexception(ex, this);
            }
        }
        public override void Atualizar()
        {
            base.Atualizar();
            PessoaFisicaJuridica();
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
                    objTransportador = transportadorService.GetTransportador((int)iRetPesquisa, true);
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
                    objTransportador = transportadorService.GetTransportador((int)iRetPesquisa, true);
                    if (objTransportador != null)
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
                transportadorService.Copy(objTransportador);
                PopulaForm();
                base.RegistroDuplicado(idOrigem, (int)objTransportador.idTransportador);
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
                    objTransportador = transportadorService.GetTransportador((int)iRetPesquisa, true);
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
                    objTransportador = transportadorService.GetTransportador((int)lParaExcluir[i], true);
                    transportadorService.Delete(objTransportador);
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
            transportadorService.Delete(objTransportador);
            base.Excluir();
            if (iRetPesquisa != null)
            {
                base.MoveProximoItem();
                objTransportador = transportadorService.GetTransportador((int)iRetPesquisa, true);
                PopulaForm();
            }
        }



        void PopulaTabela()
        {
            objTransportador.xCodigoAlternativo = txtxCodigoAlternativo.Text;
            objTransportador.xNome = txtxNome.Text;
            objTransportador.xFantasia = txtxFantasia.Text;
            objTransportador.stPessoa = cbxstPessoa.SelectedIndexByte;
            objTransportador.xCnpj = mskxCnpj.Text;
            objTransportador.xIe = mskxIe.Text;
            objTransportador.xIm = txtxIm.Text;
            objTransportador.xCpf = mskxCpf.Text;
            objTransportador.xRg = txtxRg.Text;
            objTransportador.xRntrc = txtxRntrc.Text;
            objTransportador.xTelefone1 = txtxTelefone1.Text;
            objTransportador.xTelefone2 = txtxTelefone2.Text;
            objTransportador.xFax = txtxFax.Text;
            objTransportador.xHttp = txtxHttp.Text;
            objTransportador.Ativo = cboAtivo.SelectedIndex == 0 ? false : true;



        }

        void PopulaForm()
        {
            txtCodigo.Text = objTransportador.idTransportador.ToString();
            if (objTransportador.xCodigoAlternativo == String.Empty)
            {
                txtxCodigoAlternativo.Text = txtCodigo.Text;
            }
            else
            {
                txtxCodigoAlternativo.Text = objTransportador.xCodigoAlternativo;
            }
            txtxNome.Text = objTransportador.xNome;
            txtxFantasia.Text = objTransportador.xFantasia;
            cbxstPessoa.SelectedIndex = objTransportador.stPessoa;
            mskxCnpj.Text = objTransportador.xCnpj;
            mskxIe.Text = objTransportador.xIe;
            txtxIm.Text = objTransportador.xIm;
            mskxCpf.Text = objTransportador.xCpf;
            txtxRg.Text = objTransportador.xRg;
            txtxRntrc.Text = objTransportador.xRntrc;
            txtxTelefone1.Text = objTransportador.xTelefone1;
            txtxTelefone2.Text = objTransportador.xTelefone2;
            txtxFax.Text = objTransportador.xFax;
            txtxHttp.Text = objTransportador.xHttp;
            cboAtivo.SelectedIndex = objTransportador.Ativo == true ? 1 : 0;
            bsTransportadorContatoModel.DataSource = objTransportador.lTransportador_Contato;
            bsTransportadorEnderecoModel.DataSource = objTransportador.lTransportador_Endereco;
            bsTransportadorMotoristaModel.DataSource = objTransportador.lTransportador_Motorista;
            bsTransportadorVeiculosModel.DataSource = objTransportador.lTransportador_Veiculos;
        }

        private void dgvEndereco_Enter(object sender, EventArgs e)
        {
            Sistema.contatoStatico.idFkReferencia = (txtCodigo.Text != "") ? Convert.ToInt32(txtCodigo.Text) : 0;
            Sistema.contatoStatico.fkTableReferencia = "idTransportador";
        }

        private void cbxstPessoa__SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnSalvar.Enabled)
            {
                PessoaFisicaJuridica();
            }
        }

        void PessoaFisicaJuridica()
        {
            if (cbxstPessoa.SelectedIndex == 0)
            {
                mskxCnpj.Enabled = false;
                mskxCnpj.Text = "";
                mskxIe.Enabled = false;
                mskxIe.Text = "";
                txtxIm.Enabled = false;
                txtxIm.Text = "";
                mskxCpf.Enabled = true;
                txtxRg.Enabled = true;
            }
            else
            {
                mskxCnpj.Enabled = true;
                mskxIe.Enabled = true;
                txtxIm.Enabled = true;
                mskxCpf.Enabled = false;
                mskxCpf.Text = "";
                txtxRg.Enabled = false;
                txtxRg.Text = "";
            }
        }

        private void dgvContato_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtxNome__Leave(object sender, EventArgs e)
        {
            if (txtxFantasia.Text == String.Empty)
            {
                txtxFantasia.Text = txtxNome.Text;
            }
        }

    }
}
