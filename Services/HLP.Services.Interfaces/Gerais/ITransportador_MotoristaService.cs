using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;

namespace HLP.Services.Interfaces.Entries.Gerais
{
    public interface ITransportador_MotoristaService
    {
        void Save(Transportador_MotoristaModel objTransportador_Motorista);
        void Update(Transportador_MotoristaModel objTransportador_Motorista);
        void Delete(Transportador_MotoristaModel objTransportador_Motorista);
        void Delete(int idTransportador);
        void Copy(Transportador_MotoristaModel objTransportador_Motorista);
        Transportador_MotoristaModel GetTransportador_Motorista(int idTransportdorMotorista);
        List<Transportador_MotoristaModel> GetAllTransportador_Motorista(int idTransportador);
    }
}
