using HLP.Comum.Infrastructure;
using HLP.Models.Entries.Gerais;
using HLP.Services.Implementation.Entries.Gerais;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemTray
{
    public partial class formExecAbertos : Form
    {
        //System.Threading.Timer timer;
        EstruturaService objEstrutService = new EstruturaService();
        EstruturaModelXmlPai objEstruturaModelXmlPai = new EstruturaModelXmlPai();
        EstruturaModelXml objEstruturaModelXml = null;

        public formExecAbertos()
        {
            InitializeComponent();
        }

        private void CarregaListaAcessosXml()
        {
            try
            {
                objEstruturaModelXmlPai = SerializeClassToXml.DeserializeClasse<EstruturaModelXmlPai>(
                Registry.CurrentConfig.OpenSubKey("magnificus").GetValue("caminhoPadrao").ToString() + @"\arquivos\acesso.xml");
            }
            catch (System.InvalidOperationException)
            {
                objEstruturaModelXmlPai = new EstruturaModelXmlPai();
                objEstruturaModelXmlPai.lEstruturaModelXml = new List<EstruturaModelXml>();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro: " + ex.Message);
            }

        }

        private void CarregaExeAbertos()
        {
            bsExec = new BindingSource();
            bsExec.DataSource = objEstrutService.GetListEstrutura();
            EstruturaModelXmlPai objEstrutModelXmlPaiSer = new EstruturaModelXmlPai();
            objEstrutModelXmlPaiSer.lEstruturaModelXml = new List<EstruturaModelXml>();
            try
            {
                kryptonDataGridView1.DataSource = bsExec;
                kryptonDataGridView1.Columns["sNomeHost"].HeaderText = "Host";
                kryptonDataGridView1.Columns["sIdentificacao"].Visible = false;
                kryptonDataGridView1.Columns["sAcessado"].HeaderText = "Acessado por";
                kryptonDataGridView1.Columns["sTipo"].HeaderText = "Tipo";
                kryptonDataGridView1.Columns["sLocks"].Visible = false;
                kryptonDataGridView1.Columns["sModoAcesso"].Visible = false;
                kryptonDataGridView1.Columns["sCaminhoArq"].HeaderText = "Caminho Arquivo";

                if (!kryptonDataGridView1.Columns.Contains("sUsuarioSistema"))
                    kryptonDataGridView1.Columns.Add("sUsuarioSistema", "Usuário Magnificus");
                if (!kryptonDataGridView1.Columns.Contains("xUsuarioSistema"))
                    kryptonDataGridView1.Columns.Add("xUsuarioSistema", "Id Usuário Magnificus");

                kryptonDataGridView1.Columns["xUsuarioSistema"].DisplayIndex = 2;
                kryptonDataGridView1.Columns["sUsuarioSistema"].DisplayIndex = 3;

                

                for (int i = 0; i < kryptonDataGridView1.Rows.Count; i++)
                {
                    objEstruturaModelXml = new EstruturaModelXml();
                    string teste = @"HLP\Carlost";
                    objEstruturaModelXml = objEstruturaModelXmlPai.lEstruturaModelXml.Where(
                        it => it.xUsuarioWindows.EndsWith(kryptonDataGridView1["sAcessado", i].Value.ToString())).OrderBy(it => it.dDataAcesso).FirstOrDefault();

                    if (objEstruturaModelXml == null)
                    {
                        kryptonDataGridView1["xUsuarioSistema", i].Value = "Usuário não logado";
                    }
                    else
                    {
                        kryptonDataGridView1["xUsuarioSistema", i].Value = objEstruturaModelXml.idFuncionario;
                        kryptonDataGridView1["sUsuarioSistema", i].Value = objEstruturaModelXml.xNomeFuncionario;
                        objEstrutModelXmlPaiSer.lEstruturaModelXml.Add(objEstruturaModelXml);
                        objEstruturaModelXmlPai.lEstruturaModelXml.Remove(objEstruturaModelXml);
                    }                    
                }

                SerializeClassToXml.SerializeClasse<EstruturaModelXmlPai>(objEstrutModelXmlPaiSer,
                    Registry.CurrentConfig.OpenSubKey("magnificus").GetValue("caminhoPadrao").ToString() + @"\arquivos\acesso.xml");
            }
            catch (Exception ex)
            {

                throw new Exception("Erro: " + ex.Message);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregaListaAcessosXml();
            CarregaExeAbertos();
        }

        private void formExecAbertos_Shown(object sender, EventArgs e)
        {
            btnAtualizar_Click(this, null);
        }
    }
}
