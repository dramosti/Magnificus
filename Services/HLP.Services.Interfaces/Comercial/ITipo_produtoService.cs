using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Comercial;

namespace HLP.Services.Interfaces.Entries.Comercial
{
    public interface ITipo_produtoService
    {
        Tipo_produtoModel GetTipo(int idTipoProduto);
        void Save(Tipo_produtoModel tipo);
        void Delete(int idTipoProduto);
        int Copy(int idTipoProduto);
    }
}
