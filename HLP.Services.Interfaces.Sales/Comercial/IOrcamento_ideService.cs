using HLP.Models.Sales.Comercial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLP.Services.Interfaces.Sales.Comercial
{
    public interface IOrcamento_ideService
    {
        void Save(Orcamento_ideModel objOrcamento_ide);
        void Delete(Orcamento_ideModel objOrcamento_ide);
        void Copy(Orcamento_ideModel objOrcamento_ide);
        Orcamento_ideModel GetOrcamento_ide(int idOrcamento);
        List<Orcamento_ideModel> GetAllOrcamento_ide();
    }
}
