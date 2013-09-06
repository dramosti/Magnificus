using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;

namespace HLP.Services.Interfaces.Entries.Gerais
{
    public interface IContatoService
    {
        void Save(ContatoModel objContato);
        void Delete(ContatoModel objContato);
        void Copy(ContatoModel objContato);
        ContatoModel GetContato(int idContato, bool bChildren = false);
        List<ContatoModel> GetContato_ByClienteFornec(int idContato);
    }
}
