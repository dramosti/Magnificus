using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using HLP.Comum.Modules;
using HLP.Comum.UI.Exception;
using HLP.Comum.Infrastructure;
using Ninject;
using HLP.Comum.Services.Interface.Configuracao;
using HLP.Comum.Services.Interface;
using HLP.Dependencies;
using CrystalDecisions.CrystalReports.Engine;

using System.Configuration;
using HLP.Comum.Models;
using HLP.Comum.Infrastructure.Static;

namespace HLP.Comum.UI
{
    public partial class FormSelecionaRelatorio : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        [Inject]
        public IConfigFormulariosService formularioService { get; set; }
        [Inject]
        public IPesquisaPadraoService pesquisaPadraoService { get; set; }

        public FormSelecionaRelatorio()
        {
            InitializeComponent();
            Util.TextBoxEx.SetWatermark(this.txtPesquisaForm.TextBox, "Pesquisar");

        }
        public FormSelecionaRelatorio(string sNameFiltro)
        {
            InitializeComponent();
            Util.TextBoxEx.SetWatermark(this.txtPesquisaForm.TextBox, "Pesquisar");
            if (sNameFiltro != "")
            {
                txtPesquisaForm.Text = sNameFiltro;
            }
        }

        void FormSelecionaRelatorio_Load(object sender, EventArgs e)
        {
            try
            {
                IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
                kernel.Settings.ActivationCacheDisabled = false;
                kernel.Inject(this);
                Util.TextBoxEx.SetWatermark(this.txtPesquisaForm.TextBox, "Pesquisar");
                this.Dock = DockStyle.Fill;
                List<Modulo> lModulo = GerenciadorModulo.Instancia.CarregaModulosAcesso();
                TreeNode nodeModulo;
                foreach (Modulo m in lModulo)
                {
                    //m.bCarregaComponentes = false;
                    if (m.NomeModulo != "Utilitarios" && m.NomeModulo != "Magnificus")
                    {
                        nodeModulo = new TreeNode();
                        nodeModulo.Text = m.NomeModulo;
                        m.InicializarModuloAcesso(nodeModulo);
                        treeTelas.Nodes.Add(nodeModulo);
                        nodeModulo.Expand();
                    }
                }
                CarregaRelportsToTreeView(treeTelas.Nodes[0]);
                treeTelas.SelectedNode = treeTelas.Nodes[0];
                txtPesquisaForm_TextChanged(sender, e);
            }
            catch (System.Exception ex)
            {
                new HLPexception(ex);
            }
        }

        void treeTelas_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            try
            {
                lblNome.Visible = false;
                lblAtivo.Visible = false;
                lblNomeFisico.Visible = false;
                lblFuncionalidade.Visible = false;
                btnVisualizarRelatorio.Enabled = false;
                btnPesquisaPadrao.Enabled = false;
                crViewer.ReportSource = null;

                if (e.Node.Tag != null)
                {
                    if (e.Node.Tag.GetType() == typeof(RelatoriosModel))
                    {
                        RelatoriosModel rel = e.Node.Tag as RelatoriosModel;

                        lblNome.Visible = true;
                        lblAtivo.Visible = true;
                        lblNomeFisico.Visible = true;
                        lblFuncionalidade.Visible = true;


                        lblNomeFisico.Text = "Nome Físico: " + rel.xNomeFisico;
                        lblAtivo.Text = rel.stAtivo ? "Relatório Ativo" : "Relatório Desativado";
                        lblNome.Text = rel.xNomeRelatorio;
                        lblFuncionalidade.Text = "Destalhes: " + rel.xDetalhes;
                        btnVisualizarRelatorio.Enabled = true;
                        btnPesquisaPadrao.Enabled = true;
                    }
                }
            }
            catch (System.Exception ex)
            {
                new HLPexception(ex);
            }
        }

        void btnVisualizarRelatorio_Click(object sender, EventArgs e)
        {
            try
            {
                KryptonTreeView objTreeView = treePesquisa.Visible ? treePesquisa : treeTelas;
                ReportDocument rpt = new ReportDocument();
                RelatoriosModel objrel = (objTreeView.SelectedNode.Tag as RelatoriosModel);
                ConfigFormulariosModel objformulario = formularioService.GetFormulario((int)objrel.idFormularios, false);
                string strTabelaPrincipal = objformulario.xTable;
                string strColuna = pesquisaPadraoService.GetIdentityColumnName(strTabelaPrincipal);
                int sFirstValue = pesquisaPadraoService.GetFirstIDbyTable(strTabelaPrincipal, strColuna);
                string sFormula = "{" + strTabelaPrincipal + "." + strColuna + "} in[" + sFirstValue.ToString() + "]";
                string sCaminho = (objrel.xNomeFisico.Contains("HLP_") ? Pastas.Path_Report : Pastas.Path_Report_Especifico) + "\\" + objrel.xNomeFisico;
                rpt.Load(sCaminho);
                if (rpt.DataDefinition.FormulaFields["Nome"] != null)
                {
                    rpt.DataDefinition.FormulaFields["Nome"].Text = "\"" + sFormula + "\"";
                }
                string sNomeRelatorio = "\"" + objrel.xNomeRelatorio + "\"";

                if (rpt.DataDefinition.FormulaFields["Nome"] != null)
                {
                    rpt.DataDefinition.FormulaFields["Nome"].Text = sNomeRelatorio;
                }
                rpt.Refresh();
                try { rpt.SetParameterValue("PathImage", CompanyData.xLinqLogoEmpresa); }
                catch (System.Exception) { };
                rpt.SetDatabaseLogon(ServerData.USER_ID, ServerData.PASSWORD);
                crViewer.SelectionFormula = sFormula;
                crViewer.ReportSource = rpt;
                crViewer.Zoom(95);

            }
            catch (System.Exception ex)
            {
                new HLPexception(ex);
            }
        }

        void btnPesquisaPadrao_Click(object sender, EventArgs e)
        {
            try
            {
                if (treeTelas.SelectedNode.Tag != null)
                {
                    int idFormulario = Convert.ToInt32((treeTelas.SelectedNode.Tag as RelatoriosModel).idFormularios);
                    ConfigFormulariosModel objformulario = formularioService.GetFormulario(idFormulario, false);
                    FormPesquisaPadrao objfrm = new FormPesquisaPadrao(objformulario);
                    objfrm.objRelatorio = (treeTelas.SelectedNode.Tag as RelatoriosModel);
                    objfrm.ShowDialog();
                }
            }
            catch (System.Exception ex)
            {
                new HLPexception(ex);
            }
        }

        void txtPesquisaForm_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPesquisaForm.Text != "")
                {
                    treePesquisa.Nodes.Clear();
                    foreach (TreeNode node in treeTelas.Nodes)
                    {
                        BuscaNodePesquisa(node);
                    }
                }
                else
                {
                    treeTelas.BringToFront();
                    treePesquisa.Nodes.Clear();
                    treePesquisa.Visible = false;
                }
            }
            catch (System.Exception ex)
            {
                new HLPexception(ex);
            }

        }

        void BuscaNodePesquisa(TreeNode node)
        {
            try
            {
                if (node.Text.ToUpper().Contains(txtPesquisaForm.Text.ToUpper()))
                {
                    ClonaNode(node);
                }
                else
                {
                    if (node.Nodes.Count > 0)
                    {
                        foreach (TreeNode nodeFilho in node.Nodes)
                        {
                            BuscaNodePesquisa(nodeFilho);
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                new HLPexception(ex);
            }
        }

        void ClonaNode(TreeNode node)
        {
            TreeNode NodeCopy = (TreeNode)node.Clone();
            treePesquisa.Nodes.Add(NodeCopy);
            treePesquisa.Visible = true;
            treePesquisa.BringToFront();
        }

        void CarregaRelportsToTreeView(TreeNode node)
        {
            if (node.Name.ToUpper().Contains("FORM"))
            {
                ConfigFormulariosModel objFormulario = formularioService.GetFormulario(node.Name, UserData.idUser);
                if (objFormulario != null)
                {
                    TreeNode nodeRpt = null;
                    foreach (RelatoriosModel report in objFormulario.lRelatorios)
                    {
                        nodeRpt = new TreeNode();
                        nodeRpt.ImageIndex = 2;
                        nodeRpt.SelectedImageIndex = 2;
                        nodeRpt.Text = report.xNomeRelatorio;
                        nodeRpt.Tag = report;
                        node.Nodes.Add(nodeRpt);
                    }
                }
            }
            else if (node.Nodes.Count > 0)
            {
                foreach (TreeNode nodeFilho in node.Nodes)
                {
                    CarregaRelportsToTreeView(nodeFilho);
                }
            }

        }


    }
}