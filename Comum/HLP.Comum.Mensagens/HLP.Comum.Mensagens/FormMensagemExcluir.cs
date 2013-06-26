using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace HLP.Comum.Messages
{
    public partial class FormMensagemExcluir : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public int iRet = 0;
        public FormMensagemExcluir()
        {
            InitializeComponent();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            iRet = 2; 
            this.Close();
        }

        private void btnTela_Click(object sender, EventArgs e)
        {
            iRet = 1;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            iRet = 0;
            this.Close();
        }
    }
}