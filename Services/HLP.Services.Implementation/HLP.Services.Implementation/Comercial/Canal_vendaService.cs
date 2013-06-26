using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Comercial;
using HLP.Models.Entries.Comercial;
using HLP.Repository.Interfaces.Entries.Comercial;
using Ninject;

namespace HLP.Services.Implementation.Entries.Comercial
{
    public class Canal_vendaService : ICanal_vendaService
    {
        [Inject]
        public ICanal_vendaRepository canalRepository { get; set; }


        public Canal_vendaModel GetCanal(int idCanalVenda)
        {
            return canalRepository.GetCanal(idCanalVenda);
        }

        public void Save(Canal_vendaModel canal)
        {
            canalRepository.Save(canal);
        }

        public void Delete(int idCanalVenda)
        {
            canalRepository.Delete(idCanalVenda);
        }


        public int Copy(int idCanalVenda)
        {
            return canalRepository.Copy(idCanalVenda);
        }
    }
}
