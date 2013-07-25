using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace HLP.Models.Entries.Gerais
{
    [Serializable]

    [XmlRoot("objects")]
    public class EstruturaModelXmlPai
    {
        [XmlElement("object")]
        public List<EstruturaModelXml> lEstruturaModelXml { get; set; }
    }

    [XmlRoot("object")]
    public class EstruturaModelXml
    {
        public Guid numSessao { get; set; }
        public string idFuncionario { get; set; }
        public string xNomeFuncionario { get; set; }
        public string xNomeMaquina { get; set; }
        public string xIpMaquina { get; set; }
        public string xUsuarioWindows { get; set; }
        public DateTime dDataAcesso { get; set; }
    }
}
