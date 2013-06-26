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
    [ToolboxBitmap(typeof(DateTimePicker))]
    public partial class HLP_DateTimePicker : UserControlBase
    {

        public HLP_DateTimePicker()
        {
            InitializeComponent();
            controleBase = this.dtp;
            lblBase = this.lblDescricao;
        }

        public enum CampoObrigatorio
        {
            SIM,
            NÃO
        }
        [Category("HLP")]
        public new bool Enabled
        {
            get { return dtp.Enabled; }
            set
            {
                dtp.Enabled = value;
                this.TabStop = value;
                if (value)
                {
                    dtp.StateNormal.Back.Color1 = Color.White;
                }
                else
                {
                    dtp.StateNormal.Back.Color1 = Color.FromArgb(226, 225, 230);
                }
            }
        }
        [Category("HLP")]
        public override string Text { get { return dtp.Text; } set { dtp.Text = value; } }
        [Category("HLP")]
        public Color Color { get { return dtp.StateNormal.Back.Color1; } set { dtp.StateNormal.Back.Color1 = value; } }
        [Category("HLP")]
        public DateTimePickerFormat Format { get { return dtp.Format; } set { dtp.Format = value; ConfiguraTamanho(); } }
        [Category("HLP")]
        public string CustomFormat { get { return dtp.CustomFormat; } set { dtp.CustomFormat = value; } }
        [Category("HLP")]
        public DateTime Value { get { return dtp.Value; } set { dtp.Value = value; } }

      




        private void ConfiguraTamanho()
        {
            switch (Format)
            {
                case DateTimePickerFormat.Custom:
                    this.Width = lblDescricao.Width + 180;
                    break;
                case DateTimePickerFormat.Long:
                    this.Width = lblDescricao.Width + 240;
                    break;
                case DateTimePickerFormat.Short:
                    this.Width = lblDescricao.Width + 90;
                    break;
                case DateTimePickerFormat.Time:
                    this.Width = lblDescricao.Width + 90;
                    break;
            }
        }
        private void dtp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                SendKeys.Send("{tab}");
            }
        }
        public event EventHandler _ValueChanged;
        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            if (_ValueChanged != null)
            {
                _ValueChanged(sender, e);
            }
        }
        public event EventHandler _Enter;
        private void dtp_Enter(object sender, EventArgs e)
        {
            if (_Enter != null)
            {
                _Enter(sender, e);
            }
        }
        public event EventHandler _Leave;
        private void dtp_Leave(object sender, EventArgs e)
        {
            if (_Leave != null)
            {
                _Leave(sender, e);
            }
        }
        private void HLP_DateTimePicker_Load(object sender, EventArgs e)
        {
            this.Height = 21;
        }
    }
}
