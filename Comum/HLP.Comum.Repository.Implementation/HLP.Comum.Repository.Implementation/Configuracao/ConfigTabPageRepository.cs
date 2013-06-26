using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Repository.Interfaces.Configuracao;
using HLP.Comum.Infrastructure;
using Ninject;
using System.Data;
using HLP.Comum.Models.Static;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace HLP.Comum.Repository.Implementation.Configuracao
{
    public class ConfigTabPageRepository : IConfigTabPageRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }
        [Inject]
        public IConfigComponenteRepository iConfigComponenteRepository { get; set; }

        private DataAccessor<ConfigTabPageModel> lTabPageAcessor;

        public void Save(ConfigTabPageModel tabPage)
        {
            if (tabPage.idTabPage == null)
            {
                tabPage.idTabPage = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                        UndTrabalho.dbTransaction,
                       "[dbo].[Proc_save_CONFIG_TabPage]",
                            ParameterBase<ConfigTabPageModel>.SetParameterValue(tabPage));
            }

            tabPage.objConfigTabPageUsu.idTabPageUsuario = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                    UndTrabalho.dbTransaction,
                   "[dbo].[Proc_save_CONFIG_TabPage_Usuario]",
                  ParameterBase<ConfigTabPageUsuModel>.SetParameterValue(tabPage.objConfigTabPageUsu));

            foreach (ConfigComponenteModel comp in tabPage.lConfigComponente)
            {
                try
                {
                    iConfigComponenteRepository.Save(comp);

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            foreach (ConfigTabPageModel tab in tabPage.lConfigTabPageModel)
            {
                try
                {
                    tab.idTabPagePai = tabPage.idTabPage;
                    Save(tab);

                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public ConfigTabPageModel GetTabPageByForm(int idFormulario, int idUsuario)
        {
            ConfigTabPageModel objTabPageRet = null;

            DataAccessor<ConfigTabPageModel> TabPageAcessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_CONFIG_TabPage_First",
                new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idFormulario"),
                MapBuilder<ConfigTabPageModel>.MapAllProperties().Build());
            objTabPageRet = TabPageAcessor.Execute(idFormulario).FirstOrDefault();
            return objTabPageRet;
        }

        public List<ConfigTabPageModel> GetListTabPage(ConfigTabPageModel objTabPage, int idUsuario)
        {
            if (lTabPageAcessor == null)
            {
                lTabPageAcessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_CONFIG_TabPages",
                    new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idFormulario").AddParameter<int>("idTabPagePai"),
                    MapBuilder<ConfigTabPageModel>.MapAllProperties().Build());
            }

            return lTabPageAcessor.Execute(objTabPage.idFormularios, objTabPage.idTabPage).ToList();


        }

        public ConfigTabPageUsuModel GetConfigTabPageUsu(int idTabPage, int idUsuario)
        {
            try
            {
                DataAccessor<ConfigTabPageUsuModel> regAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_CONFIG_TabPage_Usuario  ",
                                     new Parameters(UndTrabalho.dbPrincipal)
                                       .AddParameter<int>("idTabPage").AddParameter<int>("idUsuario"),
                                     MapBuilder<ConfigTabPageUsuModel>.MapAllProperties().Build());

                return regAccessor.Execute(idTabPage, idUsuario).FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
