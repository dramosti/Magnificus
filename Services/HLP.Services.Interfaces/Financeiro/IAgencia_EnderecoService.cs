using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Financeiro;

namespace HLP.Services.Interfaces.Entries.Financeiro
{
    public interface IAgencia_EnderecoService
    {
        void Save(Agencia_EnderecoModel objAgencia_Endereco);
        void Update(Agencia_EnderecoModel objAgencia_Endereco);
        void Delete(Agencia_EnderecoModel objAgencia_Endereco);
        void Delete(int idAgencia);
        void Copy(Agencia_EnderecoModel objAgencia_Endereco);
        Agencia_EnderecoModel GetAgencia_Endereco(int idEndereco);
        List<Agencia_EnderecoModel> GetAllAgencia_Endereco(int idAgencia);
    }
}
