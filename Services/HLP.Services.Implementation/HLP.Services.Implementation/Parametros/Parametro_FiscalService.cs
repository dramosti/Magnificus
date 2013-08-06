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
    public class Parametro_FiscalService : IParametro_FiscalService
    {
        [Inject]
        public IParametro_FiscalRepository _Parametro_FiscalRepository { get; set; }

        public void Save(Parametro_FiscalModel objParametro_Fiscal)
        {
            _Parametro_FiscalRepository.Save(objParametro_Fiscal);
        }

        public void Delete(int idParametroFiscal)
        {
            _Parametro_FiscalRepository.Delete(idParametroFiscal);
        }

        public int Copy(int idParametroFiscal)
        {
            return _Parametro_FiscalRepository.Copy(idParametroFiscal);
        }

        public Parametro_FiscalModel GetParametro_Fiscal()
        {
            return _Parametro_FiscalRepository.GetParametro_Fiscal();
        }

        public List<Parametro_FiscalModel> GetAllParametro_Fiscal()
        {
            return _Parametro_FiscalRepository.GetAllParametro_Fiscal();
        }
    }
}
