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
    public class Lista_precoService : ILista_precoService
    {
        [Inject]
        public ILista_precoRepository _Lista_precoRepository { get; set; }

        public void Save(Lista_precoModel objLista_preco)
        {
            _Lista_precoRepository.Save(objLista_preco);
        }

        public void Update(Lista_precoModel objLista_preco)
        {
            _Lista_precoRepository.Update(objLista_preco);
        }

        public void Delete(Lista_precoModel objLista_preco)
        {
            _Lista_precoRepository.Delete(objLista_preco);
        }

        public void Delete(int idListaPrecoPai)
        {
            _Lista_precoRepository.Delete(idListaPrecoPai);
        }

        public void Copy(Lista_precoModel objLista_preco)
        {
            _Lista_precoRepository.Copy(objLista_preco);
        }

        public Lista_precoModel GetLista_preco(int idListaPreco)
        {
            return _Lista_precoRepository.GetLista_preco(idListaPreco);
        }

        public List<Lista_precoModel> GetAllLista_preco(int idListaPrecoPai)
        {
            return _Lista_precoRepository.GetAllLista_preco(idListaPrecoPai);
        }

        public List<int> ReturnProducts(List<int> lidProduto)
        {
            return _Lista_precoRepository.ReturnProducts(lidProduto);
        }

        public decimal CalculaValorTaxa(decimal dpComissao, decimal dpOutros, decimal dpDesconto)
        {
            return dpComissao + dpOutros - dpDesconto;
        }

        public decimal CalculaValorCustoComTaxa(decimal dvCustoProduto, decimal dValorTaxa)
        {
            return dvCustoProduto + ((dvCustoProduto * dValorTaxa) / 100);
        }

        public decimal CalculaValorVenda(decimal dvCustoProdutoImpostos, decimal dvCustoProduto, decimal dpLucro)
        {
            return dvCustoProdutoImpostos + ((dvCustoProduto * dpLucro) / 100);
        }

        public decimal CalculaValorVendaAposTrocarProdutoLista(decimal dvCustoProduto, decimal dvCustoProdutoImpostos, decimal dpLucro)
        {
            return dvCustoProduto + ((dvCustoProduto * dpLucro) / 100) + dvCustoProdutoImpostos;
        }

        public decimal CalculaPorcentagemLucro(decimal dvVenda, decimal dvCustoProdutoImpostos, decimal dvCustoProduto)
        {
            return ((dvVenda - dvCustoProdutoImpostos) * 100) / dvCustoProduto;
        }
    }
}
