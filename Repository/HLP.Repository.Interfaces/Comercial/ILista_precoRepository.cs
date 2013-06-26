using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Comercial;

namespace HLP.Repository.Interfaces.Entries.Comercial
{
    public interface ILista_precoRepository
    {
        void Save(Lista_precoModel objLista_preco);
        void Update(Lista_precoModel objLista_preco);
        void Delete(Lista_precoModel objLista_preco);
        void Delete(int idListaPrecoPai);
        void Copy(Lista_precoModel objLista_preco);
        Lista_precoModel GetLista_preco(int idListaPreco);
        List<Lista_precoModel> GetAllLista_preco(int idListaPrecoPai);

        List<int> ReturnProducts(List<int> lidProduto);
    }
}
