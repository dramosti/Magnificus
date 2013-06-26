using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.Gerais;
using HLP.Models.Entries.Gerais;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Ninject;
using HLP.Comum.Infrastructure;
using System.Data.Common;
using HLP.Comum.Models.Static;

namespace HLP.Repository.Implementation.Entries.Gerais
{
    public class UsuarioRepository : IUsuarioRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }
        private DataAccessor<UsuarioModel> regUsuarioModelAccessor;

        public UsuarioModel ValidaUsuario(string xID, string xSenha)
        {
            DataAccessor<UsuarioModel> regUsuario = UndTrabalho.dbPrincipal.CreateSqlStringAccessor
                                  (
                                   string.Format("SELECT * FROM USUARIO WHERE xid = '{0}' and xSenha = '{1}'", xID, xSenha),
                                   MapBuilder<UsuarioModel>.MapAllProperties().Build()
                                  );
            return regUsuario.Execute().FirstOrDefault();
        }


        public int ValidaNomeUsuario(string xId)
        {

            DbCommand comand = UndTrabalho.dbPrincipal.GetSqlStringCommand
                              (
                              string.Format("SELECT COUNT(*) FROM USUARIO WHERE xId = '{0}'", xId)
                              );

            return (int)UndTrabalho.dbPrincipal.ExecuteScalar(comand);
        }


        public int ValidaAcesso(int idEmpresa, int idUsuario)
        {
            DbCommand comand = UndTrabalho.dbPrincipal.GetSqlStringCommand
                              (
                              string.Format("SELECT COUNT(*) from ACESSO WHERE idUsuario = {0} and idEmpresa = {1}", idUsuario, idEmpresa)
                              );

            return (int)UndTrabalho.dbPrincipal.ExecuteScalar(comand);
        }


        public UsuarioModel GetUsuario(int idUsuario)
        {
            if (regUsuarioModelAccessor == null)
            {
                regUsuarioModelAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_Usuario",
                                    new Parameters(UndTrabalho.dbPrincipal)
                                    .AddParameter<int>("idUsuario"),
                                    MapBuilder<UsuarioModel>.MapAllProperties().Build());
            }
            return regUsuarioModelAccessor.Execute(idUsuario).FirstOrDefault();
        }


        public string GetQueryUserByEmpresaToComboBox()
        {
            return "SELECT ID as idUsuario,(CAST(ID AS varchar)+' - '+ xNome)xNome  FROM vwUsuario Where idEmpresa = " + CompanyData.idEmpresa.ToString();
        }

        public int GetIdUserHLP()
        {
            DbCommand command = UndTrabalho.dbPrincipal.GetSqlStringCommand("select idUsuario from Usuario where stTipoUsuario = 0");
            return UndTrabalho.dbPrincipal.ExecuteScalar(command).ToInt32();
        }
        public int GetIdUserDEFAULT()
        {
            DbCommand command = UndTrabalho.dbPrincipal.GetSqlStringCommand("select idUsuario from Usuario where stTipoUsuario = 1");
            return UndTrabalho.dbPrincipal.ExecuteScalar(command).ToInt32();
        }
    }
}
