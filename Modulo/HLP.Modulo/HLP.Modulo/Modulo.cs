using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using HLP.Comum.Modules.Interface;
using HLP.Comum.Modules.Infrastructure;
using HLP.Comum.Models;
using HLP.Comum.Infrastructure;
using System.IO;
using System.Xml.Serialization;

namespace HLP.Comum.Modules
{
    public class Modulo : IModulo
    {
        private bool _bCarregaComponentes = true;

        public Modulo(string arquivoConfiguracao)
        {
            this.ArquivoConfiguracao = arquivoConfiguracao;
            this.NomeModulo = System.IO.Path.GetFileNameWithoutExtension(arquivoConfiguracao);
        }
        public Modulo()
        {}

        #region [Propriedades]

        public string NomeModulo { get; private set; }
        public string ArquivoConfiguracao { get; private set; }
        public IFormModulo FormModulo { get; private set; }
        #endregion

        #region [Métodos]

        #region [Métodos públicos]

        public void InicializarModulo()
        {
            try
            {
                Contexto.CarregaConfiguracao(this.NomeModulo, this.ArquivoConfiguracao);
                this.FormModulo = Contexto.GetServico<IFormModulo>(this.NomeModulo);
                this.FormModulo.Modulo = this;
                foreach (ToolStripMenuItem item in this.FormModulo.MenuPrincipal.Items)
                {
                    PercorreMenu(item);
                }
                IntegrarMenuModulo();
                intergrarMenuIcones();
            }
            catch (Exception ex)
            {
                new Exception(this.NomeModulo + " - " + this.ArquivoConfiguracao + " - " + ex.Message);
            }
        }

        private void PercorreMenu(ToolStripMenuItem itemMenu)
        {
            if (itemMenu.DropDownItems.Count > 0)
            {
                foreach (ToolStripMenuItem item in itemMenu.DropDownItems)
                {
                    PercorreMenu(item);
                }
            }
            OrdenaMenu(itemMenu);
        }

        public void InicializarModuloAcesso(TreeNode node)
        {
            Contexto.CarregaConfiguracao(this.NomeModulo, this.ArquivoConfiguracao);

            this.FormModulo = Contexto.GetServico<IFormModulo>(this.NomeModulo);
            this.FormModulo.Modulo = this;
            IntegrarMenuModuloAcesso(node);
        }

        public void DescarregarModulo()
        {
            GerenciadorModulo.Instancia.FormPrincipal.MenuPrincipal.Items[this.NomeModulo].Visible = false;
        }

        public void MenuModulo_Click(object sender, EventArgs e)
        {
            if (((sender) as ToolStripMenuItem).Checked)
            {
                InicializarModulo();
            }
            else
            {
                DescarregarModulo();
            }
        }

        public void ExibirForm(string nome, TipoExibeForm exibeForm)
        {
            GerenciadorModulo.Instancia.ExibirForm(nome, exibeForm);
        }

        #endregion
        #region [Metodos privados]

        private void setEventoClick(ToolStripMenuItem menuItem)
        {
            if (menuItem.DropDownItems.Count == 0)
            {
                if (menuItem.Tag == null)
                {
                    menuItem.Tag = TipoExibeForm.Normal;
                }

                string nomefisico = recuperaNomeForm(menuItem);
                //if (nomefisico != null)
                //{
                //    ((List<Formulario>)Collection.LIST_BELFORMULARIOS).Add(new Formulario
                //    {
                //        NomeFisico = nomefisico,
                //        NomeUser = menuItem.Text
                //    });

                //}

                menuItem.Click += new EventHandler(menuItem_Click);
                menuItem.ShortcutKeys = Keys.None;
                menuItem.ShowShortcutKeys = true;
                return;
            }
            foreach (ToolStripMenuItem item in menuItem.DropDownItems.OfType<ToolStripMenuItem>())
            {
                setEventoClick(item);
            }
        }


        private string recuperaNomeForm(ToolStripItem menuItem)
        {
            int index = menuItem.Name.ToLower().IndexOf("toolstrip");
            if (index > -1)
            {
                return menuItem.Name.Substring(0, index);
            }
            else
            {
                return menuItem.Name;
            }

        }

        private string recuperaNomeFormNode(TreeNode node)
        {
            int index = node.Name.ToLower().IndexOf("toolstrip");
            if (index > -1)
            {
                return node.Name.Substring(0, index);
            }
            else
            {
                return node.Name;
            }

        }



        private void intergrarMenuIcones()
        {
        }



        private void IntegrarMenuModulo()
        {
            if (GerenciadorModulo.Instancia.FormPrincipal.MenuPrincipal.Items.ContainsKey(this.NomeModulo))
            {
                GerenciadorModulo.Instancia.FormPrincipal.MenuPrincipal.Items[this.NomeModulo].Visible = true;
                return;
            }
            ToolStripMenuItem itemModulo = new ToolStripMenuItem
            {
                Text = this.NomeModulo.Insert(this.NomeModulo.Length - 1, "&"),
                ToolTipText = String.Format("Opções de menu do módulo {0}", this.NomeModulo),
                Name = this.NomeModulo,
                Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))
            };

            KryptonButton btnModulo = new KryptonButton();
            btnModulo.Text = this.NomeModulo;
            btnModulo.Dock = DockStyle.Bottom;
            btnModulo.ButtonStyle = ButtonStyle.NavigatorStack;
            btnModulo.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnModulo.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            btnModulo.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
             | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
             | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            btnModulo.Height = 30;


            TreeNode nodeModulo;
            KryptonTreeView tview = new KryptonTreeView();
            tview.StateCommon.Node.Content.ShortText.Color1 = System.Drawing.Color.Black;
            tview.StateCommon.Node.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tview.OverrideFocus.Node.Content.DrawFocus = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            tview.FullRowSelect = true;
            tview.BackStyle = PaletteBackStyle.PanelClient;
            tview.BorderStyle = PaletteBorderStyle.ContextMenuInner;
            tview.ItemStyle = ButtonStyle.ListItem;
            tview.Visible = false;
            tview.Name = this.NomeModulo;
            tview.Dock = DockStyle.Fill;
            tview.Scrollable = true;
            tview.ShowLines = false;
            // tview.ImageList = Collection.LIST_IMAGELIST_TREEVIEW;
            tview.KeyDown += new KeyEventHandler(NodeEnter_KeyDown);

            while (this.FormModulo.MenuPrincipal.Items.Count > 0)
            {
                removedItems = 0;
                ToolStripItem menuItem = this.FormModulo.MenuPrincipal.Items[0];

                nodeModulo = new TreeNode();

                MontaTreviewModulo(menuItem as ToolStripMenuItem, nodeModulo);
                if (nodeModulo.Nodes.Count == 0)
                {
                    if (nodeModulo.Tag != null)
                    {
                        tview.Nodes.Add(nodeModulo);
                    }
                }
                else
                {
                    tview.Nodes.Add(nodeModulo);
                }
                if (removedItems == (menuItem as ToolStripMenuItem).DropDownItems.OfType<ToolStripMenuItem>().Count())
                {
                    this.FormModulo.MenuPrincipal.Items.Remove(menuItem);
                }
                else
                {
                    setEventoClick(menuItem as ToolStripMenuItem);
                    menuItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    itemModulo.DropDownItems.Add(menuItem);
                }

            }
            if (tview.Nodes.Count > 0)
            {
                tview.NodeMouseDoubleClick += new TreeNodeMouseClickEventHandler(nodeItem_Click);
                GerenciadorModulo.Instancia.FormPrincipal.HeaderGroup.Panel.Controls.Add(btnModulo);
                tview.ExpandAll();
                GerenciadorModulo.Instancia.FormPrincipal.MenuLateral.Controls.Add(tview);
                GerenciadorModulo.Instancia.FormPrincipal.MenuPrincipal.Items.Add(itemModulo);
            }


        }
        int removedItems = 0;
        private void MontaTreviewModulo(ToolStripMenuItem menuItem, TreeNode node)
        {
            //ordenação de menus do toolstripmenu

            node.Text = menuItem.Text;
            node.Name = menuItem.Name;
            //if (menuItem.Image != null)
            //{
            //    Collection.LIST_IMAGELIST_TREEVIEW.Images.Add(menuItem.Image);
            //    node.ImageIndex = Collection.LIST_IMAGELIST_TREEVIEW.Images.Count - 1;
            //    node.SelectedImageIndex = Collection.LIST_IMAGELIST_TREEVIEW.Images.Count - 1;
            //}
            if (menuItem.DropDownItems.Count == 0)
            {
                if (menuItem.Tag == null)
                {
                    node.Tag = TipoExibeForm.Normal;
                }
                else if (menuItem.Tag.ToString().Equals("Modal"))
                {
                    node.Tag = TipoExibeForm.Modal;
                }
                return;
            }

            foreach (ToolStripMenuItem item in menuItem.DropDownItems.OfType<ToolStripMenuItem>().ToList())
            {
                if (item.Text != "FormNotificacao")
                {
                    TreeNode nodeFilho = new TreeNode();
                    //if (acesso != null)
                    //{
                    //  string nomeForm = recuperaNomeForm(item);
                    //HLP.Comum.Models.Formularios f = acesso.lFormularios.FirstOrDefault(C => C.Name == nomeForm);
                    //  if (f != null)
                    //  {
                    //      if (f.Acesso)
                    //      {
                    //          node.Nodes.Add(nodeFilho);
                    //      }
                    //      else
                    //      {
                    //          removedItems++;
                    //          item.GetCurrentParent().Items[item.Name].Visible = false;
                    //          item.GetCurrentParent().Items[item.Name].Enabled = false;
                    //      }
                    //  }
                    //  else
                    //  {
                    //      node.Nodes.Add(nodeFilho);
                    //  }

                    //}
                    //else
                    //{
                    //    node.Nodes.Add(nodeFilho);
                    //}
                    node.Nodes.Add(nodeFilho);
                    MontaTreviewModulo(item, nodeFilho);
                }
            }
        }

        private void OrdenaMenu(ToolStripMenuItem menuItem)
        {
            int posAtual = 0;
            int posAlt = posAtual + 1;
            int posLetra = 0;
            string menuAuxText = null;
            string menuAuxName = null;

            while (posAtual < menuItem.DropDownItems.Count - 1)
            {
                while (posAlt < menuItem.DropDownItems.Count)
                {
                    posLetra = 0;
                    while (true)
                    {
                        if (menuItem.DropDownItems[posAtual].Text[posLetra] == menuItem.DropDownItems[posAlt].Text[posLetra])
                        {
                            if (menuItem.DropDownItems[posAtual].Text.Count() == posLetra)
                            {
                                break;
                            }
                            else if (menuItem.DropDownItems[posAlt].Text.Count() == posLetra)
                            {
                                menuAuxText = menuItem.DropDownItems[posAtual].Text;
                                menuAuxName = menuItem.DropDownItems[posAtual].Name;
                                menuItem.DropDownItems[posAtual].Text = menuItem.DropDownItems[posAlt].Text;
                                menuItem.DropDownItems[posAtual].Name = menuItem.DropDownItems[posAlt].Name;
                                menuItem.DropDownItems[posAlt].Text = menuAuxText;
                                menuItem.DropDownItems[posAlt].Name = menuAuxName;
                            }
                            else
                            {
                                posLetra++;
                            }
                        }
                        else if (menuItem.DropDownItems[posAtual].Text[posLetra] > menuItem.DropDownItems[posAlt].Text[posLetra])
                        {
                            menuAuxText = menuItem.DropDownItems[posAtual].Text;
                            menuAuxName = menuItem.DropDownItems[posAtual].Name;
                            menuItem.DropDownItems[posAtual].Text = menuItem.DropDownItems[posAlt].Text;
                            menuItem.DropDownItems[posAtual].Name = menuItem.DropDownItems[posAlt].Name;
                            menuItem.DropDownItems[posAlt].Text = menuAuxText;
                            menuItem.DropDownItems[posAlt].Name = menuAuxName;
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                    posAlt++;
                }
                posAtual++;
                posAlt = posAtual + 1;
            }
        }

        private void IntegrarMenuModuloAcesso(TreeNode node)
        {

            TreeNode nodeModulo;
            foreach (var item in FormModulo.MenuPrincipal.Items)
            {
                nodeModulo = new TreeNode();

                MontaTreviewModuloAcesso(item as ToolStripMenuItem, nodeModulo);
                node.Nodes.Add(nodeModulo);//
            }

        }
        int index = 0;
        private void MontaTreviewModuloAcesso(ToolStripMenuItem menuItem, TreeNode node)
        {
            node.Text = menuItem.Text;
            node.Name = menuItem.Name;
            if (menuItem.Name.ToUpper().Contains("FORM"))
            {
                node.ImageIndex = 1;
                node.SelectedImageIndex = 1;

                index = node.Name.ToLower().IndexOf("toolstrip");
                if (index > -1)
                {
                    node.Name = node.Name.Substring(0, index);
                }
            }

            if (menuItem.DropDownItems.Count == 0)
            {
                return;
            }
            foreach (ToolStripMenuItem item in menuItem.DropDownItems.OfType<ToolStripMenuItem>())
            {
                if (item.Text != "FormNotificacao")
                {
                    TreeNode nodeFilho = new TreeNode();
                    node.Nodes.Add(nodeFilho);
                    MontaTreviewModuloAcesso(item, nodeFilho);
                }
            }
        }




        public List<string> MontaListFormularios() // Criado por mário 19/10 - Lista de Nome de todos os formulários...
        {
            List<string> lForms = new List<string>();
            ToolStripItemCollection CollectionForms = Contexto.GetServico<IFormModulo>(this.NomeModulo).MenuPrincipal.Items;
            int index = 0;

            foreach (var item in CollectionForms)
            {

                foreach (ToolStripMenuItem forms in (item as ToolStripMenuItem).DropDownItems.OfType<ToolStripMenuItem>())
                {
                    if (!forms.Name.Contains("FormNotificacao") && forms.Name.ToUpper().Contains("FORM"))
                    {
                        index = forms.Name.ToLower().IndexOf("toolstrip");
                        if (index > -1)
                        {
                            lForms.Add(forms.Name.Substring(0, index));
                        }
                    }
                }
            }
            return lForms;
        }


        public void NodeEnter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ExibeFormularioTreeView(sender);
            }
        }

        public void nodeItem_Click(object sender, TreeNodeMouseClickEventArgs e)
        {
            ExibeFormularioTreeView(sender);
        }

        public void ExibeFormularioTreeView(object sender)
        {
            KryptonTreeView view = sender as KryptonTreeView;
            TreeNode nodeItem = view.SelectedNode;
            if (nodeItem != null)
            {
                string nomeForm = recuperaNomeFormNode(nodeItem);
                TipoExibeForm exibeForm = new TipoExibeForm();

                if (nodeItem.Tag is TipoExibeForm)
                {
                    exibeForm = (TipoExibeForm)nodeItem.Tag;
                    ExibirForm(nomeForm, exibeForm);
                }
            }
        }

        public void menuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem menuItem = sender as ToolStripItem;
            string nomeForm = recuperaNomeForm(menuItem);
            TipoExibeForm exibeForm;
            if ((menuItem.Tag == null) || (!Enum.TryParse<TipoExibeForm>(menuItem.Tag.ToString(), out exibeForm)))
            {
                throw new Exception(String.Format("A tag do menu {0} precisa ser do tipo TipoExibeForm.", menuItem.Name));
            }
            if (menuItem.Tag is TipoExibeForm)
            {
                exibeForm = (TipoExibeForm)menuItem.Tag;
            }
            ExibirForm(nomeForm, exibeForm);
        }


        #endregion

        #endregion
    }
}
