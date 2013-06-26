using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.Fiscal;
using HLP.Models.Entries.Fiscal;
using Ninject;
using HLP.Comum.Infrastructure;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Comum.Models.Static;

namespace HLP.Repository.Implementation.Entries.Fiscal
{
    public class Situacao_tributaria_ipiRepository : ISituacao_tributaria_ipiRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Situacao_tributaria_ipiModel> regIpiAccessor;


        public Situacao_tributaria_ipiModel GetStIpi(int idCSTIpi)
        {

            if (regIpiAccessor == null)
            {
                regIpiAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_situacao_tributaria_ipi",
                                  new Parameters(UndTrabalho.dbPrincipal)
                                    .AddParameter<int>("idCSTIpi"),
                                  MapBuilder<Situacao_tributaria_ipiModel>.MapAllProperties().Build());
            }


            return regIpiAccessor.Execute(idCSTIpi).FirstOrDefault();
        }

        public void Save(Situacao_tributaria_ipiModel ipi)
        {
            try
            {
                Convert.ToInt32(ipi.cCSTIpi);
            }
            catch (Exception)
            {                
                throw new Exception("Situação tributária deve ser uma valor numérico válido!");
            }

            if (ipi.idCSTIpi == null)
            {
                int idCSTIpi = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
               "[dbo].[Proc_save_situacao_tributaria_ipi]",
              ParameterBase<Situacao_tributaria_ipiModel>.SetParameterValue(ipi));
                ipi.idCSTIpi = idCSTIpi;
            }
            else
            {
                UndTrabalho.dbPrincipal.ExecuteScalar(
               "[dbo].[Proc_update_Situacao_tributaria_ipi]",
              ParameterBase<Situacao_tributaria_ipiModel>.SetParameterValue(ipi));
            }            
        }

        public void Delete(int idCSTIpi)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
                     "dbo.Proc_delete_situacao_tributaria_ipi",
                      UserData.idUser,
                      idCSTIpi);
        }


        public int Copy(int idCSTIpi)
        {
            return (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                      "dbo.Proc_copy_situacao_tributaria_ipi",
                       idCSTIpi);
        }
    }
}
