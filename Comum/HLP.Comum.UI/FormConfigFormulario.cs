using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using HLP.Comum.Components;
using HLP.Comum.Infrastructure;
using HLP.Comum.UI.Exception;
using HLP.Comum.Models.Static;

namespace HLP.Comum.UI
{
    public partial class FormConfigFormulario : KryptonForm
    {
        ConfigFormulariosModel objConfigFormularioModel { get; set; }
        List<Control> lControl { get; set; }
        string sFormat = ("{0}  -  {1}");
        List<string> lProperty = ("_LabelGroup-_TamanhoComponente-_TamanhoMaiorLabel-_Table-_Field-Name-"
                                + "_LabelText-_Regex-_Help-_Obrigatorio-MaxLength-Enabled-ReadOnly-_Multiline-"
                                + "_Password-Text-CharacterCasing-Color-DataSource-ValueMember-DisplayMember-AllowDrop-Format-S"
                                + "CustomFormat-Value-CampoObrigatorio-Checked-electedIndex-SelectedIndexByte-_situacao-DisplayMember-ValueMember-SelectedValue-_Itens-"
                                + "_TpValidacao-MaskFormat-Mask-Maximum-Minimum-DecimalPlaces-ValueInt").Split('-').ToList();

        public FormConfigFormulario(ConfigFormulariosModel objConfigFormularioModel, List<Control> lControl)
        {
            InitializeComponent();
            this.objConfigFormularioModel = objConfigFormularioModel;
            this.lControl = lControl;
            headerConfig.Values.Description = objConfigFormularioModel.objConfigFormUsu.xText;
            CarregaTreeViewFormulario();
        }

        void CarregaTreeViewFormulario()
        {
            TreeFormulario.Nodes.Clear();

            TreeNode n = new TreeNode();
            n.ImageIndex = 0;
            n.SelectedImageIndex = 0;
            n.Text = objConfigFormularioModel.xNameFormulario;
            n.Tag = "FORM";

            TreeFormulario.Nodes.Add(n);

            TreeNode nTab = new TreeNode();
            CriaNodesTabPage(objConfigFormularioModel.objConfigTabPage, nTab);
            TreeFormulario.Nodes[0].Nodes.Add(nTab);


            TreeFormulario.Nodes[0].ExpandAll();

        }

        void CriaNodesTabPage(ConfigTabPageModel tab, TreeNode nTab)
        {
            nTab.ImageIndex = 1;
            nTab.SelectedImageIndex = 1;
            nTab.Text = tab.objConfigTabPageUsu.xTabPage;
            nTab.Tag = tab;

            TreeNode nSeparador;
            TreeNode nComponente;

            foreach (string separador in tab.lConfigComponente.Select(c => c.xLabelGroup).Distinct())
            {
                nSeparador = new TreeNode();
                nSeparador.ImageIndex = 2;
                nSeparador.SelectedImageIndex = 2;
                nSeparador.Text = separador;
                nSeparador.Tag = "SEPARADOR";
                foreach (var comp in tab.lConfigComponente.Where(c => (c.xTypeComp != "HLP_DataGridView") && (c.xLabelGroup == separador)))
                {
                    nComponente = new TreeNode();
                    nComponente.ImageIndex = 3;
                    nComponente.SelectedImageIndex = 3;
                    nComponente.Text = comp.objConfigCompUsu.xLabelText;
                    nComponente.Tag = comp;
                    nSeparador.Nodes.Add(nComponente);
                }
                if (nSeparador.Nodes.Count > 0)
                    nTab.Nodes.Add(nSeparador);
            }

            foreach (var comp in tab.lConfigComponente.Where(c => c.xTypeComp == "HLP_DataGridView"))
            {
                nComponente = new TreeNode();
                nComponente.ImageIndex = 4;
                nComponente.SelectedImageIndex = 4;
                nComponente.Text = "GrideView - " + comp.xName;
                nComponente.Tag = comp;

                TreeNode nColumn = null;
                foreach (var col in comp.lConfigColunasGrid)
                {
                    nColumn = new TreeNode();
                    nColumn.ImageIndex = 5;
                    nColumn.SelectedImageIndex = 5;
                    nColumn.Text = col.objColunasGridUsu.xHeaderText;
                    nColumn.Tag = col;
                    nComponente.Nodes.Add(nColumn);
                }
                if (nComponente.Nodes.Count > 0)
                    nTab.Nodes.Add(nComponente);
            }


            if (tab.lConfigTabPageModel.Count() > 0)
            {
                foreach (ConfigTabPageModel tabFilho in tab.lConfigTabPageModel)
                {
                    TreeNode nFilho = new TreeNode();
                    CriaNodesTabPage(tabFilho, nFilho);
                    nTab.Nodes.Add(nFilho);
                }
            }
        }


        void AddCompToContainer(string xNameComp)
        {
            Control ctr = null;
            try
            {
                ctr = FindControl(xNameComp) as Control;
                if (ctr != null)
                {
                    Control copy = CloneObject(ctr) as Control;
                    if (copy.GetType() == typeof(HLP_DataGridView))
                        copy.Dock = DockStyle.Fill;
                    copy.Visible = true;
                    panelDesign.Controls.Clear();
                    int y = (panelDesign.Height / 2) - (copy.Height / 2);
                    panelDesign.Controls.Add(copy);
                    copy.Location = new Point(0, y);
                    panelDesign.Refresh();
                }
            }
            catch (System.Exception)
            {
                if (ctr != null)
                    ctr.Location = new Point(0, 0);
            }
        }

        private object CloneObject(object o)
        {
            Type t = o.GetType();
            PropertyInfo[] properties = t.GetProperties();

            object p = t.InvokeMember("", System.Reflection.BindingFlags.CreateInstance, null, o, null);

            foreach (PropertyInfo pi in properties)
            {
                if (pi.CanWrite)
                {
                    if (lProperty.Contains(pi.Name))
                        pi.SetValue(p, pi.GetValue(o, null), null);
                }
            }
            return p;
        }

        private Control FindControl(string xNameConrtrol)
        {
            if (lControl.Where(c => c.Name == xNameConrtrol).Count() > 0)
                return lControl.FirstOrDefault(c => c.Name == xNameConrtrol);
            else
                return null;
        }

        private void TreeFormulario_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (e.Node.Tag.GetType() == ("").GetType())
                {

                }
                else if (e.Node.Tag.GetType() == typeof(ConfigTabPageModel))
                {

                }
                else if (e.Node.Tag.GetType() == typeof(ConfigColunasGridModel))
                {
                    AfterSelectColumnModel(e.Node);
                }
                else if (e.Node.Tag.GetType() == typeof(ConfigComponenteModel))
                {
                    AfterSelectComponenteModel(e.Node);
                }
            }
            catch (System.Exception ex)
            {
                new HLPexception(ex);
            }
        }

        void VisibleColumns(List<ConfigColunasGridModel> lcolunas, HLP_DataGridView dgv)
        {
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                col.Visible = Convert.ToBoolean(lcolunas.FirstOrDefault(c => c.xNameColuna == col.Name).objColunasGridUsu.stVisible);
            }
        }

        void UnVisibleColumns(HLP_DataGridView dgv, string sNameColumn)
        {
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                if (sNameColumn.Contains(col.Name))
                    col.Visible = true;
                else
                    col.Visible = false;
            }

        }

        void AfterSelectColumnModel(TreeNode node)
        {
            lstDados.Items.Clear();
            ConfigComponenteModel compGrid = node.Parent.Tag as ConfigComponenteModel;
            if (panelDesign.Controls.Count == 0)
            {
                AddCompToContainer(compGrid.xName);
            }
            else if (panelDesign.Controls[0].Name != compGrid.xName)
            {
                AddCompToContainer(compGrid.xName);
            }

            ConfigColunasGridModel col = node.Tag as ConfigColunasGridModel;

            UnVisibleColumns((panelDesign.Controls[0] as HLP_DataGridView), col.xNameColuna);
            lstDados.Items.Add(string.Format(sFormat, "TABELA", (node.Parent.Tag as ConfigComponenteModel).xTable.ToUpper()));
            lstDados.Items.Add(string.Format(sFormat, "CAMPO", col.xDataPropertyName.ToUpper()));
            if (col.Base != null)
            {
                lstDados.Items.Add(string.Format(sFormat, "OBRIGATÓRIO ?", col.Base.GetObrigatoriedade()));
                lstDados.Items.Add(string.Format(sFormat, "TAMANHO", col.Base.PRECISION));
                lstDados.Items.Add(string.Format(sFormat, "DECIMAIS", col.Base.SCALE));
                lstDados.Items.Add(string.Format(sFormat, "TIPO DO CAMPO", col.Base.TYPE_NAME.ToUpper()));
            }
        }

        void AfterSelectComponenteModel(TreeNode node)
        {
            lstDados.Items.Clear();
            ConfigComponenteModel comp = node.Tag as ConfigComponenteModel;
            AddCompToContainer(comp.xName);

            if (panelDesign.Controls.Count > 0)
            {

                if (panelDesign.Controls[0].GetType() != typeof(HLP_DataGridView))
                {
                    if (comp.Base != null)
                    {
                        lstDados.Items.Add(string.Format(sFormat, "TABELA", comp.xTable.ToUpper()));
                        lstDados.Items.Add(string.Format(sFormat, "CAMPO", comp.xField.ToUpper()));
                        lstDados.Items.Add(string.Format(sFormat, "OBRIGATÓRIO ?", comp.Base.GetObrigatoriedade()));
                        lstDados.Items.Add(string.Format(sFormat, "TAMANHO", comp.Base.PRECISION));
                        lstDados.Items.Add(string.Format(sFormat, "DECIMAIS", comp.Base.SCALE));
                        lstDados.Items.Add(string.Format(sFormat, "TIPO DO CAMPO", comp.Base.TYPE_NAME.ToUpper()));
                    }
                }
                else
                {

                    if (panelDesign.Controls[0].Tag != null)
                    {
                        VisibleColumns(comp.lConfigColunasGrid, (panelDesign.Controls[0] as HLP_DataGridView));
                        lstDados.Items.Add(string.Format(sFormat, "TABELA", panelDesign.Controls[0].Tag.ToString().ToUpper()));
                        (panelDesign.Controls[0] as HLP_DataGridView).AllowUserToDeleteRows = true;
                        (panelDesign.Controls[0] as HLP_DataGridView).AllowUserToAddRows = true;
                    }
                }
            }

        }

        private void TreeFormulario_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if ((e.Item as TreeNode).Tag.GetType() != ("").GetType())
            {
                if ((e.Item as TreeNode).Tag.GetType() == typeof(ConfigComponenteModel))
                {
                    if (((e.Item as TreeNode).Tag as ConfigComponenteModel).xTypeComp == typeof(HLP_DataGridView).Name)
                    {
                        return;
                    }
                }
                DoDragDrop(e.Item, DragDropEffects.Move);
            }
        }

        private void TreeFormulario_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void TreeFormulario_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            if (e.Data.GetDataPresent("System.Windows.Forms.TreeNode", false))
            {
                Point pt = ((ComponentFactory.Krypton.Toolkit.KryptonTreeView)sender).PointToClient(new Point(e.X, e.Y));
                TreeNode DestinationNode = ((ComponentFactory.Krypton.Toolkit.KryptonTreeView)sender).GetNodeAt(pt);

                int index = DestinationNode.Index;

                NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

                if (NewNode.Tag.GetType() == DestinationNode.Tag.GetType())
                {
                    if ((DestinationNode.Tag.GetType() == typeof(ConfigComponenteModel)) || (DestinationNode.Tag.GetType() == typeof(ConfigColunasGridModel)) || (DestinationNode.Tag.GetType() == typeof(ConfigTabPageModel)))
                        DestinationNode = DestinationNode.Parent;
                    DestinationNode.Nodes.Insert(index, (TreeNode)NewNode.Clone());
                    DestinationNode.Expand();
                    NewNode.Remove();

                    // tratamento para TabPag - faltando
                    // tratamento para colunas - faltando


                    if (NewNode.Tag.GetType() == typeof(ConfigComponenteModel))
                    {
                        foreach (TreeNode node in DestinationNode.Nodes)
                        {
                            (node.Tag as ConfigComponenteModel).objConfigCompUsu.nOrder = node.Index;
                            (node.Tag as ConfigComponenteModel).xLabelGroup = DestinationNode.Text; // Verificar para mudar quando mudar o text do separador.

                        }
                    }
                }
            }
        }
    }
}