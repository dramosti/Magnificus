using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Magnificus
{
    public partial class FormSplash : KryptonForm
    {
        public FormSplash()
        {
            InitializeComponent();
        }

        #region [Metodos da interface IFormSplash]

        public void ExibeInformacao(string informacao)
        {
            if (this.Visible == false)
            {
                this.Show();
            }
            this.BringToFront();
            this.pb.PerformStep();
            this.lblInformacao.Text = informacao;
            this.Refresh();
        }

        public void ValoresProgressBar(int Maximo)
        {
            this.pb.Value = 0;
            this.pb.Maximum = Maximo;
            this.Refresh();
        }

        #endregion

    }
}