using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using HLP.Comum.Modules;
using HLP.Comum.Models;

namespace HLP.Comum.Components
{
    [ToolboxBitmap(typeof(PrintPreviewControl))]
    public partial class HLP_Pesquisa : UserControlBase
    {
        public HLP_Pesquisa()
        {
            InitializeComponent();
            controleBase = this.txtDisplay;
            lblBase = this.lblDescricao;
        }
       

        private List<string> _listaValoresDisplay = new List<string>();
        [Category("HLP")]
        public List<string> _ListaValoresDisplay
        {
            get { return _listaValoresDisplay; }
            set { _listaValoresDisplay = value; }
        }


        [Editor(@"System.Windows.Forms.Design.StringCollectionEditor," +
        "System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
       typeof(System.Drawing.Design.UITypeEditor))]
        [TypeConverter(typeof(CsvConverter))]
        [Category("HLP")]
        public List<String> _ListaCamposDisplay
        {
            get
            {
                return _attributes;
            }
            set
            {
                _attributes = value;
            }
        }
        private List<String> _attributes = new List<string>();

        public class CsvConverter : TypeConverter
        {
            // Overrides the ConvertTo method of TypeConverter. 
            public override object ConvertTo(ITypeDescriptorContext context,
               CultureInfo culture, object value, Type destinationType)
            {
                List<String> v = value as List<String>;
                if (destinationType == typeof(string))
                {
                    return String.Join(";", v.ToArray());
                }
                return base.ConvertTo(context, culture, value, destinationType);
            }
        }
        private int _Value = 0;
        [Category("HLP")]
        public int Value
        {
            get { return _Value; }
            set
            {
                _Value = value;
                if (_Value != 0)
                {
                    txtPesquisa.Text = value.ToString();
                }
            }
        }
        [Category("HLP")]
        public bool _Vinculado { get; set; }
        private bool _ReadOnly = false;
        [Category("HLP")]
        public bool ReadOnly
        {
            get { return _ReadOnly; }
            set
            {
                _ReadOnly = value;
                txtPesquisa.ReadOnly = _ReadOnly;
                txtDisplay.ReadOnly = _ReadOnly;
                btnPesquisa.Enabled = _ReadOnly == true ? ComponentFactory.Krypton.Toolkit.ButtonEnabled.False : ComponentFactory.Krypton.Toolkit.ButtonEnabled.True;
            }
        }
        [Category("HLP")]
        public new bool Enabled
        {
            get { return txtPesquisa.TextBox.Enabled; }
            set
            {
                txtPesquisa.TextBox.Enabled = value;
                txtDisplay.TextBox.Enabled = value;
                txtDisplay.TextBox.ReadOnly = true;
                this.TabStop = value;
                if (value)
                {
                    txtPesquisa.StateNormal.Back.Color1 = Color.White;
                    txtDisplay.StateNormal.Back.Color1 = Color.White;
                    txtPesquisa.ButtonSpecs[0].Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True;
                }
                else
                {
                    txtPesquisa.StateNormal.Back.Color1 = Color.FromArgb(226, 225, 230);
                    txtDisplay.StateNormal.Back.Color1 = Color.FromArgb(226, 225, 230);
                    txtPesquisa.ButtonSpecs[0].Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False;
                }
            }
        }
        [Category("HLP")]
        public string _NomeView
        {
            get { return txtPesquisa.ButtonSpecs[0].Tag.ToString(); }
            set { txtPesquisa.ButtonSpecs[0].Tag = value; }
        }
        private string _nomeFormCadastroOriginal = "";
        [Category("HLP")]
        public string _NomeFormCadastroOriginal
        {
            get { return _nomeFormCadastroOriginal; }
            set { _nomeFormCadastroOriginal = value; }
        }
        [Category("HLP")]
        public string _NomeCampoPK
        {
            get;
            set;
        }


        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                SendKeys.Send("{tab}");
            }
            else
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
        }

        private void HLP_Pesquisa_Load(object sender, EventArgs e)
        {
            this.Height = 21;
            txtDisplay.Height = 20;
            _TamanhoComponente = 300;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(_NomeFormCadastroOriginal))
            {
                GerenciadorModulo.Instancia.ExibirForm(_NomeFormCadastroOriginal, TipoExibeForm.Modal);
            }
        }

        public event EventHandler _Enter;
        private void HLP_Pesquisa_Enter(object sender, EventArgs e)
        {
            if (_Enter != null)
            {
                _Enter(sender, e);
            }
        }


    }
}
