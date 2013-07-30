using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HLP.Comum.Ws;
using System.Reflection;
using Microsoft.Win32;
using System.Diagnostics;
using HLP.Models.Entries.Gerais;
using Ninject;
using HLP.Services.Interfaces.Entries.Gerais;
using HLP.Dependencies;
using HLP.Comum.Infrastructure.Static;


namespace SystemTray
{
    public partial class formAtualizacoes : Form
    {
        [Inject]
        public ILog_ScriptsService _Log_ScriptsService { get; set; }

        servicos objServicos = new servicos();
        VersaoService objService = null;
        List<HLP.Comum.Ws.servicoHlp.VersoesModel> lVersoesModel = new List<HLP.Comum.Ws.servicoHlp.VersoesModel>();
        MethodInfo iniciaAtualizacao = null;
        private object Sender = null;
        object[] mParam = null;
        const int Seed = 5;
        string sVersao = null;
        public formAtualizacoes(object oSender)
        {
            InitializeComponent();
            sVersao = FileVersionInfo.GetVersionInfo((Pastas.CaminhoPadraoRegWindows
                    + @"\magnificus\Magnificus.exe")).FileVersion;
            this.Text = "Versão atual: "+sVersao;
            objService = new VersaoService();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
            this.Sender = oSender;
            CarregarVersoes();
            PopularListView(Seed);
        }

        private void CarregarVersoes()
        {
            if (objServicos.RespostaWS())
            {

                lVersoesModel = objServicos.GetVersoes().OrderBy(i => i.xVersao).ToList();
            }
            else
                MessageBox.Show("Não foi possível conectar ao WebService de atualização, tente novamente em instantes.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void PopularListView(int iQuant)
        {
            listBox1.Items.Clear();

            for (int i = lVersoesModel.Count - iQuant < 0 ? 0 : lVersoesModel.Count - iQuant;
                i < lVersoesModel.Count; i++)
            {
                listBox1.Items.Add(lVersoesModel[i].xVersao.ToString());
            }
        }

        private void btnBaixar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Não foi selecionada nenhuma versão para ser baixada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (sVersao == listBox1.Items[listBox1.SelectedIndex].ToString().Replace(".zip", ""))
                {
                    MessageBox.Show("Versão já instalada neste computador.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (objService.RetornaVersaoMaior(sVersao, listBox1.Items[listBox1.SelectedIndex].ToString())
                    != listBox1.Items[listBox1.SelectedIndex].ToString())
                {
                    if (_Log_ScriptsService.GetLog_ScriptCountTotal(listBox1.Items[listBox1.SelectedIndex]
                     .ToString().Replace(".zip", "")) > 0)
                    {
                        MessageBox.Show("Não é possível retorno de versão. " + Environment.NewLine +
                            "Motivo: Versão que você está tentando baixar é menor que versão atual e foram executados scripts na base de dados.",
                            "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }

                Type tipo = Sender.GetType();
                mParam = new object[] {listBox1.Items[listBox1.SelectedIndex]
                        .ToString().Split('-')[0].Trim()};
                iniciaAtualizacao = tipo.GetMethod("IniciaAtualizacao");
                iniciaAtualizacao.Invoke(Sender, mParam);
                this.Close();
            }
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            PopularListView(listBox1.Items.Count + Seed);
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            int parIQuant = (listBox1.Items.Count - Seed) > Seed ? listBox1.Items.Count - Seed : Seed;
            PopularListView(parIQuant);
        }
    }
}
