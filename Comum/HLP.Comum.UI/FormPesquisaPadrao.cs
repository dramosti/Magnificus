using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using HLP.Comum.Messages;
using HLP.Comum.Models;
using HLP.Comum.Models.Static;
using HLP.Comum.Modules;
using HLP.Comum.Services.Interface.Configuracao;
using HLP.Dependencies;
using Ninject;
using HLP.Comum.UI.Exception;
using HLP.Comum.Infrastructure;
using HLP.Comum.Services.Interface;

namespace HLP.Comum.UI
{
    public partial class FormPesquisaPadrao : KryptonForm
    {
        [Inject]
        public IPesquisaPadraoService pesquisaPadraoService { get; set; }
        [Inject]
        public IConfigFormulariosService iConfigFormulariosService { get; set; }

        /// <summary>
        /// Objeto ref. a configuração salva da Grid
        /// </summary>
        [Inject]
        public IConfigPesquisaService iConfigPesquisa { get; set; }

        public string sNomeForm { get; set; }
        public string sView { get; set; }

        public string ValorComponentePesquisa = "";
        public bool Alterou = false;
        private bool bCarregaTela = false;
        private bool FiltroAtivo = false;
        private RelatoriosModel _objRelatorio = null;
        public RelatoriosModel objRelatorio
        {
            get { return _objRelatorio; }
            set { _objRelatorio = value; }
        }
        List<PesquisaPadraoModel> listInformation = null;
        private ConfigFormulariosModel configFormularioModel { get; set; }
        public List<int> ListIdSelecionados = new List<int>();
        public List<string> sListComponentePesquisa = new List<string>();

        int iUltimaPk = 0;
        bool blnEmSelec = false;

        string[] listaInt = new string[] { "Igual a", "Entre", "Não Entre", "Na Lista", "Não na Lista", "Diferente que", "Maior que", "Maior Igual que", "Menor que", "Menor Igual que" };
        string[] listaString = new string[] { "Igual a", "Igual na Frase", "Começando com", "Diferente que", "Branco", "Não Branco" };
        string[] listaDecimal = new string[] { "Igual a", "Entre", "Não Entre", "Na Lista", "Não na Lista", "Diferente que", "Maior que", "Maior Igual que", "Menor que", "Menor Igual que" };
        string[] listaData = new string[] { "Igual a", "Maior que", "Maior Igual que", "Menor que", "Menor Igual que", "Entre", "Não Entre", "Diferente que" };
        string[] listaBool = new string[] { "Igual a" };

        public FormPesquisaPadrao(ConfigFormulariosModel configFormularioModel, bool bCarregaTela = false, bool FiltroAtivo = false)
        {
            InitializeComponent();
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
            this.configFormularioModel = configFormularioModel;
            this.sView = configFormularioModel.xNameView;
            this.sNomeForm = configFormularioModel.xNameFormulario;
            this.bCarregaTela = bCarregaTela;
            this.FiltroAtivo = FiltroAtivo;

            if (sNomeForm != "")
            {
                //btnConfigurar.Visible = false;
                btnCadastrar.Visible = true;
                this.sNomeForm = sNomeForm;

            }
            else
            {
                btnNovo.Visible = true;
            }
            if (configFormularioModel != null)
            {
                this.Text = "Pesquisa - " + this.configFormularioModel.objConfigFormUsu.xText;
            }
            //else
            //{
            //    //btnConfigurar.Visible = false;
            //}


        }

        private void FormPesquisaPadrao_Load(object sender, EventArgs e)
        {
            if (objRelatorio != null)
            {
                btnImprimir.Visible = true;
            }

            listInformation = pesquisaPadraoService.GetTableInformation(sView);
            GeraGridFiltro();
            GeraGridDados();
            if (configFormularioModel.lPesquisa != null)
            {
                if (configFormularioModel.lPesquisa.OrderBy(C => C.iOrderFilter).Where(C => C.stFilter == true).Count() > 0)
                {
                    CONFIG_PesquisaModel f = configFormularioModel.lPesquisa.OrderBy(C => C.iOrderFilter).First(C => C.stFilter == true);
                    if (f != null)
                    {
                        for (int i = 0; i < dgvFiltro.RowCount; i++)
                        {
                            if (dgvFiltro["COLUMN_NAME", i].Value.ToString() == f.xField)
                            {
                                if (dgvFiltro["Valor", i].Visible)
                                {
                                    dgvFiltro.CurrentCell = dgvFiltro.Rows[0].Cells["Valor"];
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            if (bCarregaTela)
            {
                btnAplica_Click(null, null);
            }
            if (dgvDados.RowCount > 0)
            {
                iUltimaPk = Convert.ToInt32(dgvDados["ID", dgvDados.RowCount - 1].Value);
            }
        }

        #region Botoes e eventos

        private void dgvFiltro_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if ((dgvFiltro.Columns[e.ColumnIndex].Name == "Valor") && (dgvFiltro.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null) && (dgvFiltro.IsCurrentCellInEditMode))
                {
                    if ((dgvFiltro.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != ""))
                    {
                        string[] modifc = new string[2];

                        modifc = ValidaCell(e.RowIndex, dgvFiltro.Rows[e.RowIndex].Cells["Valor"].Value.ToString());

                        dgvFiltro.Rows[e.RowIndex].Cells["Valor"].Value = (modifc[1] != null ? modifc[1].ToString() : dgvFiltro.Rows[e.RowIndex].Cells["Valor"].Value);
                        dgvFiltro.Rows[e.RowIndex].Cells["Operador"].Value = (modifc[0] != null ? modifc[0].ToString() : dgvFiltro.Rows[e.RowIndex].Cells["Operador"].Value);

                        if (dgvFiltro.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Contains('-'))
                        {
                            string[] valores = dgvFiltro.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Split('-');
                            string stipo = dgvFiltro["DATA_TYPE", e.RowIndex].Value.ToString();
                            object[] order = new object[2];
                            Type tipo = (stipo == "int" ? typeof(Int32) :
                                (stipo == "datetime" ? typeof(DateTime) :
                                (stipo == "float" ? typeof(float) :
                                (stipo == "decimal" ? typeof(Decimal) : typeof(Nullable)))));
                            if (tipo != typeof(Nullable))
                            {
                                foreach (var item in valores)
                                {
                                    if (order[0] == null)
                                    {
                                        order[0] = item;
                                    }
                                    else if (order[0] != null)
                                    {
                                        if (tipo == typeof(DateTime))
                                        {
                                            pesquisaPadraoService.ValidValue(order[0].ToString(), "datetime");
                                            pesquisaPadraoService.ValidValue(item, "datetime");
                                            if (Convert.ToDateTime(order[0]) >= Convert.ToDateTime(item))
                                            {
                                                order[1] = order[0];
                                                order[0] = item;
                                            }
                                            else if (tipo == typeof(DateTime))
                                            {
                                                if (Convert.ToDateTime(order[0]) <= Convert.ToDateTime(item))
                                                {
                                                    order[1] = item;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            pesquisaPadraoService.ValidValue(order[0].ToString(), "decimal");
                                            pesquisaPadraoService.ValidValue(item, "decimal");
                                            if (Convert.ToDecimal(order[0]) >= Convert.ToDecimal(item))
                                            {
                                                order[1] = order[0];
                                                order[0] = item;
                                            }
                                            else if (Convert.ToDecimal(order[0]) <= Convert.ToDecimal(item))
                                            {
                                                order[1] = item;
                                            }
                                        }
                                    }
                                }
                            }
                            dgvFiltro.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = order[0].ToString() + "-" + order[1].ToString();
                        }
                    }
                }
                if ((dgvFiltro.Columns[e.ColumnIndex].Name == "Valor") &&
                    ((dgvFiltro.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null) || dgvFiltro.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != "")
                     && (dgvFiltro.IsCurrentCellInEditMode))
                {
                    btnAplica_Click(sender, e);
                }
                else if (dgvFiltro.Columns[e.ColumnIndex].Name == "Operador")
                {
                    if (dgvFiltro.Rows[e.RowIndex].Cells["Operador"].Value.ToString() == "Branco")
                    {
                        dgvFiltro.Rows[e.RowIndex].Cells["Valor"].Value = "\"\"";
                    }
                    else if (dgvFiltro.Rows[e.RowIndex].Cells["Operador"].Value.ToString() == "Não Branco")
                    {
                        dgvFiltro.Rows[e.RowIndex].Cells["Valor"].Value = "\"\"";
                    }
                }
            }
            catch (System.Exception ex)
            {
                KryptonMessageBox.Show(ex.Message, Mensagens.MSG_Aviso, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dgvFiltro_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {
                if ((dgvFiltro.Columns[e.ColumnIndex].Name == "Valor") && (e.FormattedValue.ToString() != string.Empty) && (dgvFiltro.IsCurrentCellInEditMode))
                {
                    string Tipo = dgvFiltro.Rows[e.RowIndex].Cells["DATA_TYPE"].Value.ToString();
                    Regex IsInt = new Regex("(([!]?)(([0-9]+[-|;])?)|([<|>|!|&|\"\"|=|>=|<=]?))([0-9]+)$");
                    if (!IsInt.IsMatch(e.FormattedValue.ToString()) && (Tipo == "int"))
                    {
                        e.Cancel = true;

                        KryptonMessageBox.Show(null, "Esse Campo é numérico inteiro. Não digite letras ou valores numéricos com vírgula.", Mensagens.MSG_Aviso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    string[] Ncontem = { ">", "<", "<=", ">=" };


                    if (Tipo.Equals("string") || Tipo.Equals("char") || Tipo.Equals("varchar") || Tipo.Equals("nvarchar"))
                    {
                        bool tag = false;
                        foreach (var item in Ncontem)
                        {
                            if (e.FormattedValue.ToString().StartsWith(item))
                            {
                                tag = true;
                                break;
                            }
                        }
                        if (tag == true)
                        {
                            e.Cancel = true;

                            KryptonMessageBox.Show(null, "Esse campo nao pode iniciar com caracteres que interfiram em operações. " + Environment.NewLine +
                                                 "Esses caracteres são \">\", \"<\", \"<=\", \">=\"", Mensagens.MSG_Aviso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

            }
            catch (System.Exception ex)
            {
                KryptonMessageBox.Show(null, ex.Message, Mensagens.MSG_Aviso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
        }
        private void dgvDados_DataSourceChanged(object sender, EventArgs e)
        {
            if (dgvDados.Columns["idEmpresa"] != null)
            {
                dgvDados.Columns["idEmpresa"].Visible = false;
            }
            int iCount = dgvDados.Rows.Count;
            if (iCount > 0)
            {
                lblTotalRegistros.Text = dgvDados.Rows.Count.ToString() + " registro" + (iCount == 1 ? "" : "s") + " encontrado" + (iCount == 1 ? "" : "s");
            }
            else
            {
                lblTotalRegistros.Text = "Nenhum registro encontrado";
            }
        }
        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    for (int i = 0; i < dgvDados.ColumnCount; i++)
                    {
                        if (dgvDados.Columns[i].Name == "ID")
                        {
                            ListIdSelecionados.Add(Convert.ToInt32(dgvDados.CurrentRow.Cells[i].Value));
                            ConcatenaValoresComponentePesquisa();
                            break;
                        }
                    }
                    this.Close();
                }
            }
            catch (System.Exception ex)
            {
                new HLPexception(ex);
            }
        }
        private void dgvDados_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 9)
            {
                if (dgvDados.RowCount > 0)
                {
                    ListIdSelecionados = new List<int>();
                    try
                    {
                        if (dgvDados.CurrentRow.Index >= 0)
                        {
                            if (sListComponentePesquisa.Count() > 0)
                            {
                                for (int i = 0; i < dgvDados.SelectedRows.Count; i++)
                                {
                                    ListIdSelecionados.Add(Convert.ToInt32(dgvDados.SelectedRows[i].Cells["ID"].Value));
                                    ConcatenaValoresComponentePesquisa();
                                }
                            }
                            else
                            {
                                ListIdSelecionados = (from c in dgvDados.SelectedRows.Cast<DataGridViewRow>()
                                                      select (int)c.Cells["ID"].Value).ToList();
                            }
                            ListIdSelecionados.Sort();
                            this.Close();
                        }
                    }
                    catch (System.Exception ex)
                    {
                        new HLPexception(ex);
                    }
                }

            }
            if (e.KeyValue == 17)
            {
                blnEmSelec = true;
            }
        }
        private void dgvDados_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyValue == 17)
                {
                    List<PesquisaPadraoModel> lSelecionados = new List<PesquisaPadraoModel>();
                    blnEmSelec = false;

                    for (int i = 0; i < dgvDados.ColumnCount; i++)
                    {
                        if (Convert.ToString(dgvDados.Columns[i].HeaderCell.Tag) == "1")
                        {
                            lSelecionados.Add(listInformation.FirstOrDefault(C => C.COLUMN_NAME == dgvDados.Columns[i].DataPropertyName));
                        }

                        dgvDados.Columns[i].HeaderCell.Tag = "";
                    }
                    if (lSelecionados.Count > 0)
                    {
                        FormPesquisaPadraoHeaderCell frm = new FormPesquisaPadraoHeaderCell(lSelecionados, sView);
                        frm.ShowDialog();
                        if (frm.sql != "")
                        {
                            try
                            {
                                DataTable dt = pesquisaPadraoService.GetData(frm.sql.ToString());
                                OrdenaColunasDataTable(dt);
                                dgvDados.DataSource = dt;
                            }
                            catch (SqlException ex)
                            {
                                if (ex.Number == 245)
                                {
                                    KryptonMessageBox.Show("Não foi possível efetuar a pesquisa porque um ou mais valores inseridos não é coerente com o tipo de dado.", Mensagens.MSG_Aviso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                new HLPexception(ex);
            }

        }
        private void dgvDados_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (blnEmSelec == true)
                {
                    dgvDados.Columns[e.ColumnIndex].HeaderCell.Tag = "1";
                }
                else
                {
                    blnEmSelec = false;
                    List<PesquisaPadraoModel> lSelecionados = new List<PesquisaPadraoModel>();
                    lSelecionados.Add(listInformation.FirstOrDefault(C => C.COLUMN_NAME == dgvDados.Columns[e.ColumnIndex].DataPropertyName));
                }
            }
            catch (System.Exception ex)
            {
                new HLPexception(ex);
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvDados.DataSource = null;
                lblTotalRegistros.Text = "";
                dgvDados.Rows.Clear();
                GeraGridDados();
                for (int i = 0; i < dgvFiltro.RowCount; i++)
                {
                    dgvFiltro.Rows[i].Cells["Valor"].Value = null;
                }
            }
            catch (System.Exception ex)
            {

                new HLPexception(ex);
            }
        }
        private void btnAplica_Click(object sender, EventArgs e)
        {
            try
            {
                dgvFiltro.EndEdit();
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM " + sView);

                List<string> sExpression = new List<string>();
                if (listInformation.Where(C => C.COLUMN_NAME == "idEmpresa").Count() > 0)
                {
                    sExpression.Add("(idEmpresa = " + CompanyData.idEmpresa + ")");
                    sExpression.Add("AND");
                }
                if (FiltroAtivo)
                {
                    if (listInformation.Where(C => C.COLUMN_NAME == "Ativo").Count() > 0)
                    {
                        sExpression.Add("(Ativo = 1)");
                        sExpression.Add("AND");
                    }
                }
                for (int i = 0; i < dgvFiltro.RowCount; i++)
                {
                    if (dgvFiltro.Rows[i].Cells["Valor"].Value != null)
                    {
                        if (dgvFiltro.Rows[i].Cells["Valor"].Value.ToString() != "")
                        {
                            string sTipo = dgvFiltro.Rows[i].Cells["DATA_TYPE"].Value.ToString();
                            string sCampo = dgvFiltro.Rows[i].Cells["COLUMN_NAME"].Value.ToString();
                            string sValor = dgvFiltro.Rows[i].Cells["Valor"].Value.ToString();
                            string sOperador = dgvFiltro.Rows[i].Cells["Operador"].Value.ToString();

                            sExpression.Add("(" + sCampo + " " + pesquisaPadraoService.GetFilter(sValor, sOperador, sCampo, sTipo) + ")");
                            string inner = dgvFiltro.Rows[i].Cells["EOU"].Value.ToString();
                            if (dgvFiltro.RowCount - 1 != i)
                            {
                                sExpression.Add(inner == "E" ? "AND" : "OR");
                            }
                        }
                    }
                }

                if (sExpression.Count() > 0)
                {
                    sql.Append(" WHERE ");

                    if (sExpression[sExpression.Count() - 1] == "AND" || sExpression[sExpression.Count() - 1] == "OR")
                    {
                        sExpression.RemoveAt(sExpression.Count() - 1);
                    }
                    foreach (string s in sExpression)
                    {
                        sql.Append(s + " ");
                    }
                }
                DataTable dt = pesquisaPadraoService.GetData(sql.ToString());
                OrdenaColunasDataTable(dt);
                dgvDados.DataSource = dt;
            }
            catch (System.Exception ex)
            {
                KryptonMessageBox.Show(ex.Message, Mensagens.MSG_Aviso, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                GerenciadorModulo.Instancia.ExibirForm(sNomeForm, TipoExibeForm.Modal);

                BuscaTodosRegistros(iUltimaPk.ToString());
                if (dgvDados.RowCount == 0)
                {
                    btnAplica_Click(sender, e);
                }
                if (dgvDados.RowCount == 0)
                {
                    BuscaTodosRegistros((0).ToString());
                }
                dgvDados.Focus();
            }
            catch (System.Exception ex)
            {
                new HLPexception(ex);
            }
        }
        private void FormPesquisaPadrao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        private void exportarConteudoPExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDados.RowCount > 0)
                {
                    Util.ExportarExcel(dgvDados);
                }
            }
            catch (System.Exception ex)
            {
                new HLPexception(ex);
            }
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnNovo.Tag = "1";
            this.Close();
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string sTextFiltro = "";

            try
            {
                int count = 0;
                foreach (PesquisaPadraoModel item in (dgvFiltro.DataSource as List<PesquisaPadraoModel>))
                {
                    if (item.Valor != null)
                    {
                        sTextFiltro += ((count > 0 ? " " + item.EOU : "") + " " +
                            item.COLUMN_NAME + " " +
                            item.Operador + " '" +
                            item.Valor + "' ").ToUpper();
                    }
                    count++;
                }
                sTextFiltro = "\"TRAZER REGISTROS ONDE " + sTextFiltro + " ;\"";
                ConfigFormulariosModel objformulario = iConfigFormulariosService.GetFormulario(objRelatorio.idFormularios.ToInt32());
                string strTabelaPrincipal = objformulario.xTable;
                string strColuna = pesquisaPadraoService.GetIdentityColumnName(strTabelaPrincipal);
                string sFormula = ParametroRelatorio(strColuna, strTabelaPrincipal);
                sTextFiltro = sTextFiltro.Replace(" ID ", " " + strColuna + " ").ToUpper();
                FormPreviewReport frm = new FormPreviewReport(sTextFiltro, sFormula, objRelatorio);
                frm.ShowDialog();


            }
            catch (System.Exception)
            {
            }
        }
        #endregion

        #region Metodos
        private void OrdenaColunasDataTable(DataTable dt)
        {
            for (int i = 0; i < dgvDados.ColumnCount; i++)
            {
                dt.Columns[dgvDados.Columns[i].DataPropertyName].SetOrdinal(i);
            }
        }
        private void ConcatenaValoresComponentePesquisa()
        {

            for (int i = 0; i < sListComponentePesquisa.Count; i++)
            {
                if (dgvDados.Rows[dgvDados.CurrentRow.Index].Cells[sListComponentePesquisa[i]].Value != null)
                {
                    ValorComponentePesquisa = i + 1 == sListComponentePesquisa.Count ?
                        ValorComponentePesquisa + dgvDados.Rows[dgvDados.CurrentRow.Index].Cells[sListComponentePesquisa[i]].Value.ToString() :
                        ValorComponentePesquisa + dgvDados.Rows[dgvDados.CurrentRow.Index].Cells[sListComponentePesquisa[i]].Value.ToString() + " - ";
                }
            }

        }
        public string[] ValidaCell(int intRowIndex, string strValor)
        {

            string[] ret = new string[2];

            if (strValor.StartsWith("!"))
            {
                ret[0] = "Diferente que";

                ret[1] = strValor.Remove(strValor.IndexOf("!"), 1).Trim();
            }
            else if (strValor.StartsWith("="))
            {
                ret[0] = "Igual a";

                ret[1] = strValor.Remove(strValor.IndexOf("="), 1).Trim();
            }
            else if (strValor.StartsWith(">="))
            {
                ret[0] = "Maior Igual que";

                ret[1] = strValor.Remove(strValor.IndexOf(">="), 2).Trim();
            }
            else if (strValor.StartsWith("<="))
            {
                ret[0] = "Menor Igual que";

                ret[1] = strValor.Remove(strValor.IndexOf("<="), 2).Trim();
            }
            else if (strValor.StartsWith(">"))
            {
                ret[0] = "Maior que";

                ret[1] = strValor.Remove(strValor.IndexOf(">"), 1).Trim();
            }
            else if (strValor.StartsWith("<"))
            {
                ret[0] = "Menor que";

                ret[1] = strValor.Remove(strValor.IndexOf("<"), 1).Trim();
            }
            else if ((strValor.Contains(";")) && (!strValor.StartsWith("!")))
            {
                ret[0] = "Na Lista";

                ret[1] = strValor;
            }
            else if ((strValor.Contains(";")) && (strValor.StartsWith("!")))
            {
                ret[0] = "Não na Lista";

                ret[1] = strValor.Remove(strValor.IndexOf("!"), 1).Trim();
            }
            else if ((strValor.Contains("-")) && (!strValor.StartsWith("!")))
            {
                ret[0] = "Entre";

                ret[1] = strValor;
            }
            else if ((strValor.Contains("-")) && (strValor.StartsWith("!")))
            {
                ret[0] = "Não Entre";

                ret[1] = strValor.Remove(strValor.IndexOf("!"), 1).Trim();
            }
            else if (strValor.StartsWith("&"))
            {
                ret[0] = "Igual na Frase";

                ret[1] = strValor.Remove(strValor.IndexOf("&"), 1).Trim();
            }
            else if (strValor == "\"\"")
            {
                ret[0] = "Branco";

                ret[1] = strValor;
            }
            else if (strValor == "!\"\"")
            {
                ret[0] = "Não Branco";

                ret[1] = strValor;
            }

            return ret;
        }
        private void GeraGridFiltro()
        {

            List<PesquisaPadraoModel> lOrder = new List<PesquisaPadraoModel>();
            if (configFormularioModel != null)
            {
                foreach (CONFIG_PesquisaModel item in configFormularioModel.lPesquisa.OrderBy(C => C.iOrderFilter))
                {
                    lOrder.Add(listInformation.FirstOrDefault(C => C.COLUMN_NAME == item.xField));
                }
            }
            else
            {
                lOrder = listInformation;
            }

            dgvFiltro.DataSource = lOrder;

            for (int i = 0; i < dgvFiltro.RowCount; i++)
            {
                string sCampo = dgvFiltro.Rows[i].Cells["COLUMN_NAME"].Value.ToString();
                if (sCampo == "idEmpresa")
                {
                    dgvFiltro.CurrentCell = null;
                    dgvFiltro.Rows[i].Visible = false;
                    dgvFiltro.Rows[i].ReadOnly = true;
                }
                else
                {
                    dgvFiltro["HeaderText", i].Value = sCampo == "ID" ? "Código" : dgvFiltro["COLUMN_NAME", i].Value;
                    if (configFormularioModel.lPesquisa != null)
                    {
                        if (configFormularioModel.lPesquisa.Where(C => C.xField == sCampo).Count() > 0)
                        {
                            if (configFormularioModel.lPesquisa.FirstOrDefault(C => C.xField == sCampo).stFilter == false)
                            {
                                dgvFiltro.CurrentCell = null;
                                dgvFiltro.Rows[i].Visible = false;
                                dgvFiltro.Rows[i].ReadOnly = true;
                            }
                        }
                        if (configFormularioModel.lobjConfigComponente.Where(C => C.xField == sCampo).Count() > 0)
                        {
                            dgvFiltro["HeaderText", i].Value = configFormularioModel.lobjConfigComponente.FirstOrDefault(C => C.xField == sCampo).objConfigCompUsu.xLabelText;
                        }
                    }
                }
                switch (dgvFiltro["DATA_TYPE", i].Value.ToString())
                {
                    case "char":
                    case "varchar":
                    case "nvarchar":
                    case "string":
                        {
                            ((DataGridViewComboBoxCell)dgvFiltro["Operador", i]).DataSource = listaString;
                            dgvFiltro.Rows[i].Cells["Operador"].Value = "Igual na Frase";
                            break;
                        }
                    case "int":
                    case "tinyint":
                        {
                            ((DataGridViewComboBoxCell)dgvFiltro["Operador", i]).DataSource = listaInt;
                            dgvFiltro.Rows[i].Cells["Operador"].Value = "Igual a";
                            break;
                        }
                    case "decimal":
                        {
                            ((DataGridViewComboBoxCell)dgvFiltro["Operador", i]).DataSource = listaDecimal;
                            dgvFiltro.Rows[i].Cells["Operador"].Value = "Igual a";
                            break;
                        }
                    case "bit":
                    case "bool":
                        {
                            ((DataGridViewComboBoxCell)dgvFiltro["Operador", i]).DataSource = listaBool;
                            dgvFiltro.Rows[i].Cells["Operador"].Value = "Igual a";
                            break;
                        }
                    case "datetime":
                        {
                            ((DataGridViewComboBoxCell)dgvFiltro["Operador", i]).DataSource = listaData;
                            dgvFiltro.Rows[i].Cells["Operador"].Value = "Igual a";
                            break;
                        }


                }

                dgvFiltro.Rows[i].Cells["EOU"].Value = "E";

            }

        }
        private void GeraGridDados()
        {

            dgvDados.DataSource = null;
            dgvDados.Columns.Clear();
            List<PesquisaPadraoModel> lOrder = new List<PesquisaPadraoModel>();
            if (configFormularioModel.lPesquisa != null)
            {
                foreach (CONFIG_PesquisaModel item in configFormularioModel.lPesquisa.OrderBy(C => C.iOrderData))
                {
                    lOrder.Add(listInformation.FirstOrDefault(C => C.COLUMN_NAME == item.xField));
                }
            }
            else
            {
                lOrder = listInformation;
            }

            for (int i = 0; i < lOrder.Count; i++)
            {
                string sCampo = lOrder[i].COLUMN_NAME;
                if (sCampo != "idEmpresa")
                {
                    DataGridViewTextBoxColumn c = new DataGridViewTextBoxColumn();
                    c.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    c.DataPropertyName = sCampo;
                    c.Name = sCampo;
                    c.HeaderText = sCampo == "ID" ? "Código" : sCampo;
                    if (lOrder.Count > 5)
                    {
                        c.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                        c.Width = 250;
                    }
                    else
                    {
                        c.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                    if (configFormularioModel.lPesquisa != null)
                    {
                        if (configFormularioModel.lPesquisa.Where(C => C.xField == sCampo).Count() > 0)
                        {
                            if (configFormularioModel.lobjConfigComponente.Where(C => C.xField == sCampo).Count() > 0)
                            {
                                c.HeaderText = configFormularioModel.lobjConfigComponente.FirstOrDefault(C => C.xField == sCampo).objConfigCompUsu.xLabelText;
                            }
                            if (configFormularioModel.lPesquisa.FirstOrDefault(C => C.xField == sCampo).stData == false)
                            {
                                c.Visible = false;
                            }
                        }
                    }
                    dgvDados.Columns.Add(c);
                }

            }

        }
        private void BuscaTodosRegistros(string sValor)
        {

            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT * FROM " + sView);
            sql.Append(" WHERE ID > " + sValor);
            if (listInformation.Where(C => C.COLUMN_NAME == "idEmpresa").Count() > 0)
            {
                sql.Append(" AND  idEmpresa = " + CompanyData.idEmpresa + "");
            }
            if (FiltroAtivo)
            {
                if (listInformation.Where(C => C.COLUMN_NAME == "Ativo").Count() > 0)
                {
                    sql.Append(" AND (Ativo = 1) ");
                }
            }
            DataTable dt = pesquisaPadraoService.GetData(sql.ToString());
            OrdenaColunasDataTable(dt);
            dgvDados.DataSource = dt;


        }
        private string ParametroRelatorio(string strColuna, string strTabelaPrincipal)
        {
            string scond = "{" + strTabelaPrincipal + "." + strColuna + "} in[";
            int col = dgvDados.Columns["ID"].Index;
            string svirgula = ",";
            for (int i = 0; i < dgvDados.RowCount; i++)
            {
                if (dgvDados.RowCount == 1)
                {
                    svirgula = "]";
                }
                scond = scond + dgvDados["ID", i].Value.ToString() + svirgula;

                if ((dgvDados.RowCount - i) == 2)
                {
                    svirgula = "]";
                }
            }
            return scond;
        }
        #endregion

        private void configurarPesquisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {             
                FormConfigPesquisaPadrao frm = new FormConfigPesquisaPadrao(configFormularioModel);
                frm.ShowDialog();
                this.Alterou = frm.Alterou;
                if (this.Alterou)
                {
                    iConfigPesquisa.Save(configFormularioModel.lPesquisa);
                    GeraGridFiltro();
                    GeraGridDados();
                }
            }
            catch (System.Exception ex)
            {
                throw;
            }

        }

    }
}