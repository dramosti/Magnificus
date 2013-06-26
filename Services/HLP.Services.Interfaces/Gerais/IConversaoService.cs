﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;

namespace HLP.Services.Interfaces.Entries.Gerais
{
    public interface IConversaoService
    {
        ConversaoModel GetConversao(int idConversao);
        List<ConversaoModel> GetAll(int idProduto);
        void Save(ConversaoModel conversao);
        void Delete(int idProduto);
        void Delete(ConversaoModel conversao);
        void Copy(ConversaoModel objConversao);
    }
}
