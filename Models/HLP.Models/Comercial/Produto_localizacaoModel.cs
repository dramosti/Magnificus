﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Comercial
{
    public class Produto_localizacaoModel
    {
        [ParameterOrder(Order = 1)]
        public int? idProdutoLocalizacao { get; set; }
        [ParameterOrder(Order = 2)]
        public string xNome { get; set; }
        [ParameterOrder(Order = 3)]
        public string xDescricao { get; set; }
        [ParameterOrder(Order = 4)]
        public int idDeposito { get; set; }

    }
}
