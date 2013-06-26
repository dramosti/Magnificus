using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Comum.Services.Interface.Configuracao
{
    public interface IRelatoriosService
    {
        List<RelatoriosModel> GetRelatorioByFormulario(int idFormulario);
        void Save(RelatoriosModel relatorio);
        void DeleteItens(int? idPai, string snotIn = "");
        void Delete(int idRelatorio);
        bool ReportExistInDataBase(string xName);
    }
}
