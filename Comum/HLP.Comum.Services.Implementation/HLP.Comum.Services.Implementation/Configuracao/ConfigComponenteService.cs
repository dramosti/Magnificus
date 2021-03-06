﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Services.Interface.Configuracao;
using Ninject;
using HLP.Comum.Repository.Interfaces.Configuracao;
using HLP.Comum.Infrastructure;
using HLP.Comum.Components;
using HLP.Comum.Infrastructure.Static;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using HLP.Comum.Models;
using HLP.Services.Interfaces.Entries.Parametros;
using HLP.Models.Entries.Parametros;
using System.Drawing;
using HLP.Comum.Messages;


namespace HLP.Comum.Services.Implementation.Configuracao
{
    public class ConfigComponenteService : IConfigComponenteService
    {
        [Inject]
        public IConfigComponenteRepository icomponenteRepository { get; set; }

        [Inject]
        public IConfigColunasGridService colunasGridService { get; set; }

        private List<ConfigComponenteModel> lobjConfigComponente { get; set; }


        /// <summary>
        /// Busca as Configurações dos componentes salvos na base de dados.
        /// </summary>
        /// <param name="idTabPage"></param>
        /// <param name="idUsuario"></param>
        /// <returns></returns>
        public List<ConfigComponenteModel> GetAllCompByTabPage(int idTabPage, int idUsuario)
        {
            try
            {
                List<ConfigComponenteModel> lComponente = icomponenteRepository.GetAllCompByTabPage(idTabPage);


                foreach (ConfigComponenteModel componente in lComponente)
                {
                    if (componente.xTypeComp == typeof(HLP.Comum.Components.HLP_DataGridView).Name)
                    {
                        componente.objConfigCompGridUsu = icomponenteRepository.GetConfigCompGridUsu((int)componente.idComponente, idUsuario);
                        //componente.objConfigCompUsu = null;
                        componente.lConfigColunasGrid = colunasGridService.GetAllColByGrid((int)componente.idComponente, idUsuario, componente.xTable); //verificar
                    }
                    else
                    {
                        componente.objConfigCompUsu = icomponenteRepository.GetConfigCompUsu((int)componente.idComponente, idUsuario);

                        if (componente.Base != null)
                        {
                            if (componente.xTypeComp.Equals("HLP_NumericUpDown")) // analisar lógica
                            {
                                componente.objConfigCompUsu.nMaxLength = componente.Base.GetMaxLeghtToNumericUpDown();
                                componente.objConfigCompUsu.nDecimalPlaces = componente.Base.SCALE.ToInt32();
                            }
                            else
                            {
                                //componente.objConfigCompUsu.nMaxLength = componente.Base.GetMaxLenghtNormal();
                            }
                        }

                        //componente.objConfigCompGridUsu = null;
                        //componente.lConfigColunasGrid = null;
                    }
                }
                return lComponente;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public Models.InfoFieldModel GetInfoField(string table_name, string column_name)
        {
            return icomponenteRepository.GetInfoField(table_name, column_name);
        }

        /// <summary>
        /// Método que Carrega as informações dos componentes contidos dentro do Container TabPage.
        /// </summary>
        /// <param name="ctr"></param>
        /// <param name="tab"></param>
        public void GetInfoCompByTabePage(ConfigTabPageModel tab, List<Control> lControl)
        {
            List<Control> lControlsContainer = lControl.Where(c => (c.GetType().BaseType == typeof(UserControlBase)) || (c.GetType() == typeof(HLP_DataGridView))).ToList()
                .Where(c => c.GetPropertyValue("_sNameTabPage").ToString() == tab.xNameTab).ToList();

            ConfigComponenteModel comp;
            foreach (Control controle in lControlsContainer.Where(c => c.GetType() != typeof(HLP_LabelSeparator)))
            {
                try
                {
                    comp = new ConfigComponenteModel();
                    //Default Info
                    comp.xName = controle.Name;
                    comp.xTypeComp = controle.GetType().Name;

                    if (controle.GetType().BaseType == typeof(UserControlBase))
                    {
                        try
                        {
                            #region Component Info

                            UserControlBase objUserControl = controle as UserControlBase;

                            //Base Info
                            comp.xField = objUserControl._Field;
                            comp.xTable = objUserControl._Table;

                            // User Info                        
                            comp.objConfigCompUsu.nOrder = controle.Parent.Controls.IndexOf(controle);
                            comp.objConfigCompUsu.xLabelText = objUserControl._LabelText;
                            comp.objConfigCompUsu.xText = "";//Verificar
                            comp.objConfigCompUsu.stVisible = 1;
                            comp.objConfigCompUsu.stEnabled = controle.Enabled.ToByte();
                            if (objUserControl._HlpGroup != null)
                                comp.objConfigCompUsu.xLabelGroup = objUserControl._HlpGroup.Name;

                            // the property color is not common for all components.
                            try
                            {
                                Color cor = (Color)controle.ToObject().GetPropertyValue("Color");
                                comp.objConfigCompUsu.xColor = cor.ToArgb().ToString();
                            }
                            catch (Exception) { }

                            comp.objConfigCompUsu.xParent = objUserControl._sNameTabPage;
                            comp.objConfigCompUsu.xHelp = objUserControl._Help;
                            comp.objConfigCompUsu.stAtivo = true.ToByte();//Dafault
                            comp.objConfigCompUsu.stAcesso = true.ToByte(); //Dafault
                            comp.objConfigCompUsu.iTamanhoComponente = controle.Width;

                            if (comp.xField != "" && comp.xTable == "")
                            {
                                throw new Exception(string.Format("Esta faltando preencher propriedades no componente {0} ", comp.xName));
                            }
                            if (comp.xTable != "" && comp.xField == "")
                            {
                                throw new Exception(string.Format("Esta faltando preencher propriedades no componente {0} ", comp.xName));
                            }

                            if (comp.xField != "" && comp.xTable != "")
                            {
                                comp.Base = this.GetInfoField(comp.xTable, comp.xField);
                                if (comp.Base != null)
                                {
                                    if (comp.xTypeComp.Equals("HLP_NumericUpDown"))
                                    {
                                        comp.objConfigCompUsu.xText = "0";
                                        comp.objConfigCompUsu.nMaxLength = comp.Base.GetMaxLeghtToNumericUpDown();
                                        comp.objConfigCompUsu.nDecimalPlaces = comp.Base.SCALE.ToInt32();
                                    }
                                    else
                                    {
                                        comp.objConfigCompUsu.nMaxLength = comp.Base.GetMaxLenghtNormal();
                                    }
                                }
                                else
                                {
                                    HLPMessageBox.ShowAviso(string.Format("Dados não encontrado na base de dados do campo {0} da tabela {1}, componente: {2}", comp.xField, comp.xTable, comp.xName));
                                }
                            }
                            #endregion
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(string.Format("Erro ao buscar informações do componente:{0} - tipo:{1}, que se encontra na TabPage:{2}{3}Erro: ", comp.xName, comp.xTypeComp, tab.xNameTab, Environment.NewLine) + ex.Message);
                        }
                    }
                    else if (controle.GetType() == typeof(HLP_DataGridView))
                    {
                        try
                        {
                            #region DataGridView Info
                            HLP_DataGridView grid = controle as HLP_DataGridView;
                            comp.xTable = grid.Tag != null ? grid.Tag.ToString() : "";

                            //comp.objConfigCompGridUsu.idUsuario = UserData.idUserHLP;
                            comp.objConfigCompGridUsu.stInclusao = true.ToByte();
                            comp.objConfigCompGridUsu.stExclusao = true.ToByte();
                            comp.objConfigCompGridUsu.stAlteracao = true.ToByte();

                            ConfigColunasGridModel col = null;
                            foreach (DataGridViewColumn dgvCol in grid.Columns)
                            {
                                col = new ConfigColunasGridModel();
                                col.xNameColuna = dgvCol.Name;
                                col.xDataPropertyName = dgvCol.DataPropertyName;

                                // User Config
                                col.objColunasGridUsu.xHeaderText = dgvCol.HeaderText;
                                col.objColunasGridUsu.stVisible = dgvCol.Visible.ToByte();
                                col.objColunasGridUsu.stAtivo = true.ToByte();
                                col.objColunasGridUsu.stAcesso = true.ToByte();
                                //col.objColunasGridUsu.idUsuario = UserData.idUserHLP;
                                col.objColunasGridUsu.nWidth = dgvCol.Width;

                                col.Base = this.GetInfoField(comp.xTable, col.xDataPropertyName);
                                if (col.Base != null)
                                {
                                    col.xType = col.Base.TYPE_NAME;
                                    if (dgvCol.GetType() == typeof(KryptonDataGridViewNumericUpDownColumn))
                                    {
                                        col.objColunasGridUsu.nMaxLength = col.Base.GetMaxLeghtToNumericUpDown();
                                        col.objColunasGridUsu.nDecimalPlaces = col.Base.SCALE.ToInt32();
                                    }
                                    else
                                    {
                                        col.objColunasGridUsu.nMaxLength = col.Base.GetMaxLenghtNormal();
                                    }
                                }
                                else
                                {
                                    HLPMessageBox.ShowAviso(string.Format("Erro ao buscar informações do campo {0}. da Tabelda {1}", col.xDataPropertyName, comp.xTable));
                                    //throw new Exception(string.Format("Erro ao buscar informações do campo {0}. da Tabelda {1}", col.xDataPropertyName, comp.xTable));
                                }

                                col.objColunasGridUsu.nDisplayIndex = dgvCol.Index;
                                col.objColunasGridUsu.xHelp = dgvCol.ToolTipText;


                                if (dgvCol.GetType() == typeof(DataGridViewComboBoxColumn))
                                {
                                    col.objColunasGridUsu.xDisplayMember = ((DataGridViewComboBoxColumn)dgvCol).DisplayMember;
                                }
                                comp.lConfigColunasGrid.Add(col);
                            }
                            #endregion
                        }
                        catch (Exception ex)
                        {
                            HLPMessageBox.ShowAviso(string.Format("Erro ao buscar informações do componente:{0} - tipo:{1}, que se encontra na TabPage:{2}{3} Erro:", comp.xName, comp.xTypeComp, tab.xNameTab, Environment.NewLine) + ex.Message);
                        }
                    }
                    tab.lConfigComponente.Add(comp);
                    if (lobjConfigComponente == null)
                    {
                        lobjConfigComponente = new List<ConfigComponenteModel>();
                    }
                    lobjConfigComponente.Add(comp);

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }

        public void SetConfigToComp(List<ConfigComponenteModel> lCompModel, List<Control> lControl)
        {
            bool Upper = CompanyData.stMaiusculo;
            HLP_Group groupSeparador = null;
            foreach (ConfigComponenteModel objCompModel in lCompModel)
            {
                try
                {
                    Control controle = lControl.FirstOrDefault(c => c.Name == objCompModel.xName);
                    if (controle != null)
                    {
                        if (controle.GetType().BaseType == typeof(UserControlBase))
                        {
                            groupSeparador = null;
                            try
                            {
                                if (objCompModel.objConfigCompUsu.xLabelGroup != null)
                                {
                                    groupSeparador = (HLP_Group)lControl.FirstOrDefault(c => c.Name == objCompModel.objConfigCompUsu.xLabelGroup);
                                    (controle as UserControlBase).objConfigComponenteModel = objCompModel;
                                    groupSeparador.Add(controle, (controle as UserControlBase).objConfigComponenteModel.objConfigCompUsu.nOrder);
                                }
                                if (controle.GetType() == typeof(HLP_TextBox))
                                {
                                    (controle as UserControlBase).CarregaComponente();
                                }
                                else
                                {
                                    #region Component Info

                                    controle.TabIndex = objCompModel.objConfigCompUsu.nOrder;
                                    (controle.Parent as FlowLayoutPanel).Controls.SetChildIndex(controle, controle.TabIndex);
                                    controle.SetPropertyValue("_LabelText", objCompModel.objConfigCompUsu.xLabelText);
                                    // Valor Padrão não tratado TEXT
                                    controle.SetPropertyValue("_Visible", Convert.ToBoolean(objCompModel.objConfigCompUsu.stVisible));
                                    controle.SetPropertyValue("Enabled", Convert.ToBoolean(objCompModel.objConfigCompUsu.stEnabled));

                                    if (!objCompModel.xName.Equals("txtCodigo"))
                                    {
                                        if (!(objCompModel.Base == null))
                                        {
                                            if (objCompModel.Base.NULLABLE.Equals("0"))
                                            {
                                                controle.SetPropertyValue("_Obrigatorio", HLP_TextBox.CampoObrigatorio.SIM);
                                            }

                                        }
                                        else
                                            controle.SetPropertyValue("_Obrigatorio", HLP_TextBox.CampoObrigatorio.NÃO);
                                    }
                                    else
                                    {
                                        controle.SetPropertyValue("_Obrigatorio", HLP_TextBox.CampoObrigatorio.NÃO);
                                    }


                                    // controle.SetPropertyValue("_Obrigatorio", objCompModel.Base == null ? HLP_TextBox.CampoObrigatorio.NÃO : (objCompModel.Base.NULLABLE == "1" && !objCompModel.xName.Equals("txtCodigo") ? HLP_TextBox.CampoObrigatorio.SIM : HLP_TextBox.CampoObrigatorio.NÃO));

                                    //  controle.SetPropertyValue("_Obrigatorio",              controle.ToObject().GetPropertyValue("_Obrigatorio").ToString());


                                    try
                                    { controle.SetPropertyValue("CharacterCasing", (Upper ? CharacterCasing.Upper : CharacterCasing.Normal)); }
                                    catch (Exception) { }

                                    try
                                    {//controle.BackColor= onjCompModel.ToObject().GetPropertyValue("Color").ToString();
                                    }
                                    catch (Exception) { }
                                    controle.SetPropertyValue("_Help", objCompModel.objConfigCompUsu.xHelp);

                                    if (objCompModel.objConfigCompUsu.stAtivo == 0)
                                        controle.Visible = true;

                                    if (objCompModel.objConfigCompUsu.stAtivo == 0)
                                        controle.Enabled = false;

                                    if (objCompModel.xField != "" && objCompModel.xTable != "")
                                    {

                                        if (objCompModel.xTypeComp == typeof(HLP_NumericUpDown).Name)
                                        {
                                            controle.SetPropertyValue("Maximum", objCompModel.objConfigCompUsu.nMaxLength);
                                            controle.SetPropertyValue("DecimalPlaces", objCompModel.objConfigCompUsu.nDecimalPlaces);
                                            controle.SetPropertyValue("Text", objCompModel.objConfigCompUsu.xText);
                                        }
                                        else
                                        {
                                            try
                                            { controle.SetPropertyValue("MaxLength", objCompModel.objConfigCompUsu.nMaxLength.ToInt32()); }
                                            catch (Exception) { }
                                        }
                                    }
                                    else
                                    {
                                        if (objCompModel.xTypeComp == typeof(HLP_NumericUpDown).Name)
                                            controle.SetPropertyValue("Text", "0");

                                    }



                                    #endregion
                                }
                            }
                            catch (Exception ex)
                            {
                                throw new Exception(string.Format("Erro ao Configurar componente:{0} - tipo:{1}, {2}Erro: ", objCompModel.xName, objCompModel.xTypeComp, Environment.NewLine) + ex.Message);
                            }
                        }
                        else if (controle.GetType() == typeof(HLP_DataGridView))
                        {
                            try
                            {
                                #region DataGridView Info
                                HLP_DataGridView grid = controle as HLP_DataGridView;

                                grid.AllowUserToOrderColumns = true;
                                grid.AllowUserToResizeColumns = true;
                                grid.RowHeadersWidth = 15;
                                grid.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Segoe UI", 8.25F);
                                grid.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Segoe UI", 8.25F);


                                grid.Inclui = Convert.ToBoolean(objCompModel.objConfigCompGridUsu.stInclusao);
                                grid.Exclui = Convert.ToBoolean(objCompModel.objConfigCompGridUsu.stExclusao);
                                grid.Altera = Convert.ToBoolean(objCompModel.objConfigCompGridUsu.stAlteracao);

                                ConfigColunasGridModel objColModel = null;
                                foreach (DataGridViewColumn dgvCol in grid.Columns)
                                {
                                    dgvCol.MinimumWidth = 100;
                                    objColModel = objCompModel.lConfigColunasGrid.FirstOrDefault(c => c.xNameColuna == dgvCol.Name);

                                    // User Config
                                    dgvCol.HeaderText = Util.ToUpperFirstLetter(objColModel.objColunasGridUsu.xHeaderText);
                                    dgvCol.ToolTipText = Util.ToUpperFirstLetter(objColModel.objColunasGridUsu.xHelp);
                                    dgvCol.DisplayIndex = objColModel.objColunasGridUsu.nDisplayIndex.ToInt32();

                                    dgvCol.Visible = Convert.ToBoolean(objColModel.objColunasGridUsu.stVisible);

                                    if (objColModel.objColunasGridUsu.stAtivo == 0)
                                        dgvCol.Visible = true;

                                    if (objColModel.objColunasGridUsu.stAcesso == 0)
                                        dgvCol.ReadOnly = true;


                                    if (objColModel.objColunasGridUsu.nWidth.ToInt32() != 0)
                                    {
                                        dgvCol.Width = objColModel.objColunasGridUsu.nWidth.ToInt32();
                                    }
                                    else
                                    {
                                        if (grid.ColumnCount > 5)
                                        {
                                            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                                            dgvCol.Width = 250;
                                        }
                                        else
                                        {
                                            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                        }
                                    }

                                    if (dgvCol.GetType() == typeof(KryptonDataGridViewNumericUpDownColumn))
                                    {
                                        try
                                        {

                                            KryptonDataGridViewNumericUpDownColumn nud = dgvCol as KryptonDataGridViewNumericUpDownColumn;
                                            nud.Maximum = Convert.ToDecimal(objColModel.objColunasGridUsu.nMaxLength);
                                            nud.DecimalPlaces = objColModel.objColunasGridUsu.nDecimalPlaces.ToInt32();
                                        }
                                        catch (Exception)
                                        {
                                            throw;
                                        }
                                    }
                                    else if (dgvCol.GetType() == typeof(DataGridViewComboBoxColumn))
                                    {
                                        ((DataGridViewComboBoxColumn)dgvCol).DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;

                                        if (objColModel.xType == "tinyint")
                                        {
                                            ((DataGridViewComboBoxColumn)dgvCol).ValueMember = "ValueMemberTiny";
                                            ((DataGridViewComboBoxColumn)dgvCol).DisplayMember = "DisplayMember";

                                            List<ComboBoxColumnModel> objboCombo = new List<ComboBoxColumnModel>();
                                            int icount = 0;
                                            foreach (object item in ((DataGridViewComboBoxColumn)dgvCol).Items)
                                            {
                                                objboCombo.Add(new ComboBoxColumnModel { DisplayMember = (item.GetType() == typeof(System.String) ? item.ToString() : ((ComboBoxColumnModel)item).DisplayMember), ValueMember = icount, ValueMemberTiny = Convert.ToByte(icount) });
                                                icount++;
                                            }
                                            ((DataGridViewComboBoxColumn)dgvCol).DataSource = objboCombo;
                                        }
                                    }
                                    else
                                    {
                                        try
                                        {
                                            dgvCol.SetPropertyValue("MaxInputLength", objColModel.objColunasGridUsu.nMaxLength.ToInt32());
                                        }
                                        catch (Exception) { }
                                    }
                                }
                                #endregion
                            }
                            catch (Exception ex)
                            {
                                throw new Exception(string.Format("Erro ao configurar o componente:{0} - tipo:{1}, que se encontra na TabPage:{2}{3} Erro:", objCompModel.xName, objCompModel.xTypeComp, "a tratar", Environment.NewLine) + ex.Message);
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }

        public List<ConfigComponenteModel> GetListaControlesConfigComponenteModel()
        {
            return lobjConfigComponente;
        }

        public void Save(ConfigComponenteModel componente)
        {
            icomponenteRepository.Save(componente);
        }
    }
}
