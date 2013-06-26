using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComponentFactory.Krypton.Toolkit;
using System.Windows.Forms;

namespace HLP.Comum.Modules.Interface
{
    public interface IFormModulo
    {

        MenuStrip MenuPrincipal { get; }

        KryptonHeaderGroup HeaderGroup { get; }

        KryptonPanel MenuLateral { get; }

        KryptonSplitContainer ContainerTela { get; }

        ContextMenuStrip MenuContexto { get; }

        IModulo Modulo { get; set; }
    }
}
