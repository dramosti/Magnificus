using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Gerais
{
    public class RotaModel
    {
        [ParameterOrder(Order = 1)]
        public int? idRota { get; set; }

        [ParameterOrder(Order = 2)]
        public string xRota { get; set; }

        [ParameterOrder(Order = 3)]
        public int idListaPrecoPai { get; set; }

        [ParameterOrder(Order = 4)]
        public bool Ativo { get; set; }

        public List<Rota_pracaModel> lRota_Praca = new List<Rota_pracaModel>();
    }
}
