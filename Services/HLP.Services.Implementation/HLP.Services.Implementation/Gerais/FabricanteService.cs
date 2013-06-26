using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Gerais;
using Ninject;
using HLP.Repository.Interfaces.Entries.Gerais;

namespace HLP.Services.Implementation.Entries.Gerais
{
    public class FabricanteService : IFabricanteService
    {
        [Inject]
        public IFabricanteRepository fabricanteRepository { get; set; }

        public Models.Entries.Gerais.FabricanteModel GetFabricante(int idFabricante)
        {
            return fabricanteRepository.GetFabricante(idFabricante);
        }

        public void Save(Models.Entries.Gerais.FabricanteModel fabricante)
        {
            fabricanteRepository.Save(fabricante);
        }

        public void Delete(int idFabricante)
        {
            fabricanteRepository.Delete(idFabricante);
        }

        public int Copy(int idFabricante)
        {
            return fabricanteRepository.Copy(idFabricante);
        }
    }
}
