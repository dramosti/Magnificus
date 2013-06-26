using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;
using Ninject;
using HLP.Repository.Interfaces.Entries.Gerais;
using HLP.Services.Interfaces.Entries.Gerais;

namespace HLP.Services.Implementation.Entries.Gerais
{
    public class Funcionario_CertificacaoService : IFuncionario_CertificacaoService
    {
        [Inject]
        public IFuncionario_CertificacaoRepository _Funcionario_CertificacaoRepository { get; set; }

        public void Save(Funcionario_CertificacaoModel objFuncionario_Certificacao)
        {
            _Funcionario_CertificacaoRepository.Save(objFuncionario_Certificacao);
        }

        public void Update(Funcionario_CertificacaoModel objFuncionario_Certificacao)
        {
            _Funcionario_CertificacaoRepository.Update(objFuncionario_Certificacao);
        }

        public void Delete(Funcionario_CertificacaoModel objFuncionario_Certificacao)
        {
            _Funcionario_CertificacaoRepository.Delete(objFuncionario_Certificacao);
        }

        public void Delete(int idFuncionario)
        {
            _Funcionario_CertificacaoRepository.Delete(idFuncionario);
        }

        public void Copy(Funcionario_CertificacaoModel objFuncionario_Certificacao)
        {
            _Funcionario_CertificacaoRepository.Copy(objFuncionario_Certificacao);
        }

        public Funcionario_CertificacaoModel GetFuncionario_Certificacao(int idFuncionarioCertificacao)
        {
            return _Funcionario_CertificacaoRepository.GetFuncionario_Certificacao(idFuncionarioCertificacao);
        }

        public List<Funcionario_CertificacaoModel> GetAllFuncionario_Certificacao(int idFuncionario)
        {
            return _Funcionario_CertificacaoRepository.GetAllFuncionario_Certificacao(idFuncionario);
        }
    }
}
