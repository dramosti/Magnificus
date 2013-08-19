using HLP.Comum.Infrastructure;
using HLP.Comum.Infrastructure.Static;
using HLP.Models.Sales.Comercial;
using HLP.Repository.Interfaces.Sales.Comercial;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLP.Repository.Implementation.Sales.Comercial
{
    public class Orcamento_retTranspRepository : IOrcamento_retTranspRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Orcamento_retTranspModel> regOrcamento_retTranspAccessor;
        private DataAccessor<Orcamento_retTranspModel> regAllOrcamento_retTranspAccessor;

        public void Save(Orcamento_retTranspModel objOrcamento_retTransp)
        {
            if (objOrcamento_retTransp.idRetTransp == null)
            {
                objOrcamento_retTransp.idRetTransp = (int)UndTrabalho.dbPrincipal.ExecuteScalar("dbo.Proc_save_Orcamento_retTransp",
                ParameterBase<Orcamento_retTranspModel>.SetParameterValue(objOrcamento_retTransp));
            }
            else
            {
                UndTrabalho.dbPrincipal.ExecuteScalar("[dbo].[Proc_update_Orcamento_retTransp]",
                ParameterBase<Orcamento_retTranspModel>.SetParameterValue(objOrcamento_retTransp));
            }
        }

        public void Delete(int idRetTransp)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar("dbo.Proc_delete_Orcamento_retTransp",
                 UserData.idUser,
                 idRetTransp);
        }

        public int Copy(int idRetTransp)
        {
            return (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                      "dbo.Proc_copy_Orcamento_retTransp",
                       idRetTransp);
        }

        public Orcamento_retTranspModel GetOrcamento_retTransp(int idRetTransp)
        {
            if (regOrcamento_retTranspAccessor == null)
            {
                regOrcamento_retTranspAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_Orcamento_retTransp",
                                 new Parameters(UndTrabalho.dbPrincipal)
                                 .AddParameter<int>("idRetTransp"),
                                 MapBuilder<Orcamento_retTranspModel>.MapAllProperties().Build());
            }

            return regOrcamento_retTranspAccessor.Execute(idRetTransp).FirstOrDefault();
        }

        public List<Orcamento_retTranspModel> GetAllOrcamento_retTransp()
        {
            if (regAllOrcamento_retTranspAccessor == null)
            {
                regAllOrcamento_retTranspAccessor = UndTrabalho.dbPrincipal.CreateSqlStringAccessor("SELECT * FROM Orcamento_retTransp",
                                MapBuilder<Orcamento_retTranspModel>.MapAllProperties().Build());
            }
            return regAllOrcamento_retTranspAccessor.Execute().ToList();
        }
    }
}
