using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;

namespace HLP.Repository.Interfaces.Entries.Gerais
{
    public interface ITransportador_ContatoRepository
    {
        void Save(Transportador_ContatoModel objTransportador_Contato);
        void Update(Transportador_ContatoModel objTransportador_Contato);
        void Delete(Transportador_ContatoModel objTransportador_Contato);
        void Delete(int idTransportador);
        void Copy(Transportador_ContatoModel objTransportador_Contato);
        Transportador_ContatoModel GetTransportador_Contato(int idTransportdorContato);
        List<Transportador_ContatoModel> GetAllTransportador_Contato(int idTransportador);
    }
}
