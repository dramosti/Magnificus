using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using HLP.Comum.Ws;
using HLP.Comum.Ws.servicoHlp;
using ComponentFactory.Krypton.Toolkit;
using System.Reflection;

namespace HLP.UI.Utility
{
    public partial class formAtualizacao : KryptonForm
    {
        servicos objServicos = new servicos();
        List<VersoesModel> lVersoes = new List<VersoesModel>();
        MethodInfo iniciaAtualizacao = null;
        object[] mParam = null;
        public formAtualizacao()
        {
            InitializeComponent();
        }

        private void formAtualizacao_Load(object sender, EventArgs e)
        {
            //Type myTypeObj = myClassObj.GetType();
            //// Get Method Information.
            //MethodInfo myMethodInfo = myTypeObj.GetMethod("AddNumb");
            //object[] mParam = new object[] { 5, 10 };
            //// Get and display the Invoke method.
            //Console.Write("\nFirst method - " + myTypeObj.FullName + " returns " +
            //                     myMethodInfo.Invoke(myClassObj, mParam) + "\n");

            //Type tipo = this.ParentForm.GetType();
            //setStatusBar = tipo.GetMethod("SetStatusBar");
            //mParam = new object[] {"Procurando Atualizações...", null, ""};
            //setStatusBar.Invoke(this.ParentForm, mParam);

            this.Text = this.Text +" Versão atual: "+ Application.ProductVersion.ToString();
            lVersoes = objServicos.GetVersoes();
            foreach (VersoesModel item in lVersoes)
            {
                listViewVersoes.Items.Add(item.xVersao + " - " + item.dtArquivo);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listViewVersoes.SelectedIndex < 0)
            {
                MessageBox.Show("Não foi selecionada nenhuma versão para ser baixada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Type tipo = this.ParentForm.GetType();
                mParam = new object[] {listViewVersoes.Items[listViewVersoes.SelectedIndex]
                        .ToString().Split('-')[0].Trim()};
                iniciaAtualizacao = tipo.GetMethod("IniciaAtualizacao");
                iniciaAtualizacao.Invoke(this.ParentForm, mParam);
            }
        }

    }
}
