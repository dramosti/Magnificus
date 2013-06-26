using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using HLP.Comum.Infrastructure;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Repository.Interfaces.Entries.Gerais;
using HLP.Models.Entries.Gerais;
using HLP.Comum.Models.Static;
using System.Data.Common;
using System.Data;

namespace HLP.Repository.Implementation.Entries.Gerais
{
    public class ContatoRepository : IContatoRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<ContatoModel> regContatoAccessor;

        public void Save(ContatoModel objContato)
        {
            //Aqui deve-se setar as FK's (se houver)
            //Exemplo:
            //produto.idEmpresa = CompanyData.idEmpresa;

            if (objContato.idContato == null)
            {
                objContato.idContato = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                "[dbo].[Proc_save_Contato]",
                ParameterBase<ContatoModel>.SetParameterValue(objContato));
            }
            else
            {
                UndTrabalho.dbPrincipal.ExecuteScalar(
                "[dbo].[Proc_update_Contato]",
                ParameterBase<ContatoModel>.SetParameterValue(objContato));
            }
        }

        public void Delete(ContatoModel objContato)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
            UndTrabalho.dbTransaction,
           "[dbo].[Proc_delete_Contato]",
            UserData.idUser,
            objContato.idContato);
        }

        public void Copy(ContatoModel objContato)
        {
            objContato.idContato = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
            UndTrabalho.dbTransaction,
           "dbo.Proc_copy_Contato",
            objContato.idContato);
        }

        public ContatoModel GetContato(int idContato)
        {

            if (regContatoAccessor == null)
            {
                regContatoAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_Contato",
                                         new Parameters(UndTrabalho.dbPrincipal)
                                         .AddParameter<int>("idContato"),
                                         MapBuilder<ContatoModel>.MapAllProperties().Build());
            }

            return regContatoAccessor.Execute(idContato).FirstOrDefault();
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
