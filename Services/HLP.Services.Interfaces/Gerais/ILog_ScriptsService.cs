using HLP.Models.Entries.Gerais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLP.Services.Interfaces.Entries.Gerais
{
    public interface ILog_ScriptsService
    {
        void Save(List<Log_ScriptsModel> lLog_Scripts);
        Log_ScriptsModel GetLog_Scripts(int idLog);
        List<Log_ScriptsModel> GetAllLog_Scripts();
        void Update(Log_ScriptsModel objLog_Scripts);
        bool ExecScript(string sScript);
        int GetLog_ScriptCount(string xName);
        void Backup(string xPath, string xNameBackup);
        int RetornaPorcBkp();
    }
}
