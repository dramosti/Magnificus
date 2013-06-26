using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Financeiro
{
    public class Agencia_ContatoModel : BaseModelFilhos
    {
        private int? _idAgenciaContato;
        [ParameterOrder(Order = 1)]
        public int? idAgenciaContato
        {
            get { return _idAgenciaContato; }
            set
            {
                _idAgenciaContato = value;
                base.SetID(value);
            }
        }
        [ParameterOrder(Order = 2)]
        public int idAgencia { get; set; }
        [ParameterOrder(Order = 3)]
        public int idContato { get; set; }


    }
}
