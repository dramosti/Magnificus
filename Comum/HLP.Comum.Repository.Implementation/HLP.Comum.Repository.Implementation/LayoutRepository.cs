
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Repository.Interfaces;
using System.Windows.Forms;
using HLP.Comum.Models;
using HLP.Comum.Components;
using ComponentFactory.Krypton.Toolkit;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Ninject;
using HLP.Comum.Infrastructure;
using System.Xml.Serialization;
using System.IO;
using System.Drawing;
using HLP.Comum.Models.Static;
using HLP.Services.Interfaces.Entries.Parametros;
using HLP.Models.Entries.Parametros;

namespace HLP.Comum.Repository.Implementation
{
    public class LayoutRepository : ILayoutRepository
    {
        public List<Control> lControl { get; set; }
        public List<FlowLayoutPanel> lFlowLayoutPanel { get; set; }
        public List<HLP_DataGridView> lKryptonDataGridView { get; set; }
        public List<AC.ExtendedRenderer.Navigator.KryptonTabControl> lTabControl { get; set; }
        public Formulario AcessoFormulario { get; set; }

        public ConfigFormSerializer objConfig { get; set; }

        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        [Inject]
        public IParametro_GeralService parametroGeralService { get; set; }

        public void DeleteXml()
        {
            try
            {
                File.Delete(PathSave);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private string PathSave { get; set; }
        private List<Componente> lNewComp = new List<Componente>();
        private List<HLP_DataGridView> lNewGridColumn = new List<HLP_DataGridView>();
        private string sViewName { get; set; }
        private string PathSaveSys;

        #region Métodos Publicos
        public void ConfigurationForm(Control.ControlCollection lControles, string sViewName = "")
        {
            try
            {
                if (sViewName != "")
                {
                    this.sViewName = sViewName;
                }
                lControl = new List<Control>();
                lControl = GetControls(lControles);
                lFlowLayoutPanel = new List<FlowLayoutPanel>();
                GetFlowLayoutPanel(lControles);
                lTabControl = new List<AC.ExtendedRenderer.Navigator.KryptonTabControl>();
                GetTabControl(lControles);

                lKryptonDataGridView = new List<HLP_DataGridView>();
                GetGrid(lControles);

                PathSave = GetPathXmlForm(lControl.FirstOrDefault().FindForm().Name);
                PathSaveSys = Pastas.Path_Settings_From_Sys + "Sys_" + lControl.FirstOrDefault().FindForm().Name + ".xml";


                if (File.Exists(UserData.FileUserAcesso))
                {
                    AcessoUser acesso = SerializeClassToXml.DeserializeClasse<AcessoUser>(UserData.FileUserAcesso);

                    if (acesso.lFormularios.Where(c => c.Name == lControl.FirstOrDefault().FindForm().Name).Count() > 0)
                    {
                        AcessoFormulario = acesso.lFormularios.FirstOrDefault(c => c.Name == lControl.FirstOrDefault().FindForm().Name);
                    }
                    else
                    {
                        AcessoFormulario = null;
                    }
                }
                else
                {
                    AcessoFormulario = null;
                }
                bool bAlteracaoForm = false;
                if (File.Exists(PathSave))  // se o arquivo xml já existe...
                {
                    objConfig = Deserialize(PathSave); // carrega as configurações contidas o arquivo .xml

                    #region Analisa campos novos no Form
                    List<Control> lControlsOutXml = new List<Control>();
                    foreach (Control controle in lControl)
                    {
                        if (controle.GetType().ToString().ToUpper().Contains("HLP"))
                        {
                            if (objConfig.Componentes.Where(c => c.Name == controle.Name).Count() == 0)
                            {
                                if (controle.GetType() != typeof(HLP_LabelSeparator))
                                {
                                    bAlteracaoForm = true;
                                    controle.Visible = true;
                                    lControlsOutXml.Add(controle); // se tiver componentes novos, adiciono na lista de Control
                                }
                            }
                        }
                    }
                    foreach (Componente item in GetConfigCompByForm(lControlsOutXml))
                    {
                        lNewComp.Add(item); // lista de objetos das propriedades (informações) dos componentes novos
                    }
                    #endregion

                    #region Analisa campos removidos do formulário
                    List<Componente> lComponenteOutForm = new List<Componente>();
                    foreach (Componente comp in objConfig.Componentes) 
                    {
                        if (lControl.Where(c => c.Name == comp.Name).Count() == 0) // verifica se o componente do XML existe na lista dos comp em tela
                        {
                            bAlteracaoForm = true;
                            lComponenteOutForm.Add(comp); // se não existir mais na tela, adiciona este comp na lista de componente
                        }
                    }
                    foreach (Componente compOutForm in lComponenteOutForm)
                    {
                        objConfig.Componentes.Remove(compOutForm); // Remove os componentes da LISTA do arquivo XML
                    }
                    List<GridColumn> lColumnOutGrid = new List<GridColumn>();
                    List<Grid> lOutGrid = new List<Grid>();
                    foreach (Grid grid in objConfig.DataGrid)
                    {
                        if (lKryptonDataGridView.Where(C => C.Name == grid.Name).Count() == 0) // verifica se foi removido alguma datagrid da tela
                        {
                            bAlteracaoForm = true;
                            lOutGrid.Add(grid); // adiciona para lista de grids q nao existem mais em tela
                        }
                        else
                        {
                            foreach (GridColumn col in grid.DataGridColumn) // verifica se foi removido alguma coluna
                            {
                                //aqui!
                                if (!((HLP_DataGridView)lKryptonDataGridView.FirstOrDefault(C => C.Name == grid.Name)).Columns.Contains(col.Name))
                                {
                                    lColumnOutGrid.Add(col); // adiciona para lista de colunas que não existem mais em tela
                                }
                            }
                            foreach (GridColumn col in lColumnOutGrid)
                            {
                                objConfig.DataGrid.FirstOrDefault(C => C.Name == grid.Name).DataGridColumn.Remove(col);
                            }
                        }
                    }
                    foreach (Grid grid in lOutGrid)
                    {
                        objConfig.DataGrid.Remove(grid); // remove a grid da LISTA do xml
                    }

                    #endregion

                    if (bAlteracaoForm)
                    {
                        ConsistForm();
                    }
                }
                else // se o arquivo xml nao existe
                {
                    objConfig = ConfiguracaoInicial(lControles); // pega as cofiguração que estão nos componentes e gera o XML
                }

                if (bAlteracaoForm || (!File.Exists(PathSaveSys)))
                    ConfiguracaoInicial(lControles, true);


                //Executa a configuração do formulario.
                ConfigFormBySetting();
                ConfigLabelSeparator();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public ConfigFormSerializer ConfiguracaoInicial(Control.ControlCollection lControles, bool config_sys = false)
        {

            ConfigFormSerializer config = new ConfigFormSerializer();
            config.NameForm = lControl.FirstOrDefault().FindForm().Name;
            config.TextForm = lControl.FirstOrDefault().FindForm().Text;
            config.NameView = sViewName;
            config.Componentes = GetConfigCompByForm(this.lControl);
            config.DataGrid = GetConfigCompByColumn(this.lKryptonDataGridView);
            HierarquiaTab hierarquia = new HierarquiaTab();
            hierarquia.TextTab = "HLP";
            hierarquia.NameTab = "HLP";
            GetTabPages(lControles, hierarquia);
            config.Hierarquia = hierarquia;



            if (!config_sys)
            {
                if (!String.IsNullOrEmpty(sViewName))
                {
                    config.Pesquisa = GetConfigFieldByView(sViewName);
                }
                Serialize(config);
            }
            else
            {
                if (File.Exists(PathSaveSys))
                {
                    try
                    {
                        File.Delete(PathSaveSys);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Problema ao Deletar o Arquivo SYS", ex.InnerException);
                    }
                }
                Serialize(config, PathSaveSys);//Serializa o XML SYS_HLP do Formulario                
            }
            return config;
        }





        public ConfigFormSerializer ConfigurationForm(string sFormName)
        {
            try
            {
                string xPathSave = GetPathXmlForm(sFormName);
                ConfigFormSerializer config = null;
                if (File.Exists(xPathSave))
                {
                    config = Deserialize(xPathSave);
                }

                return config;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void ConsistForm()
        {
            foreach (Componente newComp in lNewComp)
            {
                foreach (Componente itemPosition in objConfig.Componentes.Where(c => c.Order >= newComp.Order))
                {
                    itemPosition.Order++;
                }
                objConfig.Componentes.Add(newComp);
            }
            OrderByComponentes();
            //Analisa alterações na Base de dados.
            foreach (Componente item in objConfig.Componentes)
            {
                GetInfoField(item);
            }
            objConfig.DataGrid = GetConfigCompByColumn(lKryptonDataGridView);
            ////Executa a configuração do formulario.
            //ConfigFormBySetting();
            this.Serialize(this.objConfig);
        }
        private void OrderByComponentes()
        {
            List<Componente> lCompOrder = new List<Componente>();
            foreach (Componente item in objConfig.Componentes.OrderBy(c => c.Order))
            {
                lCompOrder.Add(item);
            }
            objConfig.Componentes = lCompOrder;
        }
        public void Serialize(ConfigFormSerializer config, string sPath = "")
        {
            if (sPath == "")
            {
                sPath = PathSave;
            }
            SerializeClassToXml.SerializeClasse(config, sPath);
        }
        public void ConfigFormBySetting()
        {
            bool Upper = isToUpper();

            foreach (FlowLayoutPanel flp in lFlowLayoutPanel)
            {
                #region HLP_TextBox
                foreach (HLP_TextBox control in lControl.Where(c => c.Parent == flp).OfType<HLP_TextBox>().Distinct())
                {
                    try
                    {
                        Componente comp = objConfig.Componentes.FirstOrDefault(c => c.Name == control.Name);
                        if (comp != null)
                        {
                            control._Field = comp.Field;
                            control._Table = comp.Table;
                            control.MaxLength = Convert.ToInt32(Math.Round(comp.MaxLength, 0));
                            control.txt.BackColor = Util.ConverteCor(comp.Color);
                            control.Enabled = comp.Enabled;
                            control._LabelText = comp.LabelText;
                            control.Name = comp.Name;
                            control.TabIndex = comp.Order;
                            flp.Controls.SetChildIndex(control, comp.Order);
                            control.Text = comp.Text;
                            control.Visible = VerificaAcessoComponente(control, comp.Visible);
                            control._Obrigatorio = (comp.BaseConfig.Required && !comp.Name.Equals("txtCodigo") ? HLP_TextBox.CampoObrigatorio.SIM : HLP_TextBox.CampoObrigatorio.NÃO);
                            control._Help = comp.Help;
                            control.CharacterCasing = Upper == true ? CharacterCasing.Upper : CharacterCasing.Normal;
                        }
                        else
                        {
                            flp.Controls.SetChildIndex(control, control.Parent.Controls.IndexOf(control));
                            control.TabIndex = control.Parent.Controls.IndexOf(control);
                            control.Visible = VerificaAcessoComponente(control, false);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(string.Format("Erro ao configurar componente:{0} do tipo: {1} - Exception:{2}", control.Name, control.GetType(), ex.Message));
                    }
                }
                #endregion
                #region HLP_MaskedTextBox
                foreach (HLP_MaskedTextBox control in lControl.Where(c => c.Parent == flp).OfType<HLP_MaskedTextBox>())
                {
                    try
                    {
                        Componente comp = objConfig.Componentes.FirstOrDefault(c => c.Name == control.Name);
                        control._Field = comp.Field;
                        control._Table = comp.Table;
                        control.MaxLength = Convert.ToInt32(Math.Round(comp.MaxLength, 0));
                        control.msk.BackColor = Util.ConverteCor(comp.Color);
                        control.Enabled = comp.Enabled;
                        control._LabelText = comp.LabelText;
                        control.Name = comp.Name;
                        control.TabIndex = comp.Order;
                        flp.Controls.SetChildIndex(control, comp.Order);
                        control.Text = comp.Text;
                        control.Visible = VerificaAcessoComponente(control, comp.Visible);
                        control._Obrigatorio = (comp.BaseConfig.Required ? HLP_MaskedTextBox.CampoObrigatorio.SIM : HLP_MaskedTextBox.CampoObrigatorio.NÃO);
                        control._Help = comp.Help;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(string.Format("Erro ao configurar componente:{0} do tipo: {1} - Exception:{2}", control.Name, control.GetType(), ex.Message));
                    }
                }
                #endregion
                #region HLP_NumericUpDown

                foreach (HLP_NumericUpDown control in lControl.Where(c => c.Parent == flp).OfType<HLP_NumericUpDown>())
                {
                    try
                    {
                        Componente comp = objConfig.Componentes.FirstOrDefault(c => c.Name == control.Name);
                        control._Field = comp.Field;
                        control._Table = comp.Table;
                        control.DecimalPlaces = comp.DecimalPlaces;
                        control.Maximum = comp.BaseConfig.Type == "tinyint" ? 255 : (comp.MaxLength + 1);
                        control.nud.BackColor = Util.ConverteCor(comp.Color);
                        control.Enabled = comp.Enabled;
                        control._LabelText = comp.LabelText;
                        control.Name = comp.Name;
                        control.TabIndex = comp.Order;
                        flp.Controls.SetChildIndex(control, comp.Order);
                        control.Text = comp.Text;
                        control.Visible = VerificaAcessoComponente(control, comp.Visible);
                        control._Obrigatorio = (comp.BaseConfig.Required ? HLP_NumericUpDown.CampoObrigatorio.SIM : HLP_NumericUpDown.CampoObrigatorio.NÃO);
                        control._Help = comp.Help;

                    }
                    catch (Exception ex)
                    {
                        throw new Exception(string.Format("Erro ao configurar componente:{0} do tipo: {1} - Exception:{2}", control.Name, control.GetType(), ex.Message));
                    }
                }

                #endregion
                #region HLP_DateTimePicker


                foreach (HLP_DateTimePicker control in lControl.Where(c => c.Parent == flp).OfType<HLP_DateTimePicker>())
                {
                    try
                    {
                        Componente comp = objConfig.Componentes.FirstOrDefault(c => c.Name == control.Name);
                        control._Field = comp.Field;
                        control._Table = comp.Table;
                        control.dtp.BackColor = Util.ConverteCor(comp.Color);
                        control.Enabled = comp.Enabled;
                        control._LabelText = comp.LabelText;
                        control.Name = comp.Name;
                        control.TabIndex = comp.Order;
                        flp.Controls.SetChildIndex(control, comp.Order);
                        control.Text = comp.Text;
                        control.Visible = VerificaAcessoComponente(control, comp.Visible);
                        control._Obrigatorio = (comp.BaseConfig.Required ? UserControlBase.CampoObrigatorio.SIM : UserControlBase.CampoObrigatorio.NÃO);
                        control._Help = comp.Help;
                        if (control.dtp.Format == DateTimePickerFormat.Time)
                        {
                            control.dtp.ShowUpDown = true;
                        }

                    }
                    catch (Exception ex)
                    {
                        throw new Exception(string.Format("Erro ao configurar componente:{0} do tipo: {1} - Exception:{2}", control.Name, control.GetType(), ex.Message));
                    }
                }

                #endregion
                #region HLP_ComboBox


                foreach (HLP_ComboBox control in lControl.Where(c => c.Parent == flp).OfType<HLP_ComboBox>())
                {
                    try
                    {
                        Componente comp = objConfig.Componentes.FirstOrDefault(c => c.Name == control.Name);
                        control._Field = comp.Field;
                        control._Table = comp.Table;
                        control.cbx.BackColor = Util.ConverteCor(comp.Color);
                        control.Enabled = comp.Enabled;
                        control._LabelText = comp.LabelText;
                        control.Name = comp.Name;
                        control.TabIndex = comp.Order;
                        flp.Controls.SetChildIndex(control, comp.Order);
                        control.Text = comp.Text;
                        control.Visible = VerificaAcessoComponente(control, comp.Visible);
                        control._Obrigatorio = (comp.BaseConfig.Required ? HLP_ComboBox.CampoObrigatorio.SIM : HLP_ComboBox.CampoObrigatorio.NÃO);
                        control._Help = comp.Help;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(string.Format("Erro ao configurar componente:{0} do tipo: {1} - Exception:{2}", control.Name, control.GetType(), ex.Message));
                    }
                }

                #endregion
                #region HLP_CheckBox

                foreach (HLP_CheckBox control in lControl.Where(c => c.Parent == flp).OfType<HLP_CheckBox>())
                {
                    try
                    {
                        Componente comp = objConfig.Componentes.FirstOrDefault(c => c.Name == control.Name);
                        control._Field = comp.Field;
                        control._Table = comp.Table;
                        control.chk.BackColor = Util.ConverteCor(comp.Color);
                        control.Enabled = comp.Enabled;
                        control._LabelText = comp.LabelText;
                        control.Name = comp.Name;
                        control.TabIndex = comp.Order;
                        flp.Controls.SetChildIndex(control, comp.Order);
                        control.Checked = Convert.ToBoolean(comp.Text);
                        control.Visible = VerificaAcessoComponente(control, comp.Visible);
                        control._Help = comp.Help;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(string.Format("Erro ao configurar componente:{0} do tipo: {1} - Exception:{2}", control.Name, control.GetType(), ex.Message));
                    }
                }

                #endregion
                #region HLP_ListBox

                foreach (HLP_ListBox control in lControl.Where(c => c.Parent == flp).OfType<HLP_ListBox>())
                {
                    try
                    {
                        Componente comp = objConfig.Componentes.FirstOrDefault(c => c.Name == control.Name);
                        control._Field = comp.Field;
                        control._Table = comp.Table;
                        control.lst.BackColor = Util.ConverteCor(comp.Color);
                        control.Enabled = comp.Enabled;
                        control._LabelText = comp.LabelText;
                        control.Name = comp.Name;
                        control.TabIndex = comp.Order;
                        flp.Controls.SetChildIndex(control, comp.Order);
                        control.Visible = VerificaAcessoComponente(control, comp.Visible);
                        control._Help = comp.Help;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(string.Format("Erro ao configurar componente:{0} do tipo: {1} - Exception:{2}", control.Name, control.GetType(), ex.Message));
                    }
                }

                #endregion
                #region HLP_Pesquisa
                foreach (HLP_Pesquisa control in lControl.Where(c => c.Parent == flp).OfType<HLP_Pesquisa>())
                {
                    try
                    {

                        Componente comp = objConfig.Componentes.FirstOrDefault(c => c.Name == control.Name);
                        control._Field = comp.Field;
                        control._Table = comp.Table;
                        control.Enabled = comp.Enabled;
                        control._LabelText = comp.LabelText;
                        control.Name = comp.Name;
                        control.TabIndex = comp.Order;
                        flp.Controls.SetChildIndex(control, comp.Order);
                        control.Visible = VerificaAcessoComponente(control, comp.Visible);
                        control._Obrigatorio = (comp.BaseConfig.Required ? HLP_Pesquisa.CampoObrigatorio.SIM : HLP_Pesquisa.CampoObrigatorio.NÃO);
                        control._Help = comp.Help;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(string.Format("Erro ao configurar componente:{0} do tipo: {1} - Exception:{2}", control.Name, control.GetType(), ex.Message));
                    }
                }
                #endregion
                #region HLP_Observacao
                foreach (HLP_Observacao control in lControl.Where(c => c.Parent == flp).OfType<HLP_Observacao>())
                {
                    try
                    {

                        Componente comp = objConfig.Componentes.FirstOrDefault(c => c.Name == control.Name);
                        control._Field = comp.Field;
                        control._Table = comp.Table;
                        control.Enabled = comp.Enabled;
                        control._LabelText = comp.LabelText;
                        control.Name = comp.Name;
                        control.TabIndex = comp.Order;
                        flp.Controls.SetChildIndex(control, comp.Order);
                        control.Visible = VerificaAcessoComponente(control, comp.Visible);
                        control._Help = comp.Help;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(string.Format("Erro ao configurar componente:{0} do tipo: {1} - Exception:{2}", control.Name, control.GetType(), ex.Message));
                    }
                }
                #endregion


                #region Verifica Acesso
                int icountInvisible = 0;

                if (AcessoFormulario != null)
                {
                    foreach (Componente componente in objConfig.Componentes.Where(c => c.Parent == flp.Parent.Parent.Name))
                    {
                        if ((componente.Visible == true) && (AcessoFormulario.lComponentes.FirstOrDefault(c => c.NameComp == componente.Name).AcessoComp == false))
                        {
                            icountInvisible++;
                        }
                    }
                }



                if (icountInvisible == objConfig.Componentes.Where(c => c.Parent == flp.Parent.Parent.Name).Count())
                {
                    Control ctr = flp.Parent;
                    while (ctr.Parent != null)
                    {
                        if (ctr.GetType() == typeof(TabPage))
                        {
                            AC.ExtendedRenderer.Navigator.KryptonTabControl tab = ((AC.ExtendedRenderer.Navigator.KryptonTabControl)ctr.Parent);
                            ((AC.ExtendedRenderer.Navigator.KryptonTabControl)ctr.Parent).TabPages.Remove((TabPage)ctr);
                            if (tab.TabPages.Count == 0)
                            {
                                ctr = tab.Parent;
                                while (ctr.Parent != null)
                                {
                                    if (ctr.GetType() == typeof(TabPage))
                                    {
                                        ((AC.ExtendedRenderer.Navigator.KryptonTabControl)ctr.Parent).TabPages.Remove((TabPage)ctr);
                                        break;
                                    }
                                }
                            }
                            break;
                        }
                        ctr = ctr.Parent;
                    }
                }
                #endregion


            }
            foreach (HLP_DataGridView grid in lKryptonDataGridView)
            {
                #region Grid

                grid.AllowUserToOrderColumns = true;
                grid.AllowUserToResizeColumns = true;
                grid.RowHeadersWidth = 15;
                grid.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Segoe UI", 8.25F);
                grid.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Segoe UI", 8.25F);
                Grid objGrid = objConfig.DataGrid.FirstOrDefault(C => C.Name == grid.Name);
                if (objGrid != null)
                {
                    GridColumn col = null;
                    for (int i = 0; i < grid.ColumnCount; i++)
                    {
                        col = objGrid.DataGridColumn.FirstOrDefault(C => C.DataPropertyName == grid.Columns[i].DataPropertyName);
                        grid.Columns[i].MinimumWidth = 100;

                        if (col != null)
                        {
                            if (col.Width != 0)
                            {
                                grid.Columns[i].Width = col.Width;
                            }
                            else
                            {
                                if (grid.ColumnCount > 5)
                                {
                                    grid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                                    grid.Columns[i].Width = 250;
                                }
                                else
                                {
                                    grid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                }
                            }
                            grid.Columns[i].DisplayIndex = col.DisplayIndex;
                            grid.Columns[i].HeaderText = Util.ToUpperFirstLetter(col.HeaderText);
                            grid.Columns[i].ToolTipText = Util.ToUpperFirstLetter(col.Help);
                            bool bvisible = VerificaAcessoComponente(grid.Columns[i], col.Visible);
                            grid.Columns[i].Visible = bvisible;
                            if (grid.Columns[i].GetType() == typeof(DataGridViewTextBoxColumn))
                            {
                                ((DataGridViewTextBoxColumn)grid.Columns[i]).MaxInputLength = (int)col.MaxLength;
                            }
                            else if (grid.Columns[i].GetType() == typeof(KryptonDataGridViewNumericUpDownColumn))
                            {
                                ((KryptonDataGridViewNumericUpDownColumn)grid.Columns[i]).Maximum = col.MaxLength - col.DecimalPlaces;
                                ((KryptonDataGridViewNumericUpDownColumn)grid.Columns[i]).DecimalPlaces = col.DecimalPlaces;
                            }
                            else if (grid.Columns[i].GetType() == typeof(DataGridViewComboBoxColumn))
                            {
                                ((DataGridViewComboBoxColumn)grid.Columns[i]).DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;

                                if (col.BaseConfigGrid.Type == "tinyint")
                                {
                                    ((DataGridViewComboBoxColumn)grid.Columns[i]).ValueMember = "ValueMemberTiny";
                                    ((DataGridViewComboBoxColumn)grid.Columns[i]).DisplayMember = "DisplayMember";

                                    List<ComboBoxColumn> objboCombo = new List<ComboBoxColumn>();
                                    int icount = 0;
                                    foreach (object item in ((DataGridViewComboBoxColumn)grid.Columns[i]).Items)
                                    {
                                        objboCombo.Add(new ComboBoxColumn { DisplayMember = (item.GetType() == typeof(System.String) ? item.ToString() : ((ComboBoxColumn)item).DisplayMember), ValueMember = icount, ValueMemberTiny = Convert.ToByte(icount) });
                                        icount++;
                                    }
                                    ((DataGridViewComboBoxColumn)grid.Columns[i]).DataSource = objboCombo;
                                }
                            }
                        }
                    }
                }
                #endregion

                #region Verifica Acesso
                if (AcessoFormulario != null)
                {
                    if (AcessoFormulario.lGrids.Where(c => c.NameGrid == grid.Name).Count() > 0)
                    {
                        if (!AcessoFormulario.lGrids.FirstOrDefault(c => c.NameGrid == grid.Name).AcessoGrid)
                        {
                            Control ctr = grid.Parent;
                            while (ctr.Parent != null)
                            {
                                if (ctr.GetType() == typeof(TabPage))
                                {
                                    ((AC.ExtendedRenderer.Navigator.KryptonTabControl)ctr.Parent).TabPages.Remove((TabPage)ctr);
                                    break;
                                }
                                ctr = ctr.Parent;
                            }
                        }
                    }
                }
                #endregion
            }

        }

        private void ConfigLabelSeparator()
        {
            foreach (FlowLayoutPanel flp in lFlowLayoutPanel)
            {
                if (flp.FlowDirection != FlowDirection.LeftToRight)
                {
                    ConfigMaiorLabel(flp);
                }
                foreach (HLP_LabelSeparator l in lControl.Where(c => c.Parent == flp).OfType<HLP_LabelSeparator>().Distinct())
                {
                    int iIndex = 1000;
                    int iChildIndex = 0;
                    int iMaiorComponente = 0;
                    int iTamanhoComponente = 0;
                    string sCompName = "";

                    #region HLP_TextBox
                    List<HLP_TextBox> ltxt = lControl.Where(c => c.Parent == flp).OfType<HLP_TextBox>().Where(C => C._LabelGroup == l && C._Visible == true).Distinct().ToList();
                    if (ltxt.Count() > 0)
                    {
                        iTamanhoComponente = ltxt.Max(C => C.Width);
                        if (iMaiorComponente < iTamanhoComponente)
                        {
                            iMaiorComponente = iTamanhoComponente;
                            sCompName = lControl.FirstOrDefault(C => C.Width == iMaiorComponente).Name;
                        }
                    }
                    foreach (HLP_TextBox txt in ltxt)
                    {
                        if (objConfig.Componentes.FirstOrDefault(C => C.Name == txt.Name).Visible)
                        {
                            iChildIndex = flp.Controls.GetChildIndex(txt);
                            iIndex = (iChildIndex < iIndex ? iChildIndex : iIndex);
                            break;
                        }
                    }

                    #endregion
                    #region HLP_MaskedTextBox
                    List<HLP_MaskedTextBox> lmsk = lControl.Where(c => c.Parent == flp).OfType<HLP_MaskedTextBox>().Where(C => C._LabelGroup == l && C._Visible == true).Distinct().ToList();
                    if (lmsk.Count() > 0)
                    {
                        iTamanhoComponente = lmsk.Max(C => C.Width);
                        if (iMaiorComponente < iTamanhoComponente)
                        {
                            iMaiorComponente = iTamanhoComponente;
                            sCompName = lControl.FirstOrDefault(C => C.Width == iMaiorComponente).Name;
                        }
                    }
                    foreach (HLP_MaskedTextBox msk in lmsk)
                    {
                        if (objConfig.Componentes.FirstOrDefault(C => C.Name == msk.Name).Visible)
                        {
                            iChildIndex = flp.Controls.GetChildIndex(msk);
                            iIndex = (iChildIndex < iIndex ? iChildIndex : iIndex);
                            break;
                        }
                    }
                    #endregion
                    #region HLP_NumericUpDown
                    List<HLP_NumericUpDown> lnud = lControl.Where(c => c.Parent == flp).OfType<HLP_NumericUpDown>().Where(C => C._LabelGroup == l && C._Visible == true).Distinct().ToList();
                    if (lnud.Count() > 0)
                    {
                        iTamanhoComponente = lnud.Max(C => C.Width);
                        if (iMaiorComponente < iTamanhoComponente)
                        {
                            iMaiorComponente = iTamanhoComponente;
                            sCompName = lControl.FirstOrDefault(C => C.Width == iMaiorComponente).Name;
                        }
                    }
                    foreach (HLP_NumericUpDown nud in lnud)
                    {
                        if (objConfig.Componentes.FirstOrDefault(C => C.Name == nud.Name).Visible)
                        {
                            iChildIndex = flp.Controls.GetChildIndex(nud);
                            iIndex = (iChildIndex < iIndex ? iChildIndex : iIndex);
                            break;
                        }
                    }
                    #endregion
                    #region HLP_DateTimePicker
                    List<HLP_DateTimePicker> ldtp = lControl.Where(c => c.Parent == flp).OfType<HLP_DateTimePicker>().Where(C => C._LabelGroup == l && C._Visible == true).Distinct().ToList();
                    if (ldtp.Count() > 0)
                    {
                        iTamanhoComponente = ldtp.Max(C => C.Width);
                        if (iMaiorComponente < iTamanhoComponente)
                        {
                            iMaiorComponente = iTamanhoComponente;
                            sCompName = lControl.FirstOrDefault(C => C.Width == iMaiorComponente).Name;
                        }
                    }
                    foreach (HLP_DateTimePicker dtp in ldtp)
                    {
                        if (objConfig.Componentes.FirstOrDefault(C => C.Name == dtp.Name).Visible)
                        {
                            iChildIndex = flp.Controls.GetChildIndex(dtp);
                            iIndex = (iChildIndex < iIndex ? iChildIndex : iIndex);
                            break;
                        }
                    }
                    #endregion
                    #region HLP_ComboBox
                    List<HLP_ComboBox> lcbo = lControl.Where(c => c.Parent == flp).OfType<HLP_ComboBox>().Where(C => C._LabelGroup == l && C._Visible == true).Distinct().ToList();
                    if (lcbo.Count() > 0)
                    {
                        iTamanhoComponente = lcbo.Max(C => C.Width);
                        if (iMaiorComponente < iTamanhoComponente)
                        {
                            iMaiorComponente = iTamanhoComponente;
                            sCompName = lControl.FirstOrDefault(C => C.Width == iMaiorComponente).Name;
                        }
                    }
                    foreach (HLP_ComboBox cbo in lcbo)
                    {
                        if (objConfig.Componentes.FirstOrDefault(C => C.Name == cbo.Name).Visible)
                        {
                            iChildIndex = flp.Controls.GetChildIndex(cbo);
                            iIndex = (iChildIndex < iIndex ? iChildIndex : iIndex);
                            break;
                        }
                    }
                    #endregion
                    #region HLP_CheckBox
                    List<HLP_CheckBox> lchk = lControl.Where(c => c.Parent == flp).OfType<HLP_CheckBox>().Where(C => C._LabelGroup == l && C._Visible == true).Distinct().ToList();
                    if (lchk.Count() > 0)
                    {
                        iTamanhoComponente = lchk.Max(C => C.Width);
                        if (iMaiorComponente < iTamanhoComponente)
                        {
                            iMaiorComponente = iTamanhoComponente;
                            sCompName = lControl.FirstOrDefault(C => C.Width == iMaiorComponente).Name;
                        }
                    }
                    foreach (HLP_CheckBox chk in lchk)
                    {
                        if (objConfig.Componentes.FirstOrDefault(C => C.Name == chk.Name).Visible)
                        {
                            iChildIndex = flp.Controls.GetChildIndex(chk);
                            iIndex = (iChildIndex < iIndex ? iChildIndex : iIndex);
                            break;
                        }
                    }
                    #endregion
                    #region HLP_ListBox
                    List<HLP_ListBox> llst = lControl.Where(c => c.Parent == flp).OfType<HLP_ListBox>().Where(C => C._LabelGroup == l && C._Visible == true).Distinct().ToList();
                    if (llst.Count() > 0)
                    {
                        iTamanhoComponente = llst.Max(C => C.Width);
                        if (iMaiorComponente < iTamanhoComponente)
                        {
                            iMaiorComponente = iTamanhoComponente;
                            sCompName = lControl.FirstOrDefault(C => C.Width == iMaiorComponente).Name;
                        }
                    }
                    foreach (HLP_ListBox lst in llst)
                    {
                        if (objConfig.Componentes.FirstOrDefault(C => C.Name == lst.Name).Visible)
                        {
                            iChildIndex = flp.Controls.GetChildIndex(lst);
                            iIndex = (iChildIndex < iIndex ? iChildIndex : iIndex);
                            break;
                        }
                    }
                    #endregion
                    #region HLP_Pesquisa
                    List<HLP_Pesquisa> lpesq = lControl.Where(c => c.Parent == flp).OfType<HLP_Pesquisa>().Where(C => C._LabelGroup == l && C._Visible == true).Distinct().ToList();
                    if (lpesq.Count() > 0)
                    {
                        iTamanhoComponente = lpesq.Max(C => C.Width);
                        if (iMaiorComponente < iTamanhoComponente)
                        {
                            iMaiorComponente = iTamanhoComponente;
                            sCompName = lControl.FirstOrDefault(C => C.Width == iMaiorComponente).Name;
                        }
                    }
                    foreach (HLP_Pesquisa pesq in lpesq)
                    {
                        if (objConfig.Componentes.FirstOrDefault(C => C.Name == pesq.Name).Visible)
                        {
                            iChildIndex = flp.Controls.GetChildIndex(pesq);
                            iIndex = (iChildIndex < iIndex ? iChildIndex : iIndex);
                            break;
                        }
                    }
                    #endregion
                    #region HLP_Observacao
                    List<HLP_Observacao> lobs = lControl.Where(c => c.Parent == flp).OfType<HLP_Observacao>().Where(C => C._LabelGroup == l && C._Visible == true).Distinct().ToList();
                    if (lobs.Count() > 0)
                    {
                        iTamanhoComponente = lobs.Max(C => C.Width);
                        if (iMaiorComponente < iTamanhoComponente)
                        {
                            iMaiorComponente = iTamanhoComponente;
                            sCompName = lControl.FirstOrDefault(C => C.Width == iMaiorComponente).Name;
                        }
                    }
                    foreach (HLP_Observacao obs in lobs)
                    {
                        if (objConfig.Componentes.FirstOrDefault(C => C.Name == obs.Name).Visible)
                        {
                            iChildIndex = flp.Controls.GetChildIndex(obs);
                            iIndex = (iChildIndex < iIndex ? iChildIndex : iIndex);
                            break;
                        }
                    }
                    #endregion
                    if (iIndex == 1000)
                    {
                        flp.Controls.Remove(l);
                    }
                    else
                    {

                        int iMargem = lControl.FirstOrDefault(C => C.Name == sCompName).Margin.Left;
                        l.Width = iMaiorComponente + iMargem;
                        if (lFlowLayoutPanel.Count > 1 || objConfig.Hierarquia.Tabs.Count > 1)
                        {
                            flp.Controls.SetChildIndex(l, iIndex - 1);
                        }
                        else
                        {
                            flp.Controls.SetChildIndex(l, iIndex);
                        }
                    }
                }
            }
        }

        bool VerificaAcessoComponente(Control controle, bool bconfigUser)
        {
            if (AcessoFormulario != null)
            {
                if (AcessoFormulario.lComponentes.Where(c => c.NameComp == controle.Name).Count() > 0)
                {
                    if (AcessoFormulario.lComponentes.FirstOrDefault(c => c.NameComp == controle.Name).AcessoComp)
                    {
                        return bconfigUser;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return bconfigUser;
                }
            }
            else
            {
                return bconfigUser;
            }
        }
        bool VerificaAcessoComponente(DataGridViewColumn coluna, bool bconfigUser)
        {
            if (AcessoFormulario != null)
            {
                if (AcessoFormulario.lGrids.Where(c => c.NameGrid == coluna.DataGridView.Name).Count() > 0)
                {
                    if (AcessoFormulario.lGrids.FirstOrDefault(c => c.NameGrid == coluna.DataGridView.Name).lColunas.Where(C => C.NameCol == coluna.Name).Count() > 0)
                    {
                        if (AcessoFormulario.lGrids.FirstOrDefault(c => c.NameGrid == coluna.DataGridView.Name).lColunas.
                            FirstOrDefault(C => C.NameCol == coluna.Name).AcessoCol == true)
                        {
                            return bconfigUser;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return bconfigUser;
                }
            }
            else
            {
                return bconfigUser;
            }
        }

        public bool isToUpper()
        {
            bool Upper = false;
            Parametro_GeralModel param = parametroGeralService.GetGeralByEmpresa();
            if (param != null)
            {
                Upper = param.stMaiusculo == 0 ? false : true;
            }
            return Upper;
        }
        #endregion

        #region Métodos Privados
        private int ConfigMaiorLabel(FlowLayoutPanel flp)
        {
            int imaiorLabel = GetBiggestLabel(lControl.Where(c => c.Parent == flp).ToList());

            #region HLP_TextBox
            foreach (HLP_TextBox control in lControl.Where(c => c.Parent == flp).OfType<HLP_TextBox>().Distinct())
            {
                control._TamanhoMaiorLabel = imaiorLabel;
            }
            #endregion
            #region HLP_MaskedTextBox
            foreach (HLP_MaskedTextBox control in lControl.Where(c => c.Parent == flp).OfType<HLP_MaskedTextBox>())
            {
                control._TamanhoMaiorLabel = imaiorLabel;
            }
            #endregion
            #region HLP_NumericUpDown
            foreach (HLP_NumericUpDown control in lControl.Where(c => c.Parent == flp).OfType<HLP_NumericUpDown>())
            {
                control._TamanhoMaiorLabel = imaiorLabel;
            }
            #endregion
            #region HLP_DateTimePicker
            foreach (HLP_DateTimePicker control in lControl.Where(c => c.Parent == flp).OfType<HLP_DateTimePicker>())
            {
                control._TamanhoMaiorLabel = imaiorLabel;
            }
            #endregion
            #region HLP_ComboBox
            foreach (HLP_ComboBox control in lControl.Where(c => c.Parent == flp).OfType<HLP_ComboBox>())
            {
                control._TamanhoMaiorLabel = imaiorLabel;
            }
            #endregion
            #region HLP_CheckBox
            foreach (HLP_CheckBox control in lControl.Where(c => c.Parent == flp).OfType<HLP_CheckBox>())
            {
                control._TamanhoMaiorLabel = imaiorLabel;
            }
            #endregion
            #region HLP_ListBox
            foreach (HLP_ListBox control in lControl.Where(c => c.Parent == flp).OfType<HLP_ListBox>())
            {
                control._TamanhoMaiorLabel = imaiorLabel;
            }
            #endregion
            #region HLP_Pesquisa
            foreach (HLP_Pesquisa control in lControl.Where(c => c.Parent == flp).OfType<HLP_Pesquisa>())
            {
                control._TamanhoMaiorLabel = imaiorLabel;
            }
            #endregion
            #region HLP_Observacao
            foreach (HLP_Observacao control in lControl.Where(c => c.Parent == flp).OfType<HLP_Observacao>())
            {
                control._TamanhoMaiorLabel = imaiorLabel;
            }
            #endregion

            return imaiorLabel;
        }

        private void GetFlowLayoutPanel(Control.ControlCollection lControles)
        {

            foreach (Control ctr in lControles)
            {
                if (ctr.GetType() == typeof(SplitContainer))
                {
                    ((SplitContainer)ctr).BorderStyle = BorderStyle.None;
                    ((SplitContainer)ctr).Panel1.Padding = new Padding(0);
                    ((SplitContainer)ctr).Panel2.Padding = new Padding(0);
                }
                if (ctr.GetType() == typeof(FlowLayoutPanel))
                {
                    if (!lFlowLayoutPanel.Contains(ctr))
                    {
                        ((FlowLayoutPanel)ctr).AutoScroll = true;
                        ((FlowLayoutPanel)ctr).BorderStyle = BorderStyle.FixedSingle;
                        lFlowLayoutPanel.Add((FlowLayoutPanel)ctr);
                    }
                }
                else if (ctr.HasChildren)
                {
                    GetFlowLayoutPanel(ctr.Controls);
                }
            }
        }

        private void GetTabPages(Control.ControlCollection lControles, HierarquiaTab tabPai)
        {
            foreach (Control ctr in lControles)
            {
                if (ctr.GetType() == typeof(TabPage))
                {
                    HierarquiaTab tab = new HierarquiaTab();
                    tab.NameTab = ctr.Name;
                    tab.TextTab = ctr.Text;
                    if (ctr.Tag != null)
                        tab.HelpTab = ctr.Tag.ToString();
                    tabPai.Tabs.Add(tab);
                    GetTabPages(ctr.Controls, tab);
                }
                else if (ctr.HasChildren)
                {
                    GetTabPages(ctr.Controls, tabPai);
                }
            }
        }

        private void GetTabControl(Control.ControlCollection lControles)
        {

            foreach (Control ctr in lControles)
            {
                if (ctr.GetType() == typeof(AC.ExtendedRenderer.Navigator.KryptonTabControl))
                {
                    if (!lTabControl.Contains(ctr))
                    {
                        lTabControl.Add((AC.ExtendedRenderer.Navigator.KryptonTabControl)ctr);
                    }
                }
                else if (ctr.HasChildren)
                {
                    GetTabControl(ctr.Controls);
                }
            }
        }
        private void GetGrid(Control.ControlCollection lControles)
        {

            foreach (Control ctr in lControles)
            {
                if (ctr.GetType() == typeof(HLP_DataGridView))
                {
                    if (!lKryptonDataGridView.Contains((HLP_DataGridView)ctr))
                    {
                        lKryptonDataGridView.Add((HLP_DataGridView)ctr);
                    }
                }
                else if (ctr.HasChildren)
                {
                    GetGrid(ctr.Controls);
                }
            }
        }

        private List<Control> GetControls(Control.ControlCollection lControles)
        {
            foreach (Control ctr in lControles)
            {
                if (ctr.GetType().BaseType == typeof(UserControl) || ctr.GetType().BaseType == typeof(UserControlBase))
                {
                    if (!lControl.Contains(ctr))
                    {
                        lControl.Add(ctr);
                    }
                }
                else if (!lControl.Contains(ctr))
                {
                    #region Controles Normais
                    if (ctr.GetType() == typeof(KryptonButton))
                    {
                        lControl.Add(ctr);
                    }
                    else if (ctr.GetType() == typeof(KryptonTextBox))
                    {
                        lControl.Add(ctr);
                    }
                    else if (ctr.GetType() == typeof(KryptonMaskedTextBox))
                    {
                        lControl.Add(ctr);
                    }
                    else if (ctr.GetType() == typeof(KryptonComboBox))
                    {
                        lControl.Add(ctr);
                    }
                    else if (ctr.GetType() == typeof(KryptonDateTimePicker))
                    {
                        lControl.Add(ctr);
                    }
                    else if (ctr.GetType() == typeof(KryptonCheckedListBox))
                    {
                        lControl.Add(ctr);
                    }
                    else if (ctr.GetType() == typeof(KryptonCheckBox))
                    {
                        lControl.Add(ctr);
                    }
                    else if (ctr.GetType() == typeof(KryptonRichTextBox))
                    {
                        lControl.Add(ctr);
                    }
                    else if (ctr.GetType() == typeof(KryptonNumericUpDown))
                    {
                        lControl.Add(ctr);
                    }
                    else if (ctr.HasChildren == true && ctr.GetType().BaseType != typeof(UserControl))
                    {
                        GetControls(ctr.Controls);
                    }

                    #endregion
                }
            }
            return lControl;
        }
        private int GetBiggestLabel(List<Control> lcontrolContainer)
        {
            int iBiggestLabel = 0;
            int iLabel = 0;

            if (ContainsControleInContainer<HLP_TextBox>(lcontrolContainer))
            {
                iLabel = GetControlesInContainer<HLP_TextBox>(lcontrolContainer).Max(c => c._TamanhoLabel);
                iBiggestLabel = (iLabel > iBiggestLabel ? iLabel : iBiggestLabel);
            }
            if (ContainsControleInContainer<HLP_MaskedTextBox>(lcontrolContainer))
            {
                iLabel = (GetControlesInContainer<HLP_MaskedTextBox>(lcontrolContainer) as List<HLP_MaskedTextBox>).Max(c => c._TamanhoLabel);
                iBiggestLabel = (iLabel > iBiggestLabel ? iLabel : iBiggestLabel);
            }
            if (ContainsControleInContainer<HLP_NumericUpDown>(lcontrolContainer))
            {
                iLabel = (GetControlesInContainer<HLP_NumericUpDown>(lcontrolContainer) as List<HLP_NumericUpDown>).Max(c => c._TamanhoLabel);
                iBiggestLabel = (iLabel > iBiggestLabel ? iLabel : iBiggestLabel);
            }
            if (ContainsControleInContainer<HLP_DateTimePicker>(lcontrolContainer))
            {
                iLabel = (GetControlesInContainer<HLP_DateTimePicker>(lcontrolContainer) as List<HLP_DateTimePicker>).Max(c => c._TamanhoLabel);
                iBiggestLabel = (iLabel > iBiggestLabel ? iLabel : iBiggestLabel);
            }
            if (ContainsControleInContainer<HLP_ComboBox>(lcontrolContainer))
            {
                iLabel = (GetControlesInContainer<HLP_ComboBox>(lcontrolContainer) as List<HLP_ComboBox>).Max(c => c._TamanhoLabel);
                iBiggestLabel = (iLabel > iBiggestLabel ? iLabel : iBiggestLabel);
            }
            if (ContainsControleInContainer<HLP_CheckBox>(lcontrolContainer))
            {
                iLabel = (GetControlesInContainer<HLP_CheckBox>(lcontrolContainer) as List<HLP_CheckBox>).Max(c => c._TamanhoLabel);
                iBiggestLabel = (iLabel > iBiggestLabel ? iLabel : iBiggestLabel);
            }
            if (ContainsControleInContainer<HLP_ListBox>(lcontrolContainer))
            {
                iLabel = (GetControlesInContainer<HLP_ListBox>(lcontrolContainer) as List<HLP_ListBox>).Max(c => c._TamanhoLabel);
                iBiggestLabel = (iLabel > iBiggestLabel ? iLabel : iBiggestLabel);
            }
            if (ContainsControleInContainer<HLP_Pesquisa>(lcontrolContainer))
            {
                iLabel = (GetControlesInContainer<HLP_Pesquisa>(lcontrolContainer) as List<HLP_Pesquisa>).Max(c => c._TamanhoLabel);
                iBiggestLabel = (iLabel > iBiggestLabel ? iLabel : iBiggestLabel);
            }
            if (ContainsControleInContainer<HLP_Observacao>(lcontrolContainer))
            {
                iLabel = (GetControlesInContainer<HLP_Observacao>(lcontrolContainer) as List<HLP_Observacao>).Max(c => c._TamanhoLabel);
                iBiggestLabel = (iLabel > iBiggestLabel ? iLabel : iBiggestLabel);
            }

            return iBiggestLabel;
        }
        private bool ContainsControleInContainer<T>(List<Control> lcontrolContainer)
        {
            List<T> lcontrolsRet = lcontrolContainer.OfType<T>().ToList();

            if (lcontrolsRet.Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        private List<T> GetControlesInContainer<T>(List<Control> lcontrolContainer)
        {
            List<T> lcontrolsRet = lcontrolContainer.OfType<T>().ToList();
            return lcontrolsRet;
        }
        private List<Componente> GetConfigCompByForm(List<Control> lcontroles)
        {
            try
            {
                List<Componente> lLayout = new List<Componente>();
                Componente objLayout;

                #region HLP_TextBox
                foreach (HLP_TextBox comp in lcontroles.Where(c => c.GetType() == typeof(HLP_TextBox)).ToList())
                {
                    objLayout = new Componente();
                    objLayout.TypeComp = comp.GetType().Name;
                    objLayout.Color = comp.txt.BackColor.Name;
                    objLayout.Enabled = comp.Enabled;
                    objLayout.Field = comp._Field;
                    objLayout.LabelText = comp._LabelText;
                    objLayout.Name = comp.Name;
                    objLayout.Order = comp.Parent.Controls.IndexOf(comp);
                    objLayout.Parent = comp.Parent.Parent.Parent != null ? comp.Parent.Parent.Parent.Name : "HLP_Verificar";
                    objLayout.Table = comp._Table;
                    objLayout.Text = comp.Text;
                    objLayout.Visible = comp._Visible;
                    GetInfoField(objLayout);
                    objLayout.MaxLength = objLayout.BaseConfig.MaxLength;
                    objLayout.Help = comp._Help;
                    lLayout.Add(objLayout);
                }
                #endregion
                #region HLP_MaskTextBox
                foreach (HLP_MaskedTextBox comp in lcontroles.Where(c => c.GetType() == typeof(HLP_MaskedTextBox)).ToList())
                {
                    objLayout = new Componente();
                    objLayout.TypeComp = comp.GetType().Name;
                    objLayout.Color = comp.msk.BackColor.Name;
                    objLayout.Enabled = comp.Enabled;
                    objLayout.Field = comp._Field;
                    objLayout.LabelText = comp._LabelText;
                    objLayout.Name = comp.Name;
                    objLayout.Order = comp.Parent.Controls.IndexOf(comp);
                    objLayout.Parent = comp.Parent.Parent.Parent != null ? comp.Parent.Parent.Parent.Name : "HLP_Verificar";
                    objLayout.Table = comp._Table;
                    objLayout.Text = comp.Text;
                    objLayout.Visible = comp._Visible;
                    GetInfoField(objLayout);
                    objLayout.MaxLength = objLayout.BaseConfig.MaxLength;
                    objLayout.Help = comp._Help;
                    lLayout.Add(objLayout);

                }
                #endregion
                #region HLP_NumericUpDown
                foreach (HLP_NumericUpDown comp in lcontroles.Where(c => c.GetType() == typeof(HLP_NumericUpDown)).ToList())
                {
                    objLayout = new Componente();
                    objLayout.TypeComp = comp.GetType().Name;
                    objLayout.Color = comp.nud.BackColor.Name;
                    objLayout.Enabled = comp.Enabled;
                    objLayout.Field = comp._Field;
                    objLayout.LabelText = comp._LabelText;
                    objLayout.Name = comp.Name;
                    objLayout.Order = comp.Parent.Controls.IndexOf(comp);
                    objLayout.Parent = comp.Parent.Parent.Parent != null ? comp.Parent.Parent.Parent.Name : "HLP_Verificar";
                    objLayout.Table = comp._Table;
                    objLayout.Text = comp.Text;
                    objLayout.Visible = comp._Visible;
                    GetInfoField(objLayout);
                    objLayout.MaxLength = objLayout.BaseConfig.MaxLength;
                    objLayout.DecimalPlaces = objLayout.BaseConfig.DecimalPlaces;
                    objLayout.Help = comp._Help;
                    lLayout.Add(objLayout);

                }
                #endregion
                #region HLP_DateTimePicker
                foreach (HLP_DateTimePicker comp in lcontroles.Where(c => c.GetType() == typeof(HLP_DateTimePicker)).ToList())
                {
                    objLayout = new Componente();
                    objLayout.TypeComp = comp.GetType().Name;
                    objLayout.Color = comp.dtp.BackColor.Name;
                    objLayout.Enabled = comp.Enabled;
                    objLayout.Field = comp._Field;
                    objLayout.LabelText = comp._LabelText;
                    objLayout.Name = comp.Name;
                    objLayout.Order = comp.Parent.Controls.IndexOf(comp);
                    objLayout.Parent = comp.Parent.Parent.Parent != null ? comp.Parent.Parent.Parent.Name : "HLP_Verificar";
                    objLayout.Table = comp._Table;
                    objLayout.Text = comp.Text;
                    objLayout.Visible = comp._Visible;
                    GetInfoField(objLayout);
                    objLayout.Help = comp._Help;
                    lLayout.Add(objLayout);

                }
                #endregion
                #region HLP_ComboBox
                foreach (HLP_ComboBox comp in lcontroles.Where(c => c.GetType() == typeof(HLP_ComboBox)).ToList())
                {
                    objLayout = new Componente();
                    objLayout.TypeComp = comp.GetType().Name;
                    objLayout.Color = comp.cbx.BackColor.Name;
                    objLayout.Enabled = comp.Enabled;
                    objLayout.Field = comp._Field;
                    objLayout.LabelText = comp._LabelText;
                    objLayout.Name = comp.Name;
                    objLayout.Order = comp.Parent.Controls.IndexOf(comp);
                    objLayout.Parent = comp.Parent.Parent.Parent != null ? comp.Parent.Parent.Parent.Name : "HLP_Verificar";
                    objLayout.Table = comp._Table;
                    objLayout.Text = comp.Text;
                    objLayout.Visible = comp._Visible;
                    GetInfoField(objLayout);
                    objLayout.Help = comp._Help;
                    lLayout.Add(objLayout);
                }
                #endregion
                #region HLP_CheckBox
                foreach (HLP_CheckBox comp in lcontroles.Where(c => c.GetType() == typeof(HLP_CheckBox)).ToList())
                {
                    objLayout = new Componente();
                    objLayout.TypeComp = comp.GetType().Name;
                    objLayout.Color = comp.chk.BackColor.Name;
                    objLayout.Enabled = comp.Enabled;
                    objLayout.Field = comp._Field;
                    objLayout.LabelText = comp._LabelText;
                    objLayout.Name = comp.Name;
                    objLayout.Order = comp.Parent.Controls.IndexOf(comp);
                    objLayout.Parent = comp.Parent.Parent.Parent != null ? comp.Parent.Parent.Parent.Name : "HLP_Verificar";
                    objLayout.Table = comp._Table;
                    objLayout.Text = comp.Checked.ToString();
                    objLayout.Visible = comp._Visible;
                    GetInfoField(objLayout);
                    objLayout.Help = comp._Help;
                    lLayout.Add(objLayout);
                }
                #endregion
                #region HLP_ListBox
                foreach (HLP_ListBox comp in lcontroles.Where(c => c.GetType() == typeof(HLP_ListBox)).ToList())
                {
                    objLayout = new Componente();
                    objLayout.TypeComp = comp.GetType().Name;
                    objLayout.Color = comp.lst.BackColor.Name;
                    objLayout.Enabled = comp.Enabled;
                    objLayout.Field = comp._Field;
                    objLayout.LabelText = comp._LabelText;
                    objLayout.Name = comp.Name;
                    objLayout.Order = comp.Parent.Controls.IndexOf(comp);
                    objLayout.Parent = comp.Parent.Parent.Parent != null ? comp.Parent.Parent.Parent.Name : "HLP_Verificar";
                    objLayout.Table = comp._Table;
                    objLayout.Visible = comp._Visible;
                    GetInfoField(objLayout);
                    objLayout.Help = comp._Help;
                    lLayout.Add(objLayout);
                }
                #endregion
                #region HLP_Pesquisa
                foreach (HLP_Pesquisa comp in lcontroles.Where(c => c.GetType() == typeof(HLP_Pesquisa)).ToList())
                {
                    objLayout = new Componente();
                    objLayout.TypeComp = comp.GetType().Name;
                    objLayout.Enabled = comp.Enabled;
                    objLayout.Field = comp._Field;
                    objLayout.LabelText = comp._LabelText;
                    objLayout.Name = comp.Name;
                    objLayout.Order = comp.Parent.Controls.IndexOf(comp);
                    objLayout.Parent = comp.Parent.Parent.Parent != null ? comp.Parent.Parent.Parent.Name : "HLP_Verificar";
                    objLayout.Table = comp._Table;
                    objLayout.Visible = comp._Visible;
                    GetInfoField(objLayout);
                    objLayout.Help = comp._Help;
                    lLayout.Add(objLayout);
                }
                #endregion
                #region HLP_Observacao
                foreach (HLP_Observacao comp in lcontroles.Where(c => c.GetType() == typeof(HLP_Observacao)).ToList())
                {
                    objLayout = new Componente();
                    objLayout.TypeComp = comp.GetType().Name;
                    objLayout.Enabled = comp.Enabled;
                    objLayout.Field = comp._Field;
                    objLayout.LabelText = comp._LabelText;
                    objLayout.Name = comp.Name;
                    objLayout.Order = comp.Parent.Controls.IndexOf(comp);
                    objLayout.Parent = comp.Parent.Parent.Parent != null ? comp.Parent.Parent.Parent.Name : "HLP_Verificar";
                    objLayout.Table = comp._Table;
                    objLayout.Visible = comp._Visible;
                    GetInfoField(objLayout);
                    objLayout.Help = comp._Help;
                    lLayout.Add(objLayout);
                }
                #endregion

                return lLayout;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private List<Grid> GetConfigCompByColumn(List<HLP_DataGridView> lGridView)
        {
            try
            {
                List<Grid> lGrid = new List<Grid>();
                Grid objGrid = null;
                GridColumn col = null;
                string sParentTab = "";

                foreach (HLP_DataGridView grid in lGridView)
                {
                    sParentTab = "";
                    objGrid = new Grid();
                    objGrid.Name = grid.Name;
                    Control ctr = grid;
                    while (ctr.Parent != null)
                    {
                        if (ctr.Parent.GetType() == typeof(TabPage))
                        {
                            sParentTab = ((TabPage)ctr.Parent).Name;
                            break;
                        }
                        else
                        {
                            ctr = ctr.Parent;
                        }
                    }

                    objGrid.ParentTabName = sParentTab == "" ? objGrid.Name : sParentTab;
                    for (int i = 0; i < grid.ColumnCount; i++)
                    {
                        col = new GridColumn();
                        col.Name = grid.Columns[i].Name;
                        col.Table = grid.Tag.ToString();
                        col.DataPropertyName = grid.Columns[i].DataPropertyName;
                        col.TypeColumn = grid.Columns[i].GetType().Name.ToString();
                        col.HeaderText = grid.Columns[i].HeaderText;
                        col.Visible = grid.Columns[i].Visible;
                        GetInfoColumn(col);
                        col.DecimalPlaces = col.BaseConfigGrid.DecimalPlaces;
                        col.MaxLength = col.BaseConfigGrid.MaxLength;
                        col.DisplayIndex = grid.Columns[i].Index;
                        col.Help = grid.Columns[i].ToolTipText;

                        if (grid.Columns[i].GetType() == typeof(DataGridViewComboBoxColumn))
                        {
                            col.DisplayMember = ((DataGridViewComboBoxColumn)grid.Columns[i]).DisplayMember;
                        }
                        if (objGrid.DataGridColumn == null)
                        {
                            objGrid.DataGridColumn = new List<GridColumn>();
                        }
                        objGrid.DataGridColumn.Add(col);

                    }
                    lGrid.Add(objGrid);
                }

                return lGrid;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private List<FieldView> GetConfigFieldByView(string sViewName)
        {
            try
            {
                DataAccessor<FieldView> regFieldsView;

                regFieldsView = UndTrabalho.dbPrincipal
                      .CreateSqlStringAccessor(@"select COLUMN_NAME as 'Field', ORDINAL_POSITION as 'OrderFilter',ORDINAL_POSITION as 'OrderData' from INFORMATION_SCHEMA.COLUMNS
                                           where TABLE_NAME = @sViewName",
                                     new Parameters(UndTrabalho.dbPrincipal)
                                     .AddParameter<string>("sViewName"),
                      MapBuilder<FieldView>.MapAllProperties().DoNotMap(c => c.Data)
                                                               .DoNotMap(c => c.Filter).Build());

                return regFieldsView.Execute(sViewName).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void GetInfoField(Componente objLayout)
        {
            try
            {
                string table_name = objLayout.Table;
                string column_name = objLayout.Field;
                DataAccessor<InfoField> regInfoFieldAccessor = null;
                regInfoFieldAccessor = UndTrabalho.dbPrincipal
                  .CreateSprocAccessor("sp_columns",
                                  new Parameters(UndTrabalho.dbPrincipal)
                                  .AddParameter<string>("table_name")
                                  .AddParameter<string>("column_name"),
                                  MapBuilder<InfoField>.MapAllProperties().Build());
                InfoField objInfoField = null;
                try
                {


                    objInfoField = regInfoFieldAccessor.Execute(table_name, column_name).FirstOrDefault();
                }
                catch (Exception ex)
                {

                    throw;
                }
                if (objInfoField != null)
                {
                    switch (objLayout.TypeComp)
                    {
                        case "HLP_TextBox":
                            {

                                objLayout.BaseConfig.MaxLength = Convert.ToInt32(objInfoField.PRECISION);
                                objLayout.BaseConfig.Required = (objInfoField.NULLABLE.Equals("0") ? true : false);
                                objLayout.BaseConfig.Type = objInfoField.TYPE_NAME;
                                if (objLayout.MaxLength > objLayout.BaseConfig.MaxLength)
                                {
                                    objLayout.MaxLength = objLayout.BaseConfig.MaxLength;
                                }


                            }
                            break;
                        case "HLP_MaskedTextBox":
                            {
                                objLayout.BaseConfig.MaxLength = Convert.ToInt32(objInfoField.PRECISION);
                                objLayout.BaseConfig.Type = objInfoField.TYPE_NAME;
                                objLayout.BaseConfig.Required = (objInfoField.NULLABLE.Equals("0") ? true : false);
                                if (objLayout.MaxLength > objLayout.BaseConfig.MaxLength)
                                {
                                    objLayout.MaxLength = objLayout.BaseConfig.MaxLength;
                                }

                            }
                            break;
                        case "HLP_NumericUpDown":
                            {
                                objLayout.BaseConfig.DecimalPlaces = Convert.ToInt32(objInfoField.SCALE);
                                objLayout.BaseConfig.MaxLength = Convert.ToDecimal(("").PadLeft(Convert.ToInt32(objInfoField.PRECISION) - Convert.ToInt32(objInfoField.SCALE), '9'));
                                objLayout.BaseConfig.Required = (objInfoField.NULLABLE.Equals("0") ? true : false);
                                objLayout.BaseConfig.Type = objInfoField.TYPE_NAME;
                                if (objLayout.DecimalPlaces > objLayout.BaseConfig.DecimalPlaces)
                                {
                                    objLayout.DecimalPlaces = objLayout.BaseConfig.DecimalPlaces;
                                }
                                if (objLayout.MaxLength > objLayout.BaseConfig.MaxLength)
                                {
                                    objLayout.MaxLength = objLayout.BaseConfig.MaxLength;
                                }
                            }
                            break;
                        case "HLP_DateTimePicker":
                            {

                                objLayout.BaseConfig.Required = (objInfoField.NULLABLE.Equals("0") ? true : false);
                                objLayout.BaseConfig.Type = objInfoField.TYPE_NAME;

                            }
                            break;
                        case "HLP_ComboBox":
                            {
                                objLayout.BaseConfig.Required = (objInfoField.NULLABLE.Equals("0") ? true : false);
                                objLayout.BaseConfig.Type = objInfoField.TYPE_NAME;

                            }
                            break;
                        case "HLP_CheckBox":
                            {
                                objLayout.BaseConfig.Required = (objInfoField.NULLABLE.Equals("0") ? true : false);
                                objLayout.BaseConfig.Type = objInfoField.TYPE_NAME;
                            }
                            break;
                        case "HLP_Pesquisa":
                            {

                                objLayout.BaseConfig.Required = (objInfoField.NULLABLE.Equals("0") ? true : false);
                                objLayout.BaseConfig.Type = objInfoField.TYPE_NAME;

                            }
                            break;
                    }
                }
                else
                {
                    Console.WriteLine(String.Format("Erro: Campo {0} ou Tabela {1} não foram encontrados, Componente: {2}.", column_name, table_name, objLayout.Name));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void GetInfoColumn(GridColumn col)
        {
            try
            {
                string table_name = col.Table;
                string column_name = col.DataPropertyName;
                DataAccessor<InfoField> regInfoFieldAccessor = null;
                regInfoFieldAccessor = UndTrabalho.dbPrincipal
                  .CreateSprocAccessor("sp_columns",
                                  new Parameters(UndTrabalho.dbPrincipal)
                                  .AddParameter<string>("table_name")
                                  .AddParameter<string>("column_name"),
                                  MapBuilder<InfoField>.MapAllProperties().Build());


                InfoField objInfoField = regInfoFieldAccessor.Execute(table_name, column_name).FirstOrDefault();
                if (objInfoField != null)
                {
                    switch (col.TypeColumn)
                    {
                        case "KryptonDataGridViewTextBoxColumn":
                        case "DataGridViewTextBoxColumn":
                            {
                                col.BaseConfigGrid.MaxLength = Convert.ToInt32(objInfoField.PRECISION);
                                col.BaseConfigGrid.Required = (objInfoField.NULLABLE.Equals("0") ? true : false);
                                col.BaseConfigGrid.Type = objInfoField.TYPE_NAME;
                                if (col.MaxLength > col.BaseConfigGrid.MaxLength)
                                {
                                    col.MaxLength = col.BaseConfigGrid.MaxLength;
                                }
                            }
                            break;
                        case "KryptonDataGridViewMaskedTextBoxColumn":
                            {
                                col.BaseConfigGrid.MaxLength = Convert.ToInt32(objInfoField.PRECISION);
                                col.BaseConfigGrid.Type = objInfoField.TYPE_NAME;
                                col.BaseConfigGrid.Required = (objInfoField.NULLABLE.Equals("0") ? true : false);
                                if (col.MaxLength > col.BaseConfigGrid.MaxLength)
                                {
                                    col.MaxLength = col.BaseConfigGrid.MaxLength;
                                }
                            }
                            break;
                        case "KryptonDataGridViewNumericUpDownColumn":
                            {
                                col.BaseConfigGrid.MaxLength = Convert.ToDecimal(("").PadLeft(Convert.ToInt32(objInfoField.PRECISION) - Convert.ToInt32(objInfoField.SCALE), '9'));
                                col.BaseConfigGrid.DecimalPlaces = Convert.ToInt32(objInfoField.SCALE);
                                col.BaseConfigGrid.Required = (objInfoField.NULLABLE.Equals("0") ? true : false);
                                col.BaseConfigGrid.Type = objInfoField.TYPE_NAME;
                                if (col.DecimalPlaces > col.BaseConfigGrid.DecimalPlaces)
                                {
                                    col.DecimalPlaces = col.BaseConfigGrid.DecimalPlaces;
                                }
                                if (col.MaxLength > col.BaseConfigGrid.MaxLength)
                                {
                                    col.MaxLength = col.BaseConfigGrid.MaxLength;
                                }
                            }
                            break;
                        case "KryptonDataGridViewDateTimePickerColumn":
                            {
                                col.BaseConfigGrid.Required = (objInfoField.NULLABLE.Equals("0") ? true : false);
                                col.BaseConfigGrid.Type = objInfoField.TYPE_NAME;
                            }
                            break;
                        case "KryptonDataGridViewComboBoxColumn":
                        case "DataGridViewComboBoxColumn":
                            {
                                col.BaseConfigGrid.Required = (objInfoField.NULLABLE.Equals("0") ? true : false);
                                col.BaseConfigGrid.Type = objInfoField.TYPE_NAME;
                            }
                            break;
                        case "KryptonDataGridViewCheckBoxColumn":
                        case "DataGridViewCheckBoxColumn":
                            {
                                col.BaseConfigGrid.Required = (objInfoField.NULLABLE.Equals("0") ? true : false);
                                col.BaseConfigGrid.Type = objInfoField.TYPE_NAME;
                            }
                            break;
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private string GetPathXmlForm(string nameForm)
        {
            return Pastas.Path_SettingsUser + nameForm + ".xml";
        }

        private ConfigFormSerializer Deserialize(string PathSave)
        {
            return SerializeClassToXml.DeserializeClasse<ConfigFormSerializer>(PathSave);
        }
        #endregion







    }
}
