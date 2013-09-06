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
    public partial class formTeste1 : Form
    {
        public formTeste1()
        {
            InitializeComponent();

            //hlP_Group1.PositionComponente = HLP.Comum.Components.HLP_Group.Posicao.LeftToRigth;


            hlP_Group2.Add(hlP_Button1,0);


        }

        private void txtxCfop_Load(object sender, EventArgs e)
        {

        }
    }
}
