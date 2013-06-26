using System.Collections.Generic;
using HLP.Services.Interfaces.Entries.Comercial;
using Ninject;
using HLP.Repository.Interfaces.Entries.Gerais;
using HLP.Models.Entries.Gerais;
using HLP.Services.Interfaces.Entries.Gerais;

namespace HLP.Services.Implementation.Entries.Gerais
{
    public class Rota_pracaService : IRota_pracaService
    {
        [Inject]
        public IRota_pracaRepository _Rota_PracaRepository { get; set; }

        public void Save(Rota_pracaModel objRota_Praca)
        {
            _Rota_PracaRepository.Save(objRota_Praca);
        }

        public void Update(Rota_pracaModel objRota_Praca)
        {
            _Rota_PracaRepository.Update(objRota_Praca);
        }

        public void Delete(Rota_pracaModel objRota_Praca)
        {
            _Rota_PracaRepository.Delete(objRota_Praca);
        }

        public void Delete(int idRota)
        {
            _Rota_PracaRepository.Delete(idRota);
        }

        public void Copy(Rota_pracaModel objRota_Praca)
        {
            _Rota_PracaRepository.Copy(objRota_Praca);
        }

        public Rota_pracaModel GetRota_Praca(int idRotaPraca)
        {
            return _Rota_PracaRepository.GetRota_Praca(idRotaPraca);
        }

        public List<Rota_pracaModel> GetAllRota_Praca(int idRota)
        {
            return _Rota_PracaRepository.GetAllRota_Praca(idRota);
        }
    }
}
