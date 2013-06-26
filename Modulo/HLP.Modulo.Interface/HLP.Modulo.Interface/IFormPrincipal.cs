using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HLP.Modulo.Interface
{
    public interface IFormPrincipal : IFormModulo
    {
        void IntegrarMenuIcones(ToolStrip menuIcones);

        void EscondeMenuIcones(ToolStrip menuIcones);

        StatusStrip BarraStatus { get; }
    }
}
