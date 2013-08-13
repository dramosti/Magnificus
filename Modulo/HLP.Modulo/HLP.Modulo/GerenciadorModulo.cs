using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using HLP.Comum.Modules.Interface;
using HLP.Comum.Modules.Infrastructure;
using HLP.Comum.Models;

using ComponentFactory.Krypton.Toolkit;
using System.Xml.Serialization;
using HLP.Comum.Infrastructure.Static;

namespace HLP.Comum.Modules
{
    public class GerenciadorModulo
    {

        #region [Singleton]
        private static volatile GerenciadorModulo instance;
        private static object syncRoot = new Object();

        private GerenciadorModulo() { }


        public static GerenciadorModulo Instancia
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new GerenciadorModulo();
                    }
                }

                return instance;
            }
        }
        #endregion

        #region [Propriedades]


        public IFormPrincipal FormPrincipal { get; private set; }

        public string CaminhoConfiguracoes { get; private set; }

        public List<Modulo> Modulos { get; private set; }

        #endregion

        #region Variaveis privadas
        private ExibeInformacaoSplash _exibeInformacaoSplash = null;

        private ValoresProgressBar _valoresProgressBar = null;

        #endregion

        #region [Métodos]

        #region [Métodos publicos]


        public void InicializaSistema<Principal>(ExibeInformacaoSplash exibeInformacaoSplash, ValoresProgressBar valoresProgressBar)
            where Principal : FormBaseModulo, IFormPrincipal
        {
            this._exibeInformacaoSplash = exibeInformacaoSplash;
            this._valoresProgressBar = valoresProgressBar;
            criaFormPrincipal<Principal>();
            inicializaModulos();
            CarregaConfigsComponentes();
            configuraExceptionHandler();
        }






        public void ExibirForm(string nome, TipoExibeForm exibeForm)
        {
            Form form = (this.FormPrincipal as Form).MdiChildren.FirstOrDefault(mdiFilho => mdiFilho.Name == nome);
            try
            {
                if (form == null)
                {
                    //Solicita instancia do form
                    form = Contexto.GetServico<Form>(nome);

                    form.Name = nome;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Form " + nome + " não foi encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (form == null) { return; }
            if (exibeForm == TipoExibeForm.Modal)
            {
                System.Drawing.Size size = form.Size;
                form.FormBorderStyle = FormBorderStyle.Sizable;
                if (form.GetType().BaseType.BaseType.Name == "KryptonForm")
                {
                    ((KryptonForm)form).AllowFormChrome = false;
                    ((KryptonForm)form).MaximizeBox = true;
                }
                form.ShowInTaskbar = false;
                form.WindowState = FormWindowState.Maximized;
                form.ShowDialog();

            }
            else
            {
                if (form.MdiParent == null)
                {
                    bool bstate = false;

                    foreach (Control crt in this.FormPrincipal.ContainerTela.Panel2.Controls)
                    {
                        if (crt.Name.Equals(form.Name))
                        {
                            bstate = true;
                            form = crt as Form;
                        }
                    }

                    if (!bstate)
                    {
                        (this.FormPrincipal as Form).AddOwnedForm(form);
                        form.MdiParent = this.FormPrincipal as Form;
                        this.FormPrincipal.ContainerTela.Panel2.Controls.Add(form);
                        form.Dock = DockStyle.Fill;
                        //form.WindowState = FormWindowState.Minimized;
                        form.Show();


                        ToolStripMenuItem c = new ToolStripMenuItem();

                        ToolStripItem[] itens = this.FormPrincipal.MenuPrincipal.Items.Find("tsJanelas", true);
                        ToolStripItem item = new ToolStripMenuItem();
                        item.Text = form.Text;
                        item.Name = form.Name;
                        item.Click += new EventHandler(AddFormJanelaClick);
                        ((ToolStripMenuItem)itens[0]).DropDownItems.Add(item);
                        // form.WindowState = FormWindowState.Maximized;
                    }
                    else
                    {
                        form.WindowState = FormWindowState.Normal;
                        form.BringToFront();
                    }

                }
            }
        }



        private void AddFormJanelaClick(object sender, EventArgs e)
        {
            ToolStripItem ts = ((ToolStripItem)sender);
            Control[] form = this.FormPrincipal.ContainerTela.Panel2.Controls.Find(ts.Name, true);
            if (form.Count() > 0)
            {
                (form[0] as Form).WindowState = FormWindowState.Normal;
                (form[0] as Form).BringToFront();
            }

        }


        public void CarregaForm(string nome, TipoExibeForm exibeForm)
        {
            Form form = (this.FormPrincipal as Form).MdiChildren.FirstOrDefault(mdiFilho => mdiFilho.Name == nome);
            try
            {
                if (form == null)
                {
                    form = Contexto.GetServico<Form>(nome);
                    form.Name = nome;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (form == null) { return; }

            if (exibeForm == TipoExibeForm.Modal)
            {
                form.ShowDialog();
            }
            else
            {
                if (form.MdiParent == null)
                {
                    (this.FormPrincipal as Form).AddOwnedForm(form);
                    form.MdiParent = this.FormPrincipal as Form;
                }
                form.Show();
            }
        }

        #endregion


        #region [Métodos privados]


        private void CarregaConfigsComponentes()  // Criado por mário 19/10
        {
            List<Modulo> lModulo = GerenciadorModulo.Instancia.CarregaModulosAcesso();

            List<string> lFormularios;

            foreach (Modulo m in lModulo)
            {

                if (m.NomeModulo != "Utilitarios" && m.NomeModulo != "Magnificus")
                {
                    //  lFormularios = m.MontaListFormularios();
                }
            }
        }


        private void configuraExceptionHandler()
        {
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
        }

        private void inicializaModulos()
        {
            carregaModulos();
            IniciaModuloPrincipal(Modulos.FirstOrDefault(m => m.NomeModulo == "Magnificus"));
            Collection.LIST_IMAGELIST_TREEVIEW = new ImageList();

            for (int i = 0; i < Collection.LIST_ORDEM_MODULOS.Count; i++)
            {
                Modulo m = this.Modulos.FirstOrDefault(M => M.NomeModulo == Collection.LIST_ORDEM_MODULOS[i].nome);
                if (m != null)
                {
                    m.InicializarModulo();
                }
            }
        }


        private void carregaModulos()
        {
            exibeInformacaoSplash("Carregando modulos disponíveis");
            this.CaminhoConfiguracoes = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                "configuracoes\\Modulos");

            this.Modulos = (from modulo in System.IO.Directory.EnumerateFiles(this.CaminhoConfiguracoes, "*.modulo")
                            select new Modulo(modulo)).ToList();

            XmlDocument xarquivo = new XmlDocument();
            xarquivo.Load(this.CaminhoConfiguracoes + "\\Modulos.xml");
            XmlNodeList xmlListaModulos = xarquivo.GetElementsByTagName("modulo");
            Collection.LIST_ORDEM_MODULOS = new List<OrdemModulo>();
            foreach (XmlNode item in xmlListaModulos)
            {
                Collection.LIST_ORDEM_MODULOS.Add(new OrdemModulo { nome = item.Attributes["nome"].Value, arquivo = item.Attributes["arquivo"].Value, ordem = Convert.ToInt16(item.Attributes["ordem"].Value) });
            }
            Collection.LIST_ORDEM_MODULOS = Collection.LIST_ORDEM_MODULOS.OrderBy(L => L.ordem).ToList();

        }

        public List<Modulo> CarregaModulosAcesso()
        {
            string sCaminhoConfiguracoes = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                "configuracoes\\Modulos");

            return (from modulo in System.IO.Directory.EnumerateFiles(sCaminhoConfiguracoes, "*.modulo")
                    select new Modulo(modulo)).ToList();

        }


        private void IniciaModuloPrincipal(Modulo modulo)
        {
            Contexto.CarregaConfiguracao(modulo.NomeModulo, modulo.ArquivoConfiguracao);
            this.FormPrincipal = Contexto.GetServico<IFormPrincipal>(modulo.NomeModulo);
        }


        private void criaFormPrincipal<Principal>() where Principal : FormBaseModulo, IFormPrincipal
        {
            Principal formPrincipal = Activator.CreateInstance<Principal>();

            exibeInformacaoSplash("Preparando formulário principal do sistema");

            formPrincipal.IsMdiContainer = true;
            formPrincipal.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            formPrincipal.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            formPrincipal.MenuPrincipal.ItemClicked += new ToolStripItemClickedEventHandler(this.MenuItem_Clicked);
            this.FormPrincipal = formPrincipal;
        }


        private void exibeInformacaoSplash(string informacao)
        {
            if (_exibeInformacaoSplash != null)
            {
                _exibeInformacaoSplash(informacao);
            }
        }


        private void preparaMenuModulos()
        {
            exibeInformacaoSplash("Preparando menu para acesso aos módulos");
            ToolStripMenuItem itemModulo = new ToolStripMenuItem
            {
                Text = "Modulos",
                ToolTipText = "Lista os módulos disponíveis"
            };
            foreach (Modulo modulo in Modulos)
            {
                ToolStripMenuItem itemMenuModulo = new ToolStripMenuItem
                {
                    Name = String.Format("tsm_{0}", modulo.NomeModulo),
                    Text = modulo.NomeModulo,
                    ToolTipText = String.Format("Carrega o módulo {0}", modulo.NomeModulo),
                    DisplayStyle = ToolStripItemDisplayStyle.ImageAndText,
                    CheckOnClick = true
                };
                itemMenuModulo.Click += new EventHandler(modulo.MenuModulo_Click);
                itemModulo.DropDownItems.Add(itemMenuModulo);
            }
            FormPrincipal.MenuPrincipal.Items.Insert(0, itemModulo);
        }



        void MenuItem_Clicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if ((String.IsNullOrEmpty(e.ClickedItem.Name)) ||
                (e.ClickedItem is ToolStripMenuItem) ||
                ((e.ClickedItem as ToolStripMenuItem).DropDownItems.Count > 0))
            {
                return;
            }
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
            System.Enum.TryParse<TipoExibeForm>(e.ClickedItem.Tag.ToString(), out exibeForm);
            this.ExibirForm(nomeItem, exibeForm);
        }

        void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            if (e.Exception != null)
            {
                MessageBox.Show("Ocorreu um erro não tratado, favor entrar em contato com o Suporte tecnico.", "Informacao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #endregion

    }
}
