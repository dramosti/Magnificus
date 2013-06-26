using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Gerais
{
    public class ConversaoModel : BaseModelFilhos
    {
        private int? _idConversao;
        [ParameterOrder(Order = 1)]
        public int? idConversao
        {
            get { return _idConversao; }
            set
            {
                _idConversao = value;
                base.SetID(value);
            }
        }
        [ParameterOrder(Order = 2)]
        public int idEmpresa { get; set; }
        [ParameterOrder(Order = 3)]
        public int idProduto { get; set; }
        [ParameterOrder(Order = 4)]
        public decimal? nQuantidadeAdicional { get; set; }
        [ParameterOrder(Order = 5)]
        public decimal nFator { get; set; }
        [ParameterOrder(Order = 6)]
        public byte? stArrendondar { get; set; }
        [ParameterOrder(Order = 7)]
        public int idDeUnidadeMedida { get; set; }
        [ParameterOrder(Order = 8)]
        public int idParaUnidadeMedida { get; set; }

    }
}
