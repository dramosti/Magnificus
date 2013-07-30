using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.Parametros;
using HLP.Comum.Infrastructure;
using Ninject;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Models.Entries.Parametros;

using HLP.Models.Entries.Gerais;
using HLP.Comum.Infrastructure.Static;

namespace HLP.Repository.Implementation.Entries.Parametros
{
    public class Parametro_financeiroRepository : IParametro_financeiroRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }


        private DataAccessor<Parametro_financeiroModel> regParametroAccessor;

        public bool CreditoAprovado()
        {
            bool Aprovado = false;
            if (regParametroAccessor == null)
            {
                regParametroAccessor = UndTrabalho.dbPrincipal.CreateSqlStringAccessor("SELECT * FROM Parametro_financeiro WHERE idEmpresa = @idEmpresa",
                                  new Parameters(UndTrabalho.dbPrincipal)
                                    .AddParameter<int>("idEmpresa"),
                                  MapBuilder<Parametro_financeiroModel>.MapAllProperties().Build());
            }


            Parametro_financeiroModel param = regParametroAccessor.Execute(CompanyData.idEmpresa).FirstOrDefault();
            if (param != null)
            {
                if (param.stCreditoAprovado == 1)
                {
                    Aprovado = true;
                }
            }

            return Aprovado;
        }
    }
}
