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
using System.Reflection;

namespace SystemTray
{
    public partial class formAtualizacoes : Form
    {
        servicos objServicos = new servicos();
        List<HLP.Comum.Ws.servicoHlp.VersoesModel> lVersoesModel = new List<HLP.Comum.Ws.servicoHlp.VersoesModel>();
        MethodInfo iniciaAtualizacao = null;
        private object Sender = null;
        object[] mParam = null;
        const int Seed = 5;
        public formAtualizacoes(object oSender)
        {
            InitializeComponent();
            this.Sender = oSender;
            CarregarVersoes();
            PopularListView(Seed);
        }

        private void CarregarVersoes()
        {
            if (objServicos.RespostaWS())
                lVersoesModel = objServicos.GetVersoes().OrderBy(i => Convert.ToDateTime(i.dtArquivo)).ToList();
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
                Type tipo = Sender.GetType();
                mParam = new object[] {listBox1.Items[listBox1.SelectedIndex]
                        .ToString().Split('-')[0].Trim()};
                iniciaAtualizacao = tipo.GetMethod("IniciaAtualizacao");
                iniciaAtualizacao.Invoke(Sender, mParam);
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
