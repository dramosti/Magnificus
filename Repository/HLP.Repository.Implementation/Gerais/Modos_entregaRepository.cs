using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.Gerais;
using HLP.Models.Entries.Gerais;
using HLP.Comum.Infrastructure;
using Ninject;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Comum.Models.Static;

namespace HLP.Repository.Implementation.Entries.Gerais
{
    public class Modos_entregaRepository : IModos_entregaRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Modos_entregaModel> regModoAccessor;

        public Modos_entregaModel GetModo(int idModosEntrega)
        {
            if (regModoAccessor == null)
            {
                regModoAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_modos_entrega",
                                  new Parameters(UndTrabalho.dbPrincipal)
                                    .AddParameter<int>("idModosEntrega"),
                                  MapBuilder<Modos_entregaModel>.MapAllProperties().Build());
            }


            return regModoAccessor.Execute(idModosEntrega).FirstOrDefault();
        }

        public void Save(Modos_entregaModel modo)
        {
            if(modo.idModosEntrega == null)
            {
                int idModosEntrega = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
               "[dbo].[Proc_save_modos_entrega]",
              ParameterBase<Modos_entregaModel>.SetParameterValue(modo));
                modo.idModosEntrega = idModosEntrega;
            }
            else
            {
                UndTrabalho.dbPrincipal.ExecuteScalar(
               "[dbo].[Proc_update_Modos_entrega]",
              ParameterBase<Modos_entregaModel>.SetParameterValue(modo));
            }            
        }

        public void Delete(int idModosEntrega)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
                 "dbo.Proc_delete_modos_entrega",
                  UserData.idUser,
                  idModosEntrega);
        }


        public int Copy(int idModosEntrega)
        {
            return (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                       "dbo.Proc_copy_modos_entrega",
                        idModosEntrega);
        }
    }
}
