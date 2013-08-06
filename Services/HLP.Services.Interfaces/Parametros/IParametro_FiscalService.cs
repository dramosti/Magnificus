using HLP.Models.Entries.Parametros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLP.Services.Interfaces.Entries.Parametros
{
    public interface IParametro_FiscalService
    {
        void Save(Parametro_FiscalModel objParametro_Fiscal);
        void Delete(int idParametroFiscal);
        int Copy(int idParametroFiscal);
        Parametro_FiscalModel GetParametro_Fiscal();
        List<Parametro_FiscalModel> GetAllParametro_Fiscal();
    }
}
