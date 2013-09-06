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
using HLP.Comum.Messages;
using HLP.Comum.Infrastructure.Static;

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
            base.Initialize();
            this.ctxConfig.Tag = this;         // NEWCONFIG    
            lblBase.Click += lblBase_Click;    // NEWCONFIG        
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
        [Description("Tamanho Máximo")]
        public new int MaxLength
        {
            get { return txt.MaxLength; }
            set
            {
                txt.TextBox.MaxLength = value;
                if (bConfiguracao)
                {
                    if (objConfigComponenteModel != null && objConfigComponenteModel.Base != null)
                    {
                        if (value <= objConfigComponenteModel.Base.GetMaxLenghtNormal())
                            txt.TextBox.MaxLength = value;
                        else
                        {
                            value = objConfigComponenteModel.Base.GetMaxLenghtNormal();
                            txt.TextBox.MaxLength = value;
                        }
                    }
                }
                string str = "".PadLeft(value, 'Z');
                int iSize = (int)CreateGraphics().MeasureString(str, txt.Font).Width;
                iSize = iSize > 600 ? 600 : (iSize < 50 ? 50 : iSize);

                int iDiferenca = controleBase.Width - iSize;

                if (iDiferenca < 0)
                {
                    this.Width = this.Width + (iDiferenca * -1);
                }
                else if (iDiferenca > 0)
                {
                    this.Width = this.Width - iDiferenca;
                }
                this._TamanhoComponente = this._TamanhoComponente;
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
                if (bConfiguracao)
                {
                    if (objConfigComponenteModel != null && objConfigComponenteModel.Base != null)
                    {
                        if (objConfigComponenteModel.Base.NULLABLE == "0" && this.Text == "")
                        {
                            txt.TextBox.Enabled = true;
                        }
                    }
                }

                if (!ReadOnly)
                {
                    this.TabStop = txt.TextBox.Enabled;
                    if (txt.TextBox.Enabled)
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
                    //this.CharacterCasing = 
                    //controle.SetPropertyValue("CharacterCasing", (Upper ? CharacterCasing.Upper : CharacterCasing.Normal));
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            //contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
        }


        void InitializeComponentModoTopToDown()
        {
            int iTamanhoTxt = this.txt.Width;

            this.txt.Dock = System.Windows.Forms.DockStyle.Fill;

            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDescricao.Location = new System.Drawing.Point(0, 0);

            this.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.Size = new Size((lblBase.Width + iTamanhoTxt), 22);

            this.ResumeLayout(false);
            this.PerformLayout();




        }
        void InitializeComponentModoLeftToRigth()
        {

            int iWidth = this.txt.Width;
            // 
            // txt
            //            
            this.txt.Dock = System.Windows.Forms.DockStyle.Left;
            this.txt.Location = new System.Drawing.Point(0, 13);
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
            txt.Width = iWidth;
            this.Size = new Size(iWidth, 35);

            this.ResumeLayout(false);
            this.PerformLayout();



        }

    }
}
