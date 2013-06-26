using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Fiscal;
using Ninject;
using HLP.Repository.Interfaces.Entries.Fiscal;
using HLP.Models.Entries.Fiscal;

namespace HLP.Services.Implementation.Entries.Fiscal
{
    public class Classificacao_fiscalService : IClassificacao_fiscalService
    {
        [Inject]
        public IClassificacao_fiscalRepository classificacaoRepository { get; set; }

        public Classificacao_fiscalModel GetClassificacao(int idClassificacaoFiscal)
        {
            return classificacaoRepository.GetClassificacao(idClassificacaoFiscal);
        }

        public void Save(Classificacao_fiscalModel classificacao)
        {
            classificacaoRepository.Save(classificacao);
        }

        public void Delete(int idClassificacaoFiscal)
        {
            classificacaoRepository.Delete(idClassificacaoFiscal);
        }


        public int Copy(int idClassificacaoFiscal)
        {
            return classificacaoRepository.Copy(idClassificacaoFiscal);
        }
    }
}
