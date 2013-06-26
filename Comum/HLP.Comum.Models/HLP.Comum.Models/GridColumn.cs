using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace HLP.Comum.Models
{
    [Serializable]
    public class GridColumn
    {
        [XmlAttribute]
        public string DataPropertyName { get; set; }
        public string Name { get; set; }
        public string Table { get; set; }
        public string TypeColumn { get; set; }
        public string HeaderText { get; set; }
        public bool Visible { get; set; }
        public decimal MaxLength { get; set; }
        public int DecimalPlaces { get; set; }
        public string DisplayMember { get; set; }
        private bool _acessoColum = true;
        public int DisplayIndex { get; set; }
        private int _Width = 0;
        public int Width
        {
            get { return _Width; }
            set { _Width = value; }
        }
        private string _Help = "";
        public string Help
        {
            get { return _Help; }
            set { _Help = value; }
        }
        public bool AcessoColum
        {
            get { return _acessoColum; }
            set { _acessoColum = value; }
        }

        public BaseGrid BaseConfigGrid = new BaseGrid();

        public struct BaseGrid
        {
            public string Type { get; set; }
            public bool Required { get; set; }
            public decimal MaxLength { get; set; }
            public int DecimalPlaces { get; set; }
        }
    }
}
