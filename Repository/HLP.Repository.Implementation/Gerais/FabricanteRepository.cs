using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.Gerais;
using Ninject;
using HLP.Comum.Infrastructure;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Models.Entries.Gerais;
using HLP.Comum.Infrastructure.Static;


namespace HLP.Repository.Implementation.Entries.Gerais
{
    public class FabricanteRepository : IFabricanteRepository
    {

        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<FabricanteModel> regFabricanteAccessor;

        public Models.Entries.Gerais.FabricanteModel GetFabricante(int idFabricante)
        {
            if (regFabricanteAccessor == null)
            {
                regFabricanteAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_fabricante",
                                    new Parameters(UndTrabalho.dbPrincipal)
                                    .AddParameter<int>("idFabricante"),
                                    MapBuilder<FabricanteModel>.MapAllProperties().Build());
            }
            return regFabricanteAccessor.Execute(idFabricante).FirstOrDefault();
        }

        public void Save(Models.Entries.Gerais.FabricanteModel fabricante)
        {
            if (fabricante.idFabricante == null)
            {
                int idFabricante = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                  "dbo.Proc_save_fabricante",
                 ParameterBase<FabricanteModel>.SetParameterValue(fabricante));

                fabricante.idFabricante = idFabricante;
            }
            else
            {
                UndTrabalho.dbPrincipal.ExecuteScalar(
                  "[dbo].[Proc_update_Fabricante]",
                 ParameterBase<FabricanteModel>.SetParameterValue(fabricante));
            }
        }

        public void Delete(int idFabricante)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
                        "dbo.Proc_delete_fabricante",
                         UserData.idUser,
                         idFabricante);
        }

        public int Copy(int idFabricante)
        {
            return (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                        "dbo.Proc_copy_fabricante",
                         idFabricante);
        }
    }
}
