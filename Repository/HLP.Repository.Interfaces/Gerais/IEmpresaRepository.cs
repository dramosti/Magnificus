using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;

namespace HLP.Repository.Interfaces.Entries.Gerais
{
    public interface IEmpresaRepository
    {
        void Save(EmpresaModel objEmpresa);
        void Delete(int idEmpresa);
        int Copy(EmpresaModel objModel);
        EmpresaModel GetEmpresa(int idEmpresa);
        List<EmpresaModel> GetAllEmpresa();
        void BeginTransaction();
        void CommitTransaction();
        void RollackTransaction();
    }
}
