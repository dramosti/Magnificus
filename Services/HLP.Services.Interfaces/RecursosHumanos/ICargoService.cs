using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.RecursosHumanos;

namespace HLP.Services.Interfaces.Entries.RecursosHumanos
{
    public interface ICargoService
    {
        CargoModel GetCargo(int idCargo);
        void Save(CargoModel cargo);
        void Delete(int idCargo);
        int Copy(int idCargo);
    }
}
