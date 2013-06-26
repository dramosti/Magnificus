using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Fiscal;
using HLP.Models.Entries.Fiscal;
using HLP.Repository.Interfaces.Entries.Fiscal;
using Ninject;

namespace HLP.Services.Implementation.Entries.Fiscal
{
    public class Operacao_importacaoService : IOperacao_importacaoService
    {
        [Inject]
        public IOperacao_importacaoRepository operacaoImportacaoRepository { get; set; }

        public List<Operacao_importacaoModel> GetAll(int idTipoOperacao)
        {
            return operacaoImportacaoRepository.GetAll(idTipoOperacao);
        }

        public void Save(Operacao_importacaoModel operacaoImportacao)
        {
            operacaoImportacaoRepository.Save(operacaoImportacao);
        }

        public void Delete(int idOperacaoImportacao)
        {
            operacaoImportacaoRepository.Delete(idOperacaoImportacao);
        }

        public void Delete(int idTipoOperacao, List<int?> lidOperacaoImportacao)
        {
            operacaoImportacaoRepository.Delete(idTipoOperacao, lidOperacaoImportacao);
        }
    }
}
