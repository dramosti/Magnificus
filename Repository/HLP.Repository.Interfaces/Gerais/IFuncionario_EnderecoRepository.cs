using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;

namespace HLP.Repository.Interfaces.Entries.Gerais
{
    public interface IFuncionario_EnderecoRepository
    {
        void Save(Funcionario_EnderecoModel objFuncionario_Endereco);
        void Update(Funcionario_EnderecoModel objFuncionario_Endereco);
        void Delete(Funcionario_EnderecoModel objFuncionario_Endereco);
        void Delete(int idFuncionario);
        void Copy(Funcionario_EnderecoModel objFuncionario_Endereco);
        Funcionario_EnderecoModel GetFuncionario_Endereco(int idEndereco);
        List<Funcionario_EnderecoModel> GetAllFuncionario_Endereco(int idFuncionario);
    }
}
