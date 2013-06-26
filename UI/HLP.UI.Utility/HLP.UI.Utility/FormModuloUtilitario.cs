using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HLP.Comum.Modules;
using HLP.Comum.Modules.Interface;
using ComponentFactory.Krypton.Toolkit;

namespace HLP.UI.Utility
{
    public partial class FormModuloUtilitario : FormBaseModulo, IFormModulo
    {
        public FormModuloUtilitario()
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
