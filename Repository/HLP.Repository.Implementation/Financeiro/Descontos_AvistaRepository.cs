using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.Financeiro;
using HLP.Models.Entries.Financeiro;
using HLP.Comum.Infrastructure;
using Ninject;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Comum.Infrastructure.Static;


namespace HLP.Repository.Implementation.Entries.Financeiro
{
    public class Descontos_AvistaRepository : IDescontos_AvistaRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Descontos_AvistaModel> regDescontoAccessor;

        private DataAccessor<Descontos_AvistaModel> regAllDescontoeAccessor;

        public Descontos_AvistaModel GetDesconto(int idDescontosAvista)
        {
            if (regDescontoAccessor == null)
            {
                regDescontoAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_descontos_avista",
                                  new Parameters(UndTrabalho.dbPrincipal)
                                    .AddParameter<int>("idDescontosAvista"),
                                  MapBuilder<Descontos_AvistaModel>.MapAllProperties().Build());
            }


            return regDescontoAccessor.Execute(idDescontosAvista).FirstOrDefault();
        }

        public List<Descontos_AvistaModel> GetAll()
        {
            if (regAllDescontoeAccessor == null)
            {
                regAllDescontoeAccessor = UndTrabalho.dbPrincipal.CreateSqlStringAccessor("SELECT * FROM Descontos_Avista",
                                  MapBuilder<Descontos_AvistaModel>.MapAllProperties().Build());
            }
            return regAllDescontoeAccessor.Execute().ToList();
        }

        public void Save(Descontos_AvistaModel desconto)
        {
            if (desconto.idDescontosAvista == null)
            {
                int idDescontosAvista = Convert.ToInt32((UndTrabalho.dbPrincipal.ExecuteScalar("dbo.Proc_save_descontos_avista",
           ParameterBase<Descontos_AvistaModel>.SetParameterValue(desconto))));

                desconto.idDescontosAvista = idDescontosAvista;
            }
            else
            {
                UndTrabalho.dbPrincipal.ExecuteScalar("dbo.Proc_update_Descontos_Avista",
           ParameterBase<Descontos_AvistaModel>.SetParameterValue(desconto));
            }
            
        }

        public void Delete(int idDescontosAvista)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar("dbo.Proc_delete_descontos_avista",
                 UserData.idUser,
                 idDescontosAvista);
        }


        public int Copy(int idDescontosAvista)
        {
            return (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                       "dbo.Proc_copy_descontos_avista",
                        idDescontosAvista);
        }
    }
}
