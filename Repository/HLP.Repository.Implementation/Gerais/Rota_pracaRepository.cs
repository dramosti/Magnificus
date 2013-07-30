using System;
using System.Collections.Generic;
using System.Linq;
using HLP.Repository.Interfaces.Entries.Comercial;
using Ninject;
using HLP.Comum.Infrastructure;
using Microsoft.Practices.EnterpriseLibrary.Data;

using System.Data.Common;
using System.Data;
using HLP.Models.Entries.Gerais;
using HLP.Repository.Interfaces.Entries.Gerais;
using HLP.Comum.Infrastructure.Static;

namespace HLP.Repository.Implementation.Entries.Gerais
{
    public class Rota_pracaRepository : IRota_pracaRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Rota_pracaModel> regAcessor;

        public void Save(Rota_pracaModel objRota_Praca)
        {
            objRota_Praca.idRotaPraca = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
           "[dbo].[Proc_save_Rota_Praca]",
            ParameterBase<Rota_pracaModel>.SetParameterValue(objRota_Praca));

            objRota_Praca.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Update(Rota_pracaModel objRota_Praca)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
            "[dbo].[Proc_update_Rota_Praca]",
            ParameterBase<Rota_pracaModel>.SetParameterValue(objRota_Praca));

            objRota_Praca.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Delete(Rota_pracaModel objRota_Praca)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar("[dbo].[Proc_delete_Rota_Praca]",
                  UserData.idUser,
                  objRota_Praca.idRotaPraca);

            objRota_Praca.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Delete(int idRota)
        {
            UndTrabalho.dbPrincipal.ExecuteNonQuery(System.Data.CommandType.Text,
              "DELETE Rota_Praca WHERE idRota = " + idRota);
        }

        public void Copy(Rota_pracaModel objRota_Praca)
        {
            objRota_Praca.idRotaPraca = null;
            objRota_Praca.idRotaPraca = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                                           UndTrabalho.dbTransaction,
                                           "[dbo].[Proc_save_Rota_Praca]",
        ParameterBase<Rota_pracaModel>.SetParameterValue(objRota_Praca));
        }

        public Rota_pracaModel GetRota_Praca(int idRotaPraca)
        {
            if (regAcessor == null)
            {
                regAcessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("[dbo].[Proc_sel_Rota_Praca]",
                   new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idRotaPraca"),
                   MapBuilder<Rota_pracaModel>.MapAllProperties().Build());
            }
            return regAcessor.Execute(idRotaPraca).FirstOrDefault();
        }

        public List<Rota_pracaModel> GetAllRota_Praca(int idRota)
        {
            DataAccessor<Rota_pracaModel> reg = UndTrabalho.dbPrincipal.CreateSqlStringAccessor
            ("SELECT * FROM Rota_Praca WHERE idRota = @idRota", new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idRota"),
            MapBuilder<Rota_pracaModel>.MapAllProperties().Build());

            return reg.Execute(idRota).ToList();
        }
    }
}
