using ComponentFactory.Krypton.Toolkit;
using HLP.Comum.UI;
using HLP.Models.Entries.Gerais;
using HLP.Services.Interfaces.Entries.Comercial;
using HLP.Services.Interfaces.Sales.Comercial;
using Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HLP.UI.Sales.Comercial
{
    public partial class formItensPorcAcimaLista : KryptonForm
    {
        [Inject]
        public IProdutoService produtoService { get; set; }

        public formItensPorcAcimaLista(List<ItemPorcAcimaListaModel> lItemPorcAcimaListaModel)
        {
            InitializeComponent();
            dgvItens.DataSource = lItemPorcAcimaListaModel;
        }

        private void btnPermitir__btnHlpClick(object sender, EventArgs e)
        {
            FormSenhaSupervisor frmSenhaSupervisor = new FormSenhaSupervisor();

            if (frmSenhaSupervisor.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancelar__btnHlpClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
