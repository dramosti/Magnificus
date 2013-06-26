using HLP.Comum.Infrastructure;
using System.ServiceModel;

namespace HLP.Comum.WebServices
{
    [ServiceContract]
    public interface IExceptionLog
    {
        [OperationContract]
        void SendLogError(LogDados logDados);
    }
}
