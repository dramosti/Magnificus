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
using System.Reflection;
using System.Linq;

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
        }

        [Category("HLP")]
        [Description("Tamanho Máximo")]
        public new int MaxLength
        {
            get { return txt.MaxLength; }
            set
            {
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
                txt.TextBox.Enabled = value;
                if (!ReadOnly)
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
        public override string Text { get { return txt.Text; } set { txt.Text = value; } }
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
                _color = value;
                txt.StateNormal.Back.Color1 = value;
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

    }
}
