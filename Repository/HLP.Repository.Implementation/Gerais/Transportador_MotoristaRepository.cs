using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Comum.Models.Static;
using HLP.Comum.Infrastructure;
using Ninject;
using HLP.Repository.Interfaces.Entries.Gerais;

namespace HLP.Repository.Implementation.Entries.Gerais
{
    public class Transportador_MotoristaRepository : ITransportador_MotoristaRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Transportador_MotoristaModel> regAcessor;

        public void Save(Transportador_MotoristaModel objTransportador_Motorista)
        {
            objTransportador_Motorista.idTransportdorMotorista = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
           "[dbo].[Proc_save_Transportador_Motorista]",
            ParameterBase<Transportador_MotoristaModel>.SetParameterValue(objTransportador_Motorista));

            objTransportador_Motorista.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Update(Transportador_MotoristaModel objTransportador_Motorista)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
            "[dbo].[Proc_update_Transportador_Motorista]",
            ParameterBase<Transportador_MotoristaModel>.SetParameterValue(objTransportador_Motorista));

            objTransportador_Motorista.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Delete(Transportador_MotoristaModel objTransportador_Motorista)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar("[dbo].[Proc_delete_Transportador_Motorista]",
                  UserData.idUser,
                  objTransportador_Motorista.idTransportdorMotorista);

            objTransportador_Motorista.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Delete(int idTransportador)
        {
            UndTrabalho.dbPrincipal.ExecuteNonQuery(System.Data.CommandType.Text,
              "DELETE Transportador_Motorista WHERE idTransportador = " + idTransportador);
        }

        public void Copy(Transportador_MotoristaModel objTransportador_Motorista)
        {
            objTransportador_Motorista.idTransportdorMotorista = null;
            objTransportador_Motorista.idTransportdorMotorista = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                                           UndTrabalho.dbTransaction,
                                           "[dbo].[Proc_save_Transportador_Motorista]",
        ParameterBase<Transportador_MotoristaModel>.SetParameterValue(objTransportador_Motorista));
        }

        public Transportador_MotoristaModel GetTransportador_Motorista(int idTransportdorMotorista)
        {
            if (regAcessor == null)
            {
                regAcessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("[dbo].[Proc_sel_Transportador_Motorista]",
                   new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idTransportdorMotorista"),
                   MapBuilder<Transportador_MotoristaModel>.MapAllProperties().Build());
            }
            return regAcessor.Execute(idTransportdorMotorista).FirstOrDefault();
        }

        public List<Transportador_MotoristaModel> GetAllTransportador_Motorista(int idTransportador)
        {
            DataAccessor<Transportador_MotoristaModel> reg = UndTrabalho.dbPrincipal.CreateSqlStringAccessor
            ("SELECT * FROM Transportador_Motorista WHERE idTransportador = @idTransportador", new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idTransportador"),
            MapBuilder<Transportador_MotoristaModel>.MapAllProperties().Build());

            return reg.Execute(idTransportador).ToList();
        }
    }
}
