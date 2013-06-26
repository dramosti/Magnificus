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
    public class ConversaoService : IConversaoService
    {
        [Inject]
        public IConversaoRepository conversaoRepository { get; set; }

        public ConversaoModel GetConversao(int idConversao)
        {
            return conversaoRepository.GetConversao(idConversao);
        }
        public List<ConversaoModel> GetAll(int idProduto)
        {
            return conversaoRepository.GetAll(idProduto);
        }

        public void Save(ConversaoModel conversao)
        {
            conversaoRepository.Save(conversao);
        }

        public void Delete(int idProduto)
        {
            conversaoRepository.Delete(idProduto);
        }

        public void Delete(ConversaoModel conversao)
        {
            conversaoRepository.Delete(conversao);
        }

        public void Copy(ConversaoModel objConversao)
        {
            conversaoRepository.Copy(objConversao);
        }
    }
}
