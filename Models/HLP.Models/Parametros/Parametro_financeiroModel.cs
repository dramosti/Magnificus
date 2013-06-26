using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Parametros
{
    public class Parametro_financeiroModel
    {
        [ParameterOrder(Order = 1)]
        public int idEmpresa { get; set; }
        [ParameterOrder(Order = 2)]
        public int? idParametroFinanceiro { get; set; }
        [ParameterOrder(Order = 3)]
        public byte stPedidoCpraGeraPrevisao { get; set; }
        [ParameterOrder(Order = 4)]
        public byte stPedidoVdaGeraPrevisao { get; set; }
        [ParameterOrder(Order = 5)]
        public byte stPagaComissaoPor { get; set; }
        [ParameterOrder(Order = 6)]
        public byte stCreditoAprovado { get; set; }
        [ParameterOrder(Order = 7)]
        public byte stBloqueiaClientePosCartaCobranca { get; set; }

    }
}
