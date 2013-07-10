using HLP.Comum.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLP.Models.Entries.Gerais
{
    public class Log_ScriptsModel: BaseModelFilhos
    {
        private int? _idLog;
        [ParameterOrder(Order = 1)]
        public int? idLog
        {
            get { return _idLog; }
            set
            {
                _idLog = value;
                base.SetID(value);
            }
        }
        [ParameterOrder(Order = 2)]
        public string xVersao { get; set; }
        [ParameterOrder(Order = 3)]
        public string dtExec { get; set; }
        [ParameterOrder(Order = 4)]
        public string idUsuario { get; set; }
        [ParameterOrder(Order = 5)]
        public string script { get; set; }

        //private bool bExecutado;
        //public bool _bExecutado
        //{
        //    get
        //    {
        //        return bExecutado;
        //    }
        //    set
        //    {
        //        bExecutado = value;
        //    }
        //}
    }
}
