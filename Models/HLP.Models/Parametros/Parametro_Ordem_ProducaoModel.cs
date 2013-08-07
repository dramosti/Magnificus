using HLP.Comum.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLP.Models.Entries.Parametros
{
    public class Parametro_Ordem_ProducaoModel
    {
        [ParameterOrder(Order = 1)]
        public int? idParametroOrdemProducao { get; set; }
        [ParameterOrder(Order = 2)]
        public byte stProducaoGera { get; set; }
        [ParameterOrder(Order = 3)]
        public byte stGeraOPFilhas { get; set; }
        [ParameterOrder(Order = 4)]
        public byte stFechaOPSaldoAproduzir { get; set; }
        [ParameterOrder(Order = 5)]
        public int? idTipoOperacaoparaOPProduto { get; set; }
        [ParameterOrder(Order = 6)]
        public int? idTipoOperacaoparaOPServico { get; set; }
        [ParameterOrder(Order = 7)]
        public int? idTipoOperacaoparaOPBenificiamento { get; set; }
        [ParameterOrder(Order = 8)]
        public int idEmpresa { get; set; }
    }
}
