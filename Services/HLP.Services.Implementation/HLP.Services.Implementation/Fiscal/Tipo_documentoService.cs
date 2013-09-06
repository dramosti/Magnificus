using HLP.Models.Entries.Fiscal;
using HLP.Repository.Interfaces.Entries.Fiscal;
using HLP.Services.Interfaces.Entries.Fiscal;
using Ninject;
using System.Collections.Generic;

namespace HLP.Services.Implementation.Entries.Fiscal
{
    public class Tipo_documentoService : ITipo_documentoService
    {
        [Inject]
        public ITipo_documentoRepository documentoRepository { get; set; }

        public Tipo_documentoModel GetDocumento(int idTipoDocumento)
        {
            return documentoRepository.GetDocumento(idTipoDocumento);
        }

        public void Save(Tipo_documentoModel documento)
        {
            documentoRepository.Save(documento);
        }

        public void Delete(int idTipoDocumento)
        {
            documentoRepository.Delete(idTipoDocumento);
        }

        public void Begin()
        {
            documentoRepository.Begin();
        }

        public void Commit()
        {
            documentoRepository.Commit();
        }

        public void RollBack()
        {
            documentoRepository.RollBack();
        }


        public int Copy(int idTipoDocumento)
        {
            return documentoRepository.Copy(idTipoDocumento);
        }

        public List<Tipo_documentoModel> GetTipo_documentoAll()
        {
            return documentoRepository.GetTipo_documentoAll();
        }
    }
}
