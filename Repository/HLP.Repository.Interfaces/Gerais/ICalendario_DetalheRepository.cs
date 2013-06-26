using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;

namespace HLP.Repository.Interfaces.Entries.Gerais
{
    public interface ICalendario_DetalheRepository
    {
        void Save(Calendario_DetalheModel objCalendario_Detalhe);
        void Update(Calendario_DetalheModel objCalendario_Detalhe);
        void Delete(Calendario_DetalheModel objCalendario_Detalhe);
        void Delete(int idCalendario);
        void Copy(Calendario_DetalheModel objCalendario_Detalhe);
        Calendario_DetalheModel GetCalendario_Detalhe(int idCalendarioDetalhe);
        List<Calendario_DetalheModel> GetAllCalendario_Detalhe(int idCalendario);
    }
}
