using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;

namespace HLP.Repository.Interfaces.Entries.Gerais
{
    public interface IMoedaRepository
    {
        MoedaModel GetMoeda(int idMoeda);
        void Save(MoedaModel moeda);
        void Delete(int idMoeda);
        bool IsNew(string xSiglaMoeda);
        int Copy(int idMoeda);
    }
}
