using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.RecursosHumanos;

namespace HLP.Services.Interfaces.Entries.RecursosHumanos
{
    public interface ISetorService
    {
        SetorModel GetSetor(int idSetor);
        void Save(SetorModel setor);
        void Delete(int idSetor);
        int Copy(int idSetor);
        List<SetorModel> GetAll();
    }
}
