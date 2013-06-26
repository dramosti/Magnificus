using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HLP.Modulo.Interface
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
