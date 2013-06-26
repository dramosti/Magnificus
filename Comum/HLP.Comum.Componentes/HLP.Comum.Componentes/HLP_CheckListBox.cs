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
    public partial class HLP_CheckListBox : UserControlBase
    {
        public HLP_CheckListBox()
        {
            InitializeComponent();
            controleBase = this.chk;
            lblBase = this.lblDescricao;
        }
        [Category("HLP")]
        public new bool Enabled
        {
            get { return chk.Enabled; }
            set
            {
                chk.Enabled = value;
                this.TabStop = value;
                if (value)
                {
                    chk.StateNormal.Back.Color1 = Color;
                }
                else
                {
                    chk.StateNormal.Back.Color1 = Color.FromArgb(226, 225, 230);
                }
            }
        }
        [Category("HLP")]
        public new bool AllowDrop
        {
            get { return chk.AllowDrop; }
            set { chk.AllowDrop = value; }
        }

       
        private Color _color = Color.White;
        [Category("HLP")]
        public Color Color
        {
            get { return _color; }
            set
            {
                _color = value;
                chk.StateNormal.Back.Color1 = value;
            }
        }
    }
}
