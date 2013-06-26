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
    public partial class HLP_ListBox : UserControlBase
    {

        public HLP_ListBox()
        {
            InitializeComponent();
            controleBase = this.lst;
            lblBase = this.lblDescricao;
        }
        [Category("HLP")]
        public new bool Enabled
        {
            get { return lst.ListBox.Enabled; }
            set
            {
                lst.ListBox.Enabled = value;
                this.TabStop = value;
                if (value)
                {
                    lst.StateNormal.Back.Color1 = Color;
                }
                else
                {
                    lst.StateNormal.Back.Color1 = Color.FromArgb(226, 225, 230);
                }

            }
        }
        [Category("HLP")]
        public override bool AllowDrop
        {
            get
            {
                return lst.ListBox.AllowDrop;

            }
            set
            {
                lst.ListBox.AllowDrop = value;
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
                lst.DisplayMember = value;
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
                lst.ValueMember = value;
            }
        }
        [Category("HLP")]
        public object DataSource
        {
            get { return lst.DataSource; }
            set
            {
                lst.DataSource = value;
                lst.DisplayMember = DisplayMember;
                lst.ValueMember = ValueMember;
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
                lst.StateNormal.Back.Color1 = value;
            }
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
                List<string> objRet = new List<string>();
                foreach (string item in lst.ListBox.Items)
                {
                    objRet.Add(item);
                }
                return objRet;
            }
            set
            {
                _attributes = value;
                lst.Items.Clear();
                foreach (string sItem in _attributes)
                {
                    lst.ListBox.Items.Add(sItem);
                }

            }
        }
        private List<String> _attributes = new List<string>();
        public class CsvConverter : TypeConverter
        {
            // Overrides the ConvertTo method of TypeConverter. 
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


        private void lst_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                if (lst.ListBox.AllowDrop)
                {
                    int index = 0;
                    Point point = lst.PointToClient(new Point(e.X, e.Y));
                    index = this.lst.IndexFromPoint(point);

                    if (index < 0) index = this.lst.Items.Count - 1;

                    object data = e.Data.GetData(typeof(string));
                    this.lst.Items.Remove(data);
                    this.lst.Items.Insert(index, data);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void lst_DragOver(object sender, DragEventArgs e)
        {
            if (lst.ListBox.AllowDrop)
            {
                e.Effect = DragDropEffects.Move;
            }
        }
        private void lst_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (lst.ListBox.AllowDrop)
                {
                    if (lst.SelectedItem != null)
                    {
                        lst.DoDragDrop(this.lst.SelectedItem, DragDropEffects.Move);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void lst_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                lst.Items.Remove(lst.SelectedItem);
            }
        }
    }
}
