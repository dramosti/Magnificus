using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Gerais;
using Ninject;
using HLP.Repository.Interfaces.Entries.Gerais;
using HLP.Models.Entries.Gerais;

namespace HLP.Services.Implementation.Entries.Gerais
{
    public class RegiaoService : IRegiaoService
    {
        [Inject]
        public IRegiaoRepository regiaoRepository { get; set; }

        public List<RegiaoModel> GetAll()
        {
            return regiaoRepository.GetAll();
        }
    }
}
