using HLP.Dependencies;
using HLP.Models.Entries.Gerais;
using HLP.Services.Interfaces.Entries.Gerais;
using Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HLP.Comum.Ws;
using System.Threading;

using Microsoft.Win32;
using HLP.Comum.Infrastructure.Static;

namespace Magnificus
{
    public partial class FormScripts : Form
    {
        [Inject]
        public ILog_ScriptsService log_scriptService { get; set; }
        servicos objServico = new servicos();
        List<Log_ScriptsModel> lLogScriptsWs = new List<Log_ScriptsModel>();
        List<Log_ScriptsModel> lLogScriptsBd = new List<Log_ScriptsModel>();
        private int iPorcentagem = 0;


        public FormScripts()
        {
            InitializeComponent();
            progressBar1.Visible = false;
            lblStatusScripts.Visible = false;
            lblStatusScripts.Text = "";
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
            bwAtualizacoes.RunWorkerAsync();
        }

        private void hlP_DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bwAtualizacoes_DoWork(object sender, DoWorkEventArgs e)
        {
            if (objServico.RespostaWS())
            {
                lLogScriptsBd = log_scriptService.GetAllLog_Scripts();
                //bsAtualizacoes.DataSource = lLogScriptsBd;

                lLogScriptsWs = objServico.GetUltimosScripts(Application.ProductVersion.ToString()).AsEnumerable().Select(r => new Log_ScriptsModel
                {
                    xVersao = r.xVersao
                }).ToList();



                List<Log_ScriptsModel> lResult = (from c in lLogScriptsWs
                                                  where !lLogScriptsBd.Select(u => u.xVersao).ToArray().Contains(c.xVersao)
                                                  select c).ToList();


                foreach (Log_ScriptsModel item in lResult)
                {
                    lLogScriptsBd.Add(item);
                    item.SetStatusRegistro(HLP.Comum.Infrastructure.BaseModelFilhos.statusRegistroFilho.Incluido);
                }

                bsAtualizacoes.DataSource = null;
                bsAtualizacoes.DataSource = lLogScriptsBd;
                hlP_DataGridView1.DataSource = bsAtualizacoes;
                hlP_DataGridView1.HLP_Refresh();
            }
        }

        private void bwAtualizacoes_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void FormScripts_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in hlP_DataGridView1.Rows)
            {
                if (hlP_DataGridView1[dtExecucao.Name, item.Index].Value == null)
                    item.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FF6A6A"); //cor do tom vermelho
                else
                    item.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#C1FFC1"); //cor do tom verde
            }
            hlP_DataGridView1.Rows[hlP_DataGridView1.Rows.Count - 1].Selected = true;
            hlP_DataGridView1.CurrentRow.Selected = false;
        }

        private void hlP_DataGridView1_Click(object sender, EventArgs e)
        {
            hlP_DataGridView1.CurrentRow.Selected = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            bwExecScripts.RunWorkerAsync();
        }

        public bool ScriptNaoExec()
        {
            return lLogScriptsBd.Where(l => l.dtExec == null).Count() > 0;
        }

        private void bwPorcBackup_DoWork(object sender, DoWorkEventArgs e)
        {
            if (objServico.RespostaWS())
            {
                Log_ScriptsModel objLogScript;
                Invoke(new MethodInvoker(delegate
                    {
                        progressBar1.Visible = lblStatusScripts.Visible = true;
                        progressBar1.Maximum = lLogScriptsBd.Where(l => l.dtExec == null).Count() + 1;
                        progressBar1.Value = 0;
                    }));

                Invoke(new MethodInvoker(delegate
                {
                    lblStatusScripts.Text = "Executando Backup...";
                }));

                //bwPorcBackup.RunWorkerAsync(log_scriptService);

                try
                {

                    log_scriptService.Backup(Pastas.CaminhoPadraoRegWindows
                    + @"\backupsbases\bkpScript", "bkp_" + DateTime.Now.Day.ToString() + "_" +
                    DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + "_" +
                    DateTime.Now.Hour.ToString() + "_" + DateTime.Now.Minute.ToString() + "_" +
                    DateTime.Now.Second.ToString() + ".bak");
                    Invoke(new MethodInvoker(delegate
                    {
                        progressBar1.Value++;
                    }));
                }
                catch (Exception)
                {
                    throw;
                }

                foreach (DataGridViewRow item in hlP_DataGridView1.Rows)
                {
                    if (item.DefaultCellStyle.BackColor == ColorTranslator.FromHtml("#FF6A6A"))
                    {
                        objLogScript = lLogScriptsBd.Where(i => i.xVersao ==
                                hlP_DataGridView1[versao.Name,
                                item.Index].Value.ToString()).FirstOrDefault();
                        Invoke(new MethodInvoker(delegate
                        {
                            lblStatusScripts.Text = "Executando script " +
                            hlP_DataGridView1[versao.Name, item.Index].Value.ToString();
                        }));


                        if (hlP_DataGridView1[script.Name, item.Index].Value == null)
                        {
                            hlP_DataGridView1[script.Name, item.Index].Value =
                            objServico.getScript(hlP_DataGridView1[versao.Name, item.Index].Value.ToString());
                        }
                        else
                        {
                            objLogScript.SetStatusRegistro(HLP.Comum.Infrastructure.BaseModelFilhos.statusRegistroFilho.Alterado);
                        }

                        try
                        {
                            if (log_scriptService.ExecScript(hlP_DataGridView1[script.Name, item.Index].Value.ToString()
                            ))
                            {
                                item.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#C1FFC1"); //cor do tom verde;
                                objLogScript.idFuncionario = UserData.idUser.ToString();
                                objLogScript.dtExec = DateTime.Now.ToString();
                            }
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                        Thread.Sleep(100);
                        Invoke(new MethodInvoker(delegate
                        {
                            progressBar1.Value++;
                        }));

                    }
                }
                log_scriptService.Save(lLogScriptsBd);
            }
            else
            {
                MessageBox.Show("Não foi possível conectar ao WebService de atualização, tente novamente em instantes.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ControlaPorcBkp(ILog_ScriptsService objLog_ScriptService)
        {
            while (iPorcentagem < 100)
            {
                iPorcentagem = objLog_ScriptService.RetornaPorcBkp();

                Invoke(new MethodInvoker(delegate
                {
                    progressBar1.Value = iPorcentagem;
                }));
            }
        }

        private void bwExecScripts_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Close();
        }
    }
}
