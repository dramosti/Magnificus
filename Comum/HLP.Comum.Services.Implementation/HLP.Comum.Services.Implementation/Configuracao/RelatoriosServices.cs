using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Services.Interface.Configuracao;
using Ninject;
using HLP.Comum.Repository.Interfaces.Configuracao;

namespace HLP.Comum.Services.Implementation.Configuracao
{

    public class RelatoriosServices : IRelatoriosService
    {
        [Inject]
        public IRelatoriosRepository relatorioRepository { get; set; }

        public List<Infrastructure.RelatoriosModel> GetRelatorioByFormulario(int idFormulario)
        {
            return GetRelatorioByFormulario(idFormulario);
        }
        public void Save(Infrastructure.RelatoriosModel relatorio)
        {
            relatorioRepository.Save(relatorio);
        }
        public void DeleteItens(int? idPai, string snotIn = "")
        {
            relatorioRepository.DeleteItens(idPai, snotIn);
        }
        public void Delete(int idRelatorio)
        {
            relatorioRepository.Delete(idRelatorio);
        }

        public bool ReportExistInDataBase(string xName)
        {
            return relatorioRepository.ReportExistInDataBase(xName);
        }
    }
}
