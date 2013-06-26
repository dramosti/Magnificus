using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HLP.Comum.Infrastructure;

namespace HLP.Comum.Services.Interface.Configuracao
{
    public interface IConfigPesquisaService
    {
        void Save(List<CONFIG_PesquisaModel> lobjCONFIG_Pesquisa);
    }
}
