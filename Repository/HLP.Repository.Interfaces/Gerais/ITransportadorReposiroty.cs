using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;

namespace HLP.Repository.Interfaces.Entries.Gerais
{
    public interface ITransportadorReposiroty
    {
        void Save(TransportadorModel objTransportador);
        void Delete(TransportadorModel objTransportador);
        void Copy(TransportadorModel objTransportador);
        TransportadorModel GetTransportador(int idTransportador);

        void BeginTransaction();
        void CommitTransaction();
        void RollackTransaction();

    }
}
