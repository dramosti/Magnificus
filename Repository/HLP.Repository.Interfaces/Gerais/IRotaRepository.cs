using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Comercial;
using HLP.Models.Entries.Gerais;

namespace HLP.Repository.Interfaces.Entries.Gerais
{
    public interface IRotaRepository
    {
        void Save(RotaModel objRota);
        void Delete(RotaModel objRota);
        void Copy(RotaModel objRota);
        RotaModel GetRota(int idRota);

        void BeginTransaction();
        void CommitTransaction();
        void RollackTransaction();
    }
}
