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
    public class Descontos_AvistaService : IDescontos_AvistaService
    {
        [Inject]
        public IDescontos_AvistaRepository descontoRepository { get; set; }

        public Descontos_AvistaModel GetDesconto(int idDescontosAvista)
        {
            return descontoRepository.GetDesconto(idDescontosAvista);
        }

        public List<Descontos_AvistaModel> GetAll()
        {
            return descontoRepository.GetAll();
        }

        public void Save(Descontos_AvistaModel desconto)
        {
            descontoRepository.Save(desconto);
        }

        public void Delete(int idDescontosAvista)
        {
            descontoRepository.Delete(idDescontosAvista);
        }


        public int Copy(int idDescontosAvista)
        {
            return descontoRepository.Copy(idDescontosAvista);
        }
    }
}
