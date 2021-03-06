﻿using System;
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
            base.Initialize();
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
        [Category("HLP")]
        [Description("Label no modo superior ?")]
        public bool _LabelSuperior
        {
            get { return _labelSuperior; }
            set
            {
                _labelSuperior = value;
                if (value)
                {
                    this.InitializeComponentModoLeftToRigth();
                }
                else
                {
                    this.InitializeComponentModoTopToDown();

                }
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

            if (nud.Value > nud.Maximum)
            {
                if (nud.Maximum > 0)
                {
                    string sValor = "0";
                    if (this.old_value >= nud.Maximum)
                    {
                        this.old_value.ToString().Substring(0, nud.Maximum.ToString().Length);
                    }
                    (sender as KryptonNumericUpDown).Value = Convert.ToDecimal(sValor);
                }
                else
                {
                    (sender as KryptonNumericUpDown).Value = 0;
                }
            }
            else
            {
                this.old_value = nud.Value;


            }
        }

        public event EventHandler _Validated;
        private void nud_Validated(object sender, EventArgs e)
        {
            if (_Validated != null)
            {
                _Validated(sender, e);
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

        void InitializeComponentModoTopToDown()
        {
            int iTamanhoTxt = this.nud.Width;

            this.nud.Dock = System.Windows.Forms.DockStyle.Fill;

            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDescricao.Location = new System.Drawing.Point(0, 0);

            this.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.Size = new System.Drawing.Size((lblBase.Width + iTamanhoTxt), 22);

            this.ResumeLayout(false);
            this.PerformLayout();




        }
        void InitializeComponentModoLeftToRigth()
        {
            int iWidth = this.nud.Width;
      
            this.nud.Dock = System.Windows.Forms.DockStyle.Left;
            this.nud.Location = new System.Drawing.Point(0, 13);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDescricao.Location = new System.Drawing.Point(0, 0);
            // 
            // HLP_TextBox
            // 
            //this._TamanhoComponente = 80;
            this.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            //this.Size = new System.Drawing.Size(180, 35);

            

            if (lblBase.Width > iWidth)
                iWidth = lblBase.Width;
            nud.Width = iWidth;
            this.Size = new Size(iWidth, 35);

            this.ResumeLayout(false);
            this.PerformLayout();



        }



    }
}
