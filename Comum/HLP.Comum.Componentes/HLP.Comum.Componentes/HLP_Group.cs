using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using HLP.Comum.Infrastructure.Static;
namespace HLP.Comum.Components
{
    public partial class HLP_Group : KryptonHeaderGroup
    {
        public ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup buttonSpecHeaderGroup1;

        Size sizeGroup;
        FlowLayoutPanel flp = null;

        public HLP_Group()
        {
            InitializeComponent();
            this.Panel.ControlAdded += Panel_ControlAdded;
        }

        void Panel_ControlAdded(object sender, ControlEventArgs e)
        {

            if (e.Control.GetType() == typeof(FlowLayoutPanel))
            {
                flp = e.Control as FlowLayoutPanel;
                flp.AutoScroll = true;
                flp.VerticalScroll.Value = 0;
                flp.HorizontalScroll.Value = 0;
                flp.BackColor = Color.Transparent;
                flp.Dock = DockStyle.Fill;
                flp.FlowDirection = FlowDirection.TopDown;
                flp.ControlAdded += flp_ControlAdded;
                flp.AutoScroll = false;
                this.ConfigMaiorLabel();
            }
        }

        void flp_ControlAdded(object sender, ControlEventArgs e)
        {
            try
            {
                if (e.Control.GetType().BaseType == typeof(UserControlBase))
                {
                    if (this.PositionComponente == Posicao.TopDown)
                    {
                        e.Control.SetPropertyValue("_LabelSuperior", false);
                        if ( e.Control.GetType() == typeof(HLP_Button))
                        {
                            e.Control.Height = 24;
                        }
                        else
                        {
                            e.Control.Height = 22;
                        }
                        this.ConfigMaiorLabel();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void buttonSpecHeaderGroup1_Click(object sender, EventArgs e)
        {
            if (((ComponentFactory.Krypton.Toolkit.ButtonSpecAny)(sender)).Type == ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown)
            {
                sizeGroup = this.Size;
                this.Height = 24;
            }
            else
            {
                this.Size = sizeGroup;
            }
        }

        public List<UserControlBase> lControl
        {
            get
            {
                List<UserControlBase> lControl = new List<UserControlBase>();
                if (this.Panel.Controls.Count > 0)
                {
                    if (this.Panel.Controls[0].GetType() == typeof(FlowLayoutPanel))
                        lControl = this.Panel.Controls[0].Controls.OfType<UserControlBase>().ToList();
                }
                return lControl;

            }
        }
        private Posicao _positionComponente = Posicao.TopDown;

        [Category("HLP")]
        [Description("Muda a maneira em que o componente será visualizado e a Diereção do FlowLayoutPanel")]
        public Posicao PositionComponente
        {
            get { return _positionComponente; }
            set
            {
                _positionComponente = value;
                if (value == Posicao.LeftToRigth)
                {
                    if (lControl.Count > 0)
                    {
                        (this.Panel.Controls[0] as FlowLayoutPanel).FlowDirection = FlowDirection.LeftToRight;
                        foreach (UserControl ctr in lControl)
                        {
                            try
                            {
                                ctr.SetPropertyValue("_LabelSuperior", true);
                                ctr.SetPropertyValue("_TamanhoMaiorLabel", 0);
                            }
                            catch (Exception) { }
                        }

                    }
                }
                else
                {
                    if (lControl.Count > 0)
                    {
                        (this.Panel.Controls[0] as FlowLayoutPanel).FlowDirection = FlowDirection.TopDown;
                        foreach (UserControl ctr in lControl)
                        {
                            try
                            {
                                ctr.SetPropertyValue("_LabelSuperior", false);
                            }
                            catch (Exception) { }
                        }
                        ConfigMaiorLabel();
                    }


                }
            }
        }
        [Category("HLP")]
        [Description("Texto do Cabeçalho do Grupo.")]
        public string TextHeader
        {
            get { return this.ValuesPrimary.Heading; }
            set { this.ValuesPrimary.Heading = value; }
        }

        private void GetNameTabPage(Control value)
        {
            if (value.GetType() == typeof(TabPage))
            {
                sNameTabPage = value.Name;
            }
            else if (value.Parent != null)
            {
                GetNameTabPage(value.Parent);
            }
        }
        private string sNameTabPage = "";
        [Category("HLP")]
        [Description("TabPage em que o Componente se encontra.")]
        public string _sNameTabPage
        {
            get
            {
                sNameTabPage = "";
                GetNameTabPage(this);
                return sNameTabPage;
            }
        }

        public enum Posicao { LeftToRigth, TopDown }


        public void ConfigMaiorLabel()
        {
            try
            {
                if (lControl.Count() > 0)
                {
                    int iLabelMax = lControl.Max(c => c.GetPropertyValue("_TamanhoLabel")).ToInt32();
                    foreach (Control ctr in lControl)
                    {
                        ctr.SetPropertyValue("_TamanhoMaiorLabel", iLabelMax);
                    }
                    int iWidthMax = lControl.Select(m => (m.Width + m.Margin.Left)).Max();
                    //this.Width = iWidthMax + 25;                  

                    //if (iWidthMax > this.Width)
                    //{
                    //    flp.AutoScroll = true;
                    //    flp.VerticalScroll.Value = 0;
                    //    flp.HorizontalScroll.Value = 0;
                    //}
                    //else
                    //{
                    //    flp.AutoScroll = false;
                    //}

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao configurar maior label dos componentes");
            }


        }


        public void Add(Control ctr, int iPosition)
        {
            if (flp != null)
            {
                if (!flp.Controls.Contains(ctr))
                {
                    flp.Controls.Add(ctr);
                }
                flp.Controls.SetChildIndex(ctr, iPosition);
            }

        }

    }
}
