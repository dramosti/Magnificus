using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Fiscal
{
    public class Codigo_IcmsModel : BaseModelFilhos
    {
        private int? _idCodigoIcms;
        [ParameterOrder(Order = 1)]
        public int? idCodigoIcms
        {
            get { return _idCodigoIcms; }
            set
            {
                _idCodigoIcms = value;
                base.SetID(value);
            }
        }
        [ParameterOrder(Order = 2)]
        public int idUf { get; set; }
        [ParameterOrder(Order = 3)]
        public decimal pIcmsEstado { get; set; }
        [ParameterOrder(Order = 4)]
        public decimal pIcmsInterna { get; set; }
        [ParameterOrder(Order = 5)]
        public decimal pIcmsSubstituicaoTributaria { get; set; }
        [ParameterOrder(Order = 6)]
        public decimal pIcmsNaoContribruinteForaEstado { get; set; }
        [ParameterOrder(Order = 7)]
        public decimal vCoeficienteIcms { get; set; }
        [ParameterOrder(Order = 8)]
        public string xFundamLegalCodTrib { get; set; }
        [ParameterOrder(Order = 9)]
        public int idCodigoIcmsPai { get; set; }
        [ParameterOrder(Order = 10)]
        public decimal? pMvaSubstituicaoTributaria { get; set; }
        [ParameterOrder(Order = 11)]
        public int? idCSTIcms { get; set; }
    }
}
