using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using HLP.Comum.Modules;
using HLP.Comum.Modules.Interface;

namespace HLP.UI.Entries
{
    public partial class FormModuloCadastro : FormBaseModulo, IFormModulo
    {
        public FormModuloCadastro()
        {
            InitializeComponent();
        }

        public ContextMenuStrip MenuContexto
        {
            get { throw new NotImplementedException(); }
        }

        public KryptonPanel MenuLateral
        {
            get { throw new NotImplementedException(); }
        }

        public MenuStrip MenuPrincipal
        {
            get { return this.menuStrip1; }
        }

        public KryptonSplitContainer ContainerTela
        {
            get { throw new NotImplementedException(); }
        }

        private void geralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Modulo.ExibirForm("Geral", TipoExibeForm.Normal);
        }


        #region IFormModulo Members


        public ToolStrip MenuIcones
        {
            get { throw new NotImplementedException(); }
        }

        #endregion




        public KryptonHeaderGroup HeaderGroup
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
