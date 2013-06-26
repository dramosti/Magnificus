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
    public class BancoService : IBancoService
    {
        [Inject]
        public IBancoRepository bancoRepository { get; set; }

        public List<BancoModel> GetAll()
        {
            return bancoRepository.GetAll();
        }


        public BancoModel GetBanco(int idBanco)
        {
            return bancoRepository.GetBanco(idBanco);
        }

        public void Save(BancoModel banco)
        {
            bancoRepository.Save(banco);
        }

        public void Delete(int idBanco)
        {
            bancoRepository.Delete(idBanco);
        }


        public int Copy(int idBanco)
        {
            return bancoRepository.Copy(idBanco);
        }
    }
}
