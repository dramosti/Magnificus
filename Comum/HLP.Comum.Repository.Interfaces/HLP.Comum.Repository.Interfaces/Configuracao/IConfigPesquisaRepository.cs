using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;
using HLP.Comum.Models;

namespace HLP.Comum.Repository.Interfaces.Configuracao
{
    public interface IConfigPesquisaRepository
    {
        void Save(CONFIG_PesquisaModel objCONFIG_Pesquisa);
        //CONFIG_PesquisaModel GetCONFIG_Pesquisa(int idPesquisa);
        List<CONFIG_PesquisaModel> GetCONFIG_PesquisaByView(string sViewName);
        List<CONFIG_PesquisaModel> GetAllCONFIG_Pesquisa(int idFormulario, int idUsuario);
    }
}
