using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Parametros;
using Ninject;
using HLP.Repository.Interfaces.Entries.Parametros;
using HLP.Models.Entries.Parametros;

namespace HLP.Services.Implementation.Entries.Parametros
{
    public class Parametro_FinanceiroService : IParametro_FinanceiroService
    {
        [Inject]
        public IParametro_FinanceiroRepository _Parametro_FinanceiroRepository { get; set; }

        public void Save(Parametro_FinanceiroModel objParametro_Financeiro)
        {
            _Parametro_FinanceiroRepository.Save(objParametro_Financeiro);
        }

        public void Delete(int idParametroFinanceiro)
        {
            _Parametro_FinanceiroRepository.Delete(idParametroFinanceiro);
        }

        public int Copy(int idParametroFinanceiro)
        {
            return _Parametro_FinanceiroRepository.Copy(idParametroFinanceiro);
        }

        public Parametro_FinanceiroModel GetParametro_Financeiro()
        {
            Parametro_FinanceiroModel objParamFinanceiroModel = new Parametro_FinanceiroModel();
            return _Parametro_FinanceiroRepository.GetParametro_Financeiro() ?? objParamFinanceiroModel;
        }

        public List<Parametro_FinanceiroModel> GetAllParametro_Financeiro()
        {
            return _Parametro_FinanceiroRepository.GetAllParametro_Financeiro();
        }

        public bool GetCreditoAprovado()
        {
            return _Parametro_FinanceiroRepository.GetCreditoAprovado();
        }
    }
}
