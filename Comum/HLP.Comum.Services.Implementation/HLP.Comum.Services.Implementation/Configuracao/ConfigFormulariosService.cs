using System;
using System.Linq;
using System.Collections.Generic;
using Ninject;
using HLP.Comum.Repository.Interfaces.Configuracao;
using HLP.Comum.Infrastructure;
using HLP.Comum.Models.Static;
using System.IO;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using HLP.Comum.Services.Interface.Configuracao;
using HLP.Comum.Components;
using ComponentFactory.Krypton.Toolkit;
using HLP.Comum.Models.Static;
using HLP.Services.Interfaces.Entries.Gerais;




namespace HLP.Comum.Services.Implementation.Configuracao
{
    public class ConfigFormulariosService : IConfigFormulariosService
    {
        [Inject]
        public IConfigFormulariosRepository iConfigFormulariosRepository { get; set; }
        [Inject]
        public IRelatoriosRepository irelatorioRepository { get; set; }
        [Inject]
        public IConfigTabPageService itabPageService { get; set; }
        [Inject]
        public IConfigPesquisaRepository iConfigPesquisaRepository { get; set; }



        public bool bEndSincronizacao { get; set; }
        public List<Control> lControl { get; set; }
        public List<Control> lFlowLayoutPanel { get; set; }

        /// <summary>
        /// Objeto principal onde contera todas as configurações do Formulario
        /// </summary>
        public ConfigFormulariosModel objConfigFormularioModel { get; set; }

        #region Regras de Negócio

        #region Métodos Públicos
        public void InitializeFormulario(ComponentFactory.Krypton.Toolkit.KryptonPanel pnPrincipal, string sViewForm)
        {
            try
            {

                lControl = new List<Control>();
                objConfigFormularioModel = new ConfigFormulariosModel();
                //this.GetTabControlRecursivo(pnPrincipal.Controls);
                this.GetControlsContainerRecursivo(pnPrincipal.Controls, lControl);

                lFlowLayoutPanel = lControl.Where(c => c.GetType() == typeof(FlowLayoutPanel)).ToList();

                lControl.RemoveAll(c => c.GetType() == typeof(FlowLayoutPanel));

                CarregaDadosFormulario(pnPrincipal, sViewForm);
                // Se estiver sendo debugado, ira salvar a configuração da Tela na Base de Dados com o usuario HLP
                if (System.Diagnostics.Debugger.IsAttached)
                {                   
                        
                    if (iConfigFormulariosRepository.FormularioExistInDataBase(objConfigFormularioModel.xNameFormulario))
                    {
                        iConfigFormulariosRepository.DeleteFormularioUsuario(objConfigFormularioModel.xNameFormulario, UserData.idUserHLP);
                    }
                    objConfigFormularioModel.SetIdUsuario(UserData.idUserHLP);
                    this.Save(objConfigFormularioModel);
                }

                objConfigFormularioModel = null;
                objConfigFormularioModel = this.GetFormulario(pnPrincipal.FindForm().Name, UserData.idUser);

                if (objConfigFormularioModel == null)
                {
                    if (UserData.idUser == UserData.idUserDEFAULT)
                    {
                        RotinaUSER_HLP(pnPrincipal, sViewForm);
                    }
                    else
                    {
                        objConfigFormularioModel = this.GetFormulario(pnPrincipal.FindForm().Name, UserData.idUserDEFAULT);
                        if (objConfigFormularioModel == null)
                        {
                            RotinaUSER_HLP(pnPrincipal, sViewForm);
                        }
                    }
                    //Duplica para id_logado
                    objConfigFormularioModel.SetIdNullAllClasses();
                    objConfigFormularioModel.SetIdUsuario(UserData.idUser);
                    this.Save(objConfigFormularioModel);
                }

                //Configura Formulario
                pnPrincipal.FindForm().Text = objConfigFormularioModel.objConfigFormUsu.xText;
                pnPrincipal.FindForm().Enabled = Convert.ToBoolean(objConfigFormularioModel.objConfigFormUsu.stAtivo);

                itabPageService.SetConfigToTabPagesRecursivo(objConfigFormularioModel.lConfigTabPage, lControl);
                objConfigFormularioModel.lobjConfigComponente = itabPageService.GetListaControlesConfigComponenteModel();


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void RotinaUSER_HLP(ComponentFactory.Krypton.Toolkit.KryptonPanel pnPrincipal, string sViewForm)
        {
            try
            {
                objConfigFormularioModel = this.GetFormulario(pnPrincipal.FindForm().Name, UserData.idUserHLP);

                if (objConfigFormularioModel == null)
                {
                    objConfigFormularioModel = new ConfigFormulariosModel();
                    CarregaDadosFormulario(pnPrincipal, sViewForm);
                    objConfigFormularioModel.SetIdUsuario(UserData.idUserHLP);
                    this.Save(objConfigFormularioModel);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Carrega Dados do Formulario no objeto 'objConfigFormularioModel'
        /// </summary>
        /// <param name="pnPrincipal"></param>
        /// <param name="sViewForm"></param>
        private void CarregaDadosFormulario(ComponentFactory.Krypton.Toolkit.KryptonPanel pnPrincipal, string sViewForm)
        {
            #region
            List<ConfigTabPageModel> lConfgTabPage = this.objConfigFormularioModel.lConfigTabPage;
            //lConfgTabPage.xNameTab = "HLP";
            itabPageService.GetInfoTabPagesRecursiovo(pnPrincipal.Controls, lConfgTabPage, lControl);
            //this.objConfigFormularioModel.lConfigTabPage = lConfgTabPage;


            objConfigFormularioModel.xNameFormulario = pnPrincipal.FindForm().Name;
            objConfigFormularioModel.xNameView = sViewForm;

            objConfigFormularioModel.xTable = "do not use."; // this.objConfigFormularioModel.objConfigTabPage.lConfigComponente.FirstOrDefault().GetPropertyValue("_Table").ToString();  // pnPrincipal.FindForm().Tag != null ? pnPrincipal.FindForm().Tag.ToString() : pnPrincipal.FindForm().Text;
            objConfigFormularioModel.lPesquisa = iConfigPesquisaRepository.GetCONFIG_PesquisaByView(sViewForm);

            //objConfigFormularioModel.objConfigFormUsu.idUsuario = UserData.idUserHLP; inativo
            objConfigFormularioModel.objConfigFormUsu.xText = pnPrincipal.FindForm().Text;
            objConfigFormularioModel.objConfigFormUsu.stAtivo = 1;
            #endregion
        }

        public void MudaPosicaoScrollFlowPanelTabControl()
        {
            foreach (Control ctr in lFlowLayoutPanel)
            {
                (ctr as FlowLayoutPanel).VerticalScroll.Value = 0;
                (ctr as FlowLayoutPanel).HorizontalScroll.Value = 0;
            }
            //foreach (FlowLayoutPanel f in layoutService.lFlowLayoutPanel)
            //{
            //    f.VerticalScroll.Value = 0;
            //    f.HorizontalScroll.Value = 0;
            //}
            //foreach (AC.ExtendedRenderer.Navigator.KryptonTabControl t in layoutService.lTabControl)
            //{
            //    t.SelectedIndex = 0; //esta dando erro...          
            //}
        }

        public List<TabPage> GetTabPages()
        {
            if (itabPageService.lTabPageControl != null)
                return itabPageService.lTabPageControl;
            else
                return new List<TabPage>();
        }


        #endregion

        #region Métodos Privados
        /// <summary>
        /// Método recursivo que Lista todos os UserControls do Formulario.
        /// </summary>
        /// <param name="lControles"></param>
        /// <param name="lctr"></param>
        /// <returns></returns>
        private List<Control> GetControlsContainerRecursivo(Control.ControlCollection lControles, List<Control> lctr)
        {
            foreach (Control ctr in lControles)
            {
                if (ctr.GetType().BaseType == typeof(UserControlBase))
                {
                    if (!lctr.Contains(ctr))
                    {
                        lctr.Add(ctr);
                    }
                }
                else if (!lctr.Contains(ctr))
                {
                    #region Outros Controles
                    if (ctr.GetType() == typeof(HLP_DataGridView))
                    {
                        lctr.Add(ctr);
                    }
                    if (ctr.GetType() == typeof(KryptonButton))
                    {
                        lctr.Add(ctr);
                    }
                    else if (ctr.GetType() == typeof(KryptonTextBox))
                    {
                        lctr.Add(ctr);
                    }
                    else if (ctr.GetType() == typeof(KryptonMaskedTextBox))
                    {
                        lctr.Add(ctr);
                    }
                    else if (ctr.GetType() == typeof(KryptonComboBox))
                    {
                        lctr.Add(ctr);
                    }
                    else if (ctr.GetType() == typeof(KryptonDateTimePicker))
                    {
                        lctr.Add(ctr);
                    }
                    else if (ctr.GetType() == typeof(KryptonCheckedListBox))
                    {
                        lctr.Add(ctr);
                    }
                    else if (ctr.GetType() == typeof(KryptonCheckBox))
                    {
                        lctr.Add(ctr);
                    }
                    else if (ctr.GetType() == typeof(KryptonRichTextBox))
                    {
                        lctr.Add(ctr);
                    }
                    else if (ctr.GetType() == typeof(KryptonNumericUpDown))
                    {
                        lctr.Add(ctr);
                    }
                    else if (ctr.HasChildren == true && ctr.GetType().BaseType != typeof(UserControl))
                    {
                        if (ctr.GetType() == typeof(FlowLayoutPanel))
                        {
                            lctr.Add(ctr);
                        }
                        GetControlsContainerRecursivo(ctr.Controls, lctr);
                    }
                    #endregion
                }
            }
            return lctr;
        }

        /// <summary>
        /// Método que carrega todos os TabControls do Formulario
        /// </summary>
        /// <param name="lControles"></param>
        //private void GetTabControlRecursivo(Control.ControlCollection lControles)
        //{
        //    foreach (Control ctr in lControles)
        //    {
        //        if (ctr.GetType() == typeof(AC.ExtendedRenderer.Navigator.KryptonTabControl))
        //        {
        //            if (!lTabControl.Contains(ctr))
        //            {
        //                lTabControl.Add((AC.ExtendedRenderer.Navigator.KryptonTabControl)ctr);
        //            }
        //        }
        //        else if (ctr.HasChildren)
        //        {
        //            GetTabControlRecursivo(ctr.Controls);
        //        }
        //    }
        //}
        #endregion

        #endregion

        #region ADO
        public void Save(ConfigFormulariosModel formulario)
        {
            try
            {
                iConfigFormulariosRepository.BeginTransaction();
                iConfigFormulariosRepository.Save(formulario);
                iConfigFormulariosRepository.CommitTransaction();
            }
            catch (Exception ex)
            {
                iConfigFormulariosRepository.RollBackTransaction();
                throw ex;
            }
        }
        public void Delete(string sNameFormulario, int idUsuario)
        {
            int idFormulario = iConfigFormulariosRepository.DeleteFormularioUsuario(sNameFormulario, idUsuario);


        }

        public ConfigFormulariosModel GetFormulario(int idFormulario, bool bChildren = false, int idUser = 0)
        {
            ConfigFormulariosModel objformulario = iConfigFormulariosRepository.GetFormulario(idFormulario, idUser);

            if (bChildren)
            {
                objformulario.lRelatorios = irelatorioRepository.GetRelatorioByFormulario((int)objformulario.idFormularios);
                // objformulario.lConfigTabPage = tabPageService.GetAllTabPageByForm((int)objformulario.idFormularios, bChildren); inativo
            }
            return objformulario;
        }
        public ConfigFormulariosModel GetFormulario(string xNameFormulario, int idUsuario)
        {
            ConfigFormulariosModel objFormularioRet = null;
            if (iConfigFormulariosRepository.FormularioExistInDataBase(xNameFormulario, idUsuario))
            {
                objFormularioRet = iConfigFormulariosRepository.GetFormulario(xNameFormulario, idUsuario);

                objFormularioRet.lConfigTabPage = itabPageService.GetTabPageByForm(objFormularioRet.idFormularios.ToInt32(), idUsuario);
            }

            return objFormularioRet;
        }


        public void BeginTransaction()
        {
            iConfigFormulariosRepository.BeginTransaction();
        }
        public void CommitTransaction()
        {
            iConfigFormulariosRepository.CommitTransaction();
        }
        public void RollBackTransaction()
        {
            iConfigFormulariosRepository.RollBackTransaction();
        }
        #endregion

        #region Report
        public void SicnronizaRelatorios()
        {
            try
            {
                bEndSincronizacao = false;
                string sPath = Application.StartupPath + "\\Relatorios\\";
                AplicaSincrBanco(sPath, Pastas.Path_Report_Especifico);
                AplicaSincrDiretorio(sPath);
                AplicaSincrDiretorio(Pastas.Path_Report_Especifico);
                bEndSincronizacao = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void AplicaSincrDiretorio(string sPath)
        {
            //Sincronização Diretório > Banco
            if (Directory.Exists(sPath))
            {

                DirectoryInfo dinfo = new DirectoryInfo(sPath);
                FileInfo[] reports = dinfo.GetFiles("*.rpt");

                foreach (FileInfo rel in reports)
                {
                    if (!irelatorioRepository.ReportExistInDataBase(rel.Name))
                    {
                        ReportDocument rpt = new ReportDocument();
                        rpt.Load(rel.FullName);
                        // salvo informações do relatorio no formulario;
                        if (iConfigFormulariosRepository.FormularioExistInDataBase(rpt.SummaryInfo.ReportTitle))
                        {
                            ConfigFormulariosModel formulario = new ConfigFormulariosModel();// formulariosRepository.GetFormulario(rpt.SummaryInfo.ReportTitle);
                            formulario.lRelatorios = irelatorioRepository.GetRelatorioByFormulario((int)formulario.idFormularios);
                            string sNameReport = rel.Name.Replace("USER_", "").Replace("HLP_", "").Replace("_", " ").Replace(".rpt", "");
                            formulario.lRelatorios.Add(new RelatoriosModel { stAtivo = true, xNomeFisico = rel.Name, xNomeRelatorio = sNameReport });
                            iConfigFormulariosRepository.Save(formulario);
                        }
                    }
                }
            }
        }
        private void AplicaSincrBanco(string sPathHlp, string sPathUser)
        {
            // Sincronização Banco > Diretório
            foreach (RelatoriosModel item in irelatorioRepository.GetAllRelatorio())
            {
                string sNomeFisico = item.xNomeFisico;
                if (sNomeFisico.Contains("HLP_") && !File.Exists(sPathHlp + sNomeFisico))
                {
                    iConfigFormulariosRepository.DeleteFormularioUsuario((int)item.idRelatorio, UserData.idUser);//verificar usuario
                }
                else if (sNomeFisico.Contains("USER_") && !File.Exists(sPathUser + sNomeFisico))
                {
                    iConfigFormulariosRepository.DeleteFormularioUsuario((int)item.idRelatorio, UserData.idUser); //verificar usuario
                }
            }
        }
        #endregion

    }
}
