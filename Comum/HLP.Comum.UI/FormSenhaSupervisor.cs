using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HLP.Comum.UI
{
    public partial class FormSenhaSupervisor : KryptonForm
    {
        public FormSenhaSupervisor()
        {
            InitializeComponent();
            txtSenha.txt.UseSystemPasswordChar = true;
        }

        private void btnConfirmar__btnHlpClick(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnCancelar__btnHlpClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
