using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.RecursosHumanos;
using Ninject;
using HLP.Comum.Infrastructure;
using HLP.Models.Entries.RecursosHumanos;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Comum.Infrastructure.Static;


namespace HLP.Repository.Implementation.Entries.RecursosHumanos
{
    public class SetorRepository : ISetorRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }


        private DataAccessor<SetorModel> regSetorAccessor;
        private DataAccessor<SetorModel> regAllSetorAccessor;

        public SetorModel GetSetor(int idSetor)
        {
            if (regSetorAccessor == null)
            {
                regSetorAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_setor",
                                  new Parameters(UndTrabalho.dbPrincipal)
                                    .AddParameter<int>("idSetor"),
                                  MapBuilder<SetorModel>.MapAllProperties().Build());
            }


            return regSetorAccessor.Execute(idSetor, CompanyData.idEmpresa).FirstOrDefault();
        }

        public void Save(SetorModel setor)
        {
            if (setor.idSetor == null)
            {
                int idSetor = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
              "[dbo].[Proc_save_setor]",
             ParameterBase<SetorModel>.SetParameterValue(setor));

                setor.idSetor = idSetor;
            }
            else
            {
                UndTrabalho.dbPrincipal.ExecuteScalar(
              "dbo.Proc_update_Setor",
             ParameterBase<SetorModel>.SetParameterValue(setor));
            }            
        }

        public void Delete(int idSetor)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
                   "dbo.Proc_delete_setor",
                    UserData.idUser,
                    idSetor);
        }


        public int Copy(int idSetor)
        {
            return (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                       "dbo.Proc_copy_setor",
                        idSetor);
        }

        public List<SetorModel> GetAll()
        {
            if (regAllSetorAccessor == null)
            {
                regAllSetorAccessor = UndTrabalho.dbPrincipal.CreateSqlStringAccessor("SELECT * FROM Setor",
                                  MapBuilder<SetorModel>.MapAllProperties().Build());
            }
            return regAllSetorAccessor.Execute().ToList();
        }
    }
}
