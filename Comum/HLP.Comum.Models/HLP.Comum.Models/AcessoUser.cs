using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace HLP.Comum.Models
{
    [Serializable]
    public class AcessoUser
    {
        public int idUser { get; set; }
        public string xNome { get; set; }
        public List<Formulario> lFormularios = new List<Formulario>();
    }

    public class Formulario
    {
        [XmlAttribute]
        public string Name { get; set; }

        private bool _acesso = true;
        public bool Acesso
        {
            get { return _acesso; }
            set { _acesso = value; }
        }
        private bool _inclusao = true;
        public bool Inclusao
        {
            get { return _inclusao; }
            set { _inclusao = value; }
        }
        private bool _alteracao = true;
        public bool Alteracao
        {
            get { return _alteracao; }
            set { _alteracao = value; }
        }
        private bool _exclusao = true;
        public bool Exclusao
        {
            get { return _exclusao; }
            set { _exclusao = value; }
        }
        private bool _pesquisar = true;
        public bool Pesquisar
        {
            get { return _pesquisar; }
            set { _pesquisar = value; }
        }
        private bool _duplicar = true;
        public bool Duplicar
        {
            get { return _duplicar; }
            set { _duplicar = value; }
        }
        
        public List<ComponenteFormulario> lComponentes = new List<ComponenteFormulario>();
        public List<DataGridFormulario> lGrids = new List<DataGridFormulario>();

    }
    public class DataGridFormulario
    {
        [XmlAttribute]
        public string NameGrid { get; set; }

        private bool _acessoGrid = true;
        public bool AcessoGrid
        {
            get { return _acessoGrid; }
            set { _acessoGrid = value; }
        }
        private bool _inclusaoItem = true;
        public bool InclusaoItem
        {
            get { return _inclusaoItem; }
            set { _inclusaoItem = value; }
        }
        private bool _alteracaoItem = true;
        public bool AlteracaoItem
        {
            get { return _alteracaoItem; }
            set { _alteracaoItem = value; }
        }
        private bool _exclusaoItem = true;
        public bool ExclusaoItem
        {
            get { return _exclusaoItem; }
            set { _exclusaoItem = value; }
        }
        public List<ColunasGrid> lColunas = new List<ColunasGrid>();

    }

    public class ComponenteFormulario
    {
        public string NameComp { get; set; }
        public string TypeComp { get; set; }
        public bool AcessoComp { get; set; }

    }
    public class ColunasGrid
    {
        public string NameCol { get; set; }
        public string TypeCol { get; set; }
        public bool AcessoCol { get; set; }

    }
}
