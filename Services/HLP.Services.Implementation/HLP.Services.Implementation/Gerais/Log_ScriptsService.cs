using HLP.Comum.Models.Static;
using HLP.Models.Entries.Gerais;
using HLP.Repository.Interfaces.Entries.Gerais;
using HLP.Services.Interfaces.Entries.Gerais;
using Ninject;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLP.Services.Implementation.Entries.Gerais
{
    public class Log_ScriptsService : ILog_ScriptsService
    {
        [Inject]
        public ILog_ScriptsRepository _Log_ScriptsRepository { get; set; }

        public void Save(List<Log_ScriptsModel> lLog_Scripts)
        {
            foreach (Log_ScriptsModel item in lLog_Scripts.Where(l => l.GetStatusRegistro() == 
                Comum.Infrastructure.BaseModelFilhos.statusRegistroFilho.Incluido))
            {
                _Log_ScriptsRepository.Save(item);
            }

            foreach (Log_ScriptsModel item in lLog_Scripts.Where(l => l.GetStatusRegistro() ==
                Comum.Infrastructure.BaseModelFilhos.statusRegistroFilho.Alterado))
            {
                _Log_ScriptsRepository.Update(item);
            }
        }

        public void Update(Log_ScriptsModel objLog_Scripts)
        {
            _Log_ScriptsRepository.Update(objLog_Scripts);
        }

        public Log_ScriptsModel GetLog_Scripts(int idLog)
        {
            return _Log_ScriptsRepository.GetLog_Scripts(idLog);
        }

        public List<Log_ScriptsModel> GetAllLog_Scripts()
        {
            return _Log_ScriptsRepository.GetAllLog_Scripts();
        }

        public bool ExecScript(string sScript)
        {
            return _Log_ScriptsRepository.ExecutaScritp(sScript);
        }

        public int GetLog_ScriptCount(string xName)
        {
            return _Log_ScriptsRepository.GetLog_ScriptCount(xName);
        }

        public void Backup(string xPath, string xNameBackup)
        {
            if (!Directory.Exists(xPath))
                Directory.CreateDirectory(xPath);

            _Log_ScriptsRepository.BackupDataBase(xPath: xPath, xNameBackup: xNameBackup);
        }

        public int RetornaPorcBkp()
        {
            return _Log_ScriptsRepository.RetornaPorcBkp();
        }

    }
}
