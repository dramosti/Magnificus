using HLP.Comum.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLP.Models.Entries.Parametros
{
    public class Parametro_EstoqueModel
    {
        [ParameterOrder(Order = 1)]
        public int idEmpresa { get; set; }
        [ParameterOrder(Order = 2)]
        public int? idParametroEstoque { get; set; }
        [ParameterOrder(Order = 3)]
        public byte stEstoqueMinimo { get; set; }
        [ParameterOrder(Order = 4)]
        public byte stEstoqueMaximo { get; set; }
        [ParameterOrder(Order = 5)]
        public byte stMediaConsumo { get; set; }
        [ParameterOrder(Order = 6)]
        public byte stVendasGera { get; set; }
        [ParameterOrder(Order = 7)]
        public byte stGradeEstoque { get; set; }
        [ParameterOrder(Order = 8)]
        public byte stRastreabilidadeMaterial { get; set; }
        [ParameterOrder(Order = 9)]
        public byte stRastreabilidadeProdutoAcabado { get; set; }
        [ParameterOrder(Order = 10)]
        public int? cFornecedorPagamentoPis { get; set; }
        [ParameterOrder(Order = 11)]
        public int? cFornecedorPagamentoCofins { get; set; }
        [ParameterOrder(Order = 12)]
        public int? cFornecedorPagamentoCsll { get; set; }
        [ParameterOrder(Order = 13)]
        public int? cFornecedorPagamentoIrrf { get; set; }
        [ParameterOrder(Order = 14)]
        public int? cFornecedorPagamentoIss { get; set; }
        [ParameterOrder(Order = 15)]
        public int? cFornecedorPagamentoInss { get; set; }
        [ParameterOrder(Order = 16)]
        public int cQtdFornecedoresCotacao { get; set; }
        [ParameterOrder(Order = 17)]
        public decimal pIiqFornecimento { get; set; }
        [ParameterOrder(Order = 18)]
        public decimal pIfFornecimento { get; set; }
        [ParameterOrder(Order = 19)]
        public decimal pCertificado { get; set; }
        [ParameterOrder(Order = 20)]
        public decimal pQuestionario { get; set; }
        [ParameterOrder(Order = 21)]
        public byte stLeadTimeRecebimento { get; set; }
        [ParameterOrder(Order = 22)]
        public byte stCustoMedio { get; set; }
        [ParameterOrder(Order = 23)]
        public byte stCusto { get; set; }
        [ParameterOrder(Order = 24)]
        public string XMaskFamiliaProdutos { get; set; }
        [ParameterOrder(Order = 25)]
        public byte stMaiusculo { get; set; }
    }
}
