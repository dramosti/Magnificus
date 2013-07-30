using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;
using HLP.Models.Entries.Gerais;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Ninject;
using HLP.Repository.Interfaces.Entries.Gerais;
using HLP.Comum.Infrastructure.Static;

namespace HLP.Repository.Implementation.Entries.Gerais
{
    public class Transportador_VeiculosRepository : ITransportador_VeiculosRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Transportador_VeiculosModel> regAcessor;

        public void Save(Transportador_VeiculosModel objTransportador_Veiculos)
        {
            objTransportador_Veiculos.idTransportadorVeiculo = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
           "[dbo].[Proc_save_Transportador_Veiculos]",
            ParameterBase<Transportador_VeiculosModel>.SetParameterValue(objTransportador_Veiculos));

            objTransportador_Veiculos.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Update(Transportador_VeiculosModel objTransportador_Veiculos)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
            "[dbo].[Proc_update_Transportador_Veiculos]",
            ParameterBase<Transportador_VeiculosModel>.SetParameterValue(objTransportador_Veiculos));

            objTransportador_Veiculos.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Delete(Transportador_VeiculosModel objTransportador_Veiculos)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar("[dbo].[Proc_delete_Transportador_Veiculos]",
                  UserData.idUser,
                  objTransportador_Veiculos.idTransportadorVeiculo);

            objTransportador_Veiculos.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Delete(int idTransportador)
        {
            UndTrabalho.dbPrincipal.ExecuteNonQuery(System.Data.CommandType.Text,
              "DELETE Transportador_Veiculos WHERE idTransportador = " + idTransportador);
        }

        public void Copy(Transportador_VeiculosModel objTransportador_Veiculos)
        {
            objTransportador_Veiculos.idTransportadorVeiculo = null;
            objTransportador_Veiculos.idTransportadorVeiculo = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                                           UndTrabalho.dbTransaction,
                                           "[dbo].[Proc_save_Transportador_Veiculos]",
        ParameterBase<Transportador_VeiculosModel>.SetParameterValue(objTransportador_Veiculos));
        }

        public Transportador_VeiculosModel GetTransportador_Veiculos(int idTransportadorVeiculo)
        {
            if (regAcessor == null)
            {
                regAcessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("[dbo].[Proc_sel_Transportador_Veiculos]",
                   new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idTransportadorVeiculo"),
                   MapBuilder<Transportador_VeiculosModel>.MapAllProperties().Build());
            }
            return regAcessor.Execute(idTransportadorVeiculo).FirstOrDefault();
        }

        public List<Transportador_VeiculosModel> GetAllTransportador_Veiculos(int idTransportador)
        {
            DataAccessor<Transportador_VeiculosModel> reg = UndTrabalho.dbPrincipal.CreateSqlStringAccessor
            ("SELECT * FROM Transportador_Veiculos WHERE idTransportador = @idTransportador", new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idTransportador"),
            MapBuilder<Transportador_VeiculosModel>.MapAllProperties().Build());

            return reg.Execute(idTransportador).ToList();
        }
    }
}
