using HLP.Models.Entries.Parametros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLP.Services.Interfaces.Entries.Parametros
{
    public interface IParametro_Ordem_ProducaoService
    {
        void Save(Parametro_Ordem_ProducaoModel objParametro_Ordem_Producao);
        void Delete(int idParametroOrdemProducao);
        int Copy(int idParametroOrdemProducao);
        Parametro_Ordem_ProducaoModel GetParametro_Ordem_Producao();
        List<Parametro_Ordem_ProducaoModel> GetAllParametro_Ordem_Producao();
    }
}
