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
    public class Parametro_CustosService : IParametro_CustosService
    {
        [Inject]
        public IParametro_CustosRepository _Parametro_CustosRepository { get; set; }

        public void Save(Parametro_CustosModel objParametro_Custos)
        {
            _Parametro_CustosRepository.Save(objParametro_Custos);
        }

        public void Delete(int idParametroCustos)
        {
            _Parametro_CustosRepository.Delete(idParametroCustos);
        }

        public int Copy(int idParametroCustos)
        {
            return _Parametro_CustosRepository.Copy(idParametroCustos);
        }

        public Parametro_CustosModel GetParametro_Custos()
        {
            return _Parametro_CustosRepository.GetParametro_Custos();
        }

        public List<Parametro_CustosModel> GetAllParametro_Custos()
        {
            return _Parametro_CustosRepository.GetAllParametro_Custos();
        }
    }
}
