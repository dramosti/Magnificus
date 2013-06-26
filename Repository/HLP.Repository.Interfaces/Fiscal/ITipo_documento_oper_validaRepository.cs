using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Fiscal;

namespace HLP.Repository.Interfaces.Entries.Fiscal
{
    public interface ITipo_documento_oper_validaRepository
    {
        List<Tipo_documento_oper_validaModel> GetAll(int idTipoDocumento);
        void Save(Tipo_documento_oper_validaModel documentoOper);
        void Delete(int idTipoDocumentoOperValida);
        void Delete(int idTipoDocumento, List<int?> lidTipoDocumentoOperValida);
    }
}
