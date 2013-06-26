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
    [ToolboxBitmap(typeof(CheckBox))]
    public partial class HLP_CheckBox : UserControlBase
    {

        public enum CampoObrigatorio
        {
            SIM,
            NÃO
        }

        public HLP_CheckBox()
        {
            InitializeComponent();
            controleBase = this.chk;
            lblBase = this.lblDescricao;
        }
        [Category("HLP")]
        public bool Checked { get { return chk.Checked; } set { chk.Checked = value; } }
        [Category("HLP")]
        public new bool Enabled
        {
            get { return chk.Enabled; }
            set
            {
                chk.Enabled = value;
                this.TabStop = value;
            }
        }
        [Category("HLP")]
        public bool Value { get { return chk.Checked; } set { chk.Checked = value; } }        
                     
        private void chk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                SendKeys.Send("{tab}");
            }
        }
        public event EventHandler _CheckedChanged;
        private void chk_CheckedChanged(object sender, EventArgs e)
        {
            if (_CheckedChanged != null)
            {
                _CheckedChanged(sender, e);
            }
        }
        public event EventHandler _Enter;
        private void chk_Enter(object sender, EventArgs e)
        {
            if (_Enter != null)
            {
                _Enter(sender, e);
            }
        }
        public event EventHandler _Leave;
        private void chk_Leave(object sender, EventArgs e)
        {
            if (_Leave != null)
            {
                _Leave(sender, e);
            }
        }
        private void HLP_CheckBox_Load(object sender, EventArgs e)
        {
            this.Height = 21;
        }



    }
}
