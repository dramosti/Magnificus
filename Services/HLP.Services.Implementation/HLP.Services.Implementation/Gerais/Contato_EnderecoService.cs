using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.Gerais;
using HLP.Models.Entries.Gerais;
using Ninject;
using HLP.Services.Interfaces.Entries.Gerais;

namespace HLP.Services.Implementation.Entries.Gerais
{
    public class Contato_EnderecoService : IContato_EnderecoService
    {
        [Inject]
        public IContato_EnderecoRepository _Contato_EnderecoRepository { get; set; }

        public void Save(Contato_EnderecoModel objContato_Endereco)
        {
            _Contato_EnderecoRepository.Save(objContato_Endereco);
        }

        public void Update(Contato_EnderecoModel objContato_Endereco)
        {
            _Contato_EnderecoRepository.Update(objContato_Endereco);
        }

        public void Delete(Contato_EnderecoModel objContato_Endereco)
        {
            _Contato_EnderecoRepository.Delete(objContato_Endereco);
        }

        public void Delete(int idContato)
        {
            _Contato_EnderecoRepository.Delete(idContato);
        }

        public void Copy(Contato_EnderecoModel objContato_Endereco)
        {
            _Contato_EnderecoRepository.Copy(objContato_Endereco);
        }

        public Contato_EnderecoModel GetContato_Endereco(int idEndereco)
        {
            return _Contato_EnderecoRepository.GetContato_Endereco(idEndereco);
        }

        public List<Contato_EnderecoModel> GetAllContato_Endereco(int idContato)
        {
            return _Contato_EnderecoRepository.GetAllContato_Endereco(idContato);
        }
    }
}
