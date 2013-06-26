using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;

namespace HLP.Repository.Interfaces.Entries.Gerais
{
    public interface ICondicoes_entregaRepository
    {
        Condicoes_entregaModel GetCondicao(int idCondicaoEntrega);
        void Save(Condicoes_entregaModel condicao);
        void Delete(int idCondicaoEntrega);
        int Copy(int idCondicaoEntrega);
    }
}
