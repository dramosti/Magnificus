using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HLP.Comum.Models
{
    [Serializable]
    public class UserBasicConfig
    {
        private string _xSkin = "Silver";

        public string xSkin
        {
            get { return _xSkin; }
            set { _xSkin = value; }
        }
        private TipoMenu _tpMenu = TipoMenu.Lateral;

        public TipoMenu tpMenu
        {
            get { return _tpMenu; }
            set { _tpMenu = value; }
        }
        public List<string> Favoritos = new List<string>();
        public List<string> ModulosAtivos = new List<string>();
        public List<string> BarraStatus = new List<string>();
        public List<Lembrete> Lembretes = new List<Lembrete>();
        public bool RecolheMenuLateral = false;
        public enum TipoMenu { Top, Lateral };


        public class Lembrete
        {
            public DateTime dtLembrete { get; set; }
            public string xDescricao { get; set; }
        }
    }
}
