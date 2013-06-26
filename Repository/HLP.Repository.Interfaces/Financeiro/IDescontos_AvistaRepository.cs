using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Financeiro;

namespace HLP.Repository.Interfaces.Entries.Financeiro
{
    public interface IDescontos_AvistaRepository
    {
        Descontos_AvistaModel GetDesconto(int idDescontosAvista);
        List<Descontos_AvistaModel> GetAll();
        void Save(Descontos_AvistaModel desconto);
        void Delete(int idDescontosAvista);
        int Copy(int idDescontosAvista);
    }
}
