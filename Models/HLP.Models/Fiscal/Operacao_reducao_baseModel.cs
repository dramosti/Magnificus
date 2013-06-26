using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Fiscal
{
    public class Operacao_reducao_baseModel
    {
        [ParameterOrder(Order = 1)]
        public int idTipoOperacao { get; set; }
        [ParameterOrder(Order = 2)]
        public int? idOperacaoReducaoBase { get; set; }
        [ParameterOrder(Order = 3)]
        public decimal pReducaoIcms { get; set; }
        [ParameterOrder(Order = 4)]
        public decimal pReducaoIcmsSubstTributaria { get; set; }
        [ParameterOrder(Order = 5)]
        public int idUf { get; set; }

    }
}
