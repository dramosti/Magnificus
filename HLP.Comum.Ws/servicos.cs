using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HLP.Comum.Ws.servicoHlp;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using Microsoft.Win32;
using HLP.Models.Entries.Gerais;
using HLP.Services.Interfaces.Entries.Gerais;
using Ninject;
using HLP.Dependencies;
using HLP.Comum.Infrastructure;
using System.Net;

namespace HLP.Comum.Ws
{
    public class servicos
    {
        [Inject]
        public ILog_ScriptsService log_scriptService { get; set; }

        ServicesClient objServicos = new ServicesClient();
        FileStream fs1 = null;
        long tamanhoDownload = 0;
        private bool statusDownload = false;
        const string enderecoWs = "http://hlpsistemas.no-ip.org:8081/Servicos/Services.svc";

        public servicos()
        {
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
        }

        public bool RespostaWS()
        {
            try
            {
                WebRequest wR = WebRequest.Create(enderecoWs);
                WebResponse wResponse = wR.GetResponse();
                wResponse.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }       

        }

        public List<VersoesModel> GetVersoes()
        {
            try
            {
                return objServicos.GetVersoesMagnificus().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro: " + ex.Message);
            }

        }

        public void downloadArquivo(string fName)
        {
            try
            {
                fs1 = null;
                Byte[] b1 = null;
                b1 = objServicos.DownloadFile(fName);
                string sCaminho = null;
                sCaminho = (Registry.CurrentConfig.OpenSubKey(@"magnificus").GetValue("caminhoPadrao").ToString());
                if (!Directory.Exists(sCaminho + @"\atualizacoes\"))
                    Directory.CreateDirectory(sCaminho + @"\atualizacoes\");

                DirectoryInfo di = new DirectoryInfo(sCaminho + @"\atualizacoes");
                foreach (FileInfo item in di.GetFiles())
                {
                    File.Delete(item.FullName);
                }

                fs1 = new FileStream(sCaminho + @"\atualizacoes\" + fName, FileMode.Create);
                tamanhoDownload = b1.Length;
                //Thread t1 = new Thread(GerenciaPb);
                //t1.Start(pb);               
                fs1.Write(b1, 0, b1.Length);
                fs1.Close();
                fs1 = null;
                BaixarScriptsVersaoExe(fName);
                statusDownload = true;
            }
            catch (Exception ex)
            {
                statusDownload = false;
            }
        }

        public void downloadScript(string sName)
        {
            try
            {
                fs1 = null;
                Byte[] b1 = null;
                b1 = objServicos.DownloadScript(sName);
                string sCaminho = null;
                sCaminho = (Registry.CurrentConfig.OpenSubKey(@"magnificus").GetValue("caminhoPadrao").ToString());
                if (!Directory.Exists(sCaminho + @"\atualizacoes\versoes"))
                    Directory.CreateDirectory(sCaminho + @"\atualizacoes\versoes");

                fs1 = new FileStream(sCaminho + @"\atualizacoes\versoes" + sName, FileMode.Create);
                tamanhoDownload = b1.Length;
                //Thread t1 = new Thread(GerenciaPb);
                //t1.Start(pb);               
                fs1.Write(b1, 0, b1.Length);
                fs1.Close();
                fs1 = null;
            }
            catch (Exception ex)
            {
            }
        }

        public string getScript(string sName)
        {
            try
            {
                fs1 = null;
                Byte[] b1 = null;
                b1 = objServicos.DownloadScript(sName);
                statusDownload = true;
                return System.Text.Encoding.UTF8.GetString(b1);

            }
            catch (Exception ex)
            {
                statusDownload = false;
                return "";
            }
        }

        public void GerenciaPb(object pb)
        {
            if (fs1.Length == tamanhoDownload)
                Thread.CurrentThread.Abort();

            ((ProgressBar)pb).Maximum = 100;
            ((ProgressBar)pb).Value = (int)(fs1.Length / tamanhoDownload);
        }

        public bool getStatus()
        {
            return statusDownload;
        }

        public string GetUltimaVersao()
        {
            try
            {
                return objServicos.GetUltimaVersao();
            }
            catch (Exception ex)
            {
                
                throw new Exception("Erro: "+ex.Message);
            }
            
        }

        public List<VersoesModel> GetUltimosScripts(string xVersao)
        {
            try
            {
                return objServicos.GetUltimosScripts(xVersao).ToList();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro: " + ex.Message);
            }            
        }

        private void BaixarScriptsVersaoExe(string xVersao)
        {
            try
            {
                List<Log_ScriptsModel> lScripts =
                objServicos.GetScriptVersaoExe(xVersao.Replace(".zip", "")).ToList().AsEnumerable().Select(
                i => new Log_ScriptsModel
                {
                    xVersao = i.xVersao,
                    script = getScript(i.xVersao)
                }).ToList();

                foreach (Log_ScriptsModel item in lScripts)
                {
                    if (log_scriptService.GetLog_ScriptCount(item.xVersao) == 0)
                    {
                        item.SetStatusRegistro(Infrastructure.BaseModelFilhos.statusRegistroFilho.Incluido);
                    }

                }
                log_scriptService.Save(lScripts);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro: " + ex.Message);
            }         
            
        }

        public bool ExisteAtualizacao()
        {
            try
            {
                string sCaminho = null;

                sCaminho = (Registry.CurrentConfig.OpenSubKey(@"magnificus").GetValue("caminhoPadrao").ToString());

                if (!Directory.Exists(sCaminho + @"\atualizacoes"))
                {
                    Directory.CreateDirectory(sCaminho + @"\atualizacoes");
                    return false;
                }

                DirectoryInfo di = new DirectoryInfo(sCaminho + @"\atualizacoes");
                if (di.GetFiles().Count() > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro: " + ex.Message);
            }           
        }

        public void BackupBaseSql(string xPath, string xNameBackup)
        {
            log_scriptService.Backup(xPath: xPath, xNameBackup: xNameBackup);
        }
    }
}
