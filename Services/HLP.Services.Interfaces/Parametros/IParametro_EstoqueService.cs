using HLP.Models.Entries.Parametros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLP.Services.Interfaces.Entries.Parametros
{
    public interface IParametro_EstoqueService
    {
        void Save(Parametro_EstoqueModel objParametro_Estoque);
        void Delete(int idParametroEstoque);
        int Copy(int idParametroEstoque);
        Parametro_EstoqueModel GetParametro_Estoque();
        List<Parametro_EstoqueModel> GetAllParametro_Estoque();
    }
}
