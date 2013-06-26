using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Gerais
{
    public class DepositoModel
    {
        [ParameterOrder(Order = 1)]
        public int? idDeposito { get; set; }
        [ParameterOrder(Order = 2)]
        public int idSite { get; set; }
        [ParameterOrder(Order = 3)]
        public string xDeposito { get; set; }
        [ParameterOrder(Order = 4)]
        public string xDescricao { get; set; }
        [ParameterOrder(Order = 5)]
        public byte stTipo { get; set; }
        [ParameterOrder(Order = 6)]
        public byte stGrupoIdentificacao { get; set; }

    }
}
