using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;

namespace HLP.Services.Interfaces.Entries.Gerais
{
    public interface IEmpresaService
    {
        void Save(EmpresaModel objEmpresa);
        void Delete(int idEmpresa);
        int Copy(EmpresaModel objEmpresa);
        EmpresaModel GetEmpresa(int idEmpresa, bool bChildren = false);
        List<EmpresaModel> GetAllEmpresa(bool bEstruturaComboBox);
        void SalvarParametrosEmpresa(EmpresaParametrosModel objParametrosModel);
        EmpresaParametrosModel GetParametrosEmpresa();
    }
}
