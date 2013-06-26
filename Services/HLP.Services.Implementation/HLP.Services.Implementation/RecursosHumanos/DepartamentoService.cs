using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.RecursosHumanos;
using HLP.Models.Entries.RecursosHumanos;
using Ninject;
using HLP.Repository.Interfaces.Entries.RecursosHumanos;

namespace HLP.Services.Implementation.Entries.RecursosHumanos
{
    public class DepartamentoService : IDepartamentoService
    {
        [Inject]
        public IDepartamentoRepository departamentolRepository { get; set; }

        public DepartamentoModel GetDepartamento(int idDepartamento)
        {
            return departamentolRepository.GetDepartamento(idDepartamento);
        }

        public void Save(DepartamentoModel departamento)
        {
            departamentolRepository.Save(departamento);
        }

        public void Delete(int idDepartamento)
        {
            departamentolRepository.Delete(idDepartamento);
        }

        public int Copy(int idDepartamento)
        {
            return departamentolRepository.Copy(idDepartamento);
        }

        public List<DepartamentoModel> GetBySetor(int idSetor)
        {
            return departamentolRepository.GetBySetor(idSetor: idSetor);
        }
    }
}
