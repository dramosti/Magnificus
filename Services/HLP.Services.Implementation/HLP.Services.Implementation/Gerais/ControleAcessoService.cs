using HLP.Comum.Infrastructure;
using HLP.Comum.Models.Static;
using HLP.Models.Entries.Gerais;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HLP.Services.Implementation.Entries.Gerais
{
    public class ControleAcessoService
    {
        private static EstruturaModelXml objEstruturaModelXml = new EstruturaModelXml();

        public static void InsereControleAcesso(bool Login)
        {
            string dir = Registry.CurrentConfig.OpenSubKey("magnificus").GetValue("caminhoPadrao").ToString() + @"\arquivos";
            DirectoryInfo di = new DirectoryInfo(dir);

            if (!di.Exists)
                Directory.CreateDirectory(dir);

            string xFile = dir + @"\acesso.xml";
            FileInfo fi = new FileInfo(xFile);

            EstruturaModelXmlPai objEstrutModelXmlPai = null;
            if (!fi.Exists)
                File.Create(xFile).Close();
            
            
            try
            {
                objEstrutModelXmlPai = SerializeClassToXml.DeserializeClasse<EstruturaModelXmlPai>(xFile);
            }
            catch (System.InvalidOperationException)
            {
                objEstrutModelXmlPai = new EstruturaModelXmlPai();
                objEstrutModelXmlPai.lEstruturaModelXml = new List<EstruturaModelXml>();
            }
            catch(Exception ex)
            {
                throw new Exception("Erro: " + ex.Message);
            }

            if (Login)
            {
                objEstruturaModelXml.dDataAcesso = DateTime.Now;
                objEstruturaModelXml.idFuncionario = UserData.idUser.ToString();
                objEstruturaModelXml.xNomeFuncionario = UserData.xNome;
                objEstruturaModelXml.xNomeMaquina = Environment.MachineName;
                objEstruturaModelXml.xIpMaquina = Dns.GetHostAddresses(objEstruturaModelXml.xNomeMaquina)[1].ToString();
                objEstruturaModelXml.xUsuarioWindows = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            }
            RemoveObjetoEstruturaModelXml(objEstrutModelXmlPai: objEstrutModelXmlPai);

            if (Login)
            {
                objEstrutModelXmlPai.lEstruturaModelXml.Add(objEstruturaModelXml);
            }
            SerializeClassToXml.SerializeClasse<EstruturaModelXmlPai>(objEstrutModelXmlPai, xFile);
        }

        private static void RemoveObjetoEstruturaModelXml(EstruturaModelXmlPai objEstrutModelXmlPai)
        {
            if (objEstrutModelXmlPai.lEstruturaModelXml.Where(b => b.xNomeMaquina == objEstruturaModelXml.xNomeMaquina &&
                b.xNomeFuncionario == objEstruturaModelXml.xNomeFuncionario).Count() > 0)
            {
                objEstrutModelXmlPai.lEstruturaModelXml.Remove(objEstrutModelXmlPai.lEstruturaModelXml.Where(
                    b => b.xNomeMaquina == objEstruturaModelXml.xNomeMaquina &&
                b.xNomeFuncionario == objEstruturaModelXml.xNomeFuncionario).FirstOrDefault());
            }
        }
    }
}
