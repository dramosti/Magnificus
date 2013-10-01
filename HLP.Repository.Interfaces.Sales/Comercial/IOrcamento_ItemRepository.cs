using HLP.Models.Sales.Comercial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLP.Repository.Interfaces.Sales.Comercial
{
    public interface IOrcamento_ItemRepository
    {
        void Save(Orcamento_ItemModel objOrcamento_Item);
        void Delete(int idOrcamentoItem);
        int Copy(int idOrcamentoItem);
        Orcamento_ItemModel GetOrcamento_Item(int idOrcamentoItem);
        List<Orcamento_ItemModel> GetAllOrcamento_Item();
        List<Orcamento_ItemModel> GetAllOrcamento_Item(int idOrcamento);
        void BebingTransaction();
        void Commit();
        void Rollback();
    }
}
