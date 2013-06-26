using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Financeiro;
using HLP.Models.Entries.Financeiro;
using Ninject;
using HLP.Repository.Interfaces.Entries.Financeiro;

namespace HLP.Services.Implementation.Entries.Financeiro
{
    public class Conta_bancariaService : IConta_bancariaService
    {
        [Inject]
        public IConta_bancariaRepository contaRepository { get; set; }

        public List<Conta_bancariaModel> GetByAgencia(int idAgencia)
        {
            return contaRepository.GetByAgencia(idAgencia);
        }

        public Conta_bancariaModel GetConta(int idContaBancaria)
        {
            return contaRepository.GetConta(idContaBancaria);
        }

        public void Save(Conta_bancariaModel conta)
        {
            contaRepository.Save(conta);
        }

        public void Delete(int idContaBancaria)
        {
            contaRepository.Delete(idContaBancaria);
        }


        public int Copy(int idContaBancaria)
        {
            return contaRepository.Copy(idContaBancaria);
        }

       
    }
}
