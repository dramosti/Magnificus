using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace HLP.Comum.Models.Static
{
    public static class Pastas
    {
        private static string _Path_SettingsEmpresa;
        public static string Path_SettingsEmpresa
        {
            get { return Pastas._Path_SettingsEmpresa; }
            set
            {
                Pastas._Path_SettingsEmpresa = value;
                if (Pastas._Path_SettingsEmpresa == "")
                {
                    string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    Pastas._Path_SettingsEmpresa = Path.Combine(localAppData, "HLP");
                }

                if (!Directory.Exists(Pastas._Path_SettingsEmpresa))
                {
                    Directory.CreateDirectory(Pastas._Path_SettingsEmpresa);
                }

            }
        }

        public static string Path_SettingsUser
        {
            get
            {
                return Util.ValidaCaminho(Pastas.Path_SettingsEmpresa + "\\USER_" + UserData.idUser + "\\");
            }
        }

        public static string Path_Report_Especifico
        {
            get
            {
                return Util.ValidaCaminho(Pastas.Path_SettingsEmpresa + "\\RELATORIOS\\");
            }
        }
        public static string Path_Report
        {
            get
            {
                return Util.ValidaCaminho(Application.StartupPath + "\\RELATORIOS\\");
            }
        }

        public static string Path_Logs
        {
            get
            {
                return Util.ValidaCaminho(Application.StartupPath + "\\LOGS\\");
            }
        }

        public static string Path_Settings_From_Sys
        {
            get
            {
                return Util.ValidaCaminho(Pastas.Path_SettingsEmpresa + "\\SYS_FORM\\");
            }
        }
      
    }
}
