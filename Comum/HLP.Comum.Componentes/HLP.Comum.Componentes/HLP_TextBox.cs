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
using System.Reflection;
using HLP.Comum.Components.Configuracao;
using HLP.Comum.Models.Static;
using HLP.Comum.Messages;

namespace HLP.Comum.Components
{
    [ToolboxBitmap(typeof(TextBox))]
    public partial class HLP_TextBox : UserControlBase
    {


        public HLP_TextBox()
        {
            InitializeComponent();
            base.controleBase = this.txt;
            base.lblBase = this.lblDescricao;
            this.btnConfig.Tag = this;
        }

        [Category("HLP")]
        [Description("Tamanho Máximo")]
        public new int MaxLength
        {
            get { return txt.MaxLength; }
            set
            {
                //txt.TextBox.MaxLength = value;
                if (objConfigComponenteModel != null && objConfigComponenteModel.Base != null)
                {
                    if (value <= objConfigComponenteModel.Base.GetMaxLenghtNormal())
                        txt.TextBox.MaxLength = value;
                    else
                    {
                        value =  objConfigComponenteModel.Base.GetMaxLenghtNormal();
                        txt.TextBox.MaxLength = value;
                    }
                }
                else
                    txt.TextBox.MaxLength = value;

                string str = "".PadLeft(value, 'Z');
                int iSize = (int)CreateGraphics().MeasureString(str, txt.Font).Width;
                _TamanhoComponente = iSize > 600 ? 600 : (iSize < 50 ? 50 : iSize);
            }
        }
        [Category("HLP")]
        [Description("Habilita e desabilita o componente")]
        public new bool Enabled
        {
            get { return txt.TextBox.Enabled; }
            set
            {
                if (objConfigComponenteModel != null && objConfigComponenteModel.Base != null)
                {
                    if (objConfigComponenteModel.Base.NULLABLE == "0" && this.Text == "")
                    {
                        txt.TextBox.Enabled = true;
                    }
                    else
                        txt.TextBox.Enabled = value;
                }
                else
                    txt.TextBox.Enabled = value;
                //this.Enabled = txt.TextBox.Enabled;

                if ((!ReadOnly) && (!txt.TextBox.Enabled))
                {
                    this.TabStop = value;
                    if (value)
                    {
                        txt.StateNormal.Back.Color1 = Color;
                    }
                    else
                    {
                        txt.StateNormal.Back.Color1 = Color.FromArgb(226, 225, 230);
                    }
                }
            }
        }
        [Category("HLP")]
        [Description("Apenas leitura")]
        public bool ReadOnly
        {
            get { return txt.ReadOnly; }
            set
            {
                txt.ReadOnly = value;
                if (value)
                {
                    txt.StateNormal.Back.Color1 = Color.FromArgb(226, 225, 230);
                }
                else
                {
                    txt.StateNormal.Back.Color1 = Color;
                }
            }
        }
        [Category("HLP")]
        [Description("Varias Linhas")]
        public bool _Multiline
        {
            get { return txt.Multiline; }
            set
            {
                txt.Multiline = value;
                if (value)
                {
                    this.Height = 70;
                }
                else
                {
                    this.Height = 21;
                }
            }
        }
        [Category("HLP")]
        [Description("Desabilita leitura dos caracteres")]
        public bool _Password
        {
            get { return txt.UseSystemPasswordChar; }
            set
            {
                txt.UseSystemPasswordChar = value;
            }
        }
        [Category("HLP")]
        public override string Text
        {
            get { return txt.Text; }
            set
            {
                if (value.Length > this.MaxLength)
                    value = value.Substring(0, this.MaxLength);
                txt.Text = value;
            }
        }
        [Category("HLP")]
        [Description("Tipo de caracter.")]
        public CharacterCasing CharacterCasing
        {
            get { return txt.CharacterCasing; }
            set { txt.CharacterCasing = value; }
        }
        private Color _color = Color.White;
        [Category("HLP")]
        [Description("Cor do componente")]
        public Color Color
        {
            get { return _color; }
            set
            {
                if (value.ToArgb() != 16777215)
                {
                    _color = value;
                    txt.StateNormal.Back.Color1 = value;
                }
                else
                {
                    HLPMessageBox.ShowAviso("Cor inválida.");
                }
            }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                SendKeys.Send("{tab}");
            }
        }

        public event EventHandler _TextChanged;
        private void txt_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
            {
                _TextChanged(sender, e);
            }
        }

        public event EventHandler _Enter;
        private void txt_Enter(object sender, EventArgs e)
        {
            if (_Enter != null)
            {
                _Enter(sender, e);
            }
        }

        public event EventHandler _Leave;
        private void txt_Leave(object sender, EventArgs e)
        {
            if (_Leave != null)
            {
                _Leave(sender, e);
            }
        }

        private void HLP_TextBox_Load(object sender, EventArgs e)
        {
            if (!_Multiline)
            {
                this.Height = 21;
            }
            else
            {
                this.Height = 70;
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            //FormPopupConfig objFrm = new FormPopupConfig(this);
            //objFrm.ShowDialog(this);
        }

        public override void CarregaobjConfigComponenteModelByControle()
        {
            try
            {
                if (objConfigComponenteModel != null)
                {
                    objConfigComponenteModel.objConfigCompUsu.xColor = this._color.ToArgb().ToString();
                    objConfigComponenteModel.objConfigCompUsu.nMaxLength = this.MaxLength;
                    objConfigComponenteModel.objConfigCompUsu.xText = this.Text;
                    objConfigComponenteModel.objConfigCompUsu.stEnabled = this.Enabled.ToByte();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            base.CarregaobjConfigComponenteModelByControle();
        }

        public override void CarregaComponente()
        {
            base.CarregaComponente();

            try
            {
                if (objConfigComponenteModel != null)
                {
                    this._color = Color.FromArgb(objConfigComponenteModel.objConfigCompUsu.xColor.ToInt32());                    
                    this.Text = objConfigComponenteModel.objConfigCompUsu.xText;
                    this.Enabled = objConfigComponenteModel.objConfigCompUsu.stEnabled.ToBoolean();
                    this.MaxLength = objConfigComponenteModel.objConfigCompUsu.nMaxLength.ToInt32();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
