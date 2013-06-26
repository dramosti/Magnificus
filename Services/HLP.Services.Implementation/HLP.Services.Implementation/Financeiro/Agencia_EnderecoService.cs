using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Financeiro;
using Ninject;
using HLP.Models.Entries.Financeiro;
using HLP.Repository.Interfaces.Entries.Financeiro;

namespace HLP.Services.Implementation.Entries.Financeiro
{
    public class Agencia_EnderecoService : IAgencia_EnderecoService
    {
        [Inject]
        public IAgencia_EnderecoRepository _Agencia_EnderecoRepository { get; set; }

        public void Save(Agencia_EnderecoModel objAgencia_Endereco)
        {
            _Agencia_EnderecoRepository.Save(objAgencia_Endereco);
        }

        public void Update(Agencia_EnderecoModel objAgencia_Endereco)
        {
            _Agencia_EnderecoRepository.Update(objAgencia_Endereco);
        }

        public void Delete(Agencia_EnderecoModel objAgencia_Endereco)
        {
            _Agencia_EnderecoRepository.Delete(objAgencia_Endereco);
        }

        public void Delete(int idAgencia)
        {
            _Agencia_EnderecoRepository.Delete(idAgencia);
        }

        public void Copy(Agencia_EnderecoModel objAgencia_Endereco)
        {
            _Agencia_EnderecoRepository.Copy(objAgencia_Endereco);
        }

        public Agencia_EnderecoModel GetAgencia_Endereco(int idEndereco)
        {
            return _Agencia_EnderecoRepository.GetAgencia_Endereco(idEndereco);
        }

        public List<Agencia_EnderecoModel> GetAllAgencia_Endereco(int idAgencia)
        {
            return _Agencia_EnderecoRepository.GetAllAgencia_Endereco(idAgencia);
        }
    }
}
