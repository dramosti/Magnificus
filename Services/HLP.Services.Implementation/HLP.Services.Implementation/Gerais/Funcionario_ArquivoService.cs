using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;
using HLP.Repository.Interfaces.Entries.Gerais;
using Ninject;
using HLP.Services.Interfaces.Entries.Gerais;

namespace HLP.Services.Implementation.Entries.Gerais
{
    public class Funcionario_ArquivoService : IFuncionario_ArquivoService
    {
        [Inject]
        public IFuncionario_ArquivoRepository _Funcionario_ArquivoRepository { get; set; }

        public void Save(Funcionario_ArquivoModel objFuncionario_Arquivo)
        {
            _Funcionario_ArquivoRepository.Save(objFuncionario_Arquivo);
        }

        public void Update(Funcionario_ArquivoModel objFuncionario_Arquivo)
        {
            _Funcionario_ArquivoRepository.Update(objFuncionario_Arquivo);
        }

        public void Delete(Funcionario_ArquivoModel objFuncionario_Arquivo)
        {
            _Funcionario_ArquivoRepository.Delete(objFuncionario_Arquivo);
        }

        public void Delete(int idFuncionario)
        {
            _Funcionario_ArquivoRepository.Delete(idFuncionario);
        }

        public void Copy(Funcionario_ArquivoModel objFuncionario_Arquivo)
        {
            _Funcionario_ArquivoRepository.Copy(objFuncionario_Arquivo);
        }

        public Funcionario_ArquivoModel GetFuncionario_Arquivo(int idFuncionarioArquivo)
        {
            return _Funcionario_ArquivoRepository.GetFuncionario_Arquivo(idFuncionarioArquivo);
        }

        public List<Funcionario_ArquivoModel> GetAllFuncionario_Arquivo(int idFuncionario)
        {
            return _Funcionario_ArquivoRepository.GetAllFuncionario_Arquivo(idFuncionario);
        }
    }
}
