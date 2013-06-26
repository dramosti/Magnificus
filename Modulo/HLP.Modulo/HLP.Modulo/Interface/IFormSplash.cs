using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HLP.Comum.Modules.Interface
{
    public interface IFormSplash
    {
        void ExibeInformacao(string informacao);

        void ValoresProgressBar(int Maximo);
    }

    public delegate void ExibeInformacaoSplash(string Informacao);

    public delegate void ValoresProgressBar(int Maximo);
}
