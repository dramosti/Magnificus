using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.Financeiro;
using HLP.Models.Entries.Financeiro;
using Ninject;
using HLP.Comum.Infrastructure;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Comum.Models.Static;
using System.Data.Common;
using System.Data;

namespace HLP.Repository.Implementation.Entries.Financeiro
{
    public class Agencia_ContatoRepository : IAgencia_ContatoRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Agencia_ContatoModel> regAcessor;

        public void Save(Agencia_ContatoModel objAgencia_Contato)
        {
            objAgencia_Contato.idAgenciaContato = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
           "[dbo].[Proc_save_Agencia_Contato]",
            ParameterBase<Agencia_ContatoModel>.SetParameterValue(objAgencia_Contato));

            objAgencia_Contato.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Update(Agencia_ContatoModel objAgencia_Contato)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
            "[dbo].[Proc_update_Agencia_Contato]",
            ParameterBase<Agencia_ContatoModel>.SetParameterValue(objAgencia_Contato));

            objAgencia_Contato.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Delete(Agencia_ContatoModel objAgencia_Contato)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar("[dbo].[Proc_delete_Agencia_Contato]",
                  UserData.idUser,
                  objAgencia_Contato.idAgenciaContato);

            objAgencia_Contato.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Delete(int idAgencia)
        {
            UndTrabalho.dbPrincipal.ExecuteNonQuery(System.Data.CommandType.Text,
              "DELETE Agencia_Contato WHERE idAgencia = " + idAgencia);
        }

        public void Copy(Agencia_ContatoModel objAgencia_Contato)
        {
            objAgencia_Contato.idAgenciaContato = null;
            objAgencia_Contato.idAgenciaContato = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                                           UndTrabalho.dbTransaction,
                                           "[dbo].[Proc_save_Agencia_Contato]",
        ParameterBase<Agencia_ContatoModel>.SetParameterValue(objAgencia_Contato));
        }

        public Agencia_ContatoModel GetAgencia_Contato(int idAgenciaContato)
        {
            if (regAcessor == null)
            {
                regAcessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("[dbo].[Proc_sel_Agencia_Contato]",
                   new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idAgenciaContato"),
                   MapBuilder<Agencia_ContatoModel>.MapAllProperties().Build());
            }
            return regAcessor.Execute(idAgenciaContato).FirstOrDefault();
        }

        public List<Agencia_ContatoModel> GetAllAgencia_Contato(int idAgencia)
        {
            DataAccessor<Agencia_ContatoModel> reg = UndTrabalho.dbPrincipal.CreateSqlStringAccessor
            ("SELECT * FROM Agencia_Contato WHERE idAgencia = @idAgencia", new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idAgencia"),
            MapBuilder<Agencia_ContatoModel>.MapAllProperties().Build());

            return reg.Execute(idAgencia).ToList();
        }
    }
}
