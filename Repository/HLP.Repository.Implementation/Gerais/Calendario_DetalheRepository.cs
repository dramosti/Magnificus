using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.Gerais;
using HLP.Models.Entries.Gerais;
using Ninject;
using HLP.Comum.Infrastructure;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Comum.Models.Static;
using System.Data.Common;
using System.Data;

namespace HLP.Repository.Implementation.Entries.Gerais
{
    public class Calendario_DetalheRepository : ICalendario_DetalheRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Calendario_DetalheModel> regAcessor;

        public void Save(Calendario_DetalheModel objCalendario_Detalhe)
        {
            objCalendario_Detalhe.idCalendarioDetalhe = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
           "[dbo].[Proc_save_Calendario_Detalhe]",
            ParameterBase<Calendario_DetalheModel>.SetParameterValue(objCalendario_Detalhe));

            objCalendario_Detalhe.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Update(Calendario_DetalheModel objCalendario_Detalhe)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
            "[dbo].[Proc_update_Calendario_Detalhe]",
            ParameterBase<Calendario_DetalheModel>.SetParameterValue(objCalendario_Detalhe));

            objCalendario_Detalhe.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Delete(Calendario_DetalheModel objCalendario_Detalhe)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar("[dbo].[Proc_delete_Calendario_Detalhe]",
                  UserData.idUser,
                  objCalendario_Detalhe.idCalendarioDetalhe);

            objCalendario_Detalhe.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Delete(int idCalendario)
        {
            UndTrabalho.dbPrincipal.ExecuteNonQuery(System.Data.CommandType.Text,
              "DELETE Calendario_Detalhe WHERE idCalendario = " + idCalendario);
        }

        public void Copy(Calendario_DetalheModel objCalendario_Detalhe)
        {
            objCalendario_Detalhe.idCalendarioDetalhe = null;
            objCalendario_Detalhe.idCalendarioDetalhe = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                                           UndTrabalho.dbTransaction,
                                           "[dbo].[Proc_save_Calendario_Detalhe]",
        ParameterBase<Calendario_DetalheModel>.SetParameterValue(objCalendario_Detalhe));
        }

        public Calendario_DetalheModel GetCalendario_Detalhe(int idCalendarioDetalhe)
        {
            if (regAcessor == null)
            {
                regAcessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("[dbo].[Proc_sel_Calendario_Detalhe]",
                   new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idCalendarioDetalhe"),
                   MapBuilder<Calendario_DetalheModel>.MapAllProperties().Build());
            }
            return regAcessor.Execute(idCalendarioDetalhe).FirstOrDefault();
        }

        public List<Calendario_DetalheModel> GetAllCalendario_Detalhe(int idCalendario)
        {
            DataAccessor<Calendario_DetalheModel> reg = UndTrabalho.dbPrincipal.CreateSqlStringAccessor
            ("SELECT * FROM Calendario_Detalhe WHERE idCalendario = @idCalendario", new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idCalendario"),
            MapBuilder<Calendario_DetalheModel>.MapAllProperties().Build());

            return reg.Execute(idCalendario).ToList();
        }
    }
}
