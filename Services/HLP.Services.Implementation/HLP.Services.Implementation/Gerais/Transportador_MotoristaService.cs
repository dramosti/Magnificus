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
    public class Transportador_MotoristaService : ITransportador_MotoristaService
    {
        [Inject]
        public ITransportador_MotoristaRepository _Transportador_MotoristaRepository { get; set; }

        public void Save(Transportador_MotoristaModel objTransportador_Motorista)
        {
            _Transportador_MotoristaRepository.Save(objTransportador_Motorista);
        }

        public void Update(Transportador_MotoristaModel objTransportador_Motorista)
        {
            _Transportador_MotoristaRepository.Update(objTransportador_Motorista);
        }

        public void Delete(Transportador_MotoristaModel objTransportador_Motorista)
        {
            _Transportador_MotoristaRepository.Delete(objTransportador_Motorista);
        }

        public void Delete(int idTransportador)
        {
            _Transportador_MotoristaRepository.Delete(idTransportador);
        }

        public void Copy(Transportador_MotoristaModel objTransportador_Motorista)
        {
            _Transportador_MotoristaRepository.Copy(objTransportador_Motorista);
        }

        public Transportador_MotoristaModel GetTransportador_Motorista(int idTransportdorMotorista)
        {
            return _Transportador_MotoristaRepository.GetTransportador_Motorista(idTransportdorMotorista);
        }

        public List<Transportador_MotoristaModel> GetAllTransportador_Motorista(int idTransportador)
        {
            return _Transportador_MotoristaRepository.GetAllTransportador_Motorista(idTransportador);
        }
    }
}
