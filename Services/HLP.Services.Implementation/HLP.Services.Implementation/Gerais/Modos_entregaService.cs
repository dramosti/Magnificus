using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Gerais;
using HLP.Models.Entries.Gerais;
using HLP.Repository.Interfaces.Entries.Gerais;
using Ninject;

namespace HLP.Services.Implementation.Entries.Gerais
{
    public class Modos_entregaService : IModos_entregaService
    {
        [Inject]
        public IModos_entregaRepository modoRepository { get; set; }

        public Modos_entregaModel GetModo(int idModosEntrega)
        {
            return modoRepository.GetModo(idModosEntrega);
        }

        public void Save(Modos_entregaModel modo)
        {
            modoRepository.Save(modo);
        }

        public void Delete(int idModosEntrega)
        {
            modoRepository.Delete(idModosEntrega);
        }


        public int Copy(int idModosEntrega)
        {
            return modoRepository.Copy(idModosEntrega);
        }
    }
}
