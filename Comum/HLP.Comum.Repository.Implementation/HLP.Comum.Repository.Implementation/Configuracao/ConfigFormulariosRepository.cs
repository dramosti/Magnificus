using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;
using Ninject;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Comum.Repository.Interfaces.Configuracao;
using System.Data.Common;
using HLP.Comum.Models.Static;
using HLP.Models.Entries.Parametros;
using HLP.Services.Interfaces.Entries.Parametros;
using HLP.Repository.Interfaces.Entries.Parametros;

namespace HLP.Comum.Repository.Implementation.Configuracao
{
    public class ConfigFormulariosRepository : IConfigFormulariosRepository
    {

        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }
        [Inject]
        public IConfigTabPageRepository itabPageRepository { get; set; }
        [Inject]
        public IConfigPesquisaRepository iConfigPesquisaRepository { get; set; }        

        private DataAccessor<ConfigFormulariosModel> regListFormularioAccessor;
        public void Save(ConfigFormulariosModel formulario)
        {
            if (formulario.idFormularios == null)
            {
                formulario.idFormularios = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                    UndTrabalho.dbTransaction,
                   "[dbo].[Proc_save_CONFIG_Formularios]",
                  ParameterBase<ConfigFormulariosModel>.SetParameterValue(formulario));
            }
            foreach (CONFIG_PesquisaModel pesq in formulario.lPesquisa)
            {
                pesq.idFormularios = formulario.idFormularios.ToInt32();
                iConfigPesquisaRepository.Save(pesq);
            }

            formulario.objConfigFormUsu.idFormularioUsuario = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                UndTrabalho.dbTransaction,
               "[dbo].[Proc_save_CONFIG_Formulario_Usuario]",
              ParameterBase<ConfigFormularioUsuModel>.SetParameterValue(formulario.objConfigFormUsu));

            foreach (var tab in formulario.lConfigTabPage)
            {
                itabPageRepository.Save(tab);
            }

            
        }
        public int GetIdFormulario(string xNameFormulario, int idUsuario)
        {
            try
            {
                DbCommand command = UndTrabalho.dbPrincipal.GetSqlStringCommand(
                                                "select f.idFormularios from CONFIG_Formularios f inner join CONFIG_Formulario_usuario fu on " +
                                                "f.idFormularios = fu.idFormularios " +
                                                "where f.xNameFormulario = @xNameFormulario  and fu.idUsuario = @idUsuario");
                command.CommandType = CommandType.Text;
                UndTrabalho.dbPrincipal.AddInParameter(command, "xNameFormulario", DbType.String, xNameFormulario);
                UndTrabalho.dbPrincipal.AddInParameter(command, "idUsuario", DbType.String, idUsuario);
                var dados = UndTrabalho.dbPrincipal.ExecuteScalar(command);
                if (dados != null)
                {
                    return dados.ToInt32();
                }
                else
                {
                    return 0;
                }

            }
            catch (Exception)
            {
                throw;
            }
        }
        public ConfigFormulariosModel GetFormulario(string xNameFormulario, int idUsuario)
        {
            try
            {
                ConfigFormulariosModel objFormularioRet = null;
                DataAccessor<ConfigFormulariosModel> regFormularioAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_CONFIG_FormularioByName",
                                    new Parameters(UndTrabalho.dbPrincipal)
                                      .AddParameter<string>("xNameFormulario"),
                                    MapBuilder<ConfigFormulariosModel>.MapAllProperties().Build());

                objFormularioRet = regFormularioAccessor.Execute(xNameFormulario).FirstOrDefault();
                if (objFormularioRet != null)
                {
                    DataAccessor<ConfigFormularioUsuModel> regAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_CONFIG_Formulario_Usuario",
                                      new Parameters(UndTrabalho.dbPrincipal)
                                        .AddParameter<int>("idFormulario").AddParameter<int>("idUsuario"),
                                      MapBuilder<ConfigFormularioUsuModel>.MapAllProperties().Build());

                    objFormularioRet.objConfigFormUsu = regAccessor.Execute(objFormularioRet.idFormularios, idUsuario).FirstOrDefault();

                    objFormularioRet.lPesquisa = iConfigPesquisaRepository.GetAllCONFIG_Pesquisa(objFormularioRet.idFormularios.ToInt32(), idUsuario);
                }
                return objFormularioRet;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public ConfigFormulariosModel GetFormulario(int idFormularios, int idUsuario)
        {
            try
            {
                ConfigFormulariosModel objFormularioRet = null;
                DataAccessor<ConfigFormulariosModel> regAccessorFormulario = UndTrabalho.dbPrincipal.CreateSqlStringAccessor("Proc_sel_CONFIG_Formularios",
                                     new Parameters(UndTrabalho.dbPrincipal)
                                       .AddParameter<int>("idFormularios"),
                                     MapBuilder<ConfigFormulariosModel>.MapAllProperties().Build());

                objFormularioRet = regAccessorFormulario.Execute(idFormularios).FirstOrDefault();

                DataAccessor<ConfigFormularioUsuModel> regAccessorFormularioUsu = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_CONFIG_Formulario_Usuario",
                                  new Parameters(UndTrabalho.dbPrincipal)
                                    .AddParameter<int>("idFormulario").AddParameter<int>("idUsuario"),
                                  MapBuilder<ConfigFormularioUsuModel>.MapAllProperties().Build());

                objFormularioRet.objConfigFormUsu = regAccessorFormularioUsu.Execute(objFormularioRet.idFormularios, idUsuario).FirstOrDefault();

                return objFormularioRet;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<ConfigFormulariosModel> GetAll()
        {
            if (regListFormularioAccessor == null)
            {
                regListFormularioAccessor = UndTrabalho.dbPrincipal.CreateSqlStringAccessor("SELECT * FROM CONFIG_Formularios",
                                  new Parameters(UndTrabalho.dbPrincipal),
                                  MapBuilder<ConfigFormulariosModel>.MapAllProperties().Build());
            }
            return regListFormularioAccessor.Execute().ToList();
        }
        public void DeleteFormularioUsuario(int idFormularios, int idUsuario)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar("dbo.Proc_delete_CONFIG_Formularios",
                UserData.idUser, //usuario para log 
                 idFormularios,
                 idUsuario);
        }
        public int DeleteFormularioUsuario(string sNameFormulario, int idUsuario)
        {
            ConfigFormulariosModel objForm = GetFormulario(sNameFormulario, idUsuario);
            int idReturn = 0;
            if (objForm != null)
            {
                idReturn = objForm.idFormularios.ToInt32();
                this.DeleteFormularioUsuario(objForm.idFormularios.ToInt32(), idUsuario);
            }
            return idReturn;
        }
        public bool FormularioExistInDataBase(string xName)
        {
            try
            {
                DbCommand comand = UndTrabalho.dbPrincipal.GetSqlStringCommand
                            (
                            string.Format("SELECT  COUNT(*)  FROM CONFIG_Formularios WHERE xNameFormulario = '{0}'", xName)
                            );

                int i = (int)UndTrabalho.dbPrincipal.ExecuteScalar(comand);
                if (i == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool FormularioExistInDataBase(string xName, int idUser)
        {
            try
            {
                StringBuilder sQuery = new StringBuilder();
                sQuery.Append("select count(*) from CONFIG_Formularios f ");
                sQuery.Append("inner join CONFIG_Formulario_Usuario fu on f.idFormularios = fu.idFormularios ");
                sQuery.Append("where fu.idUsuario = {0} and f.xNameFormulario = '{1}'");

                DbCommand comand = UndTrabalho.dbPrincipal.GetSqlStringCommand
                            (
                            string.Format(sQuery.ToString(), idUser, xName)
                            );

                int i = (int)UndTrabalho.dbPrincipal.ExecuteScalar(comand);
                if (i == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
      
        public void BeginTransaction()
        {
            UndTrabalho.BeginTransaction();
        }
        public void CommitTransaction()
        {
            UndTrabalho.CommitTransaction();
        }
        public void RollBackTransaction()
        {
            UndTrabalho.RollBackTransaction();
        }




    }
}
