using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Gerais
{
    public class Calendario_DetalheModel : BaseModelFilhos
    {
        private int? _idCalendarioDetalhe;
        [ParameterOrder(Order = 1)]
        public int? idCalendarioDetalhe
        {
            get { return _idCalendarioDetalhe; }
            set
            {
                _idCalendarioDetalhe = value;
                base.SetID(value);
            }
        }
        [ParameterOrder(Order = 2)]
        public DateTime dCalendario { get; set; }
        [ParameterOrder(Order = 3)]
        public DateTime dHoraInicio { get; set; }
        [ParameterOrder(Order = 4)]
        public DateTime dHoraTermino { get; set; }
        [ParameterOrder(Order = 5)]
        public int idCalendario { get; set; }

    }
}
