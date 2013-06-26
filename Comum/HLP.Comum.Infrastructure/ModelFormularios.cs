using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Models;
using HLP.Comum.Models.Static;

namespace HLP.Comum.Infrastructure
{

    public class RelatoriosModel
    {
        [ParameterOrder(Order = 1)]
        public int? idRelatorio { get; set; }
        [ParameterOrder(Order = 2)]
        public int idFormularios { get; set; }
        [ParameterOrder(Order = 3)]
        public string xNomeRelatorio { get; set; }
        [ParameterOrder(Order = 4)]
        public bool stAtivo { get; set; }
        [ParameterOrder(Order = 5)]
        public string xNomeFisico { get; set; }
        [ParameterOrder(Order = 6)]
        public string xDetalhes { get; set; }

    }

    public class ConfigFormulariosModel
    {
        public int? _idFormularios;

        [ParameterOrder(Order = 1)]
        public int? idFormularios
        {
            get { return _idFormularios; }
            set
            {
                _idFormularios = value;
                objConfigFormUsu.idFormularios = value;
                SetPropertyTabPageRecursivo(objConfigTabPage, "idFormularios", value);
            }
        }
        [ParameterOrder(Order = 2)]
        public string xNameFormulario { get; set; }
        [ParameterOrder(Order = 3)]
        public string xNameView { get; set; }
        [ParameterOrder(Order = 4)]
        public string xTable { get; set; }

        /// <summary>
        /// Property para controlar os componentes sem a necessidade de métodos recusrsivos.
        /// </summary>
        public List<ConfigComponenteModel> lobjConfigComponente = new List<ConfigComponenteModel>();
        public List<CONFIG_PesquisaModel> lPesquisa { get; set; }

        public ConfigFormularioUsuModel objConfigFormUsu = new ConfigFormularioUsuModel();
        public List<RelatoriosModel> lRelatorios = new List<RelatoriosModel>();
        public ConfigTabPageModel objConfigTabPage = new ConfigTabPageModel();


        public void SetIdNullAllClasses()
        {
            //this.idFormularios = null;
            this.objConfigFormUsu.idFormularioUsuario = null;
            SetIdNullTabPagRecursivo(this.objConfigTabPage);
        }
        public void SetIdUsuario(int idUsuario)
        {
            this.objConfigFormUsu.idUsuario = idUsuario;
            foreach (CONFIG_PesquisaModel pesq in this.lPesquisa)
            {
                pesq.idUsuario = idUsuario;
            }
            SetIdUserRecursivo(this.objConfigTabPage, idUsuario);
        }


        private void SetIdNullTabPagRecursivo(ConfigTabPageModel objTabPage)
        {
            //objTabPage.idTabPage = null;
            //objTabPage.idTabPagePai = null;
            objTabPage.objConfigTabPageUsu.idTabPageUsuario = null;
            foreach (ConfigComponenteModel comp in objTabPage.lConfigComponente)
            {
                //comp.idComponente = null;

                comp.objConfigCompUsu.idComponenteUsuario = null;
                //comp.objConfigCompUsu.idComponente = null;

                comp.objConfigCompGridUsu.idCompGridUsuario = null;
                //comp.objConfigCompGridUsu.idComponente = null;

                foreach (ConfigColunasGridModel coluna in comp.lConfigColunasGrid)
                {
                    //coluna.idColunasGrid = null;
                    coluna.objColunasGridUsu.idColunasGridUsuario = null;
                }
            }

            foreach (ConfigTabPageModel tab in objTabPage.lConfigTabPageModel)
            {
                SetIdNullTabPagRecursivo(tab);
            }
        }
        private void SetIdUserRecursivo(ConfigTabPageModel objTabPage, int idUsuario)
        {

            objTabPage.objConfigTabPageUsu.idUsuario = idUsuario;
            foreach (ConfigComponenteModel comp in objTabPage.lConfigComponente)
            {
                comp.objConfigCompUsu.idUsuario = idUsuario;
                comp.objConfigCompGridUsu.idUsuario = idUsuario;
                comp.objConfigCompUsu.idUsuario = idUsuario;

                foreach (ConfigColunasGridModel coluna in comp.lConfigColunasGrid)
                {
                    coluna.objColunasGridUsu.idUsuario = idUsuario;
                }
            }

            foreach (ConfigTabPageModel tab in objTabPage.lConfigTabPageModel)
            {
                SetIdUserRecursivo(tab, idUsuario);
            }
        }
        private void SetPropertyTabPageRecursivo(ConfigTabPageModel objConfigTab, string sProperty, object value)
        {
            (objConfigTab as object).SetPropertyValue(sProperty, value);

            foreach (ConfigTabPageModel item in objConfigTab.lConfigTabPageModel)
            {
                SetPropertyTabPageRecursivo(item, sProperty, value);
            }
        }
    }

    public class ConfigFormularioUsuModel
    {
        [ParameterOrder(Order = 1)]
        public int? idFormularioUsuario { get; set; }
        [ParameterOrder(Order = 2)]
        public int? idFormularios { get; set; }
        [ParameterOrder(Order = 3)]
        public int? idUsuario { get; set; }
        [ParameterOrder(Order = 4)]
        public string xText { get; set; }
        [ParameterOrder(Order = 5)]
        public byte stAtivo { get; set; }
        [ParameterOrder(Order = 6)]
        public byte stInclusao { get; set; }
        [ParameterOrder(Order = 7)]
        public byte stExclusao { get; set; }
        [ParameterOrder(Order = 8)]
        public byte stAlteracao { get; set; }
        [ParameterOrder(Order = 9)]
        public byte stAcesso { get; set; }

    }


    public class CONFIG_PesquisaModel
    {
        [ParameterOrder(Order = 1)]
        public int? idPesquisa { get; set; }
        [ParameterOrder(Order = 2)]
        public int idFormularios { get; set; }
        [ParameterOrder(Order = 3)]
        public string xField { get; set; }
        [ParameterOrder(Order = 4)]
        public bool stFilter { get; set; }
        [ParameterOrder(Order = 5)]
        public bool stData { get; set; }
        [ParameterOrder(Order = 6)]
        public int iOrderFilter { get; set; }
        [ParameterOrder(Order = 7)]
        public int iOrderData { get; set; }
        [ParameterOrder(Order = 8)]
        public int idUsuario { get; set; }
    }

    public class ConfigTabPageModel
    {

        private int? _idTabPage;
        [ParameterOrder(Order = 1)]
        public int? idTabPage
        {
            get { return _idTabPage; }
            set
            {
                _idTabPage = value;
                if (value != null)
                {
                    this.objConfigTabPageUsu.idTabPage = value.ToInt32();
                    foreach (ConfigComponenteModel comp in this.lConfigComponente)
                    {
                        comp.idTabPage = value.ToInt32();
                    }
                }

            }
        }
        [ParameterOrder(Order = 2)]
        public string xNameTab { get; set; }
        [ParameterOrder(Order = 3)]
        public int? idFormularios { get; set; }
        [ParameterOrder(Order = 4)]
        public int? idTabPagePai { get; set; }

        public ConfigTabPageUsuModel objConfigTabPageUsu = new ConfigTabPageUsuModel();
        public List<ConfigTabPageModel> lConfigTabPageModel = new List<ConfigTabPageModel>();
        public List<ConfigComponenteModel> lConfigComponente = new List<ConfigComponenteModel>();

    }

    public class ConfigTabPageUsuModel
    {
        [ParameterOrder(Order = 1)]
        public int? idTabPageUsuario { get; set; }
        [ParameterOrder(Order = 2)]
        public int? idUsuario { get; set; }
        [ParameterOrder(Order = 3)]
        public int? idTabPage { get; set; }
        [ParameterOrder(Order = 4)]
        public string xTabPage { get; set; }
        [ParameterOrder(Order = 5)]
        public string xHelp { get; set; }
        [ParameterOrder(Order = 6)]
        public byte? stAtivo { get; set; }


    }

    public class ConfigComponenteModel
    {

        private int? _idComponente;
        [ParameterOrder(Order = 1)]

        public int? idComponente
        {
            get { return _idComponente; }
            set
            {
                _idComponente = value;
                if (this.xTypeComp != null)
                {
                    if (this.xTypeComp != "HLP_DataGridView")
                    {
                        this.objConfigCompUsu.idComponente = _idComponente;
                    }
                    else
                    {
                        this.objConfigCompGridUsu.idComponente = _idComponente;
                        foreach (ConfigColunasGridModel col in this.lConfigColunasGrid)
                        {
                            col.idComponente = _idComponente;
                        }
                    }
                }
            }
        }

        [ParameterOrder(Order = 2)]
        public string xName { get; set; }
        [ParameterOrder(Order = 3)]
        public string xTable { get; set; }
        [ParameterOrder(Order = 4)]
        public string xField { get; set; }
        [ParameterOrder(Order = 5)]
        public string xTypeComp { get; set; }
        [ParameterOrder(Order = 6)]
        public int? idTabPage { get; set; }
        [ParameterOrder(Order = 7)]
        public string xLabelGroup { get; set; }


        /// <summary>
        /// Propriedade que não é salva e nem modificada
        /// </summary>
        private InfoField _Base;

        public InfoField Base
        {
            get { return _Base; }
            set { _Base = value; }
        }
        public ConfigComponenteUsuModel objConfigCompUsu = new ConfigComponenteUsuModel();
        public ConfigCompGridViewUsuModel objConfigCompGridUsu = new ConfigCompGridViewUsuModel();
        public List<ConfigColunasGridModel> lConfigColunasGrid = new List<ConfigColunasGridModel>();
    }


    public class ConfigComponenteUsuModel
    {
        [ParameterOrder(Order = 1)]
        public int? idComponenteUsuario { get; set; }
        [ParameterOrder(Order = 2)]
        public int nOrder { get; set; }
        [ParameterOrder(Order = 3)]
        public string xLabelText { get; set; }
        [ParameterOrder(Order = 4)]
        public string xText { get; set; }
        [ParameterOrder(Order = 5)]
        public byte stVisible { get; set; }
        [ParameterOrder(Order = 6)]
        public byte stEnabled { get; set; }
        [ParameterOrder(Order = 7)]
        public string xColor { get; set; }
        [ParameterOrder(Order = 8)]
        public string xParent { get; set; }
        [ParameterOrder(Order = 9)]
        public decimal nMaxLength { get; set; }
        [ParameterOrder(Order = 10)]
        public int nDecimalPlaces { get; set; }
        [ParameterOrder(Order = 11)]
        public byte stAcesso { get; set; }
        [ParameterOrder(Order = 12)]
        public string xHelp { get; set; }
        [ParameterOrder(Order = 13)]
        public byte? stAtivo { get; set; }
        [ParameterOrder(Order = 14)]
        public int? idComponente { get; set; }
        [ParameterOrder(Order = 15)]
        public int? idUsuario { get; set; }


    }

    public class ConfigCompGridViewUsuModel
    {
        [ParameterOrder(Order = 1)]
        public int? idCompGridUsuario { get; set; }
        [ParameterOrder(Order = 2)]
        public byte? stInclusao { get; set; }
        [ParameterOrder(Order = 3)]
        public byte? stExclusao { get; set; }
        [ParameterOrder(Order = 4)]
        public byte? stAlteracao { get; set; }
        [ParameterOrder(Order = 5)]
        public int? idComponente { get; set; }
        [ParameterOrder(Order = 6)]
        public int? idUsuario { get; set; }


    }

    public class ConfigColunasGridModel
    {
        [ParameterOrder(Order = 1)]
        public int? idColunasGrid { get; set; }
        [ParameterOrder(Order = 2)]
        public string xNameColuna { get; set; }
        [ParameterOrder(Order = 3)]
        public string xDataPropertyName { get; set; }
        [ParameterOrder(Order = 4)]
        public string xType { get; set; }
        [ParameterOrder(Order = 5)]
        public int? idComponente { get; set; }

        /// <summary>
        /// Propriedade que não é salva e nem modificada
        /// </summary>
        private InfoField _Base;

        public InfoField Base
        {
            get { return _Base; }
            set { _Base = value; }
        }

        public ConfigColunasGridUsuModel objColunasGridUsu = new ConfigColunasGridUsuModel();
    }

    public class ConfigColunasGridUsuModel
    {
        [ParameterOrder(Order = 1)]
        public int? idColunasGridUsuario { get; set; }
        [ParameterOrder(Order = 2)]
        public string xHeaderText { get; set; }
        [ParameterOrder(Order = 3)]
        public byte? stVisible { get; set; }
        [ParameterOrder(Order = 4)]
        public decimal? nMaxLength { 
            get; 
            set; }
        [ParameterOrder(Order = 5)]
        public int? nDecimalPlaces { get; set; }
        [ParameterOrder(Order = 6)]
        public string xDisplayMember { get; set; }
        [ParameterOrder(Order = 7)]
        public int? nDisplayIndex { get; set; }
        [ParameterOrder(Order = 8)]
        public byte? stAcesso { get; set; }
        [ParameterOrder(Order = 9)]
        public int? nWidth { get; set; }
        [ParameterOrder(Order = 10)]
        public byte? stAtivo { get; set; }
        [ParameterOrder(Order = 11)]
        public int? idUsuario { get; set; }
        [ParameterOrder(Order = 12)]
        public int? idColunasGrid { get; set; }
        [ParameterOrder(Order = 13)]
        public string xHelp { get; set; }
    }
}
