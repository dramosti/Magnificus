using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.Gerais;
using Ninject;
using HLP.Models.Entries.Gerais;
using HLP.Services.Interfaces.Entries.Gerais;

namespace HLP.Services.Implementation.Entries.Gerais
{
    public class Transportador_EnderecoService : ITransportador_EnderecoService
    {
        [Inject]
        public ITransportador_EnderecoRepository _Transportador_EnderecoRepository { get; set; }

        public void Save(Transportador_EnderecoModel objTransportador_Endereco)
        {
            _Transportador_EnderecoRepository.Save(objTransportador_Endereco);
        }

        public void Update(Transportador_EnderecoModel objTransportador_Endereco)
        {
            _Transportador_EnderecoRepository.Update(objTransportador_Endereco);
        }

        public void Delete(Transportador_EnderecoModel objTransportador_Endereco)
        {
            _Transportador_EnderecoRepository.Delete(objTransportador_Endereco);
        }

        public void Delete(int idTransportador)
        {
            _Transportador_EnderecoRepository.Delete(idTransportador);
        }

        public void Copy(Transportador_EnderecoModel objTransportador_Endereco)
        {
            _Transportador_EnderecoRepository.Copy(objTransportador_Endereco);
        }

        public Transportador_EnderecoModel GetTransportador_Endereco(int idEndereco)
        {
            return _Transportador_EnderecoRepository.GetTransportador_Endereco(idEndereco);
        }

        public List<Transportador_EnderecoModel> GetAllTransportador_Endereco(int idTransportador)
        {
            return _Transportador_EnderecoRepository.GetAllTransportador_Endereco(idTransportador);
        }
    }
}
