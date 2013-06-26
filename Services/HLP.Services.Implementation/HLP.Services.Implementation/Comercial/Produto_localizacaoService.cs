using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Comercial;
using HLP.Models.Entries.Comercial;
using Ninject;
using HLP.Repository.Interfaces.Entries.Comercial;

namespace HLP.Services.Implementation.Entries.Comercial
{
    public class Produto_localizacaoService : IProduto_localizacaoService
    {
        [Inject]
        public IProduto_localizacaoRepository localizacaoRepository { get; set; }

        public Produto_localizacaoModel GetLocalizacao(int idProdutoLocalizacao)
        {
            return localizacaoRepository.GetLocalizacao(idProdutoLocalizacao);
        }

        public void Save(Produto_localizacaoModel localizacao)
        {
            localizacaoRepository.Save(localizacao);
        }

        public void Delete(int idProdutoLocalizacao)
        {
            localizacaoRepository.Delete(idProdutoLocalizacao);
        }

        public int Copy(int idProdutoLocalizacao)
        {
            return localizacaoRepository.Copy(idProdutoLocalizacao);
        }
    }
}
