using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Comum.Services.Interface
{
    public interface ILogExceptionService
    {
        LogException GetLogXML();
        void SalvarLog(LogException objLog);
    }
}
