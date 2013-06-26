using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Comercial;

namespace HLP.Repository.Interfaces.Entries.Comercial
{
    public interface IMultasRepository
    {
        MultasModel GetMulta(int idMultas);
        void Save(MultasModel multa);
        void Delete(int idMultas);
        int Copy(int idMultas);
    }
}
