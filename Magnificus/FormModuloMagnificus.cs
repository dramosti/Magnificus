using System;
using System.Collections.Generic;
using System.Configuration;
using System.Deployment.Application;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using HLP.Comum.Infrastructure;
using HLP.Comum.Messages;
using HLP.Comum.Models;

using HLP.Comum.Modules;
using HLP.Comum.Modules.Infrastructure;
using HLP.Comum.Modules.Interface;
using HLP.Comum.UI.Exception;
using HLP.Comum.Ws;
using System.Reflection;
using System.Diagnostics;
using System.Drawing;
using Microsoft.Win32;
using HLP.Services.Implementation.Entries.Gerais;
using HLP.Comum.Infrastructure.Static;

namespace Magnificus
{
    public partial class FormModuloMagnificus : FormBaseModulo, IFormPrincipal
    {
        List<KryptonButton> listBotoesLaterais = new List<KryptonButton>();
        Modulo modulo = new Modulo();
        UserBasicConfigModel userBasicConfig = new UserBasicConfigModel();
        ApplicationDeployment ad;
        FormInformacao frm = null;
        MethodInfo setStatusBar = null;
        object[] mParam = null;
        bool bLoad = true;
        private int _cacheWidth;
        private bool bTxtPesquisaFocado = false;



        #region Implementacao do IFormModulo



        public MenuStrip MenuPrincipal
        {
            get
            {
                return this.menuPrincipal;
            }
        }

        public KryptonSplitContainer ContainerTela
        {
            get
            {
                return this.splitContainerTela;
            }
        }

        public KryptonHeaderGroup HeaderGroup
        {
            get
            {
                return headerMenuLateral;
            }

        }

        public KryptonPanel MenuLateral
        {
            get { return this.panelHeader; }
        }

        public ContextMenuStrip MenuContexto
        {
            get { return null; }
        }


        #endregion

        #region Implementacao do IFormPrincipal
        public StatusStrip BarraStatus
        {
            get { return this.statusPrincipal; }
        }

        public void EscondeMenuIcones(ToolStrip menuIcones)
        {
            menuIcones.Visible = false;
            Control[] controls = this.Controls.Find(menuIcones.Name, true);
            foreach (Control control in controls)
            {
                control.Visible = false;
            }
        }

        public void IntegrarMenuIcones(ToolStrip menuIcones)
        {
            //menuIcones.Visible = true;
            //Control[] controls = this.Controls.Find(menuIcones.Name, true);
            //if (controls.Length == 0)
            //{
            //    this.toolStripPanelTopo.Controls.Add(menuIcones);
            //}
            //else
            //{
            //    foreach (Control control in controls)
            //    {
            //        control.Visible = true;
            //    }
            //}
        }

        #endregion


        public FormModuloMagnificus()
            : base()
        {
            InitializeComponent();

            this.IsMdiContainer = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            if (File.Exists(UserData.xPathBasicConfig))
            {
                userBasicConfig = SerializeClassToXml.DeserializeClasse<UserBasicConfigModel>(UserData.xPathBasicConfig);
            }
            BuscaVisual();
        }

        private void FormModuloMagnificus_Load(object sender, EventArgs e)
        {
            try
            {
                Util.TextBoxEx.SetWatermark(this.txtPesquisaForm.TextBox, "Pesquisar Telas");
                this.Text = "Magnificus - " + CompanyData.xFantasia;

                Favoritos.NodeMouseDoubleClick += new TreeNodeMouseClickEventHandler(modulo.nodeItem_Click);
                treeViewPesquisa.NodeMouseDoubleClick += new TreeNodeMouseClickEventHandler(modulo.nodeItem_Click);
                Favoritos.KeyDown += new KeyEventHandler(modulo.NodeEnter_KeyDown);
                treeViewPesquisa.KeyDown += new KeyEventHandler(modulo.NodeEnter_KeyDown);

                AdicionaContextMenuTreeView(panelHeader.Controls);
                AdicionaCrumbTreeView(panelHeader.Controls);
                SetaEventoeImagemMenuLateral();
                CarregaListaBotoesModulos();
                if (File.Exists(UserData.xPathBasicConfig))
                {
                    userBasicConfig = SerializeClassToXml.DeserializeClasse<UserBasicConfigModel>(UserData.xPathBasicConfig);
                }
                else
                {
                    foreach (KryptonButton btn in listBotoesLaterais)
                    {
                        userBasicConfig.ModulosAtivos.Add(btn.Text);
                    }
                    foreach (ToolStripItem item in statusPrincipal.Items)
                    {
                        if (item.Tag != null)
                        {
                            if (item.Tag.ToString() != "")
                            {
                                userBasicConfig.BarraStatus.Add(item.Tag.ToString());
                            }
                        }
                    }
                    SaveConfigUser();
                }
                CarregaContextMenu();
                ConfiguraMenu();

                this.headerMenuLateral.Panel.Controls.Remove(kryptonHeader1);
                this.headerMenuLateral.Panel.Controls.Add(kryptonHeader1);
                PopulaToolstrip();

                ConnectionStringSettings conSettings = ConfigurationManager.ConnectionStrings["dbPrincipal"];
                lblBase.Text = conSettings.ConnectionString.Split(';')[1].Replace("Initial Catalog=", "").Trim();
                tslblEmpresa.Text = CompanyData.idEmpresa + "-" + CompanyData.xFantasia;
                tslblUsuario.Text = UserData.xNome;
                tslblAtualizacao.Image = Properties.Resources.AtualizacaoImg;
                tslblAtualizacao.Visible = UserData.idUser == UserData.idUserHLP;
                if (System.Diagnostics.Debugger.IsAttached)
                {
                    lblVersao.Text = "Debug";
                }
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
                this.Close();
            }
        }


        #region Atualizacao
        private void popup_MouseClick(object sender, MouseEventArgs e)
        {
            ad.Update();
            KryptonMessageBox.Show("Atualização realizada com sucesso. O sistema será reiniciado", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Restart();
        }
        private void Atualizacao()
        {

            UpdateCheckInfo info = null;
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                frm = null;
                try
                {
                    info = ad.CheckForDetailedUpdate();
                }
                catch (DeploymentDownloadException dde)
                {
                    return;
                }
                catch (InvalidDeploymentException ide)
                {
                    return;
                }
                catch (InvalidOperationException ioe)
                {
                    MessageBox.Show("This application cannot be updated. It is likely not a ClickOnce application. Error: " + ioe.Message);
                    return;
                }

                if (info.UpdateAvailable)
                {
                    if (!info.IsUpdateRequired)
                    {
                        frm = new FormInformacao("Atualização", "A versão " + info.AvailableVersion.ToString() + " já está disponível!" + Environment.NewLine +
                        "Clique aqui para Atualizar e Aguarde!");
                        frm.MouseClick += new MouseEventHandler(popup_MouseClick);
                        frm.lblAviso.MouseClick += new MouseEventHandler(popup_MouseClick);
                        frm.ShowDialog();
                    }
                    else
                    {
                        // Display a message that the app MUST reboot. Display the minimum required version.
                        MessageBox.Show("This application has detected a mandatory update from your current " +
                            "version to version " + info.MinimumRequiredVersion.ToString() +
                            ". The application will now install the update and restart.",
                            "Update Available", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
        }
        #endregion

        #region Menu
        private void menuPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                //Se o item não tem nome ou não e um MenuItem ou tem filhos nao faz nada
                if ((String.IsNullOrEmpty(e.ClickedItem.Name)) ||
                    (e.ClickedItem is ToolStripMenuItem) ||
                    ((e.ClickedItem as ToolStripMenuItem).DropDownItems.Count > 0))
                {
                    return;
                }
                //Retira no nome do item o nome da classe
                int index = e.ClickedItem.Name.ToLower().IndexOf(e.ClickedItem.GetType().Name.ToLower());
                string nomeItem;
                if (index > -1)
                {
                    nomeItem = e.ClickedItem.Name.Substring(0, index);
                }
                else
                {
                    nomeItem = e.ClickedItem.Name;
                }

                TipoExibeForm exibeForm = TipoExibeForm.Normal;
                //Tenta transformar a tag no tipo de exibicao
                System.Enum.TryParse<TipoExibeForm>(e.ClickedItem.Tag.ToString(), out exibeForm);
                //Manda o form ser criado e exibido
                this.ExibirForm(nomeItem, exibeForm);
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }
        public void ExibirForm(string nome, TipoExibeForm exibeForm)
        {
            Form form = new Form();
            try
            {
                form = Contexto.GetServico<Form>(nome);
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
                return;
            }
            if (form == null) { return; }

            if (exibeForm == TipoExibeForm.Modal)
            {
                form.ShowDialog();
            }
            else
            {
                form.MdiParent = this as Form;
                form.Show();
            }
        }
        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            tslblEmpresa.Visible = false;
            tslblUsuario.Visible = false;

            //frmLogin objLogin = new frmLogin();
            //objLogin.ShowDialog();
            //PopulaToolstrip();
        }
        private void tsFecharTodas_Click(object sender, EventArgs e)
        {
            splitContainerTela.Panel2.Controls.Clear();
        }
        private void btnMudarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                //splitContainerTela.Panel2.Controls.Clear();
                //frmLogin objfrmLogin = new frmLogin();
                //objfrmLogin.ShowDialog();
                //PopulaToolstrip();
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }
        #endregion

        #region ConfigMenus
        private void mnSuperior_Click(object sender, EventArgs e)
        {
            userBasicConfig.tpMenu = UserBasicConfigModel.TipoMenu.Top;
            SaveConfigUser();
            ConfiguraMenu();
        }
        private void msLateral_Click(object sender, EventArgs e)
        {
            userBasicConfig.tpMenu = UserBasicConfigModel.TipoMenu.Lateral;
            SaveConfigUser();
            ConfiguraMenu();
        }
        private void mnRecolher_Click(object sender, EventArgs e)
        {
            userBasicConfig.RecolheMenuLateral = mnRecolher.Checked;
            SaveConfigUser();
        }
        private void ConfiguraMenu()
        {
            try
            {
                if (userBasicConfig.tpMenu == UserBasicConfigModel.TipoMenu.Lateral)
                {
                    mnLateral.Checked = true;
                    mnSuperior.Checked = false;
                }
                else
                {
                    mnLateral.Checked = false;
                    mnSuperior.Checked = true;
                }
                mnRecolher.Checked = userBasicConfig.RecolheMenuLateral;
                this.menuPrincipal.Items.Remove(tsMudarUsuario);
                this.menuPrincipal.Items.Remove(tsJanelas);
                this.menuPrincipal.Items.Remove(tsVisual);
                this.menuPrincipal.Items.Remove(tsLocal);


                if (mnSuperior.Checked)
                {
                    for (int i = 0; i < menuPrincipal.Items.Count; i++)
                    {
                        menuPrincipal.Items[i].Visible = true;
                    }
                    splitContainerTela.Panel1Collapsed = true;
                }
                else
                {
                    for (int i = 0; i < menuPrincipal.Items.Count; i++)
                    {
                        menuPrincipal.Items[i].Visible = false;
                    }
                    splitContainerTela.Panel1Collapsed = false;

                }

                this.menuPrincipal.Items.Add(tsMudarUsuario);
                this.menuPrincipal.Items.Add(tsJanelas);
                this.menuPrincipal.Items.Add(tsVisual);
                this.menuPrincipal.Items.Add(tsLocal);
            }
            catch (Exception ex_)
            {
                KryptonMessageBox.Show(null, string.Format(Mensagens.Exception, Environment.NewLine) + (ex_.InnerException != null ? ex_.InnerException.Message : ex_.Message).ToString(), "MAGNIFICUS - AVISO ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void SetaEventoeImagemMenuLateral()
        {

            foreach (Control item in headerMenuLateral.Panel.Controls)
            {
                if (item.GetType() == typeof(KryptonButton))
                {
                    if (item.Text == "Relatórios")
                    {
                        item.Click += new EventHandler(BotaoModulo_Click);
                        ((KryptonButton)item).Values.Image = Magnificus.Properties.Resources.crystal;
                    }
                    else if (item.Text == "Cadastros")
                    {
                        item.Click += new EventHandler(BotaoModulo_Click);
                        ((KryptonButton)item).Values.Image = Magnificus.Properties.Resources.Cadastro;
                    }
                    else if (item.Text == "Utilitarios")
                    {
                        item.Click += new EventHandler(BotaoModulo_Click);
                        ((KryptonButton)item).Values.Image = Magnificus.Properties.Resources.Utilitario;
                    }
                    else if (item.Text == "Abastecimento")
                    {
                        item.Click += new EventHandler(BotaoModulo_Click);
                        ((KryptonButton)item).Values.Image = Magnificus.Properties.Resources.Box5;
                    }
                    else if (item.Text == "Produção")
                    {
                        item.Click += new EventHandler(BotaoModulo_Click);
                        ((KryptonButton)item).Values.Image = Magnificus.Properties.Resources.Producao;
                    }
                    else if (item.Text == "Comercial")
                    {
                        item.Click += new EventHandler(BotaoModulo_Click);
                        ((KryptonButton)item).Values.Image = Magnificus.Properties.Resources.Comercial;
                    }
                }
            }
        }

        #endregion

        #region VisualForm
        private void tsSkin_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem ts = sender as ToolStripMenuItem;

            tsAzul.Checked = false;
            tsPrata.Checked = false;

            if (ts.Text.Equals("Azul"))
            {
                ts.Checked = true;
                kryptonManager1.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
            }
            else if (ts.Text.Equals("Prata"))
            {
                ts.Checked = true;
                kryptonManager1.GlobalPaletteMode = PaletteModeManager.Office2010Silver;
            }

            userBasicConfig.xSkin = kryptonManager1.GlobalPaletteMode.ToString();
            SaveConfigUser();

        }
        private void tsSkin(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void BuscaVisual()
        {
            switch (userBasicConfig.xSkin)
            {
                case "Office2010Blue":
                    kryptonManager1.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
                    tsPrata.Checked = false;
                    tsAzul.Checked = true;
                    break;

                case "Office2010Silver":
                    kryptonManager1.GlobalPaletteMode = PaletteModeManager.Office2010Silver;
                    tsPrata.Checked = true;
                    tsAzul.Checked = false;
                    break;

            }
        }
        #endregion

        #region Aba Favoritos
        private void cmAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripMenuItem tsm = (ToolStripMenuItem)sender;
                ContextMenuStrip cm = (ContextMenuStrip)tsm.Owner;

                KryptonTreeView tview = (KryptonTreeView)cm.SourceControl;
                if (tview.SelectedNode != null)
                {
                    TreeNode node = (TreeNode)tview.SelectedNode.Clone();
                    InsereNode(node);
                }
                SaveConfigUser();
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }
        private void cmRemove_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripMenuItem tsm = (ToolStripMenuItem)sender;
                ContextMenuStrip cm = (ContextMenuStrip)tsm.Owner;

                KryptonTreeView tview = (KryptonTreeView)cm.SourceControl;
                if (tview.SelectedNode != null)
                {
                    Favoritos.Nodes.Remove(tview.SelectedNode);
                }
                SaveConfigUser();
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }
        private void AdicionaContextMenuTreeView(Control.ControlCollection pane)
        {
            foreach (Control ctr in pane)
            {
                if (ctr.GetType() == typeof(KryptonTreeView))
                {
                    if (ctr.Name != "Favoritos")
                    {
                        ctr.ContextMenuStrip = cmFavoritos;
                        if (userBasicConfig.Favoritos.Count > 0)
                        {
                            ProcuraNodesConfigurados((KryptonTreeView)ctr);
                        }
                    }
                    else
                    {
                        ctr.ContextMenuStrip = cmRemover;
                    }
                }
            }
        }

        private void AdicionaCrumbTreeView(Control.ControlCollection pane)
        {
            kryptonBreadCrumb1.RootItem.Items.Clear();
            foreach (Control ctr in pane)
            {
                if (ctr.GetType() == typeof(KryptonTreeView) && ctr.Visible)
                {
                    kryptonBreadCrumb1.RootItem.ShortText = ctr.Name;

                    ((KryptonTreeView)ctr).AfterSelect -= new TreeViewEventHandler(TreeView_AfterSelect);
                    ((KryptonTreeView)ctr).AfterSelect += new TreeViewEventHandler(TreeView_AfterSelect);
                    foreach (TreeNode item in ((KryptonTreeView)ctr).Nodes)
                    {
                        KryptonBreadCrumbItem i = new KryptonBreadCrumbItem();
                        MontaCrumbModulo(item, i);
                        kryptonBreadCrumb1.RootItem.Items.Add(i);
                    }
                    kryptonBreadCrumb1.SelectedItem = kryptonBreadCrumb1.RootItem;
                    if (((KryptonTreeView)ctr).Nodes.Count > 0)
                    {
                        ((KryptonTreeView)ctr).SelectedNode = ((KryptonTreeView)ctr).Nodes[0];
                        ((KryptonTreeView)ctr).Focus();
                    }
                    break;
                }
            }

        }
        private void kryptonBreadCrumb1_SelectedItemChanged(object sender, EventArgs e)
        {
            if (kryptonBreadCrumb1.SelectedItem != null)
            {
                Stack<int> indexes = new Stack<int>();
                KryptonBreadCrumbItem crumb = kryptonBreadCrumb1.SelectedItem;
                while (crumb.Parent != null)
                {
                    indexes.Push(crumb.Parent.Items.IndexOf(crumb));
                    crumb = crumb.Parent;
                }
                if (indexes.Count > 0)
                {
                    KryptonTreeView tv = null;
                    foreach (Control ctr in panelHeader.Controls)
                    {
                        if (ctr.GetType() == typeof(KryptonTreeView) && ctr != treeViewPesquisa)
                        {
                            if (ctr.Visible)
                            {
                                tv = ((KryptonTreeView)ctr);
                            }
                        }
                    }
                    if (tv != null)
                    {
                        int i = indexes.Pop();
                        TreeNode node = tv.Nodes[i];
                        while (indexes.Count > 0)
                        {
                            i = indexes.Pop();
                            node = node.Nodes[i];
                        }
                        tv.SelectedNode = node;
                        //if (tsJanelas.DropDownItems.Count > 1)
                        //{
                        //    foreach (ToolStripItem item in tsJanelas.DropDownItems)
                        //    {
                        //        if (item.Text == node.Text)
                        //        {
                        //            item.PerformClick();
                        //            break;
                        //        }
                        //    }

                        //}
                    }
                }
            }
        }
        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Stack<int> indexes = new Stack<int>();
            TreeNode node = e.Node;
            bool bParent = false;
            int i = 0;

            while (node.Parent != null)
            {
                i = node.Parent.Index;
                indexes.Push(node.Index);
                node = node.Parent;
                bParent = true;
            }

            KryptonBreadCrumbItem crumb = null;
            if (bParent)
            {
                crumb = kryptonBreadCrumb1.RootItem.Items[i];
            }
            else
            {
                crumb = kryptonBreadCrumb1.RootItem.Items[node.Index];
            }
            while (indexes.Count > 0)
                crumb = crumb.Items[indexes.Pop()];

            kryptonBreadCrumb1.SelectedItem = crumb;

        }

        private void MontaCrumbModulo(TreeNode node, KryptonBreadCrumbItem item)
        {
            item.ShortText = node.Text;

            foreach (TreeNode n in node.Nodes)
            {
                KryptonBreadCrumbItem itemFilho = new KryptonBreadCrumbItem();
                itemFilho.ShortText = n.Text;
                item.Items.Add(itemFilho);
                MontaCrumbModulo(n, itemFilho);

            }
        }

        private void InsereNode(TreeNode node)
        {
            try
            {
                if (node.Nodes.Count > 0)
                {
                    foreach (TreeNode nodeFilho in node.Nodes)
                    {
                        InsereNode(nodeFilho);
                    }
                }
                else
                {
                    if (Favoritos.Nodes.Find(node.Name, true).Count() == 0)
                    {
                        node.ImageIndex = 0;
                        node.SelectedImageIndex = 0;
                        Favoritos.Nodes.Add(node);
                        if (!userBasicConfig.Favoritos.Contains(node.Text))
                        {
                            userBasicConfig.Favoritos.Add(node.Text);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void ProcuraNodesConfigurados(KryptonTreeView tView)
        {
            try
            {
                if (tView.Nodes.Count > 0)
                {
                    foreach (TreeNode nodeFilho in tView.Nodes)
                    {
                        AdicionaNode(nodeFilho);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void AdicionaNode(TreeNode node)
        {
            try
            {
                if (node.Nodes.Count > 0)
                {
                    foreach (TreeNode nodeFilho in node.Nodes)
                    {
                        AdicionaNode(nodeFilho);
                    }
                }
                else
                {
                    if (userBasicConfig.Favoritos.Contains(node.Text))
                    {
                        TreeNode nodeAdd = (TreeNode)node.Clone();
                        InsereNode(nodeAdd);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Menu Lateral
        private void btnMinimiza_Click(object sender, EventArgs e)
        {
            if (bLoad)
            {
                splitContainerTela.FixedPanel = FixedPanel.None;
                bLoad = false;
            }
            splitContainerTela.SuspendLayout();
            if (splitContainerTela.FixedPanel == FixedPanel.None)
            {
                splitContainerTela.FixedPanel = FixedPanel.Panel1;
                splitContainerTela.IsSplitterFixed = true;

                _cacheWidth = headerMenuLateral.Width;
                int newWidth = headerMenuLateral.PreferredSize.Height;

                splitContainerTela.Panel1MinSize = newWidth;
                splitContainerTela.SplitterDistance = newWidth;

                headerMenuLateral.HeaderPositionPrimary = VisualOrientation.Right;
                headerMenuLateral.ButtonSpecs[0].Edge = PaletteRelativeEdgeAlign.Near;


                for (int i = 0; i < splitContainerTela.Panel1.Controls.Count; i++)
                {
                    if (splitContainerTela.Panel1.Controls[i].GetType() == typeof(KryptonButton) || splitContainerTela.Panel1.Controls[i].GetType() == typeof(KryptonSeparator))
                    {
                        splitContainerTela.Panel1.Controls[i].Visible = false;
                    }
                    else if (splitContainerTela.Panel1.Controls[i].GetType() == typeof(KryptonTextBox))
                    {
                        splitContainerTela.Panel1.Controls[i].Visible = false;
                    }
                    else if (splitContainerTela.Panel1.Controls[i].GetType() == typeof(KryptonHeader))
                    {
                        splitContainerTela.Panel1.Controls[i].Visible = false;
                    }
                }
            }
            else
            {
                splitContainerTela.FixedPanel = FixedPanel.None;
                splitContainerTela.IsSplitterFixed = false;
                splitContainerTela.Panel1MinSize = 25;
                splitContainerTela.SplitterDistance = _cacheWidth;

                headerMenuLateral.HeaderPositionPrimary = VisualOrientation.Top;
                headerMenuLateral.ButtonSpecs[0].Edge = PaletteRelativeEdgeAlign.Far;


                for (int i = 0; i < splitContainerTela.Panel1.Controls.Count; i++)
                {

                    if (splitContainerTela.Panel1.Controls[i].GetType() == typeof(KryptonButton))
                    {
                        KryptonButton btn = (KryptonButton)splitContainerTela.Panel1.Controls[i];
                        if (btn.Name == "btnFavoritos")
                        {
                            btn.Visible = true;
                        }
                        else
                        {
                            btn.Visible = userBasicConfig.ModulosAtivos.Where(c => c == btn.Text).Count() > 0 ? true : false;
                        }
                    }
                    else if (splitContainerTela.Panel1.Controls[i].GetType() == typeof(KryptonSeparator))
                    {
                        splitContainerTela.Panel1.Controls[i].Visible = true;
                    }
                    else if (splitContainerTela.Panel1.Controls[i].GetType() == typeof(KryptonTextBox))
                    {
                        splitContainerTela.Panel1.Controls[i].Visible = true;
                    }
                    else if (splitContainerTela.Panel1.Controls[i].GetType() == typeof(KryptonHeader))
                    {
                        splitContainerTela.Panel1.Controls[i].Visible = true;
                    }
                }

            }
            splitContainerTela.ResumeLayout();
        }
        private void BotaoModulo_Click(object sender, EventArgs e) // a TreeView ja esta carregada... aqui só exibe?
        {
            KryptonButton btn = (KryptonButton)sender;
            foreach (Control ctr in panelHeader.Controls)
            {
                if (ctr.GetType() == typeof(KryptonTreeView))
                {
                    if (ctr.Name == btn.Text)
                    {
                        ctr.Visible = true;
                        ctr.BringToFront();
                        headerMenuLateral.Text = btn.Text;
                        headerMenuLateral.ValuesPrimary.Image = btn.Values.Image;
                        txtPesquisaForm.Text = "";
                    }
                    else
                    {
                        ctr.Visible = false;
                    }
                }
            }
            AdicionaCrumbTreeView(panelHeader.Controls);
        }
        private void splitContainerTela_Panel2_ControlRemoved(object sender, ControlEventArgs e)
        {
            tsJanelas.DropDownItems.Remove(tsJanelas.DropDownItems[((Form)e.Control).Name]);
        }
        private void txtPesquisaForm_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPesquisaForm.Text != "")
                {
                    treeViewPesquisa.Nodes.Clear();
                    foreach (Control ctr in panelHeader.Controls)
                    {
                        if (ctr.GetType() == typeof(KryptonTreeView))
                        {
                            KryptonTreeView tv = (KryptonTreeView)ctr;
                            if (tv.Name != "Favoritos" && tv.Name != "treeViewPesquisa")
                            {
                                foreach (TreeNode node in tv.Nodes)
                                {
                                    BuscaNodePesquisa(node);
                                }
                            }
                        }
                    }
                }
                else
                {
                    treeViewPesquisa.Nodes.Clear();
                }
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }
        private void specs_Click(object sender, EventArgs e)
        {
            try
            {
                if ((sender as ButtonSpec).Tag.ToString() == "specModulos")
                {
                    cmModulos.Show(Control.MousePosition.X, Control.MousePosition.Y);
                    VerificaBotoesAtivos();
                }
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }
        private void frmCalendario_FormClosing(object sender, FormClosingEventArgs e)
        {
            BuscaLembrete();
        }
        private void BuscaNodePesquisa(TreeNode node)
        {
            try
            {
                if (node.Nodes.Count > 0)
                {
                    foreach (TreeNode nodeFilho in node.Nodes)
                    {
                        BuscaNodePesquisa(nodeFilho);
                    }
                }
                else
                {
                    if (node.Text.ToUpper().Contains(txtPesquisaForm.Text.ToUpper()))
                    {
                        TreeNode NodeCopy = (TreeNode)node.Clone();
                        headerMenuLateral.Text = "Pesquisa";
                        headerMenuLateral.ValuesPrimary.Image = Magnificus.Properties.Resources.Pesquisar;
                        treeViewPesquisa.Nodes.Add(NodeCopy);
                        treeViewPesquisa.Visible = true;
                        treeViewPesquisa.BringToFront();
                    }
                }
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }
        private void CarregaContextMenu()
        {
            ToolStripMenuItem td = null;
            foreach (KryptonButton btn in listBotoesLaterais)
            {
                if (userBasicConfig.ModulosAtivos.Contains(btn.Text))
                {
                    btn.Visible = true;
                }
                else
                {
                    btn.Visible = false;
                }
                td = new ToolStripMenuItem();
                td.Text = btn.Text;
                td.Font = tsmBotoes.Font;
                td.Image = btn.Values.Image;
                tsmBotoes.DropDownItems.Add(td);
            }
            VerificaBotoesAtivos();
            Favoritos.BringToFront();


            foreach (ToolStripItem item in statusPrincipal.Items)
            {
                if (item.Tag != null)
                {
                    if (item.Tag.ToString() != "")
                    {
                        if (userBasicConfig.BarraStatus.Contains(item.Tag.ToString()))
                        {
                            item.Visible = true;
                        }
                        else
                        {
                            item.Visible = false;
                        }
                        td = new ToolStripMenuItem();
                        td.Text = item.Tag.ToString();
                        td.Font = tsmBarraStatus.Font;
                        tsmBarraStatus.DropDownItems.Add(td);
                        ((ToolStripMenuItem)tsmBarraStatus.DropDownItems[tsmBarraStatus.DropDownItems.Count - 1]).Checked = item.Visible;
                    }
                }
            }

        }
        private void CarregaListaBotoesModulos()
        {
            foreach (object obj in this.headerMenuLateral.Panel.Controls)
            {
                if (obj.GetType() == typeof(KryptonButton))
                {
                    KryptonButton btn = obj as KryptonButton;
                    if (btn.Name != "btnFavoritos")
                    {
                        listBotoesLaterais.Add(btn);
                    }
                }
            }
        }
        private void VerificaBotoesAtivos()
        {
            foreach (ToolStripMenuItem item in tsmBotoes.DropDownItems)
            {
                item.Checked = userBasicConfig.ModulosAtivos.Contains(item.Text);// listBotoesLaterais.FirstOrDefault(c => c.Text == item.Text).Visible;
            }
        }
        private void PopulaToolstrip()
        {
            tslblEmpresa.Text = CompanyData.idEmpresa + " - " + CompanyData.xFantasia;
            tslblUsuario.Text = UserData.idUser + " - " + UserData.xNome;

        }
        private void BuscaLembrete()
        {
            if (userBasicConfig.Lembretes.Where(c => c.dtLembrete.Date == DateTime.Today).Count() > 0)
            {
                lblLembrete.Text = "Há Lembrete para Hoje";
                if (frm != null)
                {
                    if (frm.Visible)
                    {
                        frm.Close();
                    }
                }
                frm = new FormInformacao("Lembrete", "Você tem um Lembrete marcado para Hoje!");
                frm.Show();
            }
            else
            {
                lblLembrete.Text = "";
            }
        }
        private void barraDeStatusToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                ToolStripMenuItem item = e.ClickedItem as ToolStripMenuItem;
                item.Checked = !item.Checked;
                foreach (ToolStripItem ts in statusPrincipal.Items)
                {
                    if (ts.Tag != null)
                    {
                        if (ts.Tag.ToString() == item.Text)
                        {
                            ts.Visible = !ts.Visible;
                            break;
                        }
                    }
                }
                // objIsolated.SalvarConfiguracaoBarraStatus(statusPrincipal.Items);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void FormModuloMagnificus_Shown(object sender, EventArgs e)
        {
            BuscaLembrete();
            this.txtPesquisaForm.TextBox.Focus();
        }
        private void btnLimpaPesquisa_Click(object sender, EventArgs e)
        {
            try
            {
                txtPesquisaForm.Text = "";
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }
        private void tsmBarraStatus_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                ToolStripMenuItem item = e.ClickedItem as ToolStripMenuItem;
                item.Checked = !item.Checked;
                foreach (ToolStripItem ts in statusPrincipal.Items)
                {
                    if (ts.Tag != null)
                    {
                        if (ts.Tag.ToString() == item.Text)
                        {
                            ts.Visible = !ts.Visible;
                            break;
                        }
                    }
                }
                foreach (ToolStripItem tsitem in statusPrincipal.Items)
                {
                    if (tsitem.Visible && tsitem.Tag != null)
                    {
                        if (!userBasicConfig.BarraStatus.Contains(tsitem.Tag.ToString()))
                            userBasicConfig.BarraStatus.Add(tsitem.Tag.ToString());
                    }
                    else if (tsitem.Tag != null)
                    {
                        userBasicConfig.BarraStatus.Remove(tsitem.Tag.ToString());
                    }
                }
                SaveConfigUser();
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }
        private void tsmBotoes_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                ToolStripMenuItem item = e.ClickedItem as ToolStripMenuItem;
                if (!item.Checked)
                {
                    userBasicConfig.ModulosAtivos.Add(item.Text);
                    listBotoesLaterais.FirstOrDefault(c => c.Text == item.Text).Visible = true;
                }
                else
                {
                    userBasicConfig.ModulosAtivos.Remove(item.Text);
                    listBotoesLaterais.FirstOrDefault(c => c.Text == item.Text).Visible = false;
                }
                BotaoModulo_Click(btnFavoritos, e);
                SaveConfigUser();


            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }
        #endregion


        private void SaveConfigUser()
        {
            SerializeClassToXml.SerializeClasse(userBasicConfig, UserData.xPathBasicConfig);
        }

        private void splitContainerTela_Panel2_ControlAdded(object sender, ControlEventArgs e)
        {
            if (userBasicConfig.RecolheMenuLateral)
            {
                if (headerMenuLateral.HeaderPositionPrimary == VisualOrientation.Top)
                {
                    btnMinimiza.PerformClick();
                }
            }
        }

        private void localDeInstalaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HLPMessageBox.ShowAviso(Application.StartupPath);
        }

        private void FormModuloMagnificus_FormClosed(object sender, FormClosedEventArgs e)
        {
            ControleAcessoService.InsereControleAcesso(false);
        }

        private void tslblAtualizacao_Click(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("SystemTray").Count() == 0)
            {
                Process p = new Process();
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = Pastas.CaminhoPadraoRegWindows +
                    @"\magnificus\hlptray\SystemTray.exe";
                psi.Arguments = UserData.xNome;
                p.StartInfo = psi;
                try
                {
                    p.Start();
                }
                catch (Exception ex)
                {
                    if (ex.Message == "A operação foi cancelada pelo usuário")
                        MessageBox.Show("Operação cancelada pelo usuário", "Atenção",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        throw ex;
                }
            }
            else
            {
                MessageBox.Show("Aplicativo de atualização Magnificus já está aberto.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void FormModuloMagnificus_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPesquisaForm.Focused)
            {
                return;
            }

            if (bTxtPesquisaFocado)
            {
                if (e.KeyCode == Keys.Tab)
                {
                    if (treeViewPesquisa.Nodes.Count > 0)
                    {
                        treeViewPesquisa.Focus();
                        bTxtPesquisaFocado = false;
                    }
                    else if (Favoritos.Nodes.Count > 0)
                    {
                        Favoritos.Focus();
                        bTxtPesquisaFocado = false;
                    }
                }
            }
        }

        private void txtPesquisaForm_Enter(object sender, EventArgs e)
        {
            bTxtPesquisaFocado = true;
        }
    }
}
