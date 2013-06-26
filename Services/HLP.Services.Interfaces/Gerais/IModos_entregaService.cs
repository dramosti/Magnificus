using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;

namespace HLP.Services.Interfaces.Entries.Gerais
{
    public interface IModos_entregaService
    {
        Modos_entregaModel GetModo(int idModosEntrega);
        void Save(Modos_entregaModel modo);
        void Delete(int idModosEntrega);
        int Copy(int idModosEntrega);
    }
}
