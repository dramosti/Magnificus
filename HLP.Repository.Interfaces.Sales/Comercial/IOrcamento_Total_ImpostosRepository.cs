using HLP.Models.Sales.Comercial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLP.Repository.Interfaces.Sales.Comercial
{
    public interface IOrcamento_Total_ImpostosRepository
    {
        void Save(Orcamento_Total_ImpostosModel objOrcamento_Total_Impostos);
        void Delete(int idOrcamentoTotalImpostos);
        int Copy(int idOrcamentoTotalImpostos);
        Orcamento_Total_ImpostosModel GetOrcamento_Total_Impostos(int idOrcamentoTotalImpostos);
        List<Orcamento_Total_ImpostosModel> GetAllOrcamento_Total_Impostos();
        Orcamento_Total_ImpostosModel GetOrcamento_Total_ImpostosByIdOrcamento(int idOrcamento);
    }
}
