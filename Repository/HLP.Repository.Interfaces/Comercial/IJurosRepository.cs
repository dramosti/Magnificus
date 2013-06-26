using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Comercial;

namespace HLP.Repository.Interfaces.Entries.Comercial
{
    public interface IJurosRepository
    {
        JurosModel GetJuros(int idJuros);
        void Save(JurosModel juros);
        void Delete(int idJuros);
        int Copy(int idJuros);
    }
}
