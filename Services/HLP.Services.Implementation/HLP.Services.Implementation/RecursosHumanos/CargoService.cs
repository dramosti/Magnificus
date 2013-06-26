using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.RecursosHumanos;
using HLP.Models.Entries.RecursosHumanos;
using Ninject;
using HLP.Repository.Interfaces.Entries.RecursosHumanos;

namespace HLP.Services.Implementation.Entries.RecursosHumanos
{
    public class CargoService : ICargoService
    {
        [Inject]
        public ICargoRepository cargoRepository { get; set; }

        public CargoModel GetCargo(int idCargo)
        {
            return cargoRepository.GetCargo(idCargo);
        }

        public void Save(CargoModel cargo)
        {
            cargoRepository.Save(cargo);
        }

        public void Delete(int idCargo)
        {
            cargoRepository.Delete(idCargo);
        }

        public int Copy(int idCargo)
        {
            return cargoRepository.Copy(idCargo);
        }
    }
}
