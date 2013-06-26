using HLP.Models.Entries.Gerais;
using HLP.Repository.Interfaces.Entries.Gerais;
using HLP.Services.Interfaces.Entries.Gerais;
using Ninject;

namespace HLP.Services.Implementation.Entries.Gerais
{
    public class Ramo_atividadeService : IRamo_atividadeService
    {
        [Inject]
        public IRamo_atividadeRepository ramoRepository { get; set; }

        public Ramo_atividadeModel GetRamo(int idRamoAtividade)
        {
            return ramoRepository.GetRamo(idRamoAtividade);
        }

        public void Save(Ramo_atividadeModel ramo)
        {
            ramoRepository.Save(ramo);
        }

        public void Delete(int idRamoAtividade)
        {
            ramoRepository.Delete(idRamoAtividade);
        }


        public int Copy(int idRamoAtividade)
        {
            return ramoRepository.Copy(idRamoAtividade);
        }
    }
}
