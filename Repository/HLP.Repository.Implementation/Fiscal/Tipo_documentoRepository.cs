using System;
using System.Linq;
using HLP.Comum.Infrastructure;
using HLP.Comum.Models.Static;
using HLP.Models.Entries.Fiscal;
using HLP.Repository.Interfaces.Entries.Fiscal;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Ninject;

namespace HLP.Repository.Implementation.Entries.Fiscal
{
    public class Tipo_documentoRepository : ITipo_documentoRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Tipo_documentoModel> regDocumentoAccessor;

        public Tipo_documentoModel GetDocumento(int idTipoDocumento)
        {
            if (regDocumentoAccessor == null)
            {
                regDocumentoAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_tipo_documento",
                                  new Parameters(UndTrabalho.dbPrincipal)
                                    .AddParameter<int>("idTipoDocumento"),
                                  MapBuilder<Tipo_documentoModel>.MapAllProperties().Build());
            }


            return regDocumentoAccessor.Execute(idTipoDocumento).FirstOrDefault();
        }

        public void Save(Tipo_documentoModel documento)
        {
            if (documento.idTipoDocumento == null)
            {
                int idTipoDocumento = Convert.ToInt32((UndTrabalho.dbPrincipal.ExecuteScalar(UndTrabalho.dbTransaction,
                   "dbo.Proc_save_tipo_documento",
                  ParameterBase<Tipo_documentoModel>.SetParameterValue(documento))));

                documento.idTipoDocumento = idTipoDocumento;
            }
            else
            {
                UndTrabalho.dbPrincipal.ExecuteScalar(UndTrabalho.dbTransaction,
                   "[dbo].[Proc_update_Tipo_documento]",
                  ParameterBase<Tipo_documentoModel>.SetParameterValue(documento));
            }
        }

        public void Delete(int idTipoDocumento)
        {

            UndTrabalho.dbPrincipal.ExecuteScalar(UndTrabalho.dbTransaction,
                "dbo.Proc_delete_tipo_documento",
                 UserData.idUser,
                 idTipoDocumento);
        }

        public void Begin()
        {
            UndTrabalho.BeginTransaction();
        }

        public void Commit()
        {
            UndTrabalho.CommitTransaction();
        }

        public void RollBack()
        {
            UndTrabalho.RollBackTransaction();
        }


        public int Copy(int idTipoDocumento)
        {
            return (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                         "dbo.Proc_copy_tipo_documento",
                          idTipoDocumento);
        }
    }
}
