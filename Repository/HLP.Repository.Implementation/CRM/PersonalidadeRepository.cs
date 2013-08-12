using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.CRM;
using HLP.Models.Entries.CRM;
using Ninject;
using HLP.Comum.Infrastructure;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Comum.Infrastructure.Static;


namespace HLP.Repository.Implementation.Entries.CRM
{
    public class PersonalidadeRepository : IPersonalidadeRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<PersonalidadeModel> regPersonalidadeAccessor;

        public PersonalidadeModel GetPersonalidade(int idPersonalidade)
        {
            if (regPersonalidadeAccessor == null)
            {
                regPersonalidadeAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_personalidade",
                                    new Parameters(UndTrabalho.dbPrincipal)
                                    .AddParameter<int>("idPersonalidade"),
                                    MapBuilder<PersonalidadeModel>.MapAllProperties().Build());
            }
            return regPersonalidadeAccessor.Execute(idPersonalidade).FirstOrDefault();
        }

        public void Save(PersonalidadeModel personalidade)
        {
            if (personalidade.idPersonalidade == null)
            {
                int idPersonalidade = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                 "dbo.Proc_save_personalidade",
                ParameterBase<PersonalidadeModel>.SetParameterValue(personalidade));

                personalidade.idPersonalidade = idPersonalidade;
            }
            else
            {
                UndTrabalho.dbPrincipal.ExecuteScalar(
                 "[dbo].[Proc_update_Personalidade]",
                ParameterBase<PersonalidadeModel>.SetParameterValue(personalidade));
            }
        }

        public void Delete(int idPersonalidade)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
                     "dbo.Proc_delete_personalidade",
                      UserData.idUser,
                      idPersonalidade);
        }

        public int Copy(int idPersonalidade)
        {
            return (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                      "dbo.Proc_copy_personalidade",
                       idPersonalidade);
        }
    }
}
