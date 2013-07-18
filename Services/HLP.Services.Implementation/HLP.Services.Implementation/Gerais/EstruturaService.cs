using HLP.Models.Entries.Gerais;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HLP.Services.Implementation.Entries.Gerais
{
    public class EstruturaService
    {
        private static StringBuilder sb = null;

        public List<EstruturaModel> GetListEstrutura()
        {
            List<EstruturaModel> lEstruturaModel = new List<EstruturaModel>();
            sb = new StringBuilder("");
            EstruturaModel objEstrModel = null;
            Process processo = new Process();
            ProcessStartInfo pi = new ProcessStartInfo("C:\\Windows\\System32\\cmd.exe");
            processo.StartInfo = pi;
            pi.RedirectStandardInput = true;
            pi.RedirectStandardOutput = true;
            pi.UseShellExecute = false;
            processo.OutputDataReceived += new DataReceivedEventHandler(SortOutputHandler);
            processo.Start();
            processo.StandardInput.WriteLine("cd c:\\windows\\system32");
            processo.StandardInput.WriteLine("openfiles /query /FO CSV /nh /v");
            Thread.Sleep(500);
            processo.StandardInput.WriteLine("exit");
            processo.BeginOutputReadLine();
            processo.WaitForExit();

            string retorno = sb.ToString();
            string[] estrutura = null;

            List<string> linhas = retorno.Split('\n').ToList();

            int indexHeader = linhas.FindIndex(l => l.Contains("----------"));

            linhas.RemoveRange(0, indexHeader + 1);

            foreach (String l in linhas)
            {
                estrutura = l.Split(',');

                if (estrutura.Count() > 1)
                {
                    objEstrModel = new EstruturaModel();
                    objEstrModel.sNomeHost = estrutura[0].Replace("\"", "");
                    objEstrModel.sIdentificacao = estrutura[1].Replace("\"", "");
                    objEstrModel.sAcessado = estrutura[2].Replace("\"", "");
                    objEstrModel.sTipo = estrutura[3].Replace("\"", "");
                    objEstrModel.sLocks = estrutura[4].Replace("\"", "");
                    objEstrModel.sModoAcesso = estrutura[5].Replace("\"", "");
                    objEstrModel.sCaminhoArq = estrutura[6].Replace("\"", "");
                    lEstruturaModel.Add(objEstrModel);
                }
            }

            return lEstruturaModel.Where(l => l.sCaminhoArq.EndsWith("Magnificus.exe\r", true, null)).ToList();
        }

        private static void SortOutputHandler(object sendingProcess,
            DataReceivedEventArgs outLine)
        {
            if (!String.IsNullOrEmpty(outLine.Data))
            {
                sb.Append(Environment.NewLine + outLine.Data);
            }
        }
    }
}
