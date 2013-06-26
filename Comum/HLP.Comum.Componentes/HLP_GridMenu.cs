using System;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace HLP.Comum.Components
{
    public partial class HLP_GridMenu : UserControl
    {
        public HLP_GridMenu()
        {
            InitializeComponent();
        }


        private KryptonDataGridView _dataGridView;
        public KryptonDataGridView _DataGridView
        {
            get { return _dataGridView; }
            set
            {
                _dataGridView = value;
                _dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                _dataGridView.RowHeadersWidth = 15;
                _dataGridView.ReadOnly = true;
                _dataGridView.AllowUserToAddRows = false;
                _dataGridView.AllowUserToDeleteRows = false;
                _dataGridView.AllowUserToOrderColumns = false;
            }
        }

        public string _NomeForm { get; set; }




        public event EventHandler _btnIncluir_Click;
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (_btnIncluir_Click != null)
            {
                _btnIncluir_Click(sender, e);
            }
        }

        public event EventHandler _btnExcluir_Click;
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (_btnExcluir_Click != null)
            {
                _btnExcluir_Click(sender, e);
            }
        }

        public event EventHandler _btnAlterar_Click;
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (_btnAlterar_Click != null)
            {
                _btnAlterar_Click(sender, e);
            }
        }

        private void HLP_GridMenu_Load(object sender, EventArgs e)
        {
            this.btnIncluir.Size = new System.Drawing.Size(50, 25);
            this.btnExcluir.Size = new System.Drawing.Size(50, 25);
            this.btnAlterar.Size = new System.Drawing.Size(50, 25);
            this.Height = 30;
        }


    }
}
