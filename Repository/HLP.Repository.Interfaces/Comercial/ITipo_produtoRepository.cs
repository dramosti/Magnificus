using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Comercial;

namespace HLP.Repository.Interfaces.Entries.Comercial
{
    public interface ITipo_produtoRepository
    {
        Tipo_produtoModel GetTipo(int idTipoProduto);
        void Save(Tipo_produtoModel tipo);
        void Delete(int idTipoProduto);
        int Copy(int idTipoProduto);
    }
}
