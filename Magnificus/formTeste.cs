using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magnificus
{
    public partial class formTeste : Form
    {
        public formTeste()
        {
            InitializeComponent();
            hlP_TextBox1.ChangeColorLabel(true);
            hlP_TextBox2.ChangeColorLabel(true);
            hlP_TextBox3.ChangeColorLabel(true);
            hlP_TextBox1.bConfiguracao = true;
        }

        private void hlP_TextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Control ctr = sender as Control;
            ctr.DoDragDrop(ctr, DragDropEffects.Move);
        }

        private void hlP_TextBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void hlP_TextBox1_DragDrop(object sender, DragEventArgs e)
        {

        }




    }
}
