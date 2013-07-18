using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HLP.Comum.Modules;
using HLP.Comum.UI;
using ComponentFactory.Krypton.Toolkit;
using HLP.Comum.UI.Exception;
using HLP.Comum.Models.Static;
using System.Runtime.InteropServices;
using HLP.UI.Utility;
using System.ComponentModel;
using HLP.Comum.Infrastructure;
using Microsoft.Win32;
using System.IO;
using HLP.Models.Entries.Gerais;
using System.Net;
using HLP.Services.Implementation.Entries.Gerais;

namespace Magnificus
{
    static class Program
    {        
        [DllImport("user32.dll")]
        private static extern int ShowWindow(IntPtr hWnd, int nCmdShow);
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        public const int SW_RESTORE = 9;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FormSplash splash = null;
            try
            {
                bool bExeAberto = false;
                System.Diagnostics.Process[] processos = System.Diagnostics.Process.GetProcessesByName(Application.ProductName);
                string sPathExeProduct = Application.StartupPath + "\\" + Application.ProductName + ".exe";
                if (processos.Count() > 1)
                {
                    foreach (System.Diagnostics.Process p in processos)
                    {
                        if (p.MainModule.FileName == sPathExeProduct)
                        {
                            ShowWindow(p.MainWindowHandle, SW_RESTORE);
                            SetForegroundWindow(p.MainWindowHandle);
                            bExeAberto = true;
                            break;
                        }
                    }
                }
                if (!bExeAberto)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    FormConfigBase f = new FormConfigBase();
                    if (!f.TestCurrentConnection())
                    {
                        f.ShowDialog();
                    }

                   
                    if (f.ConnectionActivated)
                    {
                        FormScripts frmScripts = new FormScripts();
                        formLoginHlp login = new formLoginHlp();
                        login.ShowDialog();
                        if (UserData.bLogado)
                        {
                            ControleAcessoService.InsereControleAcesso(true);
                            splash = new FormSplash();
                            GerenciadorModulo.Instancia.InicializaSistema<FormModuloMagnificus>(splash.ExibeInformacao, splash.ValoresProgressBar);
                            splash.Close();
                            ServerData.Refresh();
                            if(frmScripts.ScriptNaoExec())
                                frmScripts.ShowDialog();

                            if(!RegistroWindows.VerificaRegistro(Registry.CurrentConfig, "magnificus"))
                            {
                                try 
	                            {
                                    RegistroWindows.CriaRegistro(Registry.CurrentConfig, "magnificus");
                                    RegistroWindows.SetaValueRegistro(Registry.CurrentConfig, "magnificus", "caminhoPadrao",
                                            Application.StartupPath.Replace(Application.StartupPath.Substring(Application.StartupPath.LastIndexOf('\\')),
                                            ""));
	                            }
	                            catch (Exception)
	                            {
		
		                            throw;
	                            }
                            }
                            Application.Run(GerenciadorModulo.Instancia.FormPrincipal as Form);
                        }
                    }
                }
                else
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
        }
    }
}
