using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Fiscal;
using HLP.Models.Entries.Fiscal;
using HLP.Repository.Interfaces.Entries.Fiscal;
using Ninject;

namespace HLP.Services.Implementation.Entries.Fiscal
{
    public class Tipo_documento_oper_validaService : ITipo_documento_oper_validaService
    {
        [Inject]
        public ITipo_documento_oper_validaRepository documentoOperRepository { get; set; }


        public void Save(Tipo_documento_oper_validaModel documentoOper)
        {
            documentoOperRepository.Save(documentoOper);
        }

        public void Delete(int idTipoDocumentoOperValida)
        {
            documentoOperRepository.Delete(idTipoDocumentoOperValida);
        }

        public void Delete(int idTipoDocumento, List<int?> lidTipoDocumentoOperValida)
        {
            documentoOperRepository.Delete(idTipoDocumento, lidTipoDocumentoOperValida);
        }

        public List<Tipo_documento_oper_validaModel> GetAll(int idTipoDocumento)
        {
            return documentoOperRepository.GetAll(idTipoDocumento);
        }
    }
}
