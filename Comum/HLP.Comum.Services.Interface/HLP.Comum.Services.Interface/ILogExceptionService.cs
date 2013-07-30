using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;
using HLP.Comum.Models;

namespace HLP.Comum.Services.Interface
{
    public interface ILogExceptionService
    {
        LogExceptionModel GetLogXML();
        void SalvarLog(LogExceptionModel objLog);
    }
}
