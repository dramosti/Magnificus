using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HLP.Comum.Models;

namespace HLP.Comum.Components
{
    public partial class HLP_LabelSeparator : UserControl
    {
        public HLP_LabelSeparator()
        {
            InitializeComponent();
            this.TabStop = false;
        }



        private int _tamanhoMaiorLabel;
        public int _TamanhoMaiorLabel
        {
            get { return _tamanhoMaiorLabel; }
            set
            {
                _tamanhoMaiorLabel = value;
                this.Width = value;

                //int Margem = value - this.Width + 3;
                //this.Margin = new System.Windows.Forms.Padding(Margem, 3, 15, 3);

            }
        }

        public string _LabelText
        {
            get { return lblDescricao.Text; }
            set
            {
                lblDescricao.Text = Util.ToUpperFirstLetter(value);
            }
        }

        private void HLP_LabelSeparator_Load(object sender, EventArgs e)
        {
            // this.Width = 300;
            this.Height = 18;
        }

    }
}
