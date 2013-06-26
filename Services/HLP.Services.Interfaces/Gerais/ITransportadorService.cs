using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;

namespace HLP.Services.Interfaces.Entries.Gerais
{
  public  interface ITransportadorService
    {
      void Save(TransportadorModel objTransportador);
      void Delete(TransportadorModel objTransportador);
      void Copy(TransportadorModel objTransportador);
      TransportadorModel GetTransportador(int idTransportador, bool bChildren = false);
    }
}
