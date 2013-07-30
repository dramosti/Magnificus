using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.Comercial;
using HLP.Models.Entries.Comercial;
using Ninject;
using HLP.Comum.Infrastructure;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Comum.Infrastructure.Static;


namespace HLP.Repository.Implementation.Entries.Comercial
{
    public class Canal_vendaRepository : ICanal_vendaRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Canal_vendaModel> regCanalAccessor;

        public Canal_vendaModel GetCanal(int idCanalVenda)
        {
            if (regCanalAccessor == null)
            {
                regCanalAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_canal_venda",
                                    new Parameters(UndTrabalho.dbPrincipal)
                                    .AddParameter<int>("idCanalVenda"),
                                    MapBuilder<Canal_vendaModel>.MapAllProperties().Build());
            }
            return regCanalAccessor.Execute(idCanalVenda).FirstOrDefault();
        }

        public void Save(Canal_vendaModel canal)
        {
            //int idMultas = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
            //         "[dbo].[Proc_save_multas]",
            //        ParameterBase<MultasModel>.SetParameterValue(multa));

            //multa.idMultas = idMultas;

            if (canal.idCanalVenda == null)
            {
                int idCanalVenda = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                  "Proc_save_Canal_venda", //Proc_save_Canal_venda
                 ParameterBase<Canal_vendaModel>.SetParameterValue(canal));
                canal.idCanalVenda = idCanalVenda;                
            }
            else
            {
                UndTrabalho.dbPrincipal.ExecuteScalar(
                  "[dbo].[Proc_update_Canal_venda]",
                 ParameterBase<Canal_vendaModel>.SetParameterValue(canal));
            }
        }

        public void Delete(int idCanalVenda)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
                     "dbo.Proc_delete_canal_venda",
                      UserData.idUser,
                      idCanalVenda);
        }


        public int Copy(int idCanalVenda)
        {
          return (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                        "dbo.Proc_copy_canal_venda",
                         idCanalVenda);
        }
    }
}
