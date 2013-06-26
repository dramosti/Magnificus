using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Fiscal
{
    public class Tipo_documento_oper_validaModel
    {
        [ParameterOrder(Order = 1)]
        public int? idTipoDocumentoOperValida { get; set; }

        [ParameterOrder(Order = 2)]
        public int idTipoOperacao { get; set; }

        [ParameterOrder(Order = 3)]
        public int idTipoDocumento { get; set; }

    }
}
