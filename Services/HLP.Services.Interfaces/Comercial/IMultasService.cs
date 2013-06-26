using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Comercial;

namespace HLP.Services.Interfaces.Entries.Comercial
{
    public interface IMultasService
    {
        MultasModel GetMulta(int idMultas);
        void Save(MultasModel multa);
        void Delete(int idMultas);
        int Copy(int idMultas);
    }
}
