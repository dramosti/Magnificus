using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.Fiscal;
using HLP.Comum.Infrastructure;
using Ninject;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Models.Entries.Fiscal;
using HLP.Comum.Infrastructure.Static;


namespace HLP.Repository.Implementation.Entries.Fiscal
{
    public class Codigo_Icms_paiRepository : ICodigo_Icms_paiRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Codigo_Icms_paiModel> regCodigo_Icms_paiAccessor;

        public void Save(Codigo_Icms_paiModel objCodigo_Icms_pai)
        {
            //Aqui deve-se setar as FK's (se houver)
            //Exemplo:
            //produto.idEmpresa = CompanyData.idEmpresa;

            objCodigo_Icms_pai.idEmpresa = CompanyData.idEmpresa;

            if (objCodigo_Icms_pai.idCodigoIcmsPai == null)
            {
                objCodigo_Icms_pai.idCodigoIcmsPai = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                "[dbo].[Proc_save_Codigo_Icms_pai]",
                ParameterBase<Codigo_Icms_paiModel>.SetParameterValue(objCodigo_Icms_pai));
            }
            else
            {
                UndTrabalho.dbPrincipal.ExecuteScalar(
                "[dbo].[Proc_update_Codigo_Icms_pai]",
                ParameterBase<Codigo_Icms_paiModel>.SetParameterValue(objCodigo_Icms_pai));
            }
        }

        public void Delete(Codigo_Icms_paiModel objCodigo_Icms_pai)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
            UndTrabalho.dbTransaction,
           "[dbo].[Proc_delete_Codigo_Icms_pai]",
            UserData.idUser,
            objCodigo_Icms_pai.idCodigoIcmsPai);
        }

        public void Copy(Codigo_Icms_paiModel objCodigo_Icms_pai)
        {
            objCodigo_Icms_pai.idCodigoIcmsPai = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
            UndTrabalho.dbTransaction,
           "dbo.Proc_copy_Codigo_Icms_pai",
            objCodigo_Icms_pai.idCodigoIcmsPai);
        }

        public Codigo_Icms_paiModel GetCodigo_Icms_pai(int idCodigoIcmsPai)
        {

            if (regCodigo_Icms_paiAccessor == null)
            {
                regCodigo_Icms_paiAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_Codigo_Icms_pai",
                                         new Parameters(UndTrabalho.dbPrincipal)
                                         .AddParameter<int>("idCodigoIcmsPai"),
                                         MapBuilder<Codigo_Icms_paiModel>.MapAllProperties().Build());
            }

            return regCodigo_Icms_paiAccessor.Execute(idCodigoIcmsPai).FirstOrDefault();
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
