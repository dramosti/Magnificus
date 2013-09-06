using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HLP.Comum.Components
{
    public partial class HLP_Button : UserControlBase
    {
        public HLP_Button()
        {
            InitializeComponent();
            base.Initialize();
            base.controleBase = this.btn;
            base.lblBase = this.lblDescricao;

        }

        [Description("Habilita e desabilita o componente")]
        public new bool Enabled
        {
            get { return btn.Enabled; }
            set
            {
                btn.Enabled = value;
                this.TabStop = value;
            }
        }

        public event EventHandler _btnHlpClick;

        private void btn_btnHlpClick(object sender, EventArgs e)
        {
            if (_btnHlpClick != null)
            {
                _btnHlpClick(sender, e);
            }

        }

        [Category("HLP")]
        [Description("Label no modo superior ?")]
        public bool _LabelSuperior { get; set; }




    }
}
