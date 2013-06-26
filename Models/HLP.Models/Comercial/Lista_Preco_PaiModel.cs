using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Comercial
{
    public class Lista_Preco_PaiModel
    {

        [ParameterOrder(Order = 1)]
        public int idEmpresa { get; set; }
        [ParameterOrder(Order = 2)]
        public int? idListaPrecoPai { get; set; }
        [ParameterOrder(Order = 3)]
        public string xLista { get; set; }
        [ParameterOrder(Order = 4)]
        public byte stContrato { get; set; }
        [ParameterOrder(Order = 5)]
        public string xNrContrato { get; set; }
        [ParameterOrder(Order = 6)]
        public DateTime? dValidadeContrato { get; set; }
        [ParameterOrder(Order = 7)]
        public bool Ativo { get; set; }
        [ParameterOrder(Order = 8)]
        public DateTime dListaPreco { get; set; }
        [ParameterOrder(Order = 9)]
        public byte stAtualizacao { get; set; }
        [ParameterOrder(Order = 10)]
        public decimal? nDiasSemAtualicao { get; set; }
        [ParameterOrder(Order = 11)]
        public decimal? pDescontoMaximo { get; set; }
        [ParameterOrder(Order = 12)]
        public decimal? pAcressimoMaximo { get; set; }
        [ParameterOrder(Order = 13)]
        public string xCodigoListaPreco { get; set; }
        [ParameterOrder(Order = 14)]
        public decimal? pPercentual { get; set; }
        [ParameterOrder(Order = 15)]
        public int? idListaPrecoOrigem { get; set; }

        public List<Lista_precoModel> lLista_preco = new List<Lista_precoModel>();

    }
}
