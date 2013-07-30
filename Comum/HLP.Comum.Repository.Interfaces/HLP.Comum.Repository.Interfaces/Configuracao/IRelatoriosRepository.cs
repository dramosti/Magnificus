using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;
using HLP.Comum.Models;

namespace HLP.Comum.Repository.Interfaces.Configuracao
{
    public interface IRelatoriosRepository
    {
        bool ReportExistInDataBase(string xName);
        List<RelatoriosModel> GetRelatorioByFormulario(int idFormulario);
        List<RelatoriosModel> GetAllRelatorio();
        void Save(RelatoriosModel relatorio);
        void DeleteItens(int? idPai, string snotIn = "");
        void Delete(int idRelatorio);
    }
}
