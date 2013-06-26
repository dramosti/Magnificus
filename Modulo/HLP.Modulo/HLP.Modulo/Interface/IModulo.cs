using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Modules;

namespace HLP.Comum.Modules.Interface
{
    public interface IModulo
    {
        string NomeModulo { get; }

        string ArquivoConfiguracao { get; }

        void InicializarModulo();

        void DescarregarModulo();

        void ExibirForm(string nome, TipoExibeForm exibeForm);
    }
}
