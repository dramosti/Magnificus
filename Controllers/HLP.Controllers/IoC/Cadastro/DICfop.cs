using HLP.Repository.Implementation;
using HLP.Repository.Implementation.Cadastros;
using HLP.Repository.Implementation.SQL;
using HLP.Repository.Implementation.SQL.Cadastros.Cfop;
using HLP.Repository.Interfaces.Cadastros;
using HLP.Repository.Interfaces.SQL;
using HLP.Repository.Interfaces.SQL.Cadastros.Cfop;
using HLP.Services.Implementation.Cadastros;
using HLP.Services.Interfaces.Cadastros;

namespace HLP.Controllers.IoC.Cadastro
{
    public class DICfop : DIContollersModuleBase<UnitOfWork>
    {
        protected override void ResolveServices()
        {
            Bind<ICfopService>().To<CfopService>();

        }

        protected override void ResolveRepositories()
        {
            Bind<ICfopRepository>().To<CfopRepository>();
            Bind<ISqlExpressionCfop>().To<SqlExpressionCfop>();
            Bind<ISqlExpressionsRepository>().To<SqlExpressionsRepository>();
        }
    }
}
