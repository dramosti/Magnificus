using HLP.Comum.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLP.Models.Entries.Parametros
{
    public class Parametro_EstoqueModel
    {
        [ParameterOrder(Order = 1)]
        public int idEmpresa { get; set; }
        [ParameterOrder(Order = 2)]
        public int? idParametroEstoque { get; set; }
        [ParameterOrder(Order = 3)]
        public byte stEstoqueMinimo { get; set; }
        [ParameterOrder(Order = 4)]
        public byte stEstoqueMaximo { get; set; }
        [ParameterOrder(Order = 5)]
        public byte stMediaConsumo { get; set; }
        [ParameterOrder(Order = 6)]
        public byte stVendasGera { get; set; }
        [ParameterOrder(Order = 7)]
        public byte stGradeEstoque { get; set; }
        [ParameterOrder(Order = 8)]
        public byte stRastreabilidadeMaterial { get; set; }
        [ParameterOrder(Order = 9)]
        public byte stRastreabilidadeProdutoAcabado { get; set; }
    }
}
