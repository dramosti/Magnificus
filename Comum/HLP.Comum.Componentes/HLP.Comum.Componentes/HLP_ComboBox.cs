using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HLP.Comum.Components
{
    [ToolboxBitmap(typeof(ComboBox))]
    public partial class HLP_ComboBox : UserControlBase
    {
        public HLP_ComboBox()
        {
            InitializeComponent();
            base.Initialize();
            controleBase = this.cbx;
            lblBase = this.lblDescricao;
        }
        [Editor(@"System.Windows.Forms.Design.StringCollectionEditor," +
      "System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
     typeof(System.Drawing.Design.UITypeEditor))]
        [TypeConverter(typeof(CsvConverter))]
        [Category("HLP")]
        public List<String> _Itens
        {
            get
            {
                return _attributes;
            }
            set
            {
                _attributes = value;
                cbx.Items.Clear();
                foreach (string sItem in _attributes)
                {
                    cbx.Items.Add(sItem);
                }
            }
        }
        private List<String> _attributes = new List<string>();

        public class CsvConverter : TypeConverter
        {
            public override object ConvertTo(ITypeDescriptorContext context,
               System.Globalization.CultureInfo culture, object value, Type destinationType)
            {
                List<String> v = value as List<String>;
                if (destinationType == typeof(string))
                {
                    return String.Join(";", v.ToArray());
                }
                return base.ConvertTo(context, culture, value, destinationType);
            }
        }
        [Category("HLP")]
        public int SelectedIndex { get { return cbx.SelectedIndex; } set { cbx.SelectedIndex = value; } }
        [Category("HLP")]
        public Byte SelectedIndexByte
        {
            get
            {
                if (cbx.SelectedIndex != -1)
                {
                    int i = Convert.ToInt32(cbx.SelectedIndex);
                    if (i > 255)
                    {
                        return 255;
                    }
                    else
                    {
                        return Convert.ToByte(cbx.SelectedIndex);
                    }
                }
                else
                {
                    return 0;
                }
            }
        }
        [Category("HLP")]
        public override string Text { get { return cbx.Text; } set { cbx.Text = value; } }

        private bool situacao = false;
        [Category("HLP")]
        public bool _situacao
        {
            get { return situacao; }
            set
            {
                situacao = value;
                if (value)
                {
                    List<string> l = new List<string>();
                    l.Add("0-NÃO");
                    l.Add("1-SIM");
                    _Itens = l;
                    _TamanhoComponente = 80;
                }
            }
        }
        [Category("HLP")]
        public new bool Enabled
        {
            get { return cbx.ComboBox.Enabled; }
            set
            {
                cbx.ComboBox.Enabled = value;
                this.TabStop = value;
                if (value)
                {
                    cbx.StateNormal.ComboBox.Back.Color1 = Color;
                }
                else
                {
                    cbx.StateNormal.ComboBox.Back.Color1 = Color.FromArgb(226, 225, 230);
                }
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
                cbx.StateNormal.ComboBox.Back.Color1 = value;
            }
        }

        private string _DisplayMember = "DisplayMember";
        [Category("HLP")]
        public string DisplayMember
        {
            get { return _DisplayMember; }
            set
            {
                _DisplayMember = value;
                cbx.DisplayMember = value;
            }
        }
        private string _ValueMember = "ValueMember";
        [Category("HLP")]
        public string ValueMember
        {
            get { return _ValueMember; }
            set
            {
                _ValueMember = value;
                cbx.ValueMember = value;
            }
        }
        [Category("HLP")]
        public object DataSource
        {
            get { return cbx.DataSource; }
            set
            {
                cbx.DataSource = value;
                cbx.DisplayMember = DisplayMember;
                cbx.ValueMember = ValueMember;
                if (value != null)
                {
                    int width = 0;
                    int newWidth = 0;
                    foreach (var sItem in cbx.Items)
                    {
                        newWidth = (int)CreateGraphics().MeasureString(cbx.GetItemText(sItem), cbx.Font).Width;
                        if (width < newWidth)
                        {
                            width = newWidth;
                        }
                    }
                    _TamanhoComponente = width + 22;
                }
            }
        }
        [Category("HLP")]
        public object SelectedValue { get { return (cbx.SelectedValue != null ? Convert.ToInt32(cbx.SelectedValue) : 0); } set { cbx.SelectedValue = value; } }

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
                    this.InitializeComponentModoLeftToRight();
                }
                else
                {
                    this.InitializeComponentModoTopDown();

                }
            }
        }

        private void cbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                SendKeys.Send("{tab}");
            }
        }

        public event EventHandler _SelectedIndexChanged;
        private void cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_SelectedIndexChanged != null)
            {
                _SelectedIndexChanged(sender, e);
            }
        }

        public event EventHandler _SelectedValueChanged;
        private void cbx_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_SelectedValueChanged != null)
            {
                _SelectedValueChanged(sender, e);
            }
        }

        public event EventHandler _Enter;
        private void cbx_Enter(object sender, EventArgs e)
        {
            if (_Enter != null)
            {
                _Enter(sender, e);
            }
        }

        public event EventHandler _Leave;
        private void cbx_Leave(object sender, EventArgs e)
        {
            if (_Leave != null)
            {
                _Leave(sender, e);
            }
        }

        private void HLP_ComboBox_Load(object sender, EventArgs e)
        {
            this.Height = 21;
            if (_attributes.Count() > 0)
            {
                if (!situacao)
                {
                    int width = 0;
                    int newWidth = 0;
                    foreach (string sItem in _attributes)
                    {
                        newWidth = (int)CreateGraphics().MeasureString(sItem, cbx.Font).Width;
                        if (width < newWidth)
                        {
                            width = newWidth;
                        }
                    }
                    _TamanhoComponente = width + 30;
                }
                else
                {
                    _TamanhoComponente = 80;
                }
            }
            else if (situacao)
            {
                _TamanhoComponente = 80;
            }
        }



        private void InitializeComponentModoTopDown()
        {
            int iTamanhoCbx = this.cbx.Width;

            this.cbx.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDescricao.Location = new System.Drawing.Point(0, 0);
            // 
            // HLP_ComboBox
            // 
            this.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.Size = new System.Drawing.Size((lblBase.Width + iTamanhoCbx), 21);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void InitializeComponentModoLeftToRight()
        {
            int iWidth = this.cbx.Width;
            this.cbx.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbx.Location = new System.Drawing.Point(0, 13);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDescricao.Location = new System.Drawing.Point(0, 0);

            this.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);

            if (lblBase.Width > iWidth)
                iWidth = lblBase.Width;
            cbx.Width = iWidth;
            this.Size = new Size(iWidth, 35);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

       


    }
}
