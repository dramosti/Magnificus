using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;

namespace HLP.Repository.Interfaces.Entries.Gerais
{
    public interface IContatoRepository
    {
        void Save(ContatoModel objContato);
        void Delete(ContatoModel objContato);
        void Copy(ContatoModel objContato);
        ContatoModel GetContato(int idContato);

        void BeginTransaction();
        void CommitTransaction();
        void RollackTransaction();
    }
}
