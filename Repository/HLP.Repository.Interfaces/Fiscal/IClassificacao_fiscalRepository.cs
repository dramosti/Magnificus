using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Fiscal;

namespace HLP.Repository.Interfaces.Entries.Fiscal
{
    public interface IClassificacao_fiscalRepository
    {
        Classificacao_fiscalModel GetClassificacao(int idClassificacaoFiscal);
        void Save(Classificacao_fiscalModel classificacao);
        void Delete(int idClassificacaoFiscal);
        int Copy(int idClassificacaoFiscal);
    }
}
