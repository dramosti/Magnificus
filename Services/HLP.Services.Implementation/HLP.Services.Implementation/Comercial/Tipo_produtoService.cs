using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Comercial;
using HLP.Models.Entries.Comercial;
using HLP.Repository.Interfaces.Entries.Comercial;
using Ninject;

namespace HLP.Services.Implementation.Entries.Comercial
{
    public class Tipo_produtoService : ITipo_produtoService
    {
        [Inject]
        public ITipo_produtoRepository tipoRepository { get; set; }

        public Tipo_produtoModel GetTipo(int idTipoProduto)
        {
            return tipoRepository.GetTipo(idTipoProduto);
        }

        public void Save(Tipo_produtoModel tipo)
        {
            tipoRepository.Save(tipo);
        }

        public void Delete(int idTipoProduto)
        {
            tipoRepository.Delete(idTipoProduto);
        }

        public int Copy(int idTipoProduto)
        {
            return tipoRepository.Copy(idTipoProduto);
        }
    }
}
