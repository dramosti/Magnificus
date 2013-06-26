using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;

namespace HLP.Repository.Interfaces.Entries.Gerais
{
    public interface IFuncionario_ArquivoRepository
    {
        void Save(Funcionario_ArquivoModel objFuncionario_Arquivo);
        void Update(Funcionario_ArquivoModel objFuncionario_Arquivo);
        void Delete(Funcionario_ArquivoModel objFuncionario_Arquivo);
        void Delete(int idFuncionario);
        void Copy(Funcionario_ArquivoModel objFuncionario_Arquivo);
        Funcionario_ArquivoModel GetFuncionario_Arquivo(int idFuncionarioArquivo);
        List<Funcionario_ArquivoModel> GetAllFuncionario_Arquivo(int idFuncionario);
    }
}
