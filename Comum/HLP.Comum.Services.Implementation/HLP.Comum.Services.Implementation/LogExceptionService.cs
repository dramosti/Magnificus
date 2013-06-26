using System;
using HLP.Comum.Services.Interface;
using HLP.Comum.Infrastructure;
using System.IO;
using HLP.Comum.Models.Static;

namespace HLP.Comum.Services.Implementation
{
    public class LogExceptionService :ILogExceptionService
    {

        private string sPathLog = Pastas.Path_Logs + "ExceptionLog.xml";

        public LogException GetLogXML()
        {
            LogException objLog = new LogException();

            if (File.Exists(sPathLog))
            {
                //verifica data
                FileInfo fLog = new FileInfo(sPathLog);
                if (fLog.CreationTime.ToString("dd/MM/yyyy") == DateTime.Today.ToString("dd/MM/yyyy"))
                    objLog = SerializeClassToXml.DeserializeClasse<LogException>(sPathLog);
                else
                    File.Delete(sPathLog);
            }
            return objLog;
        }

        public void SalvarLog(LogException objLog)
        {
            SerializeClassToXml.SerializeClasse<LogException>(objLog, sPathLog);
        }

    }
}
