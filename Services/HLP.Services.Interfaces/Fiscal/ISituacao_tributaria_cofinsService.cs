using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Fiscal;

namespace HLP.Services.Interfaces.Entries.Fiscal
{
    public interface ISituacao_tributaria_cofinsService
    {
        Situacao_tributaria_cofinsModel GetStCofins(int idCSTCofins);
        void Save(Situacao_tributaria_cofinsModel cofins);
        void Delete(int idCSTCofins);
        int Copy(int idCSTCofins);
    }
}
