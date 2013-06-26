using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Gerais;
using HLP.Models.Entries.Gerais;
using Ninject;
using HLP.Repository.Interfaces.Entries.Gerais;

namespace HLP.Services.Implementation.Entries.Gerais
{
    public class Calendario_DetalheService : ICalendario_DetalheService
    {
        [Inject]
        public ICalendario_DetalheRepository _Calendario_DetalheRepository { get; set; }

        public void Save(Calendario_DetalheModel objCalendario_Detalhe)
        {
            _Calendario_DetalheRepository.Save(objCalendario_Detalhe);
        }

        public void Update(Calendario_DetalheModel objCalendario_Detalhe)
        {
            _Calendario_DetalheRepository.Update(objCalendario_Detalhe);
        }

        public void Delete(Calendario_DetalheModel objCalendario_Detalhe)
        {
            _Calendario_DetalheRepository.Delete(objCalendario_Detalhe);
        }

        public void Delete(int idCalendario)
        {
            _Calendario_DetalheRepository.Delete(idCalendario);
        }

        public void Copy(Calendario_DetalheModel objCalendario_Detalhe)
        {
            _Calendario_DetalheRepository.Copy(objCalendario_Detalhe);
        }

        public Calendario_DetalheModel GetCalendario_Detalhe(int idCalendarioDetalhe)
        {
            return _Calendario_DetalheRepository.GetCalendario_Detalhe(idCalendarioDetalhe);
        }

        public List<Calendario_DetalheModel> GetAllCalendario_Detalhe(int idCalendario)
        {
            return _Calendario_DetalheRepository.GetAllCalendario_Detalhe(idCalendario);
        }
    }
}
