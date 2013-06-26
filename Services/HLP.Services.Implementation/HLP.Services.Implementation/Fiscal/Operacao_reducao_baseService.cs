using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Fiscal;
using HLP.Models.Entries.Fiscal;
using Ninject;
using HLP.Repository.Interfaces.Entries.Fiscal;

namespace HLP.Services.Implementation.Entries.Fiscal
{
    public class Operacao_reducao_baseService : IOperacao_reducao_baseService
    {
        [Inject]
        public IOperacao_reducao_baseRepository operacaoReducaoRepository { get; set; }

        public List<Operacao_reducao_baseModel> GetAll(int idTipoOperacao)
        {
            return operacaoReducaoRepository.GetAll(idTipoOperacao);
        }

        public void Save(Operacao_reducao_baseModel operacaoReducao)
        {
            operacaoReducaoRepository.Save(operacaoReducao);
        }

        public void Delete(int idOperacaoReducaoBase)
        {
            operacaoReducaoRepository.Delete(idOperacaoReducaoBase);
        }

        public void Delete(int idTipoOperacao, List<int?> lidOperacaoReducaoBase)
        {
            operacaoReducaoRepository.Delete(idTipoOperacao, lidOperacaoReducaoBase);
        }
    }
}
