using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.Comercial;
using Ninject;
using HLP.Comum.Infrastructure;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Models.Entries.Comercial;
using HLP.Comum.Infrastructure.Static;


namespace HLP.Repository.Implementation.Entries.Comercial
{
    public class Lista_Preco_PaiRepository : ILista_Preco_PaiRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Lista_Preco_PaiModel> regLista_Preco_PaiAccessor;

        public void Save(Lista_Preco_PaiModel objLista_Preco_Pai)
        {
            //Aqui deve-se setar as FK's (se houver)
            //Exemplo:
            //produto.idEmpresa = CompanyData.idEmpresa;

            objLista_Preco_Pai.idEmpresa = CompanyData.idEmpresa;
            
            if (objLista_Preco_Pai.idListaPrecoPai == null)
            {
                objLista_Preco_Pai.idListaPrecoPai = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                "[dbo].[Proc_save_Lista_Preco_Pai]",
                ParameterBase<Lista_Preco_PaiModel>.SetParameterValue(objLista_Preco_Pai));
            }
            else
            {
                UndTrabalho.dbPrincipal.ExecuteScalar(
                "[dbo].[Proc_update_Lista_Preco_Pai]",
                ParameterBase<Lista_Preco_PaiModel>.SetParameterValue(objLista_Preco_Pai));
            }
        }

        public void Delete(Lista_Preco_PaiModel objLista_Preco_Pai)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
            UndTrabalho.dbTransaction,
           "[dbo].[Proc_delete_Lista_Preco_Pai]",
            UserData.idUser,
            objLista_Preco_Pai.idListaPrecoPai);
        }

        public void Copy(Lista_Preco_PaiModel objLista_Preco_Pai)
        {
            objLista_Preco_Pai.idListaPrecoPai = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
            UndTrabalho.dbTransaction,
           "dbo.Proc_copy_Lista_Preco_Pai",
            objLista_Preco_Pai.idListaPrecoPai);
        }

        public Lista_Preco_PaiModel GetLista_Preco_Pai(int idListaPrecoPai)
        {

            if (regLista_Preco_PaiAccessor == null)
            {
                regLista_Preco_PaiAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_Lista_Preco_Pai",
                                         new Parameters(UndTrabalho.dbPrincipal)
                                         .AddParameter<int>("idListaPrecoPai"),
                                         MapBuilder<Lista_Preco_PaiModel>.MapAllProperties().Build());
            }

            return regLista_Preco_PaiAccessor.Execute(idListaPrecoPai).FirstOrDefault();
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
