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
    public class Orcamento_ideRepository : IOrcamento_ideRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Orcamento_ideModel> regOrcamento_ideAccessor;
        private DataAccessor<Orcamento_ideModel> regAllOrcamento_ideAccessor;

        public void Save(Orcamento_ideModel objOrcamento_ide)
        {
            if (objOrcamento_ide.idOrcamento == null)
            {
                objOrcamento_ide.idOrcamento = (int)UndTrabalho.dbPrincipal.ExecuteScalar("dbo.Proc_save_Orcamento_ide",
                ParameterBase<Orcamento_ideModel>.SetParameterValue(objOrcamento_ide));
            }
            else
            {
                UndTrabalho.dbPrincipal.ExecuteScalar("[dbo].[Proc_update_Orcamento_ide]",
                ParameterBase<Orcamento_ideModel>.SetParameterValue(objOrcamento_ide));
            }
        }

        public void Delete(int idOrcamento)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar("dbo.Proc_delete_Orcamento_ide",
                 UserData.idUser,
                 idOrcamento);
        }

        public int Copy(int idOrcamento)
        {
            return (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                      "dbo.Proc_copy_Orcamento_ide",
                       idOrcamento);
        }

        public Orcamento_ideModel GetOrcamento_ide(int idOrcamento)
        {
            if (regOrcamento_ideAccessor == null)
            {
                regOrcamento_ideAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_Orcamento_ide",
                                 new Parameters(UndTrabalho.dbPrincipal)
                                 .AddParameter<int>("idOrcamento"),
                                 MapBuilder<Orcamento_ideModel>.MapAllProperties().Build());
            }

            return regOrcamento_ideAccessor.Execute(idOrcamento).FirstOrDefault();
        }

        public List<Orcamento_ideModel> GetAllOrcamento_ide()
        {
            if (regAllOrcamento_ideAccessor == null)
            {
                regAllOrcamento_ideAccessor = UndTrabalho.dbPrincipal.CreateSqlStringAccessor("SELECT * FROM Orcamento_ide",
                                MapBuilder<Orcamento_ideModel>.MapAllProperties().Build());
            }
            return regAllOrcamento_ideAccessor.Execute().ToList();
        }

        public void BeginTransaction()
        {
            UndTrabalho.BeginTransaction();
        }
        public void CommitTransaction()
        {
            UndTrabalho.CommitTransaction();
        }
        public void RollackTransaction()
        {
            UndTrabalho.RollBackTransaction();
        }
    }
}
