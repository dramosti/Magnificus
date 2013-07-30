using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.Fiscal;
using HLP.Models.Entries.Fiscal;
using Ninject;
using HLP.Comum.Infrastructure;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Comum.Infrastructure.Static;


namespace HLP.Repository.Implementation.Entries.Fiscal
{
    public class Situacao_tributaria_pisRepository : ISituacao_tributaria_pisRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Situacao_tributaria_pisModel> regPisAccessor;


        public Situacao_tributaria_pisModel GetStPis(int idCSTPis)
        {

            if (regPisAccessor == null)
            {
                regPisAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_situacao_tributaria_pis",
                                  new Parameters(UndTrabalho.dbPrincipal)
                                    .AddParameter<int>("idCSTPis"),
                                  MapBuilder<Situacao_tributaria_pisModel>.MapAllProperties().Build());
            }


            return regPisAccessor.Execute(idCSTPis).FirstOrDefault();
        }

        public void Save(Situacao_tributaria_pisModel pis)
        {
            try
            {
                Convert.ToInt32(pis.cCSTPis);
            }
            catch (Exception)
            {
                throw new Exception("Situação tributária deve ser um valor numérico válido!");
            }

            if (pis.idCSTPis == null)
            {
                int idCSTPis = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
               "[dbo].[Proc_save_situacao_tributaria_pis]",
              ParameterBase<Situacao_tributaria_pisModel>.SetParameterValue(pis));

                pis.idCSTPis = idCSTPis;
            }
            else
            {
                UndTrabalho.dbPrincipal.ExecuteScalar(
               "[dbo].[Proc_update_Situacao_tributaria_pis]",
              ParameterBase<Situacao_tributaria_pisModel>.SetParameterValue(pis));
            }

            
        }

        public void Delete(int idCSTPis)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
                     "dbo.Proc_delete_situacao_tributaria_pis",
                      UserData.idUser,
                      idCSTPis);
        }


        public int Copy(int idCSTPis)
        {
            return (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                       "dbo.Proc_copy_situacao_tributaria_pis",
                        idCSTPis);
        }
    }
}
