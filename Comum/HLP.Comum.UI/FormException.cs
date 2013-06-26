using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Ninject;
using HLP.Comum.Services.Interface;
using HLP.Dependencies;
using HLP.Comum.Models.Static;
using HLP.Comum.Infrastructure;

namespace HLP.Comum.UI
{
    public partial class FormException : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        [Inject]
        public ILogExceptionService logService { get; set; }
        private LogException objLog = new LogException();
        private LogDados objLogDados;


        private int _heightUpDown;
        public FormException(string xMessage, string xInner, string xDetalhes)
        {
            InitializeComponent();

            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);

            xMessage = xMessage.Replace("The transaction ended in the trigger. The batch has been aborted.", "");
            xMessage = xMessage.Replace("The ROLLBACK TRANSACTION request has no corresponding BEGIN TRANSACTION.", "");
            xMessage = xMessage.Replace("The statement has been terminated.", "");
            txtDescricao.Text = string.Format("{0}{1}{2}", xMessage, Environment.NewLine, xInner);
            txtDetalhes.Text = xDetalhes;
            btnOk.Focus();

            #region Gravar Logs

            try
            {
                // ARRUMAR A MANEIRA DE IDENTIFICAR O NOME DO FORMULÁRIO, ESTA ESTA COM ERRO EM ALGUNS TIPOS DE ERROS INTERNOS...
                if (Messages.Mensagens.CampoVazio_Incorreto != xMessage)
                {

                    //int iPosicaoForm = xDetalhes.IndexOf(".Form");
                    //string xDetalheAlter = xDetalhes.Substring((iPosicaoForm + 1), (xDetalhes.Length - iPosicaoForm - 1));
                    //iPosicaoForm = xDetalheAlter.IndexOf('.');
                    //int posEspac = xDetalheAlter.IndexOf(") ");
                    //string acao = xDetalheAlter.Substring((iPosicaoForm + 1), (posEspac - iPosicaoForm));
                    //xDetalheAlter = xDetalheAlter.Substring(0, iPosicaoForm);

                    //if (!xDetalheAlter.Contains("Form"))
                    //{
                    //    xDetalheAlter = "Não identificado";
                    //}

                    objLog = logService.GetLogXML();
                    objLog.lLogException.Add(objLogDados = new LogDados()
                    {
                        xEmpresa = CompanyData.xFantasia,
                        xFormulario = "",
                        xAcao = "",
                        xMessage = xMessage,
                        xDetalhes = xDetalhes,
                        xInner = xInner,
                        dtOcorrencia = DateTime.Now
                    });
                    logService.SalvarLog(objLog);

                }
                else
                {
                    btnReportErro.Enabled = false;
                }
            }
            catch (System.Exception)
            {
                KryptonMessageBox.Show(null, "Falha ao gravar arquivo de Log !", "E R R O", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            #endregion

        }
        private void buttonSpecUpDown_Click(object sender, EventArgs e)
        {
            // Suspend layout changes until all splitter properties have been updated
            kryptonSplitContainerVertical.SuspendLayout();


            // Is the bottom right header group currently expanded?
            if (kryptonSplitContainerVertical.FixedPanel == FixedPanel.None)
            {
                // Make the bottom panel of the splitter fixed in size
                kryptonSplitContainerVertical.FixedPanel = FixedPanel.Panel2;
                kryptonSplitContainerVertical.IsSplitterFixed = true;

                // Remember the current height of the header group (to restore later)
                _heightUpDown = kryptonHeaderGroupRightBottom.Height;

                // Find the new height to use for the header group
                int newHeight = kryptonHeaderGroupRightBottom.PreferredSize.Height;

                // Make the header group fixed to the new height
                kryptonSplitContainerVertical.Panel2MinSize = newHeight;
                kryptonSplitContainerVertical.SplitterDistance = kryptonSplitContainerVertical.Height;
            }
            else
            {
                // Make the bottom panel not-fixed in size anymore
                kryptonSplitContainerVertical.FixedPanel = FixedPanel.None;
                kryptonSplitContainerVertical.IsSplitterFixed = false;

                // Put back the minimise size to the original
                kryptonSplitContainerVertical.Panel2MinSize = 100;

                // Calculate the correct splitter we want to put back
                kryptonSplitContainerVertical.SplitterDistance = kryptonSplitContainerVertical.Height - _heightUpDown - kryptonSplitContainerVertical.SplitterWidth;
            }

            kryptonSplitContainerVertical.ResumeLayout();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormException_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void FormException_Load(object sender, EventArgs e)
        {
            btnOk.Focus();
        }

        private void kryptonPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonHeaderGroupRightBottom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {

        }

        #region Reportar Erro

        private void btnReportErro_Click(object sender, EventArgs e)
        {
            btnReportErro.Enabled = false;

            using (WCFServices.Services hlpServices = new WCFServices.Services())
            {


                WCFServices.Log log = new WCFServices.Log();

                log.xEmpresa = objLogDados.xEmpresa;
                log.xFormulario = objLogDados.xFormulario;
                log.xAcao = objLogDados.xAcao;
                log.xMessage = objLogDados.xMessage;
                log.xDetalhes = objLogDados.xDetalhes;
                log.xInner = objLogDados.xInner;

                hlpServices.SetLogErrorAsync(log);

                hlpServices.SetLogErrorCompleted += new WCFServices.SetLogErrorCompletedEventHandler(hlpServices_SetLogErrorCompleted);

            }
        }

        void hlpServices_SetLogErrorCompleted(object sender, WCFServices.SetLogErrorCompletedEventArgs e)
        {
            try
            {
                if (e.SetLogErrorResult)
                {
                    KryptonMessageBox.Show(null, "O Erro foi reportado com sucesso para o suporte da HLP !", "A V I S O", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    KryptonMessageBox.Show(null, "Falha ao reportar erro. Tente novamente mais tarde.", "E R R O", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (System.Exception)
            {
            }   
        }

        #endregion



    }
}