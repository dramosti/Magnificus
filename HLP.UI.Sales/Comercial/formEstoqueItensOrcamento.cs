using ComponentFactory.Krypton.Toolkit;
using HLP.Models.Sales.Comercial;
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
    public partial class formEstoqueItensOrcamento : KryptonForm
    {
        public formEstoqueItensOrcamento(List<stItensModel> lItens, DataGridViewComboBoxColumn clProdutos)
        {
            InitializeComponent();
            this.clProduto.DataSource = clProdutos.DataSource;
            this.clProduto.DisplayMember = clProdutos.DisplayMember;
            this.clProduto.ValueMember = clProdutos.ValueMember;
            bsItens.DataSource = lItens;
        }
    }
}
