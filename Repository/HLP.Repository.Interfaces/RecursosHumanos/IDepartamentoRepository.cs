using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.RecursosHumanos;

namespace HLP.Repository.Interfaces.Entries.RecursosHumanos
{
    public interface IDepartamentoRepository
    {
        DepartamentoModel GetDepartamento(int idDepartamento);
        void Save(DepartamentoModel departamento);
        void Delete(int idDepartamento);
        int Copy(int idDepartamento);
        List<DepartamentoModel> GetBySetor(int idSetor);
    }
}
