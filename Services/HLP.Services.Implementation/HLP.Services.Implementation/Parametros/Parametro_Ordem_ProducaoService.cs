using HLP.Models.Entries.Parametros;
using HLP.Repository.Interfaces.Entries.Parametros;
using HLP.Services.Interfaces.Entries.Parametros;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLP.Services.Implementation.Entries.Parametros
{
    public class Parametro_Ordem_ProducaoService : IParametro_Ordem_ProducaoService
    {
        [Inject]
        public IParametro_Ordem_ProducaoRepository _Parametro_Ordem_ProducaoRepository { get; set; }

        public void Save(Parametro_Ordem_ProducaoModel objParametro_Ordem_Producao)
        {
            _Parametro_Ordem_ProducaoRepository.Save(objParametro_Ordem_Producao);
        }

        public void Delete(int idParametroOrdemProducao)
        {
            _Parametro_Ordem_ProducaoRepository.Delete(idParametroOrdemProducao);
        }

        public int Copy(int idParametroOrdemProducao)
        {
            return _Parametro_Ordem_ProducaoRepository.Copy(idParametroOrdemProducao);
        }

        public Parametro_Ordem_ProducaoModel GetParametro_Ordem_Producao()
        {
            Parametro_Ordem_ProducaoModel objParamOrdProdModel = new Parametro_Ordem_ProducaoModel();
            return _Parametro_Ordem_ProducaoRepository.GetParametro_Ordem_Producao() ?? objParamOrdProdModel;
        }

        public List<Parametro_Ordem_ProducaoModel> GetAllParametro_Ordem_Producao()
        {
            return _Parametro_Ordem_ProducaoRepository.GetAllParametro_Ordem_Producao();
        }

    }
}
