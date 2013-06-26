using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace HLP.Comum.Models
{
    [Serializable]
    public class FieldView
    {
        [XmlAttribute]
        public string Field { get; set; }

        private bool _Filter = true;
        public bool Filter
        {
            get { return _Filter; }
            set { _Filter = value; }
        }

        private bool _Data = true;
        public bool Data
        {
            get { return _Data; }
            set { _Data = value; }
        }

        public int OrderFilter { get; set; }

        public int OrderData { get; set; }

    }
}
