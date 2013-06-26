using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Gerais
{
    public class Rota_pracaModel : BaseModelFilhos
    {

        private int? _idRotaPraca;
        [ParameterOrder(Order = 1)]
        public int? idRotaPraca
        {
            get { return _idRotaPraca; }
            set
            {
                _idRotaPraca = value;
                base.SetID(value);
            }
        }
        [ParameterOrder(Order = 2)]
        public int nOrdem { get; set; }
        [ParameterOrder(Order = 3)]
        public int? nDistanciaProximaCidade { get; set; }
        [ParameterOrder(Order = 4)]
        public int idCidade { get; set; }
        [ParameterOrder(Order = 5)]
        public int idRota { get; set; }

    }
}
