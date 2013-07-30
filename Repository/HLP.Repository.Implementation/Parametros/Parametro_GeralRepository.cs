using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.Parametros;
using HLP.Models.Entries.Parametros;
using HLP.Comum.Infrastructure;
using Ninject;
using Microsoft.Practices.EnterpriseLibrary.Data;

using HLP.Comum.Models;
using HLP.Comum.Infrastructure.Static;

namespace HLP.Repository.Implementation.Entries.Parametros
{
    public class Parametro_GeralRepository : IParametro_GeralRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }


        private DataAccessor<Parametro_GeralModel> regParametroAccessor;

        public Parametro_GeralModel GetGeralByEmpresa()
        {
            if (regParametroAccessor == null)
            {
                regParametroAccessor = UndTrabalho.dbPrincipal.CreateSqlStringAccessor("SELECT * FROM Parametro_Geral WHERE idEmpresa = @idEmpresa",
                                  new Parameters(UndTrabalho.dbPrincipal)
                                    .AddParameter<int>("idEmpresa"),
                                  MapBuilder<Parametro_GeralModel>.MapAllProperties().Build());
            }


            return regParametroAccessor.Execute(CompanyData.idEmpresa).FirstOrDefault();
        }
    }
}
