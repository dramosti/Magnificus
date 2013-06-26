using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Comercial
{
    public class Lista_precoModel : BaseModelFilhos
    {

        private int? _idListaPreco;
        [ParameterOrder(Order = 1)]
        public int? idListaPreco
        {
            get { return _idListaPreco; }
            set
            {
                _idListaPreco = value;
                base.SetID(value);
            }
        }
        [ParameterOrder(Order = 2)]
        public int idProduto { get; set; }
        [ParameterOrder(Order = 3)]
        public decimal vCustoProduto { get; set; }
        [ParameterOrder(Order = 4)]
        public decimal pLucro { get; set; }
        [ParameterOrder(Order = 5)]
        public decimal vVenda { get; set; }
        [ParameterOrder(Order = 6)]
        public decimal? pDescontoMaximo { get; set; }
        [ParameterOrder(Order = 7)]
        public decimal? pAcrescimoMaximo { get; set; }
        [ParameterOrder(Order = 8)]
        public decimal? pComissaoAvista { get; set; }
        [ParameterOrder(Order = 9)]
        public decimal? pComissaoAprazo { get; set; }
        [ParameterOrder(Order = 10)]
        public int? idListaPrecoPai { get; set; }
        [ParameterOrder(Order = 11)]
        public decimal? pDesconto { get; set; }
        [ParameterOrder(Order = 12)]
        public decimal? pComissao { get; set; }
        [ParameterOrder(Order = 13)]
        public decimal? pOutros { get; set; }
        [ParameterOrder(Order = 14)]
        public DateTime dAlteracaoCusto { get; set; }
        [ParameterOrder(Order = 15)]
        public int idUnidadeMedida { get; set; }


    }
}
