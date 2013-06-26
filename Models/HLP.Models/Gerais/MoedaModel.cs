using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Gerais
{
    public class MoedaModel
    {
        [ParameterOrder(Order = 1)]
        public int? idMoeda { get; set; }
        [ParameterOrder(Order = 2)]
        public string xSiglaMoeda { get; set; }
        [ParameterOrder(Order = 3)]
        public string xMoeda { get; set; }
        [ParameterOrder(Order = 4)]
        public string xSimbolo { get; set; }

    }
}
