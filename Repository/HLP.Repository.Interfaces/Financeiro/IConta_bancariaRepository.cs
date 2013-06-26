using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Financeiro;

namespace HLP.Repository.Interfaces.Entries.Financeiro
{
    public interface IConta_bancariaRepository
    {
        List<Conta_bancariaModel> GetByAgencia(int idAgencia);
        Conta_bancariaModel GetConta(int idContaBancaria);
        void Save(Conta_bancariaModel conta);
        void Delete(int idContaBancaria);
        int Copy(int idContaBancaria);
    }
}
