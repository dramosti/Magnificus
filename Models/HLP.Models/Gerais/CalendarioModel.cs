using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Gerais
{
    public class CalendarioModel
    {
        [ParameterOrder(Order = 1)]
        public int? idCalendario { get; set; }
        [ParameterOrder(Order = 2)]
        public string xNome { get; set; }
        [ParameterOrder(Order = 3)]
        public string xDescricao { get; set; }
        [ParameterOrder(Order = 4)]
        public int? idCalendarioBase { get; set; }
        [ParameterOrder(Order = 5)]
        public int idEmpresa { get; set; }

        public List<Calendario_DetalheModel> lCalendario_Detalhe = new List<Calendario_DetalheModel>();
    }
}
