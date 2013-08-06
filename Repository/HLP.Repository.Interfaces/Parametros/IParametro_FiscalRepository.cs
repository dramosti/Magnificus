using HLP.Models.Entries.Parametros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLP.Repository.Interfaces.Entries.Parametros
{
    public interface IParametro_FiscalRepository
    {
        void Save(Parametro_FiscalModel objParametro_Fiscal);
        void Delete(int idParametroFiscal);
        int Copy(int idParametroFiscal);
        Parametro_FiscalModel GetParametro_Fiscal();
        List<Parametro_FiscalModel> GetAllParametro_Fiscal();
    }
}
