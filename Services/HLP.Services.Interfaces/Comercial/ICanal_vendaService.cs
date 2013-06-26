using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Comercial;

namespace HLP.Services.Interfaces.Entries.Comercial
{
    public interface ICanal_vendaService
    {
        Canal_vendaModel GetCanal(int idCanalVenda);
        void Save(Canal_vendaModel canal);
        void Delete(int idCanalVenda);
        int Copy(int idCanalVenda);
    }
}
