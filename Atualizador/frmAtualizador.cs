using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Microsoft.Win32;
using System.IO;
using System.Diagnostics;
using HLP.Services.Implementation.Entries.Gerais;
using HLP.Models.Entries;
using HLP.Comum.Ws;

namespace Atualizador
{
    public partial class frmAtualizador : KryptonForm
    {
        servicos objServicos = new servicos();
        ArquivosService objServico = new ArquivosService();
        ArquivosModel objArquivo = null;
        string sCaminhoExtracao = null;
        private bool validaAtualizacao = true;
        public frmAtualizador()
        {
            InitializeComponent();
            //FileInfo fi = new FileInfo(@"G:\CSharp\Desenvolvimento\Projetos\Magnificus\teste_atualizacao\magnificus\Magnificus.exe");            
            objArquivo = objServico.GetUltimoArquivo();
            this.Text = "Atualizando versão " + objArquivo.xNome;
            sCaminhoExtracao = (Registry.CurrentConfig.OpenSubKey(@"magnificus").GetValue("caminhoPadrao").ToString()) + @"\atualizacoes\temp";
            progressBar1.Maximum = 4;
            bwAtualizacao.RunWorkerAsync();
        }

        private void bwAtualizacao_DoWork(object sender, DoWorkEventArgs e)
        {            
            try
            {
                label1.Invoke((MethodInvoker)delegate
                {
                    label1.Text = "Fazendo backup da base de dados";                    
                });
                objServicos.BackupBaseSql(xPath: Registry.CurrentConfig.OpenSubKey("magnificus").GetValue("caminhoPadrao").ToString()
                + @"\backupsbases\bkpExe",
                xNameBackup: Application.ProductVersion.ToString() + "_" +
                DateTime.Now.Day + "_" +
                DateTime.Now.Month + "_" +
                DateTime.Now.Year + "_" +
                DateTime.Now.Hour + "_" +
                DateTime.Now.Minute + "_" +
                DateTime.Now.Second + ".bak");
                progressBar1.Invoke((MethodInvoker)delegate
                {
                    progressBar1.Value++;
                });
            }
            catch (Exception)
            {
                validaAtualizacao = false;
                return;
            }
            
            
            try
            {
                if (Directory.Exists(Registry.CurrentConfig.OpenSubKey(@"magnificus").GetValue("caminhoPadrao").ToString()
                + @"\bkpAtualizacao"))
                {
                    label1.Invoke((MethodInvoker)delegate
                    {
                        label1.Text = "Removendo backups anteriores";
                    });
                    objServico.ApagarDiretorio(Registry.CurrentConfig.OpenSubKey(@"magnificus").GetValue("caminhoPadrao").ToString()
                    + @"\bkpAtualizacao");
                }                
                progressBar1.Invoke((MethodInvoker)delegate
                {
                    progressBar1.Value++;
                });
            }
            catch (Exception)
            {
                validaAtualizacao = false;
                return;
            }
            
            try
            {
                label1.Invoke((MethodInvoker)delegate
                {
                    label1.Text = "Extraindo arquivo " + objArquivo.xCaminho;

                });
                objServico.ExtrairArquivo(objArquivo.xCaminho, sCaminhoExtracao);
                progressBar1.Invoke((MethodInvoker)delegate
                {
                    progressBar1.Value++;
                });                
            }
            catch (Exception)
            {
                validaAtualizacao = false;
                return;
            }           

            try
            {
                label1.Invoke((MethodInvoker)delegate
                {
                    label1.Text = "Copiando arquivos para a pasta do sistema...";

                });
                objServico.CopiarArquivos(sCaminhoExtracao + @"\" + objArquivo.xNome.Replace(".zip", "") + @"\");
                progressBar1.Invoke((MethodInvoker)delegate
                {
                    progressBar1.Value++;
                });                
            }
            catch (Exception ex)
            {
                validaAtualizacao = false;
                return;
            }


            DirectoryInfo di = new DirectoryInfo(Registry.CurrentConfig.OpenSubKey(@"magnificus").GetValue("caminhoPadrao").ToString()
                + @"\atualizacoes");

            foreach (FileInfo item in di.GetFiles())
            {
                try
                {
                    File.Delete(item.FullName);
                }
                catch (Exception)
                {
                    validaAtualizacao = false;
                    return;
                }
            }

            label1.Invoke((MethodInvoker)delegate
            {
                label1.Text = "Atualização finalizada";
            });
        }

        private void bwAtualizacao_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (validaAtualizacao)
            {
                List<Process> lProcessos = Process.GetProcessesByName("Magnificus").ToList();
                foreach (Process item in lProcessos)
                {
                    item.Kill();
                }
                Process p = new Process();
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = Registry.CurrentConfig.OpenSubKey(@"magnificus").GetValue("caminhoPadrao").ToString() + @"\magnificus\Magnificus.exe";
                //-q[n|b|r|f]   Sets user interface (UI) level:
                //n = no UI
                //b = basic UI (progress only, no prompts)
                //r = reduced UI (dialog at the end of installation)
                //f = full UI
                p.StartInfo = psi;
                p.Start();

                Application.Exit();
            }
            else
            {
                progressBar1.Value = 0;
                label1.Text = "Falha ao atualizar o sistema.";
            }
        }
    }
}
