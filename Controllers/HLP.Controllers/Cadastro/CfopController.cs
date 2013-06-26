using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure.Controllers;
using Ninject.Modules;
using HLP.Controllers.IoC.Cadastro;
using Ninject;
using HLP.Services.Interfaces.Cadastros;
using HLP.Business;

namespace HLP.Controllers.Cadastro
{
    public class CfopController : BaseController
    {
        [Inject]
        public ICfopService CfopService { get; set;}

        private boCfop _objboCfop;

        public CfopController(boCfop objboCfop) 
        {
            _objboCfop = objboCfop;
            this.AsynchronousSave += new AsynchronousSaveHandler(CfopController_AsynchronousSave);
            this.AsynchronusPesquisa += new AsynchronousPesquisaHandler(CfopController_AsynchronusPesquisa);
        }

        void CfopController_AsynchronusPesquisa()
        {
            this.Pesquisa();
        }

        private void Pesquisa()
        {
            CfopService.GetAllCfop();
        }

        void CfopController_AsynchronousSave()
        {
            this.Save();
        }

        private void Save()
        {
            CfopService.SaveChanges(_objboCfop);
        }

      



        #region Métodos protegidos
        protected override NinjectModule GetInstanceDIControllersModule()
        {
            DICfop module = new DICfop();
            return module;

        }
        #endregion
    }
}
