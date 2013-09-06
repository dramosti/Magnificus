using HLP.Models.Sales.Comercial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLP.Repository.Interfaces.Sales.Comercial
{
    public interface IOrcamento_retTranspRepository
    {
        void Save(Orcamento_retTranspModel objOrcamento_retTransp);
        void Delete(int idRetTransp);
        int Copy(int idRetTransp);
        Orcamento_retTranspModel GetOrcamento_retTransp(int idRetTransp);
        List<Orcamento_retTranspModel> GetAllOrcamento_retTransp();
    }
}
