using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HLP.Comum.Modules.Interface;
using ComponentFactory.Krypton.Toolkit;

namespace HLP.Comum.Modules
{
    public partial class FormBaseModulo : KryptonForm
    {

        public FormBaseModulo()
        {
            InitializeComponent();
        }

        public IModulo Modulo { get; set; }

    }
}
