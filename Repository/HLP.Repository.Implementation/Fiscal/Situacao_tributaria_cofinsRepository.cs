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
    public class Situacao_tributaria_cofinsRepository : ISituacao_tributaria_cofinsRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Situacao_tributaria_cofinsModel> regCofinsAccessor;


        public Situacao_tributaria_cofinsModel GetStCofins(int idCSTCofins)
        {

            if (regCofinsAccessor == null)
            {
                regCofinsAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_situacao_tributaria_cofins",
                                  new Parameters(UndTrabalho.dbPrincipal)
                                    .AddParameter<int>("idCSTCofins"),
                                  MapBuilder<Situacao_tributaria_cofinsModel>.MapAllProperties().Build());
            }


            return regCofinsAccessor.Execute(idCSTCofins).FirstOrDefault();
        }

        public void Save(Situacao_tributaria_cofinsModel cofins)
        {
            try
            {
                Convert.ToInt32(cofins.cCSTCofins);
            }
            catch (Exception)
            {                
                throw new Exception("Situação tributária deve ser uma valor numérico válido!");
            }

            if (cofins.idCSTCofins == null)
            {
                int idCSTCofins = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
               "[dbo].[Proc_save_situacao_tributaria_cofins]",
              ParameterBase<Situacao_tributaria_cofinsModel>.SetParameterValue(cofins));
                cofins.idCSTCofins = idCSTCofins;
            }
            else
            {
                UndTrabalho.dbPrincipal.ExecuteScalar(
               "[dbo].[Proc_update_Situacao_tributaria_cofins]",
              ParameterBase<Situacao_tributaria_cofinsModel>.SetParameterValue(cofins));
            }
            
        }

        public void Delete(int idCSTCofins)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
                     "dbo.Proc_delete_situacao_tributaria_cofins",
                      UserData.idUser,
                      idCSTCofins);
        }


        public int Copy(int idCSTCofins)
        {
            return (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                        "dbo.Proc_copy_situacao_tributaria_cofins",
                         idCSTCofins);
        }
    }
}
