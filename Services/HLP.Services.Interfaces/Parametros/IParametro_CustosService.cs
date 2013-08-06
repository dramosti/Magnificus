using HLP.Models.Entries.Parametros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLP.Services.Interfaces.Entries.Parametros
{
    public interface IParametro_CustosService
    {
        void Save(Parametro_CustosModel objParametro_Custos);
        void Delete(int idParametroCustos);
        int Copy(int idParametroCustos);
        Parametro_CustosModel GetParametro_Custos();
        List<Parametro_CustosModel> GetAllParametro_Custos();
    }
}
