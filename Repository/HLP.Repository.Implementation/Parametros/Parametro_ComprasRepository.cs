﻿using HLP.Comum.Infrastructure;
using HLP.Comum.Infrastructure.Static;
using HLP.Models.Entries.Parametros;
using HLP.Repository.Interfaces.Entries.Parametros;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLP.Repository.Implementation.Entries.Parametros
{
    public class Parametro_ComprasRepository : IParametro_ComprasRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Parametro_ComprasModel> regParametro_ComprasAccessor;
        private DataAccessor<Parametro_ComprasModel> regAllParametro_ComprasAccessor;

        public void Save(Parametro_ComprasModel objParametro_Compras)
        {
            if (objParametro_Compras.idParametro_Compras == null)
            {
                objParametro_Compras.idParametro_Compras = (int)UndTrabalho.dbPrincipal.ExecuteScalar("dbo.Proc_save_Parametro_Compras",
                ParameterBase<Parametro_ComprasModel>.SetParameterValue(objParametro_Compras));
            }
            else
            {
                UndTrabalho.dbPrincipal.ExecuteScalar("[dbo].[Proc_update_Parametro_Compras]",
                ParameterBase<Parametro_ComprasModel>.SetParameterValue(objParametro_Compras));
            }
        }

        public void Delete(int idParametro_Compras)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar("dbo.Proc_delete_Parametro_Compras",
                 UserData.idUser,
                 idParametro_Compras);
        }

        public int Copy(int idParametro_Compras)
        {
            return (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                      "dbo.Proc_copy_Parametro_Compras",
                       idParametro_Compras);
        }

        public Parametro_ComprasModel GetParametro_Compras()
        {
            if (regParametro_ComprasAccessor == null)
            {
                regParametro_ComprasAccessor = UndTrabalho.dbPrincipal.CreateSqlStringAccessor("SELECT * FROM Parametro_Compras" +
                " where idEmpresa = " + CompanyData.idEmpresa,
                                MapBuilder<Parametro_ComprasModel>.MapAllProperties().Build());
            }

            return regParametro_ComprasAccessor.Execute().FirstOrDefault();
        }

        public List<Parametro_ComprasModel> GetAllParametro_Compras()
        {
            if (regAllParametro_ComprasAccessor == null)
            {
                regAllParametro_ComprasAccessor = UndTrabalho.dbPrincipal.CreateSqlStringAccessor("SELECT * FROM Parametro_Compras",
                                MapBuilder<Parametro_ComprasModel>.MapAllProperties().Build());
            }
            return regAllParametro_ComprasAccessor.Execute().ToList();
        }
    }
}
