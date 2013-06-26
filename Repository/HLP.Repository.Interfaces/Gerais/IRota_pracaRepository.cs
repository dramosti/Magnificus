using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Comercial;
using HLP.Models.Entries.Gerais;

namespace HLP.Repository.Interfaces.Entries.Gerais
{
    public interface IRota_pracaRepository
    {
        void Save(Rota_pracaModel objRota_Praca);
        void Update(Rota_pracaModel objRota_Praca);
        void Delete(Rota_pracaModel objRota_Praca);
        void Delete(int idRota);
        void Copy(Rota_pracaModel objRota_Praca);
        Rota_pracaModel GetRota_Praca(int idRotaPraca);
        List<Rota_pracaModel> GetAllRota_Praca(int idRota);
    }
}
