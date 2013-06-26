using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;

namespace HLP.Services.Interfaces.Entries.Gerais
{
    public interface IMoedaService
    {
        MoedaModel GetMoeda(int idMoeda);
        void Save(MoedaModel moeda);
        void Delete(int idMoeda);
        bool IsNew(string xSiglaMoeda);
        int Copy(int idMoeda);
    }
}
