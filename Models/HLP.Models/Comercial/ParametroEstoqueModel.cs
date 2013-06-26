using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Comercial
{
    public class ParametroEstoqueModel
    {
        [ParameterOrder(Order = 1)]
        public int idEmpresa { get; set; }
        [ParameterOrder(Order = 2)]
        public int? idParametroEstoque { get; set; }
        [ParameterOrder(Order = 3)]
        public byte tpEstMinimo { get; set; }
        [ParameterOrder(Order = 4)]
        public byte tpEstMaximo { get; set; }
        [ParameterOrder(Order = 5)]
        public byte tpMediaConsumo { get; set; }
        [ParameterOrder(Order = 6)]
        public byte stVendasGera { get; set; }
        [ParameterOrder(Order = 7)]
        public byte stRequerAprovaSolicitacao { get; set; }
        [ParameterOrder(Order = 8)]
        public byte stRequerAprovaCotacao { get; set; }
        [ParameterOrder(Order = 9)]
        public byte stRequerAprovaPedido { get; set; }
        [ParameterOrder(Order = 10)]
        public decimal vAprovaAutoPedido { get; set; }
        [ParameterOrder(Order = 11)]
        public byte stProducaoGera { get; set; }
        [ParameterOrder(Order = 12)]
        public byte stIgnoraSaldoRequisicao { get; set; }
        [ParameterOrder(Order = 13)]
        public byte stGeraOpFilhas { get; set; }
        [ParameterOrder(Order = 14)]
        public byte stFechaOpSaldoAproduzir { get; set; }
        [ParameterOrder(Order = 15)]
        public byte stUtilizaConversaoUndApontamento { get; set; }
        [ParameterOrder(Order = 16)]
        public int cOperPadProduto { get; set; }
        [ParameterOrder(Order = 17)]
        public int cOperPadServico { get; set; }
        [ParameterOrder(Order = 18)]
        public int cOperPadBeneficiamento { get; set; }
        [ParameterOrder(Order = 19)]
        public byte stGradeEstoque { get; set; }
        [ParameterOrder(Order = 20)]
        public byte stRastreabilidadeMaterial { get; set; }
        [ParameterOrder(Order = 21)]
        public byte stRastreabilidadeFinais { get; set; }
        [ParameterOrder(Order = 22)]
        public int cFornecedorPagamentoPis { get; set; }
        [ParameterOrder(Order = 23)]
        public int cFornecedorPagamentoCofins { get; set; }
        [ParameterOrder(Order = 24)]
        public int cFornecedorPagamentoCsll { get; set; }
        [ParameterOrder(Order = 25)]
        public int cFornecedorPagamentoIrrf { get; set; }
        [ParameterOrder(Order = 26)]
        public int cFornecedorPagamentoIss { get; set; }
        [ParameterOrder(Order = 27)]
        public int cFornecedorPagamentoInss { get; set; }
        [ParameterOrder(Order = 28)]
        public int cQtdFornecedoresCotacao { get; set; }
        [ParameterOrder(Order = 29)]
        public decimal pIiqFornecimento { get; set; }
        [ParameterOrder(Order = 30)]
        public decimal pIfFornecimento { get; set; }
        [ParameterOrder(Order = 31)]
        public decimal pCertificado { get; set; }
        [ParameterOrder(Order = 32)]
        public decimal pQuestionario { get; set; }
        [ParameterOrder(Order = 33)]
        public byte stLeadTimeCotacao { get; set; }
        [ParameterOrder(Order = 34)]
        public byte stLeadTimeRecebimento { get; set; }
        [ParameterOrder(Order = 35)]
        public byte stLeadTimePedidoCompra { get; set; }
        [ParameterOrder(Order = 36)]
        public byte stCustoMedio { get; set; }
        [ParameterOrder(Order = 37)]
        public byte stCusto { get; set; }



    }
}
