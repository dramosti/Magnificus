using HLP.Models.Entries.Fiscal;

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
    }
}
