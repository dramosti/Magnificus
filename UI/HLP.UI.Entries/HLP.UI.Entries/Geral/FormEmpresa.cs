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
    public partial class FormEmpresa : FormPadraoCadastro
    {
        [Inject]
        public IEmpresaService empresaService { get; set; }
        [Inject]
        public IPesquisaPadraoService pesquisaPadraoService { get; set; }
        Action verifBw = null;
        EmpresaModel objEmpresaModel = new EmpresaModel();
        ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnImage = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
        ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnImage2 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
        public FormEmpresa()
        {
            InitializeComponent();                        
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);            
        }

        private void FormEmpresa_Load(object sender, EventArgs e)
        {
            btnImage.Image = HLP.UI.Entries.Properties.Resources.Pasta;
            btnImage.Click += new EventHandler(btn_Click);
            txtxLinkLogoEmpresa.txt.ButtonSpecs.Add(btnImage);
            btnImage2.Image = HLP.UI.Entries.Properties.Resources.Pasta;
            btnImage2.Click += new EventHandler(btn_Click_2);
            txtxLinkPastas.txt.ButtonSpecs.Add(btnImage2);
            idCidade.Tag = "FormCidade-vwCidade-xCidade_Uf_xRegiao_xPais";
            InicializaFormPadrao("vwEmpresa");
            verifBw += (() =>
            {
                InitializaComboBox();
            });

            Thread t1 = new Thread(new ThreadStart(verifBw));
            t1.Start();            
        }

        void btn_Click(object sender, EventArgs e)
        {
            if (btnNovo.Enabled == false)
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Title = "Imagem do produto";
                fileDialog.Filter = "Imagem (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";
                if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    txtxLinkLogoEmpresa.Text = fileDialog.FileName;
            }
        }

        void btn_Click_2(object sender, EventArgs e)
        {
            if (btnNovo.Enabled == false)
            {
                FolderBrowserDialog folderDialog = new FolderBrowserDialog();
                if (folderDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtxLinkPastas.Text = folderDialog.SelectedPath;
                }
            }

        }

        private void InitializaComboBox()
        {
            if (objMetodosForm != null)
            {
                idCidade.DataSource = pesquisaPadraoService.GetData(objMetodosForm.GetDisplayMember(idCidade), true);
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
                objEmpresaModel = new EmpresaModel();
                bsEmpresaEndereco.DataSource = objEmpresaModel.lEmpresa_endereco;
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

                empresaService.Save(objEmpresaModel);

                base.Salvar();
                txtCodigo.Text = objEmpresaModel.idEmpresa.ToString();
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
                    objEmpresaModel = empresaService.GetEmpresa((int)iRetPesquisa, true);
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
                    objEmpresaModel = empresaService.GetEmpresa((int)iRetPesquisa);
                    if (objEmpresaModel != null)
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
                //int i = multasService.Copy(Convert.ToInt32(txtCodigo.Text));
                //multasModel = multasService.GetMulta(i);
                int idOrigem = Convert.ToInt32(txtCodigo.Text);
                int i = empresaService.Copy(objEmpresaModel);
                objEmpresaModel = new EmpresaModel();
                objEmpresaModel = empresaService.GetEmpresa(i, true);
                PopulaForm();
                base.RegistroDuplicado(idOrigem, (int)objEmpresaModel.idEmpresa);
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
                    objEmpresaModel = empresaService.GetEmpresa((int)iRetPesquisa);
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
                    objEmpresaModel = empresaService.GetEmpresa((int)lParaExcluir[i], true);
                    empresaService.Delete(objEmpresaModel.idEmpresa.Value);
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
            empresaService.Delete(objEmpresaModel.idEmpresa.Value);
            base.Excluir();
            if (iRetPesquisa != null)
            {
                base.MoveProximoItem();
                objEmpresaModel = empresaService.GetEmpresa((int)iRetPesquisa, true);
                PopulaForm();
            }
        }

        void PopulaForm()
        {
            bsEmpresaEndereco.DataSource = objEmpresaModel.lEmpresa_endereco;
            txtCodigo.Text = objEmpresaModel.idEmpresa.ToString();
            txtxNome.Text = objEmpresaModel.xNome;
            txtxFantasia.Text = objEmpresaModel.xFantasia;
            masktxtxCnpj.Text = objEmpresaModel.xCNPJ;
            txtxIe.Text = objEmpresaModel.xIE;
            txtxIm.Text = objEmpresaModel.xIM;
            txtxSuframa.Text = objEmpresaModel.xSuframa;
            txtxTelefone.Text = objEmpresaModel.xTelefone;
            txtxFax.Text = objEmpresaModel.xFax;
            txtxEmail.Text = objEmpresaModel.xEmail;
            txtxHttp.Text = objEmpresaModel.xHttp;
            hlP_PesquisaidRamoAtividade.Value = objEmpresaModel.idRamoAtividade;
            cbostCodigoRegimeTributario.SelectedIndex = objEmpresaModel.stCodigoRegimeTributario;
            cboAtivo.SelectedIndex = Convert.ToInt32(objEmpresaModel.Ativo);
            txtxLinkLogoEmpresa.Text = objEmpresaModel.xLinkLogoEmpresa;
            txtxLinkPastas.Text = objEmpresaModel.xLinkPastas;       
        }

        void PopulaTabela()
        {
            objEmpresaModel.xNome = txtxNome.Text;
            objEmpresaModel.xFantasia = txtxFantasia.Text;
            objEmpresaModel.xCNPJ = masktxtxCnpj.Text;
            objEmpresaModel.xIE = txtxIe.Text;
            objEmpresaModel.xIM = txtxIm.Text;
            objEmpresaModel.idRamoAtividade = hlP_PesquisaidRamoAtividade.Value;
            objEmpresaModel.xSuframa = txtxSuframa.Text;
            objEmpresaModel.xTelefone = txtxTelefone.Text;
            objEmpresaModel.xFax = txtxFax.Text;
            objEmpresaModel.xEmail = txtxEmail.Text;
            objEmpresaModel.xHttp = txtxHttp.Text;
            objEmpresaModel.xLinkLogoEmpresa = txtxLinkLogoEmpresa.Text;
            objEmpresaModel.xLinkPastas = txtxLinkPastas.Text;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}
