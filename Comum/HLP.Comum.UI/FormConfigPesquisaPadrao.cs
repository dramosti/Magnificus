using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using HLP.Comum.Models;
using System.Linq;
using Ninject;
using HLP.Comum.Services.Interface;
using HLP.Dependencies;
using HLP.Comum.Infrastructure;
using HLP.Comum.Services.Interface.Configuracao;

namespace HLP.Comum.UI
{
    public partial class FormConfigPesquisaPadrao : KryptonForm
    {
        public bool Alterou = false;
        private Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;
        private int rowIndexOfItemUnderMouseToDrop;
        List<CONFIG_PesquisaModel> lFilter = new List<CONFIG_PesquisaModel>();
        List<CONFIG_PesquisaModel> lData = new List<CONFIG_PesquisaModel>();

        public ConfigFormulariosModel configFormularioModel { get; set; }

        public FormConfigPesquisaPadrao(ConfigFormulariosModel configFormularioModel)
        {
            InitializeComponent();
            this.configFormularioModel = configFormularioModel;
            foreach (var item in configFormularioModel.lPesquisa.Where(c => c.xField != "idEmpresa").OrderBy(c => c.iOrderFilter).ToList())
            {
                lFilter.Add(item);
            }
            foreach (var item in configFormularioModel.lPesquisa.Where(c => c.xField != "idEmpresa").OrderBy(c => c.iOrderData).ToList())
            {
                lData.Add(item);
            }
            cboGrid.SelectedIndex = 0;
        }


        private void cboGrid__SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGrid.SelectedIndex == 0)
            {
                Save();
                dgvCampos.Tag = 0;
                CarregaItensFiltro();
            }
            else
            {
                Save();
                dgvCampos.Tag = 1;
                CarregaItensDados();
            }
        }

        private void CarregaItensDados()
        {
            dgvCampos.Rows.Clear();
            for (int i = 0; i < lData.Count(); i++)
            {
                dgvCampos.Rows.Add();
                ConfigComponenteModel comp = configFormularioModel.lobjConfigComponente.FirstOrDefault(C => C.xField == lData[i].xField);

                dgvCampos["Campo", i].Value = lData[i].xField == "ID" ? "Código" : (comp != null ? comp.objConfigCompUsu.xLabelText : lData[i].xField);
                dgvCampos["Utiliza", i].Value = lData[i].stData;
                dgvCampos["Field", i].Value = lData[i].xField;
            }
        }
        private void CarregaItensFiltro()
        {
            dgvCampos.Rows.Clear();
            for (int i = 0; i < lFilter.Count(); i++)
            {
                dgvCampos.Rows.Add();
                ConfigComponenteModel comp = configFormularioModel.lobjConfigComponente.FirstOrDefault(C => C.xField == lFilter[i].xField);

                dgvCampos["Campo", i].Value = lFilter[i].xField == "ID" ? "Código" : (comp != null ? comp.objConfigCompUsu.xLabelText : lFilter[i].xField);
                dgvCampos["Utiliza", i].Value = lFilter[i].stFilter;
                dgvCampos["Field", i].Value = lFilter[i].xField;
            }
        }


        private void dgvCampos_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                if (dragBoxFromMouseDown != Rectangle.Empty &&
          !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {
                    DragDropEffects dropEffect = dgvCampos.DoDragDrop(dgvCampos.Rows[rowIndexFromMouseDown], DragDropEffects.Move);
                }
            }
        }
        private void dgvCampos_MouseDown(object sender, MouseEventArgs e)
        {
            rowIndexFromMouseDown = dgvCampos.HitTest(e.X, e.Y).RowIndex;
            if (rowIndexFromMouseDown != -1)
            {
                Size dragSize = SystemInformation.DragSize;

                dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2),
                                                               e.Y - (dragSize.Height / 2)),
                                                        dragSize);
            }
            else
                dragBoxFromMouseDown = Rectangle.Empty;
        }
        private void dgvCampos_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        private void dgvCampos_DragDrop(object sender, DragEventArgs e)
        {
            Point clientPoint = dgvCampos.PointToClient(new Point(e.X, e.Y));
            rowIndexOfItemUnderMouseToDrop =
            dgvCampos.HitTest(clientPoint.X, clientPoint.Y).RowIndex;

            if (e.Effect == DragDropEffects.Move)
            {
                DataGridViewRow rowToMove = e.Data.GetData(typeof(DataGridViewRow)) as DataGridViewRow;
                if (rowIndexOfItemUnderMouseToDrop > -1)
                {
                    dgvCampos.Rows.RemoveAt(rowIndexFromMouseDown);
                    dgvCampos.Rows.Insert(rowIndexOfItemUnderMouseToDrop, rowToMove);
                    dgvCampos.CurrentCell = dgvCampos[0, rowIndexOfItemUnderMouseToDrop];
                }
            }
        }


        private void dgvCampos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                SendKeys.Send("{left}");
                SendKeys.Send("{right}");
            }
        }

        private void Save()
        {
            if (dgvCampos.RowCount > 0)
            {
                CONFIG_PesquisaModel f = null;
                if ((int)dgvCampos.Tag == 0)
                {

                    lFilter = new List<CONFIG_PesquisaModel>();
                    for (int i = 0; i < dgvCampos.RowCount; i++)
                    {
                        string sCampo = dgvCampos["Field", i].Value.ToString();
                        f = new CONFIG_PesquisaModel();
                        f.xField = sCampo;
                        f.iOrderFilter = i + 1;
                        f.stFilter = Convert.ToBoolean(dgvCampos["Utiliza", i].Value);
                        lFilter.Add(f);
                    }
                }
                else
                {
                    lData = new List<CONFIG_PesquisaModel>();
                    for (int i = 0; i < dgvCampos.RowCount; i++)
                    {
                        string sCampo = dgvCampos["Field", i].Value.ToString();
                        f = new CONFIG_PesquisaModel();
                        f.xField = sCampo;
                        f.iOrderData = i + 1;
                        f.stData = Convert.ToBoolean(dgvCampos["Utiliza", i].Value);
                        lData.Add(f);
                    }
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Save();
            for (int i = 0; i < lFilter.Count; i++)
            {
                CONFIG_PesquisaModel f = configFormularioModel.lPesquisa.FirstOrDefault(C => C.xField == lFilter[i].xField);
                f.stFilter = lFilter[i].stFilter;
                f.iOrderFilter = lFilter[i].iOrderFilter;
            }
            for (int i = 0; i < lData.Count; i++)
            {
                CONFIG_PesquisaModel f = configFormularioModel.lPesquisa.FirstOrDefault(C => C.xField == lData[i].xField);
                f.stData = lData[i].stData;
                f.iOrderData = lData[i].iOrderData;
            }
            Alterou = true;
            this.Close();
        }

        private void FormConfigPesquisaPadrao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }



    }
}