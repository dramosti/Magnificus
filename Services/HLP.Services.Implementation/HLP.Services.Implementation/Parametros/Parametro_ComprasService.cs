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
    public class Parametro_ComprasService : IParametro_ComprasService
    {
        [Inject]
        public IParametro_ComprasRepository _Parametro_ComprasRepository { get; set; }

        public void Save(Parametro_ComprasModel objParametro_Compras)
        {
            _Parametro_ComprasRepository.Save(objParametro_Compras);
        }

        public void Delete(int idParametro_Compras)
        {
            _Parametro_ComprasRepository.Delete(idParametro_Compras);
        }

        public int Copy(int idParametro_Compras)
        {
            return _Parametro_ComprasRepository.Copy(idParametro_Compras);
        }

        public Parametro_ComprasModel GetParametro_Compras()
        {
            return _Parametro_ComprasRepository.GetParametro_Compras();
        }

        public List<Parametro_ComprasModel> GetAllParametro_Compras()
        {
            return _Parametro_ComprasRepository.GetAllParametro_Compras();
        }


    }
}
