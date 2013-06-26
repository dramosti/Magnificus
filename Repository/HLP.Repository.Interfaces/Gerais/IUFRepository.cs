using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;
using System.Data;

namespace HLP.Repository.Interfaces.Entries.Gerais
{
    public interface IUFRepository
    {
        List<UFModel> GetAll();
        UFModel GetUF(int idUF);
        DataTable GetAlltoComboBox();
        void Save(UFModel uf);
        void Delete(int idUF);
        bool IsNew(string xSiglaUf);
        int Copy(int idUF);
    }
}
