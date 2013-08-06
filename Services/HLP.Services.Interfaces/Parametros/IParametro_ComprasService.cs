using HLP.Models.Entries.Parametros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLP.Services.Interfaces.Entries.Parametros
{
    public interface IParametro_ComprasService
    {
        void Save(Parametro_ComprasModel objParametro_Compras);
        void Delete(int idParametro_Compras);
        int Copy(int idParametro_Compras);
        Parametro_ComprasModel GetParametro_Compras();
        List<Parametro_ComprasModel> GetAllParametro_Compras();
    }
}
