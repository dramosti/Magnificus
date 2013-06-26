using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace HLP.Comum.Models
{
    [Serializable]
    public class Grid
    {
        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public string ParentTabName{ get; set; }

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

        public List<GridColumn> DataGridColumn { get; set; }
    }
}
