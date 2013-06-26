using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Comercial;

namespace HLP.Repository.Interfaces.Entries.Comercial
{
    public interface ILista_Preco_PaiRepository
    {
        void Save(Lista_Preco_PaiModel objLista_Preco_Pai);
        void Delete(Lista_Preco_PaiModel objLista_Preco_Pai);
        void Copy(Lista_Preco_PaiModel objLista_Preco_Pai);
        Lista_Preco_PaiModel GetLista_Preco_Pai(int idListaPrecoPai);

        void BeginTransaction();
        void CommitTransaction();
        void RollackTransaction();
    }
}
