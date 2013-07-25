using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using HLP.Comum.Infrastructure;
using HLP.Comum.Models;
using HLP.Comum.Models.Static;
using HLP.Comum.Messages;

namespace HLP.Comum.Components.Configuracao
{
    public partial class FormPopupConfig : KryptonForm
    {
        Control controle { get; set; }
        public bool bAlterou = false;

        public FormPopupConfig(Control objControle)
        {
            InitializeComponent();
            HLP_TXT txt = new HLP_TXT(objControle);
            this.controle = objControle;
            propertyConfig.SelectedObject = txt;

        }

        private void FormPopupConfig_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Control.MousePosition.X, Control.MousePosition.Y);
        }

        private class HLP_TXT : HLP_BASE
        {
            public HLP_TXT(Control objControle)
            {
                this.controle = objControle;
                this.objConfigComponenteModel = (objControle.GetPropertyValue("objConfigComponenteModel") as ConfigComponenteModel);
            }

            [Category("HLP")]
            [Description("Cor do componente")]
            public Color Color
            {
                get
                {
                    return (Color)this.controle.GetPropertyValue("Color");
                }
                set
                {
                    this.controle.SetPropertyValue("Color", value);
                }
            }

            [Category("HLP")]
            [Description("Tamanho do Componente.")]
            public int TamanhoComponente
            {
                get
                {
                    return this.controle.GetPropertyValue("_TamanhoComponente").ToInt32();
                }
            }

            [Category("HLP")]
            [Description("Tamanho Máximo")]
            public new int TamanhoMaximo
            {
                get
                {
                    return this.controle.GetPropertyValue("MaxLength").ToInt32();
                }
                set
                {

                    //if (objConfigComponenteModel != null && objConfigComponenteModel.Base != null)
                    //{
                    //    if (value <= objConfigComponenteModel.Base.GetMaxLenghtNormal())
                    //        this.controle.SetPropertyValue("MaxLength", value);
                    //    else
                    //        this.controle.SetPropertyValue("MaxLength", objConfigComponenteModel.Base.GetMaxLenghtNormal());
                    //}
                    //else
                    this.controle.SetPropertyValue("MaxLength", value);

                    //objConfigComponenteModel.objConfigCompUsu.nMaxLength = this.controle.GetPropertyValue("MaxLength").ToInt32();
                    //objConfigComponenteModel.objConfigCompUsu.iTamanhoComponente = this.controle.GetPropertyValue("_TamanhoComponente").ToInt32();
                }
            }

            [Category("HLP")]
            public string TextoPadrao
            {
                get
                {
                    return this.controle.GetPropertyValue("Text").ToString();
                }
                set
                {
                    this.controle.SetPropertyValue("Text", value);
                }
            }

        }

        private class HLP_BASE
        {
            [Browsable(false)]
            [Bindable(true)]
            public Control controle { get; set; }
            [Browsable(false)]
            [Bindable(true)]
            public ConfigComponenteModel objConfigComponenteModel { get; set; }


            [Category("HLP")]
            [Description("Texto do Label")]
            [DefaultValue("")]
            public string Descricao
            {
                get
                {
                    return this.controle.GetPropertyValue("_LabelText").ToString();
                }
                set
                {
                    this.controle.SetPropertyValue("_LabelText", value);
                }
            }


            [Category("HLP")]
            [Description("Help do Componente")]
            [DefaultValue("")]
            public string Ajuda
            {
                get
                {
                    return this.controle.GetPropertyValue("_Help").ToString();
                }
                set
                {
                    this.controle.SetPropertyValue("_Help", value);
                }
            }

            [Category("HLP")]
            [Description("Indica se o componente estará visível para o Usuário")]
            [DefaultValue(true)]
            public virtual bool Visivel
            {
                get
                {
                    return controle.Visible;
                }
                set
                {
                    controle.SetPropertyValue("_Visible", value);
                }
            }


            [Category("HLP")]
            [Description("Habilita e desabilita o componente")]
            public new bool Habilitado
            {
                get
                {
                    return Convert.ToBoolean(this.controle.GetPropertyValue("Enabled"));
                }
                set
                {
                    this.controle.SetPropertyValue("Enabled", value);
                }
            }

            [Category("HLP BASE DE DADOS")]
            [Description("Nome da tabela")]
            public string Tabela
            {
                get
                {
                    if (objConfigComponenteModel.Base != null)
                        return objConfigComponenteModel.Base.TABLE_NAME.ToUpper();
                    else
                        return "";
                }
            }

            [Category("HLP BASE DE DADOS")]
            [Description("Nome do campo")]
            public string Campo
            {
                get
                {
                    if (objConfigComponenteModel.Base != null)
                        return objConfigComponenteModel.xField.ToUpper();
                    else
                        return "";
                }
            }
            [Category("HLP BASE DE DADOS")]
            [Description("Campo é obrigatório?")]
            public string Obrigatório
            {
                get
                {
                    if (objConfigComponenteModel.Base != null)
                        return objConfigComponenteModel.Base.GetObrigatoriedade();
                    else
                        return "";
                }
            }
            [Category("HLP BASE DE DADOS")]
            [Description("Tamanho máximo suportado.")]
            public string Tamanho
            {
                get
                {
                    if (objConfigComponenteModel.Base != null)
                        return objConfigComponenteModel.Base.PRECISION;
                    else
                        return "";
                }
            }
            [Category("HLP BASE DE DADOS")]
            [Description("Número de casas decimais.")]
            public string Decimais
            {
                get
                {
                    if (objConfigComponenteModel.Base != null)
                        return objConfigComponenteModel.Base.SCALE;
                    else
                        return "";
                }
            }
            [Category("HLP BASE DE DADOS")]
            [Description("Tipo do campo.")]
            public string Type
            {
                get
                {
                    if (objConfigComponenteModel.Base != null)
                        return objConfigComponenteModel.Base.TYPE_NAME.ToUpper();
                    else
                        return "";
                }
            }



        }

        private void FormPopupConfig_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                UserControlBase obj = controle as UserControlBase;

                if (HLPMessageBox.MsgSalvar())
                {
                    obj.CarregaobjConfigComponenteModelByControle();
                    bAlterou = true;
                }
                else
                {
                    obj.CarregaComponente();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
