using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;

namespace HLP.Repository.Interfaces.Entries.Gerais
{
    public interface ITransportador_EnderecoRepository
    {
        void Save(Transportador_EnderecoModel objTransportador_Endereco);
        void Update(Transportador_EnderecoModel objTransportador_Endereco);
        void Delete(Transportador_EnderecoModel objTransportador_Endereco);
        void Delete(int idTransportador);
        void Copy(Transportador_EnderecoModel objTransportador_Endereco);
        Transportador_EnderecoModel GetTransportador_Endereco(int idEndereco);
        List<Transportador_EnderecoModel> GetAllTransportador_Endereco(int idTransportador);
    }
}
