using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;

namespace HLP.Services.Interfaces.Entries.Gerais
{
    public interface IContato_EnderecoService
    {
        void Save(Contato_EnderecoModel objContato_Endereco);
        void Update(Contato_EnderecoModel objContato_Endereco);
        void Delete(Contato_EnderecoModel objContato_Endereco);
        void Delete(int idContato);
        void Copy(Contato_EnderecoModel objContato_Endereco);
        Contato_EnderecoModel GetContato_Endereco(int idEndereco);
        List<Contato_EnderecoModel> GetAllContato_Endereco(int idContato);
    }
}
