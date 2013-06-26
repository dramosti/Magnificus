using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Financeiro
{
    public class Conta_bancariaModel
    {
        [ParameterOrder(Order = 1)]
        public int? idContaBancaria { get; set; }
        [ParameterOrder(Order = 2)]
        public int idEmpresa { get; set; }
        [ParameterOrder(Order = 3)]
        public string xNumeroConta { get; set; }
        [ParameterOrder(Order = 4)]
        public byte stConta { get; set; }
        [ParameterOrder(Order = 5)]
        public string xTitular { get; set; }
        [ParameterOrder(Order = 6)]
        public string xCNPJouCPFTitular { get; set; }
        [ParameterOrder(Order = 7)]
        public int idAgencia { get; set; }
        [ParameterOrder(Order = 8)]
        public string xNumeroContaHomeBanking { get; set; }
        [ParameterOrder(Order = 9)]
        public byte stBloquete { get; set; }
        [ParameterOrder(Order = 10)]
        public int nDiasProtesto { get; set; }
        [ParameterOrder(Order = 11)]
        public int nSequenciaNossoNumero { get; set; }
        [ParameterOrder(Order = 12)]
        public byte stZeraNossoNumero { get; set; }
        [ParameterOrder(Order = 13)]
        public int nCarteira { get; set; }
        [ParameterOrder(Order = 14)]
        public int nVariacaoCarteira { get; set; }
        [ParameterOrder(Order = 15)]
        public byte stAceite { get; set; }
        [ParameterOrder(Order = 16)]
        public int nConvenio { get; set; }
        [ParameterOrder(Order = 17)]
        public string xCodigoEmpresaHomeBanking { get; set; }
        [ParameterOrder(Order = 18)]
        public int nDigitosConvenio { get; set; }
        [ParameterOrder(Order = 19)]
        public string xEspecie { get; set; }
        [ParameterOrder(Order = 20)]
        public int nRemessaHomeBanking { get; set; }
        [ParameterOrder(Order = 21)]
        public string xDescricao { get; set; }



    }
}
