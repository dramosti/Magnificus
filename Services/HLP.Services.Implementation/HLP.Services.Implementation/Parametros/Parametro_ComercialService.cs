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
    public class Parametro_ComercialService : IParametro_ComercialService
    {
        [Inject]
        public IParametro_ComercialRepository _Parametro_ComercialRepository { get; set; }

        public void Save(Parametro_ComercialModel objParametro_Comercial)
        {
            _Parametro_ComercialRepository.Save(objParametro_Comercial);
        }

        public void Delete(int idParametroComercial)
        {
            _Parametro_ComercialRepository.Delete(idParametroComercial);
        }

        public int Copy(int idParametroComercial)
        {
            return _Parametro_ComercialRepository.Copy(idParametroComercial);
        }

        public Parametro_ComercialModel GetParametro_Comercial()
        {
            return _Parametro_ComercialRepository.GetParametro_Comercial();
        }

        public List<Parametro_ComercialModel> GetAllParametro_Comercial()
        {
            return _Parametro_ComercialRepository.GetAllParametro_Comercial();
        }

    }
}
