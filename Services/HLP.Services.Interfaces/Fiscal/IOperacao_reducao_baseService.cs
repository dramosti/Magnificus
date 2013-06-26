using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Fiscal;

namespace HLP.Services.Interfaces.Entries.Fiscal
{
    public interface IOperacao_reducao_baseService
    {
        List<Operacao_reducao_baseModel> GetAll(int idTipoOperacao);
        void Save(Operacao_reducao_baseModel operacaoReducao);
        void Delete(int idOperacaoReducaoBase);
        void Delete(int idTipoOperacao, List<int?> lidOperacaoReducaoBase);
    }
}
