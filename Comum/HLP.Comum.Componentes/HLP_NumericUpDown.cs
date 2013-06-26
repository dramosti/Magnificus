using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Xml.Linq;
using HLP.Comum.Models;

namespace HLP.Comum.Components
{
    [ToolboxBitmap(typeof(NumericUpDown))]
    public partial class HLP_NumericUpDown : UserControlBase
    {
        private decimal old_value { get; set; }
        public HLP_NumericUpDown()
        {
            InitializeComponent();
            controleBase = this.nud;
            lblBase = this.lblDescricao;
            this.Height = 22;
        }
        [Category("HLP")]
        public int ValueInt { get { return (nud.Text == "" ? 0 : Convert.ToInt32(Math.Round(Convert.ToDecimal(nud.Text), 0))); } set { nud.Text = value.ToString(); nud.Value = Convert.ToDecimal(value); } }
        [Category("HLP")]
        public int DecimalPlaces
        {
            get { return nud.DecimalPlaces; }
            set
            {
                nud.DecimalPlaces = value;
                string str = "".PadLeft(value + (int)Maximum.ToString().Length, '9');
                _TamanhoComponente = (int)CreateGraphics().MeasureString(str, nud.Font).Width + 20;
            }
        }
        [Category("HLP")]
        public decimal Value
        {
            get { return (nud.Text == "" ? 0 : Convert.ToDecimal(nud.Text)); }
            set
            {
                if (nud.Minimum > value)
                {
                    nud.Text = "0";
                    nud.Value = 0;
                }
                else
                {
                    nud.Text = value.ToString();
                    nud.Value = value;
                }
            }
        }
        [Category("HLP")]
        public decimal Maximum
        {
            get { return nud.Maximum; }
            set
            {
                nud.Maximum = value;
                string str = "".PadLeft(value.ToString().Length + DecimalPlaces, '9');
                _TamanhoComponente = (int)CreateGraphics().MeasureString(str, nud.Font).Width + 20;
            }
        }
        [Category("HLP")]
        public decimal Minimum { get { return nud.Minimum; } set { nud.Minimum = value; } }
        [Category("HLP")]
        public bool ReadOnly
        {
            get { return nud.ReadOnly; }
            set
            {
                nud.ReadOnly = value;
                if (value)
                {
                    nud.Increment = 0;
                    nud.StateNormal.Back.Color1 = Color.FromArgb(226, 225, 230);
                }
                else
                {
                    nud.Increment = 1;
                    nud.StateNormal.Back.Color1 = Color;
                }
            }
        }
        [Category("HLP")]
        public new bool Enabled
        {
            get { return nud.NumericUpDown.Enabled; }
            set
            {
                nud.NumericUpDown.Enabled = value;
                if (!ReadOnly)
                {
                    this.TabStop = value;
                    if (value)
                    {
                        nud.Increment = 1;
                        nud.StateNormal.Back.Color1 = Color;
                    }
                    else
                    {
                        nud.Increment = 0;
                        nud.StateNormal.Back.Color1 = Color.FromArgb(226, 225, 230);
                    }
                }
            }
        }
        [Category("HLP")]
        public override string Text
        {
            get { return nud.Text; }
            set
            {
                nud.Text = value;
                nud.Value = (value.Equals("") ? 0 : Convert.ToDecimal(value));
            }
        }
        private Color _color = Color.White;
        [Category("HLP")]
        public Color Color
        {
            get { return _color; }
            set
            {
                _color = value;
                nud.StateNormal.Back.Color1 = value;
            }
        }


        private void nud_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                SendKeys.Send("{tab}");
            }
        }

        public event EventHandler _ValueChanged;
        private void nud_ValueChanged(object sender, EventArgs e)
        {
            if (_ValueChanged != null)
            {
                _ValueChanged(sender, e);
            }

            if (nud.Value >= nud.Maximum)
            {
                (sender as KryptonNumericUpDown).Value = this.old_value;
            }
            else
            {
                this.old_value = nud.Value;
            }
        }

        public event EventHandler _Enter;
        private void nud_Enter(object sender, EventArgs e)
        {
            nud.Select(0, nud.Text.Length);
            if (_Enter != null)
            {
                _Enter(sender, e);
            }
        }

        public event EventHandler _Leave;
        private void nud_Leave(object sender, EventArgs e)
        {
            if (_Leave != null)
            {
                _Leave(sender, e);
            }
        }

        private void HLP_NumericUpDown_Load(object sender, EventArgs e)
        {
            //this.Height = 22;
        }




    }
}
