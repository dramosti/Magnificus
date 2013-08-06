using HLP.Models.Entries.Parametros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLP.Services.Interfaces.Entries.Parametros
{
    public interface IParametro_ComercialService
    {
        void Save(Parametro_ComercialModel objParametro_Comercial);
        void Delete(int idParametroComercial);
        int Copy(int idParametroComercial);
        Parametro_ComercialModel GetParametro_Comercial();
        List<Parametro_ComercialModel> GetAllParametro_Comercial();
    }
}
