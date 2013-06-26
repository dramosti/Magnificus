using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;

namespace HLP.Services.Interfaces.Entries.Gerais
{
    public interface IRotaService
    {
        void Save(RotaModel objRota);
        void Delete(RotaModel objRota);
        void Copy(RotaModel objRota);
        RotaModel GetRota(int idRota, bool bChildren = false);
    }
}
