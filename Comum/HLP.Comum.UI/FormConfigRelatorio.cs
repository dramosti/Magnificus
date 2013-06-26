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
using Ninject;
using HLP.Comum.Services.Interface;
using HLP.Comum.Infrastructure;
using HLP.Dependencies;
using HLP.Comum.Models.Static;
using System.Threading;
using System.Linq;
using System.IO;
using Microsoft.Win32;
using HLP.Comum.Models;
using HLP.Comum.Services.Interface.Configuracao;

namespace HLP.Comum.UI
{
    public partial class FormConfigRelatorio : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        [Inject]
        public IConfigFormulariosService formularioService { get; set; }

        [Inject]
        public IRelatoriosService relatorioService { get; set; }

        ConfigFormulariosModel formulario = new ConfigFormulariosModel();

        Thread workSincronizacao;

        private string nomeFormulario;


        public FormConfigRelatorio()
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);


        }

        private void FormConfigRelatorio_Load(object sender, EventArgs e)
        {
            try
            {
                this.Dock = DockStyle.Fill;

                Util.TextBoxEx.SetWatermark(this.txtPesquisaForm.TextBox, "Pesquisar");

                List<Modulo> lModulo = GerenciadorModulo.Instancia.CarregaModulosAcesso();
                TreeNode nodeModulo;
                foreach (Modulo m in lModulo)
                {
                    //m.bCarregaComponentes = false;
                    if (m.NomeModulo == "Cadastros")
                    {
                        nodeModulo = new TreeNode();
                        nodeModulo.Text = m.NomeModulo;

                        m.InicializarModuloAcesso(nodeModulo);
                        treeTelas.Nodes.Add(nodeModulo);
                        treeTelas.BringToFront();
                        nodeModulo.Expand();
                    }
                }
                treeTelas.SelectedNode = treeTelas.Nodes[0];

            }
            catch (System.Exception ex)
            {
                new HLPexception(ex);
            }
        }

        private void treeTelas_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {

            try
            {
                if ((sender as KryptonTreeView).SelectedNode != null && (sender as KryptonTreeView).SelectedNode.Name.ToUpper().Contains("FORM"))
                {
                    if (bsReports != null && bsReports.List.Count > 0)
                    {
                       // formularioService.Save(formulario);
                    }
                }


                if (!String.IsNullOrEmpty(e.Node.Name) && e.Node.Name.ToUpper().Contains("FORM"))
                {
                    lblFormSelecionado.Text = e.Node.Text;

                    formulario = formularioService.GetFormulario(e.Node.Name, UserData.idUser);
                    nomeFormulario = e.Node.Name;

                    if (formulario != null && formulario.lRelatorios != null)
                    {
                        bsReports.DataSource = formulario.lRelatorios;

                        ColorGrid();
                    }
                    else
                    {
                        bsReports.DataSource = new ConfigFormulariosModel().lRelatorios;
                    }
                }
                else
                {
                    lblFormSelecionado.Text = "-";
                    bsReports.DataSource = new ConfigFormulariosModel().lRelatorios;
                }
            }
            catch (System.Exception ex)
            {
                new HLPexception(ex);
            }
        }

        private void ColorGrid()
        {
            for (int i = 0; i < dgvReports.RowCount; i++)
            {
                if (dgvReports["clxNomeFisico", i].Value.ToString().Contains("USER_"))
                {
                    dgvReports["clxNomeFisico", i].Style.BackColor = Color.FromArgb(201, 217, 218);
                }
            }
        }

        private void btnSincronizar_Click(object sender, EventArgs e)
        {
            workSincronizacao = new Thread(formularioService.SicnronizaRelatorios);
            workSincronizacao.Start();
            tempo.Start();
            btnSincronizar.Enabled = false;
            while (!workSincronizacao.IsAlive) ;
        }

        private void txtPesquisaForm_TextChanged(object sender, EventArgs e)
        {
            try
            {
                treePesquisa.Nodes.Clear();

                if (txtPesquisaForm.Text != "")
                {

                    foreach (TreeNode node in treeTelas.Nodes)
                    {
                        BuscaNodePesquisa(node, treePesquisa);
                    }
                    if (treePesquisa.Nodes.Count > 0)
                    {
                        treePesquisa.Visible = true;
                        treeTelas.Visible = false;
                    }
                }
                else
                {
                    treePesquisa.Visible = false;
                    treeTelas.Visible = true;
                }
            }
            catch (System.Exception ex)
            {
                new HLPexception(ex);
            }
        }

        private void BuscaNodePesquisa(TreeNode node, KryptonTreeView tv)
        {
            try
            {

                if (node.Nodes.Count > 0)
                {
                    foreach (TreeNode nodeFilho in node.Nodes)
                    {
                        BuscaNodePesquisa(nodeFilho, tv);
                    }
                }
                else
                {
                    if (node.Text.ToUpper().Contains(txtPesquisaForm.Text.ToUpper()))
                    {
                        TreeNode NodeCopy = (TreeNode)node.Clone();
                        tv.Nodes.Add(NodeCopy);
                    }
                }

            }
            catch (System.Exception ex)
            {
                new HLPexception(ex);
            }
        }

        private void btnLimpaPesquisa_Click(object sender, EventArgs e)
        {
            txtPesquisaForm.Text = String.Empty;
            treePesquisa.Nodes.Clear();
            treePesquisa.Visible = false;
            treeTelas.Visible = true;

        }

        private void tempo_Tick(object sender, EventArgs e)
        {
            if (formularioService.bEndSincronizacao)
            {
                tempo.Stop();
                workSincronizacao.Join();

                formulario = formularioService.GetFormulario(nomeFormulario, UserData.idUser);
                if (formulario != null && formulario.lRelatorios != null)
                {
                    bsReports.DataSource = formulario.lRelatorios;
                    ColorGrid();
                }

                btnSincronizar.Enabled = true;
            }
        }

        private void tsmDuplicar_Click(object sender, EventArgs e)
        {
            try
            {

                RelatoriosModel objRelCurrent = bsReports.Current as RelatoriosModel;

                RelatoriosModel objRelDupl = new RelatoriosModel();
                objRelDupl.idFormularios = objRelCurrent.idFormularios;
                objRelDupl.stAtivo = true;
                objRelDupl.xDetalhes = objRelCurrent.xDetalhes;
                objRelDupl.xNomeFisico = objRelCurrent.xNomeFisico.Replace("HLP_", "USER_");
                objRelDupl.xNomeRelatorio = objRelCurrent.xNomeRelatorio;


                //copiar relatorio para pasta específica
                string sPathReportHlp = Pastas.Path_Report + objRelCurrent.xNomeFisico;
                string sPathReportUser = Pastas.Path_Report_Especifico + objRelDupl.xNomeFisico;

                bool ExistReportInDataBase = relatorioService.ReportExistInDataBase(objRelDupl.xNomeFisico);

                if (File.Exists(sPathReportUser) && !ExistReportInDataBase) // verificar se o relatorio já existe no diretorio e não existe ainda no banco...
                {
                    if (KryptonMessageBox.Show(null, "Este relatório já existe, deseja realizar a Sincronização agora?", "A V I S O", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        btnSincronizar_Click(sender, e);
                    }
                }
                else if (!File.Exists(sPathReportUser) && ExistReportInDataBase)
                {
                    btnSincronizar_Click(sender, e);
                }
                else
                {
                    int n = 0;
                    string sNomeFisico = objRelDupl.xNomeFisico;
                    string sNomeRelat = objRelDupl.xNomeRelatorio;
                    string sPathDupRelatUser = sPathReportUser;

                    while (File.Exists(sPathReportUser))
                    {
                        n++;

                        objRelDupl.xNomeFisico = sNomeFisico.Replace(".rpt", "_") + n + ".rpt";
                        objRelDupl.xNomeRelatorio = sNomeRelat + " " + n;
                        sPathReportUser = Pastas.Path_Report_Especifico + objRelDupl.xNomeFisico;
                    }


                    formularioService.BeginTransaction();

                    relatorioService.Save(objRelDupl);
                    if (objRelCurrent.xNomeFisico.Contains("HLP_"))
                    {
                        File.Copy(sPathReportHlp, sPathReportUser);
                    }
                    else
                    {
                        File.Copy(sPathDupRelatUser, sPathReportUser);
                    }


                    (bsReports.DataSource as List<RelatoriosModel>).Add(objRelDupl); //adiciona o relatorio no bindingsource
                    bsReports.ResetBindings(false); // Atualiza BindingSource
                    formularioService.CommitTransaction();
                    ColorGrid();
                }

            }
            catch (System.Exception ex)
            {
                formularioService.RollBackTransaction();
                new HLPexception(ex);
            }
        }

        private void tsmExcluir_Click(object sender, EventArgs e)
        {
            try
            {

                RelatoriosModel relatDel = (bsReports.Current as RelatoriosModel);

                if (!relatDel.xNomeFisico.Contains("HLP_"))
                {
                    formularioService.BeginTransaction();
                    //formularioService.Delete((int)relatDel.idRelatorio);
                    string sPathReportUser = Pastas.Path_Report_Especifico + relatDel.xNomeFisico;
                    File.Delete(sPathReportUser);
                    formularioService.CommitTransaction();

                    bsReports.Remove(relatDel);
                }
                else
                {
                    KryptonMessageBox.Show(null, "Você não pode deletar um relatório padrão!", "E R R O", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (System.Exception ex)
            {
                formularioService.RollBackTransaction();
                new HLPexception(ex);
            }
        }

        private void FormConfigRelatorio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bsReports != null && bsReports.List.Count > 0)
            {
                //formularioService.Save(formulario);
            }
        }

        private void editarRelatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatoriosModel objRelatorio = (RelatoriosModel)bsReports.Current;

            if (objRelatorio.xNomeFisico.Contains("HLP_"))
            {
                return;
            }

            RegistryKey key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\SAP BusinessObjects\\Crystal Reports for .NET Framework 4.0\\Crystal Reports", true);
            if (key != null)
            {
                string sPath = Convert.ToString(key.GetValue("Path", ""));
                string sCaminho = sPath + "crw32.exe";

                if (File.Exists(sCaminho))
                {
                    System.Diagnostics.Process.Start(sCaminho, Pastas.Path_Report_Especifico + "\\" + objRelatorio.xNomeFisico);
                }
                else
                {
                    KryptonMessageBox.Show("Aplicativo de edição de Relatórios não foi encontrado.", "A V I S O", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                KryptonMessageBox.Show("Aplicativo de edição de Relatórios não foi encontrado.", "A V I S O", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvReports_CellValidated(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.RowIndex > -1)
                {
                    if (dgvReports.Columns[e.ColumnIndex].Name.Equals("clxNomeRelatorio"))
                    {
                        if (!dgvReports["clxNomeFisico", e.RowIndex].Value.ToString().Contains("HLP_")) //Se não for relatório padrão...
                        {
                            string sNomeFisicoRelat = dgvReports[e.ColumnIndex, e.RowIndex].Value.ToString().Replace(" ", "_");
                            string sAntigo = dgvReports["clxNomeFisico", e.RowIndex].Value.ToString();
                            string sNovo = "USER_" + sNomeFisicoRelat + ".rpt";

                            // Se o nome foi alterado, mas já existe um relatório com este nome...
                            if (sAntigo != sNovo && File.Exists(Pastas.Path_Report_Especifico + sNovo))
                            {
                                KryptonMessageBox.Show(null, "Já existe um Relatório com este nome !", "A V I S O", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                dgvReports["clxNomeRelatorio", e.RowIndex].Value = sAntigo.Replace("_", " ").Replace(".rpt", "").Replace("USER ", "");
                            }
                            else if (sAntigo != sNovo)
                            {
                                dgvReports["clxNomeFisico", e.RowIndex].Value = sNovo;

                                formularioService.BeginTransaction();
                                File.Move(Pastas.Path_Report_Especifico + sAntigo, Pastas.Path_Report_Especifico + sNovo);
                                relatorioService.Save(bsReports.Current as RelatoriosModel);
                                formularioService.CommitTransaction();

                            }
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                formularioService.RollBackTransaction();
                string sNmForm = (treePesquisa.Visible ? treePesquisa : treeTelas).SelectedNode.Name;
                bsReports.DataSource = formularioService.GetFormulario(sNmForm, UserData.idUser).lRelatorios;
                ColorGrid();

                new HLPexception(ex);
            }
        }

        private void dgvReports_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                // Se o nome físico for relatorio padrão e a coluna selecionada não for detalhes... entra no if
                if (dgvReports["clxNomeFisico", e.RowIndex].Value.ToString().Contains("HLP_") && !dgvReports.Columns[e.ColumnIndex].Name.Equals("xDestalhes"))
                {
                    e.Cancel = true;
                }
                else
                {
                    e.Cancel = false;
                }
            }
        }


    }
}