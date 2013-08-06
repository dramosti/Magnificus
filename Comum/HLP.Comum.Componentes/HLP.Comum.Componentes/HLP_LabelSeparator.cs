using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HLP.Comum.Models;
using HLP.Comum.Infrastructure.Static;

namespace HLP.Comum.Components
{
    public partial class HLP_LabelSeparator : UserControl
    {
        public bool bOpen = true;
        public HLP_LabelSeparator()
        {
            InitializeComponent();
            this.TabStop = false;

        }

        public List<Control> lComponentesBySerparador = new List<Control>();


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
            get { return headerSep.Text; }
            set
            {
                headerSep.Text = Util.ToUpperFirstLetter(value);
            }
        }

        private void HLP_LabelSeparator_Load(object sender, EventArgs e)
        {
            // this.Width = 300;
            this.Height = 19;
        }

        public void ConfigMaiorLabel()
        {
            try
            {
                List<Control> lctr = this.lComponentesBySerparador.Where(c => (c as UserControlBase)._labelGroup == this).ToList();

                int iLabelMax = lctr.Max(c => c.GetPropertyValue("_TamanhoLabel")).ToInt32();
                foreach (Control ctr in lctr)
                {
                    ctr.SetPropertyValue("_TamanhoMaiorLabel", iLabelMax);
                }
                int iWidthMax = lctr.Max(c => c.Width);
                Control controle = lctr.FirstOrDefault(c => c.Width == iWidthMax);
                this.Width = (controle.Width + controle.Margin.Left) - 3;


            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao configurar maior label dos componentes");
            }


        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            VisibleComponentes(!bOpen);
            if (bOpen)
            {
                btnStatus.Image = HLP.Comum.Components.Properties.Resources.seta_down;
            }
            else
            {
                btnStatus.Image = HLP.Comum.Components.Properties.Resources.seta_up;
            }
            bOpen = !bOpen;
        }

        void VisibleComponentes(bool bVisible)
        {
            foreach (Control ctr in lComponentesBySerparador)
            {
                ctr.Visible = bVisible;
            }
        }

    }
}
