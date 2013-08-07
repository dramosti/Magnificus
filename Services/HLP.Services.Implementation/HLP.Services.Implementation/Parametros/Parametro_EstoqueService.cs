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
    public class Parametro_EstoqueService : IParametro_EstoqueService
    {
        [Inject]
        public IParametro_EstoqueRepository _Parametro_EstoqueRepository { get; set; }

        public void Save(Parametro_EstoqueModel objParametro_Estoque)
        {
            _Parametro_EstoqueRepository.Save(objParametro_Estoque);
        }

        public void Delete(int idParametroEstoque)
        {
            _Parametro_EstoqueRepository.Delete(idParametroEstoque);
        }

        public int Copy(int idParametroEstoque)
        {
            return _Parametro_EstoqueRepository.Copy(idParametroEstoque);
        }

        public Parametro_EstoqueModel GetParametro_Estoque()
        {
            Parametro_EstoqueModel objParamEstoqueModel = new Parametro_EstoqueModel();
            return _Parametro_EstoqueRepository.GetParametro_Estoque() ?? objParamEstoqueModel;
        }

        public List<Parametro_EstoqueModel> GetAllParametro_Estoque()
        {
            return _Parametro_EstoqueRepository.GetAllParametro_Estoque();
        }
    }
}
