using System.Linq;
using HLP.Comum.Infrastructure;
using HLP.Comum.Models.Static;
using HLP.Models.Entries.Gerais;
using HLP.Repository.Interfaces.Entries.Gerais;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Ninject;

namespace HLP.Repository.Implementation.Entries.Gerais
{
    public class Ramo_atividadeRepository : IRamo_atividadeRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Ramo_atividadeModel> regMoedaAccessor;

        public Ramo_atividadeModel GetRamo(int idRamoAtividade)
        {
            if (regMoedaAccessor == null)
            {
                regMoedaAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_ramo_atividade",
                                  new Parameters(UndTrabalho.dbPrincipal)
                                    .AddParameter<int>("idRamoAtividade"),
                                  MapBuilder<Ramo_atividadeModel>.MapAllProperties().Build());
            }


            return regMoedaAccessor.Execute(idRamoAtividade).FirstOrDefault();
        }

        public void Save(Ramo_atividadeModel ramo)
        {
            if(ramo.idRamoAtividade == null)
            {
                int idRamoAtividade = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
             "[dbo].[Proc_save_ramo_atividade]",
            ParameterBase<Ramo_atividadeModel>.SetParameterValue(ramo));

                ramo.idRamoAtividade = idRamoAtividade;
            }
            else
            {
                UndTrabalho.dbPrincipal.ExecuteScalar(
             "[dbo].[Proc_update_Ramo_atividade]",
            ParameterBase<Ramo_atividadeModel>.SetParameterValue(ramo));
            }
            
        }

        public void Delete(int idRamoAtividade)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
                   "dbo.Proc_delete_ramo_atividade",
                    UserData.idUser,
                    idRamoAtividade);
        }


        public int Copy(int idRamoAtividade)
        {
            return (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                        "dbo.Proc_copy_ramo_atividade",
                         idRamoAtividade);
        }
    }
}
