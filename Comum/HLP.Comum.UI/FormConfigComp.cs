using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using HLP.Comum.Messages;
using HLP.Comum.Models;
using HLP.Comum.Services.Interface;
using HLP.Dependencies;
using Ninject;
using System.Drawing;
using HLP.Comum.Infrastructure;

namespace HLP.Comum.UI
{
    public partial class FormConfigComp : KryptonForm
    {
        //ILayoutService layoutService { get; set; }

        [Inject]
        public IPesquisaPadraoService pesquisaPadraoService { get; set; }

        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        //HierarquiaTab objTabHierarquia { get; set; }
        //Componente objCompDisplay { get; set; }
        //GridColumn objColumnDisplay { get; set; }
        //List<string> lDisplayColumn = new List<string>();
        //List<PesquisaPadraoModel> objList = null;
        //public bool bAlterou = false;

        //public FormConfigComp(ILayoutService layoutService)
        //{
        //    InitializeComponent();
        //    IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
        //    kernel.Settings.ActivationCacheDisabled = false;
        //    kernel.Inject(this);

        //    this.layoutService = layoutService;
        //    CarregaTreeview();
        //    this.Text = string.Format(this.Text, layoutService.lControl.FirstOrDefault().FindForm().Text);
        //    treeCampos.SelectedNode = treeCampos.Nodes[0];
        //    txtLabelText.txt.KeyUp += new KeyEventHandler(txt_KeyUp);

        //    chkDisplayMember.chk.ItemCheck += new ItemCheckEventHandler(chk_ItemCheck);

        //    lstOrdem.ListBox.AllowDrop = true;
        //    lstOrdem.ListBox.DragDrop += new DragEventHandler(lstOrdem_DragDrop);
        //    lstOrdem.ListBox.DragOver += new DragEventHandler(lstOrdem_DragOver);
        //    lstOrdem.ListBox.MouseDown += new MouseEventHandler(lstOrdem_MouseDown);
        //}

        //private void LoadControls()
        //{
        //    if (objCompDisplay != null)
        //    {
        //        CarregaComponente();
        //    }
        //    else if (objColumnDisplay != null)
        //    {
        //        CarregaColuna();
        //    }
        //    else if (objTabHierarquia != null)
        //    {
        //        CarregaTahHierarquia();
        //    }
        //}

        //void VisualizacaoComponente(bool bHabilita)
        //{
        //    foreach (UserControl item in flpComponentes.Controls.OfType<UserControl>().ToList())
        //    {
        //        item.Visible = bHabilita;
        //    }
        //    kryptonPanel2.Visible = bHabilita;
        //}

        //void CarregaTahHierarquia()
        //{
        //    try
        //    {
        //        VisualizacaoComponente(false);
        //        txtHelp.Visible = true;
        //        txtHelp.txt.DataBindings.Clear();
        //        txtHelp.txt.DataBindings.Add("Text", objTabHierarquia, "HelpTab");

        //    }
        //    catch (System.Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //void CarregaComponente()
        //{
        //    VisualizacaoComponente(true);
        //    if (objCompDisplay.TypeComp.Equals("HLP_NumericUpDown"))
        //    {
        //        nudDecimalPlaces.Visible = true;
        //        nudDecimalPlacesBase.Visible = true;
        //    }
        //    else
        //    {
        //        nudDecimalPlaces.Visible = false;
        //        nudDecimalPlacesBase.Visible = false;
        //    }
        //    lstOrdem.Visible = chkDisplayMember.Visible = false;
        //    txtText.Visible = false;
        //    nudText.Visible = false;
        //    nudDecimalPlacesBase.Maximum = objCompDisplay.BaseConfig.DecimalPlaces;
        //    nudMaxLengthBase.nud.Value = 0;
        //    nudMaxLengthBase.Maximum = objCompDisplay.BaseConfig.MaxLength + 1;
        //    nudMaxLength.nud.Value = 0;
        //    nudMaxLength.Maximum = objCompDisplay.BaseConfig.MaxLength + 1;
        //    nudDecimalPlaces.Maximum = objCompDisplay.BaseConfig.DecimalPlaces;


        //    txtField.txt.DataBindings.Clear();
        //    txtLabelText.txt.DataBindings.Clear();
        //    txtHelp.txt.DataBindings.Clear();
        //    txtTable.txt.DataBindings.Clear();
        //    txtType.txt.DataBindings.Clear();
        //    nudDecimalPlaces.nud.DataBindings.Clear();
        //    nudDecimalPlacesBase.nud.DataBindings.Clear();
        //    nudMaxLength.nud.DataBindings.Clear();
        //    nudMaxLengthBase.nud.DataBindings.Clear();
        //    chkEnabled.chk.DataBindings.Clear();
        //    chkVisible.chk.DataBindings.Clear();
        //    chkRequired.chk.DataBindings.Clear();
        //    txtText.txt.DataBindings.Clear();
        //    nudText.nud.DataBindings.Clear();

        //    if ((objCompDisplay.TypeComp.Equals("HLP_TextBox")) || (objCompDisplay.TypeComp.Equals("HLP_MaskedTextBox")))
        //    {
        //        txtText.Visible = true;
        //        txtText.txt.MaxLength = Convert.ToInt32(objCompDisplay.BaseConfig.MaxLength);
        //        txtText.txt.DataBindings.Add("Text", objCompDisplay, "Text");
        //    }
        //    else if ((objCompDisplay.TypeComp.Equals("HLP_NumericUpDown")))
        //    {
        //        nudText.Visible = true;
        //        nudText.Maximum = objCompDisplay.BaseConfig.DecimalPlaces;
        //        nudText.Maximum = objCompDisplay.BaseConfig.MaxLength;
        //        nudText.nud.DataBindings.Add("Text", objCompDisplay, "Text");
        //    }
        //    if (objCompDisplay.BaseConfig.Required)
        //    {
        //        chkEnabled.Enabled = false;
        //        chkVisible.Enabled = false;
        //    }
        //    else
        //    {
        //        chkEnabled.Enabled = true;
        //        chkVisible.Enabled = true;
        //    }

        //    txtField.txt.DataBindings.Add("Text", objCompDisplay, "Field");
        //    txtLabelText.txt.DataBindings.Add("Text", objCompDisplay, "LabelText");
        //    txtHelp.txt.DataBindings.Add("Text", objCompDisplay, "Help");
        //    txtTable.txt.DataBindings.Add("Text", objCompDisplay, "Table");
        //    txtType.txt.DataBindings.Add("Text", objCompDisplay.BaseConfig, "Type");
        //    nudDecimalPlaces.nud.DataBindings.Add("Text", objCompDisplay, "DecimalPlaces");
        //    nudDecimalPlacesBase.nud.DataBindings.Add("Text", objCompDisplay.BaseConfig, "DecimalPlaces");
        //    nudMaxLength.nud.DataBindings.Add("Text", objCompDisplay, "MaxLength");
        //    nudMaxLengthBase.nud.DataBindings.Add("Value", objCompDisplay.BaseConfig, "MaxLength", true, DataSourceUpdateMode.OnPropertyChanged);
        //    chkEnabled.chk.DataBindings.Add("Checked", objCompDisplay, "Enabled");
        //    chkVisible.chk.DataBindings.Add("Checked", objCompDisplay, "Visible");
        //    chkRequired.chk.DataBindings.Add("Checked", objCompDisplay.BaseConfig, "Required");
        //}
        //void CarregaColuna()
        //{

        //    VisualizacaoComponente(true);
        //    if (objColumnDisplay.TypeColumn.Equals("KryptonDataGridViewNumericUpDownColumn"))
        //    {
        //        nudDecimalPlaces.Visible = true;
        //        nudDecimalPlacesBase.Visible = true;
        //    }
        //    else
        //    {
        //        nudDecimalPlaces.Visible = false;
        //        nudDecimalPlacesBase.Visible = false;
        //    }
        //    lstOrdem.Visible = chkDisplayMember.Visible = false;
        //    txtText.Visible = false;
        //    nudText.Visible = false;
        //    nudDecimalPlacesBase.Maximum = objColumnDisplay.BaseConfigGrid.DecimalPlaces;
        //    nudMaxLengthBase.nud.Value = 0;
        //    nudMaxLengthBase.nud.Maximum = objColumnDisplay.BaseConfigGrid.MaxLength + 1;
        //    nudMaxLength.nud.Value = 0;
        //    nudMaxLength.nud.Maximum = objColumnDisplay.BaseConfigGrid.MaxLength + 1;
        //    nudDecimalPlaces.Maximum = objColumnDisplay.BaseConfigGrid.DecimalPlaces;
        //    txtField.txt.DataBindings.Clear();
        //    txtLabelText.txt.DataBindings.Clear();
        //    txtHelp.txt.DataBindings.Clear();
        //    txtTable.txt.DataBindings.Clear();
        //    txtType.txt.DataBindings.Clear();
        //    nudDecimalPlaces.nud.DataBindings.Clear();
        //    nudDecimalPlacesBase.nud.DataBindings.Clear();
        //    nudMaxLength.nud.DataBindings.Clear();
        //    nudMaxLengthBase.nud.DataBindings.Clear();
        //    chkEnabled.chk.DataBindings.Clear();
        //    chkVisible.chk.DataBindings.Clear();
        //    chkRequired.chk.DataBindings.Clear();
        //    txtText.txt.DataBindings.Clear();
        //    nudText.nud.DataBindings.Clear();

        //    if (objColumnDisplay.TypeColumn.Equals("DataGridViewComboBoxColumn"))
        //    {
        //        lstOrdem.Visible = chkDisplayMember.Visible = true;
        //        CarregaDisplay();

        //    }
        //    if (objColumnDisplay.BaseConfigGrid.Required)
        //    {
        //        chkEnabled.Enabled = false;
        //        chkVisible.Enabled = false;
        //    }
        //    else
        //    {
        //        chkEnabled.Enabled = true;
        //        chkVisible.Enabled = true;
        //    }


        //    txtField.txt.DataBindings.Add("Text", objColumnDisplay, "DataPropertyName");
        //    txtLabelText.txt.DataBindings.Add("Text", objColumnDisplay, "HeaderText");
        //    txtTable.txt.DataBindings.Add("Text", objColumnDisplay, "Table");
        //    txtHelp.txt.DataBindings.Add("Text", objColumnDisplay, "Help");
        //    txtType.txt.DataBindings.Add("Text", objColumnDisplay.BaseConfigGrid, "Type");
        //    nudDecimalPlaces.nud.DataBindings.Add("Text", objColumnDisplay, "DecimalPlaces");
        //    nudDecimalPlacesBase.nud.DataBindings.Add("Text", objColumnDisplay.BaseConfigGrid, "DecimalPlaces");
        //    nudMaxLength.nud.DataBindings.Add("Text", objColumnDisplay, "MaxLength");
        //    nudMaxLengthBase.nud.DataBindings.Add("Text", objColumnDisplay.BaseConfigGrid, "MaxLength");
        //    //chkEnabled.chk.DataBindings.Add("Checked", objColumnDisplay, "Enabled");
        //    chkVisible.chk.DataBindings.Add("Checked", objColumnDisplay, "Visible");
        //    chkRequired.chk.DataBindings.Add("Checked", objColumnDisplay.BaseConfigGrid, "Required");
        //}
        //void CarregaDisplay()
        //{
        //    lstOrdem.Items.Clear();
        //    chkDisplayMember.chk.Items.Clear();
        //    if (objColumnDisplay.TypeColumn == "DataGridViewComboBoxColumn")
        //    {
        //        string sTable = pesquisaPadraoService.GetFkTableName(objColumnDisplay.Table, objColumnDisplay.DataPropertyName);
        //        //Verificar se a View Existe
        //        //Criar View

        //        if (sTable != "")
        //        {
        //            string sView = "vw" + sTable.Replace("_", "");
        //            if (!UndTrabalho.ViewExistis(sView))
        //            {
        //                pesquisaPadraoService.CreateViewByTable(sTable);
        //            }

        //            objList = pesquisaPadraoService.GetTableInformation(sView);
        //            List<string> lDisplay = objColumnDisplay.DisplayMember.Replace("CAST(", "").Replace("as varchar)", "")
        //             .Replace("+", "").Replace("'", "").Replace(" ", "").Split('-').ToList();
        //            foreach (var item in objList)
        //            {
        //                chkDisplayMember.chk.Items.Add(item.COLUMN_NAME);
        //                if (lDisplay.Contains(item.COLUMN_NAME))
        //                {
        //                    chkDisplayMember.chk.SetItemChecked(chkDisplayMember.chk.Items.IndexOf(item.COLUMN_NAME), true);
        //                }
        //            }
        //            foreach (string item in lDisplay)
        //            {
        //                lstOrdem.Items.Add(item);
        //            }
        //        }
        //    }
        //}
        //void CarregaTreeview()
        //{
        //    try
        //    {
        //        treeCampos.Nodes.Clear();
        //        TreeNode n;
        //        foreach (HierarquiaTab tab in layoutService.objConfig.Hierarquia.Tabs)
        //        {
        //            n = new TreeNode();
        //            CriaNodesTabPage(tab, n);
        //            treeCampos.Nodes.Add(n);
        //        }

        //        for (int i = 0; i < treeCampos.Nodes.Count; i++)
        //        {
        //            CriaNodesCampos(treeCampos.Nodes[i]);
        //        }
        //        treeCampos.ExpandAll();
        //        treeCampos.SelectedNode = treeCampos.Nodes[0];

        //    }
        //    catch (System.Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //private void CriaNodesTabPage(HierarquiaTab tab, TreeNode n)
        //{
        //    n.Text = tab.TextTab;
        //    n.Tag = tab;

        //    if (tab.Tabs.Count > 0)
        //    {
        //        foreach (HierarquiaTab tabFilho in tab.Tabs)
        //        {
        //            TreeNode nFilho = new TreeNode();
        //            CriaNodesTabPage(tabFilho, nFilho);
        //            n.Nodes.Add(nFilho);
        //        }
        //    }
        //}

        //private void CriaNodesCampos(TreeNode n)
        //{
        //    if (n.Tag != null)
        //    {
        //        if (n.Tag.GetType() == typeof(HierarquiaTab))
        //        {
        //            HierarquiaTab tab = n.Tag as HierarquiaTab;
        //            foreach (Componente comp in layoutService.objConfig.Componentes.Where(c => c.Parent == tab.NameTab))
        //            {
        //                if (!comp.Name.Equals("txtCodigo"))
        //                {
        //                    if (comp.Field != null)
        //                    {
        //                        n.Nodes.Add(comp.Field, comp.LabelText, 1, 1);
        //                        n.Nodes[comp.Field].Tag = comp;
        //                    }
        //                }
        //            }
        //            Grid grid = layoutService.objConfig.DataGrid.FirstOrDefault(C => C.ParentTabName == tab.NameTab);
        //            if (grid != null)
        //            {
        //                foreach (GridColumn col in grid.DataGridColumn)
        //                {
        //                    n.Nodes.Add(col.DataPropertyName, col.HeaderText, 1, 1);
        //                    n.Nodes[col.DataPropertyName].Tag = col;
        //                }
        //            }
        //        }

        //    }

        //    foreach (TreeNode nodeFilho in n.Nodes)
        //    {
        //        CriaNodesCampos(nodeFilho);
        //    }

        //}

        //private void BuscaTab(List<HierarquiaTab> listTabs, string sContainer, out string sText)
        //{
        //    sText = "";
        //    foreach (HierarquiaTab tab in listTabs)
        //    {
        //        if (tab.NameTab == sContainer)
        //        {
        //            sText = tab.TextTab;
        //            return;
        //        }
        //        else
        //        {
        //            BuscaTab(tab.Tabs, sContainer, out sText);
        //            if (sText != "")
        //            {
        //                return;
        //            }
        //        }
        //    }
        //}
        //private void SaveDisplay()
        //{
        //    if (objColumnDisplay != null)
        //    {
        //        lDisplayColumn = new List<string>();
        //        if (lstOrdem.Items.Count > 0)
        //        {
        //            for (int i = 0; i < lstOrdem.Items.Count; i++)
        //            {
        //                string sItem = lstOrdem.Items[i].ToString();
        //                if (!String.IsNullOrEmpty(sItem))
        //                {
        //                    string sType = objList.FirstOrDefault(C => C.COLUMN_NAME == sItem).DATA_TYPE;
        //                    if (sType != "char" && sType != "varchar" && sType != "nvarchar")
        //                    {
        //                        lDisplayColumn.Add("CAST(" + lstOrdem.Items[i].ToString() + " as varchar)");
        //                    }
        //                    else
        //                    {
        //                        lDisplayColumn.Add(lstOrdem.Items[i].ToString());
        //                    }
        //                }
        //            }
        //        }
        //        if (lDisplayColumn.Count() > 0)
        //        {
        //            objColumnDisplay.DisplayMember = String.Join(" + ' - ' + ", lDisplayColumn.ToArray());
        //        }
        //        else
        //        {
        //            objColumnDisplay.DisplayMember = "";
        //        }
        //        layoutService.objConfig.DataGrid.FirstOrDefault(C => C.DataGridColumn.Contains(objColumnDisplay))
        //            .DataGridColumn.FirstOrDefault(C => C.Name == objColumnDisplay.Name && C.TypeColumn == C.TypeColumn).DisplayMember = objColumnDisplay.DisplayMember;
        //    }
        //}


        //private void btnControles_Click(object sender, EventArgs e)
        //{
        //    ToolStripButton btn = sender as ToolStripButton;
        //    if (btn == btnAlterar)
        //    {
        //        flpComponentes.Enabled = true;
        //        btnAlterar.Enabled = false;
        //        btnSalvar.Enabled = true;
        //        btnCancelar.Enabled = true;
        //    }
        //    else if (btn == btnSalvar)
        //    {
        //        if (chkDisplayMember.Enabled && chkDisplayMember.Visible)
        //        {
        //            SaveDisplay();
        //        }
        //        btnSalvar.Enabled = false;
        //        layoutService.Serialize(layoutService.objConfig);
        //        bAlterou = true;
        //        this.Close();
        //    }
        //    else if (btn == btnCancelar)
        //    {
        //        if (HLPMessageBox.MsgCancelar())
        //        {
        //            layoutService.objConfig = layoutService.ConfigurationForm(layoutService.lControl.FirstOrDefault().FindForm().Name);
        //            CarregaTreeview();
        //            flpComponentes.Enabled = false;
        //            btnAlterar.Enabled = true;
        //            btnSalvar.Enabled = false;
        //            btnCancelar.Enabled = false;
        //        }
        //    }
        //}
        //private void txt_KeyUp(object sender, KeyEventArgs e)
        //{
        //    if (treeCampos.SelectedNode.Tag != null)
        //    {
        //        if (treeCampos.SelectedNode.Tag.GetType() == typeof(Componente))
        //        {
        //            treeCampos.SelectedNode.Text = txtLabelText.Text;
        //        }
        //    }
        //}
        //private void chkVisible__Leave(object sender, EventArgs e)
        //{
        //    treeCampos.Focus();
        //}


        //private void treeCampos_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (treeCampos.SelectedNode != null)
        //    {
        //        if (e.KeyCode == Keys.Enter && treeCampos.SelectedNode.Tag != null)
        //        {
        //            if (treeCampos.SelectedNode.Tag.GetType() == typeof(Componente) || treeCampos.SelectedNode.Tag.GetType() == typeof(GridColumn))
        //            {
        //                if (btnAlterar.Enabled)
        //                    btnControles_Click(btnAlterar, e);
        //                txtLabelText.Focus();
        //            }
        //        }
        //    }
        //}
        //private void treeCampos_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        //{
        //    if (treeCampos.SelectedNode != null)
        //    {
        //        if (treeCampos.SelectedNode.Tag != null)
        //        {
        //            if (treeCampos.SelectedNode.Tag.GetType() == typeof(Componente) || treeCampos.SelectedNode.Tag.GetType() == typeof(GridColumn))
        //            {
        //                if (btnAlterar.Enabled)
        //                    btnControles_Click(btnAlterar, e);
        //                txtLabelText.Focus();
        //            }
        //        }
        //    }
        //}
        //private void treeCampos_AfterSelect(object sender, TreeViewEventArgs e)
        //{
        //    if (e.Node.Tag != null)
        //    {
        //        if (chkDisplayMember.Enabled)
        //        {
        //            SaveDisplay();
        //        }
        //        if (e.Node.Tag is HierarquiaTab)
        //        {
        //            objColumnDisplay = null;
        //            objCompDisplay = null;
        //            flpComponentes.Visible = true;
        //            objTabHierarquia = e.Node.Tag as HierarquiaTab;
        //            LoadControls();
        //        }
        //        else if (e.Node.Tag is Componente)
        //        {
        //            objCompDisplay = e.Node.Tag as Componente;
        //            objColumnDisplay = null;
        //            flpComponentes.Visible = true;
        //            LoadControls();
        //        }
        //        else if (e.Node.Tag is GridColumn)
        //        {
        //            objColumnDisplay = e.Node.Tag as GridColumn;
        //            objCompDisplay = null;
        //            flpComponentes.Visible = true;
        //            LoadControls();
        //        }
        //    }
        //    else
        //    {
        //        flpComponentes.Visible = false;
        //    }
        //}


        //private void FormConfigComp_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.Modifiers == Keys.Control && e.KeyValue == (char)13)
        //    {
        //        if ((btnSalvar.Enabled))
        //        {
        //            btnControles_Click(btnSalvar, e);
        //        }
        //    }
        //    else if (e.Modifiers == Keys.Alt && e.KeyValue == (char)65)
        //    {
        //        if (!btnSalvar.Enabled)
        //        {
        //            btnControles_Click(btnAlterar, e);
        //        }
        //    }
        //    else if (e.Modifiers == Keys.Control && e.KeyValue == (char)8)
        //    {
        //        if (btnSalvar.Enabled)
        //        {
        //            btnControles_Click(btnCancelar, e);
        //        }
        //    }
        //    else if ((e.Modifiers == Keys.Alt && e.KeyValue == (char)70) || e.KeyCode == Keys.Escape)
        //    {
        //        this.Close();
        //    }
        //}
        //private void FormConfigComp_FormClosing(object sender, FormClosingEventArgs e)
        //{

        //    if (btnSalvar.Enabled)
        //    {
        //        btnControles_Click(btnSalvar, e);
        //    }
        //}


        //private void chk_ItemCheck(object sender, ItemCheckEventArgs e)
        //{
        //    if (chkDisplayMember.chk.SelectedItem != null)
        //    {
        //        if (e.NewValue == CheckState.Checked)
        //        {
        //            lstOrdem.Items.Add(chkDisplayMember.chk.SelectedItem.ToString());
        //        }
        //        else
        //        {
        //            lstOrdem.Items.Remove(chkDisplayMember.chk.SelectedItem.ToString());
        //        }
        //    }
        //}

        //private void lstOrdem_MouseDown(object sender, MouseEventArgs e)
        //{
        //    if (lstOrdem.SelectedItem != null)
        //    {
        //        lstOrdem.DoDragDrop(lstOrdem.SelectedItem, DragDropEffects.Move);
        //    }
        //}
        //private void lstOrdem_DragOver(object sender, DragEventArgs e)
        //{
        //    e.Effect = DragDropEffects.Move;
        //}
        //private void lstOrdem_DragDrop(object sender, DragEventArgs e)
        //{
        //    int index = 0;
        //    Point point = lstOrdem.PointToClient(new Point(e.X, e.Y));
        //    index = lstOrdem.IndexFromPoint(point);

        //    if (index < 0) index = lstOrdem.Items.Count - 1;

        //    object data = e.Data.GetData(typeof(string));
        //    lstOrdem.Items.Remove(data);
        //    lstOrdem.Items.Insert(index, data);
        //}






    }
}