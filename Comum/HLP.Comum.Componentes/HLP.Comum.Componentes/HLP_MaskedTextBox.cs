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
using HLP.Comum.Infrastructure.Static;

namespace HLP.Comum.Components
{
    [ToolboxBitmap(typeof(MaskedTextBox))]
    public partial class HLP_MaskedTextBox : UserControlBase
    {


        public HLP_MaskedTextBox()
        {
            InitializeComponent();
            base.Initialize();
            controleBase = this.msk;
            lblBase = this.lblDescricao;
        }
        public enum TipoValidacao
        {
            DEFAULT,
            CNPJ,
            CPF,
            IE
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
        [Category("HLP")]
        public override string Text { get { return msk.Text; } set { msk.Text = value; } }
        private TipoValidacao _tpValidacao = TipoValidacao.DEFAULT;
        [Category("HLP")]
        public TipoValidacao _TpValidacao
        {
            get { return _tpValidacao; }
            set
            {
                _tpValidacao = value;
                if (_tpValidacao == TipoValidacao.CNPJ)
                {
                    this.Mask = "99,999,999/9999-99";
                }
                else if (_tpValidacao == TipoValidacao.CPF)
                {
                    this.Mask = "999,999,999-99";
                }
                else if (_tpValidacao == TipoValidacao.IE)
                {
                    this.Mask = "";
                }
            }
        }
        [Category("HLP")]
        public string _UF { get; set; }
        [Category("HLP")]
        public MaskFormat MaskFormat
        {
            get { return msk.TextMaskFormat; }
            set { msk.TextMaskFormat = value; }
        }
        [Category("HLP")]
        public new bool Enabled
        {
            get { return msk.MaskedTextBox.Enabled; }
            set
            {
                msk.MaskedTextBox.Enabled = value;
                if (!ReadOnly)
                {
                    this.TabStop = value;
                    if (value)
                    {
                        msk.StateNormal.Back.Color1 = Color;
                    }
                    else
                    {
                        msk.StateNormal.Back.Color1 = Color.FromArgb(226, 225, 230);
                    }
                }
            }
        }
        [Category("HLP")]
        public bool ReadOnly
        {
            get { return msk.ReadOnly; }
            set
            {
                msk.ReadOnly = value;
                if (value)
                {
                    msk.StateNormal.Back.Color1 = Color.FromArgb(226, 225, 230);
                }
                else
                {
                    msk.StateNormal.Back.Color1 = Color;
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
                msk.StateNormal.Back.Color1 = value;
            }
        }
        [Category("HLP")]
        public new int MaxLength
        {
            get { return msk.MaxLength; }
            set
            {
                msk.MaxLength = value;
                string str = "".PadLeft(value, 'Z');
                _TamanhoComponente = (int)CreateGraphics().MeasureString(str, msk.Font).Width;
            }
        }
        [Category("HLP")]
        public string Mask { get { return msk.Mask; } set { msk.Mask = value; } }

      

        private void msk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                SendKeys.Send("{tab}");
            }
        }
        public event EventHandler _TextChanged;
        private void msk_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
            {
                _TextChanged(sender, e);
            }
        }
        public event EventHandler _Enter;
        private void msk_Enter(object sender, EventArgs e)
        {
            if (_Enter != null)
            {
                _Enter(sender, e);
            }
        }
        public event EventHandler _Leave;
        private void msk_Leave(object sender, EventArgs e)
        {
            if (_Leave != null)
            {
                _Leave(sender, e);
            }
        }
        private void HLP_MaskedTextBox_Load(object sender, EventArgs e)
        {
            this.Height = 21;
        }

        public bool Valida()
        {
            bool bValida = false;
            if (this._tpValidacao == TipoValidacao.CNPJ)
            {
                bValida = Util.ValidaCnpj(this.Text);
            }
            else if (this._tpValidacao == TipoValidacao.CPF)
            {
                bValida = Util.ValidaCpf(this.Text);
            }
            else if (this._tpValidacao == TipoValidacao.IE)
            {
                bValida = Convert.ToBoolean(Util.ValidarInscricaoEstadual(this.Text, this._UF));
            }
            return bValida;
        }


        void InitializeComponentModoTopToDown()
        {
            int iTamanhoTxt = this.msk.Width;

            this.msk.Dock = System.Windows.Forms.DockStyle.Fill;

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
            int iWidth = this.msk.Width;
            // 
            // txt
            //            
            this.msk.Dock = System.Windows.Forms.DockStyle.Left;
            this.msk.Location = new System.Drawing.Point(0, 13);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDescricao.Location = new System.Drawing.Point(0, 0);
            // 
            // HLP_MASKTEXTBOX
            // 
            this.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);

            if (lblBase.Width > iWidth)
                iWidth = lblBase.Width;
            this.msk.Width = iWidth;
            this.Size = new Size(iWidth, 35);

            this.ResumeLayout(false);
            this.PerformLayout();



        }
    }
}
