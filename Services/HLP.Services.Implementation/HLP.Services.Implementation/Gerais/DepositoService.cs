using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Gerais;
using HLP.Models.Entries.Gerais;
using Ninject;
using HLP.Repository.Interfaces.Entries.Gerais;

namespace HLP.Services.Implementation.Entries.Gerais
{
    public class DepositoService : IDepositoService
    {
        [Inject]
        public IDepositoRepository depositoRepository { get; set; }

        public List<DepositoModel> GetBySite(int idSite)
        {
            return depositoRepository.GetBySite(idSite);
        }


        public DepositoModel GetDeposito(int idDeposito)
        {
            return depositoRepository.GetDeposito(idDeposito);
        }

        public void Save(DepositoModel deposito)
        {
            depositoRepository.Save(deposito);
        }

        public void Delete(int idDeposito)
        {
            depositoRepository.Delete(idDeposito);
        }


        public int Copy(int idDeposito)
        {
            return depositoRepository.Copy(idDeposito);
        }
    }
}
