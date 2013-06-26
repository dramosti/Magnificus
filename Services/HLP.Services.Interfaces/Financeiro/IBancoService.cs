using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Financeiro;

namespace HLP.Services.Interfaces.Entries.Financeiro
{
    public interface IBancoService
    {
        List<BancoModel> GetAll();
        BancoModel GetBanco(int idBanco);
        void Save(BancoModel banco);
        void Delete(int idBanco);
        int Copy(int idBanco);
    }
}
