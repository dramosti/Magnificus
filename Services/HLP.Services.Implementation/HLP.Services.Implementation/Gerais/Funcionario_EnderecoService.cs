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
    public class Funcionario_EnderecoService : IFuncionario_EnderecoService
    {
        [Inject]
        public IFuncionario_EnderecoRepository _Funcionario_EnderecoRepository { get; set; }

        public void Save(Funcionario_EnderecoModel objFuncionario_Endereco)
        {
            _Funcionario_EnderecoRepository.Save(objFuncionario_Endereco);
        }

        public void Update(Funcionario_EnderecoModel objFuncionario_Endereco)
        {
            _Funcionario_EnderecoRepository.Update(objFuncionario_Endereco);
        }

        public void Delete(Funcionario_EnderecoModel objFuncionario_Endereco)
        {
            _Funcionario_EnderecoRepository.Delete(objFuncionario_Endereco);
        }

        public void Delete(int idFuncionario)
        {
            _Funcionario_EnderecoRepository.Delete(idFuncionario);
        }

        public void Copy(Funcionario_EnderecoModel objFuncionario_Endereco)
        {
            _Funcionario_EnderecoRepository.Copy(objFuncionario_Endereco);
        }

        public Funcionario_EnderecoModel GetFuncionario_Endereco(int idEndereco)
        {
            return _Funcionario_EnderecoRepository.GetFuncionario_Endereco(idEndereco);
        }

        public List<Funcionario_EnderecoModel> GetAllFuncionario_Endereco(int idFuncionario)
        {
            return _Funcionario_EnderecoRepository.GetAllFuncionario_Endereco(idFuncionario);
        }
    }
}
