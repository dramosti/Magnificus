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
using Ninject;
using HLP.Comum.Services.Interface;
using HLP.Dependencies;
using HLP.Comum.Models;

namespace HLP.Comum.UI
{
    public partial class FormConfigFormulario : KryptonForm
    {
        [Inject]
        public IPesquisaPadraoService pesquisaPadraoService { get; set; }
        ConfigFormulariosModel objConfigFormularioModel { get; set; }
        List<Control> lControl { get; set; }
        string sFormat = ("{0}  -  {1}");
        //List<string> lProperty = ("_LabelGroup-_TamanhoComponente-_TamanhoMaiorLabel-_Table-_Field-Name-_NomeView-_ListaCamposDisplay-"
        //                        + "_LabelText-_Regex-_Help-_Obrigatorio-MaxLength-Enabled-Visible-ReadOnly-_Multiline-"
        //                        + "_Password-CharacterCasing-Color-DataSource-DisplayMember-AllowDrop-Format-S"
        //                        + "CustomFormat-CampoObrigatorio-Checked-electedIndex-SelectedIndexByte-_situacao-DisplayMember-_Itens-"
        //                        + "_TpValidacao-MaskFormat-Mask-Maximum-Minimum-DecimalPlaces-ValueInt-Value-Text-ValueMember-SelectedValue").Split('-').ToList();

        List<string> lProperty = ("_NomeView-_ListaCamposDisplay").Split('-').ToList();



        public FormConfigFormulario(ConfigFormulariosModel objConfigFormularioModel, List<Control> lControl)
        {
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);

            InitializeComponent();
            this.objConfigFormularioModel = objConfigFormularioModel;
            this.lControl = lControl;
            headerConfig.Values.Description = objConfigFormularioModel.objConfigFormUsu.xText;
            CarregaTreeViewFormulario();
            listDisplay.ListBox2.MouseDown += Componentes__TextChanged;
            listDisplay.ListBox2.DragDrop += Componentes__TextChanged;
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

            TreeNode nTab;
            foreach (ConfigTabPageModel tab in objConfigFormularioModel.lConfigTabPage)
            {
                nTab = new TreeNode();
                CriaNodesTabPage(tab, nTab);
                TreeFormulario.Nodes[0].Nodes.Add(nTab);
            }


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
                foreach (var comp in tab.lConfigComponente.Where(c => (c.xTypeComp != "HLP_DataGridView") && (c.xLabelGroup == separador)).OrderBy(C => C.objConfigCompUsu.nOrder))
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


        private object CloneObject(object o)
        {
            Type t = o.GetType();
            PropertyInfo[] properties = t.GetProperties();
            object p = t.InvokeMember("", System.Reflection.BindingFlags.CreateInstance, null, o, null);
            foreach (string proper in lProperty)
            {
                if (properties.Where(c => c.Name == proper).Count() > 0)
                {
                    PropertyInfo pi = properties.FirstOrDefault(c => c.Name == proper);
                    if (pi.CanWrite)
                    {
                        pi.SetValue(p, pi.GetValue(o, null), null);
                    }
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

        Control AddCompToContainer(string xNameComp)
        {
            Control ctr = null;
            try
            {
                ctr = FindControl(xNameComp) as Control;
                if (ctr != null)
                {
                    ctr = CloneObject(ctr) as Control;
                    if (ctr.GetType() == typeof(HLP_DataGridView))
                        ctr.Dock = DockStyle.Fill;
                    panelDesign.Controls.Clear();
                    int y = (panelDesign.Height / 2) - (ctr.Height / 2);
                    panelDesign.Controls.Add(ctr);
                    ctr.Location = new Point(0, y);
                    panelDesign.Refresh();

                    if (ctr.GetType() == typeof(HLP_NumericUpDown))
                    {
                        (ctr as HLP_NumericUpDown)._ValueChanged += ComponenteVisual__TextChanged;
                    }
                    else if (ctr.GetType() == typeof(HLP_TextBox))
                    {
                        (ctr as HLP_TextBox)._TextChanged += ComponenteVisual__TextChanged;
                    }
                    else if (ctr.GetType() == typeof(HLP_ComboBox))
                    {
                        (ctr as HLP_ComboBox)._SelectedIndexChanged += ComponenteVisual__TextChanged;
                    }
                    else if (ctr.GetType() == typeof(HLP_CheckBox))
                    {
                        (ctr as HLP_CheckBox)._CheckedChanged += ComponenteVisual__TextChanged;
                    }

                }
                return ctr;
            }
            catch (System.Exception)
            {
                if (ctr != null)
                    ctr.Location = new Point(0, 0);
                return null;
            }
        }

        void LimpaPanelConfig()
        {
            foreach (Control ctr in FlowConfig.Controls)
            {
                ctr.Visible = false;
            }
        }


        void AfterSelectComponenteModel(TreeNode node)
        {
            lstDados.Items.Clear();
            ConfigComponenteModel comp = node.Tag as ConfigComponenteModel;
            Control ctr = AddCompToContainer(comp.xName);
            LimpaPanelConfig();
            chkEnabled.Checked = comp.objConfigCompUsu.stEnabled.ToBoolean();
            chkEnabled.Visible = true;
            chkVisible.Checked = comp.objConfigCompUsu.stVisible.ToBoolean();
            chkVisible.Visible = true;
            nudComprimento.ReadOnly = false;
            int iTamanhoComp = comp.objConfigCompUsu.iTamanhoComponente;
            txtHelp.Text = comp.objConfigCompUsu.xHelp;  // ctr.GetPropertyValue("_Help").ToString();
            txtHelp.Visible = true;
            txtLabelText.Text = comp.objConfigCompUsu.xLabelText; // ctr.GetPropertyValue("_LabelText").ToString();
            txtLabelText.Visible = true;            
            if ((ctr.GetType() == typeof(HLP_ComboBox)) || (ctr.GetType() == typeof(HLP_MaskedTextBox)) || (ctr.GetType() == typeof(HLP_NumericUpDown)) || (ctr.GetType() == typeof(HLP_TextBox)))
                nudComprimento.ReadOnly = true;

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

                        if (comp.Base.SCALE.ToDecimal() > 0)
                        {
                            nudDecimalPlaces.Maximum = comp.Base.SCALE.ToDecimal();
                            //nudDecimalPlaces.Minimum = 1;
                        }
                        if (comp.Base.PRECISION.ToDecimal() > 0)
                        {
                            nudMaxLength.Maximum = (comp.Base.PRECISION.ToDecimal() - comp.Base.SCALE.ToDecimal());
                            //nudMaxLength.Minimum = 1;
                        }
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


            if ((ctr.GetType().GetProperties().Where(c => c.Name == "MaxLength").Count() > 0))
            {
                nudMaxLength.Value = comp.objConfigCompUsu.nMaxLength;
                nudMaxLength.Visible = true;
            }
            if ((ctr.GetType().GetProperties().Where(c => c.Name == "Maximum").Count() > 0))
            {
                nudMaxLength.Value = comp.objConfigCompUsu.nMaxLength.ToString().Count();
                nudMaxLength.Visible = true;
            }


            if (ctr.GetType().GetProperties().Where(c => c.Name == "DecimalPlaces").Count() > 0)
            {
                nudDecimalPlaces.Value = comp.objConfigCompUsu.nDecimalPlaces;
                nudDecimalPlaces.Visible = true;
            }
            if (ctr.GetType().GetProperties().Where(c => c.Name == "Color").Count() > 0)
            {
                btnCor.Visible = true;
            }
            if ((ctr.GetType() != typeof(HLP_Pesquisa)))
                btnValorPadrao.Visible = true;

            if ((ctr.GetType() == typeof(HLP_Pesquisa)))
            {
                listDisplay.Visible = true;
                foreach (PesquisaPadraoModel item in pesquisaPadraoService.GetTableInformation(ctr.GetPropertyValue("_NomeView").ToString()))
                    listDisplay.ListBox1.Items.Add(item.COLUMN_NAME);
                listDisplay.ListBox2.Items.Clear();
                foreach (string item in (List<string>)ctr.GetPropertyValue("_ListaCamposDisplay"))
                    listDisplay.ListBox2.Items.Add(item);
                ctr.Enabled = false;
            }
            nudComprimento.Value = iTamanhoComp;
            nudComprimento.Visible = true;


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


        private void btnCor__btnHlpClick(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ConfigComponenteModel comp = TreeFormulario.SelectedNode.Tag as ConfigComponenteModel;
                comp.objConfigCompUsu.xColor = cd.Color.ToArgb().ToString();
                panelDesign.Controls[0].SetPropertyValue("Color", cd.Color);
            }

        }

        private void btnValorPadrao__btnHlpClick(object sender, EventArgs e)
        {
            panelDesign.Controls[0].Focus();

        }



        private void ComponenteVisual__TextChanged(object sender, EventArgs e)
        {
            try
            {
                ConfigComponenteModel objComp = TreeFormulario.SelectedNode.Tag as ConfigComponenteModel;
                List<PropertyInfo> lProperty = (sender as Control).GetType().GetProperties().ToList();
                Control controlOriginal = FindControl(objComp.xName);
                if (lProperty.Where(c => c.Name == "SelectedIndex").Count() > 0)
                {
                    objComp.objConfigCompUsu.xText = (sender as Control).GetPropertyValue("SelectedIndex").ToString();
                    if (objComp.objConfigCompUsu.xText != "")
                        controlOriginal.SetPropertyValue("SelectedIndex", Convert.ToInt32(objComp.objConfigCompUsu.xText));
                }
                else if (lProperty.Where(c => c.Name == "Value").Count() > 0)
                {
                    objComp.objConfigCompUsu.xText = (sender as Control).GetPropertyValue("Value").ToString();
                    controlOriginal.SetPropertyValue("Value", objComp.objConfigCompUsu.xText.ToDecimal());
                }
                else if (lProperty.Where(c => c.Name == "Text").Count() > 0)
                {
                    objComp.objConfigCompUsu.xText = (sender as Control).GetPropertyValue("Text").ToString();
                    controlOriginal.SetPropertyValue("Text", objComp.objConfigCompUsu.xText);
                }
                else if (lProperty.Where(c => c.Name == "Checked").Count() > 0)
                {
                    objComp.objConfigCompUsu.xText = (sender as Control).GetPropertyValue("Checked").ToString();
                    controlOriginal.SetPropertyValue("Checked", Convert.ToBoolean(objComp.objConfigCompUsu.xText));
                }
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

        }

        private void Componentes__TextChanged(object sender, EventArgs e)
        {
            try
            {
                ConfigComponenteModel objComp = TreeFormulario.SelectedNode.Tag as ConfigComponenteModel;
                Control objSender = (sender as Control).Parent;
                Control controle = panelDesign.Controls[0];
                Control controleOriginal = FindControl(objComp.xName);
                if (objSender == txtHelp)
                {
                    objComp.objConfigCompUsu.xHelp = txtHelp.Text;
                    controle.SetPropertyValue("_Help", txtHelp.Text);
                    controleOriginal.SetPropertyValue("_Help", txtHelp.Text);
                }
                else if (objSender == txtLabelText)
                {
                    objComp.objConfigCompUsu.xLabelText = txtLabelText.Text;
                    controle.SetPropertyValue("_LabelText", txtLabelText.Text);
                    controleOriginal.SetPropertyValue("_LabelText", txtLabelText.Text); ;
                }
                else if (objSender.GetType() == typeof(HLP_NumericUpDown))
                {
                    KryptonNumericUpDown nud = sender as KryptonNumericUpDown;
                    if (nud.Parent == nudDecimalPlaces)
                    {

                        if (objComp.Base != null)
                        {
                            if (nud.Text.ToInt32() <= objComp.Base.SCALE.ToInt32())
                            {
                                objComp.objConfigCompUsu.nDecimalPlaces = nud.Value.ToInt32();
                                controle.SetPropertyValue("DecimalPlaces", nud.Value.ToInt32());
                                controleOriginal.SetPropertyValue("DecimalPlaces", nud.Value.ToInt32());
                            }
                        }
                    }
                    else if (nud.Parent == nudMaxLength)
                    {
                        if (controle.GetType().GetProperties().Where(c => c.Name == "Maximum").Count() > 0)
                        {
                            controle.SetPropertyValue("Maximum", ("").PadLeft(nud.Value.ToInt32(), '9').ToDecimal());
                            controleOriginal.SetPropertyValue("Maximum", ("").PadLeft(nud.Value.ToInt32(), '9').ToDecimal());
                            objComp.objConfigCompUsu.nMaxLength = ("").PadLeft(nud.Value.ToInt32(), '9').ToDecimal();
                        }
                        else if (controle.GetType().GetProperties().Where(c => c.Name == "MaxLength").Count() > 0)
                        {
                            controle.SetPropertyValue("MaxLength", nud.Value.ToInt32());
                            controleOriginal.SetPropertyValue("MaxLength", nud.Value.ToInt32());
                            objComp.objConfigCompUsu.nMaxLength = nud.Value.ToInt32();
                        }
                    }
                    else if (nud.Parent == nudComprimento)
                    {
                        objComp.objConfigCompUsu.iTamanhoComponente = nud.Value.ToInt32();
                        controle.SetPropertyValue("_TamanhoComponente", nud.Value.ToInt32());
                        controleOriginal.SetPropertyValue("_TamanhoComponente", nud.Value.ToInt32());
                    }
                }
                else if (objSender.GetType() == typeof(GroupBox))
                {
                    ListBox lst = (sender as ListBox);

                    if (lst.Items.Count > 0)
                    {
                        (controle as HLP_Pesquisa)._ListaCamposDisplay = new List<string>();
                        foreach (string item in lst.Items)
                        {
                            (controle as HLP_Pesquisa)._ListaCamposDisplay.Add(item);
                        }
                        (controleOriginal as HLP_Pesquisa)._ListaCamposDisplay = (controle as HLP_Pesquisa)._ListaCamposDisplay;
                    }
                }

                objComp.objConfigCompUsu.stEnabled = chkEnabled.Checked.ToByte();
                controle.Enabled = chkEnabled.Checked;
                controleOriginal.Enabled = chkEnabled.Checked;

                objComp.objConfigCompUsu.stVisible = chkVisible.Checked.ToByte();
                controle.Visible = chkVisible.Checked;
                controleOriginal.Visible = chkVisible.Checked;

                nudComprimento._ValueChanged -= Componentes__TextChanged;
                nudComprimento.Value = controle.GetPropertyValue("_TamanhoComponente").ToInt32();
                nudComprimento._ValueChanged += Componentes__TextChanged;
                objComp.objConfigCompUsu.iTamanhoComponente = nudComprimento.Value.ToInt32();

                //foreach (PropertyInfo pi in controle.GetType().GetProperties())
                //{
                //    if (pi.CanWrite)
                //    {
                //        if (lProperty.Contains(pi.Name))
                //            pi.SetValue(controleOriginal, pi.GetValue(controle, null), null);
                //    }
                //}
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }


    }
}