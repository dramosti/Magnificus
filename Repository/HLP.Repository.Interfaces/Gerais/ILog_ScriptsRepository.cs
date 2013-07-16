using HLP.Models.Entries.Gerais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLP.Repository.Interfaces.Entries.Gerais
{
    public interface ILog_ScriptsRepository
    {
        void Save(Log_ScriptsModel objLog_Scripts);
        void Update(Log_ScriptsModel objLog_Scripts);
        Log_ScriptsModel GetLog_Scripts(int idLog);
        List<Log_ScriptsModel> GetAllLog_Scripts();
        int GetLog_ScriptCount(string xNome);
        bool ExecutaScritp(string sScript);
        void BackupDataBase(string xPath, string xNameBackup);
        int RetornaPorcBkp();
    }
}
