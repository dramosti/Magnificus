using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Fiscal;

namespace HLP.Services.Interfaces.Entries.Fiscal
{
    public interface IClassificacao_fiscalService
    {
        Classificacao_fiscalModel GetClassificacao(int idClassificacaoFiscal);
        void Save(Classificacao_fiscalModel classificacao);
        void Delete(int idClassificacaoFiscal);
        int Copy(int idClassificacaoFiscal);
    }
}
