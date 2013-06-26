using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;

namespace HLP.Services.Interfaces.Entries.Gerais
{
    public interface IRamo_atividadeService
    {
        Ramo_atividadeModel GetRamo(int idRamoAtividade);
        void Save(Ramo_atividadeModel ramo);
        void Delete(int idRamoAtividade);
        int Copy(int idRamoAtividade);
    }
}
