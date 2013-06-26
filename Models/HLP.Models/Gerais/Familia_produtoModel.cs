using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Gerais
{
    public class Familia_produtoModel
    {
        [ParameterOrder(Order = 1)]
        public int? idFamiliaProduto { get; set; }
        [ParameterOrder(Order = 2)]
        public int idEmpresa { get; set; }
        [ParameterOrder(Order = 3)]
        public string xFamiliaProduto { get; set; }
        [ParameterOrder(Order = 4)]
        public string xDescricao { get; set; }
        [ParameterOrder(Order = 5)]
        public string xSigla { get; set; }
        [ParameterOrder(Order = 6)]
        public decimal pDescontoMaximo { get; set; }
        [ParameterOrder(Order = 7)]
        public decimal pAcressimoMaximo { get; set; }
        [ParameterOrder(Order = 8)]
        public decimal pComissaoAvista { get; set; }
        [ParameterOrder(Order = 9)]
        public decimal pComissaoAprazo { get; set; }
        [ParameterOrder(Order = 10)]
        public int? idContaContabil { get; set; }
        [ParameterOrder(Order = 11)]
        public int? idCentroCusto { get; set; }
        [ParameterOrder(Order = 12)]
        public int? idFamiliaProdutoBase { get; set; }
        [ParameterOrder(Order = 13)]
        public byte stgrau { get; set; }
        [ParameterOrder(Order = 14)]
        public byte stAlteraDescricaoComercialProdutoVenda { get; set; }

        public List<Familia_Produto_ClassesModel> lFamilia_Produto_Classe = new List<Familia_Produto_ClassesModel>();

    }

}
