using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;

namespace HLP.Repository.Interfaces.Entries.Gerais
{
    public interface IFabricanteRepository
    {
        FabricanteModel GetFabricante(int idFabricante);
        void Save(FabricanteModel fabricante);
        void Delete(int idFabricante);
        int Copy(int idFabricante);
    }
}
