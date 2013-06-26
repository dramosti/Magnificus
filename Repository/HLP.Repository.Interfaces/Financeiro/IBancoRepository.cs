using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Financeiro;

namespace HLP.Repository.Interfaces.Entries.Financeiro
{
    public interface IBancoRepository
    {
        List<BancoModel> GetAll();
        BancoModel GetBanco(int idBanco);
        void Save(BancoModel banco);
        void Delete(int idBanco);
        int Copy(int idBanco);
    }
}
