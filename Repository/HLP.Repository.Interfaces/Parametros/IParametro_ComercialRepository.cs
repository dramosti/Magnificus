using HLP.Models.Entries.Parametros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLP.Repository.Interfaces.Entries.Parametros
{
    public interface IParametro_ComercialRepository
    {
        void Save(Parametro_ComercialModel objParametro_Comercial);
        void Delete(int idParametroComercial);
        int Copy(int idParametroComercial);
        Parametro_ComercialModel GetParametro_Comercial();
        List<Parametro_ComercialModel> GetAllParametro_Comercial();
    }
}
