﻿using HLP.Comum.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLP.Models.Entries.Parametros
{
    public class Parametro_CustosModel
    {
        [ParameterOrder(Order = 1)]
        public int idEmpresa { get; set; }
        [ParameterOrder(Order = 2)]
        public int? idParametroCustos { get; set; }
        [ParameterOrder(Order = 3)]
        public string xHorasTrabalhadasDia { get; set; }
        [ParameterOrder(Order = 4)]
        public string xDiasTrabalhadasSemana { get; set; }
        [ParameterOrder(Order = 5)]
        public byte stCustoComposicao { get; set; }
        [ParameterOrder(Order = 6)]
        public byte stValorVenda { get; set; }
        [ParameterOrder(Order = 7)]
        public byte stAtualizaValorCusto { get; set; }
        [ParameterOrder(Order = 8)]
        public byte stAtualizaValorVenda { get; set; }
        [ParameterOrder(Order = 9)]
        public byte stCustoDefault { get; set; }
        [ParameterOrder(Order = 10)]
        public byte stCustoMedio { get; set; }
        [ParameterOrder(Order = 11)]
        public byte stCompoeBaseCalculoCustoOperacional { get; set; }
        [ParameterOrder(Order = 12)]
        public int? idTipoOperacao { get; set; }
    }
}
