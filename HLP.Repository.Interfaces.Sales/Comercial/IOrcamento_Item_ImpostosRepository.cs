using HLP.Models.Sales.Comercial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLP.Repository.Interfaces.Sales.Comercial
{
    public interface IOrcamento_Item_ImpostosRepository
    {
        void Save(Orcamento_Item_ImpostosModel objOrcamento_Item_Impostos);
        void Delete(int idOrcamentoTotalizadorImpostos);
        int Copy(int idOrcamentoTotalizadorImpostos);
        Orcamento_Item_ImpostosModel GetOrcamento_Item_Impostos(int idOrcamentoTotalizadorImpostos);
        List<Orcamento_Item_ImpostosModel> GetAllOrcamento_Item_Impostos();
    }
}
