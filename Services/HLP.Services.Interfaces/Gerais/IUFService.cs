using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;
using System.Data;

namespace HLP.Services.Interfaces.Entries.Gerais
{
    public interface IUFService
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
