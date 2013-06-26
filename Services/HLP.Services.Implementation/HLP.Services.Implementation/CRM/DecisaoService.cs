using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.CRM;
using Ninject;
using HLP.Repository.Interfaces.Entries.CRM;
using HLP.Models.Entries.CRM;

namespace HLP.Services.Implementation.Entries.CRM
{
    public class DecisaoService : IDecisaoService
    {
        [Inject]
        public IDecisaoRepository decisaoRepository { get; set; }

        public DecisaoModel GetDecisao(int idDecisao)
        {
            return decisaoRepository.GetDecisao(idDecisao);
        }

        public void Save(DecisaoModel decisao)
        {
            decisaoRepository.Save(decisao);
        }

        public void Delete(int idDecisao)
        {
            decisaoRepository.Delete(idDecisao);
        }

        public int Copy(int idDecisao)
        {
            return decisaoRepository.Copy(idDecisao);
        }
    }
}
