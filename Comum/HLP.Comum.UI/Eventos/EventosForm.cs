using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using HLP.Comum.Components;
using HLP.Comum.Models;

using HLP.Comum.Modules;
using HLP.Comum.Services.Interface;
using HLP.Comum.UI.Exception;
using HLP.Comum.UI.Metodos;
using HLP.Dependencies;
using Ninject;
using HLP.Comum.Services.Interface.Configuracao;
using HLP.Comum.Infrastructure;
using HLP.Comum.Components.Configuracao;
using HLP.Comum.Infrastructure.Static;

namespace HLP.Comum.UI.Eventos
{
    public class EventosForm
    {
        [Inject]
        public IPesquisaPadraoService ipesquisaPadraoService { get; set; }

        [Inject]
        public IConfigComponenteService iConfigComponenteService { get; set; }

        public IConfigFormulariosService iConfigFormulario { get; set; }

        public EventosForm(IConfigFormulariosService iConfigFormulario)
        {
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);

            this.iConfigFormulario = iConfigFormulario;

            CarregaEventos();
        }
        public EventosForm()
        {
            IKernel kernel = new StandardKernel(new MagnificusDependenciesModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
        }

        public void ValidaTodosComponentesPesquisa()
        {
            foreach (HLP_Pesquisa comp_pesq in iConfigFormulario.lControl.Where(c => c.GetType() == typeof(HLP_Pesquisa)).ToList())
            {
                PopulaCampoPesquisaTextoEndEdit(comp_pesq.txtPesquisa);
            }
        }

        void CarregaEventos()
        {

            foreach (Control ctr in iConfigFormulario.lControl)
            {
                if (ctr.GetType() == typeof(HLP_Pesquisa))
                {
                    ((HLP_Pesquisa)ctr).btnPesquisa.Click -= new EventHandler(btnPesquisa_Click);
                    ((HLP_Pesquisa)ctr).btnPesquisa.Click += new EventHandler(btnPesquisa_Click);

                    ((HLP_Pesquisa)ctr).txtPesquisa.Leave -= new EventHandler(txtPesquisa_Leave);
                    ((HLP_Pesquisa)ctr).txtPesquisa.Leave += new EventHandler(txtPesquisa_Leave);

                    ((HLP_Pesquisa)ctr).txtPesquisa.TextChanged -= new EventHandler(txtPesquisa_TextChanged);
                    ((HLP_Pesquisa)ctr).txtPesquisa.TextChanged += new EventHandler(txtPesquisa_TextChanged);

                    ((HLP_Pesquisa)ctr).txtPesquisa.KeyDown -= new KeyEventHandler(txtPesquisa_KeyDown);
                    ((HLP_Pesquisa)ctr).txtPesquisa.KeyDown += new KeyEventHandler(txtPesquisa_KeyDown);
                }
                else if (ctr.GetType() == typeof(HLP_TextBox)) // Mudar para UserControlBase
                {
                    ((HLP_TextBox)ctr).tsmConfigurar.Click -= tsmConfigurar_Click;
                    ((HLP_TextBox)ctr).tsmMoveDown.Click -= tsmMoveDown_Click;
                    ((HLP_TextBox)ctr).tsmMoveUp.Click -= tsmMoveUp_Click;
                    ((HLP_TextBox)ctr).tsmMoverPara.MouseEnter -= tsmMoverPara_MouseHover;

                    ((HLP_TextBox)ctr).tsmMoveDown.Click += tsmMoveDown_Click;
                    ((HLP_TextBox)ctr).tsmConfigurar.Click += tsmConfigurar_Click;
                    ((HLP_TextBox)ctr).tsmMoveUp.Click += tsmMoveUp_Click;
                    ((HLP_TextBox)ctr).tsmMoverPara.MouseEnter += tsmMoverPara_MouseHover;

                }
            }
            List<Control> lgrids = iConfigFormulario.lControl.Where(c => c.GetType() == typeof(HLP_DataGridView)).ToList();

            foreach (Control controle in lgrids)
            {
                HLP_DataGridView grid = controle as HLP_DataGridView;
                grid.DataError -= new DataGridViewDataErrorEventHandler(grid_DataError);
                grid.DataError += new DataGridViewDataErrorEventHandler(grid_DataError);

                grid.KeyDown -= new KeyEventHandler(grid_KeyDown);
                grid.KeyDown += new KeyEventHandler(grid_KeyDown);
            }

            // Muda TabPage apos sair do foco do último componente.  **VERIFICAR**


            List<Control> lGroups;
            foreach (TabPage tab in iConfigFormulario.GetTabPages())
            {
                lGroups = iConfigFormulario.lControl.Where(c => c.GetType() == typeof(HLP_Group)).Where(c => (c as HLP_Group)._sNameTabPage == tab.Name).ToList();

                if (lGroups != null)
                {
                    if (lGroups.Count() > 0)
                    {
                        int iMaxTabindex = lGroups.Select(c => c.TabIndex).Max();
                        HLP_Group group = lGroups.FirstOrDefault(c => c.TabIndex == iMaxTabindex) as HLP_Group;
                        iMaxTabindex = group.lControl.Select(c => c.TabIndex).Max();
                        UserControlBase ctr = group.lControl.FirstOrDefault(c => c.TabIndex == iMaxTabindex);
                        ctr.Leave -= new EventHandler(dados_Leave);
                        ctr.Leave += new EventHandler(dados_Leave);
                    }
                }
            }


            //foreach (Control flp in iConfigFormulario.lFlowLayoutPanel)
            //{
            //    int iTabMax = flp.Controls.OfType<UserControl>().Where(c => c.GetType() != typeof(HLP_LabelSeparator)).Max(c => c.TabIndex);
            //    var dados = flp.Controls.OfType<UserControl>().Where(c => c.GetType() != typeof(HLP_LabelSeparator)).FirstOrDefault(c => c.TabIndex == iTabMax);

            //    if (dados != null)
            //    {
            //        dados.Leave -= new EventHandler(dados_Leave);
            //        dados.Leave += new EventHandler(dados_Leave);
            //    }
            //}
        }


        void dados_Leave(object sender, EventArgs e)
        {
            try
            {
                TabPage tab = iConfigFormulario.GetTabPages().FirstOrDefault(c => c.Name == (sender as UserControlBase)._sNameTabPage);

                AC.ExtendedRenderer.Navigator.KryptonTabControl tabControl = tab.Parent as AC.ExtendedRenderer.Navigator.KryptonTabControl;

                int iPosicaoPage = tabControl.TabPages.IndexOf(tab);
                if ((tabControl.TabPages.Count - 1) > iPosicaoPage)
                {
                    tabControl.SelectedTab = tabControl.TabPages[iPosicaoPage + 1];
                }
                else
                {
                    SendKeys.Send("{RIGHT}");
                }
            }
            catch (System.Exception ex)
            {
                new HLPexception(ex);
            }
        }

        private void grid_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F5)
                {
                    KryptonDataGridView grid = (KryptonDataGridView)sender;
                    if (!grid.ReadOnly)
                    {
                        if (grid.CurrentCell != null)
                        {
                            if (grid.CurrentCell.GetType() == typeof(DataGridViewComboBoxCell))
                            {
                                DataGridViewComboBoxColumn col = (DataGridViewComboBoxColumn)grid.CurrentCell.OwningColumn;

                                if (col.Tag != null)
                                {
                                    string[] dados = col.Tag.ToString().Split('-');
                                    ConfigFormulariosModel configFormulario = iConfigFormulario.GetFormulario(dados[0].ToString(), UserData.idUser);
                                    if (configFormulario != null)
                                    {
                                        FormPesquisaPadrao objfrmPesquisaPadrao = new FormPesquisaPadrao(configFormulario, true, true);
                                        objfrmPesquisaPadrao.dgvDados.MultiSelect = false;
                                        objfrmPesquisaPadrao.ShowDialog();

                                        if (objfrmPesquisaPadrao.ListIdSelecionados.Count > 0)
                                        {
                                            try
                                            {
                                                grid.CurrentCell.Value = 0;
                                                (grid.CurrentCell as DataGridViewComboBoxCell).Value = objfrmPesquisaPadrao.ListIdSelecionados[0];
                                                grid.BeginEdit(true);
                                                SendKeys.Send("{DOWN}");
                                                SendKeys.Send("{UP}");
                                                (grid.CurrentCell as DataGridViewComboBoxCell).Value = objfrmPesquisaPadrao.ListIdSelecionados[0];

                                                if (grid.CurrentCell.FormattedValue == null)
                                                {
                                                    grid.CurrentCell.Value = 0;
                                                }

                                            }
                                            catch (System.Exception)
                                            {
                                                grid.CurrentCell.Value = 0;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (KryptonMessageBox.Show(string.Format("Não existe configuração para o Formulario {0}, Deseja abrir o formulario para que a primeira configuração seja salva ?", col.HeaderText), "I N F O R M A Ç Ã O", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                        {
                                            GerenciadorModulo.Instancia.ExibirForm(dados[0].ToString(), TipoExibeForm.Modal);
                                        }

                                    }
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

        public void PesquisaHeaderGrid(object sender, int iIndex)
        {
            KryptonDataGridView grid = sender as KryptonDataGridView;
            DataGridViewColumn col = grid.Columns[iIndex];


            if (grid.RowCount > 1)
            {
                FormPesquisaPadraoHeaderCell frm = new FormPesquisaPadraoHeaderCell(col);
                frm.ShowDialog();
                if (frm.Aplica)
                {
                    for (int i = 0; i < grid.RowCount; i++)
                    {
                        if (grid[iIndex, i].Value != null)
                        {
                            if (grid.Columns[iIndex].GetType() == typeof(DataGridViewComboBoxColumn))
                            {
                                if (grid[iIndex, i].EditedFormattedValue.ToString().ToUpper().Contains(frm.sValorTela.ToUpper()))
                                {
                                    grid.Rows[i].Selected = true;
                                    grid.CurrentCell = grid[iIndex, i];
                                    break;
                                }
                            }
                            else if (grid[iIndex, i].Value.ToString().ToUpper().Contains(frm.sValorTela.ToUpper()))
                            {
                                grid.Rows[i].Selected = true;
                                grid.CurrentCell = grid[iIndex, i];
                                break;
                            }
                        }
                    }
                }
            }
        }

        public void AbreFormGrid(object sender)
        {
            ToolStripItem menuItem = sender as ToolStripItem;
            ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
            KryptonDataGridView grid = owner.SourceControl as KryptonDataGridView;

            if (!grid.ReadOnly)
            {
                if (grid.CurrentCell != null)
                {
                    if (grid.CurrentCell.GetType() == typeof(DataGridViewComboBoxCell))
                    {
                        DataGridViewComboBoxColumn col = (DataGridViewComboBoxColumn)grid.CurrentCell.OwningColumn;
                        if (col.Tag != null)
                        {
                            string[] dados = col.Tag.ToString().Split('-');

                            if (col.DataPropertyName.ToUpper().Equals("IDCONTATO"))
                            {
                                Sistema.contatoStatico.idFkContato = Convert.ToInt32(grid.CurrentCell.Value);
                                Sistema.contatoStatico.nmTable = grid.Tag.ToString();
                            }

                            GerenciadorModulo.Instancia.ExibirForm(dados[0], TipoExibeForm.Modal);

                            MetodosForm objMetodosForm = new MetodosForm(iConfigFormulario);

                            col.DataSource = ipesquisaPadraoService.GetData(objMetodosForm.GetDisplayMember(col), true);
                            try
                            {
                                if (grid.CurrentCell.FormattedValue == null)
                                {
                                    grid.CurrentCell.Value = 0;
                                }
                            }
                            catch (System.Exception)
                            {
                                grid.CurrentCell.Value = 0;
                            }
                        }
                    }
                }
            }
        }

        private void grid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            new HLPexception(e.Exception);
        }


        #region ContextMenuStrip
        void SavePositionsComponent(List<UserControlBase> lComponentes)
        {
            UserControlBase ctr;
            for (int i = 0; i < lComponentes.Count(); i++)
            {
                ctr = lComponentes[i];

                if (ctr.objConfigComponenteModel != null)
                {
                    ctr.objConfigComponenteModel.objConfigCompUsu.nOrder = i;
                    ctr.objConfigComponenteModel.objConfigCompUsu.xLabelGroup = ctr._HlpGroup.Name;
                    iConfigComponenteService.Save(ctr.objConfigComponenteModel);
                }
            }
        }
        void tsmMoverPara_MouseHover(object sender, EventArgs e)
        {
            try
            {
                UserControlBase controle = (sender as ToolStripMenuItem).GetContextMenuStrip().Tag as UserControlBase;
                if (controle.tsmSeparador.DropDownItems.Count == 0)
                {
                    List<HLP_LabelSeparator> lSeparadores = (controle.Parent as FlowLayoutPanel).Controls.OfType<HLP_LabelSeparator>().ToList();
                    if (lSeparadores != null)
                    {
                        if (lSeparadores.Count > 1)
                        {
                            List<ToolStripMenuItem> lMenusSep = new List<ToolStripMenuItem>();
                            ToolStripMenuItem newMenuSep = null;
                            foreach (HLP_LabelSeparator sep in lSeparadores.Where(c => c != controle._LabelGroup))
                            {
                                newMenuSep = new ToolStripMenuItem();
                                newMenuSep.Text = sep._LabelText;
                                newMenuSep.Tag = sep;
                                newMenuSep.Click -= newMenuSep_Click;
                                newMenuSep.Click += newMenuSep_Click;
                                lMenusSep.Add(newMenuSep);
                            }
                            controle.tsmSeparador.DropDownItems.AddRange(lMenusSep.ToArray());
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                new HLPexception(ex);
            }
        }
        void tsmConfigurar_Click(object sender, EventArgs e)
        {
            ContextMenuStrip ctx = (sender as ToolStripMenuItem).Owner as ContextMenuStrip;
            (ctx.Tag as UserControlBase).bConfiguracao = true;
            FormPopupConfig objFrm = new FormPopupConfig(ctx.Tag as Control);
            objFrm.ShowDialog();

            if (objFrm.bAlterou)
            {
                iConfigComponenteService.Save(((ctx.Tag as UserControlBase).objConfigComponenteModel));
                ((ctx.Tag as UserControlBase))._HlpGroup.ConfigMaiorLabel();
            }
            (ctx.Tag as UserControlBase).bConfiguracao = false;
        }
        void tsmMoveUp_Click(object sender, EventArgs e)
        {
            try
            {
                ContextMenuStrip ctx = (sender as ToolStripMenuItem).GetContextMenuStrip();
                (ctx.Tag as UserControlBase).MoveUp();
                this.SavePositionsComponent((ctx.Tag as UserControlBase)._HlpGroup.lControl);
            }
            catch (System.Exception ex)
            {
                new HLPexception(ex);
            }
        }
        void tsmMoveDown_Click(object sender, EventArgs e)
        {
            try
            {
                ContextMenuStrip ctx = (sender as ToolStripMenuItem).GetContextMenuStrip();
                (ctx.Tag as UserControlBase).MoveDown();
                this.SavePositionsComponent((ctx.Tag as UserControlBase)._HlpGroup.lControl);

            }
            catch (System.Exception ex)
            {
                new HLPexception(ex);
            }

        }
        void newMenuSep_Click(object sender, EventArgs e)
        {
            try
            {
                //Separador Escolhido
                HLP_LabelSeparator sepSelect = (sender as ToolStripMenuItem).Tag as HLP_LabelSeparator;

                UserControlBase controle = (sender as ToolStripMenuItem).GetContextMenuStrip().Tag as UserControlBase;
                //Remove primeiro o componente do grupo atual dele no separador
                //controle._LabelGroup.lComponentesBySerparador.Remove(controle);
                //string sParent = controle.Parent.Name;
                // Remove do Container
                //(controle.Parent as FlowLayoutPanel).Controls.Remove(controle);
                //Salva a posição do Grupo do separador que o componente pertencia.


                //Busca a primeira posição do novo grupo do separador escolhido
                int iPosicao = (controle.Parent as FlowLayoutPanel).Controls.GetChildIndex(sepSelect);// (sepSelect.lComponentesBySerparador.Min(c => c.TabIndex) - 1);

                //List<Control> lteste = (controle.Parent as FlowLayoutPanel).Controls.OfType<Control>().Where(c => 
                //                (controle.Parent as FlowLayoutPanel).Controls.GetChildIndex(c)  >= iPosicao).ToList();
                //int icount = iPosicao +1;
                //foreach (Control ctr in lteste)
                //{
                //    (controle.Parent as FlowLayoutPanel).Controls.SetChildIndex(ctr, icount);
                //    ctr.TabIndex = icount;
                //    icount++;
                //}

                (controle.Parent as FlowLayoutPanel).Controls.SetChildIndex(controle, iPosicao);
                controle.TabIndex = iPosicao;
                controle._LabelGroup = sepSelect;

                List<Control> lteste = (controle.Parent as FlowLayoutPanel).Controls.OfType<Control>().ToList();
                int icount = 1;
                foreach (Control ctr in lteste)
                {
                    (controle.Parent as FlowLayoutPanel).Controls.SetChildIndex(ctr, icount);
                    ctr.TabIndex = icount;
                    icount++;
                }

                //(controle.Parent as FlowLayoutPanel).Controls.SetChildIndex(controle, iPosicao);
                //controle.TabIndex = iPosicao;
                //controle._LabelGroup = sepSelect;
                //lteste = iConfigFormulario.lControl.Where(c => (c.Parent != null ? c.Parent.Name : "") == controle.Parent.Name).ToList();
                //this.SavePositionsComponent(lteste);//controle._LabelGroup.lComponentesBySerparador);

            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }


        #endregion

        #region Componente Pesquisa
        List<PesquisaPadraoModel> listInformation = null;
        private object objSenderComponentePesquisa;
        public void btnPesquisa_Click(object sender, EventArgs e)
        {
            this.objSenderComponentePesquisa = sender;
            PesquisaComponente();
        }
        public void txtPesquisa_Leave(object sender, EventArgs e)
        {
            KryptonTextBox txt = (KryptonTextBox)sender;

            if (txt.Text != String.Empty)
            {
                int num1;
                bool isValid = int.TryParse(txt.Text, out num1); // Valida se não está estourando o tamanho máximo permitido pelo tipo int
                if (isValid)
                {
                    PopulaCampoPesquisaTextoEndEdit(txt);
                }
                else
                {
                    txt.Text = "0";
                    PopulaCampoPesquisaTextoEndEdit(txt);
                }
            }


        }
        public void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            KryptonTextBox txt = (KryptonTextBox)sender;
            if (!txt.Focus())
            {
                PopulaCampoPesquisaTextoEndEdit(txt);
            }
        }
        public void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            KryptonTextBox txt = (KryptonTextBox)sender;
            if (e.KeyData == Keys.F5 && txt.Enabled)
            {
                btnPesquisa_Click(sender, e);
            }
        }
        public void PesquisaComponente()
        {
            try
            {
                ButtonSpecAny btn = null;
                List<string> _sListCamposDisplay = new List<string>();

                if (objSenderComponentePesquisa.GetType() == typeof(KryptonTextBox))
                {
                    btn = ((KryptonTextBox)objSenderComponentePesquisa).ButtonSpecs[0];
                }
                else
                {
                    btn = ((ButtonSpecAny)objSenderComponentePesquisa);
                }

                HLP_Pesquisa campo = ((KryptonTextBox)btn.Owner).Parent as HLP_Pesquisa;
                ConfigFormulariosModel configFormulario = iConfigFormulario.GetFormulario(campo._NomeFormCadastroOriginal, UserData.idUser);

                if (configFormulario != null)
                {
                    FormPesquisaPadrao objfrmPesquisaPadrao = new FormPesquisaPadrao(configFormulario, true, true);
                    objfrmPesquisaPadrao.sListComponentePesquisa = campo._ListaCamposDisplay;
                    objfrmPesquisaPadrao.dgvDados.MultiSelect = false;
                    objfrmPesquisaPadrao.ShowDialog();

                    if (objfrmPesquisaPadrao.ListIdSelecionados.Count > 0)
                    {
                        campo.txtPesquisa.Text = objfrmPesquisaPadrao.ListIdSelecionados[0].ToString();
                        campo.txtDisplay.Text = objfrmPesquisaPadrao.ValorComponentePesquisa;
                        campo.Value = objfrmPesquisaPadrao.ListIdSelecionados[0];

                        campo._ListaValoresDisplay = new List<string>();
                        string[] valores = objfrmPesquisaPadrao.ValorComponentePesquisa.Split('-');
                        foreach (string item in valores)
                        {
                            if (item != "")
                            {
                                campo._ListaValoresDisplay.Add(item.Trim());
                            }
                        }
                    }
                }
                else
                {
                    if (KryptonMessageBox.Show("Formulario solicitado não se encontra configurado, deseja abri-lo para salvar sua configuração na base de dados?", "A V I S O", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        GerenciadorModulo.Instancia.ExibirForm(campo._NomeFormCadastroOriginal, TipoExibeForm.Modal);
                }
            }
            catch (System.Exception ex)
            {
                new HLPexception(ex);
            }
        }
        private void PopulaCampoPesquisaTextoEndEdit(KryptonTextBox txt)
        {
            try
            {

                HLP_Pesquisa campo = ((HLP_Pesquisa)txt.Parent);
                if (campo._NomeView != "")
                {
                    listInformation = ipesquisaPadraoService.GetTableInformation(campo._NomeView);


                    StringBuilder sql = new StringBuilder();
                    sql.Append("SELECT * FROM " + campo._NomeView);
                    sql.Append(" WHERE " + campo._NomeCampoPK + " = '" + campo.txtPesquisa.Text + "'");
                    if (listInformation.Where(C => C.COLUMN_NAME == "idEmpresa").Count() > 0)
                    {
                        sql.Append(" AND  idEmpresa ='" + CompanyData.idEmpresa + "'");
                    }
                    if (listInformation.Where(C => C.COLUMN_NAME == "Ativo").Count() > 0)
                    {
                        sql.Append(" AND  Ativo = 1");
                    }

                    bool bTemRegistro = false;
                    DataTable dt = ipesquisaPadraoService.GetData(sql.ToString());

                    if (dt != null)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            campo.Value = Convert.ToInt32(campo.txtPesquisa.Text);
                            campo.txtDisplay.Text = "";
                            campo._ListaValoresDisplay = new List<string>();
                            for (int i = 0; i < campo._ListaCamposDisplay.Count; i++)
                            {
                                campo._ListaValoresDisplay.Add(dr[campo._ListaCamposDisplay[i]].ToString());
                                campo.txtDisplay.Text += dr[campo._ListaCamposDisplay[i]].ToString() + ((i + 1) == campo._ListaCamposDisplay.Count ? "" : " - ");
                            }
                            bTemRegistro = true;
                            break;
                        }
                    }
                    if (!bTemRegistro)
                    {
                        campo.txtPesquisa.Text = "";
                        campo.txtDisplay.Text = "";
                        campo._ListaValoresDisplay = new List<string>();
                        campo.Value = 0;
                    }
                }
            }
            catch (System.Exception ex)
            {
                new HLPexception(ex);
            }

        }

        #endregion

        #region Pesquisa Campo

        public virtual List<int> PesquisaCampo(object sender)
        {
            List<int> listRet = new List<int>();
            try
            {
                ButtonSpecAny btn = (ButtonSpecAny)sender;
                string sCampo = "";
                string sTabela = "";
                string sLabel = "";

                if (btn.Owner.GetType() == typeof(KryptonTextBox))
                {
                    sTabela = ((HLP_TextBox)((KryptonTextBox)btn.Owner).Parent)._Table;
                    sCampo = ((HLP_TextBox)((KryptonTextBox)btn.Owner).Parent)._Field;
                    sLabel = ((HLP_TextBox)((KryptonTextBox)btn.Owner).Parent)._LabelText;
                }
                else if (btn.Owner.GetType() == typeof(KryptonMaskedTextBox))
                {
                    sTabela = ((HLP_MaskedTextBox)((KryptonMaskedTextBox)btn.Owner).Parent)._Table;
                    sCampo = ((HLP_MaskedTextBox)((KryptonMaskedTextBox)btn.Owner).Parent)._Field;
                    sLabel = ((HLP_MaskedTextBox)((KryptonMaskedTextBox)btn.Owner).Parent)._LabelText;
                }
                string sIdentityName = ipesquisaPadraoService.GetIdentityColumnName(sTabela);
                List<PesquisaPadraoModel> listInformation = ipesquisaPadraoService.GetTableInformation(sTabela);

                FormPesquisaCampo frm = new FormPesquisaCampo(sTabela, sCampo, sLabel, sIdentityName, listInformation);
                frm.ShowDialog();
                if (!String.IsNullOrEmpty(frm.sql))
                {
                    listRet = ipesquisaPadraoService.GetIdentityColumnValue(frm.sql);
                }
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            return listRet;
        }

        #endregion



    }
}
