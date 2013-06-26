using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Fiscal
{
    public class Operacao_importacaoModel
    {
        [ParameterOrder(Order = 1)]
        public int idTipoOperacao { get; set; }
        [ParameterOrder(Order = 2)]
        public int? idOperacaoImportacao { get; set; }
        [ParameterOrder(Order = 3)]
        public decimal pII { get; set; }
        [ParameterOrder(Order = 4)]
        public byte stCompoeBaseIpi { get; set; }
        [ParameterOrder(Order = 5)]
        public byte stCompoeFatorIcms { get; set; }
        [ParameterOrder(Order = 6)]
        public byte stCompoeBaseIcmsOculto { get; set; }
        [ParameterOrder(Order = 7)]
        public byte stCompoeIcmsOculto { get; set; }
        [ParameterOrder(Order = 8)]
        public byte stCompoeFatorPisCofins { get; set; }
        [ParameterOrder(Order = 9)]
        public byte stCompoeBasePis { get; set; }
        [ParameterOrder(Order = 10)]
        public byte stCompoePis { get; set; }
        [ParameterOrder(Order = 11)]
        public byte stCompoeBaseCofins { get; set; }
        [ParameterOrder(Order = 12)]
        public byte stCompoeCofins { get; set; }
        [ParameterOrder(Order = 13)]
        public byte stCompoeBaseIcmsNormal { get; set; }
        [ParameterOrder(Order = 14)]
        public byte stCompoeIcmsNormal { get; set; }
        [ParameterOrder(Order = 15)]
        public byte stCompoeValorProdutos { get; set; }
        [ParameterOrder(Order = 16)]
        public byte stCompoeValorNf { get; set; }


    }
}
