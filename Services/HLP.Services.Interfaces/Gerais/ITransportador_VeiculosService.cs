using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;

namespace HLP.Services.Interfaces.Entries.Gerais
{
    public interface ITransportador_VeiculosService
    {
        void Save(Transportador_VeiculosModel objTransportador_Veiculos);
        void Update(Transportador_VeiculosModel objTransportador_Veiculos);
        void Delete(Transportador_VeiculosModel objTransportador_Veiculos);
        void Delete(int idTransportador);
        void Copy(Transportador_VeiculosModel objTransportador_Veiculos);
        Transportador_VeiculosModel GetTransportador_Veiculos(int idTransportadorVeiculo);
        List<Transportador_VeiculosModel> GetAllTransportador_Veiculos(int idTransportador);
    }
}
