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
using HLP.Comum.Models.Static;
using System.Threading;

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
                    objContatoModel = contatoService.GetContato((int)lParaExcluir[i],true);
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

            #region Geral
            objContatoModel.xTitulo = txtxTitulo.Text;
            objContatoModel.xNome = txtxNome.Text;
            objContatoModel.xFuncao = txtxFuncao.Text;
            objContatoModel.xProfissao = txtxFuncao.Text;
            objContatoModel.xDepartamento = txtxDepartamento.Text;
            objContatoModel.xApelido = txtxApelido.Text;
            objContatoModel.Ativo = cbxAtivo.SelectedIndex == 0 ? false : true;
            objContatoModel.xCPF = mskxCPF.Text;
            objContatoModel.stSexo = cbxstSexo.SelectedIndexByte;
            objContatoModel.stSensibilidade = cbxstSensibilidade.SelectedIndexByte;
            if (cbxidContatoGerente.SelectedIndex > -1)
                objContatoModel.idContatoGerente = (int)cbxidContatoGerente.SelectedValue;
            if (cbxidFuncionario.cbx.SelectedIndex > -1)
                objContatoModel.idFuncionario = Convert.ToInt32(cbxidFuncionario.SelectedValue.ToString());
            objContatoModel.dDisponivelaPartir = dtdDisponivelaPartir.Value.TimeOfDay;
            objContatoModel.dDisponivelAte = dtdDisponivelAte.Value.TimeOfDay;
            #endregion

            #region Configuracao
            if (hlP_PesquisaidFidelidade.Value > 0)
                objContatoModel.idFidelidade = hlP_PesquisaidFidelidade.Value;
            if (hlP_PesquisaidDecisao.Value > 0)
                objContatoModel.idDecisao = hlP_PesquisaidDecisao.Value;
            if (hlP_PesquisaidPersonalidade.Value > 0)
                objContatoModel.idPersonalidade = hlP_PesquisaidPersonalidade.Value;
            objContatoModel.stVip = cbxstMalaDireta.SelectedIndexByte;
            objContatoModel.stMalaDireta = cbxstMalaDireta.SelectedIndexByte;
            objContatoModel.xMemorando = txtxMemorando.Text;
            #endregion

            #region Inf. de Contato
            objContatoModel.xTelefoneComercial = mskxTelefoneComercial.Text;
            objContatoModel.xRamalComercial = txtxRamalComercial.Text;
            objContatoModel.xCelularComercial = mskxCelularComercial.Text;
            objContatoModel.xRadioFoneComercial = txtxRadioFoneComercial.Text;
            objContatoModel.xPagerComercial = txtxPagerComercial.Text;
            objContatoModel.xFaxComercial = mskxFaxComercial.Text;
            objContatoModel.xEmailComercial = txtxEmailComercial.Text;
            objContatoModel.xSkypeComercial = txtxSkypeComercial.Text;
            objContatoModel.xMSNComercial = txtxMSNComercial.Text;
            objContatoModel.xhttpComercial = txtxhttpComercial.Text;
            objContatoModel.xTelefoneResidencial = mskxTelefoneResidencial.Text;
            objContatoModel.xCelularResidencial = mskxTelefoneResidencial.Text;
            objContatoModel.xRadioFoneResidencial = txtxRadioFoneResidencial.Text;
            objContatoModel.xEmailResidencial = txtxEmailResidencial.Text;
            objContatoModel.xSkypeResidencial = txtxSkypeResidencial.Text;
            objContatoModel.xMsnResidencial = txtxMsnResidencial.Text;
            objContatoModel.XhttpPessoal = txtXhttpPessoal.Text;


            #endregion

            #region Pessoal
            objContatoModel.xFilhos = txtxFilhos.Text;
            objContatoModel.dAniversario = dtdDataAniversario.Value;
            objContatoModel.xConjuge = txtxConjuge.Text;
            objContatoModel.stEstadoCivil = cbxstEstadoCivil.SelectedIndexByte;
            objContatoModel.xHobbies = txtxHobbies.Text;
            objContatoModel.dAniversarioTempoServico = dtdAniversarioTempoServico.Value;
            #endregion

        }

        void PopulaForm()
        {
            InitializaComboBox();
            bsContatoEndereco.DataSource = objContatoModel.lContato_Endereco;

            #region Geral
            txtCodigo.Text = objContatoModel.idContato.ToString();
            txtxTitulo.Text = objContatoModel.xTitulo;
            txtxNome.Text = objContatoModel.xNome;
            txtxFuncao.Text = objContatoModel.xFuncao;
            txtxFuncao.Text = objContatoModel.xProfissao;
            txtxDepartamento.Text = objContatoModel.xDepartamento;
            txtxApelido.Text = objContatoModel.xApelido;
            cbxAtivo.SelectedIndex = objContatoModel.Ativo == false ? 0 : 1;
            mskxCPF.Text = objContatoModel.xCPF;
            cbxstSexo.SelectedIndex = objContatoModel.stSexo;
            cbxstSensibilidade.SelectedIndex = objContatoModel.stSensibilidade;
            if (objContatoModel.idContatoGerente != null)
                cbxidContatoGerente.SelectedValue = objContatoModel.idContatoGerente;
            if (objContatoModel.idFuncionario != null)
                cbxidFuncionario.SelectedValue = objContatoModel.idFuncionario;
            dtdDisponivelaPartir.Value = (DateTime.Today + objContatoModel.dDisponivelaPartir);
            dtdDisponivelAte.Value = (DateTime.Today + objContatoModel.dDisponivelAte);
            #endregion

            #region Configuracao
            if (objContatoModel.idFidelidade != null)
                hlP_PesquisaidFidelidade.Value = (int)objContatoModel.idFidelidade;
            if (objContatoModel.idDecisao != null)
                hlP_PesquisaidDecisao.Value = (int)objContatoModel.idDecisao;
            if (objContatoModel.idPersonalidade != null)
                hlP_PesquisaidPersonalidade.Value = (int)objContatoModel.idPersonalidade;
            cbxstVip.SelectedIndex = objContatoModel.stVip;
            cbxstMalaDireta.SelectedIndex = objContatoModel.stMalaDireta;
            txtxMemorando.Text = objContatoModel.xMemorando;
            #endregion

            #region Inf. de Contato
            mskxTelefoneComercial.Text = objContatoModel.xTelefoneComercial;
            txtxRamalComercial.Text = objContatoModel.xRamalComercial;
            mskxCelularComercial.Text = objContatoModel.xCelularComercial;
            txtxRadioFoneComercial.Text = objContatoModel.xRadioFoneComercial;
            txtxPagerComercial.Text = objContatoModel.xPagerComercial;
            mskxFaxComercial.Text = objContatoModel.xFaxComercial;
            txtxEmailComercial.Text = objContatoModel.xEmailComercial;
            txtxSkypeComercial.Text = objContatoModel.xSkypeComercial;
            txtxMSNComercial.Text = objContatoModel.xMSNComercial;
            txtxhttpComercial.Text = objContatoModel.xhttpComercial;
            mskxCelularResidencial.Text = objContatoModel.xCelularResidencial;
            mskxTelefoneResidencial.Text = objContatoModel.xTelefoneResidencial;
            mskxTelefoneResidencial.Text = objContatoModel.xCelularResidencial;
            txtxRadioFoneResidencial.Text = objContatoModel.xRadioFoneResidencial;
            txtxEmailResidencial.Text = objContatoModel.xEmailResidencial;
            txtxSkypeResidencial.Text = objContatoModel.xSkypeResidencial;
            txtxMsnResidencial.Text = objContatoModel.xMsnResidencial;
            txtXhttpPessoal.Text = objContatoModel.XhttpPessoal;


            #endregion

            #region Pessoal
            txtxFilhos.Text = objContatoModel.xFilhos;
            dtdDataAniversario.Value = objContatoModel.dAniversario;
            txtxConjuge.Text = objContatoModel.xConjuge;
            cbxstEstadoCivil.SelectedIndex = objContatoModel.stEstadoCivil;
            txtxHobbies.Text = objContatoModel.xHobbies;
            dtdAniversarioTempoServico.Value = objContatoModel.dAniversarioTempoServico;
            #endregion
        }

        private void FormContato_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sistema.contatoStatico.nmTable = "";
            Sistema.contatoStatico.fkTableReferencia = "";
            Sistema.contatoStatico.idFkReferencia = 0;
        }

    }
}