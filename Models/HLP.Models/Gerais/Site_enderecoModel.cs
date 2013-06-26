using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Gerais
{
    public class Site_enderecoModel : BaseModelFilhos
    {

        private int? _idEndereco;
        [ParameterOrder(Order = 1)]
        public int? idEndereco
        {
            get { return _idEndereco; }
            set
            {
                _idEndereco = value;
                base.SetID(value);
            }
        }
        [ParameterOrder(Order = 2)]
        public byte stTipoEndereco { get; set; }
        [ParameterOrder(Order = 3)]
        public string xCEP { get; set; }
        [ParameterOrder(Order = 4)]
        public byte stLogradouro { get; set; }
        [ParameterOrder(Order = 5)]
        public string xEndereco { get; set; }
        [ParameterOrder(Order = 6)]
        public string nNumero { get; set; }
        [ParameterOrder(Order = 7)]
        public string xComplemento { get; set; }
        [ParameterOrder(Order = 8)]
        public string xBairro { get; set; }
        [ParameterOrder(Order = 9)]
        public string xLatitude { get; set; }
        [ParameterOrder(Order = 10)]
        public string xLongitude { get; set; }
        [ParameterOrder(Order = 11)]
        public string xFusoHorario { get; set; }
        [ParameterOrder(Order = 12)]
        public string xCaixaPostal { get; set; }
        [ParameterOrder(Order = 13)]
        public int idSite { get; set; }
        [ParameterOrder(Order = 14)]
        public int idCidade { get; set; }
        [ParameterOrder(Order = 15)]
        public byte? stPrincipal { get; set; }
        [ParameterOrder(Order = 16)]
        public string xNome { get; set; }


    }
}
