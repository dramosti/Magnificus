using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HLP.Comum.Infrastructure;
using CrystalDecisions.CrystalReports.Engine;
using HLP.Comum.Models.Static;
using HLP.Comum.UI.Exception;
using System.Configuration;

namespace HLP.Comum.UI
{
    public partial class FormPreviewReport : Form
    {

        public FormPreviewReport(string sFiltro = "", string sFormula = "", RelatoriosModel objRelatorio = null)
        {
            InitializeComponent();
            try
            {
                ReportDocument rpt = new ReportDocument();
                string sCaminho = (objRelatorio.xNomeFisico.Contains("HLP_") ? Pastas.Path_Report : Pastas.Path_Report_Especifico) + "\\" + objRelatorio.xNomeFisico;

                rpt.Load(sCaminho);
                if (rpt.DataDefinition.FormulaFields["Filtro"] != null)
                {
                    rpt.DataDefinition.FormulaFields["Filtro"].Text = sFiltro;
                }

                if (rpt.DataDefinition.FormulaFields["Nome"] != null)
                {
                    rpt.DataDefinition.FormulaFields["Nome"].Text = "\"" + objRelatorio.xNomeRelatorio + "\"";
                }
                rpt.Refresh();
                try { rpt.SetParameterValue("PathImage", CompanyData.xLinqLogoEmpresa); }
                catch (System.Exception) { };
                rpt.SetDatabaseLogon(ServerData.USER_ID, ServerData.PASSWORD);
                crViewer.SelectionFormula = sFormula;
                crViewer.ReportSource = rpt;
                crViewer.Zoom(100);
            }
            catch (System.Exception ex)
            {
                new HLPexception(ex);
            }



        }
    }
}
