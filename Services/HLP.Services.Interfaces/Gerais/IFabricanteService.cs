using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;

namespace HLP.Services.Interfaces.Entries.Gerais
{
    public interface IFabricanteService
    {
        FabricanteModel GetFabricante(int idFabricante);
        void Save(FabricanteModel fabricante);
        void Delete(int idFabricante);
        int Copy(int idFabricante);
    }
}
