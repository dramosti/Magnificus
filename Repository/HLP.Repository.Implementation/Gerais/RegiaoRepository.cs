using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.Gerais;
using Ninject;
using HLP.Comum.Infrastructure;
using HLP.Models.Entries.Gerais;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace HLP.Repository.Implementation.Entries.Gerais
{
    public class RegiaoRepository : IRegiaoRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<RegiaoModel> regRegiaoGetAllAccessor;

        public List<RegiaoModel> GetAll()
        {
            if (regRegiaoGetAllAccessor == null)
            {
                regRegiaoGetAllAccessor = UndTrabalho.dbPrincipal.CreateSqlStringAccessor("SELECT * FROM Regiao",
                                  MapBuilder<RegiaoModel>.MapAllProperties().Build());
            }
            return regRegiaoGetAllAccessor.Execute().ToList();
        }
    }
}
