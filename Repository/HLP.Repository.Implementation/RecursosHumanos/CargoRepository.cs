using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.RecursosHumanos;
using HLP.Comum.Infrastructure;
using Ninject;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Models.Entries.RecursosHumanos;
using HLP.Comum.Infrastructure.Static;


namespace HLP.Repository.Implementation.Entries.RecursosHumanos
{
    public class CargoRepository : ICargoRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<CargoModel> regCargoAccessor;

        public CargoModel GetCargo(int idCargo)
        {
            if (regCargoAccessor == null)
            {
                regCargoAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_cargo",
                                    new Parameters(UndTrabalho.dbPrincipal)
                                    .AddParameter<int>("idCargo"),
                                    MapBuilder<CargoModel>.MapAllProperties().Build());
            }
            return regCargoAccessor.Execute(idCargo).FirstOrDefault();
        }

        public void Save(CargoModel cargo)
        {
            if (cargo.idCargo == null)
            {
                int idCargo = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                  "dbo.Proc_save_cargo",
                 ParameterBase<CargoModel>.SetParameterValue(cargo));

                cargo.idCargo = idCargo;
            }
            else
            {
                UndTrabalho.dbPrincipal.ExecuteScalar(
                  "[dbo].[Proc_update_Cargo]",
                 ParameterBase<CargoModel>.SetParameterValue(cargo));
            }
        }

        public void Delete(int idCargo)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
                       "dbo.Proc_delete_cargo",
                        UserData.idUser,
                        idCargo);  
        }

        public int Copy(int idCargo)
        {
            return (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                        "dbo.Proc_copy_cargo",
                         idCargo);
        }
    }
}
