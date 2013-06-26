using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;
using HLP.Repository.Interfaces.Entries.Gerais;
using Ninject;
using HLP.Services.Interfaces.Entries.Gerais;

namespace HLP.Services.Implementation.Entries.Gerais
{
    public class Transportador_ContatoService : ITransportador_ContatoService
    {
        [Inject]
        public ITransportador_ContatoRepository _Transportador_ContatoRepository { get; set; }

        public void Save(Transportador_ContatoModel objTransportador_Contato)
        {
            _Transportador_ContatoRepository.Save(objTransportador_Contato);
        }

        public void Update(Transportador_ContatoModel objTransportador_Contato)
        {
            _Transportador_ContatoRepository.Update(objTransportador_Contato);
        }

        public void Delete(Transportador_ContatoModel objTransportador_Contato)
        {
            _Transportador_ContatoRepository.Delete(objTransportador_Contato);
        }

        public void Delete(int idTransportador)
        {
            _Transportador_ContatoRepository.Delete(idTransportador);
        }

        public void Copy(Transportador_ContatoModel objTransportador_Contato)
        {
            _Transportador_ContatoRepository.Copy(objTransportador_Contato);
        }

        public Transportador_ContatoModel GetTransportador_Contato(int idTransportdorContato)
        {
            return _Transportador_ContatoRepository.GetTransportador_Contato(idTransportdorContato);
        }

        public List<Transportador_ContatoModel> GetAllTransportador_Contato(int idTransportador)
        {
            return _Transportador_ContatoRepository.GetAllTransportador_Contato(idTransportador);
        }
    }
}
