using HLP.Models.Entries;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLP.Services.Implementation.Entries.Gerais
{
    public class ArquivosService
    {
        List<ArquivosModel> lArquivosAtualizacao;
        ArquivosModel objArq = new ArquivosModel();
        public List<ArquivosModel> GetArquivos()
        {
            string sPathFiles = null;
            List<ArquivosModel> lArquivos = new List<ArquivosModel>();
            try
            {
                sPathFiles = (Registry.CurrentConfig.OpenSubKey(@"magnificus").GetValue("caminhoPadrao").ToString()) + @"\atualizacoes";
                DirectoryInfo dinfo = new DirectoryInfo(sPathFiles);
                ArquivosModel objArq = null;
                if (Directory.Exists(sPathFiles))
                {
                    foreach (FileInfo file in dinfo.GetFiles("*.zip"))
                    {
                        objArq = new ArquivosModel();
                        objArq.xNome = file.Name;
                        objArq.xCaminho = file.FullName;
                        objArq.dtAlteracao = file.LastWriteTime;
                        lArquivos.Add(objArq);
                    }
                }
                return lArquivos;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public ArquivosModel GetUltimoArquivo()
        {
            return GetArquivos().OrderByDescending(l => l.xNome).FirstOrDefault();
        }

        public void ExtrairArquivo(string zipFile, string xDiretorio)
        {
            if (Directory.Exists(xDiretorio))
                ApagarDiretorio(xDiret: xDiretorio);


            Directory.CreateDirectory(xDiretorio);
            ZipFile.ExtractToDirectory(zipFile, xDiretorio);
        }

        public void CopiarArquivos(string sDir)
        {
            lArquivosAtualizacao = new List<ArquivosModel>();
            ObterArquivosAtualizacao(lArquivosAtualizacao, sDir);
            string sCaminhoPadrao = (Registry.CurrentConfig.OpenSubKey(@"magnificus").GetValue("caminhoPadrao").ToString());
            string sPathFiles = sCaminhoPadrao + "\\magnificus";
            string caminhoArquivo = null;
            string caminhoDestino = null;
            if (!Directory.Exists(sPathFiles + @"\bkpAtualizacao"))
                Directory.CreateDirectory(sPathFiles + @"\bkpAtualizacao");
            try
            {
                foreach (ArquivosModel a in lArquivosAtualizacao)
                {
                    caminhoArquivo = sPathFiles + @"\" + a.xCaminho.Replace(sDir, "").Replace(a.xNome, "");

                    if (File.Exists(caminhoArquivo + a.xNome))
                    {
                        caminhoDestino = sCaminhoPadrao + @"\bkpAtualizacao\" + caminhoArquivo.Replace(
                            sPathFiles, "");
                        if (!Directory.Exists(caminhoDestino))
                            Directory.CreateDirectory(caminhoDestino);

                        File.Move(caminhoArquivo + a.xNome, caminhoDestino + a.xNome);
                    }

                    File.Copy(a.xCaminho, caminhoArquivo + a.xNome);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                ApagarDiretorio(Registry.CurrentConfig.OpenSubKey(@"magnificus").GetValue("caminhoPadrao").ToString()
                    + @"\atualizacoes\temp");
            }

        }

        public void ObterArquivosAtualizacao(List<ArquivosModel> lArquivosAtualizacao, string sDir)
        {
            foreach (string item in Directory.GetDirectories(sDir))
            {
                ObterArquivosAtualizacao(lArquivosAtualizacao, item);
            }
            DirectoryInfo di = new DirectoryInfo(sDir);
            foreach (FileInfo item in di.GetFiles())
            {
                objArq = new ArquivosModel();
                objArq.xNome = item.Name;
                objArq.xCaminho = item.FullName;
                lArquivosAtualizacao.Add(objArq);
            }
        }

        public void ApagarDiretorio(string xDiret)
        {
            foreach (string item in Directory.GetDirectories(xDiret))
            {
                ApagarDiretorio(item);
            }

            DirectoryInfo di = new DirectoryInfo(xDiret);
            foreach (FileInfo item in di.GetFiles())
            {
                File.Delete(item.FullName);

            }
            Directory.Delete(xDiret);

        }
    }
}
