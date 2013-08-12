using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using HLP.Comum.Messages;
using HLP.Comum.Services.Interface;
using HLP.Comum.UI;
using HLP.Comum.UI.Exception;
using HLP.Dependencies;
using HLP.Services.Interfaces.Entries.Gerais;
using HLP.Models.Entries.Gerais;
using Ninject;


namespace HLP.UI.Entries.Geral.Transportes
{
    public partial class FormRota : FormPadraoCadastro
    {
        [Inject]
        public IRotaService rotaService { get; set; }

        [Inject]
        public ICidadeService cidadeService { get; set; }

        [Inject]
        public IPesquisaPadraoService pesquisaPadraoService { get; set; }

        RotaModel objRotaModel = new RotaModel();
        Action verifBw = null;

        public FormRota()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
        }

        private void FormRota_Load(object sender, EventArgs e)
        {
            clidCidade.Tag = "FormCidade-vwCidade-xCidade_Uf_xRegiao_xPais";

            InicializaFormPadrao("vwRota");
            dgvRotaPraca.DataSource = bsRotaPraca;
            verifBw += (() =>
                {
                    CarregaComboBox();
                });

            Thread t1 = new Thread(new ThreadStart(verifBw));
            t1.Start();
        }


        private void CarregaComboBox()
        {
            if (objMetodosForm != null)
            {
                clidCidade.DataSource = pesquisaPadraoService.GetData(objMetodosForm.GetDisplayMember(clidCidade), true);
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
            base.Novo();
            cboAtivo.SelectedIndex = 1;
            objRotaModel = new RotaModel();
            bsRotaPraca.DataSource = objRotaModel.lRota_Praca;
            dgvRotaPraca.Columns[clnOrdem.Name].ReadOnly = true;
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
                    objRotaModel = rotaService.GetRota((int)lParaExcluir[i], true);

                    rotaService.Delete(objRotaModel);
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
            rotaService.Delete(objRotaModel);
            base.Excluir();
            bsRotaPraca.DataSource = new List<Rota_pracaModel>();

            if (iRetPesquisa != null)
            {
                base.MoveProximoItem();
                objRotaModel = rotaService.GetRota((int)iRetPesquisa, true);
                PopulaForm();
            }
        }

        public override void Atualizar()
        {
            base.Atualizar();
            dgvRotaPraca.Columns[clnOrdem.Name].ReadOnly = true;
        }
        public override void Salvar()
        {
            try
            {
                objValidaCampos.Validar();
                PopulaTabela();

                rotaService.Save(objRotaModel);

                txtCodigo.Text = objRotaModel.idRota.ToString();
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
                        objRotaModel = rotaService.GetRota(Convert.ToInt32(txtCodigo.Text), true);
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
                    objRotaModel = rotaService.GetRota((int)iRetPesquisa, true);
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
                    objRotaModel = rotaService.GetRota((int)iRetPesquisa, true);
                    if (objRotaModel != null)
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
                    objRotaModel = rotaService.GetRota((int)iRetPesquisa, true);
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
                rotaService.Copy(objRotaModel);
                PopulaForm();
                base.RegistroDuplicado(idOrigem, (int)objRotaModel.idRota);
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
                base.CarregaClasse(objRotaModel);
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
                base.CarregaPropriedades(objRotaModel, true);
                base.CarregaForm();
                objRotaModel.lRota_Praca = objRotaModel.lRota_Praca.AsEnumerable().OrderBy(c => c.nOrdem).ToList();
                bsRotaPraca.DataSource = objRotaModel.lRota_Praca;

            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }

        }

        private void dgvRotaPraca_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //if(btnSalvar.Enabled)
            //    ordenaNumRota();
        }

        private void dgvRotaPraca_DragDrop(object sender, DragEventArgs e)
        {
            if (btnSalvar.Enabled)
                ordenaNumRota();
        }

        private void ordenaNumRota()
        {
            int cont = 0;

            dgvRotaPraca.Columns[clnOrdem.Name].ReadOnly = false;
            while (cont < dgvRotaPraca.Rows.Count)
            {
                if (dgvRotaPraca[clidCidade.Name, cont].Value != null)
                {
                    dgvRotaPraca.CurrentCell = dgvRotaPraca.Rows[cont].Cells[clnOrdem.Name];
                    dgvRotaPraca.BeginEdit(true);
                    dgvRotaPraca[clnOrdem.Name, cont].Value = (cont + 1).ToString();
                    dgvRotaPraca.BeginEdit(false);
                }
                cont++;
            }
            dgvRotaPraca.Columns[clnOrdem.Name].ReadOnly = true;
        }

        private void dgvRotaPraca_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["clnOrdem"].Value = bsRotaPraca.Count;
        }



    }
}
