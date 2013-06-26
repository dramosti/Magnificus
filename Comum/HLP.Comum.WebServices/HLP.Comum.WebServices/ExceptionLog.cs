using Ninject;
using HLP.Comum.Infrastructure;
using HLP.Dependencies;
using System.Configuration;
using HLP.Comum.Services.Interface;

namespace HLP.Comum.WebServices
{
    public class ExceptionLog : IExceptionLog
    {
        [Inject]
        public ILogExceptionService LogService { get; set; }

        private string sConexao = "Data Source=HLPSRV;Initial Catalog=Portal_HLP;User Id=sa;Password=H029060tSql;";

        public ExceptionLog()
        {
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
        }

        public void SendLogError(LogDados logDados)
        {
            LogService.Save(logDados, sConexao);
        }
    }
}
