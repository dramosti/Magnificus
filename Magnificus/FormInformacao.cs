using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Magnificus
{
    public partial class FormInformacao : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public FormInformacao(string Header, string Aviso)
        {
            InitializeComponent();
            Rectangle r = Screen.PrimaryScreen.WorkingArea;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width - 15, Screen.PrimaryScreen.WorkingArea.Height - this.Height - 20);

            this.Text = Header;
            lblAviso.Text = Aviso;
        }
        private void FormInformacao_Load(object sender, EventArgs e)
        {
            timerLoad.Start();
        }

        int iSec = 0;
        private void timerLoad_Tick(object sender, EventArgs e)
        {
            iSec++;
            if (iSec == 3)
            {
                timerLoad.Stop();
                timerFechaTela.Start();
            }
        }
        private void timerFechaTela_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.04;
            if (this.Opacity < 0.1)
            {
                this.Close();
            }
        }

        private void frmInformacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        private void frmInformacao_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void control_MouseMove(object sender, MouseEventArgs e)
        {
            timerFechaTela.Stop();
            this.Opacity = 1;
        }
        private void control_MouseLeave(object sender, EventArgs e)
        {
            iSec = 0;
            timerLoad.Start();
        }




    }
}