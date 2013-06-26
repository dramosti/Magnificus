using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Comercial;

namespace HLP.Repository.Interfaces.Entries.Comercial
{
    public interface IProduto_localizacaoRepository
    {
        Produto_localizacaoModel GetLocalizacao(int idProdutoLocalizacao);
        void Save(Produto_localizacaoModel localizacao);
        void Delete(int idProdutoLocalizacao);
        int Copy(int idProdutoLocalizacao);
    }
}
