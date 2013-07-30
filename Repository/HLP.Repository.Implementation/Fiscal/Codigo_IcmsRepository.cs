using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.Fiscal;
using HLP.Models.Entries.Fiscal;
using Ninject;
using HLP.Comum.Infrastructure;
using Microsoft.Practices.EnterpriseLibrary.Data;

using System.Data.Common;
using System.Data;
using HLP.Comum.Infrastructure.Static;

namespace HLP.Repository.Implementation.Entries.Fiscal
{
    public class Codigo_IcmsRepository : ICodigo_IcmsRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Codigo_IcmsModel> regAcessor;

        public void Save(Codigo_IcmsModel objCodigo_Icms)
        {
            objCodigo_Icms.idCodigoIcms = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
           "[dbo].[Proc_save_Codigo_Icms]",
            ParameterBase<Codigo_IcmsModel>.SetParameterValue(objCodigo_Icms));

            objCodigo_Icms.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Update(Codigo_IcmsModel objCodigo_Icms)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
            "[dbo].[Proc_update_Codigo_Icms]",
            ParameterBase<Codigo_IcmsModel>.SetParameterValue(objCodigo_Icms));

            objCodigo_Icms.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Delete(Codigo_IcmsModel objCodigo_Icms)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar("[dbo].[Proc_delete_Codigo_Icms]",
                  UserData.idUser,
                  objCodigo_Icms.idCodigoIcms);

            objCodigo_Icms.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Delete(int idCodigoIcmsPai)
        {
            UndTrabalho.dbPrincipal.ExecuteNonQuery(System.Data.CommandType.Text,
              "DELETE Codigo_Icms WHERE idCodigoIcmsPai = " + idCodigoIcmsPai);
        }

        public void Copy(Codigo_IcmsModel objCodigo_Icms)
        {
            objCodigo_Icms.idCodigoIcms = null;
            objCodigo_Icms.idCodigoIcms = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                                           UndTrabalho.dbTransaction,
                                           "[dbo].[Proc_save_Codigo_Icms]",
        ParameterBase<Codigo_IcmsModel>.SetParameterValue(objCodigo_Icms));
        }

        public Codigo_IcmsModel GetCodigo_Icms(int idCodigoIcms)
        {
            if (regAcessor == null)
            {
                regAcessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("[dbo].[Proc_sel_Codigo_Icms]",
                   new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idCodigoIcms"),
                   MapBuilder<Codigo_IcmsModel>.MapAllProperties().Build());
            }
            return regAcessor.Execute(idCodigoIcms).FirstOrDefault();
        }

        public List<Codigo_IcmsModel> GetAllCodigo_Icms(int idCodigoIcmsPai)
        {
            DataAccessor<Codigo_IcmsModel> reg = UndTrabalho.dbPrincipal.CreateSqlStringAccessor
            ("SELECT * FROM Codigo_Icms WHERE idCodigoIcmsPai = @idCodigoIcmsPai", new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idCodigoIcmsPai"),
            MapBuilder<Codigo_IcmsModel>.MapAllProperties().Build());

            return reg.Execute(idCodigoIcmsPai).ToList();
        }
    }
}
