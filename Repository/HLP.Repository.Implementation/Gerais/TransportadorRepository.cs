using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.Gerais;
using Ninject;
using HLP.Comum.Infrastructure;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Models.Entries.Gerais;
using System.Data.Common;
using System.Data;
using HLP.Comum.Infrastructure.Static;


namespace HLP.Repository.Implementation.Entries.Gerais
{
    public class TransportadorRepository : ITransportadorReposiroty
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<TransportadorModel> regTransportadorAccessor;

        public void Save(TransportadorModel objTransportador)
        {
            //Aqui deve-se setar as FK's (se houver)
            //Exemplo:
            //produto.idEmpresa = CompanyData.idEmpresa;

            if (objTransportador.idTransportador == null)
            {
                objTransportador.idTransportador = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                "[dbo].[Proc_save_Transportador]",
                ParameterBase<TransportadorModel>.SetParameterValue(objTransportador));
            }
            else
            {
                UndTrabalho.dbPrincipal.ExecuteScalar(
                "[dbo].[Proc_update_Transportador]",
                ParameterBase<TransportadorModel>.SetParameterValue(objTransportador));
            }
        }

        public void Delete(TransportadorModel objTransportador)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
            UndTrabalho.dbTransaction,
           "[dbo].[Proc_delete_Transportador]",
            UserData.idUser,
            objTransportador.idTransportador);
        }

        public void Copy(TransportadorModel objTransportador)
        {
            objTransportador.idTransportador = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
            UndTrabalho.dbTransaction,
           "dbo.Proc_copy_Transportador",
            objTransportador.idTransportador);
        }

        public TransportadorModel GetTransportador(int idTransportador)
        {

            if (regTransportadorAccessor == null)
            {
                regTransportadorAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_Transportador",
                                         new Parameters(UndTrabalho.dbPrincipal)
                                         .AddParameter<int>("idTransportador"),
                                         MapBuilder<TransportadorModel>.MapAllProperties().Build());
            }

            return regTransportadorAccessor.Execute(idTransportador).FirstOrDefault();
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
