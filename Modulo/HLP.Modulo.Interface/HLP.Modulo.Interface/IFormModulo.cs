using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComponentFactory.Krypton.Toolkit;
using System.Windows.Forms;

namespace HLP.Modulo.Interface
{
    public interface IFormModulo
    {
        
        MenuStrip MenuPrincipal { get; }

        KryptonHeaderGroup MenuLateral { get; }

        KryptonSplitContainer ContainerTela { get; }
         
        ContextMenuStrip MenuContexto { get; }
         
        IModulo Modulo { get; set; }
    }
}
