using HLP.Models.Entries.Fiscal;
using System.Collections.Generic;

namespace HLP.Services.Interfaces.Entries.Fiscal
{
    public interface ITipo_documentoService
    {
        Tipo_documentoModel GetDocumento(int idTipoDocumento);
        void Save(Tipo_documentoModel documento);
        void Delete(int idTipoDocumento);
        void Begin();
        void Commit();
        void RollBack();
        int Copy(int idTipoDocumento);
        List<Tipo_documentoModel> GetTipo_documentoAll();
    }
}
