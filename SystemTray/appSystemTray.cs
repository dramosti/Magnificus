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

namespace SystemTray
{
    public class SysTrayApp : Form
    {
        servicos objServicos = new servicos();
        List<EstruturaModel> lEstruturaModel = new List<EstruturaModel>();
        private System.ComponentModel.BackgroundWorker bwAtualizacao;
        EstruturaService objEstruturaService = new EstruturaService();
        object FormAberto = null;
        [STAThread]
        public static void Main()
        {
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
            trayIcon.Text = "MyTrayApp";
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
        }

        protected override void OnLoad(EventArgs e)
        {
            Visible = false; // Hide form window.
            ShowInTaskbar = false; // Remove from taskbar.

            base.OnLoad(e);
        }

        private void OnExit(object sender, EventArgs e)
        {
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
                formExecAbertos frmExecAbertos = new formExecAbertos();
                FormAberto = new object();
                FormAberto = frmExecAbertos;
                frmExecAbertos.Show();
                frmExecAbertos.Focus();
            }
        }

        private void VisualizarAtualizacoes(object sender, EventArgs e)
        {
            if (!VerifFormAberto(typeof(formAtualizacoes)))
            {
                formAtualizacoes frmAtualizacoes = new formAtualizacoes(this);
                FormAberto = new object();
                FormAberto = frmAtualizacoes;
                frmAtualizacoes.Show();
                frmAtualizacoes.Focus();
            }
        }

        private void InstalarAtualizacao(object sender, EventArgs e)
        {
            if (objEstruturaService.GetListEstrutura().Count > 0)
            {
                MessageBox.Show("O sistema está sendo utilizado em um dos terminais, feche o magnificus nos terminais e tente novamente.", "Falha", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                VisualizarExecAbertos(sender, e);
            }
            else
            {
                trayMenu.MenuItems[3].Visible = false;
                Process p = new Process();
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = Registry.CurrentConfig.OpenSubKey(@"magnificus").GetValue("caminhoPadrao").ToString() +
                    @"\exeAtualizacao\Atualizador.exe";
                p.StartInfo = psi;
                p.Start();
            }
        }

        public void IniciaAtualizacao(string vVersao)
        {
            if (!bwAtualizacao.IsBusy)
            {
                IntPtr ptIcon = SystemTray.Properties.Resources.magnificus_baixar.GetHicon();
                trayIcon.Icon = Icon.FromHandle(ptIcon);
                ((Form)FormAberto).Close();
                ((Form)FormAberto).Dispose();
                FormAberto = null;
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
            try
            {
                if (FormAberto != null)
                {
                    if (FormAberto.GetType() == tTipo)
                    {
                        ((Form)FormAberto).Focus();
                        return true;
                    }
                    else
                    {
                        ((Form)FormAberto).Close();
                        ((Form)FormAberto).Dispose();
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro: " + ex.Message);
            }
        }
    }
}
