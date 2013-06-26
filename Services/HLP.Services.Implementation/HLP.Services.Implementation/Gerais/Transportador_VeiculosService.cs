using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using HLP.Repository.Interfaces.Entries.Gerais;
using HLP.Models.Entries.Gerais;
using HLP.Services.Interfaces.Entries.Gerais;

namespace HLP.Services.Implementation.Entries.Gerais
{
    public class Transportador_VeiculosService : ITransportador_VeiculosService
    {
        [Inject]
        public ITransportador_VeiculosRepository _Transportador_VeiculosRepository { get; set; }

        public void Save(Transportador_VeiculosModel objTransportador_Veiculos)
        {
            _Transportador_VeiculosRepository.Save(objTransportador_Veiculos);
        }

        public void Update(Transportador_VeiculosModel objTransportador_Veiculos)
        {
            _Transportador_VeiculosRepository.Update(objTransportador_Veiculos);
        }

        public void Delete(Transportador_VeiculosModel objTransportador_Veiculos)
        {
            _Transportador_VeiculosRepository.Delete(objTransportador_Veiculos);
        }

        public void Delete(int idTransportador)
        {
            _Transportador_VeiculosRepository.Delete(idTransportador);
        }

        public void Copy(Transportador_VeiculosModel objTransportador_Veiculos)
        {
            _Transportador_VeiculosRepository.Copy(objTransportador_Veiculos);
        }

        public Transportador_VeiculosModel GetTransportador_Veiculos(int idTransportadorVeiculo)
        {
            return _Transportador_VeiculosRepository.GetTransportador_Veiculos(idTransportadorVeiculo);
        }

        public List<Transportador_VeiculosModel> GetAllTransportador_Veiculos(int idTransportador)
        {
            return _Transportador_VeiculosRepository.GetAllTransportador_Veiculos(idTransportador);
        }
    }
}
