using HLP.Comum.Infrastructure;
using HLP.Comum.Infrastructure.Static;
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

        public enum TipoAcesso
        {
            local = 0,
            servidor = 1
        }

        private TipoAcesso tTpAcesso;

        //System.Threading.Timer timer;
        EstruturaService objEstrutService = new EstruturaService();
        EstruturaModelXmlPai objEstruturaModelXmlPai = new EstruturaModelXmlPai();
        EstruturaModelXml objEstruturaModelXml = null;


        public formExecAbertos(TipoAcesso tTpAcesso)
        {
            InitializeComponent();
            this.tTpAcesso = tTpAcesso;
        }

        private void CarregaListaAcessosXml()
        {
            try
            {
                objEstruturaModelXmlPai = SerializeClassToXml.DeserializeClasse<EstruturaModelXmlPai>(
                Pastas.CaminhoPadraoRegWindows + @"\arquivos\acesso.xml");
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

            bsExec = new BindingSource();
            bsExec.DataSource = objEstruturaModelXmlPai.lEstruturaModelXml;
            kryptonDataGridView1.DataSource = null;
            kryptonDataGridView1.DataSource = bsExec.DataSource;
            ConfiguraDgv();
        }

        private void CarregaExeAbertos()
        {
            List<EstruturaModel> lEstruturaModel = objEstrutService.GetListEstrutura();
            EstruturaModelXmlPai objEstrutModelXmlPaiSer = new EstruturaModelXmlPai();
            objEstrutModelXmlPaiSer.lEstruturaModelXml = new List<EstruturaModelXml>();
            EstruturaModelXml objEstrutModelXml = null;
            try
            {
                for (int i = 0; i < kryptonDataGridView1.Rows.Count; i++)
                {
                    

                    foreach (DataGridViewRow dr in kryptonDataGridView1.Rows)
                    {
                        if (lEstruturaModel.Where(it => it.sAcessado.EndsWith(
                        kryptonDataGridView1["xUsuarioWindows", dr.Index].Value.ToString())).Count() == 0)
                        {
                            kryptonDataGridView1.Rows.Remove(dr);
                        }
                        else
                        {
                            objEstruturaModelXml = new EstruturaModelXml();
                            objEstruturaModelXml.dDataAcesso = kryptonDataGridView1["dDataAcesso", dr.Index].Value != null ? (DateTime)kryptonDataGridView1["dDataAcesso", dr.Index].Value: default(DateTime);
                            objEstruturaModelXml.idFuncionario = kryptonDataGridView1["idFuncionario", dr.Index].Value != null ? kryptonDataGridView1["idFuncioanrio", dr.Index].Value.ToString(): null;
                            objEstruturaModelXml.numSessao = kryptonDataGridView1["numSessao", dr.Index].Value != null ? (Guid)kryptonDataGridView1["numSessao", dr.Index].Value: default(Guid);
                            objEstruturaModelXml.xIpMaquina = kryptonDataGridView1["xIpMaquina", dr.Index].Value != null ? kryptonDataGridView1["xIpMaquina", dr.Index].Value.ToString(): null;
                            objEstruturaModelXml.xNomeFuncionario = kryptonDataGridView1["xNomeFuncionario", dr.Index].Value != null ? kryptonDataGridView1["xNomeFuncionario", dr.Index].Value.ToString(): null;
                            objEstruturaModelXml.xNomeMaquina = kryptonDataGridView1["xNomeMaquina", dr.Index].Value != null ? kryptonDataGridView1["xNomeMaquina", dr.Index].Value.ToString(): null;
                            objEstruturaModelXml.xUsuarioWindows = kryptonDataGridView1["xUsuarioWindows", dr.Index].Value != null ? kryptonDataGridView1["xUsuarioWindows", dr.Index].Value.ToString(): null;
                            objEstrutModelXmlPaiSer.lEstruturaModelXml.Add(objEstrutModelXml);
                        }
                    }
                    #region Teste
                    //objEstruturaModelXml = objEstruturaModelXmlPai.lEstruturaModelXml.Where(
                    //    it => it.xUsuarioWindows.EndsWith(kryptonDataGridView1["sAcessado", i].Value.ToString())).OrderBy(it => it.dDataAcesso).FirstOrDefault();

                    //if (objEstruturaModelXml != null)
                    //{
                    //    kryptonDataGridView1["xUsuarioSistema", i].Value = objEstruturaModelXml.idFuncionario;
                    //    kryptonDataGridView1["sUsuarioSistema", i].Value = objEstruturaModelXml.xNomeFuncionario;
                    //    objEstrutModelXmlPaiSer.lEstruturaModelXml.Add(objEstruturaModelXml);
                    //    objEstruturaModelXmlPai.lEstruturaModelXml.Remove(objEstruturaModelXml);
                    //}
                    #endregion
                }

                SerializeClassToXml.SerializeClasse<EstruturaModelXmlPai>(objEstrutModelXmlPaiSer,
                    Pastas.CaminhoPadraoRegWindows + @"\arquivos\acesso.xml");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro: " + ex.Message);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregaListaAcessosXml();

            if (tTpAcesso == TipoAcesso.servidor)
            {
                CarregaExeAbertos();
            }
        }

        private void formExecAbertos_Shown(object sender, EventArgs e)
        {
            btnAtualizar_Click(this, null);
        }

        private void ConfiguraDgv()
        {
            kryptonDataGridView1.Columns["numSessao"].Visible = false;

            kryptonDataGridView1.Columns["dDataAcesso"].HeaderText = "Data de Acesso";
            kryptonDataGridView1.Columns["dDataAcesso"].Visible = true;
            kryptonDataGridView1.Columns["dDataAcesso"].DisplayIndex = 0;

            kryptonDataGridView1.Columns["idFuncionario"].HeaderText = "Id Usuário Magnificus";
            kryptonDataGridView1.Columns["idFuncionario"].Visible = true;
            kryptonDataGridView1.Columns["idFuncionario"].DisplayIndex = 1;

            kryptonDataGridView1.Columns["xNomeFuncionario"].HeaderText = "Usuário Magnificus";
            kryptonDataGridView1.Columns["xNomeFuncionario"].Visible = true;
            kryptonDataGridView1.Columns["xNomeFuncionario"].DisplayIndex = 2;

            kryptonDataGridView1.Columns["xUsuarioWindows"].HeaderText = "Usuário Windows";
            kryptonDataGridView1.Columns["xUsuarioWindows"].Visible = true;
            kryptonDataGridView1.Columns["xUsuarioWindows"].DisplayIndex = 3;

            kryptonDataGridView1.Columns["xIpMaquina"].HeaderText = "Ip Computador";
            kryptonDataGridView1.Columns["xIpMaquina"].Visible = true;
            kryptonDataGridView1.Columns["xIpMaquina"].DisplayIndex = 4;

            kryptonDataGridView1.Columns["xNomeMaquina"].HeaderText = "Nome Computador";
            kryptonDataGridView1.Columns["xNomeMaquina"].Visible = true;
            kryptonDataGridView1.Columns["xNomeMaquina"].DisplayIndex = 5;
            kryptonDataGridView1.Columns["xNomeMaquina"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
