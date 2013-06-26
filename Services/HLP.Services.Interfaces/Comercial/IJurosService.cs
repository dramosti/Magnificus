using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Comercial;

namespace HLP.Services.Interfaces.Entries.Comercial
{
    public interface IJurosService
    {
        JurosModel GetJuros(int idJuros);
        void Save(JurosModel juros);
        void Delete(int idJuros);
        int Copy(int idJuros);
    }
}
