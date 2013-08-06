using HLP.Models.Entries.Parametros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HLP.Services.Interfaces.Entries.Parametros
{
    public interface IParametro_FinanceiroService
    {
        void Save(Parametro_FinanceiroModel objParametro_Financeiro);
        void Delete(int idParametroFinanceiro);
        int Copy(int idParametroFinanceiro);
        Parametro_FinanceiroModel GetParametro_Financeiro();
        List<Parametro_FinanceiroModel> GetAllParametro_Financeiro();
        bool GetCreditoAprovado();
    }
}
