using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Gerais
{
    public class Unidade_medidaModel
    {
        [ParameterOrder(Order = 1)]
        public int? idUnidadeMedida { get; set; }
        [ParameterOrder(Order = 2)]
        public string xSiglaPadrao { get; set; }
        [ParameterOrder(Order = 3)]
        public string xUnidadeMedida { get; set; }
        [ParameterOrder(Order = 4)]
        public int nCasasDecimais { get; set; }

    }
}
