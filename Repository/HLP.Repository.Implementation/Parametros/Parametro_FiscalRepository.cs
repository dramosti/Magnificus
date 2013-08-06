using HLP.Comum.Infrastructure;
using HLP.Comum.Infrastructure.Static;
using HLP.Models.Entries.Parametros;
using HLP.Repository.Interfaces.Entries.Parametros;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLP.Repository.Implementation.Entries.Parametros
{
    public class Parametro_FiscalRepository : IParametro_FiscalRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Parametro_FiscalModel> regParametro_FiscalAccessor;
        private DataAccessor<Parametro_FiscalModel> regAllParametro_FiscalAccessor;

        public void Save(Parametro_FiscalModel objParametro_Fiscal)
        {
            if (objParametro_Fiscal.idParametroFiscal == null)
            {
                objParametro_Fiscal.idParametroFiscal = (int)UndTrabalho.dbPrincipal.ExecuteScalar("dbo.Proc_save_Parametro_Fiscal",
                ParameterBase<Parametro_FiscalModel>.SetParameterValue(objParametro_Fiscal));
            }
            else
            {
                UndTrabalho.dbPrincipal.ExecuteScalar("[dbo].[Proc_update_Parametro_Fiscal]",
                ParameterBase<Parametro_FiscalModel>.SetParameterValue(objParametro_Fiscal));
            }
        }

        public void Delete(int idParametroFiscal)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar("dbo.Proc_delete_Parametro_Fiscal",
                 UserData.idUser,
                 idParametroFiscal);
        }

        public int Copy(int idParametroFiscal)
        {
            return (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                      "dbo.Proc_copy_Parametro_Fiscal",
                       idParametroFiscal);
        }

        public Parametro_FiscalModel GetParametro_Fiscal()
        {
            if (regParametro_FiscalAccessor == null)
            {
                regParametro_FiscalAccessor = UndTrabalho.dbPrincipal.CreateSqlStringAccessor("SELECT * FROM Parametro_Fiscal" +
                " where idEmpresa = " + CompanyData.idEmpresa,
                                MapBuilder<Parametro_FiscalModel>.MapAllProperties().Build());
            }

            return regParametro_FiscalAccessor.Execute().FirstOrDefault();
        }

        public List<Parametro_FiscalModel> GetAllParametro_Fiscal()
        {
            if (regAllParametro_FiscalAccessor == null)
            {
                regAllParametro_FiscalAccessor = UndTrabalho.dbPrincipal.CreateSqlStringAccessor("SELECT * FROM Parametro_Fiscal",
                                MapBuilder<Parametro_FiscalModel>.MapAllProperties().Build());
            }
            return regAllParametro_FiscalAccessor.Execute().ToList();
        }
    }
}
