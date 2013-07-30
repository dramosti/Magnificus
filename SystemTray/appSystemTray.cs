using HLP.Comum.Ws;
using HLP.Models.Entries.Gerais;
using HLP.Services.Implementation.Entries.Gerais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using Microsoft.Win32;

using System.IO;
using System.Net;
using System.Threading;
using HLP.Comum.Infrastructure.Static;

namespace SystemTray
{
    public class SysTrayApp : Form
    {
        servicos objServicos = new servicos();
        List<EstruturaModel> lEstruturaModel = new List<EstruturaModel>();
        private System.ComponentModel.BackgroundWorker bwAtualizacao;
        private static string xIpInstalacao = null;
        private static string xUsuario = null;
        private static bool bAguardandoAtual = false;
        EstruturaService objEstruturaService = new EstruturaService();
        [STAThread]
        public static void Main(string[] args)
        {
            if (args.Count() > 0)
                xUsuario = args[0];

            Application.Run(new SystemTray.SysTrayApp());
        }

        private NotifyIcon trayIcon;
        private ContextMenu trayMenu;

        public SysTrayApp()
        {
            // Create a simple tray menu with only one item.
            trayMenu = new ContextMenu();
            trayMenu.MenuItems.Add("Exit", OnExit); //index 0
            trayMenu.MenuItems.Add("Visualizar todos os executáveis abertos.", VisualizarExecAbertos); //index 1
            trayMenu.MenuItems.Add("Visualizar atualizações.", VisualizarAtualizacoes); //index 2
            trayMenu.MenuItems.Add("Atualização pronta para ser instalada. Clique aqui para iniciar a instalação.", InstalarAtualizacao); //index 3

            // Create a tray icon. In this example we use a
            // standard system icon for simplicity, but you
            // can of course use your own custom icon too.
            trayIcon = new NotifyIcon();
            trayIcon.Text = "Aplicação de Atualização Magnificus";
            IntPtr ptIcon = SystemTray.Properties.Resources.iconehlp.GetHicon();
            trayIcon.Icon = Icon.FromHandle(ptIcon);

            // Add menu to tray icon and show it.
            trayIcon.ContextMenu = trayMenu;
            trayIcon.Visible = true;
            InitializeComponent();
            if (objServicos.ExisteAtualizacao())
            {
                trayMenu.MenuItems[3].Visible = true;
            }
            else
            {
                trayMenu.MenuItems[3].Visible = false;
            }
            FileInfo fi = new FileInfo(Pastas.CaminhoPadraoRegWindows +
                        @"\magnificus\Magnificus.exe");

            xIpInstalacao = Directory.GetDirectoryRoot(fi.FullName).Split('\\')[2].ToString();
            bwAtualizacao.WorkerSupportsCancellation = true;
        }

        protected override void OnLoad(EventArgs e)
        {
            Visible = false; // Hide form window.
            ShowInTaskbar = false; // Remove from taskbar.

            base.OnLoad(e);
        }

        private void OnExit(object sender, EventArgs e)
        {
            if (bwAtualizacao.IsBusy)
            {
                if (MessageBox.Show(this, "Download de atualização do sistema em andamento, caso feche o aplicativo download será interrompido. "
                    + Environment.NewLine + "Deseja continuar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        bwAtualizacao.CancelAsync();
                        foreach (string item in Directory.GetFiles(Pastas.CaminhoPadraoRegWindows + "\\atualizacoes"))
                        {
                            File.Delete(item);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, "Falha ao interromper donwload. "
                    + Environment.NewLine + "Motivo: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            Application.Exit();
        }

        protected override void Dispose(bool isDisposing)
        {
            if (isDisposing)
            {
                // Release the icon resource.
                trayIcon.Dispose();
            }

            base.Dispose(isDisposing);
        }

        private void VisualizarExecAbertos(object sender, EventArgs e)
        {
            if (!VerifFormAberto(typeof(formExecAbertos)))
            {
                SystemTray.formExecAbertos.TipoAcesso tpAcesso =
                    xIpInstalacao == Dns.GetHostAddresses(Environment.MachineName)[1].ToString()
                    ? SystemTray.formExecAbertos.TipoAcesso.servidor : formExecAbertos.TipoAcesso.local;
                formExecAbertos frmExecAbertos = new formExecAbertos(tTpAcesso: tpAcesso);
                frmExecAbertos.Show();
                frmExecAbertos.Focus();
            }
        }

        private void VisualizarAtualizacoes(object sender, EventArgs e)
        {
            if (!VerifFormAberto(typeof(formAtualizacoes)))
            {
                formAtualizacoes frmAtualizacoes = new formAtualizacoes(this);
                frmAtualizacoes.Show();
                frmAtualizacoes.Focus();
            }
        }

        private void InstalarAtualizacao(object sender, EventArgs e)
        {
            if (!bAguardandoAtual)
            {
                bAguardandoAtual = true;
                if (MessageBox.Show("O sistema será fechado para atualização. Deseja continuar?", "?", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    Process[] processos = Process.GetProcessesByName("Magnificus");

                    foreach (Process iProc in processos)
                    {
                        try
                        {
                            ControleAcessoService.InsereControleAcesso(false, xNomeFunc: xUsuario, xNomeMaquina: Environment.MachineName);
                            iProc.Kill();
                            Thread.Sleep(500);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Não foi possível fechar a aplicação. " +
                                Environment.NewLine + "Erro: " + ex.Message);
                        }
                    }
                    bool bIniciaAtualizacao = true;

                    try
                    {
                        if (!Directory.Exists(Pastas.CaminhoPadraoRegWindows + @"\magnificus\temp"))
                            Directory.CreateDirectory(Pastas.CaminhoPadraoRegWindows + @"\magnificus\temp");

                        File.Move(Pastas.CaminhoPadraoRegWindows + @"\magnificus\Magnificus.exe",
                            Pastas.CaminhoPadraoRegWindows + @"\magnificus\temp\Magnificus.exe");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não é possível iniciar atualização do sistema. " +
                            Environment.NewLine + "Existem terminais utilizando o sistema.");
                        VisualizarExecAbertos(this, null);
                        bIniciaAtualizacao = false;
                    }
                    finally
                    {
                        if (Directory.Exists(Pastas.CaminhoPadraoRegWindows + @"\magnificus\temp"))
                        {
                            foreach (string file in Directory.GetFiles(Pastas.CaminhoPadraoRegWindows + @"\magnificus\temp"))
                            {
                                if (file.Contains("Magnificus.exe"))
                                    File.Move(file, Pastas.CaminhoPadraoRegWindows + @"\magnificus\Magnificus.exe");
                            }
                            Directory.Delete(Pastas.CaminhoPadraoRegWindows + @"\magnificus\temp");
                        }
                    }

                    if (bIniciaAtualizacao)
                    {
                        foreach (Form f in Application.OpenForms)
                        {
                            if (f.Name != "SysTrayApp")
                                FecharForms(f);
                        }
                        trayMenu.MenuItems[3].Visible = false;
                        Process p = new Process();
                        ProcessStartInfo psi = new ProcessStartInfo();
                        psi.FileName = Pastas.CaminhoPadraoRegWindows +
                            @"\magnificus\exeAtualizacao\Atualizador.exe";
                        p.StartInfo = psi;
                        p.Start();
                    }
                }
                bAguardandoAtual = false;
            }
        }

        public void IniciaAtualizacao(string vVersao)
        {
            if (!bwAtualizacao.IsBusy)
            {
                IntPtr ptIcon = SystemTray.Properties.Resources.magnificus_baixar.GetHicon();
                trayIcon.Icon = Icon.FromHandle(ptIcon);
                bwAtualizacao.RunWorkerAsync(vVersao);
            }
            else
            {
                MessageBox.Show("Já está sendo feito download de uma atualização do sistema", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void InitializeComponent()
        {
            this.bwAtualizacao = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // bwAtualizacao
            // 
            this.bwAtualizacao.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwAtualizacao_DoWork);
            // 
            // SysTrayApp
            // 
            this.ClientSize = new System.Drawing.Size(754, 361);
            this.ControlBox = false;
            this.Name = "SysTrayApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
        }

        private void bwAtualizacao_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            IntPtr ptIcon = SystemTray.Properties.Resources.iconehlp.GetHicon();

            try
            {
                if (objServicos.RespostaWS())
                {
                    objServicos.downloadArquivo(e.Argument.ToString());
                    trayMenu.MenuItems[3].Visible = true;
                }
                else
                {
                    MessageBox.Show("Não foi possível conectar ao WebService de atualização, tente novamente em instantes.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro inesperado: " + ex.Message);
            }
            trayIcon.Icon = Icon.FromHandle(ptIcon);

            object o = this;
        }

        private bool VerifFormAberto(Type tTipo)
        {
            #region Old
            //try
            //{
            //    List<Form> forms = new List<Form>();

            //    foreach (Form f in Application.OpenForms)
            //    {
            //        forms.Add(f);
            //    }

            //    if (FormAberto != null)
            //    {
            //        if (FormAberto.GetType() == tTipo)
            //        {
            //            ((Form)FormAberto).Focus();
            //            return true;
            //        }
            //        else
            //        {
            //            ((Form)FormAberto).Close();
            //            ((Form)FormAberto).Dispose();
            //        }
            //    }
            //    return false;
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception("Erro: " + ex.Message);
            //}
            #endregion

            try
            {
                List<Form> forms = new List<Form>();

                foreach (Form f in Application.OpenForms)
                {
                    if (f.Name != "SysTrayApp")
                        forms.Add(f);
                }

                foreach (Form f in forms)
                {
                    if (f.GetType() == tTipo)
                    {
                        f.Focus();
                        return true;
                    }
                    else
                    {
                        FecharForms(f);
                    }
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void FecharForms(params Form[] forms)
        {
            foreach (Form f in forms)
            {
                f.Close();
            }
        }
    }
}
