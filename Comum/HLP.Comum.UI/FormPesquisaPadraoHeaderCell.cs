using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using HLP.Comum.Components;
using HLP.Comum.Models;
using Ninject;
using HLP.Comum.Services.Interface;
using HLP.Dependencies;
using HLP.Comum.UI.Exception;

namespace HLP.Comum.UI
{
    public partial class FormPesquisaPadraoHeaderCell : KryptonForm
    {
        [Inject]
        public IPesquisaPadraoService pesquisaPadraoService { get; set; }

        public bool Aplica = false;
        public string sql = "";
        public string sOperadorTela = "";
        public string sValorTela = "";
        List<PesquisaPadraoModel> lSelecionados;
        DataGridViewColumn col;
        string sView;

        string[] listaInt = new string[] { "Igual a", "Entre", "Não Entre", "Na Lista", "Não na Lista", "Diferente que", "Maior que", "Maior Igual que", "Menor que", "Menor Igual que" };
        string[] listaString = new string[] { "Igual a", "Igual na Frase", "Começando com", "Diferente que", "Branco", "Não Branco" };
        string[] listaDecimal = new string[] { "Igual a", "Entre", "Não Entre", "Na Lista", "Não na Lista", "Diferente que", "Maior que", "Maior Igual que", "Menor que", "Menor Igual que" };
        string[] listaData = new string[] { "Igual a", "Maior que", "Maior Igual que", "Menor que", "Menor Igual que", "Entre", "Não Entre", "Diferente que" };
        string[] listaBool = new string[] { "Igual a" };
        string[] listaTelaNormal = new string[] { "Igual a", "Maior que", "Menor que", "Igual na Frase" };


        public FormPesquisaPadraoHeaderCell(List<PesquisaPadraoModel> lSelecionados, string sView)
        {
            InitializeComponent();

            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);

            this.lSelecionados = lSelecionados;
            this.sView = sView;
        }
        public FormPesquisaPadraoHeaderCell(DataGridViewColumn col)
        {
            InitializeComponent();

            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);

            this.col = col;
        }

        private void FormPesquisaPadraoHeaderCell_Load(object sender, EventArgs e)
        {

            if (lSelecionados != null)
            {
                #region Tela Pesquisa
                foreach (PesquisaPadraoModel item in lSelecionados)
                {
                    HLP_ComboBox cbx = AdicionaComboBoxFiltro(item.DATA_TYPE);
                    cbx.Tag = "Filtro";

                    HLP_TextBox txt = new HLP_TextBox();
                    txt._LabelText = item.HeaderText;
                    txt._TamanhoComponente = 100;
                    txt.Width = 250;
                    txt.Tag = item.DATA_TYPE;

                    HLP_ComboBox cbxEOU = AdicionaComboBoxEOU();
                    cbxEOU.Tag = "EOU";
                    cbxEOU.Text = "  ";

                    KryptonPanel panel = new KryptonPanel();
                    panel.Tag = item.COLUMN_NAME;
                    panel.Width = this.Width;
                    panel.Height = 25;
                    panel.Controls.Add(cbx);
                    cbx.Location = new Point(3, 3);
                    panel.Controls.Add(txt);
                    txt.Location = new Point(cbx.Width + 3, 3);
                    panel.Controls.Add(cbxEOU);
                    cbxEOU.Location = new Point(txt.Width + cbx.Width + 3, 3);

                    flpComponentes.Controls.Add(panel);
                    flpComponentes.Height += 25;
                    this.Height += 25;
                }
                #endregion
            }
            else
            {
                #region Tela Normal

                HLP_TextBox txt = new HLP_TextBox();
                txt._LabelText = col.HeaderText;
                txt._TamanhoComponente = 100;
                txt.Width = 400;

                KryptonPanel panel = new KryptonPanel();
                panel.Tag = col.Name;
                panel.Width = this.Width;
                panel.Height = 25;
                panel.Controls.Add(txt);

                flpComponentes.Controls.Add(panel);
                flpComponentes.Height += 25;
                this.Height += 25;
                
                #endregion
            }
            SendKeys.Send("{tab}");
        }


        private HLP_ComboBox AdicionaComboBoxFiltro(string tipo)
        {
            HLP_ComboBox cbx = new HLP_ComboBox();
            cbx._LabelText = "Filtro";
            cbx._TamanhoComponente = 115;
            switch (tipo)
            {
                case "char":
                case "varchar":
                case "nvarchar":
                case "string":
                    {
                        foreach (string item in listaString)
                        {
                            cbx.cbx.Items.Add(item);
                        }
                    }
                    break;

                case "int":
                case "tinyint":
                    {
                        foreach (string item in listaInt)
                        {
                            cbx.cbx.Items.Add(item);
                        }
                    }
                    break;
                case "decimal":
                    {
                        foreach (string item in listaDecimal)
                        {
                            cbx.cbx.Items.Add(item);
                        }
                    }
                    break;
                case "bool":
                    {
                        foreach (string item in listaBool)
                        {
                            cbx.cbx.Items.Add(item);
                        }
                    }
                    break;
                case "datetime":
                    {
                        foreach (string item in listaData)
                        {
                            cbx.cbx.Items.Add(item);
                        }
                    }
                    break;

                case "":
                    {
                        foreach (string item in listaTelaNormal)
                        {
                            cbx.cbx.Items.Add(item);
                        }
                    }
                    break;
            }


            cbx.SelectedIndex = 0;
            return cbx;
        }
        private HLP_ComboBox AdicionaComboBoxEOU()
        {
            HLP_ComboBox cbx = new HLP_ComboBox();
            cbx._LabelText = "";
            cbx._TamanhoComponente = 50;

            cbx.cbx.Items.Add("E");
            cbx.cbx.Items.Add("OU");


            cbx.SelectedIndex = 0;
            return cbx;
        }


        private void FormPesquisaPadraoHeaderCell_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }


        private void btnFiltro_Click(object sender, EventArgs e)
        {
            if (lSelecionados != null)
            {
                #region Tela Pesquisa

                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM " + sView);

                List<string> sExpression = new List<string>();

                foreach (Control panel in flpComponentes.Controls)
                {
                    if (panel.GetType() == typeof(KryptonPanel))
                    {
                        string Campo = "";
                        string EOU = "";
                        string Valor = "";
                        string Operador = "";
                        foreach (Control item in panel.Controls)
                        {
                            if (item.GetType() == typeof(HLP_ComboBox))
                            {
                                if (item.Tag.ToString().Equals("Filtro"))
                                {
                                    Campo = panel.Tag.ToString();
                                    Operador = item.Text;
                                }
                                else
                                {
                                    EOU = item.Text;
                                }
                            }
                            else if (item.GetType() == typeof(HLP_TextBox))
                            {
                                Valor = item.Text;
                            }
                        }

                        if (Operador == "Branco" || Operador == "Não Branco")
                        {
                            Valor = "";
                            sExpression.Add("(" + Campo + "" + pesquisaPadraoService.GetFilter(Valor, Operador, Campo, "") + ")");
                            sExpression.Add(EOU == "E" ? "AND" : "OR");
                        }
                        else if (Valor != "")
                        {
                            sExpression.Add("(" + Campo + "" + pesquisaPadraoService.GetFilter(Valor, Operador, Campo, "") + ")");
                            sExpression.Add(EOU == "E" ? "AND" : "OR");
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
                this.sql = sql.ToString();
                this.Close();

                #endregion
            }
            else
            {
                foreach (Control panel in flpComponentes.Controls)
                {
                    if (panel.GetType() == typeof(KryptonPanel))
                    {
                        foreach (Control item in panel.Controls)
                        {
                            if (item.GetType() == typeof(HLP_TextBox))
                            {
                                sValorTela = item.Text;
                            }
                        }
                    }
                }
                Aplica = true;
                this.Close();
            }
        }
    }
}