using System;
using HLP.Comum.Services.Interface;
using HLP.Comum.Infrastructure;
using System.IO;

using HLP.Comum.Models;
using HLP.Comum.Infrastructure.Static;

namespace HLP.Comum.Services.Implementation
{
    public class LogExceptionService :ILogExceptionService
    {

        private string sPathLog = Pastas.Path_Logs + "ExceptionLog.xml";

        public LogExceptionModel GetLogXML()
        {
            LogExceptionModel objLog = new LogExceptionModel();

            if (File.Exists(sPathLog))
            {
                //verifica data
                FileInfo fLog = new FileInfo(sPathLog);
                if (fLog.CreationTime.ToString("dd/MM/yyyy") == DateTime.Today.ToString("dd/MM/yyyy"))
                    objLog = SerializeClassToXml.DeserializeClasse<LogExceptionModel>(sPathLog);
                else
                    File.Delete(sPathLog);
            }
            return objLog;
        }

        public void SalvarLog(LogExceptionModel objLog)
        {
            SerializeClassToXml.SerializeClasse<LogExceptionModel>(objLog, sPathLog);
        }

    }
}
