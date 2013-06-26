using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Comercial;

namespace HLP.Services.Interfaces.Entries.Comercial
{
    public interface ILista_precoService
    {
        void Save(Lista_precoModel objLista_preco);
        void Update(Lista_precoModel objLista_preco);
        void Delete(Lista_precoModel objLista_preco);
        void Delete(int idListaPrecoPai);
        void Copy(Lista_precoModel objLista_preco);
        Lista_precoModel GetLista_preco(int idListaPreco);
        List<Lista_precoModel> GetAllLista_preco(int idListaPrecoPai);
        List<int> ReturnProducts(List<int> lidProduto);


        decimal CalculaValorTaxa(decimal dpComissao, decimal dpOutros, decimal dpDesconto);
        decimal CalculaValorCustoComTaxa(decimal dvCustoProduto, decimal dValor);
        decimal CalculaValorVenda(decimal dvCustoProdutoImpostos, decimal dvCustoProduto, decimal dpLucro);
        decimal CalculaValorVendaAposTrocarProdutoLista(decimal dvCustoProduto, decimal dvCustoProdutoImpostos, decimal dpLucro);
        decimal CalculaPorcentagemLucro(decimal dvVenda, decimal dvCustoProdutoImpostos, decimal dvCustoProduto);
    }
}
