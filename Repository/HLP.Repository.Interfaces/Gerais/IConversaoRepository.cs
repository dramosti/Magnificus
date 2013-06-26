using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;

namespace HLP.Repository.Interfaces.Entries.Gerais
{
    public interface IConversaoRepository
    {
        ConversaoModel GetConversao(int idConversao);
        List<ConversaoModel> GetAll(int idProduto);
        void Save(ConversaoModel conversao);
        void Delete(int idProduto);
        void Delete(ConversaoModel conversao);
        void Copy(ConversaoModel objConversao);
    }
}
