using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Gerais;
using HLP.Models.Entries.Gerais;
using HLP.Repository.Interfaces.Entries.Gerais;
using Ninject;

namespace HLP.Services.Implementation.Entries.Gerais
{
    public class MoedaService : IMoedaService
    {
        [Inject]
        public IMoedaRepository moedaRepository { get; set; }

        public MoedaModel GetMoeda(int idMoeda)
        {
            return moedaRepository.GetMoeda(idMoeda);
        }

        public void Save(MoedaModel moeda)
        {
            moedaRepository.Save(moeda);
        }

        public void Delete(int idMoeda)
        {
            moedaRepository.Delete(idMoeda);
        }


        public bool IsNew(string xSiglaMoeda)
        {
            return moedaRepository.IsNew(xSiglaMoeda);
        }


        public int Copy(int idMoeda)
        {
            return moedaRepository.Copy(idMoeda);
        }
    }
}
