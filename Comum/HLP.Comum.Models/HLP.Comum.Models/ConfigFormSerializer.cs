using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace HLP.Comum.Models
{
    [Serializable]
    public class ConfigFormSerializer
    {
        [XmlAttribute("Formulario")]
        public string NameForm { get; set; }
        [XmlAttribute]
        public string NameView { get; set; }
        public string TextForm { get; set; }     
        public List<Componente> Componentes { get; set; }
        public List<FieldView> Pesquisa { get; set; }
        public List<Grid> DataGrid { get; set; }
        public HierarquiaTab Hierarquia { get; set; }
    }



    public class HierarquiaTab
    {
        public string NameTab { get; set; }
        public string TextTab { get; set; }
        private string _helpTab;
        public string HelpTab
        {
            get { return _helpTab; }
            set { _helpTab = value; }
        }
        public List<HierarquiaTab> Tabs = new List<HierarquiaTab>();
    }

}
